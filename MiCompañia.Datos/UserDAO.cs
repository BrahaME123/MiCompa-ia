using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using MiCompañia.Soporte;
using MiCompañia.Soporte.cache;
using ZstdSharp.Unsafe;
namespace MiCompañia.Datos
{
    public class UserDAO : ConnectionToMySQL
    {
        public bool Login(string user, string pass)
        {
            using (var connection = new MySqlConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from Usuarios where (LoginName = @user and password = @pass) or (email = @user and password=@pass)";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@password", pass);
                    command.CommandType = CommandType.Text;
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UserCache.idUser = reader.GetInt32(0);
                            UserCache.LoginNombre = reader.GetString(1);
                            UserCache.Password = reader.GetString(2);
                            UserCache.PrimerNombre = reader.GetString(3);
                            UserCache.UltimoNombre = reader.GetString(4);
                            UserCache.Position = reader.GetString(5);
                            UserCache.email = reader.GetString(6);

                        }
                        return true;
                        Console.WriteLine("INICIO Y CACHE INICIADOS CORRECTAMENTE");
                    }
                    else
                    {
                        Console.WriteLine("PROBLEMA AL OBTENER Y ALMACENNAR LA CACHE DE USUARO");
                        return false;
                    }

                }

            }
        }
    }
}
