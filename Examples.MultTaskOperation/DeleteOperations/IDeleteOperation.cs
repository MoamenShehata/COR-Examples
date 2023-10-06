namespace Examples.MultTaskOperation.DeleteOperations
{
	public interface IDeleteOperation : IDeleteHandler
	{
		 int Order { get; }
		void RegisterSuccessor(IDeleteOperation successor);
	}
}