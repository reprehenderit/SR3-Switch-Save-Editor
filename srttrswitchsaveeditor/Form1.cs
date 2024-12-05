using System.Text;

namespace srttrswitchsaveeditor
{
    public partial class Form1 : Form
    {
        private Sr3SaveFile loadedSaveFile;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            txtOutput.Clear();
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Sains Row Switch Save File (*.sr3s_nx64)|*.sr3s_nx64|All Files (*.*)|*.*",
                Title = "Select a Saints Row 3 Switch Save file"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                byte[] saveBytes = File.ReadAllBytes(filePath);

                try
                {
                    loadedSaveFile = Sr3SaveFile.Parse(saveBytes);
                    DisplaySaveFileData(loadedSaveFile);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error parsing save file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DisplaySaveFileData(Sr3SaveFile saveFile)
        {
            int money = saveFile.GetMoney();
            int respect = saveFile.GetRespect();
            txtOutput.AppendText($"Money: {money}{Environment.NewLine}");
            txtOutput.AppendText($"Respect: {respect}{Environment.NewLine}");

            txtMoney.Text = $"{money}";
            txtRespectLvl.Text = $"{respect}";
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            if (loadedSaveFile == null)
            {
                MessageBox.Show("No loaded save file. Please load a save file first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (int.TryParse(txtMoney.Text, out int newMoney) && int.TryParse(txtRespectLvl.Text, out int newRespect))
            {
                loadedSaveFile.SetMoney(newMoney);
                loadedSaveFile.SetRespect(newRespect);

                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Saints Row Switch Save File (*.sr3s_nx64)|*.sr3s_nx64|All Files (*.*)|*.*",
                    Title = "Save the Saints Row 3 Switch Save file"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        File.WriteAllBytes(saveFileDialog.FileName, loadedSaveFile.Bytes);
                        MessageBox.Show("Save file succesfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error saving file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid input. Please ensure the values are numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public class Sr3SaveFile
        {
            public const int TotalFileSize = 112688;
            public const int OffsetForMoney = 19616;
            public const int OffsetForRespectLevel = 18000;

            public byte[] Bytes { get; private set; }

            public Sr3SaveFile(byte[] fileBytes)
            {
                Bytes = fileBytes;
            }

            public int GetMoney()
            {
                return BitConverter.ToInt32(Bytes, OffsetForMoney);
            }

            public int GetRespect()
            {
                return BitConverter.ToInt32(Bytes, OffsetForRespectLevel) + 1;
            }

            public void SetMoney(int money)
            {
                byte[] moneyBytes = BitConverter.GetBytes(money);
                Array.Copy(moneyBytes, 0, Bytes, OffsetForMoney, moneyBytes.Length);
            }

            public void SetRespect(int respect)
            {
                byte[] respectBytes = BitConverter.GetBytes(respect - 1);
                Array.Copy(respectBytes, 0, Bytes, OffsetForRespectLevel, respectBytes.Length);
            }

            public static Sr3SaveFile Parse(byte[] fileBytes)
            {
                if (fileBytes.Length != Sr3SaveFile.TotalFileSize)
                    throw new InvalidOperationException("Invalid save file size.");

                return new Sr3SaveFile(fileBytes);
            }
        }
    }
}
