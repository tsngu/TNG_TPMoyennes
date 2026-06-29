using System;
using System.Collections.Generic;
using System.Linq;

namespace HNI_TPmoyennes
{
    class Eleve
    {

        public string prenom { get; private set; }
        public string nom { get; private set; }
        private List<Note> notes;

        // Limite de nb de notes imposée par les règles
        private const int MAX_NOTES = 200;

        public Eleve(string prenom, string nom)
        {
            this.prenom = prenom;
            this.nom = nom;
            this.notes = new List<Note>();
        }

        // Ajoute une note à l'élève, dans la limites des 200 notes.
        public void ajouterNote(Note note)
        {
            if (notes.Count >= MAX_NOTES)
            {
                Console.WriteLine("Impossible d'ajouter la note : l'eleve " + prenom + " " + nom +
                    " a deja atteint le maximum de " + MAX_NOTES + " notes.");
                return;
            }
            notes.Add(note);
        }

        // Moyenne de l'élève dans une matière
        public float moyenneMatiere(int matiere)
        {
            double somme = 0;
            int nb = 0;
            foreach (Note n in notes)
            {
                if (n.matiere == matiere)
                {
                    somme += n.note;
                    nb++;
                }
            }
            if (nb == 0) return 0f;
            return tronquer(somme / nb);
        }

        // Moyenne générale de l'élève = moyenne des moyennes par matière
        public float moyenneGeneral()
        {
            // Matières dans lesquelles l'élève possède au moins une note
            List<int> matieresEleve = notes.Select(n => n.matiere).Distinct().ToList();
            double somme = 0;
            int nb = 0;
            foreach (int m in matieresEleve)
            {
                somme += moyenneMatiere(m); 
                nb++;
            }
            if (nb == 0) return 0f;
            return tronquer(somme / nb);
        }

        // Tronque une valeur au 2e chiffre après la virgule
        private static float tronquer(double valeur)
        {
            return (float)(Math.Truncate(valeur * 100.0) / 100.0);
        }
    }
}