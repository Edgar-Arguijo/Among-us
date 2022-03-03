using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Among_us
{
    public partial class form : Form
    {
        Graphics papel;
        int Ancho = 462;
        int Alto = 284;

        public form()
        {
            InitializeComponent();
            papel = pictureBox1.CreateGraphics();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            btnColorFondo.Enabled = true;
            btnDibujar.Enabled = false;
            btnBorrar.Enabled = false;
            papel.Clear(Color.White);
            btnBorrar.Enabled = false;
        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            btnBorrar.Enabled = true;
            btnColorFondo.Enabled = false;
            Dibujo_Figura ObjF = new Dibujo_Figura();
            ObjF.DibujarF(ref papel, Alto, Ancho);
        }

        private void BtnAutor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias Por Utilizar Mi Programa.", "Copyright Oficial ©:");
            MessageBox.Show("Arguijo Vazquez Edgar Eduardo - 192310252.", "Copyright Oficial ©:");
        }

        private void btnColorFondo_Click(object sender, EventArgs e)
        {
            btnDibujar.Enabled = true;
            btnBorrar.Enabled = true;
            colorDialog1.ShowDialog();
            SolidBrush Relleno = new SolidBrush(colorDialog1.Color);
            papel.FillRectangle(Relleno, 0, 0, 1000, 1000);
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            btnInstruccion.Enabled = true; 
        }

        private void btnInstruccion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Primero tienes que cambiar el color del fondo.", "Instrucciónes:");
            MessageBox.Show("Una vez que seleccionaste el color del fondo, puedes dibujar el Amoung US.", "Instrucciónes:");
            MessageBox.Show("Cuando quieras cambiar el fondo, necesitas borrar, después de borrar repite el mismo procedimiento anteriormente explicado.", "Instrucciónes:");
        }
    }
}
