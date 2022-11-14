using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prices
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

		public void LoadData(ref BindingList<Fuel> petrols, ref BindingList<Product> products)
		{
			bool fileWithPetrolsExists = File.Exists(PATH_TO_FUEL);
			bool fileWithProductsExists = File.Exists(PATH_TO_PRODUCTS);


			if (!fileWithPetrolsExists)
			{
				File.CreateText(PATH_TO_FUEL).Dispose();
				petrols = new BindingList<Fuel>();
			}
			else
			{
				using (StreamReader reader = File.OpenText(PATH_TO_FUEL))
				{
					string fileText = reader.ReadToEnd();
					if (fileText == "")
						petrols = new BindingList<Fuel>();
					else
						petrols = JsonConvert.DeserializeObject<BindingList<Fuel>>(fileText);
				}
			}

			if (!fileWithProductsExists)
			{
				File.CreateText(PATH_TO_PRODUCTS).Dispose();
				products = new BindingList<Product>();
			}
			else
			{
				using (StreamReader reader = File.OpenText(PATH_TO_PRODUCTS))
				{
					string fileText = reader.ReadToEnd();
					if (fileText == "")
						products = new BindingList<Product>();
					else
						products = JsonConvert.DeserializeObject<BindingList<Product>>(fileText);
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
