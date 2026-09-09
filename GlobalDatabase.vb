Imports System.Data.SqlClient

Public Module GlobalDatabase

    Private Const connString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\rectodb.mdf;Integrated Security=True"

    ' 1. GetTable (No Parameters)
    Public Function GetTable(query As String) As DataTable
        Dim dt As New DataTable()
        Using conn As New SqlConnection(connString)
            Using cmd As New SqlCommand(query, conn)
                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using
        Return dt
    End Function

    ' 2. GetTable (With Parameters - Secures against SQL Injection)
    Public Function GetTable(query As String, parameters As SqlParameter()) As DataTable
        Dim dt As New DataTable()
        Using conn As New SqlConnection(connString)
            Using cmd As New SqlCommand(query, conn)
                If parameters IsNot Nothing Then
                    For Each param In parameters
                        cmd.Parameters.Add(CType(CType(param, ICloneable).Clone(), SqlParameter))
                    Next
                End If
                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using
        Return dt
    End Function

    ' 3. ExecuteQuery (INSERT, UPDATE, DELETE)
    Public Function ExecuteQuery(query As String, parameters As SqlParameter()) As Integer
        Using conn As New SqlConnection(connString)
            Using cmd As New SqlCommand(query, conn)
                If parameters IsNot Nothing Then
                    For Each param In parameters
                        cmd.Parameters.Add(CType(CType(param, ICloneable).Clone(), SqlParameter))
                    Next
                End If
                conn.Open()
                Return cmd.ExecuteNonQuery()
            End Using
        End Using
    End Function

    ' 4. ExecuteScalar (Returns a single value like COUNT)
    Public Function ExecuteScalar(query As String, parameters As SqlParameter()) As Object
        Using conn As New SqlConnection(connString)
            Using cmd As New SqlCommand(query, conn)
                If parameters IsNot Nothing Then
                    For Each param In parameters
                        cmd.Parameters.Add(CType(CType(param, ICloneable).Clone(), SqlParameter))
                    Next
                End If
                conn.Open()
                Return cmd.ExecuteScalar()
            End Using
        End Using
    End Function

    ' 5. ExecuteTransaction (Batch updates with rollback safety)
    Public Function ExecuteTransaction(queries As String(), allParameters As SqlParameter()()) As Boolean
        Using conn As New SqlConnection(connString)
            conn.Open()
            Using transaction As SqlTransaction = conn.BeginTransaction()
                Using cmd As SqlCommand = conn.CreateCommand()
                    cmd.Transaction = transaction
                    Try
                        For i As Integer = 0 To queries.Length - 1
                            cmd.CommandText = queries(i)
                            cmd.Parameters.Clear()

                            If allParameters IsNot Nothing AndAlso allParameters(i) IsNot Nothing Then
                                cmd.Parameters.AddRange(allParameters(i))
                            End If
                            cmd.ExecuteNonQuery()
                        Next
                        transaction.Commit()
                        Return True
                    Catch ex As Exception
                        transaction.Rollback()
                        Return False
                    End Try
                End Using
            End Using
        End Using
    End Function
End Module
