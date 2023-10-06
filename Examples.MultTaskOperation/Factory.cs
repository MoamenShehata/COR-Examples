namespace Examples.MultTaskOperation
{
	public static class Factory
	{
		public static IDeleteHandler Create()
		{
			return new DeleteHandler();
		}
	}
}