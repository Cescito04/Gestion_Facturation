using System;
namespace GestionFacturation
{
	public class EnregistrementPaiement
	{
		private string idEnregistrement { get; set; }
		private Facture facture { get; set; }
		private decimal montantPaye { get; set; }
		private DateTime datePaiement { get; set; }

		public string IdEnrgistrement
		{
			get
			{
				return idEnregistrement;
			}
			set
			{
				idEnregistrement = value;
			}
		}

		public Facture Facture
		{
			get
			{
				return facture;
			}
			set
			{
				facture = value;
			}
		}

		public decimal Montantpaye
		{
			get
			{
				return montantPaye;
			}
			set
			{
				montantPaye = value;
			}
		}

		public DateTime DatePaiement
		{
			get
			{
				return datePaiement;
			}
			set
			{
				datePaiement = value;
			}
		}


		public EnregistrementPaiement()
		{
		}
	}
}

