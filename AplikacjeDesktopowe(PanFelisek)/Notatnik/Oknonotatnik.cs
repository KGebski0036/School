using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.Reflection.Metadata;

namespace Notatnik
{
    public partial class Oknonotatnik : Form
    {
        private string sciezkaPliku = "";

        public Oknonotatnik()
        {

            InitializeComponent();

        }

        


        private void ChangeFontSize(int step)
        {
            Font font = textBoxNotatnik.Font;
            FontFamily family = font.FontFamily;
            FontStyle style = font.Style;
            float size = textBoxNotatnik.Font.Size + step;
            GraphicsUnit unit = textBoxNotatnik.Font.Unit;
            byte gdiCharSet = textBoxNotatnik.Font.GdiCharSet;

            if (size <= 0)
            {
                return;
            }
            textBoxNotatnik.Font = new Font(family, size, style, unit, gdiCharSet);
        }





        #region Zdarzenia menu Plik

        private void nowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!textBoxNotatnik.Modified || ZapiszPlikPytanie() != DialogResult.Cancel)
            {
                CzyscNotatnik();
                return;
            }
        }

        private void zapiszJakoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZapiszPlikJako();
        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZapiszPlikPytanie(false);
        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBoxNotatnik.Modified && ZapiszPlikPytanie() == DialogResult.Cancel)
            {
                return;
            }
            Close();
        }

        private void otworzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBoxNotatnik.Modified && ZapiszPlikPytanie() == DialogResult.Cancel)
                return;

            OtworzPlik();
        }


        #endregion

        #region Zdarzenia menu Edycja

        private void cofnijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxNotatnik.Undo();
        }

        private void wytnijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxNotatnik.Cut();
        }

        private void kopjujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxNotatnik.Copy();
        }

        private void wklejToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxNotatnik.Paste();
        }
        private void powiększpomnijszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZmienRozmiarCzcionki(5);
        }
        private void powiększToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZmienRozmiarCzcionki(5);
        }

        private void pomniejszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZmienRozmiarCzcionki(-5);
        }
        private void usuńToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxNotatnik.SelectedText = "";
        }

        private void zaznaczWszystkoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxNotatnik.SelectAll();
        }

        private void dataIGodzinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxNotatnik.Paste(DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss"));
        }

        #endregion

        #region Metody zapisu/odczytu pliku

        private void UstawPasekGornyOkna()
        {
            Text = "Notatnik";
            if (sciezkaPliku != "")
                Text += " - " + Path.GetFileName(sciezkaPliku);
        }

        private DialogResult ZapiszPlik()
        {
            File.WriteAllText(sciezkaPliku, textBoxNotatnik.Text);
            textBoxNotatnik.Modified = false;
            UstawPasekGornyOkna();

            return DialogResult.Yes;
        }

        private DialogResult ZapiszPlikJako()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Pliki tekstowe (*.txt)|*.txt|Wszystkie pliki|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                sciezkaPliku = saveFileDialog.FileName;
                ZapiszPlik();
                return DialogResult.Yes;
            }
            return DialogResult.No;
        }

        private DialogResult ZapiszPlikPytanie(bool czyPokazacPytanie = true)
        {
            DialogResult jakZamknietoOkno = DialogResult.Yes;
            if (czyPokazacPytanie)
                jakZamknietoOkno = MessageBox.Show("Plik nie zapisany.\nCzy zapisać?", "Uwaga!!!", MessageBoxButtons.YesNoCancel);

            if (jakZamknietoOkno == DialogResult.Yes)
            {
                if (sciezkaPliku != "")
                    return ZapiszPlik();

                return ZapiszPlikJako();
            }
            return jakZamknietoOkno;
        }

        private void OtworzPlik()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Pliki tekstowe (*.txt)|*.txt|Wszystkie pliki|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                sciezkaPliku = openFileDialog.FileName;
                textBoxNotatnik.Text = File.ReadAllText(sciezkaPliku);
                textBoxNotatnik.Modified = false;
                UstawPasekGornyOkna();
            }
        }

        private void CzyscNotatnik()
        {
            textBoxNotatnik.Text = "";
            textBoxNotatnik.Modified = false;
            sciezkaPliku = "";
            UstawPasekGornyOkna();
        }


        #endregion

        #region Metody menu widok

        private void ZmienRozmiarCzcionki(int krok)
        {
            FontFamily fontFamily = textBoxNotatnik.Font.FontFamily;
            float size = textBoxNotatnik.Font.Size + krok;
            FontStyle fontStyle = textBoxNotatnik.Font.Style;
            GraphicsUnit graphicsUnit = textBoxNotatnik.Font.Unit;
            byte gdiCharSet = textBoxNotatnik.Font.GdiCharSet;

            if (size <= 0)
                return;
            Font font = new Font(fontFamily, size, fontStyle, graphicsUnit, gdiCharSet);
            textBoxNotatnik.Font = font;
        }

        #endregion

       
    }
}
