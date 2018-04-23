Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports System.Collections.Generic
Imports System.Collections
Imports DevExpress.Web.ASPxEditors
Imports System.Drawing
Imports System.IO
Imports System.Drawing.Imaging
Imports DevExpress.Web.ASPxPopupControl
Imports DevExpress.Web.ASPxPanel
Imports System.Globalization
Imports DevExpress.Web.ASPxClasses.Internal
Imports DevExpress.Web.ASPxClasses
Imports DevExpress.Web.ASPxTreeList
Imports DevExpress.Data
Imports DevExpress.Web.ASPxTitleIndex
Imports DevExpress.Web.ASPxNavBar
Imports DevExpress.Web.ASPxGridView
Imports DevExpress.XtraPrinting

Partial Public Class _Default
	Inherits System.Web.UI.Page

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

	End Sub

	Protected Sub ASPxPopupMenu1_PopupElementResolve(ByVal sender As Object, ByVal e As ControlResolveEventArgs)
		e.ResolvedControl = ASPxButton1
	End Sub
End Class
