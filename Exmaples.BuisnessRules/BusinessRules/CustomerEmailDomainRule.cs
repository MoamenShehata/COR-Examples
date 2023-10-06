namespace Exmaples.BuisnessRules.BusinessRules
{
	public class CustomerEmailDomainRule: BusinessRuleBase
	{
		public override int Order => 2;

		public override void Handle(PurchaseOrderRequest request)
		{
			if (!request.CustomerInfo.Email.Contains("@domain.com"))
			{
				Console.WriteLine($"Order for customer at {request.CustomerInfo.Email} is allowed to proceed with next rule");

				base.Handle(request);
			}
		}
	}
}