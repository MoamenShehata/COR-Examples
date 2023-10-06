namespace Examples.MultTaskOperation.DeleteOperations
{
	public class SoftDeleteResourceGroupOperation : DeleteOperation
	{
		public override int Order => 0;

		public override void HandleDelete(DeleteResourceGroupRequest request)
		{
			Console.WriteLine("resource group is soft deleted from the db!");
		}

	}


}