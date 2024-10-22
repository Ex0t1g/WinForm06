using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm06
{
    public partial class MenuOpt : Form
    {
        private List<CheckBox> checkBoxes = new();
        public MenuOpt(Point location)
        {
            InitializeComponent();
            Location = location;
            checkBoxes.Add(checkBox1);
            checkBoxes.Add(checkBox2);
            checkBoxes.Add(checkBox3);
            for (int i = 0; i < checkBoxes.Count; i++)
            {
                checkBoxes[i].CheckedChanged -= CheckBoxesChanget;
                checkBoxes[i].Checked = ResultForm.ChecboxesState[ResultForm.ChecboxesState.Count - checkBoxes.Count + i];
                checkBoxes[i].CheckedChanged += CheckBoxesChanget;
            }
        }

        private void ChoiseOptions_FormClosing(object? sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите завершить установку?", "Завершение", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else if (result == DialogResult.Yes)
            {
                FormClosing -= ChoiseOptions_FormClosing;
                Application.Exit();
            }
        }

        private void CheckBoxesChanget(object? sender, EventArgs e)
        {
            for (int i = 0; i < checkBoxes.Count; i++)
            {
                ResultForm.ChecboxesState[ResultForm.ChecboxesState.Count - checkBoxes.Count + i] = checkBoxes[i].Checked;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormClosing -= ChoiseOptions_FormClosing;
            MenuPath choisePath = new(Location);
            choisePath.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormClosing -= ChoiseOptions_FormClosing;
            ResultForm resultForm = new(Location);
            resultForm.Show();
            Close();
        }
    }
}
