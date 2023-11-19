using System.Windows.Forms;

namespace ownWorld
{
    public class LetterService
    {
        public static string MakeMoreSenseOfTheNameFrom(string val)
        {
            string newVal = "";
            try
            {
                foreach (char character in val)
                {
                    if (char.IsLower(character) || newVal == string.Empty)
                    {
                        newVal += character;
                    }
                    else
                    {
                        newVal += " " + char.ToLower(character);
                    }
                }
               // MessageBox.Show(newVal);
            }
            catch
            {
                MessageBox.Show("Omg its over anakin");
            }

         return newVal;
        }
    }
}