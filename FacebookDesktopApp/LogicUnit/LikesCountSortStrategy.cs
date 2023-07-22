using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace FacebookLogic.Strategy
{
    public class LikesCountSortStrategy : ISortAlgorithm
    {
        public bool Sort(object i_FirstItemToCompare, object i_SecondItemToCompare)
        {
            bool isSwap = false;

            Page page1 = i_FirstItemToCompare as Page;
            Page page2 = i_SecondItemToCompare as Page;
            if (page1.LikesCount < page2.LikesCount)
            {
                isSwap = true;
            }

            return isSwap;
        }
    }
}
