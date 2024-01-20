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
    public partial class frmCocinero : Form
    {
        private NegociosCocinero negociosCocinero;
        public frmCocinero()
        {
            InitializeComponent();
            negociosCocinero=new NegociosCocinero();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            EntityCocinero cocinero = new EntityCocinero();
            txtboxIdCocinero.Text = Convert.ToString(cocinero.CocineroId);
            txtboxNombre.Text = cocinero.CocineroNombre;
            txtboxApellido.Text = cocinero.CocineroApellido;
            txtboxDomicilio.Text = cocinero.CocineroDomicilio;
            txtboxCi.Text = cocinero.CocineroCi;
            txtboxSueldo.Text = Convert.ToString(cocinero.CocineroSueldo);
            negociosCocinero.CreateCocinero(cocinero);
            ActualizarGrid();
        }
        private void ActualizarGrid()
        {
            /// actualiza el grid
            /// booras el grid y lo vuelves a cargar
            dgvData.Rows.Clear();
            dgvData.DataSource = negociosCocinero.GetAll();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EntityCocinero cocinero = new EntityCocinero();
            txtboxIdCocinero.Text = Convert.ToString(cocinero.CocineroId);
            txtboxNombre.Text = cocinero.CocineroNombre;
            txtboxApellido.Text = cocinero.CocineroApellido;
            txtboxDomicilio.Text = cocinero.CocineroDomicilio;
            txtboxCi.Text = cocinero.CocineroCi;
            txtboxSueldo.Text = Convert.ToString(cocinero.CocineroSueldo);
            negociosCocinero.UpdateCocinero(cocinero);
            ActualizarGrid();
        }
    }// en namespace
}
