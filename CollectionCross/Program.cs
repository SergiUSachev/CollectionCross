namespace CollectionCross
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string[] arrayOne = new string[] { "1", "84", "2", "1", "1", "5" };
			string[] arrayTwo = new string[] { "3", "2", "2", "5", "82" };
			
			List<string> collectionOne= new List<string>();
			List<string> collectionTwo = new List<string>();

			collectionOne = MakingFilteredCollection(arrayOne);
			collectionTwo = MakingFilteredCollection(arrayTwo);

			foreach (var item in collectionTwo)
			{
				if (!collectionOne.Contains(item))
				{
					collectionOne.Add(item);
				}
			}

			foreach (var item in collectionOne)
			{
				Console.Write(item);
				Console.Write(" ");
			}

			static List<string> MakingFilteredCollection(string[] array)
			{
				List<string> collection = new List<string>();
				foreach (var item in array)
				{
					if (!collection.Contains(item))
					{
						collection.Add(item);
					}
				}           
				return collection;
			}
		}
	}
}