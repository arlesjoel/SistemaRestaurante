using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace DAL
{
    public class Conection
    {
        private static string NombreAplicacion = "SistemaRestaurante";
        private static string Servidor = @"DESKTOP-9VH7CLA";
        private static string BaseDatos = "SistemaRestaurante";
        public static string ConexionString(bool WindowsAuthentication = true)
        {
            SqlConnectionStringBuilder Constructor = new()
            {
                ApplicationName = NombreAplicacion,
                DataSource = Servidor,
                InitialCatalog = BaseDatos,
                TrustServerCertificate = true,
                IntegratedSecurity = WindowsAuthentication
            };


            return Constructor.ConnectionString;
        }
    }
}
