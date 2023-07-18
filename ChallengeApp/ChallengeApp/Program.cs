
Employee E1 = new Employee("Marek", "Chodny", 20);
Employee E2 = new Employee("Julia", "Mak", 33);
Employee E3 = new Employee("Damian", "Sokolik", 35);
E1.dodajWynik(2);
E1.dodajWynik(4);
E1.dodajWynik(6);
E1.dodajWynik(8);
E1.dodajWynik(10);

E2.dodajWynik(2);
E2.dodajWynik(2);
E2.dodajWynik(2);
E2.dodajWynik(2);
E2.dodajWynik(2);

E3.dodajWynik(9);
E3.dodajWynik(9);
E3.dodajWynik(9);
E3.dodajWynik(9);
E3.dodajWynik(9);

var sumaE1 = E1.Suma;
var sumaE2 = E2.Suma;
var sumaE3 = E3.Suma;

List<Employee> employees = new List<Employee>()
{
    E1,E2,E3
};

int maxWynik = -1;
Employee EwithMaxWynik = null;

foreach (var emp in employees)
{
    if (emp.Suma > maxWynik)
    {
        EwithMaxWynik = emp;
    }
}
Console.WriteLine(EwithMaxWynik.Imie + " " + EwithMaxWynik.Nazwisko + " " + EwithMaxWynik.Wiek + "lat, Uzyskany wynik: " + EwithMaxWynik.Suma);

class Employee
{
    private List<int> punktyPracownika = new List<int>();

    public Employee(string imie, string nazwisko, int wiek)
    {
        this.Imie = imie;
        this.Nazwisko = nazwisko;
        this.Wiek = wiek;
    }

    public string Imie { get; private set; }
    public string Nazwisko { get; private set; }
    public int Wiek { get; private set; }

    public int Suma
    {
        get
        {
            return this.punktyPracownika.Sum();
        }
    }

    public void dodajWynik(int punkty)
    {
        this.punktyPracownika.Add(punkty);
    }
}

