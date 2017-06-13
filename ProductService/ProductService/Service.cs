using System.Collections.Generic;

namespace Service
{
    internal class Service<T>
    {
      
        public Service()
        {
        }

        internal List<T> GetData(List<T> data)
        {
            return new List<T>();
        }

        internal List<T> GetData()
        {
            return new List<T>();
        }

        internal List<int> GetSum(int groupRows,string column)
        {
            return new List<int>();
        }
    }
}
