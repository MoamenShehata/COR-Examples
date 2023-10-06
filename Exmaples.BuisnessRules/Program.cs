// See https://aka.ms/new-console-template for more information
using Exmaples.BuisnessRules;

Console.WriteLine("Hello, World!");

var order = new PurchaseOrderRequest
{
	Products = new List<string>
	{
		"Labptob",
		"iPhone",
		"Television"
	},
	CustomerInfo = new CustomerInfo
	{
		Location = "Nigeria",
		Email = "customer@domainX.com",
		IpAddress = "128.0.0.1",
	},
};

var handler = Factory.Creat();
handler.Handle(order);
Console.ReadLine();