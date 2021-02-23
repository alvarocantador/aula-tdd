namespace AulaTDD.interfaces
{
    public interface IBook
    {
        string Title { get; set; }
        bool IsAvailable { get; }
        void Borrow();
    }
}
