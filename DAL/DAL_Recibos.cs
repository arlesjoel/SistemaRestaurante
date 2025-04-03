using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class DAL_Recibos
    {
        public static Recibos Insert(Recibos entidad)
        {
            using BDSistemaRestaurante bd = new();
            entidad.FechaRegistro = DateTime.Now;
            entidad.Activo = true;
            bd.Recibos.Add(entidad);
            bd.SaveChanges();
            return entidad;
        }
        public static bool Update(int id, Recibos entidad)
        {
            using BDSistemaRestaurante bd = new();
            var registro = bd.Recibos.FirstOrDefault(r => r.ReciboId == id);
            if (registro != null)
            {
                registro.SubTotal = entidad.SubTotal;
                registro.IVA = entidad.IVA;
                registro.PagoTotal = entidad.PagoTotal;
                registro.ReciboFecha = DateTime.Now;
                registro.FechaActualiza = DateTime.Now;

                bd.SaveChanges();
                return true;
            }
            return false;
        }
        public static bool Delete(int id)
        {
            using BDSistemaRestaurante bd = new();
            var registro = bd.Recibos.FirstOrDefault(r => r.ReciboId == id);
            if (registro != null)
            {
                registro.Activo = false;
                bd.SaveChanges();
            }
            return bd.SaveChanges() > 0;
        }
        public static List<Recibos> Lista()
        {
            using BDSistemaRestaurante bd = new();
            return bd.Recibos.ToList();
        }
    }
}
