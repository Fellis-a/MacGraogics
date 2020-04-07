using System;
using System.Collections.Generic;
using AppKit;
using Foundation;

namespace Unbelievable
{
    public partial class ViewController : NSViewController
    {
        List<Sweets> sweetsList = new List<Sweets>();//создаем очередь из сладостей

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



        partial void btnGet(AppKit.NSButtonCell sender)//кнопка получить товар

        {
            if (this.sweetsList.Count == 0)//если в автомате не осталось товара
            {
                txtGett.StringValue = "Пусто -_-";
                return;
            }

            var fruit = this.sweetsList[0];
            
            this.sweetsList.RemoveAt(0);//убираем элемент из списка
            QueueInfo();
            txtGett.StringValue = fruit.GetInfo();

            ShowInfo();
        }

        partial void btnRefill(AppKit.NSButton sender)//кнопка заполнения автомата
        {
            this.sweetsList.Clear();
            var rnd = new Random();
            for (var i = 0; i < 10; ++i)//количество товаров в автомате 
            {
                switch (rnd.Next() % 3) // генерирую случайное число от 0 до 2 для выдачи 
                {
                    case 0: //если 0, то шоколад
                        this.sweetsList.Add(Chocolate.Generate());
                        break;
                    case 1: // если 1, то фрукт
                        this.sweetsList.Add(Fruits.Generate());
                        break;
                    case 2: // если 2, то выпечка
                        this.sweetsList.Add(Bakery.Generate());
                        break;

                }
            }
            QueueInfo();

            ShowInfo(); // вывод информации о выбранном товаре
        }
        private void QueueInfo()
        {
            var str = "Очередь:\n";
            for (int i = 0; i < sweetsList.Count; i++)
            {
                if (this.sweetsList[i] is Chocolate)
                {
                    str += "Шоколад\n";
                }
             
                else if (this.sweetsList[i] is Fruits)
                {
                    str += "Фрукт\n";
                }
                else if (this.sweetsList[i] is Bakery)
                {
                    str += "Выпечка\n";
                }

            }
            txtQueue.StringValue = str;
        }
        private void ShowInfo()
        {
            // заводим счетчики под каждый тип
            int chocoCount = 0;
            int fruitCount = 0;
            int bakeryCount = 0;


            foreach (var sweet in this.sweetsList)
            {

                if (sweet is Chocolate)
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

            //выводим на форму
            txtInfo.StringValue = "Шоко\tФрукт\tВыпчк";
            txtInfo.StringValue += "\n";

            txtInfo.StringValue += String.Format("{0}\t\t{1}\t\t{2}", chocoCount, fruitCount, bakeryCount);



        }
    }
}
