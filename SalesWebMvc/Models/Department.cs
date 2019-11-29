using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvc.Models
{
    public class Department
    {
        public int Id { get; set; }
        public String Name { get; set; }

        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();// implementamos a associacao do Departmente com o Seller
       
        public Department() { //contrutor sem argumento
        
        }
        public Department(int Id, String Name) {//construtor com argumento
            this.Id = Id;
            this.Name = Name;
        }
        public void addSeller(Seller seller) 
        {
            Sellers.Add(seller);
        }

        public double TotalSales (DateTime initial, DateTime final)
        {
            return Sellers.Sum(Seller => Seller.TotalSales(initial, final));// cada vendedor seller na minha lista chamando o TOTALSALES do vendedor naquele periodo e faz uma soma 
            //pegar lista de vendedores desse department, filtrara apenas a venda desse periodo

        }
    }

}
