using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uciekaj
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
            this.Shown += button_MouseEnter;
        }

        private void button_MouseEnter(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                Random random = new Random();
                Button newButton = new System.Windows.Forms.Button();
                this.Controls.Add(newButton);
                
                button.Location = new Point(random.Next(0, Size.Width - button1.Width), random.Next(0, Size.Height - button1.Height));
                newButton.Cursor = System.Windows.Forms.Cursors.No;
                newButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
                newButton.Location = new System.Drawing.Point(100,50);
                newButton.Name = $"button{random.Next(0,70)}";
                newButton.Size = new System.Drawing.Size(150, 80);
                newButton.TabIndex = 0;
                newButton.Text = "Nie Naciskaj";
                newButton.UseVisualStyleBackColor = true;
                newButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);


            }
            
        }
    }
}
