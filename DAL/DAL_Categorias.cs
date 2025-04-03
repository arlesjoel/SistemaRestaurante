using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class DAL_Categorias
    {
        public static Categorias Insert(Categorias entidad)
        {
            using BDSistemaRestaurante bd = new();
            entidad.FechaRegistro = DateTime.Now;
            entidad.Activo = true;
            bd.Categorias.Add(entidad);
            bd.SaveChanges();
            return entidad;
        }
        public static bool Update(int id, Categorias entidad)
        {
            using BDSistemaRestaurante bd = new();
            var registro = bd.Categorias.FirstOrDefault(r => r.CategoriaId == id);
            if (registro != null)
            {
                registro.Categoria = entidad.Categoria;
                registro.FechaActualiza = DateTime.Now;

                bd.SaveChanges();
                return true;
            }
            return false;
        }
        public static bool Delete(int id)
        {
            using BDSistemaRestaurante bd = new();
            var registro = bd.Categorias.FirstOrDefault(r => r.CategoriaId == id);
            if (registro != null)
            {
                registro.Activo = false;
                bd.SaveChanges();
            }
            return bd.SaveChanges() > 0;
        }
        public static List<Categorias> Lista()
        {
            using BDSistemaRestaurante bd = new();
            return bd.Categorias.ToList();
        }
    }
}
