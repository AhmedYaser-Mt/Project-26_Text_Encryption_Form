namespace Project_26___Text_Encryption_Form__
{
    partial class frmTextEncryption
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTextEncryption));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDecrementSecurityKey = new System.Windows.Forms.Button();
            this.txtSecurityKey = new System.Windows.Forms.TextBox();
            this.btnIncrementSecurityKey = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.lblOutputStatus = new System.Windows.Forms.Label();
            this.btnCopyResult = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblLength = new System.Windows.Forms.Label();
            this.txtHistoryLog = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.btnSaveProcess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(248, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(580, 95);
            this.label1.TabIndex = 0;
            this.label1.Text = "Text Encryption Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(5, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "Input Text";
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(188, 137);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtInput.Size = new System.Drawing.Size(397, 114);
            this.txtInput.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Uighur", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(5, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 45);
            this.label3.TabIndex = 3;
            this.label3.Text = "Security Key";
            // 
            // btnDecrementSecurityKey
            // 
            this.btnDecrementSecurityKey.BackColor = System.Drawing.Color.Black;
            this.btnDecrementSecurityKey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDecrementSecurityKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrementSecurityKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDecrementSecurityKey.Location = new System.Drawing.Point(188, 277);
            this.btnDecrementSecurityKey.Name = "btnDecrementSecurityKey";
            this.btnDecrementSecurityKey.Size = new System.Drawing.Size(59, 47);
            this.btnDecrementSecurityKey.TabIndex = 4;
            this.btnDecrementSecurityKey.Text = "-";
            this.btnDecrementSecurityKey.UseVisualStyleBackColor = false;
            this.btnDecrementSecurityKey.Click += new System.EventHandler(this.btnDecrementSecurityKey_Click);
            // 
            // txtSecurityKey
            // 
            this.txtSecurityKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecurityKey.Location = new System.Drawing.Point(294, 275);
            this.txtSecurityKey.MaxLength = 1;
            this.txtSecurityKey.Name = "txtSecurityKey";
            this.txtSecurityKey.ReadOnly = true;
            this.txtSecurityKey.Size = new System.Drawing.Size(59, 49);
            this.txtSecurityKey.TabIndex = 5;
            this.txtSecurityKey.Text = "1";
            // 
            // btnIncrementSecurityKey
            // 
            this.btnIncrementSecurityKey.BackColor = System.Drawing.Color.Black;
            this.btnIncrementSecurityKey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIncrementSecurityKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncrementSecurityKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnIncrementSecurityKey.Location = new System.Drawing.Point(412, 275);
            this.btnIncrementSecurityKey.Name = "btnIncrementSecurityKey";
            this.btnIncrementSecurityKey.Size = new System.Drawing.Size(59, 47);
            this.btnIncrementSecurityKey.TabIndex = 6;
            this.btnIncrementSecurityKey.Text = "+";
            this.btnIncrementSecurityKey.UseVisualStyleBackColor = false;
            this.btnIncrementSecurityKey.Click += new System.EventHandler(this.btnIncrementSecurityKey_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BackColor = System.Drawing.Color.Green;
            this.btnEncrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEncrypt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnEncrypt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnEncrypt.Font = new System.Drawing.Font("Microsoft Uighur", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.Location = new System.Drawing.Point(619, 142);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(164, 79);
            this.btnEncrypt.TabIndex = 7;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = false;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.BackColor = System.Drawing.Color.Black;
            this.btnDecrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDecrypt.Font = new System.Drawing.Font("Microsoft Uighur", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrypt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDecrypt.Location = new System.Drawing.Point(821, 137);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(164, 79);
            this.btnDecrypt.TabIndex = 8;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = false;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(188, 423);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutput.Size = new System.Drawing.Size(397, 114);
            this.txtOutput.TabIndex = 10;
            // 
            // lblOutputStatus
            // 
            this.lblOutputStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblOutputStatus.Font = new System.Drawing.Font("Microsoft Uighur", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblOutputStatus.Location = new System.Drawing.Point(5, 423);
            this.lblOutputStatus.Name = "lblOutputStatus";
            this.lblOutputStatus.Size = new System.Drawing.Size(162, 92);
            this.lblOutputStatus.TabIndex = 11;
            this.lblOutputStatus.Text = "Output";
            // 
            // btnCopyResult
            // 
            this.btnCopyResult.BackColor = System.Drawing.Color.Green;
            this.btnCopyResult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopyResult.Font = new System.Drawing.Font("Microsoft Uighur", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopyResult.Location = new System.Drawing.Point(619, 411);
            this.btnCopyResult.Name = "btnCopyResult";
            this.btnCopyResult.Size = new System.Drawing.Size(164, 54);
            this.btnCopyResult.TabIndex = 12;
            this.btnCopyResult.Text = "Copy Result";
            this.btnCopyResult.UseVisualStyleBackColor = false;
            this.btnCopyResult.Click += new System.EventHandler(this.btnCopyResult_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Black;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Uighur", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnClear.Location = new System.Drawing.Point(619, 483);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(164, 54);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblLength
            // 
            this.lblLength.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblLength.Font = new System.Drawing.Font("Microsoft Uighur", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLength.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblLength.Location = new System.Drawing.Point(813, 441);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(243, 60);
            this.lblLength.TabIndex = 14;
            this.lblLength.Text = "Length :";
            // 
            // txtHistoryLog
            // 
            this.txtHistoryLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHistoryLog.Location = new System.Drawing.Point(188, 665);
            this.txtHistoryLog.Multiline = true;
            this.txtHistoryLog.Name = "txtHistoryLog";
            this.txtHistoryLog.ReadOnly = true;
            this.txtHistoryLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtHistoryLog.Size = new System.Drawing.Size(886, 161);
            this.txtHistoryLog.TabIndex = 15;
            this.txtHistoryLog.WordWrap = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Uighur", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(191, 608);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 45);
            this.label4.TabIndex = 16;
            this.label4.Text = "History Log :";
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.BackColor = System.Drawing.Color.Black;
            this.btnDeleteAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteAll.Font = new System.Drawing.Font("Microsoft Uighur", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDeleteAll.Location = new System.Drawing.Point(3, 757);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(164, 54);
            this.btnDeleteAll.TabIndex = 18;
            this.btnDeleteAll.Text = "Delete All";
            this.btnDeleteAll.UseVisualStyleBackColor = false;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // btnSaveProcess
            // 
            this.btnSaveProcess.BackColor = System.Drawing.Color.Green;
            this.btnSaveProcess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveProcess.Font = new System.Drawing.Font("Microsoft Uighur", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveProcess.Location = new System.Drawing.Point(3, 685);
            this.btnSaveProcess.Name = "btnSaveProcess";
            this.btnSaveProcess.Size = new System.Drawing.Size(164, 54);
            this.btnSaveProcess.TabIndex = 17;
            this.btnSaveProcess.Text = "Save Process";
            this.btnSaveProcess.UseVisualStyleBackColor = false;
            this.btnSaveProcess.Click += new System.EventHandler(this.btnSaveProcess_Click);
            // 
            // frmTextEncryption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project_26___Text_Encryption_Form__.Properties.Resources.Text_Encryption_Background;
            this.ClientSize = new System.Drawing.Size(1086, 838);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.btnSaveProcess);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHistoryLog);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCopyResult);
            this.Controls.Add(this.lblOutputStatus);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.btnIncrementSecurityKey);
            this.Controls.Add(this.txtSecurityKey);
            this.Controls.Add(this.btnDecrementSecurityKey);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTextEncryption";
            this.Text = "Text Encryption Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDecrementSecurityKey;
        private System.Windows.Forms.TextBox txtSecurityKey;
        private System.Windows.Forms.Button btnIncrementSecurityKey;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label lblOutputStatus;
        private System.Windows.Forms.Button btnCopyResult;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.TextBox txtHistoryLog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.Button btnSaveProcess;
    }
}

