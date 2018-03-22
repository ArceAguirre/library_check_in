using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace library_check_in
{
    public class PROPS
    {
        public static string EMPTY = "";
        public static int CERO = 0;

        public static string CONSULT_L1 = "L1";
        public static string CONSULT_L2 = "L2";
        public static string CONSULT_L3 = "L3";
        public static string CONSULT_C1 = "C1";

        public static string TABLE_CAREER = "career";
        public static string TABLE_TYPE_NOT_STUDENT = "type_not_student";
        public static string TABLE_TYPE_USER = "type_user";
        public static string TABLE_USER_CICE = "user_CICE";
        public static string TABLE_STUDENT = "student";
        public static string TABLE_NOT_STUDENT = "not_student";

        /****************************************************************/
        /*  Author      | Arcelia Aguirre                               */
        /*  Description | Limpiar TextBox                               */
        /*  Date        | 28-02-2018                                    */
        /*  Parameters  | TextBox[] componen                            */
        /****************************************************************/
        public static void clear(TextBox[] component)
        {
            for (int i = 0; i < component.Length; i++)
            {
                if (component[i] != null)
                    component[i].Text = EMPTY;
            }
        }

        /****************************************************************/
        /*  Author      | Arcelia Aguirre                               */
        /*  Description | El campo solo acepta caracteres númericos     */
        /*  Date        | 23-02-2018                                    */
        /*  Parameters  | object sender, KeyPressEventArgs e            */
        /****************************************************************/
        public static void onlyNumbers(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        //void upperText(Text)
        //{

        //}
        //string textIn;
        //textIn + ".text" = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textIn + "text");
        //textIn+ ".text".SelectionStart = textIn + ".text".Length;
    }
}
