using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; //agregar esta biblioteca
using System.Drawing; // agregarla para poder usar los colores

namespace SegundoProyectoCompleto.Logica
{
   public class Bases
    {
        public static void DisenoDGV(ref DataGridView Listado)
        {
            //ajustar las columnas
            Listado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Listado.BackgroundColor = Color.FromArgb(0, 64, 64); //color del fondo del dgv
            //desabilitar el estilo de las cabeceras que vienen por default
            Listado.EnableHeadersVisualStyles = false;
            Listado.BorderStyle = BorderStyle.None;
            Listado.CellBorderStyle = DataGridViewCellBorderStyle.None;
            Listado.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            Listado.RowHeadersVisible = false;

            //crear una nueva variable de tipo DataGridView para modificar los parametros
            DataGridViewCellStyle cabecera = new DataGridViewCellStyle();
            cabecera.BackColor = Color.Teal; // cambiar color de la cabecera
            cabecera.ForeColor = Color.White; // cambiar color de la letra de la cabecesra
            cabecera.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            //pasarle las propiedades a la variab;e listado
            Listado.ColumnHeadersDefaultCellStyle = cabecera;

        
        }

        public static void DisenoDgvEliminar( ref DataGridView Listado )
        {
            

            foreach (DataGridViewRow fila in Listado.Rows)
            {
                string estado;
                estado = fila.Cells["Estado"].Value.ToString();

                if (estado == "ELIMINADO")
                {
                    fila.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Strikeout | FontStyle.Bold);
                    fila.DefaultCellStyle.ForeColor = Color.FromArgb(255, 128, 128);
                
                }
            }

        }

        public static object Decimales(TextBox CajaTexto, KeyPressEventArgs e)
        {
            if ((e.KeyChar=='.') || (e.KeyChar==',')) // validar si preciono un , o un .
            { 
                //si preciono una coma , convertirla a un . punto
            e.KeyChar = System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];
            }
            if (Char.IsDigit(e.KeyChar)) //permitir las teclas numericas
            {
                e.Handled = false; // permitirlo
            }
            // permita borrar en la tecla de la flechita
            else if (char.IsControl(e.KeyChar)) 
            {
                e.Handled = false;
            }
            // evitar que se coloquen mas de un punto en la caja de texto ej 3.2.3
            else if (e.KeyChar == '.' && (~CajaTexto.Text.IndexOf(".")) != 0)
            {
                e.Handled = true; // negarlo
            }
            else if (e.KeyChar == '.') // permitir los puntos
            {
                e.Handled = false;
            }
            // permita las comas, pero arriba lo convierte en .
            else if (e.KeyChar == ',') 
            {
                e.Handled = false;
            }
            // si se preciona cualquier otra tecla no lo permitira ejemplo las letras
            else
            {
                e.Handled = true; // negar las demas teclas
            }
            return null; // no se desea retornar nada
        }
    }
}
