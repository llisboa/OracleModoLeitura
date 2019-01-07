Public Class Form1

    Function StrConn() As String
        Return "providerName:System.Data.OracleClient;Data Source:" & txtCONN.Text & ";User Id:" & txtUSU.Text & ";Password:" & txtSENHA.Text
    End Function

    Private Sub btnAtualiza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtualiza.Click
        Try
            grd.SQL = "SELECT OWNER, TABLE_NAME, READ_ONLY FROM ALL_TABLES WHERE OWNER IN (SELECT USERNAME FROM ALL_USERS WHERE INSTR(';SYS;SYSTEM;OUTLN;DIP;ORACLE_OCM;DBSNMP;APPQOSSYS;WMSYS;EXFSYS;CTXSYS;XDB;ANONYMOUS;ORDSYS;ORDDATA;ORDPLUGINS;SI_INFORMTN_SCHEMA;MDSYS;OLAPSYS;MDDATA;SPATIAL_WFS_ADMIN_USR;SPATIAL_CSW_ADMIN_USR;SYSMAN;MGMT_VIEW;FLOWS_FILES;APEX_PUBLIC_USER;APEX_030200;OWBSYS;OWBSYS_AUDIT;SCOTT;', ';' || USERNAME || ';')=0)"
            grd.StrConn = StrConn()
            grd.Bind()
        Catch EX As Exception
            MsgBox(EX.Message)
        End Try
    End Sub

    Private Sub btnTravar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTravar.Click
        Try
            SALVAPOS()
            Dim CRIT As String = ""
            For Each Linha As DataGridViewRow In grd.Grid.SelectedRows
                CRIT &= IIf(CRIT <> "", " OR ", "") & "(OWNER='" & Icraft.IcftBase.Tratex(Linha.Cells(0).Value) & "' AND TABLE_NAME='" & Icraft.IcftBase.Tratex(Linha.Cells(1).Value) & "')"
            Next

            Dim SQL As String = "DECLARE" & vbCrLf & _
            "COMA VARCHAR2(4000);" & vbCrLf & _
            "BEGIN" & vbCrLf & _
            "FOR CUR IN (SELECT OWNER, TABLE_NAME FROM ALL_TABLES WHERE " & CRIT & ") LOOP" & vbCrLf & _
            "IF INSTR(';SYS_CONFIG_USUARIO;', ';' || CUR.TABLE_NAME || ';')=0 THEN" & vbCrLf & _
            "COMA := 'ALTER TABLE ' || CUR.OWNER || '.' || CUR.TABLE_NAME || ' READ ONLY';" & vbCrLf & _
            "DBMS_OUTPUT.PUT_LINE(COMA);" & vbCrLf & _
            "BEGIN" & vbCrLf & _
            "EXECUTE IMMEDIATE COMA;" & vbCrLf & _
            "Exception" & vbCrLf & _
            "WHEN OTHERS THEN" & vbCrLf & _
            "DBMS_OUTPUT.PUT_LINE('==> ERRO:' || SQLERRM);" & vbCrLf & _
            "END;" & vbCrLf & _
            "END IF;" & vbCrLf & _
            "END LOOP;" & vbCrLf & _
            "END;"
            Icraft.IcftBase.DSGrava(SQL, StrConn)

            btnAtualiza_Click(Nothing, Nothing)
            RECUPERAPOS()
        Catch EX As Exception
            MsgBox(EX.Message)
        End Try
    End Sub

    Private Sub btnLiberar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLiberar.Click
        Try
            SALVAPOS()
            Dim CRIT As String = ""
            For Each Linha As DataGridViewRow In grd.Grid.SelectedRows
                CRIT &= IIf(CRIT <> "", " OR ", "") & "(OWNER='" & Icraft.IcftBase.Tratex(Linha.Cells(0).Value) & "' AND TABLE_NAME='" & Icraft.IcftBase.Tratex(Linha.Cells(1).Value) & "')"
            Next

            Dim SQL As String = "DECLARE" & vbCrLf & _
            "COMA VARCHAR2(4000);" & vbCrLf & _
            "BEGIN" & vbCrLf & _
            "FOR CUR IN (SELECT OWNER, TABLE_NAME FROM ALL_TABLES WHERE " & CRIT & ") LOOP" & vbCrLf & _
            "IF INSTR(';SYS_CONFIG_USUARIO;', ';' || CUR.TABLE_NAME || ';')=0 THEN" & vbCrLf & _
            "COMA := 'ALTER TABLE ' || CUR.OWNER || '.' || CUR.TABLE_NAME || ' READ WRITE';" & vbCrLf & _
            "DBMS_OUTPUT.PUT_LINE(COMA);" & vbCrLf & _
            "BEGIN" & vbCrLf & _
            "EXECUTE IMMEDIATE COMA;" & vbCrLf & _
            "Exception" & vbCrLf & _
            "WHEN OTHERS THEN" & vbCrLf & _
            "DBMS_OUTPUT.PUT_LINE('==> ERRO:' || SQLERRM);" & vbCrLf & _
            "END;" & vbCrLf & _
            "END IF;" & vbCrLf & _
            "END LOOP;" & vbCrLf & _
            "END;"
            Icraft.IcftBase.DSGrava(SQL, StrConn)

            btnAtualiza_Click(Nothing, Nothing)
            RECUPERAPOS()
        Catch EX As Exception
            MsgBox(EX.Message)
        End Try
    End Sub

    Dim ESQUEMA As String
    Dim TABELA As String
    Dim CELL As Integer
    Sub SALVAPOS()
        If Not IsNothing(grd.Grid.CurrentRow) Then
            ESQUEMA = grd.Grid.CurrentRow.Cells(0).Value
            TABELA = grd.Grid.CurrentRow.Cells(1).Value
            CELL = grd.Grid.CurrentCell.ColumnIndex
        End If
    End Sub

    Sub RECUPERAPOS()
        For Each ROW As DataGridViewRow In grd.Grid.Rows
            If ROW.Cells(0).Value = ESQUEMA And ROW.Cells(1).Value = TABELA Then
                grd.Grid.CurrentCell = ROW.Cells(CELL)
                Exit Sub
            End If
        Next
    End Sub
End Class
