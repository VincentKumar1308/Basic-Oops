using System;
using System.Collections.Generic;
using System.Security;
using System.Security.Cryptography.X509Certificates;
namespace Ecommerce;
class Program{
      public static List<CustomerDetails> EcommerceList=new List<CustomerDetails>();
      public static List<ProductDetails> ProductList=new List<ProductDetails>();
      public static List<OrderDetails> OrderDetailsList=new List<OrderDetails>();
    public static void Main(string[] args)
    {
        LoadDefaultData();
        System.Console.WriteLine("-----------------------------------");
        System.Console.WriteLine("Welcome to the E-Commerce Products");
        System.Console.WriteLine("------------------------------------");
        bool isOuterMenu=true;

        do{       
            System.Console.WriteLine("1.Customer Registration\n2.Login\n3.Exit");
            int option=int.Parse(Console.ReadLine());
            switch(option){
                case 1:
                {
                    CustomerRegistration();
                    break;
                }
                case 2:
                {
                    CustomerLogin();  
                    break;
                }
                case 3:
                {
                    isOuterMenu=false;
                    break;
                }

            }
        }while(isOuterMenu);



        
    }

    //customer Registration
     public static  void CustomerRegistration(){
    
            System.Console.WriteLine("------------------------------------");
            System.Console.WriteLine("Welcome to the Registration Page");
            System.Console.WriteLine("-------------------------------------");
            System.Console.Write("Enter Your Name           : ");
            string Name=Console.ReadLine();
            System.Console.Write("Enter Your City          : ");      
            string City=Console.ReadLine();
            System.Console.Write("Enter Your Mobile Number  : ");
            long PhoneNO=long.Parse(Console.ReadLine());
            System.Console.Write("Enter Your Wallet Balance : ");
            int WalletBalance=int.Parse(Console.ReadLine());
            System.Console.Write("Enter Your MailID         : ");
            string MailID=Console.ReadLine();
            System.Console.WriteLine("---------------------------------------------------------");
            
            CustomerDetails Details=new CustomerDetails(Name,City,PhoneNO,MailID,WalletBalance);
            EcommerceList.Add(Details);
            System.Console.WriteLine("Registration completed successfully and Customer ID is "+Details.CustomerID);
            System.Console.WriteLine("---------------------------------------------------------");
            
            Console.ReadKey();
        }
        //customer login
        public static void CustomerLogin(){
            System.Console.Write("Enter Your Customer ID : ");
            string ID=Console.ReadLine();
            bool Isfound=false;
            foreach(CustomerDetails details in EcommerceList){
                if(ID==details.CustomerID){
                   Isfound=true;
                   Submenu(details);
                   break;
                }
            }
            if(!Isfound){
                System.Console.WriteLine("Invalid Customer ID");
            }
           
              
            
        }

        //submenu
        public static void Submenu(CustomerDetails CurrentUser){
            bool Ismainmenu=true;
            do{
            System.Console.WriteLine("a.Purchase\nb.Order History\nc.Cancel Order\nd.Wallet Balance\ne.Wallet Recharge\nf.Exit");
            char option=char.Parse(Console.ReadLine());
         
            switch(option){
                case 'a':
                {
                    Purchase(CurrentUser);
                    break;
                }
                case 'b':
                {
                    OrderHistory(CurrentUser);
                    break;
                }
                case 'c':
                {
                    CancelOrder(CurrentUser);
                    break;
                }
                case 'd':{
                    CurrentUser.walletBalance();
                    break;
                }
                case 'e':
                {
                    CurrentUser.WalletRecharge();
                    break;
                }
                case 'f':
                {
                    Ismainmenu=false;
                    break;
                }
            }
           
        }while(Ismainmenu);

        }

      //purchase 

