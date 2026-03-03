using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppZXing;

public sealed class InvertedLuminanceSource : LuminanceSource
{
	private static readonly IntPtr NativeFieldInfoPtr_delegate;

	private static readonly IntPtr NativeFieldInfoPtr_invertedMatrix;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_LuminanceSource_0;

	private static readonly IntPtr NativeMethodInfoPtr_getRow_Public_Virtual_Il2CppStructArray_1_Byte_Int32_Il2CppStructArray_1_Byte_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_Matrix_Public_Virtual_get_Il2CppStructArray_1_Byte_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_RotateSupported_Public_Virtual_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_invert_Public_Virtual_LuminanceSource_0;

	private static readonly IntPtr NativeMethodInfoPtr_rotateCounterClockwise_Public_Virtual_LuminanceSource_0;

	public unsafe LuminanceSource @delegate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_delegate);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<LuminanceSource>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_delegate)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<byte> invertedMatrix
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_invertedMatrix);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_invertedMatrix)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe override Il2CppStructArray<byte> Matrix
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1412630, XrefRangeEnd = 1412634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Matrix_Public_Virtual_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
		}
	}

	public unsafe override bool RotateSupported
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RotateSupported_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static InvertedLuminanceSource()
	{
		Il2CppClassPointerStore<InvertedLuminanceSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing", "InvertedLuminanceSource");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InvertedLuminanceSource>.NativeClassPtr);
		NativeFieldInfoPtr_delegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvertedLuminanceSource>.NativeClassPtr, "delegate");
		NativeFieldInfoPtr_invertedMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvertedLuminanceSource>.NativeClassPtr, "invertedMatrix");
		NativeMethodInfoPtr__ctor_Public_Void_LuminanceSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvertedLuminanceSource>.NativeClassPtr, 100663440);
		NativeMethodInfoPtr_getRow_Public_Virtual_Il2CppStructArray_1_Byte_Int32_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvertedLuminanceSource>.NativeClassPtr, 100663441);
		NativeMethodInfoPtr_get_Matrix_Public_Virtual_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvertedLuminanceSource>.NativeClassPtr, 100663442);
		NativeMethodInfoPtr_get_RotateSupported_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvertedLuminanceSource>.NativeClassPtr, 100663443);
		NativeMethodInfoPtr_invert_Public_Virtual_LuminanceSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvertedLuminanceSource>.NativeClassPtr, 100663444);
		NativeMethodInfoPtr_rotateCounterClockwise_Public_Virtual_LuminanceSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvertedLuminanceSource>.NativeClassPtr, 100663445);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1412627, XrefRangeEnd = 1412630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InvertedLuminanceSource(LuminanceSource @delegate)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvertedLuminanceSource>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@delegate);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_LuminanceSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe override Il2CppStructArray<byte> getRow(int y, Il2CppStructArray<byte> row)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&y);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)row);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getRow_Public_Virtual_Il2CppStructArray_1_Byte_Int32_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 25665, RefRangeEnd = 25677, XrefRangeStart = 25665, XrefRangeEnd = 25677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override LuminanceSource invert()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_invert_Public_Virtual_LuminanceSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<LuminanceSource>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1412634, XrefRangeEnd = 1412639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override LuminanceSource rotateCounterClockwise()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_rotateCounterClockwise_Public_Virtual_LuminanceSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<LuminanceSource>(intPtr2) : null;
	}

	public InvertedLuminanceSource(IntPtr pointer)
		: base(pointer)
	{
	}
}
