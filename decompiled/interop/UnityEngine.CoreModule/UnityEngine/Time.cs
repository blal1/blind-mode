using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.IntegerTime;

namespace UnityEngine;

public class Time : Il2CppSystem.Object
{
	private delegate float get_timeSinceLevelLoadDelegate();

	private delegate double get_timeSinceLevelLoadAsDoubleDelegate();

	private delegate float get_fixedTimeDelegate();

	private delegate double get_fixedTimeAsDoubleDelegate();

	private delegate double get_unscaledTimeAsDoubleDelegate();

	private delegate double get_fixedUnscaledTimeAsDoubleDelegate();

	private delegate float get_fixedUnscaledDeltaTimeDelegate();

	private delegate void set_fixedDeltaTimeDelegate(float value);

	private delegate void set_maximumDeltaTimeDelegate(float value);

	private delegate float get_maximumParticleDeltaTimeDelegate();

	private delegate void set_maximumParticleDeltaTimeDelegate(float value);

	private delegate float get_captureDeltaTimeDelegate();

	private delegate void set_captureDeltaTimeDelegate(float value);

	private delegate bool get_inFixedTimeStepDelegate();

	private delegate void get_captureDeltaTimeRational_InjectedDelegate([Out] System.IntPtr ret);

	private delegate void set_captureDeltaTimeRational_InjectedDelegate([In] System.IntPtr value);

	private static readonly System.IntPtr NativeMethodInfoPtr_get_time_Public_Static_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_timeAsDouble_Public_Static_get_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_timeAsRational_Public_Static_get_RationalTime_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_deltaTime_Public_Static_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_unscaledTime_Public_Static_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_fixedUnscaledTime_Public_Static_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_unscaledDeltaTime_Public_Static_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_fixedDeltaTime_Public_Static_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_maximumDeltaTime_Public_Static_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_smoothDeltaTime_Public_Static_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_timeScale_Public_Static_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_timeScale_Public_Static_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_frameCount_Public_Static_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_renderedFrameCount_Public_Static_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_realtimeSinceStartup_Public_Static_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_realtimeSinceStartupAsDouble_Public_Static_get_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_timeAsRational_Injected_Private_Static_Void_byref_RationalTime_0;

	private static readonly get_timeSinceLevelLoadDelegate get_timeSinceLevelLoadDelegateField;

	private static readonly get_timeSinceLevelLoadAsDoubleDelegate get_timeSinceLevelLoadAsDoubleDelegateField;

	private static readonly get_fixedTimeDelegate get_fixedTimeDelegateField;

	private static readonly get_fixedTimeAsDoubleDelegate get_fixedTimeAsDoubleDelegateField;

	private static readonly get_unscaledTimeAsDoubleDelegate get_unscaledTimeAsDoubleDelegateField;

	private static readonly get_fixedUnscaledTimeAsDoubleDelegate get_fixedUnscaledTimeAsDoubleDelegateField;

	private static readonly get_fixedUnscaledDeltaTimeDelegate get_fixedUnscaledDeltaTimeDelegateField;

	private static readonly set_fixedDeltaTimeDelegate set_fixedDeltaTimeDelegateField;

	private static readonly set_maximumDeltaTimeDelegate set_maximumDeltaTimeDelegateField;

	private static readonly get_maximumParticleDeltaTimeDelegate get_maximumParticleDeltaTimeDelegateField;

	private static readonly set_maximumParticleDeltaTimeDelegate set_maximumParticleDeltaTimeDelegateField;

	private static readonly get_captureDeltaTimeDelegate get_captureDeltaTimeDelegateField;

	private static readonly set_captureDeltaTimeDelegate set_captureDeltaTimeDelegateField;

	private static readonly get_inFixedTimeStepDelegate get_inFixedTimeStepDelegateField;

	private static readonly get_captureDeltaTimeRational_InjectedDelegate get_captureDeltaTimeRational_InjectedDelegateField;

	private static readonly set_captureDeltaTimeRational_InjectedDelegate set_captureDeltaTimeRational_InjectedDelegateField;

