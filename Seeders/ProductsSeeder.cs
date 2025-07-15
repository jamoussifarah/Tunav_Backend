using TunavBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace TunavBackend.Seeders
{
    public static class ProductsSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 1,
                Email = "test@Tunav.com",
                Password = "TUNAV_ADMIN_123",
                Role = Models.Enums.Role.Administrateur,
                Nom="admin1"
            });
            var produitsSansDevis = new List<ProduitSansDevis>
            {
                new ProduitSansDevis { Id = 1, UserId = 1, Titre = "ET6_KIT", Description = "Ce produit est un traceur GPS de haute précision, idéal pour la géolocalisation de véhicules.", ImagePath = "/assets/img/ET6_KIT.png", Categorie = "GPS TRACKER", Prix = "495,000DT" },
                new ProduitSansDevis { Id = 2, UserId = 1, Titre = "ET8_KIT", Description = "Un modèle avancé de traceur GPS, avec connectivité améliorée et autonomie prolongée.", ImagePath = "/assets/img/ET8_KIT.png", Categorie = "GPS TRACKER", Prix = "435,000DT" },
                new ProduitSansDevis { Id = 3, UserId = 1, Titre = "ETBLE_KIT", Description = "Traceur GPS avec technologie BLE pour un suivi en temps réel via smartphone.", ImagePath = "/assets/img/ETBLE_KIT.png", Categorie = "GPS TRACKER", Prix = "345,000 DT" },
                new ProduitSansDevis { Id = 4, UserId = 1, Titre = "ETX_KIT", Description = "Traceur GPS robuste conçu pour les environnements difficiles et les flottes.", ImagePath = "/assets/img/ETX_KIT.png", Categorie = "GPS TRACKER", Prix = "195,000DT" },
                new ProduitSansDevis { Id = 5, UserId = 1, Titre = "ETCAN_KIT", Description = "Traceur GPS avancé conçu pour les véhicules lourds et la gestion de flotte, avec surveillance du carburant et connectivité BUSCAN.", ImagePath = "/assets/img/ETCAN_KIT.png", Categorie = "GPS TRACKER", Prix = "695,000DT" },
                new ProduitSansDevis { Id = 6, UserId = 1, Titre = "MiniTrace_KIT", Description = "Un mini traceur GPS compact pour les objets personnels ou petits véhicules.", ImagePath = "/assets/img/MiniTrace_ KIT.png", Categorie = "GPS TRACKER", Prix = "695,000DT" },
                new ProduitSansDevis { Id = 7, UserId = 1, Titre = "Camtrack", Description = "Caméra de surveillance avec GPS intégré pour le suivi vidéo et géographique.", ImagePath = "/assets/img/Camtrack.png", Categorie = "GPS TRACKER", Prix = "1 195,000DT" },
                new ProduitSansDevis { Id = 8, UserId = 1, Titre = "SMART_LOCK", Description = "Serrure connectée avec traçabilité GPS pour les containers et accès sécurisés.", ImagePath = "/assets/img/SMART_lo.png", Categorie = "GPS TRACKER", Prix = "1 195,000DT" }
            };

            var caracteristiquesSansDevis = new List<CaracteristiqueProduitSansDevis>
            {
                new CaracteristiqueProduitSansDevis { ProduitSansDevisId = 1, Texte = "KIT TRACKING GPS" },
                new CaracteristiqueProduitSansDevis { ProduitSansDevisId = 1, Texte = "GPRS" },
                new CaracteristiqueProduitSansDevis { ProduitSansDevisId = 1, Texte = "SMS - ADVANCED AUTOMOTIVE" },

                new CaracteristiqueProduitSansDevis { ProduitSansDevisId = 2, Texte = "KIT TRACKING GPS" },
                new CaracteristiqueProduitSansDevis { ProduitSansDevisId = 2, Texte = "GPRS" },
                new CaracteristiqueProduitSansDevis { ProduitSansDevisId = 2, Texte = "SMS - ETANCHE AUTOMOTIVE" },

                new CaracteristiqueProduitSansDevis { ProduitSansDevisId = 3, Texte = "KIT TRACKING GPS" },
                new CaracteristiqueProduitSansDevis { ProduitSansDevisId = 3, Texte = "GPRS" },
                new CaracteristiqueProduitSansDevis { ProduitSansDevisId = 3, Texte = "SMS - AUTOMOTIVE" },

                new CaracteristiqueProduitSansDevis { ProduitSansDevisId = 4, Texte = "KIT TRACKING GPS" },
                new CaracteristiqueProduitSansDevis { ProduitSansDevisId = 4, Texte = "GPRS" },
                new CaracteristiqueProduitSansDevis { ProduitSansDevisId = 4, Texte = "SMS - AUTOMOTIVE" },

                new CaracteristiqueProduitSansDevis { ProduitSansDevisId = 5, Texte = "KIT TRACKING GPS" },
                new CaracteristiqueProduitSansDevis { ProduitSansDevisId = 5, Texte = "GPRS" },
                new CaracteristiqueProduitSansDevis { ProduitSansDevisId = 5, Texte = "SMS - BUSCAN" },
                new CaracteristiqueProduitSansDevis { ProduitSansDevisId = 5, Texte = "CARBURANT AUTOMOTIVE" },

                new CaracteristiqueProduitSansDevis { ProduitSansDevisId = 6, Texte = "KIT TRACKING GPS" },
                new CaracteristiqueProduitSansDevis { ProduitSansDevisId = 6, Texte = "GPRS" },
                new CaracteristiqueProduitSansDevis { ProduitSansDevisId = 6, Texte = "SMS - PORTABLE" },

                new CaracteristiqueProduitSansDevis { ProduitSansDevisId = 7, Texte = "DASHCAM GPS 4G 3CH" },
                new CaracteristiqueProduitSansDevis { ProduitSansDevisId = 7, Texte = "FRONT CAM INSIDE CAM" },
                new CaracteristiqueProduitSansDevis { ProduitSansDevisId = 7, Texte = "WIFI,MICRO&SPEAKER, SOS, ADAS, DMS - OPTIONAL EXT CAM, OBD, RFID, " },
                new CaracteristiqueProduitSansDevis { ProduitSansDevisId = 7, Texte = "TF CARD" },

                new CaracteristiqueProduitSansDevis { ProduitSansDevisId = 8, Texte = "KIT TRACKING GPS" },
                new CaracteristiqueProduitSansDevis { ProduitSansDevisId = 8, Texte = "GRPS" },
                new CaracteristiqueProduitSansDevis { ProduitSansDevisId = 8, Texte = "SMS - TRAILER SMART LOCK" }
            };

            modelBuilder.Entity<ProduitSansDevis>().HasData(produitsSansDevis);

            int idSans = 1;
            foreach (var c in caracteristiquesSansDevis)
            {
                c.Id = idSans++;
            }
            modelBuilder.Entity<CaracteristiqueProduitSansDevis>().HasData(caracteristiquesSansDevis);

            // PRODUITS AVEC DEVIS
            var produitsAvecDevis = new List<ProduitAvecDevis>
            {
                new ProduitAvecDevis { Id = 1, Titre = "DISJONCTEUR INTELLIGENT", Description = "Système de disjoncteur connecté permettant la surveillance et le contrôle à distance.", ImagePath = "/assets/img/disjoncteur_intelligent.png", Categorie = "IOT" },
                new ProduitAvecDevis { Id = 2, Titre = "TAGIT RFID", Description = "Solution RFID intelligente pour la gestion et l’identification automatisée des actifs.", ImagePath = "/assets/img/tagit_rfid.png", Categorie = "IOT" },
                new ProduitAvecDevis { Id = 3, Titre = "EASY 360", Description = "Système IoT complet pour le suivi énergétique et la gestion des bâtiments intelligents.", ImagePath = "/assets/img/easy_360.png", Categorie = "IOT" },
                new ProduitAvecDevis { Id = 4, Titre = "FUEL RESCUE", Description = "Système IoT complet pour le suivi énergétique et la gestion des bâtiments intelligents.", ImagePath = "/assets/img/FUEL_RESCUE.png", Categorie = "IOT" },
                new ProduitAvecDevis { Id = 5, Titre = "MED WATCH", Description = "Notre smartwatch allie performance et bien-être dans un design moderne et connecté. Équipée d’un écran tactile haute résolution...", ImagePath = "/assets/img/MedWatch.png", Categorie = "IOT" }
            };

            var caracteristiquesAvecDevis = new List<CaracteristiqueProduitAvecDevis>
            {
                new CaracteristiqueProduitAvecDevis { ProduitAvecDevisId = 1, Texte = "Fermer à distance n importe quel disjoncteur." },
                new CaracteristiqueProduitAvecDevis { ProduitAvecDevisId = 1, Texte = "Planifier l arrêt et le démarrage automatiques des machines." },
                new CaracteristiqueProduitAvecDevis { ProduitAvecDevisId = 1, Texte = "Mesurer la tension électronique à distance." },

                new CaracteristiqueProduitAvecDevis { ProduitAvecDevisId = 2, Texte = "traçabilité et sécurisation de vos biens" },
                new CaracteristiqueProduitAvecDevis { ProduitAvecDevisId = 2, Texte = "Données en temps réel" },

                new CaracteristiqueProduitAvecDevis { ProduitAvecDevisId = 3, Texte = "surveillance en temps réel des niveaux d’oxygène, de l’humidité, de la température, de la pression, intégrant le GPS, le WiFi, le Bluetooth" },
                new CaracteristiqueProduitAvecDevis { ProduitAvecDevisId = 3, Texte = "compatible avec les protocoles de communication Modbus RS485 et RS422" },

                new CaracteristiqueProduitAvecDevis { ProduitAvecDevisId = 4, Texte = "Détecte rapidement les anomalies telles que le vol de carburant, envossie des alertes" },
                new CaracteristiqueProduitAvecDevis { ProduitAvecDevisId = 4, Texte = "suit l’activité du réservoir" },
                new CaracteristiqueProduitAvecDevis { ProduitAvecDevisId = 4, Texte = "enregistre les pleins et les retraits" },
                new CaracteristiqueProduitAvecDevis { ProduitAvecDevisId = 4, Texte = "simulation et reconstitution de trajets" },

                new CaracteristiqueProduitAvecDevis { ProduitAvecDevisId = 5, Texte = "Grâce à ses capteurs de santé avancés, elle permet une surveillance précise des signes vitaux, pour un mode de vie plus intelligent et plus sain." }
            };

            modelBuilder.Entity<ProduitAvecDevis>().HasData(produitsAvecDevis);

            int idAvec = 1;
            foreach (var c in caracteristiquesAvecDevis)
            {
                c.Id = idAvec++;
            }
            modelBuilder.Entity<CaracteristiqueProduitAvecDevis>().HasData(caracteristiquesAvecDevis);
        }
    }
}