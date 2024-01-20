namespace RestaurantePizzeria
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuTitulo = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuEmpleados = new FontAwesome.Sharp.IconMenuItem();
            this.submenuMeseros = new FontAwesome.Sharp.IconMenuItem();
            this.submenuCocineros = new FontAwesome.Sharp.IconMenuItem();
            this.menuProducto = new FontAwesome.Sharp.IconMenuItem();
            this.menuVentas = new FontAwesome.Sharp.IconMenuItem();
            this.menuClientes = new FontAwesome.Sharp.IconMenuItem();
            this.contenedor = new System.Windows.Forms.Panel();
            this.submenuPedido = new FontAwesome.Sharp.IconMenuItem();
            this.submenuDetallePedido = new FontAwesome.Sharp.IconMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuTitulo
            // 
            this.menuTitulo.AutoSize = false;
            this.menuTitulo.BackColor = System.Drawing.Color.SteelBlue;
            this.menuTitulo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuTitulo.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuTitulo.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuTitulo.Location = new System.Drawing.Point(0, 0);
            this.menuTitulo.Name = "menuTitulo";
            this.menuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuTitulo.Size = new System.Drawing.Size(1240, 47);
            this.menuTitulo.TabIndex = 1;
            this.menuTitulo.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sistema de Venta";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEmpleados,
            this.menuProducto,
            this.menuVentas,
            this.menuClientes});
            this.menuStrip1.Location = new System.Drawing.Point(0, 47);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1240, 78);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuEmpleados
            // 
            this.menuEmpleados.AutoSize = false;
            this.menuEmpleados.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenuMeseros,
            this.submenuCocineros});
            this.menuEmpleados.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
            this.menuEmpleados.IconColor = System.Drawing.Color.Black;
            this.menuEmpleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuEmpleados.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuEmpleados.Name = "menuEmpleados";
            this.menuEmpleados.Size = new System.Drawing.Size(100, 70);
            this.menuEmpleados.Text = "Empleados";
            this.menuEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // submenuMeseros
            // 
            this.submenuMeseros.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuMeseros.IconColor = System.Drawing.Color.Black;
            this.submenuMeseros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuMeseros.Name = "submenuMeseros";
            this.submenuMeseros.Size = new System.Drawing.Size(270, 34);
            this.submenuMeseros.Text = "Meseros";
            this.submenuMeseros.Click += new System.EventHandler(this.submenuMeseros_Click);
            // 
            // submenuCocineros
            // 
            this.submenuCocineros.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuCocineros.IconColor = System.Drawing.Color.Black;
            this.submenuCocineros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuCocineros.Name = "submenuCocineros";
            this.submenuCocineros.Size = new System.Drawing.Size(270, 34);
            this.submenuCocineros.Text = "Cocineros";
            this.submenuCocineros.Click += new System.EventHandler(this.submenuCocineros_Click);
            // 
            // menuProducto
            // 
            this.menuProducto.AutoSize = false;
            this.menuProducto.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.menuProducto.IconColor = System.Drawing.Color.Black;
            this.menuProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuProducto.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuProducto.Name = "menuProducto";
            this.menuProducto.Size = new System.Drawing.Size(100, 70);
            this.menuProducto.Text = "Producto";
            this.menuProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuProducto.Click += new System.EventHandler(this.menuProducto_Click);
            // 
            // menuVentas
            // 
            this.menuVentas.AutoSize = false;
            this.menuVentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenuPedido,
            this.submenuDetallePedido});
            this.menuVentas.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed;
            this.menuVentas.IconColor = System.Drawing.Color.Black;
            this.menuVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuVentas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuVentas.Name = "menuVentas";
            this.menuVentas.Size = new System.Drawing.Size(100, 70);
            this.menuVentas.Text = "Ventas";
            this.menuVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuClientes
            // 
            this.menuClientes.AutoSize = false;
            this.menuClientes.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.menuClientes.IconColor = System.Drawing.Color.Black;
            this.menuClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuClientes.Name = "menuClientes";
            this.menuClientes.Size = new System.Drawing.Size(100, 70);
            this.menuClientes.Text = "Clientes";
            this.menuClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuClientes.Click += new System.EventHandler(this.menuClientes_Click);
            // 
            // contenedor
            // 
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.contenedor.Location = new System.Drawing.Point(0, 128);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1240, 554);
            this.contenedor.TabIndex = 4;
            // 
            // submenuPedido
            // 
            this.submenuPedido.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuPedido.IconColor = System.Drawing.Color.Black;
            this.submenuPedido.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuPedido.Name = "submenuPedido";
            this.submenuPedido.Size = new System.Drawing.Size(270, 34);
            this.submenuPedido.Text = "Pedido";
            this.submenuPedido.Click += new System.EventHandler(this.submenuPedido_Click);
            // 
            // submenuDetallePedido
            // 
            this.submenuDetallePedido.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuDetallePedido.IconColor = System.Drawing.Color.Black;
            this.submenuDetallePedido.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuDetallePedido.Name = "submenuDetallePedido";
            this.submenuDetallePedido.Size = new System.Drawing.Size(270, 34);
            this.submenuDetallePedido.Text = "Detalle de Pedido";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 682);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuTitulo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuTitulo;
            this.Name = "Inicio";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem menuEmpleados;
        private FontAwesome.Sharp.IconMenuItem menuProducto;
        private FontAwesome.Sharp.IconMenuItem menuVentas;
        private FontAwesome.Sharp.IconMenuItem menuClientes;
        private System.Windows.Forms.Panel contenedor;
        private FontAwesome.Sharp.IconMenuItem submenuMeseros;
        private FontAwesome.Sharp.IconMenuItem submenuCocineros;
        private FontAwesome.Sharp.IconMenuItem submenuPedido;
        private FontAwesome.Sharp.IconMenuItem submenuDetallePedido;
    }
}

