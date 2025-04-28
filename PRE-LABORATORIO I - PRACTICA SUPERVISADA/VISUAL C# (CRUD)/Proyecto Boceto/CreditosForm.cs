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

    // Declaración de la clase principal CreditosForm que hereda de Form
    // -------------------------------------------------------------
    // partial: Indica que la clase está dividida entre varios archivos
    // (normalmente el código principal y el código generado por el diseñador)
    // public: La clase es accesible desde otros assemblies (ensamblados)
    public partial class CreditosForm : Form
    {

        // Constructor de la clase CreditosForm
        // ------------------------------------
        // Se ejecuta automáticamente al crear una instancia con 'new CreditosForm()'
        // No recibe parámetros (constructor por defecto)
        public CreditosForm()
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
    }
}
