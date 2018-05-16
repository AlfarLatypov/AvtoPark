using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 1.Машина (Модель, Год выпуска, Наименование, 
 * Тип, Гаражный номер)*/

    
namespace AvtoPark.DAL.Modules
{
    public enum TypeMasine {Ecscovator=1, Grader, Traktor}
    public class Mashine
    {
        public string Model { get; set; }
        public DateTime GodVupuska { get; set; }
        public TypeMasine TypeMasine { get; set; }
        public int GosNomer { get; set; }

        public List<Component> Components = new List<Component>();


        public void PrintInfo()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-> {0}\t {1} g.v.", Model, GodVupuska.Year);
            Console.ForegroundColor = ConsoleColor.White;
            foreach (Component item in Components)
            {
                Console.WriteLine("--> {0}", item.nameComponent);
            }
        }

    }
}
