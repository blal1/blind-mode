using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppTMPro;

public class Compute_DT_EventArgs : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_EventType;

	private static readonly System.IntPtr NativeFieldInfoPtr_ProgressPercentage;

	private static readonly System.IntPtr NativeFieldInfoPtr_Colors;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Compute_DistanceTransform_EventTypes_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Compute_DistanceTransform_EventTypes_Il2CppStructArray_1_Color_0;

	public unsafe Compute_DistanceTransform_EventTypes EventType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EventType);
			return *(Compute_DistanceTransform_EventTypes*)num;
		}
		set
		{
			*(Compute_DistanceTransform_EventTypes*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EventType)) = value;
		}
	}

	public unsafe float ProgressPercentage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ProgressPercentage);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ProgressPercentage)) = value;
		}
	}

	public unsafe Il2CppStructArray<Color> Colors
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Colors);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Colors)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static Compute_DT_EventArgs()
	{
		Il2CppClassPointerStore<Compute_DT_EventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "Compute_DT_EventArgs");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Compute_DT_EventArgs>.NativeClassPtr);
		NativeFieldInfoPtr_EventType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Compute_DT_EventArgs>.NativeClassPtr, "EventType");
		NativeFieldInfoPtr_ProgressPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Compute_DT_EventArgs>.NativeClassPtr, "ProgressPercentage");
		NativeFieldInfoPtr_Colors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Compute_DT_EventArgs>.NativeClassPtr, "Colors");
		NativeMethodInfoPtr__ctor_Public_Void_Compute_DistanceTransform_EventTypes_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compute_DT_EventArgs>.NativeClassPtr, 100663588);
		NativeMethodInfoPtr__ctor_Public_Void_Compute_DistanceTransform_EventTypes_Il2CppStructArray_1_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compute_DT_EventArgs>.NativeClassPtr, 100663589);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119762, XrefRangeEnd = 1119763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Compute_DT_EventArgs(Compute_DistanceTransform_EventTypes type, float progress)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Compute_DT_EventArgs>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&type);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &progress;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Compute_DistanceTransform_EventTypes_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(171)]
	[CachedScanResults(RefRangeStart = 351582, RefRangeEnd = 351753, XrefRangeStart = 351582, XrefRangeEnd = 351753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Compute_DT_EventArgs(Compute_DistanceTransform_EventTypes type, Il2CppStructArray<Color> colors)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Compute_DT_EventArgs>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)colors);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Compute_DistanceTransform_EventTypes_Il2CppStructArray_1_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public Compute_DT_EventArgs(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
