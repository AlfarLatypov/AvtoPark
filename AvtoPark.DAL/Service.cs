using AvtoPark.DAL.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Поиск машины по его гаражному номеру, модели;*/
namespace AvtoPark.DAL
{
   public class Service
    {
        public Mashine Search(Project project, int GosNomer_)
        {
                                  
            foreach (Mashine item in project.Mashines)
            {
                if (item.GosNomer == GosNomer_) return item;
               
            }
            return null;
        }

        public Mashine Search(Project project, string model)
        {
           foreach (Mashine item in project.Mashines)
            {
                if (item.Model == model) return item;

            }
            return null;
        }
    }
}
