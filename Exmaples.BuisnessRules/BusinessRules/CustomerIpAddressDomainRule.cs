namespace Exmaples.BuisnessRules.BusinessRules
{
	public class CustomerIpAddressDomainRule : BusinessRuleBase
	{
		public override int Order => 3;

		public override void Handle(PurchaseOrderRequest request)
		{
			if (!request.CustomerInfo.IpAddress.Contains("127"))
			{
				Console.WriteLine($"Order for customer at {request.CustomerInfo.Email} is allowed to proceed with next rule");

				base.Handle(request);
			}
		}
	}
}