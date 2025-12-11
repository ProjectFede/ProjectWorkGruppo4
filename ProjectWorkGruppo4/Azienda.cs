using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWorkGruppo4
{
    internal class Azienda
    {
        string nomeAzienda;

        List<Impiegato> impiegatoList;

        public Azienda(List<Impiegato> impiegatoList) { 
            this.nomeAzienda = "Azienda generica";
            this.impiegatoList = impiegatoList;
        }

        public void aggiungiImpiegato(Impiegato i) //aggiunge un impiegato alla lista
        {
            impiegatoList.Add(i);
        }

        public List<Impiegato> caricaImpiegati(string filePath) //carica da file csv gli impiegati
        {
            //string filePath = "C:\\its\\impiegati.csv";

            List<Impiegato> impiegatiList = new List<Impiegato>();
            string[] righe = File.ReadAllLines(filePath);
            foreach (string line in righe)
            {
                string[] parti = line.Split(',');
                int idImpiegato = Int32.Parse(parti[0]);
                string nome = parti[1];
                string cognome = parti[2];
                DateTime dataAssunzione = DateTime.Parse(parti[3]);
                string email = parti[4];
                string mansione = parti[5];
                int numeroAumenti = Int32.Parse(parti[6]);
                string nominativoManager = parti[7];
                string nomeDipartimento = parti[8];
                string indirizzoDipartimento = parti[9];

                Impiegato i = new Impiegato(idImpiegato, nome, cognome, dataAssunzione, email, mansione, numeroAumenti, nominativoManager, nomeDipartimento, indirizzoDipartimento);
                impiegatiList.Add(i);
            }

            return impiegatiList;
        }

        public void scriviImpiegati(string filepath) //scrive su file txt gli impiegati
        {
            //string filePath = "C:\\its\\impiegato.txt";

            File.WriteAllText(filepath, ""); //pulisce il file prima di scriverci

            foreach (Impiegato i in impiegatoList)
            {
                File.AppendAllText(filepath, i.ToString() + "\n");
            }
        }


    }
}
