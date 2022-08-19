string[]array = {"1234", "asdf", "ok!", ":-)"};
string[]newArray = new string[4];
int i = 0; int j = 0;
while(i < array.Length)
{
    if (array[i].Length <=3)
    {
        newArray[j] = array[i];
        j++;
    }
    i++;
}
Console.Write("["+ string.Join(", ",array) +"]");
Console.WriteLine();
Console.Write("[" + string.Join(", ",newArray) + "]");