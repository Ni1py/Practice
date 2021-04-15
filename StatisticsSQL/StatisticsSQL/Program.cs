using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace StatisticsSQL
{
    class Program
    {
        private static string _connectionString = @"Server=DESKTOP-3KKRO48\SQLEXPRESS01;Database=CustomerOrder;Trusted_Connection=True;";

        static void Main(string[] args)
        {
            List<Statistics> orderStatistics = ReadPosts();
            int increment = 1;
            Console.WriteLine("Statistics: ");
            foreach (Statistics record in orderStatistics)
            {
                Console.WriteLine();
                Console.Write($"Name: {record.Name};");
                if ((increment == 2) || (increment == 3)) { Console.Write("\t"); }
                Console.Write($"\t Number of products: {record.NumberOfProducts};");
                Console.WriteLine($"\t\t Order amount: {record.OrderAmount}.");
                increment++;
            }
            Console.ReadKey();
        }

        private static List<Statistics> ReadPosts()
        {
            List<Statistics> orderStatistics = new List<Statistics>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText =
                        @"SELECT 
                            [Name], 
                            COUNT([Order].[CustomerId]) AS [Number of products],
                            SUM([Price]) AS [Order amount]
                          FROM 
                            Customer
                          JOIN [Order]
                            ON [Order].[CustomerId] =  [Customer].[CustomerId]
                          GROUP BY [Name];";

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var record = new Statistics
                            {
                                Name = Convert.ToString(reader[0]),
                                NumberOfProducts = Convert.ToInt32(reader[1]),
                                OrderAmount = Convert.ToInt32(reader[2]),
                            };
                            orderStatistics.Add(record);
                        }
                    }
                }
            }
            return orderStatistics;
        }
    }
}
