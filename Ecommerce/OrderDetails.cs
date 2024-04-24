using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce
{
    public enum OrderStatus{Default,Ordered,Cancelled}
    
    public class OrderDetails
    {
        //fields
        private static int s_OrderID=1000;

        //auto property
        public string OrderID{get;set;}
        public string CustomerID{get;set;}
        public string ProductID{get;set;}
        public int TotalPrice{get;set;}
        public DateTime PurchaseDate{get;set;}
        public int Quantitiy{get;set;}
        public OrderStatus OrderStatus;

        //constructor
        public OrderDetails(string customerID,string productID,int totalPrice,int quantitiy,OrderStatus status){
            s_OrderID++;
            OrderID="OID"+s_OrderID;
            CustomerID=customerID;
            ProductID=productID;
            TotalPrice=totalPrice;
            Quantitiy=quantitiy;
            PurchaseDate=DateTime.Now;
            OrderStatus=status;
        }

    }
}