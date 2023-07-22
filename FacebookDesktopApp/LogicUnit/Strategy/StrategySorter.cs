namespace LogicUnit.Strategy
{
    public class StrategySorter
    {
        public ISortAlgorithm SortAlgorithm { get; set; } = new AzSortStrategy();

        public void StrategySort(object[] i_Array)
        {
            for (int index1 = i_Array.Length / 2; index1 > 0; index1 /= 2)
            {
                for (int index2 = index1; index2 < i_Array.Length; index2++)
                {
                    for (int index3 = index2 - index1; index3 >= 0; index3 -= index1)
                    {
                        if (SortAlgorithm.Sort(i_Array[index3], i_Array[index3 + index1]))
                        {
                            (i_Array[index3], i_Array[index3 + index1]) = (i_Array[index3 + index1], i_Array[index3]);
                        }
                    }
                }
            }
        }
    }
}