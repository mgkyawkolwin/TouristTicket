USE [TouristTicket]
GO
/****** Object:  StoredProcedure [dbo].[SelectZone]    Script Date: 10/24/2012 03:07:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectZone]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SelectZone]
GO
/****** Object:  StoredProcedure [dbo].[SelectZoneAndZoneGroup]    Script Date: 10/24/2012 03:07:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectZoneAndZoneGroup]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SelectZoneAndZoneGroup]
GO
/****** Object:  StoredProcedure [dbo].[SelectZoneGroup]    Script Date: 10/24/2012 03:07:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectZoneGroup]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SelectZoneGroup]
GO
/****** Object:  StoredProcedure [dbo].[SelectZoneSetting]    Script Date: 10/24/2012 03:07:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectZoneSetting]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SelectZoneSetting]
GO
/****** Object:  StoredProcedure [dbo].[SelectPrintingApproved]    Script Date: 10/24/2012 03:07:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectPrintingApproved]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SelectPrintingApproved]
GO
/****** Object:  StoredProcedure [dbo].[SelectRole]    Script Date: 10/24/2012 03:07:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectRole]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SelectRole]
GO
/****** Object:  StoredProcedure [dbo].[SelectSample]    Script Date: 10/24/2012 03:07:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectSample]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SelectSample]
GO
/****** Object:  StoredProcedure [dbo].[SelectTicket]    Script Date: 10/24/2012 03:07:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectTicket]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SelectTicket]
GO
/****** Object:  StoredProcedure [dbo].[SelectTicketCollectionsUsingFilters]    Script Date: 10/24/2012 03:07:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectTicketCollectionsUsingFilters]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SelectTicketCollectionsUsingFilters]
GO
/****** Object:  StoredProcedure [dbo].[SelectTicketDetails]    Script Date: 10/24/2012 03:07:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectTicketDetails]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SelectTicketDetails]
GO
/****** Object:  StoredProcedure [dbo].[SelectTicketInZone]    Script Date: 10/24/2012 03:07:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectTicketInZone]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SelectTicketInZone]
GO
/****** Object:  StoredProcedure [dbo].[SelectTicketSetting]    Script Date: 10/24/2012 03:07:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectTicketSetting]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SelectTicketSetting]
GO
/****** Object:  StoredProcedure [dbo].[SelectTicketStatusByTicketID]    Script Date: 10/24/2012 03:07:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectTicketStatusByTicketID]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SelectTicketStatusByTicketID]
GO
/****** Object:  StoredProcedure [dbo].[SelectTicketUnused]    Script Date: 10/24/2012 03:07:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectTicketUnused]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SelectTicketUnused]
GO
/****** Object:  StoredProcedure [dbo].[SelectTicketUsage]    Script Date: 10/24/2012 03:07:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectTicketUsage]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SelectTicketUsage]
GO
/****** Object:  StoredProcedure [dbo].[SelectDistinctZoneGroup]    Script Date: 10/24/2012 03:07:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectDistinctZoneGroup]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SelectDistinctZoneGroup]
GO
/****** Object:  StoredProcedure [dbo].[SelectExceptionLog]    Script Date: 10/24/2012 03:07:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectExceptionLog]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SelectExceptionLog]
GO
/****** Object:  StoredProcedure [dbo].[SelectMaxPKID]    Script Date: 10/24/2012 03:07:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectMaxPKID]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SelectMaxPKID]
GO
/****** Object:  StoredProcedure [dbo].[SelectCounter]    Script Date: 10/24/2012 03:07:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectCounter]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SelectCounter]
GO
/****** Object:  StoredProcedure [dbo].[SelectCounterDetail]    Script Date: 10/24/2012 03:07:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectCounterDetail]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SelectCounterDetail]
GO
/****** Object:  StoredProcedure [dbo].[SelectTicketUsageLogByFilter]    Script Date: 10/24/2012 03:07:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectTicketUsageLogByFilter]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SelectTicketUsageLogByFilter]
GO
/****** Object:  StoredProcedure [dbo].[SelectTicketUsingFilters]    Script Date: 10/24/2012 03:07:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectTicketUsingFilters]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SelectTicketUsingFilters]
GO
/****** Object:  StoredProcedure [dbo].[SelectUserAccessLog]    Script Date: 10/24/2012 03:07:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectUserAccessLog]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SelectUserAccessLog]
GO
/****** Object:  StoredProcedure [dbo].[SelectUserAccessLogByUserID]    Script Date: 10/24/2012 03:07:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectUserAccessLogByUserID]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SelectUserAccessLogByUserID]
GO
/****** Object:  StoredProcedure [dbo].[SelectUserCollectionUsingFilters]    Script Date: 10/24/2012 03:07:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectUserCollectionUsingFilters]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SelectUserCollectionUsingFilters]
GO
/****** Object:  StoredProcedure [dbo].[SelectUserInRole]    Script Date: 10/24/2012 03:07:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectUserInRole]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SelectUserInRole]
GO
/****** Object:  StoredProcedure [dbo].[SelectWebUser]    Script Date: 10/24/2012 03:07:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectWebUser]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SelectWebUser]
GO
/****** Object:  StoredProcedure [dbo].[SelectUserInfo]    Script Date: 10/24/2012 03:07:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectUserInfo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SelectUserInfo]
GO
/****** Object:  StoredProcedure [dbo].[SelectUser]    Script Date: 10/24/2012 03:07:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectUser]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SelectUser]
GO
/****** Object:  StoredProcedure [dbo].[SelectCounterTicketUsageHistory]    Script Date: 10/24/2012 03:07:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectCounterTicketUsageHistory]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SelectCounterTicketUsageHistory]
GO
/****** Object:  StoredProcedure [dbo].[SelectTicketUsageHistory]    Script Date: 10/24/2012 03:07:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectTicketUsageHistory]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SelectTicketUsageHistory]
GO
/****** Object:  View [dbo].[vwTicketUsageLog]    Script Date: 10/24/2012 03:07:57 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwTicketUsageLog]'))
DROP VIEW [dbo].[vwTicketUsageLog]
GO
/****** Object:  View [dbo].[vwTicketUsageLogByFilter]    Script Date: 10/24/2012 03:07:57 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwTicketUsageLogByFilter]'))
DROP VIEW [dbo].[vwTicketUsageLogByFilter]
GO
/****** Object:  View [dbo].[vwTransactionLog]    Script Date: 10/24/2012 03:07:57 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwTransactionLog]'))
DROP VIEW [dbo].[vwTransactionLog]
GO
/****** Object:  View [dbo].[vwTWTicketInfo]    Script Date: 10/24/2012 03:07:57 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwTWTicketInfo]'))
DROP VIEW [dbo].[vwTWTicketInfo]
GO
/****** Object:  View [dbo].[vwTWZoneGroupZoneCounter]    Script Date: 10/24/2012 03:07:57 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwTWZoneGroupZoneCounter]'))
DROP VIEW [dbo].[vwTWZoneGroupZoneCounter]
GO
/****** Object:  View [dbo].[vwUser]    Script Date: 10/24/2012 03:07:57 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwUser]'))
DROP VIEW [dbo].[vwUser]
GO
/****** Object:  View [dbo].[vwUserAccessLog]    Script Date: 10/24/2012 03:07:57 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwUserAccessLog]'))
DROP VIEW [dbo].[vwUserAccessLog]
GO
/****** Object:  View [dbo].[vwUserInfo]    Script Date: 10/24/2012 03:07:57 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwUserInfo]'))
DROP VIEW [dbo].[vwUserInfo]
GO
/****** Object:  View [dbo].[vwUserInRole]    Script Date: 10/24/2012 03:07:57 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwUserInRole]'))
DROP VIEW [dbo].[vwUserInRole]
GO
/****** Object:  View [dbo].[vwWebUser]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwWebUser]'))
DROP VIEW [dbo].[vwWebUser]
GO
/****** Object:  View [dbo].[vwZone]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwZone]'))
DROP VIEW [dbo].[vwZone]
GO
/****** Object:  View [dbo].[vwZoneAndZoneGroup]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwZoneAndZoneGroup]'))
DROP VIEW [dbo].[vwZoneAndZoneGroup]
GO
/****** Object:  View [dbo].[vwZoneGroup]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwZoneGroup]'))
DROP VIEW [dbo].[vwZoneGroup]
GO
/****** Object:  View [dbo].[vwZoneSetting]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwZoneSetting]'))
DROP VIEW [dbo].[vwZoneSetting]
GO
/****** Object:  StoredProcedure [dbo].[WebUserLogIn]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[WebUserLogIn]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[WebUserLogIn]
GO
/****** Object:  StoredProcedure [dbo].[ActivateTicket]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ActivateTicket]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ActivateTicket]
GO
/****** Object:  StoredProcedure [dbo].[CheckClientData]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CheckClientData]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[CheckClientData]
GO
/****** Object:  StoredProcedure [dbo].[CheckInTicket]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CheckInTicket]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[CheckInTicket]
GO
/****** Object:  StoredProcedure [dbo].[CheckServerData]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CheckServerData]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[CheckServerData]
GO
/****** Object:  StoredProcedure [dbo].[DeleteCounter]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DeleteCounter]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[DeleteCounter]
GO
/****** Object:  StoredProcedure [dbo].[DeletePrintingCode]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DeletePrintingCode]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[DeletePrintingCode]
GO
/****** Object:  StoredProcedure [dbo].[DeleteTicketSettings]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DeleteTicketSettings]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[DeleteTicketSettings]
GO
/****** Object:  StoredProcedure [dbo].[DeleteUser]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DeleteUser]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[DeleteUser]
GO
/****** Object:  StoredProcedure [dbo].[DeleteUserInRole]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DeleteUserInRole]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[DeleteUserInRole]
GO
/****** Object:  StoredProcedure [dbo].[DeleteWebUser]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DeleteWebUser]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[DeleteWebUser]
GO
/****** Object:  StoredProcedure [dbo].[DeleteZone]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DeleteZone]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[DeleteZone]
GO
/****** Object:  StoredProcedure [dbo].[DeleteZoneGroup]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DeleteZoneGroup]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[DeleteZoneGroup]
GO
/****** Object:  StoredProcedure [dbo].[DownloadData]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DownloadData]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[DownloadData]
GO
/****** Object:  StoredProcedure [dbo].[ExportData]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ExportData]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ExportData]
GO
/****** Object:  StoredProcedure [dbo].[ExportFromServer]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ExportFromServer]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ExportFromServer]
GO
/****** Object:  StoredProcedure [dbo].[GetTicketInfo]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetTicketInfo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetTicketInfo]
GO
/****** Object:  StoredProcedure [dbo].[InsertApprovedCode]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertApprovedCode]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[InsertApprovedCode]
GO
/****** Object:  StoredProcedure [dbo].[InsertCounter]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertCounter]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[InsertCounter]
GO
/****** Object:  StoredProcedure [dbo].[InsertExceptionLog]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertExceptionLog]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[InsertExceptionLog]
GO
/****** Object:  StoredProcedure [dbo].[InsertNewTicket]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertNewTicket]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[InsertNewTicket]
GO
/****** Object:  StoredProcedure [dbo].[InsertNewUser]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertNewUser]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[InsertNewUser]
GO
/****** Object:  StoredProcedure [dbo].[InsertNewWebUser]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertNewWebUser]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[InsertNewWebUser]
GO
/****** Object:  StoredProcedure [dbo].[InsertTicketActivationLog]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertTicketActivationLog]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[InsertTicketActivationLog]
GO
/****** Object:  StoredProcedure [dbo].[InsertTicketInZone]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertTicketInZone]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[InsertTicketInZone]
GO
/****** Object:  StoredProcedure [dbo].[InsertTicketUnused]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertTicketUnused]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[InsertTicketUnused]
GO
/****** Object:  StoredProcedure [dbo].[InsertTicketUsage]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertTicketUsage]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[InsertTicketUsage]
GO
/****** Object:  StoredProcedure [dbo].[InsertTicketUsageLog]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertTicketUsageLog]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[InsertTicketUsageLog]
GO
/****** Object:  StoredProcedure [dbo].[InsertTransactionLog]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertTransactionLog]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[InsertTransactionLog]
GO
/****** Object:  StoredProcedure [dbo].[InsertUpdateTicket]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertUpdateTicket]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[InsertUpdateTicket]
GO
/****** Object:  StoredProcedure [dbo].[InsertUserAccessLog]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertUserAccessLog]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[InsertUserAccessLog]
GO
/****** Object:  StoredProcedure [dbo].[InsertUserInRole]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertUserInRole]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[InsertUserInRole]
GO
/****** Object:  StoredProcedure [dbo].[InsertZone]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertZone]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[InsertZone]
GO
/****** Object:  StoredProcedure [dbo].[InsertZoneAndZoneGroup]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertZoneAndZoneGroup]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[InsertZoneAndZoneGroup]
GO
/****** Object:  StoredProcedure [dbo].[InsertZoneGroup]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertZoneGroup]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[InsertZoneGroup]
GO
/****** Object:  StoredProcedure [dbo].[ResetPassword]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ResetPassword]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ResetPassword]
GO
/****** Object:  StoredProcedure [dbo].[RetrieveDataToUpload]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RetrieveDataToUpload]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[RetrieveDataToUpload]
GO
/****** Object:  StoredProcedure [dbo].[RetrieveTicketActivationLog]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RetrieveTicketActivationLog]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[RetrieveTicketActivationLog]
GO
/****** Object:  StoredProcedure [dbo].[RetrieveTicketUsageLog]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RetrieveTicketUsageLog]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[RetrieveTicketUsageLog]
GO
/****** Object:  StoredProcedure [dbo].[SelectClientUploadDownloadLog]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectClientUploadDownloadLog]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SelectClientUploadDownloadLog]
GO
/****** Object:  StoredProcedure [dbo].[TicketUsage]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TicketUsage]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[TicketUsage]
GO
/****** Object:  StoredProcedure [dbo].[UpdateCounter]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UpdateCounter]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[UpdateCounter]
GO
/****** Object:  StoredProcedure [dbo].[UpdateLastDownloadedDateTime]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UpdateLastDownloadedDateTime]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[UpdateLastDownloadedDateTime]
GO
/****** Object:  StoredProcedure [dbo].[UpdateLastDownloadedDateTimeAtClientMachine]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UpdateLastDownloadedDateTimeAtClientMachine]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[UpdateLastDownloadedDateTimeAtClientMachine]
GO
/****** Object:  StoredProcedure [dbo].[UpdateLastUploadedDateTime]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UpdateLastUploadedDateTime]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[UpdateLastUploadedDateTime]
GO
/****** Object:  StoredProcedure [dbo].[UpdateLastUploadedDateTimeAtClientMachine]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UpdateLastUploadedDateTimeAtClientMachine]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[UpdateLastUploadedDateTimeAtClientMachine]
GO
/****** Object:  StoredProcedure [dbo].[UpdateTicket]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UpdateTicket]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[UpdateTicket]
GO
/****** Object:  StoredProcedure [dbo].[UpdateTicketSoldInfo]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UpdateTicketSoldInfo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[UpdateTicketSoldInfo]
GO
/****** Object:  StoredProcedure [dbo].[UpdateTicketStatus]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UpdateTicketStatus]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[UpdateTicketStatus]
GO
/****** Object:  StoredProcedure [dbo].[UpdateTicketUnused]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UpdateTicketUnused]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[UpdateTicketUnused]
GO
/****** Object:  StoredProcedure [dbo].[UpdateUser]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UpdateUser]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[UpdateUser]
GO
/****** Object:  StoredProcedure [dbo].[UpdateUserInRole]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UpdateUserInRole]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[UpdateUserInRole]
GO
/****** Object:  StoredProcedure [dbo].[UpdateWebUser]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UpdateWebUser]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[UpdateWebUser]
GO
/****** Object:  StoredProcedure [dbo].[UpdateZone]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UpdateZone]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[UpdateZone]
GO
/****** Object:  StoredProcedure [dbo].[UpdateZoneAndZoneGroup]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UpdateZoneAndZoneGroup]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[UpdateZoneAndZoneGroup]
GO
/****** Object:  StoredProcedure [dbo].[UpdateZoneGroup]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UpdateZoneGroup]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[UpdateZoneGroup]
GO
/****** Object:  StoredProcedure [dbo].[UserLogIn]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UserLogIn]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[UserLogIn]
GO
/****** Object:  StoredProcedure [dbo].[ValidateTicket]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ValidateTicket]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ValidateTicket]
GO
/****** Object:  View [dbo].[vwClientUploadDownloadLog]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwClientUploadDownloadLog]'))
DROP VIEW [dbo].[vwClientUploadDownloadLog]
GO
/****** Object:  View [dbo].[vwCounter]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwCounter]'))
DROP VIEW [dbo].[vwCounter]
GO
/****** Object:  View [dbo].[vwCounterAndZone]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwCounterAndZone]'))
DROP VIEW [dbo].[vwCounterAndZone]
GO
/****** Object:  View [dbo].[vwCounterTicketUsageHistory]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwCounterTicketUsageHistory]'))
DROP VIEW [dbo].[vwCounterTicketUsageHistory]
GO
/****** Object:  View [dbo].[vwDistinctZoneGroupName]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwDistinctZoneGroupName]'))
DROP VIEW [dbo].[vwDistinctZoneGroupName]
GO
/****** Object:  View [dbo].[vwExceptionLog]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwExceptionLog]'))
DROP VIEW [dbo].[vwExceptionLog]
GO
/****** Object:  View [dbo].[vwPrintingApproved]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwPrintingApproved]'))
DROP VIEW [dbo].[vwPrintingApproved]
GO
/****** Object:  View [dbo].[vwRole]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwRole]'))
DROP VIEW [dbo].[vwRole]
GO
/****** Object:  View [dbo].[vwSampleObject]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwSampleObject]'))
DROP VIEW [dbo].[vwSampleObject]
GO
/****** Object:  View [dbo].[vwTicket]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwTicket]'))
DROP VIEW [dbo].[vwTicket]
GO
/****** Object:  View [dbo].[vwTicketActivationLog]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwTicketActivationLog]'))
DROP VIEW [dbo].[vwTicketActivationLog]
GO
/****** Object:  View [dbo].[vwTicketDetails]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwTicketDetails]'))
DROP VIEW [dbo].[vwTicketDetails]
GO
/****** Object:  View [dbo].[vwTicketInZone]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwTicketInZone]'))
DROP VIEW [dbo].[vwTicketInZone]
GO
/****** Object:  View [dbo].[vwTicketSettings]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwTicketSettings]'))
DROP VIEW [dbo].[vwTicketSettings]
GO
/****** Object:  View [dbo].[vwTicketUnused]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwTicketUnused]'))
DROP VIEW [dbo].[vwTicketUnused]
GO
/****** Object:  View [dbo].[vwTicketUsage]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwTicketUsage]'))
DROP VIEW [dbo].[vwTicketUsage]
GO
/****** Object:  StoredProcedure [dbo].[spTWChangePassword]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spTWChangePassword]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spTWChangePassword]
GO
/****** Object:  StoredProcedure [dbo].[spTWSelectTicketInfoUsingFilters]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spTWSelectTicketInfoUsingFilters]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spTWSelectTicketInfoUsingFilters]
GO
/****** Object:  StoredProcedure [dbo].[spTWSelectZoneGroupZoneCounter]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spTWSelectZoneGroupZoneCounter]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spTWSelectZoneGroupZoneCounter]
GO
/****** Object:  Table [dbo].[tbClientUploadDownloadLog]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbClientUploadDownloadLog]') AND type in (N'U'))
DROP TABLE [dbo].[tbClientUploadDownloadLog]
GO
/****** Object:  Table [dbo].[tbCode]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbCode]') AND type in (N'U'))
DROP TABLE [dbo].[tbCode]
GO
/****** Object:  Table [dbo].[tbCodeCategory]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbCodeCategory]') AND type in (N'U'))
DROP TABLE [dbo].[tbCodeCategory]
GO
/****** Object:  Table [dbo].[tbCounter]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbCounter]') AND type in (N'U'))
DROP TABLE [dbo].[tbCounter]
GO
/****** Object:  Table [dbo].[tbDownloadLog]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbDownloadLog]') AND type in (N'U'))
DROP TABLE [dbo].[tbDownloadLog]
GO
/****** Object:  Table [dbo].[tbExceptionLog]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbExceptionLog]') AND type in (N'U'))
DROP TABLE [dbo].[tbExceptionLog]
GO
/****** Object:  Table [dbo].[tbPrintingApproved]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbPrintingApproved]') AND type in (N'U'))
DROP TABLE [dbo].[tbPrintingApproved]
GO
/****** Object:  Table [dbo].[tbRole]    Script Date: 10/24/2012 03:07:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbRole]') AND type in (N'U'))
DROP TABLE [dbo].[tbRole]
GO
/****** Object:  Table [dbo].[tbSampleTable]    Script Date: 10/24/2012 03:07:55 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbSampleTable]') AND type in (N'U'))
DROP TABLE [dbo].[tbSampleTable]
GO
/****** Object:  Table [dbo].[tbSetting]    Script Date: 10/24/2012 03:07:55 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbSetting]') AND type in (N'U'))
DROP TABLE [dbo].[tbSetting]
GO
/****** Object:  StoredProcedure [dbo].[InsertSoldTicket]    Script Date: 10/24/2012 03:07:55 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertSoldTicket]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[InsertSoldTicket]
GO
/****** Object:  Table [dbo].[tbTicket]    Script Date: 10/24/2012 03:07:55 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbTicket]') AND type in (N'U'))
DROP TABLE [dbo].[tbTicket]
GO
/****** Object:  Table [dbo].[tbTicketActivationLog]    Script Date: 10/24/2012 03:07:55 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbTicketActivationLog]') AND type in (N'U'))
DROP TABLE [dbo].[tbTicketActivationLog]
GO
/****** Object:  Table [dbo].[tbTicketInZone]    Script Date: 10/24/2012 03:07:55 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbTicketInZone]') AND type in (N'U'))
DROP TABLE [dbo].[tbTicketInZone]
GO
/****** Object:  Table [dbo].[tbTicketLog]    Script Date: 10/24/2012 03:07:55 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbTicketLog]') AND type in (N'U'))
DROP TABLE [dbo].[tbTicketLog]
GO
/****** Object:  Table [dbo].[tbTicketSettings]    Script Date: 10/24/2012 03:07:55 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbTicketSettings]') AND type in (N'U'))
DROP TABLE [dbo].[tbTicketSettings]
GO
/****** Object:  Table [dbo].[tbTicketUnused]    Script Date: 10/24/2012 03:07:55 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbTicketUnused]') AND type in (N'U'))
DROP TABLE [dbo].[tbTicketUnused]
GO
/****** Object:  Table [dbo].[tbTicketUsage]    Script Date: 10/24/2012 03:07:55 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbTicketUsage]') AND type in (N'U'))
DROP TABLE [dbo].[tbTicketUsage]
GO
/****** Object:  Table [dbo].[tbTicketUsageLog]    Script Date: 10/24/2012 03:07:55 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbTicketUsageLog]') AND type in (N'U'))
DROP TABLE [dbo].[tbTicketUsageLog]
GO
/****** Object:  Table [dbo].[tbTransactionLog]    Script Date: 10/24/2012 03:07:55 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbTransactionLog]') AND type in (N'U'))
DROP TABLE [dbo].[tbTransactionLog]
GO
/****** Object:  Table [dbo].[tbUser]    Script Date: 10/24/2012 03:07:55 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbUser]') AND type in (N'U'))
DROP TABLE [dbo].[tbUser]
GO
/****** Object:  Table [dbo].[tbUserAccessLog]    Script Date: 10/24/2012 03:07:55 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbUserAccessLog]') AND type in (N'U'))
DROP TABLE [dbo].[tbUserAccessLog]
GO
/****** Object:  Table [dbo].[tbUserInRole]    Script Date: 10/24/2012 03:07:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbUserInRole]') AND type in (N'U'))
DROP TABLE [dbo].[tbUserInRole]
GO
/****** Object:  Table [dbo].[tbWebUser]    Script Date: 10/24/2012 03:07:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbWebUser]') AND type in (N'U'))
DROP TABLE [dbo].[tbWebUser]
GO
/****** Object:  Table [dbo].[tbZone]    Script Date: 10/24/2012 03:07:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbZone]') AND type in (N'U'))
DROP TABLE [dbo].[tbZone]
GO
/****** Object:  Table [dbo].[tbZoneAndZoneGroup]    Script Date: 10/24/2012 03:07:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbZoneAndZoneGroup]') AND type in (N'U'))
DROP TABLE [dbo].[tbZoneAndZoneGroup]
GO
/****** Object:  Table [dbo].[tbZoneGroup]    Script Date: 10/24/2012 03:07:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbZoneGroup]') AND type in (N'U'))
DROP TABLE [dbo].[tbZoneGroup]
GO
/****** Object:  StoredProcedure [dbo].[TEMP]    Script Date: 10/24/2012 03:07:51 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TEMP]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[TEMP]
GO
/****** Object:  StoredProcedure [dbo].[Ticket]    Script Date: 10/24/2012 03:07:51 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Ticket]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Ticket]
GO
/****** Object:  View [dbo].[vwTicketUsageHistory]    Script Date: 10/24/2012 03:07:51 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwTicketUsageHistory]'))
DROP VIEW [dbo].[vwTicketUsageHistory]
GO
/****** Object:  StoredProcedure [dbo].[SelectNewCounterID]    Script Date: 10/24/2012 03:07:50 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectNewCounterID]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SelectNewCounterID]
GO
/****** Object:  StoredProcedure [dbo].[SelectNewTicketID]    Script Date: 10/24/2012 03:07:50 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectNewTicketID]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SelectNewTicketID]
GO
/****** Object:  StoredProcedure [dbo].[SelectNewTicketID]    Script Date: 10/24/2012 03:07:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectNewTicketID]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

-- SelectNewTicketID
CREATE PROCEDURE [dbo].[SelectNewTicketID] 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT CAST(IDENT_CURRENT(''tbTicket'') AS INT) + 1

END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SelectNewCounterID]    Script Date: 10/24/2012 03:07:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectNewCounterID]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

-- SelectNewTicketID
CREATE PROCEDURE [dbo].[SelectNewCounterID] 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT CAST(IDENT_CURRENT(''tbCounter'') AS INT) + 1

END
' 
END
GO
/****** Object:  View [dbo].[vwTicketUsageHistory]    Script Date: 10/24/2012 03:07:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwTicketUsageHistory]'))
EXEC dbo.sp_executesql @statement = N'CREATE VIEW [dbo].[vwTicketUsageHistory]
AS
SELECT     0 AS Expr1, 0 AS Expr2, 0 AS Expr3, 0 AS Expr4, 0 AS Expr5, 0 AS Expr6, '''' AS Expr7, 0 AS Expr8, '''' AS Expr9, ''1/1/2012'' AS Expr10, NEWID() AS Expr11
WHERE     (0 = 1)
'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'vwTicketUsageHistory', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwTicketUsageHistory'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'vwTicketUsageHistory', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwTicketUsageHistory'
GO
/****** Object:  StoredProcedure [dbo].[Ticket]    Script Date: 10/24/2012 03:07:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Ticket]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[Ticket]

AS
/* SET NOCOUNT ON */
	SELECT * FROM Ticket
	RETURN
