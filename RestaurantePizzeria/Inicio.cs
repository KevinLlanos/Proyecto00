using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using FontAwesome.Sharp;

namespace RestaurantePizzeria
{
    public partial class Inicio : Form
    {
        public static IconMenuItem menuActivo = null;
        public static Form formularioActivo = null;
        public Inicio()
        {
            InitializeComponent();
        }
        public void abrirFormulario(IconMenuItem menu, Form formulario)
        {
            if (menuActivo != null)
            {
                menuActivo.BackColor = Color.White;
            }
            menu.BackColor = Color.Silver;
            menuActivo = menu;
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }
            formularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.SteelBlue;
            contenedor.Controls.Add(formulario);
            formulario.Show();
        }

        private void submenuMeseros_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuEmpleados, new frmMesero());
        }

        private void submenuCocineros_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuEmpleados, new frmCocinero());
        }

        private void menuProducto_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new frmPizza());
        }

        private void menuClientes_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new frmCliente());
        }

        private void submenuPedido_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuVentas, new frmPedido());
        }
    }
}
