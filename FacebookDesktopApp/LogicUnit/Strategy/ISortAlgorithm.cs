namespace LogicUnit.Strategy
{
    public interface ISortAlgorithm
    {
        bool Sort(object i_FirstItemToCompare, object i_SecondItemToCompare);
    }
}