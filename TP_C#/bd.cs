
using System;
using MySql.Data.MySqlClient;


namespace TP_C_


{
    /// <summary>
    /// Description of bdd.
    /// </summary>
    public class bdd
	{ 
		
        private MySqlConnection connection;

        // Constructeur
        public bdd()
        {
            this.InitConnexion();
        }

        // Méthode pour initialiser la connexion
        private void InitConnexion()
        {
            // Création de la chaîne de connexion
            const string connectionString = "SERVER=127.0.0.1; DATABASE=article; PORT=3306; UID=root; PASSWORD=";
            this.connection = new MySqlConnection(connectionString);
        }
        
        // Procedure pour Ouvrir la connexion
        
        public void OpenConnexion()
        {
        	try{
        		this.connection.Open();
        		
        	}
        	catch(MySqlException e)
        	{
        		Console.WriteLine("Erreur {0}",e.Number);
        		Console.WriteLine(e.Message);
        		
        	}
        	
        }
        
         // Procedure pour Femer la connexion
        
        public void CloseConnexion()
        {
        	try{
        		this.connection.Close();
        		
        	}
        	catch(MySqlException e)
        	{
        		Console.WriteLine("Erreur {0}",e.Number);
        		Console.WriteLine(e.Message);
        		
        	}
        	
        }
        
        

        // Procedure pour ajouter un Article
        public void AjouterArticle(Article a)
        {
        	try
        	{
        		
	        //Rquete a executer
	           String req ="INSERT INTO article VALUES('"+a.Numero+"','"+a.Nom+"','"+a.Prix+"','"+a.Quantite+"')";
	           
	          this.OpenConnexion();
             //   instruction pour prendre en compte la requete
	          MySqlCommand cmd = new MySqlCommand(req,connection);
	          
	         // instruction pour Executer de la requete
	          cmd.ExecuteNonQuery();
	          Console.Clear();
	          Console.WriteLine("Insertion reussi");
        	}
        	catch(MySqlException e)
        	{
        		Console.WriteLine("Insertion Impossible");
        		Console.WriteLine("Erreur "+e.Number+" "+e.Message);
        	}
          	finally
          	{
          		this.CloseConnexion();
          	}
        }
        
        //Modifier Article {modification du nom du prix ou de la quantite
        
        public void ModifierNom(int numero,String nom)
        {
        	try
        	{
        		
	        //Rquete a executer
	        String req ="UPDATE  article SET nom='"+nom+"' WHERE numero='"+numero+"'";
	           
	          this.OpenConnexion();
	          MySqlCommand cmd = new MySqlCommand(req,connection);
	          
	         //Execution de la requete
	          cmd.ExecuteNonQuery();
	          Console.Clear();
	          Console.WriteLine("Modification reussi");
        	}
        	catch(MySqlException e)
        	{
        		Console.WriteLine("Modification Impossible");
        		Console.WriteLine("Erreur "+e.Number+" "+e.Message);
        	}
          	finally
          	{
          		this.CloseConnexion();
          	}
        }
        
        public void ModifierPrix(int numero,double prix)
        {
        		try
        	{
        		
	        //Rquete a executer
	        String req ="UPDATE  article SET prix='"+prix+"' WHERE numero='"+numero+"'";
	           
	          this.OpenConnexion();
	          MySqlCommand cmd = new MySqlCommand(req,connection);
	          
	         //Execution de la requete
	          cmd.ExecuteNonQuery();
	          Console.Clear();
	          Console.WriteLine("Modification reussi");
        	}
        	catch(MySqlException e)
        	{
        		Console.WriteLine("Modification Impossible");
        		Console.WriteLine("Erreur "+e.Number+" "+e.Message);
        	}
          	finally
          	{
          		this.CloseConnexion();
          	}
        	
        }
        
        public void ModifierQuantite(int numero,int quantite)
        {
        	try
        	{
        		
	        //Rquete a executer
	        String req = "UPDATE  article SET quantite='" + quantite+"' WHERE numero='"+numero+"'";
	           
	          this.OpenConnexion();
	          MySqlCommand cmd = new MySqlCommand(req,connection);
	          
	         //Execution de la requete
	          cmd.ExecuteNonQuery();
	          Console.Clear();
	          Console.WriteLine("Modification reussi");
        	}
        	catch(MySqlException e)
        	{
        		Console.WriteLine("Modification Impossible");
        		Console.WriteLine("Erreur "+e.Number+" "+e.Message);
        	}
          	finally
          	{
          		this.CloseConnexion();
          	}
        }
        
