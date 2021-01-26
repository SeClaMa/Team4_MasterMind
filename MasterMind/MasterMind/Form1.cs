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

        Color[] arrayColores = new Color [10]; //paleta 10 colores random
        List<int> numRepe = new List<int>(); //controlar que no se repita ningún color en la paleta
        List <PictureBox> arrayPicColoresDisp = new List<PictureBox>(); // lista de los 4 colores definitivos a elegir
        List<PictureBox> arrayPicColoresSol = new List<PictureBox>(); // lista de la solución
        List<PictureBox> resultados1 = new List<PictureBox>(); // propuesta solución 1
        List<PictureBox> resultados2 = new List<PictureBox>(); // propuesta solución 2
        List<PictureBox> resultados3 = new List<PictureBox>(); // propuesta solución 3
        List<PictureBox> resultados4 = new List<PictureBox>(); // propuesta solución 4
        List<PictureBox> resultados5 = new List<PictureBox>(); // propuesta solución 5
        List<PictureBox> resultados6 = new List<PictureBox>(); // propuesta solución 6
        List<PictureBox> resultados7 = new List<PictureBox>(); // propuesta solución 7
        List<PictureBox> resultados8 = new List<PictureBox>(); // propuesta solución 8
        List<PictureBox> resultados9 = new List<PictureBox>(); // propuesta solución 9
        List<PictureBox> resultados10 = new List<PictureBox>(); // propuesta solución 10

        List<PictureBox> comprobacion1 = new List<PictureBox>(); // comp. solución 1
        List<PictureBox> comprobacion2 = new List<PictureBox>(); // comp. solución 2
        List<PictureBox> comprobacion3 = new List<PictureBox>(); // comp. solución 3
        List<PictureBox> comprobacion4 = new List<PictureBox>(); // comp. solución 4
        List<PictureBox> comprobacion5 = new List<PictureBox>(); // comp. solución 5
        List<PictureBox> comprobacion6 = new List<PictureBox>(); // comp. solución 6
        List<PictureBox> comprobacion7 = new List<PictureBox>(); // comp. solución 7
        List<PictureBox> comprobacion8 = new List<PictureBox>(); // comp. solución 8
        List<PictureBox> comprobacion9 = new List<PictureBox>(); // comp. solución 9
        List<PictureBox> comprobacion10 = new List<PictureBox>(); // comp. solución 10
        int contador_turno = 1;
        int contador = 0;
        Utilidades U1 = new Utilidades();
        
        public Form1()
        {
            InitializeComponent();
        }

        public void IniciarJuego()
        {

            U1.LimpiarListas(arrayColores,numRepe,arrayPicColoresDisp,arrayPicColoresSol,resultados1,resultados2, resultados3, resultados4, resultados5, resultados6, resultados7, resultados8, resultados9, resultados10);
            U1.RellenarListas(resultados1,sol1_1,sol1_2,sol1_3,sol1_4);
            U1.RellenarListas(comprobacion1, comp1_1, comp1_2, comp1_3, comp1_4);

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

                if (i != 0)
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



        private void sol1_1_Click(object sender, EventArgs e)
        {
            contador=U1.ReiniciarContador(contador,arrayPicColoresDisp);

            sol1_1.BackColor = arrayPicColoresDisp[contador].BackColor;

            contador++;
        }

        private void sol1_2_Click(object sender, EventArgs e)
        {
            contador = U1.ReiniciarContador(contador, arrayPicColoresDisp);

            sol1_2.BackColor = arrayPicColoresDisp[contador].BackColor;

            contador++;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sol1_3_Click(object sender, EventArgs e)
        {
            contador = U1.ReiniciarContador(contador, arrayPicColoresDisp);

            sol1_3.BackColor = arrayPicColoresDisp[contador].BackColor;

            contador++;
        }

        private void sol1_4_Click(object sender, EventArgs e)
        {
            contador = U1.ReiniciarContador(contador, arrayPicColoresDisp);
            sol1_4.BackColor = arrayPicColoresDisp[contador].BackColor;

            contador++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(U1.ComprobarSolucionBlancos(resultados1, arrayPicColoresDisp) == true){
                U1.ComprobarSolucion(resultados1, arrayPicColoresSol);
            }
            else
            {
                MessageBox.Show("Faltan colores");

            }

            /*
            button1.Hide();
            contador_turno++;
            button2.Show();
            */
        }

       

    }
}
