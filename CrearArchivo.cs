using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManejadorArchivosWF
{
    public partial class CrearArchivo : Form
    {
        public List<Campo> campos = new List<Campo>();
        //private string nombreArchivo = "";
        public CrearArchivo()
        {
            InitializeComponent();
        }

        public CrearArchivo(List<Campo> camposExistentes)
        {
            InitializeComponent();
            this.campos = camposExistentes.ToList(); // Copia para no modificar original
            ActualizarDataGridView();
        }

        private void CrearArchivo_Load(object sender, EventArgs e)
        {
            cmb_TipoDato.Items.AddRange(new string[] { "Cadena", "Entero", "Decimal", "Booleano" });
            cmb_TipoDato.SelectedIndex = -1;
            cmb_TipoDato.Text = "<Seleccione Tipo>";

            // Añadir columnas al DataGridView
            dgv_Campos.Columns.Clear();
            dgv_Campos.Columns.Add("colNombre", "Nombre");
            dgv_Campos.Columns.Add("colTipo", "Tipo");

            // Opcional: hacerlas autoajustables
            dgv_Campos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btn_Crear_Click(object sender, EventArgs e)
        {
            if (campos.Count == 0)
            {
                MessageBox.Show("Debe definir al menos un campo.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_NomArch.Text))
            {
                MessageBox.Show("Debe introducir el nombre del archivo.");
                return;
            }

            string nombreArchivo = txt_NomArch.Text.Trim();
            if (!nombreArchivo.EndsWith(".dat"))
                nombreArchivo += ".dat";

            try
            {
                using (FileStream fs = new FileStream(nombreArchivo, FileMode.Create, FileAccess.Write))
                using (BinaryWriter writer = new BinaryWriter(fs))
                {
                    // Escribir número de campos (int)
                    writer.Write(campos.Count);

                    // Escribir cada campo: nombre (string) + tipo (string)
                    foreach (var campo in campos)
                    {
                        writer.Write(campo.Nombre);
                        writer.Write(campo.Tipo);
                    }

                    // Opcional: escribir un registro vacío o dejarlo listo para datos
                    // Aquí solo guardamos la cabecera.
                }

                MessageBox.Show($"Estructura guardada en '{nombreArchivo}'.");
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}");
            }

        }

        private void btn_AgregarCampo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_NombreCampo.Text))
            {
                MessageBox.Show("Ingrese un nombre para el campo.");
                return;
            }

            if (cmb_TipoDato.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un tipo de dato.");
                return;
            }

            string nombre = txt_NombreCampo.Text.Trim();
            string tipo = cmb_TipoDato.SelectedItem.ToString();

            campos.Add(new Campo(nombre, tipo));

            // Actualizar DataGridView
            ActualizarDataGridView();
            txt_NombreCampo.Clear();
            txt_NombreCampo.Focus();

            // Limpiar campos
            txt_NombreCampo.Clear();
            cmb_TipoDato.SelectedIndex = -1;
            cmb_TipoDato.Text = "<Seleccione Tipo>";
        }
        private void ActualizarDataGridView()
        {
            dgv_Campos.Rows.Clear();
            foreach (var campo in campos)
            {
                dgv_Campos.Rows.Add(campo.Nombre, campo.Tipo);
            }
        }


    }
}
