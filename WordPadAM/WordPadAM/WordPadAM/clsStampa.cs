using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

/*
  Elenco dei metodi pubblici:
 * -public void impostaPagina()
 * -public void Stampa(string testo, Font carattere)
 * -public void anteprima(string testo, Font carattere)
 * 
 
 */
namespace Es05EditorHTML
{
    public class clsStampa
    {
        // oggetto principale per la gestione della classe
        private PrintDocument prn = new PrintDocument();
        // dichiaro 3 finestre che servono per la configurazione
        // dell'oggetto PrintDocument
        private PageSetupDialog dlgSetup = new PageSetupDialog();
        private PrintDialog dlgStampa = new PrintDialog();
        private PrintPreviewDialog dlgAnteprima = new PrintPreviewDialog();
        private string userText;
        private Font userFont;
        // costruttore della classe che sarà eseguito
        // al momento in cui l'utente istanzia la classe
        public clsStampa()
        {
            // parametri relativi a Imposta Pagina
            // le unità di misura sono Unit
            // 1 Unit = 1/100 di pollice = 0,254 mm
            prn.DefaultPageSettings.Margins.Left = 79;
            prn.DefaultPageSettings.Margins.Top = 100;
            prn.DefaultPageSettings.Margins.Right = 79;
            prn.DefaultPageSettings.Margins.Bottom = 100;
            prn.DefaultPageSettings.Landscape = false;

            //parametri relativi alla stampa
            prn.PrinterSettings.Copies = 1;
            
            // link delle finestre di dialogo
            // all'oggetto PrintDocument
            dlgSetup.Document = prn;
            dlgStampa.Document = prn;
            dlgAnteprima.Document = prn;
            dlgSetup.EnableMetric = true;
            prn.PrintPage+=new PrintPageEventHandler(prn_PrintPage);
        }

        public void impostaPagina()
        {
            dlgSetup.ShowDialog();
            // In corrispondenza dell'Ok i valori
            // impostati dentro dlgSetup vengono
            // automaticamente copiati dentro prn
        }

        public void Stampa(string testo, Font carattere)
        { 
            // Salviamo testo e font nei campi UserText e UserFont
            this.userText = testo;
            this.userFont = carattere;
            DialogResult ris = dlgStampa.ShowDialog();
            if (ris == DialogResult.OK)
                prn.Print();
        }

        public void anteprima(string testo, Font carattere)
        {
            // Salviamo testo e font nei campi UserText e UserFont
            this.userText = testo;
            this.userFont = carattere;
            dlgAnteprima.ShowDialog();
        }

        private void prn_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        { 
            // Questo evento viene richiamato
            // in corrispondenza di:
            // -Metodo Print
            // -OK sull'anteprima di stampa
            SolidBrush b = new SolidBrush(Color.Black);
            int x = prn.DefaultPageSettings.Margins.Left;
            int y = prn.DefaultPageSettings.Margins.Top;
            int w = prn.DefaultPageSettings.PaperSize.Width - prn.DefaultPageSettings.Margins.Left - prn.DefaultPageSettings.Margins.Right;
            int h = prn.DefaultPageSettings.PaperSize.Height - prn.DefaultPageSettings.Margins.Top - prn.DefaultPageSettings.Margins.Bottom;
            Rectangle rect = new Rectangle(x, y, w, h);
            // metodo che esegue fisicamente la stampa
            // parametri:
            // -Testo da stampare
            // -Font da utilizzare
            // -Colore
            // -Rettangolo di stampa
            e.Graphics.DrawString(userText, userFont, b, rect);

        }
    }
}
