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
    public partial class FichMenu : Form
    {
        private List<CheckBox> checkBoxes = new();

        public FichMenu(Point location)
        {
            InitializeComponent();
            Location = location;
            checkBoxes.Add(checkBox1);
            checkBoxes.Add(checkBox2);
            checkBoxes.Add(checkBox3);
            checkBoxes.Add(checkBox4);            
            for (int i = 0; i < checkBoxes.Count; i++)
            {
                checkBoxes[i].CheckedChanged -= CheckBoxesChanget;
                checkBoxes[i].Checked = ResultForm.ChecboxesState[i];
                checkBoxes[i].CheckedChanged += CheckBoxesChanget;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuPath choisePath = new MenuPath(Location);
            choisePath.Show();
            FormClosing -= ChoiseModules_FormClosing;
            Close();
        }

        private void CheckBoxesChanget(object? sender, EventArgs e) 
        {
            for (int i = 0; i < checkBoxes.Count; i++)
            {
                ResultForm.ChecboxesState[i] = checkBoxes[i].Checked;
            }
        }

        private void ChoiseModules_FormClosing(object? sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите завершить установку?", "Завершение", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else if (result == DialogResult.Yes)
            {
                FormClosing -= ChoiseModules_FormClosing;
                Application.Exit();
            }
        }
    }
}
