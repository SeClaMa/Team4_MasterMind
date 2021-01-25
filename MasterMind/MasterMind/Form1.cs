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
        List<int> numRepe = new List<int>();
        List <PictureBox> arrayPicColoresDisp = new List<PictureBox>();
        List<PictureBox> arrayPicColoresSol = new List<PictureBox>();

        int contador = 0;
        public Form1()
        {
            InitializeComponent();
        }

        public void IniciarJuego()
        {
            numRepe.Clear();
            arrayPicColoresDisp.Clear();
            arrayPicColoresSol.Clear();
            Array.Clear(arrayColores, 0, arrayColores.Length);
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

            bool repetido = false;
            int num_random = 0;


            //Creacion array para poder crear los colores disponibles aleatoriamente
            for (int i = 0; i < arrayColores.Length; i++)
            {
                C = Color.FromArgb(colorRand.Next(0, 256), colorRand.Next(0, 256), colorRand.Next(0, 256));
                arrayColores[i] = C;
            }

            //Creacion de colores disponibles sin repetir
            for (int i = 0; i < arrayPicColoresDisp.Count; i++)
            {
                num_random = colorRand.Next(0, arrayColores.Length);
                repetido = false;

                if (i!= 0) 
                {
                    while (!repetido)
                    {
                        if (numRepe.Contains(num_random))
                        {
                            num_random = colorRand.Next(0, arrayColores.Length);
                        }

                        else
                        {
                            numRepe.Add(num_random);
                            repetido = true;
                        }
                    }
                }

                else
                {
                    numRepe.Add(num_random);
                }
                arrayPicColoresDisp[i].BackColor = arrayColores[num_random];
            }

            arrayPicColoresSol.Add(pictureBox5);
            arrayPicColoresSol.Add(pictureBox6);
            arrayPicColoresSol.Add(pictureBox7);
            arrayPicColoresSol.Add(pictureBox8);

            //Creacion combinación secreta
            foreach (PictureBox p in arrayPicColoresSol)
            {
                num_random = colorRand.Next(0, arrayPicColoresDisp.Count);

                p.BackColor = arrayPicColoresDisp[num_random].BackColor;
            }
        }

        private void nuevoJuegoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IniciarJuego();
        }

        public void ReiniciarContador()
        {
            if(contador >= arrayPicColoresDisp.Count)
            {
                contador = 0;
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            ReiniciarContador();

            pictureBox9.BackColor = arrayPicColoresDisp[contador].BackColor;

            contador++;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            ReiniciarContador();

            pictureBox10.BackColor = arrayPicColoresDisp[contador].BackColor;

            contador++;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
