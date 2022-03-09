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
    public partial class Form2 : Form
    {
        public ListaPedidos ListaPedidos2 = new ListaPedidos();
        public Form2()
        {
            InitializeComponent();
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            dgvlista.DataSource = ListaPedidos2.Pedido;
        }

        private void btnenviar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DATOS ENVIADOS CORRECTAMENTE");
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
