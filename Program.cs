string[] food = { "pizza", "carbonara", "spinaci", "frittata", "hamburger", };
Console.WriteLine("lunghezza classifica:" + " " + food.Length + " " + "posizioni");

for (int i = 0; i < food.Length; i++)
{
    Console.WriteLine( i + " " + food[i]);
}


Console.WriteLine("Cibo in prima posizione:" + " " + food[1]);

Console.WriteLine("Cibo preferito in ultima posizione:" + " " + food[food.Length -1]);

Console.WriteLine("Cibo a metà classifica:" + " " + food[food.Length / 2]);
