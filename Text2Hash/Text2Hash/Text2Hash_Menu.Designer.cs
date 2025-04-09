namespace Text2Hash
{
    partial class Text2Hash_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Text2Hash_Menu));
            this.btn_Generate = new System.Windows.Forms.Button();
            this.txtRichText = new System.Windows.Forms.RichTextBox();
            this.lbl_TextString = new System.Windows.Forms.Label();
            this.lbl_MD5 = new System.Windows.Forms.Label();
            this.txtString = new System.Windows.Forms.TextBox();
            this.chkbox = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Generate
            // 
            this.btn_Generate.AutoSize = true;
            this.btn_Generate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Generate.Location = new System.Drawing.Point(280, 166);
            this.btn_Generate.Name = "btn_Generate";
            this.btn_Generate.Size = new System.Drawing.Size(75, 24);
            this.btn_Generate.TabIndex = 0;
            this.btn_Generate.Text = "Generate";
            this.btn_Generate.UseVisualStyleBackColor = true;
            this.btn_Generate.Click += new System.EventHandler(this.btn_Generate_Click);
            // 
            // txtRichText
            // 
            this.txtRichText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtRichText.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRichText.Location = new System.Drawing.Point(12, 81);
            this.txtRichText.Name = "txtRichText";
            this.txtRichText.ReadOnly = true;
            this.txtRichText.Size = new System.Drawing.Size(343, 78);
            this.txtRichText.TabIndex = 1;
            this.txtRichText.Text = "";
            // 
            // lbl_TextString
            // 
            this.lbl_TextString.AutoSize = true;
            this.lbl_TextString.Location = new System.Drawing.Point(12, 18);
            this.lbl_TextString.Name = "lbl_TextString";
            this.lbl_TextString.Size = new System.Drawing.Size(34, 13);
            this.lbl_TextString.TabIndex = 2;
            this.lbl_TextString.Text = "Text :";
            // 
            // lbl_MD5
            // 
            this.lbl_MD5.AutoSize = true;
            this.lbl_MD5.Location = new System.Drawing.Point(12, 65);
            this.lbl_MD5.Name = "lbl_MD5";
            this.lbl_MD5.Size = new System.Drawing.Size(64, 13);
            this.lbl_MD5.TabIndex = 3;
            this.lbl_MD5.Text = "MD5 Hash :";
            // 
            // txtString
            // 
            this.txtString.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtString.Location = new System.Drawing.Point(12, 34);
            this.txtString.Name = "txtString";
            this.txtString.Size = new System.Drawing.Size(343, 21);
            this.txtString.TabIndex = 4;
            // 
            // chkbox
            // 
            this.chkbox.AutoSize = true;
            this.chkbox.Location = new System.Drawing.Point(15, 170);
            this.chkbox.Name = "chkbox";
            this.chkbox.Size = new System.Drawing.Size(82, 17);
            this.chkbox.TabIndex = 5;
            this.chkbox.Text = "Upper Case";
            this.chkbox.UseVisualStyleBackColor = true;
            this.chkbox.CheckedChanged += new System.EventHandler(this.chkbox_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(199, 166);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 24);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Text2Hash_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 200);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chkbox);
            this.Controls.Add(this.txtString);
            this.Controls.Add(this.lbl_MD5);
            this.Controls.Add(this.lbl_TextString);
            this.Controls.Add(this.txtRichText);
            this.Controls.Add(this.btn_Generate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Text2Hash_Menu";
            this.Text = "Text2Hash (MD5)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Generate;
        private System.Windows.Forms.RichTextBox txtRichText;
        private System.Windows.Forms.Label lbl_TextString;
        private System.Windows.Forms.Label lbl_MD5;
        private System.Windows.Forms.TextBox txtString;
        private System.Windows.Forms.CheckBox chkbox;
        private System.Windows.Forms.Button btnSave;
    }
}

