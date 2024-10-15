using System;

namespace Encapsulation_Record_Tuple
{
    public class Product
    {
        private string _brandName;
        private string _model;
        private int _price;
        private int _cost;
        private int _count;
        public int Income;


        public string BrandName
        {
            get { return _brandName; }
            set
            {
                if (value.Length > 1)
                {
                    _brandName = value;
                }
                else
                {
                    Console.WriteLine("Please enter a valid brand name!");
                }
            }
        }


        public string Model
        {
            get { return _model; }
            set
            {
                if (value.Length > 1)
                {
                    _model = value;
                }
                else
                {
                    Console.WriteLine("Please enter a valid model name!");
                }
            }
        }


        public int Price
        {
            get { return _price; }
            set
            {
                if (value >= 0)
                {
                    _price = value;
                }
                else
                {
                    Console.WriteLine("Please enter a valid price!");
                }
            }
        }


        public int Cost
        {
            get { return _cost; }
            set
            {
                if (value >= 0)
                {
                    _cost = value;
                }
                else
                {
                    Console.WriteLine("Please enter a valid cost!");
                }
            }
        }


        public int Count
        {
            get { return _count; }
            set
            {
                if (value >= 0)
                {
                    _count = value;
                }
                else
                {
                    Console.WriteLine("Please enter a valid count!");
                }
            }
        }

        public Product(string brandName, string model, int price, int cost, int count)
        {
            BrandName = brandName;
            Model = model;
            Price = price;
            Cost = cost;
            Count = count;
            Income = 0;
        }


        public (int count, int income) Sale(int income, int price, int cost, int count, int quantity)
        {
            if (count > 0)
            {
                income = (price - cost) * quantity;
                count -= quantity;
            }
            return (count, income);
        }


        public string IdMaker(string brandName, string model)
        {
            return brandName.Substring(0, 2) + model.Substring(0, 2);
        }


        public void GetInfo()
        {
            Console.WriteLine($"Product: {BrandName} {Model}\nPrice: ${Price}\nCost: ${Cost}\nCount: {Count}");
        }
    }
}



