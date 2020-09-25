using System;
namespace HelloWorld
{
    public class Var_Const
    {
        public Var_Const()
        {
            
        }

        static void Main(string[] args)
        {
            // Neu ma ep kieu ma gia tri khong nam trong range do, thi system se generate
            // mot so ngau nhien va in ra ket qua cho ta
            int iNumber = 2;
            // Error, ide requests to explicitly(ep kieu) transfer from big to small value 
            byte bNumber = (byte)iNumber;
            byte cNumber = Convert.ToByte(iNumber);

            // Ep tu string sang int
            // Convert.ToGiDo
            string sNumber = "200";
            int hNumber = Convert.ToInt32(sNumber);

            // Parse string to int
            // KieuDULIEU.Parse
            string strNumber = "22.2";
            float fNumber = float.Parse(strNumber);

            string nullVal = null;
            int intNumber = Convert.ToInt32(nullVal);

            Console.WriteLine(fNumber);
            Console.WriteLine(intNumber);

            Console.WriteLine("Input a number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(number);
            Console.ReadLine();
        }
    }
}
