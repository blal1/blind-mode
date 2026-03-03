using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppLZ4ps;

public static class LZ4Codec : Il2CppSystem.Object
{
	public class LZ4HC_Data_Structure : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_src;

		private static readonly System.IntPtr NativeFieldInfoPtr_src_base;

		private static readonly System.IntPtr NativeFieldInfoPtr_src_end;

		private static readonly System.IntPtr NativeFieldInfoPtr_src_LASTLITERALS;

		private static readonly System.IntPtr NativeFieldInfoPtr_dst;

		private static readonly System.IntPtr NativeFieldInfoPtr_dst_base;

		private static readonly System.IntPtr NativeFieldInfoPtr_dst_len;

		private static readonly System.IntPtr NativeFieldInfoPtr_dst_end;

		private static readonly System.IntPtr NativeFieldInfoPtr_hashTable;

		private static readonly System.IntPtr NativeFieldInfoPtr_chainTable;

		private static readonly System.IntPtr NativeFieldInfoPtr_nextToUpdate;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Il2CppStructArray<byte> src
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_src);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_src)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe int src_base
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_src_base);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_src_base)) = value;
			}
		}

		public unsafe int src_end
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_src_end);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_src_end)) = value;
			}
		}

		public unsafe int src_LASTLITERALS
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_src_LASTLITERALS);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_src_LASTLITERALS)) = value;
			}
		}

		public unsafe Il2CppStructArray<byte> dst
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dst);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dst)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe int dst_base
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dst_base);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dst_base)) = value;
			}
		}

		public unsafe int dst_len
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dst_len);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dst_len)) = value;
			}
		}

		public unsafe int dst_end
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dst_end);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dst_end)) = value;
			}
		}

		public unsafe Il2CppStructArray<int> hashTable
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hashTable);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hashTable)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Il2CppStructArray<ushort> chainTable
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chainTable);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<ushort>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chainTable)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe int nextToUpdate
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nextToUpdate);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nextToUpdate)) = value;
			}
		}

		static LZ4HC_Data_Structure()
		{
			Il2CppClassPointerStore<LZ4HC_Data_Structure>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, "LZ4HC_Data_Structure");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LZ4HC_Data_Structure>.NativeClassPtr);
			NativeFieldInfoPtr_src = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LZ4HC_Data_Structure>.NativeClassPtr, "src");
			NativeFieldInfoPtr_src_base = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LZ4HC_Data_Structure>.NativeClassPtr, "src_base");
			NativeFieldInfoPtr_src_end = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LZ4HC_Data_Structure>.NativeClassPtr, "src_end");
			NativeFieldInfoPtr_src_LASTLITERALS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LZ4HC_Data_Structure>.NativeClassPtr, "src_LASTLITERALS");
			NativeFieldInfoPtr_dst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LZ4HC_Data_Structure>.NativeClassPtr, "dst");
			NativeFieldInfoPtr_dst_base = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LZ4HC_Data_Structure>.NativeClassPtr, "dst_base");
			NativeFieldInfoPtr_dst_len = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LZ4HC_Data_Structure>.NativeClassPtr, "dst_len");
			NativeFieldInfoPtr_dst_end = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LZ4HC_Data_Structure>.NativeClassPtr, "dst_end");
			NativeFieldInfoPtr_hashTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LZ4HC_Data_Structure>.NativeClassPtr, "hashTable");
			NativeFieldInfoPtr_chainTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LZ4HC_Data_Structure>.NativeClassPtr, "chainTable");
			NativeFieldInfoPtr_nextToUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LZ4HC_Data_Structure>.NativeClassPtr, "nextToUpdate");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LZ4HC_Data_Structure>.NativeClassPtr, 100664968);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LZ4HC_Data_Structure()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LZ4HC_Data_Structure>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public LZ4HC_Data_Structure(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_MEMORY_USAGE;

	private static readonly System.IntPtr NativeFieldInfoPtr_NOTCOMPRESSIBLE_DETECTIONLEVEL;

	private static readonly System.IntPtr NativeFieldInfoPtr_BLOCK_COPY_LIMIT;

	private static readonly System.IntPtr NativeFieldInfoPtr_MINMATCH;

	private static readonly System.IntPtr NativeFieldInfoPtr_SKIPSTRENGTH;

	private static readonly System.IntPtr NativeFieldInfoPtr_COPYLENGTH;

	private static readonly System.IntPtr NativeFieldInfoPtr_LASTLITERALS;

	private static readonly System.IntPtr NativeFieldInfoPtr_MFLIMIT;

	private static readonly System.IntPtr NativeFieldInfoPtr_MINLENGTH;

	private static readonly System.IntPtr NativeFieldInfoPtr_MAXD_LOG;

	private static readonly System.IntPtr NativeFieldInfoPtr_MAXD;

	private static readonly System.IntPtr NativeFieldInfoPtr_MAXD_MASK;

	private static readonly System.IntPtr NativeFieldInfoPtr_MAX_DISTANCE;

	private static readonly System.IntPtr NativeFieldInfoPtr_ML_BITS;

	private static readonly System.IntPtr NativeFieldInfoPtr_ML_MASK;

	private static readonly System.IntPtr NativeFieldInfoPtr_RUN_BITS;

	private static readonly System.IntPtr NativeFieldInfoPtr_RUN_MASK;

	private static readonly System.IntPtr NativeFieldInfoPtr_STEPSIZE_64;

	private static readonly System.IntPtr NativeFieldInfoPtr_STEPSIZE_32;

	private static readonly System.IntPtr NativeFieldInfoPtr_LZ4_64KLIMIT;

	private static readonly System.IntPtr NativeFieldInfoPtr_HASH_LOG;

	private static readonly System.IntPtr NativeFieldInfoPtr_HASH_TABLESIZE;

	private static readonly System.IntPtr NativeFieldInfoPtr_HASH_ADJUST;

	private static readonly System.IntPtr NativeFieldInfoPtr_HASH64K_LOG;

	private static readonly System.IntPtr NativeFieldInfoPtr_HASH64K_TABLESIZE;

	private static readonly System.IntPtr NativeFieldInfoPtr_HASH64K_ADJUST;

	private static readonly System.IntPtr NativeFieldInfoPtr_HASHHC_LOG;

	private static readonly System.IntPtr NativeFieldInfoPtr_HASHHC_TABLESIZE;

	private static readonly System.IntPtr NativeFieldInfoPtr_HASHHC_ADJUST;

	private static readonly System.IntPtr NativeFieldInfoPtr_DECODER_TABLE_32;

	private static readonly System.IntPtr NativeFieldInfoPtr_DECODER_TABLE_64;

	private static readonly System.IntPtr NativeFieldInfoPtr_DEBRUIJN_TABLE_32;

	private static readonly System.IntPtr NativeFieldInfoPtr_DEBRUIJN_TABLE_64;

	private static readonly System.IntPtr NativeFieldInfoPtr_MAX_NB_ATTEMPTS;

	private static readonly System.IntPtr NativeFieldInfoPtr_OPTIMAL_ML;

	private static readonly System.IntPtr NativeMethodInfoPtr_MaximumOutputLength_Public_Static_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckArguments_Internal_Static_Void_Il2CppStructArray_1_Byte_Int32_byref_Int32_Il2CppStructArray_1_Byte_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Assert_Private_Static_Void_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Poke2_Internal_Static_Void_Il2CppStructArray_1_Byte_Int32_UInt16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Peek2_Internal_Static_UInt16_Il2CppStructArray_1_Byte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Peek4_Internal_Static_UInt32_Il2CppStructArray_1_Byte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Xor4_Private_Static_UInt32_Il2CppStructArray_1_Byte_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Xor8_Private_Static_UInt64_Il2CppStructArray_1_Byte_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equal2_Private_Static_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equal4_Private_Static_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Copy4_Private_Static_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Copy8_Private_Static_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BlockCopy_Private_Static_Void_Il2CppStructArray_1_Byte_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WildCopy_Private_Static_Int32_Il2CppStructArray_1_Byte_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SecureCopy_Private_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Encode32_Public_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Encode32_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Encode64_Public_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Encode64_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Decode32_Public_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Decode32_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Decode64_Public_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Decode64_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LZ4HC_Create_Private_Static_LZ4HC_Data_Structure_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LZ4_compressHC_32_Private_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Encode32HC_Public_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Encode32HC_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LZ4_compressHC_64_Private_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Encode64HC_Public_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Encode64HC_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LZ4_compressCtx_safe32_Private_Static_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LZ4_compress64kCtx_safe32_Private_Static_Int32_Il2CppStructArray_1_UInt16_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LZ4_uncompress_safe32_Private_Static_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LZ4_uncompress_unknownOutputSize_safe32_Private_Static_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LZ4HC_Insert_32_Private_Static_Void_LZ4HC_Data_Structure_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LZ4HC_CommonLength_32_Private_Static_Int32_LZ4HC_Data_Structure_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LZ4HC_InsertAndFindBestMatch_32_Private_Static_Int32_LZ4HC_Data_Structure_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LZ4HC_InsertAndGetWiderMatch_32_Private_Static_Int32_LZ4HC_Data_Structure_Int32_Int32_Int32_byref_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LZ4_encodeSequence_32_Private_Static_Int32_LZ4HC_Data_Structure_byref_Int32_byref_Int32_byref_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LZ4_compressHCCtx_32_Private_Static_Int32_LZ4HC_Data_Structure_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LZ4_compressCtx_safe64_Private_Static_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LZ4_compress64kCtx_safe64_Private_Static_Int32_Il2CppStructArray_1_UInt16_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LZ4_uncompress_safe64_Private_Static_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LZ4_uncompress_unknownOutputSize_safe64_Private_Static_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LZ4HC_Insert_64_Private_Static_Void_LZ4HC_Data_Structure_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LZ4HC_CommonLength_64_Private_Static_Int32_LZ4HC_Data_Structure_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LZ4HC_InsertAndFindBestMatch_64_Private_Static_Int32_LZ4HC_Data_Structure_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LZ4HC_InsertAndGetWiderMatch_64_Private_Static_Int32_LZ4HC_Data_Structure_Int32_Int32_Int32_byref_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LZ4_encodeSequence_64_Private_Static_Int32_LZ4HC_Data_Structure_byref_Int32_byref_Int32_byref_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LZ4_compressHCCtx_64_Private_Static_Int32_LZ4HC_Data_Structure_0;

	public unsafe static int MEMORY_USAGE
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MEMORY_USAGE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MEMORY_USAGE, (void*)(&value));
		}
	}

	public unsafe static int NOTCOMPRESSIBLE_DETECTIONLEVEL
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NOTCOMPRESSIBLE_DETECTIONLEVEL, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NOTCOMPRESSIBLE_DETECTIONLEVEL, (void*)(&value));
		}
	}

	public unsafe static int BLOCK_COPY_LIMIT
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BLOCK_COPY_LIMIT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BLOCK_COPY_LIMIT, (void*)(&value));
		}
	}

	public unsafe static int MINMATCH
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MINMATCH, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MINMATCH, (void*)(&value));
		}
	}

	public unsafe static int SKIPSTRENGTH
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SKIPSTRENGTH, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SKIPSTRENGTH, (void*)(&value));
		}
	}

	public unsafe static int COPYLENGTH
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_COPYLENGTH, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_COPYLENGTH, (void*)(&value));
		}
	}

	public unsafe static int LASTLITERALS
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LASTLITERALS, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LASTLITERALS, (void*)(&value));
		}
	}

	public unsafe static int MFLIMIT
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MFLIMIT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MFLIMIT, (void*)(&value));
		}
	}

	public unsafe static int MINLENGTH
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MINLENGTH, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MINLENGTH, (void*)(&value));
		}
	}

	public unsafe static int MAXD_LOG
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MAXD_LOG, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MAXD_LOG, (void*)(&value));
		}
	}

	public unsafe static int MAXD
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MAXD, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MAXD, (void*)(&value));
		}
	}

	public unsafe static int MAXD_MASK
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MAXD_MASK, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MAXD_MASK, (void*)(&value));
		}
	}

	public unsafe static int MAX_DISTANCE
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MAX_DISTANCE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MAX_DISTANCE, (void*)(&value));
		}
	}

	public unsafe static int ML_BITS
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ML_BITS, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ML_BITS, (void*)(&value));
		}
	}

	public unsafe static int ML_MASK
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ML_MASK, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ML_MASK, (void*)(&value));
		}
	}

	public unsafe static int RUN_BITS
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_RUN_BITS, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_RUN_BITS, (void*)(&value));
		}
	}

	public unsafe static int RUN_MASK
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_RUN_MASK, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_RUN_MASK, (void*)(&value));
		}
	}

	public unsafe static int STEPSIZE_64
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_STEPSIZE_64, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_STEPSIZE_64, (void*)(&value));
		}
	}

	public unsafe static int STEPSIZE_32
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_STEPSIZE_32, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_STEPSIZE_32, (void*)(&value));
		}
	}

	public unsafe static int LZ4_64KLIMIT
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LZ4_64KLIMIT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LZ4_64KLIMIT, (void*)(&value));
		}
	}

	public unsafe static int HASH_LOG
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HASH_LOG, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HASH_LOG, (void*)(&value));
		}
	}

	public unsafe static int HASH_TABLESIZE
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HASH_TABLESIZE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HASH_TABLESIZE, (void*)(&value));
		}
	}

	public unsafe static int HASH_ADJUST
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HASH_ADJUST, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HASH_ADJUST, (void*)(&value));
		}
	}

	public unsafe static int HASH64K_LOG
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HASH64K_LOG, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HASH64K_LOG, (void*)(&value));
		}
	}

	public unsafe static int HASH64K_TABLESIZE
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HASH64K_TABLESIZE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HASH64K_TABLESIZE, (void*)(&value));
		}
	}

	public unsafe static int HASH64K_ADJUST
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HASH64K_ADJUST, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HASH64K_ADJUST, (void*)(&value));
		}
	}

	public unsafe static int HASHHC_LOG
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HASHHC_LOG, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HASHHC_LOG, (void*)(&value));
		}
	}

	public unsafe static int HASHHC_TABLESIZE
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HASHHC_TABLESIZE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HASHHC_TABLESIZE, (void*)(&value));
		}
	}

	public unsafe static int HASHHC_ADJUST
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HASHHC_ADJUST, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HASHHC_ADJUST, (void*)(&value));
		}
	}

	public unsafe static Il2CppStructArray<int> DECODER_TABLE_32
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DECODER_TABLE_32, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DECODER_TABLE_32, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<int> DECODER_TABLE_64
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DECODER_TABLE_64, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DECODER_TABLE_64, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<int> DEBRUIJN_TABLE_32
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEBRUIJN_TABLE_32, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEBRUIJN_TABLE_32, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<int> DEBRUIJN_TABLE_64
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEBRUIJN_TABLE_64, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEBRUIJN_TABLE_64, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static int MAX_NB_ATTEMPTS
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MAX_NB_ATTEMPTS, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MAX_NB_ATTEMPTS, (void*)(&value));
		}
	}

	public unsafe static int OPTIMAL_ML
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OPTIMAL_ML, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OPTIMAL_ML, (void*)(&value));
		}
	}

	static LZ4Codec()
	{
		Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "LZ4ps", "LZ4Codec");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr);
		NativeFieldInfoPtr_MEMORY_USAGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, "MEMORY_USAGE");
		NativeFieldInfoPtr_NOTCOMPRESSIBLE_DETECTIONLEVEL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, "NOTCOMPRESSIBLE_DETECTIONLEVEL");
		NativeFieldInfoPtr_BLOCK_COPY_LIMIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, "BLOCK_COPY_LIMIT");
		NativeFieldInfoPtr_MINMATCH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, "MINMATCH");
		NativeFieldInfoPtr_SKIPSTRENGTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, "SKIPSTRENGTH");
		NativeFieldInfoPtr_COPYLENGTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, "COPYLENGTH");
		NativeFieldInfoPtr_LASTLITERALS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, "LASTLITERALS");
		NativeFieldInfoPtr_MFLIMIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, "MFLIMIT");
		NativeFieldInfoPtr_MINLENGTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, "MINLENGTH");
		NativeFieldInfoPtr_MAXD_LOG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, "MAXD_LOG");
		NativeFieldInfoPtr_MAXD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, "MAXD");
		NativeFieldInfoPtr_MAXD_MASK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, "MAXD_MASK");
		NativeFieldInfoPtr_MAX_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, "MAX_DISTANCE");
		NativeFieldInfoPtr_ML_BITS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, "ML_BITS");
		NativeFieldInfoPtr_ML_MASK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, "ML_MASK");
		NativeFieldInfoPtr_RUN_BITS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, "RUN_BITS");
		NativeFieldInfoPtr_RUN_MASK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, "RUN_MASK");
		NativeFieldInfoPtr_STEPSIZE_64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, "STEPSIZE_64");
		NativeFieldInfoPtr_STEPSIZE_32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, "STEPSIZE_32");
		NativeFieldInfoPtr_LZ4_64KLIMIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, "LZ4_64KLIMIT");
		NativeFieldInfoPtr_HASH_LOG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, "HASH_LOG");
		NativeFieldInfoPtr_HASH_TABLESIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, "HASH_TABLESIZE");
		NativeFieldInfoPtr_HASH_ADJUST = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, "HASH_ADJUST");
		NativeFieldInfoPtr_HASH64K_LOG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, "HASH64K_LOG");
		NativeFieldInfoPtr_HASH64K_TABLESIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, "HASH64K_TABLESIZE");
		NativeFieldInfoPtr_HASH64K_ADJUST = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, "HASH64K_ADJUST");
		NativeFieldInfoPtr_HASHHC_LOG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, "HASHHC_LOG");
		NativeFieldInfoPtr_HASHHC_TABLESIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, "HASHHC_TABLESIZE");
		NativeFieldInfoPtr_HASHHC_ADJUST = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, "HASHHC_ADJUST");
		NativeFieldInfoPtr_DECODER_TABLE_32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, "DECODER_TABLE_32");
		NativeFieldInfoPtr_DECODER_TABLE_64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, "DECODER_TABLE_64");
		NativeFieldInfoPtr_DEBRUIJN_TABLE_32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, "DEBRUIJN_TABLE_32");
		NativeFieldInfoPtr_DEBRUIJN_TABLE_64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, "DEBRUIJN_TABLE_64");
		NativeFieldInfoPtr_MAX_NB_ATTEMPTS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, "MAX_NB_ATTEMPTS");
		NativeFieldInfoPtr_OPTIMAL_ML = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, "OPTIMAL_ML");
		NativeMethodInfoPtr_MaximumOutputLength_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, 100664917);
		NativeMethodInfoPtr_CheckArguments_Internal_Static_Void_Il2CppStructArray_1_Byte_Int32_byref_Int32_Il2CppStructArray_1_Byte_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, 100664918);
		NativeMethodInfoPtr_Assert_Private_Static_Void_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, 100664919);
		NativeMethodInfoPtr_Poke2_Internal_Static_Void_Il2CppStructArray_1_Byte_Int32_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, 100664920);
		NativeMethodInfoPtr_Peek2_Internal_Static_UInt16_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, 100664921);
		NativeMethodInfoPtr_Peek4_Internal_Static_UInt32_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, 100664922);
		NativeMethodInfoPtr_Xor4_Private_Static_UInt32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, 100664923);
		NativeMethodInfoPtr_Xor8_Private_Static_UInt64_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, 100664924);
		NativeMethodInfoPtr_Equal2_Private_Static_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, 100664925);
		NativeMethodInfoPtr_Equal4_Private_Static_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, 100664926);
		NativeMethodInfoPtr_Copy4_Private_Static_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, 100664927);
		NativeMethodInfoPtr_Copy8_Private_Static_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, 100664928);
		NativeMethodInfoPtr_BlockCopy_Private_Static_Void_Il2CppStructArray_1_Byte_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, 100664929);
		NativeMethodInfoPtr_WildCopy_Private_Static_Int32_Il2CppStructArray_1_Byte_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, 100664930);
		NativeMethodInfoPtr_SecureCopy_Private_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, 100664931);
		NativeMethodInfoPtr_Encode32_Public_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, 100664932);
		NativeMethodInfoPtr_Encode32_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, 100664933);
		NativeMethodInfoPtr_Encode64_Public_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, 100664934);
		NativeMethodInfoPtr_Encode64_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, 100664935);
		NativeMethodInfoPtr_Decode32_Public_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, 100664936);
		NativeMethodInfoPtr_Decode32_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, 100664937);
		NativeMethodInfoPtr_Decode64_Public_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, 100664938);
		NativeMethodInfoPtr_Decode64_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, 100664939);
		NativeMethodInfoPtr_LZ4HC_Create_Private_Static_LZ4HC_Data_Structure_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, 100664940);
		NativeMethodInfoPtr_LZ4_compressHC_32_Private_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, 100664941);
		NativeMethodInfoPtr_Encode32HC_Public_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, 100664942);
		NativeMethodInfoPtr_Encode32HC_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, 100664943);
		NativeMethodInfoPtr_LZ4_compressHC_64_Private_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, 100664944);
		NativeMethodInfoPtr_Encode64HC_Public_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, 100664945);
		NativeMethodInfoPtr_Encode64HC_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, 100664946);
		NativeMethodInfoPtr_LZ4_compressCtx_safe32_Private_Static_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, 100664947);
		NativeMethodInfoPtr_LZ4_compress64kCtx_safe32_Private_Static_Int32_Il2CppStructArray_1_UInt16_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, 100664948);
		NativeMethodInfoPtr_LZ4_uncompress_safe32_Private_Static_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, 100664949);
		NativeMethodInfoPtr_LZ4_uncompress_unknownOutputSize_safe32_Private_Static_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, 100664950);
		NativeMethodInfoPtr_LZ4HC_Insert_32_Private_Static_Void_LZ4HC_Data_Structure_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, 100664951);
		NativeMethodInfoPtr_LZ4HC_CommonLength_32_Private_Static_Int32_LZ4HC_Data_Structure_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, 100664952);
		NativeMethodInfoPtr_LZ4HC_InsertAndFindBestMatch_32_Private_Static_Int32_LZ4HC_Data_Structure_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, 100664953);
		NativeMethodInfoPtr_LZ4HC_InsertAndGetWiderMatch_32_Private_Static_Int32_LZ4HC_Data_Structure_Int32_Int32_Int32_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, 100664954);
		NativeMethodInfoPtr_LZ4_encodeSequence_32_Private_Static_Int32_LZ4HC_Data_Structure_byref_Int32_byref_Int32_byref_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, 100664955);
		NativeMethodInfoPtr_LZ4_compressHCCtx_32_Private_Static_Int32_LZ4HC_Data_Structure_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, 100664956);
		NativeMethodInfoPtr_LZ4_compressCtx_safe64_Private_Static_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, 100664957);
		NativeMethodInfoPtr_LZ4_compress64kCtx_safe64_Private_Static_Int32_Il2CppStructArray_1_UInt16_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, 100664958);
		NativeMethodInfoPtr_LZ4_uncompress_safe64_Private_Static_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, 100664959);
		NativeMethodInfoPtr_LZ4_uncompress_unknownOutputSize_safe64_Private_Static_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, 100664960);
		NativeMethodInfoPtr_LZ4HC_Insert_64_Private_Static_Void_LZ4HC_Data_Structure_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, 100664961);
		NativeMethodInfoPtr_LZ4HC_CommonLength_64_Private_Static_Int32_LZ4HC_Data_Structure_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, 100664962);
		NativeMethodInfoPtr_LZ4HC_InsertAndFindBestMatch_64_Private_Static_Int32_LZ4HC_Data_Structure_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, 100664963);
		NativeMethodInfoPtr_LZ4HC_InsertAndGetWiderMatch_64_Private_Static_Int32_LZ4HC_Data_Structure_Int32_Int32_Int32_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, 100664964);
		NativeMethodInfoPtr_LZ4_encodeSequence_64_Private_Static_Int32_LZ4HC_Data_Structure_byref_Int32_byref_Int32_byref_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, 100664965);
		NativeMethodInfoPtr_LZ4_compressHCCtx_64_Private_Static_Int32_LZ4HC_Data_Structure_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LZ4Codec>.NativeClassPtr, 100664966);
	}

	[CallerCount(0)]
	public unsafe static int MaximumOutputLength(int inputLength)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&inputLength);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MaximumOutputLength_Public_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47706, XrefRangeEnd = 47708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CheckArguments(Il2CppStructArray<byte> input, int inputOffset, ref int inputLength, Il2CppStructArray<byte> output, int outputOffset, ref int outputLength)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)input);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &inputOffset;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref inputLength);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)output);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &outputOffset;
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref outputLength);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckArguments_Internal_Static_Void_Il2CppStructArray_1_Byte_Int32_byref_Int32_Il2CppStructArray_1_Byte_Int32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47708, XrefRangeEnd = 47713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Assert(bool condition, string errorMessage)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&condition);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(errorMessage);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Assert_Private_Static_Void_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static void Poke2(Il2CppStructArray<byte> buffer, int offset, ushort value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		*(ushort**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Poke2_Internal_Static_Void_Il2CppStructArray_1_Byte_Int32_UInt16_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static ushort Peek2(Il2CppStructArray<byte> buffer, int offset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Peek2_Internal_Static_UInt16_Il2CppStructArray_1_Byte_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ushort*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 47713, RefRangeEnd = 47715, XrefRangeStart = 47713, XrefRangeEnd = 47713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint Peek4(Il2CppStructArray<byte> buffer, int offset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Peek4_Internal_Static_UInt32_Il2CppStructArray_1_Byte_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 47715, RefRangeEnd = 47719, XrefRangeStart = 47715, XrefRangeEnd = 47715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint Xor4(Il2CppStructArray<byte> buffer, int offset1, int offset2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset1;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Xor4_Private_Static_UInt32_Il2CppStructArray_1_Byte_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 47719, RefRangeEnd = 47723, XrefRangeStart = 47719, XrefRangeEnd = 47719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ulong Xor8(Il2CppStructArray<byte> buffer, int offset1, int offset2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset1;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Xor8_Private_Static_UInt64_Il2CppStructArray_1_Byte_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ulong*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool Equal2(Il2CppStructArray<byte> buffer, int offset1, int offset2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset1;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equal2_Private_Static_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 47723, RefRangeEnd = 47731, XrefRangeStart = 47723, XrefRangeEnd = 47723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Equal4(Il2CppStructArray<byte> buffer, int offset1, int offset2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset1;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equal4_Private_Static_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static void Copy4(Il2CppStructArray<byte> buf, int src, int dst)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buf);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &src;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &dst;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Copy4_Private_Static_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 47731, RefRangeEnd = 47733, XrefRangeStart = 47731, XrefRangeEnd = 47731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Copy8(Il2CppStructArray<byte> buf, int src, int dst)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buf);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &src;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &dst;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Copy8_Private_Static_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static void BlockCopy(Il2CppStructArray<byte> src, int src_0, Il2CppStructArray<byte> dst, int dst_0, int len)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)src);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &src_0;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dst);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &dst_0;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &len;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BlockCopy_Private_Static_Void_Il2CppStructArray_1_Byte_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47733, XrefRangeEnd = 47735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int WildCopy(Il2CppStructArray<byte> src, int src_0, Il2CppStructArray<byte> dst, int dst_0, int dst_end)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)src);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &src_0;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dst);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &dst_0;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &dst_end;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WildCopy_Private_Static_Int32_Il2CppStructArray_1_Byte_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 47736, RefRangeEnd = 47744, XrefRangeStart = 47735, XrefRangeEnd = 47736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int SecureCopy(Il2CppStructArray<byte> buffer, int src, int dst, int dst_end)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &src;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &dst;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &dst_end;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SecureCopy_Private_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 47755, RefRangeEnd = 47756, XrefRangeStart = 47744, XrefRangeEnd = 47755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int Encode32(Il2CppStructArray<byte> input, int inputOffset, int inputLength, Il2CppStructArray<byte> output, int outputOffset, int outputLength)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)input);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &inputOffset;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &inputLength;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)output);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &outputOffset;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &outputLength;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Encode32_Public_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 47764, RefRangeEnd = 47765, XrefRangeStart = 47756, XrefRangeEnd = 47764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> Encode32(Il2CppStructArray<byte> input, int inputOffset, int inputLength)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)input);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &inputOffset;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &inputLength;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Encode32_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 47776, RefRangeEnd = 47777, XrefRangeStart = 47765, XrefRangeEnd = 47776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int Encode64(Il2CppStructArray<byte> input, int inputOffset, int inputLength, Il2CppStructArray<byte> output, int outputOffset, int outputLength)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)input);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &inputOffset;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &inputLength;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)output);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &outputOffset;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &outputLength;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Encode64_Public_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47777, XrefRangeEnd = 47785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> Encode64(Il2CppStructArray<byte> input, int inputOffset, int inputLength)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)input);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &inputOffset;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &inputLength;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Encode64_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 47796, RefRangeEnd = 47797, XrefRangeStart = 47785, XrefRangeEnd = 47796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int Decode32(Il2CppStructArray<byte> input, int inputOffset, int inputLength, Il2CppStructArray<byte> output, int outputOffset, int outputLength, bool knownOutputLength)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)input);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &inputOffset;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &inputLength;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)output);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &outputOffset;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &outputLength;
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &knownOutputLength;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Decode32_Public_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 47805, RefRangeEnd = 47806, XrefRangeStart = 47797, XrefRangeEnd = 47805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> Decode32(Il2CppStructArray<byte> input, int inputOffset, int inputLength, int outputLength)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)input);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &inputOffset;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &inputLength;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &outputLength;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Decode32_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 47817, RefRangeEnd = 47818, XrefRangeStart = 47806, XrefRangeEnd = 47817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int Decode64(Il2CppStructArray<byte> input, int inputOffset, int inputLength, Il2CppStructArray<byte> output, int outputOffset, int outputLength, bool knownOutputLength)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)input);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &inputOffset;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &inputLength;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)output);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &outputOffset;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &outputLength;
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &knownOutputLength;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Decode64_Public_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47818, XrefRangeEnd = 47826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> Decode64(Il2CppStructArray<byte> input, int inputOffset, int inputLength, int outputLength)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)input);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &inputOffset;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &inputLength;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &outputLength;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Decode64_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 47840, RefRangeEnd = 47844, XrefRangeStart = 47826, XrefRangeEnd = 47840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LZ4HC_Data_Structure LZ4HC_Create(Il2CppStructArray<byte> src, int src_0, int src_len, Il2CppStructArray<byte> dst, int dst_0, int dst_len)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)src);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &src_0;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &src_len;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dst);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &dst_0;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &dst_len;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LZ4HC_Create_Private_Static_LZ4HC_Data_Structure_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<LZ4HC_Data_Structure>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47844, XrefRangeEnd = 47849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int LZ4_compressHC_32(Il2CppStructArray<byte> input, int inputOffset, int inputLength, Il2CppStructArray<byte> output, int outputOffset, int outputLength)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)input);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &inputOffset;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &inputLength;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)output);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &outputOffset;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &outputLength;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LZ4_compressHC_32_Private_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 47859, RefRangeEnd = 47860, XrefRangeStart = 47849, XrefRangeEnd = 47859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int Encode32HC(Il2CppStructArray<byte> input, int inputOffset, int inputLength, Il2CppStructArray<byte> output, int outputOffset, int outputLength)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)input);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &inputOffset;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &inputLength;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)output);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &outputOffset;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &outputLength;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Encode32HC_Public_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47860, XrefRangeEnd = 47870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> Encode32HC(Il2CppStructArray<byte> input, int inputOffset, int inputLength)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)input);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &inputOffset;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &inputLength;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Encode32HC_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47870, XrefRangeEnd = 47875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int LZ4_compressHC_64(Il2CppStructArray<byte> input, int inputOffset, int inputLength, Il2CppStructArray<byte> output, int outputOffset, int outputLength)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)input);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &inputOffset;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &inputLength;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)output);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &outputOffset;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &outputLength;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LZ4_compressHC_64_Private_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 47885, RefRangeEnd = 47886, XrefRangeStart = 47875, XrefRangeEnd = 47885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int Encode64HC(Il2CppStructArray<byte> input, int inputOffset, int inputLength, Il2CppStructArray<byte> output, int outputOffset, int outputLength)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)input);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &inputOffset;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &inputLength;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)output);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &outputOffset;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &outputLength;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Encode64HC_Public_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47886, XrefRangeEnd = 47896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> Encode64HC(Il2CppStructArray<byte> input, int inputOffset, int inputLength)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)input);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &inputOffset;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &inputLength;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Encode64HC_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 47938, RefRangeEnd = 47939, XrefRangeStart = 47896, XrefRangeEnd = 47938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int LZ4_compressCtx_safe32(Il2CppStructArray<int> hash_table, Il2CppStructArray<byte> src, Il2CppStructArray<byte> dst, int src_0, int dst_0, int src_len, int dst_maxlen)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hash_table);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)src);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dst);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &src_0;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &dst_0;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &src_len;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &dst_maxlen;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LZ4_compressCtx_safe32_Private_Static_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47939, XrefRangeEnd = 47978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int LZ4_compress64kCtx_safe32(Il2CppStructArray<ushort> hash_table, Il2CppStructArray<byte> src, Il2CppStructArray<byte> dst, int src_0, int dst_0, int src_len, int dst_maxlen)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hash_table);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)src);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dst);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &src_0;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &dst_0;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &src_len;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &dst_maxlen;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LZ4_compress64kCtx_safe32_Private_Static_Int32_Il2CppStructArray_1_UInt16_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 48003, RefRangeEnd = 48004, XrefRangeStart = 47978, XrefRangeEnd = 48003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int LZ4_uncompress_safe32(Il2CppStructArray<byte> src, Il2CppStructArray<byte> dst, int src_0, int dst_0, int dst_len)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)src);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dst);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &src_0;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &dst_0;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &dst_len;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LZ4_uncompress_safe32_Private_Static_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 48033, RefRangeEnd = 48034, XrefRangeStart = 48004, XrefRangeEnd = 48033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int LZ4_uncompress_unknownOutputSize_safe32(Il2CppStructArray<byte> src, Il2CppStructArray<byte> dst, int src_0, int dst_0, int src_len, int dst_maxlen)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)src);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dst);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &src_0;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &dst_0;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &src_len;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &dst_maxlen;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LZ4_uncompress_unknownOutputSize_safe32_Private_Static_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 48040, RefRangeEnd = 48042, XrefRangeStart = 48034, XrefRangeEnd = 48040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LZ4HC_Insert_32(LZ4HC_Data_Structure ctx, int src_p)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &src_p;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LZ4HC_Insert_32_Private_Static_Void_LZ4HC_Data_Structure_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 48050, RefRangeEnd = 48052, XrefRangeStart = 48042, XrefRangeEnd = 48050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int LZ4HC_CommonLength_32(LZ4HC_Data_Structure ctx, int p1, int p2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &p1;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &p2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LZ4HC_CommonLength_32_Private_Static_Int32_LZ4HC_Data_Structure_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 48070, RefRangeEnd = 48071, XrefRangeStart = 48052, XrefRangeEnd = 48070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int LZ4HC_InsertAndFindBestMatch_32(LZ4HC_Data_Structure ctx, int src_p, ref int src_match)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &src_p;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref src_match);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LZ4HC_InsertAndFindBestMatch_32_Private_Static_Int32_LZ4HC_Data_Structure_Int32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 48084, RefRangeEnd = 48086, XrefRangeStart = 48071, XrefRangeEnd = 48084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int LZ4HC_InsertAndGetWiderMatch_32(LZ4HC_Data_Structure ctx, int src_p, int startLimit, int longest, ref int matchpos, ref int startpos)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &src_p;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &startLimit;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &longest;
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref matchpos);
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref startpos);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LZ4HC_InsertAndGetWiderMatch_32_Private_Static_Int32_LZ4HC_Data_Structure_Int32_Int32_Int32_byref_Int32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 48095, RefRangeEnd = 48100, XrefRangeStart = 48086, XrefRangeEnd = 48095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int LZ4_encodeSequence_32(LZ4HC_Data_Structure ctx, ref int src_p, ref int dst_p, ref int src_anchor, int matchLength, int src_ref, int dst_end)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref src_p);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref dst_p);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref src_anchor);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &matchLength;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &src_ref;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &dst_end;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LZ4_encodeSequence_32_Private_Static_Int32_LZ4HC_Data_Structure_byref_Int32_byref_Int32_byref_Int32_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 48137, RefRangeEnd = 48139, XrefRangeStart = 48100, XrefRangeEnd = 48137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int LZ4_compressHCCtx_32(LZ4HC_Data_Structure ctx)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LZ4_compressHCCtx_32_Private_Static_Int32_LZ4HC_Data_Structure_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 48184, RefRangeEnd = 48185, XrefRangeStart = 48139, XrefRangeEnd = 48184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int LZ4_compressCtx_safe64(Il2CppStructArray<int> hash_table, Il2CppStructArray<byte> src, Il2CppStructArray<byte> dst, int src_0, int dst_0, int src_len, int dst_maxlen)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hash_table);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)src);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dst);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &src_0;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &dst_0;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &src_len;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &dst_maxlen;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LZ4_compressCtx_safe64_Private_Static_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48185, XrefRangeEnd = 48227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int LZ4_compress64kCtx_safe64(Il2CppStructArray<ushort> hash_table, Il2CppStructArray<byte> src, Il2CppStructArray<byte> dst, int src_0, int dst_0, int src_len, int dst_maxlen)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hash_table);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)src);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dst);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &src_0;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &dst_0;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &src_len;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &dst_maxlen;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LZ4_compress64kCtx_safe64_Private_Static_Int32_Il2CppStructArray_1_UInt16_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 48253, RefRangeEnd = 48254, XrefRangeStart = 48227, XrefRangeEnd = 48253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int LZ4_uncompress_safe64(Il2CppStructArray<byte> src, Il2CppStructArray<byte> dst, int src_0, int dst_0, int dst_len)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)src);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dst);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &src_0;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &dst_0;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &dst_len;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LZ4_uncompress_safe64_Private_Static_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 48284, RefRangeEnd = 48285, XrefRangeStart = 48254, XrefRangeEnd = 48284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int LZ4_uncompress_unknownOutputSize_safe64(Il2CppStructArray<byte> src, Il2CppStructArray<byte> dst, int src_0, int dst_0, int src_len, int dst_maxlen)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)src);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dst);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &src_0;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &dst_0;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &src_len;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &dst_maxlen;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LZ4_uncompress_unknownOutputSize_safe64_Private_Static_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 48291, RefRangeEnd = 48293, XrefRangeStart = 48285, XrefRangeEnd = 48291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LZ4HC_Insert_64(LZ4HC_Data_Structure ctx, int src_p)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &src_p;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LZ4HC_Insert_64_Private_Static_Void_LZ4HC_Data_Structure_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 48306, RefRangeEnd = 48308, XrefRangeStart = 48293, XrefRangeEnd = 48306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int LZ4HC_CommonLength_64(LZ4HC_Data_Structure ctx, int p1, int p2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &p1;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &p2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LZ4HC_CommonLength_64_Private_Static_Int32_LZ4HC_Data_Structure_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 48326, RefRangeEnd = 48327, XrefRangeStart = 48308, XrefRangeEnd = 48326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int LZ4HC_InsertAndFindBestMatch_64(LZ4HC_Data_Structure ctx, int src_p, ref int matchpos)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &src_p;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref matchpos);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LZ4HC_InsertAndFindBestMatch_64_Private_Static_Int32_LZ4HC_Data_Structure_Int32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 48344, RefRangeEnd = 48346, XrefRangeStart = 48327, XrefRangeEnd = 48344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int LZ4HC_InsertAndGetWiderMatch_64(LZ4HC_Data_Structure ctx, int src_p, int startLimit, int longest, ref int matchpos, ref int startpos)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &src_p;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &startLimit;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &longest;
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref matchpos);
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref startpos);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LZ4HC_InsertAndGetWiderMatch_64_Private_Static_Int32_LZ4HC_Data_Structure_Int32_Int32_Int32_byref_Int32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 48355, RefRangeEnd = 48360, XrefRangeStart = 48346, XrefRangeEnd = 48355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int LZ4_encodeSequence_64(LZ4HC_Data_Structure ctx, ref int src_p, ref int dst_p, ref int src_anchor, int matchLength, int src_ref)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref src_p);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref dst_p);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref src_anchor);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &matchLength;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &src_ref;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LZ4_encodeSequence_64_Private_Static_Int32_LZ4HC_Data_Structure_byref_Int32_byref_Int32_byref_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 48397, RefRangeEnd = 48399, XrefRangeStart = 48360, XrefRangeEnd = 48397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int LZ4_compressHCCtx_64(LZ4HC_Data_Structure ctx)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LZ4_compressHCCtx_64_Private_Static_Int32_LZ4HC_Data_Structure_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public LZ4Codec(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
