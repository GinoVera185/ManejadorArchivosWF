namespace ManejadorArchivosWF;

partial class fm_ventanaInicio
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        btn_OpArch = new Button();
        btn_CreArch = new Button();
        btn_Cerrar = new Button();
        SuspendLayout();
        // 
        // btn_OpArch
        // 
        btn_OpArch.BackColor = Color.SeaGreen;
        btn_OpArch.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btn_OpArch.Location = new Point(43, 58);
        btn_OpArch.Name = "btn_OpArch";
        btn_OpArch.Size = new Size(242, 52);
        btn_OpArch.TabIndex = 0;
        btn_OpArch.Text = "Abrir Archivo";
        btn_OpArch.UseVisualStyleBackColor = false;
        btn_OpArch.Click += btn_OpArch_Click;
        // 
        // btn_CreArch
        // 
        btn_CreArch.BackColor = Color.SeaGreen;
        btn_CreArch.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btn_CreArch.Location = new Point(43, 128);
        btn_CreArch.Name = "btn_CreArch";
        btn_CreArch.Size = new Size(242, 52);
        btn_CreArch.TabIndex = 1;
        btn_CreArch.Text = "Crear Archivo";
        btn_CreArch.UseVisualStyleBackColor = false;
        btn_CreArch.Click += btn_CreArch_Click;
        // 
        // btn_Cerrar
        // 
        btn_Cerrar.BackColor = Color.Red;
        btn_Cerrar.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btn_Cerrar.Location = new Point(43, 197);
        btn_Cerrar.Name = "btn_Cerrar";
        btn_Cerrar.Size = new Size(242, 52);
        btn_Cerrar.TabIndex = 2;
        btn_Cerrar.Text = "Cerrar";
        btn_Cerrar.UseVisualStyleBackColor = false;
        btn_Cerrar.Click += btn_Cerrar_Click;
        // 
        // fm_ventanaInicio
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(128, 128, 255);
        ClientSize = new Size(338, 315);
        Controls.Add(btn_Cerrar);
        Controls.Add(btn_CreArch);
        Controls.Add(btn_OpArch);
        Name = "fm_ventanaInicio";
        Text = "Inicio";
        Load += Form1_Load;
        ResumeLayout(false);
    }

    #endregion

    private Button btn_OpArch;
    private Button btn_CreArch;
    private Button btn_Cerrar;
}
