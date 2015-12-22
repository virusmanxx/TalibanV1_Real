Module Trigger
    Public Sub Trigger()
        While True
            If GetAsyncKeyState(18) And menu.Triggerbot.Checked Then
                Dim pLocalPlayer = Mem.ReadInt(bClient + Offsets.oLocalPlayer, 4)
                Dim pInCross = Mem.ReadInt(pLocalPlayer + Offsets.oInCross, 4)

                If pInCross > 0 And pInCross < 65 Then
                    Dim Team = Mem.ReadInt(pLocalPlayer + Offsets.oTeam, 4)
                    Dim pInCrossPlayer = Mem.ReadInt(bClient + Offsets.oEntityList + ((pInCross - 1) * &H10), 4)
                    Dim InCrossTeam = Mem.ReadInt(pInCrossPlayer + Offsets.oTeam, 4)

                    If Not Team = InCrossTeam Then
                        Threading.Thread.Sleep(50)
                        Mem.WriteInt(bClient + Offsets.oAttack, 4, 1)
                        Threading.Thread.Sleep(10)
                        Mem.WriteInt(bClient + Offsets.oAttack, 4, 4)
                    End If
                End If
            End If

            Threading.Thread.Sleep(1)
        End While
    End Sub
End Module