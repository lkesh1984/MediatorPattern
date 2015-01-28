using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
	public class Program
	{
		static void Main(string[] args)
		{
			ChatRoom room = new ChatRoom();
			User user1 = new User(room);
			user1.Name = "Lokesh";
			user1.SendMessage("Hi");

			User user2 = new User(room);
			user2.Name = "Lokesh1";
			user2.SendMessage("Hi");
		}
	}

	public class User
	{
		private ChatRoom _room;
		public string Name { get; set; }
		public User(ChatRoom room)
		{
			this._room = room;
		}

		public void SendMessage(string message)
		{
			this._room.SendMessage(this, message);
		}
	}

	public class ChatRoom
	{
		public void SendMessage(User user, string message)
		{
			Console.WriteLine("User: {0}, Message: {1}", user.Name, message);
		}
	}
}
