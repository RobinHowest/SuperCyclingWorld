using System;
using System.Collections.Generic;
using System.Text;

namespace SuperCyclingWorld.Core.Repositories
{
    public static class MeerWetenRepository
    {
        public static string GetMeerWetenOverSignIn()
        {
            return "Sluit je aan bij de grootste wielerclub van Vlaanderen en vertegenwoordig je eigen club doorheen het land. Word vrienden met andere wielrenners"+
                " of suppertor voor je favoriete club of wielrenner. Je kan ook je eigen ritten oploaden en anderen uitdagen om jouw record te verslaan. \n\n " +
                " Hou gemakkelijk al je ritgegevens bij en maak je droomfiets of maak gewoon je eigen fiets na ! Lees meer over ons via het tablad in het hoofdmenu bovenaan.";
        }

        public static string GetMeerWetenOverClubs()
        {
            return "Ontdek hier al onze aangesloten clubs.. Psst, wist je al dat je als supporter fan kunt zijn van meerder clubs ? Als wielrenner kan je maar tot 1 club behoren, maar je kan zelf heel veel fans hebben ! Wie is jouw fan ?";
        }
    }
}