' 
END
GO
/****** Object:  StoredProcedure [dbo].[TEMP]    Script Date: 10/24/2012 03:07:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TEMP]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[TEMP]
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
AS
	/* SET NOCOUNT ON */
	SELECT ''kkl'' as UserName, ''01/01/2012'' as DOB

	SELECT 1 as PageNum, 10 AS NumOfPages
	RETURN
' 
END
GO
/****** Object:  Table [dbo].[tbZoneGroup]    Script Date: 10/24/2012 03:07:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbZoneGroup]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tbZoneGroup](
	[PKID] [int] IDENTITY(1,1) NOT NULL,
	[ZoneGroupID] [varchar](10) NOT NULL,
	[ZoneGroupName] [varchar](255) NOT NULL,
	[DaysAllowed] [int] NOT NULL,
	[EntriesAllowed] [int] NOT NULL,
	[Price] [decimal](9, 2) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
	[ModifiedBy] [int] NOT NULL,
	[LastUploadedDate] [datetime] NULL,
	[LastDownloadedDate] [datetime] NULL,
 CONSTRAINT [PK_tbZoneGroup] PRIMARY KEY CLUSTERED 
(
	[PKID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbZoneAndZoneGroup]    Script Date: 10/24/2012 03:07:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbZoneAndZoneGroup]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tbZoneAndZoneGroup](
	[PKID] [int] IDENTITY(1,1) NOT NULL,
	[ZoneGroupID] [int] NOT NULL,
	[ZoneID] [int] NOT NULL,
	[CreatedBy] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[ModifiedDate] [datetime] NULL,
	[LastUploadedDate] [datetime] NULL,
	[LastDownloadedDate] [datetime] NULL
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[tbZone]    Script Date: 10/24/2012 03:07:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbZone]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tbZone](
	[PKID] [int] IDENTITY(1,1) NOT NULL,
	[ZoneID] [varchar](10) NULL,
	[ZoneName] [varchar](255) NOT NULL,
	[Address] [varchar](300) NULL,
	[Phone] [varchar](50) NULL,
	[InCharge] [varchar](50) NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedBy] [int] NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
	[LastUploadedDate] [datetime] NULL,
	[LastDownloadedDate] [datetime] NULL
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbWebUser]    Script Date: 10/24/2012 03:07:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbWebUser]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tbWebUser](
	[PKID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[DisplayName] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[IsAdmin] [bit] NOT NULL,
	[Status] [varchar](50) NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedBy] [int] NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_tbWebUser] PRIMARY KEY CLUSTERED 
(
	[PKID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbUserInRole]    Script Date: 10/24/2012 03:07:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbUserInRole]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tbUserInRole](
	[PKID] [int] IDENTITY(1,1) NOT NULL,
	[UserPKID] [int] NOT NULL,
	[RoleID] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
	[ModifiedBy] [int] NOT NULL,
 CONSTRAINT [PK_tbUserInRole] PRIMARY KEY CLUSTERED 
(
	[PKID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[tbUserAccessLog]    Script Date: 10/24/2012 03:07:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbUserAccessLog]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tbUserAccessLog](
	[PKID] [int] IDENTITY(1,1) NOT NULL,
	[UserPKID] [int] NOT NULL,
	[AccessDate] [datetime] NOT NULL,
	[Action] [varchar](50) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
	[ModifiedBy] [int] NOT NULL,
 CONSTRAINT [PK_tbUserAccessLog] PRIMARY KEY CLUSTERED 
(
	[PKID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbUser]    Script Date: 10/24/2012 03:07:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbUser]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tbUser](
	[PKID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [varchar](20) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[DisplayName] [varchar](50) NOT NULL,
	[Position] [varchar](255) NULL,
	[Status] [varchar](50) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
	[ModifiedBy] [int] NOT NULL,
 CONSTRAINT [PK_tbUser] PRIMARY KEY CLUSTERED 
(
	[PKID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbTransactionLog]    Script Date: 10/24/2012 03:07:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbTransactionLog]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tbTransactionLog](
	[PKID] [int] IDENTITY(1,1) NOT NULL,
	[TransactionType] [varchar](50) NOT NULL,
	[TransactionDate] [datetime] NOT NULL,
	[Data] [varchar](512) NULL,
 CONSTRAINT [PK_tbTransactionLog] PRIMARY KEY CLUSTERED 
(
	[PKID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbTicketUsageLog]    Script Date: 10/24/2012 03:07:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbTicketUsageLog]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tbTicketUsageLog](
	[PKID] [int] IDENTITY(1,1) NOT NULL,
	[TicketID] [int] NOT NULL,
	[ZoneID] [int] NOT NULL,
	[CounterID] [int] NOT NULL,
	[UsageCountBefore] [int] NOT NULL,
	[UsageCountAfter] [int] NOT NULL,
	[DateUsed] [datetime] NOT NULL,
	[TransactionID] [uniqueidentifier] NOT NULL,
	[LastUploadedDate] [datetime] NULL,
	[LastDownloadedDate] [datetime] NULL,
 CONSTRAINT [PK_tbTicketUsageLog] PRIMARY KEY CLUSTERED 
(
	[PKID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[tbTicketUsage]    Script Date: 10/24/2012 03:07:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbTicketUsage]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tbTicketUsage](
	[PKID] [int] NOT NULL,
	[TicketID] [int] NOT NULL,
	[ZoneID] [int] NOT NULL,
	[CounterID] [int] NOT NULL,
	[DateUsed] [datetime] NOT NULL,
 CONSTRAINT [PK_tbTicketUsage] PRIMARY KEY CLUSTERED 
(
	[PKID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[tbTicketUnused]    Script Date: 10/24/2012 03:07:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbTicketUnused]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tbTicketUnused](
	[PKID] [int] IDENTITY(1,1) NOT NULL,
	[SerialNo] [varchar](50) NOT NULL,
	[Reason] [nvarchar](500) NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedBy] [int] NOT NULL,
	[ModifiedDate] [datetime] NOT NULL
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbTicketSettings]    Script Date: 10/24/2012 03:07:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbTicketSettings]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tbTicketSettings](
	[PKID] [int] IDENTITY(1,1) NOT NULL,
	[ZoneGroupID] [varchar](50) NULL,
	[DaysAllowed] [int] NULL,
	[EntryAllowed] [int] NULL,
	[Price] [decimal](9, 2) NULL,
	[CreatedBy] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[ModifiedDate] [datetime] NULL,
 CONSTRAINT [PK_tbTicketSettings] PRIMARY KEY CLUSTERED 
(
	[PKID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbTicketLog]    Script Date: 10/24/2012 03:07:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbTicketLog]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tbTicketLog](
	[PKID] [int] IDENTITY(1,1) NOT NULL,
	[CounterID] [int] NOT NULL,
	[TransactionID] [uniqueidentifier] NOT NULL,
	[TicketID] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_tbTicketLog] PRIMARY KEY CLUSTERED 
(
	[PKID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[tbTicketInZone]    Script Date: 10/24/2012 03:07:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbTicketInZone]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tbTicketInZone](
	[PKID] [int] IDENTITY(1,1) NOT NULL,
	[TicketID] [varchar](50) NOT NULL,
	[ZoneGroupID] [varchar](50) NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedBy] [int] NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
	[LastUploadedDate] [datetime] NULL,
 CONSTRAINT [PK_tbTicketInZone] PRIMARY KEY CLUSTERED 
(
	[PKID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbTicketActivationLog]    Script Date: 10/24/2012 03:07:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbTicketActivationLog]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tbTicketActivationLog](
	[PKID] [int] IDENTITY(1,1) NOT NULL,
	[CounterID] [int] NOT NULL,
	[ZoneID] [int] NOT NULL,
	[TransactionID] [uniqueidentifier] NOT NULL,
	[TicketID] [int] NOT NULL,
	[ActivatedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_tbTicketActivationLog] PRIMARY KEY CLUSTERED 
(
	[PKID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[tbTicket]    Script Date: 10/24/2012 03:07:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbTicket]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tbTicket](
	[PKID] [int] IDENTITY(100000000,1) NOT NULL,
	[Price] [decimal](9, 2) NOT NULL,
	[TicketStatus] [varchar](50) NOT NULL,
	[AllowedUsage] [int] NOT NULL,
	[AlreadyUsed] [int] NOT NULL,
	[AllowedDays] [int] NOT NULL,
	[TicketData] [varchar](256) NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[SoldDate] [datetime] NULL,
	[SoldZoneID] [int] NULL,
	[ModifiedDate] [datetime] NOT NULL,
	[ModifiedBy] [int] NOT NULL,
	[IsActivated] [bit] NOT NULL,
	[ActivatedDate] [datetime] NULL,
	[ActivatedBy] [int] NULL,
	[ExpiryDate] [datetime] NULL,
	[LastUploadedDate] [datetime] NULL,
	[LastDownloadedDate] [datetime] NULL,
 CONSTRAINT [PK_tbTicket] PRIMARY KEY CLUSTERED 
(
	[PKID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[InsertSoldTicket]    Script Date: 10/24/2012 03:07:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertSoldTicket]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[InsertSoldTicket]
	(
	@id int OUTPUT
	, @TicketID int
	, @SoldZoneID int
	, @SoldZoneGroupID int
	, @SoldDate datetime
	, @ErrorCode varchar(50) OUTPUT
	, @ErrorMsg varchar(50) OUTPUT
	)
AS
/* SET NOCOUNT ON */
	BEGIN

	INSERT INTO tbSoldInfo(TicketID, SoldZoneID, SoldZoneGroupID, SoldDate)
	VALUES (@TicketID, @SoldZoneID, @SoldZoneGroupID, @SoldDate)

	SET @id = @@IDENTITY
		
	IF @@ERROR <> 0
		BEGIN
			SELECT @ErrorCode = @@ERROR	
			SELECT CAST(@ErrorCode AS INT)
			RETURN
		END
	
	SELECT @ErrorCode = 0
	SELECT @ErrorMsg = ''''
	
	SELECT CAST(@ErrorCode AS INT)
	
	RETURN
	END
' 
END
GO
/****** Object:  Table [dbo].[tbSetting]    Script Date: 10/24/2012 03:07:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbSetting]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tbSetting](
	[PKID] [int] IDENTITY(1,1) NOT NULL,
	[SettingName] [varchar](50) NOT NULL,
	[SettingDisplayName] [varchar](128) NOT NULL,
	[SettingDescription] [varchar](256) NULL,
	[SettingValue] [varchar](50) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[ModifiedDate] [datetime] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_tbSetting] PRIMARY KEY CLUSTERED 
(
	[PKID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbSampleTable]    Script Date: 10/24/2012 03:07:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbSampleTable]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tbSampleTable](
	[PKID] [int] IDENTITY(1,1) NOT NULL,
	[SampleColumn] [varchar](50) NOT NULL,
	[CreatedDate] [datetime] NULL,
 CONSTRAINT [PK_SampleTable] PRIMARY KEY CLUSTERED 
(
	[PKID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbRole]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbRole]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tbRole](
	[PKID] [int] NOT NULL,
	[RoleName] [varchar](50) NOT NULL,
	[RoleDescription] [varchar](255) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
	[ModifiedBy] [int] NOT NULL,
 CONSTRAINT [PK_tbRole] PRIMARY KEY CLUSTERED 
(
	[PKID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbPrintingApproved]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbPrintingApproved]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tbPrintingApproved](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ApprovedCode] [varchar](50) NOT NULL
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbExceptionLog]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbExceptionLog]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tbExceptionLog](
	[PKID] [int] IDENTITY(1,1) NOT NULL,
	[ErrorMessage] [varchar](256) NOT NULL,
	[StackTrace] [varchar](1024) NULL,
	[CreatedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_tbExceptionLog] PRIMARY KEY CLUSTERED 
(
	[PKID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbDownloadLog]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbDownloadLog]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tbDownloadLog](
	[PKID] [int] IDENTITY(1,1) NOT NULL,
	[CounterID] [int] NOT NULL,
	[LastDownloadedDateTime] [datetime] NOT NULL,
 CONSTRAINT [PK_DownloadLog] PRIMARY KEY CLUSTERED 
(
	[PKID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[tbCounter]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbCounter]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tbCounter](
	[PKID] [int] IDENTITY(100,1) NOT NULL,
	[CounterID] [int] NOT NULL,
	[ZoneID] [int] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[tbCodeCategory]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbCodeCategory]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tbCodeCategory](
	[PKID] [int] NOT NULL,
	[CodeCategory] [varchar](50) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
	[ModifiedBy] [int] NOT NULL,
 CONSTRAINT [PK_tbCodeCategory] PRIMARY KEY CLUSTERED 
(
	[PKID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbCode]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbCode]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tbCode](
	[PKID] [int] NOT NULL,
	[CategoryID] [int] NOT NULL,
	[Code] [varchar](50) NOT NULL,
	[Description] [varchar](50) NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
	[ModifiedBy] [int] NOT NULL,
 CONSTRAINT [PK_tbCode] PRIMARY KEY CLUSTERED 
(
	[PKID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbClientUploadDownloadLog]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbClientUploadDownloadLog]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tbClientUploadDownloadLog](
	[PKID] [int] IDENTITY(1,1) NOT NULL,
	[LastUploadedDateTime] [datetime] NOT NULL,
	[LastDownloadedDateTime] [datetime] NOT NULL,
 CONSTRAINT [PK_UploadLog] PRIMARY KEY CLUSTERED 
(
	[PKID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  StoredProcedure [dbo].[spTWSelectZoneGroupZoneCounter]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spTWSelectZoneGroupZoneCounter]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[spTWSelectZoneGroupZoneCounter]
	(
@PageNum INT,
@ItemPerPage INT,
@NumOfPage INT OUTPUT
	)
AS
DECLARE @ItemCount INT
SET @ItemCount =  (SELECT Count(ZNE.PKID)
FROM      

	tbZoneGroup AS ZGP
	LEFT JOIN tbZoneAndZoneGroup AS ZZG ON ZZG.ZoneGroupID = ZGP.ZoneGroupID
	LEFT JOIN tbZone AS ZNE ON ZNE.ZoneID = ZZG.ZoneID
	LEFT JOIn tbCounter AS CTR ON CTR.ZoneID = ZNE.ZoneID
	)
	
SET @NumOfPage = Ceiling(Cast(@ItemCount as Decimal) / Cast(@ItemPerPage as Decimal))

	SELECT * FROM (
SELECT Row_Number() Over(ORDER BY ZNE.PKID DESC) AS RowIndex,     ZGP.ZoneGroupName, ZGP.ZoneGroupID, ZNE.ZoneID, ZNE.ZoneName, CTR.CounterID
FROM      

	tbZoneGroup AS ZGP
	LEFT JOIN tbZoneAndZoneGroup AS ZZG ON ZZG.ZoneGroupID = ZGP.ZoneGroupID
	LEFT JOIN tbZone AS ZNE ON ZNE.ZoneID = ZZG.ZoneID
	LEFT JOIn tbCounter AS CTR ON CTR.ZoneID = ZNE.ZoneID
	) AS TEMP
WHERE RowIndex BETWEEN (@ItemPerPage * @PageNum) AND (@ItemPerPage * (@PageNum + 1))

	RETURN
' 
END
GO
/****** Object:  StoredProcedure [dbo].[spTWSelectTicketInfoUsingFilters]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spTWSelectTicketInfoUsingFilters]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[spTWSelectTicketInfoUsingFilters]
(
	@TicketSerialFrom INT,
	@TicketSerialTo INT,
	@TicketStatus varchar(50),
	@ZoneGroupID INT,
	@CreatedDateFrom DateTime,
	@CreatedDateTo DateTime,
	@ActivatedDateFrom DateTime,
	@ActivatedDateTo DateTime,
	@ExpiryDateFrom DateTime,
	@ExpiryDateTo DateTime,
	@PageNum INT,
	@ItemPerPage INT,
	@NumOfPage INT OUTPUT
)
AS
	/* SET NOCOUNT ON */
DECLARE @ItemCount INT
SET @ItemCount = (
	SELECT 
		Count(TKT.PKID)
	FROM tbTicket AS TKT
	INNER JOIN tbTicketInZone AS TIZ ON TIZ.TicketID = TKT.PKID
	INNER JOIN tbZoneGroup AS ZGP ON ZGP.ZoneGroupID = TIZ.ZoneGroupID
	LEFT JOIN tbUser AS USR1 ON USR1.PKID = TKT.CreatedBy
	LEFT JOIN tbUser AS USR2 ON USR2.PKID = TKT.ModifiedBy
	LEFT JOIN tbUser AS USR3 ON USR3.PKID = TKT.ActivatedBy
	WHERE 
	(@TicketSerialFrom IS NULL OR @TicketSerialTo IS NULL OR TKT.PKID BETWEEN @TicketSerialFrom AND @TicketSerialTo)
	AND (@TicketStatus IS NULL OR @TicketStatus = TicketStatus)
	AND (@CreatedDateFrom IS NULL OR @CreatedDateTo IS NULL OR TKT.CreatedDate BETWEEN @CreatedDateFrom AND @CreatedDateTo)
	AND (@ActivatedDateFrom IS NULL OR @ActivatedDateTo IS NULL OR TKT.ActivatedDate BETWEEN @ActivatedDateFrom AND @ActivatedDateTo)
	AND (@ExpiryDateFrom IS NULL OR @ExpiryDateTo IS NULL OR TKT.ExpiryDate BETWEEN @ExpiryDateFrom AND @ExpiryDateTo)
	AND (@ZoneGroupID IS NULL OR @ZoneGroupID = TIZ.ZoneGroupID)
	)
	
SET @NumOfPage = Ceiling(Cast(@ItemCount as Decimal) / Cast(@ItemPerPage as Decimal))

SELECT * FROM (
	SELECT Row_Number() Over(ORDER BY TKT.PKID DESC) AS RowIndex,
		TKT.PKID,
		TKT.Price,
		TKT.TicketStatus,
		TKT.AllowedUsage,
		TKT.AlreadyUsed,
		TKT.AllowedDays,
		TKT.CreatedDate,
		TKT.ExpiryDate,
		USR1.UserID AS CreatedBy,
		TKT.ModifiedDate,
		USR2.UserID AS ModifiedBy,
		TKT.ActivatedDate,
		USR3.UserID AS ActivatedBy,
		ZGP.ZoneGroupID,
		ZGP.ZoneGroupName
	FROM tbTicket AS TKT
	INNER JOIN tbTicketInZone AS TIZ ON TIZ.TicketID = TKT.PKID
	INNER JOIN tbZoneGroup AS ZGP ON ZGP.ZoneGroupID = TIZ.ZoneGroupID
	LEFT JOIN tbUser AS USR1 ON USR1.PKID = TKT.CreatedBy
	LEFT JOIN tbUser AS USR2 ON USR2.PKID = TKT.ModifiedBy
	LEFT JOIN tbUser AS USR3 ON USR3.PKID = TKT.ActivatedBy
	WHERE 
	(@TicketSerialFrom IS NULL OR @TicketSerialTo IS NULL OR TKT.PKID BETWEEN @TicketSerialFrom AND @TicketSerialTo)
	AND (@TicketStatus IS NULL OR @TicketStatus = TicketStatus)
	AND (@CreatedDateFrom IS NULL OR @CreatedDateTo IS NULL OR TKT.CreatedDate BETWEEN @CreatedDateFrom AND @CreatedDateTo)
	AND (@ActivatedDateFrom IS NULL OR @ActivatedDateTo IS NULL OR TKT.ActivatedDate BETWEEN @ActivatedDateFrom AND @ActivatedDateTo)
	AND (@ExpiryDateFrom IS NULL OR @ExpiryDateTo IS NULL OR TKT.ExpiryDate BETWEEN @ExpiryDateFrom AND @ExpiryDateTo)
	AND (@ZoneGroupID IS NULL OR @ZoneGroupID = TIZ.ZoneGroupID)
	) AS TEMP
WHERE RowIndex BETWEEN (@ItemPerPage * @PageNum) AND (@ItemPerPage * (@PageNum + 1))


	RETURN
' 
END
GO
/****** Object:  StoredProcedure [dbo].[spTWChangePassword]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spTWChangePassword]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[spTWChangePassword]
(
	@UserPKID INT,
	@Password VARCHAR(128),
	@ModifiedDate DATETIME,
	@ModifiedBy INT,
	@ErrorCode INT OUTPUT,
	@ErrorMsg VARCHAR(128) OUTPUT
)
AS
	/* SET NOCOUNT ON */

	UPDATE tbWebUser
	SET Password = @Password
	WHERE PKID = @UserPKID
	RETURN
' 
END
GO
/****** Object:  View [dbo].[vwTicketUsage]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwTicketUsage]'))
EXEC dbo.sp_executesql @statement = N'
CREATE VIEW [dbo].[vwTicketUsage]
AS
SELECT        PKID, TicketID, ZoneID, DateUsed
FROM            dbo.tbTicketUsage'
GO
/****** Object:  View [dbo].[vwTicketUnused]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwTicketUnused]'))
EXEC dbo.sp_executesql @statement = N'CREATE VIEW [dbo].[vwTicketUnused]
AS
SELECT        dbo.tbTicketUnused.PKID, dbo.tbTicketUnused.SerialNo, dbo.tbTicketUnused.Reason, dbo.tbTicketUnused.CreatedBy, dbo.tbTicketUnused.CreatedDate, 
                         dbo.tbTicketUnused.ModifiedBy, dbo.tbTicketUnused.ModifiedDate, dbo.tbUser.UserID
FROM            dbo.tbTicketUnused INNER JOIN
                         dbo.tbUser ON dbo.tbTicketUnused.CreatedBy = dbo.tbUser.PKID AND dbo.tbTicketUnused.ModifiedBy = dbo.tbUser.PKID'
GO
/****** Object:  View [dbo].[vwTicketSettings]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwTicketSettings]'))
EXEC dbo.sp_executesql @statement = N'CREATE VIEW [dbo].[vwTicketSettings]
AS
SELECT        PKID, ZoneGroupID, DaysAllowed, EntryAllowed, Price, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate
FROM            dbo.tbTicketSettings
'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'vwTicketSettings', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tbTicketSettings"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 135
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 5
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwTicketSettings'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'vwTicketSettings', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwTicketSettings'
GO
/****** Object:  View [dbo].[vwTicketInZone]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwTicketInZone]'))
EXEC dbo.sp_executesql @statement = N'
CREATE VIEW [dbo].[vwTicketInZone]
AS
SELECT        PKID, TicketID, ZoneGroupID, CreatedDate, CreatedBy, ModifiedDate, ModifiedBy
FROM            dbo.tbTicketInZone'
GO
/****** Object:  View [dbo].[vwTicketDetails]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwTicketDetails]'))
EXEC dbo.sp_executesql @statement = N'CREATE VIEW [dbo].[vwTicketDetails]
AS
SELECT        dbo.tbTicket.PKID, dbo.tbTicket.Price, dbo.tbTicket.TicketStatus, dbo.tbZoneGroup.ZoneGroupName, dbo.tbTicket.CreatedDate, dbo.tbUser.UserID, 
                         dbo.tbTicket.AllowedUsage, dbo.tbTicket.AllowedDays, dbo.tbTicket.SoldDate, dbo.tbZone.ZoneName, dbo.tbTicket.ActivatedDate, dbo.tbTicket.ExpiryDate, 
                         dbo.tbTicket.AlreadyUsed
FROM            dbo.tbTicket INNER JOIN
                         dbo.tbTicketInZone ON dbo.tbTicket.PKID = dbo.tbTicketInZone.TicketID INNER JOIN
                         dbo.tbZoneGroup ON dbo.tbTicketInZone.ZoneGroupID = dbo.tbZoneGroup.ZoneGroupID INNER JOIN
                         dbo.tbUser ON dbo.tbTicket.CreatedBy = dbo.tbUser.PKID INNER JOIN
                         dbo.tbZone ON dbo.tbTicket.PKID = dbo.tbZone.PKID AND dbo.tbTicket.SoldZoneID = dbo.tbZone.ZoneID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'vwTicketDetails', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[54] 4[20] 2[16] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tbTicket"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 256
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbTicketInZone"
            Begin Extent = 
               Top = 0
               Left = 239
               Bottom = 129
               Right = 409
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbZoneGroup"
            Begin Extent = 
               Top = 38
               Left = 465
               Bottom = 167
               Right = 646
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbUser"
            Begin Extent = 
               Top = 142
               Left = 271
               Bottom = 271
               Right = 441
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
  ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwTicketDetails'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane2' , N'SCHEMA',N'dbo', N'VIEW',N'vwTicketDetails', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'    End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwTicketDetails'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'vwTicketDetails', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwTicketDetails'
GO
/****** Object:  View [dbo].[vwTicketActivationLog]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwTicketActivationLog]'))
EXEC dbo.sp_executesql @statement = N'CREATE VIEW [dbo].[vwTicketActivationLog]
AS
SELECT     dbo.tbTicketActivationLog.*
FROM         dbo.tbTicketActivationLog
'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'vwTicketActivationLog', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tbTicketActivationLog"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 149
               Right = 198
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwTicketActivationLog'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'vwTicketActivationLog', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwTicketActivationLog'
GO
/****** Object:  View [dbo].[vwTicket]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwTicket]'))
EXEC dbo.sp_executesql @statement = N'CREATE VIEW [dbo].[vwTicket]
AS
SELECT        dbo.tbTicket.PKID, dbo.tbTicket.Price, dbo.tbTicket.TicketStatus, dbo.tbTicket.AllowedUsage, dbo.tbTicket.AlreadyUsed, dbo.tbTicket.IsActivated, 
                         dbo.tbTicket.CreatedDate, dbo.tbTicket.CreatedBy, dbo.tbTicket.ModifiedDate, dbo.tbTicket.ModifiedBy, dbo.tbTicket.ActivatedDate, dbo.tbTicket.ActivatedBy, 
                         dbo.tbTicket.ExpiryDate, dbo.tbTicket.AllowedDays, dbo.tbTicket.SoldDate, dbo.tbZone.ZoneName, dbo.tbTicket.TicketData
FROM            dbo.tbTicket LEFT OUTER JOIN
                         dbo.tbZone ON dbo.tbTicket.SoldZoneID = dbo.tbZone.ZoneID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'vwTicket', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tbTicket"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 149
               Right = 198
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwTicket'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'vwTicket', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwTicket'
GO
/****** Object:  View [dbo].[vwSampleObject]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwSampleObject]'))
EXEC dbo.sp_executesql @statement = N'CREATE VIEW [dbo].[vwSampleObject]
AS
SELECT     PKID, SampleColumn
FROM         dbo.tbSampleTable
'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'vwSampleObject', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tbSampleTable"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 129
               Right = 198
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwSampleObject'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'vwSampleObject', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwSampleObject'
GO
/****** Object:  View [dbo].[vwRole]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwRole]'))
EXEC dbo.sp_executesql @statement = N'CREATE VIEW [dbo].[vwRole]
AS
SELECT        PKID, RoleName, RoleDescription
FROM            dbo.tbRole
'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'vwRole', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tbRole"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 195
               Right = 210
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwRole'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'vwRole', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwRole'
GO
/****** Object:  View [dbo].[vwPrintingApproved]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwPrintingApproved]'))
EXEC dbo.sp_executesql @statement = N'CREATE VIEW [dbo].[vwPrintingApproved]
AS
SELECT        id, ApprovedCode
FROM            dbo.tbPrintingApproved'
GO
/****** Object:  View [dbo].[vwExceptionLog]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwExceptionLog]'))
EXEC dbo.sp_executesql @statement = N'CREATE VIEW [dbo].[vwExceptionLog]
AS
SELECT        PKID, ErrorMessage, StackTrace, CreatedDate
FROM            dbo.tbExceptionLog
'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'vwExceptionLog', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tbExceptionLog"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 160
               Right = 206
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwExceptionLog'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'vwExceptionLog', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwExceptionLog'
GO
/****** Object:  View [dbo].[vwDistinctZoneGroupName]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwDistinctZoneGroupName]'))
EXEC dbo.sp_executesql @statement = N'CREATE VIEW [dbo].[vwDistinctZoneGroupName]
AS
SELECT        ZoneGroupName
FROM            dbo.tbZoneGroup'
GO
/****** Object:  View [dbo].[vwCounterTicketUsageHistory]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwCounterTicketUsageHistory]'))
EXEC dbo.sp_executesql @statement = N'CREATE VIEW [dbo].[vwCounterTicketUsageHistory]
AS
SELECT     dbo.tbTicketUsageLog.TicketID, dbo.tbTicketUsageLog.ZoneID, dbo.tbTicketUsageLog.CounterID, dbo.tbTicketUsageLog.UsageCountBefore, dbo.tbTicketUsageLog.UsageCountAfter, dbo.tbTicketUsageLog.DateUsed, dbo.tbTicketUsageLog.TransactionID, 
                      dbo.tbTicket.TicketStatus, dbo.tbTicket.AllowedUsage
FROM         dbo.tbTicketUsageLog INNER JOIN
                      dbo.tbTicket ON dbo.tbTicketUsageLog.PKID = dbo.tbTicket.PKID
'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'vwCounterTicketUsageHistory', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tbTicketUsageLog"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 149
               Right = 218
            End
            DisplayFlags = 280
            TopColumn = 4
         End
         Begin Table = "tbTicket"
            Begin Extent = 
               Top = 6
               Left = 256
               Bottom = 149
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 5
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwCounterTicketUsageHistory'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'vwCounterTicketUsageHistory', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwCounterTicketUsageHistory'
GO
/****** Object:  View [dbo].[vwCounterAndZone]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwCounterAndZone]'))
EXEC dbo.sp_executesql @statement = N'CREATE VIEW [dbo].[vwCounterAndZone]
AS
SELECT        dbo.tbZoneAndZoneGroup.ZoneID, dbo.tbZoneAndZoneGroup.ZoneGroupID, dbo.tbZone.ZoneName, dbo.tbZoneGroup.ZoneGroupName, dbo.tbCounter.CounterID, 
                         dbo.tbCounter.PKID, dbo.tbCounter.CreatedBy, dbo.tbCounter.CreatedDate
FROM            dbo.tbZoneAndZoneGroup INNER JOIN
                         dbo.tbZoneGroup ON dbo.tbZoneAndZoneGroup.ZoneGroupID = dbo.tbZoneGroup.ZoneGroupID INNER JOIN
                         dbo.tbZone ON dbo.tbZoneAndZoneGroup.ZoneID = dbo.tbZone.ZoneID INNER JOIN
                         dbo.tbCounter ON dbo.tbZoneAndZoneGroup.ZoneID = dbo.tbCounter.ZoneID'
GO
/****** Object:  View [dbo].[vwCounter]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwCounter]'))
EXEC dbo.sp_executesql @statement = N'CREATE VIEW [dbo].[vwCounter]
AS
SELECT        PKID, CounterID, ZoneID, CreatedBy, CreatedDate
FROM            dbo.tbCounter'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'vwCounter', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tbCounter"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 101
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwCounter'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'vwCounter', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwCounter'
GO
/****** Object:  View [dbo].[vwClientUploadDownloadLog]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwClientUploadDownloadLog]'))
EXEC dbo.sp_executesql @statement = N'CREATE VIEW [dbo].[vwClientUploadDownloadLog]
AS
SELECT     dbo.tbClientUploadDownloadLog.*
FROM         dbo.tbClientUploadDownloadLog
'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'vwClientUploadDownloadLog', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tbClientUploadDownloadLog"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 109
               Right = 251
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwClientUploadDownloadLog'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'vwClientUploadDownloadLog', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwClientUploadDownloadLog'
GO
/****** Object:  StoredProcedure [dbo].[ValidateTicket]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ValidateTicket]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- ValidateTicket 1000090,null,null
/*
declare @errorCode varchar(50)
declare @errorMsg varchar(50)
exec ValidateTicket ''1000090'',100,@errorCode OUTPUT, @errorMsg,null,null
select @errorCode,@errorMsg
*/
CREATE PROCEDURE [dbo].[ValidateTicket]	
(
	@ticketSerialNum INT,
	@zoneID INT,
	@ValidationCode VARCHAR(50) OUTPUT,
	@ValidationMsg VARCHAR(50) OUTPUT,
	@ErrorCode VARCHAR(50) OUTPUT,
	@ErrorMsg VARCHAR(50) OUTPUT
)
AS
BEGIN
	SET @ErrorCode = 0
	SET @ErrorMsg = ''''
	-- check the ticket is in our system
	IF NOT EXISTS(SELECT PKID FROM tbTicket WHERE PKID =  @ticketSerialNum)
	BEGIN
		-- ticket is not activated yet
		SET @ValidationCode = 1001
		SET @ValidationMsg = ''Not Valid''
		SELECT 1
		RETURN
	END

	-- check the ticket activation status
	IF NOT EXISTS(SELECT * FROM tbTicket WHERE PKID =  @ticketSerialNum AND IsActivated =  1)
	BEGIN
		-- ticket is not activated yet
		SET @ValidationCode = 1000
		SET @ValidationMsg = ''Not Activated''
		SELECT 2
		RETURN
	END

	-- check the ticket is valid to be used in this zone (DO NOT VALIDATE ZONE FOR NOW TO AVOID DATA SYNC FOR ZONE)
	/*
	IF NOT EXISTS(
		SELECT TKT.PKID FROM tbTicket AS TKT 
		INNER JOIN tbTicketInZone AS TIZ ON TIZ.TicketID = TKT.PKID
		WHERE  TKT.PKID =  @ticketSerialNum AND TIZ.ZoneGroupID = @ZoneID
	)
	BEGIN
		-- ticket is not valid in this zone
		SET @ErrorCode = 4
		SET @ErrorMsg = ''Invalid Zone''
		SELECT 4
		RETURN
	END
	*/

	-- check the ticket is expired or not
	IF NOT EXISTS(SELECT * FROM tbTicket WHERE PKID =  @ticketSerialNum AND (ExpiryDate IS NULL OR ExpiryDate >= DateAdd(minute,90,GetUTCDate())))
	BEGIN
		-- ticket is expired
		SET @ValidationCode = 3
		SET @ValidationMsg = ''Expired''
		SELECT 3
		RETURN
	END

	

	-- check ticket has already used up for maximum number of entries allowed
	IF EXISTS(SELECT PKID FROM tbTicket WHERE PKID =  @ticketSerialNum AND AlreadyUsed = AllowedUsage)
	BEGIN
		-- ticket is expired
		SET @ValidationCode = 5
		SET @ValidationMsg = ''Fully Used Up''
		SELECT 5
		RETURN
	END

	-- if all validation is passed, ticket is valid
	SET @ValidationCode = 0
	SET @ValidationMsg = ''Validation Pass''
	
	SET @ErrorCode = 0
	SET @ErrorMsg = ''''
	
	SELECT CAST(@ErrorCode AS INT)

	/* SET NOCOUNT ON */
	RETURN 0
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[UserLogIn]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UserLogIn]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[UserLogIn]

	(
	@UserID nvarchar(15)
	, @Password nvarchar(50)
	)

AS
	/* SET NOCOUNT ON */
	SELECT USR.*,RLE.PKID AS RoleID, RLE.RoleName AS Role FROM tbUser AS USR
	INNER JOIN tbUserInRole AS UIR ON UIR.UserPKID = USR.PKID
	INNER JOIN tbRole AS RLE ON UIR.RoleID = RLE.PKID
	WHERE USR.UserID = @UserID AND USR.Password = @Password
	RETURN
' 
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateZoneGroup]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UpdateZoneGroup]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[UpdateZoneGroup]
	
	(
	@PKID int,
	@ZoneGroupID varchar(10),
	@ZoneGroupName varchar(255),
	@DaysAllowed int,
	@EntriesAllowed int,
	@Price decimal,
	@ModifiedBy int,
	@ModifiedDate datetime,
	@ErrorCode varchar(50) output,
	@ErrorMsg varchar(50) output
	)
	
AS
BEGIN
		/* SET NOCOUNT ON */
		UPDATE tbZoneGroup
		SET
			ZoneGroupID  = @ZoneGroupID
			, ZoneGroupName = @ZoneGroupName
			, DaysAllowed = @DaysAllowed
			, EntriesAllowed = @EntriesAllowed
			, Price = @Price
			, ModifiedBy = @ModifiedBy
			, ModifiedDate = @ModifiedDate
		WHERE PKID = @PKID
	
	SET @PKID = @@IDENTITY
		
	IF @@ERROR <> 0
		BEGIN
			SELECT @ErrorCode = @@ERROR	
			SELECT CAST(@ErrorCode AS INT)
			RETURN
		END
	
	SELECT @ErrorCode = 0
	SELECT @ErrorMsg = ''''
	
	SELECT CAST(@ErrorCode AS INT)
	RETURN
	END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateZoneAndZoneGroup]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UpdateZoneAndZoneGroup]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[UpdateZoneAndZoneGroup]
	
	(
	@PKID int,
	@ZoneGroupID varchar(10),
	@ZoneID varchar(10),
	@ModifiedBy int,
	@ModifiedDate datetime,
	@ErrorCode varchar(50) output,
	@ErrorMsg varchar(50) output
	)
	
