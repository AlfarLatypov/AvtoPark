using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*3.	Проект (Наименование) 
 (пример. Варваринский ГОК, Карагандинская шахта, СС ГОК)*/
namespace AvtoPark.DAL.Modules
{

  public class Project
    {
        public string NameProject { get; set; }
        public List<Mashine> Mashines = new List<Mashine>();


        public void PrintInfo()
        {
            Console.WriteLine("Project : {0}", NameProject);

            foreach (Mashine item in Mashines)
            {
                Console.WriteLine("----------------------");
                item.PrintInfo();
            }
        }
        
    }
}
