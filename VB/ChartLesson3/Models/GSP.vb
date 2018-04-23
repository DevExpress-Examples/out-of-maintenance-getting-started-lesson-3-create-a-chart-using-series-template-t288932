Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("GSP")>
Partial Public Class GSP
    Public Property ID As Integer

    <StringLength(50)>
    Public Property Region As String

    Public Property Year As Integer?

    <Column("GSP")>
    Public Property GSP1 As Double?

    <Column(TypeName:="timestamp")>
    <MaxLength(8)>
    <Timestamp>
    Public Property SSMA_TimeStamp As Byte()
End Class
