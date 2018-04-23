Imports Microsoft.VisualBasic
Imports System.Windows.Controls

Namespace slAttributesBasedValidation
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
			grid.ItemsSource = Stuff.GetStuff()
		End Sub
	End Class
End Namespace
