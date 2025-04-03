using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Usuarios
    {
        public static Usuarios Insert(Usuarios entidad)
        {
            using BDSistemaRestaurante bd = new();
            entidad.FechaRegistro = DateTime.Now;
            entidad.Activo = true;
            bd.Usuarios.Add(entidad);
            bd.SaveChanges();
            return entidad;
        }
        public static bool Update(int id, Usuarios entidad)
        {
            using BDSistemaRestaurante bd = new();
            var registro = bd.Usuarios.FirstOrDefault(r => r.IdUsuario == id);
            if (registro != null)
            {
                registro.NombreCompleto = entidad.NombreCompleto;
                registro.Telefono = entidad.Telefono;
                registro.Email = entidad.Email;
                registro.NombreUsuario = entidad.NombreUsuario;
                registro.NombreCompleto = entidad.NombreCompleto;
                registro.Password = entidad.Password;
                registro.FechaActualiza = DateTime.Now;

                bd.SaveChanges();
                return true;
            }
            return false;
        }
        public static bool Delete(int id)
        {
            using BDSistemaRestaurante bd = new();
            var registro = bd.Usuarios.FirstOrDefault(r => r.IdUsuario == id);
            if (registro != null)
            {
                registro.Activo = false;
                bd.SaveChanges();
            }
            return bd.SaveChanges() > 0;
        }
        public static List<Roles> Lista()
        {
            using BDSistemaRestaurante bd = new();
            return bd.Roles.ToList();
        }
    }
}
