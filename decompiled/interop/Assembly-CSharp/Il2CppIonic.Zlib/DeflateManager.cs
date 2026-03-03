using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppIonic.Zlib;

public sealed class DeflateManager : Il2CppSystem.Object
{
	public sealed class CompressFunc : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_BlockState_FlushType_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_FlushType_AsyncCallback_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_BlockState_IAsyncResult_0;

		static CompressFunc()
		{
			Il2CppClassPointerStore<CompressFunc>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, "CompressFunc");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompressFunc>.NativeClassPtr, 100664234);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_BlockState_FlushType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompressFunc>.NativeClassPtr, 100664235);
			NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_FlushType_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompressFunc>.NativeClassPtr, 100664236);
			NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_BlockState_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompressFunc>.NativeClassPtr, 100664237);
		}

		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 40144, RefRangeEnd = 40156, XrefRangeStart = 40141, XrefRangeEnd = 40144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CompressFunc(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompressFunc>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual BlockState Invoke(FlushType flush)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&flush);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_BlockState_FlushType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(BlockState*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40156, XrefRangeEnd = 40160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppSystem.IAsyncResult BeginInvoke(FlushType flush, Il2CppSystem.AsyncCallback callback, Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = (nint)(&flush);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_FlushType_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.IAsyncResult>(intPtr2) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40160, XrefRangeEnd = 40162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual BlockState EndInvoke(Il2CppSystem.IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_BlockState_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(BlockState*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public CompressFunc(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public static implicit operator CompressFunc(System.Func<FlushType, BlockState> P_0)
		{
			return DelegateSupport.ConvertDelegate<CompressFunc>((System.Delegate)P_0);
		}

		public static CompressFunc operator +(CompressFunc P_0, CompressFunc P_1)
		{
			return ((Il2CppObjectBase)Il2CppSystem.Delegate.Combine(P_0, P_1)).Cast<CompressFunc>();
		}

		public static CompressFunc operator -(CompressFunc P_0, CompressFunc P_1)
		{
			object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<CompressFunc>();
			}
			return (CompressFunc)obj;
		}
	}

	public class Config : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_GoodLength;

		private static readonly System.IntPtr NativeFieldInfoPtr_MaxLazy;

		private static readonly System.IntPtr NativeFieldInfoPtr_NiceLength;

		private static readonly System.IntPtr NativeFieldInfoPtr_MaxChainLength;

		private static readonly System.IntPtr NativeFieldInfoPtr_Flavor;

		private static readonly System.IntPtr NativeFieldInfoPtr_Table;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_Int32_Int32_Int32_Int32_DeflateFlavor_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Lookup_Public_Static_Config_CompressionLevel_0;

		public unsafe int GoodLength
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GoodLength);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GoodLength)) = value;
			}
		}

		public unsafe int MaxLazy
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxLazy);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxLazy)) = value;
			}
		}

		public unsafe int NiceLength
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NiceLength);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NiceLength)) = value;
			}
		}

		public unsafe int MaxChainLength
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxChainLength);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxChainLength)) = value;
			}
		}

		public unsafe DeflateFlavor Flavor
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Flavor);
				return *(DeflateFlavor*)num;
			}
			set
			{
				*(DeflateFlavor*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Flavor)) = value;
			}
		}

		public unsafe static Il2CppReferenceArray<Config> Table
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Table, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Config>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Table, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static Config()
		{
			Il2CppClassPointerStore<Config>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, "Config");
			NativeFieldInfoPtr_GoodLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "GoodLength");
			NativeFieldInfoPtr_MaxLazy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "MaxLazy");
			NativeFieldInfoPtr_NiceLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "NiceLength");
			NativeFieldInfoPtr_MaxChainLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "MaxChainLength");
			NativeFieldInfoPtr_Flavor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "Flavor");
			NativeFieldInfoPtr_Table = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "Table");
			NativeMethodInfoPtr__ctor_Private_Void_Int32_Int32_Int32_Int32_DeflateFlavor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100664238);
			NativeMethodInfoPtr_Lookup_Public_Static_Config_CompressionLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100664239);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40162, XrefRangeEnd = 40163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Config(int goodLength, int maxLazy, int niceLength, int maxChainLength, DeflateFlavor flavor)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Config>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[5];
			*ptr = (nint)(&goodLength);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxLazy;
			*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &niceLength;
			*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxChainLength;
			*(DeflateFlavor**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &flavor;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_Int32_Int32_Int32_Int32_DeflateFlavor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 40167, RefRangeEnd = 40168, XrefRangeStart = 40163, XrefRangeEnd = 40167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Config Lookup(CompressionLevel level)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&level);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Lookup_Public_Static_Config_CompressionLevel_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Config>(intPtr2) : null;
		}

		public Config(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_MEM_LEVEL_MAX;

	private static readonly System.IntPtr NativeFieldInfoPtr_MEM_LEVEL_DEFAULT;

	private static readonly System.IntPtr NativeFieldInfoPtr_DeflateFunction;

	private static readonly System.IntPtr NativeFieldInfoPtr__ErrorMessage;

	private static readonly System.IntPtr NativeFieldInfoPtr_PRESET_DICT;

	private static readonly System.IntPtr NativeFieldInfoPtr_INIT_STATE;

	private static readonly System.IntPtr NativeFieldInfoPtr_BUSY_STATE;

	private static readonly System.IntPtr NativeFieldInfoPtr_FINISH_STATE;

	private static readonly System.IntPtr NativeFieldInfoPtr_Z_DEFLATED;

	private static readonly System.IntPtr NativeFieldInfoPtr_STORED_BLOCK;

	private static readonly System.IntPtr NativeFieldInfoPtr_STATIC_TREES;

	private static readonly System.IntPtr NativeFieldInfoPtr_DYN_TREES;

	private static readonly System.IntPtr NativeFieldInfoPtr_Z_BINARY;

	private static readonly System.IntPtr NativeFieldInfoPtr_Z_ASCII;

	private static readonly System.IntPtr NativeFieldInfoPtr_Z_UNKNOWN;

	private static readonly System.IntPtr NativeFieldInfoPtr_Buf_size;

	private static readonly System.IntPtr NativeFieldInfoPtr_MIN_MATCH;

	private static readonly System.IntPtr NativeFieldInfoPtr_MAX_MATCH;

	private static readonly System.IntPtr NativeFieldInfoPtr_MIN_LOOKAHEAD;

	private static readonly System.IntPtr NativeFieldInfoPtr_HEAP_SIZE;

	private static readonly System.IntPtr NativeFieldInfoPtr_END_BLOCK;

	private static readonly System.IntPtr NativeFieldInfoPtr__codec;

	private static readonly System.IntPtr NativeFieldInfoPtr_status;

	private static readonly System.IntPtr NativeFieldInfoPtr_pending;

	private static readonly System.IntPtr NativeFieldInfoPtr_nextPending;

	private static readonly System.IntPtr NativeFieldInfoPtr_pendingCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_data_type;

	private static readonly System.IntPtr NativeFieldInfoPtr_last_flush;

	private static readonly System.IntPtr NativeFieldInfoPtr_w_size;

	private static readonly System.IntPtr NativeFieldInfoPtr_w_bits;

	private static readonly System.IntPtr NativeFieldInfoPtr_w_mask;

	private static readonly System.IntPtr NativeFieldInfoPtr_window;

	private static readonly System.IntPtr NativeFieldInfoPtr_window_size;

	private static readonly System.IntPtr NativeFieldInfoPtr_prev;

	private static readonly System.IntPtr NativeFieldInfoPtr_head;

	private static readonly System.IntPtr NativeFieldInfoPtr_ins_h;

	private static readonly System.IntPtr NativeFieldInfoPtr_hash_size;

	private static readonly System.IntPtr NativeFieldInfoPtr_hash_bits;

	private static readonly System.IntPtr NativeFieldInfoPtr_hash_mask;

	private static readonly System.IntPtr NativeFieldInfoPtr_hash_shift;

	private static readonly System.IntPtr NativeFieldInfoPtr_block_start;

	private static readonly System.IntPtr NativeFieldInfoPtr_config;

	private static readonly System.IntPtr NativeFieldInfoPtr_match_length;

	private static readonly System.IntPtr NativeFieldInfoPtr_prev_match;

	private static readonly System.IntPtr NativeFieldInfoPtr_match_available;

	private static readonly System.IntPtr NativeFieldInfoPtr_strstart;

	private static readonly System.IntPtr NativeFieldInfoPtr_match_start;

	private static readonly System.IntPtr NativeFieldInfoPtr_lookahead;

	private static readonly System.IntPtr NativeFieldInfoPtr_prev_length;

	private static readonly System.IntPtr NativeFieldInfoPtr_compressionLevel;

	private static readonly System.IntPtr NativeFieldInfoPtr_compressionStrategy;

	private static readonly System.IntPtr NativeFieldInfoPtr_dyn_ltree;

	private static readonly System.IntPtr NativeFieldInfoPtr_dyn_dtree;

	private static readonly System.IntPtr NativeFieldInfoPtr_bl_tree;

	private static readonly System.IntPtr NativeFieldInfoPtr_treeLiterals;

	private static readonly System.IntPtr NativeFieldInfoPtr_treeDistances;

	private static readonly System.IntPtr NativeFieldInfoPtr_treeBitLengths;

	private static readonly System.IntPtr NativeFieldInfoPtr_bl_count;

	private static readonly System.IntPtr NativeFieldInfoPtr_heap;

	private static readonly System.IntPtr NativeFieldInfoPtr_heap_len;

	private static readonly System.IntPtr NativeFieldInfoPtr_heap_max;

	private static readonly System.IntPtr NativeFieldInfoPtr_depth;

	private static readonly System.IntPtr NativeFieldInfoPtr__lengthOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_lit_bufsize;

	private static readonly System.IntPtr NativeFieldInfoPtr_last_lit;

	private static readonly System.IntPtr NativeFieldInfoPtr__distanceOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_opt_len;

	private static readonly System.IntPtr NativeFieldInfoPtr_static_len;

	private static readonly System.IntPtr NativeFieldInfoPtr_matches;

	private static readonly System.IntPtr NativeFieldInfoPtr_last_eob_len;

	private static readonly System.IntPtr NativeFieldInfoPtr_bi_buf;

	private static readonly System.IntPtr NativeFieldInfoPtr_bi_valid;

	private static readonly System.IntPtr NativeFieldInfoPtr_Rfc1950BytesEmitted;

	private static readonly System.IntPtr NativeFieldInfoPtr__WantRfc1950HeaderBytes;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__InitializeLazyMatch_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__InitializeTreeData_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__InitializeBlocks_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_pqdownheap_Internal_Void_Il2CppStructArray_1_Int16_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__IsSmaller_Internal_Static_Boolean_Il2CppStructArray_1_Int16_Int32_Int32_Il2CppStructArray_1_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_scan_tree_Internal_Void_Il2CppStructArray_1_Int16_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_build_bl_tree_Internal_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_send_all_trees_Internal_Void_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_send_tree_Internal_Void_Il2CppStructArray_1_Int16_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_put_bytes_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_send_code_Internal_Void_Int32_Il2CppStructArray_1_Int16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_send_bits_Internal_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__tr_align_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__tr_tally_Internal_Boolean_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_send_compressed_block_Internal_Void_Il2CppStructArray_1_Int16_Il2CppStructArray_1_Int16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_data_type_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_bi_flush_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_bi_windup_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_copy_block_Internal_Void_Int32_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_flush_block_only_Internal_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeflateNone_Internal_BlockState_FlushType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__tr_stored_block_Internal_Void_Int32_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__tr_flush_block_Internal_Void_Int32_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__fillWindow_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeflateFast_Internal_BlockState_FlushType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeflateSlow_Internal_BlockState_FlushType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_longest_match_Internal_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_WantRfc1950HeaderBytes_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_WantRfc1950HeaderBytes_Internal_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Internal_Int32_ZlibCodec_CompressionLevel_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Internal_Int32_ZlibCodec_CompressionLevel_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Internal_Int32_ZlibCodec_CompressionLevel_Int32_CompressionStrategy_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Internal_Int32_ZlibCodec_CompressionLevel_Int32_Int32_CompressionStrategy_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_End_Internal_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDeflater_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetParams_Internal_Int32_CompressionLevel_CompressionStrategy_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDictionary_Internal_Int32_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Deflate_Internal_Int32_FlushType_0;

	public unsafe static int MEM_LEVEL_MAX
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MEM_LEVEL_MAX, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MEM_LEVEL_MAX, (void*)(&value));
		}
	}

	public unsafe static int MEM_LEVEL_DEFAULT
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MEM_LEVEL_DEFAULT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MEM_LEVEL_DEFAULT, (void*)(&value));
		}
	}

	public unsafe CompressFunc DeflateFunction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DeflateFunction);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CompressFunc>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DeflateFunction)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStringArray _ErrorMessage
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__ErrorMessage, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__ErrorMessage, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

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

	public unsafe static int INIT_STATE
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_INIT_STATE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_INIT_STATE, (void*)(&value));
		}
	}

	public unsafe static int BUSY_STATE
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BUSY_STATE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BUSY_STATE, (void*)(&value));
		}
	}

	public unsafe static int FINISH_STATE
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FINISH_STATE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FINISH_STATE, (void*)(&value));
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

	public unsafe static int STORED_BLOCK
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_STORED_BLOCK, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_STORED_BLOCK, (void*)(&value));
		}
	}

	public unsafe static int STATIC_TREES
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_STATIC_TREES, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_STATIC_TREES, (void*)(&value));
		}
	}

	public unsafe static int DYN_TREES
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DYN_TREES, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DYN_TREES, (void*)(&value));
		}
	}

	public unsafe static int Z_BINARY
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Z_BINARY, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Z_BINARY, (void*)(&value));
		}
	}

	public unsafe static int Z_ASCII
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Z_ASCII, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Z_ASCII, (void*)(&value));
		}
	}

	public unsafe static int Z_UNKNOWN
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Z_UNKNOWN, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Z_UNKNOWN, (void*)(&value));
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

	public unsafe static int MIN_MATCH
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MIN_MATCH, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MIN_MATCH, (void*)(&value));
		}
	}

	public unsafe static int MAX_MATCH
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MAX_MATCH, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MAX_MATCH, (void*)(&value));
		}
	}

	public unsafe static int MIN_LOOKAHEAD
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MIN_LOOKAHEAD, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MIN_LOOKAHEAD, (void*)(&value));
		}
	}

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

	public unsafe static int END_BLOCK
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_END_BLOCK, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_END_BLOCK, (void*)(&value));
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

	public unsafe int status
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_status);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_status)) = value;
		}
	}

	public unsafe Il2CppStructArray<byte> pending
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pending);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pending)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int nextPending
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nextPending);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nextPending)) = value;
		}
	}

	public unsafe int pendingCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pendingCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pendingCount)) = value;
		}
	}

	public unsafe sbyte data_type
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_data_type);
			return *(sbyte*)num;
		}
		set
		{
			*(sbyte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_data_type)) = value;
		}
	}

	public unsafe int last_flush
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_last_flush);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_last_flush)) = value;
		}
	}

	public unsafe int w_size
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_w_size);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_w_size)) = value;
		}
	}

	public unsafe int w_bits
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_w_bits);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_w_bits)) = value;
		}
	}

	public unsafe int w_mask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_w_mask);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_w_mask)) = value;
		}
	}

	public unsafe Il2CppStructArray<byte> window
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_window);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_window)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int window_size
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_window_size);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_window_size)) = value;
		}
	}

	public unsafe Il2CppStructArray<short> prev
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prev);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<short>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prev)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<short> head
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_head);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<short>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_head)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int ins_h
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ins_h);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ins_h)) = value;
		}
	}

	public unsafe int hash_size
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hash_size);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hash_size)) = value;
		}
	}

	public unsafe int hash_bits
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hash_bits);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hash_bits)) = value;
		}
	}

	public unsafe int hash_mask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hash_mask);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hash_mask)) = value;
		}
	}

	public unsafe int hash_shift
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hash_shift);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hash_shift)) = value;
		}
	}

	public unsafe int block_start
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_block_start);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_block_start)) = value;
		}
	}

	public unsafe Config config
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_config);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Config>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_config)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int match_length
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_match_length);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_match_length)) = value;
		}
	}

	public unsafe int prev_match
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prev_match);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prev_match)) = value;
		}
	}

	public unsafe int match_available
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_match_available);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_match_available)) = value;
		}
	}

	public unsafe int strstart
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_strstart);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_strstart)) = value;
		}
	}

	public unsafe int match_start
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_match_start);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_match_start)) = value;
		}
	}

	public unsafe int lookahead
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lookahead);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lookahead)) = value;
		}
	}

	public unsafe int prev_length
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prev_length);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prev_length)) = value;
		}
	}

	public unsafe CompressionLevel compressionLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_compressionLevel);
			return *(CompressionLevel*)num;
		}
		set
		{
			*(CompressionLevel*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_compressionLevel)) = value;
		}
	}

	public unsafe CompressionStrategy compressionStrategy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_compressionStrategy);
			return *(CompressionStrategy*)num;
		}
		set
		{
			*(CompressionStrategy*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_compressionStrategy)) = value;
		}
	}

	public unsafe Il2CppStructArray<short> dyn_ltree
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dyn_ltree);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<short>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dyn_ltree)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<short> dyn_dtree
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dyn_dtree);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<short>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dyn_dtree)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<short> bl_tree
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bl_tree);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<short>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bl_tree)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Tree treeLiterals
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_treeLiterals);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Tree>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_treeLiterals)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Tree treeDistances
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_treeDistances);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Tree>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_treeDistances)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Tree treeBitLengths
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_treeBitLengths);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Tree>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_treeBitLengths)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<short> bl_count
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bl_count);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<short>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bl_count)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<int> heap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int heap_len
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heap_len);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heap_len)) = value;
		}
	}

	public unsafe int heap_max
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heap_max);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heap_max)) = value;
		}
	}

	public unsafe Il2CppStructArray<sbyte> depth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_depth);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<sbyte>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_depth)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int _lengthOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lengthOffset);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lengthOffset)) = value;
		}
	}

	public unsafe int lit_bufsize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lit_bufsize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lit_bufsize)) = value;
		}
	}

	public unsafe int last_lit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_last_lit);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_last_lit)) = value;
		}
	}

	public unsafe int _distanceOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__distanceOffset);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__distanceOffset)) = value;
		}
	}

	public unsafe int opt_len
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_opt_len);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_opt_len)) = value;
		}
	}

	public unsafe int static_len
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_static_len);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_static_len)) = value;
		}
	}

	public unsafe int matches
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_matches);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_matches)) = value;
		}
	}

	public unsafe int last_eob_len
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_last_eob_len);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_last_eob_len)) = value;
		}
	}

	public unsafe short bi_buf
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bi_buf);
			return *(short*)num;
		}
		set
		{
			*(short*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bi_buf)) = value;
		}
	}

	public unsafe int bi_valid
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bi_valid);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bi_valid)) = value;
		}
	}

	public unsafe bool Rfc1950BytesEmitted
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Rfc1950BytesEmitted);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Rfc1950BytesEmitted)) = value;
		}
	}

	public unsafe bool _WantRfc1950HeaderBytes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__WantRfc1950HeaderBytes);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__WantRfc1950HeaderBytes)) = value;
		}
	}

	public unsafe bool WantRfc1950HeaderBytes
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_WantRfc1950HeaderBytes_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
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
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_WantRfc1950HeaderBytes_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static DeflateManager()
	{
		Il2CppClassPointerStore<DeflateManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Ionic.Zlib", "DeflateManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr);
		NativeFieldInfoPtr_MEM_LEVEL_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, "MEM_LEVEL_MAX");
		NativeFieldInfoPtr_MEM_LEVEL_DEFAULT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, "MEM_LEVEL_DEFAULT");
		NativeFieldInfoPtr_DeflateFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, "DeflateFunction");
		NativeFieldInfoPtr__ErrorMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, "_ErrorMessage");
		NativeFieldInfoPtr_PRESET_DICT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, "PRESET_DICT");
		NativeFieldInfoPtr_INIT_STATE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, "INIT_STATE");
		NativeFieldInfoPtr_BUSY_STATE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, "BUSY_STATE");
		NativeFieldInfoPtr_FINISH_STATE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, "FINISH_STATE");
		NativeFieldInfoPtr_Z_DEFLATED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, "Z_DEFLATED");
		NativeFieldInfoPtr_STORED_BLOCK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, "STORED_BLOCK");
		NativeFieldInfoPtr_STATIC_TREES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, "STATIC_TREES");
		NativeFieldInfoPtr_DYN_TREES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, "DYN_TREES");
		NativeFieldInfoPtr_Z_BINARY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, "Z_BINARY");
		NativeFieldInfoPtr_Z_ASCII = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, "Z_ASCII");
		NativeFieldInfoPtr_Z_UNKNOWN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, "Z_UNKNOWN");
		NativeFieldInfoPtr_Buf_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, "Buf_size");
		NativeFieldInfoPtr_MIN_MATCH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, "MIN_MATCH");
		NativeFieldInfoPtr_MAX_MATCH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, "MAX_MATCH");
		NativeFieldInfoPtr_MIN_LOOKAHEAD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, "MIN_LOOKAHEAD");
		NativeFieldInfoPtr_HEAP_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, "HEAP_SIZE");
		NativeFieldInfoPtr_END_BLOCK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, "END_BLOCK");
		NativeFieldInfoPtr__codec = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, "_codec");
		NativeFieldInfoPtr_status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, "status");
		NativeFieldInfoPtr_pending = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, "pending");
		NativeFieldInfoPtr_nextPending = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, "nextPending");
		NativeFieldInfoPtr_pendingCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, "pendingCount");
		NativeFieldInfoPtr_data_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, "data_type");
		NativeFieldInfoPtr_last_flush = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, "last_flush");
		NativeFieldInfoPtr_w_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, "w_size");
		NativeFieldInfoPtr_w_bits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, "w_bits");
		NativeFieldInfoPtr_w_mask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, "w_mask");
		NativeFieldInfoPtr_window = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, "window");
		NativeFieldInfoPtr_window_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, "window_size");
		NativeFieldInfoPtr_prev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, "prev");
		NativeFieldInfoPtr_head = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, "head");
		NativeFieldInfoPtr_ins_h = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, "ins_h");
		NativeFieldInfoPtr_hash_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, "hash_size");
		NativeFieldInfoPtr_hash_bits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, "hash_bits");
		NativeFieldInfoPtr_hash_mask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, "hash_mask");
		NativeFieldInfoPtr_hash_shift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, "hash_shift");
		NativeFieldInfoPtr_block_start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, "block_start");
		NativeFieldInfoPtr_config = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, "config");
		NativeFieldInfoPtr_match_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, "match_length");
		NativeFieldInfoPtr_prev_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, "prev_match");
		NativeFieldInfoPtr_match_available = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, "match_available");
		NativeFieldInfoPtr_strstart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, "strstart");
		NativeFieldInfoPtr_match_start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, "match_start");
		NativeFieldInfoPtr_lookahead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, "lookahead");
		NativeFieldInfoPtr_prev_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, "prev_length");
		NativeFieldInfoPtr_compressionLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, "compressionLevel");
		NativeFieldInfoPtr_compressionStrategy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, "compressionStrategy");
		NativeFieldInfoPtr_dyn_ltree = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, "dyn_ltree");
		NativeFieldInfoPtr_dyn_dtree = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, "dyn_dtree");
		NativeFieldInfoPtr_bl_tree = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, "bl_tree");
		NativeFieldInfoPtr_treeLiterals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, "treeLiterals");
		NativeFieldInfoPtr_treeDistances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, "treeDistances");
		NativeFieldInfoPtr_treeBitLengths = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, "treeBitLengths");
		NativeFieldInfoPtr_bl_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, "bl_count");
		NativeFieldInfoPtr_heap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, "heap");
		NativeFieldInfoPtr_heap_len = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, "heap_len");
		NativeFieldInfoPtr_heap_max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, "heap_max");
		NativeFieldInfoPtr_depth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, "depth");
		NativeFieldInfoPtr__lengthOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, "_lengthOffset");
		NativeFieldInfoPtr_lit_bufsize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, "lit_bufsize");
		NativeFieldInfoPtr_last_lit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, "last_lit");
		NativeFieldInfoPtr__distanceOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, "_distanceOffset");
		NativeFieldInfoPtr_opt_len = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, "opt_len");
		NativeFieldInfoPtr_static_len = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, "static_len");
		NativeFieldInfoPtr_matches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, "matches");
		NativeFieldInfoPtr_last_eob_len = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, "last_eob_len");
		NativeFieldInfoPtr_bi_buf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, "bi_buf");
		NativeFieldInfoPtr_bi_valid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, "bi_valid");
		NativeFieldInfoPtr_Rfc1950BytesEmitted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, "Rfc1950BytesEmitted");
		NativeFieldInfoPtr__WantRfc1950HeaderBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, "_WantRfc1950HeaderBytes");
		NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, 100664193);
		NativeMethodInfoPtr__InitializeLazyMatch_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, 100664194);
		NativeMethodInfoPtr__InitializeTreeData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, 100664195);
		NativeMethodInfoPtr__InitializeBlocks_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, 100664196);
		NativeMethodInfoPtr_pqdownheap_Internal_Void_Il2CppStructArray_1_Int16_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, 100664197);
		NativeMethodInfoPtr__IsSmaller_Internal_Static_Boolean_Il2CppStructArray_1_Int16_Int32_Int32_Il2CppStructArray_1_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, 100664198);
		NativeMethodInfoPtr_scan_tree_Internal_Void_Il2CppStructArray_1_Int16_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, 100664199);
		NativeMethodInfoPtr_build_bl_tree_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, 100664200);
		NativeMethodInfoPtr_send_all_trees_Internal_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, 100664201);
		NativeMethodInfoPtr_send_tree_Internal_Void_Il2CppStructArray_1_Int16_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, 100664202);
		NativeMethodInfoPtr_put_bytes_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, 100664203);
		NativeMethodInfoPtr_send_code_Internal_Void_Int32_Il2CppStructArray_1_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, 100664204);
		NativeMethodInfoPtr_send_bits_Internal_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, 100664205);
		NativeMethodInfoPtr__tr_align_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, 100664206);
		NativeMethodInfoPtr__tr_tally_Internal_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, 100664207);
		NativeMethodInfoPtr_send_compressed_block_Internal_Void_Il2CppStructArray_1_Int16_Il2CppStructArray_1_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, 100664208);
		NativeMethodInfoPtr_set_data_type_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, 100664209);
		NativeMethodInfoPtr_bi_flush_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, 100664210);
		NativeMethodInfoPtr_bi_windup_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, 100664211);
		NativeMethodInfoPtr_copy_block_Internal_Void_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, 100664212);
		NativeMethodInfoPtr_flush_block_only_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, 100664213);
		NativeMethodInfoPtr_DeflateNone_Internal_BlockState_FlushType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, 100664214);
		NativeMethodInfoPtr__tr_stored_block_Internal_Void_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, 100664215);
		NativeMethodInfoPtr__tr_flush_block_Internal_Void_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, 100664216);
		NativeMethodInfoPtr__fillWindow_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, 100664217);
		NativeMethodInfoPtr_DeflateFast_Internal_BlockState_FlushType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, 100664218);
		NativeMethodInfoPtr_DeflateSlow_Internal_BlockState_FlushType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, 100664219);
		NativeMethodInfoPtr_longest_match_Internal_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, 100664220);
		NativeMethodInfoPtr_get_WantRfc1950HeaderBytes_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, 100664221);
		NativeMethodInfoPtr_set_WantRfc1950HeaderBytes_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, 100664222);
		NativeMethodInfoPtr_Initialize_Internal_Int32_ZlibCodec_CompressionLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, 100664223);
		NativeMethodInfoPtr_Initialize_Internal_Int32_ZlibCodec_CompressionLevel_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, 100664224);
		NativeMethodInfoPtr_Initialize_Internal_Int32_ZlibCodec_CompressionLevel_Int32_CompressionStrategy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, 100664225);
		NativeMethodInfoPtr_Initialize_Internal_Int32_ZlibCodec_CompressionLevel_Int32_Int32_CompressionStrategy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, 100664226);
		NativeMethodInfoPtr_Reset_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, 100664227);
		NativeMethodInfoPtr_End_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, 100664228);
		NativeMethodInfoPtr_SetDeflater_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, 100664229);
		NativeMethodInfoPtr_SetParams_Internal_Int32_CompressionLevel_CompressionStrategy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, 100664230);
		NativeMethodInfoPtr_SetDictionary_Internal_Int32_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, 100664231);
		NativeMethodInfoPtr_Deflate_Internal_Int32_FlushType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr, 100664232);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 40215, RefRangeEnd = 40216, XrefRangeStart = 40168, XrefRangeEnd = 40215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DeflateManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeflateManager>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40216, XrefRangeEnd = 40230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _InitializeLazyMatch()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__InitializeLazyMatch_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40230, XrefRangeEnd = 40244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _InitializeTreeData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__InitializeTreeData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 40261, RefRangeEnd = 40264, XrefRangeStart = 40244, XrefRangeEnd = 40261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _InitializeBlocks()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__InitializeBlocks_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 40269, RefRangeEnd = 40272, XrefRangeStart = 40264, XrefRangeEnd = 40269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void pqdownheap(Il2CppStructArray<short> tree, int k)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tree);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &k;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_pqdownheap_Internal_Void_Il2CppStructArray_1_Int16_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static bool _IsSmaller(Il2CppStructArray<short> tree, int n, int m, Il2CppStructArray<sbyte> depth)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tree);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &n;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &m;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)depth);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__IsSmaller_Internal_Static_Boolean_Il2CppStructArray_1_Int16_Int32_Int32_Il2CppStructArray_1_SByte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 40286, RefRangeEnd = 40290, XrefRangeStart = 40272, XrefRangeEnd = 40286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void scan_tree(Il2CppStructArray<short> tree, int max_code)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tree);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &max_code;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_scan_tree_Internal_Void_Il2CppStructArray_1_Int16_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40290, XrefRangeEnd = 40301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int build_bl_tree()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_build_bl_tree_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40301, XrefRangeEnd = 40313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void send_all_trees(int lcodes, int dcodes, int blcodes)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&lcodes);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &dcodes;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &blcodes;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_send_all_trees_Internal_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 40335, RefRangeEnd = 40339, XrefRangeStart = 40313, XrefRangeEnd = 40335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void send_tree(Il2CppStructArray<short> tree, int max_code)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tree);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &max_code;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_send_tree_Internal_Void_Il2CppStructArray_1_Int16_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40339, XrefRangeEnd = 40340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void put_bytes(Il2CppStructArray<byte> p, int start, int len)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &start;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &len;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_put_bytes_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40340, XrefRangeEnd = 40343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void send_code(int c, Il2CppStructArray<short> tree)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&c);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tree);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_send_code_Internal_Void_Int32_Il2CppStructArray_1_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(29)]
	[CachedScanResults(RefRangeStart = 40347, RefRangeEnd = 40376, XrefRangeStart = 40343, XrefRangeEnd = 40347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void send_bits(int value, int length)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&value);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_send_bits_Internal_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40376, XrefRangeEnd = 40398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _tr_align()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__tr_align_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 40415, RefRangeEnd = 40420, XrefRangeStart = 40398, XrefRangeEnd = 40415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool _tr_tally(int dist, int lc)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&dist);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &lc;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__tr_tally_Internal_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 40448, RefRangeEnd = 40449, XrefRangeStart = 40420, XrefRangeEnd = 40448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void send_compressed_block(Il2CppStructArray<short> ltree, Il2CppStructArray<short> dtree)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ltree);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dtree);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_send_compressed_block_Internal_Void_Il2CppStructArray_1_Int16_Il2CppStructArray_1_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 40461, RefRangeEnd = 40462, XrefRangeStart = 40449, XrefRangeEnd = 40461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void set_data_type()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_data_type_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 40462, RefRangeEnd = 40464, XrefRangeStart = 40462, XrefRangeEnd = 40462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void bi_flush()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_bi_flush_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 40464, RefRangeEnd = 40467, XrefRangeStart = 40464, XrefRangeEnd = 40464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void bi_windup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_bi_windup_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40467, XrefRangeEnd = 40469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void copy_block(int buf, int len, bool header)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&buf);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &len;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &header;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_copy_block_Internal_Void_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 40473, RefRangeEnd = 40474, XrefRangeStart = 40469, XrefRangeEnd = 40473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void flush_block_only(bool eof)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&eof);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_flush_block_only_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40474, XrefRangeEnd = 40485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BlockState DeflateNone(FlushType flush)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&flush);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeflateNone_Internal_BlockState_FlushType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(BlockState*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 40492, RefRangeEnd = 40493, XrefRangeStart = 40485, XrefRangeEnd = 40492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _tr_stored_block(int buf, int stored_len, bool eof)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&buf);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &stored_len;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &eof;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__tr_stored_block_Internal_Void_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 40539, RefRangeEnd = 40545, XrefRangeStart = 40493, XrefRangeEnd = 40539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _tr_flush_block(int buf, int stored_len, bool eof)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&buf);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &stored_len;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &eof;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__tr_flush_block_Internal_Void_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 40561, RefRangeEnd = 40564, XrefRangeStart = 40545, XrefRangeEnd = 40561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _fillWindow()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__fillWindow_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40564, XrefRangeEnd = 40598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BlockState DeflateFast(FlushType flush)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&flush);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeflateFast_Internal_BlockState_FlushType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(BlockState*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40598, XrefRangeEnd = 40646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BlockState DeflateSlow(FlushType flush)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&flush);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeflateSlow_Internal_BlockState_FlushType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(BlockState*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 40659, RefRangeEnd = 40661, XrefRangeStart = 40646, XrefRangeEnd = 40659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int longest_match(int cur_match)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&cur_match);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_longest_match_Internal_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40661, XrefRangeEnd = 40666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int Initialize(ZlibCodec codec, CompressionLevel level)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)codec);
		*(CompressionLevel**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &level;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Internal_Int32_ZlibCodec_CompressionLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40666, XrefRangeEnd = 40671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int Initialize(ZlibCodec codec, CompressionLevel level, int bits)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)codec);
		*(CompressionLevel**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &level;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &bits;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Internal_Int32_ZlibCodec_CompressionLevel_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 40676, RefRangeEnd = 40677, XrefRangeStart = 40671, XrefRangeEnd = 40676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int Initialize(ZlibCodec codec, CompressionLevel level, int bits, CompressionStrategy compressionStrategy)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)codec);
		*(CompressionLevel**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &level;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &bits;
		*(CompressionStrategy**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &compressionStrategy;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Internal_Int32_ZlibCodec_CompressionLevel_Int32_CompressionStrategy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 40702, RefRangeEnd = 40705, XrefRangeStart = 40677, XrefRangeEnd = 40702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int Initialize(ZlibCodec codec, CompressionLevel level, int windowBits, int memLevel, CompressionStrategy strategy)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)codec);
		*(CompressionLevel**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &level;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &windowBits;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &memLevel;
		*(CompressionStrategy**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &strategy;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Internal_Int32_ZlibCodec_CompressionLevel_Int32_Int32_CompressionStrategy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 40744, RefRangeEnd = 40746, XrefRangeStart = 40705, XrefRangeEnd = 40744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Reset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reset_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40746, XrefRangeEnd = 40754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int End()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_End_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 40777, RefRangeEnd = 40780, XrefRangeStart = 40754, XrefRangeEnd = 40777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDeflater()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDeflater_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 40787, RefRangeEnd = 40788, XrefRangeStart = 40780, XrefRangeEnd = 40787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int SetParams(CompressionLevel level, CompressionStrategy strategy)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&level);
		*(CompressionStrategy**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &strategy;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetParams_Internal_Int32_CompressionLevel_CompressionStrategy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 40810, RefRangeEnd = 40811, XrefRangeStart = 40788, XrefRangeEnd = 40810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 40829, RefRangeEnd = 40833, XrefRangeStart = 40811, XrefRangeEnd = 40829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int Deflate(FlushType flush)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&flush);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Deflate_Internal_Int32_FlushType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public DeflateManager(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
