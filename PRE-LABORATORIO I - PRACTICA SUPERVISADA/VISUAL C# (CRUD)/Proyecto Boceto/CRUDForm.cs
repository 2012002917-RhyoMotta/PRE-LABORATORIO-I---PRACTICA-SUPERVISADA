using System; // Proporciona clases fundamentales

using System.Collections.Generic; // Contiene colecciones genéricas como

using System.ComponentModel; // Proporciona funcionalidades para

using System.Data; // Clases para manejo de datos como

using System.Drawing; // Funcionalidades gráficas básicas

using System.Linq; // Soporte para LINQ (Language Integrated Query)

using System.Text; // Manipulación avanzada de cadenas

using System.Threading.Tasks; // Soporte para programación asíncrona

using System.Windows.Forms; // Clases para crear aplicaciones de Windows Forms



// Definición del espacio de nombres (namespace) Proyecto_PreLab
// ------------------------------------------------------------
// Agrupa lógicamente todas las clases relacionadas con este proyecto
// Beneficios:
// 1. Organización lógica del código
// 2. Evita colisiones de nombres con otros componentes
// 3. Facilita el mantenimiento y la modularidad
namespace Proyecto_PreLab
{
    // Declaración de la clase principal CRUDForm que hereda de Form
    // -------------------------------------------------------------
    // partial: Indica que la clase está dividida entre varios archivos
    // (normalmente el código principal y el código generado por el diseñador)
    // public: La clase es accesible desde otros assemblies (ensamblados)
    public partial class CRUDForm : Form
    {
        // Declaración de variables miembro de la clase
        // --------------------------------------------
        // code: Contador para generar IDs automáticos secuenciales
        // private: Solo accesible dentro de esta clase (encapsulación)
        // int: Tipo de dato entero de 32 bits con signo (-2,147,483,648 a 2,147,483,647)
        // Se inicia en 1 porque:
        // - Es más natural para IDs (0 suele significar "no asignado" o valor por defecto)
        // - Mejor legibilidad para el usuario final
        private int code = 1;

        // seleccionFila: Almacena el índice de la fila seleccionada en el DataGridView
        // static: La variable es compartida por todas las instancias de CRUDForm
        // Esto podría ser discutible ya que normalmente cada formulario debería manejar su propia selección
        // -1: Valor convencional que indica "ninguna selección"
        // Se usa para:
        // - Saber qué fila se está editando
        // - Mantener el estado entre diferentes operaciones CRUD
        private static int seleccionFila = -1;

        // Constructor de la clase CRUDForm
        // -------------------------------
        // Se ejecuta automáticamente al crear una instancia con 'new CRUDForm()'
        // No recibe parámetros (constructor por defecto)
        public CRUDForm()
        {
            // InitializeComponent(): Método generado automáticamente por el diseñador de Windows Forms
            // Responsabilidades:
            // 1. Instanciar todos los controles definidos visualmente en el diseñador
            // 2. Configurar sus propiedades iniciales (tamaño, posición, texto, etc.)
            // 3. Asignar manejadores de eventos básicos
            // DEBE ser la primera línea en el constructor porque:
            // - Asegura que todos los controles estén creados antes de cualquier otra operación
            // - Los controles deben existir antes de poder manipularlos
            InitializeComponent();
        }

        // Manejador del evento Load del formulario
        // ----------------------------------------
        // Se ejecuta cuando el formulario se carga en memoria, después del constructor
        // pero antes de mostrarse al usuario
        // sender: Referencia al objeto que generó el evento (en este caso, el formulario mismo)
        // e: Instancia de EventArgs que contiene datos adicionales del evento (vacío en este caso)
        private void CRUDForm_Load(object sender, EventArgs e)
        {
            // Configurar el texto del Label lblCodigo con el valor actual del contador
            // .Text: Propiedad que contiene el texto mostrado en un control Label
            // .ToString(): Convierte el entero 'code' a su representación string
            // Esto muestra al usuario el ID que se asignará al próximo registro
            lblCodigo.Text = code.ToString();

            // Establecer la selección inicial del ComboBox cmbEstado al primer ítem
            // .SelectedIndex: Índice basado en 0 del ítem seleccionado (-1 si no hay selección)
            // Se establece en 0 para:
            // - Tener un valor por defecto
            // - Evitar que el ComboBox aparezca vacío al inicio
            cmbEstado.SelectedIndex = 0;
        }

