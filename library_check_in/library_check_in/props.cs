using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
/**
 *  Author      | Arcelia Aguirre
 *  Description | Clase para constantes y métdos estandar
 *  Date        | 28-02-2018
 *  Parameters  | TextBox[] componen
 */
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

        public string ERROR_DATA_BASE = "dataBase";
        /**
         *  Author      | Arcelia Aguirre
         *  Description | Limpiar TextBox
         *  Date        | 28-02-2018
         *  Parameters  | TextBox[] componen
         */
        public static void clearTextBox(TextBox[] component)
        {
            for (int i = 0; i < component.Length; i++)
            {
                if (component[i] != null)
                    component[i].Text = EMPTY;
            }
        }
        /**
         *  Author      | Arcelia Aguirre
         *  Description | El campo solo acepta caracteres númericos
         *  Date        | 23-02-2018
         *  Parameters  | object sender, KeyPressEventArgs e
         */
        public static void onlyNumbers(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        /**
         *  Author      | Arcelia Aguirre
         *  Description | Validación de campos vacíos
         *  Date        | 16-04-2018
         *  Parameters  | TextBox[] component
         */
        public static bool emptyTextBox(TextBox[] component)
        {
            if (component == null) return false;
            for (int i = 0; i < component.Length; i++)
            {
                if (component[i] != null)
                {
                    if (component[i].Text == EMPTY)
                    {
                        MessageBox.Show("El campo de " + component[i].AccessibleName + " no puede estar vacío");
                        return false;
                    }
                }
                else
                    return false;
                    
            }return true;
        }
        /**
         *  Author      | Arcelia Aguirre
         *  Description | Mensajes de Error
         *  Date        | 16-04-2018
         *  Parameters  | string error, codigo de error
         */
        public static void messageError(string error)
        {
            //MessageBox.Show("Ocurrió un error con la base de datos");
        }
        /**
         *  Author      | Arcelia Aguirre
         *  Description | Deshabilitar TextBox
         *  Date        | 16-04-2018
         *  Parameters  | string error, codigo de error
         */
        public static void enableTextBox(TextBox[] component)
        {
            for (int i = 0; i < component.Length; i++)
            {
                if (component[i] != null)
                    component[i].Enabled = false;
            }
        }
        /**
        *  Author      | Arcelia Aguirre
        *  Description | Deshabilitar botones
        *  Date        | 16-04-2018
        *  Parameters  | string error, codigo de error
        */
        public static void enableButton(Button[] component)
        {
            for (int i = 0; i < component.Length; i++)
            {
                if (component[i] != null)
                    component[i].Enabled = false;
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