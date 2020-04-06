using System;

using AppKit;
using Foundation;

namespace Unbelievable
{
    public class Sweets
    {
        //рандом для дальнейшего использованя
        protected static Random rnd = new Random();


        public virtual String GetInfo()
        {

            return "Я сладость";//не я
        }
        //общих своств нет, поэтому больше здесь нечего прписывать
    }


    public class Chocolate : Sweets
    {
        public int BlocksNumber = 0;
        public string ChocType = "";
        public static string[] ChocolatesType = {
            "Горький",
            "Молочный",
            "Белый",
           };
        public bool ChocolateFilling = false;

        public override String GetInfo()
        {

            var str = "Я шоколад";

            str += String.Format("\nКоличество плиток: {0}", this.BlocksNumber);
            str += String.Format("\nНачинка: {0}", this.ChocolateFilling ? "с начинкой" : "без начинки");
            str += String.Format("\nТип шоколада: {0}", this.ChocType);
            return str;
        }
        //задаем параметры при создании объекта
        public static Chocolate Generate()
        {

            return new Chocolate
            {
                BlocksNumber = 1 + rnd.Next() % 10,  // количество плиток от 1 до 10
                ChocType = ChocolatesType[rnd.Next(0, ChocolatesType.Length)],//тип шоколада
                ChocolateFilling = rnd.Next() % 2 == 0//есть или нет начинки

            };
        }

    }



    public class Fruits : Sweets
    {

        public int Ripeness = 0;
        public string Fruit = "";
        public static string[] FruitsType = {
            "Манго",
            "Авокадо",
            "Персик",
           };

        public override String GetInfo()
        {
            var str = "Я фрукт";
            str += String.Format("\nСпелость: {0}", this.Ripeness);
            str += String.Format("\nТип фрукта: {0}", this.Fruit);
            return str;
        }

        public static Fruits Generate()
        {

            return new Fruits
            {
                Ripeness = rnd.Next() % 101, // спелость от 0 до 100
                Fruit = FruitsType[rnd.Next(0, FruitsType.Length)],//тип фрукта

            };
        }
    }



    public class Bakery : Sweets
    {
        public int Calorie = 0;
        public string BakeryType = "";
        public static string[] BakeryTypes = {
            "Пирог",
            "Круассан",
            "Булочка",
           };


        public override String GetInfo()
        {

            var str = "Я выпечка";
            str += String.Format("\nКалорийность: {0}", this.Calorie);
            str += String.Format("\nТип выпечки: {0}", this.BakeryType);
            return str;
        }
        public static Bakery Generate()
        {

            return new Bakery
            {
                Calorie = 0 + rnd.Next() % 1000,  // калорийность от 0 до 1000
                BakeryType = BakeryTypes[rnd.Next(0, BakeryTypes.Length)]//тип выпечки

            };
        }
    }

}