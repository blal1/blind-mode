using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppZXing.Common.ReedSolomon;

public sealed class ReedSolomonEncoder : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_field;

	private static readonly System.IntPtr NativeFieldInfoPtr_cachedGenerators;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_GenericGF_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_buildGenerator_Private_GenericGFPoly_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_encode_Public_Void_Il2CppStructArray_1_Int32_Int32_0;

	public unsafe GenericGF field
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_field);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GenericGF>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_field)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe IList<GenericGFPoly> cachedGenerators
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedGenerators);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IList<GenericGFPoly>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedGenerators)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static ReedSolomonEncoder()
	{
		Il2CppClassPointerStore<ReedSolomonEncoder>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.Common.ReedSolomon", "ReedSolomonEncoder");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReedSolomonEncoder>.NativeClassPtr);
		NativeFieldInfoPtr_field = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReedSolomonEncoder>.NativeClassPtr, "field");
		NativeFieldInfoPtr_cachedGenerators = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReedSolomonEncoder>.NativeClassPtr, "cachedGenerators");
		NativeMethodInfoPtr__ctor_Public_Void_GenericGF_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReedSolomonEncoder>.NativeClassPtr, 100664821);
		NativeMethodInfoPtr_buildGenerator_Private_GenericGFPoly_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReedSolomonEncoder>.NativeClassPtr, 100664822);
		NativeMethodInfoPtr_encode_Public_Void_Il2CppStructArray_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReedSolomonEncoder>.NativeClassPtr, 100664823);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1429762, RefRangeEnd = 1429765, XrefRangeStart = 1429726, XrefRangeEnd = 1429762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ReedSolomonEncoder(GenericGF field)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReedSolomonEncoder>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)field);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GenericGF_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1429806, RefRangeEnd = 1429807, XrefRangeStart = 1429765, XrefRangeEnd = 1429806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GenericGFPoly buildGenerator(int degree)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&degree);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_buildGenerator_Private_GenericGFPoly_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GenericGFPoly>(intPtr2) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1429819, RefRangeEnd = 1429822, XrefRangeStart = 1429807, XrefRangeEnd = 1429819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void encode(Il2CppStructArray<int> toEncode, int ecBytes)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)toEncode);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &ecBytes;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_encode_Public_Void_Il2CppStructArray_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ReedSolomonEncoder(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
