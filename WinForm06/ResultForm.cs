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
    public partial class ResultForm : Form
    {
        public static List<bool> ChecboxesState { get => checboxesState; set => checboxesState = value; }
        private List<CheckBox> checkBoxes = new();
        static List<bool> checboxesState = new List<bool>() { false, false, false, false, true, true, true };
        public static string InstaletFolder { get; set; } = @"C:\";

        public ResultForm(Point location)
        {
            InitializeComponent();
            Location = location;
            checkBoxes.Add(checkBox1);
            checkBoxes.Add(checkBox2);
            checkBoxes.Add(checkBox3);
            checkBoxes.Add(checkBox4);
            checkBoxes.Add(checkBox5);
            checkBoxes.Add(checkBox6);
            checkBoxes.Add(checkBox7);
            for (int i = 0; i < checboxesState.Count; i++)
            {
                checkBoxes[i].Checked = checboxesState[i];
            }
            label1.Text = $"Путь установки: {InstaletFolder}";
        }

        private void ResultForm_FormClosing(object? sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите завершить установку?", "Завершение", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else if (result == DialogResult.Yes)
            {
                FormClosing -= ResultForm_FormClosing;
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormClosing -= ResultForm_FormClosing;
            MenuOpt choiseOptions = new(Location);
            choiseOptions.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuEnd finalForm = new MenuEnd(Location);
            finalForm.Show();
            FormClosing -= ResultForm_FormClosing;
            Close();
        }
    }
}
