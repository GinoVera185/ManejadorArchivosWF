using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManejadorArchivosWF
{
    public partial class ManejadorArchivo : Form
    {
        private List<Campo> campos = new List<Campo>();
        private List<Registro> registros = new List<Registro>();
        private string nombreArchivo = "";
        

        public ManejadorArchivo()
        {
            InitializeComponent();
        }
        public ManejadorArchivo(string Archivo)
        {
            InitializeComponent();
            nombreArchivo = Archivo;
            lbl_NombreArchivo.Text = Path.GetFileName(Archivo);
            CargarEstructura(Archivo); // Llama al método que ya tienes para cargar campos y registros
            ConfigurarDataGridView(); // Configura las columnas del DataGridView
            ActualizarDataGridView(); // Actualiza la tabla con los registros cargados
        }

        private void ManejadorArchivo_Load(object sender, EventArgs e)
        {
            //ConfigurarDataGridView();
        }

        private void CargarEstructura(string archivo)
        {
            if (!File.Exists(archivo))
                throw new FileNotFoundException($"El archivo '{archivo}' no existe.");

            using (FileStream fs = new FileStream(archivo, FileMode.Open, FileAccess.Read))
            using (BinaryReader reader = new BinaryReader(fs))
            {
                int cantidadCampos = reader.ReadInt32();
                campos.Clear();

                for (int i = 0; i < cantidadCampos; i++)
                {
                    string nombre = reader.ReadString();
                    string tipo = reader.ReadString();
                    campos.Add(new Campo(nombre, tipo));
                }

                // Leer registros (si existen)
                registros.Clear();
                while (fs.Position < fs.Length)
                {
                    var registro = new Registro();
                    foreach (var campo in campos)
                    {
                        object valor = null;
                        switch (campo.Tipo)
                        {
                            case "Cadena":
                                valor = reader.ReadString();
                                break;
                            case "Entero":
                                valor = reader.ReadInt32();
                                break;
                            case "Decimal":
                                valor = reader.ReadDecimal();
                                break;
                            case "Booleano":
                                valor = reader.ReadBoolean();
                                break;
                        }
                        registro.SetValor(campo.Nombre, valor);
                    }
                    registros.Add(registro);
                }
            }
        }

        private void btn_AgReg_Click(object sender, EventArgs e)
        {
            if (campos.Count == 0)
            {
                MessageBox.Show("No hay campos definidos. Cree un archivo primero.");
                return;
            }

            var nuevoRegistro = new Registro
            {
                ID = registros.Count + 1
            };

            // Crear un formulario para ingresar/editar datos
            using (var frm = new FormRegistro(campos, nuevoRegistro))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    registros.Add(nuevoRegistro);
                    ActualizarDataGridView();
                    GuardarArchivo(); // Opcional: guardar inmediatamente
                }
            }
        }

        private void btn_infoArch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nombreArchivo))
            {
                MessageBox.Show("No hay archivo cargado.");
                return;
            }

            string info = $"Ubicación: {nombreArchivo}\n\n" +
              $"Nombre: {Path.GetFileName(nombreArchivo)}\n\n" +
              $"Fecha de creación: {File.GetCreationTime(nombreArchivo)}\n\n" +
              $"Tamaño: {FormatoTamaño(new FileInfo(nombreArchivo).Length)}\n\n" +
              $"Campos:\n";

            foreach (var campo in campos)
            {
                info += $"- {campo.Nombre} ({campo.Tipo})\n";
            }
            info += $"\nRegistros: {registros.Count}";

            MessageBox.Show(info, "Información del Archivo");
        }

        private string FormatoTamaño(long bytes)
        {
            if (bytes < 1024) return $"{bytes} bytes";
            if (bytes < 1024 * 1024) return $"{bytes / 1024.0:F1} KB";
            if (bytes < 1024 * 1024 * 1024) return $"{bytes / (1024.0 * 1024):F1} MB";
            return $"{bytes / (1024.0 * 1024 * 1024):F1} GB";
        }

        private void btn_CambiarArchivo_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Archivos DAT (*.dat)|*.dat|Todos los archivos (*.*)|*.*";
                ofd.Title = "Seleccionar archivo .dat";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        nombreArchivo = ofd.FileName;
                        ConfigurarDataGridView();
                        ActualizarDataGridView();
                        MessageBox.Show("Archivo cargado correctamente.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al cargar el archivo: {ex.Message}");
                    }
                }
            }
        }

        private void btn_EliminarRegistro_Click(object sender, EventArgs e)
        {
            if (dgv_Registros.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un registro para eliminar.");
                return;
            }

            int indice = dgv_Registros.SelectedRows[0].Index;
            registros.RemoveAt(indice);

            for (int i = 0; i < registros.Count; i++)
            {
                registros[i].ID = i + 1;
            }

            ActualizarDataGridView();
            GuardarArchivo(); // Opcional: guardar inmediatamente
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void ConfigurarDataGridView()
        {
            dgv_Registros.Columns.Clear();
            dgv_Registros.Columns.Add("ID", "ID");

            foreach (var campo in campos)
            {
                dgv_Registros.Columns.Add(campo.Nombre, campo.Nombre);
            }
            dgv_Registros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ActualizarDataGridView()
        {
            dgv_Registros.Rows.Clear();
            foreach (var registro in registros)
            {
                var row = new string[campos.Count + 1]; // +1 para la columna ID
                row[0] = registro.ID.ToString();        // Columna 0 = ID

                for (int i = 0; i < campos.Count; i++)
                {
                    var campo = campos[i];
                    var valor = registro.GetValor(campo.Nombre);
                    row[i + 1] = valor?.ToString() ?? "(vacío)";
                }
                dgv_Registros.Rows.Add(row);
            }
        }

        private void GuardarArchivo()
        {
            using (FileStream fs = new FileStream(nombreArchivo, FileMode.Create, FileAccess.Write))
            using (BinaryWriter writer = new BinaryWriter(fs))
            {
                // Escribir cabecera
                writer.Write(campos.Count);
                foreach (var campo in campos)
                {
                    writer.Write(campo.Nombre);
                    writer.Write(campo.Tipo);
                }

                // Escribir registros
                foreach (var registro in registros)
                {
                    foreach (var campo in campos)
                    {
                        var valor = registro.GetValor(campo.Nombre);
                        switch (campo.Tipo)
                        {
                            case "Cadena":
                                writer.Write(valor?.ToString() ?? "");
                                break;
                            case "Entero":
                                writer.Write(Convert.ToInt32(valor ?? 0));
                                break;
                            case "Decimal":
                                writer.Write(Convert.ToDecimal(valor ?? 0m));
                                break;
                            case "Booleano":
                                writer.Write(Convert.ToBoolean(valor ?? false));
                                break;
                        }
                    }
                }
            }
        }

        private void ActualizarEstadoBotones()
        {
            btn_AgrEditCampo.Enabled = registros.Count == 0;
        }

        private void btn_AgrEditCampo_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_EditRegistro_Click(object sender, EventArgs e)
        {
            if (dgv_Registros.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un registro para editar.");
                return;
            }

            int indice = dgv_Registros.SelectedRows[0].Index;
            var registroSeleccionado = registros[indice];

            using (var frm = new FormRegistro(campos, registroSeleccionado))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    // El registro ya fue modificado por FormRegistro
                    ActualizarDataGridView();
                    GuardarArchivo();
                }
            }
        }
    }
}
