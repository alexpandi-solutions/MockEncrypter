namespace Encrypter
{
    partial class Form
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
            this.algSelectLabel = new System.Windows.Forms.Label();
            this.algSelectOpt = new System.Windows.Forms.ComboBox();
            this.plaintextLabel = new System.Windows.Forms.Label();
            this.plaintextInput = new System.Windows.Forms.TextBox();
            this.keyLabel = new System.Windows.Forms.Label();
            this.keyInput = new System.Windows.Forms.TextBox();
            this.cyphertextLabel = new System.Windows.Forms.Label();
            this.cyphertextResult = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // algSelectLabel
            // 
            this.algSelectLabel.AutoSize = true;
            this.algSelectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.algSelectLabel.ForeColor = System.Drawing.Color.Black;
            this.algSelectLabel.Location = new System.Drawing.Point(9, 9);
            this.algSelectLabel.Name = "algSelectLabel";
            this.algSelectLabel.Size = new System.Drawing.Size(123, 16);
            this.algSelectLabel.TabIndex = 1;
            this.algSelectLabel.Text = "Algorithm Selection";
            this.algSelectLabel.UseMnemonic = false;
            // 
            // algSelectOpt
            // 
            this.algSelectOpt.FormattingEnabled = true;
            this.algSelectOpt.Items.AddRange(new object[] {
            "ASM - Rivest–Shamir–Adleman (RSA)",
            "ASM - Diffie Hellman (DH)",
            "SYM - Advanced Encryption Standard (AES)",
            "SYM - Rivest Cipher 4 (RC4)"});
            this.algSelectOpt.Location = new System.Drawing.Point(12, 28);
            this.algSelectOpt.Name = "algSelectOpt";
            this.algSelectOpt.Size = new System.Drawing.Size(432, 21);
            this.algSelectOpt.TabIndex = 2;
            this.algSelectOpt.SelectedIndexChanged += new System.EventHandler(this.algSelectOpt_SelectedIndexChanged);
            // 
            // plaintextLabel
            // 
            this.plaintextLabel.AutoSize = true;
            this.plaintextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plaintextLabel.Location = new System.Drawing.Point(9, 52);
            this.plaintextLabel.Name = "plaintextLabel";
            this.plaintextLabel.Size = new System.Drawing.Size(58, 16);
            this.plaintextLabel.TabIndex = 3;
            this.plaintextLabel.Text = "Plaintext";
            // 
            // plaintextInput
            // 
            this.plaintextInput.Location = new System.Drawing.Point(12, 71);
            this.plaintextInput.Name = "plaintextInput";
            this.plaintextInput.Size = new System.Drawing.Size(650, 20);
            this.plaintextInput.TabIndex = 4;
            // 
            // keyLabel
            // 
            this.keyLabel.AutoSize = true;
            this.keyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyLabel.Location = new System.Drawing.Point(9, 94);
            this.keyLabel.Name = "keyLabel";
            this.keyLabel.Size = new System.Drawing.Size(31, 16);
            this.keyLabel.TabIndex = 5;
            this.keyLabel.Text = "Key";
            // 
            // keyInput
            // 
            this.keyInput.Location = new System.Drawing.Point(12, 113);
            this.keyInput.Name = "keyInput";
            this.keyInput.Size = new System.Drawing.Size(650, 20);
            this.keyInput.TabIndex = 6;
            // 
            // cyphertextLabel
            // 
            this.cyphertextLabel.AutoSize = true;
            this.cyphertextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cyphertextLabel.Location = new System.Drawing.Point(9, 136);
            this.cyphertextLabel.Name = "cyphertextLabel";
            this.cyphertextLabel.Size = new System.Drawing.Size(71, 16);
            this.cyphertextLabel.TabIndex = 7;
            this.cyphertextLabel.Text = "Cyphertext";
            // 
            // cyphertextResult
            // 
            this.cyphertextResult.Location = new System.Drawing.Point(12, 155);
            this.cyphertextResult.Name = "cyphertextResult";
            this.cyphertextResult.Size = new System.Drawing.Size(650, 20);
            this.cyphertextResult.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(450, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 22);
            this.button1.TabIndex = 9;
            this.button1.Text = "Encrypt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(559, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 22);
            this.button2.TabIndex = 10;
            this.button2.Text = "Decrypt";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(668, 28);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 22);
            this.button3.TabIndex = 11;
            this.button3.Text = "Reset";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(668, 71);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 22);
            this.button4.TabIndex = 12;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(668, 155);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(103, 22);
            this.button5.TabIndex = 13;
            this.button5.Text = "Clear";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(668, 113);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(103, 22);
            this.button6.TabIndex = 14;
            this.button6.Text = "Clear";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(783, 189);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cyphertextResult);
            this.Controls.Add(this.cyphertextLabel);
            this.Controls.Add(this.keyInput);
            this.Controls.Add(this.keyLabel);
            this.Controls.Add(this.plaintextInput);
            this.Controls.Add(this.plaintextLabel);
            this.Controls.Add(this.algSelectOpt);
            this.Controls.Add(this.algSelectLabel);
            this.Name = "Form";
            this.Text = "Endrypter/Decrypter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label algSelectLabel;
        private System.Windows.Forms.ComboBox algSelectOpt;
        private System.Windows.Forms.Label plaintextLabel;
        private System.Windows.Forms.TextBox plaintextInput;
        private System.Windows.Forms.Label keyLabel;
        private System.Windows.Forms.TextBox keyInput;
        private System.Windows.Forms.Label cyphertextLabel;
        private System.Windows.Forms.TextBox cyphertextResult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

