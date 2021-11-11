
namespace Lab1_Sem3_Galin_Mihail
{
    partial class TaskForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameAndClass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameAndClass
            // 
            this.nameAndClass.AutoSize = true;
            this.nameAndClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.nameAndClass.Location = new System.Drawing.Point(12, 9);
            this.nameAndClass.Name = "nameAndClass";
            this.nameAndClass.Size = new System.Drawing.Size(0, 20);
            this.nameAndClass.TabIndex = 2;
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.nameAndClass);
            this.Name = "TaskForm";
            this.Text = "Задание";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameAndClass;
    }
}