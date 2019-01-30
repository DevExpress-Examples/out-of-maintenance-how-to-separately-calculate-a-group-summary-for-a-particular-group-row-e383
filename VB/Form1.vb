Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Data
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid

Namespace summary
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			gridControl1.DataSource = CarList.GetList()
		End Sub

		Private counter As Integer
		Private ivalue As Integer
		Private dvalue As Double

		Private Sub gridView1_CustomSummaryCalculate(ByVal sender As Object, ByVal e As DevExpress.Data.CustomSummaryEventArgs) Handles gridView1.CustomSummaryCalculate
			If (Not e.IsGroupSummary) Then
				Return
			End If
			If e.SummaryProcess = CustomSummaryProcess.Start Then
				ivalue = 0
				dvalue = 0
				counter = 0
			End If
			If e.SummaryProcess = CustomSummaryProcess.Calculate Then
				If (CType(e.Item, GridGroupSummaryItem)).FieldName = "HP" Then
					If e.GroupRowHandle Mod 2 = 0 Then
						ivalue += CShort(Fix(e.FieldValue))
					Else
						ivalue += 1
					End If
				End If
				If (CType(e.Item, GridGroupSummaryItem)).FieldName = "Liter" Then
					If e.GroupRowHandle Mod 2 = 0 Then
						dvalue = Math.Max(dvalue, CDbl(e.FieldValue))
					Else
						dvalue += CDbl(e.FieldValue)
						counter += 1
					End If
				End If
			End If
			If e.SummaryProcess = CustomSummaryProcess.Finalize Then
				If (CType(e.Item, GridGroupSummaryItem)).FieldName = "HP" Then
					If e.GroupRowHandle Mod 2 = 0 Then
						e.TotalValue = ivalue
					Else
						e.TotalValue = ivalue
					End If
				End If
				If (CType(e.Item, GridGroupSummaryItem)).FieldName = "Liter" Then
					If e.GroupRowHandle Mod 2 = 0 Then
						e.TotalValue = dvalue
					Else
						e.TotalValue = dvalue / counter
					End If
				End If
			End If
		End Sub

		Private Sub gridView1_CustomDrawRowFooterCell(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventArgs) Handles gridView1.CustomDrawRowFooterCell
			Dim view As GridView = CType(sender, GridView)
			If e.Column.FieldName = "HP" Then
				If e.RowHandle Mod 2 = 0 Then
					e.Info.DisplayText = String.Format("Total: {0}", view.GetGroupSummaryValue(e.RowHandle, CType(view.GroupSummary(0), GridGroupSummaryItem)))
				Else
					e.Info.DisplayText = String.Format("Count: {0}", view.GetGroupSummaryValue(e.RowHandle, CType(view.GroupSummary(0), GridGroupSummaryItem)))
				End If
			End If
			If e.Column.FieldName = "Liter" Then
				If e.RowHandle Mod 2 = 0 Then
					e.Info.DisplayText = String.Format("Max: {0}", view.GetGroupSummaryValue(e.RowHandle, CType(view.GroupSummary(1), GridGroupSummaryItem)))
				Else
					e.Info.DisplayText = String.Format("Avr: {0}", view.GetGroupSummaryValue(e.RowHandle, CType(view.GroupSummary(1), GridGroupSummaryItem)))
				End If
			End If
		End Sub
	End Class
End Namespace