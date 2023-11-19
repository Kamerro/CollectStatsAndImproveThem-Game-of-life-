using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ownWorld
{
    public class ServicePlacingControls
    {

        internal static void CalculateNewPlaceForControls(Button btn, TextBox txt, List<TextBox> textBoxes, List<Button> buttons, Panel panel1)
        {
            bool marker;
            int placeholder = 10;
            while (placeholder <= textBoxes.Count * 30 + 10)
            {
                marker = true;
                foreach (Control text in panel1.Controls)
                {
                    if (text is TextBox)
                    {
                        if (text.Location.Y == placeholder)
                        {
                            marker = false;
                        }
                    }

                }

                if (marker)
                {
                    txt.Location = new Point(10, placeholder);
                    btn.Location = new Point(150, placeholder);
                    break;

                }
                placeholder += 30;
            }
        }
    }
}