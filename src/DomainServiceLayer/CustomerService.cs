using DomainLayer.Model;
using DomainServiceLayer.Interface;
using InfrastructureLayer.Repositories.Interfaces;
using System.Collections.Generic;

namespace DomainServiceLayer
{
    public class CustomerService : ICustomerService
    {
        private readonly IRepositoryBase<Customer> _repository;

        public CustomerService(IRepositoryBase<Customer> repository)
        {
            _repository = repository;
        }

        public void DeleteCustomer(int id)
        {
            var customer = GetCustomer(id);
            _repository.Remove(customer);
            _repository.SaveChanges();
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return _repository.GetAll();
        }

        public Customer GetCustomer(int id)
        {
            return _repository.Get(id);
        }

        public void InsertCustomer(Customer customer)
        {
            _repository.Insert(customer);
        }

        public void UpdateCustomer(Customer customer)
        {
            _repository.Update(customer);
        }
    }
}