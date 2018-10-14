using System;
using System.Collections.Generic;

namespace CommandLineSurvey
{
    class Survey
    {

        private string Name { get; set; }
        private int Age {get; set; }
        private string Month {get; set; }
        private string Zodiac { get;}


        public Survey()
        {

        }

        public Survey(string name, int age, string month)
        {

            Name = name;
            Age = age;
            Month = month;
            switch (month.ToLower())
            {
                case "january":
                    Zodiac = "a Capricorn or an Aquarius";
                    break;
                case "february":
                    Zodiac = "an Aquarius or a Pisces";
                    break;
                case "march":
                    Zodiac = "a Pisces or an Aries";
                    break;
                case "april":
                    Zodiac = "an Aries or a Taurus";
                    break;
                case "may":
                    Zodiac = "a Taurus or a Gemini";
                    break;
                case "june":
                    Zodiac = "a Gemini or a Cancer";
                    break;
                case "july":
                    Zodiac = "a Cancer or a Leo";
                    break;
                case "august":
                    Zodiac = "a Leo or a Virgo";
                    break;
                case "september":
                    Zodiac = "a Virgo or a Libra";
                    break;
                case "october":
                    Zodiac = "a Libra or a Scorpio";
                    break;
                case "november":
                    Zodiac = "a Scorpio or a Sagittarius";
                    break;
                case "december":
                    Zodiac = "a Sagittarius or a Capricorn";
                    break;
                default:
                    Zodiac = "\b\b\b\b\b\b\ba liar...";
                    break;

            }
        }
        public void Display()
        {

            Console.WriteLine("Hello, {0}. You are {1} years old and either {2}",Name,Age,Zodiac);

        }
    }
    class Program
    {
        static public event Action Posted;
        static void Main(string[] args)
        {
            Stats stats = new Stats();

            List<Survey> surveyList = new List<Survey>();

            Boolean adding = true;

            while (adding)
            {
                stats.Start();

                string name = Answer("Name:");

                int age = int.Parse(Answer("Age:"));

                string month = Answer("Birth Month:");

                surveyList.Add(new Survey(name, age, month));

                if (Answer("Continue [Y/n]: ").ToLower() != "y")
                {

                    adding = false;

                }

            }

            if(Posted != null)
                Posted();

            foreach (Survey survey in surveyList)
            {
                survey.Display();
            }
        }
        static string Answer(string question)
        {
            Console.WriteLine(question);
            string answer = Console.ReadLine();
            while (answer == "")
            {
                Console.WriteLine("Try Again!");
                answer = Console.ReadLine();
            }
            return answer;
        }
    }
}