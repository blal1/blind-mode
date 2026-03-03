using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono;

public static class DependencyInjector : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_locker;

	private static readonly System.IntPtr NativeFieldInfoPtr_systemDependency;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_SystemProvider_Internal_Static_get_ISystemDependencyProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Register_Internal_Static_Void_ISystemDependencyProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReflectionLoad_Private_Static_ISystemDependencyProvider_0;

	public unsafe static Il2CppSystem.Object locker
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_locker, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_locker, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static ISystemDependencyProvider systemDependency
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_systemDependency, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ISystemDependencyProvider>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_systemDependency, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static ISystemDependencyProvider SystemProvider
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 696454, RefRangeEnd = 696455, XrefRangeStart = 696412, XrefRangeEnd = 696454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_SystemProvider_Internal_Static_get_ISystemDependencyProvider_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ISystemDependencyProvider>(intPtr2) : null;
		}
	}

	static DependencyInjector()
	{
		Il2CppClassPointerStore<DependencyInjector>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono", "DependencyInjector");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DependencyInjector>.NativeClassPtr);
		NativeFieldInfoPtr_locker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DependencyInjector>.NativeClassPtr, "locker");
		NativeFieldInfoPtr_systemDependency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DependencyInjector>.NativeClassPtr, "systemDependency");
		NativeMethodInfoPtr_get_SystemProvider_Internal_Static_get_ISystemDependencyProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DependencyInjector>.NativeClassPtr, 100663362);
		NativeMethodInfoPtr_Register_Internal_Static_Void_ISystemDependencyProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DependencyInjector>.NativeClassPtr, 100663363);
		NativeMethodInfoPtr_ReflectionLoad_Private_Static_ISystemDependencyProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DependencyInjector>.NativeClassPtr, 100663364);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 696472, RefRangeEnd = 696474, XrefRangeStart = 696455, XrefRangeEnd = 696472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Register(ISystemDependencyProvider provider)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Register_Internal_Static_Void_ISystemDependencyProvider_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 696474, XrefRangeEnd = 696491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ISystemDependencyProvider ReflectionLoad()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReflectionLoad_Private_Static_ISystemDependencyProvider_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ISystemDependencyProvider>(intPtr2) : null;
	}

	public DependencyInjector(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
