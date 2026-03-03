using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine;

public sealed class ColorUsageAttribute : PropertyAttribute
{
	private static readonly IntPtr NativeFieldInfoPtr_showAlpha;

	private static readonly IntPtr NativeFieldInfoPtr_hdr;

	private static readonly IntPtr NativeFieldInfoPtr_minBrightness;

	private static readonly IntPtr NativeFieldInfoPtr_maxBrightness;

	private static readonly IntPtr NativeFieldInfoPtr_minExposureValue;

	private static readonly IntPtr NativeFieldInfoPtr_maxExposureValue;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_0;

	public unsafe bool showAlpha
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showAlpha);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showAlpha)) = value;
		}
	}

	public unsafe bool hdr
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hdr);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hdr)) = value;
		}
	}

	public unsafe float minBrightness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minBrightness);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minBrightness)) = value;
		}
	}

	public unsafe float maxBrightness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxBrightness);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxBrightness)) = value;
		}
	}

	public unsafe float minExposureValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minExposureValue);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minExposureValue)) = value;
		}
	}

	public unsafe float maxExposureValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxExposureValue);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxExposureValue)) = value;
		}
	}

	static ColorUsageAttribute()
	{
		Il2CppClassPointerStore<ColorUsageAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ColorUsageAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorUsageAttribute>.NativeClassPtr);
		NativeFieldInfoPtr_showAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorUsageAttribute>.NativeClassPtr, "showAlpha");
		NativeFieldInfoPtr_hdr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorUsageAttribute>.NativeClassPtr, "hdr");
		NativeFieldInfoPtr_minBrightness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorUsageAttribute>.NativeClassPtr, "minBrightness");
		NativeFieldInfoPtr_maxBrightness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorUsageAttribute>.NativeClassPtr, "maxBrightness");
		NativeFieldInfoPtr_minExposureValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorUsageAttribute>.NativeClassPtr, "minExposureValue");
		NativeFieldInfoPtr_maxExposureValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorUsageAttribute>.NativeClassPtr, "maxExposureValue");
		NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUsageAttribute>.NativeClassPtr, 100666070);
		NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUsageAttribute>.NativeClassPtr, 100666071);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1185294, XrefRangeEnd = 1185295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ColorUsageAttribute(bool showAlpha)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorUsageAttribute>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&showAlpha);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1185295, XrefRangeEnd = 1185296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ColorUsageAttribute(bool showAlpha, bool hdr)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorUsageAttribute>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&showAlpha);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &hdr;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ColorUsageAttribute(IntPtr pointer)
		: base(pointer)
	{
	}
}
