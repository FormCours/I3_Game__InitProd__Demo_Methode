namespace Demo_Methode.Models
{
    public struct MathService
    {
        // Méthode avec deux parametres
        // - "nb1" : Obligatoire
        // - "nb2" : Optionnel, avec la valeur par default de 1
        public int Multi(int nb1, int nb2 = 1)
        {
            return nb1 * nb2;
        }

        // Surchage de méthode
        // - Un méthode qui porte le meme nom
        // - Mais avec un signature différente
        // Soit le nombre de parametre change, soit le type parametre
        public double Multi(double nb1, double nb2)
        {
            Console.WriteLine();
            return 42;
        }
        public double Multi(double nb1, double nb2, double nb3)
        {
            return 42;
        }


        // Méthode qui prend au moins 2 parametres : 
        // - "nb1" : Obligatoire
        // - "nb2" : Obligatoire
        // - "nbs" : Nombre indeterminé via "params" (Un seul)
        public int Addition(int nb1, int nb2, params int[] nbs)
        {
            int result = nb1 + nb2;
            foreach(int val in nbs)
            {
                result += val;
            }
            return result;
        }


        // Méthode avec un test de garde 
        public double Division(int nb1, int nb2)
        {
            // Test de garde
            if(nb2 == 0)
            {
                // - Retour d'une valeur adaptée
                return double.PositiveInfinity; 
                //     (Par default, le symbole pour l'infini c'est "8" en console)

                // - Déclanchement d'une erreur
                // throw new Exception("Boum !");
            }

            return (double)nb1 / nb2;
        }
    }
}
