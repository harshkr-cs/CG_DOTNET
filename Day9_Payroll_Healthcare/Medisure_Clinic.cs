using System;
class PatientBill{
    public string BillId { get; set; }
    public string PatientName { get; set; }
    public bool HasInsurance { get; set; }
    public decimal ConsultationFee { get; set; }
    public decimal LabCharges { get; set; } 
    public decimal MedicineCharges { get; set; }

    public double GrossAmount { get; set; }
    public double DiscountAmount { get; set; }
    public double FinalPayable { get; set; }

    // Static storage (ONLY ONE BILL)
    public static PatientBill LastBill;
    public static bool HasLastBill = false;

    public static void CreateBill(){
        PatientBill p=new PatientBill();//create object
        Console.WriteLine("Enter Bill ID:");
        p.BillId = Console.ReadLine();
        //validation BillId
        if(string.IsNullOrEmpty(p.BillId)){
            Console.WriteLine("Bill Id cannot be Empty.");
            return;
        }
        Console.WriteLine("Enter Patient Name:");
        p.PatientName = Console.ReadLine();
        Console.WriteLine("Does the patient have insurance? (true/false):");
        p.HasInsurance=Convert.ToBoolean(Console.ReadLine());
        Console.WriteLine("Enter consultant Fee (double): ");
        p.ConsultationFee = Convert.ToDecimal(Console.ReadLine());
        //validation consultantfee
        if(p.ConsultationFee<=0){
            Console.WriteLine("Consultant Fee must be greater than 0.");
            return;
        }
        Console.WriteLine("Enter LabCharges: ");
        p.LabCharges = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Enter MedicineCharges: ");
        p.MedicineCharges = Convert.ToDecimal(Console.ReadLine());
        //validation LabCharges && MedicineCharges
        if(p.LabCharges<0 || p.MedicineCharges<0){
            Console.WriteLine("LabCharges and MedicineCharges must be greater than or equal to 0.");
            return;
        }

        p.GrossAmount=(double)(p.ConsultationFee + p.LabCharges + p.MedicineCharges);

        if(p.HasInsurance){
            p.DiscountAmount=(p.GrossAmount*10)/100;
        }else{
            p.DiscountAmount=0;
        }
        
        p.FinalPayable=p.GrossAmount - p.DiscountAmount;
        LastBill = p;       //object is stored in it.
        HasLastBill = true;

        Console.WriteLine("Bill created successfully.");
        Console.WriteLine("Gross Amount: "+p.GrossAmount.ToString("F2"));
        Console.WriteLine("Discount Amount: "+p.DiscountAmount.ToString("F2"));
        Console.WriteLine("Final Payable: "+p.FinalPayable.ToString("F2"));
    }

    public static void ViewBill(){
        Console.WriteLine("----------- Last Bill -----------");
        if(HasLastBill){
            Console.WriteLine("Bill Id: "+LastBill.BillId);
            Console.WriteLine("Patient: "+ LastBill.PatientName);
            Console.WriteLine("Insuranced: Yes");
            Console.WriteLine("Consultation Fee: "+ LastBill.ConsultationFee);
            Console.WriteLine("Lab Charges: "+ LastBill.LabCharges);
            Console.WriteLine("Medicine Charges: "+ LastBill.MedicineCharges);
            Console.WriteLine("Gross Amount: "+ LastBill.GrossAmount.ToString("F2"));
            Console.WriteLine("Discount Amount:  "+ LastBill.DiscountAmount.ToString("F2"));
            Console.WriteLine("Final Payable: "+ LastBill.FinalPayable.ToString("F2"));
            Console.WriteLine("End of last Bill Show!");
        }else{
            Console.WriteLine("No bill available. Please create a new bill first.");
        }
    }

    public static void ClearBill(){
        if(HasLastBill){
            LastBill = null;
            HasLastBill=false;
            Console.WriteLine("Last bill cleared.");
        }else{
            Console.WriteLine("No Last Bill Created.");
        }
    }
    
}