
namespace MasaBomby
{
    partial class OknoGlowne
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxRodzajJednostek = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sqliteCommand1 = new Microsoft.Data.Sqlite.SqliteCommand();
            this.comboBoxUnitFrom = new System.Windows.Forms.ComboBox();
            this.comboBoxUnitTo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDownInput = new System.Windows.Forms.NumericUpDown();
            this.labelWynik = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInput)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rodzaj jednostek:";
            // 
            // comboBoxRodzajJednostek
            // 
            this.comboBoxRodzajJednostek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRodzajJednostek.FormattingEnabled = true;
            this.comboBoxRodzajJednostek.Location = new System.Drawing.Point(12, 27);
            this.comboBoxRodzajJednostek.Name = "comboBoxRodzajJednostek";
            this.comboBoxRodzajJednostek.Size = new System.Drawing.Size(784, 23);
            this.comboBoxRodzajJednostek.TabIndex = 2;
            this.comboBoxRodzajJednostek.SelectedIndexChanged += new System.EventHandler(this.comboBoxRodzajJednostek_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Jednostka z której konwertujemy:";
            // 
            // sqliteCommand1
            // 
            this.sqliteCommand1.CommandTimeout = 30;
            this.sqliteCommand1.Connection = null;
            this.sqliteCommand1.Transaction = null;
            this.sqliteCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // comboBoxUnitFrom
            // 
            this.comboBoxUnitFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUnitFrom.FormattingEnabled = true;
            this.comboBoxUnitFrom.Location = new System.Drawing.Point(12, 89);
            this.comboBoxUnitFrom.Name = "comboBoxUnitFrom";
            this.comboBoxUnitFrom.Size = new System.Drawing.Size(784, 23);
            this.comboBoxUnitFrom.TabIndex = 4;
            this.comboBoxUnitFrom.SelectedIndexChanged += new System.EventHandler(this.comboBoxUnitFrom_SelectedIndexChanged);
            // 
            // comboBoxUnitTo
            // 
            this.comboBoxUnitTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUnitTo.FormattingEnabled = true;
            this.comboBoxUnitTo.Location = new System.Drawing.Point(12, 158);
            this.comboBoxUnitTo.Name = "comboBoxUnitTo";
            this.comboBoxUnitTo.Size = new System.Drawing.Size(784, 23);
            this.comboBoxUnitTo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Jednostka na którą  konwertujemy:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(586, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 42);
            this.button1.TabIndex = 7;
            this.button1.Text = "Przelicz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDownInput
            // 
            this.numericUpDownInput.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.numericUpDownInput.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDownInput.Location = new System.Drawing.Point(12, 217);
            this.numericUpDownInput.Name = "numericUpDownInput";
            this.numericUpDownInput.Size = new System.Drawing.Size(568, 23);
            this.numericUpDownInput.TabIndex = 8;
            this.numericUpDownInput.ValueChanged += new System.EventHandler(this.numericUpDownInput_ValueChanged);
            // 
            // labelWynik
            // 
            this.labelWynik.AutoSize = true;
            this.labelWynik.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelWynik.Location = new System.Drawing.Point(41, 320);
            this.labelWynik.Name = "labelWynik";
            this.labelWynik.Size = new System.Drawing.Size(0, 37);
            this.labelWynik.TabIndex = 9;
            // 
            // OknoGlowne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelWynik);
            this.Controls.Add(this.numericUpDownInput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxUnitTo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxUnitFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxRodzajJednostek);
            this.Controls.Add(this.label1);
            this.Name = "OknoGlowne";
            this.Text = "Przelicznik";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxRodzajJednostek;
        private System.Windows.Forms.Label label2;
        private Microsoft.Data.Sqlite.SqliteCommand sqliteCommand1;
        private System.Windows.Forms.ComboBox comboBoxUnitFrom;
        private System.Windows.Forms.ComboBox comboBoxUnitTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDownInput;
        private System.Windows.Forms.Label labelWynik;
    }
}

