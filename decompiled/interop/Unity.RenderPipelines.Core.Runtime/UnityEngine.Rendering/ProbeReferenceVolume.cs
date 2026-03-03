using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Unity.Collections;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine.Events;
using UnityEngine.Rendering.RenderGraphModule;
using UnityEngine.SceneManagement;

namespace UnityEngine.Rendering;

public class ProbeReferenceVolume : Il2CppSystem.Object
{
	public static class ShaderIDs : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__APVResIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr__APVResCellIndices;

		private static readonly System.IntPtr NativeFieldInfoPtr__APVResL0_L1Rx;

		private static readonly System.IntPtr NativeFieldInfoPtr__APVResL1G_L1Ry;

		private static readonly System.IntPtr NativeFieldInfoPtr__APVResL1B_L1Rz;

		private static readonly System.IntPtr NativeFieldInfoPtr__APVResL2_0;

		private static readonly System.IntPtr NativeFieldInfoPtr__APVResL2_1;

		private static readonly System.IntPtr NativeFieldInfoPtr__APVResL2_2;

		private static readonly System.IntPtr NativeFieldInfoPtr__APVResL2_3;

		private static readonly System.IntPtr NativeFieldInfoPtr__APVProbeOcclusion;

		private static readonly System.IntPtr NativeFieldInfoPtr__APVResValidity;

		private static readonly System.IntPtr NativeFieldInfoPtr__SkyOcclusionTexL0L1;

		private static readonly System.IntPtr NativeFieldInfoPtr__SkyShadingDirectionIndicesTex;

		private static readonly System.IntPtr NativeFieldInfoPtr__SkyPrecomputedDirections;

		private static readonly System.IntPtr NativeFieldInfoPtr__AntiLeakData;

