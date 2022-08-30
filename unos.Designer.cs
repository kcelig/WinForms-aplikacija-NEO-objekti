namespace Neo_objekti
{
    partial class Unos
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
            this.label1 = new System.Windows.Forms.Label();
            this.naziv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxOpasan = new System.Windows.Forms.CheckBox();
            this.sjezgre = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnok = new System.Windows.Forms.Button();
            this.brzina = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sjezgre.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv asteroida:";
            // 
            // naziv
            // 
            this.naziv.Location = new System.Drawing.Point(168, 10);
            this.naziv.Name = "naziv";
            this.naziv.Size = new System.Drawing.Size(164, 20);
            this.naziv.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Potencijalno opasan?:";
            // 
            // cbxOpasan
            // 
            this.cbxOpasan.AutoSize = true;
            this.cbxOpasan.Location = new System.Drawing.Point(168, 47);
            this.cbxOpasan.Name = "cbxOpasan";
            this.cbxOpasan.Size = new System.Drawing.Size(61, 17);
            this.cbxOpasan.TabIndex = 3;
            this.cbxOpasan.Text = "opasan";
            this.cbxOpasan.UseVisualStyleBackColor = true;
            // 
            // sjezgre
            // 
            this.sjezgre.Controls.Add(this.radioButton3);
            this.sjezgre.Controls.Add(this.radioButton2);
            this.sjezgre.Controls.Add(this.radioButton1);
            this.sjezgre.Location = new System.Drawing.Point(16, 91);
            this.sjezgre.Name = "sjezgre";
            this.sjezgre.Size = new System.Drawing.Size(243, 100);
            this.sjezgre.TabIndex = 4;
            this.sjezgre.TabStop = false;
            this.sjezgre.Text = "Sastav jezgre:";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 66);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(62, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "metalna";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 43);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(75, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "karbonska";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(63, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "silikatna";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(257, 317);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 5;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(168, 317);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(75, 23);
            this.btnok.TabIndex = 6;
            this.btnok.Text = "U redu";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // brzina
            // 
            this.brzina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.brzina.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50"});
            this.brzina.Location = new System.Drawing.Point(168, 219);
            this.brzina.Name = "brzina";
            this.brzina.Size = new System.Drawing.Size(63, 21);
            this.brzina.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Procjena brzine (km/s):";
            // 
            // Unos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 352);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.brzina);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.sjezgre);
            this.Controls.Add(this.cbxOpasan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.naziv);
            this.Controls.Add(this.label1);
            this.Name = "Unos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Unos";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.sjezgre.ResumeLayout(false);
            this.sjezgre.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox naziv;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.CheckBox cbxOpasan;
        private System.Windows.Forms.GroupBox sjezgre;
        public System.Windows.Forms.RadioButton radioButton3;
        public System.Windows.Forms.RadioButton radioButton2;
        public System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnok;
        public System.Windows.Forms.ComboBox brzina;
        private System.Windows.Forms.Label label3;
    }
}