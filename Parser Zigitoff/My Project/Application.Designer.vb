﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Этот код создан программой.
'     Исполняемая версия:4.0.30319.18052
'
'     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
'     повторной генерации кода.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    'ПРИМЕЧАНИЕ. Этот файл создан автоматически; не изменяйте его самостоятельно. Для внесения изменений
    ' или, если в ходе построения обнаружены ошибки в этом файле, перейдите в конструктор проектов
    ' (перейдите к свойствам проекта или дважды щелкните узел "Мой проект" в
    ' обозревателе решений), и внесите изменения на вкладке "Приложение".
    '
    Partial Friend Class MyApplication
        
        <Global.System.Diagnostics.DebuggerStepThroughAttribute()>  _
        Public Sub New()
            MyBase.New(Global.Microsoft.VisualBasic.ApplicationServices.AuthenticationMode.Windows)
            Me.IsSingleInstance = true
            Me.EnableVisualStyles = true
            Me.SaveMySettingsOnExit = true
            Me.ShutDownStyle = Global.Microsoft.VisualBasic.ApplicationServices.ShutdownMode.AfterMainFormCloses
        End Sub
        
        <Global.System.Diagnostics.DebuggerStepThroughAttribute()>  _
        Protected Overrides Sub OnCreateMainForm()
            Me.MainForm = Global.KAP.Form1
        End Sub
    End Class
End Namespace
