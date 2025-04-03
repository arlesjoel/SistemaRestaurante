using EL;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class DAL_Roles
    {
        public static Roles Insert(Roles entidad)
        {
            using BDSistemaRestaurante bd = new();
            entidad.FechaAsignacion = DateTime.Now;
            entidad.FechaRegistro = DateTime.Now;
            entidad.Activo = true;
            bd.Roles.Add(entidad);
            bd.SaveChanges();
            return entidad;
        }
        public static bool Update(int id, Roles entidad) 
        {
            using BDSistemaRestaurante bd = new();
            var registro = bd.Roles.FirstOrDefault(r => r.IdRol == id);
            if (registro != null)
            {
                registro.Rol = entidad.Rol;
                registro.FechaAsignacion = DateTime.Now;
                registro.UsuarioActualiza = entidad.UsuarioActualiza;
                registro.FechaActualiza = DateTime.Now;

                bd.SaveChanges();
                return true;
            }
            return false;
        }
        public static bool Delete(int id)
        {
            using BDSistemaRestaurante bd = new();
            var registro = bd.Roles.FirstOrDefault(c => c.IdRol == id);
            if (registro != null)
            {
                registro.Activo = false;
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
