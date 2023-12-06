using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hub_Exercicios.Class
{
    internal class FecharTudo
    {
        internal static void FecharFormularios()
        {
            foreach (Form formaberto in Application.OpenForms)
            {
                formaberto.Close();
            }
        }
    }
}
