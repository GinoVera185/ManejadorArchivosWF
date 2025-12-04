namespace ManejadorArchivosWF
{
    partial class ManejadorArchivo
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
            btn_AgReg = new Button();
            btn_cerrar = new Button();
            dgv_Registros = new DataGridView();
            btn_infoArch = new Button();
            btn_EditRegistro = new Button();
            btn_EliminarRegistro = new Button();
            btn_CambiarArchivo = new Button();
            label1 = new Label();
            lbl_NombreArchivo = new Label();
            btn_AgrEditCampo = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_Registros).BeginInit();
            SuspendLayout();
            // 
            // btn_AgReg
            // 
            btn_AgReg.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_AgReg.Location = new Point(669, 128);
            btn_AgReg.Name = "btn_AgReg";
            btn_AgReg.Size = new Size(182, 60);
            btn_AgReg.TabIndex = 3;
            btn_AgReg.Text = "Agregar Registro";
            btn_AgReg.UseVisualStyleBackColor = true;
            btn_AgReg.Click += btn_AgReg_Click;
            // 
            // btn_cerrar
            // 
            btn_cerrar.BackColor = Color.Red;
            btn_cerrar.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_cerrar.ForeColor = Color.Transparent;
            btn_cerrar.Location = new Point(758, 433);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(93, 44);
            btn_cerrar.TabIndex = 7;
            btn_cerrar.Text = "Cerrar";
            btn_cerrar.UseVisualStyleBackColor = false;
            btn_cerrar.Click += btn_cerrar_Click;
            // 
            // dgv_Registros
            // 
            dgv_Registros.AllowUserToAddRows = false;
            dgv_Registros.AllowUserToDeleteRows = false;
            dgv_Registros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Registros.Location = new Point(12, 62);
            dgv_Registros.Name = "dgv_Registros";
            dgv_Registros.ReadOnly = true;
            dgv_Registros.RowHeadersWidth = 51;
            dgv_Registros.Size = new Size(651, 415);
            dgv_Registros.TabIndex = 0;
            // 
            // btn_infoArch
            // 
            btn_infoArch.BackColor = SystemColors.HotTrack;
            btn_infoArch.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_infoArch.ForeColor = SystemColors.ButtonHighlight;
            btn_infoArch.Location = new Point(722, 12);
            btn_infoArch.Name = "btn_infoArch";
            btn_infoArch.Size = new Size(93, 44);
            btn_infoArch.TabIndex = 1;
            btn_infoArch.Text = "Info.";
            btn_infoArch.UseVisualStyleBackColor = false;
            btn_infoArch.Click += btn_infoArch_Click;
            // 
            // btn_EditRegistro
            // 
            btn_EditRegistro.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_EditRegistro.Location = new Point(669, 194);
            btn_EditRegistro.Name = "btn_EditRegistro";
            btn_EditRegistro.Size = new Size(182, 55);
            btn_EditRegistro.TabIndex = 4;
            btn_EditRegistro.Text = "Editar Registro";
            btn_EditRegistro.UseVisualStyleBackColor = true;
            btn_EditRegistro.Click += btn_EditRegistro_Click;
            // 
            // btn_EliminarRegistro
            // 
            btn_EliminarRegistro.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_EliminarRegistro.Location = new Point(669, 255);
            btn_EliminarRegistro.Name = "btn_EliminarRegistro";
            btn_EliminarRegistro.Size = new Size(182, 60);
            btn_EliminarRegistro.TabIndex = 5;
            btn_EliminarRegistro.Text = "Eliminar Registro";
            btn_EliminarRegistro.UseVisualStyleBackColor = true;
            btn_EliminarRegistro.Click += btn_EliminarRegistro_Click;
            // 
            // btn_CambiarArchivo
            // 
            btn_CambiarArchivo.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_CambiarArchivo.Location = new Point(669, 321);
            btn_CambiarArchivo.Name = "btn_CambiarArchivo";
            btn_CambiarArchivo.Size = new Size(182, 60);
            btn_CambiarArchivo.TabIndex = 6;
            btn_CambiarArchivo.Text = "Cambiar Archivo";
            btn_CambiarArchivo.UseVisualStyleBackColor = true;
            btn_CambiarArchivo.Click += btn_CambiarArchivo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 16);
            label1.Name = "label1";
            label1.Size = new Size(106, 25);
            label1.TabIndex = 7;
            label1.Text = "Archivo:";
            // 
            // lbl_NombreArchivo
            // 
            lbl_NombreArchivo.AutoSize = true;
            lbl_NombreArchivo.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_NombreArchivo.Location = new Point(131, 16);
            lbl_NombreArchivo.Name = "lbl_NombreArchivo";
            lbl_NombreArchivo.Size = new Size(174, 25);
            lbl_NombreArchivo.TabIndex = 9;
            lbl_NombreArchivo.Text = "Nombre Archivo";
            // 
            // btn_AgrEditCampo
            // 
            btn_AgrEditCampo.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_AgrEditCampo.Location = new Point(669, 62);
            btn_AgrEditCampo.Name = "btn_AgrEditCampo";
            btn_AgrEditCampo.Size = new Size(182, 60);
            btn_AgrEditCampo.TabIndex = 2;
            btn_AgrEditCampo.Text = "Agregar/Editar Campo";
            btn_AgrEditCampo.UseVisualStyleBackColor = true;
            btn_AgrEditCampo.Click += btn_AgrEditCampo_Click;
            // 
            // ManejadorArchivo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(875, 489);
            Controls.Add(btn_AgrEditCampo);
            Controls.Add(lbl_NombreArchivo);
            Controls.Add(label1);
            Controls.Add(btn_CambiarArchivo);
            Controls.Add(btn_EliminarRegistro);
            Controls.Add(btn_EditRegistro);
            Controls.Add(btn_infoArch);
            Controls.Add(btn_cerrar);
            Controls.Add(btn_AgReg);
            Controls.Add(dgv_Registros);
            Name = "ManejadorArchivo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManejadorArchivo";
            ((System.ComponentModel.ISupportInitialize)dgv_Registros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_AgReg;
        private Button btn_cerrar;
        private DataGridView dgv_Registros;
        private Button btn_infoArch;
        private Button btn_EditRegistro;
        private Button btn_EliminarRegistro;
        private Button btn_CambiarArchivo;
        private Label label1;
        private Label label2;
        private Label lbl_NombreArchivo;
        private Button btn_AgrEditCampo;
    }
}