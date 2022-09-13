using System;

namespace SRP
{

    class Program
    {
        static void Main()
        {
            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034");
            Book book2 = new Book("Pro C#","Troelsen","001-035");
            //Como hicimos una nueva clase con un nuevo constructor, el codigo anterior para "ShelveBook" no funciona, entonces ingresamos el siguiente:
            ShelveBook Shelve1 = new ShelveBook("A", "7");
            ShelveBook Shelve2 = new ShelveBook("B", "3");

            /*book1.ShelveBook("A","7");
            book2.ShelveBook("B","3");*/

        }
    }
}