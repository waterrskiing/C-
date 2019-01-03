using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceCS89
{
    class Dongvat
    {
        /* Create public properties, remember to use prop + hold tab */
        public bool isChan { get; set; }
        public bool isMat { get; set; }
        /* Constructor without params for DongVat class */
        public Dongvat()
        {
            Console.WriteLine("Khoi tao doi tuong lop Dongvat - first");
        }
        /* Constructor with params for class Dongvat */
        public Dongvat(bool isChan, bool isMat)
        {
            Console.WriteLine("Khoi tao doi tuong lop Dongvat - with PARAMS");
            this.isChan = isChan;
            this.isMat = isMat;
        }
        /* Public method in Dongvat class */
        public void Update()
        {
            Console.WriteLine("Cap nhat thanh cong lop cha");
        }
    }
}
