
using System;
using System.Collections.Generic;

namespace TP_C_
{
	/// <summary>
	/// Description of Program.
	/// </summary>
	class Program
    {
		
		
        static void Main(string[] args)
        {
            int choix,numref,quantite;
            float prix;
            string nom;
            do
            {	   bdd bd= new bdd();
            	
            	
            	Console.Out.WriteLine("********************************************************************************************************************") ;
                Console.Out.WriteLine("*********************************************          MENU           **********************************************");
                Console.Out.WriteLine("********************************************************************************************************************\n\n\n");


                Console.Out.WriteLine("1-Rechercher un article par numéro");
                Console.Out.WriteLine("2-Ajouter un article");
                Console.Out.WriteLine("3-Supprimer un article par numéro");
                Console.Out.WriteLine("4-Modifier un article par numéro");
                Console.Out.WriteLine("5-Rechercher un article par nom");
                Console.Out.WriteLine("6-Rechercher un article par intervalle de prix de vente");
                Console.Out.WriteLine("7-Afficher tous les articles");
                Console.Out.WriteLine("8-Quitter \n\n\n");


                Console.Out.Write("Donner votre choix: \t");
                choix = int.Parse(Console.In.ReadLine());
                switch (choix){


                    case 1:
                   		 Console.ReadKey(true);
                   		 Console.Clear();
                        Console.Out.WriteLine("Donner le numéro de l'article à rechercher: \t ");
                        numref = int.Parse(Console.In.ReadLine());
                        bd.Rechercher(numref);
                        Console.ReadKey(true);
                        Console.Clear();
                        break;
 
                    case 2:
                    	Console.ReadKey(true);
                    	Console.Clear();
                        Console.Out.Write("Donner le numéro de l'article à ajouter: \t");
                        numref = int.Parse(Console.In.ReadLine());
                            Console.Out.Write("Donner le nom : \t");
                            nom = Console.In.ReadLine();
                            Console.Out.Write("Donner le prix: \t\t");
                            prix = float.Parse(Console.In.ReadLine());
                            Console.Out.Write("Donner la quantité: \t");
                            quantite = int.Parse(Console.In.ReadLine());
                            bd.AjouterArticle(new Article(numref, nom, prix, quantite));                           
                            Console.ReadKey(true);
                            Console.Clear();
                        break;
 
                    case 3:
                   		 Console.ReadKey(true);
                         Console.Clear();
                        Console.Out.Write("Donner le numéro de l'article à supprimer: \t");
                        numref = int.Parse(Console.In.ReadLine());
                        bd.SuprimerArticle(numref);
                        Console.ReadKey(true);
                        Console.Clear();
                        break;
 
                    case 4:
                  	  Console.ReadKey(true);
                        Console.Clear();
                        Console.Out.Write("Entrer le numéro de l'article à modifier: \t");
                        numref = int.Parse(Console.In.ReadLine());
                         //Proposer un sous menu pour choisir l'attribut à modifier
                            int c;
                            do
                            {
                            	Console.Clear();
                                Console.Out.WriteLine("********   OPTIONS   ********");
                                Console.Out.WriteLine("1-Modifier le nom");
                                Console.Out.WriteLine("2-Modifier le prix");
                                Console.Out.WriteLine("3-Modifier la quantité");
                                Console.Out.WriteLine("4-Terminer");
                                Console.Out.Write("Donner votre choix: \t");
                                c = int.Parse(Console.In.ReadLine());
                                switch (c)
                                {
                                    case 1:
                                		Console.Clear();
                                        Console.Out.Write("Donner le nouveau nom: \t");
                                        String Nom = Console.In.ReadLine();
                                        Console.WriteLine();
                                        bd.ModifierNom(numref,Nom);
                                        Console.ReadKey(true);
                                         Console.Clear();
                                        break;
                                    case 2:
                                         Console.Clear();
                                        Console.Out.Write("Donner le prix: \t");
                                        Console.WriteLine();
                                        double Prix = double.Parse(Console.In.ReadLine());
                                        Console.WriteLine();
                                        bd.ModifierPrix(numref,Prix);
                                        Console.ReadKey(true);
                                        break;
                                    case 3:
                                        Console.Clear();
                                        Console.Out.Write("Donner la quantité: \t");
                                        Console.WriteLine();
                                        int Quantite = int.Parse(Console.In.ReadLine());
                                        Console.WriteLine();
                                        bd.ModifierQuantite(numref,Quantite);
                                        Console.ReadKey(true);
                                        Console.Clear();
                                        break;
                                    case 4:
                                        Console.WriteLine();
                                        Console.Out.WriteLine("Modifications terminées");
                                        Console.ReadKey(true);
                                        Console.Clear();
                                        break;
                                    default:
                                        Console.WriteLine();
                                        Console.Out.WriteLine("Choix invalide");
                                        Console.ReadKey(true);
                                        break;
                                }
                            }
                		
                            
                            while (c != 4);                         			 
            			
                        break;
 
                    case 5:
                    Console.ReadKey(true);
                         Console.Clear();
                        Console.Out.Write("Donner le nom de l'article à rechercher: \t");
                        nom = Console.In.ReadLine();
                        bd.RechercherNom(nom);
                        break;
                    case 6:
                    Console.ReadKey(true);
                        Console.Clear();
                        double min, max; 
                        Console.WriteLine();
                        Console.Out.Write("Donner le prix min : \t");
                        min = double.Parse(Console.In.ReadLine());
                        Console.WriteLine();
                        Console.Out.Write("Donner le prix max: \t");
                        max = double.Parse(Console.In.ReadLine());
                        if (min < 0 || max < 0 || min > max)
                        {	Console.WriteLine();
                            Console.Out.WriteLine("Intervalle invalide");
                           Console.ReadKey(true);
                        }
                        else
                        {
                        	Console.Clear();
                        	bd.RechercherInter(min,max);
                        	Console.ReadKey(true);
                        	Console.Clear();
                        }
                        break;
                    case 7:
                    Console.ReadKey(true);
                    	Console.Clear();
                    	bd.AfficherTout();
                    	Console.ReadKey(true);
                    	Console.Clear();
                        break;
                    case 8:
                    Console.ReadKey(true);
                         Console.Clear();
                        Console.Out.WriteLine("Fin du programme");
                        Console.ReadKey(true);
                        break;
                    default:
                        Console.Clear();
                        Console.Out.WriteLine("Choix invalide");
                        Console.ReadKey(true);
                        break;
 
                }
            } while (choix != 8);
            Console.ReadKey(true);
            
        } 
		
		
    }
}
