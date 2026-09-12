using System.Drawing;
using System.Numerics;
using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment4
{
    internal class Program
    {
        #region method question3
        //static void PrintWelcomeMessage()
        //{
        //    Console.WriteLine("Welcome to the Library");
        //} 
        #endregion

        #region method question4
        //static void PrintBook(string title)
        //{
        //    Console.WriteLine( $"Book title : {title}");
        //}

        #endregion

        #region method question5

        //static void AddBonusPages(int pages )
        //{
        //    pages +=50;
        //    Console.WriteLine( pages );
        //} 
        #endregion

        #region method question6
        //static void ApplyDiscount(double[] prices)
        //{
        //    prices[0] -= 5;
        //}

        #endregion

        #region method question7
        //static void AddBonusPagesByRef(ref int pages)
        //{
        //    pages += 5;
        //} 
        #endregion

        #region method question8
        //static void ReplaceArray(ref double[] prices)
        //{
        //    prices = new double[] { 10.0, 12.5, 15.0 };
        //} 
        #endregion

        // Assignment 5
        #region method question1 
        //bool TryGetPrice(string title, out double price)
        //{
        //    if (title == "Clean Code")
        //    {
        //        price = 25.5;
        //        return true;
        //    }

        //    price = 0;
        //    return false;
        //} 
        #endregion

        #region method question2 and 3
        //static void PrintBookInfo(string title, int pages = 300)
        //{
        //    Console.WriteLine($"{title} = {pages} pages");
        //}
        #endregion

        #region method question 4
        //static  void PrintAllTitles(params string[] titles)
        // {
        //     foreach (var title in titles)
        //     {
        //         Console.WriteLine(title);
        //     }
        // } 
        #endregion

        #region method question 5 and 6 and 7
        //class Book
        //{
        //    private string password = "secret";
        //        internal int copiesInStock = 5;
        //   public string Title;
        //} 
        #endregion








        static void Main(string[] args)
        {
            // Assignment 4

            #region question1
            //1-Create a one-dimensional array double[] prices with the values 25.5, 40.0, 33.75. Print
            //the second price(index 1).

            //double[] price = { 25.5, 40.3, 33.75 };
            //Console.WriteLine($"The second price index 1 is : {price[1]}");

            #endregion

            #region question2
            //2 - Create a 2x2 multidimensional array int[,] shelfCopies where shelf 0 has 3, 5 copies and
            //    shelf 1 has 1, 4 copies.Print the number of copies on shelf 1, slot 0.

            //int[,] shelfCopies = new int[2, 2]
            //{
            //    {3,5 },
            //    {1,4 }
            //};

            //Console.WriteLine( shelfCopies[1,0]);

            #endregion

            #region question3
            //3-Write a method called PrintWelcomeMessage that takes no parameters and prints
            //"Welcome to the Library!".Call it from Main.

            //PrintWelcomeMessage();


            #endregion

            #region question4
            //4-Write a method PrintBookTitle(string title) that prints "Book title: " + title. Call it with
            //"Clean Code".

            //PrintBook("Clean Code");

            #endregion

            #region question5
            //5-Write a method AddBonusPages(int pages) that adds 50 to pages. Call it with a variable
            //int pages = 400; and print pages afterward. What do you expect to see, and why?

            //int pages = 400;
            //AddBonusPages(pages);
            //Console.WriteLine(pages); 
            //I expect to see 400 because the method AddBonusPages takes a copy of the pages variable 
            #endregion

            #region question6
            //6-Write a method ApplyDiscount(double[] prices) that subtracts 5 from prices[0]. Call it
            //with double[] prices = { 25.5, 40.0 }; and print prices[0] afterward.What do you expect to see, and why?

            //double[] prices = { 25.5, 40.0, };
            //ApplyDiscount(prices);
            //Console.WriteLine( prices[0]);

            #endregion

            #region question7
            //7 - Rewrite the method from question 5 as AddBonusPagesByRef(ref int pages) using ref.
            //        Call it and print pages afterward. How is the result different from question 5 ?

            //int pages = 400;
            //AddBonusPagesByRef(ref pages);
            //Console.WriteLine( pages);

            #endregion

            #region question8
            //8 - Write a method ReplaceArray(ref double[] prices) that replaces prices entirely with a
            //new array { 10.0, 12.5, 15.0 }.Call it with your prices array and print prices.Length afterward


            //double[] prices = { 25.5, 40.0, };
            //ReplaceArray(ref prices);
            //Console.WriteLine( prices.Length );


            #endregion



            // Assignment 5

            #region question1 
            // 1 - Write a method bool TryGetPrice(string title, out double price) that returns
            //true and sets price to 25.5 if title is "Clean Code", otherwise returns false and
            //sets price to 0.Call it and print the price if found

            //if (TryGetPrice("Clean Code", out double price))
            //{
            //    Console.WriteLine($"Price: {price}");
            //}
            //else
            //{
            //    Console.WriteLine("Book not found.");
            //}

            #endregion


            #region question2
            //2 - Write a method PrintBookInfo(string title, int pages = 300) where pages is
            //   optional.Call it once with only a title, and once passing both a title and pages.

            //PrintBookInfo("Clean Code");        
            //PrintBookInfo("Clean Code", 464); 
            #endregion


            #region question3
            //3 - Using the PrintBookInfo method from the question above, call it by naming
            //    the parameters, passing pages before title.

            //PrintBookInfo(pages: 500, title: "Clean Code");

            #endregion


            #region question 4
            //4 - Write a method PrintAllTitles(params string[] titles) that prints each title on its
            //       own line. Call it with three book titles.

            //PrintAllTitles("Clean Code", "The Pragmatic Programmer", "Refactoring"); 
            #endregion


            #region question 5
            //Book b = new Book();
            //Console.WriteLine( b.password);
            //compile time error because password is private and cannot be accessed outside the class

            #endregion


            #region question 6
            //2 - Add an internal int copiesInStock = 5; field to Book.Print it from Main.
            //    Does it compile? Why?

            //Book b = new Book();
            //Console.WriteLine(b.copiesInStock);
            //Yes, it compiles because internal members are accessible within the same assembly

            #endregion


            #region question 7
            //3 - Add a public string Title; field to Book.Set it and print it from Main

            //Book b = new Book();
            //b.Title = "Clean Code";          
            //Console.WriteLine(b.Title);       

            #endregion





        }






    }
}
