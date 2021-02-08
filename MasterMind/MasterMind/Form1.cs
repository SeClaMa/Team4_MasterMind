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

        int contador = 0; //contador para saber que color ir poniendo en cada picture box

        Utilidades U1 = new Utilidades(); // se crea objeto utilidades

        string dificultad = ""; // para guardar el nivel de dificultad
        
        public Form1()
        {
            InitializeComponent();
        }

        public void IniciarJuego()
        {
            
            U1.LimpiarListas(arrayColores,numRepe,arrayPicColoresDisp,arrayPicColoresSol,resultados1,resultados2, resultados3, resultados4, resultados5, resultados6, resultados7, resultados8, resultados9, resultados10);//reseteo soluciones
            U1.LimpiarListasComp(comprobacion1, comprobacion2, comprobacion3, comprobacion4, comprobacion5, comprobacion6, comprobacion7, comprobacion8, comprobacion9, comprobacion10);//reseteo comprobaciones
            /* relleno las distintas listas de resultados con sus picture box correspondientes */
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

            /* relleno las distintas listas de comprobaciones con sus picture box correspondientes */
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

            // llamo a la ventana del nivel
            Form2 f2 = new Form2();
            f2.ShowDialog();


            dificultad = f2.dif; //capturo el nivel de dificultad
            CrearColores(); //llamo al metodo que crea la paleta de colores
            IniciarDificultad(); //metodo dificultad, que oculta o muestra cosas según el nivel

            //muetro la primera solución y la primera comprobación
            foreach (PictureBox p in resultados1)
            {
                p.BackColor = Color.White;
            }

            foreach (PictureBox p in comprobacion1)
            {
                p.BackColor = Color.White;
                p.Show();
            }
            /* oculto el resto de soluciones*/
            U1.HideWhiteListas(resultados2);
            U1.HideWhiteListas(resultados3);
            U1.HideWhiteListas(resultados4);
            U1.HideWhiteListas(resultados5);
            U1.HideWhiteListas(resultados6);
            U1.HideWhiteListas(resultados7);
            U1.HideWhiteListas(resultados8);
            U1.HideWhiteListas(resultados9);
            U1.HideWhiteListas(resultados10);

            /* oculto el resto de comprobaciones*/
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

            /*oculto todos los botones menos el primero*/
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

            esconderLista.Hide(); //pongo una solapa para ocultar todo cuando se inicia la app
        }

        public void CrearColores()
        {
            /* metodo para crear la paleta de colores, que se guardan en una lista de tipo picture box */
            arrayPicColoresDisp.Add(pic_disp1);
            arrayPicColoresDisp.Add(pic_disp2);
            arrayPicColoresDisp.Add(pic_disp3);
            arrayPicColoresDisp.Add(pic_disp4);

            /* dependiendo del nivel de dificultad, la paleta de colores tendra 4, 5 o 6 colores*/

            if(dificultad == "intermedio")
            {
                arrayPicColoresDisp.Add(pic_disp5);
            }

            else if (dificultad == "avanzado")
            {
                arrayPicColoresDisp.Add(pic_disp5);
                arrayPicColoresDisp.Add(pic_disp6);
            }



            Random colorRand = new Random(); //variable para coger colores aleatorios

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

            //inicializo la lista de picture box de la solución, que dependiendo del nivel de dificultad tendrá 4, 5 o 6 casillas
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
            
            

            //Creacion combinación secreta recorriendo la lista de la solución
            foreach (PictureBox p in arrayPicColoresSol)
            {
                num_random = colorRand.Next(0, arrayPicColoresDisp.Count);

                p.BackColor = arrayPicColoresDisp[num_random].BackColor;
            }
        }


        private void nuevoJuegoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IniciarJuego(); // cuando pincha en el botón nuevo juego llamo al metodo iniciar juego
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void IniciarDificultad()
        {
            switch (dificultad)
            {
                /* si es principiante llamo a metodo que oculta la casilla 5 y 6 de cada solución
                 * y de cada comprobación*/
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
                    /* si es intermedio llamo a metodo que oculta la casilla  6 de cada solución
             * y de cada comprobación*/
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
                    

                    resultados1[4].Show();
                    comprobacion1[4].Show();

                   break;

                case "avanzado":
                    /*nivel avanzado muetro la casilla 5 y 6 de todo*/
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




        #region Solucion Buttons

        /* al pinchar en cada picture box de selección de color hago lo siguiente:
         * - inicio el contador
         * - cambio el color
         * - aumento el contador
         * */
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


        private void sol2_1_Click(object sender, EventArgs e)
        {
            contador = U1.ReiniciarContador(contador, arrayPicColoresDisp);
            sol2_1.BackColor = arrayPicColoresDisp[contador].BackColor;

            contador++;
        }

        private void sol2_2_Click(object sender, EventArgs e)
        {
            contador = U1.ReiniciarContador(contador, arrayPicColoresDisp);
            sol2_2.BackColor = arrayPicColoresDisp[contador].BackColor;

            contador++;
        }

        private void sol2_3_Click(object sender, EventArgs e)
        {
            contador = U1.ReiniciarContador(contador, arrayPicColoresDisp);
            sol2_3.BackColor = arrayPicColoresDisp[contador].BackColor;

            contador++;
        }

        private void sol2_4_Click(object sender, EventArgs e)
        {
            contador = U1.ReiniciarContador(contador, arrayPicColoresDisp);
            sol2_4.BackColor = arrayPicColoresDisp[contador].BackColor;

            contador++;
        }

        private void sol2_5_Click(object sender, EventArgs e)
        {
            contador = U1.ReiniciarContador(contador, arrayPicColoresDisp);
            sol2_5.BackColor = arrayPicColoresDisp[contador].BackColor;

            contador++;
        }

        private void sol2_6_Click(object sender, EventArgs e)
        {
            contador = U1.ReiniciarContador(contador, arrayPicColoresDisp);
            sol2_6.BackColor = arrayPicColoresDisp[contador].BackColor;

            contador++;
        }

        private void sol3_1_Click(object sender, EventArgs e)
        {
            contador = U1.ReiniciarContador(contador, arrayPicColoresDisp);
            sol3_1.BackColor = arrayPicColoresDisp[contador].BackColor;

            contador++;
        }

        private void sol3_2_Click(object sender, EventArgs e)
        {
            contador = U1.ReiniciarContador(contador, arrayPicColoresDisp);
            sol3_2.BackColor = arrayPicColoresDisp[contador].BackColor;

            contador++;
        }

        private void sol3_3_Click(object sender, EventArgs e)
        {
            contador = U1.ReiniciarContador(contador, arrayPicColoresDisp);
            sol3_3.BackColor = arrayPicColoresDisp[contador].BackColor;

            contador++;
        }

        private void sol3_4_Click(object sender, EventArgs e)
        {
            contador = U1.ReiniciarContador(contador, arrayPicColoresDisp);
            sol3_4.BackColor = arrayPicColoresDisp[contador].BackColor;

            contador++;
        }

        private void sol3_5_Click(object sender, EventArgs e)
        {
            contador = U1.ReiniciarContador(contador, arrayPicColoresDisp);
            sol3_5.BackColor = arrayPicColoresDisp[contador].BackColor;

            contador++;
        }

        private void sol3_6_Click(object sender, EventArgs e)
        {
            contador = U1.ReiniciarContador(contador, arrayPicColoresDisp);
            sol3_6.BackColor = arrayPicColoresDisp[contador].BackColor;

            contador++;
        }

        private void sol4_1_Click(object sender, EventArgs e)
        {
            contador = U1.ReiniciarContador(contador, arrayPicColoresDisp);
            sol4_1.BackColor = arrayPicColoresDisp[contador].BackColor;

            contador++;
        }

        private void sol4_2_Click(object sender, EventArgs e)
        {
            contador = U1.ReiniciarContador(contador, arrayPicColoresDisp);
            sol4_2.BackColor = arrayPicColoresDisp[contador].BackColor;

            contador++;
        }

        private void sol4_3_Click(object sender, EventArgs e)
        {
            contador = U1.ReiniciarContador(contador, arrayPicColoresDisp);
            sol4_3.BackColor = arrayPicColoresDisp[contador].BackColor;

            contador++;
        }

        private void sol4_4_Click(object sender, EventArgs e)
        {
            contador = U1.ReiniciarContador(contador, arrayPicColoresDisp);
            sol4_4.BackColor = arrayPicColoresDisp[contador].BackColor;

            contador++;
        }

        private void sol4_5_Click(object sender, EventArgs e)
        {
            contador = U1.ReiniciarContador(contador, arrayPicColoresDisp);
            sol4_5.BackColor = arrayPicColoresDisp[contador].BackColor;

            contador++;
        }

        private void sol4_6_Click(object sender, EventArgs e)
        {
            contador = U1.ReiniciarContador(contador, arrayPicColoresDisp);
            sol4_6.BackColor = arrayPicColoresDisp[contador].BackColor;

            contador++;
        }

        private void sol5_1_Click(object sender, EventArgs e)
        {
            contador = U1.ReiniciarContador(contador, arrayPicColoresDisp);
            sol5_1.BackColor = arrayPicColoresDisp[contador].BackColor;

            contador++;
        }

        private void sol5_2_Click(object sender, EventArgs e)
        {
            contador = U1.ReiniciarContador(contador, arrayPicColoresDisp);
            sol5_2.BackColor = arrayPicColoresDisp[contador].BackColor;

            contador++;
        }

        private void sol5_3_Click(object sender, EventArgs e)
        {
            contador = U1.ReiniciarContador(contador, arrayPicColoresDisp);
            sol5_3.BackColor = arrayPicColoresDisp[contador].BackColor;

            contador++;
        }

        private void sol5_4_Click(object sender, EventArgs e)
        {
            contador = U1.ReiniciarContador(contador, arrayPicColoresDisp);
            sol5_4.BackColor = arrayPicColoresDisp[contador].BackColor;

            contador++;
        }

        private void sol5_5_Click(object sender, EventArgs e)
        {
            contador = U1.ReiniciarContador(contador, arrayPicColoresDisp);
            sol5_5.BackColor = arrayPicColoresDisp[contador].BackColor;

            contador++;
        }

        private void sol5_6_Click(object sender, EventArgs e)
        {
            contador = U1.ReiniciarContador(contador, arrayPicColoresDisp);
            sol5_6.BackColor = arrayPicColoresDisp[contador].BackColor;

            contador++;
        }

        private void sol6_1_Click(object sender, EventArgs e)
        {
            contador = U1.ReiniciarContador(contador, arrayPicColoresDisp);
            sol6_1.BackColor = arrayPicColoresDisp[contador].BackColor;

            contador++;
        }

        private void sol6_2_Click(object sender, EventArgs e)
        {
            contador = U1.ReiniciarContador(contador, arrayPicColoresDisp);
            sol6_2.BackColor = arrayPicColoresDisp[contador].BackColor;

            contador++;
        }

        private void sol6_3_Click(object sender, EventArgs e)
        {
            contador = U1.ReiniciarContador(contador, arrayPicColoresDisp);
            sol6_3.BackColor = arrayPicColoresDisp[contador].BackColor;

            contador++;
        }

        private void sol6_4_Click(object sender, EventArgs e)
        {
            contador = U1.ReiniciarContador(contador, arrayPicColoresDisp);
            sol6_4.BackColor = arrayPicColoresDisp[contador].BackColor;

            contador++;
        }

        private void sol6_5_Click(object sender, EventArgs e)
        {
            contador = U1.ReiniciarContador(contador, arrayPicColoresDisp);
            sol6_5.BackColor = arrayPicColoresDisp[contador].BackColor;

            contador++;
        }

        private void sol6_6_Click(object sender, EventArgs e)
        {
            contador = U1.ReiniciarContador(contador, arrayPicColoresDisp);
            sol6_6.BackColor = arrayPicColoresDisp[contador].BackColor;

            contador++;
        }

        private void sol7_1_Click(object sender, EventArgs e)
        {
            contador = U1.ReiniciarContador(contador, arrayPicColoresDisp);
            sol7_1.BackColor = arrayPicColoresDisp[contador].BackColor;

            contador++;
        }

        private void sol7_2_Click(object sender, EventArgs e)
        {
            contador = U1.ReiniciarContador(contador, arrayPicColoresDisp);
            sol7_2.BackColor = arrayPicColoresDisp[contador].BackColor;

            contador++;
        }

        private void sol7_3_Click(object sender, EventArgs e)
        {
            contador = U1.ReiniciarContador(contador, arrayPicColoresDisp);
            sol7_3.BackColor = arrayPicColoresDisp[contador].BackColor;

            contador++;
        }

        private void sol7_4_Click(object sender, EventArgs e)
        {
            contador = U1.ReiniciarContador(contador, arrayPicColoresDisp);
            sol7_4.BackColor = arrayPicColoresDisp[contador].BackColor;

            contador++;
        }

        private void sol7_5_Click(object sender, EventArgs e)
        {
            contador = U1.ReiniciarContador(contador, arrayPicColoresDisp);
            sol7_5.BackColor = arrayPicColoresDisp[contador].BackColor;

            contador++;
        }

        private void sol7_6_Click(object sender, EventArgs e)
        {
            contador = U1.ReiniciarContador(contador, arrayPicColoresDisp);
            sol7_6.BackColor = arrayPicColoresDisp[contador].BackColor;

            contador++;
        }

        private void sol8_1_Click(object sender, EventArgs e)
        {
            contador = U1.ReiniciarContador(contador, arrayPicColoresDisp);
            sol8_1.BackColor = arrayPicColoresDisp[contador].BackColor;

            contador++;
        }

        private void sol8_2_Click(object sender, EventArgs e)
        {
            contador = U1.ReiniciarContador(contador, arrayPicColoresDisp);
            sol8_2.BackColor = arrayPicColoresDisp[contador].BackColor;

            contador++;
        }

        private void sol8_3_Click(object sender, EventArgs e)
        {
            contador = U1.ReiniciarContador(contador, arrayPicColoresDisp);
            sol8_3.BackColor = arrayPicColoresDisp[contador].BackColor;

            contador++;
        }

        private void sol8_4_Click(object sender, EventArgs e)
        {
            contador = U1.ReiniciarContador(contador, arrayPicColoresDisp);
            sol8_4.BackColor = arrayPicColoresDisp[contador].BackColor;

            contador++;
        }

        private void sol8_5_Click(object sender, EventArgs e)
        {
            contador = U1.ReiniciarContador(contador, arrayPicColoresDisp);
            sol8_5.BackColor = arrayPicColoresDisp[contador].BackColor;

            contador++;
        }

        private void sol8_6_Click(object sender, EventArgs e)
        {
            contador = U1.ReiniciarContador(contador, arrayPicColoresDisp);
            sol8_6.BackColor = arrayPicColoresDisp[contador].BackColor;

            contador++;
        }

        private void sol9_1_Click(object sender, EventArgs e)
        {
            contador = U1.ReiniciarContador(contador, arrayPicColoresDisp);
            sol9_1.BackColor = arrayPicColoresDisp[contador].BackColor;

            contador++;
        }

        private void sol9_2_Click(object sender, EventArgs e)
        {
            contador = U1.ReiniciarContador(contador, arrayPicColoresDisp);
            sol9_2.BackColor = arrayPicColoresDisp[contador].BackColor;

            contador++;
        }

        private void sol9_3_Click(object sender, EventArgs e)
        {
            contador = U1.ReiniciarContador(contador, arrayPicColoresDisp);
            sol9_3.BackColor = arrayPicColoresDisp[contador].BackColor;

            contador++;
        }

        private void sol9_4_Click(object sender, EventArgs e)
        {
            contador = U1.ReiniciarContador(contador, arrayPicColoresDisp);
            sol9_4.BackColor = arrayPicColoresDisp[contador].BackColor;

            contador++;
        }

        private void sol9_5_Click(object sender, EventArgs e)
        {
            contador = U1.ReiniciarContador(contador, arrayPicColoresDisp);
            sol9_5.BackColor = arrayPicColoresDisp[contador].BackColor;

            contador++;
        }

        private void sol9_6_Click(object sender, EventArgs e)
        {
            contador = U1.ReiniciarContador(contador, arrayPicColoresDisp);
            sol9_6.BackColor = arrayPicColoresDisp[contador].BackColor;

            contador++;
        }

        private void sol10_1_Click(object sender, EventArgs e)
        {
            contador = U1.ReiniciarContador(contador, arrayPicColoresDisp);
            sol10_1.BackColor = arrayPicColoresDisp[contador].BackColor;

            contador++;
        }

        private void sol10_2_Click(object sender, EventArgs e)
        {
            contador = U1.ReiniciarContador(contador, arrayPicColoresDisp);
            sol10_2.BackColor = arrayPicColoresDisp[contador].BackColor;

            contador++;
        }

        private void sol10_3_Click(object sender, EventArgs e)
        {
            contador = U1.ReiniciarContador(contador, arrayPicColoresDisp);
            sol10_3.BackColor = arrayPicColoresDisp[contador].BackColor;

            contador++;
        }

        private void sol10_4_Click(object sender, EventArgs e)
        {
            contador = U1.ReiniciarContador(contador, arrayPicColoresDisp);
            sol10_4.BackColor = arrayPicColoresDisp[contador].BackColor;

            contador++;
        }

        private void sol10_5_Click(object sender, EventArgs e)
        {
            contador = U1.ReiniciarContador(contador, arrayPicColoresDisp);
            sol10_5.BackColor = arrayPicColoresDisp[contador].BackColor;

            contador++;
        }

        private void sol10_6_Click(object sender, EventArgs e)
        {
            contador = U1.ReiniciarContador(contador, arrayPicColoresDisp);
            sol10_6.BackColor = arrayPicColoresDisp[contador].BackColor;

            contador++;
        }
        #endregion

        /* en cada botón de comprobar hago lo siguiente:
         *  - compruebo que la solución propuesta no está en blanco
         *      - si no lo cumple mensaje de aviso y no dejo continuar
         * - si si q lo cumple ha go las siguientes cosas:
         *      - compruebo que la solución propuesta es correcta. si es así mensaje de ganador, sino cambio de turno
         * */
        #region Comprobar Buttons
        private void button1_Click(object sender, EventArgs e)
        {
            if (U1.ComprobarSolucionBlancos(resultados1, arrayPicColoresDisp) == true)
            {
                U1.ComprobarSolucion(resultados1, arrayPicColoresSol, comprobacion1);
                     if (U1.CondicionVictoria(comprobacion1))
                {
                    MessageBox.Show("Ha ganado el juego con 1 intento");
                    button1.Hide();
                }
                     else
                {
                    U1.CambioTurno(button1, button2, resultados1, resultados2, comprobacion2);

                }

            }
            else
            {
                MessageBox.Show("Faltan colores");

            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (U1.ComprobarSolucionBlancos(resultados2, arrayPicColoresDisp) == true)
            {
                U1.ComprobarSolucion(resultados2, arrayPicColoresSol, comprobacion2);
                    if (U1.CondicionVictoria(comprobacion2))
                {
                    MessageBox.Show("Ha ganado el juego con 2 intentos");
                    button2.Hide();
                }
                    else
                {
                    U1.CambioTurno(button2, button3, resultados2, resultados3, comprobacion3);
                }
            }
            else
            {
                MessageBox.Show("Faltan colores");

            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (U1.ComprobarSolucionBlancos(resultados3, arrayPicColoresDisp) == true)
            {
                U1.ComprobarSolucion(resultados3, arrayPicColoresSol, comprobacion3);
                    if (U1.CondicionVictoria(comprobacion3))
                {
                    MessageBox.Show("Ha ganado el juego con 3 intentos");
                    button3.Hide();
                }
                    else
                {
                    U1.CambioTurno(button3, button4, resultados3, resultados4, comprobacion4);

                }
            }
            else
            {
                MessageBox.Show("Faltan colores");

            }
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (U1.ComprobarSolucionBlancos(resultados4, arrayPicColoresDisp) == true)
            {
                U1.ComprobarSolucion(resultados4, arrayPicColoresSol, comprobacion4);
                    if (U1.CondicionVictoria(comprobacion4))
                {
                    MessageBox.Show("Ha ganado el juego con 4 intentos");
                    button4.Hide();
                }
                    else
                {
                    U1.CambioTurno(button4, button5, resultados4, resultados5, comprobacion5);

                }
            }
            else
            {
                MessageBox.Show("Faltan colores");

            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (U1.ComprobarSolucionBlancos(resultados5, arrayPicColoresDisp) == true)
            {
                U1.ComprobarSolucion(resultados5, arrayPicColoresSol, comprobacion5);
                    if (U1.CondicionVictoria(comprobacion5))
                {
                    MessageBox.Show("Ha ganado el juego con 5 intentos");
                    button5.Hide();
                }
                    else
                {
                    U1.CambioTurno(button5, button6, resultados5, resultados6, comprobacion6);
                }
            }
            else
            {
                MessageBox.Show("Faltan colores");

            }
           
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (U1.ComprobarSolucionBlancos(resultados6, arrayPicColoresDisp) == true)
            {
                U1.ComprobarSolucion(resultados6, arrayPicColoresSol, comprobacion6);
                if (dificultad == "avanzado")
                {
                    if (U1.CondicionVictoria(comprobacion6))
                    {
                        MessageBox.Show("Ha ganado el juego con 6 intentos");
                        button6.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Ha perdido el juego con los maximos intentos, pruebe otra dificultad");
                    }
                }
                else
                {
                    if (U1.CondicionVictoria(comprobacion6))
                    {
                        MessageBox.Show("Ha ganado el juego con 6 intentos");
                        button6.Hide();
                    }
                    else
                    {
                        U1.CambioTurno(button6, button7, resultados6, resultados7, comprobacion7);

                    }
                }
            }
            else
            {
                MessageBox.Show("Faltan colores");

            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (U1.ComprobarSolucionBlancos(resultados7, arrayPicColoresDisp) == true)
            {
                U1.ComprobarSolucion(resultados7, arrayPicColoresSol, comprobacion7);
                if (U1.CondicionVictoria(comprobacion7))
                {
                    MessageBox.Show("Ha ganado el juego con 7 intentos");
                    button7.Hide();
                }
                else
                {
                    U1.CambioTurno(button7, button8, resultados7, resultados8, comprobacion8);
                }
            }
            else
            {
                MessageBox.Show("Faltan colores");

            }
           
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (U1.ComprobarSolucionBlancos(resultados8, arrayPicColoresDisp) == true)
            {
                U1.ComprobarSolucion(resultados8, arrayPicColoresSol, comprobacion8);
                if (dificultad == "intermedio")
                {
                    if (U1.CondicionVictoria(comprobacion6))
                    {
                        MessageBox.Show("Ha ganado el juego con 8 intentos");
                        button8.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Ha perdido el juego con los maximos intentos, pruebe otra dificultad");
                    }
                }
                else
                {
                    if (U1.CondicionVictoria(comprobacion8))
                    {
                        MessageBox.Show("Ha ganado el juego con 8 intentos");
                        button8.Hide();
                    }
                    else
                    {
                        U1.CambioTurno(button8, button9, resultados8, resultados9, comprobacion9);
                    }
                }
            }
            else
            {
                MessageBox.Show("Faltan colores");

            }
                     
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (U1.ComprobarSolucionBlancos(resultados9, arrayPicColoresDisp) == true)
            {
                U1.ComprobarSolucion(resultados9, arrayPicColoresSol, comprobacion9);
                if (U1.CondicionVictoria(comprobacion9))
                {
                    MessageBox.Show("Ha ganado el juego con 9 intentos");
                    button9.Hide();
                }
                else
                {
                    U1.CambioTurno(button9, button10, resultados9, resultados10, comprobacion10);
                }
            }
            else
            {
                MessageBox.Show("Faltan colores");

            }
          
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (U1.ComprobarSolucionBlancos(resultados10, arrayPicColoresDisp) == true)
            {
                U1.ComprobarSolucion(resultados10, arrayPicColoresSol, comprobacion10);
                if (U1.CondicionVictoria(comprobacion10))
                {
                    MessageBox.Show("Ha ganado el juego con 10 intentos");
                    button10.Hide();
                }
                else
                {
                    MessageBox.Show("Ha gastado sus intentos, ha perdido");
                    button10.Hide();
                }
            }
            else
            {
                MessageBox.Show("Faltan colores");

            }

        }

        #endregion

        // abre la ventana de como jugar
        private void comoJugarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ComoJugar jugar = new ComoJugar();
            jugar.ShowDialog();
        }

        //abre la venta de mas info
        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcercaDe acerca = new AcercaDe();
            acerca.ShowDialog();
        }
    }
}
