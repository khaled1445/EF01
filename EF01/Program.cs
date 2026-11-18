using EF01.Data;

namespace EF01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (ApplicationDBContext context = new ApplicationDBContext());

        }
    }
}
