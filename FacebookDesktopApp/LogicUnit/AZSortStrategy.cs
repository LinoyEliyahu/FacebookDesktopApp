using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace FacebookLogic.Strategy
{
    public class AZSortStrategy : ISortAlgorithm
    {
        public bool Sort(object i_FirstItemToCompare, object i_SecondItemToCompare)
        {
            bool isSwap = false;

            Page page1 = i_FirstItemToCompare as Page;
            Page page2 = i_SecondItemToCompare as Page;
            if (string.Compare(page1.Name, page2.Name) > 0)
            {
                isSwap = true;
            }

            return isSwap;
        }
    }
}