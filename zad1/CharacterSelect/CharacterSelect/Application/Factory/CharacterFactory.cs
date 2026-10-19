using CharacterSelect.Domain.Characters;
using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Application.Factory
{
    public static class CharacterFactory
    {
        public static Postac Create(CharacterClass cls, string? name)
        {
            return cls switch
            {
                CharacterClass.Wojownik => new Wojownik(Imie(name, "Wojownik")),
                CharacterClass.Mag => new Mag(Imie(name, "Mag")),
                CharacterClass.Lotrzyk => new Lotrzyk(Imie(name, "Łotrzyk")),
                CharacterClass.Rycerz => new Rycerz(Imie(name, "Rycerz")),
                CharacterClass.Lucznik => new Lucznik(Imie(name, "Łucznik")),
                CharacterClass.Nekromanta => new Nekromanta(Imie(name, "Nekromanta")),
                _ => throw new ArgumentOutOfRangeException(nameof(cls))
            };
        }

        private static string Imie(string? name, string domyslne)
            => string.IsNullOrWhiteSpace(name) ? domyslne : name.Trim();
    }
}