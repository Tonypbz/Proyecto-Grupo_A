using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Programa_Grupo_A
{
    public class Pedidos
    {
        public string Nombre { set; get; }
        public string Ubicacion { set; get; }
        public int Cantidad { set; get; }
        public string Envio { set; get; }
        public string Estado { set; get; }
        public Pedidos()
        {
        }
        public Pedidos(string nombre, string ubicacion, int cantidad, string envio, string estado)
        {
            Nombre = nombre;
            Ubicacion = ubicacion;
            Cantidad = cantidad;
            Envio = envio;
            Estado = estado;
        }
    }
}
