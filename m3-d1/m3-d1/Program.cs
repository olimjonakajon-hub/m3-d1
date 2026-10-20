




// var n=new List<string>{"apple", "banana"," orange"};


// System.Console.WriteLine(n.Sum(x=>x.Length));
// System.Console.WriteLine(n.Count());
// n.RemoveAt(1);
// System.Console.WriteLine(n.Any(x=>x=="apple"));
//  var a=new List<string> {};
//  a.AddRange(n);
//  n.InsertRange(0,"grape");


// n.RemoveAll(x=>x==n[2]);
// System.Console.WriteLine(n.Any());
// n.Sort();
// // n.Reverse();
// var n=new List<string>{"apple", "banana"," orange"};
// // var n2=new List<string>{ "banana"," orange"};
// // n2.AddRange(n);
// // System.Console.WriteLine(n.IndexOf("apple"));
// // n.RemoveAll(x=>x.Length>5);
// // System.Console.WriteLine(n.Count(x=>x.StartsWith("a")));
// // n.Sort();
// // n.Reverse();
// foreach(var i in n )
// {
//     System.Console.WriteLine(i+" ");
// }




// List<int> ints = new List<int> { 1, 2, 3, 4, 5, };
// int sum = 0;
// foreach (var item in ints)
// {
//     sum +=item;
// }
// System.Console.WriteLine(sum);



// List<string> words = new List<string> { "Hello", "word", "!" };
// string concat = "";
// foreach (var item in words)
// {
//     concat += item;
// }
// System.Console.WriteLine(concat);


// List<DateTime> dates = new List<DateTime>
// {
//     new DateTime(2020, 10, 1),
//     new DateTime(2022, 8, 15),
//     new DateTime(2021, 4, 28)
// };
// dates.Sort();
// System.Console.WriteLine("The sorted dates are:");
// foreach (var item in dates)
// {
//     System.Console.WriteLine( item.ToShortDateString());
// }



// List<double> doubles = new List<double> { 3.5, 2.7, 6.9, 1.9 };
// double average = 0;
// foreach (var item in doubles)
// {
//     average += item;

// }
// average = average / doubles.Count;
//  System.Console.WriteLine(average);


// List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

// List<int> evenNumbers = numbers.FindAll(number => number % 2 == 0);

// Console.WriteLine("The filtered numbers are:");

// foreach (int number in evenNumbers)
// {
//     Console.WriteLine(number);
// }


// List<bool> values = new List<bool> { true, true, true };

// bool allTrue = values.All(value => value == true);

// Console.WriteLine(allTrue);




// List<string> Meva = new List<string> { "Apple", "Banana", "Chery" };
// Meva.Remove("Banana");
// foreach (var item in Meva)
// {
//     System.Console.WriteLine(item);
// }




// List<string> strings = new List<string> { "apple", "Banana", "Cherry" };

// bool Foud = strings.Contains("Banana");
// System.Console.WriteLine(Foud);

// List<int> ints = new List<int>();
// ints.Add(10);
// foreach (var item in ints)
// {
//     System.Console.WriteLine(item);
// }



// List<int> numbers = new List<int>();

// Random random = new Random();

// for (int i = 0; i < 5; i++)
// {
//     numbers.Add(random.Next(1, 101));
// }


// foreach (var number in numbers)
// {
//     Console.WriteLine(number);
// }
