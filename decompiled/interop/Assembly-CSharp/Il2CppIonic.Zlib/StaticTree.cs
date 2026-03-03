using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppIonic.Zlib;

public sealed class StaticTree : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_lengthAndLiteralsTreeCodes;

	private static readonly System.IntPtr NativeFieldInfoPtr_distTreeCodes;

	private static readonly System.IntPtr NativeFieldInfoPtr_Literals;

	private static readonly System.IntPtr NativeFieldInfoPtr_Distances;

	private static readonly System.IntPtr NativeFieldInfoPtr_BitLengths;

	private static readonly System.IntPtr NativeFieldInfoPtr_treeCodes;

	private static readonly System.IntPtr NativeFieldInfoPtr_extraBits;

	private static readonly System.IntPtr NativeFieldInfoPtr_extraBase;

	private static readonly System.IntPtr NativeFieldInfoPtr_elems;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxLength;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_Il2CppStructArray_1_Int16_Il2CppStructArray_1_Int32_Int32_Int32_Int32_0;

	public unsafe static Il2CppStructArray<short> lengthAndLiteralsTreeCodes
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_lengthAndLiteralsTreeCodes, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<short>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_lengthAndLiteralsTreeCodes, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<short> distTreeCodes
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_distTreeCodes, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<short>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_distTreeCodes, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static StaticTree Literals
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Literals, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<StaticTree>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Literals, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static StaticTree Distances
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Distances, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<StaticTree>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Distances, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static StaticTree BitLengths
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BitLengths, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<StaticTree>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BitLengths, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<short> treeCodes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_treeCodes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<short>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_treeCodes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<int> extraBits
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_extraBits);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_extraBits)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int extraBase
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_extraBase);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_extraBase)) = value;
		}
	}

	public unsafe int elems
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_elems);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_elems)) = value;
		}
	}

	public unsafe int maxLength
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxLength);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxLength)) = value;
		}
	}

	static StaticTree()
	{
		Il2CppClassPointerStore<StaticTree>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Ionic.Zlib", "StaticTree");
		NativeFieldInfoPtr_lengthAndLiteralsTreeCodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticTree>.NativeClassPtr, "lengthAndLiteralsTreeCodes");
		NativeFieldInfoPtr_distTreeCodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticTree>.NativeClassPtr, "distTreeCodes");
		NativeFieldInfoPtr_Literals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticTree>.NativeClassPtr, "Literals");
		NativeFieldInfoPtr_Distances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticTree>.NativeClassPtr, "Distances");
		NativeFieldInfoPtr_BitLengths = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticTree>.NativeClassPtr, "BitLengths");
		NativeFieldInfoPtr_treeCodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticTree>.NativeClassPtr, "treeCodes");
		NativeFieldInfoPtr_extraBits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticTree>.NativeClassPtr, "extraBits");
		NativeFieldInfoPtr_extraBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticTree>.NativeClassPtr, "extraBase");
		NativeFieldInfoPtr_elems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticTree>.NativeClassPtr, "elems");
		NativeFieldInfoPtr_maxLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticTree>.NativeClassPtr, "maxLength");
		NativeMethodInfoPtr__ctor_Private_Void_Il2CppStructArray_1_Int16_Il2CppStructArray_1_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticTree>.NativeClassPtr, 100664314);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41431, XrefRangeEnd = 41434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe StaticTree(Il2CppStructArray<short> treeCodes, Il2CppStructArray<int> extraBits, int extraBase, int elems, int maxLength)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StaticTree>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)treeCodes);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)extraBits);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &extraBase;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &elems;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxLength;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_Il2CppStructArray_1_Int16_Il2CppStructArray_1_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public StaticTree(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
