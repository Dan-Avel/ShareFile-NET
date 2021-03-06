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
namespace ShareFile.Api.Client.Models 
{
    [Flags]
    public enum ItemOperations
    {
        None = 0,
        CanDownload = 1,
        CanShareEmail = 2,
        CanShareLink = 4,
        CanDelete = 8,
        CanEditMetadata = 16,
        CanMove = 32,
        CanCopy = 64,
        CanEditDocument = 128,
        CanSignRS3 = 256,
        CanSignRS4 = 512,
        CanCheckOut = 1024,
        CanCheckIn = 2048,
        CanDiscardCheckout = 4096,
        CanToggleFavorite = 8192,
        CanInitiateApproval = 16384,
        CanCreateOfficeDocuments = 32768,
        CanUnzipFiles = 65536,
        CanPreview = 131072,
        CanRequestFiles = 262144
    }
}
