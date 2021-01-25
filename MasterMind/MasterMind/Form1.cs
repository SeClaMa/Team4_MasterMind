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
    public partial class Form1 : Form
    {

        Color[] arrayColores = new Color [10];
        List <PictureBox> arrayPicColoresDisp = new List<PictureBox>();
        List<PictureBox> arrayPicColoresSol = new List<PictureBox>();
        public Form1()
        {
            InitializeComponent();
        }

        public void IniciarJuego()
        {
            CrearColores();
        }

        public void CrearColores()
        {
            arrayPicColoresDisp.Add(pictureBox1);
            arrayPicColoresDisp.Add(pictureBox2);
            arrayPicColoresDisp.Add(pictureBox3);
            arrayPicColoresDisp.Add(pictureBox4);

            Random colorRand = new Random();

            Color C = Color.White;

            

            for (int i = 0; i < arrayColores.Length; i++)
            {
                C = Color.FromArgb(colorRand.Next(0, 256), colorRand.Next(0, 256), colorRand.Next(0, 256));
                arrayColores[i] = C;
            }
            foreach (PictureBox P in arrayPicColoresDisp)
            {
                P.BackColor = arrayColores[colorRand.Next(0, arrayColores.Length)];
            }
            

        }

        private void nuevoJuegoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IniciarJuego();
        }
    }
}
