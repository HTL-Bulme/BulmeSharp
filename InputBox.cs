using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BulmeSharp
{
    public enum InputDataType
    {
        TypeString,
        TypeDouble,
        TypeFloat,
        TypeInteger
    }

    public partial class InputBox : Form
    {
        private InputDataType DataType;
        
        private string stringValue = "";
        private double doubleValue = 0;
        private float floatValue = 0;
        private int intValue = 0;

        public InputBox()
        {
            InitializeComponent();
        }
        public string InputString(string message)
        {
            DataType = InputDataType.TypeString;
            LblMessage.Text = message;
            this.ShowDialog();
            return stringValue;
        }

        public double InputDouble(string message)
        {
            DataType = InputDataType.TypeDouble;
            LblMessage.Text = message;
            this.ShowDialog();
            return doubleValue;
        }

        public float InputFloat(string message)
        {
            DataType = InputDataType.TypeFloat;
            LblMessage.Text = message;
            this.ShowDialog();
            return floatValue;
        }

        public int InputInt(string message)
        {
            DataType = InputDataType.TypeInteger;
            LblMessage.Text = message;
            this.ShowDialog();
            return intValue;
        }

        private void BtnOkay_Click(object sender, EventArgs e)
        {
            stringValue = TxtInput.Text;
            switch (DataType)
            {
                case InputDataType.TypeString:
                    //no validation needed
                    this.Close();
                    break;
                case InputDataType.TypeDouble:
                case InputDataType.TypeFloat:

                    double number = 0;
                    if (!double.TryParse(stringValue, out number))
                    {
                        MessageBox.Show(
                            "Das war keine gültige Gleitkommazahl.\n\nGültige Gleitkommazahlen sind beispielsweiwse:" +
                            "\n      3.14 oder \n   -123 oder \n 32318,123",
                            "Fehler bei der Eingabe",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.DefaultDesktopOnly
                        );
                    }
                    else
                    {
                        if (DataType == InputDataType.TypeDouble)
                        {
                            doubleValue = number;
                        }
                        else
                        {
                            floatValue = (float)number;
                        }
                        this.Close();
                    }

                    break;
                case InputDataType.TypeInteger:


                    int intNumber = 0;
                    if (!int.TryParse(stringValue, out intNumber))
                    {
                        MessageBox.Show(
                            "Das war keine gültige Ganzzahl (int).\n\nGültige Ganzzahlen sind beispielsweiwse:" +
                            "\n    5 oder \n  -13 oder \n 1567",
                            "Fehler bei der Eingabe",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.DefaultDesktopOnly
                        );
                    }
                    else
                    {
                        intValue = intNumber;
                        this.Close();
                    }

                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        private void InputBox_Shown(object sender, EventArgs e)
        {
            TxtInput.Focus();
        }
    }
}
