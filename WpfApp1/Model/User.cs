using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model
{
	public class User
	{
		private string m_Name;
		private int m_UserImg;

		public string M_Name
		{
			get { return m_Name; }
			set { m_Name = value; }
		}

		public int M_UserImg
		{
			get { return m_UserImg; }
			set { m_UserImg = value; }
		}
	}
}
