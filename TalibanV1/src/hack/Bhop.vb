Module Bhop
    Public Sub Bhop()
        While True
            Dim pLocalPlayer = Mem.ReadInt(bClient + Offsets.oLocalPlayer, 4)
            Dim Flags = Mem.ReadInt(pLocalPlayer + Offsets.oFlags, 4)

            If GetAsyncKeyState(Keys.Space) And menu.BunnyHop.Checked And Flags = 257 Then
                Mem.WriteInt(bClient + Offsets.oJump, 4, 5)
                Threading.Thread.Sleep(1)
                Mem.WriteInt(bClient + Offsets.oJump, 4, 4)
            Else
                Threading.Thread.Sleep(3)
            End If
        End While
    End Sub
End Module
