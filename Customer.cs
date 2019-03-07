using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0603HW
{
    public class Customer : IComparable<Customer>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BirthYear { get; set; }
        public string Address { get; set; }
        public int Protection { get; set; }
        public int TotalPurchases { get; set; }

        public Customer(int id, string name, int birthYear, string address, int protection, int totalPurchases)
        {
            Id = id;
            Name = name;
            BirthYear = birthYear;
            Address = address;
            Protection = protection;
            TotalPurchases = totalPurchases;
        }

        public override string ToString()
        {
            return $"Customer Id: {Id} Name: {Name} BirthYear: {BirthYear} " +
                $"Address: {Address} Protection: {Protection} TotalPurchases: {TotalPurchases}";
        }

        public int CompareTo(Customer other)
        {
            return other.BirthYear - this.BirthYear;
        }
    }

    public class CustomerCompareByProtection : IComparer<Customer>
    {
        public int Compare(Customer x, Customer y)
        {
            return y.Protection - x.Protection;
        }
    }

    public class CustomerCompareByTotalPurchases : IComparer<Customer>
    {
        public int Compare(Customer x, Customer y)
        {
            return y.TotalPurchases - x.TotalPurchases;
        }
    }
}
