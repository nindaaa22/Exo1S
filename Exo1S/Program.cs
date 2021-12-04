using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo1S
{
	class Program
	{
		//delcaraton globale
		static char reponse;

		/**
		 * Saisie d'un prix
		 */

		static void saisie()
		{
			do
			{
				Console.WriteLine();
				Console.WriteLine("avez vous un prix à saisir? O/N =  ");
				reponse = Console.ReadKey().KeyChar;
			}
			while (reponse != 'O' && reponse != 'N');
		}

		static void Main(string[] args)
		{
			//declaration de valeur 
			int prix, somme=0;


			//saisie d'une réponse


			saisie();

			while (reponse == 'O')
			{
					Console.WriteLine("     Saisir un prix=");
					prix = int.Parse(Console.ReadLine());

				//cumul des prix 
				somme = somme + prix;
				saisie();
			}
			//affichage du total 
			Console.WriteLine("le total est" + somme);
			Console.ReadLine();
			










			

			
			{
				

				
			
			}

			


		
		}
	}
}
