namespace srttrswitchsaveeditor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLoadFile = new Button();
            txtOutput = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            txtMoney = new TextBox();
            txtRespectLvl = new TextBox();
            lblMoney = new Label();
            lblRespect = new Label();
            button1 = new Button();
            btnSaveFile = new Button();
            SuspendLayout();
            // 
            // btnLoadFile
            // 
            btnLoadFile.Location = new Point(12, 11);
            btnLoadFile.Name = "btnLoadFile";
            btnLoadFile.Size = new Size(75, 23);
            btnLoadFile.TabIndex = 0;
            btnLoadFile.Text = "Open File";
            btnLoadFile.UseVisualStyleBackColor = true;
            btnLoadFile.Click += btnLoadFile_Click;
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(441, 11);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(404, 515);
            txtOutput.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtMoney
            // 
            txtMoney.Location = new Point(12, 65);
            txtMoney.Name = "txtMoney";
            txtMoney.Size = new Size(100, 23);
            txtMoney.TabIndex = 2;
            // 
            // txtRespectLvl
            // 
            txtRespectLvl.Location = new Point(12, 109);
            txtRespectLvl.Name = "txtRespectLvl";
            txtRespectLvl.Size = new Size(100, 23);
            txtRespectLvl.TabIndex = 3;
            // 
            // lblMoney
            // 
            lblMoney.AutoSize = true;
            lblMoney.Location = new Point(12, 47);
            lblMoney.Name = "lblMoney";
            lblMoney.Size = new Size(44, 15);
            lblMoney.TabIndex = 4;
            lblMoney.Text = "Money";
            // 
            // lblRespect
            // 
            lblRespect.AutoSize = true;
            lblRespect.Location = new Point(12, 91);
            lblRespect.Name = "lblRespect";
            lblRespect.Size = new Size(78, 15);
            lblRespect.TabIndex = 5;
            lblRespect.Text = "Respect Level";
            // 
            // button1
            // 
            button1.Location = new Point(93, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnSaveFile
            // 
            btnSaveFile.Location = new Point(93, 11);
            btnSaveFile.Name = "btnSaveFile";
            btnSaveFile.Size = new Size(75, 23);
            btnSaveFile.TabIndex = 6;
            btnSaveFile.Text = "Save File";
            btnSaveFile.UseVisualStyleBackColor = true;
            btnSaveFile.Click += btnSaveFile_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 538);
            Controls.Add(btnSaveFile);
            Controls.Add(button1);
            Controls.Add(lblRespect);
            Controls.Add(lblMoney);
            Controls.Add(txtRespectLvl);
            Controls.Add(txtMoney);
            Controls.Add(txtOutput);
            Controls.Add(btnLoadFile);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLoadFile;
        private TextBox txtOutput;
        private OpenFileDialog openFileDialog1;
        private TextBox txtMoney;
        private TextBox txtRespectLvl;
        private Label lblMoney;
        private Label lblRespect;
        private Button button1;
        private Button btnSaveFile;
    }
}
