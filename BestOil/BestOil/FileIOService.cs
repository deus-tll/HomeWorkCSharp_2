using Newtonsoft.Json;
using System.ComponentModel;
using System.IO;

namespace BestOil
{
	class FileIOService
	{
		private readonly string PATH_TO_FUEL;
		private readonly string PATH_TO_PRODUCTS;

		public FileIOService(string pathToFuel, string pathToProducts)
		{
			PATH_TO_FUEL = pathToFuel;
			PATH_TO_PRODUCTS = pathToProducts;
		}

		public void LoadData(ref BindingList<Goods> petrols, ref BindingList<Goods> products)
		{
			bool fileWithPetrolsExists = File.Exists(PATH_TO_FUEL);
			bool fileWithProductsExists = File.Exists(PATH_TO_PRODUCTS);


			if (!fileWithPetrolsExists)
			{
				File.CreateText(PATH_TO_FUEL).Dispose();
				petrols = new BindingList<Goods>();
			}
			else
			{
				using (StreamReader reader = File.OpenText(PATH_TO_FUEL))
				{
					string fileText = reader.ReadToEnd();
					if (fileText == "")
						petrols = new BindingList<Goods>();
					else
						petrols = JsonConvert.DeserializeObject<BindingList<Goods>>(fileText);
				}
			}

			if (!fileWithProductsExists)
			{
				File.CreateText(PATH_TO_PRODUCTS).Dispose();
				products = new BindingList<Goods>();
			}
			else
			{
				using (StreamReader reader = File.OpenText(PATH_TO_PRODUCTS))
				{
					string fileText = reader.ReadToEnd();
					if (fileText == "")
						products = new BindingList<Goods>();
					else
						products = JsonConvert.DeserializeObject<BindingList<Goods>>(fileText);
				}
			}
		}


		public void SaveData(object list, string path)
		{
			using (StreamWriter writer = File.CreateText(path))
			{
				writer.WriteLine(JsonConvert.SerializeObject(list));
			}
		}
	}
}
