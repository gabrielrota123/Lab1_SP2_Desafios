// =====================================================================
//  DESAFIO 04 - Completar el evento Load
//  Unidad: SP2 / H1 - Diseno de formularios
//  Tipo: Codigo faltante (TODO)
// ---------------------------------------------------------------------
//  CONSIGNA:
//  El evento Load esta vacio. Segun el material, Load se ejecuta al iniciar
//  el formulario, ANTES de mostrarlo en pantalla: es el lugar correcto para
//  dejar la ventana configurada.
//  
//  Completa los TODO de abajo. No toques el Designer, todo va por codigo.
//  
//  Objetivo: titulo propio, ventana no redimensionable, sin boton maximizar
//  y centrada respecto del formulario que la abrio.
// =====================================================================
using System;
using System.Windows.Forms;

namespace Lab1_SP2_Desafios
{
    public partial class Desafio04 : Form
    {
        public Desafio04()
        {
            InitializeComponent();
        }

        private void Desafio04_Load(object sender, EventArgs e)
        {
            // TODO 1: asignar al titulo de la ventana el texto
            //         "Desafio 04 - Resuelto" usando la propiedad correcta.

            // TODO 2: impedir que el usuario redimensione la ventana
            //         (FormBorderStyle).

            // TODO 3: ocultar el boton de maximizar.

            // TODO 4: hacer que la ventana se centre respecto del formulario
            //         que la abrio (StartPosition).
        }

        private void lblInfo_Click(object sender, EventArgs e)
        {
            this.Text = "Desafio04 resuelto";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;

        }
    }
}
