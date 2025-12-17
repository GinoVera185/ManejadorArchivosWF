using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ManejadorArchivosWF
{
    public partial class FormEditarCampos : Form
    {
        public List<Campo> Campos { get; private set; } = new List<Campo>();
        private int indiceSeleccionado = -1;

        public FormEditarCampos(List<Campo> camposExistentes)
        {
            InitializeComponent();
            Campos = camposExistentes.ToList(); // Copia para no modificar original
            ActualizarDataGridView();
        }

        private void FormEditarCampos_Load(object sender, EventArgs e)
        {
            cmb_TipoDato.Items.AddRange(new string[] { "Entero", "Cadena", "Fecha", "Decimal", "Booleano" });
            cmb_TipoDato.SelectedIndex = -1;
            cmb_TipoDato.Text = "<Seleccione Tipo>";
        }

        private void ActualizarDataGridView()
        {
            dgv_Campos.Rows.Clear();
            foreach (var campo in Campos)
            {
                dgv_Campos.Rows.Add(campo.Nombre, campo.Tipo);
            }
        }

        private void btn_AgregarCampo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_NombreCampo.Text))
            {
                MessageBox.Show("Ingrese un nombre para el campo.");
                return;
            }

            if (cmb_TipoDato.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un tipo de dato.");
                return;
            }
            string nombre = txt_NombreCampo.Text.Trim();
            string tipo = cmb_TipoDato.SelectedItem.ToString();

            if (Campos.Any(c => c.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show($"Ya existe un campo con el nombre '{nombre}'.");
                return;
            }

            Campos.Add(new Campo(nombre, tipo));
            ActualizarDataGridView();
            LimpiarControles();

        }

        private void LimpiarControles()
        {
            txt_NombreCampo.Clear();
            cmb_TipoDato.SelectedIndex = -1;
            cmb_TipoDato.Text = "<Seleccione Tipo>";
        }

        private void btn_EditarCampo_Click(object sender, EventArgs e)
        {
            if (indiceSeleccionado == -1)
            {
                MessageBox.Show("Seleccione un campo para editar.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_NombreCampo.Text))
            {
                MessageBox.Show("Ingrese un nombre para el campo.");
                return;
            }

            if (cmb_TipoDato.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un tipo de dato.");
                return;
            }

            string nombre = txt_NombreCampo.Text.Trim();
            string tipo = cmb_TipoDato.SelectedItem.ToString();

            // Validar que no haya duplicados (excepto el mismo campo)
            if (Campos.Any(c => c.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase) && c != Campos[indiceSeleccionado]))
            {
                MessageBox.Show($"Ya existe un campo con el nombre '{nombre}'.");
                return;
            }

            Campos[indiceSeleccionado].Nombre = nombre;
            Campos[indiceSeleccionado].Tipo = tipo;

            ActualizarDataGridView();
            LimpiarControles();
            indiceSeleccionado = -1;
        }

        private void btn_EliminarCampo_Click(object sender, EventArgs e)
        {
            if (indiceSeleccionado == -1)
            {
                MessageBox.Show("Seleccione un campo para eliminar.");
                return;
            }

            if (Campos.Count <= 1)
            {
                MessageBox.Show("Debe haber al menos un campo.");
                return;
            }

            Campos.RemoveAt(indiceSeleccionado);
            ActualizarDataGridView();
            LimpiarControles();
            indiceSeleccionado = -1;
        }

        private void dgv_Campos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_Campos.SelectedRows.Count > 0)
            {
                indiceSeleccionado = dgv_Campos.SelectedRows[0].Index;
                var campo = Campos[indiceSeleccionado];
                txt_NombreCampo.Text = campo.Nombre;
                cmb_TipoDato.SelectedItem = campo.Tipo;
            }
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        
    }
}
