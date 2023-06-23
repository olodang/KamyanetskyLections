int [] array = {2,6,45,35,2,76,17,18};
//array[2] = 777;
int n = array.Length;
int find = 2;
int index = 0;

while(index<n)
{
    if(array[index]==find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;

}
