namespace Exmaples.BuisnessRules
{
	public interface IRequestHandler
	{
		void Handle(PurchaseOrderRequest request);
	}
}