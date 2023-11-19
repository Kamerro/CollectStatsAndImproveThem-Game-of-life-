using System;
using System.Drawing;
using System.Windows.Forms;

namespace ownWorld
{
   public class ButtonFactory
   {
        internal static void BtnMaker(Button btn)
        {
                btn.Size = new Size(50, 20);
                btn.Text = "Add";
        }
   }
}