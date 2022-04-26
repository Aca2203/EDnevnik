
namespace EDnevnik
{
    partial class Glavna2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.обрадаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расподелаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оценеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.уписницеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.шифарнициToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.особеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.смеровиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.школскеГодинеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.предметиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.извештајиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_uloga = new System.Windows.Forms.TextBox();
            this.txt_prezime = new System.Windows.Forms.TextBox();
            this.txt_ime = new System.Windows.Forms.TextBox();
            this.lbl_uloga = new System.Windows.Forms.Label();
            this.lbl_prezime = new System.Windows.Forms.Label();
            this.lbl_ime = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обрадаToolStripMenuItem,
            this.шифарнициToolStripMenuItem,
            this.извештајиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(633, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // обрадаToolStripMenuItem
            // 
            this.обрадаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.расподелаToolStripMenuItem,
            this.оценеToolStripMenuItem,
            this.уписницеToolStripMenuItem});
            this.обрадаToolStripMenuItem.Name = "обрадаToolStripMenuItem";
            this.обрадаToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.обрадаToolStripMenuItem.Text = "Обрада";
            // 
            // расподелаToolStripMenuItem
            // 
            this.расподелаToolStripMenuItem.Name = "расподелаToolStripMenuItem";
            this.расподелаToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.расподелаToolStripMenuItem.Text = "Расподела";
            this.расподелаToolStripMenuItem.Click += new System.EventHandler(this.расподелаToolStripMenuItem_Click);
            // 
            // оценеToolStripMenuItem
            // 
            this.оценеToolStripMenuItem.Name = "оценеToolStripMenuItem";
            this.оценеToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.оценеToolStripMenuItem.Text = "Оцене";
            this.оценеToolStripMenuItem.Click += new System.EventHandler(this.оценеToolStripMenuItem_Click);
            // 
            // уписницеToolStripMenuItem
            // 
            this.уписницеToolStripMenuItem.Name = "уписницеToolStripMenuItem";
            this.уписницеToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.уписницеToolStripMenuItem.Text = "Уписнице";
            this.уписницеToolStripMenuItem.Click += new System.EventHandler(this.уписницеToolStripMenuItem_Click);
            // 
            // шифарнициToolStripMenuItem
            // 
            this.шифарнициToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.особеToolStripMenuItem,
            this.смеровиToolStripMenuItem,
            this.школскеГодинеToolStripMenuItem,
            this.предметиToolStripMenuItem});
            this.шифарнициToolStripMenuItem.Name = "шифарнициToolStripMenuItem";
            this.шифарнициToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.шифарнициToolStripMenuItem.Text = "Шифарници";
            // 
            // особеToolStripMenuItem
            // 
            this.особеToolStripMenuItem.Name = "особеToolStripMenuItem";
            this.особеToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.особеToolStripMenuItem.Text = "Особе";
            this.особеToolStripMenuItem.Click += new System.EventHandler(this.особеToolStripMenuItem_Click);
            // 
            // смеровиToolStripMenuItem
            // 
            this.смеровиToolStripMenuItem.Name = "смеровиToolStripMenuItem";
            this.смеровиToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.смеровиToolStripMenuItem.Text = "Смерови";
            this.смеровиToolStripMenuItem.Click += new System.EventHandler(this.смеровиToolStripMenuItem_Click);
            // 
            // школскеГодинеToolStripMenuItem
            // 
            this.школскеГодинеToolStripMenuItem.Name = "школскеГодинеToolStripMenuItem";
            this.школскеГодинеToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.школскеГодинеToolStripMenuItem.Text = "Школске године";
            this.школскеГодинеToolStripMenuItem.Click += new System.EventHandler(this.школскеГодинеToolStripMenuItem_Click);
            // 
            // предметиToolStripMenuItem
            // 
            this.предметиToolStripMenuItem.Name = "предметиToolStripMenuItem";
            this.предметиToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.предметиToolStripMenuItem.Text = "Предмети";
            this.предметиToolStripMenuItem.Click += new System.EventHandler(this.предметиToolStripMenuItem_Click);
            // 
            // извештајиToolStripMenuItem
            // 
            this.извештајиToolStripMenuItem.Name = "извештајиToolStripMenuItem";
            this.извештајиToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.извештајиToolStripMenuItem.Text = "Извештаји";
            // 
            // txt_uloga
            // 
            this.txt_uloga.Enabled = false;
            this.txt_uloga.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_uloga.Location = new System.Drawing.Point(175, 141);
            this.txt_uloga.Name = "txt_uloga";
            this.txt_uloga.Size = new System.Drawing.Size(440, 38);
            this.txt_uloga.TabIndex = 22;
            // 
            // txt_prezime
            // 
            this.txt_prezime.Enabled = false;
            this.txt_prezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prezime.Location = new System.Drawing.Point(175, 97);
            this.txt_prezime.Name = "txt_prezime";
            this.txt_prezime.Size = new System.Drawing.Size(440, 38);
            this.txt_prezime.TabIndex = 21;
            // 
            // txt_ime
            // 
            this.txt_ime.Enabled = false;
            this.txt_ime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ime.Location = new System.Drawing.Point(175, 54);
            this.txt_ime.Name = "txt_ime";
            this.txt_ime.Size = new System.Drawing.Size(440, 38);
            this.txt_ime.TabIndex = 20;
            // 
            // lbl_uloga
            // 
            this.lbl_uloga.AutoSize = true;
            this.lbl_uloga.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_uloga.Location = new System.Drawing.Point(69, 144);
            this.lbl_uloga.Name = "lbl_uloga";
            this.lbl_uloga.Size = new System.Drawing.Size(100, 32);
            this.lbl_uloga.TabIndex = 19;
            this.lbl_uloga.Text = "Улога:";
            // 
            // lbl_prezime
            // 
            this.lbl_prezime.AutoSize = true;
            this.lbl_prezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prezime.Location = new System.Drawing.Point(28, 100);
            this.lbl_prezime.Name = "lbl_prezime";
            this.lbl_prezime.Size = new System.Drawing.Size(141, 32);
            this.lbl_prezime.TabIndex = 18;
            this.lbl_prezime.Text = "Презиме:";
            // 
            // lbl_ime
            // 
            this.lbl_ime.AutoSize = true;
            this.lbl_ime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ime.Location = new System.Drawing.Point(90, 57);
            this.lbl_ime.Name = "lbl_ime";
            this.lbl_ime.Size = new System.Drawing.Size(79, 32);
            this.lbl_ime.TabIndex = 17;
            this.lbl_ime.Text = "Име:";
            // 
            // Glavna2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 218);
            this.Controls.Add(this.txt_uloga);
            this.Controls.Add(this.txt_prezime);
            this.Controls.Add(this.txt_ime);
            this.Controls.Add(this.lbl_uloga);
            this.Controls.Add(this.lbl_prezime);
            this.Controls.Add(this.lbl_ime);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Glavna2";
            this.Text = "Glavna2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Glavna2_FormClosed_1);
            this.Load += new System.EventHandler(this.Glavna2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem обрадаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расподелаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оценеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem уписницеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem шифарнициToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem особеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem смеровиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem школскеГодинеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem предметиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem извештајиToolStripMenuItem;
        private System.Windows.Forms.TextBox txt_uloga;
        private System.Windows.Forms.TextBox txt_prezime;
        private System.Windows.Forms.TextBox txt_ime;
        private System.Windows.Forms.Label lbl_uloga;
        private System.Windows.Forms.Label lbl_prezime;
        private System.Windows.Forms.Label lbl_ime;
    }
}