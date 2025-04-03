using EL;
using DAL;

Roles r = new Roles();
r.Rol = "Arles";
r.FechaAsignacion = DateTime.Now;
r.Activo = true;
r.UsuarioRegistra = 1;

var resultado = DAL_Roles.Insert(r);

if (resultado != null)
{
    Console.WriteLine("Ingresado correctamente");
}

else
{
    Console.WriteLine("No se ingreso");
}
Console.ReadLine();