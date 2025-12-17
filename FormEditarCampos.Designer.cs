namespace ManejadorArchivosWF
{
    partial class FormEditarCampos
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
            label2 = new Label();
            txt_NombreCampo = new TextBox();
            cmb_TipoDato = new ComboBox();
            dgv_Campos = new DataGridView();
            colNombre = new DataGridViewTextBoxColumn();
            colTipo = new DataGridViewTextBoxColumn();
            btn_AgregarCampo = new Button();
            btn_EliminarCampo = new Button();
            btn_Cancelar = new Button();
            btn_Aceptar = new Button();
            btn_EditarCampo = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_Campos).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 32);
            label2.Name = "label2";
            label2.Size = new Size(103, 25);
            label2.TabIndex = 2;
            label2.Text = "Campo: ";
            // 
            // txt_NombreCampo
            // 
            txt_NombreCampo.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_NombreCampo.Location = new Point(127, 29);
            txt_NombreCampo.Name = "txt_NombreCampo";
            txt_NombreCampo.Size = new Size(210, 32);
            txt_NombreCampo.TabIndex = 1;
            // 
            // cmb_TipoDato
            // 
            cmb_TipoDato.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmb_TipoDato.FormattingEnabled = true;
            cmb_TipoDato.Location = new Point(364, 32);
            cmb_TipoDato.Name = "cmb_TipoDato";
            cmb_TipoDato.Size = new Size(163, 26);
            cmb_TipoDato.TabIndex = 2;
            cmb_TipoDato.Text = "<Seleccione Tipo>";
            // 
            // dgv_Campos
            // 
            dgv_Campos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Campos.Columns.AddRange(new DataGridViewColumn[] { colNombre, colTipo });
            dgv_Campos.Location = new Point(12, 146);
            dgv_Campos.Name = "dgv_Campos";
            dgv_Campos.RowHeadersWidth = 51;
            dgv_Campos.Size = new Size(510, 164);
            dgv_Campos.TabIndex = 6;
            dgv_Campos.SelectionChanged += dgv_Campos_SelectionChanged;
            // 
            // colNombre
            // 
            colNombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colNombre.HeaderText = "Nombre";
            colNombre.MinimumWidth = 6;
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            // 
            // colTipo
            // 
            colTipo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colTipo.HeaderText = "Tipo";
            colTipo.MinimumWidth = 6;
            colTipo.Name = "colTipo";
            colTipo.ReadOnly = true;
            // 
            // btn_AgregarCampo
            // 
            btn_AgregarCampo.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_AgregarCampo.Location = new Point(12, 80);
            btn_AgregarCampo.Name = "btn_AgregarCampo";
            btn_AgregarCampo.Size = new Size(165, 33);
            btn_AgregarCampo.TabIndex = 3;
            btn_AgregarCampo.Text = "Agregar Campo";
            btn_AgregarCampo.UseVisualStyleBackColor = true;
            btn_AgregarCampo.Click += btn_AgregarCampo_Click;
            // 
            // btn_EliminarCampo
            // 
            btn_EliminarCampo.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_EliminarCampo.Location = new Point(354, 80);
            btn_EliminarCampo.Name = "btn_EliminarCampo";
            btn_EliminarCampo.Size = new Size(165, 33);
            btn_EliminarCampo.TabIndex = 5;
            btn_EliminarCampo.Text = "Eliminar Campo";
            btn_EliminarCampo.UseVisualStyleBackColor = true;
            btn_EliminarCampo.Click += btn_EliminarCampo_Click;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.BackColor = Color.Red;
            btn_Cancelar.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Cancelar.ForeColor = Color.Transparent;
            btn_Cancelar.Location = new Point(397, 325);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(126, 43);
            btn_Cancelar.TabIndex = 8;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = false;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // btn_Aceptar
            // 
            btn_Aceptar.BackColor = Color.Lime;
            btn_Aceptar.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Aceptar.ForeColor = Color.Transparent;
            btn_Aceptar.Location = new Point(265, 325);
            btn_Aceptar.Name = "btn_Aceptar";
            btn_Aceptar.Size = new Size(126, 43);
            btn_Aceptar.TabIndex = 7;
            btn_Aceptar.Text = "Aceptar";
            btn_Aceptar.UseVisualStyleBackColor = false;
            btn_Aceptar.Click += btn_Aceptar_Click;
            // 
            // btn_EditarCampo
            // 
            btn_EditarCampo.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_EditarCampo.Location = new Point(183, 80);
            btn_EditarCampo.Name = "btn_EditarCampo";
            btn_EditarCampo.Size = new Size(165, 33);
            btn_EditarCampo.TabIndex = 9;
            btn_EditarCampo.Text = "Editar Campo";
            btn_EditarCampo.UseVisualStyleBackColor = true;
            btn_EditarCampo.Click += btn_EditarCampo_Click;
            // 
            // FormEditarCampos
            // 
            AcceptButton = btn_Aceptar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            CancelButton = btn_Cancelar;
            ClientSize = new Size(535, 383);
            Controls.Add(btn_EditarCampo);
            Controls.Add(btn_Cancelar);
            Controls.Add(btn_Aceptar);
            Controls.Add(btn_EliminarCampo);
            Controls.Add(btn_AgregarCampo);
            Controls.Add(dgv_Campos);
            Controls.Add(cmb_TipoDato);
            Controls.Add(txt_NombreCampo);
            Controls.Add(label2);
            Name = "FormEditarCampos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar_Campos";
            Load += FormEditarCampos_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Campos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox txt_NombreCampo;
        private ComboBox cmb_TipoDato;
        private DataGridView dgv_Campos;
        private Button btn_AgregarCampo;
        private Button button1;
        private Button btn_EliminarCampo;
        private Button btn_Cancelar;
        private Button btn_Aceptar;
        private Button btn_EditarCampo;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colTipo;
    }
}