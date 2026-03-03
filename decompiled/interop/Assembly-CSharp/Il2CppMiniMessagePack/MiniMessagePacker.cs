using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using Il2CppSystem.Text;

namespace Il2CppMiniMessagePack;

public class MiniMessagePacker : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_tmp0;

	private static readonly System.IntPtr NativeFieldInfoPtr_tmp1;

	private static readonly System.IntPtr NativeFieldInfoPtr_string_buf;

	private static readonly System.IntPtr NativeFieldInfoPtr_encoder;

	private static readonly System.IntPtr NativeMethodInfoPtr_Pack_Public_Il2CppStructArray_1_Byte_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Pack_Public_Void_Stream_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PackNull_Private_Void_Stream_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Pack_Private_Void_Stream_IList_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Pack_Private_Void_Stream_IDictionary_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Pack_Private_Void_Stream_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Pack_Private_Void_Stream_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Pack_Private_Void_Stream_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Pack_Private_Void_Stream_Int16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Pack_Private_Void_Stream_UInt16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Pack_Private_Void_Stream_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Pack_Private_Void_Stream_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Pack_Private_Void_Stream_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Pack_Private_Void_Stream_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Pack_Private_Void_Stream_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Pack_Private_Void_Stream_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Pack_Private_Void_Stream_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Write_Private_Void_Stream_UInt16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Write_Private_Void_Stream_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Write_Private_Void_Stream_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Unpack_Public_Object_Il2CppStructArray_1_Byte_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Unpack_Public_Object_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Unpack_Public_Object_Stream_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnpackUint16_Private_Int64_Stream_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnpackUint32_Private_Int64_Stream_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnpackString_Private_String_Stream_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnpackBinary_Private_Il2CppStructArray_1_Byte_Stream_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnpackArray_Private_List_1_Object_Stream_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnpackMap_Private_Dictionary_2_String_Object_Stream_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Il2CppStructArray<byte> tmp0
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tmp0);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tmp0)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<byte> tmp1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tmp1);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tmp1)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<byte> string_buf
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_string_buf);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_string_buf)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Encoding encoder
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_encoder);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Encoding>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_encoder)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static MiniMessagePacker()
	{
		Il2CppClassPointerStore<MiniMessagePacker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "MiniMessagePack", "MiniMessagePacker");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MiniMessagePacker>.NativeClassPtr);
		NativeFieldInfoPtr_tmp0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMessagePacker>.NativeClassPtr, "tmp0");
		NativeFieldInfoPtr_tmp1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMessagePacker>.NativeClassPtr, "tmp1");
		NativeFieldInfoPtr_string_buf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMessagePacker>.NativeClassPtr, "string_buf");
		NativeFieldInfoPtr_encoder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMessagePacker>.NativeClassPtr, "encoder");
		NativeMethodInfoPtr_Pack_Public_Il2CppStructArray_1_Byte_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMessagePacker>.NativeClassPtr, 100664887);
		NativeMethodInfoPtr_Pack_Public_Void_Stream_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMessagePacker>.NativeClassPtr, 100664888);
		NativeMethodInfoPtr_PackNull_Private_Void_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMessagePacker>.NativeClassPtr, 100664889);
		NativeMethodInfoPtr_Pack_Private_Void_Stream_IList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMessagePacker>.NativeClassPtr, 100664890);
		NativeMethodInfoPtr_Pack_Private_Void_Stream_IDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMessagePacker>.NativeClassPtr, 100664891);
		NativeMethodInfoPtr_Pack_Private_Void_Stream_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMessagePacker>.NativeClassPtr, 100664892);
		NativeMethodInfoPtr_Pack_Private_Void_Stream_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMessagePacker>.NativeClassPtr, 100664893);
		NativeMethodInfoPtr_Pack_Private_Void_Stream_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMessagePacker>.NativeClassPtr, 100664894);
		NativeMethodInfoPtr_Pack_Private_Void_Stream_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMessagePacker>.NativeClassPtr, 100664895);
		NativeMethodInfoPtr_Pack_Private_Void_Stream_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMessagePacker>.NativeClassPtr, 100664896);
		NativeMethodInfoPtr_Pack_Private_Void_Stream_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMessagePacker>.NativeClassPtr, 100664897);
		NativeMethodInfoPtr_Pack_Private_Void_Stream_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMessagePacker>.NativeClassPtr, 100664898);
		NativeMethodInfoPtr_Pack_Private_Void_Stream_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMessagePacker>.NativeClassPtr, 100664899);
		NativeMethodInfoPtr_Pack_Private_Void_Stream_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMessagePacker>.NativeClassPtr, 100664900);
		NativeMethodInfoPtr_Pack_Private_Void_Stream_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMessagePacker>.NativeClassPtr, 100664901);
		NativeMethodInfoPtr_Pack_Private_Void_Stream_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMessagePacker>.NativeClassPtr, 100664902);
		NativeMethodInfoPtr_Pack_Private_Void_Stream_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMessagePacker>.NativeClassPtr, 100664903);
		NativeMethodInfoPtr_Write_Private_Void_Stream_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMessagePacker>.NativeClassPtr, 100664904);
		NativeMethodInfoPtr_Write_Private_Void_Stream_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMessagePacker>.NativeClassPtr, 100664905);
		NativeMethodInfoPtr_Write_Private_Void_Stream_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMessagePacker>.NativeClassPtr, 100664906);
		NativeMethodInfoPtr_Unpack_Public_Object_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMessagePacker>.NativeClassPtr, 100664907);
		NativeMethodInfoPtr_Unpack_Public_Object_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMessagePacker>.NativeClassPtr, 100664908);
		NativeMethodInfoPtr_Unpack_Public_Object_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMessagePacker>.NativeClassPtr, 100664909);
		NativeMethodInfoPtr_UnpackUint16_Private_Int64_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMessagePacker>.NativeClassPtr, 100664910);
		NativeMethodInfoPtr_UnpackUint32_Private_Int64_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMessagePacker>.NativeClassPtr, 100664911);
		NativeMethodInfoPtr_UnpackString_Private_String_Stream_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMessagePacker>.NativeClassPtr, 100664912);
		NativeMethodInfoPtr_UnpackBinary_Private_Il2CppStructArray_1_Byte_Stream_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMessagePacker>.NativeClassPtr, 100664913);
		NativeMethodInfoPtr_UnpackArray_Private_List_1_Object_Stream_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMessagePacker>.NativeClassPtr, 100664914);
		NativeMethodInfoPtr_UnpackMap_Private_Dictionary_2_String_Object_Stream_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMessagePacker>.NativeClassPtr, 100664915);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMessagePacker>.NativeClassPtr, 100664916);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 47474, RefRangeEnd = 47479, XrefRangeStart = 47463, XrefRangeEnd = 47474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStructArray<byte> Pack(Il2CppSystem.Object o)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)o);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Pack_Public_Il2CppStructArray_1_Byte_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 47523, RefRangeEnd = 47528, XrefRangeStart = 47479, XrefRangeEnd = 47523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Pack(Stream s, Il2CppSystem.Object o)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)o);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Pack_Public_Void_Stream_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47528, XrefRangeEnd = 47529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PackNull(Stream s)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)s);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PackNull_Private_Void_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47529, XrefRangeEnd = 47553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Pack(Stream s, IList list)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Pack_Private_Void_Stream_IList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47553, XrefRangeEnd = 47584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Pack(Stream s, IDictionary dict)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dict);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Pack_Private_Void_Stream_IDictionary_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47584, XrefRangeEnd = 47585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Pack(Stream s, bool val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)s);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &val;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Pack_Private_Void_Stream_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe void Pack(Stream s, sbyte val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)s);
		*(sbyte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &val;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Pack_Private_Void_Stream_SByte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe void Pack(Stream s, byte val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)s);
		*(byte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &val;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Pack_Private_Void_Stream_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe void Pack(Stream s, short val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)s);
		*(short**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &val;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Pack_Private_Void_Stream_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 47585, RefRangeEnd = 47586, XrefRangeStart = 47585, XrefRangeEnd = 47585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Pack(Stream s, ushort val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)s);
		*(ushort**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &val;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Pack_Private_Void_Stream_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 47587, RefRangeEnd = 47588, XrefRangeStart = 47586, XrefRangeEnd = 47587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Pack(Stream s, int val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)s);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &val;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Pack_Private_Void_Stream_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 47589, RefRangeEnd = 47590, XrefRangeStart = 47588, XrefRangeEnd = 47589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Pack(Stream s, uint val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)s);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &val;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Pack_Private_Void_Stream_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 47592, RefRangeEnd = 47593, XrefRangeStart = 47590, XrefRangeEnd = 47592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Pack(Stream s, long val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)s);
		*(long**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &val;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Pack_Private_Void_Stream_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 47595, RefRangeEnd = 47596, XrefRangeStart = 47593, XrefRangeEnd = 47595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Pack(Stream s, ulong val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)s);
		*(ulong**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &val;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Pack_Private_Void_Stream_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47596, XrefRangeEnd = 47597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Pack(Stream s, float val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)s);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &val;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Pack_Private_Void_Stream_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 47598, RefRangeEnd = 47599, XrefRangeStart = 47597, XrefRangeEnd = 47598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Pack(Stream s, double val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)s);
		*(double**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &val;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Pack_Private_Void_Stream_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 47603, RefRangeEnd = 47604, XrefRangeStart = 47599, XrefRangeEnd = 47603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Pack(Stream s, string val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(val);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Pack_Private_Void_Stream_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe void Write(Stream s, ushort val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)s);
		*(ushort**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &val;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Write_Private_Void_Stream_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 47604, RefRangeEnd = 47611, XrefRangeStart = 47604, XrefRangeEnd = 47604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Write(Stream s, uint val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)s);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &val;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Write_Private_Void_Stream_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 47611, RefRangeEnd = 47613, XrefRangeStart = 47611, XrefRangeEnd = 47611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Write(Stream s, ulong val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)s);
		*(ulong**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &val;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Write_Private_Void_Stream_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 47624, RefRangeEnd = 47626, XrefRangeStart = 47613, XrefRangeEnd = 47624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Object Unpack(Il2CppStructArray<byte> buf, int offset, int size)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buf);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Unpack_Public_Object_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 47627, RefRangeEnd = 47635, XrefRangeStart = 47626, XrefRangeEnd = 47627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Object Unpack(Il2CppStructArray<byte> buf)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buf);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Unpack_Public_Object_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 47635, RefRangeEnd = 47641, XrefRangeStart = 47635, XrefRangeEnd = 47635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Object Unpack(Stream s)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)s);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Unpack_Public_Object_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
	}

	[CallerCount(0)]
	public unsafe long UnpackUint16(Stream s)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)s);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnpackUint16_Private_Int64_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe long UnpackUint32(Stream s)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)s);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnpackUint32_Private_Int64_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47641, XrefRangeEnd = 47646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string UnpackString(Stream s, long len)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)s);
		*(long**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &len;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnpackString_Private_String_Stream_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47646, XrefRangeEnd = 47650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStructArray<byte> UnpackBinary(Stream s, long len)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)s);
		*(long**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &len;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnpackBinary_Private_Il2CppStructArray_1_Byte_Stream_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47650, XrefRangeEnd = 47662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<Il2CppSystem.Object> UnpackArray(Stream s, long len)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)s);
		*(long**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &len;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnpackArray_Private_List_1_Object_Stream_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Il2CppSystem.Object>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47662, XrefRangeEnd = 47681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Dictionary<string, Il2CppSystem.Object> UnpackMap(Stream s, long len)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)s);
		*(long**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &len;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnpackMap_Private_Dictionary_2_String_Object_Stream_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, Il2CppSystem.Object>>(intPtr2) : null;
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 47694, RefRangeEnd = 47706, XrefRangeStart = 47681, XrefRangeEnd = 47694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MiniMessagePacker()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MiniMessagePacker>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public MiniMessagePacker(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
