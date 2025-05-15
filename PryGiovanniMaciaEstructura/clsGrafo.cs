using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryGiovanniMaciaEstructura
{
    internal class clsGrafo
    {
        //Campos de la clase

        //Vector
        private String[] Ciudades = new String[] { "Córdoba", "Mendoza", "Santa Fe", "Buenos Aires", "Salta" };

        //Matriz
        private Decimal[,] Precio = new Decimal[5, 5];



        //AGREGAR–ELIMINAR–CONSULTAR
        public void Agregar(Int32 f, Int32 c, Decimal p)
        {
            Precio[f, c] = p;
        }

        public void Eliminar(Int32 f, Int32 c)
        {
            Precio[f, c] = 0;
        }

        public Decimal Consultar(Int32 f, Int32 c)
        {
            return Precio[f, c];
        }


        public void cargarCiudades(ComboBox cmb)
        {
            foreach (string ciudad in Ciudades)
            {
                cmb.Items.Add(ciudad);
            }
        }

        public void MostrarDestinos(Int32 f, DataGridView dgv)
        {
            dgv.Rows.Clear();
            dgv.Columns.Clear();

            // Agregar columnas manualmente
            dgv.Columns.Add("col1", "Destino");
            dgv.Columns.Add("col2", "Precio");
            dgv.Columns[0].Width = 200;
            dgv.Columns[1].Width = 200;

            int c = 0;
            foreach (string ciudad in Ciudades)
            {
                if (Precio[f, c] > 0)
                {
                    dgv.Rows.Add(ciudad, Precio[f, c]);
                }
                c++;
            }
        }

        public void MostrarOrígenes(Int32 c, DataGridView dgv)
        {
            dgv.Rows.Clear();
            dgv.Columns.Clear();

            // Agregar columnas manualmente
            dgv.Columns.Add("col1", "Origen");
            dgv.Columns.Add("col2", "Precio");

            dgv.Columns[0].Width = 200;
            dgv.Columns[1].Width = 200;

            int f = 0;
            foreach (string ciudad in Ciudades)
            {
                if (Precio[f, c] > 0)
                {
                    dgv.Rows.Add(ciudad, Precio[f, c]);
                }
                f++;
            }
        }

        //procedimiento que borra todos los datos cargados
        public void BorrarTodo()
        {
            for (Int32 f = 0; f < Ciudades.Length; f++)
            {
                for (Int32 c = 0; c < Ciudades.Length; c++)
                {
                    Precio[f, c] = 0;
                }
            }
        }

        public void MostrarTodo(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            Grilla.Columns.Clear();

            // Agregar columnas manualmente
            Grilla.Columns.Add("NomOrigen", "Origen");
            for (Int32 i = 0; i < 5; i++)
            {
                Grilla.Columns.Add("Destino" + i.ToString(), Ciudades[i]);
            }

            for (Int32 f = 0; f < 5; f++)
            {
                Grilla.Rows.Add(Ciudades[f]);
                for (Int32 c = 0; c < 5; c++)
                {
                    Grilla.Rows[f].Cells[c + 1].Value = Precio[f, c];
                }
            }
        }
    }
}
