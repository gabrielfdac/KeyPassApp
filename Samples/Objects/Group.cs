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
	public class Group
	{
		#region Non-Public Data Members

		private string _text = string.Empty;
		private int _imageIndex = 0;

		private List<Key> _keys = new List<Key>();

		#endregion

		#region Non-Public Properties/Methods

		#endregion

		#region Public Interface

		/// <summary>
		/// 
		/// </summary>
		public Group()
		{
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="text"></param>
		/// <param name="imageIndex"></param>
		public Group(string text, int imageIndex)
		{
			_text = text;
			_imageIndex = imageIndex;
		}

		/// <summary>
		/// 
		/// </summary>
		public string Text
		{
			get { return _text; }
			set { _text = value; }
		}

		/// <summary>
		/// 
		/// </summary>
		public int ImageIndex
		{
			get { return _imageIndex; }
			set { _imageIndex = value; }
		}

		/// <summary>
		/// 
		/// </summary>
		public List<Key> Keys
		{
			get { return _keys; }
			set { _keys = value; }
		}


		/// <summary>
		/// 
		/// </summary>
		public List<string> KeyStrings
		{
			get
			{
				List<string> keyStrings = new List<string>();
				foreach (Key key in _keys)
					keyStrings.Add(key.Title);
				return keyStrings;
			}

		}


		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return Text;
		}

		#endregion
	}
}
