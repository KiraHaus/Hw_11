using Hw_11;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

Client client1 = new Client("Кирилл", "Паладич", "Максимович", "+79521109088", "4235 678905");
Client client2 = new Client("Теодор", "Мосби", "Эвелин", "45 56 76589");

client1.ShowInfo();
client2.ShowInfo();

Consultant consult1 = new Consultant("Sam");
Manager manage1 = new Manager("Ken");

Console.WriteLine(consult1.ClientName(client1));
Console.WriteLine(manage1.ClientName(client2));

manage1.ChangeClientName(client2, "Барни", "Стинсон", "Джеромович");
Console.WriteLine(manage1.ClientName(client2));
Console.WriteLine(consult1.ClientName(client2));