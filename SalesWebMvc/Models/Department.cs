﻿namespace SalesWebMvc.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Department()
        {
        }
        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void addSeller(Seller seller)
        {

        }

        /*public int totalSales(DateTime initial, DateTime final)
        {

        }*/
    }
}
