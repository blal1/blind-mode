using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppInternal.Runtime.Augments;

public class RuntimeAugments : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_s_reflectionExecutionDomainCallbacks;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReportUnhandledException_Public_Static_Void_Exception_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Callbacks_Internal_Static_get_ReflectionExecutionDomainCallbacks_0;

	public unsafe static ReflectionExecutionDomainCallbacks s_reflectionExecutionDomainCallbacks
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_reflectionExecutionDomainCallbacks, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ReflectionExecutionDomainCallbacks>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_reflectionExecutionDomainCallbacks, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static ReflectionExecutionDomainCallbacks Callbacks
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701215, XrefRangeEnd = 701219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Callbacks_Internal_Static_get_ReflectionExecutionDomainCallbacks_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ReflectionExecutionDomainCallbacks>(intPtr2) : null;
		}
	}

	static RuntimeAugments()
	{
		Il2CppClassPointerStore<RuntimeAugments>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Internal.Runtime.Augments", "RuntimeAugments");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeAugments>.NativeClassPtr);
		NativeFieldInfoPtr_s_reflectionExecutionDomainCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeAugments>.NativeClassPtr, "s_reflectionExecutionDomainCallbacks");
		NativeMethodInfoPtr_ReportUnhandledException_Public_Static_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeAugments>.NativeClassPtr, 100663862);
		NativeMethodInfoPtr_get_Callbacks_Internal_Static_get_ReflectionExecutionDomainCallbacks_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeAugments>.NativeClassPtr, 100663863);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 701214, RefRangeEnd = 701215, XrefRangeStart = 701203, XrefRangeEnd = 701214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReportUnhandledException(Il2CppSystem.Exception exception)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)exception);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReportUnhandledException_Public_Static_Void_Exception_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public RuntimeAugments(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
