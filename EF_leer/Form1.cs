    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

namespace EF_leer
{
    public partial class Form1 : Form
    {
        krankenhausEntities1 daten = new krankenhausEntities1();
        public Form1()
        {
            InitializeComponent();

            terminBindingSource.DataSource = daten.termin.ToList();
            raumBindingSource.DataSource = daten.raum.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Hinzufügen & Speichern Termin
            var aktuell = terminBindingSource.Current as termin;
            daten.termin.Add(aktuell);
            daten.SaveChanges();

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            // Hinzufügen von Terminen
            
            if (terminBindingSource.Current != null)
            {
                termin termine1 = terminBindingSource.Current as termin;
                daten.termin.Add(termine1);
                daten.SaveChanges();

                terminBindingSource.DataSource = daten.termin.ToList();
                daten.SaveChanges();
            }
            else
            {
                terminBindingSource.AddNew();
                terminBindingSource.MoveLast();
                MessageBox.Show("Test");
            }

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            var termine1 = terminBindingSource.Current as termin;

            daten.termin.Remove(termine1);
            daten.SaveChanges();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            daten.SaveChanges();

        }
    }
}