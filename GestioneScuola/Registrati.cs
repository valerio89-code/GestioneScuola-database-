using GestioneScuola.SCUOLADataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestioneScuola
{
    public partial class Registrati : Form
    {
        public Registrati()
        {
            InitializeComponent();
        }

        private void btn_registrati_Click(object sender, EventArgs e)
        {
            var userName = tbx_username.Text;
            var psw = tbx_password.Text;
            using (var sqlAdapter = new UtentiTableAdapter())
            {
                var dt = sqlAdapter.GetData();
                var existingUser = dt.Select($"UserName = '{userName}'").FirstOrDefault();
                if(existingUser != null)
                {
                    MessageBox.Show("UTENTE GIà PRESENTE");
                    return;
                }
                sqlAdapter.Insert(userName, psw);
                MessageBox.Show("registrazione effettuata con successo");
                Close();
            }
        }
    }
}
