using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;
using Entidades;

namespace RestaurantePizzeria
{
    public partial class frmCliente : Form
    {
        private NegociosCliente negociosCliente;
        public frmCliente()
        {
            InitializeComponent();
            negociosCliente = new NegociosCliente();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            EntityCliente cliente = new EntityCliente();
            txtboxIdCliente.Text = Convert.ToString(cliente.ClienteId);
            txtboxNombre.Text = cliente.ClienteNombre;
            txtboxApellido.Text = cliente.ClienteApellido;
            negociosCliente.CreateCliente(cliente);
            ActualizarGrid();
        }
        private void ActualizarGrid()
        {
            /// actualiza el grid
            /// booras el grid y lo vuelves a cargar
            dgvData.Rows.Clear();
            dgvData.DataSource = negociosCliente.GetAll();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EntityCliente cliente = new EntityCliente();
            txtboxIdCliente.Text = Convert.ToString(cliente.ClienteId);
            txtboxNombre.Text = cliente.ClienteNombre;
            txtboxApellido.Text = cliente.ClienteApellido;
            negociosCliente.UpdateCliente(cliente);
            ActualizarGrid();
        }
    }
}
