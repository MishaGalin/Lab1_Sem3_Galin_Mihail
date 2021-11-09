using System;
using System.Windows.Forms;

namespace Lab1_Sem3_Galin_Mihail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void createTaskButton_Click(object sender, EventArgs e)
        {
            if (firstNameBox.Text.Length == 0 || lastNameBox.Text.Length == 0 || patronymicBox.Text.Length == 0 || !classBox.Items.Contains(classBox.Text))
            {
                MessageBox.Show("Введите все данные корректно");
                return;
            }
            TaskForm form2 = new TaskForm(firstNameBox.Text + " " + lastNameBox.Text + " " + patronymicBox.Text, classBox.Text, numOfTasks.Value);
            form2.Show();
        }
    }
}