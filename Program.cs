using System.Drawing;

namespace C50_GSat_Basics03
{
    public class Program
    {
        static void Main(string[] args)
        {
            //#region Question 1
            ////Question 1: Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle. Print
            ////both title and upperTitle to show that title did not change.
            //string title = "clean code";
            //string upperTitle = title.ToUpper();
            //Console.WriteLine($"Title: {title}");
            //Console.WriteLine($"Upper Title: {upperTitle}");

            //#endregion

            #region Question 2
            ////Question 2: Declare two separate string variables, both set to the literal "Clean Code". Use ReferenceEquals()
            //to check if they point to the same object in memory.

            string x = "Clean Code";
            string y = "Clean Code";

            Console.WriteLine($"ReferenceEquals(x, y): {ReferenceEquals(x, y)}");



            #endregion
        }
    }
}
