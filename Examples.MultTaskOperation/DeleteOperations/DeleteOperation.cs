namespace Examples.MultTaskOperation.DeleteOperations
{
	public abstract class DeleteOperation : IDeleteOperation
	{
		protected IDeleteOperation Successor;

		public abstract int Order { get; }

		public abstract void HandleDelete(DeleteResourceGroupRequest request);

		public void Handle(DeleteResourceGroupRequest request)
		{
			HandleDelete(request);

			if (Successor != null)
			{
				Successor.Handle(request);
			}
		}

		public void RegisterSuccessor(IDeleteOperation successor)
		{
			Successor = successor;
		}
	}
}