using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GestioneScuola.SCUOLADataSet;

namespace GestioneScuola
{
    public partial class VisualizzaDB : Form
    {
        public VisualizzaDB()
        {
            InitializeComponent();
        }

        private void VisualizzaDB_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sCUOLADataSet.Studenti' table. You can move, or remove it, as needed.
            this.studentiTableAdapter.Fill(this.sCUOLADataSet.Studenti);
            // TODO: This line of code loads data into the 'sCUOLADataSet.Classi' table. You can move, or remove it, as needed.
            this.classiTableAdapter.Fill(this.sCUOLADataSet.Classi);

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null) return;
            var selectedClassId = ((comboBox1.SelectedItem as DataRowView).Row as ClassiRow).IdClasse;
            var studenti = sCUOLADataSet.Studenti.Where(s => s.IdClasse == selectedClassId).ToList();
            dataGridView1.DataSource = studenti;
        }
    }
}
