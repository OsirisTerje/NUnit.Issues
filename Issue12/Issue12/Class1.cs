using System.Threading.Tasks;

namespace Issue12
{
    public class Class1
    {
        public async Task<int> AddAsync(int a, int b)
        {
            Task<int> insideAddTask = InsideAdd(a, b);
            var res = await insideAddTask;
            return res;
        }

        Task<int> InsideAdd(int x, int y)
        {
            return Task.Run(()=>x + y);
        }

        public int Add(int x, int y)
        {
            return x + y;
        }
    }
}
