namespace ManejadorArchivosWF
{
    partial class FormRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistro));
            btn_Aceptar = new Button();
            btn_Cancelar = new Button();
            tbl_Registro = new TableLayoutPanel();
            SuspendLayout();
            // 
            // btn_Aceptar
            // 
            btn_Aceptar.BackColor = Color.Lime;
            resources.ApplyResources(btn_Aceptar, "btn_Aceptar");
            btn_Aceptar.ForeColor = Color.Transparent;
            btn_Aceptar.Name = "btn_Aceptar";
            btn_Aceptar.UseVisualStyleBackColor = false;
            btn_Aceptar.Click += btn_Aceptar_Click;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.BackColor = Color.Red;
            resources.ApplyResources(btn_Cancelar, "btn_Cancelar");
            btn_Cancelar.ForeColor = Color.Transparent;
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = false;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // tbl_Registro
            // 
            resources.ApplyResources(tbl_Registro, "tbl_Registro");
            tbl_Registro.Name = "tbl_Registro";
            // 
            // FormRegistro
            // 
            AcceptButton = btn_Aceptar;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btn_Cancelar;
            Controls.Add(tbl_Registro);
            Controls.Add(btn_Cancelar);
            Controls.Add(btn_Aceptar);
            Name = "FormRegistro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_Aceptar;
        private Button btn_Cancelar;
        private TableLayoutPanel tbl_Registro;
    }
}