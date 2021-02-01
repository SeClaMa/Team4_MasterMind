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
        public void RellenarListas(List<PictureBox> resultados, PictureBox pic1, PictureBox pic2, PictureBox pic3, PictureBox pic4, PictureBox pic5, PictureBox pic6)
        {
            resultados.Add(pic1);
            resultados.Add(pic2);
            resultados.Add(pic3);
            resultados.Add(pic4);
            resultados.Add(pic5);
            resultados.Add(pic6);
        }

        public void UnlockLista(List<PictureBox> list_unlock)
        {
            foreach (PictureBox p in list_unlock)
            {
                p.Enabled = true;
            }
        }

        public void LimpiarListas(Color[] a_color,List<int> n_repe,List<PictureBox> colores_disp, List<PictureBox> solucion, List<PictureBox> sol1, List<PictureBox> sol2, List<PictureBox> sol3, List<PictureBox> sol4, List<PictureBox> sol5, List<PictureBox> sol6, List<PictureBox> sol7, List<PictureBox> sol8, List<PictureBox> sol9, List<PictureBox> sol10)
        {
            Array.Clear(a_color, 0, a_color.Length);
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

        public void LimpiarListasComp(List<PictureBox> solucion1, List<PictureBox> solucion2, List<PictureBox> solucion3, List<PictureBox> solucion4, List<PictureBox> solucion5, List<PictureBox> solucion6, List<PictureBox> solucion7, List<PictureBox> solucion8, List<PictureBox> solucion9, List<PictureBox> solucion10)
        {
            solucion1.Clear();
            solucion2.Clear();
            solucion3.Clear();
            solucion4.Clear();
            solucion5.Clear();
            solucion6.Clear();
            solucion7.Clear();
            solucion8.Clear();
            solucion9.Clear();
            solucion10.Clear();
        }

        public void HideWhiteListas(List<PictureBox> solucion)
        {
            foreach (PictureBox p in solucion)
            {
                p.BackColor = Color.White;
                p.Hide();
            }
        }

        public void NivelPrincipiante(List<PictureBox> lista)
        {
            lista[4].BackColor = Color.White;
            lista[5].BackColor = Color.White;
            lista[4].Hide();
            lista[5].Hide();
            lista.RemoveRange(4, 2);
        }

        public void NivelIntermedio(List<PictureBox> lista)
        {
            lista[5].BackColor = Color.White;
            lista[5].Hide();
            lista.RemoveRange(5, 1);
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

        public void ComprobarSolucion(List<PictureBox> resultados, List<PictureBox> solucion,List<PictureBox> compro)
        {
            int contador_total = 0;
            int contador_parcial = 0;
            List<PictureBox> resultados_espejo = new List<PictureBox>();
            List<PictureBox> solucion_espejo = new List<PictureBox>();

            
            for (int i = 0; i < resultados.Count; i++)
            {
                resultados_espejo.Add(resultados[i]);
            }

            for (int i = 0; i < solucion.Count; i++)
            {
                solucion_espejo.Add(solucion[i]);
            }

            for (int i = resultados.Count-1; i >= 0; i--)
            {
                    if (resultados[i].BackColor == solucion[i].BackColor)
                    {
                    contador_total++;
                    resultados_espejo.RemoveAt(i);
                    solucion_espejo.RemoveAt(i);
                    }
            }

            for (int i = resultados_espejo.Count-1; i >=0; i--)
            {
                for (int x = solucion_espejo.Count-1; x >=0; x--)
                {
                    if (resultados_espejo[i].BackColor == solucion_espejo[x].BackColor)
                    {
                        contador_parcial++;
                        solucion_espejo.RemoveAt(x);
                        resultados_espejo.RemoveAt(i);
                        break;
                    }
                }
            }
            MessageBox.Show("Totales: " + contador_total + " . Parciales: " + contador_parcial);
            PintarSolucion(contador_total, contador_parcial, compro);
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

        public void CambioTurno(Button button_ocultar, Button button_mostrar, List<PictureBox> lista_Bloquear, List<PictureBox> lista_Mostrar, List<PictureBox> comprobar_mostrar)
        {
            button_ocultar.Hide();
            button_mostrar.Show();
            foreach (PictureBox p in lista_Bloquear)
            {
                p.Enabled = false;
            }

            foreach (PictureBox p in lista_Mostrar)
            {
                p.Show();
            }

            foreach (PictureBox p in comprobar_mostrar)
            {
                p.Show();
            }

        }
        
    }
}
