using System;

namespace NEW_PROJECT
{
    // מחלקה בסיסית לנכס
    public abstract class Property
    {
        // Properties
        public string Name { get; set; }
        public string Address { get; set; }
        public PropertyType Type { get; set; }
        public decimal Price { get; set; }

        // בנאי בסיסי
        public Property(string name, string address, PropertyType type, decimal price)
        {
            Name = name;
            Address = address;
            Type = type;
            Price = price;
        }

        // פונקציה וירטואלית להצגת פרטי הנכס
        public virtual string DisplayDetails()
        {
            return $"Name: {Name}, Address: {Address}, Type: {Type}, Price: {Price}";
        }

        // פונקציה אבסטרקטית לחישוב מס
        public abstract decimal CalculateTax();

        // ✅ תצוגה ידידותית לכל סוגי הנכסים
        public override string ToString()
        {
            return $"{Name} | {Address} | {Price:N0} ₪";
        }
    }

    // מחלקה עבור בית פרטי
    public class PrivateHouse : Property
    {
        public PrivateHouse(string name, string address, decimal price)
            : base(name, address, PropertyType.PrivateHouse, price)
        {
        }

        public override decimal CalculateTax()
        {
            return Price * 0.01m;
        }
    }

    // מחלקה עבור דירה
    public class Apartment : Property
    {
        public Apartment(string name, string address, decimal price)
            : base(name, address, PropertyType.Apartment, price)
        {
        }

        public override decimal CalculateTax()
        {
            return Price * 0.02m;
        }
    }

    // מחלקה עבור משרד
    public class Office : Property
    {
        public Office(string name, string address, decimal price)
            : base(name, address, PropertyType.Office, price)
        {
        }

        public override decimal CalculateTax()
        {
            return Price * 0.015m;
        }
    }
}