        // Manejador del evento Click del botón Registrar (Create en CRUD)
        // ------------------------------------------------------------
        private void btnReg_Click(object sender, EventArgs e)
        {
            // VALIDACIÓN INICIAL:
            // ValidarCampos(): Método que verifica que todos los campos obligatorios estén completos
            // Devuelve true si todos los campos son válidos, false si hay errores
            // El operador ! niega el resultado (si es false, sale del método con return)
            // Esto previene que se registren datos incompletos o inválidos
            if (!ValidarCampos())
                return;

            // AGREGAR NUEVA FILA AL DATAGRIDVIEW:
            // dgvAlumnos: Control DataGridView que muestra los registros en formato tabular
            // .Rows: Colección que contiene todas las filas del DataGridView
            // .Add(): Método para agregar una nueva fila, acepta valores para cada columna
            // Se pasan los valores en el orden de las columnas del DataGridView
            dgvAlumnos.Rows.Add(
                code.ToString(),                     // Columna 0: ID (convertido a string)
                txtNombre.Text.Trim(),               // Columna 1: Nombre (sin espacios extras)
                txtGrado.Text.Trim(),                // Columna 2: Grado
                txtSeccion.Text.Trim(),              // Columna 3: Sección
                txtTelefono.Text.Trim(),             // Columna 4: Teléfono
                txtMatricula.Text.Trim(),            // Columna 5: Matrícula
                txtCiclo.Text.Trim(),                // Columna 6: Ciclo Académico
                txtEmail.Text.Trim(),                // Columna 7: Email
                txtDireccion.Text.Trim(),            // Columna 8: Dirección
                dtpFechaNacimiento.Value             // Columna 9: Fecha 
                    .ToShortDateString(),            //   .ToShortDateString() muestra formato regional
                txtPromedio.Text.Trim(),             // Columna 10: Promedio
                cmbEstado.Text                       // Columna 11: Estado del ComboBox
            );

            // MOSTRAR MENSAJE DE CONFIRMACIÓN:
            // MessageBox.Show(): Muestra un cuadro de diálogo modal al usuario
            // Parámetros:
            // 1. Mensaje principal ("Alumno registrado correctamente.")
            // 2. Título de la ventana ("Éxito")
            // 3. Botones a mostrar (OK)
            // 4. Icono (Information = ícono azul con 'i')
            // Esto proporciona feedback inmediato al usuario sobre la operación exitosa
            MessageBox.Show("Alumno registrado correctamente.", 
                          "Éxito", 
                          MessageBoxButtons.OK, 
                          MessageBoxIcon.Information);

            // ACTUALIZAR CONTADOR DE ID:
            // ++ operador de incremento (equivale a code = code + 1)
            // Prepara el siguiente ID para un nuevo registro
            code++;
            
            // ACTUALIZAR LABEL CON NUEVO ID:
            // Muestra al usuario el ID que se asignará al próximo registro
            lblCodigo.Text = code.ToString();

            // LIMPIAR CAMPOS PARA NUEVO REGISTRO:
            // Prepara el formulario para una nueva entrada de datos
            LimpiarCampos();
        }

