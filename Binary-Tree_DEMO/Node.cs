using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree_DEMO
{
	class Node
	{
		//Fields
		private Node m_Left;//Node to the small element
		private Node m_Right;//Node to the large element
		private int m_nData;//Information of the node

		//Properties
		public Node Left
		{
			get { return m_Left; }
			set { m_Left = value; }
		}
		public Node Right
		{
			get { return m_Right; }
			set { m_Right = value; }
		}
		public int Data
		{
			get { return m_nData; }
			set { m_nData = value; }
		}

		//Constructor
		public Node(int a_nData)
		{
			m_nData = a_nData;
			m_Left = null;
			m_Right = null;
		}

		//override ToString
		public override string ToString()
		{
			//If node has a left value say L if not -
			string output = "";
			if (m_Left != null)
				output += "L";
			else
				output += "-";

			//value of the Node
			output += " " + m_nData + " ";

			//If node has a right value say R if not -
			if (m_Right != null)
				output += "R";
			else
				output += "-";

			return output;
		}
	}
}
