﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("GrapeCity.ActiveReports.Samples.ReportsGallery.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property CmdNewReport() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("CmdNewReport", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property CmdOpen() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("CmdOpen", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property CmdSave() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("CmdSave", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property CmdSaveAs() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("CmdSaveAs", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Untitled.rdlx.
        '''</summary>
        Friend ReadOnly Property DefaultReportNameRdlx() As String
            Get
                Return ResourceManager.GetString("DefaultReportNameRdlx", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Untitled.rpx.
        '''</summary>
        Friend ReadOnly Property DefaultReportNameRpx() As String
            Get
                Return ResourceManager.GetString("DefaultReportNameRpx", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to *.
        '''</summary>
        Friend ReadOnly Property DirtySign() As String
            Get
                Return ResourceManager.GetString("DirtySign", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Exit.
        '''</summary>
        Friend ReadOnly Property ExitText() As String
            Get
                Return ResourceManager.GetString("ExitText", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property GroupEditorHide() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("GroupEditorHide", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property GroupEditorShow() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("GroupEditorShow", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
           
        '''<summary>
        '''  Looks up a localized string similar to Hide Group Editor.
        '''</summary>
        Friend ReadOnly Property HideGroupPanelToolTip() As String
            Get
                Return ResourceManager.GetString("HideGroupPanelToolTip", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to Could not load specified file. Specified File format is not supported.
        '''</summary>
        Friend ReadOnly Property InvalidFileText() As String
            Get
                Return ResourceManager.GetString("InvalidFileText", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to New.
        '''</summary>
        Friend ReadOnly Property NewText() As String
            Get
                Return ResourceManager.GetString("NewText", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Open.
        '''</summary>
        Friend ReadOnly Property OpenText() As String
            Get
                Return ResourceManager.GetString("OpenText", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to rdlx files|*.rdlx.
        '''</summary>
        Friend ReadOnly Property RdlxFilter() As String
            Get
                Return ResourceManager.GetString("RdlxFilter", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Report has been changed! Do you wish to save it?.
        '''</summary>
        Friend ReadOnly Property ReportDirtyMessage() As String
            Get
                Return ResourceManager.GetString("ReportDirtyMessage", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to rpx files|*.rpx.
        '''</summary>
        Friend ReadOnly Property RpxFilter() As String
            Get
                Return ResourceManager.GetString("RpxFilter", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to ReportsGallery - .
        '''</summary>
        Friend ReadOnly Property SampleNameTitle() As String
            Get
                Return ResourceManager.GetString("SampleNameTitle", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Save As.
        '''</summary>
        Friend ReadOnly Property SaveAsText() As String
            Get
                Return ResourceManager.GetString("SaveAsText", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Save.
        '''</summary>
        Friend ReadOnly Property SaveText() As String
            Get
                Return ResourceManager.GetString("SaveText", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Show Group Editor.
        '''</summary>
        Friend ReadOnly Property ShowGroupPanelToolTip As String
            Get
				Return ResourceManager.GetString("ShowGroupPanelToolTip", resourceCulture)
			End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Data.
        '''</summary>
        Friend ReadOnly Property ToolBoxData() As String
            Get
                Return ResourceManager.GetString("ToolBoxData", resourceCulture)
            End Get
        End Property
    End Module
End Namespace
