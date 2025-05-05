// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//String in C#
//string firstFriend = "Maria";
//string secondFriend = "Sage";

//Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");
//Console.WriteLine("My friend is " + firstFriend + " and " + secondFriend);

//ring firstFriend = "            Maria         ";
//rstFriend = firstFriend.TrimStart();
//rstFriend = firstFriend.Trim();
//string secondFriend = "    Sage          ";
//Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");
//Console.WriteLine($"My friends are {firstFriend} and {secondFriend.Trim()}");

//string firstFriend = "Maria";
//firstFriend =firstFriend.Trim();
//string secondFriend = "Scott";
//string friends = $"My friends are {firstFriend} and {secondFriend.Trim()}";

//Console.WriteLine(friends);

//friends.Contains("Scott","Pants");

//Console.WriteLine(friends.Contains("Scott"));

//friends = friends.Replace("Scott","Damian");

//Console.WriteLine(friends.Replace("Scott","Damian"));

//Console.WriteLine(friends);

//Console.WriteLine(friends.ToUpper());
//Console.WriteLine(friends);
//Console.WriteLine(friends.Length);

//Console.WriteLine(friends.StartsWith("My "));

//Console.WriteLine("Hello, World!");string firstFriend = "Maria";firstFriend =firstFriend.Trim();string secondFriend = "Scott";string friends = $"My friends are {firstFriend} and {secondFriend.Trim()}";Console.WriteLine(friends.StartsWith("My "));

//Numbers in C#
//int a = 18;
//int b = 6;
//int c = a+b;
//Console.WriteLine(c);


//int a = 1800000000;
//int b = 6;
//int c = a+b;
//Console.WriteLine(c);

//int a = 2100000000;
//int b = 2100000000;
//int c = a+b;
//Console.WriteLine(c);

//int a = 2100000000;
//int b = 2100000000;
//long c = a+b;
//Console.WriteLine(c);

//int a = 2100000000;
//int b = 2100000000;
//long c = (long)a + (long)b;
//Console.WriteLine(c);

//int a = 2100000000;
//int b = 2100000000;
//long c = checked(a+b);
//Console.WriteLine(c);

//int a = 42.1;
//int b = 38.2;
//long c = a+b;
//Console.WriteLine(c);

//int a = (int)42.1;
//int b = (int)38.2;
//long c = checked(a+b);
//Console.WriteLine(c);

//double a=42.1; //natural type
//float b=38.2F; 
//double c= a+b;
//Console.WriteLine(c);

//decimal a=42.1M; // explicit type
//decimal b=38.2M;
//decimal c= a+b;
//Console.WriteLine("The answer is {c}");
//Console.WriteLine($"The answer is {c}");

// Branches and loops in C#
//bool myTest=c>10; //will be true or false
//if(myTest) //is true
//int a=5;
//int b=3;
//if (a+b>10){
    //Console.WriteLine("The answer is greater than 10.");
//}
//otherwise
//else{
    //Console.WriteLine("The answer is less than 10.");
//}

//int a = 5;
//int b = 3;
//int c = 4;
//if ((a + b + c > 10) && (a == b))
//{
    //Console.WriteLine("The answer is greater than 10.");
    //Console.WriteLine("And the first number is equal to the second.");
//}
//else
//{
    //Console.WriteLine("The answer is greater than 10.");
    //Console.WriteLine("Or the first number is equal to the second.");
//}

//int a = 5;
//int b = 3;
//int c = 4;
//if ((a + b + c > 10) || (a == b))
//{
    //Console.WriteLine("The answer is greater than 10.");
    //Console.WriteLine("And the first number is equal to the second.");
//}
//else
//{
    //Console.WriteLine("The answer is greater than 10.");
    //Console.WriteLine("Or the first number is equal to the second.");
//}

using System.Net.Http.Headers;

//int counter=0;
//counter=counter+1;
//Console.WriteLine(counter);
//counter=counter+1;
//Console.WriteLine(counter);
//counter=counter+1;
//Console.WriteLine(counter);
//counter=counter+1;
//Console.WriteLine(counter);

//int counter=0;
//while(counter<5)
//{
    //counter++;
    //Console.WriteLine(counter);
//}

//int counter=0;
//while(counter<5)
//{
    //Console.WriteLine(counter);
    //counter++;
//}

//int counter=0;
//while(true)
//{
    //Console.WriteLine(counter);
    //counter++;
//}

//int counter=0;
//do
//{
    //Console.WriteLine(counter);
    //counter++;
//}
//while(counter<5);

//int counter=10;
//do
//{
    //Console.WriteLine(counter);
    //counter++;
//}
//while(counter<5);

//Loops in C#

//for (
    //int i = 0; // setup/initialize (start)
    //i < 5; //conditional
    //i++) //iteration(increment)
//{
    //Console.WriteLine(i);
    //DO THE THING
//}

//int counter=0;
//do
//{
    //Console.WriteLine(counter);
    //counter++;
//}
//while (counter<5);

//for (int i = 0; i < 5; i++)
//{
    //if(i==3)
    //{
        //Console.WriteLine(i);
    //}
//}

//for (int row = 1; row < 11; row++)
//{
    //for(char column= 'a'; column< 'k'; column++)
    //{
        //Console.WriteLine($"The cell is ({row}, {column})");
    //}
//}

//var name ="Scott";

//var names= new List<string> {"Scott","Ana","Felipe"};
//foreach (var name in names)
//{
    //Console.WriteLine($"Hello{name.ToUpper()}!");
//}

//var names= new List<string> {"Scott","Ana","Felipe"};

