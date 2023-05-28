using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void tomarRespuesta(object sender, EventArgs e)
        {
            GestorRespuestaOperador.tomarRespuesta(cmbOpciones.SelectedItem.ToString());
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
            foreach (string descripcion in descripcionesAccion)
            {
                cmbAcciones.Items.Add(descripcion);
            }
            gbAcciones.Enabled = true;
        }

        private void tomarAccionSeleccionada(object sender, EventArgs e)
        {
            gbConfirmacion.Visible = true;
            gbConfirmacion.Enabled = true;
            gbAcciones.Enabled = false;
        }

        private void btnRechazarConfirmacion_Click(object sender, EventArgs e)
        {
            gbConfirmacion.Enabled = false;
            gbDescripcionOperador.Enabled = true;
        }

        private void tomarConfirmacion(object sender, EventArgs e)
        {
            gestor.tomarAccionSeleccionada(cmbAcciones.Text);
        }

        internal void informarSituacion()
        {
            MessageBox.Show("Se registro la accion con exito.");
        }
    }
}
