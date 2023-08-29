namespace OOPSample.Sales.Domain.Model.Entities;

public class SalesOrderItem
{
    
    public int id { get; set; }

    public int SalesOrderId { get; set; }
   
    public int Quantity  { get; set; }
 
}