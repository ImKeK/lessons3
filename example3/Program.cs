int[] array = {12, 27, 35, 4, 41, 51, 66, 74, 85};

int n = array.Length;
int find = 12;

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