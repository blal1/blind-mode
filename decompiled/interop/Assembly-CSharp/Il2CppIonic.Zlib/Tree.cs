using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppIonic.Zlib;

public sealed class Tree : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_HEAP_SIZE;

	private static readonly System.IntPtr NativeFieldInfoPtr_ExtraLengthBits;

	private static readonly System.IntPtr NativeFieldInfoPtr_ExtraDistanceBits;

	private static readonly System.IntPtr NativeFieldInfoPtr_extra_blbits;

	private static readonly System.IntPtr NativeFieldInfoPtr_bl_order;

	private static readonly System.IntPtr NativeFieldInfoPtr_Buf_size;

	private static readonly System.IntPtr NativeFieldInfoPtr__dist_code;

	private static readonly System.IntPtr NativeFieldInfoPtr_LengthCode;

	private static readonly System.IntPtr NativeFieldInfoPtr_LengthBase;

	private static readonly System.IntPtr NativeFieldInfoPtr_DistanceBase;

	private static readonly System.IntPtr NativeFieldInfoPtr_dyn_tree;

	private static readonly System.IntPtr NativeFieldInfoPtr_max_code;

	private static readonly System.IntPtr NativeFieldInfoPtr_staticTree;

	private static readonly System.IntPtr NativeMethodInfoPtr_DistanceCode_Internal_Static_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_gen_bitlen_Internal_Void_DeflateManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_build_tree_Internal_Void_DeflateManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_gen_codes_Internal_Static_Void_Il2CppStructArray_1_Int16_Int32_Il2CppStructArray_1_Int16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_bi_reverse_Internal_Static_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static int HEAP_SIZE
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HEAP_SIZE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HEAP_SIZE, (void*)(&value));
		}
	}

	public unsafe static Il2CppStructArray<int> ExtraLengthBits
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ExtraLengthBits, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ExtraLengthBits, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<int> ExtraDistanceBits
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ExtraDistanceBits, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ExtraDistanceBits, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<int> extra_blbits
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_extra_blbits, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_extra_blbits, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<sbyte> bl_order
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_bl_order, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<sbyte>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_bl_order, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static int Buf_size
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Buf_size, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Buf_size, (void*)(&value));
		}
	}

	public unsafe static Il2CppStructArray<sbyte> _dist_code
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__dist_code, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<sbyte>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__dist_code, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<sbyte> LengthCode
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LengthCode, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<sbyte>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LengthCode, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<int> LengthBase
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LengthBase, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LengthBase, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<int> DistanceBase
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DistanceBase, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DistanceBase, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<short> dyn_tree
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dyn_tree);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<short>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dyn_tree)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int max_code
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_max_code);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_max_code)) = value;
		}
	}

	public unsafe StaticTree staticTree
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_staticTree);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<StaticTree>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_staticTree)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static Tree()
	{
		Il2CppClassPointerStore<Tree>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Ionic.Zlib", "Tree");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Tree>.NativeClassPtr);
		NativeFieldInfoPtr_HEAP_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tree>.NativeClassPtr, "HEAP_SIZE");
		NativeFieldInfoPtr_ExtraLengthBits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tree>.NativeClassPtr, "ExtraLengthBits");
		NativeFieldInfoPtr_ExtraDistanceBits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tree>.NativeClassPtr, "ExtraDistanceBits");
		NativeFieldInfoPtr_extra_blbits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tree>.NativeClassPtr, "extra_blbits");
		NativeFieldInfoPtr_bl_order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tree>.NativeClassPtr, "bl_order");
		NativeFieldInfoPtr_Buf_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tree>.NativeClassPtr, "Buf_size");
		NativeFieldInfoPtr__dist_code = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tree>.NativeClassPtr, "_dist_code");
		NativeFieldInfoPtr_LengthCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tree>.NativeClassPtr, "LengthCode");
		NativeFieldInfoPtr_LengthBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tree>.NativeClassPtr, "LengthBase");
		NativeFieldInfoPtr_DistanceBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tree>.NativeClassPtr, "DistanceBase");
		NativeFieldInfoPtr_dyn_tree = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tree>.NativeClassPtr, "dyn_tree");
		NativeFieldInfoPtr_max_code = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tree>.NativeClassPtr, "max_code");
		NativeFieldInfoPtr_staticTree = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tree>.NativeClassPtr, "staticTree");
		NativeMethodInfoPtr_DistanceCode_Internal_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tree>.NativeClassPtr, 100664299);
		NativeMethodInfoPtr_gen_bitlen_Internal_Void_DeflateManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tree>.NativeClassPtr, 100664300);
		NativeMethodInfoPtr_build_tree_Internal_Void_DeflateManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tree>.NativeClassPtr, 100664301);
		NativeMethodInfoPtr_gen_codes_Internal_Static_Void_Il2CppStructArray_1_Int16_Int32_Il2CppStructArray_1_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tree>.NativeClassPtr, 100664302);
		NativeMethodInfoPtr_bi_reverse_Internal_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tree>.NativeClassPtr, 100664303);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tree>.NativeClassPtr, 100664304);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 41353, RefRangeEnd = 41355, XrefRangeStart = 41349, XrefRangeEnd = 41353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int DistanceCode(int dist)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&dist);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DistanceCode_Internal_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 41366, RefRangeEnd = 41367, XrefRangeStart = 41355, XrefRangeEnd = 41366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void gen_bitlen(DeflateManager s)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)s);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_gen_bitlen_Internal_Void_DeflateManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 41386, RefRangeEnd = 41390, XrefRangeStart = 41367, XrefRangeEnd = 41386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void build_tree(DeflateManager s)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)s);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_build_tree_Internal_Void_DeflateManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 41404, RefRangeEnd = 41405, XrefRangeStart = 41390, XrefRangeEnd = 41404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void gen_codes(Il2CppStructArray<short> tree, int max_code, Il2CppStructArray<short> bl_count)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tree);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &max_code;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bl_count);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_gen_codes_Internal_Static_Void_Il2CppStructArray_1_Int16_Int32_Il2CppStructArray_1_Int16_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static int bi_reverse(int code, int len)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&code);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &len;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_bi_reverse_Internal_Static_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Tree()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Tree>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public Tree(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
