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
	public class SSOAccountProvider : ODataObject 
	{
		public string LogoutUrl { get; set; }
		public string LoginUrl { get; set; }
		public string IPRestrictions { get; set; }
		public bool? ForceSSO { get; set; }
		public string Certificate { get; set; }
		public Account Account { get; set; }
		public string EntityID { get; set; }
		public string SFEntityID { get; set; }
		public string SSOProvidersToAccountsID { get; set; }
		public string SPInitatedAuthContext { get; set; }
		public string SPInitatedAuthMethod { get; set; }
		public bool? UseWebAuthentication { get; set; }
		public bool? IsActive { get; set; }
		public bool? IsDefault { get; set; }
		public string ProviderID { get; set; }
		public bool? DebugMode { get; set; }
		public bool? LenientSignatures { get; set; }

		public override void Copy(ODataObject source, JsonSerializer serializer)
		{
			if(source == null || serializer == null) return;
			base.Copy(source, serializer);

			var typedSource = source as SSOAccountProvider;
			if(typedSource != null)
			{
				LogoutUrl = typedSource.LogoutUrl;
				LoginUrl = typedSource.LoginUrl;
				IPRestrictions = typedSource.IPRestrictions;
				ForceSSO = typedSource.ForceSSO;
				Certificate = typedSource.Certificate;
				Account = typedSource.Account;
				EntityID = typedSource.EntityID;
				SFEntityID = typedSource.SFEntityID;
				SSOProvidersToAccountsID = typedSource.SSOProvidersToAccountsID;
				SPInitatedAuthContext = typedSource.SPInitatedAuthContext;
				SPInitatedAuthMethod = typedSource.SPInitatedAuthMethod;
				UseWebAuthentication = typedSource.UseWebAuthentication;
				IsActive = typedSource.IsActive;
				IsDefault = typedSource.IsDefault;
				ProviderID = typedSource.ProviderID;
				DebugMode = typedSource.DebugMode;
				LenientSignatures = typedSource.LenientSignatures;
			}
			else
			{
				JToken token;
				if(source.TryGetProperty("LogoutUrl", out token) && token.Type != JTokenType.Null)
				{
					LogoutUrl = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("LoginUrl", out token) && token.Type != JTokenType.Null)
				{
					LoginUrl = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("IPRestrictions", out token) && token.Type != JTokenType.Null)
				{
					IPRestrictions = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("ForceSSO", out token) && token.Type != JTokenType.Null)
				{
					ForceSSO = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("Certificate", out token) && token.Type != JTokenType.Null)
				{
					Certificate = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("Account", out token) && token.Type != JTokenType.Null)
				{
					Account = (Account)serializer.Deserialize(token.CreateReader(), typeof(Account));
				}
				if(source.TryGetProperty("EntityID", out token) && token.Type != JTokenType.Null)
				{
					EntityID = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("SFEntityID", out token) && token.Type != JTokenType.Null)
				{
					SFEntityID = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("SSOProvidersToAccountsID", out token) && token.Type != JTokenType.Null)
				{
					SSOProvidersToAccountsID = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("SPInitatedAuthContext", out token) && token.Type != JTokenType.Null)
				{
					SPInitatedAuthContext = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("SPInitatedAuthMethod", out token) && token.Type != JTokenType.Null)
				{
					SPInitatedAuthMethod = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("UseWebAuthentication", out token) && token.Type != JTokenType.Null)
				{
					UseWebAuthentication = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("IsActive", out token) && token.Type != JTokenType.Null)
				{
					IsActive = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("IsDefault", out token) && token.Type != JTokenType.Null)
				{
					IsDefault = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("ProviderID", out token) && token.Type != JTokenType.Null)
				{
					ProviderID = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("DebugMode", out token) && token.Type != JTokenType.Null)
				{
					DebugMode = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("LenientSignatures", out token) && token.Type != JTokenType.Null)
				{
					LenientSignatures = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
			}
		}
	}
}