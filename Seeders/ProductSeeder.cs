using TunavBackend.Models;

namespace TunavBackend.Data
{
    public static class ProductSeeder
    {
        public static void Initialize(AppDbContext context)
        {
            if (!context.ProduitsSansDevis.Any())
            {
                var produitsSansDevis = new List<ProduitSansDevis>
                {
                    new ProduitSansDevis
                    {
                        Titre = "ET6_KIT",
                        Description = "Ce produit est un traceur GPS de haute précision, idéal pour la géolocalisation de véhicules.",
                        ImagePath = "ET6_KIT.png",
                        Categorie = "GPS TRACKER",
                        Prix = "495,000DT",
                        Caracteristiques = new List<CaracteristiqueProduitSansDevis>
                        {
                            new() { Texte = "KIT TRACKING GPS" },
                            new() { Texte = "GPRS" },
                            new() { Texte = "SMS - ADVANCED AUTOMOTIVE" }
                        }
                    },
                    new ProduitSansDevis
                    {
                        Titre = "ET8_KIT",
                        Description = "Un modèle avancé de traceur GPS, avec connectivité améliorée et autonomie prolongée.",
                        ImagePath = "ET8_KIT.png",
                        Categorie = "GPS TRACKER",
                        Prix = "435,000DT",
                        Caracteristiques = new List<CaracteristiqueProduitSansDevis>
                        {
                            new() { Texte = "KIT TRACKING GPS" },
                            new() { Texte = "GPRS" },
                            new() { Texte = "SMS - ETANCHE AUTOMOTIVE" }
                        }
                    },
                    new ProduitSansDevis
                    {
                        Titre = "ETBLE_KIT",
                        Description = "Traceur GPS avec technologie BLE pour un suivi en temps réel via smartphone.",
                        ImagePath = "ETBLE_KIT.png",
                        Categorie = "GPS TRACKER",
                        Prix = "345,000 DT",
                        Caracteristiques = new List<CaracteristiqueProduitSansDevis>
                        {
                            new() { Texte = "KIT TRACKING GPS" },
                            new() { Texte = "GPRS" },
                            new() { Texte = "SMS - AUTOMOTIVE" }
                        }
                    },
                    new ProduitSansDevis
                    {
                        Titre = "ETX_KIT",
                        Description = "Traceur GPS robuste conçu pour les environnements difficiles et les flottes.",
                        ImagePath = "ETX_KIT.png",
                        Categorie = "GPS TRACKER",
                        Prix = "195,000DT",
                        Caracteristiques = new List<CaracteristiqueProduitSansDevis>
                        {
                            new() { Texte = "KIT TRACKING GPS" },
                            new() { Texte = "GPRS" },
                            new() { Texte = "SMS - AUTOMOTIVE" }
                        }
                    },
                    new ProduitSansDevis
                    {
                        Titre = "ETCAN_KIT",
                        Description = "Traceur GPS avancé conçu pour les véhicules lourds et la gestion de flotte, avec surveillance du carburant et connectivité BUSCAN.",
                        ImagePath = "ETCAN_KIT.png",
                        Categorie = "GPS TRACKER",
                        Prix = "695,000DT",
                        Caracteristiques = new List<CaracteristiqueProduitSansDevis>
                        {
                            new() { Texte = "KIT TRACKING GPS" },
                            new() { Texte = "GPRS" },
                            new() { Texte = "SMS - BUSCAN" },
                            new() { Texte = "CARBURANT AUTOMOTIVE" }
                        }
                    },
                    new ProduitSansDevis
                    {
                        Titre = "MiniTrace_KIT",
                        Description = "Un mini traceur GPS compact pour les objets personnels ou petits véhicules.",
                        ImagePath = "MiniTrace_ KIT.png",
                        Categorie = "GPS TRACKER",
                        Prix = "695,000DT",
                        Caracteristiques = new List<CaracteristiqueProduitSansDevis>
                        {
                            new() { Texte = "KIT TRACKING GPS" },
                            new() { Texte = "GPRS" },
                            new() { Texte = "SMS - PORTABLE" }
                        }
                    },
                    new ProduitSansDevis
                    {
                        Titre = "Camtrack",
                        Description = "Caméra de surveillance avec GPS intégré pour le suivi vidéo et géographique.",
                        ImagePath = "Camtrack.png",
                        Categorie = "GPS TRACKER",
                        Prix = "1 195,000DT",
                        Caracteristiques = new List<CaracteristiqueProduitSansDevis>
                        {
                            new() { Texte = "DASHCAM GPS 4G 3CH" },
                            new() { Texte = "FRONT CAM INSIDE CAM" },
                            new() { Texte = "WIFI,MICRO&SPEAKER, SOS, ADAS, DMS - OPTIONAL EXT CAM, OBD, RFID, " },
                            new() { Texte = "TF CARD" }
                        }
                    },
                    new ProduitSansDevis
                    {
                        Titre = "SMART_LOCK",
                        Description = "Serrure connectée avec traçabilité GPS pour les containers et accès sécurisés.",
                        ImagePath = "SMART_lo.png",
                        Categorie = "GPS TRACKER",
                        Prix = "1 195,000DT",
                        Caracteristiques = new List<CaracteristiqueProduitSansDevis>
                        {
                            new() { Texte = "KIT TRACKING GPS" },
                            new() { Texte = "GRPS" },
                            new() { Texte = "SMS - TRAILER SMART LOCK" }
                        }
                    }
                };

                context.ProduitsSansDevis.AddRange(produitsSansDevis);
                context.SaveChanges();
            }

            if (!context.ProduitsAvecDevis.Any())
            {
                var produitsAvecDevis = new List<ProduitAvecDevis>
                {
                    new ProduitAvecDevis
                    {
                        Titre = "DISJONCTEUR INTELLIGENT",
                        Description = "Système de disjoncteur connecté permettant la surveillance et le contrôle à distance.",
                        ImagePath = "disjoncteur_intelligent.png",
                        Categorie = "IOT",
                        Caracteristiques = new List<CaracteristiqueProduitAvecDevis>
                        {
                            new() { Texte = "Fermer à distance n importe quel disjoncteur." },
                            new() { Texte = "Planifier l arrêt et le démarrage automatiques des machines." },
                            new() { Texte = "Mesurer la tension électronique à distance." }
                        }
                    },
                    new ProduitAvecDevis
                    {
                        Titre = "TAGIT RFID",
                        Description = "Solution RFID intelligente pour la gestion et l’identification automatisée des actifs.",
                        ImagePath = "tagit_rfid.png",
                        Categorie = "IOT",
                        Caracteristiques = new List<CaracteristiqueProduitAvecDevis>
                        {
                            new() { Texte = "traçabilité et sécurisation de vos biens" },
                            new() { Texte = "Données en temps réel" }
                        }
                    },
                    new ProduitAvecDevis
                    {
                        Titre = "EASY 360",
                        Description = "Système IoT complet pour le suivi énergétique et la gestion des bâtiments intelligents.",
                        ImagePath = "easy_360.png",
                        Categorie = "IOT",
                        Caracteristiques = new List<CaracteristiqueProduitAvecDevis>
                        {
                            new() { Texte = "surveillance en temps réel des niveaux d’oxygène, de l’humidité, de la température, de la pression, intégrant le GPS, le WiFi, le Bluetooth" },
                            new() { Texte = "compatible avec les protocoles de communication Modbus RS485 et RS422" }
                        }
                    },
                    new ProduitAvecDevis
                    {
                        Titre = "FUEL RESCUE",
                        Description = "Système IoT complet pour le suivi énergétique et la gestion des bâtiments intelligents.",
                        ImagePath = "FUEL_RESCUE.png",
                        Categorie = "IOT",
                        Caracteristiques = new List<CaracteristiqueProduitAvecDevis>
                        {
                            new() { Texte = "Détecte rapidement les anomalies telles que le vol de carburant, envossie des alertes" },
                            new() { Texte = "suit l’activité du réservoir" },
                            new() { Texte = "enregistre les pleins et les retraits" },
                            new() { Texte = "simulation et reconstitution de trajets" }
                        }
                    },
                    new ProduitAvecDevis
                    {
                        Titre = "MED WATCH",
                        Description = "Notre smartwatch allie performance et bien-être dans un design moderne et connecté. Équipée d’un écran tactile haute résolution,d’un processeur double cœur à faible consommation d’énergie et d’une connectivité 4G mondiale, elle offre une expérience fluide et continue ",
                        ImagePath = "MedWatch.jpg",
                        Categorie = "IOT",
                        Caracteristiques = new List<CaracteristiqueProduitAvecDevis>
                        {
                            new() { Texte = "Grâce à ses capteurs de santé avancés, elle permet une surveillance précise des signes vitaux, pour un mode de vie plus intelligent et plus sain." }
                        }
                    }
                };

                context.ProduitsAvecDevis.AddRange(produitsAvecDevis);
                context.SaveChanges();
            }
        }
    }
}