//for (int i = 0; i < names.Count; i++)
//{
    //Console.WriteLine($"Hello {names[i].ToUpper()}!");
//}
//foreach (var name in names)
//{
    //Console.WriteLine($"Hello {name.ToUpper()}!");
//}

//foreach (var i in names)
//{
    //Console.WriteLine($"Hello {i.ToUpper()}!");
//}

//var names= new List<string> {"Scott","Ana","Felipe"};
//names.Add("David");
//names.Add("Damian");
//names.Add("Maria");
//foreach (var name in names)
//{
    //Console.WriteLine($"Hello {name.ToUpper()}!");
//}

// var names= new List<string> {"Scott","Ana","Felipe"};
// names.Add("David");
// names.Add("Damian");
// names.Add("Maria");
// foreach (var name in names)
// foreach (var name in names[2..4])
// {
//     Console.WriteLine($"Hello {name.ToUpper()}!");
// }
// Console.WriteLine(names[0]);
// Console.WriteLine(names[2]);
// Console.WriteLine(names[6]);
// Console.WriteLine(names[^1]); // 1 from the back
// Console.WriteLine(names[^2]);

// var names= new string[] {"Scott","Ana","Felipe"};

// names.Add("Damian");//Lıst<T>

// names=[.. names,"Damian"];
// foreach (var name in names)
// {
//     Console.WriteLine($"Hello {name.ToUpper()}!");
// }
// arrays are fixed in length

// var names= new List<string> {"Scott","Ana","Felipe"};

// names.Sort();

// names=[.. names,"Damian"];
// foreach (var name in names)
// {
//     Console.WriteLine($"{name}!");
// }

// var numbers= new List<int> {45,56,99,48,67,78};

// Console.WriteLine($" I found 99 at index {numbers.IndexOf(99)}");
// numbers.Sort();
// Console.WriteLine($" I found 99 at index {numbers.IndexOf(99)}");

// names=[.. names,"Damian"];
// foreach (var number in numbers)
// {
//     Console.WriteLine($"{number}");
// }

// Overview of LINQ
// Specify the data source.

// int[] scores=[97,92,81,60];
// var scores=new List<int>{97,92,81,60};
// List<int>scores=[97,92,81,60];
// List<int>scores=[3,45,100,97,92,81,60];
// List<int>scores=[3,45,82,97,92,100,81,60];


// for (int i = 0; i < scores.Count; i++)
// {
//     if(scores[i]>80)
//     {
//         Console.WriteLine($"found a score over a 80 {scores[i]}");
//     }
// }

// Define the query expression.
// IEnumerable<int> scoreQuery=
//     from score in scores
//     where score>80
//     orderby score descending
//     select score;

// //Execute the query.
// foreach(int i in scoreQuery)
// {
//     Console.WriteLine(i+" ");
// }

// for string

// IEnumerable<string> scoreQuery=
//     from score in scores
//     where score>80
//     orderby score descending
//     select  $" The score is {score}";


// //Execute the query.
// foreach(string i in scoreQuery)
// {
//     Console.WriteLine;
// }

// IEnumerable<int> scoreQuery= //query variable
//     from score in scores //required
//     where score>80 // optional
//     orderby score descending // optional
//     select score; // must end with select or group


// Console.WriteLine(scoreQuery.Count());
// int scoreCount =highScoresQuery3.Count(); //the answer

// var scoreQuery=scores.Where(s=>s>80).
//              OrderByDescending(s=>s);



// List<int> myScores= scoreQuery.ToList();

// foreach (var score in myScores)
// {
//     Console.WriteLine(score);
// }
// List<string> myScores= scoreQuery.ToList();

// Execute the query.
// foreach(string s in scoreQuery)
// {
//     Console.WriteLine(s);
// }

//OBJECT ORIENTED PROGRAMMING

// using System;

// namespace MyNamespace
// {
//     public class MyApp{
//         public static void Main()
//         {
//             Console.WriteLine("hello");
//         }
        
//     }
// }

Console.WriteLine("hello oop");

var p1=new Person("Scott","Hanselman",new DateOnly(1970,1,1));
var p2=new Person("David","Fowler",new DateOnly(1970,1,1));

p1.Pets.Add(new Dog("Fred"));
p1.Pets.Add(new Dog("Barney"));

p2.Pets.Add(new Cat("Beyonce"));



// public class Person
// {
    
//     public Person(string first,string last,DateOnly bd)
//     {
//         firstname=first;
//         lastname=last;
//         birthday=bd;
//     }
    
//     public string firstname;

//     public string lastname;

//     public DateOnly birthday;
// }

//DateTime can be use for DateOnly
List<Person> people = [p1,p2];


foreach (var person in people)
{
    Console.WriteLine($"{person}");

    foreach(var pet in person.Pets)
    {
        Console.WriteLine($"       {pet}");
    }
}

Console.WriteLine(people.Count);

public class Person(string firstname, string lastname, DateOnly birthday)
{
    public string First{get;}=firstname;

    public string Last{get;}= lastname;

    public DateOnly Birthday{get;}=birthday;

    public List<Pet> Pets{get;}=new();

    public override string ToString()
    {
        return $"Human {First} {Last}";
    }

}

public abstract class Pet(string firstname)
{
    public string First{get;}=firstname;

    public abstract string MakeNoise();

    public override string ToString()
    {
        return $"{First} and I am a  {GetType().Name} and I {MakeNoise()}";
    }
}


public class Cat(string firstname):Pet(firstname)
{
    public override string MakeNoise() => "meow";
}

public class Dog(string firstname):Pet(firstname)
{
    public override string MakeNoise() => "bark";
}