using System;
using System.Data;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;
using System.Linq;
using System.Text;
using System.Globalization;


namespace csqlite
{
    class Product
    {
        private int id;
        public string Name { get; set; }
        public double Price { get; set; }
        public double Weight { get; set; }
        public DateTime CreatDate { get; set; }
        public int ExpDate { get; set; }

        public Product(string name, double price, double weight, DateTime creatTime)
        {
            Name = name;
            Price = price;
            Weight = weight;
            CreatDate = creatTime;
        }

        public Product() { }


        public static Product Create(IDataRecord data)
        {
            return new Product(data["NAME"].ToString(), Convert.ToDouble(data["PRICE"]), Convert.ToDouble(data["WEIGHT"]),
              DateTime.ParseExact(data["CREAT_DATE"].ToString(), "dd.MM.yyyy", CultureInfo.InvariantCulture));
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Name: {Name}, price: {Price}, weight: {Weight}\n");
            return sb.ToString();
        }


    }

    static class DBHelper
    {
        public static List<Product> GetProductsList(this Db db)
        {
            return db.GetList<Product>("select * from PRODUCT", Product.Create);
        }

        public static Product GetProductByPrice(this Db db, double price)
        {
            return db.GetList($"select * from PRODUCT where PRICE like '{price}%' limit 1", Product.Create).FirstOrDefault();
        }

        public static Product GetProductByName(this Db db, string name)
        {
            return db.GetList<Product>($"select NAME, PRICE, WEIGHT, CREAT_DATE from PRODUCT where NAME like '{name}%' limit 1 ", Product.Create).FirstOrDefault();
        }
    }

    class Db
    {
        public SqliteConnection connection;
        public Db() { }
        public Db(string connectionString)
        {
            connection = new SqliteConnection(connectionString);
            connection.Open();
        }

        public void ExecuteSQL(string sql)
        {
            using (connection)
            {
                connection.Open();
                SqliteCommand command = new SqliteCommand();
                command.Connection = connection;
                command.CommandText = sql;
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public List<T> GetList<T>(string sql, Func<IDataRecord, T> generator)
        {
            var list = new List<T>();
            using (connection)
            {
                connection.Open();
                SqliteCommand command = new SqliteCommand(sql, connection);
                try
                {
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {

                            list.Add(generator(reader));
                        }

                    }

                }
                catch
                {
                    return null;
                }
            }


            return list;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Db db = new Db("Data Source=data.db");
                //db.ExecuteSQL("INSERT INTO PRODUCT(ID, NAME, PRICE, WEIGHT, CREAT_DATE, EXP_DATE) VALUES(4, 'Veal', 180, 1, '22.12.2021', '10.01.2022');");

                Console.WriteLine("All products");
                foreach (Product p in db.GetProductsList())
                {
                    Console.WriteLine(p);
                }

                Console.WriteLine("Product by price");
                Console.WriteLine(db.GetProductByPrice(128.0));
                Console.WriteLine(db.GetProductByPrice(11));

                Console.WriteLine("Product by name");
                Console.WriteLine(db.GetProductByName("Milk"));
                Console.WriteLine(db.GetProductByName("Candy"));
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }

        }
    }
}