using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace Sintetizzatore_vocale
{
    public partial class frmainForm : Form
    {
        SpeechSynthesizer sintetizzatore;
        public frmainForm()
        {
            InitializeComponent();
            sintetizzatore = new SpeechSynthesizer();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btleggiTesto_Click(object sender, EventArgs e)
        {
            sintetizzatore.SpeakAsync(tbmessaggioUtente.Text);
        }

        private void frmainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            sintetizzatore.SpeakAsyncCancelAll();
            sintetizzatore.Dispose();
        }
    }
}
