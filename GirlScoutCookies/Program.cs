using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//In order to win the prize for most cookies sold, my friend Alice and I are going to merge our Girl Scout Cookies orders and enter as one unit.

//Each order is represented by an "order id" (an integer).

// We have our lists of orders sorted numerically already, in arrays.Write a method to merge our arrays of orders into one sorted array.
// sample data:
//  int[] myArray = { 3, 4, 6, 10, 11, 15 };
//int[] alicesArray = { 1, 5, 8, 12, 14, 19 };
namespace GirlScoutCookies
{

	//TODO: add check for edge cases
	//TODO: use another method
	class Program
	{
		public static int[] mergedOrders(int[] myArray, int[] alicesArray)
		{
			int[] mergedArray = new int[myArray.Length + alicesArray.Length];
			
			//copy myArray to mergedArray starting at index0
			myArray.CopyTo(mergedArray, 0);
			
			//copy alicesArray to mergedArray starting after the end of myArray.Length
			alicesArray.CopyTo(mergedArray, myArray.Length);


			//sort array numerically
			Array.Sort(mergedArray);

			foreach (int orderid in mergedArray)
			{
				Console.WriteLine(orderid);
			}
			return mergedArray;
			
		}
		static void Main(string[] args)
		{
			int[] myArray = { 3, 4, 5, 6, 10, 11, 15 };
			int[] alicesArray = { 1, 5, 8, 12, 14, 19 };
			mergedOrders(myArray, alicesArray);
		}
	}
}
