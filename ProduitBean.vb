Imports Microsoft.VisualBasic

Public Class ProduitBean
    Public code As String
    Public nom As String
    Public description As String
    Public quantite As Integer

    Public Sub New(Optional cd As String = " ", Optional nm As String = " ", Optional desc As String = " ")
        code = cd
        nom = nm
        description = desc
    End Sub

End Class
