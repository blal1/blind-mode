using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppZXing.PDF417.Internal;

[DefaultMember("Item")]
public sealed class BarcodeRow : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_row;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentLocation;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Internal_Void_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_addBar_Internal_Void_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getScaledRow_Internal_Il2CppStructArray_1_SByte_Int32_0;

	public unsafe Il2CppStructArray<sbyte> row
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_row);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<sbyte>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_row)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int currentLocation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentLocation);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentLocation)) = value;
		}
	}

	static BarcodeRow()
	{
		Il2CppClassPointerStore<BarcodeRow>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.PDF417.Internal", "BarcodeRow");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BarcodeRow>.NativeClassPtr);
		NativeFieldInfoPtr_row = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BarcodeRow>.NativeClassPtr, "row");
		NativeFieldInfoPtr_currentLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BarcodeRow>.NativeClassPtr, "currentLocation");
		NativeMethodInfoPtr__ctor_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BarcodeRow>.NativeClassPtr, 100663960);
		NativeMethodInfoPtr_set_Internal_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BarcodeRow>.NativeClassPtr, 100663961);
		NativeMethodInfoPtr_addBar_Internal_Void_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BarcodeRow>.NativeClassPtr, 100663962);
		NativeMethodInfoPtr_getScaledRow_Internal_Il2CppStructArray_1_SByte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BarcodeRow>.NativeClassPtr, 100663963);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1419414, RefRangeEnd = 1419416, XrefRangeStart = 1419409, XrefRangeEnd = 1419414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BarcodeRow(int width)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BarcodeRow>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&width);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe void set(int x, bool black)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &black;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Internal_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 1419416, RefRangeEnd = 1419427, XrefRangeStart = 1419416, XrefRangeEnd = 1419416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void addBar(bool black, int width)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&black);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &width;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_addBar_Internal_Void_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419427, XrefRangeEnd = 1419431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStructArray<sbyte> getScaledRow(int scale)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&scale);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getScaledRow_Internal_Il2CppStructArray_1_SByte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<sbyte>>(intPtr2) : null;
	}

	public BarcodeRow(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
