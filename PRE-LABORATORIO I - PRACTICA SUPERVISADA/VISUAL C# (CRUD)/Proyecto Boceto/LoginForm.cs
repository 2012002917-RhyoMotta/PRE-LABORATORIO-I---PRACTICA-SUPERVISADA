// Definición del espacio de nombres (namespace) Proyecto_PreLab
// ------------------------------------------------------------
// Agrupa lógicamente todas las clases relacionadas con este proyecto
// Beneficios:
// 1. Organización lógica del código
// 2. Evita colisiones de nombres con otros componentes
// 3. Facilita el mantenimiento y la modularidad
namespace Proyecto_PreLab
{
    // Declaración de la clase principal LoginForm que hereda de Form
    // -------------------------------------------------------------
    // partial: Indica que la clase está dividida entre varios archivos
    // (normalmente el código principal y el código generado por el diseñador)
    // public: La clase es accesible desde otros assemblies (ensamblados)
    public partial class LoginForm : Form
    {
        // Constructor de la clase CRUDForm
        // -------------------------------
        // Se ejecuta automáticamente al crear una instancia con 'new CRUDForm()'
        // No recibe parámetros (constructor por defecto)
        public LoginForm()
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

            // txtUsuario.Select() es una referencia al TextBox definido en el diseñador
            // .Select() hace:
            // 1. Establece el foco (cursor) en ese control
            // 2. Si hay texto, lo selecciona todo (útil para reemplazo rápido)
            // Beneficios:
            // - El usuario puede empezar a escribir inmediatamente
            // - Guía visual sobre dónde comenzar la interacción
            // - Mejora la eficiencia en formularios de entrada de datos
            txtUsuario.Select();
        }

        // Manejador de eventos para el Click del botón Login
        // ------------------------------------------------------------
        // Estructura típica de event handler en .NET:
        // - private: Generalmente los handlers son privados
        // - void: No retornan valores
        // - Parámetros:
        //   * sender: El objeto que generó el evento (el botón en este caso)
        //   * e: Información adicional sobre el evento (EventArgs base vacío)
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Obtención y limpieza de credenciales
            // ------------------------------------------------------------
            // txtUsuario.Text - Accede al texto actual del TextBox
            // .Trim() - Elimina espacios en blanco al inicio/final
            // Beneficios:
            // - Evita problemas con espacios accidentales
            // - Mejora consistencia en comparaciones
            // - Previene "contraseña invisible" con espacios finales
            string usuario = txtUsuario.Text.Trim();
            string contraseña = txtContraseña.Text.Trim();

            // Validación 1: Ambos campos vacíos
            // ------------------------------------------------------------
            // string.IsNullOrEmpty() vs == "":
            // - También maneja casos null (aunque improbable en TextBox)
            // - Más legible y expresivo
            // - Ligeramente más eficiente
            if (string.IsNullOrEmpty(usuario) && string.IsNullOrEmpty(contraseña))
            {
                // MessageBox.Show() - Diálogo modal al usuario
                // ------------------------------------------------------------
                // Parámetros:
                // 1. Mensaje principal
                // 2. Título de la ventana
                // 3. MessageBoxButtons: Opciones (OK, YesNo, etc.)
                // 4. MessageBoxIcon: Ícono visual (Warning, Error, etc.)
                // Características:
                // - Bloquea la interacción con otros forms
                // - Devuelve DialogResult para manejar respuestas
                MessageBox.Show("Debe ingresar usuario y contraseña",
                              "Campos vacíos",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);

                // Establecer foco en el primer campo
                txtUsuario.Focus();

                // Salir temprano del método (early return pattern)
                return;
            }

            // Validación 2: Solo usuario vacío
            if (string.IsNullOrEmpty(usuario))
            {
                MessageBox.Show("Debe ingresar un usuario",
                              "Usuario requerido",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                txtUsuario.Focus();
                return;
            }

            // Validación 3: Solo contraseña vacía
            if (string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Debe ingresar una contraseña",
                              "Contraseña requerida",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                txtContraseña.Focus();
                return;
            }

            // Validación 4: Credenciales incorrectas
            // ------------------------------------------------------------
            // Credenciales hardcodeadas (en una app real usaría almacenamiento seguro)
            // Uso de OR (||) para:
            // 1. Evaluación de cortocircuito (si usuario falla, no evalúa contraseña)
            // 2. Cualquier credencial incorrecta invalida el login
            if (usuario != "DonBosco" || contraseña != "donbosco")
            {
                MessageBox.Show("Usuario o contraseña incorrectos",
                              "Error de autenticación",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);

                // Limpieza segura de la contraseña
                txtContraseña.Clear();

                // Selección completa para fácil reemplazo
                txtUsuario.SelectAll();

                // Regresar foco para nuevo intento
                txtUsuario.Focus();
                return;
            }

            // Autenticación exitosa - Abrir formulario principal
            // ------------------------------------------------------------
            // Creación del CRUDForm (formulario principal)
            // 'new' realiza:
            // 1. Asignación de memoria
            // 2. Llamada al constructor
            // 3. Inicialización de campos
            CRUDForm mainForm = new CRUDForm();

            // ShowDialog() vs Show():
            // - Modal: Bloquea interacción con el padre
            // - Retorna sólo al cerrarse
            // - Ideal para flujos donde se necesita respuesta
            mainForm.ShowDialog();

            // Limpieza post-login (seguridad y usabilidad)
            txtContraseña.Clear();
            txtUsuario.Clear();
        }

        // Manejador para el botón Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Application.Exit() vs this.Close()
            // ------------------------------------------------------------
            // Application.Exit():
            // - Termina toda la aplicación
            // - Dispara eventos de cierre en todos los forms
            // - Libera recursos
            // this.Close():
            // - Sólo cierra este formulario
            // - Si es el main form, termina la app (depende de configuración)
            // En login forms es común usar Application.Exit()
            Application.Exit();
        }

        // Manejador para el botón Créditos
        private void btnCreditos_Click(object sender, EventArgs e)
        {
            // Creación del formulario de créditos
            CreditosForm credForm = new CreditosForm();

            // Mostrado modal para asegurar atención
            credForm.ShowDialog();
        }
    }
}