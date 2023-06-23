int a = 46;
int b = 567;
int c = 813;
int a1 = 6;
int b1 = 78;
int c1 =23;
int a3 = 13;
int b3 = 123;
int c3 = 321;

int Max(int arg1, int arg2, int arg3)
{
    int max = arg1;
    if(arg2>max) max = arg2;
    if(arg3>max) max = arg3;
    return max;
}

int max = Max(Max(a,b,c),Max(a3,b3,c3),Max(a1,b1,c1));
Console.WriteLine(max);