	public unsafe static float time
	{
		[CallerCount(35)]
		[CachedScanResults(RefRangeStart = 1216078, RefRangeEnd = 1216113, XrefRangeStart = 1216076, XrefRangeEnd = 1216078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_time_Public_Static_get_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static double timeAsDouble
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1216113, XrefRangeEnd = 1216115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_timeAsDouble_Public_Static_get_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static RationalTime timeAsRational
	{
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1216117, RefRangeEnd = 1216131, XrefRangeStart = 1216115, XrefRangeEnd = 1216117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_timeAsRational_Public_Static_get_RationalTime_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(RationalTime*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static float deltaTime
	{
		[CallerCount(219)]
		[CachedScanResults(RefRangeStart = 1216133, RefRangeEnd = 1216352, XrefRangeStart = 1216131, XrefRangeEnd = 1216133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_deltaTime_Public_Static_get_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static float unscaledTime
	{
		[CallerCount(59)]
		[CachedScanResults(RefRangeStart = 1216354, RefRangeEnd = 1216413, XrefRangeStart = 1216352, XrefRangeEnd = 1216354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_unscaledTime_Public_Static_get_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static float fixedUnscaledTime
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1216415, RefRangeEnd = 1216416, XrefRangeStart = 1216413, XrefRangeEnd = 1216415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_fixedUnscaledTime_Public_Static_get_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static float unscaledDeltaTime
	{
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 1216418, RefRangeEnd = 1216435, XrefRangeStart = 1216416, XrefRangeEnd = 1216418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_unscaledDeltaTime_Public_Static_get_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static float fixedDeltaTime
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1216437, RefRangeEnd = 1216438, XrefRangeStart = 1216435, XrefRangeEnd = 1216437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_fixedDeltaTime_Public_Static_get_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			set_fixedDeltaTimeDelegateField(value);
		}
	}

	public unsafe static float maximumDeltaTime
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1216440, RefRangeEnd = 1216442, XrefRangeStart = 1216438, XrefRangeEnd = 1216440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_maximumDeltaTime_Public_Static_get_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			set_maximumDeltaTimeDelegateField(value);
		}
	}

	public unsafe static float smoothDeltaTime
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1216444, RefRangeEnd = 1216447, XrefRangeStart = 1216442, XrefRangeEnd = 1216444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_smoothDeltaTime_Public_Static_get_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static float timeScale
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1216449, RefRangeEnd = 1216451, XrefRangeStart = 1216447, XrefRangeEnd = 1216449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_timeScale_Public_Static_get_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1216453, RefRangeEnd = 1216455, XrefRangeStart = 1216451, XrefRangeEnd = 1216453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_timeScale_Public_Static_set_Void_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe static int frameCount
	{
		[CallerCount(45)]
		[CachedScanResults(RefRangeStart = 1216457, RefRangeEnd = 1216502, XrefRangeStart = 1216455, XrefRangeEnd = 1216457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_frameCount_Public_Static_get_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static int renderedFrameCount
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1216504, RefRangeEnd = 1216505, XrefRangeStart = 1216502, XrefRangeEnd = 1216504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_renderedFrameCount_Public_Static_get_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static float realtimeSinceStartup
	{
		[CallerCount(58)]
		[CachedScanResults(RefRangeStart = 1216507, RefRangeEnd = 1216565, XrefRangeStart = 1216505, XrefRangeEnd = 1216507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_realtimeSinceStartup_Public_Static_get_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static double realtimeSinceStartupAsDouble
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1216567, RefRangeEnd = 1216569, XrefRangeStart = 1216565, XrefRangeEnd = 1216567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_realtimeSinceStartupAsDouble_Public_Static_get_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public static float timeSinceLevelLoad => get_timeSinceLevelLoadDelegateField();

	public static double timeSinceLevelLoadAsDouble => get_timeSinceLevelLoadAsDoubleDelegateField();

	public static float fixedTime => get_fixedTimeDelegateField();

	public static double fixedTimeAsDouble => get_fixedTimeAsDoubleDelegateField();

	public static double unscaledTimeAsDouble => get_unscaledTimeAsDoubleDelegateField();

	public static double fixedUnscaledTimeAsDouble => get_fixedUnscaledTimeAsDoubleDelegateField();

	public static float fixedUnscaledDeltaTime => get_fixedUnscaledDeltaTimeDelegateField();

	public static float maximumParticleDeltaTime
	{
		get
		{
			return get_maximumParticleDeltaTimeDelegateField();
		}
		set
		{
			set_maximumParticleDeltaTimeDelegateField(value);
		}
	}

	public static float captureDeltaTime
	{
		get
		{
			return get_captureDeltaTimeDelegateField();
		}
		set
		{
			set_captureDeltaTimeDelegateField(value);
		}
	}

	public static RationalTime captureDeltaTimeRational
	{
		get
		{
			get_captureDeltaTimeRational_Injected(out var ret);
			return ret;
		}
		set
		{
			set_captureDeltaTimeRational_Injected(ref value);
		}
	}

	public static int captureFramerate
	{
		get
		{
			return (captureDeltaTime != 0f) ? ((int)Mathf.Round(1f / captureDeltaTime)) : 0;
		}
		set
		{
			captureDeltaTime = ((value == 0) ? 0f : (1f / (float)value));
		}
	}

	public static bool inFixedTimeStep => get_inFixedTimeStepDelegateField();

	static Time()
	{
		Il2CppClassPointerStore<Time>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Time");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Time>.NativeClassPtr);
		NativeMethodInfoPtr_get_time_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100666737);
		NativeMethodInfoPtr_get_timeAsDouble_Public_Static_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100666738);
		NativeMethodInfoPtr_get_timeAsRational_Public_Static_get_RationalTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100666739);
		NativeMethodInfoPtr_get_deltaTime_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100666740);
		NativeMethodInfoPtr_get_unscaledTime_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100666741);
		NativeMethodInfoPtr_get_fixedUnscaledTime_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100666742);
		NativeMethodInfoPtr_get_unscaledDeltaTime_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100666743);
		NativeMethodInfoPtr_get_fixedDeltaTime_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100666744);
		NativeMethodInfoPtr_get_maximumDeltaTime_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100666745);
		NativeMethodInfoPtr_get_smoothDeltaTime_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100666746);
		NativeMethodInfoPtr_get_timeScale_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100666747);
		NativeMethodInfoPtr_set_timeScale_Public_Static_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100666748);
		NativeMethodInfoPtr_get_frameCount_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100666749);
		NativeMethodInfoPtr_get_renderedFrameCount_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100666750);
		NativeMethodInfoPtr_get_realtimeSinceStartup_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100666751);
		NativeMethodInfoPtr_get_realtimeSinceStartupAsDouble_Public_Static_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100666752);
		NativeMethodInfoPtr_get_timeAsRational_Injected_Private_Static_Void_byref_RationalTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100666753);
		get_timeSinceLevelLoadDelegateField = IL2CPP.ResolveICall<get_timeSinceLevelLoadDelegate>("UnityEngine.Time::get_timeSinceLevelLoad");
		get_timeSinceLevelLoadAsDoubleDelegateField = IL2CPP.ResolveICall<get_timeSinceLevelLoadAsDoubleDelegate>("UnityEngine.Time::get_timeSinceLevelLoadAsDouble");
		get_fixedTimeDelegateField = IL2CPP.ResolveICall<get_fixedTimeDelegate>("UnityEngine.Time::get_fixedTime");
		get_fixedTimeAsDoubleDelegateField = IL2CPP.ResolveICall<get_fixedTimeAsDoubleDelegate>("UnityEngine.Time::get_fixedTimeAsDouble");
		get_unscaledTimeAsDoubleDelegateField = IL2CPP.ResolveICall<get_unscaledTimeAsDoubleDelegate>("UnityEngine.Time::get_unscaledTimeAsDouble");
		get_fixedUnscaledTimeAsDoubleDelegateField = IL2CPP.ResolveICall<get_fixedUnscaledTimeAsDoubleDelegate>("UnityEngine.Time::get_fixedUnscaledTimeAsDouble");
		get_fixedUnscaledDeltaTimeDelegateField = IL2CPP.ResolveICall<get_fixedUnscaledDeltaTimeDelegate>("UnityEngine.Time::get_fixedUnscaledDeltaTime");
		set_fixedDeltaTimeDelegateField = IL2CPP.ResolveICall<set_fixedDeltaTimeDelegate>("UnityEngine.Time::set_fixedDeltaTime");
		set_maximumDeltaTimeDelegateField = IL2CPP.ResolveICall<set_maximumDeltaTimeDelegate>("UnityEngine.Time::set_maximumDeltaTime");
		get_maximumParticleDeltaTimeDelegateField = IL2CPP.ResolveICall<get_maximumParticleDeltaTimeDelegate>("UnityEngine.Time::get_maximumParticleDeltaTime");
		set_maximumParticleDeltaTimeDelegateField = IL2CPP.ResolveICall<set_maximumParticleDeltaTimeDelegate>("UnityEngine.Time::set_maximumParticleDeltaTime");
		get_captureDeltaTimeDelegateField = IL2CPP.ResolveICall<get_captureDeltaTimeDelegate>("UnityEngine.Time::get_captureDeltaTime");
		set_captureDeltaTimeDelegateField = IL2CPP.ResolveICall<set_captureDeltaTimeDelegate>("UnityEngine.Time::set_captureDeltaTime");
		get_inFixedTimeStepDelegateField = IL2CPP.ResolveICall<get_inFixedTimeStepDelegate>("UnityEngine.Time::get_inFixedTimeStep");
		get_captureDeltaTimeRational_InjectedDelegateField = IL2CPP.ResolveICall<get_captureDeltaTimeRational_InjectedDelegate>("UnityEngine.Time::get_captureDeltaTimeRational_Injected");
		set_captureDeltaTimeRational_InjectedDelegateField = IL2CPP.ResolveICall<set_captureDeltaTimeRational_InjectedDelegate>("UnityEngine.Time::set_captureDeltaTimeRational_Injected");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1216569, XrefRangeEnd = 1216571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_timeAsRational_Injected(out RationalTime ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_timeAsRational_Injected_Private_Static_Void_byref_RationalTime_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public Time(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public unsafe static void get_captureDeltaTimeRational_Injected(out RationalTime ret)
	{
		get_captureDeltaTimeRational_InjectedDelegateField((nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_captureDeltaTimeRational_Injected([In] ref RationalTime value)
	{
		set_captureDeltaTimeRational_InjectedDelegateField((nint)Unsafe.AsPointer(ref value));
	}
}
