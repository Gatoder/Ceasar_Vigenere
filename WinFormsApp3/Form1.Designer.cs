namespace WinFormsApp3
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
            this.label1 = new System.Windows.Forms.Label();
            this.M = new System.Windows.Forms.Button();
            this.G = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PP = new System.Windows.Forms.ComboBox();
            this.T = new System.Windows.Forms.TextBox();
            this.KEY = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.K = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(418, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa Caesar/Vigenère ";
            // 
            // M
            // 
            this.M.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.M.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.M.Location = new System.Drawing.Point(370, 472);
            this.M.Name = "M";
            this.M.Size = new System.Drawing.Size(150, 39);
            this.M.TabIndex = 1;
            this.M.Text = "MÃ HÓA";
            this.M.UseVisualStyleBackColor = true;
            this.M.Click += new System.EventHandler(this.M_Click);
            // 
            // G
            // 
            this.G.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.G.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.G.Location = new System.Drawing.Point(677, 472);
            this.G.Name = "G";
            this.G.Size = new System.Drawing.Size(139, 39);
            this.G.TabIndex = 2;
            this.G.Text = "GIẢI MÃ";
            this.G.UseVisualStyleBackColor = true;
            this.G.Click += new System.EventHandler(this.G_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(139, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Text:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(418, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "KEY:";
            // 
            // PP
            // 
            this.PP.FormattingEnabled = true;
            this.PP.Location = new System.Drawing.Point(557, 283);
            this.PP.Name = "PP";
            this.PP.Size = new System.Drawing.Size(135, 23);
            this.PP.TabIndex = 5;
            this.PP.SelectedIndexChanged += new System.EventHandler(this.PP_SelectedIndexChanged);
            // 
            // T
            // 
            this.T.Location = new System.Drawing.Point(12, 139);
            this.T.Multiline = true;
            this.T.Name = "T";
            this.T.Size = new System.Drawing.Size(333, 182);
            this.T.TabIndex = 6;
            // 
            // KEY
            // 
            this.KEY.Location = new System.Drawing.Point(540, 107);
            this.KEY.Name = "KEY";
            this.KEY.Size = new System.Drawing.Size(135, 23);
            this.KEY.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(370, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Phương pháp mã hóa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(895, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "KẾT QUẢ";
            // 
            // K
            // 
            this.K.Location = new System.Drawing.Point(740, 139);
            this.K.Multiline = true;
            this.K.Name = "K";
            this.K.Size = new System.Drawing.Size(369, 182);
            this.K.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 593);
            this.Controls.Add(this.K);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.KEY);
            this.Controls.Add(this.T);
            this.Controls.Add(this.PP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.G);
            this.Controls.Add(this.M);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button M;
        private Button G;
        private Label label2;
        private Label label3;
        private ComboBox PP;
        private TextBox T;
        private TextBox KEY;
        private Label label4;
        private Label label5;
        private TextBox K;
    }
}