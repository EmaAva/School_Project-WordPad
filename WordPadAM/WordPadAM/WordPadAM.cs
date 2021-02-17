using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WordPadAM
{
    public partial class WordPadAM : Form
    {
        public WordPadAM()
        {
            InitializeComponent();
        }
        clsOperazioni wordPad = new clsOperazioni();


        private void WordPadAM_Load(object sender, EventArgs e)
        {
            wordPad.caricaFont(cmbFont);
            wordPad.caricaSize(cmbSize);
        }

        private void btnFontUp_Click(object sender, EventArgs e)
        {
            try
            {
                cmbSize.SelectedIndex = cmbSize.SelectedIndex + 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cmbSize.SelectedIndex = 1;
            }
        }

        private void btnFontDown_Click(object sender, EventArgs e)
        {
            try
            {
                cmbSize.SelectedIndex = cmbSize.SelectedIndex - 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cmbSize.SelectedIndex = 0;
            }
        }

        private void btnBold_Click(object sender, EventArgs e)
        {
            FontStyle stileFont;
            Font currentFont = rtxDocumento.SelectionFont;
            if (rtxDocumento.SelectionFont.Bold == true)
            {
                stileFont = FontStyle.Regular;
            }
            else
            {
                stileFont = FontStyle.Bold;
            }
            rtxDocumento.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, stileFont);
        }

        private void btnItalic_Click(object sender, EventArgs e)
        {
            FontStyle stileFont;
            Font currentFont = rtxDocumento.SelectionFont;
            if (rtxDocumento.SelectionFont.Italic == true)
            {
                stileFont = FontStyle.Regular;
            }
            else
            {
                stileFont = FontStyle.Italic;
            }
            rtxDocumento.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, stileFont);
        }

        private void btnUnderline_Click(object sender, EventArgs e)
        {
            FontStyle stileFont;
            Font currentFont = rtxDocumento.SelectionFont;
            if (rtxDocumento.SelectionFont.Underline == true)
            {
                stileFont = FontStyle.Regular;
            }
            else
            {
                stileFont = FontStyle.Underline;
            }
            rtxDocumento.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, stileFont);
        }

        private void btnFontColor_Click(object sender, EventArgs e)
        {
            ColorDialog myColor = new ColorDialog();
            myColor.Color = rtxDocumento.ForeColor;
            if (myColor.ShowDialog() == DialogResult.OK)
            {
                rtxDocumento.SelectionColor = myColor.Color;
            }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            rtxDocumento.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void btnCenter_Click(object sender, EventArgs e)
        {
            rtxDocumento.SelectionAlignment = HorizontalAlignment.Center;

        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            rtxDocumento.SelectionAlignment = HorizontalAlignment.Right;

        }

        private void btnBulletList_Click(object sender, EventArgs e)
        {
            if (rtxDocumento.SelectionBullet == true)
            {
                rtxDocumento.SelectionBullet = false;
            }
            else
            {
                rtxDocumento.SelectionBullet = true;
            }
        }

        private void cmbSize_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                rtxDocumento.SelectionFont = new Font(cmbFont.Text, Convert.ToInt32(cmbSize.Text));
            }
            catch (Exception)
            {
            }
        }
        private void cmbFont_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                rtxDocumento.SelectionFont = new Font(cmbFont.Text, Convert.ToInt32(cmbSize.Text));
            }
            catch (Exception)
            {
            }

        }

        private void BtnJustify_Click(object sender, EventArgs e)
        {
            Font f = rtxDocumento.Font;
            rtxDocumento.Text = wordPad.JustifyParagraph(rtxDocumento.Text, rtxDocumento.Font, rtxDocumento.Width);
            rtxDocumento.Font = new Font(f.Name, f.Size, f.Style);
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgImage = new OpenFileDialog();
            dlgImage.FileName = "*.jpg,*.jpeg,*.png,*.bmp";
            dlgImage.Filter = "Immagine(*.jpg)|*.jpg|(*.jpeg)|*.jpeg|(*.png)|*.png|(*.bmp)|*.bmp|Tutti i files|*.*";
            DialogResult ris = dlgImage.ShowDialog();
            if (ris == DialogResult.OK && dlgImage.FileName != "")
            {
                string picFile = dlgImage.FileName;
                Bitmap pic = new Bitmap(picFile);
                Clipboard.SetDataObject(pic);
                DataFormats.Format fmt = DataFormats.GetFormat(DataFormats.Bitmap);
                if (rtxDocumento.CanPaste(fmt))
                {
                    rtxDocumento.Paste(fmt);
                }
                else
                {
                    MessageBox.Show("Warning, an error has occurred");
                }
            }
            else
            {
                MessageBox.Show("Warning, an error has occurred");
            }
        }

        private void BtnSaveDoc_Click(object sender, EventArgs e)
        {
            SaveFileDialog file = new SaveFileDialog();
        }

        private void BtnOpenDoc_Click(object sender, EventArgs e)
        {
            OpenFileDialog txt = new OpenFileDialog();
            txt.FileName = "*.rtf";
            txt.Filter = "Testo(*.rtf)|*.rtf|Tutti i files|*.*";
            DialogResult ris = txt.ShowDialog();
            if (ris == DialogResult.OK && txt.FileName != "")
            {
                string txtFile = txt.FileName;
                rtxDocumento.Rtf = File.ReadAllText(txtFile);
            }
            else
            {
                MessageBox.Show("Warning, an error has occurred");
            }
        }

        private void BtnNewDoc_Click(object sender, EventArgs e)
        {
            rtxDocumento.Text = "";
        }
    }
}
