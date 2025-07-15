using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TunavBackend.Migrations
{
    /// <inheritdoc />
    public partial class SeedUpdateProductsWithMedWatch : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ProduitsAvecDevis",
                columns: new[] { "Id", "Categorie", "Description", "ImagePath", "Titre" },
                values: new object[,]
                {
                    { 1, "IOT", "Système de disjoncteur connecté permettant la surveillance et le contrôle à distance.", "/assets/img/disjoncteur_intelligent.png", "DISJONCTEUR INTELLIGENT" },
                    { 2, "IOT", "Solution RFID intelligente pour la gestion et l’identification automatisée des actifs.", "/assets/img/tagit_rfid.png", "TAGIT RFID" },
                    { 3, "IOT", "Système IoT complet pour le suivi énergétique et la gestion des bâtiments intelligents.", "/assets/img/easy_360.png", "EASY 360" },
                    { 4, "IOT", "Système IoT complet pour le suivi énergétique et la gestion des bâtiments intelligents.", "/assets/img/FUEL_RESCUE.png", "FUEL RESCUE" },
                    { 5, "GPS TRACKER", "Notre smartwatch allie performance et bien-être dans un design moderne et connecté. Équipée d’un écran tactile haute résolution...", "/assets/img/MedWatch.png", "MED WATCH" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Nom", "Password", "Role" },
                values: new object[] { 1, "test@Tunav.com", "admin1", "TUNAV_ADMIN_123", 1 });

            migrationBuilder.InsertData(
                table: "CaracteristiquesProduitAvecDevis",
                columns: new[] { "Id", "ProduitAvecDevisId", "Texte" },
                values: new object[,]
                {
                    { 1, 1, "Fermer à distance n importe quel disjoncteur." },
                    { 2, 1, "Planifier l arrêt et le démarrage automatiques des machines." },
                    { 3, 1, "Mesurer la tension électronique à distance." },
                    { 4, 2, "traçabilité et sécurisation de vos biens" },
                    { 5, 2, "Données en temps réel" },
                    { 6, 3, "surveillance en temps réel des niveaux d’oxygène, de l’humidité, de la température, de la pression, intégrant le GPS, le WiFi, le Bluetooth" },
                    { 7, 3, "compatible avec les protocoles de communication Modbus RS485 et RS422" },
                    { 8, 4, "Détecte rapidement les anomalies telles que le vol de carburant, envossie des alertes" },
                    { 9, 4, "suit l’activité du réservoir" },
                    { 10, 4, "enregistre les pleins et les retraits" },
                    { 11, 4, "simulation et reconstitution de trajets" },
                    { 12, 5, "Grâce à ses capteurs de santé avancés, elle permet une surveillance précise des signes vitaux, pour un mode de vie plus intelligent et plus sain." }
                });

            migrationBuilder.InsertData(
                table: "ProduitsSansDevis",
                columns: new[] { "Id", "Categorie", "Description", "ImagePath", "Prix", "Titre", "UserId" },
                values: new object[,]
                {
                    { 1, "GPS TRACKER", "Ce produit est un traceur GPS de haute précision, idéal pour la géolocalisation de véhicules.", "/assets/img/ET6_KIT.png", "495,000DT", "ET6_KIT", 1 },
                    { 2, "GPS TRACKER", "Un modèle avancé de traceur GPS, avec connectivité améliorée et autonomie prolongée.", "/assets/img/ET8_KIT.png", "435,000DT", "ET8_KIT", 1 },
                    { 3, "GPS TRACKER", "Traceur GPS avec technologie BLE pour un suivi en temps réel via smartphone.", "/assets/img/ETBLE_KIT.png", "345,000 DT", "ETBLE_KIT", 1 },
                    { 4, "GPS TRACKER", "Traceur GPS robuste conçu pour les environnements difficiles et les flottes.", "/assets/img/ETX_KIT.png", "195,000DT", "ETX_KIT", 1 },
                    { 5, "GPS TRACKER", "Traceur GPS avancé conçu pour les véhicules lourds et la gestion de flotte, avec surveillance du carburant et connectivité BUSCAN.", "/assets/img/ETCAN_KIT.png", "695,000DT", "ETCAN_KIT", 1 },
                    { 6, "GPS TRACKER", "Un mini traceur GPS compact pour les objets personnels ou petits véhicules.", "/assets/img/MiniTrace_ KIT.png", "695,000DT", "MiniTrace_KIT", 1 },
                    { 7, "GPS TRACKER", "Caméra de surveillance avec GPS intégré pour le suivi vidéo et géographique.", "/assets/img/Camtrack.png", "1 195,000DT", "Camtrack", 1 },
                    { 8, "GPS TRACKER", "Serrure connectée avec traçabilité GPS pour les containers et accès sécurisés.", "/assets/img/SMART_lo.png", "1 195,000DT", "SMART_LOCK", 1 }
                });

            migrationBuilder.InsertData(
                table: "CaracteristiquesProduitSansDevis",
                columns: new[] { "Id", "ProduitSansDevisId", "Texte" },
                values: new object[,]
                {
                    { 1, 1, "KIT TRACKING GPS" },
                    { 2, 1, "GPRS" },
                    { 3, 1, "SMS - ADVANCED AUTOMOTIVE" },
                    { 4, 2, "KIT TRACKING GPS" },
                    { 5, 2, "GPRS" },
                    { 6, 2, "SMS - ETANCHE AUTOMOTIVE" },
                    { 7, 3, "KIT TRACKING GPS" },
                    { 8, 3, "GPRS" },
                    { 9, 3, "SMS - AUTOMOTIVE" },
                    { 10, 4, "KIT TRACKING GPS" },
                    { 11, 4, "GPRS" },
                    { 12, 4, "SMS - AUTOMOTIVE" },
                    { 13, 5, "KIT TRACKING GPS" },
                    { 14, 5, "GPRS" },
                    { 15, 5, "SMS - BUSCAN" },
                    { 16, 5, "CARBURANT AUTOMOTIVE" },
                    { 17, 6, "KIT TRACKING GPS" },
                    { 18, 6, "GPRS" },
                    { 19, 6, "SMS - PORTABLE" },
                    { 20, 7, "DASHCAM GPS 4G 3CH" },
                    { 21, 7, "FRONT CAM INSIDE CAM" },
                    { 22, 7, "WIFI,MICRO&SPEAKER, SOS, ADAS, DMS - OPTIONAL EXT CAM, OBD, RFID, " },
                    { 23, 7, "TF CARD" },
                    { 24, 8, "KIT TRACKING GPS" },
                    { 25, 8, "GRPS" },
                    { 26, 8, "SMS - TRAILER SMART LOCK" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Devis_UserId",
                table: "Devis",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Devis_Users_UserId",
                table: "Devis",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Devis_Users_UserId",
                table: "Devis");

            migrationBuilder.DropIndex(
                name: "IX_Devis_UserId",
                table: "Devis");

            migrationBuilder.DeleteData(
                table: "CaracteristiquesProduitAvecDevis",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CaracteristiquesProduitAvecDevis",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CaracteristiquesProduitAvecDevis",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CaracteristiquesProduitAvecDevis",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CaracteristiquesProduitAvecDevis",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CaracteristiquesProduitAvecDevis",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CaracteristiquesProduitAvecDevis",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CaracteristiquesProduitAvecDevis",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CaracteristiquesProduitAvecDevis",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CaracteristiquesProduitAvecDevis",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "CaracteristiquesProduitAvecDevis",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "CaracteristiquesProduitAvecDevis",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "CaracteristiquesProduitSansDevis",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CaracteristiquesProduitSansDevis",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CaracteristiquesProduitSansDevis",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CaracteristiquesProduitSansDevis",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CaracteristiquesProduitSansDevis",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CaracteristiquesProduitSansDevis",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CaracteristiquesProduitSansDevis",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CaracteristiquesProduitSansDevis",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CaracteristiquesProduitSansDevis",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CaracteristiquesProduitSansDevis",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "CaracteristiquesProduitSansDevis",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "CaracteristiquesProduitSansDevis",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "CaracteristiquesProduitSansDevis",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "CaracteristiquesProduitSansDevis",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "CaracteristiquesProduitSansDevis",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "CaracteristiquesProduitSansDevis",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "CaracteristiquesProduitSansDevis",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "CaracteristiquesProduitSansDevis",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "CaracteristiquesProduitSansDevis",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "CaracteristiquesProduitSansDevis",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "CaracteristiquesProduitSansDevis",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "CaracteristiquesProduitSansDevis",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "CaracteristiquesProduitSansDevis",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "CaracteristiquesProduitSansDevis",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "CaracteristiquesProduitSansDevis",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "CaracteristiquesProduitSansDevis",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ProduitsAvecDevis",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProduitsAvecDevis",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProduitsAvecDevis",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProduitsAvecDevis",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProduitsAvecDevis",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProduitsSansDevis",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProduitsSansDevis",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProduitsSansDevis",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProduitsSansDevis",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProduitsSansDevis",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProduitsSansDevis",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProduitsSansDevis",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProduitsSansDevis",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
