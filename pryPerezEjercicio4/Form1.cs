namespace pryPerezEjercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // --- NUESTRAS VARIABLES GLOBALES ---

        // 1. El arreglo bidimensional (Matriz) que pide el enunciado
        // [5, 4] significa: 5 filas (Mozos) y 4 columnas (Categorías)
        float[,] ventas;

        // 2. Un array simple para los nombres de los mozos
        //    Lo usaremos para saber el nombre del "Mozo del Día"
        string[] nombresMozos = { "Julio", "Esteban", "Javier", "Gonzalo", "Alberto" };
    }
}
