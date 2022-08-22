int[] array = {1,45,22,48,96,13,75,56};

int n = array.Length;
int find = 22;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}