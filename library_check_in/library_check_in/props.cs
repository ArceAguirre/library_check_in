using System;
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
        
        public enum COMPONENT { COMPONENT_TEXT_BOX, COMPONENT_COMBO_BOX, COMPONENT_DATE_TIME };
        public enum MESSAGE_ERROR { DATA_BASE, DATA_BASE_CONSOLE, NOT_SAVE, NOT_UPDATE, NOT_DELETE, NOT_LOAD, NOT_LOAD_CONSOLE, NOT_CLEAR };

        //private string ERROR_DATA_BASE = "dataBase";
        /**
         *  Author      | Arcelia Aguirre
         *  Description | Limpiar TextBox
         *  Date        | 28-02-2018
         *  Parameters  | TextBox[] componen
         */
        public static void clear(object[] component, int type)
        {
            switch (type)
            {
                /*Textbox*/
                case (int)COMPONENT.COMPONENT_TEXT_BOX:
                    for (int i = 0; i < component.Length; i++)
                    {
                        if (component[i] != null)
                            ((TextBox)component[i]).Text = EMPTY;
                    }
                break;
                /*Combo box*/
                case (int)COMPONENT.COMPONENT_COMBO_BOX:
                    for (int i = 0; i < component.Length; i++)
                    {
                        if (component[i] != null && ((ComboBox)component[i]).Items.Count > 0)
                            ((ComboBox)component[i]).SelectedIndex = CERO;
                    }
                break;
                /* Date Time Picker*/
                case (int)COMPONENT.COMPONENT_DATE_TIME:
                    for (int i = 0; i < component.Length; i++)
                    {
                        if (component[i] != null)
                            ((DateTimePicker)component[i]).ResetText();
                    }
                break;
                default :
                break;
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
        public static bool emptyComponent(object[] component, int type)
        {
            switch (type)
            {
                case (int)COMPONENT.COMPONENT_TEXT_BOX:
                    if (component == null) return false;
                    for (int i = 0; i < component.Length; i++)
                    {
                        if (component[i] != null)
                        {
                            if (((TextBox)component[i]).Text == EMPTY)
                            {
                                MessageBox.Show("El campo de " + ((TextBox)component[i]).AccessibleName + " no puede estar vacío");
                                return false;
                            }
                        }
                        else
                            return false;
                    }
                    break;
                case (int)COMPONENT.COMPONENT_COMBO_BOX:
                    if (component == null) return false;
                    for (int i = 0; i < component.Length; i++)
                    {
                        if (component[i] != null)
                        {
                            if (((ComboBox)component[i]).SelectedValue == null)
                            {
                                MessageBox.Show("Se tiene que seleccionar opción de " + ((ComboBox)component[i]).AccessibleName);
                                return false;
                            }
                        }
                        else
                            return false;
                    }
                    break;
            }
            return true;
        }
        /**
         *  Author      | Arcelia Aguirre
         *  Description | Mensajes de Error
         *  Date        | 16-04-2018
         *  Parameters  | string error, codigo de error
         */
        public static void messageError(int error)
        {
            switch (error)
            {
                case (int)MESSAGE_ERROR.DATA_BASE :
                    Console.WriteLine("Ocurrió un error con la base de datos");
                    break;
                case (int)MESSAGE_ERROR.DATA_BASE_CONSOLE :
                    Console.WriteLine("Ocurrió un error con la base de datos");
                    break;
                case (int)MESSAGE_ERROR.NOT_SAVE:
                    MessageBox.Show("Ocurrió un error al guardar");
                    break;
                case (int)MESSAGE_ERROR.NOT_UPDATE:
                    MessageBox.Show("Ocurrió un error la actualizar");
                    break;
                case (int)MESSAGE_ERROR.NOT_DELETE:
                    MessageBox.Show("Ocurrió un error la eliminar");
                    break;
                case (int)MESSAGE_ERROR.NOT_LOAD:
                    MessageBox.Show("Ocurrió un error la cargar los datos");
                    break;
                case (int)MESSAGE_ERROR.NOT_LOAD_CONSOLE:
                    Console.WriteLine("Ocurrió un error la cargar los datos");
                    break;
                case (int)MESSAGE_ERROR.NOT_CLEAR:
                    MessageBox.Show("No se limpiaron correctamente los campos");
                    break;
                default:
                    MessageBox.Show("Ocurrió un error");
                    break;
            }
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
        /**
          *  Author      | Juan Pablo Espinoza
          *  Description | Mayusculas en la pirmera letra de cada palabra
          *  Date        | 15-02-2018
          *  Parameters  | object sender, EventArgs e
          *  ************************************************************
          *  Author      | Arcelia Aguirre
          *  Description | Modificación
          *  Date        | 19-04-2018
          *  Parameters  | object sender, EventArgs e
          */
        public static void UpperTextBox(object component, EventArgs e)
        {
            TextBox textBox = (TextBox)component;
            textBox.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox.Text);
            textBox.SelectionStart = textBox.Text.Length;
        }
    }
}