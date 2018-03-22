// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//     
//	   Copyright (c) 2018 Citrix ShareFile. All rights reserved.
// </auto-generated>
// ------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Net;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ShareFile.Api.Client.Extensions;
using ShareFile.Api.Client.Exceptions;

namespace ShareFile.Api.Client.Models 
{
	/// <summary>
	/// Represents the settings applicable to a User Access Category Policy definition for use within ShareFile's Policy Based Administration
	/// </summary>
	public class UserAccessSettings : ODataObject 
	{
		/// <summary>
		/// Create root-level folders
		/// </summary>
		public bool CanCreateFolders { get; set; }
		/// <summary>
		/// Use Personal File Box
		/// </summary>
		public bool CanUseFileBox { get; set; }
		/// <summary>
		/// Manage Client Users
		/// </summary>
		public bool CanManageUsers { get; set; }
		/// <summary>
		/// Edit the shared address book
		/// </summary>
		public bool CanAdminSharedAddressBook { get; set; }
		/// <summary>
		/// Change his/her password
		/// </summary>
		public bool CanChangePassword { get; set; }
		/// <summary>
		/// See the ‘My settings’ link on the top navigation bar
		/// </summary>
		public bool CanManageMySettings { get; set; }
		/// <summary>
		/// Whether or not a user created with this policy assigned should be added to shared company address book
		/// </summary>
		public bool AddToSharedAddressBook { get; set; }
		/// <summary>
		/// Select storage zone for root-level folders
		/// </summary>
		public bool CanSelectFolderZone { get; set; }
		/// <summary>
		/// Create Network Share Connectors
		/// </summary>
		public bool CreateNetworkShareConnectors { get; set; }
		/// <summary>
		/// Create SharePoint Connectors
		/// </summary>
		public bool CreateSharePointConnectors { get; set; }
		/// <summary>
		/// Modify account-wide Settings
		/// </summary>
		public bool CanAdminAccountSettings { get; set; }
		/// <summary>
		/// Edit Account Appearance
		/// </summary>
		public bool CanAdminBranding { get; set; }
		/// <summary>
		/// Access other users' File Boxes and Sent Items
		/// </summary>
		public bool CanAdminFileBoxAccess { get; set; }
		/// <summary>
		/// View all emails
		/// </summary>
		public bool CanAdminEmailMessages { get; set; }
		/// <summary>
		/// Manage employee users
		/// </summary>
		public bool CanAdminManageEmployees { get; set; }
		/// <summary>
		/// Manage remote upload forms
		/// </summary>
		public bool CanAdminRemoteUploadForms { get; set; }
		/// <summary>
		/// Access account-wide reporting
		/// </summary>
		public bool CanAdminReporting { get; set; }
		/// <summary>
		/// Create shared distribution groups
		/// </summary>
		public bool CanAdminCreateSharedGroups { get; set; }
		/// <summary>
		/// Edit shared distribution groups
		/// </summary>
		public bool CanAdminSharedDistGroups { get; set; }
		/// <summary>
		/// View receipts/invoices
		/// </summary>
		public bool CanAdminViewReceipts { get; set; }
		/// <summary>
		/// Edit billing information
		/// </summary>
		public bool CanAdminBilling { get; set; }
		/// <summary>
		/// Request plan changes
		/// </summary>
		public bool CanAdminChangePlan { get; set; }
		/// <summary>
		/// Configure single sign-on settings
		/// </summary>
		public bool CanAdminSSO { get; set; }
		/// <summary>
		/// Manage Super User Group membership
		/// </summary>
		public bool CanAdminSuperGroup { get; set; }
		/// <summary>
		/// Delegate admin privileges to other employee users
		/// </summary>
		public bool CanAdminDelegate { get; set; }
		/// <summary>
		/// Create and manage Zones
		/// </summary>
		public bool CanAdminZones { get; set; }
		/// <summary>
		/// Create and manage Connectors
		/// </summary>
		public bool CanAdminConnectors { get; set; }
		/// <summary>
		/// Manage Tenants
		/// </summary>
		public bool CanAdminCanAdministerCustomerAccount { get; set; }
		/// <summary>
		/// Create and manage account policies
		/// </summary>
		public bool CanManageAccountPolicies { get; set; }
		/// <summary>
		/// Can be added to file drops (drop box)
		/// </summary>
		public bool CanUseFileDrops { get; set; }
		/// <summary>
		/// Create and manage file drops (drop box)
		/// </summary>
		public bool CanManageFileDrops { get; set; }
		/// <summary>
		/// Create and manage folder templates
		/// </summary>
		public bool CanManageFolderTemplates { get; set; }
		/// <summary>
		/// Perform archived search
		/// </summary>
		public bool CanPerformArchivedSearch { get; set; }
		/// <summary>
		/// Create and manage custom workflows
		/// </summary>
		public bool CanAdminCustomWorkflows { get; set; }
		/// <summary>
		/// Can send documents for signature in RightSignature
		/// </summary>
		public bool CanSendDocumentsForSignature { get; set; }
		/// <summary>
		/// Can view all RightSignature documents
		/// </summary>
		public bool CanViewSignatureDocuments { get; set; }
		/// <summary>
		/// Can manage RightSignature templates
		/// </summary>
		public bool CanManageSignatureTemplates { get; set; }

