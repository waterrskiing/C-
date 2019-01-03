using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceCS89
{
    class ConCho : Dongvat
    {
        /* Property */
        public bool isDuoi { get; set; }

        /* Constructor for ConGa class */
        public ConCho()
        {
            Console.WriteLine("Khoi tao doi tuong lop ConCho");
        }
        public void TiengKeu()
        {
            Console.WriteLine("Gau gau gau");
        }
    }
}
