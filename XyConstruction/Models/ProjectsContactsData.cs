using System.Collections.Generic;

namespace XyConstruction.Models.SampleData
{
    public partial class SampleData
    {
        public static readonly IEnumerable<ProjectContact> Projects = new[] {
            new ProjectContact {
                ID = 1,
                Name = "Austria Headquarter",
                Address = "Hauptstrasse 1",
                City = "Wien",
                Country = "Austria",
                ZipCode = 1140,
                Phone = "AT xxx xxx xxx ",
                Email = "austria@xyconstruction.com"
            },
            new ProjectContact {
                ID = 2,
                Name = "United Kingdom Headquater",
                Address = "16 Byward St.",
                City = "London",
                Country = "United Kingdom",
                ZipCode = 553420,
                Phone = "UK xxx xxx xxx ",
                Email = "uk@xyconstruction.com"
            },
            new ProjectContact {
                ID = 3,
                Name = "France Headquater",
                Address = "184 Rue Saint-Honore",
                City = "Paris",
                Country = "France",
                ZipCode = 75001,
                Phone = "FR xxx xxx xxx ",
                Email = "france@xyconstruction.com"
            },
            new ProjectContact {
                ID = 4,
                Name = "Germany Headquater",
                Address = "Kronenstrasse 53",
                City = "Berlin",
                Country = "Germany",
                ZipCode = 10117,
                Phone = "DE xxx xxx xxx ",
                Email = "germany@xyconstruction.com"
            },
            new ProjectContact {
                ID = 5,
                Name = "Hungary Headquater",
                Address = "Falk Miksa u. 3",
                City = "Budapest",
                Country = "Hungary",
                ZipCode = 1055,
                Phone = "HU xxx xxx xxx ",
                Email = "hungary@xyconstruction.com"
            }
        };


    }
}
