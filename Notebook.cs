using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Notebook
    {
        
        protected string title; // Название
        protected int k; // Количество листов

        
        public Notebook(string title, int numberOfSheets)
        {
            this.title = title;
            this.k = numberOfSheets;
        }

        
        public void DisplayInformation()
        {
            Console.WriteLine($"заголовок: {title}");
            Console.WriteLine($"кол во листов: {k}");
        }

       
        public double CalculateCost()
        {
            return 15 * k;
        }
    }

    class CommonNotebook : Notebook
    {
        
        private string coverMaterial; // Материал обложки

        
        public CommonNotebook(string title, int numberOfSheets, string coverMaterial)
            : base(title, numberOfSheets)
        {
            this.coverMaterial = coverMaterial;
        }

        
        public void DisplayInformationAboutChild()
        {
            DisplayInformation();
            Console.WriteLine($"материал покрытия: {coverMaterial}");
        }

        
        public new double CalculateCost()
        {
            return base.CalculateCost() + 50;
        }
    }

}

