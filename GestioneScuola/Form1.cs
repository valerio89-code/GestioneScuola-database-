using GestioneScuola.Code;
using GestioneScuola.SCUOLADataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestioneScuola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            var username = tbx_username.Text;
            var password = tbx_password.Text;

            using (var sqlAdapter = new UtentiTableAdapter())
            {
                var dt = new SCUOLADataSet.UtentiDataTable();
                sqlAdapter.Fill(dt);
                var utentiFiltrati = dt.Select($"UserName = '{username}'").Cast<SCUOLADataSet.UtentiRow>();
                var utente = utentiFiltrati.FirstOrDefault();
                if (utente == null)
                {
                    MessageBox.Show("utente non trovato");
                    return;
                }

                if (utente.Password == password)
                {
                    MessageBox.Show("login avvenuto con successo!");
                    var formVisualizza = new VisualizzaDB();
                    formVisualizza.ShowDialog();
                }
                else
                {
                    MessageBox.Show("password errata");
                }
            }

        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            var f = new Registrati();
            f.ShowDialog();
        }
    }
}
