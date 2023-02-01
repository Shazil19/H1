using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace Variable_og_datatyper

{

    internal class Program

    {

        static void Main(string[] args)

        {

            //opgave a



            int length = 16;



            double width = 5.1;



            Console.WriteLine(length * width);



            //opgave b



            int area = length * width;



            //opgave c



            double d = length * width;



            Console.WriteLine(d);



            /* grunden til at du ikke kan bruge datatypen int til "areal" er fordi efter at have ganget 

             double og int sammen er svaret du får i kommatal. Derfor kan du ikke bruge int, 

             fordi den ikke kan indeholde tal med komatal */

        }

    }

}

