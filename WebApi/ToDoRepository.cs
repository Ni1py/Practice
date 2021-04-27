using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace todoWebApi
{
    public class ToDoRepository
    {
        private const int MAX_LENGTH = 255;

        private static string _connectionString = @"Server=DESKTOP-3KKRO48\SQLEXPRESS01;Database=ToDoDatabase;Trusted_Connection=True;";

        private class ToDo
        {
            public int Id { get; }
            public string Name { get; set; }
            public bool Done { get; set; }

            public DateTime creationDate { get; }

            public ToDo(int id, string name, bool done)
            {
                Id = id;
                Name = name;
                Done = done;
                creationDate = DateTime.Now;
            }
        }

        public List<ToDoDto> GetAll()
        {
            List<ToDoDto> toDos = new List<ToDoDto>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText =
                        @"SELECT
                            [Id],
                            [Name],
                            [Done]
                        FROM [Notes]";

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var toDo = new ToDoDto
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Name = Convert.ToString(reader["Name"]),
                                Done = Convert.ToBoolean(reader["Done"]),
                            };
                            toDos.Add(toDo);
                        }
                    }
                }
            }
            return toDos;
        }

        public int Create(ToDoDto toDoDto)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"
                    INSERT INTO [Notes]
                       ([Name],
                        [Done])
                    VALUES
                       (@name,
                        @done)
                    SELECT SCOPE_IDENTITY()";

                    string name = toDoDto.Name;
                    if (name.Length > MAX_LENGTH)
                    {
                        name = name.Substring(0, MAX_LENGTH);
                    }

                    command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                    command.Parameters.Add("@done", SqlDbType.Bit).Value = toDoDto.Done;

                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
        }

        public void Update(int id, ToDoDto toDoDto)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"
                        UPDATE [Notes]
                        SET [Done] = @done
                        WHERE [Id] = @Id";

                    command.Parameters.Add("@done", SqlDbType.Bit).Value = toDoDto.Done;
                    command.Parameters.Add("@Id", SqlDbType.Int).Value = id;

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}