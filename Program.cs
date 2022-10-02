string[] array = { "hello", "2", "world", ":-)", "1234", "1567", "-2", "Russia", "Denmark", "Kazan" };
string[] result = new string[new Random().Next(0, 4)];
Random rnd = new Random();

for (int i = 0; i < result.Length; i++) 
{
result[i] = array[rnd.Next(array.Length)];
}
