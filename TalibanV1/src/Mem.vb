Module Mem
    Private Function ToLong(ByVal byBytes() As Byte)
        Dim lOut As Long

        For i = 0 To (UBound(byBytes) - LBound(byBytes))
            If (i = 0 And ((byBytes(0) And &H80) > 0)) Then
                lOut = lOut Or -(CLng(byBytes(i)) * (2 ^ (8 * (Len(lOut) - 1 - i))))
            Else
                lOut = lOut Or (CLng(byBytes(i)) * (2 ^ (8 * (Len(lOut) - 1 - i))))
            End If
        Next

        Return lOut
    End Function

    Public Function Read(ByVal adr As Int32, ByVal l As Int32) As Byte()
        Dim Bytes(l - 1) As Byte
        ReadProcessMemory(csgoHandle, adr, Bytes, Bytes.Length, vbNull)
        Return Bytes
    End Function

    Public Function ReadInt(ByVal adr As Int32, ByVal l As Int32)
        Return BitConverter.ToInt32(Read(adr, l), 0)
    End Function

    Public Function ReadBool(ByVal adr As Int32, ByVal l As Int32)
        Return BitConverter.ToBoolean(Read(adr, l), 0)
    End Function

    Public Function ReadSingle(ByVal adr As Int32, ByVal l As Int32)
        Return BitConverter.ToSingle(Read(adr, l), 0)
    End Function

    Public Function ReadLong(ByVal adr As Int32, ByVal l As Int32)
        Return ToLong(Read(adr, l))
    End Function

    Public Sub Write(ByVal adr As Int32, ByVal Bytes As Byte())
        WriteProcessMemory(csgoHandle, adr, Bytes, Bytes.Length, vbNull)
    End Sub

    Public Sub WriteBool(ByVal adr As Int32, ByVal l As Int32, ByVal val As Boolean)
        Dim Bytes(l - 1) As Byte
        Bytes = BitConverter.GetBytes(val)
        Write(adr, Bytes)
    End Sub

    Public Sub WriteSingle(ByVal adr As Int32, ByVal l As Int32, ByVal val As Single)
        Dim Bytes(l - 1) As Byte
        Bytes = BitConverter.GetBytes(val)
        Write(adr, Bytes)
    End Sub

    Public Sub WriteInt(ByVal adr As Int32, ByVal l As Int32, ByVal val As Int32)
        Dim Bytes(l - 1) As Byte
        Bytes = BitConverter.GetBytes(val)
        Write(adr, Bytes)
    End Sub
End Module