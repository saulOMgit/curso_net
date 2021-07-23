
namespace EjercicioRepasoLunesLINQ
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.GridDatos = new System.Windows.Forms.DataGridView();
            this.cbSeleccion = new System.Windows.Forms.ComboBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnIDCLIENTE = new System.Windows.Forms.Button();
            this.btnNombre = new System.Windows.Forms.Button();
            this.btnApellidos = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtIDCliente = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // GridDatos
            // 
            this.GridDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridDatos.Location = new System.Drawing.Point(12, 44);
            this.GridDatos.Name = "GridDatos";
            this.GridDatos.Size = new System.Drawing.Size(459, 247);
            this.GridDatos.TabIndex = 0;
            // 
            // cbSeleccion
            // 
            this.cbSeleccion.FormattingEnabled = true;
            this.cbSeleccion.Items.AddRange(new object[] {
            "ID Cliente",
            "Nombre",
            "Apellidos"});
            this.cbSeleccion.Location = new System.Drawing.Point(13, 13);
            this.cbSeleccion.Name = "cbSeleccion";
            this.cbSeleccion.Size = new System.Drawing.Size(121, 21);
            this.cbSeleccion.TabIndex = 1;
            this.cbSeleccion.Text = "ID Cliente";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(166, 13);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(304, 20);
            this.txtBuscar.TabIndex = 2;
            // 
            // btnIDCLIENTE
            // 
            this.btnIDCLIENTE.BackColor = System.Drawing.Color.Fuchsia;
            this.btnIDCLIENTE.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnIDCLIENTE.Enabled = false;
            this.btnIDCLIENTE.Location = new System.Drawing.Point(499, 66);
            this.btnIDCLIENTE.Name = "btnIDCLIENTE";
            this.btnIDCLIENTE.Size = new System.Drawing.Size(109, 59);
            this.btnIDCLIENTE.TabIndex = 3;
            this.btnIDCLIENTE.Text = "IDCLIENTE";
            this.btnIDCLIENTE.UseVisualStyleBackColor = false;
            // 
            // btnNombre
            // 
            this.btnNombre.BackColor = System.Drawing.Color.Fuchsia;
            this.btnNombre.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnNombre.Enabled = false;
            this.btnNombre.Location = new System.Drawing.Point(499, 131);
            this.btnNombre.Name = "btnNombre";
            this.btnNombre.Size = new System.Drawing.Size(109, 59);
            this.btnNombre.TabIndex = 4;
            this.btnNombre.Text = "NOMBRE";
            this.btnNombre.UseVisualStyleBackColor = false;
            // 
            // btnApellidos
            // 
            this.btnApellidos.BackColor = System.Drawing.Color.Fuchsia;
            this.btnApellidos.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnApellidos.Enabled = false;
            this.btnApellidos.Location = new System.Drawing.Point(499, 196);
            this.btnApellidos.Name = "btnApellidos";
            this.btnApellidos.Size = new System.Drawing.Size(109, 59);
            this.btnApellidos.TabIndex = 5;
            this.btnApellidos.Text = "APELLIDOS";
            this.btnApellidos.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Fuchsia;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAgregar.Location = new System.Drawing.Point(118, 297);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(109, 59);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Fuchsia;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEliminar.Location = new System.Drawing.Point(233, 297);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(109, 59);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Fuchsia;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnModificar.Location = new System.Drawing.Point(348, 297);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(109, 59);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtIDCliente
            // 
            this.txtIDCliente.Location = new System.Drawing.Point(623, 86);
            this.txtIDCliente.Name = "txtIDCliente";
            this.txtIDCliente.Size = new System.Drawing.Size(100, 20);
            this.txtIDCliente.TabIndex = 9;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(623, 151);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 10;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(623, 216);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(100, 20);
            this.txtApellidos.TabIndex = 11;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.DarkGray;
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSalir.Location = new System.Drawing.Point(605, 287);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(118, 69);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Fuchsia;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnBuscar.Location = new System.Drawing.Point(490, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(78, 41);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Fuchsia;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnReset.Location = new System.Drawing.Point(588, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(78, 41);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(749, 378);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtIDCliente);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnApellidos);
            this.Controls.Add(this.btnNombre);
            this.Controls.Add(this.btnIDCLIENTE);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.cbSeleccion);
            this.Controls.Add(this.GridDatos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridDatos;
        private System.Windows.Forms.ComboBox cbSeleccion;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnIDCLIENTE;
        private System.Windows.Forms.Button btnNombre;
        private System.Windows.Forms.Button btnApellidos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtIDCliente;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnReset;
    }
}

