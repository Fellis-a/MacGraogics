using System;
using System.Collections.Generic;
using AppKit;
using Foundation;

namespace Unbelievable
{
    public partial class ViewController : NSViewController
    {
        List<Sweets> sweetsList = new List<Sweets>();

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Do any additional setup after loading the view.
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }

       

        partial void btnGet(AppKit.NSButtonCell sender)

        {
            
        }

        partial void btnRefill(AppKit.NSButton sender)
        {
            this.sweetsList.Clear();
            var rnd = new Random();
            for (var i = 0; i < 10; ++i)
            {
                switch (rnd.Next() % 3) // генерирую случайное число от 0 до 2 (ну остаток от деления на 3)
                {
                    case 0: // если 0, то мандарин
                        this.sweetsList.Add(new Chocolate());
                        break;
                    case 1: // если 1 то виноград
                        this.sweetsList.Add(new Fruits());
                        break;
                    case 2: // если 2 то арбуз
                        this.sweetsList.Add(new Bakery());
                        break;
                        // появление других чисел маловероятно
                }
            }
            ShowInfo(); // И СЮДА
        }

        private void ShowInfo()
        {
            // заведем счетчики под каждый тип
            int chocoCount = 0;
            int fruitCount = 0;
            int bakeryCount = 0;

            // пройдемся по всему списку
            foreach (var sweet in this.sweetsList)
            {
                // помните, что в списки у нас лежат фрукты,
                // то есть объекты типа Fruit
                // поэтому чтобы проверить какой именно фрукт
                // мы в данный момент обозреваем, мы используем ключевое слово is
                if (sweet is Chocolate) // читается почти как чистый инглиш, "если fruit есть Мандарин"
                {
                    chocoCount += 1;
                }
                else if (sweet is Fruits)
                {
                    fruitCount += 1;
                }
                else if (sweet is Bakery)
                {
                    bakeryCount += 1;
                }
            }

            // а ну и вывести все это надо на форму
            txtInfo.StringValue = "Шоко\tФрукт\tВыпчк"; // буквы экнмлю, чтобы влезло на форму
            txtInfo.StringValue += "\n";

            txtInfo.StringValue += String.Format("{0}\t\t{1}\t\t{2}", chocoCount, fruitCount, bakeryCount);
    
      
            
        }
    }
}
