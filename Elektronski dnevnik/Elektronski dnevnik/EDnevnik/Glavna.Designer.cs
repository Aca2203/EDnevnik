
namespace EDnevnik
{
    partial class Glavna
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
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.tsm_jedanBez = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmItem_osobe = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_jedanSa = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_tabelaBez = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_smerovi = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_skolskeGodine = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_predmeti = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_osobe = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_tabelaSa = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_izvestaji = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_ime = new System.Windows.Forms.Label();
            this.lbl_prezime = new System.Windows.Forms.Label();
            this.lbl_uloga = new System.Windows.Forms.Label();
            this.txt_ime = new System.Windows.Forms.TextBox();
            this.txt_prezime = new System.Windows.Forms.TextBox();
            this.txt_uloga = new System.Windows.Forms.TextBox();
            this.tsm_raspodela = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip3
            // 
            this.menuStrip3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_jedanBez,
            this.tsm_jedanSa,
            this.tsm_tabelaBez,
            this.tsm_tabelaSa,
            this.tsm_izvestaji});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(626, 31);
            this.menuStrip3.TabIndex = 0;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // tsm_jedanBez
            // 
            this.tsm_jedanBez.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmItem_osobe});
            this.tsm_jedanBez.Name = "tsm_jedanBez";
            this.tsm_jedanBez.Size = new System.Drawing.Size(99, 27);
            this.tsm_jedanBez.Text = "Један без";
            // 
            // tsmItem_osobe
            // 
            this.tsmItem_osobe.Name = "tsmItem_osobe";
            this.tsmItem_osobe.Size = new System.Drawing.Size(224, 28);
            this.tsmItem_osobe.Text = "Особе";
            this.tsmItem_osobe.Click += new System.EventHandler(this.tsmItem_osobe_Click);
            // 
            // tsm_jedanSa
            // 
            this.tsm_jedanSa.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_raspodela});
            this.tsm_jedanSa.Name = "tsm_jedanSa";
            this.tsm_jedanSa.Size = new System.Drawing.Size(89, 27);
            this.tsm_jedanSa.Text = "Један са";
            // 
            // tsm_tabelaBez
            // 
            this.tsm_tabelaBez.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_smerovi,
            this.tsm_skolskeGodine,
            this.tsm_predmeti,
            this.tsm_osobe});
            this.tsm_tabelaBez.Name = "tsm_tabelaBez";
            this.tsm_tabelaBez.Size = new System.Drawing.Size(111, 27);
            this.tsm_tabelaBez.Text = "Табела без";
            // 
            // tsm_smerovi
            // 
            this.tsm_smerovi.Name = "tsm_smerovi";
            this.tsm_smerovi.Size = new System.Drawing.Size(224, 28);
            this.tsm_smerovi.Text = "Смерови";
            this.tsm_smerovi.Click += new System.EventHandler(this.tsm_smerovi_Click);
            // 
            // tsm_skolskeGodine
            // 
            this.tsm_skolskeGodine.Name = "tsm_skolskeGodine";
            this.tsm_skolskeGodine.Size = new System.Drawing.Size(224, 28);
            this.tsm_skolskeGodine.Text = "Школске године";
            this.tsm_skolskeGodine.Click += new System.EventHandler(this.tsm_skolskeGodine_Click);
            // 
            // tsm_predmeti
            // 
            this.tsm_predmeti.Name = "tsm_predmeti";
            this.tsm_predmeti.Size = new System.Drawing.Size(224, 28);
            this.tsm_predmeti.Text = "Предмети";
            this.tsm_predmeti.Click += new System.EventHandler(this.tsm_predmeti_Click);
            // 
            // tsm_osobe
            // 
            this.tsm_osobe.Name = "tsm_osobe";
            this.tsm_osobe.Size = new System.Drawing.Size(224, 28);
            this.tsm_osobe.Text = "Особе";
            this.tsm_osobe.Click += new System.EventHandler(this.tsm_osobe_Click);
            // 
            // tsm_tabelaSa
            // 
            this.tsm_tabelaSa.Name = "tsm_tabelaSa";
            this.tsm_tabelaSa.Size = new System.Drawing.Size(101, 27);
            this.tsm_tabelaSa.Text = "Табела са";
            // 
            // tsm_izvestaji
            // 
            this.tsm_izvestaji.Name = "tsm_izvestaji";
            this.tsm_izvestaji.Size = new System.Drawing.Size(107, 27);
            this.tsm_izvestaji.Text = "Извештаји";
            // 
            // lbl_ime
            // 
            this.lbl_ime.AutoSize = true;
            this.lbl_ime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ime.Location = new System.Drawing.Point(82, 60);
            this.lbl_ime.Name = "lbl_ime";
            this.lbl_ime.Size = new System.Drawing.Size(79, 32);
            this.lbl_ime.TabIndex = 2;
            this.lbl_ime.Text = "Име:";
            // 
            // lbl_prezime
            // 
            this.lbl_prezime.AutoSize = true;
            this.lbl_prezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prezime.Location = new System.Drawing.Point(20, 103);
            this.lbl_prezime.Name = "lbl_prezime";
            this.lbl_prezime.Size = new System.Drawing.Size(141, 32);
            this.lbl_prezime.TabIndex = 3;
            this.lbl_prezime.Text = "Презиме:";
            // 
            // lbl_uloga
            // 
            this.lbl_uloga.AutoSize = true;
            this.lbl_uloga.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_uloga.Location = new System.Drawing.Point(61, 147);
            this.lbl_uloga.Name = "lbl_uloga";
            this.lbl_uloga.Size = new System.Drawing.Size(100, 32);
            this.lbl_uloga.TabIndex = 8;
            this.lbl_uloga.Text = "Улога:";
            // 
            // txt_ime
            // 
            this.txt_ime.Enabled = false;
            this.txt_ime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ime.Location = new System.Drawing.Point(167, 57);
            this.txt_ime.Name = "txt_ime";
            this.txt_ime.Size = new System.Drawing.Size(440, 38);
            this.txt_ime.TabIndex = 10;
            // 
            // txt_prezime
            // 
            this.txt_prezime.Enabled = false;
            this.txt_prezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prezime.Location = new System.Drawing.Point(167, 100);
            this.txt_prezime.Name = "txt_prezime";
            this.txt_prezime.Size = new System.Drawing.Size(440, 38);
            this.txt_prezime.TabIndex = 11;
            // 
            // txt_uloga
            // 
            this.txt_uloga.Enabled = false;
            this.txt_uloga.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_uloga.Location = new System.Drawing.Point(167, 144);
            this.txt_uloga.Name = "txt_uloga";
            this.txt_uloga.Size = new System.Drawing.Size(440, 38);
            this.txt_uloga.TabIndex = 16;
            // 
            // tsm_raspodela
            // 
            this.tsm_raspodela.Name = "tsm_raspodela";
            this.tsm_raspodela.Size = new System.Drawing.Size(224, 28);
            this.tsm_raspodela.Text = "Расподела";
            this.tsm_raspodela.Click += new System.EventHandler(this.tsm_raspodela_Click);
            // 
            // Glavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 212);
            this.Controls.Add(this.txt_uloga);
            this.Controls.Add(this.txt_prezime);
            this.Controls.Add(this.txt_ime);
            this.Controls.Add(this.lbl_uloga);
            this.Controls.Add(this.lbl_prezime);
            this.Controls.Add(this.lbl_ime);
            this.Controls.Add(this.menuStrip3);
            this.MainMenuStrip = this.menuStrip3;
            this.Name = "Glavna";
            this.Text = "Glavna";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Glavna_FormClosed);
            this.Load += new System.EventHandler(this.Glavna_Load);
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem tsm_jedanBez;
        private System.Windows.Forms.ToolStripMenuItem tsm_jedanSa;
        private System.Windows.Forms.ToolStripMenuItem tsmItem_osobe;
        private System.Windows.Forms.ToolStripMenuItem tsm_tabelaBez;
        private System.Windows.Forms.ToolStripMenuItem tsm_tabelaSa;
        private System.Windows.Forms.ToolStripMenuItem tsm_izvestaji;
        private System.Windows.Forms.Label lbl_ime;
        private System.Windows.Forms.Label lbl_prezime;
        private System.Windows.Forms.Label lbl_uloga;
        private System.Windows.Forms.TextBox txt_ime;
        private System.Windows.Forms.TextBox txt_prezime;
        private System.Windows.Forms.TextBox txt_uloga;
        private System.Windows.Forms.ToolStripMenuItem tsm_smerovi;
        private System.Windows.Forms.ToolStripMenuItem tsm_skolskeGodine;
        private System.Windows.Forms.ToolStripMenuItem tsm_predmeti;
        private System.Windows.Forms.ToolStripMenuItem tsm_osobe;
        private System.Windows.Forms.ToolStripMenuItem tsm_raspodela;
    }
}