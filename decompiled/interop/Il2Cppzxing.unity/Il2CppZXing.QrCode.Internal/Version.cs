using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppZXing.Common;

namespace Il2CppZXing.QrCode.Internal;

public sealed class Version : Il2CppSystem.Object
{
	public sealed class ECBlocks : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_ecCodewordsPerBlock;

		private static readonly System.IntPtr NativeFieldInfoPtr_ecBlocks;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_Il2CppReferenceArray_1_ECB_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_ECCodewordsPerBlock_Public_get_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_NumBlocks_Public_get_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_TotalECCodewords_Public_get_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_getECBlocks_Public_Il2CppReferenceArray_1_ECB_0;

		public unsafe int ecCodewordsPerBlock
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ecCodewordsPerBlock);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ecCodewordsPerBlock)) = value;
			}
		}

		public unsafe Il2CppReferenceArray<ECB> ecBlocks
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ecBlocks);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ECB>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ecBlocks)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe int ECCodewordsPerBlock
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 50668, RefRangeEnd = 50669, XrefRangeStart = 50668, XrefRangeEnd = 50669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ECCodewordsPerBlock_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		public unsafe int NumBlocks
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1413806, XrefRangeEnd = 1413807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_NumBlocks_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		public unsafe int TotalECCodewords
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1413807, XrefRangeEnd = 1413808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_TotalECCodewords_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		static ECBlocks()
		{
			Il2CppClassPointerStore<ECBlocks>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Version>.NativeClassPtr, "ECBlocks");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ECBlocks>.NativeClassPtr);
			NativeFieldInfoPtr_ecCodewordsPerBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ECBlocks>.NativeClassPtr, "ecCodewordsPerBlock");
			NativeFieldInfoPtr_ecBlocks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ECBlocks>.NativeClassPtr, "ecBlocks");
			NativeMethodInfoPtr__ctor_Internal_Void_Int32_Il2CppReferenceArray_1_ECB_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ECBlocks>.NativeClassPtr, 100663639);
			NativeMethodInfoPtr_get_ECCodewordsPerBlock_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ECBlocks>.NativeClassPtr, 100663640);
			NativeMethodInfoPtr_get_NumBlocks_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ECBlocks>.NativeClassPtr, 100663641);
			NativeMethodInfoPtr_get_TotalECCodewords_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ECBlocks>.NativeClassPtr, 100663642);
			NativeMethodInfoPtr_getECBlocks_Public_Il2CppReferenceArray_1_ECB_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ECBlocks>.NativeClassPtr, 100663643);
		}

		[CallerCount(171)]
		[CachedScanResults(RefRangeStart = 351582, RefRangeEnd = 351753, XrefRangeStart = 351582, XrefRangeEnd = 351753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ECBlocks(int ecCodewordsPerBlock, [Optional] Il2CppReferenceArray<ECB> ecBlocks)
		{
			if (ecBlocks == null)
			{
				ecBlocks = new Il2CppReferenceArray<ECB>(0L);
			}
			this._002Ector(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ECBlocks>.NativeClassPtr));
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&ecCodewordsPerBlock);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ecBlocks);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_Int32_Il2CppReferenceArray_1_ECB_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 25665, RefRangeEnd = 25677, XrefRangeStart = 25665, XrefRangeEnd = 25677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<ECB> getECBlocks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getECBlocks_Public_Il2CppReferenceArray_1_ECB_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ECB>>(intPtr2) : null;
		}

		public ECBlocks(int ecCodewordsPerBlock, params ECB[] ecBlocks)
			: this(ecCodewordsPerBlock, new Il2CppReferenceArray<ECB>(ecBlocks))
		{
		}

		public ECBlocks(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public sealed class ECB : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_count;

		private static readonly System.IntPtr NativeFieldInfoPtr_dataCodewords;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_DataCodewords_Public_get_Int32_0;

		public unsafe int count
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_count);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_count)) = value;
			}
		}

		public unsafe int dataCodewords
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dataCodewords);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dataCodewords)) = value;
			}
		}

		public unsafe int Count
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 50668, RefRangeEnd = 50669, XrefRangeStart = 50668, XrefRangeEnd = 50669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		public unsafe int DataCodewords
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 82717, RefRangeEnd = 82718, XrefRangeStart = 82717, XrefRangeEnd = 82718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DataCodewords_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		static ECB()
		{
			Il2CppClassPointerStore<ECB>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Version>.NativeClassPtr, "ECB");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ECB>.NativeClassPtr);
			NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ECB>.NativeClassPtr, "count");
			NativeFieldInfoPtr_dataCodewords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ECB>.NativeClassPtr, "dataCodewords");
			NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ECB>.NativeClassPtr, 100663644);
			NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ECB>.NativeClassPtr, 100663645);
			NativeMethodInfoPtr_get_DataCodewords_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ECB>.NativeClassPtr, 100663646);
		}

		[CallerCount(296)]
		[CachedScanResults(RefRangeStart = 207370, RefRangeEnd = 207666, XrefRangeStart = 207370, XrefRangeEnd = 207666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ECB(int count, int dataCodewords)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ECB>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&count);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &dataCodewords;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public ECB(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_VERSION_DECODE_INFO;

	private static readonly System.IntPtr NativeFieldInfoPtr_VERSIONS;

	private static readonly System.IntPtr NativeFieldInfoPtr_versionNumber;

	private static readonly System.IntPtr NativeFieldInfoPtr_alignmentPatternCenters;

	private static readonly System.IntPtr NativeFieldInfoPtr_ecBlocks;

	private static readonly System.IntPtr NativeFieldInfoPtr_totalCodewords;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_Int32_Il2CppStructArray_1_Int32_Il2CppReferenceArray_1_ECBlocks_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_VersionNumber_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_AlignmentPatternCenters_Public_get_Il2CppStructArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_TotalCodewords_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_DimensionForVersion_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getECBlocksForLevel_Public_ECBlocks_ErrorCorrectionLevel_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getProvisionalVersionForDimension_Public_Static_Version_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getVersionForNumber_Public_Static_Version_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_decodeVersionInformation_Internal_Static_Version_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_buildFunctionPattern_Internal_BitMatrix_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_buildVersions_Private_Static_Il2CppReferenceArray_1_Version_0;

	public unsafe static Il2CppStructArray<int> VERSION_DECODE_INFO
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_VERSION_DECODE_INFO, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_VERSION_DECODE_INFO, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<Version> VERSIONS
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_VERSIONS, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Version>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_VERSIONS, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int versionNumber
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_versionNumber);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_versionNumber)) = value;
		}
	}

	public unsafe Il2CppStructArray<int> alignmentPatternCenters
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alignmentPatternCenters);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alignmentPatternCenters)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppReferenceArray<ECBlocks> ecBlocks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ecBlocks);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ECBlocks>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ecBlocks)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int totalCodewords
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_totalCodewords);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_totalCodewords)) = value;
		}
	}

	public unsafe int VersionNumber
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 50668, RefRangeEnd = 50669, XrefRangeStart = 50668, XrefRangeEnd = 50669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_VersionNumber_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe Il2CppStructArray<int> AlignmentPatternCenters
	{
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 25665, RefRangeEnd = 25677, XrefRangeStart = 25665, XrefRangeEnd = 25677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_AlignmentPatternCenters_Public_get_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
	}

	public unsafe int TotalCodewords
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 80842, RefRangeEnd = 80843, XrefRangeStart = 80842, XrefRangeEnd = 80843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_TotalCodewords_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int DimensionForVersion
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1413852, RefRangeEnd = 1413854, XrefRangeStart = 1413852, XrefRangeEnd = 1413852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DimensionForVersion_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static Version()
	{
		Il2CppClassPointerStore<Version>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.QrCode.Internal", "Version");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Version>.NativeClassPtr);
		NativeFieldInfoPtr_VERSION_DECODE_INFO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Version>.NativeClassPtr, "VERSION_DECODE_INFO");
		NativeFieldInfoPtr_VERSIONS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Version>.NativeClassPtr, "VERSIONS");
		NativeFieldInfoPtr_versionNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Version>.NativeClassPtr, "versionNumber");
		NativeFieldInfoPtr_alignmentPatternCenters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Version>.NativeClassPtr, "alignmentPatternCenters");
		NativeFieldInfoPtr_ecBlocks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Version>.NativeClassPtr, "ecBlocks");
		NativeFieldInfoPtr_totalCodewords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Version>.NativeClassPtr, "totalCodewords");
		NativeMethodInfoPtr__ctor_Private_Void_Int32_Il2CppStructArray_1_Int32_Il2CppReferenceArray_1_ECBlocks_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100663626);
		NativeMethodInfoPtr_get_VersionNumber_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100663627);
		NativeMethodInfoPtr_get_AlignmentPatternCenters_Public_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100663628);
		NativeMethodInfoPtr_get_TotalCodewords_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100663629);
		NativeMethodInfoPtr_get_DimensionForVersion_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100663630);
		NativeMethodInfoPtr_getECBlocksForLevel_Public_ECBlocks_ErrorCorrectionLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100663631);
		NativeMethodInfoPtr_getProvisionalVersionForDimension_Public_Static_Version_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100663632);
		NativeMethodInfoPtr_getVersionForNumber_Public_Static_Version_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100663633);
		NativeMethodInfoPtr_decodeVersionInformation_Internal_Static_Version_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100663634);
		NativeMethodInfoPtr_buildFunctionPattern_Internal_BitMatrix_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100663635);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100663636);
		NativeMethodInfoPtr_buildVersions_Private_Static_Il2CppReferenceArray_1_Version_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100663637);
	}

	[CallerCount(40)]
	[CachedScanResults(RefRangeStart = 1413812, RefRangeEnd = 1413852, XrefRangeStart = 1413808, XrefRangeEnd = 1413812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Version(int versionNumber, Il2CppStructArray<int> alignmentPatternCenters, [Optional] Il2CppReferenceArray<ECBlocks> ecBlocks)
	{
		if (ecBlocks == null)
		{
			ecBlocks = new Il2CppReferenceArray<ECBlocks>(0L);
		}
		this._002Ector(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Version>.NativeClassPtr));
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&versionNumber);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)alignmentPatternCenters);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ecBlocks);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_Int32_Il2CppStructArray_1_Int32_Il2CppReferenceArray_1_ECBlocks_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1413854, RefRangeEnd = 1413857, XrefRangeStart = 1413854, XrefRangeEnd = 1413854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ECBlocks getECBlocksForLevel(ErrorCorrectionLevel ecLevel)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ecLevel);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getECBlocksForLevel_Public_ECBlocks_ErrorCorrectionLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ECBlocks>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1413862, RefRangeEnd = 1413863, XrefRangeStart = 1413857, XrefRangeEnd = 1413862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Version getProvisionalVersionForDimension(int dimension)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&dimension);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getProvisionalVersionForDimension_Public_Static_Version_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Version>(intPtr2) : null;
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1413867, RefRangeEnd = 1413873, XrefRangeStart = 1413863, XrefRangeEnd = 1413867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Version getVersionForNumber(int versionNumber)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&versionNumber);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getVersionForNumber_Public_Static_Version_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Version>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1413886, RefRangeEnd = 1413888, XrefRangeStart = 1413873, XrefRangeEnd = 1413886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Version decodeVersionInformation(int versionBits)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&versionBits);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decodeVersionInformation_Internal_Static_Version_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Version>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1413900, RefRangeEnd = 1413901, XrefRangeStart = 1413888, XrefRangeEnd = 1413900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BitMatrix buildFunctionPattern()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_buildFunctionPattern_Internal_BitMatrix_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BitMatrix>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1413901, XrefRangeEnd = 1413919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1416462, RefRangeEnd = 1416463, XrefRangeStart = 1413919, XrefRangeEnd = 1416462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<Version> buildVersions()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_buildVersions_Private_Static_Il2CppReferenceArray_1_Version_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Version>>(intPtr2) : null;
	}

	public Version(int versionNumber, Il2CppStructArray<int> alignmentPatternCenters, params ECBlocks[] ecBlocks)
		: this(versionNumber, alignmentPatternCenters, new Il2CppReferenceArray<ECBlocks>(ecBlocks))
	{
	}

	public Version(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
