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

        private void Form1_Load(object sender, EventArgs e)
        {
            // --- 1. CARGAMOS LAS FILAS DE LA GRILLA ---
            // Usamos el método .Rows.Add()
            // El primer valor "Julio" irá a la primera columna (colMozos)
            // Los siguientes valores ("0") son los valores por defecto para las 4 categorías.
            dgvVentas.Rows.Add("Julio", "0", "0", "0", "0");
            dgvVentas.Rows.Add("Esteban", "0", "0", "0", "0");
            dgvVentas.Rows.Add("Javier", "0", "0", "0", "0");
            dgvVentas.Rows.Add("Gonzalo", "0", "0", "0", "0");
            dgvVentas.Rows.Add("Alberto", "0", "0", "0", "0");

            // --- 2. DESHABILITAMOS BOTONES ---
            // El enunciado pide que los botones de consulta solo se activen
            // después de presionar "Validar Datos".
            btnMozoDelDia.Enabled = false;
            btnTotales.Enabled = false;
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            // --- 1. INICIALIZAMOS LA MATRIZ ---
            ventas = new float[5, 4];

            // --- 2. CONTROL DE ERRORES (try-catch) ---
            // Esta es la nueva lógica que permite celdas vacías (las toma como 0)
            // pero falla si encuentra letras (ej: "abc").
            try
            {
                // --- 3. RECORRIDO DE FILAS (MOZOS) ---
                for (int f = 0; f < 5; f++)
                {
                    // --- 4. RECORRIDO DE COLUMNAS (CATEGORÍAS) ---
                    for (int c = 1; c < 5; c++)
                    {
                        // 5. LECTURA Y CONVERSIÓN (LÓGICA MEJORADA)

                        // Leemos el valor de la celda de forma segura.
                        string valorCelda = Convert.ToString(dgvVentas.Rows[f].Cells[c].Value);

                        // Declaramos 'importe' y le damos un valor por defecto de 0.
                        float importe = 0;

                        // AHORA PREGUNTAMOS: ¿La celda NO está vacía?
                        if (valorCelda != "")
                        {
                            // Si NO está vacía (ej: "150" o "abc"),
                            // intentamos convertirla a número.
                            // Si tiene "abc", ESTA LÍNEA FALLA y salta al 'catch'.
                            importe = float.Parse(valorCelda);
                        }
                        // Si la celda SÍ estaba vacía, 'importe' se queda con el valor 0.

                        // 6. GUARDADO EN LA MATRIZ
                        ventas[f, c - 1] = importe;
                    }
                }

                // --- 7. VALIDACIÓN EXITOSA ---
                MessageBox.Show("Datos validados correctamente. (Celdas vacías se tomaron como 0)");

                // HABILITAMOS los botones
                btnMozoDelDia.Enabled = true;
                btnTotales.Enabled = true;
            }
            catch (Exception ex)
            {
                // --- 8. ERROR DE VALIDACIÓN ---
                // El 'try' falló (ej: una celda con "abc").
                MessageBox.Show("Error: Verifique que todas las celdas tengan un valor numérico. (No se permiten letras).");

                // Nos aseguramos de que los botones sigan deshabilitados.
                btnMozoDelDia.Enabled = false;
                btnTotales.Enabled = false;
            }
        }

        private void btnMozoDelDia_Click(object sender, EventArgs e)
        {
            // --- 1. PREPARAMOS LAS VARIABLES ---

            // Una variable para guardar el total de venta MÁS ALTO que encontremos.
            // La inicializamos en -1 (o un número bajo) para que la primera venta (ej: $100)
            // sea sí o sí más alta que este valor.
            float maximoVenta = -1;

            // Una variable para guardar el ÍNDICE (la posición 0, 1, 2, 3 o 4)
            // del mozo que tenga la venta más alta.
            int indiceMozoMaximo = 0;

            // --- 2. RECORRIDO DE FILAS (MOZOS) ---
            // Este 'for' (con la 'f' de fila) dará 5 vueltas (0 a 4), una por cada mozo.
            for (int f = 0; f < 5; f++)
            {
                // 3. CÁLCULO DEL TOTAL POR MOZO
                // Cada vez que empezamos a revisar un mozo nuevo (fila nueva),
                // ponemos su "calculadora" personal en cero.
                float totalMozoActual = 0;

                // 4. RECORRIDO DE COLUMNAS (CATEGORÍAS)
                // Este 'for' (con la 'c' de columna) dará 4 vueltas (0 a 3)
                // para sumar las 4 categorías del mozo actual (fila 'f').
                for (int c = 0; c < 4; c++)
                {
                    // Sumamos lo que hay en la matriz en [f, c] a la calculadora del mozo
                    // Ej: ventas[0, 0] (Julio, Comida)
                    //     ventas[0, 1] (Julio, BebidaSin)
                    //     ...
                    totalMozoActual = totalMozoActual + ventas[f, c];
                }

                // 

                // --- 5. COMPARACIÓN ---
                // Cuando el 'for' de las columnas termina, ya tenemos el total de ese mozo (totalMozoActual).
                // Ahora, lo comparamos con el máximo que teníamos guardado.
                if (totalMozoActual > maximoVenta)
                {
                    // ¡Encontramos un nuevo ganador!
                    // 1. Guardamos su venta como el nuevo máximo.
                    maximoVenta = totalMozoActual;

                    // 2. Guardamos su ÍNDICE (la fila 'f') como el índice del ganador.
                    indiceMozoMaximo = f;
                }
            }

            // --- 6. MOSTRAR RESULTADOS ---
            // Cuando el 'for' de las filas (mozos) termina, las variables 
            // 'maximoVenta' e 'indiceMozoMaximo' tienen los datos del ganador final.

            // Buscamos el nombre del ganador en nuestro array 'nombresMozos'
            // usando el índice (posición) que guardamos.
            string nombreGanador = nombresMozos[indiceMozoMaximo];

            // Mostramos el resultado en el Label 'lblMozoResultado'.
            // El '$' al inicio nos deja poner variables { } dentro del texto.
            // 'maximoVenta.ToString("0.00")' formatea el número para que muestre 2 decimales.
            lblMozoResultado.Text = $"{nombreGanador} (Total: ${maximoVenta.ToString("0.00")})";
        }

        private void btnTotales_Click(object sender, EventArgs e)
        {
            // --- 1. PREPARAMOS LAS VARIABLES ---

            // Una variable para la suma de TODO.
            float totalGeneral = 0;

            // Un array de 4 espacios para guardar las sumas de cada CATEGORÍA.
            // Posición 0: Total Comida
            // Posición 1: Total Bebida Sin Alcohol
            // Posición 2: Total Bebidas con Alcohol
            // Posición 3: Total Postres
            float[] totalesCategoria = new float[4];

            // --- 2. RECORRIDO DE FILAS (MOZOS) ---
            for (int f = 0; f < 5; f++)
            {
                // --- 3. RECORRIDO DE COLUMNAS (CATEGORÍAS) ---
                // (c=0 es Comida, c=1 es BebidaSin, c=2 es BebidasCon, c=3 es Postres)
                for (int c = 0; c < 4; c++)
                {
                    // 4a. SUMA PARA EL TOTAL GENERAL
                    // Leemos el valor (ej: ventas[0,0]) y lo sumamos a la bolsa grande.
                    totalGeneral = totalGeneral + ventas[f, c];

                    // 4b. SUMA PARA EL TOTAL DE LA CATEGORÍA
                    // Sumamos el mismo valor a la posición que le corresponde.
                    // Ej: ventas[0, 0] (Julio, Comida) se suma a totalesCategoria[0]
                    //     ventas[0, 1] (Julio, BebidaSin) se suma a totalesCategoria[1]
                    totalesCategoria[c] = totalesCategoria[c] + ventas[f, c];
                }
            }

            // --- 5. MOSTRAR RESULTADOS EN LOS TEXTBOX ---

            // Formateamos los números a 2 decimales y con el signo '$'

            // Asignamos el total de la categoría "Comida" (índice 0)
            txtTotalComidas.Text = $"${totalesCategoria[0].ToString("0.00")}";

            // Asignamos el total de "Bebida Sin Alcohol" (índice 1)
            txtTotalBebidasSin.Text = $"${totalesCategoria[1].ToString("0.00")}";

            // Asignamos el total de "Bebidas con Alcohol" (índice 2)
            txtTotalBebidasCon.Text = $"${totalesCategoria[2].ToString("0.00")}";

            // Asignamos el total de "Postres" (índice 3)
            txtTotalPostres.Text = $"${totalesCategoria[3].ToString("0.00")}";

            // Asignamos el Total General
            txtTotalGeneral.Text = $"${totalGeneral.ToString("0.00")}";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            // 'this' se refiere a este formulario (Form1)
            // '.Close()' es la orden de cerrarse.
            this.Close();
        }
    }
}
