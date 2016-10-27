using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AsgQuizzes
{
    public class ValidationException : Exception { }

    /// <summary>
    /// HINT: This class may need modification in order to make some tests pass
    /// </summary>
    public class OrderLine
    {
        public Guid ProductId { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        public int Qty { get; set; }
        public decimal LinePrice { get; set; }

        public void Validate()
        {
        }
    }

    public class Order
    {
        public Guid Id { get; set; }
        public string Customer { get; set; }
        public decimal TotalPrice { get; set; }

        public IEnumerable<OrderLine> Lines { get; set; }

        public decimal Discount { get; set; }

        public void Validate()
        {
            var lines = this.Lines ?? new OrderLine[] {};
            foreach(var l in lines)
                l.Validate();
            var linesSum = lines.Sum(l => l.LinePrice);
            if (linesSum * (100m - this.Discount) / 100m != this.TotalPrice)
                throw new ValidationException();
        }
    }

    public interface IOrderRepository
    {
        Order CreateOrder(Order order);
        Order ReadOrder(Guid orderId);
        Order UpdateOrder(Order order);
        void DeleteOrder(Guid orderId);
    }
    
    public class OrderController
    {
        private IOrderRepository _repo;
        public OrderController(IOrderRepository repo)
        {
            _repo = repo;
        }

        public Order New(Order order)
        {
            order.Validate();
            return _repo.CreateOrder(order);
        }

        public Order GetById(Guid orderId)
        {
            return _repo.ReadOrder(orderId);
        }

        public Order ApplyDiscount(Guid orderId, decimal discount)
        {
            var order = _repo.ReadOrder(orderId);
            order.Discount = discount;
            order.TotalPrice = order.TotalPrice*(100m - order.Discount)/100m;
            order.Validate();
            return _repo.UpdateOrder(order);
        }
    }
}