AS
BEGIN
	/* SET NOCOUNT ON */
	UPDATE tbZoneAndZoneGroup
	SET
		ZoneGroupID  = @ZoneGroupID
		, ZoneID = @ZoneID
		, ModifiedBy = @ModifiedBy
		, ModifiedDate = @ModifiedDate
	WHERE PKID = @PKID
	

	SET @PKID = @@IDENTITY
		
	IF @@ERROR <> 0
		BEGIN
			SELECT @ErrorCode = @@ERROR	
			SELECT CAST(@ErrorCode AS INT)
			RETURN
		END
	
	SELECT @ErrorCode = 0
	SELECT @ErrorMsg = ''''
	
	SELECT CAST(@ErrorCode AS INT)
	RETURN
	END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateZone]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UpdateZone]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[UpdateZone]
	
	(
	@PKID int,
	@LinkID int,
	@ZoneID varchar(10),
	@ZoneGroupID varchar(10),
	@ZoneName varchar(50),
	@Address varchar(300),
	@Phone varchar(50),
	@Incharge varchar(50),
	@ModifiedBy int,
	@ModifiedDate datetime,
	@ErrorCode varchar(50) output,
	@ErrorMsg varchar(50) output
	)
	
AS
BEGIN
/* SET NOCOUNT ON */
	UPDATE tbZONE
	SET 
	ZoneID = @ZoneID
	, ZoneName = @ZoneName
	, Address = @Address
	, Phone = @Phone
	, Incharge = @Incharge
	, ModifiedBy = @ModifiedBy
	, ModifiedDate = @ModifiedDate
	WHERE PKID = @PKID

UPDATE tbZoneAndZoneGroup
	SET
		ZoneGroupID  = @ZoneGroupID
		, ZoneID = @ZoneID
		, ModifiedBy = @ModifiedBy
		, ModifiedDate = @ModifiedDate
	WHERE PKID = @LinkID
		
	IF @@ERROR <> 0
		BEGIN
			SELECT @ErrorCode = @@ERROR	
			SELECT CAST(@ErrorCode AS INT)
			RETURN
		END
	
	SELECT @ErrorCode = 0
	SELECT @ErrorMsg = ''''
	
	SELECT CAST(@ErrorCode AS INT)
	RETURN
	END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateWebUser]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UpdateWebUser]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[UpdateWebUser]
	(
	@UserID varchar(50)
	, @Password varchar(50)
	, @DisplayName varchar(50)
	, @Email varchar(50)
	, @Status varchar(10)
	, @ModifiedDate datetime
	, @ModifiedBy int
	, @ErrorCode varchar(50) OUTPUT
	, @ErrorMsg varchar(50) OUTPUT
	)
