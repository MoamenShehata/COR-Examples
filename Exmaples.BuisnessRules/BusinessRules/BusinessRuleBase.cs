namespace Exmaples.BuisnessRules.BusinessRules
{
	public abstract class BusinessRuleBase : IBusinessRule
	{
		protected IBusinessRule Successor;

		public abstract int Order { get; }

		public virtual void Handle(PurchaseOrderRequest request)
		{
			if (Successor != null)
			{
				Successor.Handle(request);
			}
		}

		public void RegisterSuccessor(IBusinessRule successor)
		{
			Successor = successor;
		}
	}
}