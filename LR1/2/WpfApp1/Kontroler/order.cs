using System;
using System.Collections.Generic;
using System.Text;

namespace ЛабТП1.Kontroler
{
    public class order
    {
        public double end { get; set; }
        public int Time { get; set; }
        public List<bludo> C = new List<bludo>();
        public List<total> D = new List<total>();
        bool ChoseItem(Model.interfacee S, int itogo)
        {
            bludo k = new bludo();
            k.choice = S;
            k.Kolichestvo = itogo;
            C.Add(k);
            return true;
        }
        public bool FinishOrder()
        {
            end = 0;
            foreach (bludo F in C)
            {
                end = F.choice.cost * F.Kolichestvo + end;
            }

            Time = 0;
            foreach (bludo F in C)
            {
                if (F.choice.time > Time)
                {
                    Time = F.choice.time;
                }
            }
            total l = new total();
            l.orderlist = C;
            l.Summe = end;
            l.Time = Time;
            D.Add(l);
            C = new List<bludo>();
            return true;
        }

    }
}