AS
	/* SET NOCOUNT ON */

BEGIN

	UPDATE tbWebUser
	SET
		--Password = @Password
		DisplayName = @DisplayName
		, Email = @Email
		, Status = @Status
		, ModifiedDate = @ModifiedDate
		, ModifiedBy = @ModifiedBy
	WHERE UserID = @UserID

		
	IF @@ERROR <> 0
		BEGIN
			SELECT @ErrorCode = @@ERROR	
			SELECT CAST(@ErrorCode AS INT)
			RETURN
		END
	
	SELECT @ErrorCode = 0
	SELECT @ErrorMsg = ''''
	
	SELECT CAST(@ErrorCode AS INT)
	RETURN
	END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateUserInRole]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UpdateUserInRole]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[UpdateUserInRole]
	(
	@PKID int OUTPUT
	, @UserID varchar(50)
	, @RoleName varchar(50)
	, @ModifiedDate datetime
	, @ModifiedBy int
	, @ErrorCode varchar(50) OUTPUT
	, @ErrorMsg varchar(50) output
	)
AS
/* SET NOCOUNT ON */
	BEGIN

	DECLARE @UserPKID int, @RoleID int
	SET @UserPKID = (SELECT PKID FROM tbUser WHERE UserID = @UserID)
	SET @RoleID = (SELECT PKID FROM tbRole WHERE RoleName = @RoleName)

	UPDATE TbUserInRole
	SET
		RoleID = @RoleID
		, ModifiedDate = @ModifiedDate
		, ModifiedBy = @ModifiedBy
	WHERE UserPKID = @UserPKID

	SET @PKID = @@IDENTITY
		
	IF @@ERROR <> 0
		BEGIN
			SELECT @ErrorCode = @@ERROR	
			SELECT CAST(@ErrorCode AS INT)
			RETURN
		END
	
	SELECT @ErrorCode = 0
	SELECT @ErrorMsg = ''''
	
	SELECT CAST(@ErrorCode AS INT)
	RETURN
	END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateUser]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UpdateUser]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[UpdateUser]
	(
	@UserID varchar(20)
	, @Password varchar(50)
	, @DisplayName varchar(50)
	, @Position varchar(255)
	, @Status varchar(10)
	, @ModifiedDate datetime
	, @ModifiedBy int
	, @ErrorCode varchar(50) OUTPUT
	, @ErrorMsg varchar(50) OUTPUT
	)
AS
/* SET NOCOUNT ON */

BEGIN
	UPDATE tbUser
	SET
		Password = @Password
		, DisplayName = @DisplayName
		, [Position] = @Position
		, Status = @Status
		, ModifiedDate = @ModifiedDate
		, ModifiedBy = @ModifiedBy
	WHERE UserID = @UserID

		
	IF @@ERROR <> 0
		BEGIN
			SELECT @ErrorCode = @@ERROR	
			SELECT CAST(@ErrorCode AS INT)
			RETURN
		END
	
	SELECT @ErrorCode = 0
	SELECT @ErrorMsg = ''''
	
	SELECT CAST(@ErrorCode AS INT)
	RETURN
	END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateTicketUnused]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UpdateTicketUnused]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[UpdateTicketUnused]
	
	(
	@PKID int output,
	@SerialNo varchar(50),
	@Reason nvarchar(500),
	@ModifiedBy int,
	@ModifiedDate	 datetime,
	@ErrorCode varchar(50) output,
	@ErrorMsg varchar(50) output
	)
	AS
BEGIN
	/* SET NOCOUNT ON */
	UPDATE tbTicketUnused
	SET
		SerialNo = @SerialNo
		, Reason = @Reason
		, ModifiedBy = @ModifiedBy
		, ModifiedDate = @ModifiedDate
	WHERE PKID = @PKID
	
	/*
	UPDATE tbTicket
	SET
		TicketStatus = ''PRINTED''
	WHERE PKID = @SerialNo
	*/

		INSERT INTO tbTicketLog(CounterID,TicketID,TransactionID,CreatedDate)
	VALUES(0,@SerialNo,NEWID(),DateAdd(minute,90,GetUTCDate()))

	SET @PKID = @@IDENTITY
		
	IF @@ERROR <> 0
		BEGIN
			SELECT @ErrorCode = @@ERROR	
			SELECT CAST(@ErrorCode AS INT)
			RETURN
		END
	
	SELECT @ErrorCode = 0
	SELECT @ErrorMsg = ''''
	
	SELECT CAST(@ErrorCode AS INT)

	RETURN
	END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateTicketStatus]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UpdateTicketStatus]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[UpdateTicketStatus]
	(
	@PKID int,
	@TicketStatus varchar(50),
	@ModifiedBy int,
	@ModifiedDate datetime,
	@ErrorCode varchar(50) output,
	@ErrorMsg varchar(50) output
	)
	
AS
BEGIN
/* SET NOCOUNT ON */
	UPDATE tbTicket
	SET 
	TicketStatus = @TicketStatus
	, ModifiedBy = @ModifiedBy
	, ModifiedDate = @ModifiedDate
	WHERE PKID = @PKID

	SET @PKID = @@IDENTITY
		
	IF @@ERROR <> 0
		BEGIN
			SELECT @ErrorCode = @@ERROR	
			SELECT CAST(@ErrorCode AS INT)
			RETURN
		END
	
	SELECT @ErrorCode = 0
	SELECT @ErrorMsg = ''''
	
	SELECT CAST(@ErrorCode AS INT)
	RETURN
	END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateTicketSoldInfo]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UpdateTicketSoldInfo]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[UpdateTicketSoldInfo]
	
	(
	@PKID int,
	@TicketStatus varchar(50),
	@SoldDate datetime,
	@ZoneID int,
	@ErrorCode varchar(50) output,
	@ErrorMsg varchar(50) output
	)
	
AS
BEGIN
/* SET NOCOUNT ON */
	UPDATE tbTicket
	SET 
	TicketStatus = @TicketStatus
	, SoldDate = @SoldDate
	, SoldZoneID = @ZoneID
	WHERE PKID = @PKID

SET @PKID = @@IDENTITY
		
	IF @@ERROR <> 0
		BEGIN
			SELECT @ErrorCode = @@ERROR	
			SELECT CAST(@ErrorCode AS INT)
			RETURN
		END
	
	SELECT @ErrorCode = 0
	SELECT @ErrorMsg = ''''
	
	SELECT CAST(@ErrorCode AS INT)
	RETURN
	END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateTicket]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UpdateTicket]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[UpdateTicket]
	(
	@PKID int OUTPUT
	, @Price decimal
	, @TicketStatus varchar(50)
	, @AllowedUsage int
	, @AlreadyUsed int
	, @AllowedDays int
	, @ExpiryDate datetime
	, @ModifiedDate datetime
	, @ModifiedBy int
	, @CreatedDate datetime
	, @CreatedBy int
	, @ErrorCode varchar(50) OUTPUT
	, @ErrorMsg varchar(50) output
	)
AS
/* SET NOCOUNT ON */
	BEGIN
	UPDATE TbTicket
	SET
		Price = @Price
		, TicketStatus = @TicketStatus
		, AllowedUsage = @AllowedUsage
		, AlreadyUsed = @AlreadyUsed
		, AllowedDays = @AllowedDays
		, ExpiryDate = @ExpiryDate
		, CreatedDate = @CreatedDate
		, CreatedBy = @CreatedBy
		, ModifiedDate = @ModifiedDate
		, ModifiedBy = @ModifiedBy
	WHERE PKID = @PKID

SET @PKID = @@IDENTITY
		
	IF @@ERROR <> 0
		BEGIN
			SELECT @ErrorCode = @@ERROR	
			SELECT CAST(@ErrorCode AS INT)
			RETURN
		END
	
	SELECT @ErrorCode = 0
	SELECT @ErrorMsg = ''''
	
	SELECT CAST(@ErrorCode AS INT)
	RETURN
	END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateLastUploadedDateTimeAtClientMachine]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UpdateLastUploadedDateTimeAtClientMachine]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[UpdateLastUploadedDateTimeAtClientMachine]
AS
BEGIN
	/* SET NOCOUNT ON */
	UPDATE tbClientUploadDownloadLog
	SET LastUploadedDateTime = DateAdd(minute,90,GetUTCDate())
	SELECT @@RowCount
	RETURN
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateLastUploadedDateTime]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UpdateLastUploadedDateTime]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[UpdateLastUploadedDateTime]
AS
BEGIN
	/* SET NOCOUNT ON */
	UPDATE tbClientUploadDownloadLog
	SET LastUploadedDateTime = DateAdd(minute,90,GetUTCDate())
	SELECT @@RowCount
	RETURN
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateLastDownloadedDateTimeAtClientMachine]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UpdateLastDownloadedDateTimeAtClientMachine]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[UpdateLastDownloadedDateTimeAtClientMachine]
AS
BEGIN
	/* SET NOCOUNT ON */
	UPDATE tbClientUploadDownloadLog
	SET LastDownloadedDateTime = DateAdd(minute,90,GetUTCDate())
	SELECT @@RowCount
	RETURN
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateLastDownloadedDateTime]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UpdateLastDownloadedDateTime]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[UpdateLastDownloadedDateTime]
(
	@CounterID INT
)	
AS
BEGIN
	/* SET NOCOUNT ON */
	UPDATE tbDownloadLog
	SET LastDownloadedDateTime = DateAdd(minute,90,GetUTCDate())
	WHERE CounterID = @CounterID

	SELECT @@RowCount

	RETURN
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateCounter]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UpdateCounter]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[UpdateCounter]
	
	(
	@PKID int output,
	@CounterID int,
	@ZoneID int,
	@ErrorCode varchar(50) output,
	@ErrorMsg varchar(50) output
	)
	
AS
BEGIN
/* SET NOCOUNT ON */
	UPDATE tbCounter
	SET 
	CounterID = @CounterID
	, ZoneID = @ZoneID
	WHERE PKID = @PKID

SET @PKID = @@IDENTITY
		
	IF @@ERROR <> 0
		BEGIN
			SELECT @ErrorCode = @@ERROR	
			SELECT CAST(@ErrorCode AS INT)
			RETURN
		END
	
	SELECT @ErrorCode = 0
	SELECT @ErrorMsg = ''''
	
	SELECT CAST(@ErrorCode AS INT)
	RETURN
	END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[TicketUsage]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TicketUsage]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[TicketUsage]
(
	@PKID int OUTPUT
	, @TicketID int
	, @ZoneID int
	, @DateUsed datetime
	, @ErrorCode int OUTPUT
	)
AS
/* SET NOCOUNT ON */
	BEGIN
	DECLARE @TicketPKID int
	SET @TicketPKID = (SELECT PKID FROM TbTicket WHERE PKID = @PKID)
	DECLARE @ZonePKID int
	SET @ZonePKID = (SELECT PKID FROM tbZone WHERE PKID = @PKID)
	
	INSERT INTO TBTicketUsage(TicketID,ZoneID,DateUsed)
	VALUES (@TicketID, @ZoneID, @DateUsed)

		SELECT @ErrorCode = @@Error

	SET @PKID = @@IDENTITY
		
	IF @ErrorCode = 0
		SELECT @ErrorCode = @@Error 
	ELSE
		SELECT @ErrorCode
	
	SELECT @ErrorCode
	
	RETURN
	END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SelectClientUploadDownloadLog]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectClientUploadDownloadLog]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SelectClientUploadDownloadLog]
