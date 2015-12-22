Module Radar
    Public Sub Radar()
        While True
            If menu.Radar.Checked Then
                For i As Integer = 0 To 64
                    Dim pCurPlayer = Mem.ReadInt(bClient + Offsets.oEntityList + ((i - 1) * 16), 4)
                    Dim CurPlayerDormant = Mem.ReadBool(pCurPlayer + Offsets.oDormant, 4)
                    Dim CurPlayerSpotted = Mem.ReadBool(pCurPlayer + Offsets.oSpotted, 4)

                    If Not CurPlayerDormant And Not CurPlayerSpotted Then
                        Mem.WriteInt(pCurPlayer + Offsets.oSpotted, 4, 1)
                    End If
                Next
            End If
            Threading.Thread.Sleep(1000 / 60)
        End While
    End Sub
End Module
