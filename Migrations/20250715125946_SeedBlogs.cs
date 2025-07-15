using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TunavBackend.Migrations
{
    /// <inheritdoc />
    public partial class SeedBlogs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "Contenu", "DatePublication", "ImagePath", "Likes", "Titre", "UserId" },
                values: new object[] { 12, "1. Qu’est-ce que l’IoT ?\r\nL’IoT, ou Internet des Objets, désigne un réseau d'objets physiques connectés à Internet capables de collecter, échanger et analyser des données. Ces objets — capteurs, caméras, GPS, machines industrielles, équipements embarqués — communiquent entre eux ou avec une plateforme centrale, permettant ainsi de prendre des décisions en temps réel, souvent sans intervention humaine.\r\nL’IoT transforme les objets du quotidien en outils intelligents au service de la performance, de la sécurité et de l'automatisation.\r\n\r\n________________________________________\r\n2. Pourquoi choisir l’IoT ?\r\nDans un monde où la réactivité et l’optimisation des ressources sont devenues des priorités, l’IoT permet aux entreprises de :\r\n• Mieux maîtriser leurs opérations\r\n• Réduire les coûts liés aux pertes ou aux pannes\r\n• Offrir une expérience client plus fluide et personnalisée\r\n• Collecter des données stratégiques pour la prise de décision\r\nL’IoT n’est plus une option, mais un levier essentiel pour toute entreprise souhaitant rester compétitive à l’ère numérique.\r\n\r\n________________________________________\r\n\r\n3. Les avantages concrets de l’IoT pour les entreprises\r\n✅ Optimisation des processus\r\nLes objets connectés permettent d’automatiser des tâches chronophages et d’avoir une vue globale sur l’activité.\r\n✅ Réduction des coûts\r\nGrâce à la maintenance prédictive, il est possible d’intervenir avant qu’un problème ne survienne.\r\n✅ Sécurité renforcée\r\nDes systèmes de surveillance intelligente permettent de suivre en temps réel les véhicules, les bâtiments ou les machines.\r\n✅ Gain de productivité\r\nLes données collectées sont analysées automatiquement pour aider à la prise de décision rapide.\r\n✅ Traçabilité & contrôle à distance\r\nIdéal pour le suivi de flotte, la logistique, l’agriculture ou l’énergie, l’IoT offre un pilotage centralisé.\r\n\r\n________________________________________\r\n\r\n4. Tunav IT Group : votre partenaire IoT en Tunisie\r\nSpécialiste des technologies IT, IoT et GPS, Tunav IT Group accompagne depuis plusieurs années les entreprises tunisiennes dans leur transformation digitale.\r\nNos solutions IoT incluent :\r\n🔹 Tracking GPS/GSM/Satellite en temps réel\r\n🔹 Diagnostics embarqués (CANBUS / OBD) pour véhicules professionnels\r\n🔹 Surveillance vidéo embarquée avec alerte intelligente\r\n🔹 Capteurs de température, de mouvement, de consommation pour divers secteurs\r\n🔹 Plateformes cloud pour la gestion et l’analyse des données\r\n🔹 Support local réactif et personnalisé\r\nNous concevons des systèmes clés en main, évolutifs et sécurisés, adaptés à vos besoins spécifiques. Que vous soyez dans le transport, la logistique, l’agriculture ou la distribution, nous avons une solution IoT sur mesure pour vous.\r\n\r\n________________________________________\r\n\r\n💬 Vous souhaitez digitaliser votre activité avec l’IoT ?\r\nTunav IT Group est prêt à vous accompagner. Contactez-nous pour une démonstration gratuite et découvrez comment nos solutions connectées peuvent booster vos performances.\r\n", new DateTime(2025, 7, 15, 11, 46, 31, 65, DateTimeKind.Local).AddTicks(6288), "/uploads/cba1c67e-f7f0-418e-bd29-0e8f8e282831.jpeg", 0, "Pourquoi l’IoT est la clé du succès des entreprises modernes ?", 1 });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "BlogId", "Nom" },
                values: new object[,]
                {
                    { 1, 12, "GPS Tracking IoT" },
                    { 2, 12, "IOT Tunisie" },
                    { 3, 12, "Flotte intelligente" },
                    { 4, 12, "Surveillance à distance" },
                    { 5, 12, "Gestion de flotte connectée" },
                    { 6, 12, "IOT et Cloud" },
                    { 7, 12, "Diagnostic à distance" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 12);
        }
    }
}
