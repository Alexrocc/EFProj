﻿using EFProj.Core.DataAccess;
using EFProj.Core.Entities;
using MySqlConnector;


string connString = """Server=localhost; port=3306;Database=pmsapi;User=root;Password=mariam;""";

// try
// {
//     using (var context = new PmsContext(connString))
//     {
//         foreach (var el in context.Roles.ToList())
//         {
//             Console.WriteLine(el.Name);
//         }
//     }
// }
// catch (SqlException ex)
// {
//     Console.WriteLine(ex.Message);
// }
// catch (Exception ex)
// {
//     Console.WriteLine(ex.Message);
// }
try
{


    using (var context = new PmsContext(connString))
    {
        var roles = context.Roles.ToList();
        // var user1 = new User
        // {
        //     Username = "Luigi",
        //     Email = "luigi@luigi.it",
        //     Password = "luigimario",
        //     Role = role1
        // };

        // context.Users.Add(); //adding a new row in the table users
        // context.SaveChanges();  //it is HERE that the change in the table is truly made

        foreach (var user in context.Users.ToList())
        {
            Console.WriteLine($"{user.Username}, {user.Role.RoleName}");
        }
    }
}
catch (MySqlException ex)
{
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
// using (var context = new PmsContext(connString))
// {
//     foreach (var el in context.Roles.ToList())
//     {
//         Console.WriteLine($"{el.RoleName}");
//     }
// }