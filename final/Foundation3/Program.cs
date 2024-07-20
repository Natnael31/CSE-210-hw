using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");
        Console.WriteLine();
        Address a1 = new Address("3 Carlton House Terrace", "London", "Uk", "United Kingdom");
        Address a2 = new Address("615 Channelside Dr", "Tampa", "Florida", "USA");
        Address a3 = new Address("8407 QUINTANA STREET", "NEW CARROLLTON", "MARYLAND", "USA");
        

        Lecture lecture = new Lecture("Hinton Lecture 2024","The challenges in getting to net zero GHG emissions.","09 September 2024", "6.30pm-7.30pm", a1, "Lecture Event", "Professor Steven Chu FREng ", 200);
        Console.WriteLine(lecture.StandardDetails());
        Console.WriteLine();
        Console.WriteLine(lecture.FullDetails());
        Console.WriteLine();
        Console.WriteLine(lecture.ShortDescription());

        Console.WriteLine();

        Reception reception = new Reception("GSOF 10th Anniversary Reception","Help us celebrate 10 years of Global SOF, the professional association for the Special Operations Community!","06 May 2025", "2.00pm-3.30pm", a2, "Reception Event", "natystd21@gmail.com");
        Console.WriteLine(reception.StandardDetails());
        Console.WriteLine();
        Console.WriteLine(reception.FullDetails());
        Console.WriteLine();
        Console.WriteLine(reception.ShortDescription());

        Console.WriteLine();

        OutdoorGathering outdoorGathering = new OutdoorGathering("Cook out","Family gathering and feasting", "11 August 2024", "12.30pm-5.00pm", a3, "Out door Gathering Event", "Sunny day");
        Console.WriteLine(outdoorGathering.StandardDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorGathering.FullDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorGathering.ShortDescription());

    }
}