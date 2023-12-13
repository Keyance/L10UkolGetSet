using L10UkolGetSet;

Osoba osoba = new Osoba();

osoba.vek = 24;
Console.WriteLine(osoba.jePlnoleta);
osoba.jmeno = "Klára";
osoba.Prijmeni = "Konopáčová";
osoba.jePlnoleta = false; //toto nefunguje díky nastaveným kontrolám v get
Console.WriteLine(osoba);