using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManejadorArchivosWF
{
    public partial class CrearArchivo : Form
    {
        public List<Campo> camposDefinidos = new List<Campo>();
        
        public string rutaArchivo { get; private set; }
        public CrearArchivo()
        {
            InitializeComponent();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            string NombreArchivo = txt_NomArch.Text;
            if (string.IsNullOrEmpty(NombreArchivo))
            {
                MessageBox.Show("El nombre del archivo no puede estar vacio.");
                return;
            }

            if (camposDefinidos.Count == 0)
            {
                MessageBox.Show("Debe definir al menos un campo para el archivo.");
                return;
            }

            string rutaArchivo = NombreArchivo + ".dat";

            GuardarArchivo(rutaArchivo);

            MessageBox.Show($"Archivo {rutaArchivo} fue creado con exito, ahora puedes agregar registros");

            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void GuardarArchivo(string rutaArchivo)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Create(rutaArchivo)))
            {
                // Escribir número de campos
                writer.Write(camposDefinidos.Count);

                // Escribir definición de cada campo
                foreach (var campo in camposDefinidos)
                {
                    writer.Write(campo.Nombre);
                    writer.Write(campo.Tipo);
                }

                writer.Write(0);

                this.DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btn_AgregarCampo_Click(object sender, EventArgs e)
        {
            string nombreCampo = txt_Campo.Text.Trim();
            if (string.IsNullOrEmpty(nombreCampo))
            {
                MessageBox.Show("El nombre del campo no puede estar vacio.");
                return;
            }

            if (cb_TipoDatos.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un tipo de dato para el campo. ");
                return;
            }

            string tipoDato = cb_TipoDatos.SelectedItem.ToString();

            camposDefinidos.Add(new Campo 
            { 
                Nombre = nombreCampo, 
                Tipo =  tipoDato
            });

            txt_Campo.Clear();
            cb_TipoDatos.Text = "<Seleccionar tipo>";
            txt_Campo.Focus();

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
