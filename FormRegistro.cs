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
    public partial class FormRegistro : Form
    {
        public Registro Registro { get; private set; }
        private List<Campo> campos;

        public FormRegistro()
        {
            InitializeComponent();
        }

        public FormRegistro(List<Campo> campos, Registro registroExistente = null)
        {
            InitializeComponent();
            this.campos = campos;

            if (registroExistente != null)
            {
                Registro = registroExistente;
            }
            else
            {
                Registro = new Registro();
            }

            GenerarControles();
        }

        private void GenerarControles()
        {
            tbl_Registro.Controls.Clear();
            tbl_Registro.RowStyles.Clear();
            tbl_Registro.RowCount = 0;
            tbl_Registro.ColumnCount = 2;

            // Añadir fila para ID (solo lectura)
            tbl_Registro.RowCount++;
            tbl_Registro.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            Label lblId = new Label { Text = "ID:", AutoSize = true };
            TextBox txtId = new TextBox
            {
                Name = "ID",
                Text = Registro.ID.ToString(),
                ReadOnly = true,
                BackColor = Color.LightGray,
                Dock = DockStyle.Fill
            };

            tbl_Registro.Controls.Add(lblId, 0, 0);
            tbl_Registro.Controls.Add(txtId, 1, 0);

            // Añadir filas para cada campo
            for (int i = 0; i < campos.Count; i++)
            {
                var campo = campos[i];
                int rowIndex = i + 1; // La primera fila es para ID

                tbl_Registro.RowCount++;
                tbl_Registro.RowStyles.Add(new RowStyle(SizeType.AutoSize));

                Label lbl = new Label { Text = $"{campo.Nombre}:", AutoSize = true };
                Control ctrl = null;

                switch (campo.Tipo)
                {
                    case "Cadena":
                        ctrl = new TextBox
                        {
                            Name = campo.Nombre,
                            Text = Registro.GetValor(campo.Nombre)?.ToString() ?? "",
                            Dock = DockStyle.Fill
                        };
                        break;
                    case "Entero":
                        ctrl = new NumericUpDown
                        {
                            Name = campo.Nombre,
                            Minimum = int.MinValue,
                            Maximum = int.MaxValue,
                            Value = Registro.GetValor(campo.Nombre) is int IntVal ? IntVal : 0,
                            Dock = DockStyle.Fill
                        };
                        break;
                    case "Decimal":
                        ctrl = new NumericUpDown
                        {
                            Name = campo.Nombre,
                            DecimalPlaces = 2,
                            Minimum = decimal.MinValue,
                            Maximum = decimal.MaxValue,
                            Value = Registro.GetValor(campo.Nombre) is decimal DecVal ? DecVal : 0m,
                            Dock = DockStyle.Fill
                        };
                        break;
                    case "Booleano":
                        ctrl = new CheckBox
                        {
                            Name = campo.Nombre,
                            Checked = Convert.ToBoolean(Registro.GetValor(campo.Nombre) ?? false),
                            Dock = DockStyle.Left
                        };
                        break;
                }

                tbl_Registro.Controls.Add(lbl, 0, rowIndex);
                tbl_Registro.Controls.Add(ctrl, 1, rowIndex);
            }

            // Ajustar tamaño del formulario
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.MaximumSize = new Size(600, 800);
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            foreach (var campo in campos)
            {
                Control[] controles = tbl_Registro.Controls.Find(campo.Nombre, searchAllChildren: false);
                if (controles.Length == 0)
                {
                    MessageBox.Show($"Error interno: control no encontrado para '{campo.Nombre}'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Control ctrl = controles[0]; // Siempre debería haber uno

                if (campo.Tipo == "Cadena")
                {
                    string valor = ((TextBox)ctrl).Text;
                    if (string.IsNullOrWhiteSpace(valor))
                    {
                        MessageBox.Show($"El campo '{campo.Nombre}' no puede estar vacío.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ((TextBox)ctrl).Focus();
                        return;
                    }
                }                
            }

            foreach (var campo in campos)
            {
                Control ctrl = tbl_Registro.Controls.Find(campo.Nombre, false)[0];
                object valor = null;

                switch (campo.Tipo)
                {
                    case "Cadena":
                        valor = ((TextBox)ctrl).Text;
                        break;
                    case "Entero":
                        valor = (int)((NumericUpDown)ctrl).Value;
                        break;
                    case "Decimal":
                        valor = (decimal)((NumericUpDown)ctrl).Value;
                        break;
                    case "Booleano":
                        valor = ((CheckBox)ctrl).Checked;
                        break;
                }

                Registro.SetValor(campo.Nombre, valor);
            }

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
