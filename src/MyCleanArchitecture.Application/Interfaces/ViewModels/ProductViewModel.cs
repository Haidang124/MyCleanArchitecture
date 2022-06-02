using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace MyCleanArchitecture.Application.Interfaces.ViewModels
{
    public class ProductViewModel : IViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal BuyPrice { get; set; }
        public decimal SellPrice { get; set; }
        public int QuantityInStock { get; set; }
        public Guid AgentId { get; set; }
        public Guid ProductLineId { get; set; }
    }
}
