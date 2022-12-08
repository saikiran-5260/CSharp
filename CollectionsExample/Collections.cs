


List<int> newList;
newList = new List<int> { 5,7,3,1,6,10 };

for(int i=0; i < newList.Count; i++)
{
    Console.Write(newList[i]+ " ");
}
Console.WriteLine("\n");
foreach (int element in newList)
{
    
    Console.Write(element + " ");
}
newList.Reverse();
Console.WriteLine("\n");
foreach (int el in newList)
{
    Console.Write(el+" ");
}
newList.Sort();
Console.WriteLine("\n");
foreach (int ele in newList)
{
    Console.Write(ele+" ");
}