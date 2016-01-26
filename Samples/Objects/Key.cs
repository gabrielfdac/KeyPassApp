#region Header
// © 2015
// Author:      Gabriel Fernandes
// Date:        10/5/2015 8:38:35 PM
#endregion

using System;
using System.Drawing;
using System.Text;

namespace KeyPassInfoObjects
{
	/// <summary>
	/// 
	/// </summary>
	[Serializable]
	public class Key
	{
		#region Non-Public Data Members

		private string _name = string.Empty;
		private string _userName = string.Empty;
		private string _password = string.Empty;
		private string _uri = null;
		private string _notes = string.Empty;

		private Image _image = null;

		#endregion

		#region Non-Public Properties/Methods

		#endregion

		#region Public Interface

		/// <summary>
		/// 
		/// </summary>
		public Key()
		{

		}

		/// <summary>
		/// 
		/// </summary>
		public string Title
		{
			get { return _name; }
			set { _name = value; }
		}

		/// <summary>
		/// 
		/// </summary>
		public string UserName
		{
			get { return _userName; }
			set { _userName = value; }
		}

		/// <summary>
		/// 
		/// </summary>
		public string Password
		{
			get { return _password; }
			set { _password = value; }
		}

		/// <summary>
		/// 
		/// </summary>
		public string Url
		{
			get { return _uri; }
			set { _uri = value; }
		}

		/// <summary>
		/// 
		/// </summary>
		public string Notes
		{
			get { return _notes; }
			set { _notes = value; }
		}

		/// <summary>
		/// 
		/// </summary>
		public Image Image
		{
			get { return _image; }
			set { _image = value; }
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendFormat(@"Title = {0}{1}", Title, Environment.NewLine);
			sb.AppendFormat(@"UserName = {0}{1}", UserName, Environment.NewLine);
			sb.AppendFormat(@"Password = {0}{1}", Password, Environment.NewLine);
			sb.AppendFormat(@"Url = {0}{1}", Url, Environment.NewLine);
			sb.AppendLine(@"Notes");
			sb.AppendLine(@"----------------------------------------------------------");
			sb.AppendLine(Notes);
			return sb.ToString();
		}
		#endregion
	}
}
