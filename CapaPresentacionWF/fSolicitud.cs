using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace CapaPresentacionWF
{
    public partial class fSolicitud : Form
    {
        logicaNegocioSolicitud logicaNS = new logicaNegocioSolicitud();
        logicaNegocioRecursos logicaRE = new logicaNegocioRecursos();
        logicaNegocioUsuarios logicaUS = new logicaNegocioUsuarios();

        public fSolicitud()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttonGuardar.Text == "Guardar")
                {
                    Solicitud objetosolicitud = new Solicitud();
                    objetosolicitud.aula = textBoxAula.Text;
                    objetosolicitud.nivel = textBoxNivel.Text;
                    objetosolicitud.fechasolicitud = Convert.ToDateTime(dateTimePickerFechaSolicitud.Text);
                    objetosolicitud.fechauso = Convert.ToDateTime(dateTimePickerFechaUso.Text);
                    objetosolicitud.horainicio = Convert.ToDateTime(dateTimePickerHoraInicio.Text);
                    objetosolicitud.horafinal = Convert.ToDateTime(dateTimePickerHoraFinal.Text);
                    objetosolicitud.carrera = textBoxCarrera.Text;
                    objetosolicitud.asignatura = textBoxAsignatura.Text;
                    objetosolicitud.idrecursos = Convert.ToInt32(comboBoxIdrecursos.SelectedValue.ToString());
                    objetosolicitud.idusuario = Convert.ToInt32(comboBoxIdusuario.SelectedValue.ToString());

                    if (logicaNS.insertarSolicitud(objetosolicitud) > 0)
                    {
                        MessageBox.Show("Agregado con èxito");
                        dataGridViewSolicitud.DataSource = logicaNS.ListarSolicitud();
                        textBoxAula.Text = "";
                        textBoxNivel.Text = "";
                        dateTimePickerFechaSolicitud.Text = "";
                        dateTimePickerFechaUso.Text = "";
                        dateTimePickerHoraInicio.Text = "";
                        dateTimePickerHoraFinal.Text = "";
                        textBoxCarrera.Text = "";
                        textBoxAsignatura.Text = "";
                        comboBoxIdrecursos.Text = "";
                        comboBoxIdusuario.Text = "";
                        tabSolicitud.SelectedTab = tabPage2;
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar Solicitud");
                    }
                    buttonGuardar.Text = "Guardar";
                }

                if (buttonGuardar.Text == "Actualizar")
                {
                    Solicitud objetosolicitud = new Solicitud();
                    objetosolicitud.Idsolicitud = Convert.ToInt32(textBoxIdsolicitud);
                    objetosolicitud.aula = textBoxAula.Text;
                    objetosolicitud.nivel = textBoxNivel.Text;
                    objetosolicitud.fechasolicitud = Convert.ToDateTime(dateTimePickerFechaSolicitud.Text);
                    objetosolicitud.fechauso = Convert.ToDateTime(dateTimePickerFechaUso.Text);
                    objetosolicitud.horainicio = Convert.ToDateTime(dateTimePickerHoraInicio.Text);
                    objetosolicitud.horafinal = Convert.ToDateTime(dateTimePickerHoraFinal.Text);
                    objetosolicitud.carrera = textBoxCarrera.Text;
                    objetosolicitud.asignatura = textBoxAsignatura.Text;
                    objetosolicitud.idrecursos = Convert.ToInt32(comboBoxIdrecursos.Text);
                    objetosolicitud.idusuario = Convert.ToInt32(comboBoxIdusuario.Text);

                    if (logicaNS.EditarSolicitud(objetosolicitud) > 0)
                    {
                        MessageBox.Show("Actualizada con èxito");
                        dataGridViewSolicitud.DataSource = logicaNS.ListarSolicitud();
                        textBoxAula.Text = "";
                        textBoxNivel.Text = "";
                        dateTimePickerFechaSolicitud.Text = "";
                        dateTimePickerFechaUso.Text = "";
                        dateTimePickerHoraInicio.Text = "";
                        dateTimePickerHoraFinal.Text = "";
                        textBoxCarrera.Text = "";
                        textBoxAsignatura.Text = "";
                        comboBoxIdrecursos.Text = "";
                        comboBoxIdusuario.Text = "";
                        tabSolicitud.SelectedTab = tabPage2;
                    }

                    else
                    {
                        MessageBox.Show("Error al actualizar");
                    }
                    buttonGuardar.Text = "Guardar";
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void fSolicitud_Load(object sender, EventArgs e)
        {
            textBoxIdsolicitud.Visible = false;
            labelIdsolicitud.Visible = false;

            var datos = logicaRE.listarRecursos();
            comboBoxIdrecursos.DataSource = (
                from recurso in datos
                select new
                {
                    recurso.idrecursos,
                    nombrerecurso = recurso.nombrer
                }
            ).ToList();

            comboBoxIdrecursos.ValueMember = "Idrecursos";
            comboBoxIdrecursos.DisplayMember = "nombrerecurso";

            var dato = logicaUS.listarUsuarios();
            comboBoxIdusuario.DataSource = (
                from usuario in dato
                select new
                {
                    usuario.idusuario,
                    nombreusuario = usuario.nombres + " " + usuario.apellidos
                    
                }
            ).ToList();

            comboBoxIdusuario.ValueMember = "Idusuario";
            comboBoxIdusuario.DisplayMember = "nombreusuario";

            dataGridViewSolicitud.DataSource = logicaNS.ListarSolicitud();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            textBoxIdsolicitud.Visible = true;
            textBoxIdsolicitud.Enabled = false;
            labelIdsolicitud.Visible = true;
            comboBoxIdrecursos.Visible = true;
            comboBoxIdrecursos.Enabled = false;
            labelIdrecursos.Visible = true;
            comboBoxIdusuario.Visible = true;
            comboBoxIdusuario.Enabled = false;
            labelIdusuario.Visible = true;


            textBoxIdsolicitud.Text = dataGridViewSolicitud.CurrentRow.Cells["idsolicitud"].Value.ToString();
            textBoxAula.Text = dataGridViewSolicitud.CurrentRow.Cells["aula"].Value.ToString();
            textBoxNivel.Text = dataGridViewSolicitud.CurrentRow.Cells["nivel"].Value.ToString();
            dateTimePickerFechaSolicitud.Text = dataGridViewSolicitud.CurrentRow.Cells["fechasolicitud"].Value.ToString();
            dateTimePickerFechaUso.Text = dataGridViewSolicitud.CurrentRow.Cells["fechauso"].Value.ToString();
            dateTimePickerHoraInicio.Text = dataGridViewSolicitud.CurrentRow.Cells["horainicio"].Value.ToString();
            dateTimePickerHoraFinal.Text = dataGridViewSolicitud.CurrentRow.Cells["horafinal"].Value.ToString();
            textBoxCarrera.Text = dataGridViewSolicitud.CurrentRow.Cells["carrera"].Value.ToString();
            textBoxAsignatura.Text = dataGridViewSolicitud.CurrentRow.Cells["asignatura"].Value.ToString();
            comboBoxIdrecursos.Text = dataGridViewSolicitud.CurrentRow.Cells["idrecursos"].Value.ToString();
            comboBoxIdusuario.Text = dataGridViewSolicitud.CurrentRow.Cells["idusuario"].Value.ToString();

            tabSolicitud.SelectedTab = tabPage1;
            buttonGuardar.Text = "Actualizar";
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int codigoSOL = Convert.ToInt32(dataGridViewSolicitud.CurrentRow.Cells["idsolicitud"].Value.ToString());
            try
            {
                if (logicaNS.EliminarSolicitud(codigoSOL) > 0)
                {
                    MessageBox.Show("Eliminado con èxito");
                    dataGridViewSolicitud.DataSource = logicaNS.ListarSolicitud();
                }
            }
            catch
            {
                MessageBox.Show("Error al eliminar recurso");
            }



        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            List<Solicitud> listaSolicitud = logicaNS.BuscarSolicitud(textBoxBuscar.Text);
            dataGridViewSolicitud.DataSource = listaSolicitud;
        }



    }
}