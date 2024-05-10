using System;
using SimpleCMenu.Menu;

namespace SimpleCMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            string headerText = "   ____  _  _     ____    __ _           _              _   " +
                Environment.NewLine + "  / ___|| || |_  |  _ \\  /_/| |__  _   _| |_ __ _ _ __ | |_ " +
                Environment.NewLine + " | |  |_  ..  _| | | | |/ _ \\ '_ \\| | | | __/ _` | '_ \\| __|" +
                Environment.NewLine + " | |__|_      _| | |_| |  __/ |_) | |_| | || (_| | | | | |_ " +
                Environment.NewLine + "  \\____||_||_|   |____/ \\___|_.__/ \\__,_|\\__\\__,_|_| |_|\\__|";


            Console.Clear();

            // Setup the menu
            ConsoleMenu mainMenu = new ConsoleMenu();
            ConsoleMenu subMenu1 = new ConsoleMenu("==>");
            ConsoleMenu subMenu2 = new ConsoleMenu("==>");
            ConsoleMenu subMenu3 = new ConsoleMenu("==>");
            ConsoleMenu subMenu4 = new ConsoleMenu("==>");
            ConsoleMenu subMenu5 = new ConsoleMenu("==>");
            ConsoleMenu subMenu6 = new ConsoleMenu("==>");
            ConsoleMenu subMenu7 = new ConsoleMenu("==>");
            ConsoleMenu subMenu8 = new ConsoleMenu("==>");

            mainMenu.Header = headerText;
            mainMenu.SubTitle = "-------------------- Menu Module ----------------------";
            mainMenu.addMenuItem(1, "Les Variables", subMenu1.showMenu);
            mainMenu.addMenuItem(2, "Les Types Scalaires", subMenu2.showMenu);
            mainMenu.addMenuItem(3, "Les Opérateurs", subMenu3.showMenu);
            mainMenu.addMenuItem(4, "Les Conditions", subMenu4.showMenu);
            mainMenu.addMenuItem(5, "Les Boucles", subMenu5.showMenu);
            mainMenu.addMenuItem(6, "Les Fonctions", subMenu6.showMenu);
            mainMenu.addMenuItem(7, "Les Tableaux", subMenu7.showMenu);
            mainMenu.addMenuItem(8, "Les Listes", subMenu8.showMenu);
            mainMenu.addMenuItem(9, "Exit", Exit);

            // ______________________________________________________________________________________

            subMenu1.SubTitle = "----------------- Les Variables ------------------";
            subMenu1.addMenuItem(0, "Nom & Age", Var1);
            subMenu1.addMenuItem(1, "Conversion de température", subMenu1.hideMenu);
            subMenu1.addMenuItem(2, "Calcule d'aire", subMenu1.hideMenu);
            subMenu1.addMenuItem(3, "Calcules basique", subMenu1.hideMenu);
            subMenu1.addMenuItem(4, "Retour", subMenu1.hideMenu);
            subMenu1.ParentMenu = mainMenu;
            subMenu1.Header = mainMenu.Header;

            subMenu2.SubTitle = "-------------- Les Types Scalaires ---------------";
            subMenu2.addMenuItem(0, "Wow");
            subMenu2.addMenuItem(1, "Retour", subMenu2.hideMenu);
            subMenu2.ParentMenu = mainMenu;
            subMenu2.Header = mainMenu.Header;

            subMenu3.SubTitle = "--------------- Les Operateurs ------------------";
            subMenu3.addMenuItem(0, "Retour", subMenu3.hideMenu);
            subMenu3.ParentMenu = mainMenu;
            subMenu3.Header = mainMenu.Header;

            subMenu4.SubTitle = "----------------- Les Conditions ----------------";
            subMenu4.addMenuItem(0, "Retour", subMenu4.hideMenu);
            subMenu4.ParentMenu = mainMenu;
            subMenu4.Header = mainMenu.Header;

            subMenu5.SubTitle = "------------------ Les Boucles ------------------";
            subMenu5.addMenuItem(0, "Retour", subMenu5.hideMenu);
            subMenu5.ParentMenu = mainMenu;
            subMenu5.Header = mainMenu.Header;

            subMenu6.SubTitle = "---------------- Les Fonctions -----------------";
            subMenu6.addMenuItem(0, "Retour", subMenu6.hideMenu);
            subMenu6.ParentMenu = mainMenu;
            subMenu6.Header = mainMenu.Header;

            subMenu7.SubTitle = "----------------- Les Tableaux ------------------";
            subMenu7.addMenuItem(0, "Retour", subMenu7.hideMenu);
            subMenu7.ParentMenu = mainMenu;
            subMenu7.Header = mainMenu.Header;

            subMenu8.SubTitle = "------------------ Les Listes -------------------";
            subMenu8.addMenuItem(0, "Retour", subMenu8.hideMenu);
            subMenu8.ParentMenu = mainMenu;
            subMenu8.Header = mainMenu.Header;

            // Display the menu
            mainMenu.showMenu();

        }

        public static void Exit()
        {
            Environment.Exit(0);
        }

        // ______________________________________________________________________//
        //                                                                       //
        //                         ESPACE EXERCICES                              //
        // ______________________________________________________________________//

        // Variables
        static void Var1()
        {
            Console.WriteLine("Exercice 1 lancé !");
            Console.WriteLine("");
            /*
            Écrivez un programme en C# qui demande à l'utilisateur son nom et son âge
            Puis affiche un message de salutation personnalisé avec ces informations.
            */
            // Entrez vos lignes de codes ci-dessous //
            Console.WriteLine("Bonjour, veuillez entrer votre nom :");
            string nom = Console.ReadLine();
            Console.WriteLine("Merci. Veuillez entrer votre age");
            int age = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine($"Bienvenue {nom}, Vous avez : {age} ans.");


            //Ne pas effacer !
            Console.ReadLine();
        }
        static void Var2()
        {
            Console.WriteLine("Exercice 2 lancé !");
            Console.WriteLine("");
            /*
             Écrivez un programme en C# qui convertit une température en degrés Celsius en une température équivalente en degrés Fahrenheit. 
             Demandez à l'utilisateur d'entrer une température en degrés Celsius.
             Puis affichez la température équivalente en degrés Fahrenheit.
             Formule de conversion : F = C * 9/5 + 32.
            */
            // Entrez vos lignes de codes ci-dessous //


        }
        static void Var3()
        {
            Console.WriteLine("Exercice 3 lancé !");
            Console.WriteLine("");
            /*
            Écrivez un programme en C# qui calcule l'aire d'un rectangle.
            Demandez à l'utilisateur d'entrer la longueur et la largeur du rectangle. 
            Affichez ensuite l'aire calculée.
            */
            // Entrez vos lignes de codes ci-dessous //


        }
        static void Var4()
        {
            Console.WriteLine("Exercice 4 lancé !");
            Console.WriteLine("");
            /*
            Écrivez un programme en C# qui demande à l'utilisateur de saisir deux nombres entiers, puis effectue les opérations suivantes :
            Calcule la somme des deux nombres.
            Calcule la différence du premier nombre moins le deuxième nombre.
            Calcule le produit des deux nombres.
            Calcule le quotient entier du premier nombre divisé par le deuxième nombre.
            Affichez les résultats de chaque opération.
            */
            // Entrez vos lignes de codes ci-dessous //


        }

        // ______________________________________________________________________

        // Types Scalaire
        static void TS1()
        {
            Console.WriteLine("Exercice 1 lancé !");
            Console.WriteLine("");
            /*
            Écrivez un programme en C# qui demande à l'utilisateur son nom et son âge
            Puis affiche un message de salutation personnalisé avec ces informations.
            */
            // Entrez vos lignes de codes ci-dessous //


        }
        static void TS2()
        {
            Console.WriteLine("Exercice 2 lancé !");
            Console.WriteLine("");
            /*
            Écrivez un programme en C# qui calcule l'aire d'un rectangle.
            Demandez à l'utilisateur d'entrer la longueur et la largeur du rectangle. 
            Affichez ensuite l'aire calculée.
            */
            // Entrez vos lignes de codes ci-dessous //


        }
        static void TS3()
        {
            Console.WriteLine("Exercice 3 lancé !");
            Console.WriteLine("");
            /*
             Écrivez un programme en C# qui convertit une température en degrés Celsius en une température équivalente en degrés Fahrenheit. 
             Demandez à l'utilisateur d'entrer une température en degrés Celsius.
             Puis affichez la température équivalente en degrés Fahrenheit.
             Formule de conversion : F = C * 9/5 + 32.
            */
            // Entrez vos lignes de codes ci-dessous //


        }
        static void TS4()
        {
            Console.WriteLine("Exercice 4 lancé !");
            Console.WriteLine("");
            /* 
            Écrivez un programme en C# qui demande à l'utilisateur d'entrer un nombre entier et vérifie s'il est pair ou impair. 
            Utilisez une variable de type int pour stocker le nombre et une condition if pour vérifier si le nombre est pair ou impair. 
            Affichez ensuite un message approprié à l'utilisateur.
            */
            // Entrez vos lignes de codes ci-dessous //


        }

        // ______________________________________________________________________

        // Opérateurs
        static void Opr1()
        {
            Console.WriteLine("Exercice 1 lancé !");
            Console.WriteLine("");
            /*
            Écrivez un programme en C# qui demande à l'utilisateur d'entrer deux nombres entiers.
            Affichez leur somme, leur différence, leur produit, leur quotient et leur reste de la division entière.
            */
            // Entrez vos lignes de codes ci-dessous //


        }
        static void Opr2()
        {
            Console.WriteLine("Exercice 2 lancé !");
            Console.WriteLine("");
            /*
            Écrivez un programme en C# qui demande à l'utilisateur d'entrer deux valeurs booléennes (true ou false)
            Affichez le résultat des opérations logiques ET, OU et NON sur ces valeurs.         
            */
            // Entrez vos lignes de codes ci-dessous //


        }
        static void Opr3() // Même exercice que TS4
        {
            Console.WriteLine("Exercice 3 lancé !");
            Console.WriteLine("");
            /*
            Écrivez un programme en C# qui demande à l'utilisateur d'entrer un nombre entier.
            Et détermine s'il est pair ou impair. Affichez le résultat.
            */
            // Entrez vos lignes de codes ci-dessous //


        }
        static void Opr4()
        {
            Console.WriteLine("Exercice 4 lancé !");
            Console.WriteLine("");
            /*
            Écrivez un programme en C# qui demande à l'utilisateur d'entrer trois notes (sur 6) et calcule la moyenne de ces notes.   
            Affichez le résultat avec deux décimales.
            */
            // Entrez vos lignes de codes ci-dessous //


        }
        static void Opr5()
        {
            Console.WriteLine("Exercice 5 lancé !");
            Console.WriteLine("");
            /*
            Écrivez un programme en C# qui demande à l'utilisateur d'entrer deux valeurs (A et B).
            Echangez leur contenu sans utiliser de variable supplémentaire.
            */
            // Entrez vos lignes de ci-dessous //


        }

        // ______________________________________________________________________


        // Conditions
        static void Cond1()
        {
            Console.WriteLine("Exercice 1 lancé !");
            Console.WriteLine("");
            /*
            Écrivez un programme en C# qui demande à l'utilisateur de saisir un nombre entier. 
            Vérifiez si le nombre est positif, négatif ou nul.
            Affichez un message approprié à l'utilisateur
            */
            // Entrez vos lignes de ci-dessous //


        }
        static void Cond2()
        {
            Console.WriteLine("Exercice 2 lancé !");
            Console.WriteLine("");
            /*
             Écrivez un programme en C# qui demande à l'utilisateur de saisir un caractère.
             Vérifiez si le caractère est une voyelle (a, e, i, o, u) ou une consonne. 
             Affichez un message approprié à l'utilisateur.
            */
            // Entrez vos lignes de ci-dessous //

        }
        static void Cond3()
        {
            Console.WriteLine("Exercice 3 lancé !");
            Console.WriteLine("");
            /*
            Écrivez un programme en C# qui demande à l'utilisateur de saisir une note sur 100. 
            Vérifiez la plage de la note et affichez le grade correspondant en utilisant la table de correspondance suivante :

                De 0 à 59 : Échec
                De 60 à 69 : D
                De 70 à 79 : C
                De 80 à 89 : B
                De 90 à 100 : A
            */
            // Entrez vos lignes de ci-dessous //


        }
        static void Cond4()
        {
            Console.WriteLine("Exercice 4 lancé !");
            Console.WriteLine("");
            /*
            Écrivez un programme en C# qui demande à l'utilisateur de saisir un mois (1 à 12).
            Utilisez une instruction switch pour afficher le nombre de jours dans ce mois.
            */
            // Entrez vos lignes de ci-dessous //


        }

        // ______________________________________________________________________


        // Boucles
        static void Bouc1()
        {
            Console.WriteLine("Exercice 1 lancé !");
            Console.WriteLine("");
            /*
            Écrivez un programme en C# qui affiche les nombres de 1 à 10 à l'aide d'une boucle for. 
            Et ensuite avec une boucle while.
            */
            // Entrez vos lignes de code ci-dessous //   


        }
        static void Bouc2()
        {
            Console.WriteLine("Exercice 2 lancé !");
            Console.WriteLine("");
            /*
            Écrivez un programme en C# qui demande à l'utilisateur d'entrer un nombre entier positif. 
            Utilisez une boucle for pour afficher les nombres pairs de 0 jusqu'au nombre entré par l'utilisateur. 
            Et ensuite avec une boucle while.
            */
            // Entrez vos lignes de code ci-dessous //


        }
        static void Bouc3()
        {
            Console.WriteLine("Exercice 3 lancé !");
            Console.WriteLine("");
            /*
            Écrivez un programme en C# qui demande à l'utilisateur d'entrer un mot. 
            Utilisez une boucle while pour afficher chaque lettre du mot à l'envers.
            */
            // Entrez vos lignes de code ci-dessous //


        }
        static void Bouc4()
        {
            Console.WriteLine("Exercice 4 lancé !");
            Console.WriteLine("");
            /*
            Écrivez un programme en C# qui calcule la somme des entiers de 1 à 100 en utilisant une boucle for. Affichez ensuite la somme calculée.
            */
            // Entrez vos lignes de code ci-dessous //


        }

        // ______________________________________________________________________

        // Fonctions
        static void Fonc1()
        {
            Console.WriteLine("Exercice 1 lancé !");
            Console.WriteLine("");
            /*
            Déclarez une fonction nommée "CalculerCarre" qui prend un entier en paramètre et renvoie le carré de ce nombre.
            */
            // Entrez vos lignes de code ci-dessous //


        }
        static void Fonc2()
        {
            Console.WriteLine("Exercice 2 lancé !");
            Console.WriteLine("");
            /*
            Déclarez une fonction nommée "EstPair" qui prend un entier en paramètre et renvoie true si le nombre est pair, sinon renvoie false.
            */
            // Entrez vos lignes de code ci-dessous //


        }
        static void Fonc3()
        {
            Console.WriteLine("Exercice 3 lancé !");
            Console.WriteLine("");
            /*
            Déclarez une fonction nommée "CalculerMoyenne" qui prend trois nombres en paramètres et renvoie leur moyenne.
            */
            // Entrez vos lignes de code ci-dessous //


        }
        static void Fonc4()
        {
            Console.WriteLine("Exercice 4 lancé !");
            Console.WriteLine("");
            /*
            Déclarez une fonction nommée "TrouverMaximum" qui prend un tableau d'entiers en paramètre et renvoie la valeur maximale dans ce tableau.
            */
            // Entrez vos lignes de code ci-dessous //


        }
        static void Fonc5()
        {
            Console.WriteLine("Exercice 5 lancé !");
            Console.WriteLine("");
            /*
            Déclarez une fonction nommée "ConvertirEnMajuscules" qui prend une chaîne de caractères en paramètre et renvoie la même chaîne en lettres majuscules.
            */
            // Entrez vos lignes de code ci-dessous //


        }

        // ______________________________________________________________________

        // Tableau 
        static void Tab1()
        {
            Console.WriteLine("Exercice 1 lancé !");
            Console.WriteLine("");
            /*
            Déclarez et initialisez un tableau d'entiers contenant les cinq premiers nombres pairs (2, 4, 6, 8, 10) et affichez-les à l'écran.
            */
            // Entrez vos lignes de code ci-dessous //


        }
        static void Tab2()
        {
            Console.WriteLine("Exercice 2 lancé !");
            Console.WriteLine("");
            /*
            Déclarez et initialisez un tableau de chaînes de caractères contenant les noms de trois fruits (par exemple : "pomme", "orange", "banane") et affichez-les à l'écran.
            */
            // Entrez vos lignes de code ci-dessous //


        }
        static void Tab3()
        {
            Console.WriteLine("Exercice 3 lancé !");
            Console.WriteLine("");
            /*
            Déclarez et initialisez un tableau d'entiers contenant les dix premiers nombres entiers (1 à 10). 
            Demandez ensuite à l'utilisateur d'entrer un nombre entier. 
            Si le nombre entré par l'utilisateur se trouve dans le tableau, 
            affichez "Le nombre est présent dans le tableau", 
            sinon affichez "Le nombre n'est pas présent dans le tableau".
            */
            // Entrez vos lignes de code ci-dessous //


        }
        static void Tab4()
        {
            Console.WriteLine("Exercice 4 lancé !");
            Console.WriteLine("");
            /*
            Déclarez et initialisez un tableau d'entiers contenant cinq valeurs. Demandez ensuite à l'utilisateur d'entrer une valeur. 
            Si la valeur se trouve dans le tableau, supprimez-la et affichez le tableau mis à jour. 
            Sinon, ajoutez cette valeur à la fin du tableau et affichez le tableau mis à jour.
            */
            // Entrez vos lignes de code ci-dessous //


        }
        static void Tab5()
        {
            Console.WriteLine("Exercice 5 lancé !");
            Console.WriteLine("");
            /*
            Déclarez et initialisez un tableau d'entiers de taille 5. 
            Demandez à l'utilisateur d'entrer cinq valeurs entières et stockez-les dans le tableau. 
            Ensuite, affichez la somme de toutes les valeurs du tableau.
            */
            // Entrez vos lignes de code ci-dessous //


        }

        // ______________________________________________________________________

        // Listes
        static void Liste1()
        {
            Console.WriteLine("Exercice 1 lancé !");
            Console.WriteLine("");
            /*
            Créez une liste d'entiers vide et demandez à l'utilisateur d'entrer cinq nombres entiers. Ajoutez ces nombres à la liste et affichez ensuite la liste complète à l'écran.
            */
            // Entrez vos lignes de code ci-dessous //


        }
        static void Liste2()
        {
            Console.WriteLine("Exercice 2 lancé !");
            Console.WriteLine("");
            /*
            Créez une liste de chaînes de caractères contenant les noms de trois pays. Demandez ensuite à l'utilisateur d'entrer le nom d'un pays. 
            Si le pays se trouve dans la liste, supprimez-le et affichez la liste mise à jour. 
            Sinon, ajoutez ce pays à la liste et affichez la liste mise à jour.
            */
            // Entrez vos lignes de code ci-dessous //


        }
        static void Liste3()
        {
            Console.WriteLine("Exercice 3 lancé !");
            Console.WriteLine("");
            /*
            Créez une liste d'entiers contenant quelques valeurs initiales. 
            Demandez à l'utilisateur d'entrer un nombre entier. 
            Si le nombre se trouve dans la liste, affichez son index dans la liste. 
            Sinon, ajoutez-le à la liste et affichez la liste mise à jour.
            */
            // Entrez vos lignes de code ci-dessous //


        }
        static void Liste4()
        {
            Console.WriteLine("Exercice 4 lancé !");
            Console.WriteLine("");
            /*
            Créez une liste d'entiers contenant quelques valeurs initiales. 
            Demandez à l'utilisateur d'entrer un nombre entier. 
            Affichez ensuite combien de fois cette valeur apparaît dans la liste.
            */
            // Entrez vos lignes de code ci-dessous //


        }
        static void Liste5()
        {
            Console.WriteLine("Exercice 5 lancé !");
            Console.WriteLine("");
            /*
            Créez une liste d'entiers contenant quelques valeurs initiales. Demandez à l'utilisateur d'entrer un nombre entier. 
            Supprimez toutes les occurrences de cette valeur dans la liste et affichez la liste mise à jour.
            */
            // Entrez vos lignes de code ci-dessous //


        }

    }
}
