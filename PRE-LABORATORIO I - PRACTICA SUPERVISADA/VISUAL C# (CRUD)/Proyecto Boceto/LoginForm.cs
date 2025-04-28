// Definici�n del espacio de nombres (namespace) Proyecto_PreLab
// ------------------------------------------------------------
// Agrupa l�gicamente todas las clases relacionadas con este proyecto
// Beneficios:
// 1. Organizaci�n l�gica del c�digo
// 2. Evita colisiones de nombres con otros componentes
// 3. Facilita el mantenimiento y la modularidad
namespace Proyecto_PreLab
{
    // Declaraci�n de la clase principal LoginForm que hereda de Form
    // -------------------------------------------------------------
    // partial: Indica que la clase est� dividida entre varios archivos
    // (normalmente el c�digo principal y el c�digo generado por el dise�ador)
    // public: La clase es accesible desde otros assemblies (ensamblados)
    public partial class LoginForm : Form
    {
        // Constructor de la clase CRUDForm
        // -------------------------------
        // Se ejecuta autom�ticamente al crear una instancia con 'new CRUDForm()'
        // No recibe par�metros (constructor por defecto)
        public LoginForm()
        {
            // InitializeComponent(): M�todo generado autom�ticamente por el dise�ador de Windows Forms
            // Responsabilidades:
            // 1. Instanciar todos los controles definidos visualmente en el dise�ador
            // 2. Configurar sus propiedades iniciales (tama�o, posici�n, texto, etc.)
            // 3. Asignar manejadores de eventos b�sicos
            // DEBE ser la primera l�nea en el constructor porque:
            // - Asegura que todos los controles est�n creados antes de cualquier otra operaci�n
            // - Los controles deben existir antes de poder manipularlos
            InitializeComponent();

            // txtUsuario.Select() es una referencia al TextBox definido en el dise�ador
            // .Select() hace:
            // 1. Establece el foco (cursor) en ese control
            // 2. Si hay texto, lo selecciona todo (�til para reemplazo r�pido)
            // Beneficios:
            // - El usuario puede empezar a escribir inmediatamente
            // - Gu�a visual sobre d�nde comenzar la interacci�n
            // - Mejora la eficiencia en formularios de entrada de datos
            txtUsuario.Select();
        }

        // Manejador de eventos para el Click del bot�n Login
        // ------------------------------------------------------------
        // Estructura t�pica de event handler en .NET:
        // - private: Generalmente los handlers son privados
        // - void: No retornan valores
        // - Par�metros:
        //   * sender: El objeto que gener� el evento (el bot�n en este caso)
        //   * e: Informaci�n adicional sobre el evento (EventArgs base vac�o)
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Obtenci�n y limpieza de credenciales
            // ------------------------------------------------------------
            // txtUsuario.Text - Accede al texto actual del TextBox
            // .Trim() - Elimina espacios en blanco al inicio/final
            // Beneficios:
            // - Evita problemas con espacios accidentales
            // - Mejora consistencia en comparaciones
            // - Previene "contrase�a invisible" con espacios finales
            string usuario = txtUsuario.Text.Trim();
            string contrase�a = txtContrase�a.Text.Trim();

            // Validaci�n 1: Ambos campos vac�os
            // ------------------------------------------------------------
            // string.IsNullOrEmpty() vs == "":
            // - Tambi�n maneja casos null (aunque improbable en TextBox)
            // - M�s legible y expresivo
            // - Ligeramente m�s eficiente
            if (string.IsNullOrEmpty(usuario) && string.IsNullOrEmpty(contrase�a))
            {
                // MessageBox.Show() - Di�logo modal al usuario
                // ------------------------------------------------------------
                // Par�metros:
                // 1. Mensaje principal
                // 2. T�tulo de la ventana
                // 3. MessageBoxButtons: Opciones (OK, YesNo, etc.)
                // 4. MessageBoxIcon: �cono visual (Warning, Error, etc.)
                // Caracter�sticas:
                // - Bloquea la interacci�n con otros forms
                // - Devuelve DialogResult para manejar respuestas
                MessageBox.Show("Debe ingresar usuario y contrase�a",
                              "Campos vac�os",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);

                // Establecer foco en el primer campo
                txtUsuario.Focus();

                // Salir temprano del m�todo (early return pattern)
                return;
            }

            // Validaci�n 2: Solo usuario vac�o
            if (string.IsNullOrEmpty(usuario))
            {
                MessageBox.Show("Debe ingresar un usuario",
                              "Usuario requerido",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                txtUsuario.Focus();
                return;
            }

            // Validaci�n 3: Solo contrase�a vac�a
            if (string.IsNullOrEmpty(contrase�a))
            {
                MessageBox.Show("Debe ingresar una contrase�a",
                              "Contrase�a requerida",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                txtContrase�a.Focus();
                return;
            }

            // Validaci�n 4: Credenciales incorrectas
            // ------------------------------------------------------------
            // Credenciales hardcodeadas (en una app real usar�a almacenamiento seguro)
            // Uso de OR (||) para:
            // 1. Evaluaci�n de cortocircuito (si usuario falla, no eval�a contrase�a)
            // 2. Cualquier credencial incorrecta invalida el login
            if (usuario != "DonBosco" || contrase�a != "donbosco")
            {
                MessageBox.Show("Usuario o contrase�a incorrectos",
                              "Error de autenticaci�n",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);

                // Limpieza segura de la contrase�a
                txtContrase�a.Clear();

                // Selecci�n completa para f�cil reemplazo
                txtUsuario.SelectAll();

                // Regresar foco para nuevo intento
                txtUsuario.Focus();
                return;
            }

            // Autenticaci�n exitosa - Abrir formulario principal
            // ------------------------------------------------------------
            // Creaci�n del CRUDForm (formulario principal)
            // 'new' realiza:
            // 1. Asignaci�n de memoria
            // 2. Llamada al constructor
            // 3. Inicializaci�n de campos
            CRUDForm mainForm = new CRUDForm();

            // ShowDialog() vs Show():
            // - Modal: Bloquea interacci�n con el padre
            // - Retorna s�lo al cerrarse
            // - Ideal para flujos donde se necesita respuesta
            mainForm.ShowDialog();

            // Limpieza post-login (seguridad y usabilidad)
            txtContrase�a.Clear();
            txtUsuario.Clear();
        }

        // Manejador para el bot�n Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Application.Exit() vs this.Close()
            // ------------------------------------------------------------
            // Application.Exit():
            // - Termina toda la aplicaci�n
            // - Dispara eventos de cierre en todos los forms
            // - Libera recursos
            // this.Close():
            // - S�lo cierra este formulario
            // - Si es el main form, termina la app (depende de configuraci�n)
            // En login forms es com�n usar Application.Exit()
            Application.Exit();
        }

        // Manejador para el bot�n Cr�ditos
        private void btnCreditos_Click(object sender, EventArgs e)
        {
            // Creaci�n del formulario de cr�ditos
            CreditosForm credForm = new CreditosForm();

            // Mostrado modal para asegurar atenci�n
            credForm.ShowDialog();
        }
    }
}