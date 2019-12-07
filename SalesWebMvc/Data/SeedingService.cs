using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;
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

            
            Department d1 = new Department("Computers");
            Department d2 = new Department("Eletronics");
            Department d3 = new Department("Fashion");
            Department d4 = new Department("Books");


            Seller s1 = new Seller(1, "Adriano Lopes", "adriano@gmail.com", new DateTime(1998, 4, 21), 1000.0, d1);
            Seller s2 = new Seller(2, "Maria Green", "maria@gmail.com", new DateTime(1979, 2, 14), 1400.0, d2);
            Seller s3 = new Seller(3, "Alex Souza", "alex@gmail.com", new DateTime(1988, 3, 1), 1700.0, d3);
            Seller s4 = new Seller(4, "Martha Silva", "martha@gmail.com", new DateTime(1993, 10, 27), 1300.0, d4);
            Seller s5 = new Seller(5, "Diego Santos", "diego@gmail.com", new DateTime(1997, 4, 12), 1750.0, d1);
            Seller s6 = new Seller(6, "Carlos Pitaia", "carlos@gmail.com", new DateTime(2000, 12, 25), 1000.0, d4);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2018,09,25),11000.0,SaleStatus.Billed,s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2018, 10, 10), 4000.0, SaleStatus.Billed, s2);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2018, 10, 15), 2000.0, SaleStatus.Billed, s3);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2018, 10, 12), 7000.0, SaleStatus.Billed, s4);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2018, 10, 17), 12000.0, SaleStatus.Billed, s5);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2018, 10, 14), 800.0, SaleStatus.Billed, s6);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2018, 10, 19), 1120.0, SaleStatus.Billed, s3);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2018, 10, 20), 5000.0, SaleStatus.Billed, s5);


            //adicionar os objetos no banco de dados usando o entity framework
            _context.Department.AddRange(d1, d2, d3, d4);// AddRange permite que voce adicione varios objetos de uma vez 
 
            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);// AddRange permite que voce adicione varios objetos de uma vez

            _context.SalesRecord.AddRange(r1, r2, r3, r4, r5, r6, r7, r8);// AddRange permite que voce adicione varios objetos de uma vez

            _context.SaveChanges();//efetivar essas alterações

        }
    }
}
