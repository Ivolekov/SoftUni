namespace Customer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Customer : IComparable<Customer>, ICloneable
    {
        public Customer(
            string firstName,
            string middleName,
            string lastName,
            string id,
            string adress,
            string mobilePhone,
            string email,
            CustomerType type,
            params Payment[] payments)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.Id = id;
            this.Adress = adress;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.CustomerType = type;
            this.Payments = new List<Payment>(payments);
            
        }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string Id { get; set; }

        public string Adress { get; set; }

        public string MobilePhone { get; set; }

        public string Email { get; set; }

        public List<Payment> Payments { get; set; }

        public CustomerType CustomerType { get; private set; }

        public int CompareTo(Customer other)
        {
            if (this.FirstName == other.FirstName)
            {
                if (this.LastName == other.LastName)
                {
                    return string.Compare(other.Id, other.Id, StringComparison.Ordinal) * -1;
                }

                return string.Compare(this.LastName, other.LastName, StringComparison.InvariantCulture);
            }

            return string.Compare(this.FirstName, other.FirstName, StringComparison.InvariantCulture);
        }

        public override bool Equals(object obj)
        {
            Customer other = obj as Customer;
            if (other == null)
            {
                return false;
            }

            if (!Equals(this.Id, other.Id))
            {
                return false;
            }

            if (!Equals(this.CustomerType, other.CustomerType))
            {
                return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.Id.GetHashCode() ^ this.CustomerType.GetHashCode();
        }

        public object Clone()
        {
            string firstName = this.FirstName;
            string middleName = this.MiddleName;
            string lastName = this.LastName;
            string id = this.Id;
            string adress = this.Adress;
            string mobilePhone = this.MobilePhone;
            string email = this.Email;
            CustomerType cloningCustomerType = this.CustomerType;
            IList<Payment> cloningPayments = new List<Payment>(this.Payments);

            return new Customer(firstName, middleName, lastName, id, adress, mobilePhone, email, cloningCustomerType, cloningPayments.ToArray());
        }

        public static bool operator ==(Customer customer1, Customer customer2)
        {
            return Equals(customer1, customer2);
        }

        public static bool operator !=(Customer customer1, Customer customer2)
        {
            return !(Equals(customer1, customer2));
        }

        public override string ToString()
    {
        var customer = new StringBuilder();

        customer.AppendLine(string.Format("Customer: {0} {1} {2} {3}", this.FirstName, this.MiddleName, this.LastName, this.Id));
        customer.AppendLine(string.Format("Contacts: mobile phone: {0}, email: {1}", this.MobilePhone, this.Email));

        return customer.ToString();
    }
}
}
