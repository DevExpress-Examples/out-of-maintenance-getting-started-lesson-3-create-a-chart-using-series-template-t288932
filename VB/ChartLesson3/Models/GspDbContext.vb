Imports System.Data.Entity

Partial Public Class GspDbContext
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=GspDbContext")
    End Sub

    Public Overridable Property GSPs As DbSet(Of GSP)

    Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
        modelBuilder.Entity(Of GSP)() _
            .Property(Function(e) e.SSMA_TimeStamp) _
            .IsFixedLength()
    End Sub
End Class
