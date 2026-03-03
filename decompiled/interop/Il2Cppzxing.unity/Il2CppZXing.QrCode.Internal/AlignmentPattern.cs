using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppZXing.QrCode.Internal;

public sealed class AlignmentPattern : ResultPoint
{
	private static readonly IntPtr NativeFieldInfoPtr_estimatedModuleSize;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Single_Single_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_aboutEquals_Internal_Boolean_Single_Single_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_combineEstimate_Internal_AlignmentPattern_Single_Single_Single_0;

	public unsafe float estimatedModuleSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_estimatedModuleSize);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_estimatedModuleSize)) = value;
		}
	}

	static AlignmentPattern()
	{
		Il2CppClassPointerStore<AlignmentPattern>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.QrCode.Internal", "AlignmentPattern");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AlignmentPattern>.NativeClassPtr);
		NativeFieldInfoPtr_estimatedModuleSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlignmentPattern>.NativeClassPtr, "estimatedModuleSize");
		NativeMethodInfoPtr__ctor_Internal_Void_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlignmentPattern>.NativeClassPtr, 100663647);
		NativeMethodInfoPtr_aboutEquals_Internal_Boolean_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlignmentPattern>.NativeClassPtr, 100663648);
		NativeMethodInfoPtr_combineEstimate_Internal_AlignmentPattern_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlignmentPattern>.NativeClassPtr, 100663649);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416463, XrefRangeEnd = 1416464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AlignmentPattern(float posX, float posY, float estimatedModuleSize)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AlignmentPattern>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = (nint)(&posX);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &posY;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &estimatedModuleSize;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416464, XrefRangeEnd = 1416473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool aboutEquals(float moduleSize, float i, float j)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = (nint)(&moduleSize);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &i;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &j;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_aboutEquals_Internal_Boolean_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1416477, RefRangeEnd = 1416478, XrefRangeStart = 1416473, XrefRangeEnd = 1416477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AlignmentPattern combineEstimate(float i, float j, float newModuleSize)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = (nint)(&i);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &j;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &newModuleSize;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_combineEstimate_Internal_AlignmentPattern_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<AlignmentPattern>(intPtr2) : null;
	}

	public AlignmentPattern(IntPtr pointer)
		: base(pointer)
	{
	}
}
