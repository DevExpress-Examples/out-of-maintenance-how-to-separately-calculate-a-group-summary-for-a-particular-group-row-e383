using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace summary
{
    public static class CarList
    {
        public static BindingList<Car> GetList()
        {
            var list = new BindingList<Car>();
            list.Add(new Car() { ID = 1, Trademark = "Mercedes-Benz", Model = "SL500 Roadster", HP = 302, Liter = 4.966 });
            list.Add(new Car() { ID = 2, Trademark = "Mercedes-Benz", Model = "CLK55 AMG Cabriolet", HP = 342, Liter = 5.439 });
            list.Add(new Car() { ID = 3, Trademark = "Mercedes-Benz", Model = "C230 Kompressor Sport Coupe", HP = 189, Liter = 1.796 });
            list.Add(new Car() { ID = 4, Trademark = "BMW", Model = "530i", HP = 225, Liter = 3 });
            list.Add(new Car() { ID = 5, Trademark = "Rolls-Royce", Model = "Corniche", HP = 325, Liter = 6.75 });
            list.Add(new Car() { ID = 6, Trademark = "Jaguar", Model = "S-Type 3.0", HP = 235, Liter = 3 });
            list.Add(new Car() { ID = 7, Trademark = "Cadillac", Model = "Seville", HP = 275, Liter = 4.6 });
            list.Add(new Car() { ID = 8, Trademark = "Cadillac", Model = "DeVille", HP = 275, Liter = 4.6 });
            list.Add(new Car() { ID = 9, Trademark = "Lexus", Model = "LS430", HP = 290, Liter = 4.3 });
            list.Add(new Car() { ID = 10, Trademark = "Lexus", Model = "GS 430", HP = 300, Liter = 4.3 });
            list.Add(new Car() { ID = 11, Trademark = "Ford", Model = "Ranger FX-4", HP = 135, Liter = 2.3 });
            list.Add(new Car() { ID = 12, Trademark = "Dodge", Model = "Ram 1500", HP = 215, Liter = 3.7 });
            list.Add(new Car() { ID = 13, Trademark = "GMC", Model = "Siera Quadrasteer", HP = 200, Liter = 4.3 });
            list.Add(new Car() { ID = 14, Trademark = "Nissan", Model = "Crew Cab SE", HP = 143, Liter = 2.4 });
            list.Add(new Car() { ID = 15, Trademark = "Toyota", Model = "Tacoma S-Runner", HP = 190, Liter = 3.4 });
            return list;
        }
    }
    public class Car
    {
        public int ID { get; set; }
        public string Trademark { get; set; }
        public string Model { get; set; }
        public Int16 HP { get; set; }
        public double Liter { get; set; }
    }
}
