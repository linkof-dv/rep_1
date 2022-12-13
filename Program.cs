using System.Globalization;


namespace Program1
{
    class Programm
    {

        static void Main()

        { 
           string data;
            Console.WriteLine("Ввести чмсло");

           data= Console.ReadLine();

            //string n = "a";

            //NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            //{
            //NumberDecimalSeparator=".",
            //};    
                //double a = double.Parse(data, numberFormatInfo);
           
            
                //data = "1";
            try
            {
                int a = int.Parse(data);
                // a= Convert.ToDouble(n);  

                Console.WriteLine('1');
            }
            catch(Exception)
            
            {
                Console.WriteLine("ошибка");
            }

        }

    }


}

