using System;

namespace NEW_PROJECT
{
    public abstract class Property
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public PropertyType Type { get; set; }
        public decimal Price { get; set; }
        public string Owner { get; set; }

        public Property(string name, string address, PropertyType type, decimal price, string owner)
        {
            Name = name;
            Address = address;
            Type = type;
            Price = price;
            Owner = owner;
        }

        public virtual string DisplayDetails()
        {
            return $"Name: {Name}, Address: {Address}, Type: {Type}, Price: {Price:C}, Owner: {Owner}";
        }

        public abstract decimal CalculateTax();

        public override string ToString()
        {
            return $"{Name} | {Address} | {Price:C}";
        }
    }

    public class PrivateHouse : Property
    {
        public PrivateHouse(string name, string address, decimal price, string owner)
            : base(name, address, PropertyType.PrivateHouse, price, owner)
        {
        }

        public override decimal CalculateTax()
        {
            return Price * 0.01m;
        }
    }

    public class Apartment : Property
    {
        public Apartment(string name, string address, decimal price, string owner)
            : base(name, address, PropertyType.Apartment, price, owner)
        {
        }

        public override decimal CalculateTax()
        {
            return Price * 0.02m;
        }
    }

    public class Office : Property
    {
        public Office(string name, string address, decimal price, string owner)
            : base(name, address, PropertyType.Office, price, owner)
        {
        }

        public override decimal CalculateTax()
        {
            return Price * 0.015m;
        }
    }
}
