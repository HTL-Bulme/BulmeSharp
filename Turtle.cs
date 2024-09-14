using BulmeSharp.Commands;
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
        private static TurtleForm CurrentForm = null;

        private static TurtleForm GetForm()
        {

            if (CurrentForm == null)
            {
                CurrentForm = new TurtleForm();
            }

            return CurrentForm;
        }

        public static void fd(double distance)
        {
            ForwardCommand cmd = new ForwardCommand(distance);
            GetForm().AddCommand(cmd);
        }

        public static void bk(double distance)
        {
            ForwardCommand cmd = new ForwardCommand(-distance);
            GetForm().AddCommand(cmd);
        }

        public static void rt(double angle)
        {
            RotateRight cmd = new RotateRight(angle);
            GetForm().AddCommand(cmd);
        }

        public static void lt(double angle)
        {
            RotateRight cmd = new RotateRight(-angle);
            GetForm().AddCommand(cmd);
        }

        public static void showTurtle()
        {
            var form = GetForm();
            form.ShowDialog();
        }

        public static double InputDouble(string message)
        {
            return new InputBox().InputDouble(message);
        }

        public static float InputFloat(string message)
        {
            return new InputBox().InputFloat(message);
        }

        public static int InputInt(string message)
        {
            return new InputBox().InputInt(message);
        }

        public static string InputString(string message)
        {
            return new InputBox().InputString(message);
        }

        public static void Print(string value)
        {
            Console.WriteLine(value);
        }

        public static void Print(int value)
        {
            Console.WriteLine(value);
        }

        public static void Print(float value)
        {
            Console.WriteLine(value);
        }

        public static void Print(double value)
        {
            Console.WriteLine(value);
        }

        public static void Print(bool value)
        {
            Console.WriteLine(value);
        }

        public static void Print(object value)
        {
            Console.WriteLine(value);
        }
    }
}
