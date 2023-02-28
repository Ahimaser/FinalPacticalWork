using System.Linq;

public static class SelectonArr
{
    /// <summary>
    /// Метод оставляет в массиве элементы длиной до 3 символов
    /// </summary>
    /// <param name="arr">Исходный массив</param>
    /// <returns></returns>
    public static string [] Change(string[] arr)
    {

        string[] arrselect = new string[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Length <= 3)
            {
                arrselect[i] = arr[i];
            }
            ;
        }
        return arrselect;
    }
    
    /// <summary>
    /// Метод убирающий все элементы равные 0
    /// </summary>
    /// <param name="arr"></param>
    /// <returns></returns>
    public static string[] Select(string[] arr)
    {
        string[] newarr = arr.Where(s => s != null).ToArray();

        return newarr;
    }
}