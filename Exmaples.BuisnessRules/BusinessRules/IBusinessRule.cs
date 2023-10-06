namespace Exmaples.BuisnessRules.BusinessRules
{
	public interface IBusinessRule : IRequestHandler
	{
		int Order { get; }
		void RegisterSuccessor(IBusinessRule successor);
	}
}