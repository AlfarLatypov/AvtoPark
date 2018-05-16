using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*2.Компонент (Наименование, код компонента) 
 * (пример. Двигатель, КП, Трансмиссия)*/
namespace AvtoPark.DAL.Modules
{
    public enum Parts {Engine = 1, KPP, Transmission }
   public class Component
    {
        //Наименование
        public Parts nameComponent { get; set; }
        //код компонента
        public int IdComponent { get; set; }

       
    }
}
