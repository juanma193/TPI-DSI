using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TPIDSI.BaseDeDatos;

namespace TPIDSI
{
    public partial class PantallaRespuestaOperador : Form
    {
        public PantallaRespuestaOperador()
        {
            InitializeComponent();
        }
        private static GestorRespuestaOperador gestor = new GestorRespuestaOperador();

        private void PantallaRespuestaOperador_Load(object sender, EventArgs e)
        {
            this.Hide();
            gestor.seleccionComunicarseConOperador(llamadaIniciada, categoriaLlamada, opcionLlamada, subOpcion1, this);
        }

        internal void habilitarPantalla()
        {
            this.Show();
        }

        internal void mostrarDatosLlamada(string nombreCategoria, string nombreCliente, string nombreOpcion, string nombreSubOpcion)
        {
            lblNombreCategoria.Text = nombreCategoria;
            lblNombreCliente.Text = nombreCliente;
            lblNombreSubOpcion.Text = nombreSubOpcion;
            lblNombreOpcion.Text = nombreOpcion;
        }

        internal void mostrarMensajeValidacion(string mensajeVal)
        {
            lblMensajeValidacion.Text = mensajeVal;
        }

        internal void mostrarOpciones(List<string> descripcionOpciones)
        {
            cmbOpciones.Items.Clear();
            cmbOpciones.Text = "";
            foreach (string descripcion in descripcionOpciones)
            {
                cmbOpciones.Items.Add(descripcion);
            }
        }

        private void tomarRespuestaOpcion(object sender, EventArgs e)
        {
            GestorRespuestaOperador.tomarRespuestaOpcion(cmbOpciones.SelectedItem.ToString());
            gestor.realizarValidaciones();
        }

        internal void solicitarDescripcionRespuesta()
        {
            gbDescripcionOperador.Visible = true;
            gbAcciones.Visible = true;
            gbInfoCliente.Visible = false;
            gbInfoValidacion.Visible = false;
        }

        private void tomarDescripcionRespuesta(object sender, EventArgs e)
        {
            gestor.tomarDescripcionRespuesta(txtDescripcionOperador.Text);
        }

        internal void mostrarAcciones(List<string> descripcionesAccion)
        {
            gbDescripcionOperador.Enabled = false;
            cmbAcciones.Items.Clear();
            foreach (string descripcion in descripcionesAccion)
            {
                cmbAcciones.Items.Add(descripcion);
            }
            gbAcciones.Enabled = true;
        }

        internal void OpcionIncorrecta()
        {
            MessageBox.Show("Opcion incorrecta.");
        }

        private void tomarAccionSeleccionada(object sender, EventArgs e)
        {
            gbConfirmacion.Visible = true;
            gbConfirmacion.Enabled = true;
            gbAcciones.Enabled = false;
            gestor.tomarAccionSeleccionada(cmbAcciones.Text);
        }

        private void btnRechazarConfirmacion_Click(object sender, EventArgs e)
        {
            gbConfirmacion.Enabled = false;
            gbDescripcionOperador.Enabled = true;
            cmbAcciones.Text = "";
        }

        private void tomarConfirmacion(object sender, EventArgs e)
        {
            gestor.tomarConfirmacion();
            System.Windows.Forms.Application.Exit();
        }

        internal void informarSituacion()
        {
            MessageBox.Show("Se registro la accion con exito.");
        }

        private void btnFinLlamada_Click(object sender, EventArgs e)
        {
            gestor.finalizarLlamada();
            System.Windows.Forms.Application.Exit();
        }
    }
}
