
namespace PRUEBA_PRÁCTICA_UNIDAD_UF1846
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNuevoProducto = new System.Windows.Forms.TextBox();
            this.txtPrecioUni = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUnidadesStock = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cbProductos = new System.Windows.Forms.ComboBox();
            this.GridDatos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nuevo PRODUCTO";
            // 
            // txtNuevoProducto
            // 
            this.txtNuevoProducto.Location = new System.Drawing.Point(143, 31);
            this.txtNuevoProducto.Name = "txtNuevoProducto";
            this.txtNuevoProducto.Size = new System.Drawing.Size(100, 20);
            this.txtNuevoProducto.TabIndex = 1;
            // 
            // txtPrecioUni
            // 
            this.txtPrecioUni.Location = new System.Drawing.Point(143, 67);
            this.txtPrecioUni.Name = "txtPrecioUni";
            this.txtPrecioUni.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioUni.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Precio Uni";
            // 
            // txtUnidadesStock
            // 
            this.txtUnidadesStock.Location = new System.Drawing.Point(143, 112);
            this.txtUnidadesStock.Name = "txtUnidadesStock";
            this.txtUnidadesStock.Size = new System.Drawing.Size(100, 20);
            this.txtUnidadesStock.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Unidades Stock";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(729, 237);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtBuscar.TabIndex = 6;
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(12, 178);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(87, 46);
            this.btnAñadir.TabIndex = 7;
            this.btnAñadir.Text = "AÑADIR";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(110, 178);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(87, 46);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(701, 86);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(87, 46);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(729, 293);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(87, 46);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cbProductos
            // 
            this.cbProductos.FormattingEnabled = true;
            this.cbProductos.Location = new System.Drawing.Point(680, 31);
            this.cbProductos.Name = "cbProductos";
            this.cbProductos.Size = new System.Drawing.Size(121, 21);
            this.cbProductos.TabIndex = 11;
            // 
            // GridDatos
            // 
            this.GridDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridDatos.Location = new System.Drawing.Point(119, 371);
            this.GridDatos.Name = "GridDatos";
            this.GridDatos.Size = new System.Drawing.Size(617, 220);
            this.GridDatos.TabIndex = 12;
            this.GridDatos.SelectionChanged += new System.EventHandler(this.GridDatos_SelectionChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(904, 714);
            this.Controls.Add(this.GridDatos);
            this.Controls.Add(this.cbProductos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.txtUnidadesStock);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrecioUni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNuevoProducto);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "EXAMEN";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNuevoProducto;
        private System.Windows.Forms.TextBox txtPrecioUni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUnidadesStock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cbProductos;
        private System.Windows.Forms.DataGridView GridDatos;
    }
}

