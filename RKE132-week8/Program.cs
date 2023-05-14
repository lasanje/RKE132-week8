string folderPath = @"C:\data\";
string heroFile = "heroes.txt";
string villainFile = "villains.txt";

string[] heros = File.ReadAllLines(Path.Combine(folderPath, heroFile));
string[] villains = File.ReadAllLines(Path.Combine(folderPath, villainFile));


//string[] heros = { "harry potter", "Luke", "lara", "scooby" };
//string[] villains = { "voldemor", "drath", "dracula", "joker", "sauron" };
string[] weapon = { "õun", "banaan", "püss", "kahvel" };


string hero = GetRandomValueFromArray(heros);
string heroWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Today {hero}´with {heroWeapon} saves the day");

string villain = GetRandomValueFromArray(villains);
string villianWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Today {villains} with {villianWeapon} tries to take over the world");
static string GetRandomValueFromArray(string[] someArray)
{
    Random rnd = new Random();
    int randomIndex = rnd.Next(0, someArray.Length);
    string randomStringFromArray = someArray[randomIndex];
    return randomStringFromArray;
}