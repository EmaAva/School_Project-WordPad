using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Font f = rtxDocumento.Font;
            try
            {
                rtxDocumento.SelectionFont = new Font(f.FontFamily, Convert.ToInt32(cmbSize.Text), f.Style);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void cmbFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            Font f = rtxDocumento.Font;
            rtxDocumento.SelectionFont = new Font(cmbFont.Text, f.Size, f.Style);
        }

        private void BtnJustify_Click(object sender, EventArgs e)
        {
            Font f = rtxDocumento.Font;
            rtxDocumento.Text = wordPad.JustifyParagraph(rtxDocumento.Text, rtxDocumento.Font, rtxDocumento.Width);
            rtxDocumento.Font = new Font(f.Name, f.Size, f.Style);
        }
    }
}
