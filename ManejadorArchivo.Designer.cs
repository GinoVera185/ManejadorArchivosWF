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
            dgv_Datos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_Datos).BeginInit();
            SuspendLayout();
            // 
            // btn_AgReg
            // 
            btn_AgReg.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_AgReg.Location = new Point(12, 27);
            btn_AgReg.Name = "btn_AgReg";
            btn_AgReg.Size = new Size(114, 66);
            btn_AgReg.TabIndex = 1;
            btn_AgReg.Text = "Agregar Registros";
            btn_AgReg.UseVisualStyleBackColor = true;
            btn_AgReg.Click += btn_AgReg_Click;
            // 
            // btn_cerrar
            // 
            btn_cerrar.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_cerrar.Location = new Point(695, 41);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(93, 44);
            btn_cerrar.TabIndex = 2;
            btn_cerrar.Text = "Cerrar";
            btn_cerrar.UseVisualStyleBackColor = true;
            btn_cerrar.Click += btn_cerrar_Click;
            // 
            // dgv_Datos
            // 
            dgv_Datos.AllowUserToAddRows = false;
            dgv_Datos.AllowUserToDeleteRows = false;
            dgv_Datos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Datos.Location = new Point(12, 99);
            dgv_Datos.Name = "dgv_Datos";
            dgv_Datos.ReadOnly = true;
            dgv_Datos.RowHeadersWidth = 51;
            dgv_Datos.Size = new Size(776, 322);
            dgv_Datos.TabIndex = 0;
            // 
            // ManejadorArchivo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_cerrar);
            Controls.Add(btn_AgReg);
            Controls.Add(dgv_Datos);
            Name = "ManejadorArchivo";
            Text = "ManejadorArchivo";
            ((System.ComponentModel.ISupportInitialize)dgv_Datos).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btn_AgReg;
        private Button btn_cerrar;
        private DataGridView dgv_Datos;
    }
}