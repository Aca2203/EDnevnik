﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EDnevnik
{
    public partial class Sifarnik : Form
    {
        DataTable tabela;
        SqlDataAdapter adapter;
        string ime_tabele;
        public Sifarnik(string tabela)
        {
            ime_tabele = tabela;
            InitializeComponent();
        }

        private void Sifarnik_Load(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter("SELECT * FROM " + ime_tabele, Konekcija.Povezi());
            tabela = new DataTable();
            adapter.Fill(tabela);
            dataGridView1.DataSource = tabela;
            dataGridView1.Columns["id"].ReadOnly = true;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            DataTable menjano = tabela.GetChanges();
            adapter.UpdateCommand = new SqlCommandBuilder(adapter).GetUpdateCommand();
            if (menjano != null)
            {
                try
                {
                    adapter.Update(menjano);
                }
                catch (Exception greska)
                {
                    MessageBox.Show(greska.Message);
                }
            }
            this.Close();
        }
    }
}
