using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PackLibrary.Clases
{
 
    public class MicommSql : IDisposable
    {
        SqlConnection cnn;
        
        public Boolean Conectar()
        {
            try
            {
                cnn = new SqlConnection(R.SQL_SERVER.CONNECTION_STRING);
                cnn.Open();
                Console.WriteLine("Se establecio conexion con sqlserver.", cnn.ConnectionString);
                Console.WriteLine("ServerVersion: {0}", cnn.ServerVersion);
                Console.WriteLine("State: {0}",  cnn.State);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al tratar de establecer la conexion con Sql Server: [Error no:]" + ex);
                Console.WriteLine("Error Sql " + ex);
                return false;
            }  
        }
        public Boolean Desconectar()
        {
            try
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                    cnn.Dispose();
                    Console.WriteLine("se desconecto con exito con el proveedor de datos sql server.");
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al desconectar de sql server." + ex);
                return false;
            }
        }
        public void Dispose()
        {
            if (cnn != null)
            {
                cnn.Dispose();
            }
        }
    }
}
