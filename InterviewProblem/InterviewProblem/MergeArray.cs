using System.Collections.Generic;

namespace InterviewProblem
{
    public class MergeArray
    {
        public static char[] Merge(char[] array1, char[] array2)
        {
            if (array1 == null || array1.Length == 0)
            {
                return array2;
            }

            if (array2 == null || array2.Length == 0)
            {
                return array1;
            }

            var array1Queue = new Queue<char>(array1);
            var array2Queue = new Queue<char>(array2);
            
            var output = new Queue<char>(array1.Length + array2.Length);

            while (array1Queue.Count > 0)
            {
                output.Enqueue(array1Queue.Dequeue());

                if (array2Queue.Count > 0)
                {
                    output.Enqueue(array2Queue.Dequeue());
                }
            }

            while (array2Queue.Count > 0)
            {
                output.Enqueue(array2Queue.Dequeue());
            }

            return output.ToArray();
        }
    }
}
