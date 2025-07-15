using Microsoft.EntityFrameworkCore;
using TunavBackend.Models; // adapte selon ton namespace

namespace TunavBackend.Seeders
{
    public static class BlogsSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            // Seed du blog
            modelBuilder.Entity<Blog>().HasData(new Blog
            {
                Id = 12,
                Titre = "Pourquoi l’IoT est la clé du succès des entreprises modernes ?",
                Contenu = @"1. Qu’est-ce que l’IoT ?
L’IoT, ou Internet des Objets, désigne un réseau d'objets physiques connectés à Internet capables de collecter, échanger et analyser des données. Ces objets — capteurs, caméras, GPS, machines industrielles, équipements embarqués — communiquent entre eux ou avec une plateforme centrale, permettant ainsi de prendre des décisions en temps réel, souvent sans intervention humaine.
L’IoT transforme les objets du quotidien en outils intelligents au service de la performance, de la sécurité et de l'automatisation.

________________________________________
2. Pourquoi choisir l’IoT ?
Dans un monde où la réactivité et l’optimisation des ressources sont devenues des priorités, l’IoT permet aux entreprises de :
• Mieux maîtriser leurs opérations
• Réduire les coûts liés aux pertes ou aux pannes
• Offrir une expérience client plus fluide et personnalisée
• Collecter des données stratégiques pour la prise de décision
L’IoT n’est plus une option, mais un levier essentiel pour toute entreprise souhaitant rester compétitive à l’ère numérique.

________________________________________

3. Les avantages concrets de l’IoT pour les entreprises
✅ Optimisation des processus
Les objets connectés permettent d’automatiser des tâches chronophages et d’avoir une vue globale sur l’activité.
✅ Réduction des coûts
Grâce à la maintenance prédictive, il est possible d’intervenir avant qu’un problème ne survienne.
✅ Sécurité renforcée
Des systèmes de surveillance intelligente permettent de suivre en temps réel les véhicules, les bâtiments ou les machines.
✅ Gain de productivité
Les données collectées sont analysées automatiquement pour aider à la prise de décision rapide.
✅ Traçabilité & contrôle à distance
Idéal pour le suivi de flotte, la logistique, l’agriculture ou l’énergie, l’IoT offre un pilotage centralisé.

________________________________________

4. Tunav IT Group : votre partenaire IoT en Tunisie
Spécialiste des technologies IT, IoT et GPS, Tunav IT Group accompagne depuis plusieurs années les entreprises tunisiennes dans leur transformation digitale.
Nos solutions IoT incluent :
🔹 Tracking GPS/GSM/Satellite en temps réel
🔹 Diagnostics embarqués (CANBUS / OBD) pour véhicules professionnels
🔹 Surveillance vidéo embarquée avec alerte intelligente
🔹 Capteurs de température, de mouvement, de consommation pour divers secteurs
🔹 Plateformes cloud pour la gestion et l’analyse des données
🔹 Support local réactif et personnalisé
Nous concevons des systèmes clés en main, évolutifs et sécurisés, adaptés à vos besoins spécifiques. Que vous soyez dans le transport, la logistique, l’agriculture ou la distribution, nous avons une solution IoT sur mesure pour vous.

________________________________________

💬 Vous souhaitez digitaliser votre activité avec l’IoT ?
Tunav IT Group est prêt à vous accompagner. Contactez-nous pour une démonstration gratuite et découvrez comment nos solutions connectées peuvent booster vos performances.
",
                DatePublication = new DateTime(2025, 7, 15, 11, 46, 31, 65, DateTimeKind.Local).AddTicks(6288), // correspond à ton datetime
                ImagePath = "/uploads/cba1c67e-f7f0-418e-bd29-0e8f8e282831.jpeg",
                UserId = 1,
                Likes = 0
            });

            // Seed des tags liés au blog
            modelBuilder.Entity<Tag>().HasData(
                new Tag { Id = 1, Nom = "GPS Tracking IoT", BlogId = 12 },
                new Tag { Id = 2, Nom = "IOT Tunisie", BlogId = 12 },
                new Tag { Id = 3, Nom = "Flotte intelligente", BlogId = 12 },
                new Tag { Id = 4, Nom = "Surveillance à distance", BlogId = 12 },
                new Tag { Id = 5, Nom = "Gestion de flotte connectée", BlogId = 12 },
                new Tag { Id = 6, Nom = "IOT et Cloud", BlogId = 12 },
                new Tag { Id = 7, Nom = "Diagnostic à distance", BlogId = 12 }
            );
        }
    }
}
