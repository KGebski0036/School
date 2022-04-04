
namespace Szkolny_Dziennik.Windows
{
    partial class AddStudentWindow
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
            this.buttonAddStudent = new System.Windows.Forms.Button();
            this.textBoxInputImie = new System.Windows.Forms.TextBox();
            this.textBoxInputNazwisko = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxInputKlasa = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownInputRok = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInputRok)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.Location = new System.Drawing.Point(352, 35);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Size = new System.Drawing.Size(124, 48);
            this.buttonAddStudent.TabIndex = 0;
            this.buttonAddStudent.Text = "Dodaj ucznia";
            this.buttonAddStudent.UseVisualStyleBackColor = true;
            this.buttonAddStudent.Click += new System.EventHandler(this.buttonAddStudent_Click);
            // 
            // textBoxInputImie
            // 
            this.textBoxInputImie.Location = new System.Drawing.Point(12, 61);
            this.textBoxInputImie.Name = "textBoxInputImie";
            this.textBoxInputImie.Size = new System.Drawing.Size(117, 23);
            this.textBoxInputImie.TabIndex = 1;
            // 
            // textBoxInputNazwisko
            // 
            this.textBoxInputNazwisko.Location = new System.Drawing.Point(12, 139);
            this.textBoxInputNazwisko.Name = "textBoxInputNazwisko";
            this.textBoxInputNazwisko.Size = new System.Drawing.Size(117, 23);
            this.textBoxInputNazwisko.TabIndex = 2;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(352, 114);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(124, 48);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Anuluj";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Imie:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nazwisko:";
            // 
            // comboBoxInputKlasa
            // 
            this.comboBoxInputKlasa.FormattingEnabled = true;
            this.comboBoxInputKlasa.Location = new System.Drawing.Point(174, 60);
            this.comboBoxInputKlasa.Name = "comboBoxInputKlasa";
            this.comboBoxInputKlasa.Size = new System.Drawing.Size(121, 23);
            this.comboBoxInputKlasa.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Klasa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(174, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Rok urodzenia";
            // 
            // numericUpDownInputRok
            // 
            this.numericUpDownInputRok.Location = new System.Drawing.Point(175, 140);
            this.numericUpDownInputRok.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericUpDownInputRok.Name = "numericUpDownInputRok";
            this.numericUpDownInputRok.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownInputRok.TabIndex = 10;
            // 
            // AddStudentWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 204);
            this.Controls.Add(this.numericUpDownInputRok);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxInputKlasa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBoxInputNazwisko);
            this.Controls.Add(this.textBoxInputImie);
            this.Controls.Add(this.buttonAddStudent);
            this.Name = "AddStudentWindow";
            this.Text = "w";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInputRok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddStudent;
        private System.Windows.Forms.TextBox textBoxInputImie;
        private System.Windows.Forms.TextBox textBoxInputNazwisko;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxInputKlasa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownInputRok;
    }
}