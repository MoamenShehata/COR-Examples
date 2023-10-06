using Examples.MultTaskOperation.DeleteOperations;
using System.Reflection;

namespace Examples.MultTaskOperation
{
	public class DeleteHandler : IDeleteHandler
	{
		public void Handle(DeleteResourceGroupRequest request)
		{
			var deleteOperations = Assembly.GetCallingAssembly()
					.GetTypes()
					.Where(t => t.IsAssignableTo(typeof(IDeleteOperation)))
					.Where(t => !t.IsInterface)
					.Where(t => !t.IsAbstract)
					.Select(t => Activator.CreateInstance(t) as IDeleteOperation)
					.OrderBy(t => t.Order)
					.ToArray();

			var root = deleteOperations.FirstOrDefault();
			for (int i = 0; i < deleteOperations.Count() - 1; i++)
			{
				deleteOperations[i].RegisterSuccessor(deleteOperations[i + 1]);
			}

			root.Handle(request);
		}

	}
}
