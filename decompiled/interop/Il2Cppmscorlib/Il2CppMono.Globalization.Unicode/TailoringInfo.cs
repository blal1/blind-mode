using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Il2CppMono.Globalization.Unicode;

public class TailoringInfo : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_LCID;

	private static readonly System.IntPtr NativeFieldInfoPtr_TailoringIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_TailoringCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_FrenchSort;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Boolean_0;

	public unsafe int LCID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LCID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LCID)) = value;
		}
	}

	public unsafe int TailoringIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TailoringIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TailoringIndex)) = value;
		}
	}

	public unsafe int TailoringCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TailoringCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TailoringCount)) = value;
		}
	}

	public unsafe bool FrenchSort
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FrenchSort);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FrenchSort)) = value;
		}
	}

	static TailoringInfo()
	{
		Il2CppClassPointerStore<TailoringInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Globalization.Unicode", "TailoringInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TailoringInfo>.NativeClassPtr);
		NativeFieldInfoPtr_LCID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TailoringInfo>.NativeClassPtr, "LCID");
		NativeFieldInfoPtr_TailoringIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TailoringInfo>.NativeClassPtr, "TailoringIndex");
		NativeFieldInfoPtr_TailoringCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TailoringInfo>.NativeClassPtr, "TailoringCount");
		NativeFieldInfoPtr_FrenchSort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TailoringInfo>.NativeClassPtr, "FrenchSort");
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TailoringInfo>.NativeClassPtr, 100663474);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 655505, RefRangeEnd = 655509, XrefRangeStart = 655505, XrefRangeEnd = 655509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TailoringInfo(int lcid, int tailoringIndex, int tailoringCount, bool frenchSort)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TailoringInfo>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&lcid);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &tailoringIndex;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &tailoringCount;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &frenchSort;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public TailoringInfo(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
