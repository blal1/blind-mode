using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppIonic.Zlib;

public sealed class InflateCodes : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_START;

	private static readonly System.IntPtr NativeFieldInfoPtr_LEN;

	private static readonly System.IntPtr NativeFieldInfoPtr_LENEXT;

	private static readonly System.IntPtr NativeFieldInfoPtr_DIST;

	private static readonly System.IntPtr NativeFieldInfoPtr_DISTEXT;

	private static readonly System.IntPtr NativeFieldInfoPtr_COPY;

	private static readonly System.IntPtr NativeFieldInfoPtr_LIT;

	private static readonly System.IntPtr NativeFieldInfoPtr_WASH;

	private static readonly System.IntPtr NativeFieldInfoPtr_END;

	private static readonly System.IntPtr NativeFieldInfoPtr_BADCODE;

	private static readonly System.IntPtr NativeFieldInfoPtr_mode;

	private static readonly System.IntPtr NativeFieldInfoPtr_len;

	private static readonly System.IntPtr NativeFieldInfoPtr_tree;

	private static readonly System.IntPtr NativeFieldInfoPtr_tree_index;

	private static readonly System.IntPtr NativeFieldInfoPtr_need;

	private static readonly System.IntPtr NativeFieldInfoPtr_lit;

	private static readonly System.IntPtr NativeFieldInfoPtr_bitsToGet;

	private static readonly System.IntPtr NativeFieldInfoPtr_dist;

	private static readonly System.IntPtr NativeFieldInfoPtr_lbits;

	private static readonly System.IntPtr NativeFieldInfoPtr_dbits;

	private static readonly System.IntPtr NativeFieldInfoPtr_ltree;

	private static readonly System.IntPtr NativeFieldInfoPtr_ltree_index;

	private static readonly System.IntPtr NativeFieldInfoPtr_dtree;

	private static readonly System.IntPtr NativeFieldInfoPtr_dtree_index;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Internal_Void_Int32_Int32_Il2CppStructArray_1_Int32_Int32_Il2CppStructArray_1_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Process_Internal_Int32_InflateBlocks_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InflateFast_Internal_Int32_Int32_Int32_Il2CppStructArray_1_Int32_Int32_Il2CppStructArray_1_Int32_Int32_InflateBlocks_ZlibCodec_0;

	public unsafe static int START
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_START, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_START, (void*)(&value));
		}
	}

	public unsafe static int LEN
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LEN, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LEN, (void*)(&value));
		}
	}

	public unsafe static int LENEXT
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LENEXT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LENEXT, (void*)(&value));
		}
	}

	public unsafe static int DIST
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DIST, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DIST, (void*)(&value));
		}
	}

	public unsafe static int DISTEXT
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DISTEXT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DISTEXT, (void*)(&value));
		}
	}

	public unsafe static int COPY
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_COPY, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_COPY, (void*)(&value));
		}
	}

	public unsafe static int LIT
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LIT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LIT, (void*)(&value));
		}
	}

	public unsafe static int WASH
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_WASH, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_WASH, (void*)(&value));
		}
	}

	public unsafe static int END
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_END, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_END, (void*)(&value));
		}
	}

	public unsafe static int BADCODE
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BADCODE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BADCODE, (void*)(&value));
		}
	}

	public unsafe int mode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mode);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mode)) = value;
		}
	}

	public unsafe int len
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_len);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_len)) = value;
		}
	}

	public unsafe Il2CppStructArray<int> tree
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tree);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tree)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int tree_index
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tree_index);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tree_index)) = value;
		}
	}

	public unsafe int need
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_need);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_need)) = value;
		}
	}

	public unsafe int lit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lit);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lit)) = value;
		}
	}

	public unsafe int bitsToGet
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bitsToGet);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bitsToGet)) = value;
		}
	}

	public unsafe int dist
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dist);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dist)) = value;
		}
	}

	public unsafe byte lbits
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lbits);
			return *(byte*)num;
		}
		set
		{
			*(byte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lbits)) = value;
		}
	}

	public unsafe byte dbits
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dbits);
			return *(byte*)num;
		}
		set
		{
			*(byte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dbits)) = value;
		}
	}

	public unsafe Il2CppStructArray<int> ltree
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ltree);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ltree)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int ltree_index
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ltree_index);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ltree_index)) = value;
		}
	}

	public unsafe Il2CppStructArray<int> dtree
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dtree);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dtree)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int dtree_index
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dtree_index);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dtree_index)) = value;
		}
	}

	static InflateCodes()
	{
		Il2CppClassPointerStore<InflateCodes>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Ionic.Zlib", "InflateCodes");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InflateCodes>.NativeClassPtr);
		NativeFieldInfoPtr_START = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InflateCodes>.NativeClassPtr, "START");
		NativeFieldInfoPtr_LEN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InflateCodes>.NativeClassPtr, "LEN");
		NativeFieldInfoPtr_LENEXT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InflateCodes>.NativeClassPtr, "LENEXT");
		NativeFieldInfoPtr_DIST = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InflateCodes>.NativeClassPtr, "DIST");
		NativeFieldInfoPtr_DISTEXT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InflateCodes>.NativeClassPtr, "DISTEXT");
		NativeFieldInfoPtr_COPY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InflateCodes>.NativeClassPtr, "COPY");
		NativeFieldInfoPtr_LIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InflateCodes>.NativeClassPtr, "LIT");
		NativeFieldInfoPtr_WASH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InflateCodes>.NativeClassPtr, "WASH");
		NativeFieldInfoPtr_END = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InflateCodes>.NativeClassPtr, "END");
		NativeFieldInfoPtr_BADCODE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InflateCodes>.NativeClassPtr, "BADCODE");
		NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InflateCodes>.NativeClassPtr, "mode");
		NativeFieldInfoPtr_len = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InflateCodes>.NativeClassPtr, "len");
		NativeFieldInfoPtr_tree = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InflateCodes>.NativeClassPtr, "tree");
		NativeFieldInfoPtr_tree_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InflateCodes>.NativeClassPtr, "tree_index");
		NativeFieldInfoPtr_need = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InflateCodes>.NativeClassPtr, "need");
		NativeFieldInfoPtr_lit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InflateCodes>.NativeClassPtr, "lit");
		NativeFieldInfoPtr_bitsToGet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InflateCodes>.NativeClassPtr, "bitsToGet");
		NativeFieldInfoPtr_dist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InflateCodes>.NativeClassPtr, "dist");
		NativeFieldInfoPtr_lbits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InflateCodes>.NativeClassPtr, "lbits");
		NativeFieldInfoPtr_dbits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InflateCodes>.NativeClassPtr, "dbits");
		NativeFieldInfoPtr_ltree = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InflateCodes>.NativeClassPtr, "ltree");
		NativeFieldInfoPtr_ltree_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InflateCodes>.NativeClassPtr, "ltree_index");
		NativeFieldInfoPtr_dtree = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InflateCodes>.NativeClassPtr, "dtree");
		NativeFieldInfoPtr_dtree_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InflateCodes>.NativeClassPtr, "dtree_index");
		NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InflateCodes>.NativeClassPtr, 100664276);
		NativeMethodInfoPtr_Init_Internal_Void_Int32_Int32_Il2CppStructArray_1_Int32_Int32_Il2CppStructArray_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InflateCodes>.NativeClassPtr, 100664277);
		NativeMethodInfoPtr_Process_Internal_Int32_InflateBlocks_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InflateCodes>.NativeClassPtr, 100664278);
		NativeMethodInfoPtr_InflateFast_Internal_Int32_Int32_Int32_Il2CppStructArray_1_Int32_Int32_Il2CppStructArray_1_Int32_Int32_InflateBlocks_ZlibCodec_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InflateCodes>.NativeClassPtr, 100664279);
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InflateCodes()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InflateCodes>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 41109, RefRangeEnd = 41111, XrefRangeStart = 41106, XrefRangeEnd = 41109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Init(int bl, int bd, Il2CppStructArray<int> tl, int tl_index, Il2CppStructArray<int> td, int td_index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&bl);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bd;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tl);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &tl_index;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)td);
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &td_index;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Init_Internal_Void_Int32_Int32_Il2CppStructArray_1_Int32_Int32_Il2CppStructArray_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 41161, RefRangeEnd = 41162, XrefRangeStart = 41111, XrefRangeEnd = 41161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int Process(InflateBlocks blocks, int r)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)blocks);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &r;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Process_Internal_Int32_InflateBlocks_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 41194, RefRangeEnd = 41195, XrefRangeStart = 41162, XrefRangeEnd = 41194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int InflateFast(int bl, int bd, Il2CppStructArray<int> tl, int tl_index, Il2CppStructArray<int> td, int td_index, InflateBlocks s, ZlibCodec z)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = (nint)(&bl);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bd;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tl);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &tl_index;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)td);
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &td_index;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)z);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InflateFast_Internal_Int32_Int32_Int32_Il2CppStructArray_1_Int32_Int32_Il2CppStructArray_1_Int32_Int32_InflateBlocks_ZlibCodec_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public InflateCodes(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
