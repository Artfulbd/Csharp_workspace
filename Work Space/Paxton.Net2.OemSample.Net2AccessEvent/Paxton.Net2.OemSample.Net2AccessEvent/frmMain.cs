using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Paxton.Net2.OemClientLibrary;
/// <summary>
/// Add the reference to the OEM Client library
/// and point to it
/// </summary>

/*
 * This example application shows you how to handle an 
 * event coming from a Net2 Acu. For example you can register an
 * interest in an ACU, This will then start monitoring the ACU
 * for activity. When a user interacts with the ACU then the resulting
 * event is then returned to the event handler so you can see what sort
 * of event occured.
 */
namespace Paxton.Net2.OemSample.Net2AccessEvent
{
	public partial class frmMain : Form
	{
		private OemClient oemClient;
		private string message;
		public frmMain(OemClient _oemClient)
		{
			//Set the oemClient
			oemClient = _oemClient;

			//Create an event handler to handle the access event
			oemClient.Net2AccessEvent += new OemClient.Net2AcuEventHandler(oemClient_Net2AccessEvent);

			InitializeComponent();

		}

		#region Event handlers

		/// <summary>
		/// The returned event from Net2
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void oemClient_Net2AccessEvent(object sender, IEventView e)
		{
			//Set the message and update the control
			
			message = e.Address.ToString();
			lblAddress.Invoke(new EventHandler(UpdateControl));
		
			message = e.CardNumber.ToString();
			lblCardNumber.Invoke(new EventHandler(UpdateControl));
			

			if (e.Details != null)
			{
				message = e.Details;
				lblDetails.Invoke(new EventHandler(UpdateControl));
			}

			if (e.DeviceName != null)
			{
				message = e.DeviceName;
				lblDeviceName.Invoke(new EventHandler(UpdateControl));
			}


			if (e.EventDate != null)
			{
				message = e.EventDate.ToString();
				lblEventDate.Invoke(new EventHandler(UpdateControl));
			}

			if (e.EventDateTime != null)
			{
				message = e.EventDateTime.ToString();
				lblEventDateTime.Invoke(new EventHandler(UpdateControl));
			}
		
			message = e.EventId.ToString();
			lblEventId.Invoke(new EventHandler(UpdateControl));
			

			if (e.EventSubDescription != null)
			{
				message = e.EventSubDescription.ToString();
				lblEventSubDescription.Invoke(new EventHandler(UpdateControl));
			}
		
			message = e.EventSubType.ToString();
			lblEventSubType.Invoke(new EventHandler(UpdateControl));
		
			message = e.EventSubTypeEnumerated.ToString();
			lblEventSubTypeEnumerated.Invoke(new EventHandler(UpdateControl));
			

			if (e.EventTime != null)
			{
				message = e.EventTime.ToString();
				lblEventTime.Invoke(new EventHandler(UpdateControl));
			}
			
			message = e.EventType.ToString();
			lblEventType.Invoke(new EventHandler(UpdateControl));
		

			if (e.EventTypeDescription != null)
			{
				message = e.EventTypeDescription;
				lblEventTypeDescription.Invoke(new EventHandler(UpdateControl));
			}

			message = e.EventTypeEnumerated.ToString();
			lblEventTypeEnumerated.Invoke(new EventHandler(UpdateControl));
		
			message = e.InputId.ToString();
			lblInputId.Invoke(new EventHandler(UpdateControl));
		
			message = e.IoBoardId.ToString();
			lblIoBoardId.Invoke(new EventHandler(UpdateControl));
			
			message = e.LinkedEvent.ToString();
			lblLinkedEvent.Invoke(new EventHandler(UpdateControl));
		
			message = e.OutputId.ToString();
			lblOutputId.Invoke(new EventHandler(UpdateControl));
		
			message = e.SubAddress.ToString();
			lblOutputId.Invoke(new EventHandler(UpdateControl));
		
			message = e.UserId.ToString();
			lblUserId.Invoke(new EventHandler(UpdateControl));
			

			if (e.Username != null)
			{
				message = e.Username;
				lblUsername.Invoke(new EventHandler(UpdateControl));
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// Update the control's text property
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void UpdateControl(object sender, EventArgs e)
		{
			//Declare the control
			Control ctl = sender as Control;

			if (ctl != null)
			{
				//Append the text
				ctl.Text = ctl.Text + " " + message;
			}
		}

		/// <summary>
		/// Starts monitoring a door
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnStart_Click(object sender, EventArgs e)
		{
			try
			{
				//Select a door to monitor
				oemClient.MonitorAcu(817418);
				oemClient.MonitorAcu(838668);
				oemClient.MonitorAcu(790113);
				oemClient.MonitorAcu(564619);
				oemClient.MonitorAcu(718833);
				
			}
			catch (Exception ex)
			{
				Logging.WriteToLog(ex.ToString());
			}
		}

		/// <summary>
		/// Stops monitoring a door
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnStop_Click(object sender, EventArgs e)
		{
			try
			{
				//Select a door to stop monitor
				oemClient.StopMonitoringAcu(817200);
			}
			catch (Exception ex)
			{
				Logging.WriteToLog(ex.ToString());
			}
		}

        #endregion

    }
}
