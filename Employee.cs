using System;

namespace employees {

public class Employee {
    public Employee(string first, string last, string titleP, DateTime start) {
        firstname = first;
        lastname = last;
        title = titleP;
        startdate = start;
    }
    public string firstname {get; set;}
    public string lastname {get; set;}
    public string title {get; set;}

    public DateTime startdate {get; set;}

    public void Print() {
        Console.WriteLine($"Employee Name: {firstname} {lastname}");
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Start Date: {startdate}");
        Console.WriteLine("------------------");
    }

}

}