using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppIonic.Zlib;

public sealed class InfTree : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_MANY;

	private static readonly System.IntPtr NativeFieldInfoPtr_Z_OK;

	private static readonly System.IntPtr NativeFieldInfoPtr_Z_STREAM_END;

	private static readonly System.IntPtr NativeFieldInfoPtr_Z_NEED_DICT;

	private static readonly System.IntPtr NativeFieldInfoPtr_Z_ERRNO;

	private static readonly System.IntPtr NativeFieldInfoPtr_Z_STREAM_ERROR;

	private static readonly System.IntPtr NativeFieldInfoPtr_Z_DATA_ERROR;

	private static readonly System.IntPtr NativeFieldInfoPtr_Z_MEM_ERROR;

	private static readonly System.IntPtr NativeFieldInfoPtr_Z_BUF_ERROR;

	private static readonly System.IntPtr NativeFieldInfoPtr_Z_VERSION_ERROR;

	private static readonly System.IntPtr NativeFieldInfoPtr_fixed_bl;

	private static readonly System.IntPtr NativeFieldInfoPtr_fixed_bd;

	private static readonly System.IntPtr NativeFieldInfoPtr_fixed_tl;

	private static readonly System.IntPtr NativeFieldInfoPtr_fixed_td;

	private static readonly System.IntPtr NativeFieldInfoPtr_cplens;

	private static readonly System.IntPtr NativeFieldInfoPtr_cplext;

	private static readonly System.IntPtr NativeFieldInfoPtr_cpdist;

	private static readonly System.IntPtr NativeFieldInfoPtr_cpdext;

	private static readonly System.IntPtr NativeFieldInfoPtr_BMAX;

	private static readonly System.IntPtr NativeFieldInfoPtr_hn;

	private static readonly System.IntPtr NativeFieldInfoPtr_v;

	private static readonly System.IntPtr NativeFieldInfoPtr_c;

	private static readonly System.IntPtr NativeFieldInfoPtr_r;

	private static readonly System.IntPtr NativeFieldInfoPtr_u;

	private static readonly System.IntPtr NativeFieldInfoPtr_x;

	private static readonly System.IntPtr NativeMethodInfoPtr_huft_build_Private_Int32_Il2CppStructArray_1_Int32_Int32_Int32_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_inflate_trees_bits_Internal_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_ZlibCodec_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_inflate_trees_dynamic_Internal_Int32_Int32_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_ZlibCodec_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_inflate_trees_fixed_Internal_Static_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppReferenceArray_1_Il2CppStructArray_1_Int32_Il2CppReferenceArray_1_Il2CppStructArray_1_Int32_ZlibCodec_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_initWorkArea_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static int MANY
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MANY, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MANY, (void*)(&value));
		}
	}

	public unsafe static int Z_OK
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Z_OK, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Z_OK, (void*)(&value));
		}
	}

	public unsafe static int Z_STREAM_END
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Z_STREAM_END, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Z_STREAM_END, (void*)(&value));
		}
	}

	public unsafe static int Z_NEED_DICT
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Z_NEED_DICT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Z_NEED_DICT, (void*)(&value));
		}
	}

	public unsafe static int Z_ERRNO
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Z_ERRNO, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Z_ERRNO, (void*)(&value));
		}
	}

	public unsafe static int Z_STREAM_ERROR
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Z_STREAM_ERROR, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Z_STREAM_ERROR, (void*)(&value));
		}
	}

	public unsafe static int Z_DATA_ERROR
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Z_DATA_ERROR, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Z_DATA_ERROR, (void*)(&value));
		}
	}

	public unsafe static int Z_MEM_ERROR
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Z_MEM_ERROR, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Z_MEM_ERROR, (void*)(&value));
		}
	}

	public unsafe static int Z_BUF_ERROR
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Z_BUF_ERROR, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Z_BUF_ERROR, (void*)(&value));
		}
	}

	public unsafe static int Z_VERSION_ERROR
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Z_VERSION_ERROR, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Z_VERSION_ERROR, (void*)(&value));
		}
	}

	public unsafe static int fixed_bl
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_fixed_bl, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_fixed_bl, (void*)(&value));
		}
	}

	public unsafe static int fixed_bd
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_fixed_bd, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_fixed_bd, (void*)(&value));
		}
	}

	public unsafe static Il2CppStructArray<int> fixed_tl
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_fixed_tl, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_fixed_tl, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<int> fixed_td
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_fixed_td, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_fixed_td, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<int> cplens
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cplens, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cplens, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<int> cplext
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cplext, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cplext, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<int> cpdist
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cpdist, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cpdist, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<int> cpdext
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cpdext, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cpdext, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static int BMAX
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BMAX, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BMAX, (void*)(&value));
		}
	}

	public unsafe Il2CppStructArray<int> hn
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hn);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hn)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<int> v
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_v);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_v)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<int> c
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_c);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_c)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<int> r
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_r);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_r)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<int> u
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_u);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_u)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<int> x
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_x);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_x)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static InfTree()
	{
		Il2CppClassPointerStore<InfTree>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Ionic.Zlib", "InfTree");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InfTree>.NativeClassPtr);
		NativeFieldInfoPtr_MANY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfTree>.NativeClassPtr, "MANY");
		NativeFieldInfoPtr_Z_OK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfTree>.NativeClassPtr, "Z_OK");
		NativeFieldInfoPtr_Z_STREAM_END = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfTree>.NativeClassPtr, "Z_STREAM_END");
		NativeFieldInfoPtr_Z_NEED_DICT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfTree>.NativeClassPtr, "Z_NEED_DICT");
		NativeFieldInfoPtr_Z_ERRNO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfTree>.NativeClassPtr, "Z_ERRNO");
		NativeFieldInfoPtr_Z_STREAM_ERROR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfTree>.NativeClassPtr, "Z_STREAM_ERROR");
		NativeFieldInfoPtr_Z_DATA_ERROR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfTree>.NativeClassPtr, "Z_DATA_ERROR");
		NativeFieldInfoPtr_Z_MEM_ERROR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfTree>.NativeClassPtr, "Z_MEM_ERROR");
		NativeFieldInfoPtr_Z_BUF_ERROR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfTree>.NativeClassPtr, "Z_BUF_ERROR");
		NativeFieldInfoPtr_Z_VERSION_ERROR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfTree>.NativeClassPtr, "Z_VERSION_ERROR");
		NativeFieldInfoPtr_fixed_bl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfTree>.NativeClassPtr, "fixed_bl");
		NativeFieldInfoPtr_fixed_bd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfTree>.NativeClassPtr, "fixed_bd");
		NativeFieldInfoPtr_fixed_tl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfTree>.NativeClassPtr, "fixed_tl");
		NativeFieldInfoPtr_fixed_td = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfTree>.NativeClassPtr, "fixed_td");
		NativeFieldInfoPtr_cplens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfTree>.NativeClassPtr, "cplens");
		NativeFieldInfoPtr_cplext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfTree>.NativeClassPtr, "cplext");
		NativeFieldInfoPtr_cpdist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfTree>.NativeClassPtr, "cpdist");
		NativeFieldInfoPtr_cpdext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfTree>.NativeClassPtr, "cpdext");
		NativeFieldInfoPtr_BMAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfTree>.NativeClassPtr, "BMAX");
		NativeFieldInfoPtr_hn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfTree>.NativeClassPtr, "hn");
		NativeFieldInfoPtr_v = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfTree>.NativeClassPtr, "v");
		NativeFieldInfoPtr_c = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfTree>.NativeClassPtr, "c");
		NativeFieldInfoPtr_r = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfTree>.NativeClassPtr, "r");
		NativeFieldInfoPtr_u = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfTree>.NativeClassPtr, "u");
		NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfTree>.NativeClassPtr, "x");
		NativeMethodInfoPtr_huft_build_Private_Int32_Il2CppStructArray_1_Int32_Int32_Int32_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfTree>.NativeClassPtr, 100664292);
		NativeMethodInfoPtr_inflate_trees_bits_Internal_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_ZlibCodec_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfTree>.NativeClassPtr, 100664293);
		NativeMethodInfoPtr_inflate_trees_dynamic_Internal_Int32_Int32_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_ZlibCodec_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfTree>.NativeClassPtr, 100664294);
		NativeMethodInfoPtr_inflate_trees_fixed_Internal_Static_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppReferenceArray_1_Il2CppStructArray_1_Int32_Il2CppReferenceArray_1_Il2CppStructArray_1_Int32_ZlibCodec_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfTree>.NativeClassPtr, 100664295);
		NativeMethodInfoPtr_initWorkArea_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfTree>.NativeClassPtr, 100664296);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfTree>.NativeClassPtr, 100664297);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 41274, RefRangeEnd = 41277, XrefRangeStart = 41268, XrefRangeEnd = 41274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int huft_build(Il2CppStructArray<int> b, int bindex, int n, int s, Il2CppStructArray<int> d, Il2CppStructArray<int> e, Il2CppStructArray<int> t, Il2CppStructArray<int> m, Il2CppStructArray<int> hp, Il2CppStructArray<int> hn, Il2CppStructArray<int> v)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[11];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)b);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bindex;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &n;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &s;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)d);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)e);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)t);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)m);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hp);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hn);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)v);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_huft_build_Private_Int32_Il2CppStructArray_1_Int32_Int32_Int32_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 41288, RefRangeEnd = 41289, XrefRangeStart = 41277, XrefRangeEnd = 41288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int inflate_trees_bits(Il2CppStructArray<int> c, Il2CppStructArray<int> bb, Il2CppStructArray<int> tb, Il2CppStructArray<int> hp, ZlibCodec z)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)c);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bb);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tb);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hp);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)z);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_inflate_trees_bits_Internal_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_ZlibCodec_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 41309, RefRangeEnd = 41310, XrefRangeStart = 41289, XrefRangeEnd = 41309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int inflate_trees_dynamic(int nl, int nd, Il2CppStructArray<int> c, Il2CppStructArray<int> bl, Il2CppStructArray<int> bd, Il2CppStructArray<int> tl, Il2CppStructArray<int> td, Il2CppStructArray<int> hp, ZlibCodec z)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[9];
		*ptr = (nint)(&nl);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &nd;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)c);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bl);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tl);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)td);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hp);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)z);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_inflate_trees_dynamic_Internal_Int32_Int32_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_ZlibCodec_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 41317, RefRangeEnd = 41318, XrefRangeStart = 41310, XrefRangeEnd = 41317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int inflate_trees_fixed(Il2CppStructArray<int> bl, Il2CppStructArray<int> bd, Il2CppReferenceArray<Il2CppStructArray<int>> tl, Il2CppReferenceArray<Il2CppStructArray<int>> td, ZlibCodec z)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bl);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tl);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)td);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)z);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_inflate_trees_fixed_Internal_Static_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppReferenceArray_1_Il2CppStructArray_1_Int32_Il2CppReferenceArray_1_Il2CppStructArray_1_Int32_ZlibCodec_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 41346, RefRangeEnd = 41349, XrefRangeStart = 41318, XrefRangeEnd = 41346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void initWorkArea(int vsize)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&vsize);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_initWorkArea_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InfTree()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InfTree>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public InfTree(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
