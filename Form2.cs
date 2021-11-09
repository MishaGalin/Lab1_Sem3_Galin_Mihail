using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab1_Sem3_Galin_Mihail
{
    public partial class TaskForm : Form
    {
        public TaskForm(string p1, string p2, decimal p3)
        {
            InitializeComponent();
            nameAndClass.Text = "Ученик: " + p1 + "\n" + "Класс: " + p2;
            int n = Convert.ToInt32(p3);
            for (int i = 1; i <= n; i++)
            {
                TextBox t = new TextBox
                {
                    Text = "Задание " + i.ToString(),
                    Size = new Size(100, 25),
                    Location = new Point(12, 25 + i * 30)
                };

                CheckBox c = new CheckBox
                {
                    Location = new Point(125, 25 + i * 30)
                };

                this.Controls.Add(t);
                this.Controls.Add(c);
            }
        }
    }
}