		public override void Copy(ODataObject source, JsonSerializer serializer)
		{
			if(source == null || serializer == null) return;
			base.Copy(source, serializer);

			var typedSource = source as UserAccessSettings;
			if(typedSource != null)
			{
				CanCreateFolders = typedSource.CanCreateFolders;
				CanUseFileBox = typedSource.CanUseFileBox;
				CanManageUsers = typedSource.CanManageUsers;
				CanAdminSharedAddressBook = typedSource.CanAdminSharedAddressBook;
				CanChangePassword = typedSource.CanChangePassword;
				CanManageMySettings = typedSource.CanManageMySettings;
				AddToSharedAddressBook = typedSource.AddToSharedAddressBook;
				CanSelectFolderZone = typedSource.CanSelectFolderZone;
				CreateNetworkShareConnectors = typedSource.CreateNetworkShareConnectors;
				CreateSharePointConnectors = typedSource.CreateSharePointConnectors;
				CanAdminAccountSettings = typedSource.CanAdminAccountSettings;
				CanAdminBranding = typedSource.CanAdminBranding;
				CanAdminFileBoxAccess = typedSource.CanAdminFileBoxAccess;
				CanAdminEmailMessages = typedSource.CanAdminEmailMessages;
				CanAdminManageEmployees = typedSource.CanAdminManageEmployees;
				CanAdminRemoteUploadForms = typedSource.CanAdminRemoteUploadForms;
				CanAdminReporting = typedSource.CanAdminReporting;
				CanAdminCreateSharedGroups = typedSource.CanAdminCreateSharedGroups;
				CanAdminSharedDistGroups = typedSource.CanAdminSharedDistGroups;
				CanAdminViewReceipts = typedSource.CanAdminViewReceipts;
				CanAdminBilling = typedSource.CanAdminBilling;
				CanAdminChangePlan = typedSource.CanAdminChangePlan;
				CanAdminSSO = typedSource.CanAdminSSO;
				CanAdminSuperGroup = typedSource.CanAdminSuperGroup;
				CanAdminDelegate = typedSource.CanAdminDelegate;
				CanAdminZones = typedSource.CanAdminZones;
				CanAdminConnectors = typedSource.CanAdminConnectors;
				CanAdminCanAdministerCustomerAccount = typedSource.CanAdminCanAdministerCustomerAccount;
				CanManageAccountPolicies = typedSource.CanManageAccountPolicies;
				CanUseFileDrops = typedSource.CanUseFileDrops;
				CanManageFileDrops = typedSource.CanManageFileDrops;
				CanManageFolderTemplates = typedSource.CanManageFolderTemplates;
				CanPerformArchivedSearch = typedSource.CanPerformArchivedSearch;
				CanAdminCustomWorkflows = typedSource.CanAdminCustomWorkflows;
				CanSendDocumentsForSignature = typedSource.CanSendDocumentsForSignature;
				CanViewSignatureDocuments = typedSource.CanViewSignatureDocuments;
				CanManageSignatureTemplates = typedSource.CanManageSignatureTemplates;
			}
			else
			{
				JToken token;
				if(source.TryGetProperty("CanCreateFolders", out token) && token.Type != JTokenType.Null)
				{
					CanCreateFolders = (bool)serializer.Deserialize(token.CreateReader(), typeof(bool));
				}
				if(source.TryGetProperty("CanUseFileBox", out token) && token.Type != JTokenType.Null)
				{
					CanUseFileBox = (bool)serializer.Deserialize(token.CreateReader(), typeof(bool));
				}
				if(source.TryGetProperty("CanManageUsers", out token) && token.Type != JTokenType.Null)
				{
					CanManageUsers = (bool)serializer.Deserialize(token.CreateReader(), typeof(bool));
				}
				if(source.TryGetProperty("CanAdminSharedAddressBook", out token) && token.Type != JTokenType.Null)
				{
					CanAdminSharedAddressBook = (bool)serializer.Deserialize(token.CreateReader(), typeof(bool));
				}
				if(source.TryGetProperty("CanChangePassword", out token) && token.Type != JTokenType.Null)
				{
					CanChangePassword = (bool)serializer.Deserialize(token.CreateReader(), typeof(bool));
				}
				if(source.TryGetProperty("CanManageMySettings", out token) && token.Type != JTokenType.Null)
				{
					CanManageMySettings = (bool)serializer.Deserialize(token.CreateReader(), typeof(bool));
				}
				if(source.TryGetProperty("AddToSharedAddressBook", out token) && token.Type != JTokenType.Null)
				{
					AddToSharedAddressBook = (bool)serializer.Deserialize(token.CreateReader(), typeof(bool));
				}
				if(source.TryGetProperty("CanSelectFolderZone", out token) && token.Type != JTokenType.Null)
				{
					CanSelectFolderZone = (bool)serializer.Deserialize(token.CreateReader(), typeof(bool));
				}
				if(source.TryGetProperty("CreateNetworkShareConnectors", out token) && token.Type != JTokenType.Null)
				{
					CreateNetworkShareConnectors = (bool)serializer.Deserialize(token.CreateReader(), typeof(bool));
				}
				if(source.TryGetProperty("CreateSharePointConnectors", out token) && token.Type != JTokenType.Null)
				{
					CreateSharePointConnectors = (bool)serializer.Deserialize(token.CreateReader(), typeof(bool));
				}
				if(source.TryGetProperty("CanAdminAccountSettings", out token) && token.Type != JTokenType.Null)
				{
					CanAdminAccountSettings = (bool)serializer.Deserialize(token.CreateReader(), typeof(bool));
				}
				if(source.TryGetProperty("CanAdminBranding", out token) && token.Type != JTokenType.Null)
				{
					CanAdminBranding = (bool)serializer.Deserialize(token.CreateReader(), typeof(bool));
				}
				if(source.TryGetProperty("CanAdminFileBoxAccess", out token) && token.Type != JTokenType.Null)
				{
					CanAdminFileBoxAccess = (bool)serializer.Deserialize(token.CreateReader(), typeof(bool));
				}
				if(source.TryGetProperty("CanAdminEmailMessages", out token) && token.Type != JTokenType.Null)
				{
					CanAdminEmailMessages = (bool)serializer.Deserialize(token.CreateReader(), typeof(bool));
				}
				if(source.TryGetProperty("CanAdminManageEmployees", out token) && token.Type != JTokenType.Null)
				{
					CanAdminManageEmployees = (bool)serializer.Deserialize(token.CreateReader(), typeof(bool));
				}
				if(source.TryGetProperty("CanAdminRemoteUploadForms", out token) && token.Type != JTokenType.Null)
				{
					CanAdminRemoteUploadForms = (bool)serializer.Deserialize(token.CreateReader(), typeof(bool));
				}
				if(source.TryGetProperty("CanAdminReporting", out token) && token.Type != JTokenType.Null)
				{
					CanAdminReporting = (bool)serializer.Deserialize(token.CreateReader(), typeof(bool));
				}
				if(source.TryGetProperty("CanAdminCreateSharedGroups", out token) && token.Type != JTokenType.Null)
				{
					CanAdminCreateSharedGroups = (bool)serializer.Deserialize(token.CreateReader(), typeof(bool));
				}
				if(source.TryGetProperty("CanAdminSharedDistGroups", out token) && token.Type != JTokenType.Null)
				{
					CanAdminSharedDistGroups = (bool)serializer.Deserialize(token.CreateReader(), typeof(bool));
				}
				if(source.TryGetProperty("CanAdminViewReceipts", out token) && token.Type != JTokenType.Null)
				{
					CanAdminViewReceipts = (bool)serializer.Deserialize(token.CreateReader(), typeof(bool));
				}
				if(source.TryGetProperty("CanAdminBilling", out token) && token.Type != JTokenType.Null)
				{
					CanAdminBilling = (bool)serializer.Deserialize(token.CreateReader(), typeof(bool));
				}
				if(source.TryGetProperty("CanAdminChangePlan", out token) && token.Type != JTokenType.Null)
				{
					CanAdminChangePlan = (bool)serializer.Deserialize(token.CreateReader(), typeof(bool));
				}
				if(source.TryGetProperty("CanAdminSSO", out token) && token.Type != JTokenType.Null)
				{
					CanAdminSSO = (bool)serializer.Deserialize(token.CreateReader(), typeof(bool));
				}
				if(source.TryGetProperty("CanAdminSuperGroup", out token) && token.Type != JTokenType.Null)
				{
					CanAdminSuperGroup = (bool)serializer.Deserialize(token.CreateReader(), typeof(bool));
				}
				if(source.TryGetProperty("CanAdminDelegate", out token) && token.Type != JTokenType.Null)
				{
					CanAdminDelegate = (bool)serializer.Deserialize(token.CreateReader(), typeof(bool));
				}
				if(source.TryGetProperty("CanAdminZones", out token) && token.Type != JTokenType.Null)
				{
					CanAdminZones = (bool)serializer.Deserialize(token.CreateReader(), typeof(bool));
				}
				if(source.TryGetProperty("CanAdminConnectors", out token) && token.Type != JTokenType.Null)
				{
					CanAdminConnectors = (bool)serializer.Deserialize(token.CreateReader(), typeof(bool));
				}
				if(source.TryGetProperty("CanAdminCanAdministerCustomerAccount", out token) && token.Type != JTokenType.Null)
				{
					CanAdminCanAdministerCustomerAccount = (bool)serializer.Deserialize(token.CreateReader(), typeof(bool));
				}
				if(source.TryGetProperty("CanManageAccountPolicies", out token) && token.Type != JTokenType.Null)
				{
					CanManageAccountPolicies = (bool)serializer.Deserialize(token.CreateReader(), typeof(bool));
				}
				if(source.TryGetProperty("CanUseFileDrops", out token) && token.Type != JTokenType.Null)
				{
					CanUseFileDrops = (bool)serializer.Deserialize(token.CreateReader(), typeof(bool));
				}
				if(source.TryGetProperty("CanManageFileDrops", out token) && token.Type != JTokenType.Null)
				{
					CanManageFileDrops = (bool)serializer.Deserialize(token.CreateReader(), typeof(bool));
				}
				if(source.TryGetProperty("CanManageFolderTemplates", out token) && token.Type != JTokenType.Null)
				{
					CanManageFolderTemplates = (bool)serializer.Deserialize(token.CreateReader(), typeof(bool));
				}
				if(source.TryGetProperty("CanPerformArchivedSearch", out token) && token.Type != JTokenType.Null)
				{
					CanPerformArchivedSearch = (bool)serializer.Deserialize(token.CreateReader(), typeof(bool));
				}
				if(source.TryGetProperty("CanAdminCustomWorkflows", out token) && token.Type != JTokenType.Null)
				{
					CanAdminCustomWorkflows = (bool)serializer.Deserialize(token.CreateReader(), typeof(bool));
				}
				if(source.TryGetProperty("CanSendDocumentsForSignature", out token) && token.Type != JTokenType.Null)
				{
					CanSendDocumentsForSignature = (bool)serializer.Deserialize(token.CreateReader(), typeof(bool));
				}
				if(source.TryGetProperty("CanViewSignatureDocuments", out token) && token.Type != JTokenType.Null)
				{
					CanViewSignatureDocuments = (bool)serializer.Deserialize(token.CreateReader(), typeof(bool));
				}
				if(source.TryGetProperty("CanManageSignatureTemplates", out token) && token.Type != JTokenType.Null)
				{
					CanManageSignatureTemplates = (bool)serializer.Deserialize(token.CreateReader(), typeof(bool));
				}
			}
		}
	}
}