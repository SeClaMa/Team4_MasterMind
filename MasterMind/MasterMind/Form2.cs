using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterMind
{
    public partial class Form2 : Form
    {
        public string dif = "";

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                dif = "principiante";
            }

            else if (radioButton2.Checked)
            {
                dif = "intermedio";
            }

            else if (radioButton3.Checked)
            {
                dif = "avanzado";
            }

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dif = "principiante";

            this.Hide();
        }
    }
}
