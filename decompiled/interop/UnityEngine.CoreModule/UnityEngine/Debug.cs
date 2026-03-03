using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine;

public class Debug : Il2CppSystem.Object
{
	private delegate void DebugBreakDelegate();

	private delegate void ClearDeveloperConsoleDelegate();

	private delegate bool get_developerConsoleEnabledDelegate();

	private delegate void set_developerConsoleEnabledDelegate(bool value);

	private delegate bool get_developerConsoleVisibleDelegate();

	private delegate void set_developerConsoleVisibleDelegate(bool value);

	private delegate System.IntPtr get_diagnosticSwitchesDelegate();

	private delegate bool IsValidationLevelEnabledDelegate(ValidationLevel level);

	private delegate void CheckIntegrity_InjectedDelegate(IntegrityCheckLevel level, [Out] System.IntPtr ret);

	private static readonly System.IntPtr NativeFieldInfoPtr_s_DefaultLogger;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_Logger;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_unityLogger_Public_Static_get_ILogger_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawLine_Public_Static_Void_Vector3_Vector3_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawLine_Public_Static_Void_Vector3_Vector3_Color_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Break_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExtractStackTraceNoAlloc_Public_Static_Int32_ptr_Byte_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Log_Public_Static_Void_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Log_Public_Static_Void_Object_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LogFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LogFormat_Public_Static_Void_LogType_LogOption_Object_String_Il2CppReferenceArray_1_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LogError_Public_Static_Void_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LogError_Public_Static_Void_Object_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LogErrorFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LogErrorFormat_Public_Static_Void_Object_String_Il2CppReferenceArray_1_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LogException_Public_Static_Void_Exception_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LogException_Public_Static_Void_Exception_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LogWarning_Public_Static_Void_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LogWarning_Public_Static_Void_Object_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LogWarningFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LogWarningFormat_Public_Static_Void_Object_String_Il2CppReferenceArray_1_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Assert_Public_Static_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Assert_Public_Static_Void_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LogAssertion_Public_Static_Void_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LogAssertionFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isDebugBuild_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallOverridenDebugHandler_Internal_Static_Boolean_Exception_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsLoggingEnabled_Internal_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawLine_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_byref_Color_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExtractStackTraceNoAlloc_Injected_Private_Static_Int32_ptr_Byte_Int32_byref_ManagedSpanWrapper_0;

	private static readonly DebugBreakDelegate DebugBreakDelegateField;

	private static readonly ClearDeveloperConsoleDelegate ClearDeveloperConsoleDelegateField;

	private static readonly get_developerConsoleEnabledDelegate get_developerConsoleEnabledDelegateField;

	private static readonly set_developerConsoleEnabledDelegate set_developerConsoleEnabledDelegateField;

	private static readonly get_developerConsoleVisibleDelegate get_developerConsoleVisibleDelegateField;

	private static readonly set_developerConsoleVisibleDelegate set_developerConsoleVisibleDelegateField;

	private static readonly get_diagnosticSwitchesDelegate get_diagnosticSwitchesDelegateField;

	private static readonly IsValidationLevelEnabledDelegate IsValidationLevelEnabledDelegateField;

	private static readonly CheckIntegrity_InjectedDelegate CheckIntegrity_InjectedDelegateField;

