
namespace LPRS.Services
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class VehicleEntry
    {
        public int Lane { get; set; }
        public string? PlateNumber { get; set; }
        public DateTime Timestamp { get; set; }
        public string? ImageUrl { get; set; }
    }

    public class VehicleDataService
    {
        private List<VehicleEntry> _entries = new()
    {
        /*new VehicleEntry { Lane = 1, PlateNumber = "LT2314", Timestamp = new DateTime(2025, 3, 12, 12, 13, 0), ImageUrl = "images/plate1.png" },
        new VehicleEntry { Lane = 2, PlateNumber = "MQ8139", Timestamp = new DateTime(2025, 3, 12, 16, 10, 0), ImageUrl = "images/plate2.png" },
        new VehicleEntry { Lane = 3, PlateNumber = "VNA68", Timestamp = new DateTime(2025, 3, 12, 14, 00, 0), ImageUrl = "images/plate3.jpg" },
        new VehicleEntry { Lane = 2, PlateNumber = "HRL98R", Timestamp = new DateTime(2025, 3, 12, 15, 21, 0), ImageUrl = "images/plate4.jpg" },
        new VehicleEntry { Lane = 3, PlateNumber = "IIUM6763", Timestamp = new DateTime(2025, 3, 12, 15, 24, 0), ImageUrl = "images/plate5.jpg" },
        new VehicleEntry { Lane = 1, PlateNumber = "CAR505", Timestamp = new DateTime(2025, 3, 12, 15, 20, 0), ImageUrl = "images/plate6.jpg" },
        new VehicleEntry { Lane = 3, PlateNumber = "MQ8139", Timestamp = new DateTime(2025, 3, 12, 08, 00, 0), ImageUrl = "images/plate2.png" },
        new VehicleEntry { Lane = 1, PlateNumber = "VNA68", Timestamp = new DateTime(2025, 3, 12, 15, 20, 0), ImageUrl = "images/plate7.jpeg" },
        new VehicleEntry { Lane = 3, PlateNumber = "MQ8139", Timestamp = new DateTime(2025, 3, 12, 13, 12, 0), ImageUrl = "images/plate2.png" },
        new VehicleEntry { Lane = 1, PlateNumber = "WA4414P", Timestamp = new DateTime(2025, 3, 12, 15, 20, 0), ImageUrl = "images/plate8.jpg" },
        new VehicleEntry { Lane = 3, PlateNumber = "VS2277", Timestamp = new DateTime(2025, 3, 12, 08, 00, 0), ImageUrl = "images/plate9.jpg" },
        new VehicleEntry { Lane = 1, PlateNumber = "BHV33", Timestamp = new DateTime(2025, 3, 12, 15, 20, 0), ImageUrl = "images/plate10.jpg" },
        new VehicleEntry { Lane = 3, PlateNumber = "DCW7486", Timestamp = new DateTime(2025, 3, 12, 13, 12, 0), ImageUrl = "images/plate11.jpg" },*/

        new VehicleEntry { Lane = 1, PlateNumber = "LT2314", Timestamp = new DateTime(2025, 3, 12, 12, 13, 0), ImageUrl = "images/plate1.png" },
        new VehicleEntry { Lane = 1, PlateNumber = "CAR505", Timestamp = new DateTime(2025, 3, 12, 15, 20, 0), ImageUrl = "images/plate6.jpg" },
        new VehicleEntry { Lane = 1, PlateNumber = "VNA68", Timestamp = new DateTime(2025, 3, 12, 15, 20, 0), ImageUrl = "images/plate7.jpeg" },
        new VehicleEntry { Lane = 1, PlateNumber = "WA4414P", Timestamp = new DateTime(2025, 3, 12, 15, 20, 0), ImageUrl = "images/plate8.jpg" },
        new VehicleEntry { Lane = 1, PlateNumber = "BHV33", Timestamp = new DateTime(2025, 3, 12, 15, 20, 0), ImageUrl = "images/plate10.jpg" },
        new VehicleEntry { Lane = 1, PlateNumber = "LT2314", Timestamp = new DateTime(2025, 4, 13, 13, 40, 0), ImageUrl = "images/plate1.png" },
        new VehicleEntry { Lane = 1, PlateNumber = "CAR505", Timestamp = new DateTime(2025, 5, 3, 9, 15, 0), ImageUrl = "images/plate6.jpg" },
        new VehicleEntry { Lane = 1, PlateNumber = "HRL98R", Timestamp = new DateTime(2025, 3, 18, 8, 55, 0), ImageUrl = "images/plate4.jpg" },
        new VehicleEntry { Lane = 1, PlateNumber = "WA4414P", Timestamp = new DateTime(2025, 5, 11, 14, 55, 0), ImageUrl = "images/plate8.jpg" },

        new VehicleEntry { Lane = 2, PlateNumber = "MQ8139", Timestamp = new DateTime(2025, 3, 12, 16, 10, 0), ImageUrl = "images/plate2.png" },
        new VehicleEntry { Lane = 2, PlateNumber = "HRL98R", Timestamp = new DateTime(2025, 3, 12, 15, 21, 0), ImageUrl = "images/plate4.jpg" },
        new VehicleEntry { Lane = 2, PlateNumber = "LT2314", Timestamp = new DateTime(2025, 3, 5, 10, 45, 0), ImageUrl = "images/plate1.png" },
        new VehicleEntry { Lane = 2, PlateNumber = "MQ8139", Timestamp = new DateTime(2025, 4, 3, 6, 35, 0), ImageUrl = "images/plate2.png" },
        new VehicleEntry { Lane = 2, PlateNumber = "MQ8139", Timestamp = new DateTime(2025, 4, 25, 7, 30, 0), ImageUrl = "images/plate2.png" },
        new VehicleEntry { Lane = 2, PlateNumber = "VNA68", Timestamp = new DateTime(2025, 5, 16, 20, 0, 0), ImageUrl = "images/plate3.jpg" },
        new VehicleEntry { Lane = 2, PlateNumber = "BHV33", Timestamp = new DateTime(2025, 5, 1, 10, 10, 0), ImageUrl = "images/plate10.jpg" },
        new VehicleEntry { Lane = 2, PlateNumber = "HRL98R", Timestamp = new DateTime(2025, 4, 1, 7, 15, 0), ImageUrl = "images/plate4.jpg" },
        new VehicleEntry { Lane = 2, PlateNumber = "MQ8139", Timestamp = new DateTime(2025, 3, 25, 9, 25, 0), ImageUrl = "images/plate2.png" },
        new VehicleEntry { Lane = 2, PlateNumber = "DCW7486", Timestamp = new DateTime(2025, 4, 6, 13, 15, 0), ImageUrl = "images/plate11.jpg" },

        new VehicleEntry { Lane = 3, PlateNumber = "VNA68", Timestamp = new DateTime(2025, 3, 12, 14, 00, 0), ImageUrl = "images/plate3.jpg" },
        new VehicleEntry { Lane = 3, PlateNumber = "HRL98R", Timestamp = new DateTime(2025, 3, 12, 15, 21, 0), ImageUrl = "images/plate4.jpg" },
        new VehicleEntry { Lane = 3, PlateNumber = "MQ8139", Timestamp = new DateTime(2025, 3, 12, 08, 00, 0), ImageUrl = "images/plate2.png" },
        new VehicleEntry { Lane = 3, PlateNumber = "MQ8139", Timestamp = new DateTime(2025, 3, 12, 13, 12, 0), ImageUrl = "images/plate2.png" },
        new VehicleEntry { Lane = 3, PlateNumber = "VS2277", Timestamp = new DateTime(2025, 3, 12, 08, 00, 0), ImageUrl = "images/plate9.jpg" },
        new VehicleEntry { Lane = 3, PlateNumber = "DCW7486", Timestamp = new DateTime(2025, 3, 12, 13, 12, 0), ImageUrl = "images/plate11.jpg" },
        new VehicleEntry { Lane = 3, PlateNumber = "CAR505", Timestamp = new DateTime(2025, 4, 14, 9, 40, 0), ImageUrl = "images/plate6.jpg" },
        new VehicleEntry { Lane = 3, PlateNumber = "MQ8139", Timestamp = new DateTime(2025, 5, 14, 11, 10, 0), ImageUrl = "images/plate2.png" },
        new VehicleEntry { Lane = 3, PlateNumber = "DCW7486", Timestamp = new DateTime(2025, 5, 10, 15, 30, 0), ImageUrl = "images/plate11.jpg" },
        new VehicleEntry { Lane = 3, PlateNumber = "IIUM6763", Timestamp = new DateTime(2025, 3, 10, 10, 0, 0), ImageUrl = "images/plate5.jpg" },
        new VehicleEntry { Lane = 3, PlateNumber = "VNA68", Timestamp = new DateTime(2025, 4, 9, 13, 20, 0), ImageUrl = "images/plate3.jpg" },
        new VehicleEntry { Lane = 3, PlateNumber = "DCW7486", Timestamp = new DateTime(2025, 4, 5, 9, 5, 0), ImageUrl = "images/plate11.jpg" },
        new VehicleEntry { Lane = 3, PlateNumber = "IIUM6763", Timestamp = new DateTime(2025, 4, 24, 18, 35, 0), ImageUrl = "images/plate5.jpg" },

        new VehicleEntry { Lane = 4, PlateNumber = "MQ8139", Timestamp = new DateTime(2025, 5, 22, 17, 30, 0), ImageUrl = "images/plate2.png" },
        new VehicleEntry { Lane = 4, PlateNumber = "VNA68", Timestamp = new DateTime(2025, 5, 9, 15, 50, 0), ImageUrl = "images/plate7.jpeg" },
        new VehicleEntry { Lane = 4, PlateNumber = "MQ8139", Timestamp = new DateTime(2025, 3, 2, 11, 45, 0), ImageUrl = "images/plate2.png" },
        new VehicleEntry { Lane = 4, PlateNumber = "VS2277", Timestamp = new DateTime(2025, 4, 8, 14, 30, 0), ImageUrl = "images/plate9.jpg" },
        new VehicleEntry { Lane = 4, PlateNumber = "BHV33", Timestamp = new DateTime(2025, 3, 19, 6, 0, 0), ImageUrl = "images/plate10.jpg" },
        new VehicleEntry { Lane = 4, PlateNumber = "CAR505", Timestamp = new DateTime(2025, 5, 8, 13, 5, 0), ImageUrl = "images/plate6.jpg" },
        new VehicleEntry { Lane = 4, PlateNumber = "VNA68", Timestamp = new DateTime(2025, 5, 6, 10, 50, 0), ImageUrl = "images/plate3.jpg" },


    };

        private List<string> _flaggedPlates = new() { "MQ8139", "CAR505" };

        public Task<List<VehicleEntry>> GetEntriesAsync() => Task.FromResult(_entries);
        public Task<List<string>> GetFlaggedPlatesAsync() => Task.FromResult(_flaggedPlates);
    }
}