using ProtoTypeDesignPattren;
//ShallowCopy();
//ShallowCopyRef();
DeepCopy();

// ShallowCopy
static void ShallowCopy()
{
    Employee empM = new Employee()
    {
        Id = Guid.NewGuid(),
        Name = "Mohammad",
        DepartmentID = 150,
    };

    Employee empGh = (Employee)empM.Clone();
    empGh.Name = "Ghazal";

    Console.WriteLine(empM.ToString());
    Console.WriteLine(empGh.ToString());

    Console.WriteLine("////////////////////////////");
    Console.WriteLine("Changed Mohammad DepartmentID to 161");
    empM.DepartmentID = 161;
    Console.WriteLine(empM.ToString());
    Console.WriteLine(empGh.ToString());

    Console.ReadLine();
}
static void ShallowCopyRef()
{
    Employee empM = new Employee()
    {
        Id = Guid.NewGuid(),
        Name = "Mohammad",
        DepartmentID = 150,
        AddressDetails = new Address()
        {
            DoorNumber = 10,
            StreetNumber = 20,
            Zipcode = 90025,
            Country = "JO"
        }
    };

    Console.WriteLine(empM.ToString());

    Employee empGh = (Employee)empM.Clone();
    empGh.Name = "Ghazal";
    empGh.DepartmentID = 151;
    empGh.AddressDetails.StreetNumber = 21;
    empGh.AddressDetails.DoorNumber = 11;

    Console.WriteLine(empGh.ToString());

    Console.WriteLine("////////////////////////////");
    Console.WriteLine("Modified Details of Mohammad");
    empM.AddressDetails.DoorNumber = 30;
    empM.AddressDetails.StreetNumber = 40;

    empM.DepartmentID = 160;
    Console.WriteLine(empM.ToString());
    Console.WriteLine(empGh.ToString());

    Console.ReadLine();
}

static void DeepCopy()
{
    Employee empM = new Employee()
    {
        Id = Guid.NewGuid(),
        Name = "Mohammad",
        DepartmentID = 150,
        AddressDetails = new Address()
        {
            DoorNumber = 10,
            StreetNumber = 20,
            Zipcode = 90025,
            Country = "JO"
        }
    };

    Console.WriteLine(empM.ToString());

    Employee empGh = (Employee)empM.DeepCopy();

    empGh.Name = "Ghazal";
    empGh.DepartmentID = 151;

    Console.WriteLine(empGh.ToString());

    Console.WriteLine("Modified Details of Mohammad");
    empM.AddressDetails.DoorNumber = 30;
    empM.AddressDetails.StreetNumber = 40;

    empM.DepartmentID = 160;
    Console.WriteLine(empM.ToString());
    Console.WriteLine(empGh.ToString());
    Console.ReadLine();
}