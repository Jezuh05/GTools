using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTools
{
    public partial class Main : Form
    {
        private int m;
        private int mx;
        private int my;

        public Main()
        {
            InitializeComponent();

            // Crear la Id de Usuario a partir de su Mac
            string macAddress = GetMacAddress();
            string id = GenerateId(macAddress);
            label1.Text = "ID: " + id;

            // Generar prelicencia (10 dígitos exactos) y guardar
            string prelicense = GeneratePreLicense(id);
            Variables.PreLicencia = prelicense;

            // Verificar la licencia y obtener validez y duración
            (string isValid, string duration) = CheckLicense(Variables.Licencia);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
            string macAddress = GetMacAddress();
            string id = GenerateId(macAddress);

            ClipboardHelper.CopyToClipboard(id);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // Cargar Config.txt
            LoadSettings();

            // TopForm
            if (Variables.TopForm == "true")
            {
                this.TopMost = true;
            }
            else
            {
                this.TopMost = false;
            }
        }

        // ============================================================================================================

        // Conseguir la Mac para hacer la id
        private string GetMacAddress()
        {
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.NetworkInterfaceType != NetworkInterfaceType.Loopback &&
                    nic.OperationalStatus == OperationalStatus.Up)
                {
                    string mac = nic.GetPhysicalAddress().ToString();

                    if (!string.IsNullOrEmpty(mac))
                    {
                        return mac.PadLeft(12, '0').ToUpperInvariant();
                    }
                }
            }

            return "000000000000";
        }

        private string GenerateId(string macAddress)
        {
            macAddress = System.Text.RegularExpressions.Regex.Replace(macAddress, "[^A-Fa-f0-9]", "").PadLeft(12, '0').ToUpperInvariant();

            System.Numerics.BigInteger macInt = System.Numerics.BigInteger.Parse("0" + macAddress, System.Globalization.NumberStyles.HexNumber);

            System.Numerics.BigInteger id = macInt % 900000000 + 100000000;

            return id.ToString();
        }

        // Comprobar Licencia (Corregido: valida 18 caracteres y días restantes)
        public static (string valida, string duration) CheckLicense(string encryptedLicense)
        {
            if (string.IsNullOrEmpty(encryptedLicense)) return ("False", "0");

            string decryptedLicense = DecryptString(encryptedLicense);

            // 10 dígitos (PreLicencia) + 8 dígitos (Fecha YYYYMMDD) = 18 caracteres exactos
            if (string.IsNullOrEmpty(decryptedLicense) || decryptedLicense.Length < 18)
            {
                return ("False", "0");
            }

            try
            {
                string preLicenseString = decryptedLicense.Substring(0, 10);
                string expirationDateString = decryptedLicense.Substring(10, 8);

                DateTime expirationDate = DateTime.ParseExact(expirationDateString, "yyyyMMdd", CultureInfo.InvariantCulture);

                TimeSpan remainingTime = expirationDate.Date - DateTime.Today;
                int daysRemaining = (int)remainingTime.TotalDays;

                bool isValid = (Variables.PreLicencia == preLicenseString) && (daysRemaining > 0);

                string durationStr = daysRemaining > 0 ? daysRemaining.ToString() : "0";

                return (isValid.ToString(), durationStr);
            }
            catch
            {
                return ("False", "0");
            }
        }

        // Generar PreLicencia (Corregido: forzado a 10 dígitos)
        public static string GeneratePreLicense(string id)
        {
            if (!long.TryParse(id, out long idNumber)) return "0000000000";

            long preLicenseNumber = (idNumber * 2) + 83675;

            return preLicenseNumber.ToString("D10");
        }

        // EncriptarLicencia
        public static string EncryptString(string plainText)
        {
            string key = "GYPSYGYPSYGYPSY1"; // 16 caracteres para AES-128
            string iv = "ABCDEF0123456789";  // 16 caracteres para AES-128

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

        // Desencriptar
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

        private static byte[] Base32Decode(string input)
        {
            const string base32Chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ234567";
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentNullException(nameof(input));
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

        // ============================================================================================================

        private Form formActual = null;
        public void abrirFormHijo(object formHijo)
        {
            if (Variables.TopForm == "true")
            {
                this.TopMost = true;
            }
            else
            {
                this.TopMost = false;
            }

            if (formActual != null)
            {
                this.PanelContainer.Controls.Remove(formActual);
            }

            Form fH = formHijo as Form;
            fH.TopLevel = false;
            fH.Dock = DockStyle.Fill;
            this.PanelContainer.Controls.Add(fH);
            this.PanelContainer.Tag = fH;
            fH.Show();
            formActual = fH as Form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Changelogspanel.Visible = false;

            (string isValid, string duration) = CheckLicense(Variables.Licencia);

            if (isValid == "True")
            {
                abrirFormHijo(new PReparacion());
            }
            else
            {
                MessageBox.Show("Debe activar el programa con una licencia valida en ajustes para poder usar esta funcion.", "Error de licencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Changelogspanel.Visible = false;

            (string isValid, string duration) = CheckLicense(Variables.Licencia);

            if (isValid == "True")
            {
                abrirFormHijo(new FormPTerminal());
            }
            else
            {
                MessageBox.Show("Debe activar el programa con una licencia valida en ajustes para poder usar esta funcion.", "Error de licencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Changelogspanel.Visible = false;

            (string isValid, string duration) = CheckLicense(Variables.Licencia);

            if (isValid == "True")
            {
                MessageBox.Show("Esta funcion esta deshabilitada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Debe activar el programa con una licencia valida en ajustes para poder usar esta funcion.", "Error de licencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Changelogspanel.Visible = false;
            abrirFormHijo(new FormAjustes());
        }

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            this.m = 1;
            this.mx = e.X;
            this.my = e.Y;
        }

        private void TopPanel_MouseUp(object sender, MouseEventArgs e)
        {
            this.m = 0;
        }

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            bool flag = this.m == 1;
            if (flag)
            {
                base.SetDesktopLocation(Control.MousePosition.X - this.mx, Control.MousePosition.Y - this.my);
            }
        }

        private void LoadSettings()
        {
            string filePath = "config.txt";

            try
            {
                if (File.Exists(filePath))
                {
                    string[] lines = File.ReadAllLines(filePath);

                    foreach (string line in lines)
                    {
                        string[] parts = line.Split('=');
                        if (parts.Length == 2)
                        {
                            string key = parts[0];
                            string value = parts[1];

                            switch (key)
                            {
                                case "Licencia":
                                    Variables.Licencia = value;
                                    break;
                                case "TopForm":
                                    Variables.TopForm = value;
                                    break;
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

        private void TopPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PanelContainer_Paint(object sender, PaintEventArgs e)
        {
        }

        private void CreditsLabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este programa no está autorizado para su uso sin una licencia o autorizacion del creador.\nDerechos reservados a Jesus M. Nuñez Fernandez", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Changelogspanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }
    }
}