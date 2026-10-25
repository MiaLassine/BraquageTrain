//Programme : Braquage de train
//Creator : Mia Lassine 107B
//Date : 25/10/2026

namespace Braquage_train;

class Program
{
    static void Main(string[] args)
    {
        /*
         * Consignes :
           - Utiliser une première boucle pour parcourir les quatre wagons.
           - Utiliser une deuxième boucle à l'intérieur pour parcourir les trois coffres de chaque wagon.
           - Afficher chaque coffre inspecté avec son numéro de wagon.
           - Compter le nombre total de coffres inspectés.
           
           Exemple :
               Inspection des 4 wagons du train
               Wagon 1 - Coffre 1 inspecté
               Wagon 1 - Coffre 2 inspecté
               Wagon 1 - Coffre 3 inspecté
               Wagon 2 - Coffre 1 inspecté
               ...
               Total : 12 coffres inspectés.
            
            BONUS 1 : permettre à l'utilisateur de choisir le nombre de wagons
            BONUS 2 : enregistrer l'ensemble du butin trouvé et l'afficher à la fin
         */

        Console.WriteLine("Entrez le nombre de wagon :");
        Console.WriteLine("------------------------------------------------------------------");
        string? stringWagonNumber = Console.ReadLine();
        int intWagonNumber = Convert.ToInt32(stringWagonNumber);


        int wagonCounter = 0;
        int chestCounter = 0;
        int totalChestCounter = 0;
        int randomChestNumber = 0;

        Random randomNumber = new Random(); //Création d'une variable instanciée pour générer un nombre de coffre aléatoire à chaque boucle

        while (intWagonNumber > 0)
        {
            wagonCounter++;
            intWagonNumber--;
            randomChestNumber = randomNumber.Next(1, 5);
            Console.WriteLine("------------------------------------------------------------------");
            while (randomChestNumber > 0)
        {
            chestCounter++;
            totalChestCounter++;
            randomChestNumber--;
            Console.WriteLine("Wagon " + wagonCounter + " - Coffre " + chestCounter + " inspecté." );

        }
            chestCounter = 0;
    }
        Console.WriteLine("------------------------------------------------------------------");
        Console.WriteLine("Nombre de coffres inspectés : " + totalChestCounter);
        Console.WriteLine("------------------------------------------------------------------");

    }
}