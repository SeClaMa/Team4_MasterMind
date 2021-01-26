using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace MasterMind
{
    class Utilidades
    {
        public void RellenarListas(List<PictureBox> resultados,PictureBox pic1, PictureBox pic2,PictureBox pic3,PictureBox pic4)
        {
            resultados.Add(pic1);
            resultados.Add(pic2);
            resultados.Add(pic3);
            resultados.Add(pic4);
        }

       public void LimpiarListas(Color[] a_color,List<int> n_repe,List<PictureBox> colores_disp, List<PictureBox> solucion, List<PictureBox> sol1, List<PictureBox> sol2, List<PictureBox> sol3, List<PictureBox> sol4, List<PictureBox> sol5, List<PictureBox> sol6, List<PictureBox> sol7, List<PictureBox> sol8, List<PictureBox> sol9, List<PictureBox> sol10)
        {
            n_repe.Clear();
            colores_disp.Clear();
            solucion.Clear();
            sol1.Clear();
            sol2.Clear();
            sol3.Clear();
            sol4.Clear();
            sol5.Clear();
            sol6.Clear();
            sol7.Clear();
            sol8.Clear();
            sol9.Clear();
            sol10.Clear();
        }

        public int ReiniciarContador(int contador,List<PictureBox> arrayPicColoresDisp)
        {
            if (contador >= arrayPicColoresDisp.Count)
            {
                contador = 0;
            }
            return contador;
        }

        public bool ComprobarSolucionBlancos(List<PictureBox> resultados,List<PictureBox> colores_disponibles)
        {
            for (int i = 0; i < resultados.Count; i++)
            {
                if(resultados[i].BackColor== System.Drawing.Color.Transparent)
                {
                    return false;
                }
            }
            return true;
        }

        public void ComprobarSolucion(List<PictureBox> resultados, List<PictureBox> solucion)
        {
            int contador_total = 0;
            int contador_parcial = 0;
            List<PictureBox> resultados_espejo = new List<PictureBox>();
            List<PictureBox> solucion_espejo = new List<PictureBox>();

            
            for (int i = 0; i < resultados.Count; i++)
            {
                resultados_espejo.AddRange(resultados);
            }

            for (int i = 0; i < solucion.Count; i++)
            {
                solucion_espejo.Add(solucion[i]);
            }
            

            MessageBox.Show(Convert.ToString(resultados.Count));

            for (int i = 0; i < resultados.Count; i++)
            {
                MessageBox.Show(Convert.ToString(i));
                MessageBox.Show("A: " + resultados[i].BackColor + " B: " + solucion[i].BackColor);
                    if (resultados[i].BackColor == solucion[i].BackColor)
                    {
                    contador_total++;
                    resultados_espejo.RemoveAt(i);
                    solucion_espejo.RemoveAt(i);
                }
            }

            for (int i = 0; i < resultados_espejo.Count; i++)
            {
                for(int x=0;x<resultados_espejo.Count;x++)
                if (resultados_espejo[i].BackColor == solucion_espejo[x].BackColor)
                {
                    contador_parcial++;
                }
            }
            MessageBox.Show("Totales: " + contador_total + " . Parciales: " + contador_parcial);
            //PintarSolucion(contador_total, contador_parcial, compro);
        }

        public void PintarSolucion(int cont_total,int cont_parcial,List<PictureBox> compro)
        {
            for(int i = 0; i < compro.Count; i++)
            {
                if (cont_total > 0)
                {
                    compro[i].BackColor = Color.Black;
                    cont_total--;
                }
                else if (cont_parcial > 0)
                {
                    compro[i].BackColor = Color.White;
                    cont_parcial--;
                }
                else
                {
                    compro[i].Hide();
                }
                
            }

            
        }
    }
}
