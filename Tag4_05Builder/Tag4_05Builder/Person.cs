namespace Tag4_05Builder;

public class Person
{
    public string Vorname { get; set; }
    public string Nachname { get; set; }
    public string Anrede { get; set; }
    public string Ort { get; set; }
    public string Strasse { get; set; }

    public Person(string vorname, string nachname, string anrede, string ort, string strasse)
    {
        Vorname = vorname;
        Nachname = nachname;
        Anrede = anrede;
        Ort = ort;
        Strasse = strasse;
    }

    public static PersonBuilder Builder()
    {
        return new PersonBuilder();
    }

    public override string ToString()
    {
        return
            $"{nameof(Vorname)}: {Vorname}, {nameof(Nachname)}: {Nachname}, {nameof(Anrede)}: {Anrede}, {nameof(Ort)}: {Ort}, {nameof(Strasse)}: {Strasse}";
    }

    public class PersonBuilder
    {
        private Person person = new Person("","","","","");

        public PersonBuilder WithVorname(string vorname)
        {
            person.Vorname = vorname;
            return this;
        }

        public PersonBuilder WithNachname(string nachname)
        {
            person.Nachname = nachname;
            return this;
        }

        public PersonBuilder WithAnrede(string anrede)
        {
            person.Anrede = anrede;
            return this;
        }

        public PersonBuilder WithOrt(string ort)
        {
            person.Ort = ort;
            return this;
            
        }

        public PersonBuilder WithStrasse(string strasse)
        {
            person.Strasse = strasse;
            return this;
        }

        public Person Build()
        {
            // Crossfield Check
            return person;
        }
        
    }
}