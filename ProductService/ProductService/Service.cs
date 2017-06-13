using System.Collections.Generic;

namespace Service
{
    public class Service<T>
    {
      
        public Service()
        {
        }

        public List<T> GetData(List<T> data)
        {
            return new List<T>();
        }

        public List<T> GetData()
        {
            return new List<T>();
        }

        public List<int> GetSum(int groupRows,string column)
        {
            return new List<int>();
        }
    }
}