        public static   void Purchase(CustomerDetails CurrentUser){
            foreach(ProductDetails details in ProductList){
                System.Console.WriteLine("Product Id : "+details.ProductID+" Product Name : "+details.ProductName+" Available Quantity : "+details.Stock+" Price per Quantity : "+details.Price+" Shipping : "+details.ShippingDuration);
                System.Console.WriteLine("----------------------------------------------------------------------");
               
             }
             System.Console.WriteLine("Enter the Product ID : ");
             string Pid=Console.ReadLine();
             bool isValidate=true;
             foreach(ProductDetails details in ProductList){
                if(Pid==details.ProductID){
                    isValidate=false;
                    System.Console.WriteLine("Enter the no of counts : ");
                    int stockCount=int.Parse(Console.ReadLine());
                    if(stockCount>details.Stock){
                        System.Console.WriteLine("Required count not available . "+"Current available  product is : "+details.Stock);
                    }
                    else{
                        int  DeliveryCharge=(stockCount*details.Price)+50;
                        if(DeliveryCharge>CurrentUser.WalletBalance){
                            System.Console.WriteLine("Insufficient Balance and your current balance is : "+CurrentUser.WalletBalance);
                        }
                        else{
                            CurrentUser.WalletBalance=CurrentUser.WalletBalance-DeliveryCharge;
                            details.Stock=details.Stock-stockCount;
                            OrderDetails orderObj=new OrderDetails(CurrentUser.CustomerID,details.ProductID,DeliveryCharge,stockCount,OrderStatus.Ordered);
                            OrderDetailsList.Add(orderObj);
                            System.Console.WriteLine("Order Placed Successfully and Order ID is "+orderObj.OrderID);
                            System.Console.WriteLine("Your Ordered Product on "+orderObj.PurchaseDate.ToString("dd/MM/yyyy"));
                            System.Console.WriteLine("Your order delivered on "+orderObj.PurchaseDate.AddDays(details.ShippingDuration).ToString("dd/MM/yyyy"));
                        }
                        
                    
                        }
                       
                    }
                }
                if(isValidate){
                    System.Console.WriteLine("Invalid Product ID  ");
                }
            }

            public static void OrderHistory(CustomerDetails CurrentUser){
                
              bool  isOrdered=false;
               foreach(OrderDetails order in OrderDetailsList){
                if(order.CustomerID==CurrentUser.CustomerID){
                    isOrdered=true;
                    System.Console.WriteLine("Ordered History");
                    System.Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------");
                    System.Console.WriteLine($"Order ID : {order.OrderID,-10} | Customer ID : {order.CustomerID,-10} | Product ID : {order.ProductID,-10} | Total Price : {order.TotalPrice,-8} | Purchase Date : {order.PurchaseDate.ToString("dd/MM/yyyy"),-8}Quantity Purchased : {order.Quantitiy,-10}Order Status : {order.OrderStatus,-7}\n");
                    System.Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------");
                    break;
                }
               
            }
            if(!isOrdered){
                System.Console.WriteLine("You didn't ordered anything");
            }
            }

            public static void CancelOrder(CustomerDetails CurrentUser){
                OrderHistory(CurrentUser);
                bool  isValidate=false;
                System.Console.Write("Enter the Order ID :");
                string orderID=Console.ReadLine();
                foreach(OrderDetails order in OrderDetailsList){
                if(orderID==order.OrderID){
                    isValidate=true;
                    foreach(ProductDetails details in ProductList)
                    if(order.ProductID==details.ProductID){
                        details.Stock=details.Stock+order.Quantitiy;
                        CurrentUser.WalletBalance=CurrentUser.WalletBalance+order.TotalPrice;
                        System.Console.WriteLine("Order ID : "+order.OrderID+" is cancelled successfully."+"status of the order is : "+OrderStatus.Cancelled);
                        break;
                    }



                }
               }
               if(!isValidate){
                System.Console.WriteLine("Invalid order ID");
               }

            }
            
            
           
            
            

        

        //default product Details
        public static void LoadDefaultData(){
        ProductDetails details1=new ProductDetails("Mobile(Samsung)",10,10000,3);
        ProductList.Add(details1);
        ProductDetails details2=new ProductDetails("Tablet(Lenovo)",5,15000,2);
        ProductList.Add(details2);
        ProductDetails details3=new ProductDetails("Camera(Sony)",3,20000,4);
        ProductList.Add(details3);
        ProductDetails details4=new ProductDetails("IPhone",5,50000,6);
        ProductList.Add(details4);
        ProductDetails details5=new ProductDetails("Laptop(Lenovo I3)",3,40000,3);
        ProductList.Add(details5);
        ProductDetails details6=new ProductDetails("HeadPhone(Boat)",5,1000,2);
        ProductList.Add(details6);
        ProductDetails details7=new ProductDetails("Speakers(Boat)",4,500,2);
        ProductList.Add(details7);

        //Order History
        

        //default orderDetails
        OrderDetails OrderObj1=new OrderDetails("CID1001","PID101",20000,2,OrderStatus.Ordered);
        OrderDetailsList.Add(OrderObj1);
        OrderDetails OrderObj2=new OrderDetails("CID1002","PID103",40000,2,OrderStatus.Ordered);
        OrderDetailsList.Add(OrderObj2);


         //default customer details
        CustomerDetails customerObj=new CustomerDetails("Ravi","Chennai",98858588,"ravi@mail.com",50000);
        EcommerceList.Add(customerObj);

        CustomerDetails customerObj1=new CustomerDetails("Baskaran","Chennai",9888475757,"baskarn@mail.com",60000);
        EcommerceList.Add(customerObj1);
        
        }
       
    
   
}
