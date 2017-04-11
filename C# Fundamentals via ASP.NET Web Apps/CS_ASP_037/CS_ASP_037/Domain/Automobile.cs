using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS_ASP_037
{
    public class Automobile
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public int DaysOnLot { get; set; }
        
        public double MarketValue { get; set; }        
        public string SoldBy { get; set; }
        public double TotalSaleAmount { get; set; }
        public int CarLotParkingSpace { get; set; }
        public void DetermineMarketValue() { }        
        public void PrintCarDetails() { }
        public void RetrieveCarFromDatabase() { }
        public void SaveChangesToDatabase() { }
    }
}