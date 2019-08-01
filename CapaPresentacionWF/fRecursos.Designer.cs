namespace CapaPresentacionWF
{
    partial class fRecursos
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabRecursos = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.textBoxNombrer = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.labelRegistrarRecursos = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewRecursos = new System.Windows.Forms.DataGridView();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.labelBuscar = new System.Windows.Forms.Label();
            this.tabRecursos.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecursos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabRecursos
            // 
            this.tabRecursos.Controls.Add(this.tabPage1);
            this.tabRecursos.Controls.Add(this.tabPage2);
            this.tabRecursos.Location = new System.Drawing.Point(44, 42);
            this.tabRecursos.Name = "tabRecursos";
            this.tabRecursos.SelectedIndex = 0;
            this.tabRecursos.Size = new System.Drawing.Size(583, 378);
            this.tabRecursos.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonGuardar);
            this.tabPage1.Controls.Add(this.textBoxDescripcion);
            this.tabPage1.Controls.Add(this.textBoxCodigo);
            this.tabPage1.Controls.Add(this.textBoxNombrer);
            this.tabPage1.Controls.Add(this.textBoxId);
            this.tabPage1.Controls.Add(this.labelDescripcion);
            this.tabPage1.Controls.Add(this.labelCodigo);
            this.tabPage1.Controls.Add(this.labelNombre);
            this.tabPage1.Controls.Add(this.labelId);
            this.tabPage1.Controls.Add(this.labelRegistrarRecursos);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(575, 352);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nuevo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.ForeColor = System.Drawing.Color.Navy;
            this.buttonGuardar.Location = new System.Drawing.Point(102, 311);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 9;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(161, 217);
            this.textBoxDescripcion.Multiline = true;
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(216, 88);
            this.textBoxDescripcion.TabIndex = 8;
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(215, 170);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodigo.TabIndex = 7;
            // 
            // textBoxNombrer
            // 
            this.textBoxNombrer.Location = new System.Drawing.Point(215, 116);
            this.textBoxNombrer.Name = "textBoxNombrer";
            this.textBoxNombrer.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombrer.TabIndex = 6;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(215, 63);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 20);
            this.textBoxId.TabIndex = 5;
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.ForeColor = System.Drawing.Color.Fuchsia;
            this.labelDescripcion.Location = new System.Drawing.Point(33, 239);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(63, 13);
            this.labelDescripcion.TabIndex = 4;
            this.labelDescripcion.Text = "Descripciòn";
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.ForeColor = System.Drawing.Color.Fuchsia;
            this.labelCodigo.Location = new System.Drawing.Point(33, 177);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(40, 13);
            this.labelCodigo.TabIndex = 3;
            this.labelCodigo.Text = "Còdigo";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.ForeColor = System.Drawing.Color.Fuchsia;
            this.labelNombre.Location = new System.Drawing.Point(33, 123);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 2;
            this.labelNombre.Text = "Nombre";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.ForeColor = System.Drawing.Color.Fuchsia;
            this.labelId.Location = new System.Drawing.Point(33, 71);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(16, 13);
            this.labelId.TabIndex = 1;
            this.labelId.Text = "Id";
            // 
            // labelRegistrarRecursos
            // 
            this.labelRegistrarRecursos.AutoSize = true;
            this.labelRegistrarRecursos.ForeColor = System.Drawing.Color.Navy;
            this.labelRegistrarRecursos.Location = new System.Drawing.Point(158, 19);
            this.labelRegistrarRecursos.Name = "labelRegistrarRecursos";
            this.labelRegistrarRecursos.Size = new System.Drawing.Size(97, 13);
            this.labelRegistrarRecursos.TabIndex = 0;
            this.labelRegistrarRecursos.Text = "Registrar Recursos";
            this.labelRegistrarRecursos.Click += new System.EventHandler(this.labelRegistrarRecursos_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewRecursos);
            this.tabPage2.Controls.Add(this.buttonEliminar);
            this.tabPage2.Controls.Add(this.buttonEditar);
            this.tabPage2.Controls.Add(this.buttonBuscar);
            this.tabPage2.Controls.Add(this.textBoxBuscar);
            this.tabPage2.Controls.Add(this.labelBuscar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(575, 352);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalles";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewRecursos
            // 
            this.dataGridViewRecursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRecursos.Location = new System.Drawing.Point(43, 120);
            this.dataGridViewRecursos.Name = "dataGridViewRecursos";
            this.dataGridViewRecursos.Size = new System.Drawing.Size(477, 159);
            this.dataGridViewRecursos.TabIndex = 5;
            this.dataGridViewRecursos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRecursos_CellContentClick);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.ForeColor = System.Drawing.Color.Navy;
            this.buttonEliminar.Location = new System.Drawing.Point(463, 51);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminar.TabIndex = 4;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.ForeColor = System.Drawing.Color.Navy;
            this.buttonEditar.Location = new System.Drawing.Point(345, 51);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 3;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.ForeColor = System.Drawing.Color.Navy;
            this.buttonBuscar.Location = new System.Drawing.Point(238, 51);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 2;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(87, 48);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(100, 20);
            this.textBoxBuscar.TabIndex = 1;
            //this.textBoxBuscar.Click += new System.EventHandler(this.textBoxBuscar_TextChanged);
            this.textBoxBuscar.TextChanged += new System.EventHandler(this.textBoxBuscar_TextChanged_1);
            // 
            // labelBuscar
            // 
            this.labelBuscar.AutoSize = true;
            this.labelBuscar.ForeColor = System.Drawing.Color.Navy;
            this.labelBuscar.Location = new System.Drawing.Point(23, 51);
            this.labelBuscar.Name = "labelBuscar";
            this.labelBuscar.Size = new System.Drawing.Size(40, 13);
            this.labelBuscar.TabIndex = 0;
            this.labelBuscar.Text = "Buscar";
            // 
            // fRecursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 458);
            this.Controls.Add(this.tabRecursos);
            this.Name = "fRecursos";
            this.Text = "Recursos";
            this.Load += new System.EventHandler(this.fRecursos_Load);
            this.tabRecursos.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecursos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabRecursos;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelRegistrarRecursos;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.TextBox textBoxNombrer;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.DataGridView dataGridViewRecursos;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Label labelBuscar;
    }
}

