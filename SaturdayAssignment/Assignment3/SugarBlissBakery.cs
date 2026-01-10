

class Chocolate{
    //properties
    public string Flavour{get; set;}
    public int Quantity{get; set;}
    public int PricePerUnit{get; set;}
    public double TotalPrice{get; set;}
    public double DiscountedPrice{get;set;}
    
    //Data Membeer
    public bool ValidateChocolateFlavour(string flavour){
        if(flavour == "Dark" || flavour == "Milk" || flavour == "White"){
            return true;
        }else{
            return false;
        }
    }


}