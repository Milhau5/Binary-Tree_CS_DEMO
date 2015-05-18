using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree_DEMO
{
	class Program
	{
		static void Main(string[] args)
		{
			//MyBinaryTree oTree = new MyBinaryTree();
			//oTree.Insert(23);
			//oTree.Insert(33);
			//oTree.Insert(47);

			//oTree.Traverse();

			MyBinaryTree oTree = new MyBinaryTree();
			oTree.Insert(23);
			oTree.Insert(33);
			oTree.Insert(13);
			oTree.Insert(47);
			oTree.Insert(18);
			oTree.Insert(7);

			oTree.Traverse();

			//Ending the program
			//Console.WriteLine("Press Enter to finish");
			Console.ReadLine();
		}
	}
}
