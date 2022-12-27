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
			collectionOne.AddRange(arrayOne);
			collectionTwo.AddRange(arrayTwo);

			collectionOne = removeDuplicatedElements(collectionOne);
			collectionTwo = removeDuplicatedElements(collectionTwo);

			collectionOne = removeCrossElements(collectionTwo, collectionOne);
			collectionTwo = removeCrossElements(collectionOne, collectionTwo);

			collectionOne.AddRange(collectionTwo);

			foreach (var item in collectionOne)
			{
				Console.Write(item);
				Console.Write(" ");
			}

			static List<string> removeDuplicatedElements(List<string> collection)
			{
				for (int i = 0; i < collection.Count; i++)            
					for (int j = i + 1; j < collection.Count; j++)
					{
						if (collection[i] == collection[j])
						{
							collection.RemoveAt(j);
							--j;
						}
					}

				return collection;
			}

			static List<string> removeCrossElements(List<string> collectionOne, List<string>  collectionTwo)
			{
				foreach (var item in collectionOne)
				{
					collectionTwo.Contains(item);
					collectionTwo.Remove(item);
				}
				return collectionTwo;
			}


		}
	}
}