using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//Add reference to the OEM Client Library
using Paxton.Net2.OemClientLibrary;

namespace Paxton.Net2.OemSample.GetEventDescriptions
{
/* This sample will show you how to extract the event descriptions from 
 * the NetServer. Two parameters are expected as follows:
 * 1) fromEventId (The event on the database from)(Integer)
 * 2) toEventId (The event on the database to)(Integer)
 */
	public partial class frmMain : Form
	{
		private OemClient oemClient;

		public frmMain(OemClient _oemClient)
		{
			oemClient = _oemClient;

			InitializeComponent();

			//Get the event descriptions
			GetEventDescriptions();
		}
		
		#region Methods
		
		/// <summary>
		/// Gets the event descriptions and populates the
		/// datagridview with the data
		/// </summary>
		private void GetEventDescriptions()
		{
			//Declare a dataset and bind the event descriptions to it.
			DataSet ds = oemClient.GetEventDescriptions(1, 1000);

			//Is the datatable null?
			if (ds.Tables[0] != null)
			{
				//If not then set the datagridviews datasource property to the datatable
				dgEventDescriptions.DataSource = ds.Tables[0];
			}
		}

		#endregion
	}
}
