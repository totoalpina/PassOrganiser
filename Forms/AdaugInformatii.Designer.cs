﻿namespace PassOrganiser
{
    partial class AdaugInformatii
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_titlu_cautare = new System.Windows.Forms.Label();
            this.lbl_titlu_adauga = new System.Windows.Forms.Label();
            this.pnl_cautare = new System.Windows.Forms.Panel();
            this.btn_cauta = new System.Windows.Forms.Button();
            this.dgrd_cautare = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_cauta = new System.Windows.Forms.TextBox();
            this.pnl_adaugare = new System.Windows.Forms.Panel();
            this.btn_adauga_informatii = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_categorie = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rTxt_descriere = new System.Windows.Forms.RichTextBox();
            this.txt_parola = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.contBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.contBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbConnectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbConnectionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.pnl_cautare.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrd_cautare)).BeginInit();
            this.pnl_adaugare.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbConnectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbConnectionBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_titlu_cautare);
            this.panel1.Controls.Add(this.lbl_titlu_adauga);
            this.panel1.Controls.Add(this.pnl_cautare);
            this.panel1.Controls.Add(this.pnl_adaugare);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.MaximumSize = new System.Drawing.Size(1160, 737);
            this.panel1.MinimumSize = new System.Drawing.Size(1160, 737);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1160, 737);
            this.panel1.TabIndex = 0;
            // 
            // lbl_titlu_cautare
            // 
            this.lbl_titlu_cautare.AutoSize = true;
            this.lbl_titlu_cautare.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_titlu_cautare.Location = new System.Drawing.Point(598, 91);
            this.lbl_titlu_cautare.Name = "lbl_titlu_cautare";
            this.lbl_titlu_cautare.Size = new System.Drawing.Size(186, 25);
            this.lbl_titlu_cautare.TabIndex = 3;
            this.lbl_titlu_cautare.Text = "Cautare Informatii";
            this.lbl_titlu_cautare.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_titlu_adauga
            // 
            this.lbl_titlu_adauga.AutoSize = true;
            this.lbl_titlu_adauga.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_titlu_adauga.Location = new System.Drawing.Point(30, 91);
            this.lbl_titlu_adauga.Name = "lbl_titlu_adauga";
            this.lbl_titlu_adauga.Size = new System.Drawing.Size(203, 25);
            this.lbl_titlu_adauga.TabIndex = 2;
            this.lbl_titlu_adauga.Text = "Adaugare informatii";
            this.lbl_titlu_adauga.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_cautare
            // 
            this.pnl_cautare.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_cautare.BackColor = System.Drawing.Color.BurlyWood;
            this.pnl_cautare.Controls.Add(this.btn_cauta);
            this.pnl_cautare.Controls.Add(this.dgrd_cautare);
            this.pnl_cautare.Controls.Add(this.label5);
            this.pnl_cautare.Controls.Add(this.txt_cauta);
            this.pnl_cautare.Location = new System.Drawing.Point(598, 143);
            this.pnl_cautare.Name = "pnl_cautare";
            this.pnl_cautare.Size = new System.Drawing.Size(534, 560);
            this.pnl_cautare.TabIndex = 1;
            // 
            // btn_cauta
            // 
            this.btn_cauta.Location = new System.Drawing.Point(447, 204);
            this.btn_cauta.Name = "btn_cauta";
            this.btn_cauta.Size = new System.Drawing.Size(69, 23);
            this.btn_cauta.TabIndex = 11;
            this.btn_cauta.Text = "Cauta";
            this.btn_cauta.UseVisualStyleBackColor = true;
            this.btn_cauta.Click += new System.EventHandler(this.btn_cauta_Click);
            // 
            // dgrd_cautare
            // 
            this.dgrd_cautare.BackgroundColor = System.Drawing.Color.Cornsilk;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrd_cautare.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgrd_cautare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrd_cautare.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dgrd_cautare.Location = new System.Drawing.Point(38, 237);
            this.dgrd_cautare.Name = "dgrd_cautare";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrd_cautare.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgrd_cautare.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgrd_cautare.RowTemplate.Height = 25;
            this.dgrd_cautare.Size = new System.Drawing.Size(478, 155);
            this.dgrd_cautare.TabIndex = 10;
            this.dgrd_cautare.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrd_cautare_CellDoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(38, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cauta :";
            // 
            // txt_cauta
            // 
            this.txt_cauta.Location = new System.Drawing.Point(101, 205);
            this.txt_cauta.Name = "txt_cauta";
            this.txt_cauta.Size = new System.Drawing.Size(340, 23);
            this.txt_cauta.TabIndex = 8;
            // 
            // pnl_adaugare
            // 
            this.pnl_adaugare.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_adaugare.BackColor = System.Drawing.Color.RosyBrown;
            this.pnl_adaugare.Controls.Add(this.btn_adauga_informatii);
            this.pnl_adaugare.Controls.Add(this.label4);
            this.pnl_adaugare.Controls.Add(this.txt_categorie);
            this.pnl_adaugare.Controls.Add(this.label3);
            this.pnl_adaugare.Controls.Add(this.label2);
            this.pnl_adaugare.Controls.Add(this.label1);
            this.pnl_adaugare.Controls.Add(this.rTxt_descriere);
            this.pnl_adaugare.Controls.Add(this.txt_parola);
            this.pnl_adaugare.Controls.Add(this.txt_username);
            this.pnl_adaugare.Location = new System.Drawing.Point(30, 143);
            this.pnl_adaugare.Name = "pnl_adaugare";
            this.pnl_adaugare.Size = new System.Drawing.Size(534, 560);
            this.pnl_adaugare.TabIndex = 0;
            // 
            // btn_adauga_informatii
            // 
            this.btn_adauga_informatii.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_adauga_informatii.Location = new System.Drawing.Point(164, 517);
            this.btn_adauga_informatii.Name = "btn_adauga_informatii";
            this.btn_adauga_informatii.Size = new System.Drawing.Size(348, 34);
            this.btn_adauga_informatii.TabIndex = 8;
            this.btn_adauga_informatii.Text = "Adauga Informatiile";
            this.btn_adauga_informatii.UseVisualStyleBackColor = true;
            this.btn_adauga_informatii.Click += new System.EventHandler(this.btn_adauga_informatii_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(69, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Categorie :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_categorie
            // 
            this.txt_categorie.Location = new System.Drawing.Point(164, 205);
            this.txt_categorie.Name = "txt_categorie";
            this.txt_categorie.Size = new System.Drawing.Size(348, 23);
            this.txt_categorie.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(55, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Description :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(68, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username / Email :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rTxt_descriere
            // 
            this.rTxt_descriere.Location = new System.Drawing.Point(164, 292);
            this.rTxt_descriere.Name = "rTxt_descriere";
            this.rTxt_descriere.Size = new System.Drawing.Size(348, 219);
            this.rTxt_descriere.TabIndex = 2;
            this.rTxt_descriere.Text = "";
            // 
            // txt_parola
            // 
            this.txt_parola.Location = new System.Drawing.Point(164, 263);
            this.txt_parola.Name = "txt_parola";
            this.txt_parola.Size = new System.Drawing.Size(348, 23);
            this.txt_parola.TabIndex = 1;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(164, 234);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(348, 23);
            this.txt_username.TabIndex = 0;
            // 
            // AdaugInformatii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.panel1);
            this.Name = "AdaugInformatii";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adaugare Informatii";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdaugInformatii_FormClosed);
            this.Load += new System.EventHandler(this.AdaugInformatii_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_cautare.ResumeLayout(false);
            this.pnl_cautare.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrd_cautare)).EndInit();
            this.pnl_adaugare.ResumeLayout(false);
            this.pnl_adaugare.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbConnectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbConnectionBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel pnl_cautare;
        private Panel pnl_adaugare;
        private Label lbl_titlu_cautare;
        private Label lbl_titlu_adauga;
        private Label label5;
        private TextBox txt_cauta;
        private Label label4;
        private TextBox txt_categorie;
        private Label label3;
        private Label label2;
        private Label label1;
        private RichTextBox rTxt_descriere;
        private TextBox txt_parola;
        private TextBox txt_username;
        private DataGridView dgrd_cautare;
        private BindingSource dbConnectionBindingSource;
        private Button btn_adauga_informatii;
        private Button btn_cauta;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categorieDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private BindingSource contBindingSource;
        private BindingSource dbConnectionBindingSource1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private BindingSource contBindingSource1;
    }
}