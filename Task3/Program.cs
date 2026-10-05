byte smallNumber = 2;
short mediumNumber = 4;
long largeNumber = 10;
int normalNumber = 8;
float singlePrecision = 9;
double doublePrecision = 20;
decimal highPrecision = 18;
char SingleChar = 'a';
bool isTrue = true;
string s = "3.14";

string convertedInt = normalNumber.ToString();
double convertedString = Convert.ToDouble(s);

Console.WriteLine($"int; {normalNumber}");
Console.WriteLine($"int; {s}");

