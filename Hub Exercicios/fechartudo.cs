using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hub_Exercicios
{
    internal class FecharTudo
    {
        internal static void FecharFormularios()
        {
            var fecharForm = Application.OpenForms.Cast<Form>().ToList();
            foreach (Form frm in fecharForm)
            {
                frm.Close();
            }
        }
    }
}
