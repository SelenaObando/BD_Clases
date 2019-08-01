namespace CapaPresentacionWF
{
    partial class fSolicitud
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
            this.tabSolicitud = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dateTimePickerHoraFinal = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.comboBoxIdusuario = new System.Windows.Forms.ComboBox();
            this.comboBoxIdrecursos = new System.Windows.Forms.ComboBox();
            this.dateTimePickerFechaUso = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFechaSolicitud = new System.Windows.Forms.DateTimePicker();
            this.textBoxCarrera = new System.Windows.Forms.TextBox();
            this.textBoxAsignatura = new System.Windows.Forms.TextBox();
            this.textBoxNivel = new System.Windows.Forms.TextBox();
            this.textBoxAula = new System.Windows.Forms.TextBox();
            this.textBoxIdsolicitud = new System.Windows.Forms.TextBox();
            this.labelIdusuario = new System.Windows.Forms.Label();
            this.labelIdrecursos = new System.Windows.Forms.Label();
            this.labelAsignatura = new System.Windows.Forms.Label();
            this.labelCarrera = new System.Windows.Forms.Label();
            this.labelHoraFinal = new System.Windows.Forms.Label();
            this.labelHoraInicio = new System.Windows.Forms.Label();
            this.labelFechaUso = new System.Windows.Forms.Label();
            this.labelFechaSolicitud = new System.Windows.Forms.Label();
            this.labelNivel = new System.Windows.Forms.Label();
            this.labelAula = new System.Windows.Forms.Label();
            this.labelIdsolicitud = new System.Windows.Forms.Label();
            this.labelRegistrarSolicitud = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewSolicitud = new System.Windows.Forms.DataGridView();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.labelBuscar = new System.Windows.Forms.Label();
            this.tabSolicitud.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSolicitud)).BeginInit();
            this.SuspendLayout();
            // 
            // tabSolicitud
            // 
            this.tabSolicitud.Controls.Add(this.tabPage1);
            this.tabSolicitud.Controls.Add(this.tabPage2);
            this.tabSolicitud.Location = new System.Drawing.Point(12, 12);
            this.tabSolicitud.Name = "tabSolicitud";
            this.tabSolicitud.SelectedIndex = 0;
            this.tabSolicitud.Size = new System.Drawing.Size(539, 499);
            this.tabSolicitud.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dateTimePickerHoraFinal);
            this.tabPage1.Controls.Add(this.dateTimePickerHoraInicio);
            this.tabPage1.Controls.Add(this.buttonGuardar);
            this.tabPage1.Controls.Add(this.comboBoxIdusuario);
            this.tabPage1.Controls.Add(this.comboBoxIdrecursos);
            this.tabPage1.Controls.Add(this.dateTimePickerFechaUso);
            this.tabPage1.Controls.Add(this.dateTimePickerFechaSolicitud);
            this.tabPage1.Controls.Add(this.textBoxCarrera);
            this.tabPage1.Controls.Add(this.textBoxAsignatura);
            this.tabPage1.Controls.Add(this.textBoxNivel);
            this.tabPage1.Controls.Add(this.textBoxAula);
            this.tabPage1.Controls.Add(this.textBoxIdsolicitud);
            this.tabPage1.Controls.Add(this.labelIdusuario);
            this.tabPage1.Controls.Add(this.labelIdrecursos);
            this.tabPage1.Controls.Add(this.labelAsignatura);
            this.tabPage1.Controls.Add(this.labelCarrera);
            this.tabPage1.Controls.Add(this.labelHoraFinal);
            this.tabPage1.Controls.Add(this.labelHoraInicio);
            this.tabPage1.Controls.Add(this.labelFechaUso);
            this.tabPage1.Controls.Add(this.labelFechaSolicitud);
            this.tabPage1.Controls.Add(this.labelNivel);
            this.tabPage1.Controls.Add(this.labelAula);
            this.tabPage1.Controls.Add(this.labelIdsolicitud);
            this.tabPage1.Controls.Add(this.labelRegistrarSolicitud);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(531, 473);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nuevo";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dateTimePickerHoraFinal
            // 
            this.dateTimePickerHoraFinal.Location = new System.Drawing.Point(177, 269);
            this.dateTimePickerHoraFinal.Name = "dateTimePickerHoraFinal";
            this.dateTimePickerHoraFinal.ShowUpDown = true;
            this.dateTimePickerHoraFinal.Size = new System.Drawing.Size(208, 20);
            this.dateTimePickerHoraFinal.TabIndex = 25;
            this.dateTimePickerHoraFinal.Value = new System.DateTime(2019, 7, 31, 21, 15, 0, 0);
            // 
            // dateTimePickerHoraInicio
            // 
            this.dateTimePickerHoraInicio.Location = new System.Drawing.Point(177, 237);
            this.dateTimePickerHoraInicio.Name = "dateTimePickerHoraInicio";
            this.dateTimePickerHoraInicio.ShowUpDown = true;
            this.dateTimePickerHoraInicio.Size = new System.Drawing.Size(208, 20);
            this.dateTimePickerHoraInicio.TabIndex = 31;
            this.dateTimePickerHoraInicio.Value = new System.DateTime(2019, 7, 31, 21, 25, 0, 0);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonGuardar.Location = new System.Drawing.Point(115, 440);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 23;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // comboBoxIdusuario
            // 
            this.comboBoxIdusuario.FormattingEnabled = true;
            this.comboBoxIdusuario.Location = new System.Drawing.Point(177, 413);
            this.comboBoxIdusuario.Name = "comboBoxIdusuario";
            this.comboBoxIdusuario.Size = new System.Drawing.Size(208, 21);
            this.comboBoxIdusuario.TabIndex = 22;
            // 
            // comboBoxIdrecursos
            // 
            this.comboBoxIdrecursos.FormattingEnabled = true;
            this.comboBoxIdrecursos.Location = new System.Drawing.Point(177, 377);
            this.comboBoxIdrecursos.Name = "comboBoxIdrecursos";
            this.comboBoxIdrecursos.Size = new System.Drawing.Size(208, 21);
            this.comboBoxIdrecursos.TabIndex = 21;
            // 
            // dateTimePickerFechaUso
            // 
            this.dateTimePickerFechaUso.Location = new System.Drawing.Point(177, 201);
            this.dateTimePickerFechaUso.Name = "dateTimePickerFechaUso";
            this.dateTimePickerFechaUso.Size = new System.Drawing.Size(208, 20);
            this.dateTimePickerFechaUso.TabIndex = 20;
            // 
            // dateTimePickerFechaSolicitud
            // 
            this.dateTimePickerFechaSolicitud.Location = new System.Drawing.Point(177, 165);
            this.dateTimePickerFechaSolicitud.Name = "dateTimePickerFechaSolicitud";
            this.dateTimePickerFechaSolicitud.Size = new System.Drawing.Size(208, 20);
            this.dateTimePickerFechaSolicitud.TabIndex = 19;
            // 
            // textBoxCarrera
            // 
            this.textBoxCarrera.Location = new System.Drawing.Point(177, 308);
            this.textBoxCarrera.Multiline = true;
            this.textBoxCarrera.Name = "textBoxCarrera";
            this.textBoxCarrera.Size = new System.Drawing.Size(208, 20);
            this.textBoxCarrera.TabIndex = 18;
            // 
            // textBoxAsignatura
            // 
            this.textBoxAsignatura.Location = new System.Drawing.Point(177, 341);
            this.textBoxAsignatura.Multiline = true;
            this.textBoxAsignatura.Name = "textBoxAsignatura";
            this.textBoxAsignatura.Size = new System.Drawing.Size(208, 20);
            this.textBoxAsignatura.TabIndex = 17;
            // 
            // textBoxNivel
            // 
            this.textBoxNivel.Location = new System.Drawing.Point(177, 135);
            this.textBoxNivel.Multiline = true;
            this.textBoxNivel.Name = "textBoxNivel";
            this.textBoxNivel.Size = new System.Drawing.Size(208, 20);
            this.textBoxNivel.TabIndex = 14;
            // 
            // textBoxAula
            // 
            this.textBoxAula.Location = new System.Drawing.Point(177, 91);
            this.textBoxAula.Multiline = true;
            this.textBoxAula.Name = "textBoxAula";
            this.textBoxAula.Size = new System.Drawing.Size(208, 20);
            this.textBoxAula.TabIndex = 13;
            // 
            // textBoxIdsolicitud
            // 
            this.textBoxIdsolicitud.Location = new System.Drawing.Point(177, 48);
            this.textBoxIdsolicitud.Multiline = true;
            this.textBoxIdsolicitud.Name = "textBoxIdsolicitud";
            this.textBoxIdsolicitud.Size = new System.Drawing.Size(208, 20);
            this.textBoxIdsolicitud.TabIndex = 12;
            // 
            // labelIdusuario
            // 
            this.labelIdusuario.AutoSize = true;
            this.labelIdusuario.ForeColor = System.Drawing.Color.Fuchsia;
            this.labelIdusuario.Location = new System.Drawing.Point(37, 413);
            this.labelIdusuario.Name = "labelIdusuario";
            this.labelIdusuario.Size = new System.Drawing.Size(50, 13);
            this.labelIdusuario.TabIndex = 11;
            this.labelIdusuario.Text = "Idusuario";
            // 
            // labelIdrecursos
            // 
            this.labelIdrecursos.AutoSize = true;
            this.labelIdrecursos.ForeColor = System.Drawing.Color.Fuchsia;
            this.labelIdrecursos.Location = new System.Drawing.Point(37, 377);
            this.labelIdrecursos.Name = "labelIdrecursos";
            this.labelIdrecursos.Size = new System.Drawing.Size(56, 13);
            this.labelIdrecursos.TabIndex = 10;
            this.labelIdrecursos.Text = "Idrecursos";
            // 
            // labelAsignatura
            // 
            this.labelAsignatura.AutoSize = true;
            this.labelAsignatura.ForeColor = System.Drawing.Color.Fuchsia;
            this.labelAsignatura.Location = new System.Drawing.Point(37, 341);
            this.labelAsignatura.Name = "labelAsignatura";
            this.labelAsignatura.Size = new System.Drawing.Size(57, 13);
            this.labelAsignatura.TabIndex = 9;
            this.labelAsignatura.Text = "Asignatura";
            // 
            // labelCarrera
            // 
            this.labelCarrera.AutoSize = true;
            this.labelCarrera.ForeColor = System.Drawing.Color.Fuchsia;
            this.labelCarrera.Location = new System.Drawing.Point(37, 308);
            this.labelCarrera.Name = "labelCarrera";
            this.labelCarrera.Size = new System.Drawing.Size(41, 13);
            this.labelCarrera.TabIndex = 8;
            this.labelCarrera.Text = "Carrera";
            // 
            // labelHoraFinal
            // 
            this.labelHoraFinal.AutoSize = true;
            this.labelHoraFinal.ForeColor = System.Drawing.Color.Fuchsia;
            this.labelHoraFinal.Location = new System.Drawing.Point(37, 275);
            this.labelHoraFinal.Name = "labelHoraFinal";
            this.labelHoraFinal.Size = new System.Drawing.Size(55, 13);
            this.labelHoraFinal.TabIndex = 7;
            this.labelHoraFinal.Text = "Hora Final";
            // 
            // labelHoraInicio
            // 
            this.labelHoraInicio.AutoSize = true;
            this.labelHoraInicio.ForeColor = System.Drawing.Color.Fuchsia;
            this.labelHoraInicio.Location = new System.Drawing.Point(37, 237);
            this.labelHoraInicio.Name = "labelHoraInicio";
            this.labelHoraInicio.Size = new System.Drawing.Size(58, 13);
            this.labelHoraInicio.TabIndex = 6;
            this.labelHoraInicio.Text = "Hora Inicio";
            // 
            // labelFechaUso
            // 
            this.labelFechaUso.AutoSize = true;
            this.labelFechaUso.ForeColor = System.Drawing.Color.Fuchsia;
            this.labelFechaUso.Location = new System.Drawing.Point(37, 208);
            this.labelFechaUso.Name = "labelFechaUso";
            this.labelFechaUso.Size = new System.Drawing.Size(59, 13);
            this.labelFechaUso.TabIndex = 5;
            this.labelFechaUso.Text = "Fecha Uso";
            // 
            // labelFechaSolicitud
            // 
            this.labelFechaSolicitud.AutoSize = true;
            this.labelFechaSolicitud.ForeColor = System.Drawing.Color.Fuchsia;
            this.labelFechaSolicitud.Location = new System.Drawing.Point(37, 171);
            this.labelFechaSolicitud.Name = "labelFechaSolicitud";
            this.labelFechaSolicitud.Size = new System.Drawing.Size(80, 13);
            this.labelFechaSolicitud.TabIndex = 4;
            this.labelFechaSolicitud.Text = "Fecha Solicitud";
            // 
            // labelNivel
            // 
            this.labelNivel.AutoSize = true;
            this.labelNivel.ForeColor = System.Drawing.Color.Fuchsia;
            this.labelNivel.Location = new System.Drawing.Point(37, 135);
            this.labelNivel.Name = "labelNivel";
            this.labelNivel.Size = new System.Drawing.Size(31, 13);
            this.labelNivel.TabIndex = 3;
            this.labelNivel.Text = "Nivel";
            // 
            // labelAula
            // 
            this.labelAula.AutoSize = true;
            this.labelAula.ForeColor = System.Drawing.Color.Fuchsia;
            this.labelAula.Location = new System.Drawing.Point(37, 91);
            this.labelAula.Name = "labelAula";
            this.labelAula.Size = new System.Drawing.Size(28, 13);
            this.labelAula.TabIndex = 2;
            this.labelAula.Text = "Aula";
            // 
            // labelIdsolicitud
            // 
            this.labelIdsolicitud.AutoSize = true;
            this.labelIdsolicitud.ForeColor = System.Drawing.Color.Fuchsia;
            this.labelIdsolicitud.Location = new System.Drawing.Point(37, 48);
            this.labelIdsolicitud.Name = "labelIdsolicitud";
            this.labelIdsolicitud.Size = new System.Drawing.Size(54, 13);
            this.labelIdsolicitud.TabIndex = 1;
            this.labelIdsolicitud.Text = "Idsolicitud";
            // 
            // labelRegistrarSolicitud
            // 
            this.labelRegistrarSolicitud.AutoSize = true;
            this.labelRegistrarSolicitud.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelRegistrarSolicitud.Location = new System.Drawing.Point(201, 14);
            this.labelRegistrarSolicitud.Name = "labelRegistrarSolicitud";
            this.labelRegistrarSolicitud.Size = new System.Drawing.Size(92, 13);
            this.labelRegistrarSolicitud.TabIndex = 0;
            this.labelRegistrarSolicitud.Text = "Registrar Solicitud";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewSolicitud);
            this.tabPage2.Controls.Add(this.buttonEliminar);
            this.tabPage2.Controls.Add(this.buttonEditar);
            this.tabPage2.Controls.Add(this.textBoxBuscar);
            this.tabPage2.Controls.Add(this.labelBuscar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(531, 473);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalles";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSolicitud
            // 
            this.dataGridViewSolicitud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSolicitud.Location = new System.Drawing.Point(29, 150);
            this.dataGridViewSolicitud.Name = "dataGridViewSolicitud";
            this.dataGridViewSolicitud.Size = new System.Drawing.Size(465, 172);
            this.dataGridViewSolicitud.TabIndex = 4;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonEliminar.Location = new System.Drawing.Point(381, 64);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminar.TabIndex = 3;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonEditar.Location = new System.Drawing.Point(276, 65);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 2;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(99, 69);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(142, 20);
            this.textBoxBuscar.TabIndex = 1;
            this.textBoxBuscar.TextChanged += new System.EventHandler(this.textBoxBuscar_TextChanged);
            // 
            // labelBuscar
            // 
            this.labelBuscar.AutoSize = true;
            this.labelBuscar.ForeColor = System.Drawing.Color.Fuchsia;
            this.labelBuscar.Location = new System.Drawing.Point(26, 69);
            this.labelBuscar.Name = "labelBuscar";
            this.labelBuscar.Size = new System.Drawing.Size(40, 13);
            this.labelBuscar.TabIndex = 0;
            this.labelBuscar.Text = "Buscar";
            // 
            // fSolicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 523);
            this.Controls.Add(this.tabSolicitud);
            this.Name = "fSolicitud";
            this.Text = "fSolicitud";
            this.tabSolicitud.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSolicitud)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabSolicitud;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBoxCarrera;
        private System.Windows.Forms.TextBox textBoxAsignatura;
        private System.Windows.Forms.TextBox textBoxNivel;
        private System.Windows.Forms.TextBox textBoxAula;
        private System.Windows.Forms.TextBox textBoxIdsolicitud;
        private System.Windows.Forms.Label labelIdusuario;
        private System.Windows.Forms.Label labelIdrecursos;
        private System.Windows.Forms.Label labelAsignatura;
        private System.Windows.Forms.Label labelCarrera;
        private System.Windows.Forms.Label labelHoraFinal;
        private System.Windows.Forms.Label labelHoraInicio;
        private System.Windows.Forms.Label labelFechaUso;
        private System.Windows.Forms.Label labelFechaSolicitud;
        private System.Windows.Forms.Label labelNivel;
        private System.Windows.Forms.Label labelAula;
        private System.Windows.Forms.Label labelIdsolicitud;
        private System.Windows.Forms.Label labelRegistrarSolicitud;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox comboBoxIdusuario;
        private System.Windows.Forms.ComboBox comboBoxIdrecursos;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaUso;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaSolicitud;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.DataGridView dataGridViewSolicitud;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Label labelBuscar;
        private System.Windows.Forms.DateTimePicker dateTimePickerHoraFinal;
        private System.Windows.Forms.DateTimePicker dateTimePickerHoraInicio;
    }
}