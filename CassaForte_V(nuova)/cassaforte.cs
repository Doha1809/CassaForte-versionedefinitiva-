using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassaForte_V_nuova_
{
    internal class Cassaforte
    {
        private string num_matricola;
        public string Num_matricola
        {
            get { return num_matricola; }
        }
        private string prodottore;
        public string Prodottore
        {
            get { return prodottore; }

        }
        private string modello;
        public string Modello
        {
            get { return modello; }
        }
        private string codice_sblocco;

        private bool stato = false;
        public bool Stato
        {
            get { return stato; }

        }
        private string data;

        public Cassaforte(string num_matricola, string prodottore, string modello, string codice_sblocco)
        {
            this.num_matricola = num_matricola;
            this.prodottore = prodottore;
            this.modello = modello;
            this.codice_sblocco = codice_sblocco;
        }
        private string codice_5;
        private string pin_5;

        public void Imposta_codice(string codice)
        {
            if ( codice.Length == 5)
            {
                this.codice_5 = codice;
            }
            else
            {
                if (codice == "" || codice.Length < 5)
                {
                    MessageBox.Show("Devi inserire un PIN valido");
                    return;

                }
            }
        }
        private int giusto;
        public int Giusto
        {
            get { return giusto; }
        }
        int tentativi = 5;
        int digitare;
        public void Apri(string codice, string data)
        {
            if (stato == false)
            {
                if (codice == codice_5&&this.data==data)
                {
                    MessageBox.Show("Cassa Aperta");
                    stato = true;

                }
                else
                    if ((codice != codice_5 || this.data != data )&& tentativi > 0)
                {
                    tentativi -= 1;
                    MessageBox.Show($"codice o data non corrispondente a quello effettivo. Ti rimangono altri{tentativi} ");
                    giusto = 1;
                }
                if (tentativi == 0)
                {
                    MessageBox.Show("Sono finiti i 5 tentativi che avevi a disposizione.\n Non puoi apprire la cassaforte se non inserisci correettamente il codice di sblocco");
                    giusto = 2;
                }
            }
            else
                MessageBox.Show("La cassa è gia aperta");
        }
        public void Chiudi()
        {
            if (stato == true)
            {
                stato = false;
                MessageBox.Show("Cassa chiusa");
            }
            else
            {
                MessageBox.Show("La cassa è gia chiusa");
            }
           
        }
        
        public void Sblocca(string codice_12)
        {
            if (codice_12 != codice_sblocco)
            {
             MessageBox.Show("codice non corretto");
                giusto = 7;
            }
            else
                stato = true;
        }
        int mese;
        int giorno;
        public void Imposta_data(string data)
        {
            this.data = data;
            if (data == ""||data.Length!=10)
            {
                giusto = 4;
                return;
            }
            mese = (Convert.ToInt32(data[3]) - 48) * 10 + (Convert.ToInt32(data[4]) - 48) ;
            giorno= (Convert.ToInt32(data[0]) - 48) * 10+ Convert.ToInt32(data[1]) - 48;

            if (mese==1)
            {
                if (giorno>31)
                {
                    MessageBox.Show("la data che hai impostato non è validaxxxx");
                    giusto = 3;
                }
                else 
                    if(giorno>0)
                {
                    MessageBox.Show("la data che hai impostato è valida");
                    giusto = 5;
                }
            }
            if (mese== 2)
            {
                if (giorno> 29)
                {
                    MessageBox.Show("la data che hai impostato non è validaxxxx");
                    giusto = 3;
                }
                else
                    if (giorno > 0)
                {
                    MessageBox.Show("la data che hai impostato è valida");
                    giusto = 5;
                }
            }
            if (mese== 3)
            {
                if (giorno> 31)
                {
                    MessageBox.Show("la data che hai impostato non è validaxxxx");
                    giusto = 3;
                }
                else
                    if (giorno > 0)
                {
                    MessageBox.Show("la data che hai impostato è valida");
                    giusto = 5;
                }
            }
            if (mese== 4)
            {
                if (giorno> 30)
                {
                    MessageBox.Show("la data che hai impostato non è validaxxxx");
                    giusto = 3;
                }
                else
                    if (giorno > 0)
                {
                    MessageBox.Show("la data che hai impostato è valida");
                    giusto = 5;
                }
            }
            if (mese == 5)
            {
                if (giorno > 31)
                {
                    MessageBox.Show("la data che hai impostato non è validaxxxx");
                    giusto = 3;
                }
                else
                    if (giorno > 0)
                {
                    MessageBox.Show("la data che hai impostato è valida");
                       giusto = 5;
                }
            }
            if (mese == 6)
            {
                if (giorno> 30)
                {
                    MessageBox.Show("la data che hai impostato non è validaxxxx");
                    giusto = 3;
                }
                else
                    if (giorno > 0)
                {
                    MessageBox.Show("la data che hai impostato è valida");
                        giusto = 5;
                }
            }
            if (mese == 7)
            {
                if (giorno > 31)
                {
                    MessageBox.Show("la data che hai impostato non è validaxxxx");
                    giusto = 3;
                }
                else
                    if (giorno > 0)
                {
                    MessageBox.Show("la data che hai impostato è valida");
                    giusto = 5;
                }
            }
            if (mese == 8)
            {
                if (giorno > 31)
                {
                    MessageBox.Show("la data che hai impostato non è validaxxxx");
                    giusto = 3;
                }
                else
                    if (giorno> 0)
                {
                    MessageBox.Show("la data che hai impostato è valida");
                        giusto = 5;
                }
            }
            if (mese == 9)
            {
                if (giorno > 30)
                {
                    MessageBox.Show("la data che hai impostato non è validaxxxx");
                    giusto = 3;
                }
                else
                    if (giorno > 0)
                {
                    MessageBox.Show("la data che hai impostato è valida");
                    giusto = 5;
                }
            }
            if (mese == 10)
            {
                if (giorno> 31)
                {
                    MessageBox.Show("la data che hai impostato non è validaxxxx");
                    giusto = 3;
                }
                else
                    if (giorno> 0)
                {
                    MessageBox.Show("la data che hai impostato è valida");
                    giusto = 5;
                }
            }
            if (mese== 11)
            {
                if (giorno > 30)
                {
                    MessageBox.Show("la data che hai impostato non è validaxxxx");
                    giusto = 3;
                }
                else
                    if (giorno > 0)
                {
                    MessageBox.Show("la data che hai impostato è valida");
                    giusto = 5;

                }
            }
            if (mese == 12)
            {
                if (giorno> 31)
                {
                    MessageBox.Show("la data che hai impostato non è validaxxxx");
                    giusto = 3;
                }
                else
                    if (giorno > 0)
                {
                    MessageBox.Show("la data che hai impostato è valida");
                        giusto = 5;
                }
            }
           if(mese > 12)
                {
                    MessageBox.Show("La data che hai inserito non è valida");
                    giusto = 3;
                }
        }

    }
}
