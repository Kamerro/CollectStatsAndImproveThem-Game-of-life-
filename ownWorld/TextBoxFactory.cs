using System;
using System.Drawing;
using System.Windows.Forms;

namespace ownWorld
{
    internal class TextBoxFactory
    {
        internal static void TxtMaker(TextBox txt)
        {
            txt.Size = new Size(120, 20);
            txt.Text = "Write new parameter";
        }
    }
}