        // Manejador del evento Click del botón Modificar (Update en CRUD)
        // -----------------------------------------------------------
        private void btnMod_Click(object sender, EventArgs e)
        {
            // VERIFICAR SELECCIÓN VÁLIDA:
            // seleccionFila < 0 significa que no hay fila seleccionada
            // Esto previene errores al intentar modificar sin selección
            if (seleccionFila < 0)
            {
                MessageBox.Show("Por favor, seleccione un alumno para modificar.", 
                              "Error", 
                              MessageBoxButtons.OK, 
                              MessageBoxIcon.Warning);
                return; // Salir del método si no hay selección
            }

            // VALIDAR CAMPOS:
            // Reutiliza la misma validación que para registro nuevo
            if (!ValidarCampos())
                return;

            // VERIFICAR ÍNDICE VÁLIDO:
            // Comprueba que el índice esté dentro del rango válido
            // Esto es defensivo contra posibles errores de índice
            if (seleccionFila >= 0 && seleccionFila < dgvAlumnos.Rows.Count)
            {
                // ACTUALIZAR FILA SELECCIONADA:
                // Acceder a cada celda por su índice y actualizar su valor
                // Se actualizan todos los campos, incluso si no cambiaron
                dgvAlumnos.Rows[seleccionFila].Cells[0].Value = lblCodigo.Text;     // ID
                dgvAlumnos.Rows[seleccionFila].Cells[1].Value = txtNombre.Text;     // Nombre
                dgvAlumnos.Rows[seleccionFila].Cells[2].Value = txtGrado.Text;      // Grado
                dgvAlumnos.Rows[seleccionFila].Cells[3].Value = txtSeccion.Text;    // Sección
                dgvAlumnos.Rows[seleccionFila].Cells[4].Value = txtTelefono.Text;   // Teléfono
                dgvAlumnos.Rows[seleccionFila].Cells[5].Value = txtMatricula.Text;  // Matrícula
                dgvAlumnos.Rows[seleccionFila].Cells[6].Value = txtCiclo.Text;      // Ciclo
                dgvAlumnos.Rows[seleccionFila].Cells[7].Value = txtEmail.Text;      // Email
                dgvAlumnos.Rows[seleccionFila].Cells[8].Value = txtDireccion.Text;  // Dirección
                dgvAlumnos.Rows[seleccionFila].Cells[9].Value =                    // Fecha
                    dtpFechaNacimiento.Value.ToShortDateString();
                dgvAlumnos.Rows[seleccionFila].Cells[10].Value = txtPromedio.Text; // Promedio
                dgvAlumnos.Rows[seleccionFila].Cells[11].Value = cmbEstado.Text;   // Estado

                // MOSTRAR CONFIRMACIÓN:
                MessageBox.Show("Datos del alumno actualizados correctamente.", 
                              "Éxito", 
                              MessageBoxButtons.OK, 
                              MessageBoxIcon.Information);

                // LIMPIAR Y RESETEAR:
                // Prepara el formulario para una nueva operación
                LimpiarCampos();
                seleccionFila = -1; // Resetea la selección
            }
        }

        // Manejador del evento Click del botón Eliminar (Delete en CRUD)
        // ----------------------------------------------------------
        private void btnDel_Click(object sender, EventArgs e)
        {
            // VERIFICAR SELECCIÓN VÁLIDA:
            // Comprueba que haya una fila seleccionada y que el índice sea válido
            if (seleccionFila >= 0 && seleccionFila < dgvAlumnos.Rows.Count)
            {
                // PEDIR CONFIRMACIÓN:
                // MessageBox con botones Sí/No y icono de pregunta
                // Es importante confirmar antes de eliminar datos
                DialogResult confirmacion = MessageBox.Show(
                    "¿Está seguro que desea eliminar este alumno?\nEsta acción no se puede deshacer.", 
                    "Confirmar eliminación", 
                    MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Question);

                // SI CONFIRMA:
                if (confirmacion == DialogResult.Yes)
                {
                    // ELIMINAR FILA:
                    // RemoveAt elimina la fila en el índice especificado
                    dgvAlumnos.Rows.RemoveAt(seleccionFila);

                    // MOSTRAR CONFIRMACIÓN:
                    MessageBox.Show("Alumno eliminado correctamente.", 
                                  "Éxito", 
                                  MessageBoxButtons.OK, 
                                  MessageBoxIcon.Information);

                    // LIMPIAR Y RESETEAR:
                    seleccionFila = -1; // Resetea la selección
                    LimpiarCampos(); // Prepara para nueva operación
                }
            }
            else
            {
                // MOSTRAR ERROR SI NO HAY SELECCIÓN:
                MessageBox.Show("Por favor, seleccione un alumno para eliminar.", 
                              "Error", 
                              MessageBoxButtons.OK, 
                              MessageBoxIcon.Warning);
            }
        }

        // Manejador del evento Click del botón Nuevo
        // -----------------------------------------
        private void btnNew_Click(object sender, EventArgs e)
        {
            // LIMPIAR CAMPOS:
            // Restablece todos los controles a sus valores iniciales
            LimpiarCampos();
            
            // RESETEAR SELECCIÓN:
            // Indica que no hay ninguna fila seleccionada
            seleccionFila = -1;
        }

