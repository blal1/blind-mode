using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppZXing.Common;

namespace Il2CppZXing.Maxicode.Internal;

public sealed class BitMatrixParser : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_BITNR;

	private static readonly System.IntPtr NativeFieldInfoPtr_bitMatrix;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_BitMatrix_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_readCodewords_Internal_Il2CppStructArray_1_Byte_0;

	public unsafe static Il2CppReferenceArray<Il2CppStructArray<int>> BITNR
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BITNR, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<int>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BITNR, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe BitMatrix bitMatrix
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bitMatrix);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BitMatrix>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bitMatrix)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static BitMatrixParser()
	{
		Il2CppClassPointerStore<BitMatrixParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.Maxicode.Internal", "BitMatrixParser");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BitMatrixParser>.NativeClassPtr);
		NativeFieldInfoPtr_BITNR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitMatrixParser>.NativeClassPtr, "BITNR");
		NativeFieldInfoPtr_bitMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitMatrixParser>.NativeClassPtr, "bitMatrix");
		NativeMethodInfoPtr__ctor_Internal_Void_BitMatrix_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitMatrixParser>.NativeClassPtr, 100664433);
		NativeMethodInfoPtr_readCodewords_Internal_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitMatrixParser>.NativeClassPtr, 100664434);
	}

	[CallerCount(215)]
	[CachedScanResults(RefRangeStart = 79185, RefRangeEnd = 79400, XrefRangeStart = 79185, XrefRangeEnd = 79400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BitMatrixParser(BitMatrix bitMatrix)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BitMatrixParser>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bitMatrix);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_BitMatrix_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1425576, RefRangeEnd = 1425577, XrefRangeStart = 1425567, XrefRangeEnd = 1425576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStructArray<byte> readCodewords()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_readCodewords_Internal_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
	}

	public BitMatrixParser(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
