using Exmaples.BuisnessRules.BusinessRules;
using System.Reflection;

namespace Exmaples.BuisnessRules
{
	public class RequestHandler : IRequestHandler
	{
		public void Handle(PurchaseOrderRequest request)
		{
			var businessRules = Assembly.GetCallingAssembly()
					.GetTypes()
					.Where(t => t.IsAssignableTo(typeof(IBusinessRule)))
					.Where(t => !t.IsInterface)
					.Where(t => !t.IsAbstract)
					.Select(t => Activator.CreateInstance(t) as IBusinessRule)
					.OrderBy(t => t.Order)
					.ToArray();

			var root = businessRules.FirstOrDefault();
			for (int i = 0; i < businessRules.Count() - 1; i++)
			{
				businessRules[i].RegisterSuccessor(businessRules[i + 1]);
			}

			root.Handle(request);
		}
	}
}