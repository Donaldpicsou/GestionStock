using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock {
		/*
	
	Un article est caractérisé par son numéro de référence, son nom, son prix de vente et une quantité en stock
	Le stock est représenté par une collection d’articles.
	  Travail à faire:
		Créer la classe article contenant les éléments ci-dessous :
	 */
	class Article {
		/*
		 * Déclaration des attributs,deux ont déjà été déclarés
		 * Déclarer les deux autres
		 */
		// numéro de référence
		private int reference;
		// nom
		private string nom;
		// prix (ajouter l'attribut)...

		// qte_stock (ajouter la quantité en stock)

		/*
		 * Déclaration des propriétés
		 * Une propriété a déjà été déclarée, déclarée les propriétés des autres attributs
		 */


		public int Reference {
			get { return reference; }
			set { reference = value; }
		}

		public string ToString(){
			// compléter la méthode suisvante
			return ""; 
		}

		/// <summary>
		/// Constructeur par défaut
		/// Vous pouvez le compléter si possible
		/// </summary>
		public Article() {
			// Compléter au besoin
		}

		/// <summary>
		/// Constructeur d'initialisation
		/// </summary>
		/// <param name="reference"></param>
		/// <param name="?"></param>
		/// <param name="?"></param>
		/// <param name="?"></param>
		public Article(int reference, string nom, float prix, int qte_stock){
			//compléter ici...
			// Vous pouvez au besoin changer le nom des variables et les types 
		}
		
	}
}
