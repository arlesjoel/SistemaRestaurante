using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class DAL_ReciboDetalles
    {
        public static ReciboDetalles Insert(ReciboDetalles entidad)
        {
            using BDSistemaRestaurante bd = new();
            entidad.FechaRegistro = DateTime.Now;
            entidad.Activo = true;
            bd.ReciboDetalles.Add(entidad);
            bd.SaveChanges();
            return entidad;
        }
        public static bool Update(int id, ReciboDetalles entidad)
        {
            using BDSistemaRestaurante bd = new();
            var registro = bd.ReciboDetalles.FirstOrDefault(r => r.IdReciboDetalle == id);
            if (registro != null)
            {
                registro.Cantidad = entidad.Cantidad;
                registro.Recibo = entidad.Recibo;
                registro.Producto = entidad.Producto;
                registro.FechaActualiza = DateTime.Now;

                bd.SaveChanges();
                return true;
            }
            return false;
        }
        public static bool Delete(int id)
        {
            using BDSistemaRestaurante bd = new();
            var registro = bd.ReciboDetalles.FirstOrDefault(r => r.IdReciboDetalle == id);
            if (registro != null)
            {
                registro.Activo = false;
                bd.SaveChanges();
            }
            return bd.SaveChanges() > 0;
        }
        public static List<ReciboDetalles> Lista()
        {
            using BDSistemaRestaurante bd = new();
            return bd.ReciboDetalles.ToList();
        }
    }
}
