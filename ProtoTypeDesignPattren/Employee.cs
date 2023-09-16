using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoTypeDesignPattren
{
    internal partial class Employee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int DepartmentID { get; set; }

        public override string ToString()
        {
            return string.Format(" Name : {0}  " + "DepartmentID : {1}  {2} ",
                this.Name, this.DepartmentID.ToString(), AddressDetails?.ToString());
        }
    }
   // internal partial class Employee : ICloneable // Shallow Copy 
    internal partial class Employee : CloneablePrototype<Employee> // Deep Copy 
    {
        public object Clone()
        {
            // Returns a new object instance that is a memberwise copy of this
            // object.  This is always a shallow copy of the instance. The method is protected
            // so that other object may only call this method on themselves.  It is intended to
            // support the ICloneable interface. 
            return this.MemberwiseClone();
        }
    }
    internal partial class Employee
    {
        public Address AddressDetails { get; set; }
    }

    internal class Address
    {
        public Address() { }

        public int DoorNumber { get; set; }
        public int StreetNumber { get; set; }
        public int Zipcode { get; set; }
        public string Country { get; set; }
        public override string ToString()
        {
            return string.Format("AddressDetails : Door : {0}, Street: {1}, ZipCode : {2}," +
                " Country : {3}", this.DoorNumber, this.StreetNumber, this.Zipcode.ToString(),
                this.Country);
        }
    }
}
