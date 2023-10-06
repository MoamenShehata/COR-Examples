// See https://aka.ms/new-console-template for more information
using Examples.MultTaskOperation;

Console.WriteLine("Hello, World!");

var deleteRequest = new DeleteResourceGroupRequest
{
	ResourceGroupName = "my-rg",
};

var requestHandler = Factory.Create();
requestHandler.Handle(deleteRequest);
Console.ReadLine();