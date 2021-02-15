using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WordPadAM
{
    public class clsOperazioni
    {
        public clsOperazioni() { }

        public void caricaFont(ToolStripComboBox cmb)
        {
            foreach (FontFamily f in FontFamily.Families)
            {
                cmb.Items.Add(f.Name);
            }
            cmb.SelectedIndex = 0;
        }

        public void caricaSize(ToolStripComboBox cmb)
        {
            for (int i = 8; i < 41; i++)
            {
                cmb.Items.Add(i.ToString());
            }
            cmb.SelectedIndex = 3;
        }
    }
}
