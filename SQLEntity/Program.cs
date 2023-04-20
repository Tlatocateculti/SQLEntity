// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Microsoft.EntityFrameworkCore;
using SQLEntity.Model;

DbContextOptionsBuilder dbContextOptionsBuilder = new DbContextOptionsBuilder<Zajecia3p>();
dbContextOptionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\admin\\Documents\\zajecia3p2.mdf;Integrated Security=True;Connect Timeout=30");

Zajecia3p baza = new(dbContextOptionsBuilder.Options);

var osoba = new Osoba() { Imie = "Marianna", Nazwisko = "Kwiatkowska", PESEL = "88888888888" };
baza.Osoby.Add(osoba);
var osoba2 = new Osoba() { Imie = "Hieronim", Nazwisko = "Kwiatkowski", PESEL = "88888888888" };
baza.Osoby.Add(osoba2);
baza.SaveChanges();

var zapytanie = from os in baza.Osoby
                where os.Imie == "Marianna"
                select os;

foreach(var p in zapytanie)
{
    Console.WriteLine(p);
}

//zapytanie.FirstOrDefault();