using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppIonic.Zlib;

public sealed class ZlibCodec : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_InputBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_NextIn;

	private static readonly System.IntPtr NativeFieldInfoPtr_AvailableBytesIn;

	private static readonly System.IntPtr NativeFieldInfoPtr_TotalBytesIn;

	private static readonly System.IntPtr NativeFieldInfoPtr_OutputBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_NextOut;

	private static readonly System.IntPtr NativeFieldInfoPtr_AvailableBytesOut;

	private static readonly System.IntPtr NativeFieldInfoPtr_TotalBytesOut;

	private static readonly System.IntPtr NativeFieldInfoPtr_Message;

	private static readonly System.IntPtr NativeFieldInfoPtr_dstate;

	private static readonly System.IntPtr NativeFieldInfoPtr_istate;

	private static readonly System.IntPtr NativeFieldInfoPtr__Adler32;

	private static readonly System.IntPtr NativeFieldInfoPtr_CompressLevel;

	private static readonly System.IntPtr NativeFieldInfoPtr_WindowBits;

	private static readonly System.IntPtr NativeFieldInfoPtr_Strategy;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Adler32_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_CompressionMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeInflate_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeInflate_Public_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeInflate_Public_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeInflate_Public_Int32_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Inflate_Public_Int32_FlushType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EndInflate_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SyncInflate_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeDeflate_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeDeflate_Public_Int32_CompressionLevel_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeDeflate_Public_Int32_CompressionLevel_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeDeflate_Public_Int32_CompressionLevel_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeDeflate_Public_Int32_CompressionLevel_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__InternalInitializeDeflate_Private_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Deflate_Public_Int32_FlushType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EndDeflate_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetDeflate_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDeflateParams_Public_Int32_CompressionLevel_CompressionStrategy_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDictionary_Public_Int32_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_flush_pending_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_read_buf_Internal_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

	public unsafe Il2CppStructArray<byte> InputBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InputBuffer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InputBuffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int NextIn
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NextIn);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NextIn)) = value;
		}
	}

	public unsafe int AvailableBytesIn
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AvailableBytesIn);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AvailableBytesIn)) = value;
		}
	}

	public unsafe long TotalBytesIn
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TotalBytesIn);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TotalBytesIn)) = value;
		}
	}

	public unsafe Il2CppStructArray<byte> OutputBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OutputBuffer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OutputBuffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int NextOut
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NextOut);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NextOut)) = value;
		}
	}

	public unsafe int AvailableBytesOut
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AvailableBytesOut);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AvailableBytesOut)) = value;
		}
	}

	public unsafe long TotalBytesOut
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TotalBytesOut);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TotalBytesOut)) = value;
		}
	}

	public unsafe string Message
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Message);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Message)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe DeflateManager dstate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dstate);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DeflateManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dstate)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe InflateManager istate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_istate);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InflateManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_istate)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe uint _Adler32
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Adler32);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Adler32)) = value;
		}
	}

	public unsafe CompressionLevel CompressLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CompressLevel);
			return *(CompressionLevel*)num;
		}
		set
		{
			*(CompressionLevel*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CompressLevel)) = value;
		}
	}

	public unsafe int WindowBits
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WindowBits);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WindowBits)) = value;
		}
	}

	public unsafe CompressionStrategy Strategy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Strategy);
			return *(CompressionStrategy*)num;
		}
		set
		{
			*(CompressionStrategy*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Strategy)) = value;
		}
	}

	public unsafe int Adler32
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 41565, RefRangeEnd = 41568, XrefRangeStart = 41565, XrefRangeEnd = 41565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Adler32_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static ZlibCodec()
	{
		Il2CppClassPointerStore<ZlibCodec>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Ionic.Zlib", "ZlibCodec");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ZlibCodec>.NativeClassPtr);
		NativeFieldInfoPtr_InputBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZlibCodec>.NativeClassPtr, "InputBuffer");
		NativeFieldInfoPtr_NextIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZlibCodec>.NativeClassPtr, "NextIn");
		NativeFieldInfoPtr_AvailableBytesIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZlibCodec>.NativeClassPtr, "AvailableBytesIn");
		NativeFieldInfoPtr_TotalBytesIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZlibCodec>.NativeClassPtr, "TotalBytesIn");
		NativeFieldInfoPtr_OutputBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZlibCodec>.NativeClassPtr, "OutputBuffer");
		NativeFieldInfoPtr_NextOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZlibCodec>.NativeClassPtr, "NextOut");
		NativeFieldInfoPtr_AvailableBytesOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZlibCodec>.NativeClassPtr, "AvailableBytesOut");
		NativeFieldInfoPtr_TotalBytesOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZlibCodec>.NativeClassPtr, "TotalBytesOut");
		NativeFieldInfoPtr_Message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZlibCodec>.NativeClassPtr, "Message");
		NativeFieldInfoPtr_dstate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZlibCodec>.NativeClassPtr, "dstate");
		NativeFieldInfoPtr_istate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZlibCodec>.NativeClassPtr, "istate");
		NativeFieldInfoPtr__Adler32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZlibCodec>.NativeClassPtr, "_Adler32");
		NativeFieldInfoPtr_CompressLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZlibCodec>.NativeClassPtr, "CompressLevel");
		NativeFieldInfoPtr_WindowBits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZlibCodec>.NativeClassPtr, "WindowBits");
		NativeFieldInfoPtr_Strategy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZlibCodec>.NativeClassPtr, "Strategy");
		NativeMethodInfoPtr_get_Adler32_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZlibCodec>.NativeClassPtr, 100664339);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZlibCodec>.NativeClassPtr, 100664340);
		NativeMethodInfoPtr__ctor_Public_Void_CompressionMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZlibCodec>.NativeClassPtr, 100664341);
		NativeMethodInfoPtr_InitializeInflate_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZlibCodec>.NativeClassPtr, 100664342);
		NativeMethodInfoPtr_InitializeInflate_Public_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZlibCodec>.NativeClassPtr, 100664343);
		NativeMethodInfoPtr_InitializeInflate_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZlibCodec>.NativeClassPtr, 100664344);
		NativeMethodInfoPtr_InitializeInflate_Public_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZlibCodec>.NativeClassPtr, 100664345);
		NativeMethodInfoPtr_Inflate_Public_Int32_FlushType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZlibCodec>.NativeClassPtr, 100664346);
		NativeMethodInfoPtr_EndInflate_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZlibCodec>.NativeClassPtr, 100664347);
		NativeMethodInfoPtr_SyncInflate_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZlibCodec>.NativeClassPtr, 100664348);
		NativeMethodInfoPtr_InitializeDeflate_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZlibCodec>.NativeClassPtr, 100664349);
		NativeMethodInfoPtr_InitializeDeflate_Public_Int32_CompressionLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZlibCodec>.NativeClassPtr, 100664350);
		NativeMethodInfoPtr_InitializeDeflate_Public_Int32_CompressionLevel_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZlibCodec>.NativeClassPtr, 100664351);
		NativeMethodInfoPtr_InitializeDeflate_Public_Int32_CompressionLevel_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZlibCodec>.NativeClassPtr, 100664352);
		NativeMethodInfoPtr_InitializeDeflate_Public_Int32_CompressionLevel_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZlibCodec>.NativeClassPtr, 100664353);
		NativeMethodInfoPtr__InternalInitializeDeflate_Private_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZlibCodec>.NativeClassPtr, 100664354);
		NativeMethodInfoPtr_Deflate_Public_Int32_FlushType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZlibCodec>.NativeClassPtr, 100664355);
		NativeMethodInfoPtr_EndDeflate_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZlibCodec>.NativeClassPtr, 100664356);
		NativeMethodInfoPtr_ResetDeflate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZlibCodec>.NativeClassPtr, 100664357);
		NativeMethodInfoPtr_SetDeflateParams_Public_Int32_CompressionLevel_CompressionStrategy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZlibCodec>.NativeClassPtr, 100664358);
		NativeMethodInfoPtr_SetDictionary_Public_Int32_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZlibCodec>.NativeClassPtr, 100664359);
		NativeMethodInfoPtr_flush_pending_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZlibCodec>.NativeClassPtr, 100664360);
		NativeMethodInfoPtr_read_buf_Internal_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZlibCodec>.NativeClassPtr, 100664361);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41568, XrefRangeEnd = 41569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ZlibCodec()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ZlibCodec>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41569, XrefRangeEnd = 41573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ZlibCodec(CompressionMode mode)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ZlibCodec>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&mode);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_CompressionMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41573, XrefRangeEnd = 41574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int InitializeInflate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeInflate_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41574, XrefRangeEnd = 41575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int InitializeInflate(bool expectRfc1950Header)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&expectRfc1950Header);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeInflate_Public_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41575, XrefRangeEnd = 41576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int InitializeInflate(int windowBits)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&windowBits);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeInflate_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 41591, RefRangeEnd = 41595, XrefRangeStart = 41576, XrefRangeEnd = 41591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int InitializeInflate(int windowBits, bool expectRfc1950Header)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&windowBits);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &expectRfc1950Header;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeInflate_Public_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41595, XrefRangeEnd = 41602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int Inflate(FlushType flush)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&flush);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Inflate_Public_Int32_FlushType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41602, XrefRangeEnd = 41605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int EndInflate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndInflate_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41605, XrefRangeEnd = 41612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int SyncInflate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SyncInflate_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41612, XrefRangeEnd = 41613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int InitializeDeflate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeDeflate_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41613, XrefRangeEnd = 41614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int InitializeDeflate(CompressionLevel level)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&level);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeDeflate_Public_Int32_CompressionLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41614, XrefRangeEnd = 41615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int InitializeDeflate(CompressionLevel level, bool wantRfc1950Header)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&level);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &wantRfc1950Header;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeDeflate_Public_Int32_CompressionLevel_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41615, XrefRangeEnd = 41616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int InitializeDeflate(CompressionLevel level, int bits)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&level);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bits;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeDeflate_Public_Int32_CompressionLevel_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41616, XrefRangeEnd = 41617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int InitializeDeflate(CompressionLevel level, int bits, bool wantRfc1950Header)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&level);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bits;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &wantRfc1950Header;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeDeflate_Public_Int32_CompressionLevel_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 41623, RefRangeEnd = 41630, XrefRangeStart = 41617, XrefRangeEnd = 41623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int _InternalInitializeDeflate(bool wantRfc1950Header)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&wantRfc1950Header);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__InternalInitializeDeflate_Private_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 41637, RefRangeEnd = 41639, XrefRangeStart = 41630, XrefRangeEnd = 41637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int Deflate(FlushType flush)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&flush);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Deflate_Public_Int32_FlushType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41639, XrefRangeEnd = 41640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int EndDeflate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndDeflate_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41640, XrefRangeEnd = 41647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetDeflate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetDeflate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41647, XrefRangeEnd = 41654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int SetDeflateParams(CompressionLevel level, CompressionStrategy strategy)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&level);
		*(CompressionStrategy**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &strategy;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDeflateParams_Public_Int32_CompressionLevel_CompressionStrategy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41654, XrefRangeEnd = 41655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int SetDictionary(Il2CppStructArray<byte> dictionary)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDictionary_Public_Int32_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 41656, RefRangeEnd = 41662, XrefRangeStart = 41655, XrefRangeEnd = 41656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void flush_pending()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_flush_pending_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 41668, RefRangeEnd = 41669, XrefRangeStart = 41662, XrefRangeEnd = 41668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int read_buf(Il2CppStructArray<byte> buf, int start, int size)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buf);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &start;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_read_buf_Internal_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public ZlibCodec(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
