<ComClass(ComClass1.ClassId, ComClass1.InterfaceId, ComClass1.EventsId)> _
Public Class ComClass1

#Region "COM GUID"
    ' 這些 GUID 提供了這個類別的 COM 識別
    ' 與其 COM 的介面。如果您變更這些設定，現有的
    ' 用戶端將無法再存取該類別。
    Public Const ClassId As String = "0f2e45fb-f906-45e2-8ad5-d341ebb50582"
    Public Const InterfaceId As String = "74fc8c27-d098-467b-adf2-231426bcb4e8"
    Public Const EventsId As String = "f5814719-ac75-4802-a23a-53f115d6ffa2"
#End Region

    ' 可建立的 COM 類別必須要有一個沒有參數的 Public Sub New()，
    ' 否則，該類別將無法於 COM 登錄中予以登錄，
    ' 而且也無法透過
    ' CreateObject 來建立該類別。
    Public Sub New()
        MyBase.New()
    End Sub

End Class


