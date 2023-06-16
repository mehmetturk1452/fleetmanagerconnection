Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports S7.Net
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Mobile.Communication.Client
Imports Mobile.Communication.Common
Imports Mobile.Communication
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.IO
Imports System.Net
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Data.DataTable
Imports System.Data.OleDb

Public Class Istasyon_Sensoru_Update
    Public sayac As Integer
    Public client189 = New RobotClient("Robot", IPAddress.Parse("192.168.15.189"), 7171)
    Public client190 = New RobotClient("Robot", IPAddress.Parse("192.168.15.190"), 7171)
    Public client191 = New RobotClient("Robot", IPAddress.Parse("192.168.15.191"), 7171)
    Public client192 = New RobotClient("Robot", IPAddress.Parse("192.168.15.192"), 7171)
    Public client193 = New RobotClient("Robot", IPAddress.Parse("192.168.15.193"), 7171)
    Public client194 = New RobotClient("Robot", IPAddress.Parse("192.168.15.194"), 7171)
    Public client195 = New RobotClient("Robot", IPAddress.Parse("192.168.15.195"), 7171)
    Public client196 = New RobotClient("Robot", IPAddress.Parse("192.168.15.196"), 7171)
    Public client197 = New RobotClient("Robot", IPAddress.Parse("192.168.15.197"), 7171)
    Public client198 = New RobotClient("Robot", IPAddress.Parse("192.168.15.198"), 7171)
    Public client199 = New RobotClient("Robot", IPAddress.Parse("192.168.15.199"), 7171)
    Public client200 = New RobotClient("Robot", IPAddress.Parse("192.168.15.200"), 7171)
    Public client201 = New RobotClient("Robot", IPAddress.Parse("192.168.15.201"), 7171)
    Public client202 = New RobotClient("Robot", IPAddress.Parse("192.168.15.202"), 7171)
    Public client203 = New RobotClient("Robot", IPAddress.Parse("192.168.15.203"), 7171)
    Public robotacik(205)
    Public DeğikenAtamaSQLbaglanti189 As New SqlClient.SqlConnection("Server=192.168.55.240; Database=OrguPlc_Omron;User Id= sa;Password=Sa123Sa")
    Public DeğikenAtamaSQLbaglanti190 As New SqlClient.SqlConnection("Server=192.168.55.240; Database=OrguPlc_Omron;User Id= sa;Password=Sa123Sa")
    Public DeğikenAtamaSQLbaglanti191 As New SqlClient.SqlConnection("Server=192.168.55.240; Database=OrguPlc_Omron;User Id= sa;Password=Sa123Sa")
    Public DeğikenAtamaSQLbaglanti192 As New SqlClient.SqlConnection("Server=192.168.55.240; Database=OrguPlc_Omron;User Id= sa;Password=Sa123Sa")
    Public DeğikenAtamaSQLbaglanti193 As New SqlClient.SqlConnection("Server=192.168.55.240; Database=OrguPlc_Omron;User Id= sa;Password=Sa123Sa")
    Public DeğikenAtamaSQLbaglanti194 As New SqlClient.SqlConnection("Server=192.168.55.240; Database=OrguPlc_Omron;User Id= sa;Password=Sa123Sa")
    Public DeğikenAtamaSQLbaglanti195 As New SqlClient.SqlConnection("Server=192.168.55.240; Database=OrguPlc_Omron;User Id= sa;Password=Sa123Sa")
    Public DeğikenAtamaSQLbaglanti196 As New SqlClient.SqlConnection("Server=192.168.55.240; Database=OrguPlc_Omron;User Id= sa;Password=Sa123Sa")
    Public DeğikenAtamaSQLbaglanti197 As New SqlClient.SqlConnection("Server=192.168.55.240; Database=OrguPlc_Omron;User Id= sa;Password=Sa123Sa")
    Public DeğikenAtamaSQLbaglanti198 As New SqlClient.SqlConnection("Server=192.168.55.240; Database=OrguPlc_Omron;User Id= sa;Password=Sa123Sa")
    Public DeğikenAtamaSQLbaglanti199 As New SqlClient.SqlConnection("Server=192.168.55.240; Database=OrguPlc_Omron;User Id= sa;Password=Sa123Sa")
    Public DeğikenAtamaSQLbaglanti200 As New SqlClient.SqlConnection("Server=192.168.55.240; Database=OrguPlc_Omron;User Id= sa;Password=Sa123Sa")
    Public DeğikenAtamaSQLbaglanti201 As New SqlClient.SqlConnection("Server=192.168.55.240; Database=OrguPlc_Omron;User Id= sa;Password=Sa123Sa")
    Public DeğikenAtamaSQLbaglanti202 As New SqlClient.SqlConnection("Server=192.168.55.240; Database=OrguPlc_Omron;User Id= sa;Password=Sa123Sa")
    Public DeğikenAtamaSQLbaglanti203 As New SqlClient.SqlConnection("Server=192.168.55.240; Database=OrguPlc_Omron;User Id= sa;Password=Sa123Sa")
    Public SqlKomut189 As New SqlClient.SqlCommand
    Public SqlKomut190 As New SqlClient.SqlCommand
    Public SqlKomut191 As New SqlClient.SqlCommand
    Public SqlKomut192 As New SqlClient.SqlCommand
    Public SqlKomut193 As New SqlClient.SqlCommand
    Public SqlKomut194 As New SqlClient.SqlCommand
    Public SqlKomut195 As New SqlClient.SqlCommand
    Public SqlKomut196 As New SqlClient.SqlCommand
    Public SqlKomut197 As New SqlClient.SqlCommand
    Public SqlKomut198 As New SqlClient.SqlCommand
    Public SqlKomut199 As New SqlClient.SqlCommand
    Public SqlKomut200 As New SqlClient.SqlCommand
    Public SqlKomut201 As New SqlClient.SqlCommand
    Public SqlKomut202 As New SqlClient.SqlCommand
    Public SqlKomut203 As New SqlClient.SqlCommand




    Public isguncellebaglanti As New SqlClient.SqlConnection("Server=192.168.55.240; Database=OrguPlc_Omron;User Id= sa;Password=Sa123Sa")
    Public isguncellekomut As New SqlClient.SqlCommand

    Public DoluKonGordusenAdres(80) As String

    Public checkbx(205) As CheckBox

    Private Sub Istasyon_Sensoru_Update_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sayac = 0

        checkbx(189) = CheckBox189
        checkbx(190) = CheckBox190
        checkbx(191) = CheckBox191
        checkbx(192) = CheckBox192
        checkbx(193) = CheckBox193
        checkbx(194) = CheckBox194
        checkbx(195) = CheckBox195
        checkbx(196) = CheckBox196
        checkbx(197) = CheckBox197
        checkbx(198) = CheckBox198
        checkbx(199) = CheckBox199
        checkbx(200) = CheckBox200
        checkbx(201) = CheckBox201
        checkbx(202) = CheckBox202
        checkbx(203) = CheckBox203


        CheckBox1.Checked = True
        CheckBox2.Checked = True
        CheckBox3.Checked = True
        CheckBox4.Checked = True
        CheckBox5.Checked = True
        CheckBox6.Checked = True
        CheckBox7.Checked = True
        CheckBox8.Checked = True
        CheckBox9.Checked = True
        CheckBox10.Checked = True
        CheckBox11.Checked = True
        CheckBox12.Checked = True
        CheckBox13.Checked = True
        CheckBox14.Checked = True
        CheckBox15.Checked = True


    End Sub



    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click





        client189.Password = "1234"
        Try
            client189.Connect()
        Catch
            Label1.Text = "189 a bağlanılamadı"
        End Try
        If client189.connected() Then
            robotacik(189) = True
            checkbx(189).Checked = True
        End If
        client190.Password = "1234"
        Try
            client190.Connect()
        Catch
            Label1.Text = "190 a bağlanılamadı"
        End Try
        If client190.Connected() Then
            robotacik(190) = True
            checkbx(190).Checked = True
        End If
        client191.Password = "1234"
        Try

            client191.Connect()
        Catch
            Label1.Text = "191 a bağlanılamadı"
        End Try
        If client191.Connected() Then
            robotacik(191) = True
            checkbx(191).Checked = True
        End If


        client192.Password = "1234"
        Try

            client192.Connect()
        Catch
            Label1.Text = "192 a bağlanılamadı"
        End Try
        If client192.Connected() Then
            robotacik(192) = True
            checkbx(192).Checked = True
        End If


        client193.Password = "1234"
        Try

            client193.Connect()
        Catch
            Label1.Text = "193 a bağlanılamadı"
        End Try
        If client193.Connected() Then
            robotacik(193) = True
            checkbx(193).Checked = True
        End If


        client194.Password = "1234"
        Try

            client194.Connect()
        Catch
            Label1.Text = "194 a bağlanılamadı"
        End Try
        If client194.Connected() Then
            robotacik(194) = True
            checkbx(194).Checked = True
        End If


        client195.Password = "1234"
        Try

            client195.Connect()
        Catch
            Label1.Text = "195 a bağlanılamadı"
        End Try
        If client195.Connected() Then
            robotacik(195) = True
            checkbx(195).Checked = True
        End If


        client196.Password = "1234"
        Try

            client196.Connect()
        Catch
            Label1.Text = "196 a bağlanılamadı"
        End Try
        If client196.Connected() Then
            robotacik(196) = True
            checkbx(196).Checked = True
        End If


        client197.Password = "1234"
        Try

            client197.Connect()
        Catch
            Label1.Text = "197 a bağlanılamadı"
        End Try
        If client197.Connected() Then
            robotacik(197) = True
            checkbx(197).Checked = True
        End If


        client198.Password = "1234"
        Try

            client198.Connect()
        Catch
            Label1.Text = "198 a bağlanılamadı"
        End Try
        If client198.Connected() Then
            robotacik(198) = True
            checkbx(198).Checked = True
        End If



        client199.Password = "1234"
        Try

            client199.Connect()
        Catch
            Label1.Text = "199 a bağlanılamadı"
        End Try
        If client199.Connected() Then
            robotacik(199) = True
            checkbx(199).Checked = True
        End If


        client200.Password = "1234"
        Try

            client200.Connect()
        Catch
            Label1.Text = "200 a bağlanılamadı"
        End Try
        If client200.Connected() Then
            robotacik(200) = True
            checkbx(200).Checked = True
        End If


        client201.Password = "1234"
        Try

            client201.Connect()
        Catch
            Label1.Text = "201 a bağlanılamadı"
        End Try
        If client201.Connected() Then
            robotacik(201) = True
            checkbx(201).Checked = True
        End If


        client202.Password = "1234"
        Try

            client202.Connect()
        Catch
            Label1.Text = "202 a bağlanılamadı"
        End Try
        If client202.Connected() Then
            robotacik(202) = True
            checkbx(202).Checked = True
        End If


        client203.Password = "1234"
        Try

            client203.Connect()
        Catch
            Label1.Text = "203 a bağlanılamadı"
        End Try
        If client203.Connected() Then
            robotacik(203) = True
            checkbx(203).Checked = True
        End If





        Label1.Text = "Robotlar ve istasyonlar arası haberleşme başlatıldı."

        Timer189.Start()
    End Sub
    Public Async Function plcveyasqlolay(taskgeldi, taskgitti, clientgonderilen, robotnumarasi, baglanti, komut, plc) As Task
        If robotacik(robotnumarasi) Then
            If clientgonderilen.connected() Then


                taskgeldi = Task.Run(Sub()


                                         Dim ex2 As SystemException
                                         Try

                                             clientgonderilen.RefreshOutputCollection()

                                             If clientgonderilen.Outputs("o7").ToString() = "On" Then
                                                 Dim hedef As String
                                                 clientgonderilen.RefreshStatus()


                                                 If clientgonderilen.Status.Status.ToString().Substring(9, 7) <> "DoluKon" Then
                                                 Else
                                                     clientgonderilen.QM.RefreshSegments()
                                                     Dim a As Mobile.Communication.Common.JobCollection
                                                     a = clientgonderilen.QM.Jobs
                                                     Dim b As String
                                                     b = a(0).ID
                                                     Dim jobid As Integer
                                                     Dim ex1 As SystemException

                                                     Try

                                                         baglanti.Open()
                                                         komut.Connection = baglanti
                                                         komut.CommandText = "update [dbo].[Omron_Verilmis_Isler] set Tamamlandi='True',TamamlanmaZamani=getdate(),robotnumarasi='" & robotnumarasi & "' where kimlik='" & b & "'"

                                                         komut.ExecuteNonQuery()
                                                         baglanti.Close()
                                                     Catch
                                                     End Try
                                                 End If
                                             Else

                                             End If
                                         Catch
                                         End Try
                                     End Sub)
                'Task.WaitAll(taskgeldi)
                Await taskgeldi

            Else
                Try
                    clientgonderilen.Connect()
                Catch

                End Try
                If clientgonderilen.connected() Then
                    robotacik(robotnumarasi) = True
                    checkbx(robotnumarasi).Checked = True
                Else
                    robotacik(robotnumarasi) = False
                    checkbx(robotnumarasi).Checked = False
                End If
            End If
        End If
    End Function

    Private Async Sub Timer189_Tick(sender As Object, e As EventArgs) Handles Timer189.Tick
        Dim task189 As Task
        task189 = Task.Run(Sub()
                               Dim taskgeldi189 As Task
                               Dim taskgitti189 As Task
                               Dim clientgonderilen189 = client189
                               Dim robotnumarasi189 As Integer
                               robotnumarasi189 = 189
                               Dim DeğikenAtamaSQLbaglanti189 As New SqlClient.SqlConnection("Server=192.168.55.240; Database=OrguPlc_Omron;User Id= sa;Password=Sa123Sa")
                               Dim SqlKomut189 As New SqlClient.SqlCommand
                               Dim isguncellebaglanti As New SqlClient.SqlConnection("Server=192.168.55.240; Database=OrguPlc_Omron;User Id= sa;Password=Sa123Sa")
                               Dim isguncellekomut As New SqlClient.SqlCommand
                               Dim plc189 As New Plc(CpuType.S71500, "192.168.15.70", 0, 1)
                               plcveyasqlolay(taskgeldi189, taskgitti189, clientgonderilen189, robotnumarasi189, DeğikenAtamaSQLbaglanti189, SqlKomut189, plc189)
                           End Sub)
        'Task.WaitAll(task189)
        Await task189

        Dim task190 As Task
        task190 = Task.Run(Sub()
                               Dim taskgeldi190 As Task
                               Dim taskgitti190 As Task
                               Dim clientgonderilen190 = client190
                               Dim robotnumarasi190 As Integer
                               robotnumarasi190 = 190
                               Dim DeğikenAtamaSQLbaglanti190 As New SqlClient.SqlConnection("Server=192.168.55.240; Database=OrguPlc_Omron;User Id= sa;Password=Sa123Sa")

                               Dim SqlKomut190 As New SqlClient.SqlCommand
                               Dim plc190 As New Plc(CpuType.S71500, "192.168.15.70", 0, 1)

                               plcveyasqlolay(taskgeldi190, taskgitti190, clientgonderilen190, robotnumarasi190, DeğikenAtamaSQLbaglanti190, SqlKomut190, plc190)
                           End Sub)
        'Task.WaitAll(task190)
        Await task190

        Dim task191 As Task
        task191 = Task.Run(Sub()
                               Dim taskgeldi191 As Task
                               Dim taskgitti191 As Task
                               Dim clientgonderilen191 = client191
                               Dim robotnumarasi191 As Integer
                               robotnumarasi191 = 191

                               Dim DeğikenAtamaSQLbaglanti191 As New SqlClient.SqlConnection("Server=192.168.55.240; Database=OrguPlc_Omron;User Id= sa;Password=Sa123Sa")
                               Dim SqlKomut191 As New SqlClient.SqlCommand
                               Dim plc191 As New Plc(CpuType.S71500, "192.168.15.70", 0, 1)
                               plcveyasqlolay(taskgeldi191, taskgitti191, clientgonderilen191, robotnumarasi191, DeğikenAtamaSQLbaglanti191, SqlKomut191, plc191)
                           End Sub)
        'Task.WaitAll(task191)
        Await task191

        Dim task192 As Task
        task192 = Task.Run(Sub()
                               Dim DeğikenAtamaSQLbaglanti192 As New SqlClient.SqlConnection("Server=192.168.55.240; Database=OrguPlc_Omron;User Id= sa;Password=Sa123Sa")
                               Dim SqlKomut192 As New SqlClient.SqlCommand

                               Dim taskgeldi192 As Task
                               Dim taskgitti192 As Task
                               Dim clientgonderilen192 = client192
                               Dim robotnumarasi192 As Integer
                               robotnumarasi192 = 192
                               Dim plc192 As New Plc(CpuType.S71500, "192.168.15.70", 0, 1)
                               plcveyasqlolay(taskgeldi192, taskgitti192, clientgonderilen192, robotnumarasi192, DeğikenAtamaSQLbaglanti192, SqlKomut192, plc192)

                           End Sub)
        'Task.WaitAll(task192)
        Await task192

        Dim task193 As Task
        task193 = Task.Run(Sub()
                               Dim SqlKomut193 As New SqlClient.SqlCommand
                               Dim DeğikenAtamaSQLbaglanti193 As New SqlClient.SqlConnection("Server=192.168.55.240; Database=OrguPlc_Omron;User Id= sa;Password=Sa123Sa")

                               Dim taskgeldi193 As Task
                               Dim taskgitti193 As Task
                               Dim clientgonderilen193 = client193
                               Dim robotnumarasi193 As Integer
                               robotnumarasi193 = 193
                               Dim plc193 As New Plc(CpuType.S71500, "192.168.15.70", 0, 1)
                               plcveyasqlolay(taskgeldi193, taskgitti193, clientgonderilen193, robotnumarasi193, DeğikenAtamaSQLbaglanti193, SqlKomut193, plc193)
                           End Sub)
        'Task.WaitAll(task193)
        Await task193

        Dim task194 As Task
        task194 = Task.Run(Sub()
                               Dim SqlKomut194 As New SqlClient.SqlCommand


                               Dim DeğikenAtamaSQLbaglanti194 As New SqlClient.SqlConnection("Server=192.168.55.240; Database=OrguPlc_Omron;User Id= sa;Password=Sa123Sa")

                               Dim taskgeldi194 As Task
                               Dim taskgitti194 As Task
                               Dim clientgonderilen194 = client194
                               Dim robotnumarasi194 As Integer
                               robotnumarasi194 = 194
                               Dim plc194 As New Plc(CpuType.S71500, "192.168.15.70", 0, 1)
                               plcveyasqlolay(taskgeldi194, taskgitti194, clientgonderilen194, robotnumarasi194, DeğikenAtamaSQLbaglanti194, SqlKomut194, plc194)

                           End Sub)
        'Task.WaitAll(task194)
        Await task194

        Dim task195 As Task
        task195 = Task.Run(Sub()

                               Dim SqlKomut195 As New SqlClient.SqlCommand
                               Dim DeğikenAtamaSQLbaglanti195 As New SqlClient.SqlConnection("Server=192.168.55.240; Database=OrguPlc_Omron;User Id= sa;Password=Sa123Sa")

                               Dim taskgeldi195 As Task
                               Dim taskgitti195 As Task
                               Dim clientgonderilen195 = client195
                               Dim robotnumarasi195 As Integer
                               robotnumarasi195 = 195
                               Dim plc195 As New Plc(CpuType.S71500, "192.168.15.70", 0, 1)
                               plcveyasqlolay(taskgeldi195, taskgitti195, clientgonderilen195, robotnumarasi195, DeğikenAtamaSQLbaglanti195, SqlKomut195, plc195)

                           End Sub)
        'Task.WaitAll(task195)
        Await task195

        Dim task196 As Task
        task196 = Task.Run(Sub()
                               Dim DeğikenAtamaSQLbaglanti196 As New SqlClient.SqlConnection("Server=192.168.55.240; Database=OrguPlc_Omron;User Id= sa;Password=Sa123Sa")
                               Dim SqlKomut196 As New SqlClient.SqlCommand
                               Dim plc196 As New Plc(CpuType.S71500, "192.168.15.70", 0, 1)

                               Dim taskgeldi196 As Task
                               Dim taskgitti196 As Task
                               Dim clientgonderilen196 = client196
                               Dim robotnumarasi196 As Integer
                               robotnumarasi196 = 196
                               plcveyasqlolay(taskgeldi196, taskgitti196, clientgonderilen196, robotnumarasi196, DeğikenAtamaSQLbaglanti196, SqlKomut196, plc196)


                           End Sub)
        'Task.WaitAll(task196)
        Await task196

        Dim task197 As Task
        task197 = Task.Run(Sub()
                               Dim SqlKomut197 As New SqlClient.SqlCommand
                               Dim DeğikenAtamaSQLbaglanti197 As New SqlClient.SqlConnection("Server=192.168.55.240; Database=OrguPlc_Omron;User Id= sa;Password=Sa123Sa")
                               Dim plc197 As New Plc(CpuType.S71500, "192.168.15.70", 0, 1)


                               Dim taskgeldi197 As Task
                               Dim taskgitti197 As Task
                               Dim clientgonderilen197 = client197
                               Dim robotnumarasi197 As Integer
                               robotnumarasi197 = 197
                               plcveyasqlolay(taskgeldi197, taskgitti197, clientgonderilen197, robotnumarasi197, DeğikenAtamaSQLbaglanti197, SqlKomut197, plc197)


                           End Sub)
        'Task.WaitAll(task197)
        Await task197

        Dim task198 As Task
        task198 = Task.Run(Sub()
                               Dim SqlKomut198 As New SqlClient.SqlCommand
                               Dim plc198 As New Plc(CpuType.S71500, "192.168.15.70", 0, 1)

                               Dim DeğikenAtamaSQLbaglanti198 As New SqlClient.SqlConnection("Server=192.168.55.240; Database=OrguPlc_Omron;User Id= sa;Password=Sa123Sa")
                               Dim taskgeldi198 As Task
                               Dim taskgitti198 As Task
                               Dim clientgonderilen198 = client198
                               Dim robotnumarasi198 As Integer
                               robotnumarasi198 = 198
                               plcveyasqlolay(taskgeldi198, taskgitti198, clientgonderilen198, robotnumarasi198, DeğikenAtamaSQLbaglanti198, SqlKomut198, plc198)


                           End Sub)
        'Task.WaitAll(task198)
        Await task198

        Dim task199 As Task
        task199 = Task.Run(Sub()
                               Dim DeğikenAtamaSQLbaglanti199 As New SqlClient.SqlConnection("Server=192.168.55.240; Database=OrguPlc_Omron;User Id= sa;Password=Sa123Sa")

                               Dim SqlKomut199 As New SqlClient.SqlCommand
                               Dim plc199 As New Plc(CpuType.S71500, "192.168.15.70", 0, 1)
                               Dim taskgeldi199 As Task
                               Dim taskgitti199 As Task
                               Dim clientgonderilen199 = client199
                               Dim robotnumarasi199 As Integer
                               robotnumarasi199 = 199
                               plcveyasqlolay(taskgeldi199, taskgitti199, clientgonderilen199, robotnumarasi199, DeğikenAtamaSQLbaglanti199, SqlKomut199, plc199)


                           End Sub)
        'Task.WaitAll(task199)
        Await task199

        Dim task200 As Task
        task200 = Task.Run(Sub()
                               Dim DeğikenAtamaSQLbaglanti200 As New SqlClient.SqlConnection("Server=192.168.55.240; Database=OrguPlc_Omron;User Id= sa;Password=Sa123Sa")
                               Dim SqlKomut200 As New SqlClient.SqlCommand
                               Dim plc200 As New Plc(CpuType.S71500, "192.168.15.70", 0, 1)

                               Dim taskgeldi200 As Task
                               Dim taskgitti200 As Task
                               Dim clientgonderilen200 = client200
                               Dim robotnumarasi200 As Integer
                               robotnumarasi200 = 200
                               plcveyasqlolay(taskgeldi200, taskgitti200, clientgonderilen200, robotnumarasi200, DeğikenAtamaSQLbaglanti200, SqlKomut200, plc200)


                           End Sub)
        'Task.WaitAll(task200)
        Await task200


        Dim task201 As Task
        task201 = Task.Run(Sub()

                               Dim DeğikenAtamaSQLbaglanti201 As New SqlClient.SqlConnection("Server=192.168.55.240; Database=OrguPlc_Omron;User Id= sa;Password=Sa123Sa")
                               Dim plc201 As New Plc(CpuType.S71500, "192.168.15.70", 0, 1)
                               Dim SqlKomut201 As New SqlClient.SqlCommand

                               Dim taskgeldi201 As Task
                               Dim taskgitti201 As Task
                               Dim clientgonderilen201 = client201
                               Dim robotnumarasi201 As Integer
                               robotnumarasi201 = 201
                               plcveyasqlolay(taskgeldi201, taskgitti201, clientgonderilen201, robotnumarasi201, DeğikenAtamaSQLbaglanti201, SqlKomut201, plc201)


                           End Sub)
        'Task.WaitAll(task201)
        Await task201


        Dim task202 As Task
        task202 = Task.Run(Sub()
                               Dim DeğikenAtamaSQLbaglanti202 As New SqlClient.SqlConnection("Server=192.168.55.240; Database=OrguPlc_Omron;User Id= sa;Password=Sa123Sa")
                               Dim plc202 As New Plc(CpuType.S71500, "192.168.15.70", 0, 1)
                               Dim SqlKomut202 As New SqlClient.SqlCommand


                               Dim taskgeldi202 As Task
                               Dim taskgitti202 As Task
                               Dim clientgonderilen202 = client202
                               Dim robotnumarasi202 As Integer
                               robotnumarasi202 = 202
                               plcveyasqlolay(taskgeldi202, taskgitti202, clientgonderilen202, robotnumarasi202, DeğikenAtamaSQLbaglanti202, SqlKomut202, plc202)


                           End Sub)
        'Task.WaitAll(task202)
        Await task202

        Dim task203 As Task
        task203 = Task.Run(Sub()

                               Dim DeğikenAtamaSQLbaglanti203 As New SqlClient.SqlConnection("Server=192.168.55.240; Database=OrguPlc_Omron;User Id= sa;Password=Sa123Sa")
                               Dim SqlKomut203 As New SqlClient.SqlCommand
                               Dim plc203 As New Plc(CpuType.S71500, "192.168.15.70", 0, 1)
                               Dim taskgeldi203 As Task
                               Dim taskgitti203 As Task
                               Dim clientgonderilen203 = client203
                               Dim robotnumarasi203 As Integer
                               robotnumarasi203 = 203
                               plcveyasqlolay(taskgeldi203, taskgitti203, clientgonderilen203, robotnumarasi203, DeğikenAtamaSQLbaglanti203, SqlKomut203, plc203)

                           End Sub)
        'Task.WaitAll(task203)
        Await task203
        'Could 

        sayac += 1
        Label32.Text = sayac

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim client2033 = New RobotClient("toolkitadmin", IPAddress.Parse("192.168.15.206"), 7171)
        client2033.Password = "1234"
        client2033.Connect()
        'client2033.RefreshOutputCollection()
        'client2033.RefreshStatus()
        client2033.QM.RefreshSegments()
        Label32.Text = Label32.Text + 1
        'Dim a As Mobile.Communication.Common.JobCollection
        'a = client2033.QM.Jobs

        'Dim b As String
        'b = a(0).ID
        'Dim jobid As Integer
    End Sub
End Class