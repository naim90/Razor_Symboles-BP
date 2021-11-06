using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Razor.Models
{
    public class Expendidure
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public double Price { get; set; }

        public Expendidure(string name,DateTime date, double price)
        {
            Name = name;
            Date = date;
            Price = price;
        }

    }
}