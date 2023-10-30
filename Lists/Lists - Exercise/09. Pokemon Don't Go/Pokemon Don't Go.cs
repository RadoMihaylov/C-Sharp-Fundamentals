using System.Dynamic;

namespace _09._Pokemon_Don_t_Go
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  
            1.Receiving a input -> receiving nums corresponds to index and remove ints from array
            2.When we remove, we should increase and decrease!
              --> whe should increase the elements with less or equal value to removed value.
              --> whe should decrease the elements wich are greater than removed value.
            3.If the index <= 0 == remove first element and copy last to its place. / if thr index > last index == remove last index and copy the first to its place.
             --> we increase and decrease elements and in that situations with removed value
            4.When we dont have elements, the programme END!!!
             
            5 10 6 3 5 
            2 --> 11 4 9 11 
            4 --> 22 15 20 22 = we remove last index and copy first to its place, when increase with removes value 11.
            1 --> 7 5 7 = remove 15 and decrease with 15.
            1 --> 2 2 = remove 5 and decrease with 5
            3 --> 4 4 = remove 2 and copy the first to its place, then we increase with removed value 2.
            0 --> 8 = we remove and increase with 4
            0 --> we remove 8
            End
            11 + 15 + 6+ 8 + 2+ 5  +2 

            4 5 3
            1
            1
            0
             */

            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> removedElements = new List<int>();
            int sum = 0;

            while (input.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());
                int removeElement = 0;
                if (index < 0)
                {
                    removeElement = input[0]; //
                    input[0] = input[input.Count - 1];
                }
                else if (index > input.Count - 1)
                {
                    int firstElementValue = input[0];
                    removeElement = input[input.Count - 1];
                    input[input.Count - 1] = firstElementValue;
                }
                else
                {
                    removeElement = input[index];
                    input.RemoveAt(index);
                    
                }
                removedElements.Add(removeElement);
                sum += removeElement;
                
                for (int element = 0; element < input.Count; element++)
                {
                    if (input[element] <= removeElement)
                    {
                        input[element] += removeElement;
                    }
                    else if (input[element] > removeElement)
                    {
                        input[element] -= removeElement;
                    }
                }
            }
                Console.WriteLine(sum);
        }

    }
}
