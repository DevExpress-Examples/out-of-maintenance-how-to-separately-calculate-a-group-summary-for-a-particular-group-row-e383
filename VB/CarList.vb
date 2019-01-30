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
            list.Add(New Car() With { _
                .ID = 1, _
                .Trademark = "Mercedes-Benz", _
                .Model = "SL500 Roadster", _
                .HP = 302, _
                .Liter = 4.966 _
            })
            list.Add(New Car() With { _
                .ID = 2, _
                .Trademark = "Mercedes-Benz", _
                .Model = "CLK55 AMG Cabriolet", _
                .HP = 342, _
                .Liter = 5.439 _
            })
            list.Add(New Car() With { _
                .ID = 3, _
                .Trademark = "Mercedes-Benz", _
                .Model = "C230 Kompressor Sport Coupe", _
                .HP = 189, _
                .Liter = 1.796 _
            })
            list.Add(New Car() With { _
                .ID = 4, _
                .Trademark = "BMW", _
                .Model = "530i", _
                .HP = 225, _
                .Liter = 3 _
            })
            list.Add(New Car() With { _
                .ID = 5, _
                .Trademark = "Rolls-Royce", _
                .Model = "Corniche", _
                .HP = 325, _
                .Liter = 6.75 _
            })
            list.Add(New Car() With { _
                .ID = 6, _
                .Trademark = "Jaguar", _
                .Model = "S-Type 3.0", _
                .HP = 235, _
                .Liter = 3 _
            })
            list.Add(New Car() With { _
                .ID = 7, _
                .Trademark = "Cadillac", _
                .Model = "Seville", _
                .HP = 275, _
                .Liter = 4.6 _
            })
            list.Add(New Car() With { _
                .ID = 8, _
                .Trademark = "Cadillac", _
                .Model = "DeVille", _
                .HP = 275, _
                .Liter = 4.6 _
            })
            list.Add(New Car() With { _
                .ID = 9, _
                .Trademark = "Lexus", _
                .Model = "LS430", _
                .HP = 290, _
                .Liter = 4.3 _
            })
            list.Add(New Car() With { _
                .ID = 10, _
                .Trademark = "Lexus", _
                .Model = "GS 430", _
                .HP = 300, _
                .Liter = 4.3 _
            })
            list.Add(New Car() With { _
                .ID = 11, _
                .Trademark = "Ford", _
                .Model = "Ranger FX-4", _
                .HP = 135, _
                .Liter = 2.3 _
            })
            list.Add(New Car() With { _
                .ID = 12, _
                .Trademark = "Dodge", _
                .Model = "Ram 1500", _
                .HP = 215, _
                .Liter = 3.7 _
            })
            list.Add(New Car() With { _
                .ID = 13, _
                .Trademark = "GMC", _
                .Model = "Siera Quadrasteer", _
                .HP = 200, _
                .Liter = 4.3 _
            })
            list.Add(New Car() With { _
                .ID = 14, _
                .Trademark = "Nissan", _
                .Model = "Crew Cab SE", _
                .HP = 143, _
                .Liter = 2.4 _
            })
            list.Add(New Car() With { _
                .ID = 15, _
                .Trademark = "Toyota", _
                .Model = "Tacoma S-Runner", _
                .HP = 190, _
                .Liter = 3.4 _
            })
            Return list
        End Function
    End Class
    Public Class Car
        Public Property ID() As Integer
        Public Property Trademark() As String
        Public Property Model() As String
        Public Property HP() As Int16
        Public Property Liter() As Double
    End Class
End Namespace