	public unsafe static ILogger s_DefaultLogger
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_DefaultLogger, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ILogger>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_DefaultLogger, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static ILogger s_Logger
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_Logger, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ILogger>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_Logger, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static ILogger unityLogger
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169417, XrefRangeEnd = 1169421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_unityLogger_Public_Static_get_ILogger_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ILogger>(intPtr2) : null;
		}
	}

	public unsafe static bool isDebugBuild
	{
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 1170511, RefRangeEnd = 1170524, XrefRangeStart = 1170509, XrefRangeEnd = 1170511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isDebugBuild_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public static bool developerConsoleEnabled
	{
		get
		{
			return get_developerConsoleEnabledDelegateField();
		}
		set
		{
			set_developerConsoleEnabledDelegateField(value);
		}
	}

	public static bool developerConsoleVisible
	{
		get
		{
			return get_developerConsoleVisibleDelegateField();
		}
		set
		{
			set_developerConsoleVisibleDelegateField(value);
		}
	}

	public static Il2CppReferenceArray<DiagnosticSwitch> diagnosticSwitches
	{
		get
		{
			System.IntPtr intPtr = get_diagnosticSwitchesDelegateField();
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DiagnosticSwitch>>(intPtr) : null;
		}
	}

	public static ILogger logger => s_Logger;

	static Debug()
	{
		Il2CppClassPointerStore<Debug>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Debug");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Debug>.NativeClassPtr);
		NativeFieldInfoPtr_s_DefaultLogger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Debug>.NativeClassPtr, "s_DefaultLogger");
		NativeFieldInfoPtr_s_Logger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Debug>.NativeClassPtr, "s_Logger");
		NativeMethodInfoPtr_get_unityLogger_Public_Static_get_ILogger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664064);
		NativeMethodInfoPtr_DrawLine_Public_Static_Void_Vector3_Vector3_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664065);
		NativeMethodInfoPtr_DrawLine_Public_Static_Void_Vector3_Vector3_Color_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664066);
		NativeMethodInfoPtr_Break_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664067);
		NativeMethodInfoPtr_ExtractStackTraceNoAlloc_Public_Static_Int32_ptr_Byte_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664068);
		NativeMethodInfoPtr_Log_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664069);
		NativeMethodInfoPtr_Log_Public_Static_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664070);
		NativeMethodInfoPtr_LogFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664071);
		NativeMethodInfoPtr_LogFormat_Public_Static_Void_LogType_LogOption_Object_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664072);
		NativeMethodInfoPtr_LogError_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664073);
		NativeMethodInfoPtr_LogError_Public_Static_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664074);
		NativeMethodInfoPtr_LogErrorFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664075);
		NativeMethodInfoPtr_LogErrorFormat_Public_Static_Void_Object_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664076);
		NativeMethodInfoPtr_LogException_Public_Static_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664077);
		NativeMethodInfoPtr_LogException_Public_Static_Void_Exception_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664078);
		NativeMethodInfoPtr_LogWarning_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664079);
		NativeMethodInfoPtr_LogWarning_Public_Static_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664080);
		NativeMethodInfoPtr_LogWarningFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664081);
		NativeMethodInfoPtr_LogWarningFormat_Public_Static_Void_Object_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664082);
		NativeMethodInfoPtr_Assert_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664083);
		NativeMethodInfoPtr_Assert_Public_Static_Void_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664084);
		NativeMethodInfoPtr_LogAssertion_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664085);
		NativeMethodInfoPtr_LogAssertionFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664086);
		NativeMethodInfoPtr_get_isDebugBuild_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664087);
		NativeMethodInfoPtr_CallOverridenDebugHandler_Internal_Static_Boolean_Exception_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664088);
		NativeMethodInfoPtr_IsLoggingEnabled_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664089);
		NativeMethodInfoPtr_DrawLine_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_byref_Color_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664091);
		NativeMethodInfoPtr_ExtractStackTraceNoAlloc_Injected_Private_Static_Int32_ptr_Byte_Int32_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100664092);
		DebugBreakDelegateField = IL2CPP.ResolveICall<DebugBreakDelegate>("UnityEngine.Debug::DebugBreak");
		ClearDeveloperConsoleDelegateField = IL2CPP.ResolveICall<ClearDeveloperConsoleDelegate>("UnityEngine.Debug::ClearDeveloperConsole");
		get_developerConsoleEnabledDelegateField = IL2CPP.ResolveICall<get_developerConsoleEnabledDelegate>("UnityEngine.Debug::get_developerConsoleEnabled");
		set_developerConsoleEnabledDelegateField = IL2CPP.ResolveICall<set_developerConsoleEnabledDelegate>("UnityEngine.Debug::set_developerConsoleEnabled");
		get_developerConsoleVisibleDelegateField = IL2CPP.ResolveICall<get_developerConsoleVisibleDelegate>("UnityEngine.Debug::get_developerConsoleVisible");
		set_developerConsoleVisibleDelegateField = IL2CPP.ResolveICall<set_developerConsoleVisibleDelegate>("UnityEngine.Debug::set_developerConsoleVisible");
		get_diagnosticSwitchesDelegateField = IL2CPP.ResolveICall<get_diagnosticSwitchesDelegate>("UnityEngine.Debug::get_diagnosticSwitches");
		IsValidationLevelEnabledDelegateField = IL2CPP.ResolveICall<IsValidationLevelEnabledDelegate>("UnityEngine.Debug::IsValidationLevelEnabled");
		CheckIntegrity_InjectedDelegateField = IL2CPP.ResolveICall<CheckIntegrity_InjectedDelegate>("UnityEngine.Debug::CheckIntegrity_Injected");
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1169429, RefRangeEnd = 1169430, XrefRangeStart = 1169421, XrefRangeEnd = 1169429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DrawLine(Vector3 start, Vector3 end, Color color)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&start);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		*(Color**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &color;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawLine_Public_Static_Void_Vector3_Vector3_Color_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169430, XrefRangeEnd = 1169435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DrawLine(Vector3 start, Vector3 end, Color color, float duration, bool depthTest)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&start);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		*(Color**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &color;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &duration;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &depthTest;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawLine_Public_Static_Void_Vector3_Vector3_Color_Single_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1169437, RefRangeEnd = 1169438, XrefRangeStart = 1169435, XrefRangeEnd = 1169437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Break()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Break_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1169455, RefRangeEnd = 1169456, XrefRangeStart = 1169438, XrefRangeEnd = 1169455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ExtractStackTraceNoAlloc(byte* buffer, int bufferMax, string projectFolder)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)buffer;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bufferMax;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(projectFolder);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExtractStackTraceNoAlloc_Public_Static_Int32_ptr_Byte_Int32_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(87)]
	[CachedScanResults(RefRangeStart = 1169466, RefRangeEnd = 1169553, XrefRangeStart = 1169456, XrefRangeEnd = 1169466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Log(Il2CppSystem.Object message)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)message);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Log_Public_Static_Void_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1169563, RefRangeEnd = 1169566, XrefRangeStart = 1169553, XrefRangeEnd = 1169563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Log(Il2CppSystem.Object message, Object context)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)message);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)context);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Log_Public_Static_Void_Object_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1169576, RefRangeEnd = 1169579, XrefRangeStart = 1169566, XrefRangeEnd = 1169576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LogFormat(string format, [Optional] Il2CppReferenceArray<Il2CppSystem.Object> args)
	{
		if (args == null)
		{
			args = new Il2CppReferenceArray<Il2CppSystem.Object>(0L);
		}
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)args);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LogFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1169602, RefRangeEnd = 1169603, XrefRangeStart = 1169579, XrefRangeEnd = 1169602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LogFormat(LogType logType, LogOption logOptions, Object context, string format, [Optional] Il2CppReferenceArray<Il2CppSystem.Object> args)
	{
		if (args == null)
		{
			args = new Il2CppReferenceArray<Il2CppSystem.Object>(0L);
		}
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&logType);
		*(LogOption**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &logOptions;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)context);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(format);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)args);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LogFormat_Public_Static_Void_LogType_LogOption_Object_String_Il2CppReferenceArray_1_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(194)]
	[CachedScanResults(RefRangeStart = 1169613, RefRangeEnd = 1169807, XrefRangeStart = 1169603, XrefRangeEnd = 1169613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LogError(Il2CppSystem.Object message)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)message);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LogError_Public_Static_Void_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(22)]
	[CachedScanResults(RefRangeStart = 1169817, RefRangeEnd = 1169839, XrefRangeStart = 1169807, XrefRangeEnd = 1169817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LogError(Il2CppSystem.Object message, Object context)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)message);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)context);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LogError_Public_Static_Void_Object_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(20)]
	[CachedScanResults(RefRangeStart = 1169849, RefRangeEnd = 1169869, XrefRangeStart = 1169839, XrefRangeEnd = 1169849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LogErrorFormat(string format, [Optional] Il2CppReferenceArray<Il2CppSystem.Object> args)
	{
		if (args == null)
		{
			args = new Il2CppReferenceArray<Il2CppSystem.Object>(0L);
		}
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)args);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LogErrorFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1169879, RefRangeEnd = 1169883, XrefRangeStart = 1169869, XrefRangeEnd = 1169879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LogErrorFormat(Object context, string format, [Optional] Il2CppReferenceArray<Il2CppSystem.Object> args)
	{
		if (args == null)
		{
			args = new Il2CppReferenceArray<Il2CppSystem.Object>(0L);
		}
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)context);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(format);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)args);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LogErrorFormat_Public_Static_Void_Object_String_Il2CppReferenceArray_1_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(39)]
	[CachedScanResults(RefRangeStart = 1169893, RefRangeEnd = 1169932, XrefRangeStart = 1169883, XrefRangeEnd = 1169893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LogException(Il2CppSystem.Exception exception)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)exception);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LogException_Public_Static_Void_Exception_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1169942, RefRangeEnd = 1169948, XrefRangeStart = 1169932, XrefRangeEnd = 1169942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LogException(Il2CppSystem.Exception exception, Object context)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)exception);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)context);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LogException_Public_Static_Void_Exception_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(140)]
	[CachedScanResults(RefRangeStart = 1169958, RefRangeEnd = 1170098, XrefRangeStart = 1169948, XrefRangeEnd = 1169958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LogWarning(Il2CppSystem.Object message)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)message);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LogWarning_Public_Static_Void_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(28)]
	[CachedScanResults(RefRangeStart = 1170108, RefRangeEnd = 1170136, XrefRangeStart = 1170098, XrefRangeEnd = 1170108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LogWarning(Il2CppSystem.Object message, Object context)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)message);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)context);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LogWarning_Public_Static_Void_Object_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 1170146, RefRangeEnd = 1170154, XrefRangeStart = 1170136, XrefRangeEnd = 1170146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LogWarningFormat(string format, [Optional] Il2CppReferenceArray<Il2CppSystem.Object> args)
	{
		if (args == null)
		{
			args = new Il2CppReferenceArray<Il2CppSystem.Object>(0L);
		}
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)args);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LogWarningFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1170164, RefRangeEnd = 1170166, XrefRangeStart = 1170154, XrefRangeEnd = 1170164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LogWarningFormat(Object context, string format, [Optional] Il2CppReferenceArray<Il2CppSystem.Object> args)
	{
		if (args == null)
		{
			args = new Il2CppReferenceArray<Il2CppSystem.Object>(0L);
		}
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)context);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(format);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)args);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LogWarningFormat_Public_Static_Void_Object_String_Il2CppReferenceArray_1_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(237)]
	[CachedScanResults(RefRangeStart = 1170178, RefRangeEnd = 1170415, XrefRangeStart = 1170166, XrefRangeEnd = 1170178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Assert(bool condition)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&condition);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Assert_Public_Static_Void_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(55)]
	[CachedScanResults(RefRangeStart = 1170425, RefRangeEnd = 1170480, XrefRangeStart = 1170415, XrefRangeEnd = 1170425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Assert(bool condition, string message)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&condition);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(message);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Assert_Public_Static_Void_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 1170490, RefRangeEnd = 1170497, XrefRangeStart = 1170480, XrefRangeEnd = 1170490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LogAssertion(Il2CppSystem.Object message)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)message);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LogAssertion_Public_Static_Void_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1170507, RefRangeEnd = 1170509, XrefRangeStart = 1170497, XrefRangeEnd = 1170507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LogAssertionFormat(string format, [Optional] Il2CppReferenceArray<Il2CppSystem.Object> args)
	{
		if (args == null)
		{
			args = new Il2CppReferenceArray<Il2CppSystem.Object>(0L);
		}
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)args);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LogAssertionFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170524, XrefRangeEnd = 1170545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CallOverridenDebugHandler(Il2CppSystem.Exception exception, Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)exception);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CallOverridenDebugHandler_Internal_Static_Boolean_Exception_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170545, XrefRangeEnd = 1170569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsLoggingEnabled()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsLoggingEnabled_Internal_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170569, XrefRangeEnd = 1170571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DrawLine_Injected([In] ref Vector3 start, [In] ref Vector3 end, [In] ref Color color, float duration, bool depthTest)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)Unsafe.AsPointer(ref start);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref end);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref color);
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &duration;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &depthTest;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawLine_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_byref_Color_Single_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170571, XrefRangeEnd = 1170573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ExtractStackTraceNoAlloc_Injected(byte* buffer, int bufferMax, ref ManagedSpanWrapper projectFolder)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)buffer;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bufferMax;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref projectFolder);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExtractStackTraceNoAlloc_Injected_Private_Static_Int32_ptr_Byte_Int32_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public static void LogFormat(string format, params Il2CppSystem.Object[] args)
	{
		LogFormat(format, new Il2CppReferenceArray<Il2CppSystem.Object>(args));
	}

	public static void LogFormat(LogType logType, LogOption logOptions, Object context, string format, params Il2CppSystem.Object[] args)
	{
		LogFormat(logType, logOptions, context, format, new Il2CppReferenceArray<Il2CppSystem.Object>(args));
	}

	public static void LogErrorFormat(string format, params Il2CppSystem.Object[] args)
	{
		LogErrorFormat(format, new Il2CppReferenceArray<Il2CppSystem.Object>(args));
	}

	public static void LogErrorFormat(Object context, string format, params Il2CppSystem.Object[] args)
	{
		LogErrorFormat(context, format, new Il2CppReferenceArray<Il2CppSystem.Object>(args));
	}

	public static void LogWarningFormat(string format, params Il2CppSystem.Object[] args)
	{
		LogWarningFormat(format, new Il2CppReferenceArray<Il2CppSystem.Object>(args));
	}

	public static void LogWarningFormat(Object context, string format, params Il2CppSystem.Object[] args)
	{
		LogWarningFormat(context, format, new Il2CppReferenceArray<Il2CppSystem.Object>(args));
	}

	public static void LogAssertionFormat(string format, params Il2CppSystem.Object[] args)
	{
		LogAssertionFormat(format, new Il2CppReferenceArray<Il2CppSystem.Object>(args));
	}

	public Debug(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static void DrawLine(Vector3 start, Vector3 end, Color color, float duration)
	{
		bool depthTest = true;
		DrawLine(start, end, color, duration, depthTest);
	}

	public static void DrawLine(Vector3 start, Vector3 end)
	{
		bool depthTest = true;
		float duration = 0f;
		Color white = Color.white;
		DrawLine(start, end, white, duration, depthTest);
	}

	public static void DrawRay(Vector3 start, Vector3 dir, Color color, float duration)
	{
		bool depthTest = true;
		DrawRay(start, dir, color, duration, depthTest);
	}

	public static void DrawRay(Vector3 start, Vector3 dir, Color color)
	{
		bool depthTest = true;
		float duration = 0f;
		DrawRay(start, dir, color, duration, depthTest);
	}

	public static void DrawRay(Vector3 start, Vector3 dir)
	{
		bool depthTest = true;
		float duration = 0f;
		Color white = Color.white;
		DrawRay(start, dir, white, duration, depthTest);
	}

	public static void DrawRay(Vector3 start, Vector3 dir, Color color, float duration, bool depthTest)
	{
		DrawLine(start, start + dir, color, duration, depthTest);
	}

	public static void DebugBreak()
	{
		DebugBreakDelegateField();
	}

	public static void LogFormat(Object context, string format, Il2CppReferenceArray<Il2CppSystem.Object> args)
	{
		((ILogHandler)(object)unityLogger).LogFormat(LogType.Log, context, format, args);
	}

	public static void LogFormat(Object context, string format, params Il2CppSystem.Object[] args)
	{
		LogFormat(context, format, new Il2CppReferenceArray<Il2CppSystem.Object>(args));
	}

	public static void ClearDeveloperConsole()
	{
		ClearDeveloperConsoleDelegateField();
	}

	public static void Assert(bool condition, Object context)
	{
		if (!condition)
		{
			unityLogger.Log(LogType.Assert, "Assertion failed", context);
		}
	}

	public static void Assert(bool condition, Il2CppSystem.Object message)
	{
		if (!condition)
		{
			unityLogger.Log(LogType.Assert, message);
		}
	}

	public static void Assert(bool condition, Il2CppSystem.Object message, Object context)
	{
		if (!condition)
		{
			unityLogger.Log(LogType.Assert, message, context);
		}
	}

	public static void Assert(bool condition, string message, Object context)
	{
		if (!condition)
		{
			unityLogger.Log(LogType.Assert, message, context);
		}
	}

	public static void AssertFormat(bool condition, string format, Il2CppReferenceArray<Il2CppSystem.Object> args)
	{
		if (!condition)
		{
			unityLogger.LogFormat(LogType.Assert, format, args);
		}
	}

	public static void AssertFormat(bool condition, string format, params Il2CppSystem.Object[] args)
	{
		AssertFormat(condition, format, new Il2CppReferenceArray<Il2CppSystem.Object>(args));
	}

	public static void AssertFormat(bool condition, Object context, string format, Il2CppReferenceArray<Il2CppSystem.Object> args)
	{
		if (!condition)
		{
			((ILogHandler)(object)unityLogger).LogFormat(LogType.Assert, context, format, args);
		}
	}

	public static void AssertFormat(bool condition, Object context, string format, params Il2CppSystem.Object[] args)
	{
		AssertFormat(condition, context, format, new Il2CppReferenceArray<Il2CppSystem.Object>(args));
	}

	public static void LogAssertion(Il2CppSystem.Object message, Object context)
	{
		unityLogger.Log(LogType.Assert, message, context);
	}

	public static void LogAssertionFormat(Object context, string format, Il2CppReferenceArray<Il2CppSystem.Object> args)
	{
		((ILogHandler)(object)unityLogger).LogFormat(LogType.Assert, context, format, args);
	}

	public static void LogAssertionFormat(Object context, string format, params Il2CppSystem.Object[] args)
	{
		LogAssertionFormat(context, format, new Il2CppReferenceArray<Il2CppSystem.Object>(args));
	}

	public static DiagnosticSwitch GetDiagnosticSwitch(string name)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static string CheckIntegrity(IntegrityCheckLevel level)
	{
		Unsafe.SkipInit(out ManagedSpanWrapper ret);
		string stringAndDispose;
		try
		{
			CheckIntegrity_Injected(level, out ret);
		}
		finally
		{
			stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
		}
		return stringAndDispose;
	}

	public static bool IsValidationLevelEnabled(ValidationLevel level)
	{
		return IsValidationLevelEnabledDelegateField(level);
	}

	public static void Assert(bool condition, string format, Il2CppReferenceArray<Il2CppSystem.Object> args)
	{
		if (!condition)
		{
			unityLogger.LogFormat(LogType.Assert, format, args);
		}
	}

	public static void Assert(bool condition, string format, params Il2CppSystem.Object[] args)
	{
		Assert(condition, format, new Il2CppReferenceArray<Il2CppSystem.Object>(args));
	}

	public unsafe static void CheckIntegrity_Injected(IntegrityCheckLevel level, out ManagedSpanWrapper ret)
	{
		CheckIntegrity_InjectedDelegateField(level, (nint)Unsafe.AsPointer(ref ret));
	}
}
