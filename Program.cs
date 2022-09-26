//Task4

int[,] nums = new int[3, 3];
Random rnd = new Random();
for (int i = 0; i < nums.GetLength(0); i++)
{
    for (int j = 0; j < nums.GetLength(1); j++)
    {
        nums[i, j] = rnd.Next() % 10;
        Console.Write(nums[i, j] + " (" + i + j + ") ");
    }
    Console.WriteLine();
}
bool ChetPos;
for (int i = 0; i < nums.GetLength(0); i++)
{
    for (int j = 0; j < nums.GetLength(1); j++)
    {
        if (i == j)
        {
            Console.WriteLine(nums[i, j] + " - Четное число");
        }
    }
}