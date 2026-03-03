using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppIonic.Zlib;

public sealed class InflateManager : Il2CppSystem.Object
{
	[OriginalName("Assembly-CSharp.dll", "", "InflateManagerMode")]
	public enum InflateManagerMode
	{
		METHOD,
		FLAG,
		DICT4,
		DICT3,
		DICT2,
		DICT1,
		DICT0,
		BLOCKS,
		CHECK4,
		CHECK3,
		CHECK2,
		CHECK1,
		DONE,
		BAD
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_PRESET_DICT;

	private static readonly System.IntPtr NativeFieldInfoPtr_Z_DEFLATED;

	private static readonly System.IntPtr NativeFieldInfoPtr_mode;

	private static readonly System.IntPtr NativeFieldInfoPtr__codec;

	private static readonly System.IntPtr NativeFieldInfoPtr_method;

	private static readonly System.IntPtr NativeFieldInfoPtr_computedCheck;

	private static readonly System.IntPtr NativeFieldInfoPtr_expectedCheck;

	private static readonly System.IntPtr NativeFieldInfoPtr_marker;

	private static readonly System.IntPtr NativeFieldInfoPtr__handleRfc1950HeaderBytes;

	private static readonly System.IntPtr NativeFieldInfoPtr_wbits;

	private static readonly System.IntPtr NativeFieldInfoPtr_blocks;

	private static readonly System.IntPtr NativeFieldInfoPtr_mark;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_HandleRfc1950HeaderBytes_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_HandleRfc1950HeaderBytes_Internal_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Internal_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_End_Internal_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Internal_Int32_ZlibCodec_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Inflate_Internal_Int32_FlushType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDictionary_Internal_Int32_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Sync_Internal_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SyncPoint_Internal_Int32_ZlibCodec_0;

	public unsafe static int PRESET_DICT
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PRESET_DICT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PRESET_DICT, (void*)(&value));
		}
	}

	public unsafe static int Z_DEFLATED
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Z_DEFLATED, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Z_DEFLATED, (void*)(&value));
		}
	}

	public unsafe InflateManagerMode mode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mode);
			return *(InflateManagerMode*)num;
		}
		set
		{
			*(InflateManagerMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mode)) = value;
		}
	}

	public unsafe ZlibCodec _codec
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__codec);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ZlibCodec>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__codec)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int method
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_method);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_method)) = value;
		}
	}

	public unsafe uint computedCheck
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_computedCheck);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_computedCheck)) = value;
		}
	}

	public unsafe uint expectedCheck
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_expectedCheck);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_expectedCheck)) = value;
		}
	}

	public unsafe int marker
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_marker);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_marker)) = value;
		}
	}

	public unsafe bool _handleRfc1950HeaderBytes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__handleRfc1950HeaderBytes);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__handleRfc1950HeaderBytes)) = value;
		}
	}

	public unsafe int wbits
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wbits);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wbits)) = value;
		}
	}

	public unsafe InflateBlocks blocks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blocks);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InflateBlocks>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blocks)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<byte> mark
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_mark, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_mark, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool HandleRfc1950HeaderBytes
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_HandleRfc1950HeaderBytes_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_HandleRfc1950HeaderBytes_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static InflateManager()
	{
		Il2CppClassPointerStore<InflateManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Ionic.Zlib", "InflateManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InflateManager>.NativeClassPtr);
		NativeFieldInfoPtr_PRESET_DICT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InflateManager>.NativeClassPtr, "PRESET_DICT");
		NativeFieldInfoPtr_Z_DEFLATED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InflateManager>.NativeClassPtr, "Z_DEFLATED");
		NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InflateManager>.NativeClassPtr, "mode");
		NativeFieldInfoPtr__codec = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InflateManager>.NativeClassPtr, "_codec");
		NativeFieldInfoPtr_method = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InflateManager>.NativeClassPtr, "method");
		NativeFieldInfoPtr_computedCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InflateManager>.NativeClassPtr, "computedCheck");
		NativeFieldInfoPtr_expectedCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InflateManager>.NativeClassPtr, "expectedCheck");
		NativeFieldInfoPtr_marker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InflateManager>.NativeClassPtr, "marker");
		NativeFieldInfoPtr__handleRfc1950HeaderBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InflateManager>.NativeClassPtr, "_handleRfc1950HeaderBytes");
		NativeFieldInfoPtr_wbits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InflateManager>.NativeClassPtr, "wbits");
		NativeFieldInfoPtr_blocks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InflateManager>.NativeClassPtr, "blocks");
		NativeFieldInfoPtr_mark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InflateManager>.NativeClassPtr, "mark");
		NativeMethodInfoPtr_get_HandleRfc1950HeaderBytes_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InflateManager>.NativeClassPtr, 100664280);
		NativeMethodInfoPtr_set_HandleRfc1950HeaderBytes_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InflateManager>.NativeClassPtr, 100664281);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InflateManager>.NativeClassPtr, 100664282);
		NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InflateManager>.NativeClassPtr, 100664283);
		NativeMethodInfoPtr_Reset_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InflateManager>.NativeClassPtr, 100664284);
		NativeMethodInfoPtr_End_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InflateManager>.NativeClassPtr, 100664285);
		NativeMethodInfoPtr_Initialize_Internal_Int32_ZlibCodec_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InflateManager>.NativeClassPtr, 100664286);
		NativeMethodInfoPtr_Inflate_Internal_Int32_FlushType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InflateManager>.NativeClassPtr, 100664287);
		NativeMethodInfoPtr_SetDictionary_Internal_Int32_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InflateManager>.NativeClassPtr, 100664288);
		NativeMethodInfoPtr_Sync_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InflateManager>.NativeClassPtr, 100664289);
		NativeMethodInfoPtr_SyncPoint_Internal_Int32_ZlibCodec_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InflateManager>.NativeClassPtr, 100664290);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41195, XrefRangeEnd = 41196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InflateManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InflateManager>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41196, XrefRangeEnd = 41197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InflateManager(bool expectRfc1950HeaderBytes)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InflateManager>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&expectRfc1950HeaderBytes);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41197, XrefRangeEnd = 41199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int Reset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reset_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41199, XrefRangeEnd = 41201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int End()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_End_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41201, XrefRangeEnd = 41211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int Initialize(ZlibCodec codec, int w)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)codec);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &w;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Internal_Int32_ZlibCodec_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 41245, RefRangeEnd = 41249, XrefRangeStart = 41211, XrefRangeEnd = 41245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int Inflate(FlushType flush)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&flush);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Inflate_Internal_Int32_FlushType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41249, XrefRangeEnd = 41257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int SetDictionary(Il2CppStructArray<byte> dictionary)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDictionary_Internal_Int32_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 41265, RefRangeEnd = 41266, XrefRangeStart = 41257, XrefRangeEnd = 41265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int Sync()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Sync_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41266, XrefRangeEnd = 41268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int SyncPoint(ZlibCodec z)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)z);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SyncPoint_Internal_Int32_ZlibCodec_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public InflateManager(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
