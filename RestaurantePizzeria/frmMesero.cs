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
    public partial class frmMesero : Form
    {
        private NegociosMesero negociosMesero;
        public frmMesero()
        {
            InitializeComponent();
            negociosMesero= new NegociosMesero();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            EntityMesero mesero=new EntityMesero();
            txtboxIdMesero.Text = Convert.ToString(mesero.MeseroId);
            txtboxNombre.Text = mesero.MeseroNombre;
            txtboxApellido.Text = mesero.MeseroApellido;
            txtboxDomicilio.Text = mesero.MeseroDomicilio;
            txtboxCi.Text = mesero.MeseroCi;
            txtboxSueldo.Text = Convert.ToString(mesero.MeseroSueldo);
            negociosMesero.CreateMesero(mesero);
            ActualizarGrid();
        }
        private void ActualizarGrid()
        {
            /// actualiza el grid
            /// booras el grid y lo vuelves a cargar
            dgvData.Rows.Clear();
            dgvData.DataSource = negociosMesero.GetAll();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EntityMesero mesero = new EntityMesero();
            txtboxIdMesero.Text = Convert.ToString(mesero.MeseroId);
            txtboxNombre.Text = mesero.MeseroNombre;
            txtboxApellido.Text = mesero.MeseroApellido;
            txtboxDomicilio.Text = mesero.MeseroDomicilio;
            txtboxCi.Text = mesero.MeseroCi;
            txtboxSueldo.Text = Convert.ToString(mesero.MeseroSueldo);
            negociosMesero.UpdateMesero(mesero);
            ActualizarGrid();
        }
    }
}
