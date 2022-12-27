namespace CollectionCross
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string[] arrayOne = new string[] { "1", "84", "2", "1", "1", "5" };
			string[] arrayTwo = new string[] { "3", "2", "2", "5", "82" };  
			List<string> collectionSumaryOne = new List<string>();
			List<string> collectionSumaryTwo = new List<string>();
			collectionSumaryOne.AddRange(arrayOne);
			collectionSumaryTwo.AddRange(arrayTwo);

			for (int i = 0; i < collectionSumaryOne.Count; i++)            //Циклы удаления лишних элементов
				for (int j = i + 1; j < collectionSumaryOne.Count; j++)
				{
					if (collectionSumaryOne[i] == collectionSumaryOne[j])
					{
						collectionSumaryOne.RemoveAt(j);
						--j;
					}
				}
					
						
						

			for (int i = 0; i < collectionSumaryTwo.Count; i++)            //Циклы удаления лишних элементов
				for (int j = i + 1; j < collectionSumaryTwo.Count; j++)
				{
					if (collectionSumaryTwo[i] == collectionSumaryTwo[j])
					{
						collectionSumaryTwo.RemoveAt(j);
						--j;
					}		
				}
					

			foreach (var item in collectionSumaryOne)
			{
				collectionSumaryTwo.Contains(item);
				collectionSumaryTwo.Remove(item);
			}

			foreach (var item in collectionSumaryTwo)
			{
				collectionSumaryOne.Contains(item);
				collectionSumaryOne.Remove(item);
			}

			foreach (var item in collectionSumaryOne)
			{
				Console.Write(item);
			}

			Console.WriteLine();

			foreach (var item in collectionSumaryTwo)
			{
				Console.Write(item);
			}

			Console.WriteLine();

			collectionSumaryOne.AddRange(collectionSumaryTwo);

			foreach (var item in collectionSumaryOne)
			{
				Console.WriteLine(item);
			}


		}
	}
}