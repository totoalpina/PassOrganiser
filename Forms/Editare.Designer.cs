namespace PassOrganiser.Forms
{
    partial class Editare
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose ();
            }
            base.Dispose (disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ( )
        {
            this.pnl_editare = new System.Windows.Forms.Panel();
            this.lbl_edit_description = new System.Windows.Forms.Label();
            this.lbl_edit_password = new System.Windows.Forms.Label();
            this.lbl_edit_username = new System.Windows.Forms.Label();
            this.lbl_edit_categorie = new System.Windows.Forms.Label();
            this.lbl_title_editare = new System.Windows.Forms.Label();
            this.rtext_edit_description = new System.Windows.Forms.RichTextBox();
            this.txt_edit_password = new System.Windows.Forms.TextBox();
            this.txt_edit_username = new System.Windows.Forms.TextBox();
            this.txt_edit_categorie = new System.Windows.Forms.TextBox();
            this.txt_edit_save = new System.Windows.Forms.Button();
            this.pnl_editare.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_editare
            // 
            this.pnl_editare.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.pnl_editare.Controls.Add(this.txt_edit_save);
            this.pnl_editare.Controls.Add(this.lbl_edit_description);
            this.pnl_editare.Controls.Add(this.lbl_edit_password);
            this.pnl_editare.Controls.Add(this.lbl_edit_username);
            this.pnl_editare.Controls.Add(this.lbl_edit_categorie);
            this.pnl_editare.Controls.Add(this.lbl_title_editare);
            this.pnl_editare.Controls.Add(this.rtext_edit_description);
            this.pnl_editare.Controls.Add(this.txt_edit_password);
            this.pnl_editare.Controls.Add(this.txt_edit_username);
            this.pnl_editare.Controls.Add(this.txt_edit_categorie);
            this.pnl_editare.Location = new System.Drawing.Point(12, 12);
            this.pnl_editare.MaximumSize = new System.Drawing.Size(560, 340);
            this.pnl_editare.MinimumSize = new System.Drawing.Size(560, 340);
            this.pnl_editare.Name = "pnl_editare";
            this.pnl_editare.Size = new System.Drawing.Size(560, 340);
            this.pnl_editare.TabIndex = 0;
            // 
            // lbl_edit_description
            // 
            this.lbl_edit_description.AutoSize = true;
            this.lbl_edit_description.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_edit_description.Location = new System.Drawing.Point(77, 195);
            this.lbl_edit_description.Name = "lbl_edit_description";
            this.lbl_edit_description.Size = new System.Drawing.Size(89, 20);
            this.lbl_edit_description.TabIndex = 8;
            this.lbl_edit_description.Text = "Description";
            this.lbl_edit_description.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_edit_password
            // 
            this.lbl_edit_password.AutoSize = true;
            this.lbl_edit_password.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_edit_password.Location = new System.Drawing.Point(91, 153);
            this.lbl_edit_password.Name = "lbl_edit_password";
            this.lbl_edit_password.Size = new System.Drawing.Size(76, 20);
            this.lbl_edit_password.TabIndex = 7;
            this.lbl_edit_password.Text = "Password";
            this.lbl_edit_password.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_edit_username
            // 
            this.lbl_edit_username.AutoSize = true;
            this.lbl_edit_username.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_edit_username.Location = new System.Drawing.Point(88, 110);
            this.lbl_edit_username.Name = "lbl_edit_username";
            this.lbl_edit_username.Size = new System.Drawing.Size(80, 20);
            this.lbl_edit_username.TabIndex = 6;
            this.lbl_edit_username.Text = "Username";
            this.lbl_edit_username.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_edit_categorie
            // 
            this.lbl_edit_categorie.AutoSize = true;
            this.lbl_edit_categorie.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_edit_categorie.Location = new System.Drawing.Point(88, 70);
            this.lbl_edit_categorie.Name = "lbl_edit_categorie";
            this.lbl_edit_categorie.Size = new System.Drawing.Size(76, 20);
            this.lbl_edit_categorie.TabIndex = 5;
            this.lbl_edit_categorie.Text = "Categorie";
            this.lbl_edit_categorie.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_title_editare
            // 
            this.lbl_title_editare.AutoSize = true;
            this.lbl_title_editare.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lbl_title_editare.Location = new System.Drawing.Point(49, 26);
            this.lbl_title_editare.Name = "lbl_title_editare";
            this.lbl_title_editare.Size = new System.Drawing.Size(136, 20);
            this.lbl_title_editare.TabIndex = 4;
            this.lbl_title_editare.Text = "Editare informatie";
            this.lbl_title_editare.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rtext_edit_description
            // 
            this.rtext_edit_description.BackColor = System.Drawing.Color.Honeydew;
            this.rtext_edit_description.Location = new System.Drawing.Point(180, 192);
            this.rtext_edit_description.Name = "rtext_edit_description";
            this.rtext_edit_description.Size = new System.Drawing.Size(362, 96);
            this.rtext_edit_description.TabIndex = 3;
            this.rtext_edit_description.Text = "";
            // 
            // txt_edit_password
            // 
            this.txt_edit_password.BackColor = System.Drawing.Color.Honeydew;
            this.txt_edit_password.Location = new System.Drawing.Point(180, 150);
            this.txt_edit_password.Name = "txt_edit_password";
            this.txt_edit_password.Size = new System.Drawing.Size(362, 23);
            this.txt_edit_password.TabIndex = 2;
            // 
            // txt_edit_username
            // 
            this.txt_edit_username.BackColor = System.Drawing.Color.Honeydew;
            this.txt_edit_username.Location = new System.Drawing.Point(180, 107);
            this.txt_edit_username.Name = "txt_edit_username";
            this.txt_edit_username.Size = new System.Drawing.Size(362, 23);
            this.txt_edit_username.TabIndex = 1;
            // 
            // txt_edit_categorie
            // 
            this.txt_edit_categorie.BackColor = System.Drawing.Color.Honeydew;
            this.txt_edit_categorie.Location = new System.Drawing.Point(180, 67);
            this.txt_edit_categorie.Name = "txt_edit_categorie";
            this.txt_edit_categorie.Size = new System.Drawing.Size(362, 23);
            this.txt_edit_categorie.TabIndex = 0;
            // 
            // txt_edit_save
            // 
            this.txt_edit_save.BackColor = System.Drawing.Color.YellowGreen;
            this.txt_edit_save.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_edit_save.Location = new System.Drawing.Point(431, 18);
            this.txt_edit_save.Name = "txt_edit_save";
            this.txt_edit_save.Size = new System.Drawing.Size(111, 35);
            this.txt_edit_save.TabIndex = 9;
            this.txt_edit_save.Text = "Salveaza";
            this.txt_edit_save.UseVisualStyleBackColor = false;
            this.txt_edit_save.Click += new System.EventHandler(this.txt_edit_save_Click);
            // 
            // Editare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.pnl_editare);
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "Editare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Editare cont";
            this.Load += new System.EventHandler(this.Editare_Load);
            this.pnl_editare.ResumeLayout(false);
            this.pnl_editare.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnl_editare;
        private Label lbl_edit_description;
        private Label lbl_edit_password;
        private Label lbl_edit_username;
        private Label lbl_edit_categorie;
        private Label lbl_title_editare;
        private RichTextBox rtext_edit_description;
        private TextBox txt_edit_password;
        private TextBox txt_edit_username;
        private TextBox txt_edit_categorie;
        private Button txt_edit_save;
    }
}