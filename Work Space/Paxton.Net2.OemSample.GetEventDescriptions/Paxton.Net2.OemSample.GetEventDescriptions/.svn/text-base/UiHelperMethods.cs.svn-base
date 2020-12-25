using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Paxton.Net2.OemSample.GetEventDescriptions
{
	public class UiHelperMethods
	{

		/// <summary>
		/// Populate combo list, takes in the following params to return
		/// a bool value indicating if the combo has been populated or not
		/// </summary>
		/// <param name="thisCombo"></param>
		/// <param name="selectedIndex"></param>
		/// <param name="items"></param>
		/// <param name="removeItems"></param>
		/// <returns></returns>
		public bool PopulateComboList(ComboBox thisCombo, int selectedIndex, Dictionary<int, string> items, int[] removeItems)
		{
			try
			{
				int thisIndex = 0;

				thisCombo.Items.Clear();
				thisCombo.DisplayMember = "DisplayName";
				thisCombo.ValueMember = "ListId";

				//Iterate through the collection and add the items and keys to the combo
				foreach (KeyValuePair<int, string> itemId in items)
				{
					ListItem thisItem = new ListItem(itemId.Key, itemId.Value);
					thisCombo.Items.Add(thisItem);

					//remove unnecessary items

					if (removeItems != null)
					{	//Iterate through the collection
						foreach (int remItem in removeItems)
						{
							//If the ListId matches then remove
							if (thisItem.ListId == remItem)
							{
								thisCombo.Items.Remove(thisItem);
								thisIndex = thisIndex - 1;
							}
						}
					}

					//Increment the index
					thisIndex++;
				}

				//Set the selected item
				thisCombo.SelectedIndex = selectedIndex;

				//Enable the combo
				thisCombo.Enabled = true;
			}
			catch (Exception ex)
			{
				Logging.WriteToLog("Unable to populate combo list. Stack trace:" + ex.ToString());
				return false;
			}

			return true;
		}

		/// <summary>
		/// Takes an array of controls and a bool value
		/// indicating if to enable or disable the controls
		/// </summary>
		/// <param name="controls"></param>
		/// <param name="enabled"></param>
		public void EnableOrDisableControls(Control[] controls, bool enabled)
		{
			foreach (Control ctl in controls)
			{
				ctl.Enabled = enabled;
			}
		}

		/// <summary>
		/// Takes in combobox to return its selected item
		/// </summary>
		/// <param name="thisCombo"></param>
		/// <returns></returns>
		public int DeriveSelectedComboValue(ComboBox thisCombo)
		{
			try
			{
				int selectedIdx = thisCombo.SelectedIndex;
				ListItem selectedItem = (ListItem)thisCombo.Items[selectedIdx];
				return selectedItem.ListId;
			}
			catch (Exception)
			{
				return -1;
			}
		}

		/// <summary>
		/// Takes in a combobox to return its selected item string
		/// </summary>
		/// <param name="thisCombo"></param>
		/// <returns></returns>
		public string DeriveSelectedComboString(ComboBox thisCombo)
		{
			try
			{
				int selectedIdx = thisCombo.SelectedIndex;
				ListItem selectedItem = (ListItem)thisCombo.Items[selectedIdx];
				return selectedItem.DisplayName;
			}
			catch (Exception)
			{
				return string.Empty;
			}

		}
	}
}
