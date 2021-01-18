using System;
using System.Collections.Generic;
using System.Text;

namespace ЛабТП1.Model
{
   public class desert : interfacee
    {
        string _name;
        double _cost, _cost1;
        int _time, _weight;
        public desert (string name, double cost, double cost1, int time, int weight)
        {
            _name = name;
            _cost = cost;
            _cost1 = cost1;
            _time = time;
            _weight = weight;
        }
        public string name { get => _name; set => _name = value; }
        public double cost { get => _cost; set => _cost = value; }
        public double cost1 { get => _cost1; set => _cost1 = value; }
        public int time { get => _time; set => _time = value; }
        public int weight { get => _weight; set => _weight = value; }
    }
}
