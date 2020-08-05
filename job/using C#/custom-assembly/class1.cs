/*************
Job: C# Custom Assembly
Description: 
    1. Create a custom Class
    2. Register/Deploy assembly
*************/

namespace DataUtilities {
	public class Convertor {
		public static float BtyesTokb(long? btyes) {
			return (float)btyes/1000;
		}
	}
}