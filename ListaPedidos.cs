using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Programa_Grupo_A
{
    public class ListaPedidos
    {
        public List<Pedidos> Pedido { set; get; }
        public ListaPedidos()
        {
            Pedido = new List<Pedidos>();
        }
        public void Añadir(Pedidos pedidos)
        {
            Pedido.Add(pedidos);
        }
    }
}
