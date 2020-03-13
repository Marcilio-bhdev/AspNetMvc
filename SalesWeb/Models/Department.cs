using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWeb.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Saller> Sellers { get; set; } = new List<Saller>();

        public Department() 
        {
        }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddDepartment(Saller seller)
        {
            Sellers.Add(seller);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sellers.Sum(seller => seller.TotalSales (initial, final));// estou pegando cada vendedor chamanco o total do que ele vendeu e somando com todos os vendedores 
        }
    }
}
