#region Header
// © 2015
// Author:      Gabriel Fernandes
// Date:        10/5/2015 8:38:35 PM
#endregion


using System;
using System.Collections.Generic;

namespace KeyPassInfoObjects
{
	/// <summary>
	/// 
	/// </summary>
	[Serializable]
	public class KeyChainDocument
	{
		#region Non-Public Data Members

		private string _name = string.Empty;
		private bool _isModified = false;
		private List<Group> _groups = new List<Group>();

		#endregion

		#region Non-Public Properties/Methods

		#endregion

		#region Public Interface

		/// <summary>
		/// 
		/// </summary>
		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		/// <summary>
		/// Gets the underlying document's data
		/// </summary>
		public List<Group> Groups
		{
			get { return _groups; }
		}

		/// <summary>
		/// 
		/// </summary>
		public bool IsModified
		{
			get { return _isModified; }
			set { _isModified = value; }
		}

		/// <summary>
		/// 
		/// </summary>
		public bool IsNamed
		{
			get { return !string.IsNullOrEmpty(_name); }
		}

		public bool IsEmpty
		{
			get { return _groups.Count == 0; }
		}

		#endregion
	}
}
