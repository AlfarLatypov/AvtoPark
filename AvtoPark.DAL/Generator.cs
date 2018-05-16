using AvtoPark.DAL.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvtoPark.DAL
{
    public class Generator
    {
        /* 1.	Модуль создания машины
           2.	Модуль создания компонента
           3.	Модуль создания проекта
          */

        private Random rand = new Random();

        public bool Gener(ref List<Project> Projects, out string message)
        {
            try
            {
                if (Projects == null)
                    Projects = new List<Project>();

                Projects.Add(new Project() { NameProject = "Варваринский ГОК" });
                Projects[0].Mashines = GenerMashine(out message);

                Projects.Add(new Project() { NameProject = "Карагандинская шахта" });
                Projects[1].Mashines = GenerMashine(out message);

                Projects.Add(new Project() { NameProject = "СС ГОК" });
                Projects[2].Mashines = GenerMashine(out message);

                message = "Проекты добавлены!";

                return true;
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return false;
            }
        }

        private List<Mashine> GenerMashine(out string message)
        {
            List<Mashine> Mashines = new List<Mashine>();
            for (int i = 0; i < 5; i++)
            {
                Mashine mashine = new Mashine();
                mashine.GodVupuska = DateTime.Now.AddMonths((rand.Next(10, 200) * -1));
                mashine.GosNomer = rand.Next(1000, 9999);
                mashine.Model = "Model" + rand.Next(1, 10);
                mashine.TypeMasine = (TypeMasine)rand.Next(1, 3);
                mashine.Components = GenerComponents(out message);
                Mashines.Add(mashine);
            }

            message = "Mashines complete";
            return Mashines;
        }

        private List<Component> GenerComponents(out string message)
        {
            List<Component> components = new List<Component>();

            for (int i = 0; i < 3; i++)
            {
                Component component = new Component();
                component.IdComponent = rand.Next();
                component.nameComponent = (Parts)rand.Next(1, 4);
                components.Add(component);
            }

            message = "Components complete";
            return components;
        }




    }
}
