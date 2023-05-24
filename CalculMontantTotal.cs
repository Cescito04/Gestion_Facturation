using System;
namespace GestionFacturation
{
	public class CalculMontantTotal
	{
		public static decimal CalculerMontant()
		{
			Facture facture = new Facture();
			decimal total = 0;

			foreach(ElementDeFacture element in facture.ElementDeFactures)
			{
				total += element.MontantTotalElement();
			}
			facture.MontantTotal = total;
			return facture.MontantTotal;
		}

		public CalculMontantTotal()
		{
		}
	}
}

