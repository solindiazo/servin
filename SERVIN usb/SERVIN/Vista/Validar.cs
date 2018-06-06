using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVIN
{
    public partial class Validar
    {

        public String StringNumerico(String Msg)
        {
            Double x;
            try { 
                x = Convert.ToDouble(Msg); 
                }
            catch
                {
                Msg = "null";
                }
            return Msg;
        }

        public String String(String Msg)
        {

            if (Msg == null)
            {
                return "null";
            }
            else
            {
                return Msg;
            }
               
        }

        public int Entero(String Msg)
        {

            int x;
            try
            {
                x = Convert.ToInt32(Msg);
            }
            catch
            {
                x = 0;
            }
            return x;

        }

        public Double Double(String Msg)
        {

            Double x;
            try
            {
                x = Convert.ToDouble(Msg);
            }
            catch
            {
                x = 0;
            }
            return x;

        }

        public String StringPuro (String Msg)
        {
            List<char> Validos = new List<char>() { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'Ñ', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};

            String cadena = Msg.ToUpper();
            
            foreach (char a in cadena)
            {
                if (!Validos.Contains(a))
                {

                    Msg = "null";

                }

            }

            return Msg;
        }






    }
}
