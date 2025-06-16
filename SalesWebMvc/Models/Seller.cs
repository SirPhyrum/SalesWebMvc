namespace SalesWebMvc.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email{ get; set; }
        public DateTime BirthDate { get; set; }
        public double BaseSalary { get; set; }

        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
        }
        public Seller()
        {
        }

        public void addSales(SalesRecord sr)
        {

        }

        public void removeSales(SalesRecord sr)
        {

        }

        /*public int totalSales(DateTime initial, DateTime final)
        {

        }*/
    }
}
