using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
namespace SalesWebMvc.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller() {

        }
        public Seller(int Id, String Name, String Email, DateTime BirthDate, double BaseSalary, Department department) {
            Id = Id;
            Name = Name;
            Email = Email;
            BirthDate = BirthDate;
            BaseSalary = BaseSalary;
            Department = department;
        }

        public void AddSales(SalesRecord sr) //add metodo
        {
            Sales.Add(sr);
        } 
        public void RemoveSales(SalesRecord sr) 
        {
            Sales.Remove(sr);
        }
        public double TotalSales(DateTime initial,DateTime final) 
        {
            return Sales.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);//where(filtrar vendas) chamando a coleção Sales no caso a lista, calculando a venda em um determinado intervalo
        }
    }
}
