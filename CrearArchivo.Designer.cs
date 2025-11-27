namespace ManejadorArchivosWF
{
    partial class CrearArchivo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txt_NomArch = new TextBox();
            label2 = new Label();
            txt_Campo = new TextBox();
            cb_TipoDatos = new ComboBox();
            btn_AgregarCampo = new Button();
            btn_Guardar = new Button();
            btn_cancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 29);
            label1.Name = "label1";
            label1.Size = new Size(209, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre Archivo: ";
            // 
            // txt_NomArch
            // 
            txt_NomArch.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_NomArch.Location = new Point(239, 26);
            txt_NomArch.MaxLength = 20;
            txt_NomArch.Name = "txt_NomArch";
            txt_NomArch.Size = new Size(231, 32);
            txt_NomArch.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 89);
            label2.Name = "label2";
            label2.Size = new Size(96, 25);
            label2.TabIndex = 2;
            label2.Text = "Campo:";
            // 
            // txt_Campo
            // 
            txt_Campo.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Campo.Location = new Point(124, 86);
            txt_Campo.MaxLength = 20;
            txt_Campo.Name = "txt_Campo";
            txt_Campo.Size = new Size(196, 32);
            txt_Campo.TabIndex = 2;
            // 
            // cb_TipoDatos
            // 
            cb_TipoDatos.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_TipoDatos.FormattingEnabled = true;
            cb_TipoDatos.Items.AddRange(new object[] { "Cadena", "Entero", "Flotante", "Booleano" });
            cb_TipoDatos.Location = new Point(342, 89);
            cb_TipoDatos.Name = "cb_TipoDatos";
            cb_TipoDatos.Size = new Size(222, 33);
            cb_TipoDatos.TabIndex = 3;
            cb_TipoDatos.Text = "<Seleccionar Tipo>";
            // 
            // btn_AgregarCampo
            // 
            btn_AgregarCampo.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_AgregarCampo.Location = new Point(22, 141);
            btn_AgregarCampo.Name = "btn_AgregarCampo";
            btn_AgregarCampo.Size = new Size(182, 39);
            btn_AgregarCampo.TabIndex = 4;
            btn_AgregarCampo.Text = "Agregar Campo";
            btn_AgregarCampo.UseVisualStyleBackColor = true;
            btn_AgregarCampo.Click += btn_AgregarCampo_Click;
            // 
            // btn_Guardar
            // 
            btn_Guardar.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Guardar.Location = new Point(306, 228);
            btn_Guardar.Name = "btn_Guardar";
            btn_Guardar.Size = new Size(126, 43);
            btn_Guardar.TabIndex = 5;
            btn_Guardar.Text = "Guardar";
            btn_Guardar.UseVisualStyleBackColor = true;
            btn_Guardar.Click += btn_Guardar_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_cancelar.Location = new Point(438, 228);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(126, 43);
            btn_cancelar.TabIndex = 6;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // CrearArchivo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 292);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_Guardar);
            Controls.Add(btn_AgregarCampo);
            Controls.Add(cb_TipoDatos);
            Controls.Add(txt_Campo);
            Controls.Add(label2);
            Controls.Add(txt_NomArch);
            Controls.Add(label1);
            Name = "CrearArchivo";
            Text = "CrearArchivo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_NomArch;
        private Label label2;
        private TextBox txt_Campo;
        private ComboBox cb_TipoDatos;
        private Button btn_AgregarCampo;
        private Button btn_Guardar;
        private Button btn_cancelar;
    }
}