Imports System
Imports System.Windows

Namespace MapCustomElement

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub
    End Class

    Friend Class ShipwreckInformation

        Public Property ImageUri As Uri

        Public Property Name As String

        Public Property Year As Integer

        Public Property Description As String
    End Class
End Namespace
