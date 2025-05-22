using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace PryGiovanniMaciaEstructura
{
    internal class clsBaseDeDatos
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand Comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();



        private String CadenaConexion = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Libreria.mdb";



        //private String CadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Libreria.mdb";

        public void Listar(DataGridView Grilla)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                Comando.Connection = conexion;
                Comando.CommandType = CommandType.TableDirect;
                Comando.CommandText = "Autor";
                DataSet DS = new DataSet();
                adaptador = new OleDbDataAdapter(Comando);
                adaptador.Fill(DS, "Autor");
                Grilla.DataSource = DS.Tables["Autor"];
                conexion.Close();
            }
            catch(Exception varError)
            {
                conexion.Close();
                MessageBox.Show(varError.Message);
            }

        }
        public void Listar( String Tabla, DataGridView Grilla)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                Comando.Connection = conexion;
                Comando.CommandType = CommandType.TableDirect;
                Comando.CommandText = Tabla;

                DataSet DS = new DataSet();
                adaptador = new OleDbDataAdapter(Comando);
                adaptador.Fill(DS, Tabla);
                Grilla.DataSource = DS.Tables[Tabla];
                conexion.Close();
            }
            catch (Exception varError)
            {
                conexion.Close();
                MessageBox.Show(varError.Message);
            }
        }
        public void Listar( DataGridView Grilla, string Sql)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                Comando.Connection = conexion;
                Comando.CommandType = CommandType.Text;
                Comando.CommandText = Sql;

                DataSet DS = new DataSet();
                adaptador = new OleDbDataAdapter(Comando);
                adaptador.Fill(DS, "Tabla");
                Grilla.DataSource = DS.Tables["Tabla"];
                conexion.Close();
            }
            catch (Exception varError)
            {
                conexion.Close();
                MessageBox.Show(varError.Message);
            }
        }
        public void Consultar(String query, DataGridView Grilla)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                Comando.Connection = conexion;
                Comando.CommandType = CommandType.Text;
                Comando.CommandText = query;

                DataSet DS = new DataSet();
                adaptador = new OleDbDataAdapter(Comando);
                adaptador.Fill(DS);

                Grilla.DataSource = DS.Tables[0];

                conexion.Close();
            }
            catch (Exception varError)
            {
                conexion.Close();
                MessageBox.Show("Ocurrió un error: " + varError.Message);
            }

        }
    }
}
