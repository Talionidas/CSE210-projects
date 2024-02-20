using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("Peterspl. 1", "Basel", "Basel Stadt", "Schweiz");

        Lecture lecture = new Lecture("Die Schweiz in der Lupe'", "Eine generaue Dokumentation der Schweizer Bürger", "October 24, 2024", "7 AM", address, "Matthias Geering", 140);
        Console.WriteLine();

        Console.WriteLine("Event Number: 1");
        Console.WriteLine();
        Console.WriteLine(lecture.GenerateStandard());

        Console.WriteLine();
        Console.WriteLine(lecture.GenerateDetailedLecture());

        Console.WriteLine();
        Console.WriteLine(lecture.GenerateShortLecture());

        Address addressR = new Address("Rämistrasse 71", "Zürich", "Zürich", "Schweiz");

        Reception reception = new Reception("The Chilean approach!", "Unsheltered Thoughts: The Chilean approach to the regulatory challenges of neurotechnological mindreading", "February 21, 2024", "1:30 PM", addressR, "Uni-events@Zürich.ch");
        Console.WriteLine();

        Console.WriteLine("Event Number: 2");
        Console.WriteLine();
        Console.WriteLine(reception.GenerateStandard());

        Console.WriteLine();
        Console.WriteLine(reception.GenerateDetailedReception());

        Console.WriteLine();
        Console.WriteLine(reception.GenerateShortReception());

        Address addressOG = new Address("Dufourstrasse 50", "St. Gallen", "St. Gallen", "Schweiz");

        OutdoorGathering outdoorGathering = new OutdoorGathering("Geschichte / Militärgeschichte", "Die Schweiz im Krieg", "February 20, 2024", "9:30 PM", addressOG, "cloudy");
        Console.WriteLine();

        Console.WriteLine("Event Number: 3");

        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GenerateStandard());

        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GenerateDetailedOutdoorGathering());

        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GenerateShortOutdoorGathering());
    }
}