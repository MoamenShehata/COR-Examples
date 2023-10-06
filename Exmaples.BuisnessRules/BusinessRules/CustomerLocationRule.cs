namespace Exmaples.BuisnessRules.BusinessRules
{
	public class CustomerLocationRule : BusinessRuleBase
	{
		public override int Order => 1;

		public override void Handle(PurchaseOrderRequest request)
		{
			if (request.CustomerInfo.Location != "some-country")
			{
				Console.WriteLine($"Order for customer at {request.CustomerInfo.Location} is allowed to proceed with next rule");

				base.Handle(request);
			}
		}
	}
}