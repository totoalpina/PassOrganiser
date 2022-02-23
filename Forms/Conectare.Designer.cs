namespace PassOrganiser
{
    partial class frm_main
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
            this.pnl_main = new System.Windows.Forms.Panel();
            this.lbl_descriere_fastline = new System.Windows.Forms.Label();
            this.txt_fastline = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.btn_intra = new System.Windows.Forms.Button();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.pnl_mesaj_inchidere = new System.Windows.Forms.Panel();
            this.lbl_adio = new System.Windows.Forms.Label();
            this.pnl_main.SuspendLayout();
            this.pnl_mesaj_inchidere.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_main
            // 
            this.pnl_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_main.BackColor = System.Drawing.Color.SkyBlue;
            this.pnl_main.Controls.Add(this.lbl_descriere_fastline);
            this.pnl_main.Controls.Add(this.txt_fastline);
            this.pnl_main.Controls.Add(this.lbl);
            this.pnl_main.Controls.Add(this.btn_intra);
            this.pnl_main.Controls.Add(this.lbl_Password);
            this.pnl_main.Controls.Add(this.lbl_UserName);
            this.pnl_main.Controls.Add(this.txt_Password);
            this.pnl_main.Controls.Add(this.txt_UserName);
            this.pnl_main.Location = new System.Drawing.Point(12, 12);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(560, 337);
            this.pnl_main.TabIndex = 0;
            // 
            // lbl_descriere_fastline
            // 
            this.lbl_descriere_fastline.AutoSize = true;
            this.lbl_descriere_fastline.Location = new System.Drawing.Point(196, 65);
            this.lbl_descriere_fastline.Name = "lbl_descriere_fastline";
            this.lbl_descriere_fastline.Size = new System.Drawing.Size(182, 16);
            this.lbl_descriere_fastline.TabIndex = 6;
            this.lbl_descriere_fastline.Text = "username[ spatiu ]pasword";
            // 
            // txt_fastline
            // 
            this.txt_fastline.Location = new System.Drawing.Point(196, 84);
            this.txt_fastline.Name = "txt_fastline";
            this.txt_fastline.PasswordChar = '*';
            this.txt_fastline.Size = new System.Drawing.Size(215, 21);
            this.txt_fastline.TabIndex = 0;
            this.txt_fastline.TextChanged += new System.EventHandler(this.txt_fastline_TextChanged);
            this.txt_fastline.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_fastline_KeyDown);
            this.txt_fastline.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_fastline_KeyPress);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(71, 85);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(119, 16);
            this.lbl.TabIndex = 5;
            this.lbl.Text = "Fastline Connect";
            // 
            // btn_intra
            // 
            this.btn_intra.BackColor = System.Drawing.Color.BurlyWood;
            this.btn_intra.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btn_intra.Location = new System.Drawing.Point(127, 195);
            this.btn_intra.Name = "btn_intra";
            this.btn_intra.Size = new System.Drawing.Size(284, 23);
            this.btn_intra.TabIndex = 4;
            this.btn_intra.Text = "Intra";
            this.btn_intra.UseVisualStyleBackColor = false;
            this.btn_intra.Click += new System.EventHandler(this.btn_intra_Click);
            // 
            // lbl_Password
            // 
            this.lbl_Password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.BackColor = System.Drawing.Color.BurlyWood;
            this.lbl_Password.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_Password.Location = new System.Drawing.Point(127, 154);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(63, 16);
            this.lbl_Password.TabIndex = 3;
            this.lbl_Password.Text = "Password";
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.BackColor = System.Drawing.Color.BurlyWood;
            this.lbl_UserName.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbl_UserName.Location = new System.Drawing.Point(127, 116);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(63, 16);
            this.lbl_UserName.TabIndex = 2;
            this.lbl_UserName.Text = "Username";
            // 
            // txt_Password
            // 
            this.txt_Password.AcceptsReturn = true;
            this.txt_Password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Password.BackColor = System.Drawing.Color.BurlyWood;
            this.txt_Password.Location = new System.Drawing.Point(196, 151);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(215, 21);
            this.txt_Password.TabIndex = 1;
            this.txt_Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Password_KeyPress);
            // 
            // txt_UserName
            // 
            this.txt_UserName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_UserName.BackColor = System.Drawing.Color.BurlyWood;
            this.txt_UserName.Location = new System.Drawing.Point(196, 113);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(215, 21);
            this.txt_UserName.TabIndex = 0;
            this.txt_UserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_UserName_KeyPress);
            // 
            // pnl_mesaj_inchidere
            // 
            this.pnl_mesaj_inchidere.Controls.Add(this.lbl_adio);
            this.pnl_mesaj_inchidere.Location = new System.Drawing.Point(83, 137);
            this.pnl_mesaj_inchidere.Name = "pnl_mesaj_inchidere";
            this.pnl_mesaj_inchidere.Size = new System.Drawing.Size(560, 302);
            this.pnl_mesaj_inchidere.TabIndex = 1;
            // 
            // lbl_adio
            // 
            this.lbl_adio.AutoSize = true;
            this.lbl_adio.Font = new System.Drawing.Font("Cascadia Mono", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_adio.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbl_adio.Location = new System.Drawing.Point(71, 221);
            this.lbl_adio.Name = "lbl_adio";
            this.lbl_adio.Size = new System.Drawing.Size(405, 20);
            this.lbl_adio.TabIndex = 0;
            this.lbl_adio.Text = "ATI AJUNS LA FINAL !!  INCHIDETI APLICATIA !";
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.pnl_main);
            this.Controls.Add(this.pnl_mesaj_inchidere);
            this.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PassOrganiser";
            this.pnl_main.ResumeLayout(false);
            this.pnl_main.PerformLayout();
            this.pnl_mesaj_inchidere.ResumeLayout(false);
            this.pnl_mesaj_inchidere.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnl_main;
        private Label lbl_Password;
        private Label lbl_UserName;
        private TextBox txt_Password;
        private TextBox txt_UserName;
        private Button btn_intra;
        private TextBox txt_fastline;
        private Label lbl;
        private Panel pnl_mesaj_inchidere;
        private Label lbl_adio;
        private Label lbl_descriere_fastline;
    }
}