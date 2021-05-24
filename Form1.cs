using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Beschreibung:
// Regelmäßig (gemäß Timereinstellungen) soll eine bestimmte Aktion ausgeführt werden.
// Die Aktion ist unter "privat void Testeintrag" definiert.

namespace Timer_Test
{
    public partial class Form1 : Form
    {
        private Timer zeitgeber1;
        private string text1;

        public Form1()
        {
            InitializeComponent();

            zeitgeber1 = new Timer();                                    // Timer erzeugen
            zeitgeber1.Tick += new EventHandler(Testeintrag);            // nach jedem Tick die Methode Testeintrag aufrufen
            zeitgeber1.Interval = 2000;                                  // Interval für Tick
        }

        private void button1_Click(object sender, EventArgs e)
        {
            zeitgeber1.Start();                                         // Timer (zeitgeber1) starten
        }

        private void Testeintrag(Object sender, EventArgs e)
        {
            text1 = Convert.ToString(DateTime.Now);                     // Erzeugen des Textes für den Eintrag in die Listbox
            listBox1.Items.Add(text1);                                  // Text zur Listbox hinzufügen
        }

        private void button2_Click(object sender, EventArgs e)
        {
            zeitgeber1.Stop();                                          // Timer (zeitgeber1) beenden
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
