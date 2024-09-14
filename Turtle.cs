using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BulmeSharp
{
    public static class Turtle
    {
        public static TurtleForm CurrentForm = null;


        static void StaticClass_Dtor(object sender, EventArgs e)
        {
            // clean it up
        }

        private static Form GetForm()
        {

            if (CurrentForm == null)
            {
                CurrentForm = new TurtleForm();
                CurrentForm.Show();
            }

            return CurrentForm;
        }

        public static void fd(double distance)
        {
            var form = GetForm();
            
        }

        public static double readDouble(string message)
        {
            InputBox inputBox = new InputBox();
            return inputBox.ReadDouble(message);
        }
    }
}
