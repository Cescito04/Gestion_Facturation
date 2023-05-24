using System;
namespace GestionFacturation
{
	public class Facture
	{
		private string idFacture { get; set; }
		private Client client { get; set; }
		private List<ElementDeFacture> elementDeFactures { get; set; }
		private decimal montantTotal { get; set; }
		private DateTime dateFacture { get; set; }

		public string IdFacture
		{
			get
			{
				return idFacture;
			}
			set
			{
				idFacture = value;
			}

		}

		public Client Client
		{
			get
			{
				return client;
			}
			set
			{
				client = value;
			}
		}

		public List<ElementDeFacture> ElementDeFactures
		{
			get
			{
				return elementDeFactures;
			}
			set
			{
				elementDeFactures = value;
			}
		}

		public decimal MontantTotal
		{
			get
			{
				return montantTotal;
			}
			set
			{
				montantTotal = value;
			}
		}

		public DateTime DateFacture
		{
			get
			{
				return dateFacture;
			}
			set
			{
				dateFacture = value;
			}
		}



		public Facture()
		{
		}
	}
}

