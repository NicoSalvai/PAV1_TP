using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CEE.Negocio.Auxiliares
{
    public class ErrorProviderExtension
    {
        private int count;
        ErrorProvider ep;
        public ErrorProviderExtension(ErrorProvider ep)
        {
            this.ep = ep;
        }

        public void SetErrorWithCount(Control c, string message)
        {
            if (message == "")
            {
                if (ep.GetError(c) != "")
                    count--;
            }
            else
            {
                if(ep.GetError(c) == "")
                    count++;
            }
                
            
            ep.SetError(c, message);
        }

        public bool HasErrors()
        {
            return count != 0;
        }

        public int GetErrorCount()
        {
            return count;
        }
    }

}
