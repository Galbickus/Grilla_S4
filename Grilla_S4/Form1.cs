using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grilla_S4
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void lblCodigo_Click(object sender, EventArgs e)
        {

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            // Agregar un renglon para la escritura
            int renglon = dtgvDatos.Rows.Add();
            // colocamos los datos en las columnas de esa fila
            dtgvDatos.Rows[renglon].Cells[0].Value = txtCodigo.Text;
            dtgvDatos.Rows[renglon].Cells[1].Value = txtDescripcion.Text;
            dtgvDatos.Rows[renglon].Cells[2].Value = txtCantidad.Text;
            // blanqueo de los textBox
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            txtCantidad.Text = "";
            // el foco se instala en el objeto
            txtCodigo.Focus();
        }

        private void dtgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int nro = e.RowIndex; // muestra la posición de la fila  seleccionada

            if (nro != -1)
            {
                MessageBox.Show((string)dtgvDatos.Rows[nro].Cells[1].Value);
            }
            else
            {
                MessageBox.Show("selección inválida");
            }
        }
    }
}
