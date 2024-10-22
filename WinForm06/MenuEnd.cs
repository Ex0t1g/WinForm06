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
    public partial class MenuEnd : Form
    {
        public MenuEnd(Point location)
        {
            InitializeComponent();
            Location = location;
        }

        private void button1_Click(object? sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                DialogResult result = MessageBox.Show("Вы уверены, что хотите завершить установку?", "Завершение", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    FormClosing -= FinalForm_FormClosing;
                    Close();
                    Application.Exit();
                }
            }
            else
            {
                FormClosing -= FinalForm_FormClosing;
                Close();
                Application.Exit();
            }
        }

        private void FinalForm_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                DialogResult result = MessageBox.Show("Вы уверены, что хотите завершить установку?", "Завершение", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else if (result == DialogResult.Yes)
                {
                    FormClosing -= FinalForm_FormClosing;
                    Close();
                    Application.Exit();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value >= progressBar1.Maximum)
            {
                label1.Text = "Готово";
                return; 
            }
            progressBar1.Value += 1;
        }
    }
}
