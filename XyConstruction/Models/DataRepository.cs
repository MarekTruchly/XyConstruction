using XyConstruction.Models;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


/*Uncomment this section to use hard written data to code and delete other code*/
/*namespace XyConstruction.Models {

    public static class DataRepository
     {
         public static List<ProjectRevenue> GetProjectRevenues()
         {
             List<ProjectRevenue> projectRevenues = new List<ProjectRevenue>
     {
         new ProjectRevenue { Country = "Hungary", ProjectName = "Project A", Revenue = 50000000 },
         new ProjectRevenue { Country = "Hungary", ProjectName = "Project B", Revenue = 30000000 },
         new ProjectRevenue {Country = "Hungary", ProjectName = "Project BB", Revenue = 30000000},
         new ProjectRevenue { Country = "Germany", ProjectName = "Project C", Revenue = 45000000 },
         new ProjectRevenue {Country = "Germany", ProjectName = "Project D", Revenue = 35000000},
         new ProjectRevenue {Country = "France", ProjectName = "Project E", Revenue = 40000000},
         new ProjectRevenue {Country = "France", ProjectName = "Project F", Revenue = 60000000},
         new ProjectRevenue {Country = "UK", ProjectName = "Project G", Revenue = 20000000},
         new ProjectRevenue {Country = "UK", ProjectName = "Project H", Revenue = 55000000},
         new ProjectRevenue {Country = "Austria", ProjectName = "Project I", Revenue = 70000000},
         new ProjectRevenue {Country = "Austria", ProjectName = "Project J", Revenue = 80000000}
     };

             return projectRevenues;
         }
     }
    

    }*/
namespace XyConstruction.Models
{
    public static class DataRepository
    {
        public static List<ProjectRevenue> GetProjectRevenues()
        {
            var connectionString = "Server=mysql80.r4.websupport.sk;Database=ConstructionDashboard;Uid=testovacie;Pwd=Test1234;";
            /*Write this code to connectionString to use local MSSQL server*/
            /*"Data Source="Localhost server name";Initial Catalog="Database name";Integrated Security=True;Encrypt=false";*/

            var query = "SELECT Country, ProjectName, Revenue FROM ProjectRevenues";
            var projectRevenues = new List<ProjectRevenue>();

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (var command = new MySqlCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        projectRevenues.Add(new ProjectRevenue
                        {
                            Country = reader.GetString(0),
                            ProjectName = reader.GetString(1),
                            Revenue = reader.GetDecimal(2)
                        });
                    }
                }
            }

            return projectRevenues;
        }
    }
}