        // Manejador del evento CellClick del DataGridView
        // ----------------------------------------------
        private void dgvAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // VERIFICAR QUE NO SEA CLIC EN ENCABEZADO:
            // e.RowIndex es -1 si se hizo clic en el encabezado de columna
            if (e.RowIndex >= 0)
            {
                // GUARDAR SELECCIÓN:
                // Almacena el índice de la fila clickeada para operaciones posteriores
                seleccionFila = e.RowIndex;
                
                // OBTENER REFERENCIA A LA FILA:
                // Accede a la fila específica que fue clickeada
                DataGridViewRow fila = dgvAlumnos.Rows[e.RowIndex];

                // CARGAR DATOS A CONTROLES:
                // Uso de operador ?. para manejo seguro de nulos (null-conditional)
                // Uso de ?? para proporcionar valor por defecto si es nulo (null-coalescing)
                lblCodigo.Text = fila.Cells[0].Value?.ToString() ?? "";
                txtNombre.Text = fila.Cells[1].Value?.ToString() ?? "";
                txtGrado.Text = fila.Cells[2].Value?.ToString() ?? "";
                txtSeccion.Text = fila.Cells[3].Value?.ToString() ?? "";
                txtTelefono.Text = fila.Cells[4].Value?.ToString() ?? "";
                txtMatricula.Text = fila.Cells[5].Value?.ToString() ?? "";
                txtCiclo.Text = fila.Cells[6].Value?.ToString() ?? "";
                txtEmail.Text = fila.Cells[7].Value?.ToString() ?? "";
                txtDireccion.Text = fila.Cells[8].Value?.ToString() ?? "";

                // MANEJO ESPECIAL PARA FECHA:
                // TryParse intenta convertir el string a DateTime
                // Si falla, asigna la fecha actual por defecto
                if (fila.Cells[9].Value != null && 
                    DateTime.TryParse(fila.Cells[9].Value.ToString(), out DateTime fecha))
                {
                    dtpFechaNacimiento.Value = fecha;
                }
                else
                {
                    dtpFechaNacimiento.Value = DateTime.Today;
                }

                // CARGAR RESTO DE CAMPOS:
                txtPromedio.Text = fila.Cells[10].Value?.ToString() ?? "";
                cmbEstado.Text = fila.Cells[11].Value?.ToString() ?? "";
            }
        }

