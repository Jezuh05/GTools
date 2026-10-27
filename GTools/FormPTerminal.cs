using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GTools
{
    public partial class FormPTerminal : Form
    {
        public FormPTerminal()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (float.TryParse(TerminalPreciotextBox.Text.Replace('.', ','), out float PrecioTerminal))
            {
                float precioTotal = CalculateTotalPriceTerminal(PrecioTerminal);
                PriceLabel.Text = $" {precioTotal}€";
            }
            else
            {
                MessageBox.Show("El valor del terminal debe ser un numero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private float CalculateTotalPriceTerminal(float PrecioTerminal)
        {
            double BeneficioTerminal = double.Parse(Variables.BeneficioTerminal);
            double Canon = double.Parse(Variables.PrecioCanon);

            double precio = PrecioTerminal;
            double aumento = precio * 0.262;
            double PreciaSinRedondeo = (precio + aumento) + BeneficioTerminal;
            double precioRedondeado = AplicarRedondeoComercial(PreciaSinRedondeo);

            if (checkBox1.Checked == true)
            {
                precioRedondeado += Canon;
            }

            return (float)precioRedondeado;
        }

        private double AplicarRedondeoComercial(double value)
        {
            int intValue = (int)value; // Truncate decimal part
            int lastDigit = intValue % 10; // Get the last digit

            int roundedLastDigit;
            if (lastDigit < 5)
            {
                roundedLastDigit = 4;
            }
            else
            {
                roundedLastDigit = 9;
            }

            return intValue - lastDigit + roundedLastDigit; // Adjust the last digit
        }


        private void LoadSettings()
        {
            string filePath = "config.txt";

            try
            {
                if (File.Exists(filePath))
                {
                    // Leer las configuraciones del archivo
                    string[] lines = File.ReadAllLines(filePath);

                    // Recorrer las líneas y asignar valores a las variables
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split('=');
                        if (parts.Length == 2)
                        {
                            string key = parts[0];
                            string value = parts[1];

                            // Asignar los valores a las variables correspondientes
                            switch (key)
                            {
                                case "BeneficioTerminal":
                                    Variables.BeneficioTerminal = value;
                                    break;
                                case "PrecioCanon":
                                    Variables.PrecioCanon = value;
                                    break;
                                    // Puedes agregar más casos para más configuraciones
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las configuraciones: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormPTerminal_Load(object sender, EventArgs e)
        {
            LoadSettings();
            checkBox1.Text = "Canon(" + Variables.PrecioCanon + "€)";
        }

        private void OcultarBox1_Click(object sender, EventArgs e)
        {
            TerminalPreciotextBox.PasswordChar = '*';
            OcultarBox1.Visible = false;
            desocultarbox.Visible = true;
        }

        private void desocultarbox_Click(object sender, EventArgs e)
        {
            TerminalPreciotextBox.PasswordChar = '\0';
            desocultarbox.Visible = false;
            OcultarBox1.Visible = true;
        }
    }
}
