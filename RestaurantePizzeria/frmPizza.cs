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
    public partial class frmPizza : Form
    {
        private NegociosPizza negociosPizza;
        public frmPizza()
        {
            InitializeComponent();
            negociosPizza= new NegociosPizza();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }
    }
}
