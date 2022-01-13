namespace Quizy.Zakładki
{
    partial class UCListaPytan
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonUsun = new System.Windows.Forms.Button();
            this.buttonEdytuj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxListaPytan = new System.Windows.Forms.ComboBox();
            this.ucWyswietlPytanie1 = new Quizy.Okna_pomocnicze.UCWyswietlPytanie();
            this.SuspendLayout();
            // 
            // buttonUsun
            // 
            this.buttonUsun.Location = new System.Drawing.Point(555, 15);
            this.buttonUsun.Name = "buttonUsun";
            this.buttonUsun.Size = new System.Drawing.Size(156, 51);
            this.buttonUsun.TabIndex = 0;
            this.buttonUsun.Text = "Usuń Pytanie";
            this.buttonUsun.UseVisualStyleBackColor = true;
            this.buttonUsun.Click += new System.EventHandler(this.buttonUsun_Click);
            // 
            // buttonEdytuj
            // 
            this.buttonEdytuj.Location = new System.Drawing.Point(555, 72);
            this.buttonEdytuj.Name = "buttonEdytuj";
            this.buttonEdytuj.Size = new System.Drawing.Size(154, 50);
            this.buttonEdytuj.TabIndex = 1;
            this.buttonEdytuj.Text = "Edytuj Pytanie";
            this.buttonEdytuj.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lista pytań:";
            // 
            // comboBoxListaPytan
            // 
            this.comboBoxListaPytan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxListaPytan.FormattingEnabled = true;
            this.comboBoxListaPytan.Location = new System.Drawing.Point(17, 38);
            this.comboBoxListaPytan.Name = "comboBoxListaPytan";
            this.comboBoxListaPytan.Size = new System.Drawing.Size(126, 23);
            this.comboBoxListaPytan.TabIndex = 5;
            this.comboBoxListaPytan.SelectedIndexChanged += new System.EventHandler(this.comboBoxListaPytan_SelectedIndexChanged);
            // 
            // ucWyswietlPytanie1
            // 
            this.ucWyswietlPytanie1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucWyswietlPytanie1.Location = new System.Drawing.Point(0, 155);
            this.ucWyswietlPytanie1.Name = "ucWyswietlPytanie1";
            this.ucWyswietlPytanie1.Size = new System.Drawing.Size(747, 325);
            this.ucWyswietlPytanie1.TabIndex = 6;
            // 
            // UCListaPytan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucWyswietlPytanie1);
            this.Controls.Add(this.comboBoxListaPytan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEdytuj);
            this.Controls.Add(this.buttonUsun);
            this.Name = "UCListaPytan";
            this.Size = new System.Drawing.Size(747, 480);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonUsun;
        private Button buttonEdytuj;
        private Label label1;
        private ComboBox comboBoxListaPytan;
        private Okna_pomocnicze.UCWyswietlPytanie ucWyswietlPytanie1;
    }
}
