namespace Neo_objekti
{
    partial class Neo
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Asteroid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opasnost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jezgra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brzina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.brzine = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnUredi = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.oAutoruToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oAutoruToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Asteroid,
            this.Opasnost,
            this.Jezgra,
            this.Brzina});
            this.dataGridView1.Location = new System.Drawing.Point(13, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(468, 177);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Asteroid
            // 
            this.Asteroid.HeaderText = "Asteroid";
            this.Asteroid.Name = "Asteroid";
            this.Asteroid.ReadOnly = true;
            // 
            // Opasnost
            // 
            this.Opasnost.HeaderText = "Opasnost";
            this.Opasnost.Name = "Opasnost";
            this.Opasnost.ReadOnly = true;
            // 
            // Jezgra
            // 
            this.Jezgra.HeaderText = "Jezgra";
            this.Jezgra.Name = "Jezgra";
            this.Jezgra.ReadOnly = true;
            // 
            // Brzina
            // 
            this.Brzina.HeaderText = "Brzina";
            this.Brzina.Name = "Brzina";
            this.Brzina.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Postotak (%) opasnih asteroida tijekom mjerenja:";
            // 
            // brzine
            // 
            this.brzine.Location = new System.Drawing.Point(259, 229);
            this.brzine.Name = "brzine";
            this.brzine.ReadOnly = true;
            this.brzine.Size = new System.Drawing.Size(100, 20);
            this.brzine.TabIndex = 3;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(244, 283);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 4;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnUredi
            // 
            this.btnUredi.Location = new System.Drawing.Point(325, 283);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(75, 23);
            this.btnUredi.TabIndex = 5;
            this.btnUredi.Text = "Uredi";
            this.btnUredi.UseVisualStyleBackColor = true;
            this.btnUredi.Click += new System.EventHandler(this.btnuredi_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(406, 283);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(75, 23);
            this.btnObrisi.TabIndex = 6;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btndel_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.oAutoruToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(493, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(93, 20);
            this.toolStripMenuItem1.Text = "Grafički prikaz";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(119, 22);
            this.toolStripMenuItem2.Text = "Grafikon";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(119, 22);
            this.toolStripMenuItem3.Text = "Izlaz";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // oAutoruToolStripMenuItem
            // 
            this.oAutoruToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oAutoruToolStripMenuItem1});
            this.oAutoruToolStripMenuItem.Name = "oAutoruToolStripMenuItem";
            this.oAutoruToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.oAutoruToolStripMenuItem.Text = "Autor";
            this.oAutoruToolStripMenuItem.Click += new System.EventHandler(this.oAutoruToolStripMenuItem_Click_1);
            // 
            // oAutoruToolStripMenuItem1
            // 
            this.oAutoruToolStripMenuItem1.Name = "oAutoruToolStripMenuItem1";
            this.oAutoruToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.oAutoruToolStripMenuItem1.Text = "O autoru";
            this.oAutoruToolStripMenuItem1.Click += new System.EventHandler(this.oAutoruToolStripMenuItem1_Click);
            // 
            // Neo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 318);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.brzine);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Neo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NEO objekti";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asteroid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opasnost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jezgra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brzina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox brzine;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem oAutoruToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oAutoruToolStripMenuItem1;
    }
}

