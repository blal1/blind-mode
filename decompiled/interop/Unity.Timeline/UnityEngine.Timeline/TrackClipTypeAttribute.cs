using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Timeline;

public class TrackClipTypeAttribute : Il2CppSystem.Attribute
{
	private static readonly System.IntPtr NativeFieldInfoPtr_inspectedType;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowAutoCreate;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_Boolean_0;

	public unsafe Il2CppSystem.Type inspectedType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inspectedType);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Type>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inspectedType)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool allowAutoCreate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowAutoCreate);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowAutoCreate)) = value;
		}
	}

	static TrackClipTypeAttribute()
	{
		Il2CppClassPointerStore<TrackClipTypeAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "TrackClipTypeAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrackClipTypeAttribute>.NativeClassPtr);
		NativeFieldInfoPtr_inspectedType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackClipTypeAttribute>.NativeClassPtr, "inspectedType");
		NativeFieldInfoPtr_allowAutoCreate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackClipTypeAttribute>.NativeClassPtr, "allowAutoCreate");
		NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackClipTypeAttribute>.NativeClassPtr, 100664080);
		NativeMethodInfoPtr__ctor_Public_Void_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackClipTypeAttribute>.NativeClassPtr, 100664081);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141269, XrefRangeEnd = 1141271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TrackClipTypeAttribute(Il2CppSystem.Type clipClass)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrackClipTypeAttribute>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)clipClass);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 684810, RefRangeEnd = 684814, XrefRangeStart = 684810, XrefRangeEnd = 684814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TrackClipTypeAttribute(Il2CppSystem.Type clipClass, bool allowAutoCreate)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrackClipTypeAttribute>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)clipClass);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &allowAutoCreate;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Type_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public TrackClipTypeAttribute(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
