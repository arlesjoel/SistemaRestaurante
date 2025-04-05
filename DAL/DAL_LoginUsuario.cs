using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace DAL
{
    public static class DAL_LoginUsuario
    {
        public static int UserID { get; set; }
        public static Usuarios Login(string Usuario, byte[] Password)
        {
            BDSistemaRestaurante bd = new();
            var result = bd.Usuarios.Where(a => a.NombreUsuario == Usuario && a.Password == Password && a.Activo).SingleOrDefault();
            if (result != null)
            {
                return result;
            }
            return new();
        }
        public static byte[] Sha256(string input)
        {
            return SHA256.HashData(Encoding.UTF8.GetBytes(input));
        }
    }
}
