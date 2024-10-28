/*
1. String ustida amallar
String tipida (string str) qiymat berilgan. Consoleda int tipidagi qiymat kiriting. Agar bu son str ning
uzunligidan katta bo’lsa, str ni katta harflarga o’giring, aks holda kichik harflarga o’giring.

Input: x=13, str=”teLefOn”
Output: “TELEFON”
---------------
Input: x=4, str=”komPyuter”
Output: “kompyuter”



System.Console.Write ("Satrni kiriting: ");
string s = Console.ReadLine();
System.Console.Write ("Sonni kiriting: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n > s.Length)
{
    string upperText = s.ToUpper();
    System.Console.WriteLine(upperText);
} 
else
{
    string lowerText = s.ToLower();
    System.Console.WriteLine(lowerText);
}

*/


// 2.
// Quyida ternary operator bilan ifodalandan qiymatni if-else yordamida ifodalang.
/*
int x = 15;
int y = 10;
string result; 
if (x>y)
{
   result = "x is greater than y";
}
else if (x<y)
{
    result = "x is less than y";
}
else if (x == y)
{
   result = "x is equal to y";
}
else
{
    result = "x and y are not comparable";
}
System.Console.WriteLine(result);
*/

// 3. Consoleda o’zbek tilida kiritilgan hafta kunini ingliz tiliga o’girib, natijani ekranga chiqaradigan
// dastur tuzing. Switch expression dan foydalaning!

using System.Security.Cryptography;

System.Console.Write("Hafta kunini kiriting: ");
string uzbekHaftasi = Console.ReadLine();

string weekday = uzbekHaftasi.ToLower()
switch 
{
    "dushanba" => "Monday",
    "seshanba" => "Tuesday",
    "chorsahnba" => "Wednesday",
    "payshanba" => "Thursday",
    "juma" => "Friday",
    "shanba" => "Saturday",
    "yakshanba" => "Sunday",
    _ => "Bunday hafta kuni mavjud emas"
};
System.Console.WriteLine("Kiritligan kunning inglizcha tarjimasi: " + weekday);





