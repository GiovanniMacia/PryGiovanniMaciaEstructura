using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryGiovanniMaciaEstructura
{
    internal class clsListaDoble
    {
       
            private clsNodo pri;
            private clsNodo ult;
            clsArchivo x = new clsArchivo();


            public clsNodo Primero
            {
                get { return pri; }
                set { pri = value; }
            }

            public clsNodo Ultimo
            {
                get { return ult; }
                set { ult = value; }
            }


            public void Agregar(clsNodo Nuevo)
            {
                if (Primero == null)
                {
                    Primero = Nuevo;
                    Ultimo = Nuevo;

                }
                else
                {
                    if (Nuevo.Código < Primero.Código)
                    {
                        Nuevo.Siguiente = Primero;
                        Primero.Anterior = Nuevo;
                        Primero = Nuevo;
                    }
                    else
                    {
                        if (Nuevo.Código > Ultimo.Código)
                        {
                            Ultimo.Siguiente = Nuevo;
                            Nuevo.Anterior = Ultimo;
                            Ultimo = Nuevo;
                        }
                        else
                        {
                            clsNodo Aux = Primero;
                            clsNodo Ant = Primero;
                            while (Aux.Código < Nuevo.Código)
                            {
                                Ant = Aux;
                                Aux = Aux.Siguiente;
                            }
                            Ant.Siguiente = Nuevo;
                            Nuevo.Siguiente = Aux;
                            Aux.Anterior = Nuevo;
                            Nuevo.Anterior = Ant;
                        }
                    }
                }


            }


            public void Agregar()
            {
                StreamReader AD = new StreamReader("ListaDoble.csv");
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
                if (Primero.Código == Codigo && Ultimo == Primero)
                {
                    Primero = null;
                    Ultimo = null;
                }
                else
                {
                    if (Primero.Código == Codigo)
                    {
                        Primero = Primero.Siguiente;
                        Primero.Anterior = null;
                    }
                    else
                    {
                        if (Ultimo.Código == Codigo)
                        {
                            Ultimo = Ultimo.Anterior;
                            Ultimo.Siguiente = null;
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
                            Aux = Aux.Siguiente;
                            Ant.Siguiente = Aux;
                            Aux.Anterior = Ant;
                        }
                    }
                }
            }


            public void Recorrer(DataGridView Grilla)
            {
                clsNodo aux = Primero;
                Grilla.Rows.Clear();
                while (aux != null)                                                 //Recorrer Ascendeste//
                {
                    Grilla.Rows.Add(aux.Código, aux.Nombre, aux.Trámite);
                    aux = aux.Siguiente;
                }
            }

            public void RecorrerDes(DataGridView Grilla)
            {
                clsNodo aux = Ultimo;
                Grilla.Rows.Clear();                                               //Recorrer Descendeste//
                while (aux != null)
                {
                    Grilla.Rows.Add(aux.Código, aux.Nombre, aux.Trámite);
                    aux = aux.Anterior;
                }
            }

            public void Recorrer(ListBox Lista)
            {
                clsNodo aux = Primero;
                Lista.Items.Clear();
                while (aux != null)
                {
                    Lista.Items.Add(aux.Código + " " + aux.Nombre + " " + aux.Trámite);
                    aux = aux.Siguiente;
                }
            }

            public void Recorrer(ComboBox ComboBox)
            {
                clsNodo aux = Primero;
                ComboBox.Items.Clear();
                while (aux != null)
                {
                    ComboBox.Items.Add(aux.Código.ToString());
                    aux = aux.Siguiente;
                }
            }

            //para el CSV
            public void Recorrer()
            {
                clsNodo aux = Primero;
                StreamWriter AD = new StreamWriter("ListaDoble.csv", false, Encoding.UTF8);
                AD.WriteLine("Lista de espera\n");
                AD.WriteLine("Codigo;Nombre;Tramite");
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
