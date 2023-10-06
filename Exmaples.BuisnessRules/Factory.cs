namespace Exmaples.BuisnessRules
{
	public static class Factory
	{
		public static IRequestHandler Creat()
		{
			return new RequestHandler();
		}
	}
}