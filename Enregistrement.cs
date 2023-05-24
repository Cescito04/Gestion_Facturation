using System;
using static GestionFacturation.GenerationFacture;
namespace GestionFacturation
{
	public class Enregistrement
	{
		public void Menu()
		{
			List<ElementDeFacture>elementDeFactures = new List<ElementDeFacture>();

			Facture facture = new Facture();

			

			Client client = new Client();
			Console.WriteLine("ID Client: ");
			client.IdClient = Console.ReadLine();

			Console.WriteLine("Nom Client: ");
			client.Nom = Console.ReadLine();

			Console.WriteLine("Adresse: ");
			client.Adresse = Console.ReadLine();

			Console.WriteLine("Email: ");
			client.Email = Console.ReadLine();

			Console.WriteLine("Condition Paiement: ");
			client.ConditionPaiement = Console.ReadLine();

			facture.Client = client;

            int arret = 0;
            do
            {
                Console.WriteLine("Voulez vous enregistrer un element : ");
                Console.WriteLine("Taper 1 pour enregistrer, 0 pour quitter : ");

                try
                {
                    arret = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Saisie incorrecte! Veuillez saisir (0) ou (1)!");
                }
            } while (arret != 0 && arret != 1);

            while (arret == 1)
            {
				Console.WriteLine("Id de l'element :");
				string Id = Console.ReadLine();

				Console.WriteLine("Produit: ");
				string produit = Console.ReadLine();

				Console.WriteLine("Quantité :");
				int quantite = Convert.ToInt32(Console.ReadLine());

				Console.WriteLine("Prix unitaire : ");
				decimal prix = decimal.Parse(Console.ReadLine());

				ElementDeFacture element = new ElementDeFacture();
				element.IdElement = Id;
				element.Produit = produit;
				element.Quantite = quantite;
				element.Prix = prix;

				elementDeFactures.Add(element);

                Console.WriteLine("Enregistrer un nouveau element :1  QUITTER : 0");
                arret = Convert.ToInt32(Console.ReadLine());

            }

            facture.ElementDeFactures = elementDeFactures;


            Console.WriteLine("Que souhaitez-vous faire ?");
            Console.WriteLine("1. Générer la facture");
            Console.WriteLine("2. Calculer le montant total");
            Console.WriteLine("Faites un Choix : ");

            int choix = Convert.ToInt32(Console.ReadLine());


			do
			{
				switch (choix)
				{
					case 1:
						GenerationFacture.genererFacture();
						break;

					case 2:
						Console.WriteLine("Le montant total est :");
						CalculMontantTotal.CalculerMontant();
						break;

					default:
						Console.WriteLine("Choix invalide! Veuillez ressayez :");
						break;

				}
			} while (choix != 2);


        }


		

		public Enregistrement()
		{
		}
	}
}

