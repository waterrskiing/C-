using System;

namespace InheritanceCS89
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Creat new obj objGa */
            ConGa objGa = new ConGa();
            /* objGa with type ConGa now has all properties from both ConGa and Dongvat Class */
            objGa.isMat = true;
            objGa.isChan = true;
            objGa.isCanh = true;
            Console.WriteLine("Con ga co mat = " + objGa.isMat + " co chan = " + objGa.isChan + " co canh = " + objGa.isCanh);
            objGa.TiengKeu();

            Console.WriteLine("-----------------------");

            /* Creat new obj objCho */
            ConCho objCho = new ConCho();
            objCho.isChan = true;
            objCho.isMat = true;
            objCho.isDuoi = true;
            Console.WriteLine("Con cho co mat = " + objCho.isMat + " co chan = " + objCho.isChan + " co duoi = " + objCho.isDuoi);
            objCho.TiengKeu();

            Console.WriteLine("-----------------------");
            /* Using construtor with params */
            ConGa objGa1 = new ConGa(true, true, true);
            Console.WriteLine("Con ga co mat = " + objGa1.isMat + " co chan = " + objGa1.isChan + " co canh = " + objGa1.isCanh);

            Console.WriteLine("-----------------------");
            /* Update lop cha va lop con */
            objGa1.CapNhatLopCon();

            Console.WriteLine("-----------------------");
            /* Practice inherit without A:B */
            Console.WriteLine("Practice inherit HAS-A without A:B");
            MainApp objStd = new MainApp();
            objStd.ThucThi();

            Console.ReadLine();
        }
    }
}
