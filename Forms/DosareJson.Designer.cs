namespace PassOrganiser.Forms
{
    partial class DosareJson
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
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
            this.btn_lista_dosare_json = new System.Windows.Forms.Button();
            this.rtx_dosare_json = new System.Windows.Forms.RichTextBox();
            this.btn_json_to_dosare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_lista_dosare_json
            // 
            this.btn_lista_dosare_json.Location = new System.Drawing.Point(25, 21);
            this.btn_lista_dosare_json.Name = "btn_lista_dosare_json";
            this.btn_lista_dosare_json.Size = new System.Drawing.Size(129, 23);
            this.btn_lista_dosare_json.TabIndex = 0;
            this.btn_lista_dosare_json.Text = "Dosare to Json";
            this.btn_lista_dosare_json.UseVisualStyleBackColor = true;
            this.btn_lista_dosare_json.Click += new System.EventHandler(this.btn_lista_dosare_json_Click);
            // 
            // rtx_dosare_json
            // 
            this.rtx_dosare_json.Location = new System.Drawing.Point(25, 63);
            this.rtx_dosare_json.Name = "rtx_dosare_json";
            this.rtx_dosare_json.Size = new System.Drawing.Size(751, 375);
            this.rtx_dosare_json.TabIndex = 1;
            this.rtx_dosare_json.Text = "";
            // 
            // btn_json_to_dosare
            // 
            this.btn_json_to_dosare.Location = new System.Drawing.Point(659, 21);
            this.btn_json_to_dosare.Name = "btn_json_to_dosare";
            this.btn_json_to_dosare.Size = new System.Drawing.Size(117, 23);
            this.btn_json_to_dosare.TabIndex = 2;
            this.btn_json_to_dosare.Text = "Json to Dosare";
            this.btn_json_to_dosare.UseVisualStyleBackColor = true;
            this.btn_json_to_dosare.Click += new System.EventHandler(this.btn_json_to_dosare_Click);
            // 
            // DosareJson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_json_to_dosare);
            this.Controls.Add(this.rtx_dosare_json);
            this.Controls.Add(this.btn_lista_dosare_json);
            this.Name = "DosareJson";
            this.Text = "dosare_json";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DosareJson_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_lista_dosare_json;
        private RichTextBox rtx_dosare_json;
        private Button btn_json_to_dosare;
    }
}