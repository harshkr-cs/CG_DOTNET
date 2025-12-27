using System;
// Task 1: Trade Business Class
public abstract class Trade1{
    // Properties
    public int TradeId { get; set; }
    public string StockSymbol { get; set; }
    public int Quantity { get; set; }

    // Abstract method
    public abstract double CalculateTradeValue();

    // Override ToString()
    public override string ToString()
    {
        return $"Trade ID: {TradeId}, Stock: {StockSymbol}, Quantity: {Quantity}";
    }
}

public class EquityTrade1 : Trade1{
    public double PricePerShare { get; set; }
    public override double CalculateTradeValue(){
        return Quantity * PricePerShare;
    }
    public override string ToString(){
        return base.ToString() + 
               $", Price: {PricePerShare}, Trade Value: {CalculateTradeValue()}";
    }
}


