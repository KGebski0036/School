namespace Quizy
{
    partial class Quiz
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlQuiz = new System.Windows.Forms.TabControl();
            this.tabPageListaPytan = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ucListaPytan1 = new Quizy.Zakładki.UCListaPytan();
            this.tabControlQuiz.SuspendLayout();
            this.tabPageListaPytan.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlQuiz
            // 
            this.tabControlQuiz.Controls.Add(this.tabPageListaPytan);
            this.tabControlQuiz.Controls.Add(this.tabPage2);
            this.tabControlQuiz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlQuiz.Location = new System.Drawing.Point(0, 0);
            this.tabControlQuiz.Name = "tabControlQuiz";
            this.tabControlQuiz.SelectedIndex = 0;
            this.tabControlQuiz.Size = new System.Drawing.Size(771, 482);
            this.tabControlQuiz.TabIndex = 0;
            // 
            // tabPageListaPytan
            // 
            this.tabPageListaPytan.Controls.Add(this.ucListaPytan1);
            this.tabPageListaPytan.Location = new System.Drawing.Point(4, 24);
            this.tabPageListaPytan.Name = "tabPageListaPytan";
            this.tabPageListaPytan.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageListaPytan.Size = new System.Drawing.Size(763, 454);
            this.tabPageListaPytan.TabIndex = 0;
            this.tabPageListaPytan.Text = "Lista pytań";
            this.tabPageListaPytan.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(763, 454);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ucListaPytan1
            // 
            this.ucListaPytan1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucListaPytan1.Location = new System.Drawing.Point(3, 3);
            this.ucListaPytan1.Name = "ucListaPytan1";
            this.ucListaPytan1.Size = new System.Drawing.Size(757, 448);
            this.ucListaPytan1.TabIndex = 0;
            // 
            // Quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 482);
            this.Controls.Add(this.tabControlQuiz);
            this.Name = "Quiz";
            this.Text = "Quizowe ";
            this.tabControlQuiz.ResumeLayout(false);
            this.tabPageListaPytan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControlQuiz;
        private TabPage tabPageListaPytan;
        private TabPage tabPage2;
        private Zakładki.UCListaPytan ucListaPytan1;
    }
}