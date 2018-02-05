using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock
{
	/*
Dans la classe Program créer :

Le stock sous forme d'une collection d’articles de votre choix.

Un menu présentant les fonctionnalités suivantes :

1.  Rechercher un article par référence.
2.  Ajouter un article au stock en vérifiant l’unicité de la référence.
3.  Supprimer un article par référence.
4.  Modifier un article par référence.
5.  Rechercher un article par nom.
6.  Rechercher un article par intervalle de prix de vente.
7.  Afficher tous les articles.
8.  Quitter
	 */
	class Program
	{
		
		/// <summary>
		/// permet de rechercher un article via sa référence
		/// </summary>
		/// <param name="articles"></param>
		/// <param name="reference"></param>
		/// <returns></returns>
		static int Search(List<Article> articles, int reference){
			// A compléter
			return 0;
		}

		/// <summary>
		/// Allow to add an article in the stock if not exist yet
		/// </summary>
		/// <param name="articles"></param>
		/// <param name="article"></param>
		/// <returns></returns>
		static bool AddArticle(List<Article> articles, Article article) {
			// A compléter 
			return true;
		}

		/// <summary>
		/// Allow to delete an article in the stock knowing it reference
		/// </summary>
		/// <param name="articles"></param>
		/// <param name="reference"></param>
		/// <returns></returns>
		static bool deleteArticle(List<Article> articles, int reference) {
			// A compléter
			return true;
		}

		/// <summary>
		/// Allow to modify an article knowing its reference
		/// </summary>
		/// <param name="articles"></param>
		/// <param name="reference"></param>
		/// <returns></returns>
		static bool ModifyArticle(List<Article> articles, int reference) {
			// A compléter....
			return true;
		}

		/// <summary>
		/// Allow to find an article by name
		/// </summary>
		/// <param name="articles"></param>
		/// <param name="name"></param>
		/// <returns></returns>
		static int Search(List<Article> articles, string name) {
			// A compléter....
			return 0;
		}

		/// <summary>
		/// Allow to to find an article with prize between min and max
		/// </summary>
		/// <param name="articles"></param>
		/// <param name="min"></param>
		/// <param name="max"></param>
		/// <returns></returns>
		static Article[] Search(List<Article> articles, int min, int max) {
			// A compléter....
			return null;
		}

		/// <summary>
		/// Allow to display all the articles in stock 
		/// </summary>
		/// <param name="articles"></param>
		static void Disaplay(List<Article> articles) { 
			// A compléter....
		}

		/**/
		
		// déclarer les autres propriétés
		static void Main(string[] args)
		{
			int choix, num, quantite, p;
			double prix;
			string nom;
			List<Article> Stock = new List<Article>();
			System.Console.Out.WriteLine("Compléter le code et effacer cette instruction...");
			System.Console.In.ReadLine();
			// A compléter....
		}
	}
}
