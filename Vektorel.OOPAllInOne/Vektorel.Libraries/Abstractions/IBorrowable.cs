namespace Vektorel.Libraries.Abstractions
{
    public interface IBorrowable
    {
        public void Borrow(string phone);
        public void Return();
    }
}
