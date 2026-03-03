using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Unity.Collections;
using Unity.Mathematics;

namespace UnityEngine.Rendering.Universal;

public sealed class ZBinningJob : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_batchSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_headerLength;

	private static readonly System.IntPtr NativeFieldInfoPtr_bins;

	private static readonly System.IntPtr NativeFieldInfoPtr_minMaxZs;

	private static readonly System.IntPtr NativeFieldInfoPtr_zBinScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_zBinOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_binCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_wordsPerTile;

	private static readonly System.IntPtr NativeFieldInfoPtr_lightCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_reflectionProbeCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_batchCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_viewCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_isOrthographic;

	private static readonly System.IntPtr NativeMethodInfoPtr_EncodeHeader_Private_Static_UInt32_UInt32_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DecodeHeader_Private_Static_ValueTuple_2_UInt32_UInt32_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FillZBins_Private_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0;

	public unsafe static int batchSize
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_batchSize, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_batchSize, (void*)(&value));
		}
	}

	public unsafe static int headerLength
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_headerLength, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_headerLength, (void*)(&value));
		}
	}

	public unsafe NativeArray<uint> bins
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bins);
			return new NativeArray<uint>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<uint>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bins), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<uint>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<float2> minMaxZs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minMaxZs);
			return new NativeArray<float2>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float2>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minMaxZs), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float2>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe float zBinScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_zBinScale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_zBinScale)) = value;
		}
	}

	public unsafe float zBinOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_zBinOffset);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_zBinOffset)) = value;
		}
	}

	public unsafe int binCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_binCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_binCount)) = value;
		}
	}

	public unsafe int wordsPerTile
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wordsPerTile);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wordsPerTile)) = value;
		}
	}

	public unsafe int lightCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightCount)) = value;
		}
	}

	public unsafe int reflectionProbeCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reflectionProbeCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reflectionProbeCount)) = value;
		}
	}

	public unsafe int batchCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_batchCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_batchCount)) = value;
		}
	}

	public unsafe int viewCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_viewCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_viewCount)) = value;
		}
	}

	public unsafe bool isOrthographic
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isOrthographic);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isOrthographic)) = value;
		}
	}

	static ZBinningJob()
	{
		Il2CppClassPointerStore<ZBinningJob>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "ZBinningJob");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ZBinningJob>.NativeClassPtr);
		NativeFieldInfoPtr_batchSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZBinningJob>.NativeClassPtr, "batchSize");
		NativeFieldInfoPtr_headerLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZBinningJob>.NativeClassPtr, "headerLength");
		NativeFieldInfoPtr_bins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZBinningJob>.NativeClassPtr, "bins");
		NativeFieldInfoPtr_minMaxZs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZBinningJob>.NativeClassPtr, "minMaxZs");
		NativeFieldInfoPtr_zBinScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZBinningJob>.NativeClassPtr, "zBinScale");
		NativeFieldInfoPtr_zBinOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZBinningJob>.NativeClassPtr, "zBinOffset");
		NativeFieldInfoPtr_binCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZBinningJob>.NativeClassPtr, "binCount");
		NativeFieldInfoPtr_wordsPerTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZBinningJob>.NativeClassPtr, "wordsPerTile");
		NativeFieldInfoPtr_lightCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZBinningJob>.NativeClassPtr, "lightCount");
		NativeFieldInfoPtr_reflectionProbeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZBinningJob>.NativeClassPtr, "reflectionProbeCount");
		NativeFieldInfoPtr_batchCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZBinningJob>.NativeClassPtr, "batchCount");
		NativeFieldInfoPtr_viewCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZBinningJob>.NativeClassPtr, "viewCount");
		NativeFieldInfoPtr_isOrthographic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZBinningJob>.NativeClassPtr, "isOrthographic");
		NativeMethodInfoPtr_EncodeHeader_Private_Static_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZBinningJob>.NativeClassPtr, 100665642);
		NativeMethodInfoPtr_DecodeHeader_Private_Static_ValueTuple_2_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZBinningJob>.NativeClassPtr, 100665643);
		NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZBinningJob>.NativeClassPtr, 100665644);
		NativeMethodInfoPtr_FillZBins_Private_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZBinningJob>.NativeClassPtr, 100665645);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1101365, RefRangeEnd = 1101367, XrefRangeStart = 1101365, XrefRangeEnd = 1101365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint EncodeHeader(uint min, uint max)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&min);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &max;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EncodeHeader_Private_Static_UInt32_UInt32_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1101370, RefRangeEnd = 1101371, XrefRangeStart = 1101367, XrefRangeEnd = 1101370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.ValueTuple<uint, uint> DecodeHeader(uint zBin)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&zBin);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DecodeHeader_Private_Static_ValueTuple_2_UInt32_UInt32_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new Il2CppSystem.ValueTuple<uint, uint>(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1101374, RefRangeEnd = 1101375, XrefRangeStart = 1101371, XrefRangeEnd = 1101374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Execute(int jobIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&jobIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1101379, RefRangeEnd = 1101381, XrefRangeStart = 1101375, XrefRangeEnd = 1101379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FillZBins(int binStart, int binEnd, int itemStart, int itemEnd, int headerIndex, int itemOffset, int binOffset)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = (nint)(&binStart);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &binEnd;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &itemStart;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &itemEnd;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &headerIndex;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &itemOffset;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &binOffset;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FillZBins_Private_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ZBinningJob(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public ZBinningJob()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ZBinningJob>.NativeClassPtr))
	{
	}
}
