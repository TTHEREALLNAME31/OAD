namespace CharacterSelect.Domain.Characters
{
    public abstract class Postac
    {
        public string Imie { get; }
        public string Klasa { get; }

        public int Sila { get; }
        public int Inteligencja { get; }
        public int Zrecznosc { get; }
        // nowe statystyki
        public int Obrona { get; }
        public int Mana { get; }
        public int Szczescie { get; }

        protected Postac(string imie, string klasa, int sila, int inteligencja,
                         int zrecznosc, int obrona, int mana, int szczescie)
        {
            Imie = imie;
            Klasa = klasa;
            Sila = sila;
            Inteligencja = inteligencja;
            Zrecznosc = zrecznosc;
            Obrona = obrona;
            Mana = mana;
            Szczescie = szczescie;
        }

        protected abstract string NazwaGlownejStatystyki { get; }
        protected abstract int GlownaStatystyka { get; }

        // atak = główna_statystyka * 3
        public int ObliczAtak() => GlownaStatystyka * 3;

        public void Describe()
        {
            Console.WriteLine($"Imię:          {Imie}");
            Console.WriteLine($"Klasa:         {Klasa}");
            Console.WriteLine("--- Statystyki ---");
            Console.WriteLine($"Siła:          {Sila}");
            Console.WriteLine($"Inteligencja:  {Inteligencja}");
            Console.WriteLine($"Zręczność:     {Zrecznosc}");
            Console.WriteLine($"Obrona:        {Obrona}");
            Console.WriteLine($"Mana:          {Mana}");
            Console.WriteLine($"Szczęście:     {Szczescie}");
            Console.WriteLine($"Główna statystyka: {NazwaGlownejStatystyki}");
        }

        public void Attack()
        {
            Console.WriteLine($"{Imie} ({Klasa}) wykonuje atak!");
            Console.WriteLine($"Obrażenia: {ObliczAtak()}");
        }

        public abstract void UseSpecial();
    }

    public class Wojownik : Postac
    {
        public Wojownik(string imie) : base(imie, "Wojownik", 15, 5, 8, 10, 0, 5) { }
        protected override string NazwaGlownejStatystyki => "Siła";
        protected override int GlownaStatystyka => Sila;
        public override void UseSpecial()
        {
            Console.WriteLine($"{Imie} używa Szału Bojowego!");
            Console.WriteLine("Przeciwnik zostaje odepchnięty potężnym ciosem!");
        }
    }

    public class Mag : Postac
    {
        public Mag(string imie) : base(imie, "Mag", 4, 15, 7, 3, 30, 6) { }
        protected override string NazwaGlownejStatystyki => "Inteligencja";
        protected override int GlownaStatystyka => Inteligencja;
        public override void UseSpecial()
        {
            Console.WriteLine($"{Imie} używa Kuli Ognia!");
            Console.WriteLine("Przeciwnik zostaje trafiony płomieniem!");
        }
    }

    public class Lotrzyk : Postac
    {
        public Lotrzyk(string imie) : base(imie, "Łotrzyk", 7, 6, 15, 5, 5, 12) { }
        protected override string NazwaGlownejStatystyki => "Zręczność";
        protected override int GlownaStatystyka => Zrecznosc;
        public override void UseSpecial()
        {
            Console.WriteLine($"{Imie} używa Ciosu w Plecy!");
            Console.WriteLine("Przeciwnik nawet nie zauważył, skąd nadszedł atak!");
        }
    }

    // ===== NOWE POSTACIE =====

    public class Rycerz : Postac
    {
        public Rycerz(string imie) : base(imie, "Rycerz", 13, 6, 6, 18, 0, 7) { }
        protected override string NazwaGlownejStatystyki => "Siła";
        protected override int GlownaStatystyka => Sila;
        public override void UseSpecial()
        {
            Console.WriteLine($"{Imie} używa Tarczy Honoru!");
            Console.WriteLine("Atak przeciwnika odbija się od pancerza!");
        }
    }

    public class Lucznik : Postac
    {
        public Lucznik(string imie) : base(imie, "Łucznik", 6, 7, 16, 4, 8, 10) { }
        protected override string NazwaGlownejStatystyki => "Zręczność";
        protected override int GlownaStatystyka => Zrecznosc;
        public override void UseSpecial()
        {
            Console.WriteLine($"{Imie} używa Deszczu Strzał!");
            Console.WriteLine("Niebo ciemnieje od lecących pocisków!");
        }
    }

    public class Nekromanta : Postac
    {
        public Nekromanta(string imie) : base(imie, "Nekromanta", 3, 17, 5, 4, 40, 8) { }
        protected override string NazwaGlownejStatystyki => "Inteligencja";
        protected override int GlownaStatystyka => Inteligencja;
        public override void UseSpecial()
        {
            Console.WriteLine($"{Imie} przywołuje Armię Szkieletów!");
            Console.WriteLine("Martwi powstają z ziemi i atakują przeciwnika!");
        }
    }
}