        // Método para validar campos del formulario
        // ----------------------------------------
        private bool ValidarCampos()
        {
            // LISTA PARA CAMPOS VACÍOS/INVÁLIDOS:
            // List<string> es una colección dinámica que almacena los nombres de los campos inválidos
            List<string> camposVacios = new List<string>();

            // VERIFICAR CADA CAMPO:
            // string.IsNullOrWhiteSpace verifica: null, vacío o solo espacios
            // Agrega el nombre del campo a la lista si está vacío
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
                camposVacios.Add("Nombre");
            if (string.IsNullOrWhiteSpace(txtGrado.Text))
                camposVacios.Add("Grado");
            if (string.IsNullOrWhiteSpace(txtSeccion.Text))
                camposVacios.Add("Sección");
            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
                camposVacios.Add("Teléfono");
            if (string.IsNullOrWhiteSpace(txtMatricula.Text))
                camposVacios.Add("Matrícula");
            if (string.IsNullOrWhiteSpace(txtCiclo.Text))
                camposVacios.Add("Ciclo Académico");
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
                camposVacios.Add("Email");
            if (string.IsNullOrWhiteSpace(txtDireccion.Text))
                camposVacios.Add("Dirección");
            if (string.IsNullOrWhiteSpace(txtPromedio.Text))
                camposVacios.Add("Promedio");
            
            // VALIDAR COMBOBOX:
            // SelectedIndex <= 0 significa no seleccionado o selección inicial
            if (cmbEstado.SelectedIndex <= 0)
                camposVacios.Add("Estado");

            // CASO 1: TODOS LOS CAMPOS VACÍOS:
            // Si todos los campos están vacíos, muestra un mensaje general
            if (camposVacios.Count == 10)
            {
                MessageBox.Show("Debe completar todos los campos del formulario.", 
                              "Formulario incompleto", 
                              MessageBoxButtons.OK, 
                              MessageBoxIcon.Error);
                
                txtNombre.Focus(); // Enfocar primer campo para facilitar la entrada
                return false;
            }

            // CASO 2: ALGUNOS CAMPOS VACÍOS:
            // Si solo algunos campos están vacíos, muestra un mensaje detallado
            if (camposVacios.Count > 0)
            {
                // CONSTRUIR MENSAJE DETALLADO:
                // string.Join concatena los elementos de la lista con separadores
                string mensaje = "Los siguientes campos son obligatorios:\n\n" + 
                               string.Join("\n", camposVacios);

                MessageBox.Show(mensaje, 
                              "Campos incompletos", 
                              MessageBoxButtons.OK, 
                              MessageBoxIcon.Warning);

                // ENFOCAR PRIMER CAMPO VACÍO:
                // Establece el foco en el primer campo inválido encontrado
                // Esto mejora la experiencia de usuario al corregir los errores
                if (camposVacios.Contains("Nombre")) 
                    txtNombre.Focus();
                else if (camposVacios.Contains("Grado")) 
                    txtGrado.Focus();
                else if (camposVacios.Contains("Sección")) 
                    txtSeccion.Focus();
                else if (camposVacios.Contains("Teléfono")) 
                    txtTelefono.Focus();
                else if (camposVacios.Contains("Matrícula")) 
                    txtMatricula.Focus();
                else if (camposVacios.Contains("Ciclo Académico")) 
                    txtCiclo.Focus();
                else if (camposVacios.Contains("Email")) 
                    txtEmail.Focus();
                else if (camposVacios.Contains("Dirección")) 
                    txtDireccion.Focus();
                else if (camposVacios.Contains("Promedio")) 
                    txtPromedio.Focus();
                else if (camposVacios.Contains("Estado")) 
                    cmbEstado.Focus();

                return false;
            }

            // VALIDACIÓN ADICIONAL PARA PROMEDIO (NUMÉRICO):
            // TryParse intenta convertir el texto a decimal
            // Si falla, muestra un mensaje de error
            if (!decimal.TryParse(txtPromedio.Text, out decimal promedio))
            {
                MessageBox.Show("El campo 'Promedio' debe contener un valor numérico válido.\n" +
                              "Ejemplo: 15.5", 
                              "Error en promedio", 
                              MessageBoxButtons.OK, 
                              MessageBoxIcon.Error);
                
                txtPromedio.Focus();
                txtPromedio.SelectAll(); // Selecciona todo el texto para facilitar la corrección
                return false;
            }

            // VALIDACIÓN RANGO PROMEDIO (0-100):
            // Verifica que el promedio esté dentro del rango aceptable
            if (promedio < 0 || promedio >= 100)
            {
                MessageBox.Show("El promedio debe debe ser positivo y menor o igual 100.", 
                              "Error en promedio", 
                              MessageBoxButtons.OK, 
                              MessageBoxIcon.Error);
                
                txtPromedio.Focus();
                txtPromedio.SelectAll();
                return false;
            }

            return true; // Todas las validaciones pasaron
        }

        // Método para limpiar todos los controles del formulario
        // -----------------------------------------------------
        private void LimpiarCampos()
        {
            // LIMPIAR TEXTBOXES:
            // .Clear() elimina todo el texto del control
            txtNombre.Clear();
            txtGrado.Clear();
            txtSeccion.Clear();
            txtTelefono.Clear();
            txtMatricula.Clear();
            txtCiclo.Clear();
            txtEmail.Clear();
            txtDireccion.Clear();
            txtPromedio.Clear();

            // RESTABLECER DATETIMEPICKER:
            // Establece la fecha al día actual
            dtpFechaNacimiento.Value = DateTime.Today;

            // RESTABLECER COMBOBOX:
            // Vuelve a la selección inicial (índice 0)
            cmbEstado.SelectedIndex = 0;

            // ACTUALIZAR LABEL DE CÓDIGO:
            // Muestra el próximo ID disponible
            lblCodigo.Text = code.ToString();

            // ENFOCAR CAMPO PRINCIPAL:
            // Establece el foco en el campo Nombre para facilitar la nueva entrada
            txtNombre.Focus();
        }

        // Manejador del evento Click del botón Créditos
        // --------------------------------------------
        private void btnCreditos_Click(object sender, EventArgs e)
        {
            // CREAR INSTANCIA DEL FORMULARIO:
            // CreditosForm es otro formulario que muestra información sobre los autores
            CreditosForm formCreditos = new CreditosForm();
            
            // MOSTRAR COMO DIÁLOGO MODAL:
            // ShowDialog() muestra el formulario de forma modal:
            // - Bloquea interacción con formulario padre hasta cerrarse
            // - El código aquí se pausa hasta que se cierre el diálogo
            // Esto asegura que el usuario atienda la información de créditos
            formCreditos.ShowDialog();
        }
    }
}