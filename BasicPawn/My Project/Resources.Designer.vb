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
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Public Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Public ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("BasicPawn.Resources", GetType(Resources).Assembly)
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
        Public Property Culture() As Global.System.Globalization.CultureInfo
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
        Public ReadOnly Property aero_busy() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("aero_busy", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property BasicPawn_NoText_PNGx64() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("BasicPawn_NoText_PNGx64", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property BasicPawnRedTop() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("BasicPawnRedTop", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property Bmp_ButtonDeleteDefault() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Bmp_ButtonDeleteDefault", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property Bmp_ButtonDeleteHover() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Bmp_ButtonDeleteHover", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property Bmp_ButtonDeletePressed() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Bmp_ButtonDeletePressed", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property Bmp_Design() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Bmp_Design", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property Bmp_DriveEncryption() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Bmp_DriveEncryption", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property Bmp_Network() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Bmp_Network", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property Bmp_ShieldWarn() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Bmp_ShieldWarn", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property Bmp_Stop() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Bmp_Stop", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property Bmp_Warn() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Bmp_Warn", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to stock any {FunctionName}(any val=0)
        '''{
        '''	if(FileExists(&quot;{IndentifierGUID}.ignore.bpdebug&quot;))
        '''	{
        '''		return val;
        '''	}
        '''	
        '''	Handle hTriggerFile = OpenFile(&quot;{IndentifierGUID}.trigger.bpdebug&quot;, &quot;w&quot;);
        '''	if(hTriggerFile == INVALID_HANDLE)
        '''		return val;
        '''	
        '''	WriteFileLine(hTriggerFile, &quot;i:%d&quot;, val);
        '''	WriteFileLine(hTriggerFile, &quot;f:%f&quot;, val);
        '''	FlushFile(hTriggerFile);
        '''	CloseHandle(hTriggerFile);
        '''	
        '''	for(;;)
        '''	{
        '''		if(FileExists(&quot;{IndentifierGUID}.continue.bpdebug&quot;))
        '''		{
        '''			DeleteFile(&quot;{IndentifierGUID}.continu [rest of string was truncated]&quot;;.
        '''</summary>
        Public ReadOnly Property Debugger_BreakpointModuleNew() As String
            Get
                Return ResourceManager.GetString("Debugger_BreakpointModuleNew", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to stock any:{FunctionName}(any:val=0)
        '''{
        '''	if(FileExists(&quot;{IndentifierGUID}.ignore.bpdebug&quot;))
        '''	{
        '''		return val;
        '''	}
        '''	
        '''	new Handle:hTriggerFile = OpenFile(&quot;{IndentifierGUID}.trigger.bpdebug&quot;, &quot;w&quot;);
        '''	if(hTriggerFile == INVALID_HANDLE)
        '''		return val;
        '''	
        '''	WriteFileLine(hTriggerFile, &quot;i:%d&quot;, val);
        '''	WriteFileLine(hTriggerFile, &quot;f:%f&quot;, val);
        '''	FlushFile(hTriggerFile);
        '''	CloseHandle(hTriggerFile);
        '''	
        '''	for(;;)
        '''	{
        '''		if(FileExists(&quot;{IndentifierGUID}.continue.bpdebug&quot;))
        '''		{
        '''			DeleteFile(&quot;{IndentifierGUID}.con [rest of string was truncated]&quot;;.
        '''</summary>
        Public ReadOnly Property Debugger_BreakpointModuleOld() As String
            Get
                Return ResourceManager.GetString("Debugger_BreakpointModuleOld", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to #pragma semicolon 1
        '''
        '''#include &lt;sourcemod&gt;
        '''
        '''#define TIMER_DELAY 5
        '''#define ENTITY_FULL_UPDATE_TIME 60.0
        '''#define MAXENTITIES 2048
        '''
        '''static Handle:g_hTimer;
        '''static String:g_sReloadMapName[PLATFORM_MAX_PATH];
        '''
        '''enum EntityDebuggerAction
        '''{
        '''	Action_Update,
        '''	Action_Remove,
        '''}
        '''
        '''public Plugin:myinfo =
        '''{
        '''	name = &quot;BasicPawn Debugger Module Runner&quot;,
        '''	author = &quot;Timocop&quot;,
        '''	description = &quot;BasicPawn debugger module which communicates with the debugger.&quot;,
        '''	version = &quot;1.0&quot;,
        '''	url = &quot;&quot;
        '''};
        '''
        '''public OnPlugin [rest of string was truncated]&quot;;.
        '''</summary>
        Public ReadOnly Property Debugger_CommandRunnerEngineOld() As String
            Get
                Return ResourceManager.GetString("Debugger_CommandRunnerEngineOld", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to stock any {FunctionName}(any val=0)
        '''{
        '''	static int iCount;
        '''	iCount++;
        '''
        '''	Handle hValFile = OpenFile(&quot;{IndentifierGUID}.value.bpdebug&quot;, &quot;w&quot;);
        '''	if(hValFile == INVALID_HANDLE)
        '''		return val;
        '''	
        '''	WriteFileLine(hValFile, &quot;i:%d&quot;, val);
        '''	WriteFileLine(hValFile, &quot;f:%f&quot;, val);
        '''	WriteFileLine(hValFile, &quot;c:%d&quot;, iCount);
        '''	FlushFile(hValFile);
        '''	CloseHandle(hValFile);
        '''	
        '''	return val;
        '''}.
        '''</summary>
        Public ReadOnly Property Debugger_WatcherModuleNew() As String
            Get
                Return ResourceManager.GetString("Debugger_WatcherModuleNew", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to stock any:{FunctionName}(any:val=0)
        '''{
        '''	static iCount;
        '''	iCount++;
        '''
        '''	new Handle:hValFile = OpenFile(&quot;{IndentifierGUID}.value.bpdebug&quot;, &quot;w&quot;);
        '''	if(hValFile == INVALID_HANDLE)
        '''		return val;
        '''	
        '''	WriteFileLine(hValFile, &quot;i:%d&quot;, val);
        '''	WriteFileLine(hValFile, &quot;f:%f&quot;, val);
        '''	WriteFileLine(hValFile, &quot;c:%d&quot;, iCount);
        '''	FlushFile(hValFile);
        '''	CloseHandle(hValFile);
        '''	
        '''	return val;
        '''}.
        '''</summary>
        Public ReadOnly Property Debugger_WatcherModuleOld() As String
            Get
                Return ResourceManager.GetString("Debugger_WatcherModuleOld", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        '''</summary>
        Public ReadOnly Property Ico_Folder() As System.Drawing.Icon
            Get
                Dim obj As Object = ResourceManager.GetObject("Ico_Folder", resourceCulture)
                Return CType(obj,System.Drawing.Icon)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        '''</summary>
        Public ReadOnly Property Ico_Rtf() As System.Drawing.Icon
            Get
                Dim obj As Object = ResourceManager.GetObject("Ico_Rtf", resourceCulture)
                Return CType(obj,System.Drawing.Icon)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property imageres_5301_16x16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("imageres_5301_16x16", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property imageres_5302_16x16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("imageres_5302_16x16", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property imageres_5303_16x16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("imageres_5303_16x16", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property imageres_5304_16x16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("imageres_5304_16x16", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property imageres_5306_16x16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("imageres_5306_16x16", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property imageres_5311_16x16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("imageres_5311_16x16", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property imageres_5312_16x16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("imageres_5312_16x16", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property imageres_5313_16x16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("imageres_5313_16x16", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property imageres_5314_16x16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("imageres_5314_16x16", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property imageres_5315_16x16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("imageres_5315_16x16", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property imageres_5316_16x16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("imageres_5316_16x16", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property imageres_5318_16x16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("imageres_5318_16x16", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property imageres_5320_16x16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("imageres_5320_16x16", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property imageres_5321_16x16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("imageres_5321_16x16", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property imageres_5326_16x16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("imageres_5326_16x16", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property imageres_5332_16x16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("imageres_5332_16x16", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property imageres_5333_16x16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("imageres_5333_16x16", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property imageres_5337_16x16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("imageres_5337_16x16", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property imageres_5338_16x16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("imageres_5338_16x16", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property imageres_5339_16x16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("imageres_5339_16x16", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property imageres_5341_16x16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("imageres_5341_16x16", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property imageres_5342_16x16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("imageres_5342_16x16", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property imageres_5343_16x16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("imageres_5343_16x16", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property imageres_5348_16x16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("imageres_5348_16x16", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property imageres_5350_16x16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("imageres_5350_16x16", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property imageres_5351_16x16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("imageres_5351_16x16", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property imageres_5356_16x16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("imageres_5356_16x16", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property imageres_5357_16x16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("imageres_5357_16x16", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property imageres_5360_16x16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("imageres_5360_16x16", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property imageres_5364_16x16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("imageres_5364_16x16", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property imageres_5367_16x16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("imageres_5367_16x16", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property imageres_5368_16x16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("imageres_5368_16x16", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property imageres_5372_16x16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("imageres_5372_16x16", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot;?&gt;
        '''&lt;SyntaxDefinition name=&quot;SourcePawn-04e3632f-5472-42c5-929a-c3e0c2b35324&quot; extensions=&quot;.sp&quot;&gt;
        '''    &lt;Environment&gt;
        '''        &lt;Default color=&quot;Black&quot; bgcolor=&quot;White&quot;/&gt;
        '''        &lt;Selection color=&quot;White&quot; bgcolor=&quot;RoyalBlue&quot;/&gt;
        '''        &lt;VRuler color=&quot;DarkGray&quot;/&gt;
        '''        &lt;InvalidLines color=&quot;Red&quot;/&gt;
        '''        &lt;CaretMarker color=&quot;LightCyan&quot;/&gt;
        '''        &lt;LineNumbers color=&quot;Gray&quot; bgcolor=&quot;White&quot;/&gt;
        '''        &lt;FoldLine color=&quot;LightGray&quot; bgcolor=&quot;White&quot;/&gt;
        '''        &lt;FoldMarker color=&quot;DarkGray&quot; bgcolor=&quot;Whi [rest of string was truncated]&quot;;.
        '''</summary>
        Public ReadOnly Property SourcePawn_Syntax() As String
            Get
                Return ResourceManager.GetString("SourcePawn_Syntax", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to ; WARNING
        '''; This file should not be read/overwritten by standard ini parsers!
        ''';
        ''';	Type info:
        ''';		$ = Default string replace.
        ''';		? = (Two names required) Boolean, first string replace if TRUE, second string replace if FALSE and the third is the default value 0/1.
        ''';		# = (More than one name required) List, multiple string replace choices.
        ''';
        ''';	Properties info:
        ''';		{&lt;TYPE&gt;NAME,DESCRIPTION[,ITEM_DESCRIPTION]}
        ''';		{$PropertyName,The name of the property} = First argument is the name which will be replaced. [rest of string was truncated]&quot;;.
        '''</summary>
        Public ReadOnly Property Template_AMXModXInclude() As String
            Get
                Return ResourceManager.GetString("Template_AMXModXInclude", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to ; WARNING
        '''; This file should not be read/overwritten by standard ini parsers!
        ''';
        ''';	Type info:
        ''';		$ = Default string replace.
        ''';		? = (Two names required) Boolean, first string replace if TRUE, second string replace if FALSE and the third is the default value 0/1.
        ''';		# = (More than one name required) List, multiple string replace choices.
        ''';
        ''';	Properties info:
        ''';		{&lt;TYPE&gt;NAME,DESCRIPTION[,ITEM_DESCRIPTION]}
        ''';		{$PropertyName,The name of the property} = First argument is the name which will be replaced. [rest of string was truncated]&quot;;.
        '''</summary>
        Public ReadOnly Property Template_AMXModXLibraryInclude() As String
            Get
                Return ResourceManager.GetString("Template_AMXModXLibraryInclude", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to ; WARNING
        '''; This file should not be read/overwritten by standard ini parsers!
        ''';
        ''';	Type info:
        ''';		$ = Default string replace.
        ''';		? = (Two names required) Boolean, first string replace if TRUE, second string replace if FALSE and the third is the default value 0/1.
        ''';		# = (More than one name required) List, multiple string replace choices.
        ''';
        ''';	Properties info:
        ''';		{&lt;TYPE&gt;NAME,DESCRIPTION[,ITEM_DESCRIPTION]}
        ''';		{$PropertyName,The name of the property} = First argument is the name which will be replaced. [rest of string was truncated]&quot;;.
        '''</summary>
        Public ReadOnly Property Template_AMXModXModuleInclude() As String
            Get
                Return ResourceManager.GetString("Template_AMXModXModuleInclude", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to ; WARNING
        '''; This file should not be read/overwritten by standard ini parsers!
        ''';
        ''';	Type info:
        ''';		$ = Default string replace.
        ''';		? = (Two names required) Boolean, first string replace if TRUE, second string replace if FALSE and the third is the default value 0/1.
        ''';		# = (More than one name required) List, multiple string replace choices.
        ''';
        ''';	Properties info:
        ''';		{&lt;TYPE&gt;NAME,DESCRIPTION[,ITEM_DESCRIPTION]}
        ''';		{$PropertyName,The name of the property} = First argument is the name which will be replaced. [rest of string was truncated]&quot;;.
        '''</summary>
        Public ReadOnly Property Template_AMXModXPlugin() As String
            Get
                Return ResourceManager.GetString("Template_AMXModXPlugin", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to ; WARNING
        '''; This file should not be read/overwritten by standard ini parsers!
        ''';
        ''';	Type info:
        ''';		$ = Default string replace.
        ''';		? = (Two names required) Boolean, first string replace if TRUE, second string replace if FALSE and the third is the default value 0/1.
        ''';		# = (More than one name required) List, multiple string replace choices.
        ''';
        ''';	Properties info:
        ''';		{&lt;TYPE&gt;NAME,DESCRIPTION[,ITEM_DESCRIPTION]}
        ''';		{$PropertyName,The name of the property} = First argument is the name which will be replaced. [rest of string was truncated]&quot;;.
        '''</summary>
        Public ReadOnly Property Template_Include() As String
            Get
                Return ResourceManager.GetString("Template_Include", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to ; WARNING
        '''; This file should not be read/overwritten by standard ini parsers!
        ''';
        ''';	Type info:
        ''';		$ = Default string replace.
        ''';		? = (Two names required) Boolean, first string replace if TRUE, second string replace if FALSE and the third is the default value 0/1.
        ''';		# = (More than one name required) List, multiple string replace choices.
        ''';
        ''';	Properties info:
        ''';		{&lt;TYPE&gt;NAME,DESCRIPTION[,ITEM_DESCRIPTION]}
        ''';		{$PropertyName,The name of the property} = First argument is the name which will be replaced. [rest of string was truncated]&quot;;.
        '''</summary>
        Public ReadOnly Property Template_SourcePawnNewExtensionInclude() As String
            Get
                Return ResourceManager.GetString("Template_SourcePawnNewExtensionInclude", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to ; WARNING
        '''; This file should not be read/overwritten by standard ini parsers!
        ''';
        ''';	Type info:
        ''';		$ = Default string replace.
        ''';		? = (Two names required) Boolean, first string replace if TRUE, second string replace if FALSE and the third is the default value 0/1.
        ''';		# = (More than one name required) List, multiple string replace choices.
        ''';
        ''';	Properties info:
        ''';		{&lt;TYPE&gt;NAME,DESCRIPTION[,ITEM_DESCRIPTION]}
        ''';		{$PropertyName,The name of the property} = First argument is the name which will be replaced. [rest of string was truncated]&quot;;.
        '''</summary>
        Public ReadOnly Property Template_SourcePawnNewPlugin() As String
            Get
                Return ResourceManager.GetString("Template_SourcePawnNewPlugin", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to ; WARNING
        '''; This file should not be read/overwritten by standard ini parsers!
        ''';
        ''';	Type info:
        ''';		$ = Default string replace.
        ''';		? = (Two names required) Boolean, first string replace if TRUE, second string replace if FALSE and the third is the default value 0/1.
        ''';		# = (More than one name required) List, multiple string replace choices.
        ''';
        ''';	Properties info:
        ''';		{&lt;TYPE&gt;NAME,DESCRIPTION[,ITEM_DESCRIPTION]}
        ''';		{$PropertyName,The name of the property} = First argument is the name which will be replaced. [rest of string was truncated]&quot;;.
        '''</summary>
        Public ReadOnly Property Template_SourcePawnNewSharedPluginInclude() As String
            Get
                Return ResourceManager.GetString("Template_SourcePawnNewSharedPluginInclude", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to ; WARNING
        '''; This file should not be read/overwritten by standard ini parsers!
        ''';
        ''';	Type info:
        ''';		$ = Default string replace.
        ''';		? = (Two names required) Boolean, first string replace if TRUE, second string replace if FALSE and the third is the default value 0/1.
        ''';		# = (More than one name required) List, multiple string replace choices.
        ''';
        ''';	Properties info:
        ''';		{&lt;TYPE&gt;NAME,DESCRIPTION[,ITEM_DESCRIPTION]}
        ''';		{$PropertyName,The name of the property} = First argument is the name which will be replaced. [rest of string was truncated]&quot;;.
        '''</summary>
        Public ReadOnly Property Template_SourcePawnOldExtensionInclude() As String
            Get
                Return ResourceManager.GetString("Template_SourcePawnOldExtensionInclude", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to ; WARNING
        '''; This file should not be read/overwritten by standard ini parsers!
        ''';
        ''';	Type info:
        ''';		$ = Default string replace.
        ''';		? = (Two names required) Boolean, first string replace if TRUE, second string replace if FALSE and the third is the default value 0/1.
        ''';		# = (More than one name required) List, multiple string replace choices.
        ''';
        ''';	Properties info:
        ''';		{&lt;TYPE&gt;NAME,DESCRIPTION[,ITEM_DESCRIPTION]}
        ''';		{$PropertyName,The name of the property} = First argument is the name which will be replaced. [rest of string was truncated]&quot;;.
        '''</summary>
        Public ReadOnly Property Template_SourcePawnOldPlugin() As String
            Get
                Return ResourceManager.GetString("Template_SourcePawnOldPlugin", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to ; WARNING
        '''; This file should not be read/overwritten by standard ini parsers!
        ''';
        ''';	Type info:
        ''';		$ = Default string replace.
        ''';		? = (Two names required) Boolean, first string replace if TRUE, second string replace if FALSE and the third is the default value 0/1.
        ''';		# = (More than one name required) List, multiple string replace choices.
        ''';
        ''';	Properties info:
        ''';		{&lt;TYPE&gt;NAME,DESCRIPTION[,ITEM_DESCRIPTION]}
        ''';		{$PropertyName,The name of the property} = First argument is the name which will be replaced. [rest of string was truncated]&quot;;.
        '''</summary>
        Public ReadOnly Property Template_SourcePawnOldSharedPluginInclude() As String
            Get
                Return ResourceManager.GetString("Template_SourcePawnOldSharedPluginInclude", resourceCulture)
            End Get
        End Property
    End Module
End Namespace
