Imports System.IO
Imports Microsoft.Office.Interop
Imports System.Data
Imports System.Data.OleDb
Imports System
Imports Microsoft.VisualBasic

Module Importar

    Sub ImportarExcel(ByVal tabla As DataGridView)

        Dim myFileDialog As New OpenFileDialog
        Dim xSheet As String = ""

        With myFileDialog
            '"pdf files (*.pdf)|*.pdf|All files (*.*)|*.*"
            .Filter = "Excel Files (* .xlsx)|* .xlsx |Excel Files (* .xls)|* .xls"
            '.Filter = "Excel Files |* .xlsx |All files (*.*)|*.*"
            .Title = "Open File"
            .ShowDialog()

        End With

        If myFileDialog.FileName.ToString <> "" Then
            Dim ExcelFile As String = myFileDialog.FileName.ToString

            Dim ds As New DataSet
            Dim da As OleDbDataAdapter
            Dim dt As DataTable
            Dim cnn As OleDbConnection
            xSheet = InputBox("Digite el nombre de la Hoja que desea importar", "Complete")
            cnn = New OleDbConnection(
                                        "Provider=Microsoft.ACE.OLEDB.12.0;" &
                                        "data source=" & ExcelFile & "; " &
                                        "Extended Properties= 'Excel 12.0 Xml;HDR=Yes'")


            Try

                da = New OleDbDataAdapter("SELECT * FROM [" & xSheet & "$]", cnn)
                cnn.Open()
                da.Fill(ds, "MyData")
                dt = ds.Tables("MyData")

                tabla.DataSource = ds
                tabla.DataMember = "MyData"

            Catch ex As Exception

                MsgBox("Inserte un nombre valido de la hoja que desea importar" + ex.Message, MsgBoxStyle.Information, "Aviso")

            Finally

                cnn.Close()

            End Try

        End If



    End Sub


End Module
