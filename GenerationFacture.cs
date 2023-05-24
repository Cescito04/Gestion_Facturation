using System;
namespace GestionFacturation
{
	public class GenerationFacture
	{
		public static void genererFacture()
		{
			int arret = 0;

            do
            {
                Console.WriteLine("Voulez vous enregistrer une facture : ");
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

            while(arret == 1)
            {
                Facture facture = new Facture();
                Console.WriteLine("Création d'une facture");

                Console.WriteLine("Numéro de facture : ");
                facture.IdFacture = Console.ReadLine();

                Console.WriteLine("Date de la facture :");
                facture.DateFacture = DateTime.Now;


                Console.WriteLine("Enregistrer un nouvelle facture :1  QUITTER : 0");
                arret = Convert.ToInt32(Console.ReadLine());
            }



           
        }


		public GenerationFacture()
		{
		}
	}
}

