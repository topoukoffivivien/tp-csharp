
using System;

namespace TP_C_
{
	/// <summary>
	/// Description of Article.
	/// </summary>
	public class Article
	{
		
		private int numref;
        private string nom;
        private double prix;
        private int quantite;
 
        public int Numero
        {
            get { return numref; }
            set { numref = value; }
        }
       
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        
        public double Prix
        {
            get { return prix; }
            set { prix = value; }
        }
        
        public int Quantite
        {
            get { return quantite; }
            set { quantite = value; }
        }
 
 
        public Article() { }
        
        public Article(int n, string no, double p, int q)
        {
            numref = n;
            nom = no;
            prix = p;
            quantite = q;
        }
		
		public override string ToString(){
			
			return string.Format("Article n°{0}, Nom : {1}, Prix : {2}, Quantite : {3} ", numref, nom,prix,quantite);
			
			
		}
		
	
}
	
}