        //Supression
        
        public void SuprimerArticle(int numero)
        {
        	
        		try
        	{
        		
	        //Rquete a executer
	        string req= "delete from article where numero='" + numero+"'";
	           
	          this.OpenConnexion();
	          MySqlCommand cmd = new MySqlCommand(req,connection);
	          
	         //Execution de la requete
	          cmd.ExecuteNonQuery();
	          Console.Clear();
	          Console.WriteLine("Suppression reusssi reussi");
        	}
        	catch(MySqlException e)
        	{
        		Console.WriteLine("Suppression Impossible");
        		Console.WriteLine("Erreur "+e.Number+" "+e.Message);
        	}
          	finally
          	{
          		this.CloseConnexion();
          	}
        }
        
		// Afficher Tous les Article
		
		public  void AfficherTout()
		{		
			try
        	{
        		
	        //Rquete a executer
	           String req ="SELECT * FROM article";
	           
	          this.OpenConnexion();
	          MySqlCommand cmd = new MySqlCommand(req,connection);
	          
	        MySqlDataReader reader = cmd.ExecuteReader();
					if (reader.HasRows)
					{
						
while (reader.Read())
                    {
	Console.WriteLine(String.Format("Article n°{0}, Nom : {1}, Prix : {2}, Quantite : {3} ",reader.GetValue(0),reader.GetValue(1),reader.GetValue(2),reader.GetValue(3)));
					}
					}
        	}
        	catch (MySqlException e)
        	{
        		Console.WriteLine("Erreur "+e.Number+" "+e.Message);
        	}
          	finally
          	{
          		this.CloseConnexion();
          	}
		}
		
		// Rechercher 
		
		public  void RechercherNom(String nom)
		{
				
			try
        	{
        		
	        //Rquete a executer
	           String req ="SELECT * FROM article where nom='"+nom+"'";
	           
	          this.OpenConnexion();
	          MySqlCommand cmd = new MySqlCommand(req,connection);
	          
	        MySqlDataReader reader = cmd.ExecuteReader();
					if (reader.HasRows)
					{
						
		while (reader.Read())
                    {
					 Console.WriteLine(String.Format("Article n°{0}, Nom : {1}, Prix : {2}, Quantite : {3} ",reader.GetValue(0),reader.GetValue(1),reader.GetValue(2),reader.GetValue(3)));  
					}
					}
        	}
        	catch (MySqlException e)
        	{
        		Console.WriteLine("Erreur "+e.Number+" "+e.Message);
        	}
          	finally
          	{
          		this.CloseConnexion();
          	}
			
		}
		
		//Recher par intervalle
		
		public void RechercherInter(double min,double max)
		{
				
			try
        	{
        		
	        //Rquete a executer
	           String req ="SELECT * FROM article where prix>='"+min+"' AND prix<='"+max+"'";
	           
	          this.OpenConnexion();
	          MySqlCommand cmd = new MySqlCommand(req,connection);
	          
	        MySqlDataReader reader = cmd.ExecuteReader();
					if (reader.HasRows)
					{
						
while (reader.Read())
                    {
					 Console.WriteLine(String.Format("Article n°{0}, Nom : {1}, Prix : {2}, Quantite : {3} ",reader.GetValue(0),reader.GetValue(1),reader.GetValue(2),reader.GetValue(3)));  
					}
					}
        	}
        	catch (MySqlException e)
        	{
        		Console.WriteLine("Erreur "+e.Number+" "+e.Message);
        	}
          	finally
          	{
          		this.CloseConnexion();
          	}
		}
		public  void Rechercher(int num)
		{
				
			try
        	{
        		
	        //Rquete a executer
	           String req = "SELECT * FROM article where numero='" + num+"'";
	           
	          this.OpenConnexion();
	          MySqlCommand cmd = new MySqlCommand(req,connection);
	          
	        MySqlDataReader reader = cmd.ExecuteReader();
					if (reader.HasRows)
					{
						
while (reader.Read())
                    {
					   Console.WriteLine(String.Format("Article n°{0}, Nom : {1}, Prix : {2}, Quantite : {3} ",reader.GetValue(0),reader.GetValue(1),reader.GetValue(2),reader.GetValue(3)));
					}
					}
        	}
        	catch (MySqlException e)
        	{
        		Console.WriteLine("Erreur "+e.Number+" "+e.Message);
        	}
          	finally
          	{
          		this.CloseConnexion();
          	}
			
		}
				
        
    }
}
