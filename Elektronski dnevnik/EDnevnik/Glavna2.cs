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
    public partial class Glavna2 : Form
    {
        public Glavna2()
        {
            InitializeComponent();
        }

        private void Glavna2_Load(object sender, EventArgs e)
        {
            txt_ime.Text = Program.ime_korisnika;
            txt_prezime.Text = Program.prezime_korisnika;
            txt_uloga.Text = Program.uloga_korisnika;
        }        

        private void расподелаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Raspodela frm_raspodela = new Raspodela();
            frm_raspodela.Show();
        }        

        private void оценеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ocena frm_ocena = new Ocena();
            frm_ocena.Show();
        }

        private void уписницеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Upisnica frm_upisnica = new Upisnica();
            frm_upisnica.Show();
        }

        private void особеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Osoba frm_osoba = new Osoba();
            frm_osoba.Show();
        }

        private void смеровиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sifarnik frm_smer = new Sifarnik("Smer");
            frm_smer.Show();
        }

        private void школскеГодинеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sifarnik frm_godine = new Sifarnik("Skolska_godina");
            frm_godine.Show();
        }

        private void предметиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sifarnik frm_predmeti = new Sifarnik("Predmet");
            frm_predmeti.Show();
        }

        private void Glavna2_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
