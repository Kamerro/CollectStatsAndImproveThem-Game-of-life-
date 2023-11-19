using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ownWorld
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> dict = new Dictionary<string, string>();
        public Form1()
        {
            InitializeComponent();
            DictionaryService.AddValuesToDictionary(dict);
        }
       
    
        private void parametersToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            CheckAction(e.ClickedItem);
        }

        private void CheckAction(ToolStripItem clickedItem)
        {
            //Dictionary fuctionary:
            MessageBox.Show(clickedItem.Text);
            try
            {

                if (!(dict.Values.First(x => x == clickedItem.Text).ToString() is null))
                {

                    FormService.MakeAction(Strip,clickedItem,dict);

                    return;
                }
            }
            catch (Exception ex) { MessageBox.Show($"No value found in dictionary, {ex.Message}"); }
         
        }

        private void addNewParameterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
