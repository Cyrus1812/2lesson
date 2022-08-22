int Max(int arg1, int arg2, int arg3 )
{
    int result = arg1;
    if(arg2> result)result = arg2;
    if(arg3> result)result = arg3;
    return result;
}

int a1 = 22;
int b1 = 43;
int c1 = 12;
int a2 = 17;
int b2 = 53;
int c2 = 9;
int a3 = 54;
int b3 = 84;
int c3 = 61;

int max = Max(Max(a1,b1,c1),Max(a2,b2,c2),Max(a3,b3,c3));
Console.WriteLine(max);