using DiaBot;
using System.Data.SqlClient;
using Telegram.Bot;

Connection_String con = new Connection_String();
const string TOKEN = "5774023928:AAH0Zj0hgqpgErS0KX5mOeDb9Ze-A_C_BQw";

while (true)
{
	try
	{
		GetMessages().Wait();
	}
	catch (Exception ex)
	{
		Console.WriteLine("Error: " + ex);	
	}
}

void RegisterUser(string username)
{
    using (SqlConnection connection = new SqlConnection(con.Connection_string))
    {
        connection.Open();
        SqlCommand comm = new SqlCommand();
        comm.Connection = connection;
        comm.CommandText = "INSERT INTO Users VALUES(@username)";
        comm.Parameters.AddWithValue("@username", username);
        comm.ExecuteNonQuery();
        connection.Close();
    }
}

async Task GetMessages()
{
	TelegramBotClient bot = new TelegramBotClient(TOKEN);
	int offset = 0;
	int timeout = 0;

	try
	{
		await bot.SetWebhookAsync("");
		while (true)
		{
			var updates = await bot.GetUpdatesAsync(offset, timeout);

			foreach (var update in updates)
			{
				var message = update.Message;

				if (message.Text == "DiaBot")
				{
					Console.WriteLine("Получено сообщение: " + message.Text);
					await bot.SendTextMessageAsync(message.Chat.Id, "Привет НУРЛАНЧИК, я твой бот(микаил), слшуюась и повинуюсь тебя");
				}
				if (message.Text == "/reg")
				{
					RegisterUser(message.Chat.Username.ToString());
					await bot.SendTextMessageAsync(message.Chat.Id, "Пользователь зарегистрирован");
                }
				offset = update.Id + 1;
			}
		}
	}
	catch (Exception ex)
	{
        Console.WriteLine("Error: " + ex);
	}
}
