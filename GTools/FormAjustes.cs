using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTools
{
    public partial class FormAjustes : Form
    {
        public FormAjustes()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormAjustes_Load(object sender, EventArgs e)
        {
            LoadSettings();
            UsernameTextBox.Text = Variables.Username.ToString();
            PassTextBox.Text = Variables.Password.ToString();
            textBox1.Text = Variables.Licencia.ToString();
            BReparacionTextBox.Text = Variables.BeneficioReparacion.ToString();
            DescuentoPiezatextBox.Text = Variables.DescuentoPieza.ToString();
            DescuentoPrimeraVezTextBox.Text = Variables.PrimeraVez.ToString();
            BTerminalTextBox.Text = Variables.BeneficioTerminal.ToString();
            PCanonTextBox.Text = Variables.PrecioCanon.ToString();
            //TopForm
            if(Variables.TopForm == "true")
            {
                TopFormCheckBox.Checked = true;
            }


            (string isValid, string duration) = CheckLicense(Variables.Licencia);

            //Tiempo Licencia Expiracion
            if (duration != "0")
            {
                timelicenselabel.Text = $" Duracion Licencia: \n{duration} Dias";
            }
            else
            {
                timelicenselabel.Text = $" Duracion Licencia: \nExpirada";
            }


        }

        private void SaveButton_Click(object sender, EventArgs e)
        {


            //TopForm
            //TopForm
            if (TopFormCheckBox.Checked == true)
            {
                //Activar Por Encima Gtools
                Variables.TopForm = "true";
            }
            else
            {
                //Desactivar Por Encima Gtools
                Variables.TopForm = "false";
            }

            (string isValid, string duration) = CheckLicense(textBox1.Text);

            if (string.IsNullOrWhiteSpace(textBox1.Text)) textBox1.Text = "Null";
            if (false && textBox1.Text == "")
            {
                MessageBox.Show("Ingrese una Licencia válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método si el valor no es un número o está vacío

            }

            //Tiempo Licencia Expiracion
            if (duration != "0")
            {
                timelicenselabel.Text = $" Duracion Licencia: \n{duration} Dias";
            }
            else
            {
                timelicenselabel.Text = $" Duracion Licencia: \nExpirada";
            }

            // Comprobar si el texto introducido en textbox2 es un número
            if (!double.TryParse(BReparacionTextBox.Text, out _))
            {
                MessageBox.Show("El valor del Beneficio de la pieza debe ser un número.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método si el valor no es un número
            }

            // Comprobar si el texto introducido en textbox2 es un número
            if (!double.TryParse(DescuentoPiezatextBox.Text, out _))
            {
                MessageBox.Show("El valor del descuento de la pieza debe ser un número.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método si el valor no es un número
            }

            // Comprobar si el texto introducido en textbox2 es un número
            if (!double.TryParse(DescuentoPrimeraVezTextBox.Text, out _))
            {
                MessageBox.Show("El valor del descuento de la pieza debe ser un número.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método si el valor no es un número
            }

            // Comprobar si el texto introducido en textbox2 es un número
            if (!double.TryParse(BTerminalTextBox.Text, out _))
            {
                MessageBox.Show("El valor del Beneficio del terminal debe ser un número.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método si el valor no es un número
            }

            // Comprobar si el texto introducido en textbox2 es un número
            if (!double.TryParse(PCanonTextBox.Text, out _))
            {
                MessageBox.Show("El valor del Canon del terminal debe ser un número.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método si el valor no es un número
            }

            SaveSettings();
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
                                case "Username":
                                    Variables.Username = value;
                                    break;
                                case "Password":
                                    Variables.Password = value;
                                    break;
                                case "Licencia":
                                    Variables.Licencia = value;
                                    break;
                                case "BeneficioReparacion":
                                    Variables.BeneficioReparacion = value;
                                    break;
                                case "DescuentoPieza":
                                    Variables.DescuentoPieza = value;
                                    break;
                                case "DescuentoPrimeraVez":
                                    Variables.PrimeraVez = value;
                                    break;
                                case "BeneficioTerminal":
                                    Variables.BeneficioTerminal = value;
                                    break;
                                case "PrecioCanon":
                                    Variables.PrecioCanon = value;
                                    break;
                                case "TopForm":
                                    Variables.TopForm = value;
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

        private void SaveSettings()
        {
            string filePath = "config.txt";

            try
            {
                // Verificar si el archivo existe
                if (!File.Exists(filePath))
                {
                    // Si no existe, crea el archivo
                    using (StreamWriter createFile = File.CreateText(filePath))
                    {
                        createFile.Close();
                    }
                }

                // Escribir en el archivo
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine("==Login==");
                    writer.WriteLine("Username=" + UsernameTextBox.Text);
                    Variables.Username = UsernameTextBox.Text;
                    writer.WriteLine("Password=" + PassTextBox.Text);
                    Variables.Password = PassTextBox.Text;
                    writer.WriteLine("Licencia=" + textBox1.Text);
                    writer.WriteLine("==Settings==");
                    Variables.Licencia = textBox1.Text;
                    writer.WriteLine("BeneficioReparacion=" + BReparacionTextBox.Text);
                    Variables.BeneficioReparacion = BReparacionTextBox.Text;
                    writer.WriteLine("DescuentoPieza=" + DescuentoPiezatextBox.Text);
                    Variables.DescuentoPieza = DescuentoPiezatextBox.Text;
                    writer.WriteLine("DescuentoPrimeraVez=" + DescuentoPrimeraVezTextBox.Text);
                    Variables.PrimeraVez = DescuentoPrimeraVezTextBox.Text;
                    writer.WriteLine("BeneficioTerminal=" + BTerminalTextBox.Text);
                    Variables.BeneficioTerminal = BTerminalTextBox.Text;
                    writer.WriteLine("PrecioCanon=" + PCanonTextBox.Text);
                    Variables.PrecioCanon = PCanonTextBox.Text;

                    if(TopFormCheckBox.Checked == true)
                    {
                        writer.WriteLine("TopForm=" + "true");
                    }
                    else
                    {
                        writer.WriteLine("TopForm=" + "false");
                    }

                }

                MessageBox.Show("Configuraciones guardadas correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar las configuraciones: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //============================================================================================================

        //Conseguir la Mac para hacer la id
        private string GetMacAddress()
        {
            string macAddress = string.Empty;
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.NetworkInterfaceType != NetworkInterfaceType.Loopback && nic.OperationalStatus == OperationalStatus.Up)
                {
                    macAddress = nic.GetPhysicalAddress().ToString();
                    break;
                }
            }
            return macAddress;
        }

        private string GenerateId(string macAddress)
        {
            // Asegurar que la MAC tenga exactamente 12 caracteres (6 bytes)
            macAddress = System.Text.RegularExpressions.Regex.Replace(macAddress, "[^A-Fa-f0-9]", "").PadLeft(12, '0');

            // Convertir a BigInteger en lugar de long (más seguro con tamaños grandes)
            System.Numerics.BigInteger macInt = System.Numerics.BigInteger.Parse("0" + macAddress, NumberStyles.HexNumber);

            // Usar módulo para limitar a 9 dígitos
            BigInteger id = macInt % 1000000000;

            return id.ToString("D9"); // Siempre 9 dígitos, incluyendo ceros al principio si los hay
        }

        public static (string valida, string duration) CheckLicense(string encryptedLicense)
        {
            if (string.IsNullOrEmpty(encryptedLicense) || 
                encryptedLicense.Equals("Null", StringComparison.OrdinalIgnoreCase) || 
                encryptedLicense.Equals("Demo", StringComparison.OrdinalIgnoreCase))
            {
                return ("True", "999");
            }

            // Desencriptar la licencia usando AES
            string decryptedLicense = DecryptString(encryptedLicense);


            if (decryptedLicense == null || decryptedLicense.Length < 18)
            {
                // Si la licencia desencriptada es nula o tiene una longitud menor a 18 caracteres, la licencia no es válida
                return ("false", "0");
            }

            // Extraer la información de la licencia
            string preLicenseString = decryptedLicense.Substring(0, 10); // 10 caracteres para la prelicencia
            string expirationDateString = decryptedLicense.Substring(10, 8); // 8 caracteres para la fecha de expiración

            DateTime expirationDate = DateTime.ParseExact(expirationDateString, "yyyyMMdd", CultureInfo.InvariantCulture);

            bool isValidbool;
            if (Variables.PreLicencia == preLicenseString)
            {
                isValidbool = true;
            }
            else
            {
                isValidbool = false;
            }

            // Calcular los días restantes hasta la fecha de expiración
            TimeSpan remainingTime = expirationDate.Date - DateTime.Today;
            int daysremainingTime = (int)remainingTime.TotalDays;

            string duration = daysremainingTime.ToString();

            string isValid = isValidbool.ToString();

            // Devolver la validez y la duración de la licencia
            return (isValid, duration);
        }

        //PreLicencia
        public static string GeneratePreLicense(string id)
        {
            int idNumber = int.Parse(id);

            int preLicenseNumber = (idNumber * 2) + 83675;

            string preLicenseString = preLicenseNumber.ToString();

            return preLicenseString;
        }

        // Genera una licencia exclusiva para la ID proporcionada
        public static string GenerateLicense(string id, int months)
        {
            int idNumber = int.Parse(id);

            int preLicenseNumber = (idNumber * 2) + 83675;

            string preLicenseString = preLicenseNumber.ToString();

            // Generar la fecha de expiración
            DateTime expirationDate = DateTime.Today.AddMonths(months);
            string expirationDateString = expirationDate.ToString("yyyyMMdd");

            // Combinar la prelicencia con la fecha de expiración
            string fullLicense = preLicenseString + expirationDateString;

            // Encriptar la licencia usando AES
            string encryptedLicense = EncryptString(fullLicense);

            return encryptedLicense;
        }


        //EncriptarLicencia
        public static string EncryptString(string plainText)
        {
            string key = "GYPSYGYPSYGYPSY1"; // 16 caracteres para AES-128
            string iv = "ABCDEF0123456789"; // 16 caracteres para AES-128

            byte[] keyBytes = Encoding.UTF8.GetBytes(key);
            byte[] ivBytes = Encoding.UTF8.GetBytes(iv);
            byte[] inputBytes = Encoding.UTF8.GetBytes(plainText);

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = keyBytes;
                aesAlg.IV = ivBytes;

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        csEncrypt.Write(inputBytes, 0, inputBytes.Length);
                        csEncrypt.FlushFinalBlock();

                        byte[] encryptedBytes = msEncrypt.ToArray();

                        return Base32Encode(encryptedBytes);
                    }
                }
            }
        }

        // Helper method to convert byte array to Base32 string
        private static string Base32Encode(byte[] data)
        {
            const string base32Chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ234567";
            int bits = 0;
            int value = 0;
            StringBuilder result = new StringBuilder((data.Length + 4) / 5 * 8);

            foreach (byte b in data)
            {
                value = (value << 8) | b;
                bits += 8;

                while (bits >= 5)
                {
                    result.Append(base32Chars[(value >> (bits - 5)) & 0x1F]);
                    bits -= 5;
                }
            }

            if (bits > 0)
            {
                result.Append(base32Chars[(value << (5 - bits)) & 0x1F]);
            }

            return result.ToString();
        }


        //Desencriptar
        public static string DecryptString(string encryptedText)
        {
            string key = "GYPSYGYPSYGYPSY1"; // 16 caracteres para AES-128
            string iv = "ABCDEF0123456789"; // 16 caracteres para AES-128

            byte[] keyBytes = Encoding.UTF8.GetBytes(key);
            byte[] ivBytes = Encoding.UTF8.GetBytes(iv);
            byte[] encryptedBytes;

            try
            {
                encryptedBytes = Base32Decode(encryptedText);
            }
            catch (FormatException)
            {
                return null;
            }

            try
            {
                using (Aes aesAlg = Aes.Create())
                {
                    aesAlg.Key = keyBytes;
                    aesAlg.IV = ivBytes;

                    ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                    using (MemoryStream msDecrypt = new MemoryStream(encryptedBytes))
                    {
                        using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                        {
                            using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                            {
                                return srDecrypt.ReadToEnd();
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        // Helper method to convert Base32 string to byte array
        private static byte[] Base32Decode(string input)
        {
            const string base32Chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ234567";
            try
            {
                if (string.IsNullOrEmpty(input))
                {
                    throw new ArgumentNullException(nameof(input));
                }
            }
            catch (Exception)
            {
                return null;
            }


            input = input.TrimEnd('=');
            int byteCount = input.Length * 5 / 8;
            byte[] returnArray = new byte[byteCount];

            byte curByte = 0, bitsRemaining = 8;
            int mask = 0, arrayIndex = 0;

            foreach (char c in input)
            {
                int cValue = base32Chars.IndexOf(c);

                if (cValue < 0)
                {
                    throw new FormatException("Invalid Base32 character.");
                }

                if (bitsRemaining > 5)
                {
                    mask = cValue << (bitsRemaining - 5);
                    curByte = (byte)(curByte | mask);
                    bitsRemaining -= 5;
                }
                else
                {
                    mask = cValue >> (5 - bitsRemaining);
                    curByte = (byte)(curByte | mask);
                    returnArray[arrayIndex++] = curByte;
                    curByte = (byte)(cValue << (3 + bitsRemaining));
                    bitsRemaining += 3;
                }
            }

            if (arrayIndex != byteCount)
            {
                returnArray[arrayIndex] = curByte;
            }

            return returnArray;
        }

        private void timelicenselabel_Click(object sender, EventArgs e)
        {

        }

        private void DescuentoPiezatextBox_TextChanged(object sender, EventArgs e)
        {

        }

        //================================================================
    }
}
