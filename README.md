# TNG_TPMoyennes - Formation DOTNET HNInstitut.

## Rendu de projet 1.

Ayant codé le projet sur Ubuntu et donc VSCode, j'ai repris le fichier .sln du git https://github.com/HNINSTITUT/HNI-TPmoyennes.git

Sur ubuntu et depuis un terminal, entrez dans le dossier TNG_TPMoyennes et lancez le programme avec :
`dotnet run`

## Rappel des consignes :

Pour une école, réalisez un programme qui permet de calculer :

La moyenne d’un élève dans chaque matière, la moyenne générale d’un élève,
la moyenne de la classe dans chaque matière et la moyenne générale de la classe,
selon les règles suivantes :

- Chaque moyenne est tronquée au-delà du second chiffre après la virgule.
- La moyenne générale d’un élève est obtenue par la moyenne des moyennes de l’élève par matière.
- La moyenne de la classe dans une matière est la moyenne des moyennes de tous les élèves dans la matière.
- La moyenne générale de la classe est la moyenne des moyennes de la classe par matière.
- Une classe accueille 30 élèves au maximum.
- 10 matières au maximum sont enseignées dans une classe.
- Un élève reçoit au plus 200 notes, toutes matières confondues, au cours de l’année.

Les classes Program et Note ont été fournis.