(
	@ErrorCode varchar(50) OUTPUT,
	@ErrorMsg varchar(50) OUTPUT
)
AS
BEGIN
	/* SET NOCOUNT ON */

	SELECT @ErrorCode = 0
	SELECT @ErrorMsg = ''''
	
	SELECT * FROM tbClientUploadDownloadLog

	SELECT @ErrorCode =  ''0''
	SELECT @ErrorMsg = ''''
		
	SELECT CAST(@ErrorCode AS INT)

	RETURN
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[RetrieveTicketUsageLog]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RetrieveTicketUsageLog]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[RetrieveTicketUsageLog]
(
	@ErrorCode VARCHAR(50) OUTPUT,
	@ErrorMsg VARCHAR(50) OUTPUT
)
AS
BEGIN
	SELECT @ErrorCode = 0
	SELECT @ErrorMsg = ''''
	/* SET NOCOUNT ON */
	-- if this is the first time checking, insert a very old date to be able to download all data
	IF NOT EXISTS(SELECT LastUploadedDateTime FROM tbClientUploadDownloadLog)
	BEGIN
		INSERT INTO tbClientUploadDownloadLog(LastUploadedDateTime,LastDownloadedDateTime)
		SELECT ''1/1/2012'',''1/1/2012''
	END
	
	IF @@ERROR <> 0
	BEGIN
		SELECT @ErrorCode = @@ERROR	
		SELECT CAST(@ErrorCode AS INT)
		RETURN
	END

	-- check activation log
	SELECT * FROM tbTicketUsageLog WHERE DateUsed > (SELECT LastUploadedDateTime FROM tbClientUploadDownloadLog)
	
	IF @@ERROR <> 0
	BEGIN
		SELECT @ErrorCode = @@ERROR	
		SELECT CAST(@ErrorCode AS INT)
		RETURN
	END
	
	SELECT @ErrorCode = 0
	SELECT @ErrorMsg = ''''	
	
	SELECT CAST(@ErrorCode AS INT)

	RETURN
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[RetrieveTicketActivationLog]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RetrieveTicketActivationLog]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[RetrieveTicketActivationLog]
(
	@ErrorCode VARCHAR(50) OUTPUT,
	@ErrorMsg VARCHAR(50) OUTPUT
)
AS
BEGIN
	SELECT @ErrorCode = 0
	SELECT @ErrorMsg = ''''
	/* SET NOCOUNT ON */
	-- if this is the first time checking, insert a very old date to be able to download all data
	IF NOT EXISTS(SELECT LastUploadedDateTime FROM tbClientUploadDownloadLog)
	BEGIN
		INSERT INTO tbClientUploadDownloadLog(LastUploadedDateTime,LastDownloadedDateTime)
		SELECT ''1/1/2012'',''1/1/2012''
	END
	
	IF @@ERROR <> 0
	BEGIN
		SELECT @ErrorCode = @@ERROR	
		SELECT CAST(@ErrorCode AS INT)
		RETURN
	END
	
	-- check activation log
	SELECT * FROM tbTicketActivationLog WHERE ActivatedDate > (SELECT LastUploadedDateTime FROM tbClientUploadDownloadLog)
	
	IF @@ERROR <> 0
	BEGIN
		SELECT @ErrorCode = @@ERROR	
		SELECT CAST(@ErrorCode AS INT)
		RETURN
	END
		
	SELECT @ErrorCode = 0
	SELECT @ErrorMsg = ''''	
	
	SELECT CAST(@ErrorCode AS INT)
	
	RETURN
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[RetrieveDataToUpload]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RetrieveDataToUpload]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[RetrieveDataToUpload]
(
	@NumOfRecords INT,
	@PageIndex INT, -- start from zero
	@ErrorCode VARCHAR(50) OUTPUT,
	@ErrorMsg VARCHAR(50) OUTPUT
)	
AS
BEGIN
	SELECT @ErrorCode = 0
	SELECT @ErrorMsg = ''''
	/* SET NOCOUNT ON */
	SELECT * FROM (
		SELECT ROW_NUMBER() OVER(ORDER BY PKID DESC) AS RowNum, * FROM tbTicket WHERE PKID IN
		(
			SELECT TicketID FROM tbTicketLog WHERE CreatedDate > (SELECT LastUploadedDateTime FROM tbClientUploadDownloadLog)
		)
	) AS Tickets
	WHERE RowNum > (@NumOfRecords * @PageIndex)  AND RowNum <= (@NumOfRecords * @PageIndex) + @NumOfRecords

	IF @@ERROR <> 0
	BEGIN
		SELECT @ErrorCode = @@ERROR	
		SELECT CAST(@ErrorCode AS INT)
		RETURN
	END
		
	SELECT @ErrorCode = 0
	SELECT @ErrorMsg = ''''	
	
	SELECT CAST(@ErrorCode AS INT)
	
	
	RETURN
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[ResetPassword]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ResetPassword]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[ResetPassword]
	
	(
	@UserPKID INT,
	@NewPassword VARCHAR(50),
	@ModifiedBy INT,
	@ModifiedDate DATETIME,
	@ErrorCode INT OUTPUT,
	@ErrorMsg VARCHAR(128) OUTPUT
	)
	
AS
	/* SET NOCOUNT ON */
	UPDATE tbWebUser
	Set Password = @NewPassword,
	ModifiedBy = @ModifiedBy,
	ModifiedDate = @ModifiedDAte
	WHERE PKID = @UserPKID

	SELECT * FROM tbWebUser WHERE PKID = @UserPKID
	RETURN
' 
END
GO
/****** Object:  StoredProcedure [dbo].[InsertZoneGroup]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertZoneGroup]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[InsertZoneGroup]
	(
	@PKID int output,
	@ZoneGroupID varchar(10),
	@ZoneGroupName varchar(50),
	@DaysAllowed INT,
	@EntriesAllowed INT,
	@Price Decimal(9,2),
	@CreatedBy int,
	@CreatedDate datetime,
	@ModifiedBy int,
	@ModifiedDate datetime,
	@ErrorCode varchar(50) OUTPUT,
	@ErrorMsg VARCHAR(50) OUTPUT
	)
	
AS
BEGIN
	/* SET NOCOUNT ON */
	INSERT INTO tbZoneGroup(ZoneGroupID, ZoneGroupName,DaysAllowed,EntriesAllowed,Price, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate)
	VALUES(@ZoneGroupID, @ZoneGroupName, @DaysAllowed,@EntriesAllowed, @Price, @CreatedBy, @CreatedDate, @ModifiedBy, @ModifiedDate)

	SET @PKID = @@IDENTITY
		
	IF @@ERROR <> 0
		BEGIN
			SELECT @ErrorCode = @@ERROR	
			SELECT CAST(@ErrorCode AS INT)
			RETURN
		END
	
	SELECT @ErrorCode = 0
	SELECT @ErrorMsg = ''''
	
	SELECT CAST(@ErrorCode AS INT)
	
	RETURN
	END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[InsertZoneAndZoneGroup]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertZoneAndZoneGroup]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[InsertZoneAndZoneGroup]
	
	(
	@PKID int output,
	@ZoneID varchar(10),
	@ZoneGroupID varchar(10),
	@CreatedBy int,
	@CreatedDate datetime,
	@ModifiedBy int,
	@ModifiedDate datetime,
	@ErrorCode varchar(50) output,
	@ErrorMsg varchar(50) output
	)
	
AS
BEGIN
	/* SET NOCOUNT ON */
	INSERT INTO tbZoneAndZoneGroup(ZoneGroupID, ZoneID, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate)
	VALUES(@ZoneGroupID, @ZoneID, @CreatedBy, @CreatedDate, @ModifiedBy, @ModifiedDate)

	SET @PKID = @@IDENTITY
		
	IF @@ERROR <> 0
		BEGIN
			SELECT @ErrorCode = @@ERROR	
			SELECT CAST(@ErrorCode AS INT)
			RETURN
		END
	
	SELECT @ErrorCode = 0
	SELECT @ErrorMsg = ''''
	
	SELECT CAST(@ErrorCode AS INT)
	RETURN
	END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[InsertZone]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertZone]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[InsertZone]
	
	(
	@PKID int output,
	@ZoneID varchar(10),
	@ZoneGroupID varchar(10),
	@ZoneName varchar(50),
	@Address varchar(300),
	@Phone varchar(50),
	@Incharge varchar(50),
	@CreatedBy int,
	@CreatedDate datetime,
	@ModifiedBy int,
	@ModifiedDate datetime,
	@ErrorCode varchar(50) output,
	@ErrorMsg varchar(50) output
	)
	
AS
BEGIN
	/* SET NOCOUNT ON */
	INSERT INTO tbZone(ZoneID, ZoneName, [Address], Phone, Incharge, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate)
	VALUES(@ZoneID, @ZoneName, @Address, @Phone, @Incharge, @CreatedBy, @CreatedDate, @ModifiedBy, @ModifiedDate)

	INSERT INTO tbZoneAndZoneGroup(ZoneGroupID, ZoneID, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate)
	VALUES(@ZoneGroupID, @ZoneID, @CreatedBy, @CreatedDate, @ModifiedBy, @ModifiedDate)

	SET @PKID = @@IDENTITY
		
	IF @@ERROR <> 0
		BEGIN
			SELECT @ErrorCode = @@ERROR	
			SELECT CAST(@ErrorCode AS INT)
			RETURN
		END
	
	SELECT @ErrorCode = 0
	SELECT @ErrorMsg = ''''
	
	SELECT CAST(@ErrorCode AS INT)
	RETURN
	END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[InsertUserInRole]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertUserInRole]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[InsertUserInRole]
	
	(
	@PKID int output,
	@UserID varchar(50),
	@RoleName varchar(50),
	@CreatedDate datetime,
	@CreatedBy int,
	@ModifiedDate datetime,
	@ModifiedBy int,
	@ErrorCode varchar(50) output,
	@ErrorMsg varchar(50) output
	)
	
AS
/* SET NOCOUNT ON */
	BEGIN

	DECLARE @UserPKID int, @RoleID int
	SET @UserPKID = (SELECT PKID FROM tbUser WHERE UserID = @UserID)
	SET @RoleID = (SELECT PKID FROM tbRole WHERE RoleName = @RoleName)

	INSERT INTO tbUserInRole(UserPKID, RoleID, CreatedDate, CreatedBy, ModifiedDate, ModifiedBy)
	VALUES(@UserPKID, @RoleID, @CreatedDate, @CreatedBy, @ModifiedDate, @ModifiedBy)

SET @PKID = @@IDENTITY
		
	IF @@ERROR <> 0
		BEGIN
			SELECT @ErrorCode = @@ERROR	
			SELECT CAST(@ErrorCode AS INT)
			RETURN
		END
	
	SELECT @ErrorCode = 0
	SELECT @ErrorMsg = ''''
	
	SELECT CAST(@ErrorCode AS INT)
	RETURN
	END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[InsertUserAccessLog]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertUserAccessLog]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[InsertUserAccessLog]
(
	@PKID int OUTPUT
	, @UserID nvarchar(50)
	, @AccessDate datetime
	, @Action varchar(50)
	, @CreatedDate datetime
	, @CreatedBy int
	, @ModifiedDate datetime
	, @ModifiedBy int
	, @ErrorCode varchar(50) OUTPUT
	, @ErrorMsg varchar(50) OUTPUT
	)
AS
	/* SET NOCOUNT ON */
	BEGIN
	DECLARE @UserPKID int
	SET @UserPKID = (SELECT PKID FROM TbUser WHERE UserID = @UserID)

	INSERT INTO TbUserAccessLog(UserPKID, AccessDate, Action, CreatedDate, CreatedBy, ModifiedDate, ModifiedBy)
	VALUES (@UserPKID, @AccessDate, @Action, @CreatedDate, @CreatedBy, @ModifiedDate, @ModifiedBy)

	SET @PKID = @@IDENTITY
		
	IF @@ERROR <> 0
		BEGIN
			SELECT @ErrorCode = @@ERROR	
			SELECT CAST(@ErrorCode AS INT)
			RETURN
		END
	
	SELECT @ErrorCode = 0
	SELECT @ErrorMsg = ''''
	
	SELECT CAST(@ErrorCode AS INT)
	RETURN
	END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[InsertUpdateTicket]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertUpdateTicket]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[InsertUpdateTicket]
	(
	@PKID int
	, @Price decimal(9,2)
	, @TicketStatus varchar(50)
	, @AllowedUsage int
	, @AlreadyUsed int
	, @AllowedDays int
	, @ExpiryDate datetime
	, @TicketData varchar(256)	
	, @CreatedDate datetime
	, @CreatedBy int
	, @ModifiedDate datetime
	, @ModifiedBy int
	, @SoldDate datetime
	, @SoldZoneID int
	, @ErrorCode VARCHAR(50) OUTPUT
	, @ErrorMsg VARCHAR(50) OUTPUT
	)
AS
/* SET NOCOUNT ON */
BEGIN

	SELECT @ErrorCode = 0
	SELECT @ErrorMsg = ''''
	
	-- check existing ticket or new ticket
	IF NOT EXISTS(SELECT PKID FROM tbTicket WHERE PKID = @PKID)
	BEGIN
		SET IDENTITY_INSERT tbTicket ON
		INSERT INTO tbTicket(PKID,Price, TicketStatus, AllowedUsage, AlreadyUsed, AllowedDays, ExpiryDate, TicketData, IsActivated, CreatedDate, CreatedBy, ModifiedDate, ModifiedBy, SoldDate, SoldZoneID)
		VALUES (@PKID,@Price,@TicketStatus, @AllowedUsage, @AlreadyUsed, @AllowedDays, @ExpiryDate, @TicketData, 0, @CreatedDate, @CreatedBy, @ModifiedDate, @ModifiedBy, @SoldDate, @SoldZoneID)
		SET IDENTITY_INSERT tbTicket OFF
	END
	ELSE
	BEGIN
		-- update existing ticket
		UPDATE tbTicket
		SET TicketStatus = @TicketStatus
		, SoldDate = @SoldDate
		, SoldZoneID = @SoldZoneID
		,AlreadyUsed = CASE WHEN AlreadyUsed < @AlreadyUsed THEN @AlreadyUsed ELSE AlreadyUsed END
		,ExpiryDate = CASE WHEN ExpiryDate < @ExpiryDate THEN @ExpiryDate ELSE ExpiryDate END
		WHERE PKID = @PKID
	END
	
	IF @@ERROR <> 0
	BEGIN
		SELECT @ErrorCode = @@ERROR	
		SELECT CAST(@ErrorCode AS INT)
		RETURN
	END

	SET @PKID = @@IDENTITY
	
	SELECT @ErrorCode = 0
	SELECT @ErrorMsg = ''''	
	
	SELECT CAST(@ErrorCode AS INT)
	
	RETURN
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[InsertTransactionLog]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertTransactionLog]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[InsertTransactionLog]
	(
	@PKID int OUTPUT
	, @TransactionType varchar(50)
	, @TransactionDate datetime
	, @Data varchar(512)
	, @ErrorCode varchar(50) OUTPUT
	, @ErrorMsg varchar(50) OUTPUT
	)
AS
	/* SET NOCOUNT ON */
	BEGIN

	INSERT INTO TbTransactionLog(TransactionType, TransactionDate, Data)
	VALUES (@TransactionType, @TransactionDate, @Data)

	SELECT @ErrorCode = @@Error

SET @PKID = @@IDENTITY
		
	IF @@ERROR <> 0
		BEGIN
			SELECT @ErrorCode = @@ERROR	
			SELECT CAST(@ErrorCode AS INT)
			RETURN
		END
	
	SELECT @ErrorCode = 0
	SELECT @ErrorMsg = ''''
	
	SELECT CAST(@ErrorCode AS INT)
	RETURN
	END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[InsertTicketUsageLog]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertTicketUsageLog]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[InsertTicketUsageLog]
(
	@CounterID INT,
	@ZoneID INT,
	@TicketID INT,
	@DateUsed DATETIME,
	@UsageCountBefore INT,
	@TransactionID UNIQUEIDENTIFIER,
	@UsageCountAfter INT,
	@ErrorCode VARCHAR(50) OUTPUT,
	@ErrorMsg VARCHAR(50) OUTPUT
)
	
AS
BEGIN
	/* SET NOCOUNT ON */
	
	SET @ErrorCode = 0
	SET @ErrorMsg = ''''
	

	-- check whether this unique transaction is already inserted or not, if already inserted, do not insert again
	IF EXISTS(SELECT PKID FROM tbTicketUsageLog WHERE TransactionID = @TransactionID AND TicketID = @TicketID AND ZoneID = @ZoneID AND CounterID = @CounterID)
	BEGIN
		-- store proc will exist from this point
		SELECT 0
		RETURN
	END
	
	IF @@ERROR <> 0
	BEGIN
		SELECT @ErrorCode = @@ERROR	
		SELECT CAST(@ErrorCode AS INT)
		RETURN
	END

	UPDATE tbTicket
	SET AlreadyUsed = AlreadyUsed + 1
	WHERE PKID = @TicketID
	
	IF @@ERROR <> 0
	BEGIN
		SELECT @ErrorCode = @@ERROR	
		SELECT CAST(@ErrorCode AS INT)
		RETURN
	END

	-- insert into server log
	INSERT INTO tbTicketUsageLog(CounterID,ZoneID,TicketID,DateUsed,UsageCountBefore,UsageCountAfter,TransactionID)
	VALUES(@CounterID,@ZoneID,@TicketID,@DateUsed,@UsageCountBefore,@UsageCountAfter,@TransactionID)

	IF @@ERROR <> 0
	BEGIN
		SELECT @ErrorCode = @@ERROR	
		SELECT CAST(@ErrorCode AS INT)
		RETURN
	END
	
	SELECT @ErrorCode = ''0''
	SELECT @ErrorMsg = ''''	
	
	SELECT CAST(@ErrorCode AS INT)

	RETURN
	
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[InsertTicketUsage]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertTicketUsage]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[InsertTicketUsage]
(
	@PKID int OUTPUT
	, @TicketID int
	, @ZoneID int
	, @DateUsed datetime
	, @ErrorCode varchar(50) OUTPUT
	, @ErrorMsg varchar(50) OUTPUT
	)
AS
/* SET NOCOUNT ON */
	BEGIN
	DECLARE @TicketPKID int
	SET @TicketPKID = (SELECT PKID FROM TbTicket WHERE PKID = @PKID)
	DECLARE @ZonePKID int
	SET @ZonePKID = (SELECT PKID FROM tbZone WHERE PKID = @PKID)
	
	INSERT INTO TBTicketUsage(TicketID,ZoneID,DateUsed)
	VALUES (@TicketID, @ZoneID, @DateUsed)

	SET @PKID = @@IDENTITY
		
	IF @@ERROR <> 0
		BEGIN
			SELECT @ErrorCode = @@ERROR	
			SELECT CAST(@ErrorCode AS INT)
			RETURN
		END
	
	SELECT @ErrorCode = 0
	SELECT @ErrorMsg = ''''
	
	SELECT CAST(@ErrorCode AS INT)
	RETURN
	END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[InsertTicketUnused]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertTicketUnused]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[InsertTicketUnused]
	
	(
	@PKID int output,
	@SerialNo varchar(50),
	@Reason nvarchar(500),
	@CreatedBy	int,
	@CreatedDate	datetime,
	@ModifiedBy int,
	@ModifiedDate	 datetime,
	@ErrorCode varchar(50) output,
	@ErrorMsg varchar(50) output
	)
	AS
BEGIN
	/* SET NOCOUNT ON */
	INSERT INTO tbTicketUnused(SerialNo, Reason, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate)
	VALUES(@SerialNo, @Reason, @CreatedBy, @CreatedDate, @ModifiedBy, @ModifiedDate)

	UPDATE tbTicket
	SET
		TicketStatus = ''UNUSED''
	WHERE PKID = @SerialNo

		INSERT INTO tbTicketLog(CounterID,TicketID,TransactionID,CreatedDate)
	VALUES(0,@SerialNo,NEWID(),DateAdd(minute,90,GetUTCDate()))

	SET @PKID = @@IDENTITY
		
	IF @@ERROR <> 0
		BEGIN
			SELECT @ErrorCode = @@ERROR	
			SELECT CAST(@ErrorCode AS INT)
			RETURN
		END
	
	SELECT @ErrorCode = 0
	SELECT @ErrorMsg = ''''
	
	SELECT CAST(@ErrorCode AS INT)

	RETURN
	END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[InsertTicketInZone]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertTicketInZone]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[InsertTicketInZone]
	(
	@PKID int output,
	@TicketID varchar(50),
	@ZoneGroupID varchar(10),
	@CreatedBy int,
	@CreatedDate datetime,
	@ModifiedBy int,
	@ModifiedDate datetime,
	@ErrorCode VARCHAR(50) OUTPUT,
	@ErrorMsg VARCHAR(50) OUTPUT
)
AS
BEGIN
	
	SET @ErrorCode = 0
	SET @ErrorMsg = ''''
	/* SET NOCOUNT ON */
	INSERT INTO tbTicketInZone(TicketID, ZoneGroupID, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate)
	VALUES(@TicketID, @ZoneGroupID, @CreatedBy, @CreatedDate, @ModifiedBy, @ModifiedDate)

SET @PKID = @@IDENTITY
		
	IF @@ERROR <> 0
		BEGIN
			SELECT @ErrorCode = @@ERROR	
			SELECT CAST(@ErrorCode AS INT)
			RETURN
		END
	
	SELECT @ErrorCode = 0
	SELECT @ErrorMsg = ''''
	
	SELECT CAST(@ErrorCode AS INT)
	RETURN
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[InsertTicketActivationLog]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertTicketActivationLog]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[InsertTicketActivationLog]
(
	@CounterID INT,
	@ZoneID INT,
	@TicketID INT,
	@TransactionID UNIQUEIDENTIFIER,
	@ActivatedDate DATETIME,
	@ErrorCode VARCHAR(50) OUTPUT,
	@ErrorMsg VARCHAR(50) OUTPUT
)
	
