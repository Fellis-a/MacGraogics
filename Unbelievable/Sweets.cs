using System;

using AppKit;
using Foundation;

namespace Unbelievable
{
    public class Sweets { }


    public enum ChocolateType {white, milk, bitter};

    public class Chocolate: Sweets
    {
        public int BlocksNumber = 0;
        public ChocolateType typeChoc = ChocolateType.bitter;


    }


    public enum FruitType {mango, banana, avocado};

    public class Fruits:Sweets
    {
        public FruitType typeFruit = FruitType.mango;
        public int Ripeness = 0;
    }


    public enum BakeryType {pie, croissant, bun};
    public class Bakery:Sweets
    {
        public BakeryType typeBakery = BakeryType.bun;
        public int Calorie = 0;

    }

}