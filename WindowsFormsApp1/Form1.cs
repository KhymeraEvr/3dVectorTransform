using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1._3DVectorTransform;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<Operation> ops = new List<Operation>
            {
                new Operation {ID = 1, Name = "Translate"},
                new Operation {ID = 2, Name = "Scale"},
                new Operation {ID = 3, Name = "Turn around X axis"},
                new Operation {ID = 4, Name = "Turn around Y axis"},
                new Operation {ID = 5, Name = "Turn around Z axis"},
                new Operation {ID = 6, Name = "Reflect into ZoY"},
                new Operation {ID = 7, Name = "Reflect into YoX"},
                new Operation {ID = 8, Name = "Reflect into XoZ"}
            };
            comboBox1.DataSource = ops;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            int y = Convert.ToInt32(textBox2.Text);
            int z = Convert.ToInt32(textBox3.Text);

            double angle = Convert.ToDouble(textBox4.Text);

            string operId = (comboBox1.SelectedIndex+1).ToString();
            TransformMatrix mt = new TransformMatrix();            

            switch (operId)
            {
                case "1":
                    Console.WriteLine("Input translate values");
                    mt.Translation(x,y,z);
                    break;
                case "2":
                    Console.WriteLine("Input Scaling values");
                    mt.Scaling(x, y, z);
                    break;
                case "3":
                    Console.WriteLine("Input turn angle");
                    angle = Convert.ToDouble(Console.ReadLine());
                    mt.XTurn(angle);
                    break;
                case "4":
                    Console.WriteLine("Input turn angle");
                    angle = Convert.ToDouble(Console.ReadLine());
                    mt.YTurn(angle);
                    break;
                case "5":
                    Console.WriteLine("Input turn angle");
                    angle = Convert.ToDouble(Console.ReadLine());
                    mt.ZTurn(angle);
                    break;
                case "6":
                    mt.XoZMirror();
                    break;
                case "7":
                    mt.ZoYMirror();
                    break;
                case "8":
                    mt.YoXMirror();
                    break;
            }

            int basex = Convert.ToInt32(textBox7.Text);
            int basey = Convert.ToInt32(textBox6.Text);
            int basez = Convert.ToInt32(textBox5.Text);
            _3DVector vc = new _3DVector(basex,basey,basez);
            mt.Transform(ref vc);

            label4.Text = vc.X.ToString();
            label5.Text = vc.Y.ToString();
            label6.Text = vc.Z.ToString();

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
