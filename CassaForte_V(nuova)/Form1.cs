using System.Drawing.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CassaForte_V_nuova_
{
    public partial class data : Form
    {
        string pin;
        string pin_utente;
        int conta = 0;
        int digitare = 5;
        Cassaforte cassa;
        string date;
        string date_inserito;
        string pin_inserito;



        public data()
        {
            InitializeComponent();
            cassa = new Cassaforte("123", "produttore", "modello", "123456789012");
            sblocca.Visible = false;
            button2.Visible = false;
            apri.Visible = false;
            inseriredata.Visible = false;
            inserirepin.Visible = false;
            chiudi.Visible = false;
            confermadata.Visible=false;
            confermapin.Visible=false;
            button1.Visible = false;
            button2.Visible=false;
            
        }

        private void uno_Click(object sender, EventArgs e)
        {
            if (conta < digitare)
            {
                conta += 1;
                pin += "1";
                cassaforte.Text = pin;
            }

            else
            {
                MessageBox.Show($"Hai già premuto {digitare} cifre");
            }
            if (digitare == 8 && (conta == 2 || conta == 4))
            {
                pin += "/";

            }
        }

        private void due_Click(object sender, EventArgs e)
        {
            if (conta < digitare)
            {
                pin += "2";
                conta += 1;
                cassaforte.Text = pin;
            }
            else
            {
                MessageBox.Show($"Hai già premuto {digitare} cifre");
            }
            if (digitare == 8 && (conta == 2 || conta == 4))
            {
                pin += "/";

            }
        }

        private void tre_Click(object sender, EventArgs e)
        {
            if (conta < digitare)
            {
                pin += "3";
                conta += 1;
                cassaforte.Text = pin;
            }
            else
            {
                MessageBox.Show($"Hai già premuto {digitare} cifre");
            }
            if (digitare == 8 && (conta == 2 || conta == 4))
            {
                pin += "/";

            }
        }

        private void quattro_Click(object sender, EventArgs e)
        {
            if (conta < digitare)
            {
                pin += "4";
                conta += 1;
                cassaforte.Text = pin;
            }
            else
            {
                MessageBox.Show($"Hai già premuto {digitare} cifre");
            }
            if (digitare == 8 && (conta == 2 || conta == 4))
            {
                pin += "/";

            }
        }

        private void cinque_Click(object sender, EventArgs e)
        {
            if (conta < digitare)
            {
                pin += "5";
                conta += 1;
                cassaforte.Text = pin;
            }
            else
            {
                MessageBox.Show($"Hai già premuto {digitare} cifre");
            }
            if (digitare == 8 && (conta == 2 || conta == 4))
            {
                pin += "/";

            }
        }

        private void sei_Click(object sender, EventArgs e)
        {
            if (conta < digitare)
            {
                pin += "6";
                conta += 1;
                cassaforte.Text = pin;
            }
            else
            {
                MessageBox.Show($"Hai già premuto {digitare} cifre");
            }
            if (digitare == 8 && (conta == 2 || conta == 4))
            {
                pin += "/";

            }
        }

        private void sette_Click(object sender, EventArgs e)
        {
            if (conta < digitare)
            {
                pin += "7";
                conta += 1;
                cassaforte.Text = pin;
            }
            else
            {
                MessageBox.Show($"Hai già premuto {digitare} cifre");
            }
            if (digitare == 8 && (conta == 2 || conta == 4))
            {
                pin += "/";

            }
        }

        private void otto_Click(object sender, EventArgs e)
        {
            if (conta < digitare)
            {
                pin += "8";
                conta += 1;
                cassaforte.Text = pin;
            }
            else
            {
                MessageBox.Show($"Hai già premuto {digitare} cifre");
            }
            if (digitare == 8 && (conta == 2 || conta == 4))
            {
                pin += "/";

            }
        }

        private void nove_Click(object sender, EventArgs e)
        {
            if (conta < digitare)
            {
                pin += "9";
                conta += 1;
                cassaforte.Text = pin;
            }
            else
            {
                MessageBox.Show($"Hai già premuto {digitare} cifre");
            }
            if (digitare == 8 && (conta == 2 || conta == 4))
            {
                pin += "/";

            }
        }

        private void zero_Click(object sender, EventArgs e)
        {
            if (conta < digitare)
            {
                pin += "0";
                conta += 1;
                cassaforte.Text = pin;
            }

            else
            {
                MessageBox.Show($"Hai già premuto {digitare} cifre");
            }
            if (digitare == 8 && (conta == 2 || conta == 4))
            {
                pin += "/";

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Devi impostare un PIN per la tua cassaforte");
        }

        private void imposta_Click(object sender, EventArgs e)
        {
            cassa.Imposta_codice(pin);
            if (pin.Length==5)
            {
                    MessageBox.Show($"Il  PIN impostato è {pin}");

                    imposta.Visible = false;
                    button1.Visible = true;
            }

            
            cassaforte.Text = "";
            pin = "";
            conta = 0;


        }

        private void apri_Click(object sender, EventArgs e)
        {
            cassa.Apri(pin_inserito, date_inserito);
            if (cassa.Giusto == 1)
            {
                pin = "";
                conta = 0;
                apri.Visible = false;
                inserirepin.Visible = true;
                inseriredata.Visible = true;
            }
            if (cassa.Giusto == 2)
            {
                apri.Visible = false;
                sblocca.Visible = true;
                digitare = 12;
                pin = "";
                conta = 0;
            }
            if (cassa.Stato == true)
                chiudi.Visible = true;
            cassaforte.Text = "";
        }

        private void sblocca_Click(object sender, EventArgs e)
        {
            cassa.Sblocca(pin);
            if (cassa.Giusto == 7)
            {
                pin = "";
                conta = 0;
            }
            else
                MessageBox.Show("Codice corretto\n la cassa è Aperta");
            if (cassa.Stato == true)
                chiudi.Visible = true;
            cassaforte.Text = "";

        }

        private void chiudi_Click(object sender, EventArgs e)
        {
           
            cassa.Chiudi();
            apri.Visible= false;
            inserirepin.Visible = true;
            inseriredata.Visible = true;
            chiudi.Visible= false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            conta = 0;
            pin = "";
            digitare = 8;
            button2.Visible = true;
            button1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cassa.Imposta_data(pin);
            date = pin;

            if (cassa.Giusto ==5)
            {
                inserirepin.Visible = true;
                button2.Visible = false;
                inseriredata.Visible = false;
            }
            if (cassa.Giusto == 4)
                MessageBox.Show("Devi inserire una  data valida ");
            if(cassa.Giusto==3)
            {
                button1.Visible=true;
            }
            cassaforte.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pin = "";
            conta = 0;
            digitare = 5;
            confermapin.Visible = true;
            inserirepin.Visible=false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            pin = "";
            digitare = 8;
            conta = 0;
            confermadata.Visible=true;
            inseriredata.Visible=false;
        }

        private void confermapin_Click(object sender, EventArgs e)
        {
            if (pin != "")
            {
                pin_inserito = pin;
                inseriredata.Visible=true;
                confermapin.Visible = false;

            }
            else
            {
                MessageBox.Show("non hai inserito nessun PIN");
                inserirepin.Visible = true;
            }

            cassaforte.Text = "";
        }

        private void confermadata_Click(object sender, EventArgs e)
        {
            if (pin != "")
            {
                date_inserito = pin;
                apri.Visible = true;
                confermadata.Visible= false;
            }
            else
            {
                MessageBox.Show("Devi inserire una data!!!");
                inseriredata.Visible = true;
            }
            cassaforte.Text = "";
        }
    }
}
