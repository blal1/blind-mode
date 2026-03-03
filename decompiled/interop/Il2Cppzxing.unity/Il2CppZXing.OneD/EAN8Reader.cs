using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;
using Il2CppZXing.Common;

namespace Il2CppZXing.OneD;

public sealed class EAN8Reader : UPCEANReader
{
	private static readonly IntPtr NativeFieldInfoPtr_decodeMiddleCounters;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_decodeMiddle_FamOrAssem_Virtual_Int32_BitArray_Il2CppStructArray_1_Int32_StringBuilder_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_BarcodeFormat_Internal_Virtual_get_BarcodeFormat_0;

	public unsafe Il2CppStructArray<int> decodeMiddleCounters
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_decodeMiddleCounters);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_decodeMiddleCounters)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe override BarcodeFormat BarcodeFormat
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_BarcodeFormat_Internal_Virtual_get_BarcodeFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(BarcodeFormat*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static EAN8Reader()
	{
		Il2CppClassPointerStore<EAN8Reader>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.OneD", "EAN8Reader");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EAN8Reader>.NativeClassPtr);
		NativeFieldInfoPtr_decodeMiddleCounters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EAN8Reader>.NativeClassPtr, "decodeMiddleCounters");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EAN8Reader>.NativeClassPtr, 100664104);
		NativeMethodInfoPtr_decodeMiddle_FamOrAssem_Virtual_Int32_BitArray_Il2CppStructArray_1_Int32_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EAN8Reader>.NativeClassPtr, 100664105);
		NativeMethodInfoPtr_get_BarcodeFormat_Internal_Virtual_get_BarcodeFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EAN8Reader>.NativeClassPtr, 100664106);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1421511, RefRangeEnd = 1421513, XrefRangeStart = 1421503, XrefRangeEnd = 1421511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EAN8Reader()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EAN8Reader>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1421513, XrefRangeEnd = 1421530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override int decodeMiddle(BitArray row, Il2CppStructArray<int> startRange, StringBuilder result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)row);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)startRange);
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decodeMiddle_FamOrAssem_Virtual_Int32_BitArray_Il2CppStructArray_1_Int32_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public EAN8Reader(IntPtr pointer)
		: base(pointer)
	{
	}
}
