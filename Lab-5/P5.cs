// Create a class Hospital with HospitalDetails() method. Create another
// classes Apollo, Wockhardt, Gokul_Superspeciality which overrides
// HospitalDetails() method
class Hospital{
    public virtual void HospitalDetails(){
        Console.WriteLine("Hospital Details");
    }
}
class Apollo : Hospital{
    public override void HospitalDetails(){
        Console.WriteLine("Apollo Hospital");
    }
}
class Wockhardt:Hospital{
    public override void HospitalDetails(){
        Console.WriteLine("Wockhardt Hospital");
    }
}
class Gokul_Superspeciality : Hospital{
    public override void HospitalDetails(){
        Console.WriteLine("Gokul Super Speciality Hospital");
    }
}
class Program{
    
    public static void Main(string[] args)
    {
        Hospital hospital = new Hospital();
        hospital.HospitalDetails(); 

        Apollo apollo = new Apollo();
        apollo.HospitalDetails();

        Wockhardt wockhardt = new Wockhardt();
        wockhardt.HospitalDetails();

        Gokul_Superspeciality gokul_Superspeciality = new Gokul_Superspeciality();
        gokul_Superspeciality.HospitalDetails();
    }
}