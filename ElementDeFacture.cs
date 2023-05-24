using System;
namespace GestionFacturation
{
	public class ElementDeFacture
	{
		private string idElement { get; set; }
        private string produit { get; set; }
        private int quantite { get; set; }
		private decimal prix { get; set; }


		public string IdElement
		{
			get
			{
				return idElement;
			}
			set
			{
				idElement = value;
			}

		}

		public string Produit
		{
			get
			{
				return produit;
			}
			set
			{
				produit = value;
			}
		}

		public int Quantite
		{
			get
			{
				return quantite;
			}
			set
			{
				quantite = value;
			}
		}

		public decimal Prix
		{
			get
			{
				return prix;
			}
			set
			{
				prix = value;
			}
		}

		public decimal MontantTotalElement()
		{
			return quantite * prix;
		}





		public ElementDeFacture()
		{
		}
	}
}

