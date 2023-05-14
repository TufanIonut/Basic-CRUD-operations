using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_db
{
    public partial class Form1 : Form
    {
        public CNSHEntities sc { get; set; }
        public Form1()
        {
            InitializeComponent();
            sc = new CNSHEntities();
        }

        private void adaugare_Click(object sender, EventArgs e)
        {
            string nClasa = txt_numeClasa.Text.Trim();
            int nElevi = int.Parse(txt_nrElevi.Text.Trim());
            Clase clasaNoua = new Clase();
            bool existaClasa = sc.Clase.Any(x => x.nume_clasa == nClasa);

            clasaNoua.nume_clasa = nClasa;
            clasaNoua.nr_elevi = nElevi;

            //sc.CLases.FirstOrDefault(sc.CLases.Any(x => x.Nume_clasa == nClasa));
            if (existaClasa)
            {
                MessageBox.Show("clasa exista deja in baza de date");
            }
            else
            {
                if (nElevi > 15 && nElevi < 40)
                {
                    sc.Clase.Add(clasaNoua);
                    MessageBox.Show("date introduse cu succes");
                }
                else
                {
                    MessageBox.Show("Numarul de elevi nu e corect");
                }
            }
            sc.SaveChanges();
            claseBindingSource.DataSource = sc.Clase.ToList();
            txt_nrElevi.Clear();
            txt_numeClasa.Clear();
            txt_numeClasa.Focus();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cNSHDataSet.Clase' table. You can move, or remove it, as needed.
            this.claseTableAdapter.Fill(this.cNSHDataSet.Clase);
            claseBindingSource.DataSource = sc.Clase.ToList();
        }

        private void stergere_Click(object sender, EventArgs e)
        {
            sc.Clase.Attach(claseBindingSource.Current as Clase);
            sc.Clase.Remove(claseBindingSource.Current as Clase) ;
            sc.Entry(claseBindingSource.Current as Clase).State = System.Data.Entity.EntityState.Deleted;
            sc.SaveChanges();
            claseBindingSource.DataSource = sc.Clase.ToList();
        }
    }
}

