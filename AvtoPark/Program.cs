using AvtoPark.DAL;
using AvtoPark.DAL.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Функционал:
1.	Отображение всего парка машина по проектам;
2.	Поиск машины по его гаражному номеру, модели;
3.	Из результатов поиска должна быть возможность, создать останов для машины;
4.	Для любой машины должна быть возможность прикрепить компонент, при условии, что у данной машину уже не стоит данный компонент, в случае если он стоит выдать соответствующее сообщение;
5.	Для машины должна быть возможность установить статус Активна/Неактивная;
*/

namespace AvtoPark
{
    class Program
    {
        static void Main(string[] args)
        {
            Generator generator = new Generator();
            List<Project> projects = null;
            string message;

            if (!generator.Gener(ref projects, out message))
            {
                Console.WriteLine(message);
                return;
            }

            foreach (Project item in projects)
            {
                item.PrintInfo();
            }

            Console.WriteLine("Выберите проект: ");
            foreach (var item in projects)
                Console.WriteLine(" - " + item.NameProject);

            Project temp = null;
            do
            {
                //спрашиваем
                Console.Write("-> ");
                string name = Console.ReadLine();
                //ищем
                temp = projects.FirstOrDefault(o => o.NameProject.ToLower() == name.ToLower()); //регистронезависимые
                //проверяем
                if (temp != null)
                    break;
                //если не нашли
                Console.WriteLine("Проект не найден!");
            }//пока не нашли
            while (temp == null);

            Console.WriteLine("Выберите критерии поиска : 1 - гаражный номер, 2 - модель");

            int choice = 0;
            do
            {
                Console.Write("-> ");
                Int32.TryParse(Console.ReadLine(), out choice);

            } while (choice != 1 && choice != 2);

            int gosNomer = 0;
            string modelMasine = "";
            Service service = new Service();

            Mashine findeMashine = null;
            switch (choice)
            {
                case 1:
                    {
                        Console.Write("Введите гос номер машины -> ");
                        Int32.TryParse(Console.ReadLine(), out gosNomer);
                        findeMashine = service.Search(temp, gosNomer);
                    }
                    break;

                case 2:
                    {
                        Console.Write("Введите модель машины -> ");
                        findeMashine = service.Search(temp, Console.ReadLine());
                        
                    }
                    break;
            }

            if (findeMashine == null)
                Console.WriteLine("Машина не найдена");
            else
                findeMashine.PrintInfo();
       //     ---------------------------------------------------


        }
    }
}