AS
BEGIN
	/* SET NOCOUNT ON */
	
	SET @ErrorCode = 0
	SET @ErrorMsg = ''''
	
	-- check whether this unique transaction is already inserted or not, if already inserted, do not insert again
	IF EXISTS(SELECT PKID FROM tbTicketActivationLog WHERE TransactionID = @TransactionID AND TicketID = @TicketID AND ZoneID = @ZoneID AND CounterID = @CounterID)
	BEGIN
		-- store proc will exist from this point
		SELECT 0
		RETURN
	END
	
	IF @@ERROR <> 0
	BEGIN
		SELECT @ErrorCode = @@ERROR	
		SELECT CAST(@ErrorCode AS INT)
		RETURN
	END

	-- insert into server log
	INSERT INTO tbTicketActivationLog(CounterID,ZoneID,TicketID,TransactionID,ActivatedDate)
	VALUES(@CounterID,@ZoneID,@TicketID,@TransactionID,@ActivatedDate)
	
	IF @@ERROR <> 0
	BEGIN
		SELECT @ErrorCode = @@ERROR	
		SELECT CAST(@ErrorCode AS INT)
		RETURN
	END

	-- activate the ticket if not activated yet
	UPDATE tbTicket
	SET IsActivated = 1
	,ActivatedDate = @ActivatedDate
	,ActivatedBy = 1
	,TicketStatus = ''ACTIVATED''
	WHERE PKID = @TicketID AND IsActivated = 0
	
	IF @@ERROR <> 0
	BEGIN
		SELECT @ErrorCode = @@ERROR	
		SELECT CAST(@ErrorCode AS INT)
		RETURN
	END

	SELECT @ErrorCode = 0
	SELECT @ErrorMsg = ''''	
	
	SELECT CAST(@ErrorCode AS INT)

	RETURN
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[InsertNewWebUser]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertNewWebUser]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[InsertNewWebUser]
	(
	@PKID int OUTPUT
	, @UserID varchar(50)
	, @Password varchar(50)
	, @DisplayName varchar(50)
	, @Email varchar(50)
	, @Status varchar(10)
	, @CreatedDate datetime
	, @CreatedBy int
	, @ModifiedDate datetime
	, @ModifiedBy int
	, @ErrorCode varchar(50) OUTPUT
	, @ErrorMsg varchar(50) OUTPUT
	)
AS
	/* SET NOCOUNT ON */
	BEGIN

	INSERT INTO tbWebUser(UserID, Password, DisplayName, Email,IsAdmin, Status, CreatedDate, CreatedBy, ModifiedDate, ModifiedBy)
	VALUES (@UserID, @Password, @DisplayName, @Email,0, @Status, @CreatedDate, @CreatedBy, @ModifiedDate, @ModifiedBy)

SET @PKID = @@IDENTITY
		
	IF @@ERROR <> 0
		BEGIN
			SELECT @ErrorCode = @@ERROR	
			SELECT CAST(@ErrorCode AS INT)
			RETURN
		END
	
	SELECT @ErrorCode = 0
	SELECT @ErrorMsg = ''''
	
	SELECT CAST(@ErrorCode AS INT)
	RETURN
	END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[InsertNewUser]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertNewUser]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[InsertNewUser]
	(
	@PKID int OUTPUT
	, @UserID varchar(20)
	, @Password varchar(50)
	, @DisplayName varchar(50)
	, @Position varchar(255)
	, @Status varchar(10)
	, @CreatedDate datetime
	, @CreatedBy int
	, @ModifiedDate datetime
	, @ModifiedBy int
	, @ErrorCode varchar(50) OUTPUT
	, @ErrorMsg varchar(50) OUTPUT
	)
AS
/* SET NOCOUNT ON */
	BEGIN

	INSERT INTO TbUser(UserID, Password, DisplayName, [Position], Status, CreatedDate, CreatedBy, ModifiedDate, ModifiedBy)
	VALUES (@UserID, @Password, @DisplayName, @Position, @Status, @CreatedDate, @CreatedBy, @ModifiedDate, @ModifiedBy)

	SET @PKID = @@IDENTITY
		
	IF @@ERROR <> 0
		BEGIN
			SELECT @ErrorCode = @@ERROR	
			SELECT CAST(@ErrorCode AS INT)
			RETURN
		END
	
	SELECT @ErrorCode = 0
	SELECT @ErrorMsg = ''''
	
	SELECT CAST(@ErrorCode AS INT)
	
	RETURN
	END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[InsertNewTicket]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertNewTicket]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[InsertNewTicket]
	(
	@PKID int
	,@ZoneGroupID varchar(10)
	, @Price decimal(9,2)
	, @TicketStatus varchar(50)
	, @AllowedUsage int
	, @AlreadyUsed int
	, @AllowedDays int
	, @ExpiryDate datetime
	, @TicketData varchar(256)
	, @CreatedDate datetime
	, @CreatedBy int
	, @ModifiedDate datetime
	, @ModifiedBy int
	, @ErrorCode VARCHAR(50) OUTPUT
	, @ErrorMsg VARCHAR(50) OUTPUT
	)
AS
BEGIN
/* SET NOCOUNT ON */

	SELECT @ErrorCode = 0
	SELECT @ErrorMsg = ''''
	
	SET IDENTITY_INSERT tbTicket ON
	INSERT INTO tbTicket(PKID, Price, TicketStatus, AllowedUsage, AlreadyUsed, AllowedDays, ExpiryDate, TicketData, IsActivated, CreatedDate, CreatedBy, ModifiedDate, ModifiedBy)
	VALUES (@PKID, @Price,@TicketStatus, @AllowedUsage, @AlreadyUsed, @AllowedDays, @ExpiryDate, @TicketData, 0, @CreatedDate, @CreatedBy, @ModifiedDate, @ModifiedBy)
	SET IDENTITY_INSERT tbTicket OFF

	IF @@ERROR <> 0
	BEGIN
		SELECT @ErrorCode = @@ERROR	
		SELECT CAST(@ErrorCode AS INT)
		RETURN
	END
	
	INSERT INTO tbTicketInZone(TicketID, ZoneGroupID, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate)
	VALUES (@PKID, @ZoneGroupID, @CreatedBy, @CreatedDate, @ModifiedBy, @ModifiedDate)
	
	IF @@ERROR <> 0
	BEGIN
		SELECT @ErrorCode = @@ERROR	
		SELECT CAST(@ErrorCode AS INT)
		RETURN
	END
	
	-- use counter ID "0" for Ticket Admin''s ticket creation
	-- THIS LOG IS SO IMPORTANT BECAUSE THIS LOG ENTRY WILL BE USED BY SYNC FRAMEWORK
	INSERT INTO tbTicketLog(CounterID,TicketID,TransactionID,CreatedDate)
	VALUES(0,@PKID,NEWID(),DateAdd(minute,90,GetUTCDate()))
	
	IF @@ERROR <> 0
	BEGIN
		SELECT @ErrorCode = @@ERROR	
		SELECT CAST(@ErrorCode AS INT)
		RETURN
	END
	
	SELECT @ErrorCode = 0
	SELECT @ErrorMsg = ''''
	
	SELECT CAST(@ErrorCode AS INT)
	
	RETURN
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[InsertExceptionLog]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertExceptionLog]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[InsertExceptionLog]
	(
	@PKID int OUTPUT
	, @ErrorMessage varchar(255)
	, @StackTrace varchar(512)
	, @CreatedDate datetime
	, @ErrorCode varchar(50) OUTPUT
	,	@ErrorMsg varchar(50) OUTPUT
	)
AS
	/* SET NOCOUNT ON */
	BEGIN

	INSERT INTO TbExceptionLog(ErrorMessage, StackTrace, CreatedDate)
	VALUES (@ErrorMessage, @StackTrace, @CreatedDate)

SET @PKID = @@IDENTITY
		
	IF @@ERROR <> 0
		BEGIN
			SELECT @ErrorCode = @@ERROR	
			SELECT CAST(@ErrorCode AS INT)
			RETURN
		END
	
	SELECT @ErrorCode = 0
	SELECT @ErrorMsg = ''''
	
	SELECT CAST(@ErrorCode AS INT)
	RETURN
	END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[InsertCounter]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertCounter]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[InsertCounter]
	
	(
	@PKID int output,
	@CounterID int,
	@ZoneID int,
	@CreatedBy int,
	@CreatedDate datetime,
	@ErrorCode varchar(50) output,
	@ErrorMsg varchar(50) output
	)
	AS
BEGIN
	/* SET NOCOUNT ON */
	INSERT INTO tbCounter(CounterID, ZoneID, CreatedBy,CreatedDate)
	VALUES(@CounterID, @ZoneID, @CreatedBy, @CreatedDate)

	SET @PKID = @@IDENTITY
		
	IF @@ERROR <> 0
		BEGIN
			SELECT @ErrorCode = @@ERROR	
			SELECT CAST(@ErrorCode AS INT)
			RETURN
		END
	
	SELECT @ErrorCode = 0
	SELECT @ErrorMsg = ''''
	
	SELECT CAST(@ErrorCode AS INT)

	RETURN
	END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[InsertApprovedCode]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertApprovedCode]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[InsertApprovedCode]
	
	(
	@ApprovedCode varchar(50),
	@ErrorCode varchar(50) output,
	@ErrorMsg varchar(50) output
	)
	AS
BEGIN
	/* SET NOCOUNT ON */
	INSERT INTO tbPrintingApproved(ApprovedCode)
	VALUES(@ApprovedCode)

		
	IF @@ERROR <> 0
		BEGIN
			SELECT @ErrorCode = @@ERROR	
			SELECT CAST(@ErrorCode AS INT)
			RETURN
		END
	
	SELECT @ErrorCode = 0
	SELECT @ErrorMsg = ''''
	
	SELECT CAST(@ErrorCode AS INT)

	RETURN
	END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[GetTicketInfo]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetTicketInfo]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[GetTicketInfo]
(
	@ticketSerialNum INT,
	@ErrorCode VARCHAR(50) OUTPUT,
	@ErrorMsg VARCHAR(50) OUTPUT
)
AS
BEGIN

	SELECT @ErrorCode = 0
	SELECT @ErrorMsg = ''''
	
	-- select ticket
	SELECT *
	FROM tbTicket
	WHERE PKID = @ticketSerialNum
	-- 
	IF @@ERROR <> 0
	BEGIN
		SELECT @ErrorCode = @@ERROR	
		SELECT CAST(@ErrorCode AS INT)
		RETURN
	END
	
	SELECT @ErrorCode = 0
	SELECT @ErrorMsg = ''''	
	
	SELECT CAST(@ErrorCode AS INT)
	
	/* SET NOCOUNT ON */
	RETURN
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[ExportFromServer]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ExportFromServer]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[ExportFromServer]
(
	@CounterID INT,
	@ErrorCode VARCHAR(50) OUTPUT,
	@ErrorMsg VARCHAR(50) OUTPUT
)	
AS
BEGIN
	SELECT @ErrorCode = 0
	SELECT @ErrorMsg = ''''
	/* SET NOCOUNT ON */
	
	IF NOT EXISTS(SELECT LastDownloadedDateTime FROM tbDownloadLog WHERE CounterID = @CounterID)
	BEGIN
		INSERT INTO tbDownloadLog(CounterID,LastDownloadedDateTime)
		SELECT @CounterID,''1/1/2012''
	END

	SELECT * FROM (
		SELECT ROW_NUMBER() OVER(ORDER BY PKID DESC) AS RowNum, * FROM tbTicket WHERE PKID IN
		(
			SELECT TLG.TicketID FROM tbTicketLog AS TLG
			INNER JOIN tbTicketInZone AS TIZ ON TLG.TicketID = TIZ.TicketID
			WHERE TLG.CreatedDate > (SELECT LastDownloadedDateTime FROM tbDownloadLog WHERE CounterID = @CounterID)
			AND TLG.CounterID <> @CounterID
			AND TIZ.ZoneGroupID = CAST(SUBSTRING(CAST(@CounterID AS VARCHAR(50)),1,3) AS INT)
			
			UNION
			
			SELECT TicketID FROM tbTicketActivationLog AS TAL
			WHERE TAL.ActivatedDate > (SELECT LastDownloadedDateTime FROM tbDownloadLog WHERE CounterID = @CounterID)
			AND CounterID <> @CounterID
			
			UNION
			
			SELECT TicketID FROM tbTicketUsageLog
			WHERE CreatedDate > (SELECT LastDownloadedDateTime FROM tbDownloadLog WHERE CounterID = @CounterID)
			AND CounterID <> @CounterID
		)
	) AS Tickets
	--WHERE RowNum > (@NumOfRecords * @PageIndex)  AND RowNum <= (@NumOfRecords * @PageIndex) + @NumOfRecords

	IF @@ERROR <> 0
	BEGIN
		SELECT @ErrorCode = @@ERROR	
		SELECT CAST(@ErrorCode AS INT)
		RETURN
	END
	
	SELECT @ErrorCode = 0
	SELECT @ErrorMsg = ''''	
	
	SELECT CAST(@ErrorCode AS INT)
	
	RETURN
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[ExportData]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ExportData]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[ExportData]
(
	@CounterID INT,
	@ErrorCode VARCHAR(50) OUTPUT,
	@ErrorMsg VARCHAR(50) OUTPUT
)	
AS
BEGIN
	SELECT @ErrorCode = 0
	SELECT @ErrorMsg = ''''
	/* SET NOCOUNT ON */
	
	SELECT * FROM (
		SELECT ROW_NUMBER() OVER(ORDER BY PKID DESC) AS RowNum, * FROM tbTicket WHERE PKID IN
		(
			SELECT TLG.TicketID FROM tbTicketLog AS TLG
			INNER JOIN tbTicketInZone AS TIZ ON TLG.TicketID = TIZ.TicketID
			WHERE TLG.CreatedDate > (SELECT LastDownloadedDateTime FROM tbDownloadLog WHERE CounterID = @CounterID)
			AND TLG.CounterID <> @CounterID
			AND TIZ.ZoneGroupID = CAST(SUBSTRING(CAST(@CounterID AS VARCHAR(50)),1,3) AS INT)
			
			UNION
			
			SELECT TicketID FROM tbTicketActivationLog AS TAL
			WHERE TAL.ActivatedDate > (SELECT LastDownloadedDateTime FROM tbDownloadLog WHERE CounterID = @CounterID)
			AND CounterID <> @CounterID
			
			UNION
			
			SELECT TicketID FROM tbTicketUsageLog
			WHERE CreatedDate > (SELECT LastDownloadedDateTime FROM tbDownloadLog WHERE CounterID = @CounterID)
			AND CounterID <> @CounterID
		)
	) AS Tickets
	--WHERE RowNum > (@NumOfRecords * @PageIndex)  AND RowNum <= (@NumOfRecords * @PageIndex) + @NumOfRecords

	IF @@ERROR <> 0
	BEGIN
		SELECT @ErrorCode = @@ERROR	
		SELECT CAST(@ErrorCode AS INT)
		RETURN
	END
	
	SELECT @ErrorCode = 0
	SELECT @ErrorMsg = ''''	
	
	SELECT CAST(@ErrorCode AS INT)
	
	RETURN
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[DownloadData]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DownloadData]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[DownloadData]
(
	@CounterID INT,
	@NumOfRecords INT,
	@PageIndex INT, -- start from zero
	@ErrorCode VARCHAR(50) OUTPUT,
	@ErrorMsg VARCHAR(50) OUTPUT
)	
AS
BEGIN
	SELECT @ErrorCode = 0
	SELECT @ErrorMsg = ''''
	/* SET NOCOUNT ON */
	
	SELECT * FROM (
		SELECT ROW_NUMBER() OVER(ORDER BY PKID DESC) AS RowNum, * FROM tbTicket WHERE PKID IN
		(
			SELECT TLG.TicketID FROM tbTicketLog AS TLG
			INNER JOIN tbTicketInZone AS TIZ ON TLG.TicketID = TIZ.TicketID
			WHERE TLG.CreatedDate > (SELECT LastDownloadedDateTime FROM tbDownloadLog WHERE CounterID = @CounterID)
			AND TLG.CounterID <> @CounterID
			AND TIZ.ZoneGroupID = CAST(SUBSTRING(CAST(@CounterID AS VARCHAR(50)),1,3) AS INT)
			
			UNION
			
			SELECT TicketID FROM tbTicketActivationLog AS TAL
			WHERE TAL.ActivatedDate > (SELECT LastDownloadedDateTime FROM tbDownloadLog WHERE CounterID = @CounterID)
			AND CounterID <> @CounterID
			
			UNION
			
			SELECT TicketID FROM tbTicketUsageLog
			WHERE CreatedDate > (SELECT LastDownloadedDateTime FROM tbDownloadLog WHERE CounterID = @CounterID)
			AND CounterID <> @CounterID
		)
	) AS Tickets
	WHERE RowNum > (@NumOfRecords * @PageIndex)  AND RowNum <= (@NumOfRecords * @PageIndex) + @NumOfRecords

	IF @@ERROR <> 0
	BEGIN
		SELECT @ErrorCode = @@ERROR	
		SELECT CAST(@ErrorCode AS INT)
		RETURN
	END
	
	SELECT @ErrorCode = 0
	SELECT @ErrorMsg = ''''	
	
	SELECT CAST(@ErrorCode AS INT)
	
	RETURN
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteZoneGroup]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DeleteZoneGroup]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[DeleteZoneGroup]
	
	(
	@ZoneGroupID varchar(10)
	,@ErrorCode varchar(50) output
	,@ErrorMsg varchar(50) output
	)
	
AS
BEGIN
	/* SET NOCOUNT ON */
	DELETE FROM tbZoneGroup
	WHERE ZoneGroupID =@ZoneGroupID
		
	IF @@ERROR <> 0
		BEGIN
			SELECT @ErrorCode = @@ERROR	
			SELECT CAST(@ErrorCode AS INT)
			RETURN
		END
	
	SELECT @ErrorCode = 0
	SELECT @ErrorMsg = ''''
	
	SELECT CAST(@ErrorCode AS INT)
	RETURN
	END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteZone]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DeleteZone]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[DeleteZone]
	
	(
	@ZoneID varchar(10)
	,@ErrorCode varchar(50) output
	,@ErrorMsg varchar(50) output
	)
	
AS
BEGIN
	/* SET NOCOUNT ON */
	DELETE FROM tbZone
	WHERE ZoneID =@ZoneID
		
		DELETE FROM tbZoneAndZoneGroup
		WHERE ZoneID = @ZoneID

	IF @@ERROR <> 0
		BEGIN
			SELECT @ErrorCode = @@ERROR	
			SELECT CAST(@ErrorCode AS INT)
			RETURN
		END
	
	SELECT @ErrorCode = 0
	SELECT @ErrorMsg = ''''
	
	SELECT CAST(@ErrorCode AS INT)
	RETURN
	END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteWebUser]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DeleteWebUser]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[DeleteWebUser]
	
	(
	@UserID varchar(10)
	,@ErrorCode varchar(50) output
	, @ErrorMsg varchar(50) output
	)
	
AS
BEGIN
	/* SET NOCOUNT ON */
	DELETE FROM tbWebUser
	WHERE UserID = @UserID
		
	IF @@ERROR <> 0
		BEGIN
			SELECT @ErrorCode = @@ERROR	
			SELECT CAST(@ErrorCode AS INT)
			RETURN
		END
	
	SELECT @ErrorCode = 0
	SELECT @ErrorMsg = ''''
	
	SELECT CAST(@ErrorCode AS INT)
	RETURN
	END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteUserInRole]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DeleteUserInRole]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[DeleteUserInRole]
	
	(
	@UserID varchar(10)
	,@ErrorCode varchar(50) output
	, @ErrorMsg varchar(50) output
	)
	
AS
BEGIN
DECLARE @UserPKID int
SET @UserPKID = (SELECT PKID FROM tbUser WHERE UserID = @UserID)
	/* SET NOCOUNT ON */
	DELETE FROM tbUserInRole
	WHERE UserPKID = @UserPKID
		
	IF @@ERROR <> 0
		BEGIN
			SELECT @ErrorCode = @@ERROR	
			SELECT CAST(@ErrorCode AS INT)
			RETURN
		END
	
	SELECT @ErrorCode = 0
	SELECT @ErrorMsg = ''''
	
	SELECT CAST(@ErrorCode AS INT)
	RETURN
	END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteUser]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DeleteUser]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[DeleteUser]
	
	(
	@UserID varchar(10)
	,@ErrorCode varchar(50) output
	, @ErrorMsg varchar(50) output
	)
	
AS
BEGIN
	/* SET NOCOUNT ON */
	DELETE FROM tbUser
	WHERE UserID = @UserID

		
	IF @@ERROR <> 0
		BEGIN
			SELECT @ErrorCode = @@ERROR	
			SELECT CAST(@ErrorCode AS INT)
			RETURN
		END
	
	SELECT @ErrorCode = 0
	SELECT @ErrorMsg = ''''
	
	SELECT CAST(@ErrorCode AS INT)
	RETURN
	END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteTicketSettings]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DeleteTicketSettings]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[DeleteTicketSettings]
	(
	@ZoneGroupID varchar(50)
	,@ErrorCode int output
	)
	
