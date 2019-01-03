using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceCS89
{
    class ConGa : Dongvat //Inherit from class Dongvat
    {
        /* Create its own property isCanh */
        public bool isCanh { get; set; }
        /* Constructor with no params for ConGa class */
        public ConGa()
        {
            Console.WriteLine("Khoi tao doi tuong lop ConGa");
        }
        /* Constructor with params for Conga class */
        public ConGa(bool isChan, bool isMat, bool isCanh) : base(isChan, isMat)
        {
            Console.WriteLine("Khoi tao doi tuong lop ConGa - with params");
            this.isCanh = isCanh;
        }
        /* Create method TiengKeu */
        public void TiengKeu()
        {
            Console.WriteLine("O` o' o");
        }
        /* Create method CapNhatLopCon */
        public void CapNhatLopCon()
        {
            /* To use method from lop cha, use base keyword */
            base.Update();
            Console.WriteLine("Cap nhat lop con");
        }
    }
}
