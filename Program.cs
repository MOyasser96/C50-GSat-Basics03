using System.Drawing;
using System.Text;

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

            //#region Question 2
            //////Question 2: Declare two separate string variables, both set to the literal "Clean Code". Use ReferenceEquals()
            ////to check if they point to the same object in memory.

            //string x = "Clean Code";
            //string y = "Clean Code";

            //Console.WriteLine($"ReferenceEquals(x, y): {ReferenceEquals(x, y)}");



            //#endregion

            //#region Question 3
            //////Question 3: Create a StringBuilder, Append() the text "Book List", then Append() " - Updated" onto the same
            ////object.Print the final result.

            //StringBuilder sb = new StringBuilder();

            //sb.Append("Book List");
            //sb.Append(" - Updated");

            //Console.WriteLine($"Final Result: {sb}");



            //#endregion

            //#region Question 4
            //////Question 4: Using the StringBuilder from the question above, use Replace() to change "Book List" into "Library".
            ////Print the result.

            //StringBuilder sb = new StringBuilder();

            //sb.Append("Book List");
            //sb.Replace("Book List", "Library");
            //Console.WriteLine($"Result: {sb}");

            //#endregion

            //#region Question 5

            ////Question 5: Given string title = "Clean Code"; and int pages = 464;, build the sentence "Book: Clean Code,
            ////Pages: 464" using the + operator.

            //string title = "Clean Code";
            //int pages = 464;
            //string sentence = "Book: " + title + ", Pages: " + pages;

            //Console.WriteLine(sentence);
            //#endregion


            #region Question 6

            //Question 6: Build the same sentence as above, but using string interpolation ($"...").

            string title = "Clean Code";        
            int pages = 464;
            Console.WriteLine($"Book: {title}, Pages: {pages}");

            

            #endregion








        }
    }
}
