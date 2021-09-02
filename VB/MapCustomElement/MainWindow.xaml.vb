Imports System
Imports System.Windows

Namespace MapCustomElement
	Partial Public Class MainWindow
		Inherits Window

		Public Sub New()
			InitializeComponent()
		End Sub
	End Class

	Friend Class ShipwreckInformation
		Public Property ImageUri() As Uri
		Public Property Name() As String
		Public Property Year() As Int32
		Public Property Description() As String
	End Class
End Namespace
