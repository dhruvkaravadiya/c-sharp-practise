// Create a class named RBI with calculateInterest() method. Create another
// classes HDFC, SBI, ICICI which overrides calculateInterest() method
class RBI{
    public virtual void calculateInterest(){
        Console.WriteLine("RBI Bank");
    }
}
class HDFC : RBI{
    public override void calculateInterest(){
        Console.WriteLine("HDFC Bank");
    }
}
class ICICI:RBI{
    public override void calculateInterest(){
        Console.WriteLine("ICICI Bank");
    }
}
class SBI : RBI{
    public override void calculateInterest(){
        Console.WriteLine("SBI Bank");
    }
}
class Program{
    
    public static void Main(string[] args)
    {
        RBI rbi = new RBI();
        rbi.calculateInterest(); 

        HDFC hdfc = new HDFC();
        hdfc.calculateInterest();
        SBI sbi = new SBI();
        sbi.calculateInterest();  

        ICICI icici = new ICICI();
        icici.calculateInterest();
    }
}