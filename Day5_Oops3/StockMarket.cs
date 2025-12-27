using System;

struct StockPrice{
    public string stockSymbol;
    public double price;
}

class Trade{
    public int tradeId;
    public string stockSymbol;
    public int quantity;
}

class EquityTrade:Trade{
    public double dividend;
}