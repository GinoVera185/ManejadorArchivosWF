namespace ManejadorArchivosWF;

public partial class fm_ventanaInicio : Form
{
    
    public fm_ventanaInicio()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void btn_CreArch_Click(object sender, EventArgs e)
    {
        CrearArchivo crearArchivoForm = new CrearArchivo();
        crearArchivoForm.ShowDialog();
    }

    private void btn_OpArch_Click(object sender, EventArgs e)
    {
        try
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos DAT (*.dat)|*.dat";
                openFileDialog.Title = "Abrir archivo .dat";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ManejadorArchivo manejador = new ManejadorArchivo(openFileDialog.FileName);
                    manejador.Show();
                    this.Hide();
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al abrir el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
        
    }

    private void btn_Cerrar_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }
}
