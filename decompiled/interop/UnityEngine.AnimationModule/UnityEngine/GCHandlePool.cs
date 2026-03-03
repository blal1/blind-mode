using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.InteropServices;

namespace UnityEngine;

public class GCHandlePool : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_handles;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_current;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Alloc_Public_GCHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Alloc_Public_GCHandle_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AllocHandleIfNotNull_Public_IntPtr_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Free_Public_Void_GCHandle_0;

	public unsafe Il2CppStructArray<GCHandle> m_handles
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_handles);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<GCHandle>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_handles)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int m_current
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_current);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_current)) = value;
		}
	}

	static GCHandlePool()
	{
		Il2CppClassPointerStore<GCHandlePool>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine", "GCHandlePool");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GCHandlePool>.NativeClassPtr);
		NativeFieldInfoPtr_m_handles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GCHandlePool>.NativeClassPtr, "m_handles");
		NativeFieldInfoPtr_m_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GCHandlePool>.NativeClassPtr, "m_current");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GCHandlePool>.NativeClassPtr, 100663555);
		NativeMethodInfoPtr_Alloc_Public_GCHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GCHandlePool>.NativeClassPtr, 100663556);
		NativeMethodInfoPtr_Alloc_Public_GCHandle_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GCHandlePool>.NativeClassPtr, 100663557);
		NativeMethodInfoPtr_AllocHandleIfNotNull_Public_IntPtr_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GCHandlePool>.NativeClassPtr, 100663558);
		NativeMethodInfoPtr_Free_Public_Void_GCHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GCHandlePool>.NativeClassPtr, 100663559);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1153732, XrefRangeEnd = 1153737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GCHandlePool()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GCHandlePool>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1153737, XrefRangeEnd = 1153738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GCHandle Alloc()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Alloc_Public_GCHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(GCHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 1153742, RefRangeEnd = 1153751, XrefRangeStart = 1153738, XrefRangeEnd = 1153742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GCHandle Alloc(Il2CppSystem.Object o)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)o);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Alloc_Public_GCHandle_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(GCHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1153751, XrefRangeEnd = 1153752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe System.IntPtr AllocHandleIfNotNull(Il2CppSystem.Object o)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)o);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AllocHandleIfNotNull_Public_IntPtr_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1153761, RefRangeEnd = 1153765, XrefRangeStart = 1153752, XrefRangeEnd = 1153761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Free(GCHandle h)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&h);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Free_Public_Void_GCHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public GCHandlePool(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
