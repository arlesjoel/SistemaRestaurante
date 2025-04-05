using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public static class DAL_Productos
    {
        public static Productos Insert(Productos entidad)
        {
            using BDSistemaRestaurante bd = new();
            entidad.FechaRegistro = DateTime.Now;
            entidad.Activo = true;
            bd.Productos.Add(entidad);
            bd.SaveChanges();
            return entidad;
        }
        public static bool Update(int id, Productos entidad)
        {
            using BDSistemaRestaurante bd = new();
            var registro = bd.Productos.FirstOrDefault(r => r.ProductoId == id);
            if (registro != null)
            {
                registro.Producto = entidad.Producto;
                registro.ProductoPrecio = entidad.ProductoPrecio;
                registro.ProductoCategoria = entidad.ProductoCategoria;
                registro.FechaActualiza = DateTime.Now;

                bd.SaveChanges();
                return true;
            }
            return false;
        }
        public static bool Delete(int id)
        {
            using BDSistemaRestaurante bd = new();
            var registro = bd.Productos.FirstOrDefault(r => r.ProductoId == id);
            if (registro != null)
            {
                registro.Activo = false;
                bd.SaveChanges();
            }
            return bd.SaveChanges() > 0;
        }
        public static List<vProductos> Lista()
        {
            using BDSistemaRestaurante bd = new();
            return bd.vProductos.ToList();
        }
    }
}