AS
BEGIN
	/* SET NOCOUNT ON */
	DELETE FROM tbTicketSettings
	WHERE ZoneGroupID =@ZoneGroupID

		SELECT @ErrorCode = @@Error

	
	IF @ErrorCode = 0
		SELECT @ErrorCode = @@Error 
	ELSE
		SELECT @ErrorCode
	
	SELECT @ErrorCode
	
	RETURN
	END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[DeletePrintingCode]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DeletePrintingCode]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[DeletePrintingCode]
	
	
	
AS
BEGIN
	/* SET NOCOUNT ON */
	DELETE FROM tbPrintingApproved
	

		
	return 
	END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteCounter]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DeleteCounter]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[DeleteCounter]
	
	(
	@CounterID int
	,@ErrorCode varchar(50) output
	,@ErrorMsg varchar(50) output
	)
	
AS
BEGIN
	/* SET NOCOUNT ON */
	DELETE FROM tbCounter
	WHERE CounterID = @CounterID

		
	IF @@ERROR <> 0
		BEGIN
			SELECT @ErrorCode = @@ERROR	
			SELECT CAST(@ErrorCode AS INT)
			RETURN
		END
	
	SELECT @ErrorCode = 0
	SELECT @ErrorMsg = ''''
	
	SELECT CAST(@ErrorCode AS INT)
	RETURN
	END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[CheckServerData]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CheckServerData]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- CheckServerData 100100100
CREATE PROCEDURE [dbo].[CheckServerData]
(
	@CounterID INT,
	@ErrorCode VARCHAR(50) OUTPUT,
	@ErrorMsg VARCHAR(50) OUTPUT
)	
AS
BEGIN
	SELECT @ErrorCode = 0
	SELECT @ErrorMsg = ''''
	/* SET NOCOUNT ON */
	
	-- if this is the first time checking, insert a very old date to be able to download all data
	IF NOT EXISTS(SELECT LastDownloadedDateTime FROM tbDownloadLog WHERE CounterID = @CounterID)
	BEGIN
		INSERT INTO tbDownloadLog(CounterID,LastDownloadedDateTime)
		SELECT @CounterID,''1/1/2012''
	END
	
	IF @@ERROR <> 0
	BEGIN
		SELECT @ErrorCode = @@ERROR	
		SELECT CAST(@ErrorCode AS INT)
		RETURN
	END
	
	SELECT Count(PKID) FROM tbTicket WHERE PKID IN
	(
		SELECT TLG.TicketID FROM tbTicketLog AS TLG
		INNER JOIN tbTicketInZone AS TIZ ON TLG.TicketID = TIZ.TicketID
		WHERE TLG.CreatedDate > (SELECT LastDownloadedDateTime FROM tbDownloadLog WHERE CounterID = @CounterID)
		AND TLG.CounterID <> @CounterID
		AND TIZ.ZoneGroupID = CAST(SUBSTRING(CAST(@CounterID AS VARCHAR(50)),1,3) AS INT)
		
		UNION
		
		SELECT TicketID FROM tbTicketActivationLog AS TAL
		WHERE TAL.ActivatedDate > (SELECT LastDownloadedDateTime FROM tbDownloadLog WHERE CounterID = @CounterID)
		AND CounterID <> @CounterID
		
		UNION
		
		SELECT TicketID FROM tbTicketUsageLog AS TUL
		WHERE TUL.DateUsed > (SELECT LastDownloadedDateTime FROM tbDownloadLog WHERE CounterID = @CounterID)
		AND CounterID <> @CounterID
	)
	
	IF @@ERROR <> 0
	BEGIN
		SELECT @ErrorCode = @@ERROR	
		SELECT CAST(@ErrorCode AS INT)
		RETURN
	END
	
	SELECT @ErrorCode = 0
	SELECT @ErrorMsg = ''''
	
	SELECT CAST(@ErrorCode AS INT)

	RETURN
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[CheckInTicket]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CheckInTicket]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[CheckInTicket]	
(
	@TicketSerialNum INT,
	@CounterID INT,
	@CheckedInBy INT,
	@ZoneID INT,
	@ErrorCode VARCHAR(50) OUTPUT,
	@ErrorMsg VARCHAR(50) OUTPUT
)
AS
BEGIN

	SELECT @ErrorCode = 0
	SELECT @ErrorMsg = ''''
	
	-- update ticket info
	UPDATE tbTicket
	SET AlreadyUsed = AlreadyUsed + 1,
	ModifiedDate = DateAdd(minute,90,GetUTCDate()),
	ModifiedBy = @CheckedInBy
	WHERE PKID = @ticketSerialNum

	-- insert log for sync purpose
	INSERT INTO tbTicketLog(CounterID,TransactionID,TicketID,CreatedDate)
	VALUES(@CounterID,NewID(),@TicketSerialNum,DateAdd(minute,90,GetUTCDate()))

	INSERT INTO tbTicketUsageLog(TicketID,CounterID,ZoneID,UsageCountBefore,UsageCountAfter,DateUsed, TransactionID)
	SELECT PKID,@CounterID,@ZoneID,AlreadyUsed - 1,AlreadyUsed, DateAdd(minute,90,GetUTCDate()), NewID() FROM tbTicket WHERE PKID = @TicketSerialNum

	-- select ticket
	SELECT *
	FROM tbTicket
	WHERE PKID = @ticketSerialNum
	-- 
	SET @ErrorCode = 0
	SET @ErrorMsg = ''Ticket check-in successful''
	
	SELECT CAST(@ErrorCode AS INT)

	/* SET NOCOUNT ON */
	RETURN
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[CheckClientData]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CheckClientData]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[CheckClientData]
(
	@ErrorCode VARCHAR(50) OUTPUT,
	@ErrorMsg VARCHAR(50) OUTPUT
)
AS
BEGIN
	SELECT @ErrorCode = 0
	SELECT @ErrorMsg = ''''
	
	/* SET NOCOUNT ON */
	-- if this is the first time checking, insert a very old date to be able to download all data
	IF NOT EXISTS(SELECT LastUploadedDateTime FROM tbClientUploadDownloadLog)
	BEGIN
		INSERT INTO tbClientUploadDownloadLog(LastUploadedDateTime,LastDownloadedDateTime)
		SELECT ''1/1/2012'',''1/1/2012''
	END
	
	IF @@ERROR <> 0
	BEGIN
		SELECT @ErrorCode = @@ERROR	
		SELECT CAST(@ErrorCode AS INT)
		RETURN
	END

	-- check activation log
	DECLARE @ActivationLog INT
	SET @ActivationLog = (SELECT Count(PKID) FROM tbTicketActivationLog WHERE ActivatedDate > (SELECT LastUploadedDateTime FROM tbClientUploadDownloadLog))

	IF @@ERROR <> 0
	BEGIN
		SELECT @ErrorCode = @@ERROR	
		SELECT CAST(@ErrorCode AS INT)
		RETURN
	END
	
	-- check usage log
	DECLARE @UsageLog INT
	SET @UsageLog = (SELECT Count(PKID) FROM tbTicketUsageLog WHERE DateUsed > (SELECT LastUploadedDateTime FROM tbClientUploadDownloadLog))

	IF @@ERROR <> 0
	BEGIN
		SELECT @ErrorCode = @@ERROR	
		SELECT CAST(@ErrorCode AS INT)
		RETURN
	END
	
	SELECT @ActivationLog + @UsageLog
	
	SELECT @ErrorCode = 0
	SELECT @ErrorMsg = ''''
	
	SELECT CAST(@ErrorCode AS INT)

	RETURN
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[ActivateTicket]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ActivateTicket]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[ActivateTicket]	
(
	@TicketSerialNum INT,
	@CounterID INT,
	@ActivatedBy INT,
	@ZoneID INT,
	@ErrorCode VARCHAR(50) OUTPUT,
	@ErrorMsg VARCHAR(50) OUTPUT
)
AS
BEGIN

	SELECT @ErrorCode = 0
	SELECT @ErrorMsg = ''''
	
	UPDATE tbTicket
	SET IsActivated = 1,
	ActivatedDate = DateAdd(minute,90,GetUTCDate()),
	ActivatedBy = @ActivatedBy,
	TicketStatus = ''ACTIVATED'',
	ModifiedDate = DateAdd(minute,90,GetUTCDate())
	WHERE PKID = @ticketSerialNum
	
	IF @@ERROR <> 0
	BEGIN
		SELECT @ErrorCode = @@ERROR	
		SELECT CAST(@ErrorCode AS INT)
		RETURN
	END

	-- insert log for sync purpose
	INSERT INTO tbTicketLog(CounterID,TransactionID,TicketID,CreatedDate)
	VALUES(@CounterID,NewID(),@TicketSerialNum,DateAdd(minute,90,GetUTCDate()))
	
	IF @@ERROR <> 0
	BEGIN
		SELECT @ErrorCode = @@ERROR	
		SELECT CAST(@ErrorCode AS INT)
		RETURN
	END

	-- insert log for sync purpose
	INSERT INTO tbTicketActivationLog(CounterID,ZoneID,TransactionID,TicketID,ActivatedDate)
	VALUES(@CounterID,@ZoneID,NewID(),@TicketSerialNum,DateAdd(minute,90,GetUTCDate())) 
	
	IF @@ERROR <> 0
	BEGIN
		SELECT @ErrorCode = @@ERROR	
		SELECT CAST(@ErrorCode AS INT)
		RETURN
	END

	SELECT * FROM tbTicket WHERE PKID = @ticketSerialNum
	
	IF @@ERROR <> 0
	BEGIN
		SELECT @ErrorCode = @@ERROR	
		SELECT CAST(@ErrorCode AS INT)
		RETURN
	END
	
	SELECT @ErrorCode = 0
	SELECT @ErrorMsg = ''''
	
	SELECT CAST(@ErrorCode AS INT)

	/* SET NOCOUNT ON */
	RETURN
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[WebUserLogIn]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[WebUserLogIn]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[WebUserLogIn]

	(
	@UserID nvarchar(50)
	, @Password nvarchar(50)
	,@IsAdmin BIT
	)

AS
	/* SET NOCOUNT ON */
	SELECT * FROM tbWebUser
	WHERE UserID = @UserID AND Password = @Password AND IsAdmin = @IsAdmin

	RETURN
' 
END
GO
/****** Object:  View [dbo].[vwZoneSetting]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwZoneSetting]'))
EXEC dbo.sp_executesql @statement = N'
CREATE VIEW [dbo].[vwZoneSetting]
AS
SELECT        dbo.tbZoneAndZoneGroup.PKID, dbo.tbZoneAndZoneGroup.ZoneGroupID, dbo.tbZoneAndZoneGroup.ZoneID, dbo.tbZone.ZoneName, 
                         dbo.tbZoneGroup.ZoneGroupName
FROM            dbo.tbZoneAndZoneGroup INNER JOIN
                         dbo.tbZone ON dbo.tbZoneAndZoneGroup.ZoneID = dbo.tbZone.ZoneID INNER JOIN
                         dbo.tbZoneGroup ON dbo.tbZoneAndZoneGroup.ZoneGroupID = dbo.tbZoneGroup.ZoneGroupID'
GO
/****** Object:  View [dbo].[vwZoneGroup]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwZoneGroup]'))
EXEC dbo.sp_executesql @statement = N'CREATE VIEW [dbo].[vwZoneGroup]
AS
SELECT     PKID, ZoneGroupID, ZoneGroupName, DaysAllowed, EntriesAllowed, Price
FROM         dbo.tbZoneGroup
'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'vwZoneGroup', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tbZoneGroup"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 124
               Right = 207
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwZoneGroup'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'vwZoneGroup', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwZoneGroup'
GO
/****** Object:  View [dbo].[vwZoneAndZoneGroup]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwZoneAndZoneGroup]'))
EXEC dbo.sp_executesql @statement = N'CREATE VIEW [dbo].[vwZoneAndZoneGroup]
AS
SELECT        dbo.tbZone.ZoneID, dbo.tbZone.ZoneName, dbo.tbZoneGroup.ZoneGroupName, dbo.tbZoneGroup.ZoneGroupID, dbo.tbZone.PKID, 
                         dbo.tbZoneAndZoneGroup.PKID AS LinkID, dbo.tbZone.Address, dbo.tbZone.Phone, dbo.tbZone.InCharge
FROM            dbo.tbZone LEFT OUTER JOIN
                         dbo.tbZoneAndZoneGroup ON dbo.tbZone.ZoneID = dbo.tbZoneAndZoneGroup.ZoneID LEFT OUTER JOIN
                         dbo.tbZoneGroup ON dbo.tbZoneAndZoneGroup.ZoneGroupID = dbo.tbZoneGroup.ZoneGroupID'
GO
/****** Object:  View [dbo].[vwZone]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwZone]'))
EXEC dbo.sp_executesql @statement = N'CREATE VIEW [dbo].[vwZone]
AS
SELECT        PKID, ZoneID, ZoneName, Address, InCharge, Phone
FROM            dbo.tbZone'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'vwZone', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tbZone"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 135
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwZone'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'vwZone', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwZone'
GO
/****** Object:  View [dbo].[vwWebUser]    Script Date: 10/24/2012 03:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwWebUser]'))
EXEC dbo.sp_executesql @statement = N'CREATE VIEW [dbo].[vwWebUser]
AS
SELECT        PKID, UserID, Password, DisplayName, Email, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate
FROM            dbo.tbWebUser
'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'vwWebUser', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tbWebUser"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 197
               Right = 211
            End
            DisplayFlags = 280
            TopColumn = 2
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwWebUser'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'vwWebUser', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwWebUser'
GO
/****** Object:  View [dbo].[vwUserInRole]    Script Date: 10/24/2012 03:07:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwUserInRole]'))
EXEC dbo.sp_executesql @statement = N'CREATE VIEW [dbo].[vwUserInRole]
AS
SELECT        dbo.tbUserInRole.PKID, dbo.tbUserInRole.RoleID, dbo.tbRole.RoleName, dbo.tbRole.RoleDescription, dbo.tbUser.Password, dbo.tbUser.DisplayName, 
                         dbo.tbUser.Status, dbo.tbUserInRole.UserPKID, dbo.tbUser.UserID, dbo.tbUser.Position
FROM            dbo.tbUserInRole INNER JOIN
                         dbo.tbRole ON dbo.tbUserInRole.RoleID = dbo.tbRole.PKID INNER JOIN
                         dbo.tbUser ON dbo.tbUserInRole.UserPKID = dbo.tbUser.PKID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'vwUserInRole', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tbUserInRole"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 197
               Right = 219
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwUserInRole'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'vwUserInRole', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwUserInRole'
GO
/****** Object:  View [dbo].[vwUserInfo]    Script Date: 10/24/2012 03:07:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwUserInfo]'))
EXEC dbo.sp_executesql @statement = N'CREATE VIEW [dbo].[vwUserInfo]
AS
SELECT     PKID, UserID, Password, DisplayName, Status, CreatedDate, CreatedBy, ModifiedDate, ModifiedBy, '''' AS CreatedByUserID, '''' AS ModifiedByUserID, NULLIF (CAST('''' AS Datetime), NULL) AS LastLoginDate, '''' AS Role
FROM         dbo.tbUser
'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'vwUserInfo', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tbUser"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 149
               Right = 198
            End
            DisplayFlags = 280
            TopColumn = 5
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwUserInfo'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'vwUserInfo', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwUserInfo'
GO
/****** Object:  View [dbo].[vwUserAccessLog]    Script Date: 10/24/2012 03:07:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwUserAccessLog]'))
EXEC dbo.sp_executesql @statement = N'CREATE VIEW [dbo].[vwUserAccessLog]
AS
SELECT        dbo.tbUserAccessLog.PKID, dbo.tbUserAccessLog.UserPKID, dbo.tbUserAccessLog.AccessDate, dbo.tbUserAccessLog.Action, dbo.tbUser.PKID AS User_PKID, 
                         dbo.tbUser.UserID, dbo.tbUser.DisplayName, dbo.tbUser.Status, dbo.tbUser.CreatedDate, dbo.tbUser.Position
FROM            dbo.tbUserAccessLog INNER JOIN
                         dbo.tbUser ON dbo.tbUserAccessLog.PKID = dbo.tbUser.PKID'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'vwUserAccessLog', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tbUserAccessLog"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 135
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "tbUser"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 135
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 1
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwUserAccessLog'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'vwUserAccessLog', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwUserAccessLog'
GO
/****** Object:  View [dbo].[vwUser]    Script Date: 10/24/2012 03:07:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwUser]'))
EXEC dbo.sp_executesql @statement = N'CREATE VIEW [dbo].[vwUser]
AS
SELECT     PKID, UserID, [Password], DisplayName, [Status], CreatedDate, CreatedBy, ModifiedDate, ModifiedBy, 0 AS RoleID, '''' AS Role, Position
FROM         dbo.tbUser'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'vwUser', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tbUser"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 135
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 10
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwUser'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'vwUser', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwUser'
GO
/****** Object:  View [dbo].[vwTWZoneGroupZoneCounter]    Script Date: 10/24/2012 03:07:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwTWZoneGroupZoneCounter]'))
EXEC dbo.sp_executesql @statement = N'CREATE VIEW [dbo].[vwTWZoneGroupZoneCounter]
AS
SELECT     NULLIF (dbo.tbZoneGroup.ZoneGroupName, '''') AS ZoneGroupName, dbo.tbZoneGroup.ZoneGroupID, NULLIF (dbo.tbZone.ZoneID, 0) AS ZoneID, NULLIF (dbo.tbZone.ZoneName, '''') AS Expr1, NULLIF (dbo.tbCounter.CounterID, 0) AS CounterID
FROM         dbo.tbCounter INNER JOIN
                      dbo.tbZoneGroup ON dbo.tbCounter.PKID = dbo.tbZoneGroup.PKID CROSS JOIN
                      dbo.tbZoneAndZoneGroup CROSS JOIN
                      dbo.tbZone
'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'vwTWZoneGroupZoneCounter', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tbCounter"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 149
               Right = 198
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbZoneGroup"
            Begin Extent = 
               Top = 6
               Left = 236
               Bottom = 149
               Right = 405
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbZoneAndZoneGroup"
            Begin Extent = 
               Top = 6
               Left = 443
               Bottom = 149
               Right = 603
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbZone"
            Begin Extent = 
               Top = 6
               Left = 641
               Bottom = 149
               Right = 801
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwTWZoneGroupZoneCounter'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'vwTWZoneGroupZoneCounter', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwTWZoneGroupZoneCounter'
GO
/****** Object:  View [dbo].[vwTWTicketInfo]    Script Date: 10/24/2012 03:07:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwTWTicketInfo]'))
EXEC dbo.sp_executesql @statement = N'CREATE VIEW [dbo].[vwTWTicketInfo]
AS
SELECT     dbo.tbTicket.PKID, dbo.tbTicket.Price, dbo.tbTicket.TicketStatus, dbo.tbZoneGroup.ZoneGroupName, dbo.tbTicket.CreatedDate, dbo.tbTicket.AllowedUsage, dbo.tbTicket.AllowedDays, dbo.tbTicket.AlreadyUsed, dbo.tbTicket.ModifiedDate, dbo.tbTicket.ActivatedDate, 
                      dbo.tbTicket.ExpiryDate, dbo.tbZoneGroup.ZoneGroupID, NULLIF ('''', '''') AS CreatedBy, NULLIF ('''', '''') AS ModifiedBy, NULLIF ('''', '''') AS ActivatedBy
FROM         dbo.tbTicket INNER JOIN
                      dbo.tbTicketInZone ON dbo.tbTicket.PKID = dbo.tbTicketInZone.TicketID INNER JOIN
                      dbo.tbZoneGroup ON dbo.tbTicketInZone.ZoneGroupID = dbo.tbZoneGroup.ZoneGroupID INNER JOIN
                      dbo.tbUser ON dbo.tbTicket.CreatedBy = dbo.tbUser.PKID
'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'vwTWTicketInfo', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[42] 4[21] 2[30] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tbTicket"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 226
               Right = 198
            End
            DisplayFlags = 280
            TopColumn = 8
         End
         Begin Table = "tbTicketInZone"
            Begin Extent = 
               Top = 6
               Left = 236
               Bottom = 149
               Right = 396
            End
            DisplayFlags = 280
            TopColumn = 3
         End
         Begin Table = "tbZoneGroup"
            Begin Extent = 
               Top = 6
               Left = 434
               Bottom = 249
               Right = 603
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbUser"
            Begin Extent = 
               Top = 6
               Left = 641
               Bottom = 197
               Right = 801
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwTWTicketInfo'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'vwTWTicketInfo', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwTWTicketInfo'
GO
/****** Object:  View [dbo].[vwTransactionLog]    Script Date: 10/24/2012 03:07:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwTransactionLog]'))
EXEC dbo.sp_executesql @statement = N'CREATE VIEW [dbo].[vwTransactionLog]
AS
SELECT        PKID, TransactionType, TransactionDate, Data
FROM            dbo.tbTransactionLog
'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'vwTransactionLog', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tbTransactionLog"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 135
               Right = 215
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwTransactionLog'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'vwTransactionLog', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwTransactionLog'
GO
/****** Object:  View [dbo].[vwTicketUsageLogByFilter]    Script Date: 10/24/2012 03:07:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwTicketUsageLogByFilter]'))
EXEC dbo.sp_executesql @statement = N'CREATE VIEW [dbo].[vwTicketUsageLogByFilter]
AS
SELECT     dbo.tbTicketUsageLog.PKID, dbo.tbZone.ZoneName, dbo.tbZoneGroup.ZoneGroupName, dbo.tbTicketUsageLog.DateUsed, dbo.tbTicketUsageLog.UsageCountBefore, dbo.tbTicketUsageLog.UsageCountAfter, dbo.tbTicketUsageLog.CounterID, dbo.tbTicketUsageLog.TicketID, 
                      dbo.tbZoneGroup.ZoneGroupID AS ZoneGroup_PKID, dbo.tbZone.ZoneID AS Zone_PKID
FROM         dbo.tbZoneAndZoneGroup INNER JOIN
                      dbo.tbZone ON dbo.tbZoneAndZoneGroup.ZoneID = dbo.tbZone.ZoneID INNER JOIN
                      dbo.tbZoneGroup ON dbo.tbZoneAndZoneGroup.ZoneGroupID = dbo.tbZoneGroup.ZoneGroupID INNER JOIN
                      dbo.tbTicketUsageLog ON dbo.tbZone.ZoneID = dbo.tbTicketUsageLog.ZoneID
'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'vwTicketUsageLogByFilter', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[46] 4[5] 2[34] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tbZoneAndZoneGroup"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 135
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbZone"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 135
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbZoneGroup"
            Begin Extent = 
               Top = 6
               Left = 454
               Bottom = 135
               Right = 635
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbTicketUsageLog"
            Begin Extent = 
               Top = 6
               Left = 673
               Bottom = 135
               Right = 861
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwTicketUsageLogByFilter'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane2' , N'SCHEMA',N'dbo', N'VIEW',N'vwTicketUsageLogByFilter', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwTicketUsageLogByFilter'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'vwTicketUsageLogByFilter', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwTicketUsageLogByFilter'
GO
/****** Object:  View [dbo].[vwTicketUsageLog]    Script Date: 10/24/2012 03:07:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vwTicketUsageLog]'))
EXEC dbo.sp_executesql @statement = N'CREATE VIEW [dbo].[vwTicketUsageLog]
AS
SELECT     PKID, TicketID, ZoneID, CounterID, UsageCountBefore, UsageCountAfter, DateUsed, TransactionID
FROM         dbo.tbTicketUsageLog
'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'vwTicketUsageLog', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tbTicketUsageLog"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 149
               Right = 218
            End
            DisplayFlags = 280
            TopColumn = 4
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwTicketUsageLog'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'vwTicketUsageLog', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwTicketUsageLog'
GO
/****** Object:  StoredProcedure [dbo].[SelectTicketUsageHistory]    Script Date: 10/24/2012 03:07:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectTicketUsageHistory]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SelectTicketUsageHistory]
(
	@TicketSerialFrom INT,
	@TicketSerialTo INT,
	@DateUsedFrom DATETIME,
	@DateUsedTo DATETIME,
	@ZoneGroupID INT,
	@ZoneID INT,
	@CounterID INT
)
	
AS
-- SelectTicketUsageHistory null,null,null,null,null,null,null
	/* SET NOCOUNT ON */
	SELECT
		TUL.TicketID,
		TKT.AllowedUsage,
		TUL.UsageCountBefore,
		TUL.UsageCountAfter,
		TUL.CounterID,
		ZNE.ZoneID,
		ZNE.ZoneName,
		ZGP.ZoneGroupID,
		ZGP.ZoneGroupName,
		TUL.DateUsed,
		TUL.TransactionID
	FROM tbTicketUsageLog AS TUL
	INNER JOIN tbTicket AS TKT ON TKT.PKID = TUL.TicketID
	INNER JOIN tbZone AS ZNE ON ZNE.ZoneID = TUL.ZoneID
	LEFT JOIN tbZoneAndZoneGroup AS ZZG ON ZZG.ZoneID = ZNE.ZoneID
	LEFT JOIN tbZoneGroup AS ZGP ON ZGP.ZoneGroupID = ZZG.ZoneGroupID

	WHERE
	(@TicketSErialFrom IS NULL OR @TicketSerialTo IS NULL OR TUL.TicketID BETWEEN @TicketSerialFrom AND @TicketSerialTo)
	AND (@DateUsedFrom IS NULL OR @DateUsedTo IS NULL OR TUL.DateUsed BETWEEN @DateUsedFrom AND @DateUsedTo)
	AND (@ZoneGroupID IS NULL OR ZGP.ZoneGroupID = @ZoneGroupID)
	AND (@ZoneID IS NULL OR ZNE.ZoneID = @ZoneID)
	AND (@CounterID IS NULL OR TUL.CounterID = @CounterID)
	RETURN
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SelectCounterTicketUsageHistory]    Script Date: 10/24/2012 03:07:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectCounterTicketUsageHistory]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SelectCounterTicketUsageHistory]
(
	@TicketSerialFrom INT,
	@TicketSerialTo INT,
	@DateUsedFrom DATETIME,
	@DateUsedTo DATETIME
)
	
