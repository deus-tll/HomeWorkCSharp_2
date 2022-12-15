using Newtonsoft.Json;
using System.ComponentModel;
using System.IO;

namespace ContactList
{
	public class FileIOService
	{
		private readonly string PATH;

		public FileIOService(string path) => PATH = path;

		public BindingList<Contact> LoadData()
		{
			bool fileExists = File.Exists(PATH);

			if (!fileExists)
			{
				File.CreateText(PATH).Dispose();
				return new BindingList<Contact>();
			}

			using (StreamReader reader = File.OpenText(PATH))
			{
				string fileText = reader.ReadToEnd();

				return fileText == "" ? new BindingList<Contact>() : JsonConvert.DeserializeObject<BindingList<Contact>>(fileText);
			}
		}

		public void SaveData(object contactList)
		{
			using (StreamWriter writer = File.CreateText(PATH))
			{
				writer.WriteLine(JsonConvert.SerializeObject(contactList));
			}
		}
	}
}