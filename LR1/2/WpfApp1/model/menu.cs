using System;
using System.Collections.Generic;
using System.Text;

namespace ЛабТП1.Model
{
    public class menu
    {
        public List<interfacee> Menu = new List<interfacee>();

        public menu()
        {
            interfacee cake = new desert("пудинг", 300, 200, 15, 250);
            interfacee icecream = new desert("сорбет", 300, 100, 5, 100);
            interfacee pie = new desert("тирамису", 350, 250, 20, 250);
            interfacee chocolate = new desert("белый шоколад", 100, 50, 5, 100);

            interfacee juice = new drink("сок", 150, 40, 10, 200);
            interfacee tea = new drink("чай", 100, 40, 10, 200);
            interfacee coffe = new drink("кофе", 200, 40, 10, 200);
            interfacee latte = new drink("латте", 200, 40, 10, 200);

            interfacee ceasar = new salat("цезарь", 360, 200, 15, 250);
            interfacee light = new salat("легкий", 300, 200, 15, 250);
            interfacee olivier = new salat("оливье", 300, 200, 15, 250);
            interfacee hot = new salat("горячий салат", 300, 200, 15, 250);

            interfacee kanape = new coldsnack("канапе", 150, 40, 10, 200);
            interfacee pashtet = new coldsnack("паштет", 200, 40, 10, 200);
            interfacee cheese = new coldsnack("сырные шарики", 90, 40, 10, 200);
            interfacee meet = new coldsnack("мясной рулет", 300, 200, 10, 200);

            Menu.Add(cake);
            Menu.Add(icecream);
            Menu.Add(pie);
            Menu.Add(chocolate);
            Menu.Add(coffe);
            Menu.Add(tea);
            Menu.Add(juice);
            Menu.Add(latte);
            Menu.Add(ceasar);
            Menu.Add(light);
            Menu.Add(olivier);
            Menu.Add(hot);
            Menu.Add(kanape);
            Menu.Add(pashtet);
            Menu.Add(cheese);
            Menu.Add(meet);
        }
    }
}
