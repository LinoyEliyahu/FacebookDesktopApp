using FacebookWrapper.ObjectModel;
using static System.String;

namespace LogicUnit.Strategy
{
    public class AzSortStrategy : ISortAlgorithm
    {
        public bool Sort(object i_FirstItemToCompare, object i_SecondItemToCompare)
        {
            bool isSwap = false;

            Page page1 = i_FirstItemToCompare as Page;
            Page page2 = i_SecondItemToCompare as Page;
            if (CompareOrdinal(page1?.Name, page2?.Name) > 0)
            {
                isSwap = true;
            }

            return isSwap;
        }
    }
}