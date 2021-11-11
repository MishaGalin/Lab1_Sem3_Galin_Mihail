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

        private void CreateTaskButton_Click(object sender, EventArgs e)
        {
            if (firstNameBox.Text.Length == 0 || lastNameBox.Text.Length == 0 || patronymicBox.Text.Length == 0 || !classBox.Items.Contains(classBox.Text))
            {
                MessageBox.Show("Введите все данные корректно.");
                return;
            }
            if (!easyRadioButton.Checked && !hardRadioButton.Checked)
            {
                MessageBox.Show("Выберите сложность.");
                return;
            }
            string info = firstNameBox.Text + " " + lastNameBox.Text + " " + patronymicBox.Text;
            TaskForm form2 = new TaskForm(info, classBox.Text, numOfTasks.Value, easyRadioButton.Checked, hardRadioButton.Checked);
            form2.Show();
        }
    }
}