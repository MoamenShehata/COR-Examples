namespace Examples.MultTaskOperation.DeleteOperations
{
	public class DeleteRGOperation : DeleteOperation
	{
		public override int Order => 2;

		public override void HandleDelete(DeleteResourceGroupRequest request)
		{
			Console.WriteLine($"Deleting Resource group {request.ResourceGroupName} itself");
		}
	}


}