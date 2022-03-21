namespace PraktikumWeek5
{
    partial class Form1
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
            this.LblData = new System.Windows.Forms.Label();
            this.TBoxData = new System.Windows.Forms.TextBox();
            this.LblKoleksi = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.LblOutput = new System.Windows.Forms.Label();
            this.BtnClear = new System.Windows.Forms.Button();
            this.LblSetting = new System.Windows.Forms.Label();
            this.CBoxAktif = new System.Windows.Forms.CheckBox();
            this.RBtnMerah = new System.Windows.Forms.RadioButton();
            this.RBtnBiru = new System.Windows.Forms.RadioButton();
            this.LBoxData = new System.Windows.Forms.ListBox();
            this.LblOutputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblData
            // 
            this.LblData.AutoSize = true;
            this.LblData.Location = new System.Drawing.Point(32, 35);
            this.LblData.Name = "LblData";
            this.LblData.Size = new System.Drawing.Size(42, 16);
            this.LblData.TabIndex = 0;
            this.LblData.Text = "Data :";
            // 
            // TBoxData
            // 
            this.TBoxData.Location = new System.Drawing.Point(89, 32);
            this.TBoxData.Name = "TBoxData";
            this.TBoxData.Size = new System.Drawing.Size(390, 22);
            this.TBoxData.TabIndex = 3;
            // 
            // LblKoleksi
            // 
            this.LblKoleksi.AutoSize = true;
            this.LblKoleksi.Location = new System.Drawing.Point(32, 86);
            this.LblKoleksi.Name = "LblKoleksi";
            this.LblKoleksi.Size = new System.Drawing.Size(57, 16);
            this.LblKoleksi.TabIndex = 8;
            this.LblKoleksi.Text = "Koleksi :";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(496, 31);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(111, 23);
            this.BtnAdd.TabIndex = 9;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // LblOutput
            // 
            this.LblOutput.AutoSize = true;
            this.LblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOutput.Location = new System.Drawing.Point(329, 256);
            this.LblOutput.Name = "LblOutput";
            this.LblOutput.Size = new System.Drawing.Size(115, 38);
            this.LblOutput.TabIndex = 10;
            this.LblOutput.Text = "Output";
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(336, 407);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(271, 23);
            this.BtnClear.TabIndex = 11;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // LblSetting
            // 
            this.LblSetting.AutoSize = true;
            this.LblSetting.Location = new System.Drawing.Point(333, 86);
            this.LblSetting.Name = "LblSetting";
            this.LblSetting.Size = new System.Drawing.Size(54, 16);
            this.LblSetting.TabIndex = 12;
            this.LblSetting.Text = "Setting :";
            // 
            // CBoxAktif
            // 
            this.CBoxAktif.AutoSize = true;
            this.CBoxAktif.Location = new System.Drawing.Point(398, 86);
            this.CBoxAktif.Name = "CBoxAktif";
            this.CBoxAktif.Size = new System.Drawing.Size(54, 20);
            this.CBoxAktif.TabIndex = 13;
            this.CBoxAktif.Text = "Aktif";
            this.CBoxAktif.UseVisualStyleBackColor = true;
            this.CBoxAktif.CheckedChanged += new System.EventHandler(this.CBoxAktif_CheckedChanged);
            // 
            // RBtnMerah
            // 
            this.RBtnMerah.AutoSize = true;
            this.RBtnMerah.Location = new System.Drawing.Point(347, 115);
            this.RBtnMerah.Name = "RBtnMerah";
            this.RBtnMerah.Size = new System.Drawing.Size(109, 20);
            this.RBtnMerah.TabIndex = 14;
            this.RBtnMerah.TabStop = true;
            this.RBtnMerah.Text = "Warna Merah";
            this.RBtnMerah.UseVisualStyleBackColor = true;
            this.RBtnMerah.CheckedChanged += new System.EventHandler(this.RBtnMerah_CheckedChanged);
            // 
            // RBtnBiru
            // 
            this.RBtnBiru.AutoSize = true;
            this.RBtnBiru.Location = new System.Drawing.Point(347, 141);
            this.RBtnBiru.Name = "RBtnBiru";
            this.RBtnBiru.Size = new System.Drawing.Size(94, 20);
            this.RBtnBiru.TabIndex = 15;
            this.RBtnBiru.TabStop = true;
            this.RBtnBiru.Text = "Warna Biru";
            this.RBtnBiru.UseVisualStyleBackColor = true;
            this.RBtnBiru.CheckedChanged += new System.EventHandler(this.RBtnBiru_CheckedChanged);
            // 
            // LBoxData
            // 
            this.LBoxData.FormattingEnabled = true;
            this.LBoxData.ItemHeight = 16;
            this.LBoxData.Location = new System.Drawing.Point(35, 106);
            this.LBoxData.Name = "LBoxData";
            this.LBoxData.Size = new System.Drawing.Size(267, 324);
            this.LBoxData.TabIndex = 16;
            this.LBoxData.SelectedIndexChanged += new System.EventHandler(this.LBoxData_SelectedIndexChanged);
            // 
            // LblOutputLabel
            // 
            this.LblOutputLabel.AutoSize = true;
            this.LblOutputLabel.Location = new System.Drawing.Point(333, 211);
            this.LblOutputLabel.Name = "LblOutputLabel";
            this.LblOutputLabel.Size = new System.Drawing.Size(51, 16);
            this.LblOutputLabel.TabIndex = 17;
            this.LblOutputLabel.Text = "Output :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 467);
            this.Controls.Add(this.LblOutputLabel);
            this.Controls.Add(this.LBoxData);
            this.Controls.Add(this.RBtnBiru);
            this.Controls.Add(this.RBtnMerah);
            this.Controls.Add(this.CBoxAktif);
            this.Controls.Add(this.LblSetting);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.LblOutput);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.LblKoleksi);
            this.Controls.Add(this.TBoxData);
            this.Controls.Add(this.LblData);
            this.Name = "Form1";
            this.Text = "Form Materi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblData;
        private System.Windows.Forms.TextBox TBoxData;
        private System.Windows.Forms.Label LblKoleksi;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Label LblOutput;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Label LblSetting;
        private System.Windows.Forms.CheckBox CBoxAktif;
        private System.Windows.Forms.RadioButton RBtnMerah;
        private System.Windows.Forms.RadioButton RBtnBiru;
        private System.Windows.Forms.ListBox LBoxData;
        private System.Windows.Forms.Label LblOutputLabel;
    }
}

