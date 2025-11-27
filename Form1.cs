namespace ManejadorArchivosWF;

public partial class fm_ventanaInicio : Form
{
    private List<Campo> camposArchivo;
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
        if (crearArchivoForm.ShowDialog() == DialogResult.OK)
        {
            camposArchivo = crearArchivoForm.camposDefinidos;

            ManejadorArchivo manejador = new ManejadorArchivo(crearArchivoForm.rutaArchivo, camposArchivo);
            manejador.Show();

            this.Hide();
        }
    }

    private void btn_OpArch_Click(object sender, EventArgs e)
    {
        using (OpenFileDialog openFileDialog = new OpenFileDialog())
        {
            openFileDialog.Filter = "Archivos DAT (*.dat)|*.dat|Todos los archivos (*.*)|*.*";
            openFileDialog.Title = "Abrir archivo .dat";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ManejadorArchivo manejador = new ManejadorArchivo(openFileDialog.FileName, new List<Campo>());
                manejador.Show();

            }
        }
        this.Hide();
    }

    private void btn_Cerrar_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }
}