		public unsafe static int _APVResIndex
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__APVResIndex, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__APVResIndex, (void*)(&value));
			}
		}

		public unsafe static int _APVResCellIndices
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__APVResCellIndices, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__APVResCellIndices, (void*)(&value));
			}
		}

		public unsafe static int _APVResL0_L1Rx
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__APVResL0_L1Rx, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__APVResL0_L1Rx, (void*)(&value));
			}
		}

		public unsafe static int _APVResL1G_L1Ry
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__APVResL1G_L1Ry, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__APVResL1G_L1Ry, (void*)(&value));
			}
		}

		public unsafe static int _APVResL1B_L1Rz
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__APVResL1B_L1Rz, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__APVResL1B_L1Rz, (void*)(&value));
			}
		}

		public unsafe static int _APVResL2_0
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__APVResL2_0, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__APVResL2_0, (void*)(&value));
			}
		}

		public unsafe static int _APVResL2_1
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__APVResL2_1, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__APVResL2_1, (void*)(&value));
			}
		}

		public unsafe static int _APVResL2_2
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__APVResL2_2, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__APVResL2_2, (void*)(&value));
			}
		}

		public unsafe static int _APVResL2_3
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__APVResL2_3, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__APVResL2_3, (void*)(&value));
			}
		}

		public unsafe static int _APVProbeOcclusion
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__APVProbeOcclusion, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__APVProbeOcclusion, (void*)(&value));
			}
		}

		public unsafe static int _APVResValidity
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__APVResValidity, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__APVResValidity, (void*)(&value));
			}
		}

		public unsafe static int _SkyOcclusionTexL0L1
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__SkyOcclusionTexL0L1, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__SkyOcclusionTexL0L1, (void*)(&value));
			}
		}

		public unsafe static int _SkyShadingDirectionIndicesTex
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__SkyShadingDirectionIndicesTex, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__SkyShadingDirectionIndicesTex, (void*)(&value));
			}
		}

		public unsafe static int _SkyPrecomputedDirections
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__SkyPrecomputedDirections, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__SkyPrecomputedDirections, (void*)(&value));
			}
		}

		public unsafe static int _AntiLeakData
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__AntiLeakData, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__AntiLeakData, (void*)(&value));
			}
		}

		static ShaderIDs()
		{
			Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "ShaderIDs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr);
			NativeFieldInfoPtr__APVResIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "_APVResIndex");
			NativeFieldInfoPtr__APVResCellIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "_APVResCellIndices");
			NativeFieldInfoPtr__APVResL0_L1Rx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "_APVResL0_L1Rx");
			NativeFieldInfoPtr__APVResL1G_L1Ry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "_APVResL1G_L1Ry");
			NativeFieldInfoPtr__APVResL1B_L1Rz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "_APVResL1B_L1Rz");
			NativeFieldInfoPtr__APVResL2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "_APVResL2_0");
			NativeFieldInfoPtr__APVResL2_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "_APVResL2_1");
			NativeFieldInfoPtr__APVResL2_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "_APVResL2_2");
			NativeFieldInfoPtr__APVResL2_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "_APVResL2_3");
			NativeFieldInfoPtr__APVProbeOcclusion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "_APVProbeOcclusion");
			NativeFieldInfoPtr__APVResValidity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "_APVResValidity");
			NativeFieldInfoPtr__SkyOcclusionTexL0L1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "_SkyOcclusionTexL0L1");
			NativeFieldInfoPtr__SkyShadingDirectionIndicesTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "_SkyShadingDirectionIndicesTex");
			NativeFieldInfoPtr__SkyPrecomputedDirections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "_SkyPrecomputedDirections");
			NativeFieldInfoPtr__AntiLeakData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "_AntiLeakData");
		}

		public ShaderIDs(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	[StructLayout(LayoutKind.Explicit)]
	public struct IndirectionEntryInfo
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_positionInBricks;

		private static readonly System.IntPtr NativeFieldInfoPtr_minSubdiv;

		private static readonly System.IntPtr NativeFieldInfoPtr_minBrickPos;

		private static readonly System.IntPtr NativeFieldInfoPtr_maxBrickPosPlusOne;

		private static readonly System.IntPtr NativeFieldInfoPtr_hasMinMax;

		private static readonly System.IntPtr NativeFieldInfoPtr_hasOnlyBiggerBricks;

		[FieldOffset(0)]
		public Vector3Int positionInBricks;

		[FieldOffset(12)]
		public int minSubdiv;

		[FieldOffset(16)]
		public Vector3Int minBrickPos;

		[FieldOffset(28)]
		public Vector3Int maxBrickPosPlusOne;

		[FieldOffset(40)]
		[MarshalAs(UnmanagedType.U1)]
		public bool hasMinMax;

		[FieldOffset(41)]
		[MarshalAs(UnmanagedType.U1)]
		public bool hasOnlyBiggerBricks;

		static IndirectionEntryInfo()
		{
			Il2CppClassPointerStore<IndirectionEntryInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "IndirectionEntryInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IndirectionEntryInfo>.NativeClassPtr);
			NativeFieldInfoPtr_positionInBricks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndirectionEntryInfo>.NativeClassPtr, "positionInBricks");
			NativeFieldInfoPtr_minSubdiv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndirectionEntryInfo>.NativeClassPtr, "minSubdiv");
			NativeFieldInfoPtr_minBrickPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndirectionEntryInfo>.NativeClassPtr, "minBrickPos");
			NativeFieldInfoPtr_maxBrickPosPlusOne = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndirectionEntryInfo>.NativeClassPtr, "maxBrickPosPlusOne");
			NativeFieldInfoPtr_hasMinMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndirectionEntryInfo>.NativeClassPtr, "hasMinMax");
			NativeFieldInfoPtr_hasOnlyBiggerBricks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndirectionEntryInfo>.NativeClassPtr, "hasOnlyBiggerBricks");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IndirectionEntryInfo>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[System.Serializable]
	public class CellDesc : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_position;

		private static readonly System.IntPtr NativeFieldInfoPtr_index;

		private static readonly System.IntPtr NativeFieldInfoPtr_probeCount;

		private static readonly System.IntPtr NativeFieldInfoPtr_minSubdiv;

		private static readonly System.IntPtr NativeFieldInfoPtr_indexChunkCount;

		private static readonly System.IntPtr NativeFieldInfoPtr_shChunkCount;

		private static readonly System.IntPtr NativeFieldInfoPtr_bricksCount;

		private static readonly System.IntPtr NativeFieldInfoPtr_indirectionEntryInfo;

		private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Vector3Int position
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_position);
				return *(Vector3Int*)num;
			}
			set
			{
				*(Vector3Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_position)) = value;
			}
		}

		public unsafe int index
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_index);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_index)) = value;
			}
		}

		public unsafe int probeCount
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_probeCount);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_probeCount)) = value;
			}
		}

		public unsafe int minSubdiv
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minSubdiv);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minSubdiv)) = value;
			}
		}

		public unsafe int indexChunkCount
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_indexChunkCount);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_indexChunkCount)) = value;
			}
		}

		public unsafe int shChunkCount
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shChunkCount);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shChunkCount)) = value;
			}
		}

		public unsafe int bricksCount
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bricksCount);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bricksCount)) = value;
			}
		}

		public unsafe Il2CppStructArray<IndirectionEntryInfo> indirectionEntryInfo
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_indirectionEntryInfo);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<IndirectionEntryInfo>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_indirectionEntryInfo)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static CellDesc()
		{
			Il2CppClassPointerStore<CellDesc>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "CellDesc");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CellDesc>.NativeClassPtr);
			NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellDesc>.NativeClassPtr, "position");
			NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellDesc>.NativeClassPtr, "index");
			NativeFieldInfoPtr_probeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellDesc>.NativeClassPtr, "probeCount");
			NativeFieldInfoPtr_minSubdiv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellDesc>.NativeClassPtr, "minSubdiv");
			NativeFieldInfoPtr_indexChunkCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellDesc>.NativeClassPtr, "indexChunkCount");
			NativeFieldInfoPtr_shChunkCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellDesc>.NativeClassPtr, "shChunkCount");
			NativeFieldInfoPtr_bricksCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellDesc>.NativeClassPtr, "bricksCount");
			NativeFieldInfoPtr_indirectionEntryInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellDesc>.NativeClassPtr, "indirectionEntryInfo");
			NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellDesc>.NativeClassPtr, 100665606);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellDesc>.NativeClassPtr, 100665607);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1038682, XrefRangeEnd = 1038690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CellDesc()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CellDesc>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public CellDesc(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class CellData : Il2CppSystem.Object
	{
		public sealed class PerScenarioData : Il2CppSystem.ValueType
		{
			private static readonly System.IntPtr NativeFieldInfoPtr_shL0L1RxData;

			private static readonly System.IntPtr NativeFieldInfoPtr_shL1GL1RyData;

			private static readonly System.IntPtr NativeFieldInfoPtr_shL1BL1RzData;

			private static readonly System.IntPtr NativeFieldInfoPtr_shL2Data_0;

			private static readonly System.IntPtr NativeFieldInfoPtr_shL2Data_1;

			private static readonly System.IntPtr NativeFieldInfoPtr_shL2Data_2;

			private static readonly System.IntPtr NativeFieldInfoPtr_shL2Data_3;

			private static readonly System.IntPtr NativeFieldInfoPtr_probeOcclusion;

			public unsafe NativeArray<ushort> shL0L1RxData
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shL0L1RxData);
					return new NativeArray<ushort>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<ushort>>.NativeClassPtr, (System.IntPtr)num));
				}
				set
				{
					// IL cpblk instruction
					Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shL0L1RxData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<ushort>>.NativeClassPtr, ref *(uint*)null));
				}
			}

			public unsafe NativeArray<byte> shL1GL1RyData
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shL1GL1RyData);
					return new NativeArray<byte>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<byte>>.NativeClassPtr, (System.IntPtr)num));
				}
				set
				{
					// IL cpblk instruction
					Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shL1GL1RyData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<byte>>.NativeClassPtr, ref *(uint*)null));
				}
			}

			public unsafe NativeArray<byte> shL1BL1RzData
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shL1BL1RzData);
					return new NativeArray<byte>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<byte>>.NativeClassPtr, (System.IntPtr)num));
				}
				set
				{
					// IL cpblk instruction
					Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shL1BL1RzData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<byte>>.NativeClassPtr, ref *(uint*)null));
				}
			}

			public unsafe NativeArray<byte> shL2Data_0
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shL2Data_0);
					return new NativeArray<byte>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<byte>>.NativeClassPtr, (System.IntPtr)num));
				}
				set
				{
					// IL cpblk instruction
					Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shL2Data_0), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<byte>>.NativeClassPtr, ref *(uint*)null));
				}
			}

			public unsafe NativeArray<byte> shL2Data_1
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shL2Data_1);
					return new NativeArray<byte>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<byte>>.NativeClassPtr, (System.IntPtr)num));
				}
				set
				{
					// IL cpblk instruction
					Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shL2Data_1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<byte>>.NativeClassPtr, ref *(uint*)null));
				}
			}

			public unsafe NativeArray<byte> shL2Data_2
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shL2Data_2);
					return new NativeArray<byte>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<byte>>.NativeClassPtr, (System.IntPtr)num));
				}
				set
				{
					// IL cpblk instruction
					Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shL2Data_2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<byte>>.NativeClassPtr, ref *(uint*)null));
				}
			}

			public unsafe NativeArray<byte> shL2Data_3
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shL2Data_3);
					return new NativeArray<byte>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<byte>>.NativeClassPtr, (System.IntPtr)num));
				}
				set
				{
					// IL cpblk instruction
					Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shL2Data_3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<byte>>.NativeClassPtr, ref *(uint*)null));
				}
			}

			public unsafe NativeArray<byte> probeOcclusion
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_probeOcclusion);
					return new NativeArray<byte>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<byte>>.NativeClassPtr, (System.IntPtr)num));
				}
				set
				{
					// IL cpblk instruction
					Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_probeOcclusion), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<byte>>.NativeClassPtr, ref *(uint*)null));
				}
			}

			static PerScenarioData()
			{
				Il2CppClassPointerStore<PerScenarioData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CellData>.NativeClassPtr, "PerScenarioData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PerScenarioData>.NativeClassPtr);
				NativeFieldInfoPtr_shL0L1RxData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerScenarioData>.NativeClassPtr, "shL0L1RxData");
				NativeFieldInfoPtr_shL1GL1RyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerScenarioData>.NativeClassPtr, "shL1GL1RyData");
				NativeFieldInfoPtr_shL1BL1RzData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerScenarioData>.NativeClassPtr, "shL1BL1RzData");
				NativeFieldInfoPtr_shL2Data_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerScenarioData>.NativeClassPtr, "shL2Data_0");
				NativeFieldInfoPtr_shL2Data_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerScenarioData>.NativeClassPtr, "shL2Data_1");
				NativeFieldInfoPtr_shL2Data_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerScenarioData>.NativeClassPtr, "shL2Data_2");
				NativeFieldInfoPtr_shL2Data_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerScenarioData>.NativeClassPtr, "shL2Data_3");
				NativeFieldInfoPtr_probeOcclusion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerScenarioData>.NativeClassPtr, "probeOcclusion");
			}

			public PerScenarioData(System.IntPtr pointer)
				: base(pointer)
			{
			}

			public PerScenarioData()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PerScenarioData>.NativeClassPtr))
			{
			}
		}

		private static readonly System.IntPtr NativeFieldInfoPtr_validityNeighMaskData;

		private static readonly System.IntPtr NativeFieldInfoPtr__skyOcclusionDataL0L1_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__skyShadingDirectionIndices_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr_scenarios;

		private static readonly System.IntPtr NativeFieldInfoPtr__bricks_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__probePositions_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__touchupVolumeInteraction_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__offsetVectors_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__validity_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__layer_k__BackingField;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_skyOcclusionDataL0L1_Public_get_NativeArray_1_UInt16_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_skyOcclusionDataL0L1_Internal_set_Void_NativeArray_1_UInt16_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_skyShadingDirectionIndices_Public_get_NativeArray_1_Byte_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_skyShadingDirectionIndices_Internal_set_Void_NativeArray_1_Byte_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_bricks_Public_get_NativeArray_1_Brick_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_bricks_Internal_set_Void_NativeArray_1_Brick_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_probePositions_Public_get_NativeArray_1_Vector3_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_probePositions_Internal_set_Void_NativeArray_1_Vector3_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_touchupVolumeInteraction_Public_get_NativeArray_1_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_touchupVolumeInteraction_Internal_set_Void_NativeArray_1_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_offsetVectors_Public_get_NativeArray_1_Vector3_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_offsetVectors_Internal_set_Void_NativeArray_1_Vector3_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_validity_Public_get_NativeArray_1_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_validity_Internal_set_Void_NativeArray_1_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_layer_Public_get_NativeArray_1_Byte_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_layer_Internal_set_Void_NativeArray_1_Byte_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CleanupPerScenarioData_Public_Void_byref_PerScenarioData_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Cleanup_Public_Void_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe NativeArray<byte> validityNeighMaskData
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_validityNeighMaskData);
				return new NativeArray<byte>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<byte>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_validityNeighMaskData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<byte>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<ushort> _skyOcclusionDataL0L1_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__skyOcclusionDataL0L1_k__BackingField);
				return new NativeArray<ushort>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<ushort>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__skyOcclusionDataL0L1_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<ushort>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<byte> _skyShadingDirectionIndices_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__skyShadingDirectionIndices_k__BackingField);
				return new NativeArray<byte>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<byte>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__skyShadingDirectionIndices_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<byte>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe Dictionary<string, PerScenarioData> scenarios
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scenarios);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, PerScenarioData>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scenarios)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe NativeArray<ProbeBrickIndex.Brick> _bricks_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__bricks_k__BackingField);
				return new NativeArray<ProbeBrickIndex.Brick>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<ProbeBrickIndex.Brick>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__bricks_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<ProbeBrickIndex.Brick>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<Vector3> _probePositions_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__probePositions_k__BackingField);
				return new NativeArray<Vector3>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<Vector3>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__probePositions_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Vector3>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<float> _touchupVolumeInteraction_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__touchupVolumeInteraction_k__BackingField);
				return new NativeArray<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__touchupVolumeInteraction_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<Vector3> _offsetVectors_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__offsetVectors_k__BackingField);
				return new NativeArray<Vector3>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<Vector3>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__offsetVectors_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Vector3>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<float> _validity_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__validity_k__BackingField);
				return new NativeArray<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__validity_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<byte> _layer_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__layer_k__BackingField);
				return new NativeArray<byte>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<byte>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__layer_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<byte>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<ushort> skyOcclusionDataL0L1
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_skyOcclusionDataL0L1_Public_get_NativeArray_1_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new NativeArray<ushort>(pointer);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_skyOcclusionDataL0L1_Internal_set_Void_NativeArray_1_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe NativeArray<byte> skyShadingDirectionIndices
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_skyShadingDirectionIndices_Public_get_NativeArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new NativeArray<byte>(pointer);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_skyShadingDirectionIndices_Internal_set_Void_NativeArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe NativeArray<ProbeBrickIndex.Brick> bricks
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_bricks_Public_get_NativeArray_1_Brick_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new NativeArray<ProbeBrickIndex.Brick>(pointer);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_bricks_Internal_set_Void_NativeArray_1_Brick_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe NativeArray<Vector3> probePositions
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_probePositions_Public_get_NativeArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new NativeArray<Vector3>(pointer);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_probePositions_Internal_set_Void_NativeArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe NativeArray<float> touchupVolumeInteraction
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_touchupVolumeInteraction_Public_get_NativeArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new NativeArray<float>(pointer);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_touchupVolumeInteraction_Internal_set_Void_NativeArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe NativeArray<Vector3> offsetVectors
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_offsetVectors_Public_get_NativeArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new NativeArray<Vector3>(pointer);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_offsetVectors_Internal_set_Void_NativeArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe NativeArray<float> validity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_validity_Public_get_NativeArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new NativeArray<float>(pointer);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_validity_Internal_set_Void_NativeArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe NativeArray<byte> layer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_layer_Public_get_NativeArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new NativeArray<byte>(pointer);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_layer_Internal_set_Void_NativeArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		static CellData()
		{
			Il2CppClassPointerStore<CellData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "CellData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CellData>.NativeClassPtr);
			NativeFieldInfoPtr_validityNeighMaskData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellData>.NativeClassPtr, "validityNeighMaskData");
			NativeFieldInfoPtr__skyOcclusionDataL0L1_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellData>.NativeClassPtr, "<skyOcclusionDataL0L1>k__BackingField");
			NativeFieldInfoPtr__skyShadingDirectionIndices_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellData>.NativeClassPtr, "<skyShadingDirectionIndices>k__BackingField");
			NativeFieldInfoPtr_scenarios = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellData>.NativeClassPtr, "scenarios");
			NativeFieldInfoPtr__bricks_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellData>.NativeClassPtr, "<bricks>k__BackingField");
			NativeFieldInfoPtr__probePositions_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellData>.NativeClassPtr, "<probePositions>k__BackingField");
			NativeFieldInfoPtr__touchupVolumeInteraction_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellData>.NativeClassPtr, "<touchupVolumeInteraction>k__BackingField");
			NativeFieldInfoPtr__offsetVectors_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellData>.NativeClassPtr, "<offsetVectors>k__BackingField");
			NativeFieldInfoPtr__validity_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellData>.NativeClassPtr, "<validity>k__BackingField");
			NativeFieldInfoPtr__layer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellData>.NativeClassPtr, "<layer>k__BackingField");
			NativeMethodInfoPtr_get_skyOcclusionDataL0L1_Public_get_NativeArray_1_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellData>.NativeClassPtr, 100665608);
			NativeMethodInfoPtr_set_skyOcclusionDataL0L1_Internal_set_Void_NativeArray_1_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellData>.NativeClassPtr, 100665609);
			NativeMethodInfoPtr_get_skyShadingDirectionIndices_Public_get_NativeArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellData>.NativeClassPtr, 100665610);
			NativeMethodInfoPtr_set_skyShadingDirectionIndices_Internal_set_Void_NativeArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellData>.NativeClassPtr, 100665611);
			NativeMethodInfoPtr_get_bricks_Public_get_NativeArray_1_Brick_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellData>.NativeClassPtr, 100665612);
			NativeMethodInfoPtr_set_bricks_Internal_set_Void_NativeArray_1_Brick_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellData>.NativeClassPtr, 100665613);
			NativeMethodInfoPtr_get_probePositions_Public_get_NativeArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellData>.NativeClassPtr, 100665614);
			NativeMethodInfoPtr_set_probePositions_Internal_set_Void_NativeArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellData>.NativeClassPtr, 100665615);
			NativeMethodInfoPtr_get_touchupVolumeInteraction_Public_get_NativeArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellData>.NativeClassPtr, 100665616);
			NativeMethodInfoPtr_set_touchupVolumeInteraction_Internal_set_Void_NativeArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellData>.NativeClassPtr, 100665617);
			NativeMethodInfoPtr_get_offsetVectors_Public_get_NativeArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellData>.NativeClassPtr, 100665618);
			NativeMethodInfoPtr_set_offsetVectors_Internal_set_Void_NativeArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellData>.NativeClassPtr, 100665619);
			NativeMethodInfoPtr_get_validity_Public_get_NativeArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellData>.NativeClassPtr, 100665620);
			NativeMethodInfoPtr_set_validity_Internal_set_Void_NativeArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellData>.NativeClassPtr, 100665621);
			NativeMethodInfoPtr_get_layer_Public_get_NativeArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellData>.NativeClassPtr, 100665622);
			NativeMethodInfoPtr_set_layer_Internal_set_Void_NativeArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellData>.NativeClassPtr, 100665623);
			NativeMethodInfoPtr_CleanupPerScenarioData_Public_Void_byref_PerScenarioData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellData>.NativeClassPtr, 100665624);
			NativeMethodInfoPtr_Cleanup_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellData>.NativeClassPtr, 100665625);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellData>.NativeClassPtr, 100665626);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1038690, XrefRangeEnd = 1038710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CleanupPerScenarioData([In] ref PerScenarioData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)data);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CleanupPerScenarioData_Public_Void_byref_PerScenarioData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1038778, RefRangeEnd = 1038781, XrefRangeStart = 1038710, XrefRangeEnd = 1038778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cleanup(bool cleanScenarioList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&cleanScenarioList);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Cleanup_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1038789, RefRangeEnd = 1038790, XrefRangeStart = 1038781, XrefRangeEnd = 1038789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CellData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CellData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public CellData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class CellPoolInfo : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_chunkList;

		private static readonly System.IntPtr NativeFieldInfoPtr_shChunkCount;

		private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe List<ProbeBrickPool.BrickChunkAlloc> chunkList
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chunkList);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ProbeBrickPool.BrickChunkAlloc>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chunkList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe int shChunkCount
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shChunkCount);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shChunkCount)) = value;
			}
		}

		static CellPoolInfo()
		{
			Il2CppClassPointerStore<CellPoolInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "CellPoolInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CellPoolInfo>.NativeClassPtr);
			NativeFieldInfoPtr_chunkList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellPoolInfo>.NativeClassPtr, "chunkList");
			NativeFieldInfoPtr_shChunkCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellPoolInfo>.NativeClassPtr, "shChunkCount");
			NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellPoolInfo>.NativeClassPtr, 100665627);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellPoolInfo>.NativeClassPtr, 100665628);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1038790, XrefRangeEnd = 1038791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1038791, XrefRangeEnd = 1038799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CellPoolInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CellPoolInfo>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public CellPoolInfo(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class CellIndexInfo : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_flatIndicesInGlobalIndirection;

		private static readonly System.IntPtr NativeFieldInfoPtr_updateInfo;

		private static readonly System.IntPtr NativeFieldInfoPtr_indexUpdated;

		private static readonly System.IntPtr NativeFieldInfoPtr_indirectionEntryInfo;

		private static readonly System.IntPtr NativeFieldInfoPtr_indexChunkCount;

		private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Il2CppStructArray<int> flatIndicesInGlobalIndirection
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flatIndicesInGlobalIndirection);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flatIndicesInGlobalIndirection)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe ProbeBrickIndex.CellIndexUpdateInfo updateInfo
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_updateInfo);
				return new ProbeBrickIndex.CellIndexUpdateInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProbeBrickIndex.CellIndexUpdateInfo>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_updateInfo), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ProbeBrickIndex.CellIndexUpdateInfo>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe bool indexUpdated
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_indexUpdated);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_indexUpdated)) = value;
			}
		}

		public unsafe Il2CppStructArray<IndirectionEntryInfo> indirectionEntryInfo
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_indirectionEntryInfo);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<IndirectionEntryInfo>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_indirectionEntryInfo)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe int indexChunkCount
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_indexChunkCount);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_indexChunkCount)) = value;
			}
		}

		static CellIndexInfo()
		{
			Il2CppClassPointerStore<CellIndexInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "CellIndexInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CellIndexInfo>.NativeClassPtr);
			NativeFieldInfoPtr_flatIndicesInGlobalIndirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellIndexInfo>.NativeClassPtr, "flatIndicesInGlobalIndirection");
			NativeFieldInfoPtr_updateInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellIndexInfo>.NativeClassPtr, "updateInfo");
			NativeFieldInfoPtr_indexUpdated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellIndexInfo>.NativeClassPtr, "indexUpdated");
			NativeFieldInfoPtr_indirectionEntryInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellIndexInfo>.NativeClassPtr, "indirectionEntryInfo");
			NativeFieldInfoPtr_indexChunkCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellIndexInfo>.NativeClassPtr, "indexChunkCount");
			NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellIndexInfo>.NativeClassPtr, 100665629);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellIndexInfo>.NativeClassPtr, 100665630);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1038799, XrefRangeEnd = 1038801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CellIndexInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CellIndexInfo>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public CellIndexInfo(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class CellBlendingInfo : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_chunkList;

		private static readonly System.IntPtr NativeFieldInfoPtr_blendingScore;

		private static readonly System.IntPtr NativeFieldInfoPtr_blendingFactor;

		private static readonly System.IntPtr NativeFieldInfoPtr_blending;

		private static readonly System.IntPtr NativeMethodInfoPtr_MarkUpToDate_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_IsUpToDate_Public_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ForceReupload_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ShouldReupload_Public_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Prioritize_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ShouldPrioritize_Public_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe List<ProbeBrickPool.BrickChunkAlloc> chunkList
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chunkList);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ProbeBrickPool.BrickChunkAlloc>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chunkList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe float blendingScore
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blendingScore);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blendingScore)) = value;
			}
		}

		public unsafe float blendingFactor
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blendingFactor);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blendingFactor)) = value;
			}
		}

		public unsafe bool blending
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blending);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blending)) = value;
			}
		}

		static CellBlendingInfo()
		{
			Il2CppClassPointerStore<CellBlendingInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "CellBlendingInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CellBlendingInfo>.NativeClassPtr);
			NativeFieldInfoPtr_chunkList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellBlendingInfo>.NativeClassPtr, "chunkList");
			NativeFieldInfoPtr_blendingScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellBlendingInfo>.NativeClassPtr, "blendingScore");
			NativeFieldInfoPtr_blendingFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellBlendingInfo>.NativeClassPtr, "blendingFactor");
			NativeFieldInfoPtr_blending = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellBlendingInfo>.NativeClassPtr, "blending");
			NativeMethodInfoPtr_MarkUpToDate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellBlendingInfo>.NativeClassPtr, 100665631);
			NativeMethodInfoPtr_IsUpToDate_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellBlendingInfo>.NativeClassPtr, 100665632);
			NativeMethodInfoPtr_ForceReupload_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellBlendingInfo>.NativeClassPtr, 100665633);
			NativeMethodInfoPtr_ShouldReupload_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellBlendingInfo>.NativeClassPtr, 100665634);
			NativeMethodInfoPtr_Prioritize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellBlendingInfo>.NativeClassPtr, 100665635);
			NativeMethodInfoPtr_ShouldPrioritize_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellBlendingInfo>.NativeClassPtr, 100665636);
			NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellBlendingInfo>.NativeClassPtr, 100665637);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellBlendingInfo>.NativeClassPtr, 100665638);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1038801, RefRangeEnd = 1038804, XrefRangeStart = 1038801, XrefRangeEnd = 1038801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MarkUpToDate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MarkUpToDate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1038804, RefRangeEnd = 1038806, XrefRangeStart = 1038804, XrefRangeEnd = 1038804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsUpToDate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsUpToDate_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1038806, RefRangeEnd = 1038807, XrefRangeStart = 1038806, XrefRangeEnd = 1038806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ForceReupload()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ForceReupload_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1038807, RefRangeEnd = 1038808, XrefRangeStart = 1038807, XrefRangeEnd = 1038807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ShouldReupload()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShouldReupload_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1038808, RefRangeEnd = 1038809, XrefRangeStart = 1038808, XrefRangeEnd = 1038808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Prioritize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Prioritize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1038809, RefRangeEnd = 1038810, XrefRangeStart = 1038809, XrefRangeEnd = 1038809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ShouldPrioritize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShouldPrioritize_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1038810, XrefRangeEnd = 1038811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1038811, XrefRangeEnd = 1038819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CellBlendingInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CellBlendingInfo>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public CellBlendingInfo(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class CellStreamingInfo : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_request;

		private static readonly System.IntPtr NativeFieldInfoPtr_blendingRequest0;

		private static readonly System.IntPtr NativeFieldInfoPtr_blendingRequest1;

		private static readonly System.IntPtr NativeFieldInfoPtr_streamingScore;

		private static readonly System.IntPtr NativeMethodInfoPtr_IsStreaming_Public_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_IsBlendingStreaming_Public_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe CellStreamingRequest request
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_request);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CellStreamingRequest>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_request)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe CellStreamingRequest blendingRequest0
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blendingRequest0);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CellStreamingRequest>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blendingRequest0)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe CellStreamingRequest blendingRequest1
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blendingRequest1);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CellStreamingRequest>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blendingRequest1)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe float streamingScore
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_streamingScore);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_streamingScore)) = value;
			}
		}

		static CellStreamingInfo()
		{
			Il2CppClassPointerStore<CellStreamingInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "CellStreamingInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CellStreamingInfo>.NativeClassPtr);
			NativeFieldInfoPtr_request = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellStreamingInfo>.NativeClassPtr, "request");
			NativeFieldInfoPtr_blendingRequest0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellStreamingInfo>.NativeClassPtr, "blendingRequest0");
			NativeFieldInfoPtr_blendingRequest1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellStreamingInfo>.NativeClassPtr, "blendingRequest1");
			NativeFieldInfoPtr_streamingScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellStreamingInfo>.NativeClassPtr, "streamingScore");
			NativeMethodInfoPtr_IsStreaming_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellStreamingInfo>.NativeClassPtr, 100665639);
			NativeMethodInfoPtr_IsBlendingStreaming_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellStreamingInfo>.NativeClassPtr, 100665640);
			NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellStreamingInfo>.NativeClassPtr, 100665641);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellStreamingInfo>.NativeClassPtr, 100665642);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1038819, RefRangeEnd = 1038822, XrefRangeStart = 1038819, XrefRangeEnd = 1038819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsStreaming()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsStreaming_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1038822, RefRangeEnd = 1038828, XrefRangeStart = 1038822, XrefRangeEnd = 1038822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsBlendingStreaming()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsBlendingStreaming_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1038828, XrefRangeEnd = 1038831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CellStreamingInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CellStreamingInfo>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public CellStreamingInfo(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class Cell : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_desc;

		private static readonly System.IntPtr NativeFieldInfoPtr_data;

		private static readonly System.IntPtr NativeFieldInfoPtr_poolInfo;

		private static readonly System.IntPtr NativeFieldInfoPtr_indexInfo;

		private static readonly System.IntPtr NativeFieldInfoPtr_blendingInfo;

		private static readonly System.IntPtr NativeFieldInfoPtr_streamingInfo;

		private static readonly System.IntPtr NativeFieldInfoPtr_referenceCount;

		private static readonly System.IntPtr NativeFieldInfoPtr_loaded;

		private static readonly System.IntPtr NativeFieldInfoPtr_scenario0;

		private static readonly System.IntPtr NativeFieldInfoPtr_scenario1;

		private static readonly System.IntPtr NativeFieldInfoPtr_hasTwoScenarios;

		private static readonly System.IntPtr NativeFieldInfoPtr_debugProbes;

		private static readonly System.IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Cell_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateCellScenarioData_Public_Boolean_String_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe CellDesc desc
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_desc);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CellDesc>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_desc)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe CellData data
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_data);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CellData>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_data)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe CellPoolInfo poolInfo
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_poolInfo);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CellPoolInfo>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_poolInfo)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe CellIndexInfo indexInfo
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_indexInfo);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CellIndexInfo>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_indexInfo)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe CellBlendingInfo blendingInfo
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blendingInfo);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CellBlendingInfo>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blendingInfo)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe CellStreamingInfo streamingInfo
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_streamingInfo);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CellStreamingInfo>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_streamingInfo)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe int referenceCount
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_referenceCount);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_referenceCount)) = value;
			}
		}

		public unsafe bool loaded
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loaded);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loaded)) = value;
			}
		}

		public unsafe CellData.PerScenarioData scenario0
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scenario0);
				return new CellData.PerScenarioData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CellData.PerScenarioData>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scenario0), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CellData.PerScenarioData>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe CellData.PerScenarioData scenario1
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scenario1);
				return new CellData.PerScenarioData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CellData.PerScenarioData>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scenario1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CellData.PerScenarioData>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe bool hasTwoScenarios
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasTwoScenarios);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasTwoScenarios)) = value;
			}
		}

		public unsafe CellInstancedDebugProbes debugProbes
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugProbes);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CellInstancedDebugProbes>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugProbes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static Cell()
		{
			Il2CppClassPointerStore<Cell>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "Cell");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Cell>.NativeClassPtr);
			NativeFieldInfoPtr_desc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cell>.NativeClassPtr, "desc");
			NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cell>.NativeClassPtr, "data");
			NativeFieldInfoPtr_poolInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cell>.NativeClassPtr, "poolInfo");
			NativeFieldInfoPtr_indexInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cell>.NativeClassPtr, "indexInfo");
			NativeFieldInfoPtr_blendingInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cell>.NativeClassPtr, "blendingInfo");
			NativeFieldInfoPtr_streamingInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cell>.NativeClassPtr, "streamingInfo");
			NativeFieldInfoPtr_referenceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cell>.NativeClassPtr, "referenceCount");
			NativeFieldInfoPtr_loaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cell>.NativeClassPtr, "loaded");
			NativeFieldInfoPtr_scenario0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cell>.NativeClassPtr, "scenario0");
			NativeFieldInfoPtr_scenario1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cell>.NativeClassPtr, "scenario1");
			NativeFieldInfoPtr_hasTwoScenarios = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cell>.NativeClassPtr, "hasTwoScenarios");
			NativeFieldInfoPtr_debugProbes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cell>.NativeClassPtr, "debugProbes");
			NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Cell_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cell>.NativeClassPtr, 100665643);
			NativeMethodInfoPtr_UpdateCellScenarioData_Public_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cell>.NativeClassPtr, 100665644);
			NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cell>.NativeClassPtr, 100665645);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cell>.NativeClassPtr, 100665646);
		}

		[CallerCount(0)]
		public unsafe virtual int CompareTo(Cell other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)other);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Cell_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1038837, RefRangeEnd = 1038838, XrefRangeStart = 1038831, XrefRangeEnd = 1038837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool UpdateCellScenarioData(string scenario0, string scenario1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(scenario0);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(scenario1);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateCellScenarioData_Public_Boolean_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1038849, RefRangeEnd = 1038850, XrefRangeStart = 1038838, XrefRangeEnd = 1038849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1038850, XrefRangeEnd = 1038885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Cell()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cell>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public Cell(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct Volume
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_corner;

		private static readonly System.IntPtr NativeFieldInfoPtr_X;

		private static readonly System.IntPtr NativeFieldInfoPtr_Y;

		private static readonly System.IntPtr NativeFieldInfoPtr_Z;

		private static readonly System.IntPtr NativeFieldInfoPtr_maxSubdivisionMultiplier;

		private static readonly System.IntPtr NativeFieldInfoPtr_minSubdivisionMultiplier;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Matrix4x4_Single_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_Vector3_Vector3_Single_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Volume_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Bounds_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CalculateAABB_Public_Bounds_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CalculateCenterAndSize_Public_Void_byref_Vector3_byref_Vector3_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Transform_Public_Void_Matrix4x4_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Volume_0;

		[FieldOffset(0)]
		public Vector3 corner;

		[FieldOffset(12)]
		public Vector3 X;

		[FieldOffset(24)]
		public Vector3 Y;

		[FieldOffset(36)]
		public Vector3 Z;

		[FieldOffset(48)]
		public float maxSubdivisionMultiplier;

		[FieldOffset(52)]
		public float minSubdivisionMultiplier;

		static Volume()
		{
			Il2CppClassPointerStore<Volume>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "Volume");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Volume>.NativeClassPtr);
			NativeFieldInfoPtr_corner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Volume>.NativeClassPtr, "corner");
			NativeFieldInfoPtr_X = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Volume>.NativeClassPtr, "X");
			NativeFieldInfoPtr_Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Volume>.NativeClassPtr, "Y");
			NativeFieldInfoPtr_Z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Volume>.NativeClassPtr, "Z");
			NativeFieldInfoPtr_maxSubdivisionMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Volume>.NativeClassPtr, "maxSubdivisionMultiplier");
			NativeFieldInfoPtr_minSubdivisionMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Volume>.NativeClassPtr, "minSubdivisionMultiplier");
			NativeMethodInfoPtr__ctor_Public_Void_Matrix4x4_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Volume>.NativeClassPtr, 100665647);
			NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_Vector3_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Volume>.NativeClassPtr, 100665648);
			NativeMethodInfoPtr__ctor_Public_Void_Volume_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Volume>.NativeClassPtr, 100665649);
			NativeMethodInfoPtr__ctor_Public_Void_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Volume>.NativeClassPtr, 100665650);
			NativeMethodInfoPtr_CalculateAABB_Public_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Volume>.NativeClassPtr, 100665651);
			NativeMethodInfoPtr_CalculateCenterAndSize_Public_Void_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Volume>.NativeClassPtr, 100665652);
			NativeMethodInfoPtr_Transform_Public_Void_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Volume>.NativeClassPtr, 100665653);
			NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Volume>.NativeClassPtr, 100665654);
			NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Volume_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Volume>.NativeClassPtr, 100665655);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1038885, XrefRangeEnd = 1038889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Volume(Matrix4x4 trs, float maxSubdivision, float minSubdivision)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = (nint)(&trs);
			*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxSubdivision;
			*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &minSubdivision;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Matrix4x4_Single_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe Volume(Vector3 corner, Vector3 X, Vector3 Y, Vector3 Z, float maxSubdivision = 1f, float minSubdivision = 0f)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[6];
			*ptr = (nint)(&corner);
			*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &X;
			*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &Y;
			*(Vector3**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &Z;
			*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxSubdivision;
			*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &minSubdivision;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_Vector3_Vector3_Single_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe Volume(Volume copy)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&copy);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Volume_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe Volume(Bounds bounds)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&bounds);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Bounds_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1038889, RefRangeEnd = 1038890, XrefRangeStart = 1038889, XrefRangeEnd = 1038889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Bounds CalculateAABB()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateAABB_Public_Bounds_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Bounds*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1038890, XrefRangeEnd = 1038893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CalculateCenterAndSize(out Vector3 center, out Vector3 size)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)Unsafe.AsPointer(ref center);
			*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref size);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateCenterAndSize_Public_Void_byref_Vector3_byref_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1038893, XrefRangeEnd = 1038897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Transform(Matrix4x4 trs)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&trs);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Transform_Public_Void_Matrix4x4_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1038897, XrefRangeEnd = 1038924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		[CallerCount(0)]
		public unsafe virtual bool Equals(Volume other)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&other);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Volume_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Volume>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct RefVolTransform
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_posWS;

		private static readonly System.IntPtr NativeFieldInfoPtr_rot;

		private static readonly System.IntPtr NativeFieldInfoPtr_scale;

		[FieldOffset(0)]
		public Vector3 posWS;

		[FieldOffset(12)]
		public Quaternion rot;

		[FieldOffset(28)]
		public float scale;

		static RefVolTransform()
		{
			Il2CppClassPointerStore<RefVolTransform>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "RefVolTransform");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RefVolTransform>.NativeClassPtr);
			NativeFieldInfoPtr_posWS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefVolTransform>.NativeClassPtr, "posWS");
			NativeFieldInfoPtr_rot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefVolTransform>.NativeClassPtr, "rot");
			NativeFieldInfoPtr_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefVolTransform>.NativeClassPtr, "scale");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RefVolTransform>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	public sealed class RuntimeResources : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_index;

		private static readonly System.IntPtr NativeFieldInfoPtr_cellIndices;

		private static readonly System.IntPtr NativeFieldInfoPtr_L0_L1rx;

		private static readonly System.IntPtr NativeFieldInfoPtr_L1_G_ry;

		private static readonly System.IntPtr NativeFieldInfoPtr_L1_B_rz;

		private static readonly System.IntPtr NativeFieldInfoPtr_L2_0;

		private static readonly System.IntPtr NativeFieldInfoPtr_L2_1;

		private static readonly System.IntPtr NativeFieldInfoPtr_L2_2;

		private static readonly System.IntPtr NativeFieldInfoPtr_L2_3;

		private static readonly System.IntPtr NativeFieldInfoPtr_ProbeOcclusion;

		private static readonly System.IntPtr NativeFieldInfoPtr_Validity;

		private static readonly System.IntPtr NativeFieldInfoPtr_SkyOcclusionL0L1;

		private static readonly System.IntPtr NativeFieldInfoPtr_SkyShadingDirectionIndices;

		private static readonly System.IntPtr NativeFieldInfoPtr_SkyPrecomputedDirections;

		private static readonly System.IntPtr NativeFieldInfoPtr_QualityLeakReductionData;

		public unsafe ComputeBuffer index
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_index);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ComputeBuffer>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_index)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe ComputeBuffer cellIndices
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cellIndices);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ComputeBuffer>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cellIndices)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe RenderTexture L0_L1rx
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_L0_L1rx);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_L0_L1rx)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe RenderTexture L1_G_ry
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_L1_G_ry);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_L1_G_ry)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe RenderTexture L1_B_rz
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_L1_B_rz);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_L1_B_rz)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe RenderTexture L2_0
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_L2_0);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_L2_0)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe RenderTexture L2_1
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_L2_1);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_L2_1)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe RenderTexture L2_2
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_L2_2);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_L2_2)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe RenderTexture L2_3
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_L2_3);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_L2_3)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe RenderTexture ProbeOcclusion
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ProbeOcclusion);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ProbeOcclusion)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe RenderTexture Validity
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Validity);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Validity)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe RenderTexture SkyOcclusionL0L1
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SkyOcclusionL0L1);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SkyOcclusionL0L1)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe RenderTexture SkyShadingDirectionIndices
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SkyShadingDirectionIndices);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SkyShadingDirectionIndices)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe ComputeBuffer SkyPrecomputedDirections
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SkyPrecomputedDirections);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ComputeBuffer>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SkyPrecomputedDirections)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe ComputeBuffer QualityLeakReductionData
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_QualityLeakReductionData);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ComputeBuffer>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_QualityLeakReductionData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static RuntimeResources()
		{
			Il2CppClassPointerStore<RuntimeResources>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "RuntimeResources");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeResources>.NativeClassPtr);
			NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeResources>.NativeClassPtr, "index");
			NativeFieldInfoPtr_cellIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeResources>.NativeClassPtr, "cellIndices");
			NativeFieldInfoPtr_L0_L1rx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeResources>.NativeClassPtr, "L0_L1rx");
			NativeFieldInfoPtr_L1_G_ry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeResources>.NativeClassPtr, "L1_G_ry");
			NativeFieldInfoPtr_L1_B_rz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeResources>.NativeClassPtr, "L1_B_rz");
			NativeFieldInfoPtr_L2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeResources>.NativeClassPtr, "L2_0");
			NativeFieldInfoPtr_L2_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeResources>.NativeClassPtr, "L2_1");
			NativeFieldInfoPtr_L2_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeResources>.NativeClassPtr, "L2_2");
			NativeFieldInfoPtr_L2_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeResources>.NativeClassPtr, "L2_3");
			NativeFieldInfoPtr_ProbeOcclusion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeResources>.NativeClassPtr, "ProbeOcclusion");
			NativeFieldInfoPtr_Validity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeResources>.NativeClassPtr, "Validity");
			NativeFieldInfoPtr_SkyOcclusionL0L1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeResources>.NativeClassPtr, "SkyOcclusionL0L1");
			NativeFieldInfoPtr_SkyShadingDirectionIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeResources>.NativeClassPtr, "SkyShadingDirectionIndices");
			NativeFieldInfoPtr_SkyPrecomputedDirections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeResources>.NativeClassPtr, "SkyPrecomputedDirections");
			NativeFieldInfoPtr_QualityLeakReductionData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeResources>.NativeClassPtr, "QualityLeakReductionData");
		}

		public RuntimeResources(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public RuntimeResources()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimeResources>.NativeClassPtr))
		{
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct ExtraDataActionInput
	{
		static ExtraDataActionInput()
		{
			Il2CppClassPointerStore<ExtraDataActionInput>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "ExtraDataActionInput");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExtraDataActionInput>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ExtraDataActionInput>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	public class CellInstancedDebugProbes : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_probeBuffers;

		private static readonly System.IntPtr NativeFieldInfoPtr_offsetBuffers;

		private static readonly System.IntPtr NativeFieldInfoPtr_props;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe List<Il2CppStructArray<Matrix4x4>> probeBuffers
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_probeBuffers);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Il2CppStructArray<Matrix4x4>>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_probeBuffers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe List<Il2CppStructArray<Matrix4x4>> offsetBuffers
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offsetBuffers);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Il2CppStructArray<Matrix4x4>>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offsetBuffers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe List<MaterialPropertyBlock> props
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_props);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<MaterialPropertyBlock>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_props)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static CellInstancedDebugProbes()
		{
			Il2CppClassPointerStore<CellInstancedDebugProbes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "CellInstancedDebugProbes");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CellInstancedDebugProbes>.NativeClassPtr);
			NativeFieldInfoPtr_probeBuffers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellInstancedDebugProbes>.NativeClassPtr, "probeBuffers");
			NativeFieldInfoPtr_offsetBuffers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellInstancedDebugProbes>.NativeClassPtr, "offsetBuffers");
			NativeFieldInfoPtr_props = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellInstancedDebugProbes>.NativeClassPtr, "props");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellInstancedDebugProbes>.NativeClassPtr, 100665656);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CellInstancedDebugProbes()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CellInstancedDebugProbes>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public CellInstancedDebugProbes(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class RenderFragmentationOverlayPassData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_debugFragmentationMaterial;

		private static readonly System.IntPtr NativeFieldInfoPtr_debugOverlay;

		private static readonly System.IntPtr NativeFieldInfoPtr_chunkCount;

		private static readonly System.IntPtr NativeFieldInfoPtr_debugFragmentationData;

		private static readonly System.IntPtr NativeFieldInfoPtr_colorBuffer;

		private static readonly System.IntPtr NativeFieldInfoPtr_depthBuffer;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Material debugFragmentationMaterial
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugFragmentationMaterial);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugFragmentationMaterial)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe DebugOverlay debugOverlay
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugOverlay);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DebugOverlay>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugOverlay)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe int chunkCount
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chunkCount);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chunkCount)) = value;
			}
		}

		public unsafe ComputeBuffer debugFragmentationData
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugFragmentationData);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ComputeBuffer>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugFragmentationData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe TextureHandle colorBuffer
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colorBuffer);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colorBuffer)) = value;
			}
		}

		public unsafe TextureHandle depthBuffer
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_depthBuffer);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_depthBuffer)) = value;
			}
		}

		static RenderFragmentationOverlayPassData()
		{
			Il2CppClassPointerStore<RenderFragmentationOverlayPassData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "RenderFragmentationOverlayPassData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderFragmentationOverlayPassData>.NativeClassPtr);
			NativeFieldInfoPtr_debugFragmentationMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderFragmentationOverlayPassData>.NativeClassPtr, "debugFragmentationMaterial");
			NativeFieldInfoPtr_debugOverlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderFragmentationOverlayPassData>.NativeClassPtr, "debugOverlay");
			NativeFieldInfoPtr_chunkCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderFragmentationOverlayPassData>.NativeClassPtr, "chunkCount");
			NativeFieldInfoPtr_debugFragmentationData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderFragmentationOverlayPassData>.NativeClassPtr, "debugFragmentationData");
			NativeFieldInfoPtr_colorBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderFragmentationOverlayPassData>.NativeClassPtr, "colorBuffer");
			NativeFieldInfoPtr_depthBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderFragmentationOverlayPassData>.NativeClassPtr, "depthBuffer");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderFragmentationOverlayPassData>.NativeClassPtr, 100665657);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderFragmentationOverlayPassData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderFragmentationOverlayPassData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public RenderFragmentationOverlayPassData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class DiskStreamingRequest : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_m_ReadHandle;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_ReadCommandArray;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_ReadCommandBuffer;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_BytesWritten;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_AddReadCommand_Public_Void_Int32_Int32_ptr_Byte_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_RunCommands_Public_Int32_FileHandle_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Cancel_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Wait_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetStatus_Public_ReadStatus_0;

		public unsafe ReadHandle m_ReadHandle
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ReadHandle);
				return *(ReadHandle*)num;
			}
			set
			{
				*(ReadHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ReadHandle)) = value;
			}
		}

		public unsafe ReadCommandArray m_ReadCommandArray
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ReadCommandArray);
				return *(ReadCommandArray*)num;
			}
			set
			{
				*(ReadCommandArray*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ReadCommandArray)) = value;
			}
		}

		public unsafe NativeArray<ReadCommand> m_ReadCommandBuffer
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ReadCommandBuffer);
				return new NativeArray<ReadCommand>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<ReadCommand>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ReadCommandBuffer), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<ReadCommand>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe int m_BytesWritten
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BytesWritten);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BytesWritten)) = value;
			}
		}

		static DiskStreamingRequest()
		{
			Il2CppClassPointerStore<DiskStreamingRequest>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "DiskStreamingRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DiskStreamingRequest>.NativeClassPtr);
			NativeFieldInfoPtr_m_ReadHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiskStreamingRequest>.NativeClassPtr, "m_ReadHandle");
			NativeFieldInfoPtr_m_ReadCommandArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiskStreamingRequest>.NativeClassPtr, "m_ReadCommandArray");
			NativeFieldInfoPtr_m_ReadCommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiskStreamingRequest>.NativeClassPtr, "m_ReadCommandBuffer");
			NativeFieldInfoPtr_m_BytesWritten = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiskStreamingRequest>.NativeClassPtr, "m_BytesWritten");
			NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiskStreamingRequest>.NativeClassPtr, 100665658);
			NativeMethodInfoPtr_AddReadCommand_Public_Void_Int32_Int32_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiskStreamingRequest>.NativeClassPtr, 100665659);
			NativeMethodInfoPtr_RunCommands_Public_Int32_FileHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiskStreamingRequest>.NativeClassPtr, 100665660);
			NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiskStreamingRequest>.NativeClassPtr, 100665661);
			NativeMethodInfoPtr_Cancel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiskStreamingRequest>.NativeClassPtr, 100665662);
			NativeMethodInfoPtr_Wait_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiskStreamingRequest>.NativeClassPtr, 100665663);
			NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiskStreamingRequest>.NativeClassPtr, 100665664);
			NativeMethodInfoPtr_GetStatus_Public_ReadStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiskStreamingRequest>.NativeClassPtr, 100665665);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1038924, XrefRangeEnd = 1038928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DiskStreamingRequest(int maxRequestCount)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DiskStreamingRequest>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&maxRequestCount);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1038928, RefRangeEnd = 1038938, XrefRangeStart = 1038928, XrefRangeEnd = 1038928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddReadCommand(int offset, int size, byte* dest)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = (nint)(&offset);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
			*(byte**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = dest;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddReadCommand_Public_Void_Int32_Int32_ptr_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1038942, RefRangeEnd = 1038948, XrefRangeStart = 1038938, XrefRangeEnd = 1038942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int RunCommands(FileHandle file)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&file);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RunCommands_Public_Int32_FileHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1038948, XrefRangeEnd = 1038951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1038951, XrefRangeEnd = 1038953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cancel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Cancel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1038953, XrefRangeEnd = 1038956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Wait()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Wait_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1038956, XrefRangeEnd = 1038959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1038959, XrefRangeEnd = 1038961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadStatus GetStatus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetStatus_Public_ReadStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(ReadStatus*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public DiskStreamingRequest(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct CellStreamingScratchBufferLayout
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__SharedDestChunksOffset;

		private static readonly System.IntPtr NativeFieldInfoPtr__L0L1rxOffset;

		private static readonly System.IntPtr NativeFieldInfoPtr__L1GryOffset;

		private static readonly System.IntPtr NativeFieldInfoPtr__L1BrzOffset;

		private static readonly System.IntPtr NativeFieldInfoPtr__ValidityOffset;

		private static readonly System.IntPtr NativeFieldInfoPtr__ProbeOcclusionOffset;

		private static readonly System.IntPtr NativeFieldInfoPtr__SkyOcclusionOffset;

		private static readonly System.IntPtr NativeFieldInfoPtr__SkyShadingDirectionOffset;

		private static readonly System.IntPtr NativeFieldInfoPtr__L2_0Offset;

		private static readonly System.IntPtr NativeFieldInfoPtr__L2_1Offset;

		private static readonly System.IntPtr NativeFieldInfoPtr__L2_2Offset;

		private static readonly System.IntPtr NativeFieldInfoPtr__L2_3Offset;

		private static readonly System.IntPtr NativeFieldInfoPtr__L0Size;

		private static readonly System.IntPtr NativeFieldInfoPtr__L0ProbeSize;

		private static readonly System.IntPtr NativeFieldInfoPtr__L1Size;

		private static readonly System.IntPtr NativeFieldInfoPtr__L1ProbeSize;

		private static readonly System.IntPtr NativeFieldInfoPtr__ValiditySize;

		private static readonly System.IntPtr NativeFieldInfoPtr__ValidityProbeSize;

		private static readonly System.IntPtr NativeFieldInfoPtr__ProbeOcclusionSize;

		private static readonly System.IntPtr NativeFieldInfoPtr__ProbeOcclusionProbeSize;

		private static readonly System.IntPtr NativeFieldInfoPtr__SkyOcclusionSize;

		private static readonly System.IntPtr NativeFieldInfoPtr__SkyOcclusionProbeSize;

		private static readonly System.IntPtr NativeFieldInfoPtr__SkyShadingDirectionSize;

		private static readonly System.IntPtr NativeFieldInfoPtr__SkyShadingDirectionProbeSize;

		private static readonly System.IntPtr NativeFieldInfoPtr__L2Size;

		private static readonly System.IntPtr NativeFieldInfoPtr__L2ProbeSize;

		private static readonly System.IntPtr NativeFieldInfoPtr__ProbeCountInChunkLine;

		private static readonly System.IntPtr NativeFieldInfoPtr__ProbeCountInChunkSlice;

		[FieldOffset(0)]
		public int _SharedDestChunksOffset;

		[FieldOffset(4)]
		public int _L0L1rxOffset;

		[FieldOffset(8)]
		public int _L1GryOffset;

		[FieldOffset(12)]
		public int _L1BrzOffset;

		[FieldOffset(16)]
		public int _ValidityOffset;

		[FieldOffset(20)]
		public int _ProbeOcclusionOffset;

		[FieldOffset(24)]
		public int _SkyOcclusionOffset;

		[FieldOffset(28)]
		public int _SkyShadingDirectionOffset;

		[FieldOffset(32)]
		public int _L2_0Offset;

		[FieldOffset(36)]
		public int _L2_1Offset;

		[FieldOffset(40)]
		public int _L2_2Offset;

		[FieldOffset(44)]
		public int _L2_3Offset;

		[FieldOffset(48)]
		public int _L0Size;

		[FieldOffset(52)]
		public int _L0ProbeSize;

		[FieldOffset(56)]
		public int _L1Size;

		[FieldOffset(60)]
		public int _L1ProbeSize;

		[FieldOffset(64)]
		public int _ValiditySize;

		[FieldOffset(68)]
		public int _ValidityProbeSize;

		[FieldOffset(72)]
		public int _ProbeOcclusionSize;

		[FieldOffset(76)]
		public int _ProbeOcclusionProbeSize;

		[FieldOffset(80)]
		public int _SkyOcclusionSize;

		[FieldOffset(84)]
		public int _SkyOcclusionProbeSize;

		[FieldOffset(88)]
		public int _SkyShadingDirectionSize;

		[FieldOffset(92)]
		public int _SkyShadingDirectionProbeSize;

		[FieldOffset(96)]
		public int _L2Size;

		[FieldOffset(100)]
		public int _L2ProbeSize;

		[FieldOffset(104)]
		public int _ProbeCountInChunkLine;

		[FieldOffset(108)]
		public int _ProbeCountInChunkSlice;

		static CellStreamingScratchBufferLayout()
		{
			Il2CppClassPointerStore<CellStreamingScratchBufferLayout>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "CellStreamingScratchBufferLayout");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CellStreamingScratchBufferLayout>.NativeClassPtr);
			NativeFieldInfoPtr__SharedDestChunksOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellStreamingScratchBufferLayout>.NativeClassPtr, "_SharedDestChunksOffset");
			NativeFieldInfoPtr__L0L1rxOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellStreamingScratchBufferLayout>.NativeClassPtr, "_L0L1rxOffset");
			NativeFieldInfoPtr__L1GryOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellStreamingScratchBufferLayout>.NativeClassPtr, "_L1GryOffset");
			NativeFieldInfoPtr__L1BrzOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellStreamingScratchBufferLayout>.NativeClassPtr, "_L1BrzOffset");
			NativeFieldInfoPtr__ValidityOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellStreamingScratchBufferLayout>.NativeClassPtr, "_ValidityOffset");
			NativeFieldInfoPtr__ProbeOcclusionOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellStreamingScratchBufferLayout>.NativeClassPtr, "_ProbeOcclusionOffset");
			NativeFieldInfoPtr__SkyOcclusionOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellStreamingScratchBufferLayout>.NativeClassPtr, "_SkyOcclusionOffset");
			NativeFieldInfoPtr__SkyShadingDirectionOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellStreamingScratchBufferLayout>.NativeClassPtr, "_SkyShadingDirectionOffset");
			NativeFieldInfoPtr__L2_0Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellStreamingScratchBufferLayout>.NativeClassPtr, "_L2_0Offset");
			NativeFieldInfoPtr__L2_1Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellStreamingScratchBufferLayout>.NativeClassPtr, "_L2_1Offset");
			NativeFieldInfoPtr__L2_2Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellStreamingScratchBufferLayout>.NativeClassPtr, "_L2_2Offset");
			NativeFieldInfoPtr__L2_3Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellStreamingScratchBufferLayout>.NativeClassPtr, "_L2_3Offset");
			NativeFieldInfoPtr__L0Size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellStreamingScratchBufferLayout>.NativeClassPtr, "_L0Size");
			NativeFieldInfoPtr__L0ProbeSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellStreamingScratchBufferLayout>.NativeClassPtr, "_L0ProbeSize");
			NativeFieldInfoPtr__L1Size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellStreamingScratchBufferLayout>.NativeClassPtr, "_L1Size");
			NativeFieldInfoPtr__L1ProbeSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellStreamingScratchBufferLayout>.NativeClassPtr, "_L1ProbeSize");
			NativeFieldInfoPtr__ValiditySize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellStreamingScratchBufferLayout>.NativeClassPtr, "_ValiditySize");
			NativeFieldInfoPtr__ValidityProbeSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellStreamingScratchBufferLayout>.NativeClassPtr, "_ValidityProbeSize");
			NativeFieldInfoPtr__ProbeOcclusionSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellStreamingScratchBufferLayout>.NativeClassPtr, "_ProbeOcclusionSize");
			NativeFieldInfoPtr__ProbeOcclusionProbeSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellStreamingScratchBufferLayout>.NativeClassPtr, "_ProbeOcclusionProbeSize");
			NativeFieldInfoPtr__SkyOcclusionSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellStreamingScratchBufferLayout>.NativeClassPtr, "_SkyOcclusionSize");
			NativeFieldInfoPtr__SkyOcclusionProbeSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellStreamingScratchBufferLayout>.NativeClassPtr, "_SkyOcclusionProbeSize");
			NativeFieldInfoPtr__SkyShadingDirectionSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellStreamingScratchBufferLayout>.NativeClassPtr, "_SkyShadingDirectionSize");
			NativeFieldInfoPtr__SkyShadingDirectionProbeSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellStreamingScratchBufferLayout>.NativeClassPtr, "_SkyShadingDirectionProbeSize");
			NativeFieldInfoPtr__L2Size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellStreamingScratchBufferLayout>.NativeClassPtr, "_L2Size");
			NativeFieldInfoPtr__L2ProbeSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellStreamingScratchBufferLayout>.NativeClassPtr, "_L2ProbeSize");
			NativeFieldInfoPtr__ProbeCountInChunkLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellStreamingScratchBufferLayout>.NativeClassPtr, "_ProbeCountInChunkLine");
			NativeFieldInfoPtr__ProbeCountInChunkSlice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellStreamingScratchBufferLayout>.NativeClassPtr, "_ProbeCountInChunkSlice");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CellStreamingScratchBufferLayout>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	public class CellStreamingScratchBuffer : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_stagingBuffer;

		private static readonly System.IntPtr NativeFieldInfoPtr__chunkCount_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__chunkSize_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_CurrentBuffer;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_GraphicsBuffers;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Swap_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_buffer_Public_get_GraphicsBuffer_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_chunkCount_Public_get_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_chunkSize_Public_get_Int32_0;

		public unsafe NativeArray<byte> stagingBuffer
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stagingBuffer);
				return new NativeArray<byte>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<byte>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stagingBuffer), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<byte>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe int _chunkCount_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__chunkCount_k__BackingField);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__chunkCount_k__BackingField)) = value;
			}
		}

		public unsafe int _chunkSize_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__chunkSize_k__BackingField);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__chunkSize_k__BackingField)) = value;
			}
		}

		public unsafe int m_CurrentBuffer
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentBuffer);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentBuffer)) = value;
			}
		}

		public unsafe Il2CppReferenceArray<GraphicsBuffer> m_GraphicsBuffers
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_GraphicsBuffers);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GraphicsBuffer>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_GraphicsBuffers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe GraphicsBuffer buffer
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1038981, RefRangeEnd = 1038984, XrefRangeStart = 1038981, XrefRangeEnd = 1038981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_buffer_Public_get_GraphicsBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GraphicsBuffer>(intPtr2) : null;
			}
		}

		public unsafe int chunkCount
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 63233, RefRangeEnd = 63234, XrefRangeStart = 63233, XrefRangeEnd = 63234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_chunkCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		public unsafe int chunkSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_chunkSize_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		static CellStreamingScratchBuffer()
		{
			Il2CppClassPointerStore<CellStreamingScratchBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "CellStreamingScratchBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CellStreamingScratchBuffer>.NativeClassPtr);
			NativeFieldInfoPtr_stagingBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellStreamingScratchBuffer>.NativeClassPtr, "stagingBuffer");
			NativeFieldInfoPtr__chunkCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellStreamingScratchBuffer>.NativeClassPtr, "<chunkCount>k__BackingField");
			NativeFieldInfoPtr__chunkSize_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellStreamingScratchBuffer>.NativeClassPtr, "<chunkSize>k__BackingField");
			NativeFieldInfoPtr_m_CurrentBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellStreamingScratchBuffer>.NativeClassPtr, "m_CurrentBuffer");
			NativeFieldInfoPtr_m_GraphicsBuffers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellStreamingScratchBuffer>.NativeClassPtr, "m_GraphicsBuffers");
			NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellStreamingScratchBuffer>.NativeClassPtr, 100665666);
			NativeMethodInfoPtr_Swap_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellStreamingScratchBuffer>.NativeClassPtr, 100665667);
			NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellStreamingScratchBuffer>.NativeClassPtr, 100665668);
			NativeMethodInfoPtr_get_buffer_Public_get_GraphicsBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellStreamingScratchBuffer>.NativeClassPtr, 100665669);
			NativeMethodInfoPtr_get_chunkCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellStreamingScratchBuffer>.NativeClassPtr, 100665670);
			NativeMethodInfoPtr_get_chunkSize_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellStreamingScratchBuffer>.NativeClassPtr, 100665671);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1038961, XrefRangeEnd = 1038974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CellStreamingScratchBuffer(int chunkCount, int chunkSize, bool allocateGraphicsBuffers)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CellStreamingScratchBuffer>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = (nint)(&chunkCount);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &chunkSize;
			*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &allocateGraphicsBuffers;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe void Swap()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Swap_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1038980, RefRangeEnd = 1038981, XrefRangeStart = 1038974, XrefRangeEnd = 1038980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public CellStreamingScratchBuffer(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class CellStreamingRequest : Il2CppSystem.Object
	{
		[OriginalName("Unity.RenderPipelines.Core.Runtime.dll", "", "State")]
		public enum State
		{
			Pending,
			Active,
			Canceled,
			Invalid,
			Complete
		}

		public sealed class OnStreamingCompleteDelegate : Il2CppSystem.MulticastDelegate
		{
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_CellStreamingRequest_CommandBuffer_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_CellStreamingRequest_CommandBuffer_AsyncCallback_Object_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

			static OnStreamingCompleteDelegate()
			{
				Il2CppClassPointerStore<OnStreamingCompleteDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CellStreamingRequest>.NativeClassPtr, "OnStreamingCompleteDelegate");
				NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnStreamingCompleteDelegate>.NativeClassPtr, 100665695);
				NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_CellStreamingRequest_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnStreamingCompleteDelegate>.NativeClassPtr, 100665696);
				NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_CellStreamingRequest_CommandBuffer_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnStreamingCompleteDelegate>.NativeClassPtr, 100665697);
				NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnStreamingCompleteDelegate>.NativeClassPtr, 100665698);
			}

			[CallerCount(110)]
			[CachedScanResults(RefRangeStart = 49659, RefRangeEnd = 49769, XrefRangeStart = 49659, XrefRangeEnd = 49769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OnStreamingCompleteDelegate(Il2CppSystem.Object @object, System.IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnStreamingCompleteDelegate>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[2];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
				*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			[CallerCount(0)]
			public unsafe virtual void Invoke(CellStreamingRequest request, CommandBuffer cmd)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[2];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)request);
				*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_CellStreamingRequest_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual Il2CppSystem.IAsyncResult BeginInvoke(CellStreamingRequest request, CommandBuffer cmd, Il2CppSystem.AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[4];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)request);
				*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
				*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
				*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_CellStreamingRequest_CommandBuffer_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.IAsyncResult>(intPtr2) : null;
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void EndInvoke(Il2CppSystem.IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			public OnStreamingCompleteDelegate(System.IntPtr pointer)
				: base(pointer)
			{
			}

			public static implicit operator OnStreamingCompleteDelegate(System.Action<CellStreamingRequest, CommandBuffer> P_0)
			{
				return DelegateSupport.ConvertDelegate<OnStreamingCompleteDelegate>((System.Delegate)P_0);
			}

			public static OnStreamingCompleteDelegate operator +(OnStreamingCompleteDelegate P_0, OnStreamingCompleteDelegate P_1)
			{
				return ((Il2CppObjectBase)Il2CppSystem.Delegate.Combine(P_0, P_1)).Cast<OnStreamingCompleteDelegate>();
			}

			public static OnStreamingCompleteDelegate operator -(OnStreamingCompleteDelegate P_0, OnStreamingCompleteDelegate P_1)
			{
				object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
				if (obj != null)
				{
					obj = ((Il2CppObjectBase)obj).Cast<OnStreamingCompleteDelegate>();
				}
				return (OnStreamingCompleteDelegate)obj;
			}
		}

		private static readonly System.IntPtr NativeFieldInfoPtr__cell_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__state_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__scratchBuffer_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__scratchBufferLayout_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__scenarioData_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__poolIndex_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__streamSharedData_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr_onStreamingComplete;

		private static readonly System.IntPtr NativeFieldInfoPtr_cellDataStreamingRequest;

		private static readonly System.IntPtr NativeFieldInfoPtr_cellOptionalDataStreamingRequest;

		private static readonly System.IntPtr NativeFieldInfoPtr_cellSharedDataStreamingRequest;

		private static readonly System.IntPtr NativeFieldInfoPtr_cellProbeOcclusionDataStreamingRequest;

		private static readonly System.IntPtr NativeFieldInfoPtr_brickStreamingRequest;

		private static readonly System.IntPtr NativeFieldInfoPtr_supportStreamingRequest;

		private static readonly System.IntPtr NativeFieldInfoPtr_bytesWritten;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_cell_Public_get_Cell_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_cell_Public_set_Void_Cell_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_state_Public_get_State_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_state_Public_set_Void_State_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_scratchBuffer_Public_get_CellStreamingScratchBuffer_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_scratchBuffer_Public_set_Void_CellStreamingScratchBuffer_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_scratchBufferLayout_Public_get_CellStreamingScratchBufferLayout_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_scratchBufferLayout_Public_set_Void_CellStreamingScratchBufferLayout_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_scenarioData_Public_get_PerScenarioDataInfo_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_scenarioData_Public_set_Void_PerScenarioDataInfo_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_poolIndex_Public_get_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_poolIndex_Public_set_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_streamSharedData_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_streamSharedData_Public_set_Void_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_IsStreaming_Public_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Cancel_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_WaitAll_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateRequestState_Public_Boolean_DiskStreamingRequest_byref_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateState_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Cell _cell_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__cell_k__BackingField);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Cell>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__cell_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe State _state_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__state_k__BackingField);
				return *(State*)num;
			}
			set
			{
				*(State*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__state_k__BackingField)) = value;
			}
		}

		public unsafe CellStreamingScratchBuffer _scratchBuffer_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__scratchBuffer_k__BackingField);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CellStreamingScratchBuffer>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__scratchBuffer_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe CellStreamingScratchBufferLayout _scratchBufferLayout_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__scratchBufferLayout_k__BackingField);
				return *(CellStreamingScratchBufferLayout*)num;
			}
			set
			{
				*(CellStreamingScratchBufferLayout*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__scratchBufferLayout_k__BackingField)) = value;
			}
		}

		public unsafe ProbeVolumeBakingSet.PerScenarioDataInfo _scenarioData_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__scenarioData_k__BackingField);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProbeVolumeBakingSet.PerScenarioDataInfo>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__scenarioData_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe int _poolIndex_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__poolIndex_k__BackingField);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__poolIndex_k__BackingField)) = value;
			}
		}

		public unsafe bool _streamSharedData_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__streamSharedData_k__BackingField);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__streamSharedData_k__BackingField)) = value;
			}
		}

		public unsafe OnStreamingCompleteDelegate onStreamingComplete
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onStreamingComplete);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<OnStreamingCompleteDelegate>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onStreamingComplete)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe DiskStreamingRequest cellDataStreamingRequest
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cellDataStreamingRequest);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DiskStreamingRequest>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cellDataStreamingRequest)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe DiskStreamingRequest cellOptionalDataStreamingRequest
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cellOptionalDataStreamingRequest);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DiskStreamingRequest>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cellOptionalDataStreamingRequest)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe DiskStreamingRequest cellSharedDataStreamingRequest
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cellSharedDataStreamingRequest);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DiskStreamingRequest>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cellSharedDataStreamingRequest)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe DiskStreamingRequest cellProbeOcclusionDataStreamingRequest
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cellProbeOcclusionDataStreamingRequest);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DiskStreamingRequest>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cellProbeOcclusionDataStreamingRequest)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe DiskStreamingRequest brickStreamingRequest
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brickStreamingRequest);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DiskStreamingRequest>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brickStreamingRequest)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe DiskStreamingRequest supportStreamingRequest
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_supportStreamingRequest);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DiskStreamingRequest>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_supportStreamingRequest)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe int bytesWritten
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bytesWritten);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bytesWritten)) = value;
			}
		}

		public unsafe Cell cell
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 50644, RefRangeEnd = 50653, XrefRangeStart = 50644, XrefRangeEnd = 50653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_cell_Public_get_Cell_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Cell>(intPtr2) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 42532, RefRangeEnd = 42533, XrefRangeStart = 42532, XrefRangeEnd = 42533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_cell_Public_set_Void_Cell_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe State state
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 54510, RefRangeEnd = 54511, XrefRangeStart = 54510, XrefRangeEnd = 54511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_state_Public_get_State_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(State*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 155401, RefRangeEnd = 155404, XrefRangeStart = 155401, XrefRangeEnd = 155404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_state_Public_set_Void_State_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe CellStreamingScratchBuffer scratchBuffer
		{
			[CallerCount(36)]
			[CachedScanResults(RefRangeStart = 32112, RefRangeEnd = 32148, XrefRangeStart = 32112, XrefRangeEnd = 32148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_scratchBuffer_Public_get_CellStreamingScratchBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CellStreamingScratchBuffer>(intPtr2) : null;
			}
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 32149, RefRangeEnd = 32159, XrefRangeStart = 32149, XrefRangeEnd = 32159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_scratchBuffer_Public_set_Void_CellStreamingScratchBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe CellStreamingScratchBufferLayout scratchBufferLayout
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_scratchBufferLayout_Public_get_CellStreamingScratchBufferLayout_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(CellStreamingScratchBufferLayout*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_scratchBufferLayout_Public_set_Void_CellStreamingScratchBufferLayout_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe ProbeVolumeBakingSet.PerScenarioDataInfo scenarioData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_scenarioData_Public_get_PerScenarioDataInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProbeVolumeBakingSet.PerScenarioDataInfo>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_scenarioData_Public_set_Void_PerScenarioDataInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe int poolIndex
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 167261, RefRangeEnd = 167262, XrefRangeStart = 167261, XrefRangeEnd = 167262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_poolIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 483144, RefRangeEnd = 483151, XrefRangeStart = 483144, XrefRangeEnd = 483151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_poolIndex_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe bool streamSharedData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_streamSharedData_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
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
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_streamSharedData_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		static CellStreamingRequest()
		{
			Il2CppClassPointerStore<CellStreamingRequest>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "CellStreamingRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CellStreamingRequest>.NativeClassPtr);
			NativeFieldInfoPtr__cell_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellStreamingRequest>.NativeClassPtr, "<cell>k__BackingField");
			NativeFieldInfoPtr__state_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellStreamingRequest>.NativeClassPtr, "<state>k__BackingField");
			NativeFieldInfoPtr__scratchBuffer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellStreamingRequest>.NativeClassPtr, "<scratchBuffer>k__BackingField");
			NativeFieldInfoPtr__scratchBufferLayout_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellStreamingRequest>.NativeClassPtr, "<scratchBufferLayout>k__BackingField");
			NativeFieldInfoPtr__scenarioData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellStreamingRequest>.NativeClassPtr, "<scenarioData>k__BackingField");
			NativeFieldInfoPtr__poolIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellStreamingRequest>.NativeClassPtr, "<poolIndex>k__BackingField");
			NativeFieldInfoPtr__streamSharedData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellStreamingRequest>.NativeClassPtr, "<streamSharedData>k__BackingField");
			NativeFieldInfoPtr_onStreamingComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellStreamingRequest>.NativeClassPtr, "onStreamingComplete");
			NativeFieldInfoPtr_cellDataStreamingRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellStreamingRequest>.NativeClassPtr, "cellDataStreamingRequest");
			NativeFieldInfoPtr_cellOptionalDataStreamingRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellStreamingRequest>.NativeClassPtr, "cellOptionalDataStreamingRequest");
			NativeFieldInfoPtr_cellSharedDataStreamingRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellStreamingRequest>.NativeClassPtr, "cellSharedDataStreamingRequest");
			NativeFieldInfoPtr_cellProbeOcclusionDataStreamingRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellStreamingRequest>.NativeClassPtr, "cellProbeOcclusionDataStreamingRequest");
			NativeFieldInfoPtr_brickStreamingRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellStreamingRequest>.NativeClassPtr, "brickStreamingRequest");
			NativeFieldInfoPtr_supportStreamingRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellStreamingRequest>.NativeClassPtr, "supportStreamingRequest");
			NativeFieldInfoPtr_bytesWritten = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CellStreamingRequest>.NativeClassPtr, "bytesWritten");
			NativeMethodInfoPtr_get_cell_Public_get_Cell_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellStreamingRequest>.NativeClassPtr, 100665672);
			NativeMethodInfoPtr_set_cell_Public_set_Void_Cell_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellStreamingRequest>.NativeClassPtr, 100665673);
			NativeMethodInfoPtr_get_state_Public_get_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellStreamingRequest>.NativeClassPtr, 100665674);
			NativeMethodInfoPtr_set_state_Public_set_Void_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellStreamingRequest>.NativeClassPtr, 100665675);
			NativeMethodInfoPtr_get_scratchBuffer_Public_get_CellStreamingScratchBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellStreamingRequest>.NativeClassPtr, 100665676);
			NativeMethodInfoPtr_set_scratchBuffer_Public_set_Void_CellStreamingScratchBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellStreamingRequest>.NativeClassPtr, 100665677);
			NativeMethodInfoPtr_get_scratchBufferLayout_Public_get_CellStreamingScratchBufferLayout_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellStreamingRequest>.NativeClassPtr, 100665678);
			NativeMethodInfoPtr_set_scratchBufferLayout_Public_set_Void_CellStreamingScratchBufferLayout_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellStreamingRequest>.NativeClassPtr, 100665679);
			NativeMethodInfoPtr_get_scenarioData_Public_get_PerScenarioDataInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellStreamingRequest>.NativeClassPtr, 100665680);
			NativeMethodInfoPtr_set_scenarioData_Public_set_Void_PerScenarioDataInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellStreamingRequest>.NativeClassPtr, 100665681);
			NativeMethodInfoPtr_get_poolIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellStreamingRequest>.NativeClassPtr, 100665682);
			NativeMethodInfoPtr_set_poolIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellStreamingRequest>.NativeClassPtr, 100665683);
			NativeMethodInfoPtr_get_streamSharedData_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellStreamingRequest>.NativeClassPtr, 100665684);
			NativeMethodInfoPtr_set_streamSharedData_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellStreamingRequest>.NativeClassPtr, 100665685);
			NativeMethodInfoPtr_IsStreaming_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellStreamingRequest>.NativeClassPtr, 100665686);
			NativeMethodInfoPtr_Cancel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellStreamingRequest>.NativeClassPtr, 100665687);
			NativeMethodInfoPtr_WaitAll_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellStreamingRequest>.NativeClassPtr, 100665688);
			NativeMethodInfoPtr_UpdateRequestState_Public_Boolean_DiskStreamingRequest_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellStreamingRequest>.NativeClassPtr, 100665689);
			NativeMethodInfoPtr_UpdateState_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellStreamingRequest>.NativeClassPtr, 100665690);
			NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellStreamingRequest>.NativeClassPtr, 100665691);
			NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellStreamingRequest>.NativeClassPtr, 100665692);
			NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellStreamingRequest>.NativeClassPtr, 100665693);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CellStreamingRequest>.NativeClassPtr, 100665694);
		}

		[CallerCount(0)]
		public unsafe bool IsStreaming()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsStreaming_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1038996, RefRangeEnd = 1039007, XrefRangeStart = 1038984, XrefRangeEnd = 1038996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cancel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Cancel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039007, XrefRangeEnd = 1039025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WaitAll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WaitAll_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039025, XrefRangeEnd = 1039027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool UpdateRequestState(DiskStreamingRequest request, ref bool isComplete)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)request);
			*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref isComplete);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateRequestState_Public_Boolean_DiskStreamingRequest_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1039045, RefRangeEnd = 1039046, XrefRangeStart = 1039027, XrefRangeEnd = 1039045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateState_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039046, XrefRangeEnd = 1039048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1039067, RefRangeEnd = 1039071, XrefRangeStart = 1039048, XrefRangeEnd = 1039067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1039090, RefRangeEnd = 1039091, XrefRangeStart = 1039071, XrefRangeEnd = 1039090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039091, XrefRangeEnd = 1039135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CellStreamingRequest()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CellStreamingRequest>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public CellStreamingRequest(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	[ObfuscatedName("UnityEngine.Rendering.ProbeReferenceVolume+<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__158_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__158_1;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__229_1;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__229_8;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__229_18;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__229_19;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__229_25;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__229_29;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__229_36;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__229_37;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__229_45;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__229_46;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__229_50;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__229_60;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__229_61;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__229_62;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__229_63;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__229_64;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__229_65;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__229_66;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__229_70;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__229_76;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__229_77;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__229_78;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__229_79;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__229_80;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__229_81;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__229_82;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__229_87;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__229_88;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__229_89;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__229_90;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__232_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__293_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr___ctor_b__158_0_Internal_Void_Cell_0;

		private static readonly System.IntPtr NativeMethodInfoPtr___ctor_b__158_1_Internal_Void_CellStreamingRequest_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_1_Internal_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_8_Internal_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_18_Internal_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_19_Internal_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_25_Internal_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_29_Internal_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_36_Internal_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_37_Internal_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_45_Internal_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_46_Internal_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_50_Internal_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_60_Internal_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_61_Internal_Void_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_62_Internal_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_63_Internal_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_64_Internal_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_65_Internal_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_66_Internal_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_70_Internal_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_76_Internal_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_77_Internal_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_78_Internal_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_79_Internal_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_80_Internal_Void_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_81_Internal_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_82_Internal_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_87_Internal_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_88_Internal_Void_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_89_Internal_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_90_Internal_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__RenderFragmentationOverlay_b__232_0_Internal_Void_RenderFragmentationOverlayPassData_RenderGraphContext_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__CleanupStreaming_b__293_0_Internal_Void_CellStreamingRequest_0;

		public unsafe static __c __9
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static UnityAction<Cell> __9__158_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__158_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnityAction<Cell>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__158_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static UnityAction<CellStreamingRequest> __9__158_1
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__158_1, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnityAction<CellStreamingRequest>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__158_1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static Il2CppSystem.Func<bool> __9__229_1
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__229_1, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__229_1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static Il2CppSystem.Func<float> __9__229_8
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__229_8, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<float>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__229_8, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static Il2CppSystem.Func<float> __9__229_18
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__229_18, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<float>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__229_18, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static Il2CppSystem.Func<float> __9__229_19
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__229_19, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<float>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__229_19, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static Il2CppSystem.Func<int> __9__229_25
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__229_25, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__229_25, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static Il2CppSystem.Func<int> __9__229_29
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__229_29, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__229_29, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static Il2CppSystem.Func<float> __9__229_36
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__229_36, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<float>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__229_36, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static Il2CppSystem.Func<float> __9__229_37
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__229_37, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<float>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__229_37, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static Il2CppSystem.Func<float> __9__229_45
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__229_45, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<float>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__229_45, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static Il2CppSystem.Func<float> __9__229_46
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__229_46, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<float>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__229_46, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static Il2CppSystem.Func<float> __9__229_50
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__229_50, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<float>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__229_50, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static Il2CppSystem.Func<bool> __9__229_60
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__229_60, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__229_60, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static Il2CppSystem.Action<bool> __9__229_61
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__229_61, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__229_61, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static Il2CppSystem.Func<bool> __9__229_62
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__229_62, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__229_62, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static Il2CppSystem.Func<int> __9__229_63
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__229_63, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__229_63, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static Il2CppSystem.Action<int> __9__229_64
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__229_64, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__229_64, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static Il2CppSystem.Func<int> __9__229_65
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__229_65, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__229_65, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static Il2CppSystem.Func<int> __9__229_66
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__229_66, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__229_66, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static Il2CppSystem.Func<Il2CppSystem.Object> __9__229_70
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__229_70, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<Il2CppSystem.Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__229_70, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static Il2CppSystem.Func<int> __9__229_76
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__229_76, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__229_76, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static Il2CppSystem.Action<int> __9__229_77
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__229_77, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__229_77, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static Il2CppSystem.Func<int> __9__229_78
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__229_78, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__229_78, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static Il2CppSystem.Func<float> __9__229_79
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__229_79, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<float>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__229_79, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static Il2CppSystem.Action<float> __9__229_80
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__229_80, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<float>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__229_80, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static Il2CppSystem.Func<float> __9__229_81
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__229_81, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<float>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__229_81, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static Il2CppSystem.Func<float> __9__229_82
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__229_82, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<float>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__229_82, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static Il2CppSystem.Func<float> __9__229_87
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__229_87, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<float>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__229_87, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static Il2CppSystem.Action<float> __9__229_88
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__229_88, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<float>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__229_88, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static Il2CppSystem.Func<float> __9__229_89
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__229_89, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<float>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__229_89, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static Il2CppSystem.Func<float> __9__229_90
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__229_90, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<float>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__229_90, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static BaseRenderFunc<RenderFragmentationOverlayPassData, RenderGraphContext> __9__232_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__232_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BaseRenderFunc<RenderFragmentationOverlayPassData, RenderGraphContext>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__232_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static UnityAction<CellStreamingRequest> __9__293_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__293_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnityAction<CellStreamingRequest>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__293_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__158_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__158_0");
			NativeFieldInfoPtr___9__158_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__158_1");
			NativeFieldInfoPtr___9__229_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__229_1");
			NativeFieldInfoPtr___9__229_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__229_8");
			NativeFieldInfoPtr___9__229_18 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__229_18");
			NativeFieldInfoPtr___9__229_19 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__229_19");
			NativeFieldInfoPtr___9__229_25 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__229_25");
			NativeFieldInfoPtr___9__229_29 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__229_29");
			NativeFieldInfoPtr___9__229_36 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__229_36");
			NativeFieldInfoPtr___9__229_37 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__229_37");
			NativeFieldInfoPtr___9__229_45 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__229_45");
			NativeFieldInfoPtr___9__229_46 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__229_46");
			NativeFieldInfoPtr___9__229_50 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__229_50");
			NativeFieldInfoPtr___9__229_60 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__229_60");
			NativeFieldInfoPtr___9__229_61 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__229_61");
			NativeFieldInfoPtr___9__229_62 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__229_62");
			NativeFieldInfoPtr___9__229_63 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__229_63");
			NativeFieldInfoPtr___9__229_64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__229_64");
			NativeFieldInfoPtr___9__229_65 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__229_65");
			NativeFieldInfoPtr___9__229_66 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__229_66");
			NativeFieldInfoPtr___9__229_70 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__229_70");
			NativeFieldInfoPtr___9__229_76 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__229_76");
			NativeFieldInfoPtr___9__229_77 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__229_77");
			NativeFieldInfoPtr___9__229_78 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__229_78");
			NativeFieldInfoPtr___9__229_79 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__229_79");
			NativeFieldInfoPtr___9__229_80 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__229_80");
			NativeFieldInfoPtr___9__229_81 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__229_81");
			NativeFieldInfoPtr___9__229_82 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__229_82");
			NativeFieldInfoPtr___9__229_87 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__229_87");
			NativeFieldInfoPtr___9__229_88 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__229_88");
			NativeFieldInfoPtr___9__229_89 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__229_89");
			NativeFieldInfoPtr___9__229_90 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__229_90");
			NativeFieldInfoPtr___9__232_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__232_0");
			NativeFieldInfoPtr___9__293_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__293_0");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665700);
			NativeMethodInfoPtr___ctor_b__158_0_Internal_Void_Cell_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665701);
			NativeMethodInfoPtr___ctor_b__158_1_Internal_Void_CellStreamingRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665702);
			NativeMethodInfoPtr__RegisterDebug_b__229_1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665703);
			NativeMethodInfoPtr__RegisterDebug_b__229_8_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665704);
			NativeMethodInfoPtr__RegisterDebug_b__229_18_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665705);
			NativeMethodInfoPtr__RegisterDebug_b__229_19_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665706);
			NativeMethodInfoPtr__RegisterDebug_b__229_25_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665707);
			NativeMethodInfoPtr__RegisterDebug_b__229_29_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665708);
			NativeMethodInfoPtr__RegisterDebug_b__229_36_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665709);
			NativeMethodInfoPtr__RegisterDebug_b__229_37_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665710);
			NativeMethodInfoPtr__RegisterDebug_b__229_45_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665711);
			NativeMethodInfoPtr__RegisterDebug_b__229_46_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665712);
			NativeMethodInfoPtr__RegisterDebug_b__229_50_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665713);
			NativeMethodInfoPtr__RegisterDebug_b__229_60_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665714);
			NativeMethodInfoPtr__RegisterDebug_b__229_61_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665715);
			NativeMethodInfoPtr__RegisterDebug_b__229_62_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665716);
			NativeMethodInfoPtr__RegisterDebug_b__229_63_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665717);
			NativeMethodInfoPtr__RegisterDebug_b__229_64_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665718);
			NativeMethodInfoPtr__RegisterDebug_b__229_65_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665719);
			NativeMethodInfoPtr__RegisterDebug_b__229_66_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665720);
			NativeMethodInfoPtr__RegisterDebug_b__229_70_Internal_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665721);
			NativeMethodInfoPtr__RegisterDebug_b__229_76_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665722);
			NativeMethodInfoPtr__RegisterDebug_b__229_77_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665723);
			NativeMethodInfoPtr__RegisterDebug_b__229_78_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665724);
			NativeMethodInfoPtr__RegisterDebug_b__229_79_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665725);
			NativeMethodInfoPtr__RegisterDebug_b__229_80_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665726);
			NativeMethodInfoPtr__RegisterDebug_b__229_81_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665727);
			NativeMethodInfoPtr__RegisterDebug_b__229_82_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665728);
			NativeMethodInfoPtr__RegisterDebug_b__229_87_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665729);
			NativeMethodInfoPtr__RegisterDebug_b__229_88_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665730);
			NativeMethodInfoPtr__RegisterDebug_b__229_89_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665731);
			NativeMethodInfoPtr__RegisterDebug_b__229_90_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665732);
			NativeMethodInfoPtr__RenderFragmentationOverlay_b__232_0_Internal_Void_RenderFragmentationOverlayPassData_RenderGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665733);
			NativeMethodInfoPtr__CleanupStreaming_b__293_0_Internal_Void_CellStreamingRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665734);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039135, XrefRangeEnd = 1039137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__158_0(Cell x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)x);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___ctor_b__158_0_Internal_Void_Cell_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039137, XrefRangeEnd = 1039140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__158_1(CellStreamingRequest val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___ctor_b__158_1_Internal_Void_CellStreamingRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(143)]
		[CachedScanResults(RefRangeStart = 9, RefRangeEnd = 152, XrefRangeStart = 9, XrefRangeEnd = 152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _RegisterDebug_b__229_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		public unsafe float _RegisterDebug_b__229_8()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_8_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		public unsafe float _RegisterDebug_b__229_18()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_18_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1039140, RefRangeEnd = 1039143, XrefRangeStart = 1039140, XrefRangeEnd = 1039140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float _RegisterDebug_b__229_19()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_19_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(146)]
		[CachedScanResults(RefRangeStart = 35395, RefRangeEnd = 35541, XrefRangeStart = 35395, XrefRangeEnd = 35541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _RegisterDebug_b__229_25()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_25_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(146)]
		[CachedScanResults(RefRangeStart = 35395, RefRangeEnd = 35541, XrefRangeStart = 35395, XrefRangeEnd = 35541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _RegisterDebug_b__229_29()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_29_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		public unsafe float _RegisterDebug_b__229_36()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_36_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1039140, RefRangeEnd = 1039143, XrefRangeStart = 1039140, XrefRangeEnd = 1039143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float _RegisterDebug_b__229_37()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_37_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		public unsafe float _RegisterDebug_b__229_45()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_45_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1039143, RefRangeEnd = 1039145, XrefRangeStart = 1039143, XrefRangeEnd = 1039143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float _RegisterDebug_b__229_46()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_46_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		public unsafe float _RegisterDebug_b__229_50()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_50_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039145, XrefRangeEnd = 1039152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _RegisterDebug_b__229_60()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_60_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039152, XrefRangeEnd = 1039159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _RegisterDebug_b__229_61(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_61_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039159, XrefRangeEnd = 1039166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _RegisterDebug_b__229_62()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_62_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039166, XrefRangeEnd = 1039175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _RegisterDebug_b__229_63()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_63_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039175, XrefRangeEnd = 1039184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _RegisterDebug_b__229_64(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_64_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 63528, RefRangeEnd = 63535, XrefRangeStart = 63528, XrefRangeEnd = 63535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _RegisterDebug_b__229_65()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_65_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		public unsafe int _RegisterDebug_b__229_66()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_66_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039184, XrefRangeEnd = 1039194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppSystem.Object _RegisterDebug_b__229_70()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_70_Internal_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039194, XrefRangeEnd = 1039201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _RegisterDebug_b__229_76()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_76_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039201, XrefRangeEnd = 1039210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _RegisterDebug_b__229_77(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_77_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(146)]
		[CachedScanResults(RefRangeStart = 35395, RefRangeEnd = 35541, XrefRangeStart = 35395, XrefRangeEnd = 35541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _RegisterDebug_b__229_78()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_78_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039210, XrefRangeEnd = 1039217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float _RegisterDebug_b__229_79()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_79_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039217, XrefRangeEnd = 1039226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _RegisterDebug_b__229_80(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_80_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe float _RegisterDebug_b__229_81()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_81_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		public unsafe float _RegisterDebug_b__229_82()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_82_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039226, XrefRangeEnd = 1039235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float _RegisterDebug_b__229_87()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_87_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039235, XrefRangeEnd = 1039244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _RegisterDebug_b__229_88(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_88_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe float _RegisterDebug_b__229_89()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_89_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		public unsafe float _RegisterDebug_b__229_90()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_90_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039244, XrefRangeEnd = 1039259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _RenderFragmentationOverlay_b__232_0(RenderFragmentationOverlayPassData data, RenderGraphContext ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)ctx));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RenderFragmentationOverlay_b__232_0_Internal_Void_RenderFragmentationOverlayPassData_RenderGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _CleanupStreaming_b__293_0(CellStreamingRequest val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__CleanupStreaming_b__293_0_Internal_Void_CellStreamingRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("UnityEngine.Rendering.ProbeReferenceVolume+<>c__DisplayClass324_0")]
	public sealed class __c__DisplayClass324_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_cell;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__HasActiveStreamingRequest_b__0_Internal_Boolean_CellStreamingRequest_0;

		public unsafe Cell cell
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cell);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Cell>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cell)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static __c__DisplayClass324_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass324_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "<>c__DisplayClass324_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass324_0>.NativeClassPtr);
			NativeFieldInfoPtr_cell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass324_0>.NativeClassPtr, "cell");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass324_0>.NativeClassPtr, 100665735);
			NativeMethodInfoPtr__HasActiveStreamingRequest_b__0_Internal_Boolean_CellStreamingRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass324_0>.NativeClassPtr, 100665736);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass324_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass324_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe bool _HasActiveStreamingRequest_b__0(CellStreamingRequest x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)x);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__HasActiveStreamingRequest_b__0_Internal_Boolean_CellStreamingRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public __c__DisplayClass324_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private sealed class MethodInfoStoreGeneric_UpdateDataLocationTexture_Private_Void_Texture_NativeArray_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_UpdateDataLocationTexture_Private_Void_Texture_NativeArray_1_T_0, Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_DebugCellIndexChanged_Private_Void_Field_1_T_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_DebugCellIndexChanged_Private_Void_Field_1_T_T_0, Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_Method_Private_Void_Field_1_T_T_PDM_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Method_Private_Void_Field_1_T_T_PDM_0, Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_m_EmptyIndexBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_IsInitialized;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SupportScenarios;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SupportScenarioBlending;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ForceNoDiskStreaming;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SupportDiskStreaming;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SupportGPUStreaming;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_UseStreamingAssets;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MinBrickSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MaxSubdivision;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ProbeOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Pool;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Index;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CellIndices;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BlendingPool;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TmpSrcChunks;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_PositionOffsets;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CurrGlobalBounds;

	private static readonly System.IntPtr NativeFieldInfoPtr_cells;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CellPool;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TemporaryDataLocation;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TemporaryDataLocationMemCost;

	private static readonly System.IntPtr NativeFieldInfoPtr_sceneData;

	private static readonly System.IntPtr NativeFieldInfoPtr_minLoadedCellPos;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxLoadedCellPos;

	private static readonly System.IntPtr NativeFieldInfoPtr_retrieveExtraDataAction;

	private static readonly System.IntPtr NativeFieldInfoPtr_checksDuringBakeAction;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_PendingScenesToBeLoaded;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_PendingScenesToBeUnloaded;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ActiveScenes;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CurrentBakingSetReference;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LazyBakingSetReference;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_NeedLoadAsset;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ProbeReferenceVolumeInit;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_EnabledBySRP;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_VertexSampling;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_NeedsIndexRebuild;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_HasChangedIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CBShaderID;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MemoryBudget;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BlendingMemoryBudget;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SHBands;

	private static readonly System.IntPtr NativeFieldInfoPtr_clearAssetsOnVolumeClear;

	private static readonly System.IntPtr NativeFieldInfoPtr_defaultLightingScenario;

	private static readonly System.IntPtr NativeFieldInfoPtr__instance;

	private static readonly System.IntPtr NativeFieldInfoPtr__perSceneDataList_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_kProbesPerBatch;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_DebugPanelName;

	private static readonly System.IntPtr NativeFieldInfoPtr__probeVolumeDebug_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__subdivisionDebugColors_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DebugMesh;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DebugItems;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DebugMaterial;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DebugProbeSamplingMesh;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ProbeSamplingDebugMaterial;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ProbeSamplingDebugMaterial02;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DisplayNumbersTexture;

	private static readonly System.IntPtr NativeFieldInfoPtr_probeSamplingDebugData;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DebugOffsetMesh;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DebugOffsetMaterial;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DebugFragmentationMaterial;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DebugFrustumPlanes;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DebugScenarioNames;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DebugScenarioValues;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DebugActiveSceneGUID;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DebugActiveScenario;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DebugScenarioField;

	private static readonly System.IntPtr NativeFieldInfoPtr_realtimeSubdivisionInfo;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MaxSubdivVisualizedIsMaxAvailable;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_BoundsArray;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LoadMaxCellsPerFrame;

	private static readonly System.IntPtr NativeFieldInfoPtr_kMaxCellLoadedPerFrame;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_NumberOfCellsLoadedPerFrame;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_NumberOfCellsBlendedPerFrame;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TurnoverRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LoadedCells;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ToBeLoadedCells;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_WorseLoadedCells;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BestToBeLoadedCells;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TempCellToLoadList;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TempCellToUnloadList;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LoadedBlendingCells;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ToBeLoadedBlendingCells;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TempBlendingCellToLoadList;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TempBlendingCellToUnloadList;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FrozenCameraPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FrozenCameraDirection;

	private static readonly System.IntPtr NativeFieldInfoPtr_kIndexFragmentationThreshold;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_IndexDefragmentationInProgress;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DefragIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DefragCellIndices;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_IndexDefragCells;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TempIndexDefragCells;

	private static readonly System.IntPtr NativeFieldInfoPtr_minStreamingScore;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxStreamingScore;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_StreamingQueue;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ActiveStreamingRequests;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_StreamingRequestsPool;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DiskStreamingUseCompute;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ScratchBufferPool;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_OnStreamingComplete;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_OnBlendingStreamingComplete;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_BlendingComparer;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_DefragComparer;

	private static readonly System.IntPtr NativeMethodInfoPtr_BindAPVRuntimeResources_Public_Void_CommandBuffer_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateShaderVariablesProbeVolumes_Public_Boolean_CommandBuffer_ProbeVolumesOptions_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_globalBounds_Internal_get_Bounds_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_globalBounds_Internal_set_Void_Bounds_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_m_CurrentBakingSet_Private_get_ProbeVolumeBakingSet_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_m_CurrentBakingSet_Private_set_Void_ProbeVolumeBakingSet_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_m_LazyBakingSet_Private_get_ProbeVolumeBakingSet_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_m_LazyBakingSet_Private_set_Void_ProbeVolumeBakingSet_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isInitialized_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_enabledBySRP_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_vertexSampling_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_hasUnloadedCells_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_supportLightingScenarios_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_supportScenarioBlending_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_gpuStreamingEnabled_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_diskStreamingEnabled_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_probeOcclusion_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_skyOcclusion_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_skyOcclusionShadingDirection_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_useRenderingLayers_Private_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_shBands_Public_get_ProbeVolumeSHBands_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_currentBakingSet_Public_get_ProbeVolumeBakingSet_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_lightingScenario_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_lightingScenario_Public_set_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_otherScenario_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_scenarioBlendingFactor_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_scenarioBlendingFactor_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSceneGUID_Internal_Static_String_Scene_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetActiveScenario_Internal_Void_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BlendLightingScenario_Public_Void_String_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_memoryBudget_Public_get_ProbeVolumeTextureMemoryBudget_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_perSceneDataList_Internal_get_List_1_ProbeVolumePerSceneData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_perSceneDataList_Private_set_Void_List_1_ProbeVolumePerSceneData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterPerSceneData_Internal_Void_ProbeVolumePerSceneData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleBakingSet_Internal_Boolean_ProbeVolumeBakingSet_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessScheduledBakingSet_Internal_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetActiveScene_Public_Void_Scene_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetActiveBakingSet_Public_Void_ProbeVolumeBakingSet_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetBakingSetAsCurrent_Private_Void_ProbeVolumeBakingSet_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterBakingSet_Internal_Void_ProbeVolumePerSceneData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnloadBakingSet_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnregisterPerSceneData_Internal_Void_ProbeVolumePerSceneData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGetPerSceneData_Internal_Boolean_String_byref_ProbeVolumePerSceneData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_indexFragmentationRate_Internal_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_instance_Public_Static_get_ProbeReferenceVolume_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Void_byref_ProbeVolumeSystemParameters_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetEnableStateFromSRP_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetVertexSamplingEnabled_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ForceMemoryBudget_Internal_Void_ProbeVolumeTextureMemoryBudget_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ForceSHBand_Internal_Void_ProbeVolumeSHBands_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ForceNoDiskStreaming_Internal_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Cleanup_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetVideoMemoryCost_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveCell_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnloadCell_Internal_Void_Cell_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnloadBlendingCell_Internal_Void_Cell_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnloadAllCells_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnloadAllBlendingCells_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddCell_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadCell_Internal_Boolean_Cell_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadAllCells_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeCellGlobalInfo_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddPendingSceneLoading_Internal_Void_String_ProbeVolumeBakingSet_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddPendingSceneRemoval_Internal_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemovePendingScene_Internal_Void_String_List_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PerformPendingIndexChangeAndInit_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSubdivisionDimensions_Internal_Void_Single_Int32_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadCells_Private_Boolean_List_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PerformPendingLoading_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PerformPendingDeletion_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeEntryMinMax_Internal_Void_byref_IndirectionEntryInfo_ReadOnlySpan_1_Brick_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNumberOfBricksAtSubdiv_Internal_Static_Int32_IndirectionEntryInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PerformPendingOperations_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeGlobalIndirection_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitProbeReferenceVolume_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRuntimeResources_Public_RuntimeResources_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetMaxSubdivision_Internal_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CellSize_Internal_Static_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BrickSize_Internal_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MinBrickSize_Internal_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MaxBrickSize_Internal_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProbeOffset_Internal_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMaxSubdivision_Internal_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMaxSubdivision_Internal_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDistanceBetweenProbes_Internal_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MinDistanceBetweenProbes_Internal_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGlobalIndirectionEntryMaxSubdiv_Internal_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEntrySubdivLevel_Internal_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEntrySize_Internal_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DataHasBeenLoaded_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSourceLocations_Private_List_1_BrickChunkAlloc_Int32_Int32_DataLocation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateDataLocationTexture_Private_Void_Texture_NativeArray_1_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateValidityTextureWithoutMask_Private_Void_Texture_NativeArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdatePool_Private_Void_List_1_BrickChunkAlloc_PerScenarioData_NativeArray_1_Byte_NativeArray_1_UInt16_NativeArray_1_Byte_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdatePool_Private_Void_CommandBuffer_List_1_BrickChunkAlloc_CellStreamingScratchBuffer_CellStreamingScratchBufferLayout_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSharedData_Private_Void_List_1_BrickChunkAlloc_NativeArray_1_Byte_NativeArray_1_UInt16_NativeArray_1_Byte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddBlendingBricks_Private_Boolean_Cell_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReservePoolChunks_Private_Boolean_Int32_List_1_BrickChunkAlloc_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReleasePoolChunks_Private_Void_List_1_BrickChunkAlloc_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdatePoolAndIndex_Private_Void_Cell_CellStreamingScratchBuffer_CellStreamingScratchBufferLayout_Int32_CommandBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddBricks_Private_Boolean_Cell_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateCellIndex_Private_Void_Cell_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReleaseBricks_Private_Void_Cell_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateConstantBuffer_Internal_Void_CommandBuffer_ProbeVolumeShadingParameters_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeinitProbeReferenceVolume_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CleanupLoadedData_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_probeVolumeDebug_Internal_get_ProbeVolumeDebug_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_subdivisionDebugColors_Public_get_Il2CppStructArray_1_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_debugMesh_Private_get_Mesh_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RenderDebug_Public_Void_Camera_Texture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RenderDebug_Public_Void_Camera_ProbeVolumesOptions_Texture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsProbeSamplingDebugEnabled_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetProbeSamplingDebugResources_Public_Boolean_Camera_byref_GraphicsBuffer_byref_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryCreateDebugRenderData_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeDebug_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CleanupDebug_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DebugCellIndexChanged_Private_Void_Field_1_T_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterDebug_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnregisterDebug_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RenderFragmentationOverlay_Public_Void_RenderGraph_TextureHandle_TextureHandle_DebugOverlay_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShouldCullCell_Private_Boolean_Vector3_Transform_Il2CppStructArray_1_Plane_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateDebugFromSelection_Private_Static_Void_byref_Il2CppStructArray_1_Vector4_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCellBounds_Private_Bounds_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShouldCullCell_Private_Boolean_Vector3_Il2CppStructArray_1_Vector4_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawProbeDebug_Private_Void_Camera_Texture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetDebugViewToMaxSubdiv_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearDebugData_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateInstancedProbes_Private_CellInstancedDebugProbes_Cell_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnClearLightingdata_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableMaxCellStreaming_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetNumberOfCellsLoadedPerFrame_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_loadMaxCellsPerFrame_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_loadMaxCellsPerFrame_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_numberOfCellsLoadedPerFrame_Private_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_numberOfCellsBlendedPerFrame_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_numberOfCellsBlendedPerFrame_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_turnoverRate_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_turnoverRate_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitStreaming_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CleanupStreaming_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScenarioBlendingChanged_Internal_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeCellStreamingScore_Private_Static_Void_Cell_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeStreamingScore_Private_Void_Vector3_Vector3_DynamicArray_1_Cell_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeBestToBeLoadedCells_Private_Void_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeStreamingScoreAndWorseLoadedCells_Private_Void_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeBlendingScore_Private_Void_DynamicArray_1_Cell_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryLoadCell_Private_Boolean_Cell_byref_Int32_byref_Int32_DynamicArray_1_Cell_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnloadBlendingCell_Private_Void_Cell_DynamicArray_1_Cell_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryLoadBlendingCell_Private_Boolean_Cell_DynamicArray_1_Cell_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeMinMaxStreamingScore_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateCellStreaming_Public_Void_CommandBuffer_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateCellStreaming_Public_Void_CommandBuffer_Camera_ProbeVolumesOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindWorstBlendingCellToBeLoaded_Private_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BlendingComparer_Private_Static_Int32_Cell_Cell_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateBlendingCellStreaming_Private_Void_CommandBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DefragComparer_Private_Static_Int32_Cell_Cell_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StartIndexDefragmentation_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateIndexDefragmentation_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnStreamingComplete_Private_Void_CellStreamingRequest_CommandBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnBlendingStreamingComplete_Private_Void_CellStreamingRequest_CommandBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PushDiskStreamingRequest_Private_Void_Cell_String_Int32_OnStreamingCompleteDelegate_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CancelStreamingRequest_Private_Void_Cell_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CancelBlendingStreamingRequest_Private_Void_Cell_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessDiskStreamingRequest_Private_Boolean_CellStreamingRequest_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AllocateScratchBufferPoolIfNeeded_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateActiveRequests_Private_Void_CommandBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessNewRequests_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateDiskStreaming_Private_Void_CommandBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasActiveStreamingRequest_Private_Boolean_Cell_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LogStreaming_Private_Void_String_1;

	private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_Void_Field_1_T_T_PDM_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_2_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_3_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_4_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_5_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_6_Private_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_7_Private_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_9_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_10_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_11_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_12_Private_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_13_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_14_Private_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_15_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_16_Private_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_17_Private_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_20_Private_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_21_Private_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_22_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_23_Private_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_24_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_26_Private_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_27_Private_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_28_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_30_Private_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_31_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_32_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_33_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_34_Private_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_35_Private_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_38_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_39_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_40_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_41_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_42_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_43_Private_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_44_Private_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_47_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_48_Private_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_49_Private_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_51_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_52_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_53_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_54_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_55_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_56_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_57_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_58_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_59_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_67_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_68_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_69_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_71_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_72_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_73_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_74_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_83_Private_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_84_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_85_Private_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDebug_b__229_86_Private_Void_Int32_0;

	public unsafe ComputeBuffer m_EmptyIndexBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EmptyIndexBuffer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ComputeBuffer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EmptyIndexBuffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool m_IsInitialized
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IsInitialized);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IsInitialized)) = value;
		}
	}

	public unsafe bool m_SupportScenarios
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SupportScenarios);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SupportScenarios)) = value;
		}
	}

	public unsafe bool m_SupportScenarioBlending
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SupportScenarioBlending);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SupportScenarioBlending)) = value;
		}
	}

	public unsafe bool m_ForceNoDiskStreaming
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ForceNoDiskStreaming);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ForceNoDiskStreaming)) = value;
		}
	}

	public unsafe bool m_SupportDiskStreaming
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SupportDiskStreaming);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SupportDiskStreaming)) = value;
		}
	}

	public unsafe bool m_SupportGPUStreaming
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SupportGPUStreaming);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SupportGPUStreaming)) = value;
		}
	}

	public unsafe bool m_UseStreamingAssets
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UseStreamingAssets);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UseStreamingAssets)) = value;
		}
	}

	public unsafe float m_MinBrickSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MinBrickSize);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MinBrickSize)) = value;
		}
	}

	public unsafe int m_MaxSubdivision
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MaxSubdivision);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MaxSubdivision)) = value;
		}
	}

	public unsafe Vector3 m_ProbeOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ProbeOffset);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ProbeOffset)) = value;
		}
	}

	public unsafe ProbeBrickPool m_Pool
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Pool);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProbeBrickPool>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Pool)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ProbeBrickIndex m_Index
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Index);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProbeBrickIndex>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Index)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ProbeGlobalIndirection m_CellIndices
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CellIndices);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProbeGlobalIndirection>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CellIndices)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ProbeBrickBlendingPool m_BlendingPool
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BlendingPool);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProbeBrickBlendingPool>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BlendingPool)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe List<ProbeBrickPool.BrickChunkAlloc> m_TmpSrcChunks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TmpSrcChunks);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ProbeBrickPool.BrickChunkAlloc>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TmpSrcChunks)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<float> m_PositionOffsets
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PositionOffsets);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PositionOffsets)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Bounds m_CurrGlobalBounds
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrGlobalBounds);
			return *(Bounds*)num;
		}
		set
		{
			*(Bounds*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrGlobalBounds)) = value;
		}
	}

	public unsafe Dictionary<int, Cell> cells
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cells);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, Cell>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cells)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ObjectPool<Cell> m_CellPool
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CellPool);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ObjectPool<Cell>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CellPool)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ProbeBrickPool.DataLocation m_TemporaryDataLocation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TemporaryDataLocation);
			return new ProbeBrickPool.DataLocation(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProbeBrickPool.DataLocation>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TemporaryDataLocation), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ProbeBrickPool.DataLocation>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe int m_TemporaryDataLocationMemCost
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TemporaryDataLocationMemCost);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TemporaryDataLocationMemCost)) = value;
		}
	}

	public unsafe ProbeVolumeSceneData sceneData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sceneData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProbeVolumeSceneData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sceneData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Vector3Int minLoadedCellPos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minLoadedCellPos);
			return *(Vector3Int*)num;
		}
		set
		{
			*(Vector3Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minLoadedCellPos)) = value;
		}
	}

	public unsafe Vector3Int maxLoadedCellPos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxLoadedCellPos);
			return *(Vector3Int*)num;
		}
		set
		{
			*(Vector3Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxLoadedCellPos)) = value;
		}
	}

	public unsafe Il2CppSystem.Action<ExtraDataActionInput> retrieveExtraDataAction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_retrieveExtraDataAction);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<ExtraDataActionInput>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_retrieveExtraDataAction)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppSystem.Action checksDuringBakeAction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_checksDuringBakeAction);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_checksDuringBakeAction)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Dictionary<string, Il2CppSystem.ValueTuple<ProbeVolumeBakingSet, List<int>>> m_PendingScenesToBeLoaded
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PendingScenesToBeLoaded);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, Il2CppSystem.ValueTuple<ProbeVolumeBakingSet, List<int>>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PendingScenesToBeLoaded)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Dictionary<string, List<int>> m_PendingScenesToBeUnloaded
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PendingScenesToBeUnloaded);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, List<int>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PendingScenesToBeUnloaded)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe List<string> m_ActiveScenes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ActiveScenes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ActiveScenes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ProbeVolumeBakingSetWeakReference m_CurrentBakingSetReference
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentBakingSetReference);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProbeVolumeBakingSetWeakReference>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentBakingSetReference)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ProbeVolumeBakingSetWeakReference m_LazyBakingSetReference
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LazyBakingSetReference);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProbeVolumeBakingSetWeakReference>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LazyBakingSetReference)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool m_NeedLoadAsset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_NeedLoadAsset);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_NeedLoadAsset)) = value;
		}
	}

	public unsafe bool m_ProbeReferenceVolumeInit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ProbeReferenceVolumeInit);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ProbeReferenceVolumeInit)) = value;
		}
	}

	public unsafe bool m_EnabledBySRP
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EnabledBySRP);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EnabledBySRP)) = value;
		}
	}

	public unsafe bool m_VertexSampling
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_VertexSampling);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_VertexSampling)) = value;
		}
	}

	public unsafe bool m_NeedsIndexRebuild
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_NeedsIndexRebuild);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_NeedsIndexRebuild)) = value;
		}
	}

	public unsafe bool m_HasChangedIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HasChangedIndex);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HasChangedIndex)) = value;
		}
	}

	public unsafe int m_CBShaderID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CBShaderID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CBShaderID)) = value;
		}
	}

	public unsafe ProbeVolumeTextureMemoryBudget m_MemoryBudget
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MemoryBudget);
			return *(ProbeVolumeTextureMemoryBudget*)num;
		}
		set
		{
			*(ProbeVolumeTextureMemoryBudget*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MemoryBudget)) = value;
		}
	}

	public unsafe ProbeVolumeBlendingTextureMemoryBudget m_BlendingMemoryBudget
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BlendingMemoryBudget);
			return *(ProbeVolumeBlendingTextureMemoryBudget*)num;
		}
		set
		{
			*(ProbeVolumeBlendingTextureMemoryBudget*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BlendingMemoryBudget)) = value;
		}
	}

	public unsafe ProbeVolumeSHBands m_SHBands
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SHBands);
			return *(ProbeVolumeSHBands*)num;
		}
		set
		{
			*(ProbeVolumeSHBands*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SHBands)) = value;
		}
	}

	public unsafe bool clearAssetsOnVolumeClear
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clearAssetsOnVolumeClear);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clearAssetsOnVolumeClear)) = value;
		}
	}

	public unsafe static string defaultLightingScenario
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_defaultLightingScenario, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_defaultLightingScenario, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static ProbeReferenceVolume _instance
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__instance, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProbeReferenceVolume>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe List<ProbeVolumePerSceneData> _perSceneDataList_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__perSceneDataList_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ProbeVolumePerSceneData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__perSceneDataList_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static int kProbesPerBatch
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kProbesPerBatch, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kProbesPerBatch, (void*)(&value));
		}
	}

	public unsafe static string k_DebugPanelName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_DebugPanelName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_DebugPanelName, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe ProbeVolumeDebug _probeVolumeDebug_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__probeVolumeDebug_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProbeVolumeDebug>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__probeVolumeDebug_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<Color> _subdivisionDebugColors_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__subdivisionDebugColors_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__subdivisionDebugColors_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Mesh m_DebugMesh
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DebugMesh);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Mesh>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DebugMesh)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppReferenceArray<DebugUI.Widget> m_DebugItems
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DebugItems);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DebugUI.Widget>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DebugItems)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Material m_DebugMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DebugMaterial);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DebugMaterial)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Mesh m_DebugProbeSamplingMesh
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DebugProbeSamplingMesh);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Mesh>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DebugProbeSamplingMesh)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Material m_ProbeSamplingDebugMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ProbeSamplingDebugMaterial);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ProbeSamplingDebugMaterial)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Material m_ProbeSamplingDebugMaterial02
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ProbeSamplingDebugMaterial02);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ProbeSamplingDebugMaterial02)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Texture m_DisplayNumbersTexture
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DisplayNumbersTexture);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DisplayNumbersTexture)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static ProbeSamplingDebugData probeSamplingDebugData
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_probeSamplingDebugData, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProbeSamplingDebugData>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_probeSamplingDebugData, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Mesh m_DebugOffsetMesh
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DebugOffsetMesh);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Mesh>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DebugOffsetMesh)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Material m_DebugOffsetMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DebugOffsetMaterial);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DebugOffsetMaterial)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Material m_DebugFragmentationMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DebugFragmentationMaterial);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DebugFragmentationMaterial)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<Plane> m_DebugFrustumPlanes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DebugFrustumPlanes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Plane>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DebugFrustumPlanes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppReferenceArray<GUIContent> m_DebugScenarioNames
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DebugScenarioNames);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GUIContent>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DebugScenarioNames)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<int> m_DebugScenarioValues
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DebugScenarioValues);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DebugScenarioValues)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe string m_DebugActiveSceneGUID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DebugActiveSceneGUID);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DebugActiveSceneGUID)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string m_DebugActiveScenario
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DebugActiveScenario);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DebugActiveScenario)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe DebugUI.EnumField m_DebugScenarioField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DebugScenarioField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DebugUI.EnumField>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DebugScenarioField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Dictionary<Bounds, Il2CppStructArray<ProbeBrickIndex.Brick>> realtimeSubdivisionInfo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_realtimeSubdivisionInfo);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Bounds, Il2CppStructArray<ProbeBrickIndex.Brick>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_realtimeSubdivisionInfo)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool m_MaxSubdivVisualizedIsMaxAvailable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MaxSubdivVisualizedIsMaxAvailable);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MaxSubdivVisualizedIsMaxAvailable)) = value;
		}
	}

	public unsafe static Il2CppStructArray<Vector4> s_BoundsArray
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_BoundsArray, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_BoundsArray, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool m_LoadMaxCellsPerFrame
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LoadMaxCellsPerFrame);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LoadMaxCellsPerFrame)) = value;
		}
	}

	public unsafe static int kMaxCellLoadedPerFrame
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kMaxCellLoadedPerFrame, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kMaxCellLoadedPerFrame, (void*)(&value));
		}
	}

	public unsafe int m_NumberOfCellsLoadedPerFrame
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_NumberOfCellsLoadedPerFrame);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_NumberOfCellsLoadedPerFrame)) = value;
		}
	}

	public unsafe int m_NumberOfCellsBlendedPerFrame
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_NumberOfCellsBlendedPerFrame);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_NumberOfCellsBlendedPerFrame)) = value;
		}
	}

	public unsafe float m_TurnoverRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TurnoverRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TurnoverRate)) = value;
		}
	}

	public unsafe DynamicArray<Cell> m_LoadedCells
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LoadedCells);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DynamicArray<Cell>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LoadedCells)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe DynamicArray<Cell> m_ToBeLoadedCells
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ToBeLoadedCells);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DynamicArray<Cell>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ToBeLoadedCells)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe DynamicArray<Cell> m_WorseLoadedCells
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_WorseLoadedCells);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DynamicArray<Cell>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_WorseLoadedCells)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe DynamicArray<Cell> m_BestToBeLoadedCells
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BestToBeLoadedCells);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DynamicArray<Cell>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BestToBeLoadedCells)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe DynamicArray<Cell> m_TempCellToLoadList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TempCellToLoadList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DynamicArray<Cell>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TempCellToLoadList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe DynamicArray<Cell> m_TempCellToUnloadList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TempCellToUnloadList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DynamicArray<Cell>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TempCellToUnloadList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe DynamicArray<Cell> m_LoadedBlendingCells
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LoadedBlendingCells);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DynamicArray<Cell>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LoadedBlendingCells)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe DynamicArray<Cell> m_ToBeLoadedBlendingCells
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ToBeLoadedBlendingCells);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DynamicArray<Cell>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ToBeLoadedBlendingCells)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe DynamicArray<Cell> m_TempBlendingCellToLoadList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TempBlendingCellToLoadList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DynamicArray<Cell>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TempBlendingCellToLoadList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe DynamicArray<Cell> m_TempBlendingCellToUnloadList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TempBlendingCellToUnloadList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DynamicArray<Cell>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TempBlendingCellToUnloadList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Vector3 m_FrozenCameraPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FrozenCameraPosition);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FrozenCameraPosition)) = value;
		}
	}

	public unsafe Vector3 m_FrozenCameraDirection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FrozenCameraDirection);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FrozenCameraDirection)) = value;
		}
	}

	public unsafe static float kIndexFragmentationThreshold
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kIndexFragmentationThreshold, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kIndexFragmentationThreshold, (void*)(&value));
		}
	}

	public unsafe bool m_IndexDefragmentationInProgress
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IndexDefragmentationInProgress);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IndexDefragmentationInProgress)) = value;
		}
	}

	public unsafe ProbeBrickIndex m_DefragIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DefragIndex);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProbeBrickIndex>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DefragIndex)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ProbeGlobalIndirection m_DefragCellIndices
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DefragCellIndices);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProbeGlobalIndirection>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DefragCellIndices)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe DynamicArray<Cell> m_IndexDefragCells
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IndexDefragCells);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DynamicArray<Cell>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IndexDefragCells)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe DynamicArray<Cell> m_TempIndexDefragCells
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TempIndexDefragCells);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DynamicArray<Cell>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TempIndexDefragCells)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe float minStreamingScore
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minStreamingScore);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minStreamingScore)) = value;
		}
	}

	public unsafe float maxStreamingScore
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxStreamingScore);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxStreamingScore)) = value;
		}
	}

	public unsafe Queue<CellStreamingRequest> m_StreamingQueue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StreamingQueue);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Queue<CellStreamingRequest>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StreamingQueue)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe List<CellStreamingRequest> m_ActiveStreamingRequests
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ActiveStreamingRequests);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<CellStreamingRequest>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ActiveStreamingRequests)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ObjectPool<CellStreamingRequest> m_StreamingRequestsPool
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StreamingRequestsPool);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ObjectPool<CellStreamingRequest>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StreamingRequestsPool)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool m_DiskStreamingUseCompute
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DiskStreamingUseCompute);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DiskStreamingUseCompute)) = value;
		}
	}

	public unsafe ProbeVolumeScratchBufferPool m_ScratchBufferPool
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ScratchBufferPool);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProbeVolumeScratchBufferPool>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ScratchBufferPool)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe CellStreamingRequest.OnStreamingCompleteDelegate m_OnStreamingComplete
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OnStreamingComplete);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CellStreamingRequest.OnStreamingCompleteDelegate>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OnStreamingComplete)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe CellStreamingRequest.OnStreamingCompleteDelegate m_OnBlendingStreamingComplete
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OnBlendingStreamingComplete);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CellStreamingRequest.OnStreamingCompleteDelegate>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OnBlendingStreamingComplete)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static DynamicArray<Cell>.SortComparer s_BlendingComparer
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_BlendingComparer, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DynamicArray<Cell>.SortComparer>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_BlendingComparer, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static DynamicArray<Cell>.SortComparer s_DefragComparer
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_DefragComparer, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DynamicArray<Cell>.SortComparer>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_DefragComparer, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Bounds globalBounds
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_globalBounds_Internal_get_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Bounds*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_globalBounds_Internal_set_Void_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe ProbeVolumeBakingSet m_CurrentBakingSet
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039448, XrefRangeEnd = 1039450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_m_CurrentBakingSet_Private_get_ProbeVolumeBakingSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProbeVolumeBakingSet>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039450, XrefRangeEnd = 1039452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_m_CurrentBakingSet_Private_set_Void_ProbeVolumeBakingSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe ProbeVolumeBakingSet m_LazyBakingSet
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039452, XrefRangeEnd = 1039454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_m_LazyBakingSet_Private_get_ProbeVolumeBakingSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProbeVolumeBakingSet>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039454, XrefRangeEnd = 1039456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_m_LazyBakingSet_Private_set_Void_ProbeVolumeBakingSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool isInitialized
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isInitialized_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool enabledBySRP
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_enabledBySRP_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool vertexSampling
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_vertexSampling_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool hasUnloadedCells
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039456, XrefRangeEnd = 1039457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hasUnloadedCells_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool supportLightingScenarios
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_supportLightingScenarios_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool supportScenarioBlending
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_supportScenarioBlending_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool gpuStreamingEnabled
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_gpuStreamingEnabled_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool diskStreamingEnabled
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1039457, RefRangeEnd = 1039458, XrefRangeStart = 1039457, XrefRangeEnd = 1039457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_diskStreamingEnabled_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool probeOcclusion
	{
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1039464, RefRangeEnd = 1039472, XrefRangeStart = 1039458, XrefRangeEnd = 1039464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_probeOcclusion_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool skyOcclusion
	{
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1039479, RefRangeEnd = 1039493, XrefRangeStart = 1039472, XrefRangeEnd = 1039479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_skyOcclusion_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool skyOcclusionShadingDirection
	{
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1039500, RefRangeEnd = 1039510, XrefRangeStart = 1039493, XrefRangeEnd = 1039500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_skyOcclusionShadingDirection_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool useRenderingLayers
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039510, XrefRangeEnd = 1039511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_useRenderingLayers_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe ProbeVolumeSHBands shBands
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_shBands_Public_get_ProbeVolumeSHBands_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(ProbeVolumeSHBands*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe ProbeVolumeBakingSet currentBakingSet
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_currentBakingSet_Public_get_ProbeVolumeBakingSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProbeVolumeBakingSet>(intPtr2) : null;
		}
	}

	public unsafe string lightingScenario
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1039517, RefRangeEnd = 1039522, XrefRangeStart = 1039511, XrefRangeEnd = 1039517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_lightingScenario_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039522, XrefRangeEnd = 1039529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_lightingScenario_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe string otherScenario
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1039535, RefRangeEnd = 1039537, XrefRangeStart = 1039529, XrefRangeEnd = 1039535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_otherScenario_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe float scenarioBlendingFactor
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1039543, RefRangeEnd = 1039550, XrefRangeStart = 1039537, XrefRangeEnd = 1039543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_scenarioBlendingFactor_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1039558, RefRangeEnd = 1039559, XrefRangeStart = 1039550, XrefRangeEnd = 1039558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_scenarioBlendingFactor_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe ProbeVolumeTextureMemoryBudget memoryBudget
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_memoryBudget_Public_get_ProbeVolumeTextureMemoryBudget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(ProbeVolumeTextureMemoryBudget*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe List<ProbeVolumePerSceneData> perSceneDataList
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_perSceneDataList_Internal_get_List_1_ProbeVolumePerSceneData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ProbeVolumePerSceneData>>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_perSceneDataList_Private_set_Void_List_1_ProbeVolumePerSceneData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe float indexFragmentationRate
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1039692, RefRangeEnd = 1039693, XrefRangeStart = 1039692, XrefRangeEnd = 1039692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_indexFragmentationRate_Internal_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static ProbeReferenceVolume instance
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039693, XrefRangeEnd = 1039697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_instance_Public_Static_get_ProbeReferenceVolume_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProbeReferenceVolume>(intPtr2) : null;
		}
	}

	public unsafe ProbeVolumeDebug probeVolumeDebug
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_probeVolumeDebug_Internal_get_ProbeVolumeDebug_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProbeVolumeDebug>(intPtr2) : null;
		}
	}

	public unsafe Il2CppStructArray<Color> subdivisionDebugColors
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_subdivisionDebugColors_Public_get_Il2CppStructArray_1_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr2) : null;
		}
	}

	public unsafe Mesh debugMesh
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1041064, RefRangeEnd = 1041066, XrefRangeStart = 1041052, XrefRangeEnd = 1041064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_debugMesh_Private_get_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
		}
	}

	public unsafe bool loadMaxCellsPerFrame
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_loadMaxCellsPerFrame_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
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
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_loadMaxCellsPerFrame_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int numberOfCellsLoadedPerFrame
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1042930, RefRangeEnd = 1042935, XrefRangeStart = 1042927, XrefRangeEnd = 1042930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_numberOfCellsLoadedPerFrame_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int numberOfCellsBlendedPerFrame
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_numberOfCellsBlendedPerFrame_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1042935, RefRangeEnd = 1042936, XrefRangeStart = 1042935, XrefRangeEnd = 1042935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_numberOfCellsBlendedPerFrame_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe float turnoverRate
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_turnoverRate_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1042936, RefRangeEnd = 1042937, XrefRangeStart = 1042936, XrefRangeEnd = 1042936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_turnoverRate_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static ProbeReferenceVolume()
	{
		Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "ProbeReferenceVolume");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr);
		NativeFieldInfoPtr_m_EmptyIndexBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_EmptyIndexBuffer");
		NativeFieldInfoPtr_m_IsInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_IsInitialized");
		NativeFieldInfoPtr_m_SupportScenarios = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_SupportScenarios");
		NativeFieldInfoPtr_m_SupportScenarioBlending = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_SupportScenarioBlending");
		NativeFieldInfoPtr_m_ForceNoDiskStreaming = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_ForceNoDiskStreaming");
		NativeFieldInfoPtr_m_SupportDiskStreaming = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_SupportDiskStreaming");
		NativeFieldInfoPtr_m_SupportGPUStreaming = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_SupportGPUStreaming");
		NativeFieldInfoPtr_m_UseStreamingAssets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_UseStreamingAssets");
		NativeFieldInfoPtr_m_MinBrickSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_MinBrickSize");
		NativeFieldInfoPtr_m_MaxSubdivision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_MaxSubdivision");
		NativeFieldInfoPtr_m_ProbeOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_ProbeOffset");
		NativeFieldInfoPtr_m_Pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_Pool");
		NativeFieldInfoPtr_m_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_Index");
		NativeFieldInfoPtr_m_CellIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_CellIndices");
		NativeFieldInfoPtr_m_BlendingPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_BlendingPool");
		NativeFieldInfoPtr_m_TmpSrcChunks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_TmpSrcChunks");
		NativeFieldInfoPtr_m_PositionOffsets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_PositionOffsets");
		NativeFieldInfoPtr_m_CurrGlobalBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_CurrGlobalBounds");
		NativeFieldInfoPtr_cells = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "cells");
		NativeFieldInfoPtr_m_CellPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_CellPool");
		NativeFieldInfoPtr_m_TemporaryDataLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_TemporaryDataLocation");
		NativeFieldInfoPtr_m_TemporaryDataLocationMemCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_TemporaryDataLocationMemCost");
		NativeFieldInfoPtr_sceneData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "sceneData");
		NativeFieldInfoPtr_minLoadedCellPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "minLoadedCellPos");
		NativeFieldInfoPtr_maxLoadedCellPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "maxLoadedCellPos");
		NativeFieldInfoPtr_retrieveExtraDataAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "retrieveExtraDataAction");
		NativeFieldInfoPtr_checksDuringBakeAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "checksDuringBakeAction");
		NativeFieldInfoPtr_m_PendingScenesToBeLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_PendingScenesToBeLoaded");
		NativeFieldInfoPtr_m_PendingScenesToBeUnloaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_PendingScenesToBeUnloaded");
		NativeFieldInfoPtr_m_ActiveScenes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_ActiveScenes");
		NativeFieldInfoPtr_m_CurrentBakingSetReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_CurrentBakingSetReference");
		NativeFieldInfoPtr_m_LazyBakingSetReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_LazyBakingSetReference");
		NativeFieldInfoPtr_m_NeedLoadAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_NeedLoadAsset");
		NativeFieldInfoPtr_m_ProbeReferenceVolumeInit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_ProbeReferenceVolumeInit");
		NativeFieldInfoPtr_m_EnabledBySRP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_EnabledBySRP");
		NativeFieldInfoPtr_m_VertexSampling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_VertexSampling");
		NativeFieldInfoPtr_m_NeedsIndexRebuild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_NeedsIndexRebuild");
		NativeFieldInfoPtr_m_HasChangedIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_HasChangedIndex");
		NativeFieldInfoPtr_m_CBShaderID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_CBShaderID");
		NativeFieldInfoPtr_m_MemoryBudget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_MemoryBudget");
		NativeFieldInfoPtr_m_BlendingMemoryBudget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_BlendingMemoryBudget");
		NativeFieldInfoPtr_m_SHBands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_SHBands");
		NativeFieldInfoPtr_clearAssetsOnVolumeClear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "clearAssetsOnVolumeClear");
		NativeFieldInfoPtr_defaultLightingScenario = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "defaultLightingScenario");
		NativeFieldInfoPtr__instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "_instance");
		NativeFieldInfoPtr__perSceneDataList_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "<perSceneDataList>k__BackingField");
		NativeFieldInfoPtr_kProbesPerBatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "kProbesPerBatch");
		NativeFieldInfoPtr_k_DebugPanelName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "k_DebugPanelName");
		NativeFieldInfoPtr__probeVolumeDebug_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "<probeVolumeDebug>k__BackingField");
		NativeFieldInfoPtr__subdivisionDebugColors_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "<subdivisionDebugColors>k__BackingField");
		NativeFieldInfoPtr_m_DebugMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_DebugMesh");
		NativeFieldInfoPtr_m_DebugItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_DebugItems");
		NativeFieldInfoPtr_m_DebugMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_DebugMaterial");
		NativeFieldInfoPtr_m_DebugProbeSamplingMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_DebugProbeSamplingMesh");
		NativeFieldInfoPtr_m_ProbeSamplingDebugMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_ProbeSamplingDebugMaterial");
		NativeFieldInfoPtr_m_ProbeSamplingDebugMaterial02 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_ProbeSamplingDebugMaterial02");
		NativeFieldInfoPtr_m_DisplayNumbersTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_DisplayNumbersTexture");
		NativeFieldInfoPtr_probeSamplingDebugData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "probeSamplingDebugData");
		NativeFieldInfoPtr_m_DebugOffsetMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_DebugOffsetMesh");
		NativeFieldInfoPtr_m_DebugOffsetMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_DebugOffsetMaterial");
		NativeFieldInfoPtr_m_DebugFragmentationMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_DebugFragmentationMaterial");
		NativeFieldInfoPtr_m_DebugFrustumPlanes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_DebugFrustumPlanes");
		NativeFieldInfoPtr_m_DebugScenarioNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_DebugScenarioNames");
		NativeFieldInfoPtr_m_DebugScenarioValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_DebugScenarioValues");
		NativeFieldInfoPtr_m_DebugActiveSceneGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_DebugActiveSceneGUID");
		NativeFieldInfoPtr_m_DebugActiveScenario = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_DebugActiveScenario");
		NativeFieldInfoPtr_m_DebugScenarioField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_DebugScenarioField");
		NativeFieldInfoPtr_realtimeSubdivisionInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "realtimeSubdivisionInfo");
		NativeFieldInfoPtr_m_MaxSubdivVisualizedIsMaxAvailable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_MaxSubdivVisualizedIsMaxAvailable");
		NativeFieldInfoPtr_s_BoundsArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "s_BoundsArray");
		NativeFieldInfoPtr_m_LoadMaxCellsPerFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_LoadMaxCellsPerFrame");
		NativeFieldInfoPtr_kMaxCellLoadedPerFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "kMaxCellLoadedPerFrame");
		NativeFieldInfoPtr_m_NumberOfCellsLoadedPerFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_NumberOfCellsLoadedPerFrame");
		NativeFieldInfoPtr_m_NumberOfCellsBlendedPerFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_NumberOfCellsBlendedPerFrame");
		NativeFieldInfoPtr_m_TurnoverRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_TurnoverRate");
		NativeFieldInfoPtr_m_LoadedCells = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_LoadedCells");
		NativeFieldInfoPtr_m_ToBeLoadedCells = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_ToBeLoadedCells");
		NativeFieldInfoPtr_m_WorseLoadedCells = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_WorseLoadedCells");
		NativeFieldInfoPtr_m_BestToBeLoadedCells = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_BestToBeLoadedCells");
		NativeFieldInfoPtr_m_TempCellToLoadList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_TempCellToLoadList");
		NativeFieldInfoPtr_m_TempCellToUnloadList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_TempCellToUnloadList");
		NativeFieldInfoPtr_m_LoadedBlendingCells = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_LoadedBlendingCells");
		NativeFieldInfoPtr_m_ToBeLoadedBlendingCells = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_ToBeLoadedBlendingCells");
		NativeFieldInfoPtr_m_TempBlendingCellToLoadList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_TempBlendingCellToLoadList");
		NativeFieldInfoPtr_m_TempBlendingCellToUnloadList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_TempBlendingCellToUnloadList");
		NativeFieldInfoPtr_m_FrozenCameraPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_FrozenCameraPosition");
		NativeFieldInfoPtr_m_FrozenCameraDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_FrozenCameraDirection");
		NativeFieldInfoPtr_kIndexFragmentationThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "kIndexFragmentationThreshold");
		NativeFieldInfoPtr_m_IndexDefragmentationInProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_IndexDefragmentationInProgress");
		NativeFieldInfoPtr_m_DefragIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_DefragIndex");
		NativeFieldInfoPtr_m_DefragCellIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_DefragCellIndices");
		NativeFieldInfoPtr_m_IndexDefragCells = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_IndexDefragCells");
		NativeFieldInfoPtr_m_TempIndexDefragCells = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_TempIndexDefragCells");
		NativeFieldInfoPtr_minStreamingScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "minStreamingScore");
		NativeFieldInfoPtr_maxStreamingScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "maxStreamingScore");
		NativeFieldInfoPtr_m_StreamingQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_StreamingQueue");
		NativeFieldInfoPtr_m_ActiveStreamingRequests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_ActiveStreamingRequests");
		NativeFieldInfoPtr_m_StreamingRequestsPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_StreamingRequestsPool");
		NativeFieldInfoPtr_m_DiskStreamingUseCompute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_DiskStreamingUseCompute");
		NativeFieldInfoPtr_m_ScratchBufferPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_ScratchBufferPool");
		NativeFieldInfoPtr_m_OnStreamingComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_OnStreamingComplete");
		NativeFieldInfoPtr_m_OnBlendingStreamingComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "m_OnBlendingStreamingComplete");
		NativeFieldInfoPtr_s_BlendingComparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "s_BlendingComparer");
		NativeFieldInfoPtr_s_DefragComparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, "s_DefragComparer");
		NativeMethodInfoPtr_BindAPVRuntimeResources_Public_Void_CommandBuffer_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665371);
		NativeMethodInfoPtr_UpdateShaderVariablesProbeVolumes_Public_Boolean_CommandBuffer_ProbeVolumesOptions_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665372);
		NativeMethodInfoPtr_get_globalBounds_Internal_get_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665373);
		NativeMethodInfoPtr_set_globalBounds_Internal_set_Void_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665374);
		NativeMethodInfoPtr_get_m_CurrentBakingSet_Private_get_ProbeVolumeBakingSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665375);
		NativeMethodInfoPtr_set_m_CurrentBakingSet_Private_set_Void_ProbeVolumeBakingSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665376);
		NativeMethodInfoPtr_get_m_LazyBakingSet_Private_get_ProbeVolumeBakingSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665377);
		NativeMethodInfoPtr_set_m_LazyBakingSet_Private_set_Void_ProbeVolumeBakingSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665378);
		NativeMethodInfoPtr_get_isInitialized_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665379);
		NativeMethodInfoPtr_get_enabledBySRP_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665380);
		NativeMethodInfoPtr_get_vertexSampling_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665381);
		NativeMethodInfoPtr_get_hasUnloadedCells_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665382);
		NativeMethodInfoPtr_get_supportLightingScenarios_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665383);
		NativeMethodInfoPtr_get_supportScenarioBlending_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665384);
		NativeMethodInfoPtr_get_gpuStreamingEnabled_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665385);
		NativeMethodInfoPtr_get_diskStreamingEnabled_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665386);
		NativeMethodInfoPtr_get_probeOcclusion_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665387);
		NativeMethodInfoPtr_get_skyOcclusion_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665388);
		NativeMethodInfoPtr_get_skyOcclusionShadingDirection_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665389);
		NativeMethodInfoPtr_get_useRenderingLayers_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665390);
		NativeMethodInfoPtr_get_shBands_Public_get_ProbeVolumeSHBands_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665391);
		NativeMethodInfoPtr_get_currentBakingSet_Public_get_ProbeVolumeBakingSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665392);
		NativeMethodInfoPtr_get_lightingScenario_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665393);
		NativeMethodInfoPtr_set_lightingScenario_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665394);
		NativeMethodInfoPtr_get_otherScenario_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665395);
		NativeMethodInfoPtr_get_scenarioBlendingFactor_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665396);
		NativeMethodInfoPtr_set_scenarioBlendingFactor_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665397);
		NativeMethodInfoPtr_GetSceneGUID_Internal_Static_String_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665398);
		NativeMethodInfoPtr_SetActiveScenario_Internal_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665399);
		NativeMethodInfoPtr_BlendLightingScenario_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665400);
		NativeMethodInfoPtr_get_memoryBudget_Public_get_ProbeVolumeTextureMemoryBudget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665401);
		NativeMethodInfoPtr_get_perSceneDataList_Internal_get_List_1_ProbeVolumePerSceneData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665402);
		NativeMethodInfoPtr_set_perSceneDataList_Private_set_Void_List_1_ProbeVolumePerSceneData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665403);
		NativeMethodInfoPtr_RegisterPerSceneData_Internal_Void_ProbeVolumePerSceneData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665404);
		NativeMethodInfoPtr_ScheduleBakingSet_Internal_Boolean_ProbeVolumeBakingSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665405);
		NativeMethodInfoPtr_ProcessScheduledBakingSet_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665406);
		NativeMethodInfoPtr_SetActiveScene_Public_Void_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665407);
		NativeMethodInfoPtr_SetActiveBakingSet_Public_Void_ProbeVolumeBakingSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665408);
		NativeMethodInfoPtr_SetBakingSetAsCurrent_Private_Void_ProbeVolumeBakingSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665409);
		NativeMethodInfoPtr_RegisterBakingSet_Internal_Void_ProbeVolumePerSceneData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665410);
		NativeMethodInfoPtr_UnloadBakingSet_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665411);
		NativeMethodInfoPtr_UnregisterPerSceneData_Internal_Void_ProbeVolumePerSceneData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665412);
		NativeMethodInfoPtr_TryGetPerSceneData_Internal_Boolean_String_byref_ProbeVolumePerSceneData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665413);
		NativeMethodInfoPtr_get_indexFragmentationRate_Internal_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665414);
		NativeMethodInfoPtr_get_instance_Public_Static_get_ProbeReferenceVolume_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665415);
		NativeMethodInfoPtr_Initialize_Public_Void_byref_ProbeVolumeSystemParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665416);
		NativeMethodInfoPtr_SetEnableStateFromSRP_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665417);
		NativeMethodInfoPtr_SetVertexSamplingEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665418);
		NativeMethodInfoPtr_ForceMemoryBudget_Internal_Void_ProbeVolumeTextureMemoryBudget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665419);
		NativeMethodInfoPtr_ForceSHBand_Internal_Void_ProbeVolumeSHBands_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665420);
		NativeMethodInfoPtr_ForceNoDiskStreaming_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665421);
		NativeMethodInfoPtr_Cleanup_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665422);
		NativeMethodInfoPtr_GetVideoMemoryCost_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665423);
		NativeMethodInfoPtr_RemoveCell_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665424);
		NativeMethodInfoPtr_UnloadCell_Internal_Void_Cell_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665425);
		NativeMethodInfoPtr_UnloadBlendingCell_Internal_Void_Cell_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665426);
		NativeMethodInfoPtr_UnloadAllCells_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665427);
		NativeMethodInfoPtr_UnloadAllBlendingCells_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665428);
		NativeMethodInfoPtr_AddCell_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665429);
		NativeMethodInfoPtr_LoadCell_Internal_Boolean_Cell_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665430);
		NativeMethodInfoPtr_LoadAllCells_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665431);
		NativeMethodInfoPtr_ComputeCellGlobalInfo_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665432);
		NativeMethodInfoPtr_AddPendingSceneLoading_Internal_Void_String_ProbeVolumeBakingSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665433);
		NativeMethodInfoPtr_AddPendingSceneRemoval_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665434);
		NativeMethodInfoPtr_RemovePendingScene_Internal_Void_String_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665435);
		NativeMethodInfoPtr_PerformPendingIndexChangeAndInit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665436);
		NativeMethodInfoPtr_SetSubdivisionDimensions_Internal_Void_Single_Int32_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665437);
		NativeMethodInfoPtr_LoadCells_Private_Boolean_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665438);
		NativeMethodInfoPtr_PerformPendingLoading_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665439);
		NativeMethodInfoPtr_PerformPendingDeletion_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665440);
		NativeMethodInfoPtr_ComputeEntryMinMax_Internal_Void_byref_IndirectionEntryInfo_ReadOnlySpan_1_Brick_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665441);
		NativeMethodInfoPtr_GetNumberOfBricksAtSubdiv_Internal_Static_Int32_IndirectionEntryInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665442);
		NativeMethodInfoPtr_PerformPendingOperations_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665443);
		NativeMethodInfoPtr_InitializeGlobalIndirection_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665444);
		NativeMethodInfoPtr_InitProbeReferenceVolume_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665445);
		NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665446);
		NativeMethodInfoPtr_GetRuntimeResources_Public_RuntimeResources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665447);
		NativeMethodInfoPtr_SetMaxSubdivision_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665448);
		NativeMethodInfoPtr_CellSize_Internal_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665449);
		NativeMethodInfoPtr_BrickSize_Internal_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665450);
		NativeMethodInfoPtr_MinBrickSize_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665451);
		NativeMethodInfoPtr_MaxBrickSize_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665452);
		NativeMethodInfoPtr_ProbeOffset_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665453);
		NativeMethodInfoPtr_GetMaxSubdivision_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665454);
		NativeMethodInfoPtr_GetMaxSubdivision_Internal_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665455);
		NativeMethodInfoPtr_GetDistanceBetweenProbes_Internal_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665456);
		NativeMethodInfoPtr_MinDistanceBetweenProbes_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665457);
		NativeMethodInfoPtr_GetGlobalIndirectionEntryMaxSubdiv_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665458);
		NativeMethodInfoPtr_GetEntrySubdivLevel_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665459);
		NativeMethodInfoPtr_GetEntrySize_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665460);
		NativeMethodInfoPtr_DataHasBeenLoaded_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665461);
		NativeMethodInfoPtr_Clear_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665462);
		NativeMethodInfoPtr_GetSourceLocations_Private_List_1_BrickChunkAlloc_Int32_Int32_DataLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665463);
		NativeMethodInfoPtr_UpdateDataLocationTexture_Private_Void_Texture_NativeArray_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665464);
		NativeMethodInfoPtr_UpdateValidityTextureWithoutMask_Private_Void_Texture_NativeArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665465);
		NativeMethodInfoPtr_UpdatePool_Private_Void_List_1_BrickChunkAlloc_PerScenarioData_NativeArray_1_Byte_NativeArray_1_UInt16_NativeArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665466);
		NativeMethodInfoPtr_UpdatePool_Private_Void_CommandBuffer_List_1_BrickChunkAlloc_CellStreamingScratchBuffer_CellStreamingScratchBufferLayout_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665467);
		NativeMethodInfoPtr_UpdateSharedData_Private_Void_List_1_BrickChunkAlloc_NativeArray_1_Byte_NativeArray_1_UInt16_NativeArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665468);
		NativeMethodInfoPtr_AddBlendingBricks_Private_Boolean_Cell_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665469);
		NativeMethodInfoPtr_ReservePoolChunks_Private_Boolean_Int32_List_1_BrickChunkAlloc_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665470);
		NativeMethodInfoPtr_ReleasePoolChunks_Private_Void_List_1_BrickChunkAlloc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665471);
		NativeMethodInfoPtr_UpdatePoolAndIndex_Private_Void_Cell_CellStreamingScratchBuffer_CellStreamingScratchBufferLayout_Int32_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665472);
		NativeMethodInfoPtr_AddBricks_Private_Boolean_Cell_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665473);
		NativeMethodInfoPtr_UpdateCellIndex_Private_Void_Cell_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665474);
		NativeMethodInfoPtr_ReleaseBricks_Private_Void_Cell_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665475);
		NativeMethodInfoPtr_UpdateConstantBuffer_Internal_Void_CommandBuffer_ProbeVolumeShadingParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665476);
		NativeMethodInfoPtr_DeinitProbeReferenceVolume_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665477);
		NativeMethodInfoPtr_CleanupLoadedData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665478);
		NativeMethodInfoPtr_get_probeVolumeDebug_Internal_get_ProbeVolumeDebug_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665479);
		NativeMethodInfoPtr_get_subdivisionDebugColors_Public_get_Il2CppStructArray_1_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665480);
		NativeMethodInfoPtr_get_debugMesh_Private_get_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665481);
		NativeMethodInfoPtr_RenderDebug_Public_Void_Camera_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665482);
		NativeMethodInfoPtr_RenderDebug_Public_Void_Camera_ProbeVolumesOptions_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665483);
		NativeMethodInfoPtr_IsProbeSamplingDebugEnabled_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665484);
		NativeMethodInfoPtr_GetProbeSamplingDebugResources_Public_Boolean_Camera_byref_GraphicsBuffer_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665485);
		NativeMethodInfoPtr_TryCreateDebugRenderData_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665486);
		NativeMethodInfoPtr_InitializeDebug_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665487);
		NativeMethodInfoPtr_CleanupDebug_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665488);
		NativeMethodInfoPtr_DebugCellIndexChanged_Private_Void_Field_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665489);
		NativeMethodInfoPtr_RegisterDebug_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665490);
		NativeMethodInfoPtr_UnregisterDebug_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665491);
		NativeMethodInfoPtr_RenderFragmentationOverlay_Public_Void_RenderGraph_TextureHandle_TextureHandle_DebugOverlay_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665492);
		NativeMethodInfoPtr_ShouldCullCell_Private_Boolean_Vector3_Transform_Il2CppStructArray_1_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665493);
		NativeMethodInfoPtr_UpdateDebugFromSelection_Private_Static_Void_byref_Il2CppStructArray_1_Vector4_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665494);
		NativeMethodInfoPtr_GetCellBounds_Private_Bounds_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665495);
		NativeMethodInfoPtr_ShouldCullCell_Private_Boolean_Vector3_Il2CppStructArray_1_Vector4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665496);
		NativeMethodInfoPtr_DrawProbeDebug_Private_Void_Camera_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665497);
		NativeMethodInfoPtr_ResetDebugViewToMaxSubdiv_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665498);
		NativeMethodInfoPtr_ClearDebugData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665499);
		NativeMethodInfoPtr_CreateInstancedProbes_Private_CellInstancedDebugProbes_Cell_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665500);
		NativeMethodInfoPtr_OnClearLightingdata_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665501);
		NativeMethodInfoPtr_EnableMaxCellStreaming_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665502);
		NativeMethodInfoPtr_SetNumberOfCellsLoadedPerFrame_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665503);
		NativeMethodInfoPtr_get_loadMaxCellsPerFrame_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665504);
		NativeMethodInfoPtr_set_loadMaxCellsPerFrame_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665505);
		NativeMethodInfoPtr_get_numberOfCellsLoadedPerFrame_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665506);
		NativeMethodInfoPtr_get_numberOfCellsBlendedPerFrame_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665507);
		NativeMethodInfoPtr_set_numberOfCellsBlendedPerFrame_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665508);
		NativeMethodInfoPtr_get_turnoverRate_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665509);
		NativeMethodInfoPtr_set_turnoverRate_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665510);
		NativeMethodInfoPtr_InitStreaming_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665511);
		NativeMethodInfoPtr_CleanupStreaming_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665512);
		NativeMethodInfoPtr_ScenarioBlendingChanged_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665513);
		NativeMethodInfoPtr_ComputeCellStreamingScore_Private_Static_Void_Cell_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665514);
		NativeMethodInfoPtr_ComputeStreamingScore_Private_Void_Vector3_Vector3_DynamicArray_1_Cell_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665515);
		NativeMethodInfoPtr_ComputeBestToBeLoadedCells_Private_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665516);
		NativeMethodInfoPtr_ComputeStreamingScoreAndWorseLoadedCells_Private_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665517);
		NativeMethodInfoPtr_ComputeBlendingScore_Private_Void_DynamicArray_1_Cell_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665518);
		NativeMethodInfoPtr_TryLoadCell_Private_Boolean_Cell_byref_Int32_byref_Int32_DynamicArray_1_Cell_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665519);
		NativeMethodInfoPtr_UnloadBlendingCell_Private_Void_Cell_DynamicArray_1_Cell_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665520);
		NativeMethodInfoPtr_TryLoadBlendingCell_Private_Boolean_Cell_DynamicArray_1_Cell_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665521);
		NativeMethodInfoPtr_ComputeMinMaxStreamingScore_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665522);
		NativeMethodInfoPtr_UpdateCellStreaming_Public_Void_CommandBuffer_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665523);
		NativeMethodInfoPtr_UpdateCellStreaming_Public_Void_CommandBuffer_Camera_ProbeVolumesOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665524);
		NativeMethodInfoPtr_FindWorstBlendingCellToBeLoaded_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665525);
		NativeMethodInfoPtr_BlendingComparer_Private_Static_Int32_Cell_Cell_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665526);
		NativeMethodInfoPtr_UpdateBlendingCellStreaming_Private_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665527);
		NativeMethodInfoPtr_DefragComparer_Private_Static_Int32_Cell_Cell_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665528);
		NativeMethodInfoPtr_StartIndexDefragmentation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665529);
		NativeMethodInfoPtr_UpdateIndexDefragmentation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665530);
		NativeMethodInfoPtr_OnStreamingComplete_Private_Void_CellStreamingRequest_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665531);
		NativeMethodInfoPtr_OnBlendingStreamingComplete_Private_Void_CellStreamingRequest_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665532);
		NativeMethodInfoPtr_PushDiskStreamingRequest_Private_Void_Cell_String_Int32_OnStreamingCompleteDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665533);
		NativeMethodInfoPtr_CancelStreamingRequest_Private_Void_Cell_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665534);
		NativeMethodInfoPtr_CancelBlendingStreamingRequest_Private_Void_Cell_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665535);
		NativeMethodInfoPtr_ProcessDiskStreamingRequest_Private_Boolean_CellStreamingRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665536);
		NativeMethodInfoPtr_AllocateScratchBufferPoolIfNeeded_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665537);
		NativeMethodInfoPtr_UpdateActiveRequests_Private_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665538);
		NativeMethodInfoPtr_ProcessNewRequests_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665539);
		NativeMethodInfoPtr_UpdateDiskStreaming_Private_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665540);
		NativeMethodInfoPtr_HasActiveStreamingRequest_Private_Boolean_Cell_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665541);
		NativeMethodInfoPtr_LogStreaming_Private_Void_String_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665542);
		NativeMethodInfoPtr_Method_Private_Void_Field_1_T_T_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665544);
		NativeMethodInfoPtr__RegisterDebug_b__229_2_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665545);
		NativeMethodInfoPtr__RegisterDebug_b__229_3_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665546);
		NativeMethodInfoPtr__RegisterDebug_b__229_4_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665547);
		NativeMethodInfoPtr__RegisterDebug_b__229_5_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665548);
		NativeMethodInfoPtr__RegisterDebug_b__229_6_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665549);
		NativeMethodInfoPtr__RegisterDebug_b__229_7_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665550);
		NativeMethodInfoPtr__RegisterDebug_b__229_9_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665551);
		NativeMethodInfoPtr__RegisterDebug_b__229_10_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665552);
		NativeMethodInfoPtr__RegisterDebug_b__229_11_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665553);
		NativeMethodInfoPtr__RegisterDebug_b__229_12_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665554);
		NativeMethodInfoPtr__RegisterDebug_b__229_13_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665555);
		NativeMethodInfoPtr__RegisterDebug_b__229_14_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665556);
		NativeMethodInfoPtr__RegisterDebug_b__229_15_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665557);
		NativeMethodInfoPtr__RegisterDebug_b__229_16_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665558);
		NativeMethodInfoPtr__RegisterDebug_b__229_17_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665559);
		NativeMethodInfoPtr__RegisterDebug_b__229_20_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665560);
		NativeMethodInfoPtr__RegisterDebug_b__229_21_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665561);
		NativeMethodInfoPtr__RegisterDebug_b__229_22_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665562);
		NativeMethodInfoPtr__RegisterDebug_b__229_23_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665563);
		NativeMethodInfoPtr__RegisterDebug_b__229_24_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665564);
		NativeMethodInfoPtr__RegisterDebug_b__229_26_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665565);
		NativeMethodInfoPtr__RegisterDebug_b__229_27_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665566);
		NativeMethodInfoPtr__RegisterDebug_b__229_28_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665567);
		NativeMethodInfoPtr__RegisterDebug_b__229_30_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665568);
		NativeMethodInfoPtr__RegisterDebug_b__229_31_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665569);
		NativeMethodInfoPtr__RegisterDebug_b__229_32_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665570);
		NativeMethodInfoPtr__RegisterDebug_b__229_33_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665571);
		NativeMethodInfoPtr__RegisterDebug_b__229_34_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665572);
		NativeMethodInfoPtr__RegisterDebug_b__229_35_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665573);
		NativeMethodInfoPtr__RegisterDebug_b__229_38_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665574);
		NativeMethodInfoPtr__RegisterDebug_b__229_39_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665575);
		NativeMethodInfoPtr__RegisterDebug_b__229_40_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665576);
		NativeMethodInfoPtr__RegisterDebug_b__229_41_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665577);
		NativeMethodInfoPtr__RegisterDebug_b__229_42_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665578);
		NativeMethodInfoPtr__RegisterDebug_b__229_43_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665579);
		NativeMethodInfoPtr__RegisterDebug_b__229_44_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665580);
		NativeMethodInfoPtr__RegisterDebug_b__229_47_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665581);
		NativeMethodInfoPtr__RegisterDebug_b__229_48_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665582);
		NativeMethodInfoPtr__RegisterDebug_b__229_49_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665583);
		NativeMethodInfoPtr__RegisterDebug_b__229_51_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665584);
		NativeMethodInfoPtr__RegisterDebug_b__229_52_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665585);
		NativeMethodInfoPtr__RegisterDebug_b__229_53_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665586);
		NativeMethodInfoPtr__RegisterDebug_b__229_54_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665587);
		NativeMethodInfoPtr__RegisterDebug_b__229_55_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665588);
		NativeMethodInfoPtr__RegisterDebug_b__229_56_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665589);
		NativeMethodInfoPtr__RegisterDebug_b__229_57_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665590);
		NativeMethodInfoPtr__RegisterDebug_b__229_58_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665591);
		NativeMethodInfoPtr__RegisterDebug_b__229_59_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665592);
		NativeMethodInfoPtr__RegisterDebug_b__229_67_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665593);
		NativeMethodInfoPtr__RegisterDebug_b__229_68_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665594);
		NativeMethodInfoPtr__RegisterDebug_b__229_69_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665595);
		NativeMethodInfoPtr__RegisterDebug_b__229_71_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665596);
		NativeMethodInfoPtr__RegisterDebug_b__229_72_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665597);
		NativeMethodInfoPtr__RegisterDebug_b__229_73_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665598);
		NativeMethodInfoPtr__RegisterDebug_b__229_74_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665599);
		NativeMethodInfoPtr_Method_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665600);
		NativeMethodInfoPtr__RegisterDebug_b__229_83_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665601);
		NativeMethodInfoPtr__RegisterDebug_b__229_84_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665602);
		NativeMethodInfoPtr__RegisterDebug_b__229_85_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665603);
		NativeMethodInfoPtr__RegisterDebug_b__229_86_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr, 100665604);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1039426, RefRangeEnd = 1039427, XrefRangeStart = 1039259, XrefRangeEnd = 1039426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BindAPVRuntimeResources(CommandBuffer cmdBuffer, bool isProbeVolumeEnabled)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmdBuffer);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isProbeVolumeEnabled;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BindAPVRuntimeResources_Public_Void_CommandBuffer_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1039447, RefRangeEnd = 1039448, XrefRangeStart = 1039427, XrefRangeEnd = 1039447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool UpdateShaderVariablesProbeVolumes(CommandBuffer cmd, ProbeVolumesOptions probeVolumeOptions, int taaFrameIndex, bool supportRenderingLayers = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)probeVolumeOptions);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &taaFrameIndex;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &supportRenderingLayers;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateShaderVariablesProbeVolumes_Public_Boolean_CommandBuffer_ProbeVolumesOptions_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039559, XrefRangeEnd = 1039563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetSceneGUID(Scene scene)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&scene);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSceneGUID_Internal_Static_String_Scene_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039563, XrefRangeEnd = 1039570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetActiveScenario(string scenario, bool verbose = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(scenario);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &verbose;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetActiveScenario_Internal_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039570, XrefRangeEnd = 1039577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BlendLightingScenario(string otherScenario, float blendingFactor)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(otherScenario);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &blendingFactor;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BlendLightingScenario_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1039586, RefRangeEnd = 1039587, XrefRangeStart = 1039577, XrefRangeEnd = 1039586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RegisterPerSceneData(ProbeVolumePerSceneData data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterPerSceneData_Internal_Void_ProbeVolumePerSceneData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039587, XrefRangeEnd = 1039588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ScheduleBakingSet(ProbeVolumeBakingSet bakingSet)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bakingSet);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScheduleBakingSet_Internal_Boolean_ProbeVolumeBakingSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039588, XrefRangeEnd = 1039596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ProcessScheduledBakingSet()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessScheduledBakingSet_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039596, XrefRangeEnd = 1039605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetActiveScene(Scene scene)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&scene);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetActiveScene_Public_Void_Scene_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1039615, RefRangeEnd = 1039618, XrefRangeStart = 1039605, XrefRangeEnd = 1039615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetActiveBakingSet(ProbeVolumeBakingSet bakingSet)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bakingSet);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetActiveBakingSet_Public_Void_ProbeVolumeBakingSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1039640, RefRangeEnd = 1039641, XrefRangeStart = 1039618, XrefRangeEnd = 1039640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetBakingSetAsCurrent(ProbeVolumeBakingSet bakingSet)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bakingSet);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetBakingSetAsCurrent_Private_Void_ProbeVolumeBakingSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1039647, RefRangeEnd = 1039648, XrefRangeStart = 1039641, XrefRangeEnd = 1039647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RegisterBakingSet(ProbeVolumePerSceneData data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterBakingSet_Internal_Void_ProbeVolumePerSceneData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1039663, RefRangeEnd = 1039664, XrefRangeStart = 1039648, XrefRangeEnd = 1039663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnloadBakingSet()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnloadBakingSet_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1039669, RefRangeEnd = 1039670, XrefRangeStart = 1039664, XrefRangeEnd = 1039669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnregisterPerSceneData(ProbeVolumePerSceneData data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnregisterPerSceneData_Internal_Void_ProbeVolumePerSceneData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1039691, RefRangeEnd = 1039692, XrefRangeStart = 1039670, XrefRangeEnd = 1039691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TryGetPerSceneData(string sceneGUID, out ProbeVolumePerSceneData perSceneData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(sceneGUID);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryGetPerSceneData_Internal_Boolean_String_byref_ProbeVolumePerSceneData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		perSceneData = ((num3 == 0) ? null : new ProbeVolumePerSceneData(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1039791, RefRangeEnd = 1039792, XrefRangeStart = 1039697, XrefRangeEnd = 1039791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Initialize([In] ref ProbeVolumeSystemParameters parameters)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)parameters);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Void_byref_ProbeVolumeSystemParameters_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe void SetEnableStateFromSRP(bool srpEnablesPV)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&srpEnablesPV);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetEnableStateFromSRP_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe void SetVertexSamplingEnabled(bool value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetVertexSamplingEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe void ForceMemoryBudget(ProbeVolumeTextureMemoryBudget budget)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&budget);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ForceMemoryBudget_Internal_Void_ProbeVolumeTextureMemoryBudget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039792, XrefRangeEnd = 1039813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ForceSHBand(ProbeVolumeSHBands shBands)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&shBands);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ForceSHBand_Internal_Void_ProbeVolumeSHBands_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 617443, RefRangeEnd = 617444, XrefRangeStart = 617443, XrefRangeEnd = 617444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ForceNoDiskStreaming(bool state)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&state);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ForceNoDiskStreaming_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1039852, RefRangeEnd = 1039853, XrefRangeStart = 1039813, XrefRangeEnd = 1039852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Cleanup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Cleanup_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039853, XrefRangeEnd = 1039854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetVideoMemoryCost()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetVideoMemoryCost_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1039917, RefRangeEnd = 1039918, XrefRangeStart = 1039854, XrefRangeEnd = 1039917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveCell(int cellIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&cellIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveCell_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1039940, RefRangeEnd = 1039942, XrefRangeStart = 1039918, XrefRangeEnd = 1039940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnloadCell(Cell cell)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cell);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnloadCell_Internal_Void_Cell_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1039948, RefRangeEnd = 1039951, XrefRangeStart = 1039942, XrefRangeEnd = 1039948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnloadBlendingCell(Cell cell)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cell);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnloadBlendingCell_Internal_Void_Cell_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 1039964, RefRangeEnd = 1039973, XrefRangeStart = 1039951, XrefRangeEnd = 1039964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnloadAllCells()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnloadAllCells_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1039991, RefRangeEnd = 1039992, XrefRangeStart = 1039973, XrefRangeEnd = 1039991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnloadAllBlendingCells()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnloadAllBlendingCells_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039992, XrefRangeEnd = 1039999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddCell(int cellIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&cellIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddCell_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1040026, RefRangeEnd = 1040031, XrefRangeStart = 1039999, XrefRangeEnd = 1040026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool LoadCell(Cell cell, bool ignoreErrorLog = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cell);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &ignoreErrorLog;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadCell_Internal_Boolean_Cell_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1040031, XrefRangeEnd = 1040046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadAllCells()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadAllCells_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1040063, RefRangeEnd = 1040065, XrefRangeStart = 1040046, XrefRangeEnd = 1040063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ComputeCellGlobalInfo()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeCellGlobalInfo_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1040131, RefRangeEnd = 1040133, XrefRangeStart = 1040065, XrefRangeEnd = 1040131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddPendingSceneLoading(string sceneGUID, ProbeVolumeBakingSet bakingSet)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(sceneGUID);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bakingSet);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddPendingSceneLoading_Internal_Void_String_ProbeVolumeBakingSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1040152, RefRangeEnd = 1040153, XrefRangeStart = 1040133, XrefRangeEnd = 1040152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddPendingSceneRemoval(string sceneGUID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(sceneGUID);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddPendingSceneRemoval_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1040178, RefRangeEnd = 1040179, XrefRangeStart = 1040153, XrefRangeEnd = 1040178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemovePendingScene(string sceneGUID, List<int> cellList)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(sceneGUID);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cellList);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemovePendingScene_Internal_Void_String_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe void PerformPendingIndexChangeAndInit()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PerformPendingIndexChangeAndInit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1040179, XrefRangeEnd = 1040189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetSubdivisionDimensions(float minBrickSize, int maxSubdiv, Vector3 offset)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&minBrickSize);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxSubdiv;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSubdivisionDimensions_Internal_Void_Single_Int32_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1040193, RefRangeEnd = 1040195, XrefRangeStart = 1040189, XrefRangeEnd = 1040193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool LoadCells(List<int> cellIndices)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cellIndices);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadCells_Private_Boolean_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1040244, RefRangeEnd = 1040248, XrefRangeStart = 1040195, XrefRangeEnd = 1040244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PerformPendingLoading()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PerformPendingLoading_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1040268, RefRangeEnd = 1040273, XrefRangeStart = 1040248, XrefRangeEnd = 1040268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PerformPendingDeletion()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PerformPendingDeletion_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1040288, RefRangeEnd = 1040289, XrefRangeStart = 1040273, XrefRangeEnd = 1040288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ComputeEntryMinMax(ref IndirectionEntryInfo entryInfo, Il2CppSystem.ReadOnlySpan<ProbeBrickIndex.Brick> bricks)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref entryInfo);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)bricks));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeEntryMinMax_Internal_Void_byref_IndirectionEntryInfo_ReadOnlySpan_1_Brick_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1040293, RefRangeEnd = 1040294, XrefRangeStart = 1040289, XrefRangeEnd = 1040293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetNumberOfBricksAtSubdiv(IndirectionEntryInfo entryInfo)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&entryInfo);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNumberOfBricksAtSubdiv_Internal_Static_Int32_IndirectionEntryInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1040299, RefRangeEnd = 1040300, XrefRangeStart = 1040294, XrefRangeEnd = 1040299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PerformPendingOperations()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PerformPendingOperations_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 1040330, RefRangeEnd = 1040338, XrefRangeStart = 1040300, XrefRangeEnd = 1040330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitializeGlobalIndirection()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeGlobalIndirection_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1040414, RefRangeEnd = 1040415, XrefRangeStart = 1040338, XrefRangeEnd = 1040414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitProbeReferenceVolume()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitProbeReferenceVolume_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1040415, XrefRangeEnd = 1040621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ProbeReferenceVolume()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProbeReferenceVolume>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1040621, XrefRangeEnd = 1040635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RuntimeResources GetRuntimeResources()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRuntimeResources_Public_RuntimeResources_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new RuntimeResources(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1040635, XrefRangeEnd = 1040645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetMaxSubdivision(int maxSubdivision)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&maxSubdivision);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetMaxSubdivision_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1040646, RefRangeEnd = 1040651, XrefRangeStart = 1040645, XrefRangeEnd = 1040646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int CellSize(int subdivisionLevel)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&subdivisionLevel);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CellSize_Internal_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 1040655, RefRangeEnd = 1040667, XrefRangeStart = 1040651, XrefRangeEnd = 1040655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float BrickSize(int subdivisionLevel)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&subdivisionLevel);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BrickSize_Internal_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe float MinBrickSize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MinBrickSize_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1040667, XrefRangeEnd = 1040668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float MaxBrickSize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MaxBrickSize_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe Vector3 ProbeOffset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProbeOffset_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe int GetMaxSubdivision()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMaxSubdivision_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1040668, XrefRangeEnd = 1040672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetMaxSubdivision(float multiplier)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&multiplier);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMaxSubdivision_Internal_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1040672, XrefRangeEnd = 1040673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetDistanceBetweenProbes(int subdivisionLevel)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&subdivisionLevel);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDistanceBetweenProbes_Internal_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1040673, XrefRangeEnd = 1040674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float MinDistanceBetweenProbes()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MinDistanceBetweenProbes_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 86858, RefRangeEnd = 86864, XrefRangeStart = 86858, XrefRangeEnd = 86864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetGlobalIndirectionEntryMaxSubdiv()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGlobalIndirectionEntryMaxSubdiv_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1040674, RefRangeEnd = 1040675, XrefRangeStart = 1040674, XrefRangeEnd = 1040674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetEntrySubdivLevel()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEntrySubdivLevel_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1040675, XrefRangeEnd = 1040676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetEntrySize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEntrySize_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1040676, XrefRangeEnd = 1040677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool DataHasBeenLoaded()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DataHasBeenLoaded_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1040677, XrefRangeEnd = 1040692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Clear()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clear_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1040699, RefRangeEnd = 1040701, XrefRangeStart = 1040692, XrefRangeEnd = 1040699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<ProbeBrickPool.BrickChunkAlloc> GetSourceLocations(int count, int chunkSize, ProbeBrickPool.DataLocation dataLoc)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&count);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &chunkSize;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)dataLoc));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSourceLocations_Private_List_1_BrickChunkAlloc_Int32_Int32_DataLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ProbeBrickPool.BrickChunkAlloc>>(intPtr2) : null;
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 1040709, RefRangeEnd = 1040719, XrefRangeStart = 1040701, XrefRangeEnd = 1040709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateDataLocationTexture<T>(Texture output, NativeArray<T> input) where T : new()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)output);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)input));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_UpdateDataLocationTexture_Private_Void_Texture_NativeArray_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1040736, RefRangeEnd = 1040738, XrefRangeStart = 1040719, XrefRangeEnd = 1040736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateValidityTextureWithoutMask(Texture output, NativeArray<byte> input)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)output);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)input));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateValidityTextureWithoutMask_Private_Void_Texture_NativeArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1040808, RefRangeEnd = 1040812, XrefRangeStart = 1040738, XrefRangeEnd = 1040808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdatePool(List<ProbeBrickPool.BrickChunkAlloc> chunkList, CellData.PerScenarioData data, NativeArray<byte> validityNeighMaskData, NativeArray<ushort> skyOcclusionL0L1Data, NativeArray<byte> skyShadingDirectionIndices, int chunkIndex, int poolIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunkList);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)data));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)validityNeighMaskData));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)skyOcclusionL0L1Data));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)skyShadingDirectionIndices));
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &chunkIndex;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &poolIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdatePool_Private_Void_List_1_BrickChunkAlloc_PerScenarioData_NativeArray_1_Byte_NativeArray_1_UInt16_NativeArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1040819, RefRangeEnd = 1040820, XrefRangeStart = 1040812, XrefRangeEnd = 1040819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdatePool(CommandBuffer cmd, List<ProbeBrickPool.BrickChunkAlloc> chunkList, CellStreamingScratchBuffer dataBuffer, CellStreamingScratchBufferLayout layout, int poolIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunkList);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dataBuffer);
		*(CellStreamingScratchBufferLayout**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &layout;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &poolIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdatePool_Private_Void_CommandBuffer_List_1_BrickChunkAlloc_CellStreamingScratchBuffer_CellStreamingScratchBufferLayout_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1040858, RefRangeEnd = 1040859, XrefRangeStart = 1040820, XrefRangeEnd = 1040858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateSharedData(List<ProbeBrickPool.BrickChunkAlloc> chunkList, NativeArray<byte> validityNeighMaskData, NativeArray<ushort> skyOcclusionData, NativeArray<byte> skyShadingDirectionIndices, int chunkIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunkList);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)validityNeighMaskData));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)skyOcclusionData));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)skyShadingDirectionIndices));
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &chunkIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateSharedData_Private_Void_List_1_BrickChunkAlloc_NativeArray_1_Byte_NativeArray_1_UInt16_NativeArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1040892, RefRangeEnd = 1040893, XrefRangeStart = 1040859, XrefRangeEnd = 1040892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool AddBlendingBricks(Cell cell)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cell);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddBlendingBricks_Private_Boolean_Cell_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1040893, XrefRangeEnd = 1040900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ReservePoolChunks(int brickCount, List<ProbeBrickPool.BrickChunkAlloc> chunkList, bool ignoreErrorLog)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&brickCount);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunkList);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &ignoreErrorLog;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReservePoolChunks_Private_Boolean_Int32_List_1_BrickChunkAlloc_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1040900, XrefRangeEnd = 1040902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReleasePoolChunks(List<ProbeBrickPool.BrickChunkAlloc> chunkList)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunkList);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReleasePoolChunks_Private_Void_List_1_BrickChunkAlloc_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1040937, RefRangeEnd = 1040939, XrefRangeStart = 1040902, XrefRangeEnd = 1040937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdatePoolAndIndex(Cell cell, CellStreamingScratchBuffer dataBuffer, CellStreamingScratchBufferLayout layout, int poolIndex, CommandBuffer cmd)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cell);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dataBuffer);
		*(CellStreamingScratchBufferLayout**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &layout;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &poolIndex;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdatePoolAndIndex_Private_Void_Cell_CellStreamingScratchBuffer_CellStreamingScratchBufferLayout_Int32_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1040939, XrefRangeEnd = 1040959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool AddBricks(Cell cell)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cell);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddBricks_Private_Boolean_Cell_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1040968, RefRangeEnd = 1040971, XrefRangeStart = 1040959, XrefRangeEnd = 1040968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateCellIndex(Cell cell)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cell);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateCellIndex_Private_Void_Cell_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1040977, RefRangeEnd = 1040979, XrefRangeStart = 1040971, XrefRangeEnd = 1040977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReleaseBricks(Cell cell)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cell);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReleaseBricks_Private_Void_Cell_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1040993, RefRangeEnd = 1040994, XrefRangeStart = 1040979, XrefRangeEnd = 1040993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateConstantBuffer(CommandBuffer cmd, ProbeVolumeShadingParameters parameters)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(ProbeVolumeShadingParameters**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &parameters;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateConstantBuffer_Internal_Void_CommandBuffer_ProbeVolumeShadingParameters_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1041049, RefRangeEnd = 1041051, XrefRangeStart = 1040994, XrefRangeEnd = 1041049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DeinitProbeReferenceVolume()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeinitProbeReferenceVolume_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1041051, XrefRangeEnd = 1041052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CleanupLoadedData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CleanupLoadedData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1041066, XrefRangeEnd = 1041074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RenderDebug(Camera camera, Texture exposureTexture)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)exposureTexture);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RenderDebug_Public_Void_Camera_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1041083, RefRangeEnd = 1041084, XrefRangeStart = 1041074, XrefRangeEnd = 1041083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RenderDebug(Camera camera, ProbeVolumesOptions options, Texture exposureTexture)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)options);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)exposureTexture);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RenderDebug_Public_Void_Camera_ProbeVolumesOptions_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1041084, XrefRangeEnd = 1041088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsProbeSamplingDebugEnabled()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsProbeSamplingDebugEnabled_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1041102, RefRangeEnd = 1041104, XrefRangeStart = 1041088, XrefRangeEnd = 1041102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetProbeSamplingDebugResources(Camera camera, out GraphicsBuffer resultBuffer, out Vector2 coords)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref coords);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetProbeSamplingDebugResources_Public_Boolean_Camera_byref_GraphicsBuffer_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		resultBuffer = ((num3 == 0) ? null : new GraphicsBuffer(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1041178, RefRangeEnd = 1041180, XrefRangeStart = 1041104, XrefRangeEnd = 1041178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TryCreateDebugRenderData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryCreateDebugRenderData_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1041180, XrefRangeEnd = 1041182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitializeDebug()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeDebug_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1041182, XrefRangeEnd = 1041208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CleanupDebug()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CleanupDebug_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1041208, XrefRangeEnd = 1041209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DebugCellIndexChanged<T>(DebugUI.Field<T> field, T value)
	{
		//IL_005e->IL0061: Incompatible stack types: I vs Ref
		//IL_0051->IL0061: Incompatible stack types: I vs Ref
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)field);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			object obj = value;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref value;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_DebugCellIndexChanged_Private_Void_Field_1_T_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1042471, RefRangeEnd = 1042475, XrefRangeStart = 1041209, XrefRangeEnd = 1042471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RegisterDebug()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterDebug_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1042494, RefRangeEnd = 1042496, XrefRangeStart = 1042475, XrefRangeEnd = 1042494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnregisterDebug(bool destroyPanel)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&destroyPanel);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnregisterDebug_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042496, XrefRangeEnd = 1042530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RenderFragmentationOverlay(RenderGraph renderGraph, TextureHandle colorBuffer, TextureHandle depthBuffer, DebugOverlay debugOverlay)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(TextureHandle**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &colorBuffer;
		*(TextureHandle**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &depthBuffer;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)debugOverlay);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RenderFragmentationOverlay_Public_Void_RenderGraph_TextureHandle_TextureHandle_DebugOverlay_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042530, XrefRangeEnd = 1042543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ShouldCullCell(Vector3 cellPosition, Transform cameraTransform, Il2CppStructArray<Plane> frustumPlanes)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&cellPosition);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraTransform);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)frustumPlanes);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShouldCullCell_Private_Boolean_Vector3_Transform_Il2CppStructArray_1_Plane_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042543, XrefRangeEnd = 1042544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UpdateDebugFromSelection(ref Il2CppStructArray<Vector4> _AdjustmentVolumeBounds, ref int _AdjustmentVolumeCount)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_AdjustmentVolumeBounds);
		*ptr = (nint)(&intPtr);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref _AdjustmentVolumeCount);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateDebugFromSelection_Private_Static_Void_byref_Il2CppStructArray_1_Vector4_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		_AdjustmentVolumeBounds = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppStructArray<Vector4>(intPtr4));
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1042551, RefRangeEnd = 1042554, XrefRangeStart = 1042544, XrefRangeEnd = 1042551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Bounds GetCellBounds(Vector3 cellPosition)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&cellPosition);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCellBounds_Private_Bounds_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Bounds*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1042562, RefRangeEnd = 1042563, XrefRangeStart = 1042554, XrefRangeEnd = 1042562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ShouldCullCell(Vector3 cellPosition, Il2CppStructArray<Vector4> adjustmentVolumeBounds, int adjustmentVolumeCount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&cellPosition);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)adjustmentVolumeBounds);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &adjustmentVolumeCount;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShouldCullCell_Private_Boolean_Vector3_Il2CppStructArray_1_Vector4_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1042780, RefRangeEnd = 1042782, XrefRangeStart = 1042563, XrefRangeEnd = 1042780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DrawProbeDebug(Camera camera, Texture exposureTexture)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)exposureTexture);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawProbeDebug_Private_Void_Camera_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe void ResetDebugViewToMaxSubdiv()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetDebugViewToMaxSubdiv_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1042786, RefRangeEnd = 1042787, XrefRangeStart = 1042782, XrefRangeEnd = 1042786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearDebugData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearDebugData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1042925, RefRangeEnd = 1042926, XrefRangeStart = 1042787, XrefRangeEnd = 1042925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CellInstancedDebugProbes CreateInstancedProbes(Cell cell)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cell);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateInstancedProbes_Private_CellInstancedDebugProbes_Cell_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CellInstancedDebugProbes>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1042786, RefRangeEnd = 1042787, XrefRangeStart = 1042786, XrefRangeEnd = 1042787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnClearLightingdata()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnClearLightingdata_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe void EnableMaxCellStreaming(bool value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableMaxCellStreaming_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1042926, RefRangeEnd = 1042927, XrefRangeStart = 1042926, XrefRangeEnd = 1042926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetNumberOfCellsLoadedPerFrame(int numberOfCells)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&numberOfCells);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetNumberOfCellsLoadedPerFrame_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042937, XrefRangeEnd = 1042950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitStreaming()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitStreaming_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1042990, RefRangeEnd = 1042991, XrefRangeStart = 1042950, XrefRangeEnd = 1042990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CleanupStreaming()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CleanupStreaming_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042991, XrefRangeEnd = 1042998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ScenarioBlendingChanged(bool scenarioChanged)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&scenarioChanged);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScenarioBlendingChanged_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1043011, RefRangeEnd = 1043013, XrefRangeStart = 1042998, XrefRangeEnd = 1043011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ComputeCellStreamingScore(Cell cell, Vector3 cameraPosition, Vector3 cameraDirection)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cell);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &cameraPosition;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &cameraDirection;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeCellStreamingScore_Private_Static_Void_Cell_Vector3_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1043034, RefRangeEnd = 1043037, XrefRangeStart = 1043013, XrefRangeEnd = 1043034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ComputeStreamingScore(Vector3 cameraPosition, Vector3 cameraDirection, DynamicArray<Cell> cells)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&cameraPosition);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &cameraDirection;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cells);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeStreamingScore_Private_Void_Vector3_Vector3_DynamicArray_1_Cell_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1043079, RefRangeEnd = 1043080, XrefRangeStart = 1043037, XrefRangeEnd = 1043079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ComputeBestToBeLoadedCells(Vector3 cameraPosition, Vector3 cameraDirection)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&cameraPosition);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &cameraDirection;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeBestToBeLoadedCells_Private_Void_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1043122, RefRangeEnd = 1043123, XrefRangeStart = 1043080, XrefRangeEnd = 1043122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ComputeStreamingScoreAndWorseLoadedCells(Vector3 cameraPosition, Vector3 cameraDirection)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&cameraPosition);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &cameraDirection;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeStreamingScoreAndWorseLoadedCells_Private_Void_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1043130, RefRangeEnd = 1043132, XrefRangeStart = 1043123, XrefRangeEnd = 1043130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ComputeBlendingScore(DynamicArray<Cell> cells, float worstScore)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cells);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &worstScore;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeBlendingScore_Private_Void_DynamicArray_1_Cell_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043132, XrefRangeEnd = 1043136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TryLoadCell(Cell cell, ref int shBudget, ref int indexBudget, DynamicArray<Cell> loadedCells)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cell);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref shBudget);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref indexBudget);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)loadedCells);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryLoadCell_Private_Boolean_Cell_byref_Int32_byref_Int32_DynamicArray_1_Cell_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043136, XrefRangeEnd = 1043140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnloadBlendingCell(Cell cell, DynamicArray<Cell> unloadedCells)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cell);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)unloadedCells);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnloadBlendingCell_Private_Void_Cell_DynamicArray_1_Cell_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1043147, RefRangeEnd = 1043149, XrefRangeStart = 1043140, XrefRangeEnd = 1043147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TryLoadBlendingCell(Cell cell, DynamicArray<Cell> loadedCells)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cell);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)loadedCells);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryLoadBlendingCell_Private_Boolean_Cell_DynamicArray_1_Cell_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1043159, RefRangeEnd = 1043160, XrefRangeStart = 1043149, XrefRangeEnd = 1043159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ComputeMinMaxStreamingScore()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeMinMaxStreamingScore_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043160, XrefRangeEnd = 1043161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateCellStreaming(CommandBuffer cmd, Camera camera)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateCellStreaming_Public_Void_CommandBuffer_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1043288, RefRangeEnd = 1043290, XrefRangeStart = 1043161, XrefRangeEnd = 1043288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateCellStreaming(CommandBuffer cmd, Camera camera, ProbeVolumesOptions options)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)options);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateCellStreaming_Public_Void_CommandBuffer_Camera_ProbeVolumesOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1043299, RefRangeEnd = 1043300, XrefRangeStart = 1043290, XrefRangeEnd = 1043299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int FindWorstBlendingCellToBeLoaded()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindWorstBlendingCellToBeLoaded_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static int BlendingComparer(Cell a, Cell b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)a);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)b);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BlendingComparer_Private_Static_Int32_Cell_Cell_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1043377, RefRangeEnd = 1043378, XrefRangeStart = 1043300, XrefRangeEnd = 1043377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateBlendingCellStreaming(CommandBuffer cmd)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateBlendingCellStreaming_Private_Void_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043378, XrefRangeEnd = 1043382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int DefragComparer(Cell a, Cell b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)a);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)b);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DefragComparer_Private_Static_Int32_Cell_Cell_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1043396, RefRangeEnd = 1043398, XrefRangeStart = 1043382, XrefRangeEnd = 1043396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StartIndexDefragmentation()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StartIndexDefragmentation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1043443, RefRangeEnd = 1043444, XrefRangeStart = 1043398, XrefRangeEnd = 1043443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateIndexDefragmentation()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateIndexDefragmentation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043444, XrefRangeEnd = 1043446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnStreamingComplete(CellStreamingRequest request, CommandBuffer cmd)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)request);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnStreamingComplete_Private_Void_CellStreamingRequest_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043446, XrefRangeEnd = 1043450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnBlendingStreamingComplete(CellStreamingRequest request, CommandBuffer cmd)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)request);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnBlendingStreamingComplete_Private_Void_CellStreamingRequest_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1043467, RefRangeEnd = 1043471, XrefRangeStart = 1043450, XrefRangeEnd = 1043467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PushDiskStreamingRequest(Cell cell, string scenario, int poolIndex, CellStreamingRequest.OnStreamingCompleteDelegate onStreamingComplete)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cell);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(scenario);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &poolIndex;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)onStreamingComplete);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PushDiskStreamingRequest_Private_Void_Cell_String_Int32_OnStreamingCompleteDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043471, XrefRangeEnd = 1043474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CancelStreamingRequest(Cell cell)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cell);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CancelStreamingRequest_Private_Void_Cell_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043474, XrefRangeEnd = 1043476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CancelBlendingStreamingRequest(Cell cell)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cell);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CancelBlendingStreamingRequest_Private_Void_Cell_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1043595, RefRangeEnd = 1043596, XrefRangeStart = 1043476, XrefRangeEnd = 1043595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ProcessDiskStreamingRequest(CellStreamingRequest request)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)request);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessDiskStreamingRequest_Private_Boolean_CellStreamingRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043596, XrefRangeEnd = 1043606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AllocateScratchBufferPoolIfNeeded()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AllocateScratchBufferPoolIfNeeded_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1043639, RefRangeEnd = 1043641, XrefRangeStart = 1043606, XrefRangeEnd = 1043639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateActiveRequests(CommandBuffer cmd)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateActiveRequests_Private_Void_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1043647, RefRangeEnd = 1043649, XrefRangeStart = 1043641, XrefRangeEnd = 1043647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ProcessNewRequests()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessNewRequests_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1043698, RefRangeEnd = 1043699, XrefRangeStart = 1043649, XrefRangeEnd = 1043698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateDiskStreaming(CommandBuffer cmd)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateDiskStreaming_Private_Void_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043699, XrefRangeEnd = 1043713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasActiveStreamingRequest(Cell cell)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cell);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasActiveStreamingRequest_Private_Boolean_Cell_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043713, XrefRangeEnd = 1043717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LogStreaming(string log)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(log);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LogStreaming_Private_Void_String_1, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043717, XrefRangeEnd = 1043719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Method_Private_Void_Field_1_T_T_PDM_0<T>(DebugUI.Field<T> field, T value)
	{
		//IL_005e->IL0061: Incompatible stack types: I vs Ref
		//IL_0051->IL0061: Incompatible stack types: I vs Ref
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)field);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			object obj = value;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref value;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Method_Private_Void_Field_1_T_T_PDM_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe bool _RegisterDebug_b__229_2()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_2_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void _RegisterDebug_b__229_3(bool value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_3_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe bool _RegisterDebug_b__229_4()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_4_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void _RegisterDebug_b__229_5(bool value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_5_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe float _RegisterDebug_b__229_6()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_6_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void _RegisterDebug_b__229_7(float value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_7_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe bool _RegisterDebug_b__229_9()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_9_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void _RegisterDebug_b__229_10(bool value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_10_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe bool _RegisterDebug_b__229_11()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_11_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe int _RegisterDebug_b__229_12()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_12_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void _RegisterDebug_b__229_13(int value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_13_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe int _RegisterDebug_b__229_14()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_14_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void _RegisterDebug_b__229_15(int value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_15_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe float _RegisterDebug_b__229_16()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_16_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void _RegisterDebug_b__229_17(float value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_17_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe float _RegisterDebug_b__229_20()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_20_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void _RegisterDebug_b__229_21(float value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_21_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe bool _RegisterDebug_b__229_22()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_22_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe int _RegisterDebug_b__229_23()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_23_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void _RegisterDebug_b__229_24(int v)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&v);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_24_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe int _RegisterDebug_b__229_26()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_26_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe int _RegisterDebug_b__229_27()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_27_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void _RegisterDebug_b__229_28(int v)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&v);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_28_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe int _RegisterDebug_b__229_30()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_30_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe bool _RegisterDebug_b__229_31()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_31_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043719, XrefRangeEnd = 1043724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _RegisterDebug_b__229_32(bool value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_32_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe bool _RegisterDebug_b__229_33()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_33_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe float _RegisterDebug_b__229_34()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_34_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void _RegisterDebug_b__229_35(float value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_35_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe bool _RegisterDebug_b__229_38()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_38_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void _RegisterDebug_b__229_39(bool value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_39_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe bool _RegisterDebug_b__229_40()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_40_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043724, XrefRangeEnd = 1043735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _RegisterDebug_b__229_41(bool value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_41_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe bool _RegisterDebug_b__229_42()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_42_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe float _RegisterDebug_b__229_43()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_43_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void _RegisterDebug_b__229_44(float value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_44_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe bool _RegisterDebug_b__229_47()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_47_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe float _RegisterDebug_b__229_48()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_48_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void _RegisterDebug_b__229_49(float value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_49_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe bool _RegisterDebug_b__229_51()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_51_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void _RegisterDebug_b__229_52(bool value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_52_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe bool _RegisterDebug_b__229_53()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_53_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void _RegisterDebug_b__229_54(bool value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_54_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe bool _RegisterDebug_b__229_55()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_55_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe bool _RegisterDebug_b__229_56()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_56_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void _RegisterDebug_b__229_57(bool value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_57_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe bool _RegisterDebug_b__229_58()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_58_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void _RegisterDebug_b__229_59(bool value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_59_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe bool _RegisterDebug_b__229_67()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_67_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void _RegisterDebug_b__229_68(bool value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_68_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe bool _RegisterDebug_b__229_69()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_69_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe bool _RegisterDebug_b__229_71()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_71_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void _RegisterDebug_b__229_72(bool value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_72_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe bool _RegisterDebug_b__229_73()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_73_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void _RegisterDebug_b__229_74(bool value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_74_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1043813, RefRangeEnd = 1043814, XrefRangeStart = 1043735, XrefRangeEnd = 1043813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Method_Private_Void_String_0(string guid)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Method_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043814, XrefRangeEnd = 1043837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int _RegisterDebug_b__229_83()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_83_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043837, XrefRangeEnd = 1043842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _RegisterDebug_b__229_84(int value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_84_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe int _RegisterDebug_b__229_85()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_85_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void _RegisterDebug_b__229_86(int value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RegisterDebug_b__229_86_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ProbeReferenceVolume(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
