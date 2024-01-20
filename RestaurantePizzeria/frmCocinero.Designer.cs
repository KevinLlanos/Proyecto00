namespace RestaurantePizzeria
{
    partial class frmCocinero
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label7 = new System.Windows.Forms.Label();
            this.lblIdCocinero = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.lblCi = new System.Windows.Forms.Label();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.txtboxIdCocinero = new System.Windows.Forms.TextBox();
            this.txtboxNombre = new System.Windows.Forms.TextBox();
            this.txtboxApellido = new System.Windows.Forms.TextBox();
            this.txtboxDomicilio = new System.Windows.Forms.TextBox();
            this.txtboxCi = new System.Windows.Forms.TextBox();
            this.txtboxSueldo = new System.Windows.Forms.TextBox();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCocinero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ci = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sueldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Dock = System.Windows.Forms.DockStyle.Left;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(322, 517);
            this.label7.TabIndex = 12;
            // 
            // lblIdCocinero
            // 
            this.lblIdCocinero.AutoSize = true;
            this.lblIdCocinero.BackColor = System.Drawing.Color.White;
            this.lblIdCocinero.Location = new System.Drawing.Point(77, 9);
            this.lblIdCocinero.Name = "lblIdCocinero";
            this.lblIdCocinero.Size = new System.Drawing.Size(90, 20);
            this.lblIdCocinero.TabIndex = 13;
            this.lblIdCocinero.Text = "Id Cocinero";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(86, 70);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 20);
            this.lblNombre.TabIndex = 14;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.BackColor = System.Drawing.Color.White;
            this.lblApellido.Location = new System.Drawing.Point(86, 135);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(65, 20);
            this.lblApellido.TabIndex = 15;
            this.lblApellido.Text = "Apellido";
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.BackColor = System.Drawing.Color.White;
            this.lblDomicilio.Location = new System.Drawing.Point(86, 197);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(72, 20);
            this.lblDomicilio.TabIndex = 16;
            this.lblDomicilio.Text = "Domicilio";
            // 
            // lblCi
            // 
            this.lblCi.AutoSize = true;
            this.lblCi.BackColor = System.Drawing.Color.White;
            this.lblCi.Location = new System.Drawing.Point(110, 262);
            this.lblCi.Name = "lblCi";
            this.lblCi.Size = new System.Drawing.Size(23, 20);
            this.lblCi.TabIndex = 17;
            this.lblCi.Text = "Ci";
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.BackColor = System.Drawing.Color.White;
            this.lblSueldo.Location = new System.Drawing.Point(99, 323);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(59, 20);
            this.lblSueldo.TabIndex = 18;
            this.lblSueldo.Text = "Sueldo";
            // 
            // txtboxIdCocinero
            // 
            this.txtboxIdCocinero.Location = new System.Drawing.Point(32, 41);
            this.txtboxIdCocinero.Name = "txtboxIdCocinero";
            this.txtboxIdCocinero.Size = new System.Drawing.Size(192, 26);
            this.txtboxIdCocinero.TabIndex = 19;
            // 
            // txtboxNombre
            // 
            this.txtboxNombre.Location = new System.Drawing.Point(32, 106);
            this.txtboxNombre.Name = "txtboxNombre";
            this.txtboxNombre.Size = new System.Drawing.Size(192, 26);
            this.txtboxNombre.TabIndex = 20;
            // 
            // txtboxApellido
            // 
            this.txtboxApellido.Location = new System.Drawing.Point(32, 168);
            this.txtboxApellido.Name = "txtboxApellido";
            this.txtboxApellido.Size = new System.Drawing.Size(192, 26);
            this.txtboxApellido.TabIndex = 21;
            // 
            // txtboxDomicilio
            // 
            this.txtboxDomicilio.Location = new System.Drawing.Point(32, 233);
            this.txtboxDomicilio.Name = "txtboxDomicilio";
            this.txtboxDomicilio.Size = new System.Drawing.Size(192, 26);
            this.txtboxDomicilio.TabIndex = 22;
            // 
            // txtboxCi
            // 
            this.txtboxCi.Location = new System.Drawing.Point(32, 294);
            this.txtboxCi.Name = "txtboxCi";
            this.txtboxCi.Size = new System.Drawing.Size(192, 26);
            this.txtboxCi.TabIndex = 23;
            // 
            // txtboxSueldo
            // 
            this.txtboxSueldo.Location = new System.Drawing.Point(55, 357);
            this.txtboxSueldo.Name = "txtboxSueldo";
            this.txtboxSueldo.Size = new System.Drawing.Size(134, 26);
            this.txtboxSueldo.TabIndex = 24;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnGuardar.IconColor = System.Drawing.Color.White;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.IconSize = 30;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(4, 409);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(148, 50);
            this.btnGuardar.TabIndex = 25;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Firebrick;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnEliminar.IconColor = System.Drawing.Color.White;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.IconSize = 30;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(158, 409);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(148, 50);
            this.btnEliminar.TabIndex = 26;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditar.IconColor = System.Drawing.Color.White;
            this.btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditar.IconSize = 30;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(69, 465);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(144, 40);
            this.btnEditar.TabIndex = 27;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionar,
            this.IdCocinero,
            this.Nombre,
            this.Apellido,
            this.Domicilio,
            this.Ci,
            this.Sueldo});
            this.dgvData.Location = new System.Drawing.Point(328, 127);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersWidth = 62;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvData.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvData.RowTemplate.Height = 28;
            this.dgvData.Size = new System.Drawing.Size(837, 351);
            this.dgvData.TabIndex = 28;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.HeaderText = "";
            this.btnSeleccionar.MinimumWidth = 8;
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.ReadOnly = true;
            this.btnSeleccionar.Width = 30;
            // 
            // IdCocinero
            // 
            this.IdCocinero.HeaderText = "IdCocinero";
            this.IdCocinero.MinimumWidth = 8;
            this.IdCocinero.Name = "IdCocinero";
            this.IdCocinero.ReadOnly = true;
            this.IdCocinero.Visible = false;
            this.IdCocinero.Width = 150;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 8;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 150;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.MinimumWidth = 8;
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            this.Apellido.Width = 150;
            // 
            // Domicilio
            // 
            this.Domicilio.HeaderText = "Domicilio";
            this.Domicilio.MinimumWidth = 8;
            this.Domicilio.Name = "Domicilio";
            this.Domicilio.ReadOnly = true;
            this.Domicilio.Width = 180;
            // 
            // Ci
            // 
            this.Ci.HeaderText = "Ci";
            this.Ci.MinimumWidth = 8;
            this.Ci.Name = "Ci";
            this.Ci.ReadOnly = true;
            this.Ci.Width = 150;
            // 
            // Sueldo
            // 
            this.Sueldo.HeaderText = "Sueldo";
            this.Sueldo.MinimumWidth = 8;
            this.Sueldo.Name = "Sueldo";
            this.Sueldo.ReadOnly = true;
            this.Sueldo.Width = 150;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(328, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(837, 47);
            this.label8.TabIndex = 29;
            this.label8.Text = "Lista de Cocineros:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmCocinero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1176, 517);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtboxSueldo);
            this.Controls.Add(this.txtboxCi);
            this.Controls.Add(this.txtboxDomicilio);
            this.Controls.Add(this.txtboxApellido);
            this.Controls.Add(this.txtboxNombre);
            this.Controls.Add(this.txtboxIdCocinero);
            this.Controls.Add(this.lblSueldo);
            this.Controls.Add(this.lblCi);
            this.Controls.Add(this.lblDomicilio);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblIdCocinero);
            this.Controls.Add(this.label7);
            this.Name = "frmCocinero";
            this.Text = "frmCocinero";
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblIdCocinero;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.Label lblCi;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.TextBox txtboxIdCocinero;
        private System.Windows.Forms.TextBox txtboxNombre;
        private System.Windows.Forms.TextBox txtboxApellido;
        private System.Windows.Forms.TextBox txtboxDomicilio;
        private System.Windows.Forms.TextBox txtboxCi;
        private System.Windows.Forms.TextBox txtboxSueldo;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.DataGridViewTextBoxColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCocinero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Domicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ci;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sueldo;
        private System.Windows.Forms.Label label8;
    }
}