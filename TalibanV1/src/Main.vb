Imports System
Imports System.Windows.Forms
Imports System.IO
Imports System.Text

Public Module Main
    Public Declare Function ReadProcessMemory Lib "kernel32" (ByVal hProcess As IntPtr, ByVal lpBaseAddress As IntPtr, ByVal lpBuffer() As Byte, ByVal iSize As Int32, ByRef lpNumberOfBytesRead As Int32) As Boolean
    Public Declare Function WriteProcessMemory Lib "kernel32" (ByVal hProcess As IntPtr, ByVal lpBaseAddress As IntPtr, ByVal lpBuffer As Byte(), ByVal iSize As Int32, ByRef lpNumberOfBytesRead As Int32) As Boolean
    Public Declare Sub keybd_event Lib "user32" (ByVal bVk As Byte, ByVal bScan As Byte, ByVal dwFlags As Long, ByVal dwExtraInfo As Long)
    Public Declare Function CloseHandle Lib "kernel32.dll" (ByVal hObject As IntPtr) As Boolean
    Public PROCESS_ALL_ACCESS As UInt32 = &H1F0FFF
    Public Declare Function OpenProcess Lib "kernel32.dll" (ByVal dwDesiredAcess As UInt32, ByVal bInheritHandle As Boolean, ByVal dwProcessId As Int32) As IntPtr
    Public Declare Sub mouse_event Lib "user32" Alias "mouse_event" (ByVal dwFlags As Int32, ByVal dx As Int32, ByVal dy As Int32, ByVal cButtons As Int32, ByVal dwExtraInfo As Int32)
    Public Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Int32) As Integer

    Public bClient As Integer
    Public bEngine As Integer
    Public menu As New Taliban
    Public csgoHandle As IntPtr
    Public csgoProcess As Process

    Dim thread_radar As System.Threading.Thread = New System.Threading.Thread(AddressOf Radar.Radar)
    Dim thread_trigger As System.Threading.Thread = New System.Threading.Thread(AddressOf Trigger.Trigger)
    Dim thread_bhop As System.Threading.Thread = New System.Threading.Thread(AddressOf Bhop.Bhop)

    Public Sub Main()
        Try
            csgoProcess = Process.GetProcessesByName("csgo")(0)
            csgoHandle = OpenProcess(PROCESS_ALL_ACCESS, False, csgoProcess.Id)
        Catch ex As Exception
            MsgBox("CSGO is not running. Please open CSGO first.", MsgBoxStyle.Exclamation, "Taliban CSGO")
            Environment.Exit(0)
        End Try

        For Each m0d As System.Diagnostics.ProcessModule In csgoProcess.Modules
            If m0d.ModuleName = "engine.dll" Then
                bEngine = m0d.BaseAddress
            End If

            If m0d.ModuleName = "client.dll" Then
                bClient = m0d.BaseAddress
            End If
        Next

        StartThreads()
        Application.Run(menu)
    End Sub

    Private Sub StartThreads()
        thread_bhop.Start()
        thread_radar.Start()
        thread_trigger.Start()
    End Sub
End Module