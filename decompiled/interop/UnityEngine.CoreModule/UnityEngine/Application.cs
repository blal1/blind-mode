using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Globalization;
using Il2CppSystem.Text;
using Il2CppSystem.Threading;
using UnityEngine.Bindings;
using UnityEngine.Diagnostics;
using UnityEngine.Events;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

namespace UnityEngine;

public class Application : Il2CppSystem.Object
{
	public sealed class LowMemoryCallback : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;

		static LowMemoryCallback()
		{
			Il2CppClassPointerStore<LowMemoryCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Application>.NativeClassPtr, "LowMemoryCallback");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowMemoryCallback>.NativeClassPtr, 100663859);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowMemoryCallback>.NativeClassPtr, 100663860);
		}

		[CallerCount(4109)]
		[CachedScanResults(RefRangeStart = 27728, RefRangeEnd = 31837, XrefRangeStart = 27728, XrefRangeEnd = 31837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LowMemoryCallback(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LowMemoryCallback>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual void Invoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public LowMemoryCallback(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public static implicit operator LowMemoryCallback(System.Action P_0)
		{
			return DelegateSupport.ConvertDelegate<LowMemoryCallback>((System.Delegate)P_0);
		}

		public static LowMemoryCallback operator +(LowMemoryCallback P_0, LowMemoryCallback P_1)
		{
			return ((Il2CppObjectBase)Il2CppSystem.Delegate.Combine(P_0, P_1)).Cast<LowMemoryCallback>();
		}

		public static LowMemoryCallback operator -(LowMemoryCallback P_0, LowMemoryCallback P_1)
		{
			object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<LowMemoryCallback>();
			}
			return (LowMemoryCallback)obj;
		}
	}

	public sealed class MemoryUsageChangedCallback : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ApplicationMemoryUsageChange_0;

		static MemoryUsageChangedCallback()
		{
			Il2CppClassPointerStore<MemoryUsageChangedCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Application>.NativeClassPtr, "MemoryUsageChangedCallback");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryUsageChangedCallback>.NativeClassPtr, 100663861);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ApplicationMemoryUsageChange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryUsageChangedCallback>.NativeClassPtr, 100663862);
		}

		[CallerCount(245)]
		[CachedScanResults(RefRangeStart = 57019, RefRangeEnd = 57264, XrefRangeStart = 57019, XrefRangeEnd = 57264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MemoryUsageChangedCallback(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MemoryUsageChangedCallback>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual void Invoke([In] ref ApplicationMemoryUsageChange usage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)Unsafe.AsPointer(ref usage);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ApplicationMemoryUsageChange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public MemoryUsageChangedCallback(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public sealed class LogCallback : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_String_LogType_0;

		static LogCallback()
		{
			Il2CppClassPointerStore<LogCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Application>.NativeClassPtr, "LogCallback");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogCallback>.NativeClassPtr, 100663863);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_String_LogType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogCallback>.NativeClassPtr, 100663864);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167632, XrefRangeEnd = 1167636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LogCallback(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LogCallback>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual void Invoke(string condition, string stackTrace, LogType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(condition);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(stackTrace);
			*(LogType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_String_LogType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public LogCallback(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public static implicit operator LogCallback(System.Action<string, string, LogType> P_0)
		{
			return DelegateSupport.ConvertDelegate<LogCallback>((System.Delegate)P_0);
		}

		public static LogCallback operator +(LogCallback P_0, LogCallback P_1)
		{
			return ((Il2CppObjectBase)Il2CppSystem.Delegate.Combine(P_0, P_1)).Cast<LogCallback>();
		}

		public static LogCallback operator -(LogCallback P_0, LogCallback P_1)
		{
			object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<LogCallback>();
			}
			return (LogCallback)obj;
		}
	}

	private delegate void CancelQuitDelegate();

	private delegate void UnloadDelegate();

	private delegate bool get_isLoadingLevelDelegate();

	private delegate void SimulateMemoryUsageDelegate(ApplicationMemoryUsage usage);

	private delegate System.IntPtr GetBuildTagsDelegate();

	private delegate void SetBuildTagsDelegate(System.IntPtr buildTags);

	private delegate void set_runInBackgroundDelegate(bool value);

	private delegate bool HasProLicenseDelegate();

	private delegate bool get_isTestRunDelegate();

	private delegate bool get_isBuildingEditorResourcesDelegate();

	private delegate bool get_isHumanControllingUsDelegate();

	private delegate int get_unityVersionVerDelegate();

	private delegate int get_unityVersionMajDelegate();

	private delegate int get_unityVersionMinDelegate();

	private delegate ApplicationInstallMode get_installModeDelegate();

	private delegate ApplicationSandboxType get_sandboxTypeDelegate();

	private delegate void SetLogCallbackDefinedDelegate(bool defined);

	private delegate StackTraceLogType get_stackTraceLogTypeDelegate();

	private delegate void set_stackTraceLogTypeDelegate(StackTraceLogType value);

	private delegate StackTraceLogType GetStackTraceLogTypeDelegate(LogType logType);

	private delegate void SetStackTraceLogTypeDelegate(LogType logType, StackTraceLogType stackTraceType);

	private delegate ThreadPriority get_backgroundLoadingPriorityDelegate();

	private delegate void set_backgroundLoadingPriorityDelegate(ThreadPriority value);

	private delegate bool get_genuineDelegate();

	private delegate bool get_genuineCheckAvailableDelegate();

	private delegate bool HasUserAuthorizationDelegate(UserAuthorization mode);

	private delegate bool get_submitAnalyticsDelegate();

	private delegate bool CanStreamedLevelBeLoaded_InjectedDelegate(System.IntPtr levelName);

	private delegate bool IsPlaying_InjectedDelegate(System.IntPtr obj);

	private delegate void get_buildGUID_InjectedDelegate([Out] System.IntPtr ret);

	private delegate bool HasARGV_InjectedDelegate(System.IntPtr name);

	private delegate void GetValueForARGV_InjectedDelegate(System.IntPtr name, [Out] System.IntPtr ret);

	private delegate void get_temporaryCachePath_InjectedDelegate([Out] System.IntPtr ret);

	private delegate void get_absoluteURL_InjectedDelegate([Out] System.IntPtr ret);

	private delegate void Internal_ExternalCall_InjectedDelegate(System.IntPtr script);

	private delegate void get_unityVersion_InjectedDelegate([Out] System.IntPtr ret);

	private delegate void get_installerName_InjectedDelegate([Out] System.IntPtr ret);

	private delegate void get_identifier_InjectedDelegate([Out] System.IntPtr ret);

	private delegate void get_companyName_InjectedDelegate([Out] System.IntPtr ret);

	private delegate void get_cloudProjectId_InjectedDelegate([Out] System.IntPtr ret);

	private delegate void get_consoleLogPath_InjectedDelegate([Out] System.IntPtr ret);

	private delegate System.IntPtr RequestUserAuthorization_InjectedDelegate(UserAuthorization mode);

	private static readonly System.IntPtr NativeFieldInfoPtr_lowMemory;

	private static readonly System.IntPtr NativeFieldInfoPtr_memoryUsageChanged;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_LogCallbackHandler;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_LogCallbackHandlerThreaded;

	private static readonly System.IntPtr NativeFieldInfoPtr_focusChanged;

	private static readonly System.IntPtr NativeFieldInfoPtr_deepLinkActivated;

	private static readonly System.IntPtr NativeFieldInfoPtr_wantsToQuit;

	private static readonly System.IntPtr NativeFieldInfoPtr_quitting;

	private static readonly System.IntPtr NativeFieldInfoPtr_unloading;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_currentCancellationTokenSource;

	private static readonly System.IntPtr NativeMethodInfoPtr_Quit_Public_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Quit_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isPlaying_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isFocused_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_runInBackground_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isBatchMode_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_dataPath_Public_Static_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_streamingAssetsPath_Public_Static_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_persistentDataPath_Public_Static_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_version_Public_Static_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_productName_Public_Static_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OpenURL_Public_Static_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_targetFrameRate_Public_Static_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_targetFrameRate_Public_Static_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_platform_Public_Static_get_RuntimePlatform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isMobilePlatform_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_systemLanguage_Public_Static_get_SystemLanguage_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_internetReachability_Public_Static_get_NetworkReachability_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_lowMemory_Public_Static_add_Void_LowMemoryCallback_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_lowMemory_Public_Static_rem_Void_LowMemoryCallback_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallLowMemory_Internal_Static_Void_ApplicationMemoryUsage_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasLogCallback_Internal_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallLogCallback_Private_Static_Void_String_String_LogType_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_onBeforeRender_Public_Static_add_Void_UnityAction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_onBeforeRender_Public_Static_rem_Void_UnityAction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_focusChanged_Public_Static_add_Void_Action_1_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_focusChanged_Public_Static_rem_Void_Action_1_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_wantsToQuit_Public_Static_add_Void_Func_1_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_wantsToQuit_Public_Static_rem_Void_Func_1_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_quitting_Public_Static_add_Void_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_quitting_Public_Static_rem_Void_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_ApplicationWantsToQuit_Private_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_InitializeExitCancellationToken_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_RaiseExitCancellationToken_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_ApplicationQuit_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_ApplicationUnload_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeOnBeforeRender_Internal_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeFocusChanged_Internal_Static_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeDeepLinkActivated_Internal_Static_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isEditor_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_dataPath_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_streamingAssetsPath_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_persistentDataPath_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_version_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_productName_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OpenURL_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0;

	private static readonly CancelQuitDelegate CancelQuitDelegateField;

	private static readonly UnloadDelegate UnloadDelegateField;

	private static readonly get_isLoadingLevelDelegate get_isLoadingLevelDelegateField;

	private static readonly SimulateMemoryUsageDelegate SimulateMemoryUsageDelegateField;

	private static readonly GetBuildTagsDelegate GetBuildTagsDelegateField;

	private static readonly SetBuildTagsDelegate SetBuildTagsDelegateField;

	private static readonly set_runInBackgroundDelegate set_runInBackgroundDelegateField;

	private static readonly HasProLicenseDelegate HasProLicenseDelegateField;

	private static readonly get_isTestRunDelegate get_isTestRunDelegateField;

	private static readonly get_isBuildingEditorResourcesDelegate get_isBuildingEditorResourcesDelegateField;

	private static readonly get_isHumanControllingUsDelegate get_isHumanControllingUsDelegateField;

	private static readonly get_unityVersionVerDelegate get_unityVersionVerDelegateField;

	private static readonly get_unityVersionMajDelegate get_unityVersionMajDelegateField;

	private static readonly get_unityVersionMinDelegate get_unityVersionMinDelegateField;

	private static readonly get_installModeDelegate get_installModeDelegateField;

	private static readonly get_sandboxTypeDelegate get_sandboxTypeDelegateField;

	private static readonly SetLogCallbackDefinedDelegate SetLogCallbackDefinedDelegateField;

	private static readonly get_stackTraceLogTypeDelegate get_stackTraceLogTypeDelegateField;

	private static readonly set_stackTraceLogTypeDelegate set_stackTraceLogTypeDelegateField;

	private static readonly GetStackTraceLogTypeDelegate GetStackTraceLogTypeDelegateField;

	private static readonly SetStackTraceLogTypeDelegate SetStackTraceLogTypeDelegateField;

	private static readonly get_backgroundLoadingPriorityDelegate get_backgroundLoadingPriorityDelegateField;

	private static readonly set_backgroundLoadingPriorityDelegate set_backgroundLoadingPriorityDelegateField;

	private static readonly get_genuineDelegate get_genuineDelegateField;

	private static readonly get_genuineCheckAvailableDelegate get_genuineCheckAvailableDelegateField;

	private static readonly HasUserAuthorizationDelegate HasUserAuthorizationDelegateField;

	private static readonly get_submitAnalyticsDelegate get_submitAnalyticsDelegateField;

	private static readonly CanStreamedLevelBeLoaded_InjectedDelegate CanStreamedLevelBeLoaded_InjectedDelegateField;

	private static readonly IsPlaying_InjectedDelegate IsPlaying_InjectedDelegateField;

	private static readonly get_buildGUID_InjectedDelegate get_buildGUID_InjectedDelegateField;

	private static readonly HasARGV_InjectedDelegate HasARGV_InjectedDelegateField;

	private static readonly GetValueForARGV_InjectedDelegate GetValueForARGV_InjectedDelegateField;

	private static readonly get_temporaryCachePath_InjectedDelegate get_temporaryCachePath_InjectedDelegateField;

	private static readonly get_absoluteURL_InjectedDelegate get_absoluteURL_InjectedDelegateField;

	private static readonly Internal_ExternalCall_InjectedDelegate Internal_ExternalCall_InjectedDelegateField;

	private static readonly get_unityVersion_InjectedDelegate get_unityVersion_InjectedDelegateField;

	private static readonly get_installerName_InjectedDelegate get_installerName_InjectedDelegateField;

	private static readonly get_identifier_InjectedDelegate get_identifier_InjectedDelegateField;

	private static readonly get_companyName_InjectedDelegate get_companyName_InjectedDelegateField;

	private static readonly get_cloudProjectId_InjectedDelegate get_cloudProjectId_InjectedDelegateField;

	private static readonly get_consoleLogPath_InjectedDelegate get_consoleLogPath_InjectedDelegateField;

	private static readonly RequestUserAuthorization_InjectedDelegate RequestUserAuthorization_InjectedDelegateField;

	public unsafe static LowMemoryCallback lowMemory
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_lowMemory, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<LowMemoryCallback>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_lowMemory, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static MemoryUsageChangedCallback memoryUsageChanged
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_memoryUsageChanged, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MemoryUsageChangedCallback>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_memoryUsageChanged, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static LogCallback s_LogCallbackHandler
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_LogCallbackHandler, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<LogCallback>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_LogCallbackHandler, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static LogCallback s_LogCallbackHandlerThreaded
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_LogCallbackHandlerThreaded, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<LogCallback>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_LogCallbackHandlerThreaded, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppSystem.Action<bool> focusChanged
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_focusChanged, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<bool>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_focusChanged, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppSystem.Action<string> deepLinkActivated
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_deepLinkActivated, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_deepLinkActivated, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppSystem.Func<bool> wantsToQuit
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_wantsToQuit, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<bool>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_wantsToQuit, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppSystem.Action quitting
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_quitting, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_quitting, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppSystem.Action unloading
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_unloading, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_unloading, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static CancellationTokenSource s_currentCancellationTokenSource
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_currentCancellationTokenSource, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CancellationTokenSource>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_currentCancellationTokenSource, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static bool isPlaying
	{
		[CallerCount(52)]
		[CachedScanResults(RefRangeStart = 1167659, RefRangeEnd = 1167711, XrefRangeStart = 1167657, XrefRangeEnd = 1167659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isPlaying_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static bool isFocused
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1167713, RefRangeEnd = 1167718, XrefRangeStart = 1167711, XrefRangeEnd = 1167713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isFocused_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static bool runInBackground
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1167720, RefRangeEnd = 1167721, XrefRangeStart = 1167718, XrefRangeEnd = 1167720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_runInBackground_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			set_runInBackgroundDelegateField(value);
		}
	}

	public unsafe static bool isBatchMode
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1167723, RefRangeEnd = 1167724, XrefRangeStart = 1167721, XrefRangeEnd = 1167723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isBatchMode_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static string dataPath
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1167732, RefRangeEnd = 1167735, XrefRangeStart = 1167724, XrefRangeEnd = 1167732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_dataPath_Public_Static_get_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe static string streamingAssetsPath
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1167743, RefRangeEnd = 1167746, XrefRangeStart = 1167735, XrefRangeEnd = 1167743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_streamingAssetsPath_Public_Static_get_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe static string persistentDataPath
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1167754, RefRangeEnd = 1167756, XrefRangeStart = 1167746, XrefRangeEnd = 1167754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_persistentDataPath_Public_Static_get_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe static string version
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1167764, RefRangeEnd = 1167765, XrefRangeStart = 1167756, XrefRangeEnd = 1167764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_version_Public_Static_get_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe static string productName
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1167773, RefRangeEnd = 1167774, XrefRangeStart = 1167765, XrefRangeEnd = 1167773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_productName_Public_Static_get_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe static int targetFrameRate
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1167798, RefRangeEnd = 1167799, XrefRangeStart = 1167796, XrefRangeEnd = 1167798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_targetFrameRate_Public_Static_get_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1167801, RefRangeEnd = 1167803, XrefRangeStart = 1167799, XrefRangeEnd = 1167801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_targetFrameRate_Public_Static_set_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe static RuntimePlatform platform
	{
		[CallerCount(50)]
		[CachedScanResults(RefRangeStart = 1167805, RefRangeEnd = 1167855, XrefRangeStart = 1167803, XrefRangeEnd = 1167805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_platform_Public_Static_get_RuntimePlatform_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(RuntimePlatform*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static bool isMobilePlatform
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1167861, RefRangeEnd = 1167862, XrefRangeStart = 1167855, XrefRangeEnd = 1167861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isMobilePlatform_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static SystemLanguage systemLanguage
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1167864, RefRangeEnd = 1167866, XrefRangeStart = 1167862, XrefRangeEnd = 1167864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_systemLanguage_Public_Static_get_SystemLanguage_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(SystemLanguage*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static NetworkReachability internetReachability
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1167868, RefRangeEnd = 1167871, XrefRangeStart = 1167866, XrefRangeEnd = 1167868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_internetReachability_Public_Static_get_NetworkReachability_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(NetworkReachability*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static bool isEditor
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 352012, RefRangeEnd = 352018, XrefRangeStart = 352012, XrefRangeEnd = 352018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isEditor_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public static bool isLoadingLevel => get_isLoadingLevelDelegateField();

	public static int streamedBytes => 0;

	public static bool webSecurityEnabled => false;

	public static string buildGUID
	{
		get
		{
			Unsafe.SkipInit(out ManagedSpanWrapper ret);
			string stringAndDispose;
			try
			{
				get_buildGUID_Injected(out ret);
			}
			finally
			{
				stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
			}
			return stringAndDispose;
		}
	}

	public static bool isTestRun => get_isTestRunDelegateField();

	public static bool isBuildingEditorResources => get_isBuildingEditorResourcesDelegateField();

	public static bool isHumanControllingUs => get_isHumanControllingUsDelegateField();

	public static string temporaryCachePath
	{
		get
		{
			Unsafe.SkipInit(out ManagedSpanWrapper ret);
			string stringAndDispose;
			try
			{
				get_temporaryCachePath_Injected(out ret);
			}
			finally
			{
				stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
			}
			return stringAndDispose;
		}
	}

	public static string absoluteURL
	{
		get
		{
			Unsafe.SkipInit(out ManagedSpanWrapper ret);
			string stringAndDispose;
			try
			{
				get_absoluteURL_Injected(out ret);
			}
			finally
			{
				stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
			}
			return stringAndDispose;
		}
	}

	public static string unityVersion
	{
		get
		{
			Unsafe.SkipInit(out ManagedSpanWrapper ret);
			string stringAndDispose;
			try
			{
				get_unityVersion_Injected(out ret);
			}
			finally
			{
				stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
			}
			return stringAndDispose;
		}
	}

	public static int unityVersionVer => get_unityVersionVerDelegateField();

	public static int unityVersionMaj => get_unityVersionMajDelegateField();

	public static int unityVersionMin => get_unityVersionMinDelegateField();

	public static string installerName
	{
		get
		{
			Unsafe.SkipInit(out ManagedSpanWrapper ret);
			string stringAndDispose;
			try
			{
				get_installerName_Injected(out ret);
			}
			finally
			{
				stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
			}
			return stringAndDispose;
		}
	}

	public static string identifier
	{
		get
		{
			Unsafe.SkipInit(out ManagedSpanWrapper ret);
			string stringAndDispose;
			try
			{
				get_identifier_Injected(out ret);
			}
			finally
			{
				stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
			}
			return stringAndDispose;
		}
	}

	public static ApplicationInstallMode installMode => get_installModeDelegateField();

	public static ApplicationSandboxType sandboxType => get_sandboxTypeDelegateField();

	public static string companyName
	{
		get
		{
			Unsafe.SkipInit(out ManagedSpanWrapper ret);
			string stringAndDispose;
			try
			{
				get_companyName_Injected(out ret);
			}
			finally
			{
				stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
			}
			return stringAndDispose;
		}
	}

	public static string cloudProjectId
	{
		get
		{
			Unsafe.SkipInit(out ManagedSpanWrapper ret);
			string stringAndDispose;
			try
			{
				get_cloudProjectId_Injected(out ret);
			}
			finally
			{
				stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
			}
			return stringAndDispose;
		}
	}

	public static StackTraceLogType stackTraceLogType
	{
		get
		{
			return get_stackTraceLogTypeDelegateField();
		}
		set
		{
			set_stackTraceLogTypeDelegateField(value);
		}
	}

	public static string consoleLogPath
	{
		get
		{
			Unsafe.SkipInit(out ManagedSpanWrapper ret);
			string stringAndDispose;
			try
			{
				get_consoleLogPath_Injected(out ret);
			}
			finally
			{
				stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
			}
			return stringAndDispose;
		}
	}

	public static ThreadPriority backgroundLoadingPriority
	{
		get
		{
			return get_backgroundLoadingPriorityDelegateField();
		}
		set
		{
			set_backgroundLoadingPriorityDelegateField(value);
		}
	}

	public static bool genuine => get_genuineDelegateField();

	public static bool genuineCheckAvailable => get_genuineCheckAvailableDelegateField();

	public static bool submitAnalytics => get_submitAnalyticsDelegateField();

	public static bool isShowingSplashScreen => !SplashScreen.isFinished;

	public static bool isConsolePlatform
	{
		get
		{
			RuntimePlatform runtimePlatform = platform;
			return runtimePlatform == RuntimePlatform.GameCoreXboxOne || runtimePlatform == RuntimePlatform.GameCoreXboxSeries || runtimePlatform == RuntimePlatform.PS4 || runtimePlatform == RuntimePlatform.PS5 || runtimePlatform == RuntimePlatform.Switch || runtimePlatform == RuntimePlatform.Switch2 || runtimePlatform == RuntimePlatform.XboxOne;
		}
	}

	public static bool isPlayer => !isEditor;

	public static CancellationToken exitCancellationToken => s_currentCancellationTokenSource.Token;

	public static int levelCount => SceneManager.sceneCountInBuildSettings;

	public static int loadedLevel => SceneManager.GetActiveScene().buildIndex;

	public static string loadedLevelName => SceneManager.GetActiveScene().name;

	static Application()
	{
		Il2CppClassPointerStore<Application>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Application");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Application>.NativeClassPtr);
		NativeFieldInfoPtr_lowMemory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Application>.NativeClassPtr, "lowMemory");
		NativeFieldInfoPtr_memoryUsageChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Application>.NativeClassPtr, "memoryUsageChanged");
		NativeFieldInfoPtr_s_LogCallbackHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Application>.NativeClassPtr, "s_LogCallbackHandler");
		NativeFieldInfoPtr_s_LogCallbackHandlerThreaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Application>.NativeClassPtr, "s_LogCallbackHandlerThreaded");
		NativeFieldInfoPtr_focusChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Application>.NativeClassPtr, "focusChanged");
		NativeFieldInfoPtr_deepLinkActivated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Application>.NativeClassPtr, "deepLinkActivated");
		NativeFieldInfoPtr_wantsToQuit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Application>.NativeClassPtr, "wantsToQuit");
		NativeFieldInfoPtr_quitting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Application>.NativeClassPtr, "quitting");
		NativeFieldInfoPtr_unloading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Application>.NativeClassPtr, "unloading");
		NativeFieldInfoPtr_s_currentCancellationTokenSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Application>.NativeClassPtr, "s_currentCancellationTokenSource");
		NativeMethodInfoPtr_Quit_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663812);
		NativeMethodInfoPtr_Quit_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663813);
		NativeMethodInfoPtr_get_isPlaying_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663814);
		NativeMethodInfoPtr_get_isFocused_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663815);
		NativeMethodInfoPtr_get_runInBackground_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663816);
		NativeMethodInfoPtr_get_isBatchMode_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663817);
		NativeMethodInfoPtr_get_dataPath_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663818);
		NativeMethodInfoPtr_get_streamingAssetsPath_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663819);
		NativeMethodInfoPtr_get_persistentDataPath_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663820);
		NativeMethodInfoPtr_get_version_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663821);
		NativeMethodInfoPtr_get_productName_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663822);
		NativeMethodInfoPtr_OpenURL_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663823);
		NativeMethodInfoPtr_get_targetFrameRate_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663824);
		NativeMethodInfoPtr_set_targetFrameRate_Public_Static_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663825);
		NativeMethodInfoPtr_get_platform_Public_Static_get_RuntimePlatform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663826);
		NativeMethodInfoPtr_get_isMobilePlatform_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663827);
		NativeMethodInfoPtr_get_systemLanguage_Public_Static_get_SystemLanguage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663828);
		NativeMethodInfoPtr_get_internetReachability_Public_Static_get_NetworkReachability_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663829);
		NativeMethodInfoPtr_add_lowMemory_Public_Static_add_Void_LowMemoryCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663830);
		NativeMethodInfoPtr_remove_lowMemory_Public_Static_rem_Void_LowMemoryCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663831);
		NativeMethodInfoPtr_CallLowMemory_Internal_Static_Void_ApplicationMemoryUsage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663832);
		NativeMethodInfoPtr_HasLogCallback_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663833);
		NativeMethodInfoPtr_CallLogCallback_Private_Static_Void_String_String_LogType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663834);
		NativeMethodInfoPtr_add_onBeforeRender_Public_Static_add_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663835);
		NativeMethodInfoPtr_remove_onBeforeRender_Public_Static_rem_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663836);
		NativeMethodInfoPtr_add_focusChanged_Public_Static_add_Void_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663837);
		NativeMethodInfoPtr_remove_focusChanged_Public_Static_rem_Void_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663838);
		NativeMethodInfoPtr_add_wantsToQuit_Public_Static_add_Void_Func_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663839);
		NativeMethodInfoPtr_remove_wantsToQuit_Public_Static_rem_Void_Func_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663840);
		NativeMethodInfoPtr_add_quitting_Public_Static_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663841);
		NativeMethodInfoPtr_remove_quitting_Public_Static_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663842);
		NativeMethodInfoPtr_Internal_ApplicationWantsToQuit_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663843);
		NativeMethodInfoPtr_Internal_InitializeExitCancellationToken_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663844);
		NativeMethodInfoPtr_Internal_RaiseExitCancellationToken_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663845);
		NativeMethodInfoPtr_Internal_ApplicationQuit_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663846);
		NativeMethodInfoPtr_Internal_ApplicationUnload_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663847);
		NativeMethodInfoPtr_InvokeOnBeforeRender_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663848);
		NativeMethodInfoPtr_InvokeFocusChanged_Internal_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663849);
		NativeMethodInfoPtr_InvokeDeepLinkActivated_Internal_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663850);
		NativeMethodInfoPtr_get_isEditor_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663851);
		NativeMethodInfoPtr_get_dataPath_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663853);
		NativeMethodInfoPtr_get_streamingAssetsPath_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663854);
		NativeMethodInfoPtr_get_persistentDataPath_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663855);
		NativeMethodInfoPtr_get_version_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663856);
		NativeMethodInfoPtr_get_productName_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663857);
		NativeMethodInfoPtr_OpenURL_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663858);
		CancelQuitDelegateField = IL2CPP.ResolveICall<CancelQuitDelegate>("UnityEngine.Application::CancelQuit");
		UnloadDelegateField = IL2CPP.ResolveICall<UnloadDelegate>("UnityEngine.Application::Unload");
		get_isLoadingLevelDelegateField = IL2CPP.ResolveICall<get_isLoadingLevelDelegate>("UnityEngine.Application::get_isLoadingLevel");
		SimulateMemoryUsageDelegateField = IL2CPP.ResolveICall<SimulateMemoryUsageDelegate>("UnityEngine.Application::SimulateMemoryUsage");
		GetBuildTagsDelegateField = IL2CPP.ResolveICall<GetBuildTagsDelegate>("UnityEngine.Application::GetBuildTags");
		SetBuildTagsDelegateField = IL2CPP.ResolveICall<SetBuildTagsDelegate>("UnityEngine.Application::SetBuildTags");
		set_runInBackgroundDelegateField = IL2CPP.ResolveICall<set_runInBackgroundDelegate>("UnityEngine.Application::set_runInBackground");
		HasProLicenseDelegateField = IL2CPP.ResolveICall<HasProLicenseDelegate>("UnityEngine.Application::HasProLicense");
		get_isTestRunDelegateField = IL2CPP.ResolveICall<get_isTestRunDelegate>("UnityEngine.Application::get_isTestRun");
		get_isBuildingEditorResourcesDelegateField = IL2CPP.ResolveICall<get_isBuildingEditorResourcesDelegate>("UnityEngine.Application::get_isBuildingEditorResources");
		get_isHumanControllingUsDelegateField = IL2CPP.ResolveICall<get_isHumanControllingUsDelegate>("UnityEngine.Application::get_isHumanControllingUs");
		get_unityVersionVerDelegateField = IL2CPP.ResolveICall<get_unityVersionVerDelegate>("UnityEngine.Application::get_unityVersionVer");
		get_unityVersionMajDelegateField = IL2CPP.ResolveICall<get_unityVersionMajDelegate>("UnityEngine.Application::get_unityVersionMaj");
		get_unityVersionMinDelegateField = IL2CPP.ResolveICall<get_unityVersionMinDelegate>("UnityEngine.Application::get_unityVersionMin");
		get_installModeDelegateField = IL2CPP.ResolveICall<get_installModeDelegate>("UnityEngine.Application::get_installMode");
		get_sandboxTypeDelegateField = IL2CPP.ResolveICall<get_sandboxTypeDelegate>("UnityEngine.Application::get_sandboxType");
		SetLogCallbackDefinedDelegateField = IL2CPP.ResolveICall<SetLogCallbackDefinedDelegate>("UnityEngine.Application::SetLogCallbackDefined");
		get_stackTraceLogTypeDelegateField = IL2CPP.ResolveICall<get_stackTraceLogTypeDelegate>("UnityEngine.Application::get_stackTraceLogType");
		set_stackTraceLogTypeDelegateField = IL2CPP.ResolveICall<set_stackTraceLogTypeDelegate>("UnityEngine.Application::set_stackTraceLogType");
		GetStackTraceLogTypeDelegateField = IL2CPP.ResolveICall<GetStackTraceLogTypeDelegate>("UnityEngine.Application::GetStackTraceLogType");
		SetStackTraceLogTypeDelegateField = IL2CPP.ResolveICall<SetStackTraceLogTypeDelegate>("UnityEngine.Application::SetStackTraceLogType");
		get_backgroundLoadingPriorityDelegateField = IL2CPP.ResolveICall<get_backgroundLoadingPriorityDelegate>("UnityEngine.Application::get_backgroundLoadingPriority");
		set_backgroundLoadingPriorityDelegateField = IL2CPP.ResolveICall<set_backgroundLoadingPriorityDelegate>("UnityEngine.Application::set_backgroundLoadingPriority");
		get_genuineDelegateField = IL2CPP.ResolveICall<get_genuineDelegate>("UnityEngine.Application::get_genuine");
		get_genuineCheckAvailableDelegateField = IL2CPP.ResolveICall<get_genuineCheckAvailableDelegate>("UnityEngine.Application::get_genuineCheckAvailable");
		HasUserAuthorizationDelegateField = IL2CPP.ResolveICall<HasUserAuthorizationDelegate>("UnityEngine.Application::HasUserAuthorization");
		get_submitAnalyticsDelegateField = IL2CPP.ResolveICall<get_submitAnalyticsDelegate>("UnityEngine.Application::get_submitAnalytics");
		CanStreamedLevelBeLoaded_InjectedDelegateField = IL2CPP.ResolveICall<CanStreamedLevelBeLoaded_InjectedDelegate>("UnityEngine.Application::CanStreamedLevelBeLoaded_Injected");
		IsPlaying_InjectedDelegateField = IL2CPP.ResolveICall<IsPlaying_InjectedDelegate>("UnityEngine.Application::IsPlaying_Injected");
		get_buildGUID_InjectedDelegateField = IL2CPP.ResolveICall<get_buildGUID_InjectedDelegate>("UnityEngine.Application::get_buildGUID_Injected");
		HasARGV_InjectedDelegateField = IL2CPP.ResolveICall<HasARGV_InjectedDelegate>("UnityEngine.Application::HasARGV_Injected");
		GetValueForARGV_InjectedDelegateField = IL2CPP.ResolveICall<GetValueForARGV_InjectedDelegate>("UnityEngine.Application::GetValueForARGV_Injected");
		get_temporaryCachePath_InjectedDelegateField = IL2CPP.ResolveICall<get_temporaryCachePath_InjectedDelegate>("UnityEngine.Application::get_temporaryCachePath_Injected");
		get_absoluteURL_InjectedDelegateField = IL2CPP.ResolveICall<get_absoluteURL_InjectedDelegate>("UnityEngine.Application::get_absoluteURL_Injected");
		Internal_ExternalCall_InjectedDelegateField = IL2CPP.ResolveICall<Internal_ExternalCall_InjectedDelegate>("UnityEngine.Application::Internal_ExternalCall_Injected");
		get_unityVersion_InjectedDelegateField = IL2CPP.ResolveICall<get_unityVersion_InjectedDelegate>("UnityEngine.Application::get_unityVersion_Injected");
		get_installerName_InjectedDelegateField = IL2CPP.ResolveICall<get_installerName_InjectedDelegate>("UnityEngine.Application::get_installerName_Injected");
		get_identifier_InjectedDelegateField = IL2CPP.ResolveICall<get_identifier_InjectedDelegate>("UnityEngine.Application::get_identifier_Injected");
		get_companyName_InjectedDelegateField = IL2CPP.ResolveICall<get_companyName_InjectedDelegate>("UnityEngine.Application::get_companyName_Injected");
		get_cloudProjectId_InjectedDelegateField = IL2CPP.ResolveICall<get_cloudProjectId_InjectedDelegate>("UnityEngine.Application::get_cloudProjectId_Injected");
		get_consoleLogPath_InjectedDelegateField = IL2CPP.ResolveICall<get_consoleLogPath_InjectedDelegate>("UnityEngine.Application::get_consoleLogPath_Injected");
		RequestUserAuthorization_InjectedDelegateField = IL2CPP.ResolveICall<RequestUserAuthorization_InjectedDelegate>("UnityEngine.Application::RequestUserAuthorization_Injected");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167636, XrefRangeEnd = 1167638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Quit(int exitCode)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&exitCode);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Quit_Public_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1167651, RefRangeEnd = 1167657, XrefRangeStart = 1167638, XrefRangeEnd = 1167651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Quit()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Quit_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1167791, RefRangeEnd = 1167796, XrefRangeStart = 1167774, XrefRangeEnd = 1167791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OpenURL(string url)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OpenURL_Public_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1167882, RefRangeEnd = 1167883, XrefRangeStart = 1167871, XrefRangeEnd = 1167882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_lowMemory(LowMemoryCallback value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_lowMemory_Public_Static_add_Void_LowMemoryCallback_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1167894, RefRangeEnd = 1167895, XrefRangeStart = 1167883, XrefRangeEnd = 1167894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_lowMemory(LowMemoryCallback value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_lowMemory_Public_Static_rem_Void_LowMemoryCallback_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167895, XrefRangeEnd = 1167902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CallLowMemory(ApplicationMemoryUsage usage)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&usage);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CallLowMemory_Internal_Static_Void_ApplicationMemoryUsage_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167902, XrefRangeEnd = 1167906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool HasLogCallback()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasLogCallback_Internal_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167906, XrefRangeEnd = 1167913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CallLogCallback(string logString, string stackTrace, LogType type, bool invokedOnMainThread)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(logString);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(stackTrace);
		*(LogType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &invokedOnMainThread;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CallLogCallback_Private_Static_Void_String_String_LogType_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1167917, RefRangeEnd = 1167918, XrefRangeStart = 1167913, XrefRangeEnd = 1167917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_onBeforeRender(UnityAction value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_onBeforeRender_Public_Static_add_Void_UnityAction_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1167922, RefRangeEnd = 1167923, XrefRangeStart = 1167918, XrefRangeEnd = 1167922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_onBeforeRender(UnityAction value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_onBeforeRender_Public_Static_rem_Void_UnityAction_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1167936, RefRangeEnd = 1167938, XrefRangeStart = 1167923, XrefRangeEnd = 1167936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_focusChanged(Il2CppSystem.Action<bool> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_focusChanged_Public_Static_add_Void_Action_1_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1167951, RefRangeEnd = 1167953, XrefRangeStart = 1167938, XrefRangeEnd = 1167951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_focusChanged(Il2CppSystem.Action<bool> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_focusChanged_Public_Static_rem_Void_Action_1_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1167966, RefRangeEnd = 1167967, XrefRangeStart = 1167953, XrefRangeEnd = 1167966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_wantsToQuit(Il2CppSystem.Func<bool> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_wantsToQuit_Public_Static_add_Void_Func_1_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1167980, RefRangeEnd = 1167981, XrefRangeStart = 1167967, XrefRangeEnd = 1167980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_wantsToQuit(Il2CppSystem.Func<bool> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_wantsToQuit_Public_Static_rem_Void_Func_1_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1167992, RefRangeEnd = 1167993, XrefRangeStart = 1167981, XrefRangeEnd = 1167992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_quitting(Il2CppSystem.Action value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_quitting_Public_Static_add_Void_Action_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1168004, RefRangeEnd = 1168005, XrefRangeStart = 1167993, XrefRangeEnd = 1168004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_quitting(Il2CppSystem.Action value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_quitting_Public_Static_rem_Void_Action_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1168005, XrefRangeEnd = 1168021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Internal_ApplicationWantsToQuit()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_ApplicationWantsToQuit_Private_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1168021, XrefRangeEnd = 1168037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_InitializeExitCancellationToken()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_InitializeExitCancellationToken_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1168037, XrefRangeEnd = 1168042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_RaiseExitCancellationToken()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_RaiseExitCancellationToken_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1168042, XrefRangeEnd = 1168048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_ApplicationQuit()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_ApplicationQuit_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1168048, XrefRangeEnd = 1168054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_ApplicationUnload()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_ApplicationUnload_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1168054, XrefRangeEnd = 1168058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeOnBeforeRender()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeOnBeforeRender_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1168058, XrefRangeEnd = 1168064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeFocusChanged(bool focus)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&focus);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeFocusChanged_Internal_Static_Void_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1168064, XrefRangeEnd = 1168070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeDeepLinkActivated(string url)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeDeepLinkActivated_Internal_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1168070, XrefRangeEnd = 1168072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_dataPath_Injected(out ManagedSpanWrapper ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_dataPath_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1168072, XrefRangeEnd = 1168074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_streamingAssetsPath_Injected(out ManagedSpanWrapper ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_streamingAssetsPath_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1168074, XrefRangeEnd = 1168076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_persistentDataPath_Injected(out ManagedSpanWrapper ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_persistentDataPath_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1168076, XrefRangeEnd = 1168078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_version_Injected(out ManagedSpanWrapper ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_version_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1168078, XrefRangeEnd = 1168080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_productName_Injected(out ManagedSpanWrapper ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_productName_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1168080, XrefRangeEnd = 1168082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OpenURL_Injected(ref ManagedSpanWrapper url)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref url);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OpenURL_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public Application(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static void CancelQuit()
	{
		CancelQuitDelegateField();
	}

	public static void Unload()
	{
		UnloadDelegateField();
	}

	public static void SimulateMemoryUsage(ApplicationMemoryUsage usage)
	{
		SimulateMemoryUsageDelegateField(usage);
	}

	public static float GetStreamProgressForLevel(int levelIndex)
	{
		if (levelIndex >= 0 && levelIndex < SceneManager.sceneCountInBuildSettings)
		{
			return 1f;
		}
		return 0f;
	}

	public static float GetStreamProgressForLevel(string levelName)
	{
		return 1f;
	}

	public static bool CanStreamedLevelBeLoaded(int levelIndex)
	{
		return levelIndex >= 0 && levelIndex < SceneManager.sceneCountInBuildSettings;
	}

	public unsafe static bool CanStreamedLevelBeLoaded(string levelName)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//The blocks IL_0029 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(levelName, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(levelName);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return CanStreamedLevelBeLoaded_Injected(ref managedSpanWrapper);
				}
			}
			return CanStreamedLevelBeLoaded_Injected(ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public static bool IsPlaying(Object obj)
	{
		if ((object)obj == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(obj, "obj");
		}
		System.IntPtr intPtr = Object.MarshalledUnityObject.MarshalNotNull(obj);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(obj, "obj");
		}
		return IsPlaying_Injected(intPtr);
	}

	public static Il2CppStringArray GetBuildTags()
	{
		System.IntPtr intPtr = GetBuildTagsDelegateField();
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
	}

	public static void SetBuildTags(Il2CppStringArray buildTags)
	{
		SetBuildTagsDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buildTags));
	}

	public static bool HasProLicense()
	{
		return HasProLicenseDelegateField();
	}

	public unsafe static bool HasARGV(string name)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//The blocks IL_0029 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(name, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(name);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return HasARGV_Injected(ref managedSpanWrapper);
				}
			}
			return HasARGV_Injected(ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public unsafe static string GetValueForARGV(string name)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//The blocks IL_0029 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		Unsafe.SkipInit(out ManagedSpanWrapper ret);
		string stringAndDispose;
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(name, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(name);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					GetValueForARGV_Injected(ref managedSpanWrapper, out ret);
				}
			}
			else
			{
				GetValueForARGV_Injected(ref managedSpanWrapper, out ret);
			}
		}
		finally
		{
			stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
		}
		return stringAndDispose;
	}

	public static void ExternalEval(string script)
	{
		if (script.Length > 0 && script[script.Length - 1] != ';')
		{
			script = Il2CppSystem.String.Concat(script, ";");
		}
		Internal_ExternalCall(script);
	}

	public unsafe static void Internal_ExternalCall(string script)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//The blocks IL_0029 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(script, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(script);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					Internal_ExternalCall_Injected(ref managedSpanWrapper);
					return;
				}
			}
			Internal_ExternalCall_Injected(ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public static void ForceCrash(int mode)
	{
		Utils.ForceCrash((ForcedCrashCategory)mode);
	}

	public static void SetLogCallbackDefined(bool defined)
	{
		SetLogCallbackDefinedDelegateField(defined);
	}

	public static StackTraceLogType GetStackTraceLogType(LogType logType)
	{
		return GetStackTraceLogTypeDelegateField(logType);
	}

	public static void SetStackTraceLogType(LogType logType, StackTraceLogType stackTraceType)
	{
		SetStackTraceLogTypeDelegateField(logType, stackTraceType);
	}

	public static AsyncOperation RequestUserAuthorization(UserAuthorization mode)
	{
		System.IntPtr intPtr = RequestUserAuthorization_Injected(mode);
		return (intPtr == (System.IntPtr)0) ? null : AsyncOperation.BindingsMarshaller.ConvertToManaged(intPtr);
	}

	public static bool HasUserAuthorization(UserAuthorization mode)
	{
		return HasUserAuthorizationDelegateField(mode);
	}

	[SpecialName]
	public static void add_memoryUsageChanged(MemoryUsageChangedCallback value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void remove_memoryUsageChanged(MemoryUsageChangedCallback value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void add_logMessageReceived(LogCallback value)
	{
		s_LogCallbackHandler = ((Il2CppObjectBase)Il2CppSystem.Delegate.Combine(s_LogCallbackHandler, value)).Cast<LogCallback>();
		SetLogCallbackDefined(defined: true);
	}

	[SpecialName]
	public static void remove_logMessageReceived(LogCallback value)
	{
		s_LogCallbackHandler = ((Il2CppObjectBase)Il2CppSystem.Delegate.Remove(s_LogCallbackHandler, value)).Cast<LogCallback>();
	}

	[SpecialName]
	public static void add_logMessageReceivedThreaded(LogCallback value)
	{
		s_LogCallbackHandlerThreaded = ((Il2CppObjectBase)Il2CppSystem.Delegate.Combine(s_LogCallbackHandlerThreaded, value)).Cast<LogCallback>();
		SetLogCallbackDefined(defined: true);
	}

	[SpecialName]
	public static void remove_logMessageReceivedThreaded(LogCallback value)
	{
		s_LogCallbackHandlerThreaded = ((Il2CppObjectBase)Il2CppSystem.Delegate.Remove(s_LogCallbackHandlerThreaded, value)).Cast<LogCallback>();
	}

	public static void InvokeOnAdvertisingIdentifierCallback(string advertisingId, bool trackingEnabled)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static string ObjectToJSString(Il2CppSystem.Object o)
	{
		if (o == null)
		{
			return "null";
		}
		if (((Il2CppObjectBase)o).TryCast<string>() != null)
		{
			string text = o.ToString().Replace("\\", "\\\\");
			text = text.Replace("\"", "\\\"");
			text = text.Replace("\n", "\\n");
			text = text.Replace("\r", "\\r");
			text = text.Replace("\0", "");
			text = text.Replace("\u2028", "");
			text = text.Replace("\u2029", "");
			return Il2CppSystem.String.Concat("\"", text, "\"");
		}
		if (o is int || o is short || o is uint || o is ushort || o is byte)
		{
			return o.ToString();
		}
		if (o is float)
		{
			NumberFormatInfo numberFormat = CultureInfo.InvariantCulture.NumberFormat;
			return ((float)(object)o).ToString((Il2CppSystem.IFormatProvider)(object)numberFormat);
		}
		if (o is double)
		{
			NumberFormatInfo numberFormat2 = CultureInfo.InvariantCulture.NumberFormat;
			return ((double)(object)o).ToString((Il2CppSystem.IFormatProvider)(object)numberFormat2);
		}
		if (o is char)
		{
			if ((char)(object)o == '"')
			{
				return "\"\\\"\"";
			}
			return Il2CppSystem.String.Concat("\"", o.ToString(), "\"");
		}
		if (((Il2CppObjectBase)o).TryCast<IList>() != null)
		{
			IList list = ((Il2CppObjectBase)o).Cast<IList>();
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("new Array(");
			int count = ((ICollection)(object)list).Count;
			for (int i = 0; i < count; i++)
			{
				if (i != 0)
				{
					stringBuilder.Append(", ");
				}
				stringBuilder.Append(ObjectToJSString(list[i]));
			}
			stringBuilder.Append(")");
			return stringBuilder.ToString();
		}
		return ObjectToJSString(o.ToString());
	}

	public static void ExternalCall(string functionName, Il2CppReferenceArray<Il2CppSystem.Object> args)
	{
		Internal_ExternalCall(BuildInvocationForArguments(functionName, args));
	}

	public static void ExternalCall(string functionName, params Il2CppSystem.Object[] args)
	{
		ExternalCall(functionName, new Il2CppReferenceArray<Il2CppSystem.Object>(args));
	}

	public static string BuildInvocationForArguments(string functionName, Il2CppReferenceArray<Il2CppSystem.Object> args)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static string BuildInvocationForArguments(string functionName, params Il2CppSystem.Object[] args)
	{
		return BuildInvocationForArguments(functionName, new Il2CppReferenceArray<Il2CppSystem.Object>(args));
	}

	public static void DontDestroyOnLoad(Object o)
	{
		if (o != null)
		{
			Object.DontDestroyOnLoad(o);
		}
	}

	public static void CaptureScreenshot(string filename, int superSize)
	{
		throw new Il2CppSystem.NotSupportedException("Application.CaptureScreenshot is obsolete. Use ScreenCapture.CaptureScreenshot instead.");
	}

	public static void CaptureScreenshot(string filename)
	{
		throw new Il2CppSystem.NotSupportedException("Application.CaptureScreenshot is obsolete. Use ScreenCapture.CaptureScreenshot instead.");
	}

	[SpecialName]
	public static void add_deepLinkActivated(Il2CppSystem.Action<string> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void remove_deepLinkActivated(Il2CppSystem.Action<string> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void add_unloading(Il2CppSystem.Action value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void remove_unloading(Il2CppSystem.Action value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static void RegisterLogCallback(LogCallback handler)
	{
		RegisterLogCallback(handler, threaded: false);
	}

	public static void RegisterLogCallbackThreaded(LogCallback handler)
	{
		RegisterLogCallback(handler, threaded: true);
	}

	public static void RegisterLogCallback(LogCallback handler, bool threaded)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static void LoadLevel(int index)
	{
		SceneManager.LoadScene(index, LoadSceneMode.Single);
	}

	public static void LoadLevel(string name)
	{
		SceneManager.LoadScene(name, LoadSceneMode.Single);
	}

	public static void LoadLevelAdditive(int index)
	{
		SceneManager.LoadScene(index, LoadSceneMode.Additive);
	}

	public static void LoadLevelAdditive(string name)
	{
		SceneManager.LoadScene(name, LoadSceneMode.Additive);
	}

	public static AsyncOperation LoadLevelAsync(int index)
	{
		return SceneManager.LoadSceneAsync(index, LoadSceneMode.Single);
	}

	public static AsyncOperation LoadLevelAsync(string levelName)
	{
		return SceneManager.LoadSceneAsync(levelName, LoadSceneMode.Single);
	}

	public static AsyncOperation LoadLevelAdditiveAsync(int index)
	{
		return SceneManager.LoadSceneAsync(index, LoadSceneMode.Additive);
	}

	public static AsyncOperation LoadLevelAdditiveAsync(string levelName)
	{
		return SceneManager.LoadSceneAsync(levelName, LoadSceneMode.Additive);
	}

	public static bool UnloadLevel(int index)
	{
		return SceneManager.UnloadScene(index);
	}

	public static bool UnloadLevel(string scenePath)
	{
		return SceneManager.UnloadScene(scenePath);
	}

	public unsafe static bool CanStreamedLevelBeLoaded_Injected(ref ManagedSpanWrapper levelName)
	{
		return CanStreamedLevelBeLoaded_InjectedDelegateField((nint)Unsafe.AsPointer(ref levelName));
	}

	public static bool IsPlaying_Injected(System.IntPtr obj)
	{
		return IsPlaying_InjectedDelegateField(obj);
	}

	public unsafe static void get_buildGUID_Injected(out ManagedSpanWrapper ret)
	{
		get_buildGUID_InjectedDelegateField((nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static bool HasARGV_Injected(ref ManagedSpanWrapper name)
	{
		return HasARGV_InjectedDelegateField((nint)Unsafe.AsPointer(ref name));
	}

	public unsafe static void GetValueForARGV_Injected(ref ManagedSpanWrapper name, out ManagedSpanWrapper ret)
	{
		GetValueForARGV_InjectedDelegateField((nint)Unsafe.AsPointer(ref name), (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void get_temporaryCachePath_Injected(out ManagedSpanWrapper ret)
	{
		get_temporaryCachePath_InjectedDelegateField((nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void get_absoluteURL_Injected(out ManagedSpanWrapper ret)
	{
		get_absoluteURL_InjectedDelegateField((nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void Internal_ExternalCall_Injected(ref ManagedSpanWrapper script)
	{
		Internal_ExternalCall_InjectedDelegateField((nint)Unsafe.AsPointer(ref script));
	}

	public unsafe static void get_unityVersion_Injected(out ManagedSpanWrapper ret)
	{
		get_unityVersion_InjectedDelegateField((nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void get_installerName_Injected(out ManagedSpanWrapper ret)
	{
		get_installerName_InjectedDelegateField((nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void get_identifier_Injected(out ManagedSpanWrapper ret)
	{
		get_identifier_InjectedDelegateField((nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void get_companyName_Injected(out ManagedSpanWrapper ret)
	{
		get_companyName_InjectedDelegateField((nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void get_cloudProjectId_Injected(out ManagedSpanWrapper ret)
	{
		get_cloudProjectId_InjectedDelegateField((nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void get_consoleLogPath_Injected(out ManagedSpanWrapper ret)
	{
		get_consoleLogPath_InjectedDelegateField((nint)Unsafe.AsPointer(ref ret));
	}

	public static System.IntPtr RequestUserAuthorization_Injected(UserAuthorization mode)
	{
		return RequestUserAuthorization_InjectedDelegateField(mode);
	}
}
