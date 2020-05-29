using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solar
{
    public partial class DBEdit : Form
    {
        private PlanetsContext db;
        public DBEdit()
        {
            InitializeComponent();

            db = new PlanetsContext();
            db.Planets.Load();

            dataGridView1.DataSource = db.Planets.Local.ToBindingList();
        }

        private void DBEdit_Load(object sender, EventArgs e)
        {
            textBoxMass.Enabled = false;
            textBoxName.Enabled = false;
            textBoxRadius.Enabled = false;
            {
                AddOnce goadd = new AddOnce();

                Action<object, EventArgs> eventHandler = goadd.AddIt;

               
            }


        }

        public void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        { 
            using (PlanetsContext db = new PlanetsContext())
            {
                db.SaveChanges();
                MessageBox.Show("Измененo");

            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            textBoxMass.Enabled = true;
            textBoxName.Enabled = true;
            textBoxRadius.Enabled = true;

        }

        private void buttonForceUpdate_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var m = decimal.Parse(textBoxMass.Text, NumberStyles.AllowExponent);
            var r = decimal.Parse(textBoxRadius.Text);
            var name = textBoxName.Text;
            var locid  = db.Planets.ToList().Count + 1;
            Planets newplan = new Planets{Id = locid, M = (double)m, Name = name, R = (double)r};
            db.Planets.Add(newplan);
            

        }

        private void comboBox1_MouseMove(object sender, MouseEventArgs e)
        {
            SpdCount cmb = new SpdCount();
            cmb.ShowDada();

        }
    }
}
