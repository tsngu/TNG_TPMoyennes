using System;
using System.Collections.Generic;

namespace HNI_TPmoyennes
{
    class Classe
    {
        public string nomClasse { get; private set;}
        public List<Eleve> eleves { get; private set; }
        public List<string> matieres { get; private set; }

        // Limites imposées par les règles
        private const int MAX_ELEVES = 30;
        private const int MAX_MATIERES = 10;

        public Classe(string nomClasse)
        {
            this.nomClasse = nomClasse;
            this.eleves = new List<Eleve>();
            this.matieres = new List<string>();
        }

        // Ajout d'un élève sans dépasser 30
        public void ajouterEleve(string nom, string prenom)
        {
            if (eleves.Count >= MAX_ELEVES)
            {
                Console.WriteLine("Impossible d'ajouter l'élève : la classe" + nomClasse + " est déjà pleine.");
                return;
            }
            eleves.Add(new Eleve(nom, prenom));
        }

        // Ajout d'une matière, dans la limite de 10
        public void ajouterMatiere(string matiere)
        {
            if (matieres.Count >= MAX_MATIERES)
            {
                Console.WriteLine("Impossible d'ajouter la matiere : maximum de " + MAX_MATIERES + " matieres atteint.");
                return;
            }
            matieres.Add(matiere);
        }
 
        // Moyenne de la classe dans une matière =  moyenne des moyennes des élèves dans cette matière
        public float moyenneMatiere(int matiere)
        {
            double somme = 0;
            int nb = 0;
            foreach (Eleve e in eleves)
            {
                somme += e.moyenneMatiere(matiere);
                nb++;
            }
            if (nb == 0) return 0f;
            return tronquer(somme / nb);
        }
 
        // Moyenne générale de la classe = moyenne des moyennes de la classe par matière
        public float moyenneGeneral()
        {
            double somme = 0;
            int nb = 0;
            for (int m = 0; m < matieres.Count; m++)
            {
                somme += moyenneMatiere(m);
                nb++;
            }
            if (nb == 0) return 0f;
            return tronquer(somme / nb);
        }
 
        // Tronque une valeur au 2e chiffre après la virgule, sans arrondir
        private static float tronquer(double valeur)
        {
            return (float)(Math.Truncate(valeur * 100.0) / 100.0);
        }
    }
}
