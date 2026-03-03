using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Threading;

namespace UnityEngine.Android;

public static class AndroidApplication : Il2CppSystem.Object
{
	public sealed class _003C_003Ec__DisplayClass26_0
	{
	}

	public sealed class _003C_003Ec__DisplayClass27_0
	{
	}

	private delegate System.IntPtr get_CurrentContextRawDelegate();

	private delegate System.IntPtr get_CurrentActivityRawDelegate();

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MainThreadSynchronizationContext;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CurrentConfiguration;

	private static readonly System.IntPtr NativeFieldInfoPtr_onConfigurationChanged;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_UnityPlayerRaw_Internal_Static_get_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AcquireMainThreadSynchronizationContext_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCurrentConfiguration_Private_Static_Void_AndroidConfiguration_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentConfiguration_Private_Static_AndroidConfiguration_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DispatchConfigurationChanged_Private_Static_Void_Boolean_0;

	private static readonly get_CurrentContextRawDelegate get_CurrentContextRawDelegateField;

	private static readonly get_CurrentActivityRawDelegate get_CurrentActivityRawDelegateField;

	public unsafe static SynchronizationContext m_MainThreadSynchronizationContext
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_MainThreadSynchronizationContext, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<SynchronizationContext>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_MainThreadSynchronizationContext, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static AndroidConfiguration m_CurrentConfiguration
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_CurrentConfiguration, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AndroidConfiguration>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_CurrentConfiguration, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppSystem.Action<AndroidConfiguration> onConfigurationChanged
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_onConfigurationChanged, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<AndroidConfiguration>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_onConfigurationChanged, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static System.IntPtr UnityPlayerRaw
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151635, XrefRangeEnd = 1151637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_UnityPlayerRaw_Internal_Static_get_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public static System.IntPtr CurrentContextRaw => get_CurrentContextRawDelegateField();

	public static System.IntPtr CurrentActivityRaw => get_CurrentActivityRawDelegateField();

	public static AndroidJavaObject currentContext
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	public static AndroidJavaObject currentActivity
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	public static AndroidJavaObject unityPlayer
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	public static AndroidConfiguration currentConfiguration => m_CurrentConfiguration;

	static AndroidApplication()
	{
		Il2CppClassPointerStore<AndroidApplication>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AndroidJNIModule.dll", "UnityEngine.Android", "AndroidApplication");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidApplication>.NativeClassPtr);
		NativeFieldInfoPtr_m_MainThreadSynchronizationContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidApplication>.NativeClassPtr, "m_MainThreadSynchronizationContext");
		NativeFieldInfoPtr_m_CurrentConfiguration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidApplication>.NativeClassPtr, "m_CurrentConfiguration");
		NativeFieldInfoPtr_onConfigurationChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidApplication>.NativeClassPtr, "onConfigurationChanged");
		NativeMethodInfoPtr_get_UnityPlayerRaw_Internal_Static_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidApplication>.NativeClassPtr, 100663561);
		NativeMethodInfoPtr_AcquireMainThreadSynchronizationContext_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidApplication>.NativeClassPtr, 100663562);
		NativeMethodInfoPtr_SetCurrentConfiguration_Private_Static_Void_AndroidConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidApplication>.NativeClassPtr, 100663563);
		NativeMethodInfoPtr_GetCurrentConfiguration_Private_Static_AndroidConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidApplication>.NativeClassPtr, 100663564);
		NativeMethodInfoPtr_DispatchConfigurationChanged_Private_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidApplication>.NativeClassPtr, 100663565);
		get_CurrentContextRawDelegateField = IL2CPP.ResolveICall<get_CurrentContextRawDelegate>("UnityEngine.Android.AndroidApplication::get_CurrentContextRaw");
		get_CurrentActivityRawDelegateField = IL2CPP.ResolveICall<get_CurrentActivityRawDelegate>("UnityEngine.Android.AndroidApplication::get_CurrentActivityRaw");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151637, XrefRangeEnd = 1151643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AcquireMainThreadSynchronizationContext()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AcquireMainThreadSynchronizationContext_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151643, XrefRangeEnd = 1151647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetCurrentConfiguration(AndroidConfiguration config)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)config);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCurrentConfiguration_Private_Static_Void_AndroidConfiguration_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151647, XrefRangeEnd = 1151649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AndroidConfiguration GetCurrentConfiguration()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCurrentConfiguration_Private_Static_AndroidConfiguration_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AndroidConfiguration>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151649, XrefRangeEnd = 1151651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DispatchConfigurationChanged(bool notifySubscribers)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&notifySubscribers);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DispatchConfigurationChanged_Private_Static_Void_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public AndroidApplication(System.IntPtr pointer)
		: base(pointer)
	{
	}

	[SpecialName]
	public static void add_onConfigurationChanged(Il2CppSystem.Action<AndroidConfiguration> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void remove_onConfigurationChanged(Il2CppSystem.Action<AndroidConfiguration> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static void InvokeOnUIThread(Il2CppSystem.Action action)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static void InvokeOnUnityMainThread(Il2CppSystem.Action action)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}
}
