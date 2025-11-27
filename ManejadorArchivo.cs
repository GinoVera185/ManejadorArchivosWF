using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManejadorArchivosWF
{
    public partial class ManejadorArchivo : Form
    {
        private string rutaArchivo;
        public List<Campo> campos;
        private int cantidadRegistros = 0;
        public ManejadorArchivo()
        {
            InitializeComponent();
        }
        public ManejadorArchivo(string rutaArchivo, List<Campo> campos)
        {
            InitializeComponent();
            this.rutaArchivo = rutaArchivo;
            this.campos = campos;
        }

        private void ManejadorArchivo_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(rutaArchivo))
            {
                CargarArchivo(rutaArchivo);
            }
        }

        private void CargarArchivo(string rutaArchivo)
        {
            try
            {
                dgv_Datos.Rows.Clear();
                dgv_Datos.Columns.Clear();
                campos.Clear();

                using (BinaryReader reader = new BinaryReader(File.Open(rutaArchivo, FileMode.Open)))
                {
                    // Leer cantidad de campos
                    int cantCampos = reader.ReadInt32();

                    for (int i = 0; i < cantCampos; i++)
                    {
                        string nombre = reader.ReadString();
                        string tipo = reader.ReadString();

                        campos.Add(new Campo
                        {
                            Nombre = nombre,
                            Tipo = tipo
                        });
                    }

                    // Crear columnas en el DataGridView
                    GenerarColumnas();

                    // Leer cantidad de registros
                    cantidadRegistros = reader.ReadInt32();

                    // Cargar registros
                    for (int r = 0; r < cantidadRegistros; r++)
                    {
                        object[] valores = new object[campos.Count];

                        for (int c = 0; c < campos.Count; c++)
                        {
                            string tipo = campos[c].Tipo;

                            // Convertir el tipo correspondiente
                            if (tipo == "int")
                                valores[c] = reader.ReadInt32();
                            else if (tipo == "float")
                                valores[c] = reader.ReadSingle();
                            else
                                valores[c] = reader.ReadString();
                        }

                        dgv_Datos.Rows.Add(valores);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenerarColumnas()
        {
            dgv_Datos.Columns.Clear();

            foreach (var campo in campos)
            {
                dgv_Datos.Columns.Add(campo.Nombre, campo.Nombre);
            }
        }

        private void btn_AgReg_Click(object sender, EventArgs e)
        {

        }

        private void GuardarRegistro(string rutaArchivo)
        {
            List<object[]> registros = new List<object[]>();

            // Leer archivo actual
            using (BinaryReader reader = new BinaryReader(File.Open(rutaArchivo, FileMode.Open)))
            {
                int cantCampos = reader.ReadInt32();

                // Saltar lectura de campos
                for (int i = 0; i < cantCampos; i++)
                {
                    reader.ReadString();
                    reader.ReadString();
                }

                int cantReg = reader.ReadInt32();

                for (int r = 0; r < cantReg; r++)
                {
                    object[] valores = new object[campos.Count];

                    for (int c = 0; c < campos.Count; c++)
                    {
                        if (campos[c].Tipo == "int")
                            valores[c] = reader.ReadInt32();
                        else if (campos[c].Tipo == "float")
                            valores[c] = reader.ReadSingle();
                        else
                            valores[c] = reader.ReadString();
                    }

                    registros.Add(valores);
                }
            }

            // Agregar el registro nuevo desde el DataGridView
            object[] nuevo = new object[campos.Count];
            int lastRow = dgv_Datos.Rows.Count - 1;

            for (int c = 0; c < campos.Count; c++)
            {
                nuevo[c] = dgv_Datos.Rows[lastRow].Cells[c].Value;
            }

            registros.Add(nuevo);

            // Guardar todo otra vez
            using (BinaryWriter writer = new BinaryWriter(File.Open(rutaArchivo, FileMode.Create)))
            {
                writer.Write(campos.Count);

                foreach (var campo in campos)
                {
                    writer.Write(campo.Nombre);
                    writer.Write(campo.Tipo);
                }

                writer.Write(registros.Count);

                foreach (var reg in registros)
                {
                    for (int c = 0; c < campos.Count; c++)
                    {
                        if (campos[c].Tipo == "int")
                            writer.Write(Convert.ToInt32(reg[c]));
                        else if (campos[c].Tipo == "float")
                            writer.Write(Convert.ToSingle(reg[c]));
                        else
                            writer.Write(reg[c].ToString());
                    }
                }
            }
        }


        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
