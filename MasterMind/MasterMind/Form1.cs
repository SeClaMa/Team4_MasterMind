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
        List<PictureBox> arrayPicColoresDisp = new List<PictureBox>(); // lista de los 4 colores definitivos a elegir
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
        int contador = 0;
        Utilidades U1 = new Utilidades();

        string dificultad = "";
        
        public Form1()
        {
            InitializeComponent();
        }

        public void IniciarJuego()
        {
            
            U1.LimpiarListas(arrayColores,numRepe,arrayPicColoresDisp,arrayPicColoresSol,resultados1,resultados2, resultados3, resultados4, resultados5, resultados6, resultados7, resultados8, resultados9, resultados10);
            U1.LimpiarListasComp(comprobacion1, comprobacion2, comprobacion3, comprobacion4, comprobacion5, comprobacion6, comprobacion7, comprobacion8, comprobacion9, comprobacion10);
            U1.RellenarListas(resultados1,sol1_1,sol1_2,sol1_3,sol1_4,sol1_5,sol1_6);
            U1.RellenarListas(resultados2, sol2_1, sol2_2, sol2_3, sol2_4, sol2_5, sol2_6);
            U1.RellenarListas(resultados3, sol3_1, sol3_2, sol3_3, sol3_4, sol3_5, sol3_6);
            U1.RellenarListas(resultados4, sol4_1, sol4_2, sol4_3, sol4_4, sol4_5, sol4_6);
            U1.RellenarListas(resultados5, sol5_1, sol5_2, sol5_3, sol5_4, sol5_5, sol5_6);
            U1.RellenarListas(resultados6, sol6_1, sol6_2, sol6_3, sol6_4, sol6_5, sol6_6);
            U1.RellenarListas(resultados7, sol7_1, sol7_2, sol7_3, sol7_4, sol7_5, sol7_6);
            U1.RellenarListas(resultados8, sol8_1, sol8_2, sol8_3, sol8_4, sol8_5, sol8_6);
            U1.RellenarListas(resultados9, sol9_1, sol9_2, sol9_3, sol9_4, sol9_5, sol9_6);
            U1.RellenarListas(resultados10, sol10_1, sol10_2, sol10_3, sol10_4, sol10_5, sol10_6);


            U1.RellenarListas(comprobacion1, comp1_1, comp1_2, comp1_3, comp1_4, comp1_5, comp1_6);
            U1.RellenarListas(comprobacion2, comp2_1, comp2_2, comp2_3, comp2_4, comp2_5, comp2_6);
            U1.RellenarListas(comprobacion3, comp3_1, comp3_2, comp3_3, comp3_4, comp3_5, comp3_6);
            U1.RellenarListas(comprobacion4, comp4_1, comp4_2, comp4_3, comp4_4, comp4_5, comp4_6);
            U1.RellenarListas(comprobacion5, comp5_1, comp5_2, comp5_3, comp5_4, comp5_5, comp5_6);
            U1.RellenarListas(comprobacion6, comp6_1, comp6_2, comp6_3, comp6_4, comp6_5, comp6_6);
            U1.RellenarListas(comprobacion7, comp7_1, comp7_2, comp7_3, comp7_4, comp7_5, comp7_6);
            U1.RellenarListas(comprobacion8, comp8_1, comp8_2, comp8_3, comp8_4, comp8_5, comp8_6);
            U1.RellenarListas(comprobacion9, comp9_1, comp9_2, comp9_3, comp9_4, comp9_5, comp9_6);
            U1.RellenarListas(comprobacion10, comp10_1, comp10_2, comp10_3, comp10_4, comp10_5, comp10_6);


            Form2 f2 = new Form2();
            f2.ShowDialog();
            dificultad = f2.dif;
            CrearColores();
            IniciarDificultad();


            foreach (PictureBox p in resultados1)
            {
                p.BackColor = Color.White;
            }

            foreach (PictureBox p in comprobacion1)
            {
                p.BackColor = Color.White;
                p.Show();
            }
            U1.HideWhiteListas(resultados2);
            U1.HideWhiteListas(resultados3);
            U1.HideWhiteListas(resultados4);
            U1.HideWhiteListas(resultados5);
            U1.HideWhiteListas(resultados6);
            U1.HideWhiteListas(resultados7);
            U1.HideWhiteListas(resultados8);
            U1.HideWhiteListas(resultados9);
            U1.HideWhiteListas(resultados10);

            U1.HideWhiteListas(comprobacion2);
            U1.HideWhiteListas(comprobacion3);
            U1.HideWhiteListas(comprobacion4);
            U1.HideWhiteListas(comprobacion5);
            U1.HideWhiteListas(comprobacion6);
            U1.HideWhiteListas(comprobacion7);
            U1.HideWhiteListas(comprobacion8);
            U1.HideWhiteListas(comprobacion9);
            U1.HideWhiteListas(comprobacion10);


            U1.UnlockLista(resultados1);
            U1.UnlockLista(resultados2);
            U1.UnlockLista(resultados3);
            U1.UnlockLista(resultados4);
            U1.UnlockLista(resultados5);
            U1.UnlockLista(resultados6);
            U1.UnlockLista(resultados7);
            U1.UnlockLista(resultados8);
            U1.UnlockLista(resultados9);
            U1.UnlockLista(resultados10);

            button1.Show();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button6.Hide();
            button7.Hide();
            button8.Hide();
            button9.Hide();
            button10.Hide();

        }

        public void CrearColores()
        {
            arrayPicColoresDisp.Add(pic_disp1);
            arrayPicColoresDisp.Add(pic_disp2);
            arrayPicColoresDisp.Add(pic_disp3);
            arrayPicColoresDisp.Add(pic_disp4);

            if(dificultad == "intermedio")
            {
                arrayPicColoresDisp.Add(pic_disp5);
            }

            else if (dificultad == "avanzado")
            {
                arrayPicColoresDisp.Add(pic_disp5);
                arrayPicColoresDisp.Add(pic_disp6);
            }



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

            arrayPicColoresSol.Add(pic_sec1);
            arrayPicColoresSol.Add(pic_sec2);
            arrayPicColoresSol.Add(pic_sec3);
            arrayPicColoresSol.Add(pic_sec4);

            if (dificultad == "intermedio")
            {
                arrayPicColoresSol.Add(pic_sec5);
                pic_sec5.Show();
                pic_disp5.Show();

                pic_sec6.Hide();
                pic_disp6.Hide();
            }

            else if (dificultad == "avanzado")
            {
                arrayPicColoresSol.Add(pic_sec5);
                arrayPicColoresSol.Add(pic_sec6);
            }
            else if (dificultad == "principiante")
            {
                pic_sec5.Hide();
                pic_sec6.Hide();
                pic_disp5.Hide();
                pic_disp6.Hide();
            }
            
            

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

        public void IniciarDificultad()
        {
            switch (dificultad)
            {
                case "principiante":
                    U1.NivelPrincipiante(resultados1);
                    U1.NivelPrincipiante(resultados2);
                    U1.NivelPrincipiante(resultados3);
                    U1.NivelPrincipiante(resultados4);
                    U1.NivelPrincipiante(resultados5);
                    U1.NivelPrincipiante(resultados6);
                    U1.NivelPrincipiante(resultados7);
                    U1.NivelPrincipiante(resultados8);
                    U1.NivelPrincipiante(resultados9);
                    U1.NivelPrincipiante(resultados10);
                    /*  */
                    U1.NivelPrincipiante(comprobacion1);
                    U1.NivelPrincipiante(comprobacion2);
                    U1.NivelPrincipiante(comprobacion3);
                    U1.NivelPrincipiante(comprobacion4);
                    U1.NivelPrincipiante(comprobacion5);
                    U1.NivelPrincipiante(comprobacion6);
                    U1.NivelPrincipiante(comprobacion7);
                    U1.NivelPrincipiante(comprobacion8);
                    U1.NivelPrincipiante(comprobacion9);
                    U1.NivelPrincipiante(comprobacion10);

                     
                    break;
                case "intermedio":
                    U1.NivelIntermedio(resultados1);
                    U1.NivelIntermedio(comprobacion1);
                    U1.NivelIntermedio(resultados2);
                    U1.NivelIntermedio(comprobacion2);
                    U1.NivelIntermedio(resultados3);
                    U1.NivelIntermedio(comprobacion3);
                    U1.NivelIntermedio(resultados4);
                    U1.NivelIntermedio(comprobacion4);
                    U1.NivelIntermedio(resultados5);
                    U1.NivelIntermedio(comprobacion5);
                    U1.NivelIntermedio(resultados6);
                    U1.NivelIntermedio(comprobacion6);
                    U1.NivelIntermedio(resultados7);
                    U1.NivelIntermedio(comprobacion7);
                    U1.NivelIntermedio(resultados8);
                    U1.NivelIntermedio(comprobacion8);
                    U1.NivelIntermedio(resultados9);
                    U1.NivelIntermedio(comprobacion9);
                    U1.NivelIntermedio(resultados10);
                    U1.NivelIntermedio(comprobacion10);

                    resultados1[4].Show();
                    comprobacion1[4].Show();

                   break;

                case "avanzado":
                    resultados1[4].Show();
                    resultados1[5].Show();

                    comprobacion1[4].Show();
                    comprobacion1[5].Show();

                    arrayPicColoresDisp[4].Show();
                    arrayPicColoresDisp[5].Show();

                    arrayPicColoresSol[4].Show();
                    arrayPicColoresSol[5].Show();


                    break;

                default:
                    break;
            }
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

        private void sol1_5_Click(object sender, EventArgs e)
        {
            contador = U1.ReiniciarContador(contador, arrayPicColoresDisp);
            sol1_5.BackColor = arrayPicColoresDisp[contador].BackColor;

            contador++;
        }
        private void sol1_6_Click(object sender, EventArgs e)
        {
            contador = U1.ReiniciarContador(contador, arrayPicColoresDisp);
            sol1_6.BackColor = arrayPicColoresDisp[contador].BackColor;

            contador++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(U1.ComprobarSolucionBlancos(resultados1, arrayPicColoresDisp) == true){
                U1.ComprobarSolucion(resultados1, arrayPicColoresSol,comprobacion1);

            }
            else
            {
                MessageBox.Show("Faltan colores");

            }
            U1.CambioTurno(button1, button2, resultados1, resultados2, comprobacion2);
        }

       
    }
}
