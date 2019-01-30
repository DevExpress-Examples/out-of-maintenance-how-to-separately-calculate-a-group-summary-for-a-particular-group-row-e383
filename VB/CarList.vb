Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace summary
	Public NotInheritable Class CarList
		Private Sub New()
		End Sub
		Public Shared Function GetList() As BindingList(Of Car)
			Dim list = New BindingList(Of Car)()
			list.Add(New Car() With {.ID = 1, .Trademark = "Mercedes-Benz", .Model = "SL500 Roadster", .HP = 302, .Liter = 4.966})
			list.Add(New Car() With {.ID = 2, .Trademark = "Mercedes-Benz", .Model = "CLK55 AMG Cabriolet", .HP = 342, .Liter = 5.439})
			list.Add(New Car() With {.ID = 3, .Trademark = "Mercedes-Benz", .Model = "C230 Kompressor Sport Coupe", .HP = 189, .Liter = 1.796})
			list.Add(New Car() With {.ID = 4, .Trademark = "BMW", .Model = "530i", .HP = 225, .Liter = 3})
			list.Add(New Car() With {.ID = 5, .Trademark = "Rolls-Royce", .Model = "Corniche", .HP = 325, .Liter = 6.75})
			list.Add(New Car() With {.ID = 6, .Trademark = "Jaguar", .Model = "S-Type 3.0", .HP = 235, .Liter = 3})
			list.Add(New Car() With {.ID = 7, .Trademark = "Cadillac", .Model = "Seville", .HP = 275, .Liter = 4.6})
			list.Add(New Car() With {.ID = 8, .Trademark = "Cadillac", .Model = "DeVille", .HP = 275, .Liter = 4.6})
			list.Add(New Car() With {.ID = 9, .Trademark = "Lexus", .Model = "LS430", .HP = 290, .Liter = 4.3})
			list.Add(New Car() With {.ID = 10, .Trademark = "Lexus", .Model = "GS 430", .HP = 300, .Liter = 4.3})
			list.Add(New Car() With {.ID = 11, .Trademark = "Ford", .Model = "Ranger FX-4", .HP = 135, .Liter = 2.3})
			list.Add(New Car() With {.ID = 12, .Trademark = "Dodge", .Model = "Ram 1500", .HP = 215, .Liter = 3.7})
			list.Add(New Car() With {.ID = 13, .Trademark = "GMC", .Model = "Siera Quadrasteer", .HP = 200, .Liter = 4.3})
			list.Add(New Car() With {.ID = 14, .Trademark = "Nissan", .Model = "Crew Cab SE", .HP = 143, .Liter = 2.4})
			list.Add(New Car() With {.ID = 15, .Trademark = "Toyota", .Model = "Tacoma S-Runner", .HP = 190, .Liter = 3.4})
			Return list
		End Function
	End Class
	Public Class Car
		Private privateID As Integer
		Public Property ID() As Integer
			Get
				Return privateID
			End Get
			Set(ByVal value As Integer)
				privateID = value
			End Set
		End Property
		Private privateTrademark As String
		Public Property Trademark() As String
			Get
				Return privateTrademark
			End Get
			Set(ByVal value As String)
				privateTrademark = value
			End Set
		End Property
		Private privateModel As String
		Public Property Model() As String
			Get
				Return privateModel
			End Get
			Set(ByVal value As String)
				privateModel = value
			End Set
		End Property
		Private privateHP As Int16
		Public Property HP() As Int16
			Get
				Return privateHP
			End Get
			Set(ByVal value As Int16)
				privateHP = value
			End Set
		End Property
		Private privateLiter As Double
		Public Property Liter() As Double
			Get
				Return privateLiter
			End Get
			Set(ByVal value As Double)
				privateLiter = value
			End Set
		End Property
	End Class
End Namespace
