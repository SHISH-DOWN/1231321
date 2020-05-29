using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Solar
{
    public partial class SpdCount : Form
    
    {
        private static double _h;
        private static double _m;
        private static double _r;
        private static double _v1;
        private static double _v2;

        private const double G = 6.65e+6;

        public SpdCount()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            ShowDada();
        }

        private List<Planets> GetPlanetData()
        {
            using (var db = new PlanetsContext())
            {
                var planets = db.Planets.ToList();
                return planets;
            }
        }

        public void ShowDada()
        {
            comboBox1.DataSource = GetPlanetData();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
        }
        private void ButtonGD_Click(object sender, EventArgs e)
        {
            var planets = GetPlanetData();
            _h = double.Parse(textBoxHeight.Text);
            var id = int.Parse(comboBox1.SelectedValue.ToString());
            _m = planets.FirstOrDefault(f => f.Id == id).M;
            _r = planets.FirstOrDefault(f => f.Id == id).R;
        }

        private void ButtonUList_Click(object sender, EventArgs e)
        {
            ShowDada();
        }

        
       

        private void ButtonC_Click(object sender, EventArgs e)
        {
             _v1 = Math.Sqrt(G*_m/(_r+_h));
             _v2 = _v1*Math.Sqrt(2);
            textBoxVel1.Text = _v1.ToString();
            textBoxVel2.Text = _v2.ToString();
        }

        private void buttonUpData_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void buttonUpData_Click_1(object sender, EventArgs e)
        {
            var fm2 = new DBEdit();
            fm2.Show();
        }
    }
}
