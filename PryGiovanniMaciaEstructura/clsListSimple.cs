using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryGiovanniMaciaEstructura
{
    internal class clsListSimple
    {
        private clsNodo pri;

        public clsNodo Primero
        {
            get { return pri; }
            set { pri = value; }
        }
        public void Agregar(clsNodo Nuevo)
        {
            if (Primero == null)
            {
                Primero = Nuevo;
            }
            else
            {
                if (Nuevo.Código <= Primero.Código)
                {
                    Nuevo.Siguiente = Primero;
                    Primero = Nuevo;
                }
                else
                {
                    clsNodo aux = Primero;
                    clsNodo ant = Primero;
                    while (aux != null && Nuevo.Código> aux.Código)
                    {
                        ant = aux;
                        aux = aux.Siguiente;
                    }
                    ant.Siguiente = Nuevo;
                    Nuevo.Siguiente = aux;
                }
            }
        }
        public void Agregar()
        {
            StreamReader AD = new StreamReader("ListaSimple.csv");
            String dato = "";
            dato = AD.ReadLine();//titulo
            dato = AD.ReadLine();//renglon vacio
            dato = AD.ReadLine();//titulo columna
            dato = AD.ReadLine();//primera fila de datos
            while (dato != null)
            {
                clsNodo persona = new clsNodo();

                String[] datos = dato.Split(';');

                persona.Código = Convert.ToInt32(datos[0]);
                persona.Nombre = datos[1];
                persona.Trámite = datos[2];

                Agregar(persona);
                dato = AD.ReadLine();
            }


            AD.Close();
        }

        public void Eliminar(Int32 Codigo)
        {
            if (Primero.Código == Codigo)
            {
                Primero = Primero.Siguiente;
            }
            else
            {
                clsNodo Ant = Primero;
                clsNodo Aux = Primero;

                while (Aux.Código != Codigo)
                {
                    Ant = Aux;
                    Aux = Aux.Siguiente;
                }

                Ant.Siguiente = Aux.Siguiente;

            }
        }
        public void Recorrer(DataGridView Grilla)
        {
            clsNodo aux = Primero;
            Grilla.Rows.Clear();
            while (aux != null)
            {
                Grilla.Rows.Add(aux.Código, aux.Nombre, aux.Trámite);
                aux = aux.Siguiente;
            }

        }
        public void Recorrer(ListBox Lista)
        {
            clsNodo aux = Primero;
            Lista.Items.Clear();
            while (aux != null)
            {
                Lista.Items.Add(aux.Código);
                aux = aux.Siguiente;
            }
        }

        public void Recorrer(ComboBox Combo)
        {
            clsNodo aux = Primero;
            Combo.Items.Clear();
            while (aux != null)
            {
                Combo.Items.Add(aux.Código);
                aux = aux.Siguiente;
            }
        }

        public void Recorrer()
        {
            clsNodo aux = Primero;
            StreamWriter AD = new StreamWriter("ListaSimple.csv", false, Encoding.UTF8);
            AD.WriteLine("Lista de espera\n");
            AD.WriteLine("Código;Nombre;Trámite");
            while (aux != null)
            {

                AD.Write(aux.Código);
                AD.Write(";");
                AD.Write(aux.Nombre);
                AD.Write(";");
                AD.WriteLine(aux.Trámite);
                aux = aux.Siguiente;
            }
            AD.Close();
        }

        public void Recorrer(String NombreArchivo)
        {
            clsNodo aux = Primero;
            StreamWriter AD = new StreamWriter(NombreArchivo, false, Encoding.UTF8);
            AD.WriteLine("Lista de espera\n");
            AD.WriteLine("Código;Nombre;Trámite");
            while (aux != null)
            {
                AD.Write(aux.Código);
                AD.Write(";");
                AD.Write(aux.Nombre);
                AD.Write(";");
                AD.WriteLine(aux.Trámite);
                aux = aux.Siguiente;
            }
            AD.Close();
        }
    }
}

