using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Unity.Collections;
using Unity.Mathematics;

namespace UnityEngine.Rendering.Universal;

public sealed class TileRangeExpansionJob : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_tileRanges;

	private static readonly System.IntPtr NativeFieldInfoPtr_tileMasks;

	private static readonly System.IntPtr NativeFieldInfoPtr_rangesPerItem;

	private static readonly System.IntPtr NativeFieldInfoPtr_itemsPerTile;

	private static readonly System.IntPtr NativeFieldInfoPtr_wordsPerTile;

	private static readonly System.IntPtr NativeFieldInfoPtr_tileResolution;

	private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0;

	public unsafe NativeArray<InclusiveRange> tileRanges
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tileRanges);
			return new NativeArray<InclusiveRange>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<InclusiveRange>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tileRanges), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<InclusiveRange>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<uint> tileMasks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tileMasks);
			return new NativeArray<uint>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<uint>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tileMasks), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<uint>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe int rangesPerItem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rangesPerItem);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rangesPerItem)) = value;
		}
	}

	public unsafe int itemsPerTile
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemsPerTile);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemsPerTile)) = value;
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

	public unsafe int2 tileResolution
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tileResolution);
			return *(int2*)num;
		}
		set
		{
			*(int2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tileResolution)) = value;
		}
	}

	static TileRangeExpansionJob()
	{
		Il2CppClassPointerStore<TileRangeExpansionJob>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "TileRangeExpansionJob");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileRangeExpansionJob>.NativeClassPtr);
		NativeFieldInfoPtr_tileRanges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileRangeExpansionJob>.NativeClassPtr, "tileRanges");
		NativeFieldInfoPtr_tileMasks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileRangeExpansionJob>.NativeClassPtr, "tileMasks");
		NativeFieldInfoPtr_rangesPerItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileRangeExpansionJob>.NativeClassPtr, "rangesPerItem");
		NativeFieldInfoPtr_itemsPerTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileRangeExpansionJob>.NativeClassPtr, "itemsPerTile");
		NativeFieldInfoPtr_wordsPerTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileRangeExpansionJob>.NativeClassPtr, "wordsPerTile");
		NativeFieldInfoPtr_tileResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileRangeExpansionJob>.NativeClassPtr, "tileResolution");
		NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileRangeExpansionJob>.NativeClassPtr, 100665616);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1100666, XrefRangeEnd = 1100678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Execute(int jobIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&jobIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public TileRangeExpansionJob(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public TileRangeExpansionJob()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TileRangeExpansionJob>.NativeClassPtr))
	{
	}
}
