using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDnevnik
{
    public partial class Glavna : Form
    {
        public Glavna()
        {
            InitializeComponent();
        }

        private void tsmItem_osobe_Click(object sender, EventArgs e)
        {
            Osoba frm_Osoba = new Osoba();
            frm_Osoba.Show();
        }

        private void Glavna_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Glavna_Load(object sender, EventArgs e)
        {
            txt_ime.Text = Program.ime_korisnika;
            txt_prezime.Text = Program.prezime_korisnika;
            txt_uloga.Text = Program.uloga_korisnika;
        }

        private void tsm_smerovi_Click(object sender, EventArgs e)
        {
            Sifarnik frm_sifarnik = new Sifarnik("Smer");
            frm_sifarnik.Show();
        }

        private void tsm_skolskeGodine_Click(object sender, EventArgs e)
        {
            Sifarnik frm_sifarnik = new Sifarnik("Skolska_godina");
            frm_sifarnik.Show();
        }

        private void tsm_predmeti_Click(object sender, EventArgs e)
        {
            Sifarnik frm_sifarnik = new Sifarnik("Predmet");
            frm_sifarnik.Show();
        }

        private void tsm_osobe_Click(object sender, EventArgs e)
        {
            Sifarnik frm_sifarnik = new Sifarnik("Osoba");
            frm_sifarnik.Show();
        }

        private void tsm_raspodela_Click(object sender, EventArgs e)
        {
            Raspodela frm_raspodela = new Raspodela();
            frm_raspodela.Show();
        }
    }
}