AS
-- SelectTicketUsageHistory null,null,null,null,null,null,null
	/* SET NOCOUNT ON */
	SELECT
		TUL.TicketID,
		TUL.ZoneID,
		TUL.CounterID,
		TKT.TicketStatus,
		TKT.AllowedUsage,
		TUL.UsageCountBefore,
		TUL.UsageCountAfter,
		TUL.CounterID,
		TUL.DateUsed,
		TUL.TransactionID
	FROM tbTicketUsageLog AS TUL
	INNER JOIN tbTicket AS TKT ON TKT.PKID = TUL.TicketID

	WHERE
	(@TicketSErialFrom IS NULL OR @TicketSerialTo IS NULL OR TUL.TicketID BETWEEN @TicketSerialFrom AND @TicketSerialTo)
	AND (@DateUsedFrom IS NULL OR @DateUsedTo IS NULL OR TUL.DateUsed BETWEEN @DateUsedFrom AND @DateUsedTo)
	RETURN
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SelectUser]    Script Date: 10/24/2012 03:07:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectUser]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SelectUser]

AS
	/* SET NOCOUNT ON */
	SELECT USR.*,RLE.PKID AS RoleID, RLE.RoleName AS Role FROM tbUser AS USR
	INNER JOIN tbUserInRole AS UIR ON UIR.UserPKID = USR.PKID
	INNER JOIN tbRole AS RLE ON UIR.RoleID = RLE.PKID
	RETURN
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SelectUserInfo]    Script Date: 10/24/2012 03:07:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectUserInfo]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SelectUserInfo]
AS
	/* SET NOCOUNT ON */

	SELECT USR.*,USR1.UserID AS CreatedByUserID,USR2.UserID AS ModifiedByUserID, UAL.AccessDate AS LastLoginDate, RLE.RoleName AS Role
	FROM tbUser AS USR
	INNER JOIN tbUserInRole AS UIR ON UIR.UserPKID = USR.PKID
	INNER JOIN tbRole AS RLE ON RLE.PKID = UIR.RoleID
	LEFT JOIN tbUser AS USR1 ON USR1.PKID = USR.CreatedBy
	LEFT JOIN tbUser AS USR2 ON USR2.PKID = USR.ModifiedBy
	LEFT JOIN (
		SELECT TOP 1 UserPKID,AccessDate FROM tbUserAccessLog ORDER BY AccessDate DESC
	) AS UAL ON UAL.UserPKID = USR.PKID

	RETURN
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SelectWebUser]    Script Date: 10/24/2012 03:07:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectWebUser]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SelectWebUser]

AS
	/* SET NOCOUNT ON */
	SELECT * FROM tbWebUser
	WHERE IsAdmin = 0
	RETURN
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SelectUserInRole]    Script Date: 10/24/2012 03:07:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectUserInRole]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SelectUserInRole]


AS
	/* SET NOCOUNT ON */
	SELECT * FROM vwUserInRole

	RETURN
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SelectUserCollectionUsingFilters]    Script Date: 10/24/2012 03:07:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectUserCollectionUsingFilters]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SelectUserCollectionUsingFilters]
	(	
	@UserStatus varchar(50),
	@DisplayName varchar(50),
	@LoginDateFrom DateTime,
	@LoginDateTo DateTime,
	@CreatedDateFrom DateTime,
	@CreatedDateTo DateTime	
)
AS
/* SET NOCOUNT ON */

	SELECT * FROM vwUserAccessLog
	WHERE (@UserStatus IS NULL OR @UserStatus = Status)
	AND	  (@DisplayName IS NULL OR  DisplayName LIKE  @DisplayName  + ''%'' )
	AND   (@LogindateFrom IS NULL OR @LoginDateTo IS NULL OR AccessDate BETWEEN @LoginDateFrom AND @LoginDateTo)
	AND   (@CreatedDateFrom IS NULL OR @CreatedDateTo IS NULL OR CreatedDate BETWEEN @CreatedDateFrom AND @CreatedDateTo)
	
	RETURN
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SelectUserAccessLogByUserID]    Script Date: 10/24/2012 03:07:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectUserAccessLogByUserID]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SelectUserAccessLogByUserID]
	(
	@UserID varchar(50)
	)
AS
	/* SET NOCOUNT ON */
	SELECT * FROM vwUserAccessLog
	WHERE UserID = @UserID
	
	RETURN
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SelectUserAccessLog]    Script Date: 10/24/2012 03:07:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectUserAccessLog]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SelectUserAccessLog]


AS
	/* SET NOCOUNT ON */
	SELECT *
	FROM vwUserAccessLog

	
	RETURN
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SelectTicketUsingFilters]    Script Date: 10/24/2012 03:07:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectTicketUsingFilters]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SelectTicketUsingFilters]
(
	@TicketSerialFrom INT,
	@TicketSerialTo INT,
	@TicketStatus varchar(50),
	@SoldZone varchar(255),
	@SoldDateFrom DateTime,
	@SoldDateTo DateTime,
	@ActivatedDateFrom DateTime,
	@ActivatedDateTo DateTime,
	@ExpiryDateFrom DateTime,
	@ExpiryDateTo DateTime
)
AS
/* SET NOCOUNT ON */
	SELECT * FROM vwTicket
	WHERE 
	(@TicketSerialFrom IS NULL OR @TicketSerialTo IS NULL OR PKID BETWEEN @TicketSerialFrom AND @TicketSerialTo)
	AND (@TicketStatus IS NULL OR @TicketStatus = TicketStatus)
	AND (ZoneName IS NULL OR @SoldZone = ZoneName)
	AND (@SoldDateFrom IS NULL OR @SoldDateTo IS NULL OR SoldDate BETWEEN @SoldDateFrom AND @SoldDateTo)
	AND (@ActivatedDateFrom IS NULL OR @ActivatedDateTo IS NULL OR ActivatedDate BETWEEN @ActivatedDateFrom AND @ActivatedDateTo)
	AND (@ExpiryDateFrom IS NULL OR @ExpiryDateTo IS NULL OR ExpiryDate BETWEEN @ExpiryDateFrom AND @ExpiryDateTo)
	RETURN
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SelectTicketUsageLogByFilter]    Script Date: 10/24/2012 03:07:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectTicketUsageLogByFilter]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SelectTicketUsageLogByFilter]
(
@ZoneGroupName varchar(100),
@ZoneName varchar(255),
@TicketSerialFrom INT,
@TicketSerialTo INT,
@UsedDateFrom DateTime,
@UsedDateTo DateTime,
@PageNum INT,
@ItemPerPage INT,
@NumOfPage INT OUTPUT
)
AS
/* SET NOCOUNT ON */
DECLARE @ItemCount INT
SET @ItemCount =  (SELECT Count(PKID) FROM vwTicketUsageLogByFilter
	WHERE
	(@TicketSerialFrom IS NULL OR @TicketSerialTo IS NULL OR TicketID BETWEEN @TicketSerialFrom AND @TicketSerialTo)
	AND (@ZoneName IS NULL OR @ZoneName = Zone_PKID)
	AND (@ZoneGroupName IS NULL OR ZoneGroup_PKID = CAST(@ZoneGroupName AS INT))
	AND (@UsedDateFrom IS NULL OR @UsedDateTo IS NULL OR DateUsed BETWEEN @UsedDateFrom AND @UsedDateTo)
)

SET @NumOfPage = Ceiling(Cast(@ItemCount as Decimal) / Cast(@ItemPerPage as Decimal))

SELECT * FROM (
SELECT Row_Number() Over(ORDER BY PKID DESC) AS RowIndex, * FROM vwTicketUsageLogByFilter
WHERE
(@TicketSerialFrom IS NULL OR @TicketSerialTo IS NULL OR TicketID BETWEEN @TicketSerialFrom AND @TicketSerialTo)
AND (@ZoneName IS NULL OR @ZoneName = Zone_PKID)
AND (@ZoneGroupName IS NULL OR ZoneGroup_PKID = CAST(@ZoneGroupName AS INT))
AND (@UsedDateFrom IS NULL OR @UsedDateTo IS NULL OR DateUsed BETWEEN @UsedDateFrom AND @UsedDateTo)
) AS TEMP
WHERE RowIndex BETWEEN (@ItemPerPage * @PageNum) AND (@ItemPerPage * (@PageNum + 1))



RETURN
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SelectCounterDetail]    Script Date: 10/24/2012 03:07:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectCounterDetail]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SelectCounterDetail]
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
AS
/* SET NOCOUNT ON */
	SELECT * FROM vwCounterAndZone
	RETURN
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SelectCounter]    Script Date: 10/24/2012 03:07:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectCounter]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SelectCounter]
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
AS
	/* SET NOCOUNT ON */
	SELECT * FROM vwCounter
	RETURN
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SelectMaxPKID]    Script Date: 10/24/2012 03:07:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectMaxPKID]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SelectMaxPKID]


AS
/* SET NOCOUNT ON */
	SELECT MAX(PKID) FROM vwTicket

	RETURN
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SelectExceptionLog]    Script Date: 10/24/2012 03:07:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectExceptionLog]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SelectExceptionLog]
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
AS
	/* SET NOCOUNT ON */
	SELECT * FROM vwExceptionLog
	RETURN
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SelectDistinctZoneGroup]    Script Date: 10/24/2012 03:07:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectDistinctZoneGroup]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SelectDistinctZoneGroup]
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
AS
/* SET NOCOUNT ON */
	SELECT Distinct(ZoneGroupName) FROM vwDistinctZoneGroupName
	RETURN
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SelectTicketUsage]    Script Date: 10/24/2012 03:07:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectTicketUsage]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SelectTicketUsage]

AS
/* SET NOCOUNT ON */
	SELECT * FROM vwTicketUsage
	RETURN
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SelectTicketUnused]    Script Date: 10/24/2012 03:07:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectTicketUnused]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SelectTicketUnused]
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
AS
/* SET NOCOUNT ON */
	SELECT * FROM vwTicketUnused
	RETURN
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SelectTicketStatusByTicketID]    Script Date: 10/24/2012 03:07:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectTicketStatusByTicketID]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SelectTicketStatusByTicketID]
	@TicketID int
AS
/* SET NOCOUNT ON */
	SELECT * FROM vwTicket
	WHERE PKID = @TicketID
	RETURN
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SelectTicketSetting]    Script Date: 10/24/2012 03:07:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectTicketSetting]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SelectTicketSetting]
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
AS
/* SET NOCOUNT ON */
	SELECT * FROM vwTicketSettings
	RETURN
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SelectTicketInZone]    Script Date: 10/24/2012 03:07:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectTicketInZone]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SelectTicketInZone]

AS
/* SET NOCOUNT ON */
	SELECT * FROM vwTicketInZone
	RETURN
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SelectTicketDetails]    Script Date: 10/24/2012 03:07:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectTicketDetails]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SelectTicketDetails]
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
AS
	/* SET NOCOUNT ON */
	SELECT * FROM vwTicketDetails
	RETURN
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SelectTicketCollectionsUsingFilters]    Script Date: 10/24/2012 03:07:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectTicketCollectionsUsingFilters]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SelectTicketCollectionsUsingFilters]
(
	@TicketSerialFrom INT,
	@TicketSerialTo INT,
	@ZoneGroup varchar(125),
	@TicketStatus varchar(50),
	@CreatedDateFrom DateTime,
	@CreatedDateTo DateTime
	--@PrintedDateFrom DateTime,
	--@PrintedDateTo DateTime,
)
AS
/* SET NOCOUNT ON */
	SELECT * FROM vwTicketDetails
	WHERE 
	(@TicketSerialFrom IS NULL OR @TicketSerialTo IS NULL OR PKID BETWEEN @TicketSerialFrom AND @TicketSerialTo)
	AND (@TicketStatus IS NULL OR @TicketStatus = TicketStatus)
	AND (@ZoneGroup IS NULL OR @ZoneGroup = ZoneGroupName) 
	AND (@CreatedDateFrom IS NULL OR @CreatedDateTo IS NULL OR CreatedDate BETWEEN @CreatedDateFrom AND @CreatedDateTo)
	--AND (@PrintedDateFrom IS NULL OR @PrintedDateTo IS NULL OR ActivatedDate BETWEEN @ActivatedDateFrom AND @ActivatedDateTo)
	
	RETURN
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SelectTicket]    Script Date: 10/24/2012 03:07:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectTicket]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SelectTicket]

AS
/* SET NOCOUNT ON */
	SELECT * FROM vwTicket
	RETURN
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SelectSample]    Script Date: 10/24/2012 03:07:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectSample]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SelectSample]
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
AS
	/* SET NOCOUNT ON */
	SELECT * FROM vwSampleObject
	RETURN
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SelectRole]    Script Date: 10/24/2012 03:07:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectRole]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SelectRole]


AS
	/* SET NOCOUNT ON */
	SELECT * FROM vwRole

	RETURN
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SelectPrintingApproved]    Script Date: 10/24/2012 03:07:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectPrintingApproved]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SelectPrintingApproved]


AS
/* SET NOCOUNT ON */
	SELECT * FROM vwPrintingApproved

	RETURN
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SelectZoneSetting]    Script Date: 10/24/2012 03:07:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectZoneSetting]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SelectZoneSetting]
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
AS
/* SET NOCOUNT ON */
	SELECT * FROM vwZoneSetting
	RETURN
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SelectZoneGroup]    Script Date: 10/24/2012 03:07:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectZoneGroup]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SelectZoneGroup]
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
AS
/* SET NOCOUNT ON */
	SELECT * FROM vwZoneGroup
return
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SelectZoneAndZoneGroup]    Script Date: 10/24/2012 03:07:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectZoneAndZoneGroup]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SelectZoneAndZoneGroup]
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
AS
/* SET NOCOUNT ON */
	SELECT * FROM vwZoneAndZoneGroup
	RETURN
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SelectZone]    Script Date: 10/24/2012 03:07:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectZone]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SelectZone]
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
AS
	/* SET NOCOUNT ON */
	SELECT * FROM vwZone
	RETURN
' 
END
GO
