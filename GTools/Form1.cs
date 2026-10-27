namespace GTools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSettings();
            // Establecer AcceptsReturn a true para permitir el uso de Enter sin borrar el texto
            UsernameTextBox.AcceptsReturn = true;
        }

        private void LoginButtom_Click(object sender, EventArgs e)
        {

            string username = Variables.Username;
            string password = Variables.Password;

            // Comprobar si el nombre de usuario y la contraseña son "admin"
            if (UsernameTextBox.Text == username && PasswordtextBox.Text == password)
            {
                new Main().Show();
                this.Hide();
                //MessageBox.Show("Inicio de sesión exitoso.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            } else if (UsernameTextBox.Text == ""){
                MessageBox.Show("Ingresa un Username valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (PasswordtextBox.Text == ""){
                MessageBox.Show("Ingresa un Password valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UsernameTextBox.Clear();
                PasswordtextBox.Clear();
                UsernameTextBox.Focus();
                return;
            }
        }

        private void UsernameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            // Verifica si la tecla presionada es Enter y Pasa al siguiente Campo
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                PasswordtextBox.Focus();
            }
        }

        private void UsernameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void PasswordtextBox_KeyDown(object sender, KeyEventArgs e)
        {
            // Verifica si la tecla presionada es Enter y Pasa al siguiente Campo
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                LoginButtom.Focus();
            }
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



    }
}
