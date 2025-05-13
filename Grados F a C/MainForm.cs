/*
 * Created by SharpDevelop.
 * User: usuario
 * Date: 09/05/2025
 * Time: 12:41 p. m.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Grados_F_a_C
{
    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        public MainForm()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();

            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
        }
        void BtnConvClick(object sender, EventArgs e)
        {
            if (MskGrados.Text == "" || double.Parse(MskGrados.Text) < -459.67)
            {
                MessageBox.Show("Ingrese un valor valido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MskGrados.Text = "";
                MskGrados.Focus();
            }
            else
            {
                if (LblGrados.Text == "Fahrenheit →")
                {
                    double F, Resta, Mult, Div, Resultado;
                    F = double.Parse(MskGrados.Text);
                    Mult = 5;
                    Resta = 32;
                    Div = 9;
                    Resultado = (F - Resta) * Mult / Div;
                    LblR.Text = "" + Resultado + " °C";
                    MskGrados.Enabled = false;
                    LstCalc.Items.Add("(" + F + "-" + Resta + ")" + "*" + Mult + "/" + Div + "=" + Resultado);
                    BtnConv.Enabled = false;
                    BtnInt.Enabled = false;

                    // Cambiar la imagen y el texto según el resultado

                    if (Resultado <= -20)
                    { LblFrioCalido.Text = "Extremadamente frío"; pictureBox1.Image = Image.FromFile(Application.StartupPath + @" \\Imagenes\1.jpeg"); }
                    else if (Resultado <= -10)
                    { LblFrioCalido.Text = "Muy Frio"; pictureBox1.Image = Image.FromFile(Application.StartupPath + @" \\Imagenes\2.jpg"); }
                    else if (Resultado <= 0)
                    { LblFrioCalido.Text = "Frío"; pictureBox1.Image = Image.FromFile(Application.StartupPath + @" \\Imagenes\3.jpeg"); }
                    else if (Resultado <= 10)
                    { LblFrioCalido.Text = "Fresco"; pictureBox1.Image = Image.FromFile(Application.StartupPath + @" \\Imagenes\4.jpeg"); }
                    else if (Resultado <= 20)
                    { LblFrioCalido.Text = "Templado"; pictureBox1.Image = Image.FromFile(Application.StartupPath + @" \\Imagenes\5.jpeg"); }
                    else if (Resultado <= 30)
                    { LblFrioCalido.Text = "Calido"; pictureBox1.Image = Image.FromFile(Application.StartupPath + @" \\Imagenes\6.jpeg"); }
                    else if (Resultado <= 40)
                    { LblFrioCalido.Text = "Muy Calido"; pictureBox1.Image = Image.FromFile(Application.StartupPath + @" \\Imagenes\7.jpg"); }
                    else
                    { LblFrioCalido.Text = "Calor extremo"; pictureBox1.Image = Image.FromFile(Application.StartupPath + @" \\Imagenes\8.jpeg"); }
                }
                else
                {
                    if (LblGrados.Text == "Celsius →")
                    {
                        if (int.Parse(MskGrados.Text) < -273.15)
                        {
                            MessageBox.Show("Ingrese un valor valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            MskGrados.Text = "";
                            MskGrados.Focus();
                        }
                        else
                        {
                            double C, Suma, Mult, Div, Resultado;
                            C = double.Parse(MskGrados.Text);
                            Mult = 9;
                            Suma = 32;
                            Div = 5;
                            Resultado = (C * Mult / Div) + Suma;
                            LblR.Text = "" + Resultado + " °F";
                            MskGrados.Enabled = false;
                            LstCalc.Items.Add("(" + C + "*" + Mult + "/" + Div + ")+" + Suma + "=" + Resultado);
                            BtnConv.Enabled = false;
                            BtnInt.Enabled = false;

                            // Cambiar la imagen y el texto según el resultado

                            if (Resultado < -4)
                            { LblFrioCalido.Text = "Extremadamente frío"; pictureBox1.Image = Image.FromFile(Application.StartupPath + @" \\Imagenes\1.jpeg"); }
                            else if (Resultado <= 14)
                            { LblFrioCalido.Text = "Muy Frio"; pictureBox1.Image = Image.FromFile(Application.StartupPath + @" \\Imagenes\2.jpg"); }
                            else if (Resultado <= 32)
                            { LblFrioCalido.Text = "Frío"; pictureBox1.Image = Image.FromFile(Application.StartupPath + @" \\Imagenes\3.jpeg"); }
                            else if (Resultado <= 50)
                            { LblFrioCalido.Text = "Fresco"; pictureBox1.Image = Image.FromFile(Application.StartupPath + @" \\Imagenes\4.jpeg"); }
                            else if (Resultado <= 68)
                            { LblFrioCalido.Text = "Templado"; pictureBox1.Image = Image.FromFile(Application.StartupPath + @" \\Imagenes\5.jpeg"); }
                            else if (Resultado <= 86)
                            { LblFrioCalido.Text = "Calido"; pictureBox1.Image = Image.FromFile(Application.StartupPath + @" \\Imagenes\6.jpeg"); }
                            else if (Resultado <= 104)
                            { LblFrioCalido.Text = "Muy Calido"; pictureBox1.Image = Image.FromFile(Application.StartupPath + @" \\Imagenes\7.jpg"); }
                            else
                            { LblFrioCalido.Text = "Calor extremo"; pictureBox1.Image = Image.FromFile(Application.StartupPath + @" \\Imagenes\8.jpeg"); }
                        }
                    }
                }
            }
        }
        void BtnNuevoClick(object sender, EventArgs e)
        {
            LstCalc.Items.Clear();
            MskGrados.Enabled = true;
            MskGrados.Text = "";
            LblR.Text = "";
            LblFrioCalido.Text = "";
            BtnConv.Enabled = true;
            BtnInt.Enabled = true;
            MskGrados.Focus();
            pictureBox1.Image = Image.FromFile(Application.StartupPath + @" \\Imagenes\weather.png");
        }
        void BtnIntClick(object sender, EventArgs e)
        {
            MskGrados.Text = "";
            if (LblGrados.Text == "Fahrenheit →")
            {
                LblGrados.Text = "Celsius →";
                LblGrados2.Text = "°C";
                LblGrados3.Text = "Fahrenheit →";
                LblGrados4.Text = "ºF";
            }
            else
            {
                LblGrados.Text = "Fahrenheit →";
                LblGrados2.Text = "°F";
                LblGrados3.Text = "Celsius →";
                LblGrados4.Text = "ºC";
            }
            MskGrados.Focus();
        }
        void MainFormFormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("¿Realmente Desea Salir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opcion == DialogResult.No)
            {
                e.Cancel = true;
                MskGrados.Focus();
            }
        }
    }
}
