#region Header
// © 2015
// Author:      Gabriel Fernandes
// Date:        10/5/2015 8:38:35 PM
#endregion

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using KeyPassBusiness;
using KeyPassInfoObjects;

namespace KeyPassUserInterface
{
	/// <summary>
	/// 
	/// </summary>
	public partial class KeyListControl : UserControl
	{
		#region Non-Public Data Members

		#endregion

		#region Non-Public Properties/Methods

		private void AutoSizeColumns()
		{
			if (_lvwKeys.Columns.Count != 0)
			{
				_lvwKeys.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
			}

			if (_lvwKeys.Items.Count != 0)
			{
				_lvwKeys.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="key"></param>
		/// <returns></returns>
		private ListViewItem FindLviByTag(Key key)
		{
			foreach (ListViewItem lvi in _lvwKeys.Items)
			{
				if (lvi.Tag == key)
					return lvi;
			}

			return null;
		}


		private void DisplayKeys(Group group)
		{
			_lvwKeys.BeginUpdate();

			_lvwKeys.Items.Clear();

			// The if clause handles the last group/node being deleted.
			if (group != null)
			{
				foreach (Key key in group.Keys)
				{
					AddListItem(key);
				}
			}

			AutoSizeColumns();
			_lvwKeys.EndUpdate();

			// Recalculate Selected Keys from the Selected List view Items
			ContextMgr.SelectedKeys.Clear();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="key"></param>
		private void AddListItem(Key key)
		{
			ListViewItem lvi = _lvwKeys.Items.Add(key.Title);
			lvi.Tag = key;
			lvi.Name = key.Title;
			lvi.UseItemStyleForSubItems = true;
			lvi.SubItems.Add(key.UserName);
			lvi.SubItems.Add(key.Password);
			lvi.SubItems.Add(key.Url);
		}

		private void ModifyListItem(Key key)
		{
			ListViewItem lvi = FindLviByTag(key);

			_lvwKeys.BeginUpdate();
			lvi.Text = key.Title;
			lvi.SubItems[1].Text = key.UserName;
			lvi.SubItems[2].Text = key.Password;
			lvi.SubItems[3].Text = key.Url;

			_lvwKeys.EndUpdate();

			_rtbKeyDetails.Text = key.ToString();
		}

		private void DeleteListItem(Key key)
		{
			ListViewItem lvi = FindLviByTag(key);
			_lvwKeys.BeginUpdate();
			lvi.Remove();
			_lvwKeys.EndUpdate();

			_rtbKeyDetails.Clear();
		}

		#endregion

		#region Public Interface
		/// <summary>
		/// ctor
		/// </summary>
		public KeyListControl()
		{
			InitializeComponent();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="doc"></param>
		public void New(KeyChainDocument doc)
		{
			_lvwKeys.BeginUpdate();
			_lvwKeys.Items.Clear();
			_rtbKeyDetails.Clear();
			_lvwKeys.EndUpdate();
		}

		#endregion

		#region Event Handlers

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnLoad(object sender, EventArgs e)
		{
			if (DesignMode)
				return;

			// Put your Initialization code Here
			AutoSizeColumns();

			Application.Idle += new EventHandler(OnIdle);

			ContextMgr.GroupSelected += OnGroupSelected;
			ContextMgr.KeySelected += OnKeySelected;
		}

		private void OnGroupSelected(Group group)
		{
			DisplayKeys(group);

			_rtbKeyDetails.Clear();
			_rtbKeyDetails.Enabled = false;
		}

		private void OnKeySelected(List<Key> keys)
		{
			if (keys.Count == 0 || keys.Count > 1)
			{
				_rtbKeyDetails.Text = string.Empty;
				_rtbKeyDetails.Enabled = false;
			}
			else
			{
				_rtbKeyDetails.Enabled = true;
				_rtbKeyDetails.Text = keys[0].ToString();
			}
		}

		private void OnIdle(object sender, EventArgs e)
		{
			_tsbEntryDelete.Enabled = _lvwKeys.SelectedItems.Count != 0;
			_tsbEntryEdit.Enabled = _lvwKeys.SelectedItems.Count == 1;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		public void OnKeyAdd(object sender, EventArgs e)
		{
			if (ContextMgr.SelectedGroup == null)
			{
				MessageBoxHelper.Info(this, "Please select a agroup.");
				return;
			}

			KeyPropertiesForm f = new KeyPropertiesForm(ContextMgr.SelectedGroup);
			using (f)
			{
				if (f.ShowDialog(this) != DialogResult.OK)
					return;

				if (!KeyChainMgr.AddKeyToGroup(f.Group, f.Key))
				{
					MessageBoxHelper.Error(this, @"Failed to add key {0}", f.Key);
					return;
				}

				// If the user modified the key the group belongs to, then tickle the group selected event through the ContextMgr
				if (f.Group.ToString() == ContextMgr.SelectedGroup.ToString())
				{
					AddListItem(f.Key);
				}
			}


		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		public void OnKeyEdit(object sender, EventArgs e)
		{
			Key selectedKey = (Key)_lvwKeys.SelectedItems[0].Tag;
			KeyPropertiesForm f = new KeyPropertiesForm(ContextMgr.SelectedGroup, selectedKey);
			using (f)
			{
				if (f.ShowDialog(this) != DialogResult.OK)
					return;

				if (!KeyChainMgr.ModifyKey(f.Group, f.Key))
				{
					MessageBoxHelper.Error(this, @"Failed to modify key {0}", f.Key);
					return;
				}

				// If the user modified the key the group belongs to, then remove the key from the current view.
				if (f.Group == ContextMgr.SelectedGroup)
					ModifyListItem(f.Key);
				else
					DeleteListItem(f.Key);

				AutoSizeColumns();
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		public void OnKeyDelete(object sender, EventArgs e)
		{
			bool allKeysSuccessfullyDeleted = true;
			foreach (ListViewItem lvi in _lvwKeys.SelectedItems)
			{
				Key selectedKey = (Key)_lvwKeys.SelectedItems[0].Tag;
				if (!KeyChainMgr.DeleteKey(ContextMgr.SelectedGroup, selectedKey))
				{
					allKeysSuccessfullyDeleted = false;
				}
				else
				{
					DeleteListItem(selectedKey);
				}
			}

			AutoSizeColumns();

			if (allKeysSuccessfullyDeleted == false)
			{
				MessageBoxHelper.Error(this, @"Failed to delete some keys");
				return;
			}
		}

		private void OnMouseDoubleClick(object sender, MouseEventArgs e)
		{
			OnKeyEdit(sender, e);
		}


		private void OnKeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete)
			{
				OnKeyDelete(sender, e);
			}
		}

		private void OnKeySelected(object sender, EventArgs e)
		{
			// Recalculate Selected Keys from the Selected List view Items
			ContextMgr.SelectedKeys.Clear();

			foreach (ListViewItem lvi in _lvwKeys.SelectedItems)
			{
				ContextMgr.SelectedKeys.Add((Key)lvi.Tag);
			}

			ContextMgr.FireKeySelected();
		}

		#endregion

		private void OnEntryDuplicate(object sender, EventArgs e)
		{
			List<Key> keys = ContextMgr.SelectedKeys;
			Clipboard.SetData(KeyChainMgr.KeyClipboardFormat, keys);

			IDataObject dataobject = Clipboard.GetDataObject();
			if (dataobject.GetDataPresent(KeyChainMgr.KeyClipboardFormat))
			{
				keys = (List<Key>)dataobject.GetData(KeyChainMgr.KeyClipboardFormat);
				foreach (Key key in keys)
				{
					KeyChainMgr.AddKeyToGroup(ContextMgr.SelectedGroup, key);
					AddListItem(key);
				}

				_lvwKeys.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
			}
		}

		private void OnKeyMenuOpening(object sender, System.ComponentModel.CancelEventArgs e)
		{
			_mnuEntryDelete.Enabled = ContextMgr.SelectedKeys.Count > 0;
			_mnuEntryEdit.Enabled = ContextMgr.SelectedKeys.Count == 1;
			_mnuEntryDuplicate.Enabled = ContextMgr.SelectedKeys.Count > 0;
		}


	}
}
