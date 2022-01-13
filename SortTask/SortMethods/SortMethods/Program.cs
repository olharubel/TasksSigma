using System;
using System.Collections.Generic;

namespace SortMethods
{
    public class Product: IComparable<Product>
    {
        public string Name { set; get; }
        public double Price { set; get; }
        public double Weight { set; get; }

        public Product(string name, double price, double weight)
        {
            Name = name;
            Price = price;
            Weight = weight;
        }

        public override string ToString()
        {
            return $"{Name}, {Price}, {Weight}";
        }

        public int CompareTo(Product other)
        {
            if (this.Name.CompareTo(other.Name) != 0)
            {
                return this.Name.CompareTo(other.Name);
            }
            else if (this.Price.CompareTo(other.Price) != 0)
            {
                return this.Price.CompareTo(other.Price);
            }
            else if (this.Weight.CompareTo(other.Weight) != 0)
            {
                return this.Weight.CompareTo(other.Weight);
            }
            else
            {
                return 0;
            }
        }
    }

    public class ProductComp : Comparer<Product>
    {
        public override int Compare(Product x, Product y)
        {
            if (x.Name.CompareTo(y.Name) != 0)
            {
                return x.Name.CompareTo(y.Name);
            }
            else if (x.Price.CompareTo(y.Price) != 0)
            {
                return x.Price.CompareTo(y.Price);
            }
            else if (x.Weight.CompareTo(y.Weight) != 0)
            {
                return x.Weight.CompareTo(y.Weight);
            }
            else
            {
                return 0;
            }
        }
    }

    static class Sorter
    {
  

        public static void QuickSort<T, R>(T[] a, Comparer<T> compare, int start, int end, Func<T, R> selector)
        {
            int i = start, j = end;
            T tmp;
            T pivot = a[(start + end) / 2];

            while (i <= j)
            {
                while (compare.Compare(a[i], pivot) < 0)
                    i++;
                while (compare.Compare(a[j], pivot) > 0)
                    j--;
                if (i <= j)
                {
                    tmp = a[i];
                    a[i] = a[j];
                    a[j] = tmp;
                    i++;
                    j--;
                }
            };

           
            if (start < j)
                QuickSort(a, compare, start, j, selector);
            if (i < end)
                QuickSort(a, compare, i, end, selector);
        }
    }
    

    class MainClass
    {
        public static void Main(string[] args)
        {
            Product[] product = new Product[4];
            product[1] = new Product("Candy", 128, 1);
            product[0] = new Product("Milk", 30.5, 0.9);
            
            product[2] = new Product("Cheese", 56.4, 0.35);
            product[3] = new Product("Ice-cream", 56.4, 0.35);


            Sorter.QuickSort(product, new ProductComp(), 0, 3, (x => x.Name));

            foreach (var item in product)
            {
                Console.WriteLine(item.ToString());
            }

        }
    }
}
