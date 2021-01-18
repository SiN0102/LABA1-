using System;

namespace ЛабТП1
{
    class Program
    {
        static void Main(string[] args)
        {
            Model.menu _mymenu = new Model.menu();
            foreach (Model.interfacefood menu in _mymenu.MyMenu)
                Console.WriteLine(menu.name + " " + menu.cost + " руб.");
            Console.ReadKey();
        }
    }
}
