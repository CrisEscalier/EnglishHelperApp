using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishHelperApp
{
    public partial class LoadForm : Form
    {
        private int targetY;
        private int fadeOutStartY;
        public LoadForm()
        {
            InitializeComponent();
            this.Opacity = 1.0; // Oculta el formulario al inicio
            this.Load += LoadForm_Load;

            // Estilo inicial del label
            Initial_Label.ForeColor = Color.FromArgb(255, 255, 255, 255); // Blanco con opacidad
            Initial_Label.Visible = false;
        }

        private void LoadForm_Load(object sender, EventArgs e)
        {
            Initial_Label.Visible = true;

            // Posición inicial del Label: fuera del formulario por abajo
            Initial_Label.Top = this.Height + 10;

            // Posición de destino para centrado vertical
            targetY = this.Height / 2 - Initial_Label.Height / 2;
            fadeOutStartY = targetY - 20;

            animationTimer.Start();
            loadTimer.Start();
        }

        private void animationTimer_Tick(object sender, EventArgs e)
        {
            // Aparecer el formulario gradualmente
            if (this.Opacity < 1)
                this.Opacity += 0.05;

            // Subir el Label hasta que pase el punto de desvanecimiento
            if (Initial_Label.Top > fadeOutStartY)
            {
                Initial_Label.Top -= 2;
            }
            else
            {
                // Desvanecer el Label (cambiar opacidad del color)
                if (Initial_Label.ForeColor.A > 0)
                {
                    int alpha = Initial_Label.ForeColor.A - 10;
                    Initial_Label.ForeColor = Color.FromArgb(Math.Max(alpha, 0), Initial_Label.ForeColor.R, Initial_Label.ForeColor.G, Initial_Label.ForeColor.B);
                }
            }
        }

        private void loadTimer_Tick(object sender, EventArgs e)
        {
            animationTimer.Stop();
            loadTimer.Stop();

            // Mostrar el MainForm
            MainForm main = new MainForm();
            main.Show();

            // Ocultar esta pantalla de carga
            this.Hide();
        }

    }
}
