using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;

namespace SalesWebMvc.Data
{
    public class SeedingService// quando o SeedingService for criado..
    {
        private SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)// ira receber automaticamente uma instancia do context 
        {
            _context = context;
        }
        public void Seed() // operacao responsavel por popular a base de dados
        { 
            if(_context.Department.Any() || _context.Seller.Any()|| _context.SalesRecord.Any())//verifica se tem algo ja registrado
            {
                return;// banco de dados ja foi populado
            }

            Department d1 = new Department(1, "Computador");
            Department d2 = new Department(2, "Eletronico");
            Department d3 = new Department(3, "Moda");
            Department d4 = new Department(4, "Livros");


            Seller s1 = new Seller(1, "Adriano Lopes", "adriano@gmail.com", new DateTime(1998, 4, 21), 1000.0, d1);
            Seller s2 = new Seller(2, "Maria Green", "maria@gmail.com", new DateTime(1979, 2, 14), 1400.0, d2);
            Seller s3 = new Seller(3, "Alex Souza", "alex@gmail.com", new DateTime(1988, 3, 1), 1700.0, d3);
            Seller s4 = new Seller(4, "Martha Silva", "martha@gmail.com", new DateTime(1993, 10, 27), 1300.0, d4);
            Seller s5 = new Seller(5, "Diego Santos", "diego@gmail.com", new DateTime(1997, 4, 12), 1750.0, d1);
            Seller s6 = new Seller(6, "Carlos Pitaia", "carlos@gmail.com", new DateTime(2000, 12, 25), 1000.0, d4);
           

        }
    }
}
