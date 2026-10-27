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
    public partial class PReparacion : Form
    {
        public PReparacion()
        {
            InitializeComponent();
        }

        private void PReparacion_Load(object sender, EventArgs e)
        {
            LoadSettings();
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
                                case "BeneficioReparacion":
                                    Variables.BeneficioReparacion = value;
                                    break;
                                case "DescuentoPieza":
                                    Variables.DescuentoPieza = value;
                                    break;
                                case "DuescuentoPrimeraVez":
                                    Variables.PrimeraVez = value;
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

        private void button4_Click(object sender, EventArgs e)
        {
            if (float.TryParse(PiezaPreciotextBox.Text.Replace('.', ','), out float precioPieza))
            {
                float precioTotal = CalculateTotalPrice(precioPieza);

                if (checkBox1.Checked == true)
                {
                    int descuentoPorcentaje = int.Parse(Variables.DescuentoPieza);
                    // Calcular el factor de descuento
                    float factorDescuento = 1.0f - (descuentoPorcentaje / 100.0f);

                    precioTotal = precioTotal * factorDescuento;
                    // Redondear el resultado a dos decimales
                    precioTotal = (float)Math.Round(precioTotal, 2);
                }

                if (checkBox2.Checked == true)
                {
                    int descuentoPorcentaje = int.Parse(Variables.PrimeraVez);
                    // Calcular el factor de descuento
                    float factorDescuento = 1.0f - (descuentoPorcentaje / 100.0f);

                    precioTotal = precioTotal * factorDescuento;
                    // Redondear el resultado a dos decimales
                    precioTotal = (float)Math.Round(precioTotal, 2);
                }

                PriceLabel.Text = $"{precioTotal}€";
            }
            else
            {
                MessageBox.Show("El valor de la pieza debe ser un numero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private float CalculateTotalPrice(float precioPieza)
        {
            float BeneficioPieza = float.Parse(Variables.BeneficioReparacion);

            float precioSinImpuestos = precioPieza + BeneficioPieza;
            float precioConImpuestos = precioSinImpuestos * 1.21f;
            float precioRedondeado = RoundToNearest9(precioConImpuestos);

            return precioRedondeado;
        }


        private float RoundToNearest9(float value)
        {
            int intValue = (int)value;
            int lastDigit = intValue % 10;
            int roundedLastDigit = (int)Math.Round((float)lastDigit / 9) * 9;

            if (roundedLastDigit == 0)
            {
                roundedLastDigit = 9; // Si el redondeo es 0, ajustar a 9
            }

            return intValue - lastDigit + roundedLastDigit;
        }

        private void desocultarbox_Click(object sender, EventArgs e)
        {
            PiezaPreciotextBox.PasswordChar = '\0';
            desocultarbox.Visible = false;
            OcultarBox1.Visible = true;
        }

        private void OcultarBox1_Click(object sender, EventArgs e)
        {
            PiezaPreciotextBox.PasswordChar = '*';
            OcultarBox1.Visible = false;
            desocultarbox.Visible = true;
        }
    }



}
