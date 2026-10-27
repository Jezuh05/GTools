using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTools
{
    public class ClipboardHelper
    {
        public static void CopyToClipboard(string text)
        {
            try
            {
                Clipboard.SetText(text);
                Console.WriteLine("Texto copiado al portapapeles: " + text);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al copiar al portapapeles: " + ex.Message);
                // Puedes manejar la excepción según sea necesario
            }
        }
    }
}
