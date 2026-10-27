namespace GTools
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            //Definiendo Valores de Variables Predeterminadas
            Variables.Username = "";
            Variables.Password = "";
            Variables.Licencia = "Null";
            Variables.BeneficioReparacion = "40";
            Variables.BeneficioTerminal = "20";
            Variables.DescuentoPieza = "30";
            Variables.PrimeraVez = "10";
            Variables.PrecioCanon = "3,25";
            Variables.TopForm = "false";


            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}