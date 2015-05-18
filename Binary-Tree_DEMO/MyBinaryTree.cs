using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree_DEMO
{
	class MyBinaryTree
	{
		private Node m_Root; //base of the tree

		//Properties
		public Node Root
		{
			get { return m_Root; }
		}

		//constructor
		public MyBinaryTree()
		{
			m_Root = null;
		}
		//traverse the tree in order
		public void Traverse()
		{
			Traverse(m_Root);
		}

		//traverse the tree in order
		private void Traverse(Node node)
		{
			if (node != null)
			{
				Traverse(node.Left);
				Console.WriteLine(node);
				Traverse(node.Right);
			}
		}
		//Insert a node in tree
		public void Insert(int a_Data)
		{
			//If there is not a root the new node is going to be it
			//if there is we provide the new data as an argument to 
			//the other Insert method
			if (m_Root == null)
				m_Root = new Node(a_Data);
			else
				Insert(a_Data, m_Root);
		}


		//Insert and arrange node in tree
		private void Insert(int a_Data, Node node)
		{
			//If a_Data's value is less than the current node go left
			if (a_Data < node.Data)
			{
				if (node.Left != null) //if there is info to the left
				{
					Insert(a_Data, node.Left);	//recursively go inside the node
				}
				else //If there is no node to the left
				{
					node.Left = new Node(a_Data); //Create a new node with a_Data
				}
			}
			else//go right
			{
				if (node.Right != null) //if there is info to the right
				{
					Insert(a_Data, node.Right);	//recursively go inside the node
				}
				else //If there is no node to the right
				{
					node.Right = new Node(a_Data); //Create a new node with a_Data
				}
			}
		}
	}
}
