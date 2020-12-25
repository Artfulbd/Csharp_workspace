using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
/// <summary>
/// Add the reference to the OEM Client library
/// and point to it
/// </summary>
using Paxton.Net2.OemClientLibrary;

namespace Paxton.Net2.OemSample.Net2AccessEvent
{
	public partial class frmLogin : Form
	{
		private UiHelperMethods uiHelper = new UiHelperMethods();

		/// <summary>
		/// Declare your OEM Client and 
		/// create constants
		/// </summary>
		private const int PORT = 8025;
		private OemClient oemClient;
		private Dictionary<int, string> users;

		public frmLogin()
		{
			InitializeComponent();
		}

		#region Authentication

		/// <summary>
		/// Find server method, This will let you browse to the
		/// server if it is available 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void lnkFindServer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (!string.IsNullOrEmpty(txtServer.Text))
			{
				try
				{
					//Create a client
					CreateClient();

					if (oemClient != null)
					{
						//Populate the users dictionary
						users = Operators().UsersDictionary();

						if (users != null)
						{
							//Update the summary message
							statusLabel.Text = ("Connected to " + txtServer.Text + ".");

							//Generally we do not show these items in the operators dropdown
							int[] removeItems = { -1 };

							//Enable / Disable the controls when required
							Control[] enableControls = { txtPassword, btnLogin };
							Control[] disableControls = { txtServer, lnkFindServer };

							//Populate the operators combo
							bool IsOperatorsPopulated = uiHelper.PopulateComboList(cmbOperators, 0, users, removeItems);

							if (IsOperatorsPopulated)
							{
								//Modify the UI
								uiHelper.EnableOrDisableControls(enableControls, true);
								uiHelper.EnableOrDisableControls(disableControls, false);
							}
						}
					}
					else
					{
						//Server not found
						statusLabel.Text = ("Server " + txtServer.Text + " not found.");
						oemClient.Dispose();
						oemClient = null;
					}
				}
				catch (Exception ex)
				{
					//Exception caught
					statusLabel.Text = ("Server " + txtServer.Text + " not found.");
					Logging.WriteToLog("Server not found exception. Stack trace:" + ex.ToString());
					oemClient.Dispose();
					oemClient = null;
				}
			}
		}

		/// <summary>
		/// Login process can now begin...
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnLogin_Click(object sender, EventArgs e)
		{
			//Check if there is text in the password box
			if (!string.IsNullOrEmpty(txtPassword.Text))
			{
				try
				{
					//Get the selected item
					string selectedOperator = uiHelper.DeriveSelectedComboString(cmbOperators);

					//Now try and authenticate
					bool authenticate = AuthenticateUser(selectedOperator, txtPassword.Text);

					//Success?
					if (authenticate)
					{
						//Show the form
						frmMain frm = new frmMain(oemClient);
						frm.Activate();
						frm.Visible = true;

						//Set the login visibility to false
						Visible = false;
						return;
					}
					else
					{
						statusLabel.Text = ("Unable to authenticate with the credentials supplied.");
					}
				}
				catch (Exception ex)
				{
					Logging.WriteToLog("Unable to authenticate. Stack trace:" + ex.ToString());
				}
			}
			else
			{
				statusLabel.Text = ("Please enter a password.");
			}
		}


		/// <summary>
		/// Create Client, this will attempt to create a client
		/// by using the server name and port 
		/// </summary>
		private void CreateClient()
		{
			//Create client
			if (oemClient == null)
			{
				oemClient = new OemClient(txtServer.Text, PORT);
			}

			//If the error message field has a value then show
			//the message
			if (oemClient.LastErrorMessage != null)
			{
				statusLabel.Text = oemClient.LastErrorMessage;
				return;
			}
		}

		/// <summary>
		/// Authenticate user, this will take the operator name 
		/// and password and attempt to authenticate the client
		/// </summary>
		/// <param name="operatorName"></param>
		/// <param name="password"></param>
		/// <returns></returns>
		private bool AuthenticateUser(string operatorName, string password)
		{
			//Initialise the operators interface and put the users
			//from the interface into a dictionary
			IOperators operators = oemClient.GetListOfOperators();
			Dictionary<int, string> operatorsList = operators.UsersDictionary();

			//Iterate through the collection
			foreach (KeyValuePair<int, string> op in operatorsList)
			{
				//If the operator name and values match....
				if (op.Value == operatorName)
				{
					int userId = op.Key;
					//Create a dictionary to get the operator methods and return them
					Dictionary<string, int> net2Methods = oemClient.AuthenticateUser(userId, password);
					return (net2Methods != null);
				}
			}
			return false;
		}

		/// <summary>
		/// Pass in a valid OemClient to receive the operators interface
		/// </summary>
		/// <param name="oemClient"></param>
		/// <returns></returns>
		private IOperators Operators()
		{
			IOperators operators = null;
			try
			{
				operators = oemClient.GetListOfOperators();
			}
			catch (Exception ex)
			{
				Logging.WriteToLog("Unable to get operators. Stack trace:" + ex.ToString());
			}

			return operators;
		}

		#endregion
	}
}
