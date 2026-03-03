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
using Unity.Collections;

namespace UnityEngine.Rendering.Universal;

public sealed class AdditionalLightsShadowAtlasLayout : Il2CppSystem.ValueType
{
	[StructLayout(LayoutKind.Explicit)]
	public struct ShadowResolutionRequest
	{
		[OriginalName("Unity.RenderPipelines.Universal.Runtime.dll", "", "SettingsOptions")]
		[System.Flags]
		public enum SettingsOptions : ushort
		{
			None = 0,
			SoftShadow = 1,
			PointLightShadow = 2,
			All = ushort.MaxValue
		}

		private static readonly System.IntPtr NativeFieldInfoPtr_visibleLightIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_perLightShadowSliceIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_requestedResolution;

		private static readonly System.IntPtr NativeFieldInfoPtr_offsetX;

		private static readonly System.IntPtr NativeFieldInfoPtr_offsetY;

		private static readonly System.IntPtr NativeFieldInfoPtr_allocatedResolution;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_ShadowProperties;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_softShadow_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_softShadow_Public_set_Void_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_pointLightShadow_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_pointLightShadow_Public_set_Void_Boolean_0;

		[FieldOffset(0)]
		public ushort visibleLightIndex;

		[FieldOffset(2)]
		public ushort perLightShadowSliceIndex;

		[FieldOffset(4)]
		public ushort requestedResolution;

		[FieldOffset(6)]
		public ushort offsetX;

		[FieldOffset(8)]
		public ushort offsetY;

		[FieldOffset(10)]
		public ushort allocatedResolution;

		[FieldOffset(12)]
		public SettingsOptions m_ShadowProperties;

