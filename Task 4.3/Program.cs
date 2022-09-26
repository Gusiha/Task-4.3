

Console.WriteLine(A.Sum(2, "hello", 3));

internal static class A
{
    public static int Sum(params object[] arr)
    {
        return arr.Length;
    }
}