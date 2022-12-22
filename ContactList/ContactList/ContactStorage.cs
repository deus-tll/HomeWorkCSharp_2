using System.ComponentModel;

namespace ContactList
{
	public class ContactStorage
	{
		private readonly BindingList<Contact> _contacts;

		public ContactStorage(BindingList<Contact> contacts)
		{
			_contacts = contacts;
		}

		public BindingList<Contact> GetContacts() => _contacts;
	}
}