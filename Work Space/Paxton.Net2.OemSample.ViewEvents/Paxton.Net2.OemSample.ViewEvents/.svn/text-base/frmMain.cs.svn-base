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

namespace Paxton.Net2.OemSample.ViewEvents
{
/*
 * This simple example shows you how to obtain event 
 * data from the Net2Server via the OEM Client.
 */
	public partial class frmMain : Form
	{
		private OemClient oemClient;

		//Declare the IEvents interface
		private IEvents eventSet;

		public frmMain(OemClient _oemClient)
		{
			oemClient = _oemClient;

			InitializeComponent();

			//Get the events
			GetEvents();
		}

		/// <summary>
		/// Gets the events from the Net2Server and 
		/// populates the datagridview
		/// </summary>
		private void GetEvents()
		{
			//Populate the IEvents interface from the Net2Server
			eventSet = oemClient.ViewEvents(1000, "desc");

			//Set the datasource of the datagridview to the event datatable
			dgvEvents.DataSource = eventSet.EventsDataSource.Event;
		}
	}
}
