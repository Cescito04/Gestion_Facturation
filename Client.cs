using System;
namespace GestionFacturation
{
    public class Client
    {
        private string idClient { get; set; }
        private string nom { get; set; }
        private string adresse { get; set; }
        private string email { get; set; }
        private string conditionPaiement { get; set; }
        private List<Facture> historiqueAchat { get; set; }

        public string IdClient
        {
            get
            {
                return idClient;
            }
            set
            {
                idClient = value;
            }
        }

        public string Nom
        {
            get
            {
                return nom;
            }
            set
            {
                nom = value;
            }
        }

        public string Adresse
        {
            get
            {
                return adresse;
            }
            set
            {
                adresse = value;
            }

        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }

        }

        public string ConditionPaiement
        {
            get
            {
                return conditionPaiement;
            }
            set
            {
                conditionPaiement = value;
            }
        }

        public List<Facture>HistoriqueAchat
        {
            get
            {
                return historiqueAchat;
            }
            set
            {
                historiqueAchat = value;

            }
        }




        public Client()
        {
        }
    }
}

