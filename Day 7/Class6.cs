//
/* Create a program with enums having weeks name and number values
 */
using System;
namespace ConsoleApplication1
{

	// making an enumerator 'week'
	enum week
	{

		// following are the data members
		monday,
		tuesday,
		wednesday,
		thursday,
		friday,
		saturday,
		sunday


	}

	class Program
	{

		// Main Method
		static void Main(string[] args)
		{

			
			Console.WriteLine("The value of monday in week " +
							"enum is " + (int)week.monday);
			Console.WriteLine("The value of tuesday in week " +
							"enum is " + (int)week.tuesday);
			Console.WriteLine("The value of wednesday in week " +
							"enum is " + (int)week.wednesday);
			Console.WriteLine("The value of thursday in week " +
							"enum is " + (int)week.thursday);
			Console.WriteLine("The value of saturday) in week " +
							"enum is " + (int)week.saturday);

			Console.WriteLine("The value of sunday in week " +
			"enum is " + (int)week.sunday);

		}
	}
}