		public unsafe bool softShadow
		{
			[CallerCount(0)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_softShadow_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(0)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_softShadow_Public_set_Void_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe bool pointLightShadow
		{
			[CallerCount(0)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_pointLightShadow_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(0)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_pointLightShadow_Public_set_Void_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		static ShadowResolutionRequest()
		{
			Il2CppClassPointerStore<ShadowResolutionRequest>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AdditionalLightsShadowAtlasLayout>.NativeClassPtr, "ShadowResolutionRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShadowResolutionRequest>.NativeClassPtr);
			NativeFieldInfoPtr_visibleLightIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowResolutionRequest>.NativeClassPtr, "visibleLightIndex");
			NativeFieldInfoPtr_perLightShadowSliceIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowResolutionRequest>.NativeClassPtr, "perLightShadowSliceIndex");
			NativeFieldInfoPtr_requestedResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowResolutionRequest>.NativeClassPtr, "requestedResolution");
			NativeFieldInfoPtr_offsetX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowResolutionRequest>.NativeClassPtr, "offsetX");
			NativeFieldInfoPtr_offsetY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowResolutionRequest>.NativeClassPtr, "offsetY");
			NativeFieldInfoPtr_allocatedResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowResolutionRequest>.NativeClassPtr, "allocatedResolution");
			NativeFieldInfoPtr_m_ShadowProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowResolutionRequest>.NativeClassPtr, "m_ShadowProperties");
			NativeMethodInfoPtr_get_softShadow_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowResolutionRequest>.NativeClassPtr, 100664870);
			NativeMethodInfoPtr_set_softShadow_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowResolutionRequest>.NativeClassPtr, 100664871);
			NativeMethodInfoPtr_get_pointLightShadow_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowResolutionRequest>.NativeClassPtr, 100664872);
			NativeMethodInfoPtr_set_pointLightShadow_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowResolutionRequest>.NativeClassPtr, 100664873);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShadowResolutionRequest>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[System.Serializable]
	[ObfuscatedName("UnityEngine.Rendering.Universal.AdditionalLightsShadowAtlasLayout+<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__24_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__CreateCompareShadowResolutionRequesPredicate_b__24_0_Internal_Int32_ShadowResolutionRequest_ShadowResolutionRequest_0;

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

		public unsafe static Il2CppSystem.Func<ShadowResolutionRequest, ShadowResolutionRequest, int> __9__24_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__24_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<ShadowResolutionRequest, ShadowResolutionRequest, int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__24_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AdditionalLightsShadowAtlasLayout>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__24_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__24_0");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664875);
			NativeMethodInfoPtr__CreateCompareShadowResolutionRequesPredicate_b__24_0_Internal_Int32_ShadowResolutionRequest_ShadowResolutionRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664876);
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1089368, XrefRangeEnd = 1089370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _CreateCompareShadowResolutionRequesPredicate_b__24_0(ShadowResolutionRequest curr, ShadowResolutionRequest other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&curr);
			*(ShadowResolutionRequest**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &other;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__CreateCompareShadowResolutionRequesPredicate_b__24_0_Internal_Int32_ShadowResolutionRequest_ShadowResolutionRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_s_UnusedAtlasSquareAreas;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_ShadowResolutionRequests;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_VisibleLightIndexToCameraSquareDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_CompareShadowResolutionRequest;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_SortedShadowResolutionRequests;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SortedShadowResolutionRequests;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_VisibleLightIndexToSortedShadowResolutionRequestsFirstSliceIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TotalShadowSlicesCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TotalShadowResolutionRequestCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TooManyShadowMaps;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ShadowSlicesScaleFactor;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AtlasSize;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_UniversalLightData_UniversalShadowData_UniversalCameraData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTotalShadowSlicesCount_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTotalShadowResolutionRequestCount_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasTooManyShadowMaps_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetShadowSlicesScaleFactor_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAtlasSize_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasSpaceForLight_Public_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSortedShadowResolutionRequest_Public_ShadowResolutionRequest_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSliceShadowResolutionRequest_Public_ShadowResolutionRequest_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearStaticCaches_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EstimateScaleFactorNeededToFitAllShadowsInAtlas_Private_Static_Int32_byref_NativeArray_1_ShadowResolutionRequest_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateCompareShadowResolutionRequesPredicate_Private_Static_Func_3_ShadowResolutionRequest_ShadowResolutionRequest_Int32_0;

	public unsafe static List<RectInt> s_UnusedAtlasSquareAreas
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_UnusedAtlasSquareAreas, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<RectInt>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_UnusedAtlasSquareAreas, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static List<ShadowResolutionRequest> s_ShadowResolutionRequests
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_ShadowResolutionRequests, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ShadowResolutionRequest>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_ShadowResolutionRequests, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<float> s_VisibleLightIndexToCameraSquareDistance
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_VisibleLightIndexToCameraSquareDistance, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_VisibleLightIndexToCameraSquareDistance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppSystem.Func<ShadowResolutionRequest, ShadowResolutionRequest, int> s_CompareShadowResolutionRequest
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_CompareShadowResolutionRequest, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<ShadowResolutionRequest, ShadowResolutionRequest, int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_CompareShadowResolutionRequest, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<ShadowResolutionRequest> s_SortedShadowResolutionRequests
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_SortedShadowResolutionRequests, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<ShadowResolutionRequest>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_SortedShadowResolutionRequests, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe NativeArray<ShadowResolutionRequest> m_SortedShadowResolutionRequests
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SortedShadowResolutionRequests);
			return new NativeArray<ShadowResolutionRequest>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<ShadowResolutionRequest>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SortedShadowResolutionRequests), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<ShadowResolutionRequest>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<int> m_VisibleLightIndexToSortedShadowResolutionRequestsFirstSliceIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_VisibleLightIndexToSortedShadowResolutionRequestsFirstSliceIndex);
			return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_VisibleLightIndexToSortedShadowResolutionRequestsFirstSliceIndex), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe int m_TotalShadowSlicesCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TotalShadowSlicesCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TotalShadowSlicesCount)) = value;
		}
	}

	public unsafe int m_TotalShadowResolutionRequestCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TotalShadowResolutionRequestCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TotalShadowResolutionRequestCount)) = value;
		}
	}

	public unsafe bool m_TooManyShadowMaps
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TooManyShadowMaps);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TooManyShadowMaps)) = value;
		}
	}

	public unsafe int m_ShadowSlicesScaleFactor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ShadowSlicesScaleFactor);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ShadowSlicesScaleFactor)) = value;
		}
	}

	public unsafe int m_AtlasSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AtlasSize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AtlasSize)) = value;
		}
	}

	static AdditionalLightsShadowAtlasLayout()
	{
		Il2CppClassPointerStore<AdditionalLightsShadowAtlasLayout>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "AdditionalLightsShadowAtlasLayout");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AdditionalLightsShadowAtlasLayout>.NativeClassPtr);
		NativeFieldInfoPtr_s_UnusedAtlasSquareAreas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowAtlasLayout>.NativeClassPtr, "s_UnusedAtlasSquareAreas");
		NativeFieldInfoPtr_s_ShadowResolutionRequests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowAtlasLayout>.NativeClassPtr, "s_ShadowResolutionRequests");
		NativeFieldInfoPtr_s_VisibleLightIndexToCameraSquareDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowAtlasLayout>.NativeClassPtr, "s_VisibleLightIndexToCameraSquareDistance");
		NativeFieldInfoPtr_s_CompareShadowResolutionRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowAtlasLayout>.NativeClassPtr, "s_CompareShadowResolutionRequest");
		NativeFieldInfoPtr_s_SortedShadowResolutionRequests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowAtlasLayout>.NativeClassPtr, "s_SortedShadowResolutionRequests");
		NativeFieldInfoPtr_m_SortedShadowResolutionRequests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowAtlasLayout>.NativeClassPtr, "m_SortedShadowResolutionRequests");
		NativeFieldInfoPtr_m_VisibleLightIndexToSortedShadowResolutionRequestsFirstSliceIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowAtlasLayout>.NativeClassPtr, "m_VisibleLightIndexToSortedShadowResolutionRequestsFirstSliceIndex");
		NativeFieldInfoPtr_m_TotalShadowSlicesCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowAtlasLayout>.NativeClassPtr, "m_TotalShadowSlicesCount");
		NativeFieldInfoPtr_m_TotalShadowResolutionRequestCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowAtlasLayout>.NativeClassPtr, "m_TotalShadowResolutionRequestCount");
		NativeFieldInfoPtr_m_TooManyShadowMaps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowAtlasLayout>.NativeClassPtr, "m_TooManyShadowMaps");
		NativeFieldInfoPtr_m_ShadowSlicesScaleFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowAtlasLayout>.NativeClassPtr, "m_ShadowSlicesScaleFactor");
		NativeFieldInfoPtr_m_AtlasSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowAtlasLayout>.NativeClassPtr, "m_AtlasSize");
		NativeMethodInfoPtr__ctor_Public_Void_UniversalLightData_UniversalShadowData_UniversalCameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalLightsShadowAtlasLayout>.NativeClassPtr, 100664858);
		NativeMethodInfoPtr_GetTotalShadowSlicesCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalLightsShadowAtlasLayout>.NativeClassPtr, 100664859);
		NativeMethodInfoPtr_GetTotalShadowResolutionRequestCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalLightsShadowAtlasLayout>.NativeClassPtr, 100664860);
		NativeMethodInfoPtr_HasTooManyShadowMaps_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalLightsShadowAtlasLayout>.NativeClassPtr, 100664861);
		NativeMethodInfoPtr_GetShadowSlicesScaleFactor_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalLightsShadowAtlasLayout>.NativeClassPtr, 100664862);
		NativeMethodInfoPtr_GetAtlasSize_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalLightsShadowAtlasLayout>.NativeClassPtr, 100664863);
		NativeMethodInfoPtr_HasSpaceForLight_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalLightsShadowAtlasLayout>.NativeClassPtr, 100664864);
		NativeMethodInfoPtr_GetSortedShadowResolutionRequest_Public_ShadowResolutionRequest_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalLightsShadowAtlasLayout>.NativeClassPtr, 100664865);
		NativeMethodInfoPtr_GetSliceShadowResolutionRequest_Public_ShadowResolutionRequest_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalLightsShadowAtlasLayout>.NativeClassPtr, 100664866);
		NativeMethodInfoPtr_ClearStaticCaches_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalLightsShadowAtlasLayout>.NativeClassPtr, 100664867);
		NativeMethodInfoPtr_EstimateScaleFactorNeededToFitAllShadowsInAtlas_Private_Static_Int32_byref_NativeArray_1_ShadowResolutionRequest_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalLightsShadowAtlasLayout>.NativeClassPtr, 100664868);
		NativeMethodInfoPtr_CreateCompareShadowResolutionRequesPredicate_Private_Static_Func_3_ShadowResolutionRequest_ShadowResolutionRequest_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalLightsShadowAtlasLayout>.NativeClassPtr, 100664869);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1089559, RefRangeEnd = 1089560, XrefRangeStart = 1089370, XrefRangeEnd = 1089559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AdditionalLightsShadowAtlasLayout(UniversalLightData lightData, UniversalShadowData shadowData, UniversalCameraData cameraData)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AdditionalLightsShadowAtlasLayout>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lightData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)shadowData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_UniversalLightData_UniversalShadowData_UniversalCameraData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 63233, RefRangeEnd = 63234, XrefRangeStart = 63233, XrefRangeEnd = 63234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetTotalShadowSlicesCount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTotalShadowSlicesCount_Public_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe int GetTotalShadowResolutionRequestCount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTotalShadowResolutionRequestCount_Public_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe bool HasTooManyShadowMaps()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasTooManyShadowMaps_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe int GetShadowSlicesScaleFactor()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetShadowSlicesScaleFactor_Public_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 66330, RefRangeEnd = 66331, XrefRangeStart = 66330, XrefRangeEnd = 66331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetAtlasSize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAtlasSize_Public_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1089560, RefRangeEnd = 1089563, XrefRangeStart = 1089560, XrefRangeEnd = 1089560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasSpaceForLight(int originalVisibleLightIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&originalVisibleLightIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasSpaceForLight_Public_Boolean_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1089563, RefRangeEnd = 1089564, XrefRangeStart = 1089563, XrefRangeEnd = 1089563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ShadowResolutionRequest GetSortedShadowResolutionRequest(int sortedShadowResolutionRequestIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&sortedShadowResolutionRequestIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSortedShadowResolutionRequest_Public_ShadowResolutionRequest_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ShadowResolutionRequest*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1089564, RefRangeEnd = 1089566, XrefRangeStart = 1089564, XrefRangeEnd = 1089564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ShadowResolutionRequest GetSliceShadowResolutionRequest(int originalVisibleLightIndex, int sliceIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&originalVisibleLightIndex);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sliceIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSliceShadowResolutionRequest_Public_ShadowResolutionRequest_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ShadowResolutionRequest*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1089582, RefRangeEnd = 1089583, XrefRangeStart = 1089566, XrefRangeEnd = 1089582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ClearStaticCaches()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearStaticCaches_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static int EstimateScaleFactorNeededToFitAllShadowsInAtlas([In] ref NativeArray<ShadowResolutionRequest> shadowResolutionRequests, int endIndex, int atlasSize)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)shadowResolutionRequests);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &endIndex;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &atlasSize;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EstimateScaleFactorNeededToFitAllShadowsInAtlas_Private_Static_Int32_byref_NativeArray_1_ShadowResolutionRequest_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1089583, XrefRangeEnd = 1089598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.Func<ShadowResolutionRequest, ShadowResolutionRequest, int> CreateCompareShadowResolutionRequesPredicate()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateCompareShadowResolutionRequesPredicate_Private_Static_Func_3_ShadowResolutionRequest_ShadowResolutionRequest_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<ShadowResolutionRequest, ShadowResolutionRequest, int>>(intPtr2) : null;
	}

	public AdditionalLightsShadowAtlasLayout(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public AdditionalLightsShadowAtlasLayout()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AdditionalLightsShadowAtlasLayout>.NativeClassPtr))
	{
	}
}
