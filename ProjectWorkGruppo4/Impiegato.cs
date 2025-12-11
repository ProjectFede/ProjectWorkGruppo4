using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWorkGruppo4
{
    internal class Impiegato
    {
        int idImpiegato;
        string nome;
        string cognome;
        DateTime dataAssunzione;
        string email;
        string mansione;
        int numeroAumenti;
        string nominativoManager;
        string nomeDipartimento;
        string indirizzoDipartimento;

        public Impiegato(int idImpiegato, string nome, string cognome, DateTime dataAssunzione, string email, string mansione, int numeroAumenti, string nominativoManager, string nomeDipartimento, string indirizzoDipartimento)
        {
            this.idImpiegato = idImpiegato;
            this.nome = nome;
            this.cognome = cognome;
            this.dataAssunzione = dataAssunzione;
            this.email = email;
            this.mansione = mansione;
            this.numeroAumenti = numeroAumenti;
            this.nominativoManager = nominativoManager;
            this.nomeDipartimento = nomeDipartimento;
            this.indirizzoDipartimento = indirizzoDipartimento;
        }

        public int getIdImpiegato()
        {
            return idImpiegato;
        }
        public void setIdImpiegato(int idImpiegato)
        {
            this.idImpiegato = idImpiegato;
        }
        public string getNome()
        {
            return nome;
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public string getCognome()
        {
            return cognome;
        }
        public void setCognome(string cognome)
        {
            this.cognome = cognome;
        }
        public DateTime getDataAssunzione()
        {
            return dataAssunzione;
        }
        public void setDataAssunzione(DateTime dataAssunzione)
        {
            this.dataAssunzione = dataAssunzione;
        }
        public string getEmail()
        {
            return email;
        }
        public void setEmail(string email)
        {
            this.email = email;
        }
        public string getMansione()
        {
            return mansione;
        }
        public void setMansione(string mansione)
        {
            this.mansione = mansione;
        }
        public int getNumeroAumenti()
        {
            return numeroAumenti;
        }
        public void setNumeroAumenti(int numeroAumenti)
        {
            this.numeroAumenti = numeroAumenti;
        }
        public string getNominativoManager()
        {
            return nominativoManager;
        }
        public void setNominativoManager(string nominativoManager)
        {
            this.nominativoManager = nominativoManager;
        }
        public string getNomeDipartimento()
        {
            return nomeDipartimento;
        }
        public void setNomeDipartimento(string nomeDipartimento)
        {
            this.nomeDipartimento = nomeDipartimento;
        }
        public string getIndirizzoDipartimento()
        {
            return indirizzoDipartimento;
        }
        public void setIndirizzoDipartimento(string indirizzoDipartimento)
        {
            this.indirizzoDipartimento = indirizzoDipartimento;
        }

        public override string ToString()
        {
            string infoImpiegato = $"ID Impiegato: {idImpiegato}\n" +
                                  $"Nome: {nome}\n" +
                                  $"Cognome: {cognome}\n" +
                                  $"Data di Assunzione: {dataAssunzione.ToShortDateString()}\n" +
                                  $"Email: {email}\n" +
                                  $"Mansione: {mansione}\n" +
                                  $"Numero di Aumenti: {numeroAumenti}\n" +
                                  $"Nominativo Manager: {nominativoManager}\n" +
                                  $"Nome Dipartimento: {nomeDipartimento}\n" +
                                  $"Indirizzo Dipartimento: {indirizzoDipartimento}\n";
            return infoImpiegato;
        }
    }
}
