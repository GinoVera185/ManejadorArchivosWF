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
            btn_Crear = new Button();
            btn_cancelar = new Button();
            label2 = new Label();
            txt_NombreCampo = new TextBox();
            cmb_TipoDato = new ComboBox();
            btn_AgregarCampo = new Button();
            dgv_Campos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_Campos).BeginInit();
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
            // btn_Crear
            // 
            btn_Crear.BackColor = Color.Lime;
            btn_Crear.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Crear.ForeColor = Color.Transparent;
            btn_Crear.Location = new Point(274, 321);
            btn_Crear.Name = "btn_Crear";
            btn_Crear.Size = new Size(126, 43);
            btn_Crear.TabIndex = 5;
            btn_Crear.Text = "Crear";
            btn_Crear.UseVisualStyleBackColor = false;
            btn_Crear.Click += btn_Crear_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.BackColor = Color.Red;
            btn_cancelar.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_cancelar.ForeColor = Color.Transparent;
            btn_cancelar.Location = new Point(406, 321);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(126, 43);
            btn_cancelar.TabIndex = 6;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = false;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 69);
            label2.Name = "label2";
            label2.Size = new Size(96, 25);
            label2.TabIndex = 7;
            label2.Text = "Campo:";
            // 
            // txt_NombreCampo
            // 
            txt_NombreCampo.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_NombreCampo.Location = new Point(124, 66);
            txt_NombreCampo.MaxLength = 20;
            txt_NombreCampo.Name = "txt_NombreCampo";
            txt_NombreCampo.Size = new Size(231, 32);
            txt_NombreCampo.TabIndex = 2;
            // 
            // cmb_TipoDato
            // 
            cmb_TipoDato.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmb_TipoDato.FormattingEnabled = true;
            cmb_TipoDato.Location = new Point(369, 70);
            cmb_TipoDato.Name = "cmb_TipoDato";
            cmb_TipoDato.Size = new Size(163, 26);
            cmb_TipoDato.TabIndex = 3;
            cmb_TipoDato.Text = "<Seleccione Tipo>";
            // 
            // btn_AgregarCampo
            // 
            btn_AgregarCampo.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_AgregarCampo.Location = new Point(35, 104);
            btn_AgregarCampo.Name = "btn_AgregarCampo";
            btn_AgregarCampo.Size = new Size(165, 33);
            btn_AgregarCampo.TabIndex = 4;
            btn_AgregarCampo.Text = "Agregar Campo";
            btn_AgregarCampo.UseVisualStyleBackColor = true;
            btn_AgregarCampo.Click += btn_AgregarCampo_Click;
            // 
            // dgv_Campos
            // 
            dgv_Campos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Campos.Location = new Point(23, 154);
            dgv_Campos.Name = "dgv_Campos";
            dgv_Campos.RowHeadersWidth = 51;
            dgv_Campos.Size = new Size(510, 164);
            dgv_Campos.TabIndex = 8;
            // 
            // CrearArchivo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(547, 376);
            Controls.Add(dgv_Campos);
            Controls.Add(btn_AgregarCampo);
            Controls.Add(cmb_TipoDato);
            Controls.Add(txt_NombreCampo);
            Controls.Add(label2);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_Crear);
            Controls.Add(txt_NomArch);
            Controls.Add(label1);
            Name = "CrearArchivo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CrearArchivo";
            Load += CrearArchivo_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Campos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_NomArch;
        private Button btn_Crear;
        private Button btn_cancelar;
        private Label label2;
        private TextBox txt_NombreCampo;
        private ComboBox cmb_TipoDato;
        private Button btn_AgregarCampo;
        private DataGridView dgv_Campos;
    }
}