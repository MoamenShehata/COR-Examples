namespace Examples.MultTaskOperation.DeleteOperations
{
	public class DeleteMandatoryResourcesFirstOperation : DeleteOperation
	{
		public override int Order => 1;

		public override void HandleDelete(DeleteResourceGroupRequest request)
		{
			Console.WriteLine("Deleting first resources that will prevent resource group from being deleted");
			// may be remove locks or something
		}
	}

	public class SendConfirmationEmailOperation : DeleteOperation
	{
		public override int Order => 3;

		public override void HandleDelete(DeleteResourceGroupRequest request)
		{
			Console.WriteLine($"Congratulations! Your resource group {request.ResourceGroupName} is tottaly deleted from azure");
		}
	}


}