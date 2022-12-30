namespace CollectionCross
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string[] arrayOne = new string[] { "1", "84", "2", "1", "1", "5" };
			string[] arrayTwo = new string[] { "3", "2", "2", "5", "82" };

			List<string> collection = new List<string>();

			collection = MakingFilteredCollection(collection, arrayOne);
			collection = MakingFilteredCollection(collection, arrayTwo);

			foreach (var item in collection)
			{
				Console.Write(item);
				Console.Write(" ");
			}

			static List<string> MakingFilteredCollection(List<string> collection, string[] array)
			{

				foreach (var item in array)
				{
					if (collection.Contains(item))
					{

					}
					else
					{
						collection.Add(item);
					}
				}

				return collection;
			}
		}
	}
}