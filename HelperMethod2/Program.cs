using System;

namespace HelperMethod
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			string myValue = superSecretFormula();
			Console.WriteLine(myValue);
			Console.ReadLine();
		}

		private string superSecretFormula()
		{
            //stuff here 
            return "Hello World";

		}

        private static string superSecretFormula(string name)
        {
            return String.Format("Hello , {0}", name);


        }



	}
}




//private can only be called inside the class, unlike public
//use camel case to indicate that it is private or scope
//when you write a method, you are limiting what you need to change
//can offload certain operations to other methods
// name == input parameter