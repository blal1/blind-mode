using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Runtime.CompilerServices;

[System.Serializable]
public sealed class DecimalConstantAttribute : Attribute
{
	private static readonly System.IntPtr NativeFieldInfoPtr__dec;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Byte_Byte_UInt32_UInt32_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Value_Public_get_Decimal_0;

	public unsafe Decimal _dec
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__dec);
			return *(Decimal*)num;
		}
		set
		{
			*(Decimal*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__dec)) = value;
		}
	}

	public unsafe Decimal Value
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 739711, RefRangeEnd = 739712, XrefRangeStart = 739711, XrefRangeEnd = 739712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Value_Public_get_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Decimal*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static DecimalConstantAttribute()
	{
		Il2CppClassPointerStore<DecimalConstantAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "DecimalConstantAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecimalConstantAttribute>.NativeClassPtr);
		NativeFieldInfoPtr__dec = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecimalConstantAttribute>.NativeClassPtr, "_dec");
		NativeMethodInfoPtr__ctor_Public_Void_Byte_Byte_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecimalConstantAttribute>.NativeClassPtr, 100671378);
		NativeMethodInfoPtr_get_Value_Public_get_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecimalConstantAttribute>.NativeClassPtr, 100671379);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 805592, XrefRangeEnd = 805594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DecimalConstantAttribute(byte scale, byte sign, uint hi, uint mid, uint low)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecimalConstantAttribute>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&scale);
		*(byte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sign;
		*(uint**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &hi;
		*(uint**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &mid;
		*(uint**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &low;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Byte_Byte_UInt32_UInt32_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public DecimalConstantAttribute(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
