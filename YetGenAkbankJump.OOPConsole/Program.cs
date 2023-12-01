using YetGenAkbankJump.OOPConsole.Utilities;

var passwordGenerator = new PasswordGenerator();

Console.WriteLine("Lütfen şifre için istediğiniz karakter sayısını giriniz.");

var response = Console.ReadLine();

if (string.IsNullOrEmpty(response))
{
    Console.WriteLine("God damn it son!");

    return 0;
}

var password = passwordGenerator.Generate(Convert.ToInt32(response));

Console.WriteLine($"Şifreniz: {password}");
 
Console.ReadLine();

return 1;
