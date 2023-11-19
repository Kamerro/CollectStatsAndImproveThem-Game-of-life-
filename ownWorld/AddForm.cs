using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ownWorld
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }
        List<TextBox> textBoxes = new List<TextBox>();
        List<Button> buttons = new List<Button>();
        List<Label> labels = new List<Label>();
        private void asDescriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox txt = new TextBox();
            Button btn = new Button();
            if (panel1.Controls.Count == 0)
            {
                txt.Location = new Point(10, 10);
                btn.Location = new Point(150, 10);
            }
            else
            {
                ServicePlacingControls.CalculateNewPlaceForControls(btn,txt,textBoxes,buttons,panel1);
            }

            MixerMakerButtonsTextBoxes(txt, btn);
            AddOnClicksEvents(btn);
            OnTextChanged(txt);

        }
        private void OnTextChanged(TextBox txt)
        {
            txt.TextChanged += OnTextChangedMethod;
        }
        private void AddOnClicksEvents(Button btn)
        {
            btn.Click += OnClick;
        }

        public void OnClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            TextBox txt = textBoxes[buttons.IndexOf(btn)];
            if (btn.Text == "Add")
            {
                txt.Visible = false;
                if (textBoxes.Count != labels.Count)
                {
                    Label label = new Label();
                    panel1.Controls.Add(label);
                    label.Location = textBoxes[buttons.IndexOf(btn)].Location;
                    label.Text = txt.Text;
                    labels.Add(label);
                }
                else
                {
                   
                    Label lbl = labels[buttons.IndexOf(btn)];
                    lbl.Text = txt.Text;
                    lbl.Visible = true;
                }
                btn.Text = "Change";
            }
            else
            {
                txt.Visible = true;
                labels[buttons.IndexOf(btn)].Visible = false;
                btn.Text = "Add";
            }
        }
        private void MixerMakerButtonsTextBoxes(TextBox txt, Button btn)
        {
            ButtonFactory.BtnMaker(btn);
            TextBoxFactory.TxtMaker(txt);
            panel1.Controls.Add(txt);
            panel1.Controls.Add(btn);
            AddNewControlsToLists(btn,txt);
        }

        private void AddNewControlsToLists(Button btn, TextBox txt)
        {
            textBoxes.Add(txt);
            buttons.Add(btn);
        }

        private void OnTextChangedMethod(object sender, EventArgs e)
        {
            TextBox txt = (sender as TextBox);
            if (txt.Text == "Remove")
            {
                panel1.Controls.Remove(txt);
                panel1.Controls.Remove(buttons[textBoxes.IndexOf(txt)]);
                buttons[textBoxes.IndexOf(txt)] = null;
                txt = null;
                GC.Collect();
                panel1.Refresh();
            }
        }
    }
}
