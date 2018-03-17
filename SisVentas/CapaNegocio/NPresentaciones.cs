using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class NPresentaciones
    {
        //Metodo Insertar que llama al metodo Insertar de la clase DPresentaciones
        //de la CapaDatos
        public static string Insertar(string nombre, string descripcion)
        {
            DPresentaciones Obj = new DPresentaciones();
            Obj.Nombre = nombre;
            Obj.Descripcion = descripcion;
            return Obj.Insertar(Obj);

        }
        //Metodo Editar que llama al metodo Editar de la clase DPresentaciones
        //de la CapaDatos
        public static string Editar(int idpresentacion, string nombre, string descripcion)
        {
            DPresentaciones Obj = new DPresentaciones();
            Obj.Idpresentacion = idpresentacion;
            Obj.Nombre = nombre;
            Obj.Descripcion = descripcion;
            return Obj.Insertar(Obj);

        }
        //Metodo Editar que llama al metodo Eliminar de la clase DPresentaciones
        //de la CapaDatos
        public static string Eliminar(int idpresentacion)
        {
            DPresentaciones Obj = new DPresentaciones();
            Obj.Idpresentacion = idpresentacion;
            return Obj.Eliminar(Obj);
        }

        //Metodo Mostrar que llama al metodo mostrar de la clase DPresentaciones
        //de la CapaDatos
        public static DataTable Mostrar()
        {
            return new DPresentaciones().Mostrar();
        }
        //Metodo BuscarNombre que llama al metodo BuscarNombre 
        //de la clase DPresentaciones de la CapaDatos
        public static DataTable BuscarNombre(string textobuscar)
        {
            DPresentaciones Obj = new DPresentaciones();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNombre(Obj);
        }
    }
}
