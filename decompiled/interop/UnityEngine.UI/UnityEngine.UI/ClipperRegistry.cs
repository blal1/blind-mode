using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.UI.Collections;

namespace UnityEngine.UI;

public class ClipperRegistry : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_s_Instance;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Clippers;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_instance_Public_Static_get_ClipperRegistry_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Cull_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Register_Public_Static_Void_IClipper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Unregister_Public_Static_Void_IClipper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Disable_Public_Static_Void_IClipper_0;

	public unsafe static ClipperRegistry s_Instance
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_Instance, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ClipperRegistry>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_Instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe IndexedSet<IClipper> m_Clippers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Clippers);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IndexedSet<IClipper>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Clippers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static ClipperRegistry instance
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1286102, RefRangeEnd = 1286106, XrefRangeStart = 1286087, XrefRangeEnd = 1286102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_instance_Public_Static_get_ClipperRegistry_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ClipperRegistry>(intPtr2) : null;
		}
	}

	static ClipperRegistry()
	{
		Il2CppClassPointerStore<ClipperRegistry>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "ClipperRegistry");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClipperRegistry>.NativeClassPtr);
		NativeFieldInfoPtr_s_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperRegistry>.NativeClassPtr, "s_Instance");
		NativeFieldInfoPtr_m_Clippers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperRegistry>.NativeClassPtr, "m_Clippers");
		NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperRegistry>.NativeClassPtr, 100663371);
		NativeMethodInfoPtr_get_instance_Public_Static_get_ClipperRegistry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperRegistry>.NativeClassPtr, 100663372);
		NativeMethodInfoPtr_Cull_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperRegistry>.NativeClassPtr, 100663373);
		NativeMethodInfoPtr_Register_Public_Static_Void_IClipper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperRegistry>.NativeClassPtr, 100663374);
		NativeMethodInfoPtr_Unregister_Public_Static_Void_IClipper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperRegistry>.NativeClassPtr, 100663375);
		NativeMethodInfoPtr_Disable_Public_Static_Void_IClipper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperRegistry>.NativeClassPtr, 100663376);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1286079, XrefRangeEnd = 1286087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ClipperRegistry()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClipperRegistry>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1286106, XrefRangeEnd = 1286113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Cull()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Cull_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1286117, RefRangeEnd = 1286118, XrefRangeStart = 1286113, XrefRangeEnd = 1286117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Register(IClipper c)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)c);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Register_Public_Static_Void_IClipper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1286123, RefRangeEnd = 1286124, XrefRangeStart = 1286118, XrefRangeEnd = 1286123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Unregister(IClipper c)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)c);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Unregister_Public_Static_Void_IClipper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1286129, RefRangeEnd = 1286130, XrefRangeStart = 1286124, XrefRangeEnd = 1286129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Disable(IClipper c)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)c);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Disable_Public_Static_Void_IClipper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ClipperRegistry(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
