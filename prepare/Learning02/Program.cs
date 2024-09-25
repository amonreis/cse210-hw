using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Missionary Training Center";
        job1._jobTitle = "Instructor";
        job1._startYear = 2022;
        job1._endYear = 2024;

        Job job2 = new Job();
        job2._company = "FamilySearch";
        job2._jobTitle = "Operation Assistant";
        job2._startYear = 2024;
        job2._endYear = 2025;

        Resume myresume = new Resume();
        myresume._name = "Amon Reis";
        
        myresume._jobs.Add(job1);
        myresume._jobs.Add(job2);

        myresume.Display();
        
    }
}