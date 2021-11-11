using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab1_Sem3_Galin_Mihail
{
    public partial class TaskForm : Form
    {
        public TaskForm(string p1, string p2, decimal p3, bool easy, bool hard)
        {
            InitializeComponent();
            nameAndClass.Text = "Ученик: " + p1 + "\n" + "Класс: " + p2;
            int n = Convert.ToInt32(p3);
            if (easy)
            {
                Size = new Size(400, 100 + 30 * n);
                for (int i = 0; i < n; i++)
                {
                    Label t = new Label
                    {
                        Text = "Простое задание " + (i + 1).ToString(),
                        Location = new Point(12, 55 + i * 30)
                    };

                    CheckBox c = new CheckBox
                    {
                        Location = new Point(120, 50 + i * 30)
                    };

                    Controls.Add(t);
                    Controls.Add(c);
                }
            }
            else if (hard)
            {
                Size = new Size(500, 100 + 60 * n);
                var rand = new Random();
                for (int i = 0; i < n; i++)
                {
                    Label t = new Label
                    {
                        Text = "Сложное задание " + (i + 1).ToString(),
                        Location = new Point(12, 65 + i * 60)
                    };

                    for (int j = 0; j < 5; j++)
                    {
                        CheckBox c = new CheckBox
                        {
                            Text = rand.Next(1, 51).ToString(),
                            Size = new Size(40, 50),
                            Location = new Point(120 + j * 50, 48 + i * 60)
                        };
                        Controls.Add(c);
                    }

                    Controls.Add(t);
                }
            }
        }
    }
}