using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
namespace practise{
    class program {
        public static void Main (){
            // var sb = new StringBuilder();
            // for (int i = 0; i < 10000; i++)
            // {
            //     sb.Append(i).Append(",");
            // }
            // Console.WriteLine(sb.ToString());
            List<int> numbers = new List<int> { 1, 2, 3, 4 };
            var query = numbers.Where(n => n > 2).ToList();;
            numbers.Add(5);
            foreach (var n in query)
            {
            Console.WriteLine(n);
            }

        }
        
    }
}