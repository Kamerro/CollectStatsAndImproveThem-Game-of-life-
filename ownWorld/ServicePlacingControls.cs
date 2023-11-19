using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.NetworkInformation;

namespace ownWorld
{
    public class ServicePlacingControls
    {
        
        public static int initialPlaceholder = 10;
        public static int placeholder = initialPlaceholder;
        public static int spacebetween = 30;
        internal static void CalculateNewPlaceForControls(Button btn, TextBox txt, List<TextBox> textBoxes, List<Button> buttons, Panel panel1)
        {
            bool marker;
            
            while (placeholder <= textBoxes.Count * spacebetween + initialPlaceholder)
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
                placeholder += spacebetween;
            }
            placeholder = initialPlaceholder;
        }
    }
}