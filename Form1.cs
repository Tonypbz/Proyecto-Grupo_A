using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Programa_Grupo_A
{
    public partial class Form1 : Form
    {
        ListaPedidos listapedidos = new ListaPedidos();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnpedido_Click(object sender, EventArgs e)
        {
            try
            {
                Pedidos pedidos = new Pedidos();
                pedidos.Nombre = txtnombre.Text;
                pedidos.Ubicacion = cmbubicacion.SelectedItem.ToString();
                pedidos.Cantidad = Convert.ToInt32(txtcantidad.Text);
                pedidos.Envio = Envio();
                pedidos.Estado = Estado();
                listapedidos.Añadir(pedidos);
                Form2 form2 = new Form2();
                form2.Show();
                form2.ListaPedidos2 = listapedidos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public string Envio()
        {
            string aux = null;
            if (rdbdomicilio.Checked)
            {
                aux = "Envio a domicilio (5$)";
            }
            if (rdbagencia.Checked)
            {
                aux = "Acercarse a la agencia";
            }
            if (rdbmismodia.Checked)
            {
                aux = "Envio a domicilio mismo dia (15$)";
            }
            return aux;
        }
        public string Estado()
        {
            string aux = null;
            if (chbnuevo.Checked)
            {
                aux = "Nuevo";
            }
            else
            {
                aux = "Usado";
            }
            return aux;
        }
        private void btnborrar_Click(object sender, EventArgs e)
        {
            txtnombre.Text = " ";
            txtcantidad.Text = " ";
            rdbmismodia.Checked = false;
            rdbdomicilio.Checked = false;
            rdbagencia.Checked = false;
            chbnuevo.Checked = false;
            chbusado.Checked = false;
        }
    }
}
