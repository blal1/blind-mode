using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering;

public sealed class LensFlareCommonSRP : Il2CppSystem.Object
{
	public class LensFlareCompInfo : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_index;

		private static readonly System.IntPtr NativeFieldInfoPtr_comp;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_LensFlareComponentSRP_0;

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

		public unsafe LensFlareComponentSRP comp
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_comp);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LensFlareComponentSRP>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_comp)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static LensFlareCompInfo()
		{
			Il2CppClassPointerStore<LensFlareCompInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, "LensFlareCompInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LensFlareCompInfo>.NativeClassPtr);
			NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareCompInfo>.NativeClassPtr, "index");
			NativeFieldInfoPtr_comp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareCompInfo>.NativeClassPtr, "comp");
			NativeMethodInfoPtr__ctor_Internal_Void_Int32_LensFlareComponentSRP_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCompInfo>.NativeClassPtr, 100665968);
		}

		[CallerCount(171)]
		[CachedScanResults(RefRangeStart = 351582, RefRangeEnd = 351753, XrefRangeStart = 351582, XrefRangeEnd = 351753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LensFlareCompInfo(int idx, LensFlareComponentSRP cmp)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LensFlareCompInfo>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&idx);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmp);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_Int32_LensFlareComponentSRP_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public LensFlareCompInfo(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("UnityEngine.Rendering.LensFlareCommonSRP+<>c__DisplayClass50_0")]
	public sealed class __c__DisplayClass50_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_newData;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__AddData_b__0_Internal_Boolean_LensFlareCompInfo_0;

		public unsafe LensFlareComponentSRP newData
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newData);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LensFlareComponentSRP>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static __c__DisplayClass50_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass50_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, "<>c__DisplayClass50_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass50_0>.NativeClassPtr);
			NativeFieldInfoPtr_newData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass50_0>.NativeClassPtr, "newData");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass50_0>.NativeClassPtr, 100665969);
			NativeMethodInfoPtr__AddData_b__0_Internal_Boolean_LensFlareCompInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass50_0>.NativeClassPtr, 100665970);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass50_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass50_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1045617, XrefRangeEnd = 1045622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _AddData_b__0(LensFlareCompInfo x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)x);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__AddData_b__0_Internal_Boolean_LensFlareCompInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public __c__DisplayClass50_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("UnityEngine.Rendering.LensFlareCommonSRP+<>c__DisplayClass51_0")]
	public sealed class __c__DisplayClass51_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_data;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__RemoveData_b__0_Internal_Boolean_LensFlareCompInfo_0;

		public unsafe LensFlareComponentSRP data
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_data);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LensFlareComponentSRP>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_data)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static __c__DisplayClass51_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass51_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, "<>c__DisplayClass51_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass51_0>.NativeClassPtr);
			NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass51_0>.NativeClassPtr, "data");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass51_0>.NativeClassPtr, 100665971);
			NativeMethodInfoPtr__RemoveData_b__0_Internal_Boolean_LensFlareCompInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass51_0>.NativeClassPtr, 100665972);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass51_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass51_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1045622, XrefRangeEnd = 1045638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _RemoveData_b__0(LensFlareCompInfo x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)x);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RemoveData_b__0_Internal_Boolean_LensFlareCompInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public __c__DisplayClass51_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("UnityEngine.Rendering.LensFlareCommonSRP+<>c__DisplayClass74_0")]
	public sealed class __c__DisplayClass74_0 : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_screenPos;

		private static readonly System.IntPtr NativeFieldInfoPtr_position;

		private static readonly System.IntPtr NativeFieldInfoPtr_globalCos0;

		private static readonly System.IntPtr NativeFieldInfoPtr_globalSin0;

		private static readonly System.IntPtr NativeFieldInfoPtr_vScreenRatio;

		private static readonly System.IntPtr NativeFieldInfoPtr_element;

		private static readonly System.IntPtr NativeFieldInfoPtr_combinedScale;

		private static readonly System.IntPtr NativeFieldInfoPtr_usedAspectRatio;

		public unsafe Vector2 screenPos
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_screenPos);
				return *(Vector2*)num;
			}
			set
			{
				*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_screenPos)) = value;
			}
		}

		public unsafe float position
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_position);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_position)) = value;
			}
		}

		public unsafe float globalCos0
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_globalCos0);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_globalCos0)) = value;
			}
		}

		public unsafe float globalSin0
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_globalSin0);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_globalSin0)) = value;
			}
		}

		public unsafe Vector2 vScreenRatio
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vScreenRatio);
				return *(Vector2*)num;
			}
			set
			{
				*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vScreenRatio)) = value;
			}
		}

		public unsafe LensFlareDataElementSRP element
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_element);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LensFlareDataElementSRP>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_element)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe float combinedScale
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_combinedScale);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_combinedScale)) = value;
			}
		}

		public unsafe float usedAspectRatio
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usedAspectRatio);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usedAspectRatio)) = value;
			}
		}

		static __c__DisplayClass74_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass74_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, "<>c__DisplayClass74_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass74_0>.NativeClassPtr);
			NativeFieldInfoPtr_screenPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass74_0>.NativeClassPtr, "screenPos");
			NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass74_0>.NativeClassPtr, "position");
			NativeFieldInfoPtr_globalCos0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass74_0>.NativeClassPtr, "globalCos0");
			NativeFieldInfoPtr_globalSin0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass74_0>.NativeClassPtr, "globalSin0");
			NativeFieldInfoPtr_vScreenRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass74_0>.NativeClassPtr, "vScreenRatio");
			NativeFieldInfoPtr_element = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass74_0>.NativeClassPtr, "element");
			NativeFieldInfoPtr_combinedScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass74_0>.NativeClassPtr, "combinedScale");
			NativeFieldInfoPtr_usedAspectRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass74_0>.NativeClassPtr, "usedAspectRatio");
		}

		public __c__DisplayClass74_0(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public __c__DisplayClass74_0()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass74_0>.NativeClassPtr))
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Instance;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Padlock;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Data;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AvailableIndicies;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxLensFlareWithOcclusion;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxLensFlareWithOcclusionTemporalSample;

	private static readonly System.IntPtr NativeFieldInfoPtr_mergeNeeded;

	private static readonly System.IntPtr NativeFieldInfoPtr_occlusionRT;

	private static readonly System.IntPtr NativeFieldInfoPtr_frameIdx;

	private static readonly System.IntPtr NativeFieldInfoPtr__FlareOcclusionPermutation;

	private static readonly System.IntPtr NativeFieldInfoPtr__FlareOcclusionRemapTex;

	private static readonly System.IntPtr NativeFieldInfoPtr__FlareOcclusionTex;

	private static readonly System.IntPtr NativeFieldInfoPtr__FlareOcclusionIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr__FlareCloudOpacity;

	private static readonly System.IntPtr NativeFieldInfoPtr__FlareSunOcclusionTex;

	private static readonly System.IntPtr NativeFieldInfoPtr__FlareTex;

	private static readonly System.IntPtr NativeFieldInfoPtr__FlareColorValue;

	private static readonly System.IntPtr NativeFieldInfoPtr__FlareData0;

	private static readonly System.IntPtr NativeFieldInfoPtr__FlareData1;

	private static readonly System.IntPtr NativeFieldInfoPtr__FlareData2;

	private static readonly System.IntPtr NativeFieldInfoPtr__FlareData3;

	private static readonly System.IntPtr NativeFieldInfoPtr__FlareData4;

	private static readonly System.IntPtr NativeFieldInfoPtr__FlareData5;

	private static readonly System.IntPtr NativeFieldInfoPtr__FlareRadialTint;

	private static readonly System.IntPtr NativeFieldInfoPtr__ViewId;

	private static readonly System.IntPtr NativeFieldInfoPtr__LensFlareScreenSpaceBloomMipTexture;

	private static readonly System.IntPtr NativeFieldInfoPtr__LensFlareScreenSpaceResultTexture;

	private static readonly System.IntPtr NativeFieldInfoPtr__LensFlareScreenSpaceSpectralLut;

	private static readonly System.IntPtr NativeFieldInfoPtr__LensFlareScreenSpaceStreakTex;

	private static readonly System.IntPtr NativeFieldInfoPtr__LensFlareScreenSpaceMipLevel;

	private static readonly System.IntPtr NativeFieldInfoPtr__LensFlareScreenSpaceTintColor;

	private static readonly System.IntPtr NativeFieldInfoPtr__LensFlareScreenSpaceParams1;

	private static readonly System.IntPtr NativeFieldInfoPtr__LensFlareScreenSpaceParams2;

	private static readonly System.IntPtr NativeFieldInfoPtr__LensFlareScreenSpaceParams3;

	private static readonly System.IntPtr NativeFieldInfoPtr__LensFlareScreenSpaceParams4;

	private static readonly System.IntPtr NativeFieldInfoPtr__LensFlareScreenSpaceParams5;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_SupportsLensFlare16bitsFormat;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_SupportsLensFlare32bitsFormat;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsOcclusionRTCompatible_Public_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetOcclusionRTFormat_Private_Static_GraphicsFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_LensFlareCommonSRP_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Data_Private_get_List_1_LensFlareCompInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsEmpty_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNextAvailableIndex_Private_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddData_Public_Void_LensFlareComponentSRP_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveData_Public_Void_LensFlareComponentSRP_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShapeAttenuationPointLight_Public_Static_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShapeAttenuationDirLight_Public_Static_Single_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShapeAttenuationSpotConeLight_Public_Static_Single_Vector3_Vector3_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShapeAttenuationSpotBoxLight_Public_Static_Single_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShapeAttenuationSpotPyramidLight_Public_Static_Single_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShapeAttenuationAreaTubeLight_Public_Static_Single_Vector3_Vector3_Single_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShapeAttenuateForwardLight_Private_Static_Single_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShapeAttenuationAreaRectangleLight_Public_Static_Single_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShapeAttenuationAreaDiscLight_Public_Static_Single_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsLensFlareSRPHidden_Private_Static_Boolean_Camera_LensFlareComponentSRP_LensFlareDataSRP_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFlareData0_Public_Static_Vector4_Vector2_Vector2_Vector2_Vector2_Single_Single_Single_Vector2_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLensFlareRayOffset_Private_Static_Vector2_Vector2_Single_Single_Single_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WorldToViewport_Private_Static_Vector3_Camera_Boolean_Boolean_Matrix4x4_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WorldToViewportLocal_Private_Static_Vector3_Boolean_Matrix4x4_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WorldToViewportDistance_Private_Static_Vector3_Camera_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsCloudLayerOpacityNeeded_Public_Static_Boolean_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetOcclusionPermutation_Private_Static_Void_CommandBuffer_Boolean_Int32_Texture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeOcclusion_Public_Static_Void_Material_Camera_XRPass_Int32_Single_Single_Boolean_Single_Single_Boolean_Vector3_Matrix4x4_UnsafeCommandBuffer_Boolean_Boolean_Texture_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeOcclusion_Public_Static_Void_Material_Camera_XRPass_Int32_Single_Single_Boolean_Single_Single_Boolean_Vector3_Matrix4x4_UnsafeCommandBuffer_Boolean_Boolean_Texture_Texture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeOcclusion_Public_Static_Void_Material_Camera_XRPass_Int32_Single_Single_Boolean_Single_Single_Boolean_Vector3_Matrix4x4_CommandBuffer_Boolean_Boolean_Texture_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ForceSingleElement_Private_Static_Boolean_LensFlareDataElementSRP_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeOcclusion_Public_Static_Void_Material_Camera_XRPass_Int32_Single_Single_Boolean_Single_Single_Boolean_Vector3_Matrix4x4_CommandBuffer_Boolean_Boolean_Texture_Texture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessLensFlareSRPElementsSingle_Public_Static_Void_LensFlareDataElementSRP_CommandBuffer_Color_Light_Single_Single_Material_Vector2_Boolean_Vector2_Vector4_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessLensFlareSRPElements_Private_Static_Void_byref_Il2CppReferenceArray_1_LensFlareDataElementSRP_CommandBuffer_Color_Light_Single_Single_Material_Vector2_Boolean_Vector2_Vector4_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoLensFlareDataDrivenCommon_Public_Static_Void_Material_Camera_Rect_XRPass_Int32_Single_Single_Boolean_Single_Single_Boolean_Vector3_Matrix4x4_UnsafeCommandBuffer_Boolean_Boolean_Texture_Texture_RenderTargetIdentifier_Func_4_Light_Camera_Vector3_Single_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoLensFlareDataDrivenCommon_Public_Static_Void_Material_Camera_Rect_XRPass_Int32_Single_Single_Boolean_Single_Single_Boolean_Vector3_Matrix4x4_UnsafeCommandBuffer_Boolean_Boolean_Texture_Texture_RenderTargetIdentifier_Func_4_Light_Camera_Vector3_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoLensFlareDataDrivenCommon_Public_Static_Void_Material_Camera_Rect_XRPass_Int32_Single_Single_Boolean_Single_Single_Boolean_Vector3_Matrix4x4_CommandBuffer_Boolean_Boolean_Texture_Texture_RenderTargetIdentifier_Func_4_Light_Camera_Vector3_Single_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoLensFlareDataDrivenCommon_Public_Static_Void_Material_Camera_Rect_XRPass_Int32_Single_Single_Boolean_Single_Single_Boolean_Vector3_Matrix4x4_CommandBuffer_Boolean_Boolean_Texture_Texture_RenderTargetIdentifier_Func_4_Light_Camera_Vector3_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoLensFlareScreenSpaceCommon_Public_Static_Void_Material_Camera_Single_Single_Color_Texture_Texture_Texture_Texture_Texture_Vector4_Vector4_Vector4_Vector4_Vector4_UnsafeCommandBuffer_RTHandle_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoLensFlareScreenSpaceCommon_Public_Static_Void_Material_Camera_Single_Single_Color_Texture_Texture_Texture_Texture_Texture_Vector4_Vector4_Vector4_Vector4_Vector4_CommandBuffer_RTHandle_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoLensFlareScreenSpaceCommon_Public_Static_Void_Material_Camera_Single_Single_Color_Texture_Texture_Texture_Texture_Texture_Vector4_Vector4_Vector4_Vector4_Vector4_CommandBuffer_RTHandle_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoPaniniProjection_Private_Static_Vector2_Vector2_Single_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalcViewExtents_Private_Static_Vector2_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalcCropExtents_Private_Static_Vector2_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Panini_Generic_Inv_Private_Static_Vector2_Vector2_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_Single_Single_Single_PDM_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_Single_Single_Single_PDM_1;

	private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_Single_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_Vector2_Vector2_Vector2_Vector2_AnimationCurve_byref___c__DisplayClass74_0_PDM_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_Single_Single_Single_PDM_2;

	public unsafe static LensFlareCommonSRP m_Instance
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_Instance, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<LensFlareCommonSRP>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_Instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppSystem.Object m_Padlock
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_Padlock, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_Padlock, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static List<LensFlareCompInfo> m_Data
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_Data, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<LensFlareCompInfo>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_Data, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static List<int> m_AvailableIndicies
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_AvailableIndicies, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_AvailableIndicies, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static int maxLensFlareWithOcclusion
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_maxLensFlareWithOcclusion, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_maxLensFlareWithOcclusion, (void*)(&value));
		}
	}

	public unsafe static int maxLensFlareWithOcclusionTemporalSample
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_maxLensFlareWithOcclusionTemporalSample, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_maxLensFlareWithOcclusionTemporalSample, (void*)(&value));
		}
	}

	public unsafe static int mergeNeeded
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_mergeNeeded, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_mergeNeeded, (void*)(&value));
		}
	}

	public unsafe static RTHandle occlusionRT
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_occlusionRT, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_occlusionRT, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static int frameIdx
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_frameIdx, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_frameIdx, (void*)(&value));
		}
	}

	public unsafe static int _FlareOcclusionPermutation
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__FlareOcclusionPermutation, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__FlareOcclusionPermutation, (void*)(&value));
		}
	}

	public unsafe static int _FlareOcclusionRemapTex
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__FlareOcclusionRemapTex, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__FlareOcclusionRemapTex, (void*)(&value));
		}
	}

	public unsafe static int _FlareOcclusionTex
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__FlareOcclusionTex, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__FlareOcclusionTex, (void*)(&value));
		}
	}

	public unsafe static int _FlareOcclusionIndex
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__FlareOcclusionIndex, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__FlareOcclusionIndex, (void*)(&value));
		}
	}

	public unsafe static int _FlareCloudOpacity
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__FlareCloudOpacity, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__FlareCloudOpacity, (void*)(&value));
		}
	}

	public unsafe static int _FlareSunOcclusionTex
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__FlareSunOcclusionTex, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__FlareSunOcclusionTex, (void*)(&value));
		}
	}

	public unsafe static int _FlareTex
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__FlareTex, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__FlareTex, (void*)(&value));
		}
	}

	public unsafe static int _FlareColorValue
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__FlareColorValue, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__FlareColorValue, (void*)(&value));
		}
	}

	public unsafe static int _FlareData0
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__FlareData0, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__FlareData0, (void*)(&value));
		}
	}

	public unsafe static int _FlareData1
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__FlareData1, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__FlareData1, (void*)(&value));
		}
	}

	public unsafe static int _FlareData2
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__FlareData2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__FlareData2, (void*)(&value));
		}
	}

	public unsafe static int _FlareData3
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__FlareData3, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__FlareData3, (void*)(&value));
		}
	}

	public unsafe static int _FlareData4
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__FlareData4, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__FlareData4, (void*)(&value));
		}
	}

	public unsafe static int _FlareData5
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__FlareData5, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__FlareData5, (void*)(&value));
		}
	}

	public unsafe static int _FlareRadialTint
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__FlareRadialTint, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__FlareRadialTint, (void*)(&value));
		}
	}

	public unsafe static int _ViewId
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__ViewId, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__ViewId, (void*)(&value));
		}
	}

	public unsafe static int _LensFlareScreenSpaceBloomMipTexture
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__LensFlareScreenSpaceBloomMipTexture, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__LensFlareScreenSpaceBloomMipTexture, (void*)(&value));
		}
	}

	public unsafe static int _LensFlareScreenSpaceResultTexture
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__LensFlareScreenSpaceResultTexture, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__LensFlareScreenSpaceResultTexture, (void*)(&value));
		}
	}

	public unsafe static int _LensFlareScreenSpaceSpectralLut
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__LensFlareScreenSpaceSpectralLut, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__LensFlareScreenSpaceSpectralLut, (void*)(&value));
		}
	}

	public unsafe static int _LensFlareScreenSpaceStreakTex
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__LensFlareScreenSpaceStreakTex, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__LensFlareScreenSpaceStreakTex, (void*)(&value));
		}
	}

	public unsafe static int _LensFlareScreenSpaceMipLevel
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__LensFlareScreenSpaceMipLevel, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__LensFlareScreenSpaceMipLevel, (void*)(&value));
		}
	}

	public unsafe static int _LensFlareScreenSpaceTintColor
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__LensFlareScreenSpaceTintColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__LensFlareScreenSpaceTintColor, (void*)(&value));
		}
	}

	public unsafe static int _LensFlareScreenSpaceParams1
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__LensFlareScreenSpaceParams1, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__LensFlareScreenSpaceParams1, (void*)(&value));
		}
	}

	public unsafe static int _LensFlareScreenSpaceParams2
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__LensFlareScreenSpaceParams2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__LensFlareScreenSpaceParams2, (void*)(&value));
		}
	}

	public unsafe static int _LensFlareScreenSpaceParams3
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__LensFlareScreenSpaceParams3, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__LensFlareScreenSpaceParams3, (void*)(&value));
		}
	}

	public unsafe static int _LensFlareScreenSpaceParams4
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__LensFlareScreenSpaceParams4, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__LensFlareScreenSpaceParams4, (void*)(&value));
		}
	}

	public unsafe static int _LensFlareScreenSpaceParams5
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__LensFlareScreenSpaceParams5, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__LensFlareScreenSpaceParams5, (void*)(&value));
		}
	}

	public unsafe static bool s_SupportsLensFlare16bitsFormat
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_SupportsLensFlare16bitsFormat, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_SupportsLensFlare16bitsFormat, (void*)(&value));
		}
	}

	public unsafe static bool s_SupportsLensFlare32bitsFormat
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_SupportsLensFlare32bitsFormat, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_SupportsLensFlare32bitsFormat, (void*)(&value));
		}
	}

	public unsafe static LensFlareCommonSRP Instance
	{
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 1045730, RefRangeEnd = 1045743, XrefRangeStart = 1045705, XrefRangeEnd = 1045730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_LensFlareCommonSRP_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<LensFlareCommonSRP>(intPtr2) : null;
		}
	}

	public unsafe List<LensFlareCompInfo> Data
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1045743, XrefRangeEnd = 1045747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Data_Private_get_List_1_LensFlareCompInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<LensFlareCompInfo>>(intPtr2) : null;
		}
	}

	static LensFlareCommonSRP()
	{
		Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "LensFlareCommonSRP");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr);
		NativeFieldInfoPtr_m_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, "m_Instance");
		NativeFieldInfoPtr_m_Padlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, "m_Padlock");
		NativeFieldInfoPtr_m_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, "m_Data");
		NativeFieldInfoPtr_m_AvailableIndicies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, "m_AvailableIndicies");
		NativeFieldInfoPtr_maxLensFlareWithOcclusion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, "maxLensFlareWithOcclusion");
		NativeFieldInfoPtr_maxLensFlareWithOcclusionTemporalSample = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, "maxLensFlareWithOcclusionTemporalSample");
		NativeFieldInfoPtr_mergeNeeded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, "mergeNeeded");
		NativeFieldInfoPtr_occlusionRT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, "occlusionRT");
		NativeFieldInfoPtr_frameIdx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, "frameIdx");
		NativeFieldInfoPtr__FlareOcclusionPermutation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, "_FlareOcclusionPermutation");
		NativeFieldInfoPtr__FlareOcclusionRemapTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, "_FlareOcclusionRemapTex");
		NativeFieldInfoPtr__FlareOcclusionTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, "_FlareOcclusionTex");
		NativeFieldInfoPtr__FlareOcclusionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, "_FlareOcclusionIndex");
		NativeFieldInfoPtr__FlareCloudOpacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, "_FlareCloudOpacity");
		NativeFieldInfoPtr__FlareSunOcclusionTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, "_FlareSunOcclusionTex");
		NativeFieldInfoPtr__FlareTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, "_FlareTex");
		NativeFieldInfoPtr__FlareColorValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, "_FlareColorValue");
		NativeFieldInfoPtr__FlareData0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, "_FlareData0");
		NativeFieldInfoPtr__FlareData1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, "_FlareData1");
		NativeFieldInfoPtr__FlareData2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, "_FlareData2");
		NativeFieldInfoPtr__FlareData3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, "_FlareData3");
		NativeFieldInfoPtr__FlareData4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, "_FlareData4");
		NativeFieldInfoPtr__FlareData5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, "_FlareData5");
		NativeFieldInfoPtr__FlareRadialTint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, "_FlareRadialTint");
		NativeFieldInfoPtr__ViewId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, "_ViewId");
		NativeFieldInfoPtr__LensFlareScreenSpaceBloomMipTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, "_LensFlareScreenSpaceBloomMipTexture");
		NativeFieldInfoPtr__LensFlareScreenSpaceResultTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, "_LensFlareScreenSpaceResultTexture");
		NativeFieldInfoPtr__LensFlareScreenSpaceSpectralLut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, "_LensFlareScreenSpaceSpectralLut");
		NativeFieldInfoPtr__LensFlareScreenSpaceStreakTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, "_LensFlareScreenSpaceStreakTex");
		NativeFieldInfoPtr__LensFlareScreenSpaceMipLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, "_LensFlareScreenSpaceMipLevel");
		NativeFieldInfoPtr__LensFlareScreenSpaceTintColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, "_LensFlareScreenSpaceTintColor");
		NativeFieldInfoPtr__LensFlareScreenSpaceParams1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, "_LensFlareScreenSpaceParams1");
		NativeFieldInfoPtr__LensFlareScreenSpaceParams2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, "_LensFlareScreenSpaceParams2");
		NativeFieldInfoPtr__LensFlareScreenSpaceParams3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, "_LensFlareScreenSpaceParams3");
		NativeFieldInfoPtr__LensFlareScreenSpaceParams4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, "_LensFlareScreenSpaceParams4");
		NativeFieldInfoPtr__LensFlareScreenSpaceParams5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, "_LensFlareScreenSpaceParams5");
		NativeFieldInfoPtr_s_SupportsLensFlare16bitsFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, "s_SupportsLensFlare16bitsFormat");
		NativeFieldInfoPtr_s_SupportsLensFlare32bitsFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, "s_SupportsLensFlare32bitsFormat");
		NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665916);
		NativeMethodInfoPtr_IsOcclusionRTCompatible_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665917);
		NativeMethodInfoPtr_GetOcclusionRTFormat_Private_Static_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665918);
		NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665919);
		NativeMethodInfoPtr_Dispose_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665920);
		NativeMethodInfoPtr_get_Instance_Public_Static_get_LensFlareCommonSRP_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665921);
		NativeMethodInfoPtr_get_Data_Private_get_List_1_LensFlareCompInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665922);
		NativeMethodInfoPtr_IsEmpty_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665923);
		NativeMethodInfoPtr_GetNextAvailableIndex_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665924);
		NativeMethodInfoPtr_AddData_Public_Void_LensFlareComponentSRP_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665925);
		NativeMethodInfoPtr_RemoveData_Public_Void_LensFlareComponentSRP_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665926);
		NativeMethodInfoPtr_ShapeAttenuationPointLight_Public_Static_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665927);
		NativeMethodInfoPtr_ShapeAttenuationDirLight_Public_Static_Single_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665928);
		NativeMethodInfoPtr_ShapeAttenuationSpotConeLight_Public_Static_Single_Vector3_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665929);
		NativeMethodInfoPtr_ShapeAttenuationSpotBoxLight_Public_Static_Single_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665930);
		NativeMethodInfoPtr_ShapeAttenuationSpotPyramidLight_Public_Static_Single_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665931);
		NativeMethodInfoPtr_ShapeAttenuationAreaTubeLight_Public_Static_Single_Vector3_Vector3_Single_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665932);
		NativeMethodInfoPtr_ShapeAttenuateForwardLight_Private_Static_Single_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665933);
		NativeMethodInfoPtr_ShapeAttenuationAreaRectangleLight_Public_Static_Single_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665934);
		NativeMethodInfoPtr_ShapeAttenuationAreaDiscLight_Public_Static_Single_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665935);
		NativeMethodInfoPtr_IsLensFlareSRPHidden_Private_Static_Boolean_Camera_LensFlareComponentSRP_LensFlareDataSRP_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665936);
		NativeMethodInfoPtr_GetFlareData0_Public_Static_Vector4_Vector2_Vector2_Vector2_Vector2_Single_Single_Single_Vector2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665937);
		NativeMethodInfoPtr_GetLensFlareRayOffset_Private_Static_Vector2_Vector2_Single_Single_Single_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665938);
		NativeMethodInfoPtr_WorldToViewport_Private_Static_Vector3_Camera_Boolean_Boolean_Matrix4x4_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665939);
		NativeMethodInfoPtr_WorldToViewportLocal_Private_Static_Vector3_Boolean_Matrix4x4_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665940);
		NativeMethodInfoPtr_WorldToViewportDistance_Private_Static_Vector3_Camera_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665941);
		NativeMethodInfoPtr_IsCloudLayerOpacityNeeded_Public_Static_Boolean_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665942);
		NativeMethodInfoPtr_SetOcclusionPermutation_Private_Static_Void_CommandBuffer_Boolean_Int32_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665943);
		NativeMethodInfoPtr_ComputeOcclusion_Public_Static_Void_Material_Camera_XRPass_Int32_Single_Single_Boolean_Single_Single_Boolean_Vector3_Matrix4x4_UnsafeCommandBuffer_Boolean_Boolean_Texture_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665944);
		NativeMethodInfoPtr_ComputeOcclusion_Public_Static_Void_Material_Camera_XRPass_Int32_Single_Single_Boolean_Single_Single_Boolean_Vector3_Matrix4x4_UnsafeCommandBuffer_Boolean_Boolean_Texture_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665945);
		NativeMethodInfoPtr_ComputeOcclusion_Public_Static_Void_Material_Camera_XRPass_Int32_Single_Single_Boolean_Single_Single_Boolean_Vector3_Matrix4x4_CommandBuffer_Boolean_Boolean_Texture_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665946);
		NativeMethodInfoPtr_ForceSingleElement_Private_Static_Boolean_LensFlareDataElementSRP_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665947);
		NativeMethodInfoPtr_ComputeOcclusion_Public_Static_Void_Material_Camera_XRPass_Int32_Single_Single_Boolean_Single_Single_Boolean_Vector3_Matrix4x4_CommandBuffer_Boolean_Boolean_Texture_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665948);
		NativeMethodInfoPtr_ProcessLensFlareSRPElementsSingle_Public_Static_Void_LensFlareDataElementSRP_CommandBuffer_Color_Light_Single_Single_Material_Vector2_Boolean_Vector2_Vector4_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665949);
		NativeMethodInfoPtr_ProcessLensFlareSRPElements_Private_Static_Void_byref_Il2CppReferenceArray_1_LensFlareDataElementSRP_CommandBuffer_Color_Light_Single_Single_Material_Vector2_Boolean_Vector2_Vector4_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665950);
		NativeMethodInfoPtr_DoLensFlareDataDrivenCommon_Public_Static_Void_Material_Camera_Rect_XRPass_Int32_Single_Single_Boolean_Single_Single_Boolean_Vector3_Matrix4x4_UnsafeCommandBuffer_Boolean_Boolean_Texture_Texture_RenderTargetIdentifier_Func_4_Light_Camera_Vector3_Single_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665951);
		NativeMethodInfoPtr_DoLensFlareDataDrivenCommon_Public_Static_Void_Material_Camera_Rect_XRPass_Int32_Single_Single_Boolean_Single_Single_Boolean_Vector3_Matrix4x4_UnsafeCommandBuffer_Boolean_Boolean_Texture_Texture_RenderTargetIdentifier_Func_4_Light_Camera_Vector3_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665952);
		NativeMethodInfoPtr_DoLensFlareDataDrivenCommon_Public_Static_Void_Material_Camera_Rect_XRPass_Int32_Single_Single_Boolean_Single_Single_Boolean_Vector3_Matrix4x4_CommandBuffer_Boolean_Boolean_Texture_Texture_RenderTargetIdentifier_Func_4_Light_Camera_Vector3_Single_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665953);
		NativeMethodInfoPtr_DoLensFlareDataDrivenCommon_Public_Static_Void_Material_Camera_Rect_XRPass_Int32_Single_Single_Boolean_Single_Single_Boolean_Vector3_Matrix4x4_CommandBuffer_Boolean_Boolean_Texture_Texture_RenderTargetIdentifier_Func_4_Light_Camera_Vector3_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665954);
		NativeMethodInfoPtr_DoLensFlareScreenSpaceCommon_Public_Static_Void_Material_Camera_Single_Single_Color_Texture_Texture_Texture_Texture_Texture_Vector4_Vector4_Vector4_Vector4_Vector4_UnsafeCommandBuffer_RTHandle_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665955);
		NativeMethodInfoPtr_DoLensFlareScreenSpaceCommon_Public_Static_Void_Material_Camera_Single_Single_Color_Texture_Texture_Texture_Texture_Texture_Vector4_Vector4_Vector4_Vector4_Vector4_CommandBuffer_RTHandle_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665956);
		NativeMethodInfoPtr_DoLensFlareScreenSpaceCommon_Public_Static_Void_Material_Camera_Single_Single_Color_Texture_Texture_Texture_Texture_Texture_Vector4_Vector4_Vector4_Vector4_Vector4_CommandBuffer_RTHandle_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665957);
		NativeMethodInfoPtr_DoPaniniProjection_Private_Static_Vector2_Vector2_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665958);
		NativeMethodInfoPtr_CalcViewExtents_Private_Static_Vector2_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665959);
		NativeMethodInfoPtr_CalcCropExtents_Private_Static_Vector2_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665960);
		NativeMethodInfoPtr_Panini_Generic_Inv_Private_Static_Vector2_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665961);
		NativeMethodInfoPtr_Method_Internal_Static_Single_Single_Single_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665963);
		NativeMethodInfoPtr_Method_Internal_Static_Single_Single_Single_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665964);
		NativeMethodInfoPtr_Method_Internal_Static_Single_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665965);
		NativeMethodInfoPtr_Method_Internal_Static_Vector2_Vector2_Vector2_Vector2_AnimationCurve_byref___c__DisplayClass74_0_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665966);
		NativeMethodInfoPtr_Method_Internal_Static_Single_Single_Single_PDM_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665967);
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LensFlareCommonSRP()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 1045646, RefRangeEnd = 1045653, XrefRangeStart = 1045638, XrefRangeEnd = 1045646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsOcclusionRTCompatible()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsOcclusionRTCompatible_Public_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1045653, XrefRangeEnd = 1045657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GraphicsFormat GetOcclusionRTFormat()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOcclusionRTFormat_Private_Static_GraphicsFormat_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(GraphicsFormat*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1045687, RefRangeEnd = 1045688, XrefRangeStart = 1045657, XrefRangeEnd = 1045687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Initialize()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1045704, RefRangeEnd = 1045705, XrefRangeStart = 1045688, XrefRangeEnd = 1045704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Dispose()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1045752, RefRangeEnd = 1045757, XrefRangeStart = 1045747, XrefRangeEnd = 1045752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsEmpty()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsEmpty_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1045757, XrefRangeEnd = 1045772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetNextAvailableIndex()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNextAvailableIndex_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1045819, RefRangeEnd = 1045822, XrefRangeStart = 1045772, XrefRangeEnd = 1045819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddData(LensFlareComponentSRP newData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddData_Public_Void_LensFlareComponentSRP_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1045856, RefRangeEnd = 1045860, XrefRangeStart = 1045822, XrefRangeEnd = 1045856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveData(LensFlareComponentSRP data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveData_Public_Void_LensFlareComponentSRP_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static float ShapeAttenuationPointLight()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShapeAttenuationPointLight_Public_Static_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float ShapeAttenuationDirLight(Vector3 forward, Vector3 wo)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&forward);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &wo;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShapeAttenuationDirLight_Public_Static_Single_Vector3_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1045860, XrefRangeEnd = 1045863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float ShapeAttenuationSpotConeLight(Vector3 forward, Vector3 wo, float spotAngle, float innerSpotPercent01)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&forward);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &wo;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &spotAngle;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &innerSpotPercent01;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShapeAttenuationSpotConeLight_Public_Static_Single_Vector3_Vector3_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float ShapeAttenuationSpotBoxLight(Vector3 forward, Vector3 wo)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&forward);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &wo;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShapeAttenuationSpotBoxLight_Public_Static_Single_Vector3_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1045863, XrefRangeEnd = 1045866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float ShapeAttenuationSpotPyramidLight(Vector3 forward, Vector3 wo)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&forward);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &wo;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShapeAttenuationSpotPyramidLight_Public_Static_Single_Vector3_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1045866, XrefRangeEnd = 1045883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float ShapeAttenuationAreaTubeLight(Vector3 lightPositionWS, Vector3 lightSide, float lightWidth, Camera cam)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&lightPositionWS);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &lightSide;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &lightWidth;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cam);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShapeAttenuationAreaTubeLight_Public_Static_Single_Vector3_Vector3_Single_Camera_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float ShapeAttenuateForwardLight(Vector3 forward, Vector3 wo)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&forward);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &wo;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShapeAttenuateForwardLight_Private_Static_Single_Vector3_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1045883, XrefRangeEnd = 1045886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float ShapeAttenuationAreaRectangleLight(Vector3 forward, Vector3 wo)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&forward);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &wo;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShapeAttenuationAreaRectangleLight_Public_Static_Single_Vector3_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1045886, XrefRangeEnd = 1045889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float ShapeAttenuationAreaDiscLight(Vector3 forward, Vector3 wo)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&forward);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &wo;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShapeAttenuationAreaDiscLight_Public_Static_Single_Vector3_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1045901, RefRangeEnd = 1045904, XrefRangeStart = 1045889, XrefRangeEnd = 1045901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsLensFlareSRPHidden(Camera cam, LensFlareComponentSRP comp, LensFlareDataSRP data)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cam);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comp);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsLensFlareSRPHidden_Private_Static_Boolean_Camera_LensFlareComponentSRP_LensFlareDataSRP_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1045918, RefRangeEnd = 1045919, XrefRangeStart = 1045904, XrefRangeEnd = 1045918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector4 GetFlareData0(Vector2 screenPos, Vector2 translationScale, Vector2 rayOff0, Vector2 vLocalScreenRatio, float angleDeg, float position, float angularOffset, Vector2 positionOffset, bool autoRotate)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[9];
		*ptr = (nint)(&screenPos);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &translationScale;
		*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &rayOff0;
		*(Vector2**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &vLocalScreenRatio;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &angleDeg;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &position;
		*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &angularOffset;
		*(Vector2**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &positionOffset;
		*(bool**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &autoRotate;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFlareData0_Public_Static_Vector4_Vector2_Vector2_Vector2_Vector2_Single_Single_Single_Vector2_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector4*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static Vector2 GetLensFlareRayOffset(Vector2 screenPos, float position, float globalCos0, float globalSin0, Vector2 vAspectRatio)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&screenPos);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &position;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &globalCos0;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &globalSin0;
		*(Vector2**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &vAspectRatio;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLensFlareRayOffset_Private_Static_Vector2_Vector2_Single_Single_Single_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1045926, RefRangeEnd = 1045932, XrefRangeStart = 1045919, XrefRangeEnd = 1045926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 WorldToViewport(Camera camera, bool isLocalLight, bool isCameraRelative, Matrix4x4 viewProjMatrix, Vector3 positionWS)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isLocalLight;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isCameraRelative;
		*(Matrix4x4**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &viewProjMatrix;
		*(Vector3**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &positionWS;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WorldToViewport_Private_Static_Vector3_Camera_Boolean_Boolean_Matrix4x4_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1045932, XrefRangeEnd = 1045933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 WorldToViewportLocal(bool isCameraRelative, Matrix4x4 viewProjMatrix, Vector3 cameraPosWS, Vector3 positionWS)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&isCameraRelative);
		*(Matrix4x4**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &viewProjMatrix;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &cameraPosWS;
		*(Vector3**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &positionWS;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WorldToViewportLocal_Private_Static_Vector3_Boolean_Matrix4x4_Vector3_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1045933, XrefRangeEnd = 1045937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 WorldToViewportDistance(Camera cam, Vector3 positionWS)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cam);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &positionWS;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WorldToViewportDistance_Private_Static_Vector3_Camera_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1045937, XrefRangeEnd = 1045966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsCloudLayerOpacityNeeded(Camera cam)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cam);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsCloudLayerOpacityNeeded_Public_Static_Boolean_Camera_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1045978, RefRangeEnd = 1045979, XrefRangeStart = 1045966, XrefRangeEnd = 1045978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetOcclusionPermutation(CommandBuffer cmd, bool useFogOpacityOcclusion, int _FlareSunOcclusionTex, Texture sunOcclusionTexture)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &useFogOpacityOcclusion;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &_FlareSunOcclusionTex;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sunOcclusionTexture);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetOcclusionPermutation_Private_Static_Void_CommandBuffer_Boolean_Int32_Texture_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1045979, XrefRangeEnd = 1045986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ComputeOcclusion(Material lensFlareShader, Camera cam, XRPass xr, int xrIndex, float actualWidth, float actualHeight, bool usePanini, float paniniDistance, float paniniCropToFit, bool isCameraRelative, Vector3 cameraPositionWS, Matrix4x4 viewProjMatrix, UnsafeCommandBuffer cmd, bool taaEnabled, bool hasCloudLayer, Texture cloudOpacityTexture, Texture sunOcclusionTexture, int _FlareOcclusionTex, int _FlareCloudOpacity, int _FlareOcclusionIndex, int _FlareTex, int _FlareColorValue, int _FlareSunOcclusionTex, int _FlareData0, int _FlareData1, int _FlareData2, int _FlareData3, int _FlareData4)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[28];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lensFlareShader);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cam);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)xr);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &xrIndex;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &actualWidth;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &actualHeight;
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &usePanini;
		*(float**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &paniniDistance;
		*(float**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &paniniCropToFit;
		*(bool**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &isCameraRelative;
		*(Vector3**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = &cameraPositionWS;
		*(Matrix4x4**)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = &viewProjMatrix;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)12u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(bool**)((byte*)ptr + checked((nuint)13u * unchecked((nuint)sizeof(System.IntPtr)))) = &taaEnabled;
		*(bool**)((byte*)ptr + checked((nuint)14u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasCloudLayer;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)15u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cloudOpacityTexture);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)16u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sunOcclusionTexture);
		*(int**)((byte*)ptr + checked((nuint)17u * unchecked((nuint)sizeof(System.IntPtr)))) = &_FlareOcclusionTex;
		*(int**)((byte*)ptr + checked((nuint)18u * unchecked((nuint)sizeof(System.IntPtr)))) = &_FlareCloudOpacity;
		*(int**)((byte*)ptr + checked((nuint)19u * unchecked((nuint)sizeof(System.IntPtr)))) = &_FlareOcclusionIndex;
		*(int**)((byte*)ptr + checked((nuint)20u * unchecked((nuint)sizeof(System.IntPtr)))) = &_FlareTex;
		*(int**)((byte*)ptr + checked((nuint)21u * unchecked((nuint)sizeof(System.IntPtr)))) = &_FlareColorValue;
		*(int**)((byte*)ptr + checked((nuint)22u * unchecked((nuint)sizeof(System.IntPtr)))) = &_FlareSunOcclusionTex;
		*(int**)((byte*)ptr + checked((nuint)23u * unchecked((nuint)sizeof(System.IntPtr)))) = &_FlareData0;
		*(int**)((byte*)ptr + checked((nuint)24u * unchecked((nuint)sizeof(System.IntPtr)))) = &_FlareData1;
		*(int**)((byte*)ptr + checked((nuint)25u * unchecked((nuint)sizeof(System.IntPtr)))) = &_FlareData2;
		*(int**)((byte*)ptr + checked((nuint)26u * unchecked((nuint)sizeof(System.IntPtr)))) = &_FlareData3;
		*(int**)((byte*)ptr + checked((nuint)27u * unchecked((nuint)sizeof(System.IntPtr)))) = &_FlareData4;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeOcclusion_Public_Static_Void_Material_Camera_XRPass_Int32_Single_Single_Boolean_Single_Single_Boolean_Vector3_Matrix4x4_UnsafeCommandBuffer_Boolean_Boolean_Texture_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1045990, RefRangeEnd = 1045992, XrefRangeStart = 1045986, XrefRangeEnd = 1045990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ComputeOcclusion(Material lensFlareShader, Camera cam, XRPass xr, int xrIndex, float actualWidth, float actualHeight, bool usePanini, float paniniDistance, float paniniCropToFit, bool isCameraRelative, Vector3 cameraPositionWS, Matrix4x4 viewProjMatrix, UnsafeCommandBuffer cmd, bool taaEnabled, bool hasCloudLayer, Texture cloudOpacityTexture, Texture sunOcclusionTexture)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[17];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lensFlareShader);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cam);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)xr);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &xrIndex;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &actualWidth;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &actualHeight;
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &usePanini;
		*(float**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &paniniDistance;
		*(float**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &paniniCropToFit;
		*(bool**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &isCameraRelative;
		*(Vector3**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = &cameraPositionWS;
		*(Matrix4x4**)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = &viewProjMatrix;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)12u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(bool**)((byte*)ptr + checked((nuint)13u * unchecked((nuint)sizeof(System.IntPtr)))) = &taaEnabled;
		*(bool**)((byte*)ptr + checked((nuint)14u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasCloudLayer;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)15u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cloudOpacityTexture);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)16u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sunOcclusionTexture);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeOcclusion_Public_Static_Void_Material_Camera_XRPass_Int32_Single_Single_Boolean_Single_Single_Boolean_Vector3_Matrix4x4_UnsafeCommandBuffer_Boolean_Boolean_Texture_Texture_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1045992, XrefRangeEnd = 1045996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ComputeOcclusion(Material lensFlareShader, Camera cam, XRPass xr, int xrIndex, float actualWidth, float actualHeight, bool usePanini, float paniniDistance, float paniniCropToFit, bool isCameraRelative, Vector3 cameraPositionWS, Matrix4x4 viewProjMatrix, CommandBuffer cmd, bool taaEnabled, bool hasCloudLayer, Texture cloudOpacityTexture, Texture sunOcclusionTexture, int _FlareOcclusionTex, int _FlareCloudOpacity, int _FlareOcclusionIndex, int _FlareTex, int _FlareColorValue, int _FlareSunOcclusionTex, int _FlareData0, int _FlareData1, int _FlareData2, int _FlareData3, int _FlareData4)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[28];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lensFlareShader);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cam);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)xr);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &xrIndex;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &actualWidth;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &actualHeight;
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &usePanini;
		*(float**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &paniniDistance;
		*(float**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &paniniCropToFit;
		*(bool**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &isCameraRelative;
		*(Vector3**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = &cameraPositionWS;
		*(Matrix4x4**)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = &viewProjMatrix;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)12u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(bool**)((byte*)ptr + checked((nuint)13u * unchecked((nuint)sizeof(System.IntPtr)))) = &taaEnabled;
		*(bool**)((byte*)ptr + checked((nuint)14u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasCloudLayer;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)15u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cloudOpacityTexture);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)16u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sunOcclusionTexture);
		*(int**)((byte*)ptr + checked((nuint)17u * unchecked((nuint)sizeof(System.IntPtr)))) = &_FlareOcclusionTex;
		*(int**)((byte*)ptr + checked((nuint)18u * unchecked((nuint)sizeof(System.IntPtr)))) = &_FlareCloudOpacity;
		*(int**)((byte*)ptr + checked((nuint)19u * unchecked((nuint)sizeof(System.IntPtr)))) = &_FlareOcclusionIndex;
		*(int**)((byte*)ptr + checked((nuint)20u * unchecked((nuint)sizeof(System.IntPtr)))) = &_FlareTex;
		*(int**)((byte*)ptr + checked((nuint)21u * unchecked((nuint)sizeof(System.IntPtr)))) = &_FlareColorValue;
		*(int**)((byte*)ptr + checked((nuint)22u * unchecked((nuint)sizeof(System.IntPtr)))) = &_FlareSunOcclusionTex;
		*(int**)((byte*)ptr + checked((nuint)23u * unchecked((nuint)sizeof(System.IntPtr)))) = &_FlareData0;
		*(int**)((byte*)ptr + checked((nuint)24u * unchecked((nuint)sizeof(System.IntPtr)))) = &_FlareData1;
		*(int**)((byte*)ptr + checked((nuint)25u * unchecked((nuint)sizeof(System.IntPtr)))) = &_FlareData2;
		*(int**)((byte*)ptr + checked((nuint)26u * unchecked((nuint)sizeof(System.IntPtr)))) = &_FlareData3;
		*(int**)((byte*)ptr + checked((nuint)27u * unchecked((nuint)sizeof(System.IntPtr)))) = &_FlareData4;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeOcclusion_Public_Static_Void_Material_Camera_XRPass_Int32_Single_Single_Boolean_Single_Single_Boolean_Vector3_Matrix4x4_CommandBuffer_Boolean_Boolean_Texture_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static bool ForceSingleElement(LensFlareDataElementSRP element)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)element);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ForceSingleElement_Private_Static_Boolean_LensFlareDataElementSRP_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1046163, RefRangeEnd = 1046168, XrefRangeStart = 1045996, XrefRangeEnd = 1046163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ComputeOcclusion(Material lensFlareShader, Camera cam, XRPass xr, int xrIndex, float actualWidth, float actualHeight, bool usePanini, float paniniDistance, float paniniCropToFit, bool isCameraRelative, Vector3 cameraPositionWS, Matrix4x4 viewProjMatrix, CommandBuffer cmd, bool taaEnabled, bool hasCloudLayer, Texture cloudOpacityTexture, Texture sunOcclusionTexture)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[17];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lensFlareShader);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cam);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)xr);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &xrIndex;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &actualWidth;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &actualHeight;
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &usePanini;
		*(float**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &paniniDistance;
		*(float**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &paniniCropToFit;
		*(bool**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &isCameraRelative;
		*(Vector3**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = &cameraPositionWS;
		*(Matrix4x4**)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = &viewProjMatrix;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)12u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(bool**)((byte*)ptr + checked((nuint)13u * unchecked((nuint)sizeof(System.IntPtr)))) = &taaEnabled;
		*(bool**)((byte*)ptr + checked((nuint)14u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasCloudLayer;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)15u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cloudOpacityTexture);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)16u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sunOcclusionTexture);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeOcclusion_Public_Static_Void_Material_Camera_XRPass_Int32_Single_Single_Boolean_Single_Single_Boolean_Vector3_Matrix4x4_CommandBuffer_Boolean_Boolean_Texture_Texture_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1046190, RefRangeEnd = 1046191, XrefRangeStart = 1046168, XrefRangeEnd = 1046190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ProcessLensFlareSRPElementsSingle(LensFlareDataElementSRP element, CommandBuffer cmd, Color globalColorModulation, Light light, float compIntensity, float scale, Material lensFlareShader, Vector2 screenPos, bool compAllowOffScreen, Vector2 vScreenRatio, Vector4 flareData1, bool preview, int depth)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[13];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)element);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(Color**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &globalColorModulation;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)light);
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &compIntensity;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &scale;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lensFlareShader);
		*(Vector2**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &screenPos;
		*(bool**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &compAllowOffScreen;
		*(Vector2**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &vScreenRatio;
		*(Vector4**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = &flareData1;
		*(bool**)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = &preview;
		*(int**)((byte*)ptr + checked((nuint)12u * unchecked((nuint)sizeof(System.IntPtr)))) = &depth;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessLensFlareSRPElementsSingle_Public_Static_Void_LensFlareDataElementSRP_CommandBuffer_Color_Light_Single_Single_Material_Vector2_Boolean_Vector2_Vector4_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1046202, RefRangeEnd = 1046204, XrefRangeStart = 1046191, XrefRangeEnd = 1046202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ProcessLensFlareSRPElements(ref Il2CppReferenceArray<LensFlareDataElementSRP> elements, CommandBuffer cmd, Color globalColorModulation, Light light, float compIntensity, float scale, Material lensFlareShader, Vector2 screenPos, bool compAllowOffScreen, Vector2 vScreenRatio, Vector4 flareData1, bool preview, int depth)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[13];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)elements);
		*ptr = (nint)(&intPtr);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(Color**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &globalColorModulation;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)light);
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &compIntensity;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &scale;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lensFlareShader);
		*(Vector2**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &screenPos;
		*(bool**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &compAllowOffScreen;
		*(Vector2**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &vScreenRatio;
		*(Vector4**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = &flareData1;
		*(bool**)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = &preview;
		*(int**)((byte*)ptr + checked((nuint)12u * unchecked((nuint)sizeof(System.IntPtr)))) = &depth;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessLensFlareSRPElements_Private_Static_Void_byref_Il2CppReferenceArray_1_LensFlareDataElementSRP_CommandBuffer_Color_Light_Single_Single_Material_Vector2_Boolean_Vector2_Vector4_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		elements = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppReferenceArray<LensFlareDataElementSRP>(intPtr4));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1046204, XrefRangeEnd = 1046211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DoLensFlareDataDrivenCommon(Material lensFlareShader, Camera cam, Rect viewport, XRPass xr, int xrIndex, float actualWidth, float actualHeight, bool usePanini, float paniniDistance, float paniniCropToFit, bool isCameraRelative, Vector3 cameraPositionWS, Matrix4x4 viewProjMatrix, UnsafeCommandBuffer cmd, bool taaEnabled, bool hasCloudLayer, Texture cloudOpacityTexture, Texture sunOcclusionTexture, RenderTargetIdentifier colorBuffer, Il2CppSystem.Func<Light, Camera, Vector3, float> GetLensFlareLightAttenuation, int _FlareOcclusionRemapTex, int _FlareOcclusionTex, int _FlareOcclusionIndex, int _FlareCloudOpacity, int _FlareSunOcclusionTex, int _FlareTex, int _FlareColorValue, int _FlareData0, int _FlareData1, int _FlareData2, int _FlareData3, int _FlareData4, bool debugView)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[33];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lensFlareShader);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cam);
		*(Rect**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &viewport;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)xr);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &xrIndex;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &actualWidth;
		*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &actualHeight;
		*(bool**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &usePanini;
		*(float**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &paniniDistance;
		*(float**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &paniniCropToFit;
		*(bool**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = &isCameraRelative;
		*(Vector3**)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = &cameraPositionWS;
		*(Matrix4x4**)((byte*)ptr + checked((nuint)12u * unchecked((nuint)sizeof(System.IntPtr)))) = &viewProjMatrix;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)13u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(bool**)((byte*)ptr + checked((nuint)14u * unchecked((nuint)sizeof(System.IntPtr)))) = &taaEnabled;
		*(bool**)((byte*)ptr + checked((nuint)15u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasCloudLayer;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)16u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cloudOpacityTexture);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)17u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sunOcclusionTexture);
		*(RenderTargetIdentifier**)((byte*)ptr + checked((nuint)18u * unchecked((nuint)sizeof(System.IntPtr)))) = &colorBuffer;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)19u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)GetLensFlareLightAttenuation);
		*(int**)((byte*)ptr + checked((nuint)20u * unchecked((nuint)sizeof(System.IntPtr)))) = &_FlareOcclusionRemapTex;
		*(int**)((byte*)ptr + checked((nuint)21u * unchecked((nuint)sizeof(System.IntPtr)))) = &_FlareOcclusionTex;
		*(int**)((byte*)ptr + checked((nuint)22u * unchecked((nuint)sizeof(System.IntPtr)))) = &_FlareOcclusionIndex;
		*(int**)((byte*)ptr + checked((nuint)23u * unchecked((nuint)sizeof(System.IntPtr)))) = &_FlareCloudOpacity;
		*(int**)((byte*)ptr + checked((nuint)24u * unchecked((nuint)sizeof(System.IntPtr)))) = &_FlareSunOcclusionTex;
		*(int**)((byte*)ptr + checked((nuint)25u * unchecked((nuint)sizeof(System.IntPtr)))) = &_FlareTex;
		*(int**)((byte*)ptr + checked((nuint)26u * unchecked((nuint)sizeof(System.IntPtr)))) = &_FlareColorValue;
		*(int**)((byte*)ptr + checked((nuint)27u * unchecked((nuint)sizeof(System.IntPtr)))) = &_FlareData0;
		*(int**)((byte*)ptr + checked((nuint)28u * unchecked((nuint)sizeof(System.IntPtr)))) = &_FlareData1;
		*(int**)((byte*)ptr + checked((nuint)29u * unchecked((nuint)sizeof(System.IntPtr)))) = &_FlareData2;
		*(int**)((byte*)ptr + checked((nuint)30u * unchecked((nuint)sizeof(System.IntPtr)))) = &_FlareData3;
		*(int**)((byte*)ptr + checked((nuint)31u * unchecked((nuint)sizeof(System.IntPtr)))) = &_FlareData4;
		*(bool**)((byte*)ptr + checked((nuint)32u * unchecked((nuint)sizeof(System.IntPtr)))) = &debugView;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoLensFlareDataDrivenCommon_Public_Static_Void_Material_Camera_Rect_XRPass_Int32_Single_Single_Boolean_Single_Single_Boolean_Vector3_Matrix4x4_UnsafeCommandBuffer_Boolean_Boolean_Texture_Texture_RenderTargetIdentifier_Func_4_Light_Camera_Vector3_Single_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1046215, RefRangeEnd = 1046217, XrefRangeStart = 1046211, XrefRangeEnd = 1046215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DoLensFlareDataDrivenCommon(Material lensFlareShader, Camera cam, Rect viewport, XRPass xr, int xrIndex, float actualWidth, float actualHeight, bool usePanini, float paniniDistance, float paniniCropToFit, bool isCameraRelative, Vector3 cameraPositionWS, Matrix4x4 viewProjMatrix, UnsafeCommandBuffer cmd, bool taaEnabled, bool hasCloudLayer, Texture cloudOpacityTexture, Texture sunOcclusionTexture, RenderTargetIdentifier colorBuffer, Il2CppSystem.Func<Light, Camera, Vector3, float> GetLensFlareLightAttenuation, bool debugView)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[21];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lensFlareShader);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cam);
		*(Rect**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &viewport;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)xr);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &xrIndex;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &actualWidth;
		*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &actualHeight;
		*(bool**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &usePanini;
		*(float**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &paniniDistance;
		*(float**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &paniniCropToFit;
		*(bool**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = &isCameraRelative;
		*(Vector3**)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = &cameraPositionWS;
		*(Matrix4x4**)((byte*)ptr + checked((nuint)12u * unchecked((nuint)sizeof(System.IntPtr)))) = &viewProjMatrix;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)13u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(bool**)((byte*)ptr + checked((nuint)14u * unchecked((nuint)sizeof(System.IntPtr)))) = &taaEnabled;
		*(bool**)((byte*)ptr + checked((nuint)15u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasCloudLayer;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)16u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cloudOpacityTexture);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)17u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sunOcclusionTexture);
		*(RenderTargetIdentifier**)((byte*)ptr + checked((nuint)18u * unchecked((nuint)sizeof(System.IntPtr)))) = &colorBuffer;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)19u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)GetLensFlareLightAttenuation);
		*(bool**)((byte*)ptr + checked((nuint)20u * unchecked((nuint)sizeof(System.IntPtr)))) = &debugView;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoLensFlareDataDrivenCommon_Public_Static_Void_Material_Camera_Rect_XRPass_Int32_Single_Single_Boolean_Single_Single_Boolean_Vector3_Matrix4x4_UnsafeCommandBuffer_Boolean_Boolean_Texture_Texture_RenderTargetIdentifier_Func_4_Light_Camera_Vector3_Single_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1046217, XrefRangeEnd = 1046221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DoLensFlareDataDrivenCommon(Material lensFlareShader, Camera cam, Rect viewport, XRPass xr, int xrIndex, float actualWidth, float actualHeight, bool usePanini, float paniniDistance, float paniniCropToFit, bool isCameraRelative, Vector3 cameraPositionWS, Matrix4x4 viewProjMatrix, CommandBuffer cmd, bool taaEnabled, bool hasCloudLayer, Texture cloudOpacityTexture, Texture sunOcclusionTexture, RenderTargetIdentifier colorBuffer, Il2CppSystem.Func<Light, Camera, Vector3, float> GetLensFlareLightAttenuation, int _FlareOcclusionRemapTex, int _FlareOcclusionTex, int _FlareOcclusionIndex, int _FlareCloudOpacity, int _FlareSunOcclusionTex, int _FlareTex, int _FlareColorValue, int _FlareData0, int _FlareData1, int _FlareData2, int _FlareData3, int _FlareData4, bool debugView)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[33];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lensFlareShader);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cam);
		*(Rect**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &viewport;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)xr);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &xrIndex;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &actualWidth;
		*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &actualHeight;
		*(bool**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &usePanini;
		*(float**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &paniniDistance;
		*(float**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &paniniCropToFit;
		*(bool**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = &isCameraRelative;
		*(Vector3**)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = &cameraPositionWS;
		*(Matrix4x4**)((byte*)ptr + checked((nuint)12u * unchecked((nuint)sizeof(System.IntPtr)))) = &viewProjMatrix;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)13u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(bool**)((byte*)ptr + checked((nuint)14u * unchecked((nuint)sizeof(System.IntPtr)))) = &taaEnabled;
		*(bool**)((byte*)ptr + checked((nuint)15u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasCloudLayer;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)16u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cloudOpacityTexture);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)17u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sunOcclusionTexture);
		*(RenderTargetIdentifier**)((byte*)ptr + checked((nuint)18u * unchecked((nuint)sizeof(System.IntPtr)))) = &colorBuffer;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)19u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)GetLensFlareLightAttenuation);
		*(int**)((byte*)ptr + checked((nuint)20u * unchecked((nuint)sizeof(System.IntPtr)))) = &_FlareOcclusionRemapTex;
		*(int**)((byte*)ptr + checked((nuint)21u * unchecked((nuint)sizeof(System.IntPtr)))) = &_FlareOcclusionTex;
		*(int**)((byte*)ptr + checked((nuint)22u * unchecked((nuint)sizeof(System.IntPtr)))) = &_FlareOcclusionIndex;
		*(int**)((byte*)ptr + checked((nuint)23u * unchecked((nuint)sizeof(System.IntPtr)))) = &_FlareCloudOpacity;
		*(int**)((byte*)ptr + checked((nuint)24u * unchecked((nuint)sizeof(System.IntPtr)))) = &_FlareSunOcclusionTex;
		*(int**)((byte*)ptr + checked((nuint)25u * unchecked((nuint)sizeof(System.IntPtr)))) = &_FlareTex;
		*(int**)((byte*)ptr + checked((nuint)26u * unchecked((nuint)sizeof(System.IntPtr)))) = &_FlareColorValue;
		*(int**)((byte*)ptr + checked((nuint)27u * unchecked((nuint)sizeof(System.IntPtr)))) = &_FlareData0;
		*(int**)((byte*)ptr + checked((nuint)28u * unchecked((nuint)sizeof(System.IntPtr)))) = &_FlareData1;
		*(int**)((byte*)ptr + checked((nuint)29u * unchecked((nuint)sizeof(System.IntPtr)))) = &_FlareData2;
		*(int**)((byte*)ptr + checked((nuint)30u * unchecked((nuint)sizeof(System.IntPtr)))) = &_FlareData3;
		*(int**)((byte*)ptr + checked((nuint)31u * unchecked((nuint)sizeof(System.IntPtr)))) = &_FlareData4;
		*(bool**)((byte*)ptr + checked((nuint)32u * unchecked((nuint)sizeof(System.IntPtr)))) = &debugView;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoLensFlareDataDrivenCommon_Public_Static_Void_Material_Camera_Rect_XRPass_Int32_Single_Single_Boolean_Single_Single_Boolean_Vector3_Matrix4x4_CommandBuffer_Boolean_Boolean_Texture_Texture_RenderTargetIdentifier_Func_4_Light_Camera_Vector3_Single_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1046367, RefRangeEnd = 1046372, XrefRangeStart = 1046221, XrefRangeEnd = 1046367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DoLensFlareDataDrivenCommon(Material lensFlareShader, Camera cam, Rect viewport, XRPass xr, int xrIndex, float actualWidth, float actualHeight, bool usePanini, float paniniDistance, float paniniCropToFit, bool isCameraRelative, Vector3 cameraPositionWS, Matrix4x4 viewProjMatrix, CommandBuffer cmd, bool taaEnabled, bool hasCloudLayer, Texture cloudOpacityTexture, Texture sunOcclusionTexture, RenderTargetIdentifier colorBuffer, Il2CppSystem.Func<Light, Camera, Vector3, float> GetLensFlareLightAttenuation, bool debugView)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[21];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lensFlareShader);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cam);
		*(Rect**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &viewport;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)xr);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &xrIndex;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &actualWidth;
		*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &actualHeight;
		*(bool**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &usePanini;
		*(float**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &paniniDistance;
		*(float**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &paniniCropToFit;
		*(bool**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = &isCameraRelative;
		*(Vector3**)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = &cameraPositionWS;
		*(Matrix4x4**)((byte*)ptr + checked((nuint)12u * unchecked((nuint)sizeof(System.IntPtr)))) = &viewProjMatrix;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)13u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(bool**)((byte*)ptr + checked((nuint)14u * unchecked((nuint)sizeof(System.IntPtr)))) = &taaEnabled;
		*(bool**)((byte*)ptr + checked((nuint)15u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasCloudLayer;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)16u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cloudOpacityTexture);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)17u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sunOcclusionTexture);
		*(RenderTargetIdentifier**)((byte*)ptr + checked((nuint)18u * unchecked((nuint)sizeof(System.IntPtr)))) = &colorBuffer;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)19u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)GetLensFlareLightAttenuation);
		*(bool**)((byte*)ptr + checked((nuint)20u * unchecked((nuint)sizeof(System.IntPtr)))) = &debugView;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoLensFlareDataDrivenCommon_Public_Static_Void_Material_Camera_Rect_XRPass_Int32_Single_Single_Boolean_Single_Single_Boolean_Vector3_Matrix4x4_CommandBuffer_Boolean_Boolean_Texture_Texture_RenderTargetIdentifier_Func_4_Light_Camera_Vector3_Single_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1046376, RefRangeEnd = 1046377, XrefRangeStart = 1046372, XrefRangeEnd = 1046376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DoLensFlareScreenSpaceCommon(Material lensFlareShader, Camera cam, float actualWidth, float actualHeight, Color tintColor, Texture originalBloomTexture, Texture bloomMipTexture, Texture spectralLut, Texture streakTextureTmp, Texture streakTextureTmp2, Vector4 parameters1, Vector4 parameters2, Vector4 parameters3, Vector4 parameters4, Vector4 parameters5, UnsafeCommandBuffer cmd, RTHandle result, bool debugView)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[18];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lensFlareShader);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cam);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &actualWidth;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &actualHeight;
		*(Color**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &tintColor;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)originalBloomTexture);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bloomMipTexture);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spectralLut);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)streakTextureTmp);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)streakTextureTmp2);
		*(Vector4**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = &parameters1;
		*(Vector4**)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = &parameters2;
		*(Vector4**)((byte*)ptr + checked((nuint)12u * unchecked((nuint)sizeof(System.IntPtr)))) = &parameters3;
		*(Vector4**)((byte*)ptr + checked((nuint)13u * unchecked((nuint)sizeof(System.IntPtr)))) = &parameters4;
		*(Vector4**)((byte*)ptr + checked((nuint)14u * unchecked((nuint)sizeof(System.IntPtr)))) = &parameters5;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)15u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)16u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		*(bool**)((byte*)ptr + checked((nuint)17u * unchecked((nuint)sizeof(System.IntPtr)))) = &debugView;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoLensFlareScreenSpaceCommon_Public_Static_Void_Material_Camera_Single_Single_Color_Texture_Texture_Texture_Texture_Texture_Vector4_Vector4_Vector4_Vector4_Vector4_UnsafeCommandBuffer_RTHandle_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1046377, XrefRangeEnd = 1046381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DoLensFlareScreenSpaceCommon(Material lensFlareShader, Camera cam, float actualWidth, float actualHeight, Color tintColor, Texture originalBloomTexture, Texture bloomMipTexture, Texture spectralLut, Texture streakTextureTmp, Texture streakTextureTmp2, Vector4 parameters1, Vector4 parameters2, Vector4 parameters3, Vector4 parameters4, Vector4 parameters5, CommandBuffer cmd, RTHandle result, int _LensFlareScreenSpaceBloomMipTexture, int _LensFlareScreenSpaceResultTexture, int _LensFlareScreenSpaceSpectralLut, int _LensFlareScreenSpaceStreakTex, int _LensFlareScreenSpaceMipLevel, int _LensFlareScreenSpaceTintColor, int _LensFlareScreenSpaceParams1, int _LensFlareScreenSpaceParams2, int _LensFlareScreenSpaceParams3, int _LensFlareScreenSpaceParams4, int _LensFlareScreenSpaceParams5, bool debugView)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[29];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lensFlareShader);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cam);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &actualWidth;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &actualHeight;
		*(Color**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &tintColor;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)originalBloomTexture);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bloomMipTexture);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spectralLut);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)streakTextureTmp);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)streakTextureTmp2);
		*(Vector4**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = &parameters1;
		*(Vector4**)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = &parameters2;
		*(Vector4**)((byte*)ptr + checked((nuint)12u * unchecked((nuint)sizeof(System.IntPtr)))) = &parameters3;
		*(Vector4**)((byte*)ptr + checked((nuint)13u * unchecked((nuint)sizeof(System.IntPtr)))) = &parameters4;
		*(Vector4**)((byte*)ptr + checked((nuint)14u * unchecked((nuint)sizeof(System.IntPtr)))) = &parameters5;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)15u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)16u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		*(int**)((byte*)ptr + checked((nuint)17u * unchecked((nuint)sizeof(System.IntPtr)))) = &_LensFlareScreenSpaceBloomMipTexture;
		*(int**)((byte*)ptr + checked((nuint)18u * unchecked((nuint)sizeof(System.IntPtr)))) = &_LensFlareScreenSpaceResultTexture;
		*(int**)((byte*)ptr + checked((nuint)19u * unchecked((nuint)sizeof(System.IntPtr)))) = &_LensFlareScreenSpaceSpectralLut;
		*(int**)((byte*)ptr + checked((nuint)20u * unchecked((nuint)sizeof(System.IntPtr)))) = &_LensFlareScreenSpaceStreakTex;
		*(int**)((byte*)ptr + checked((nuint)21u * unchecked((nuint)sizeof(System.IntPtr)))) = &_LensFlareScreenSpaceMipLevel;
		*(int**)((byte*)ptr + checked((nuint)22u * unchecked((nuint)sizeof(System.IntPtr)))) = &_LensFlareScreenSpaceTintColor;
		*(int**)((byte*)ptr + checked((nuint)23u * unchecked((nuint)sizeof(System.IntPtr)))) = &_LensFlareScreenSpaceParams1;
		*(int**)((byte*)ptr + checked((nuint)24u * unchecked((nuint)sizeof(System.IntPtr)))) = &_LensFlareScreenSpaceParams2;
		*(int**)((byte*)ptr + checked((nuint)25u * unchecked((nuint)sizeof(System.IntPtr)))) = &_LensFlareScreenSpaceParams3;
		*(int**)((byte*)ptr + checked((nuint)26u * unchecked((nuint)sizeof(System.IntPtr)))) = &_LensFlareScreenSpaceParams4;
		*(int**)((byte*)ptr + checked((nuint)27u * unchecked((nuint)sizeof(System.IntPtr)))) = &_LensFlareScreenSpaceParams5;
		*(bool**)((byte*)ptr + checked((nuint)28u * unchecked((nuint)sizeof(System.IntPtr)))) = &debugView;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoLensFlareScreenSpaceCommon_Public_Static_Void_Material_Camera_Single_Single_Color_Texture_Texture_Texture_Texture_Texture_Vector4_Vector4_Vector4_Vector4_Vector4_CommandBuffer_RTHandle_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1046485, RefRangeEnd = 1046488, XrefRangeStart = 1046381, XrefRangeEnd = 1046485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DoLensFlareScreenSpaceCommon(Material lensFlareShader, Camera cam, float actualWidth, float actualHeight, Color tintColor, Texture originalBloomTexture, Texture bloomMipTexture, Texture spectralLut, Texture streakTextureTmp, Texture streakTextureTmp2, Vector4 parameters1, Vector4 parameters2, Vector4 parameters3, Vector4 parameters4, Vector4 parameters5, CommandBuffer cmd, RTHandle result, bool debugView)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[18];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lensFlareShader);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cam);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &actualWidth;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &actualHeight;
		*(Color**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &tintColor;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)originalBloomTexture);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bloomMipTexture);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spectralLut);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)streakTextureTmp);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)streakTextureTmp2);
		*(Vector4**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = &parameters1;
		*(Vector4**)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = &parameters2;
		*(Vector4**)((byte*)ptr + checked((nuint)12u * unchecked((nuint)sizeof(System.IntPtr)))) = &parameters3;
		*(Vector4**)((byte*)ptr + checked((nuint)13u * unchecked((nuint)sizeof(System.IntPtr)))) = &parameters4;
		*(Vector4**)((byte*)ptr + checked((nuint)14u * unchecked((nuint)sizeof(System.IntPtr)))) = &parameters5;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)15u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)16u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		*(bool**)((byte*)ptr + checked((nuint)17u * unchecked((nuint)sizeof(System.IntPtr)))) = &debugView;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoLensFlareScreenSpaceCommon_Public_Static_Void_Material_Camera_Single_Single_Color_Texture_Texture_Texture_Texture_Texture_Vector4_Vector4_Vector4_Vector4_Vector4_CommandBuffer_RTHandle_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1046502, RefRangeEnd = 1046504, XrefRangeStart = 1046488, XrefRangeEnd = 1046502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector2 DoPaniniProjection(Vector2 screenPos, float actualWidth, float actualHeight, float fieldOfView, float paniniProjectionCropToFit, float paniniProjectionDistance)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&screenPos);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &actualWidth;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &actualHeight;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &fieldOfView;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &paniniProjectionCropToFit;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &paniniProjectionDistance;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoPaniniProjection_Private_Static_Vector2_Vector2_Single_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1046504, XrefRangeEnd = 1046505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector2 CalcViewExtents(float actualWidth, float actualHeight, float fieldOfView)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&actualWidth);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &actualHeight;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &fieldOfView;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalcViewExtents_Private_Static_Vector2_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1046505, XrefRangeEnd = 1046511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector2 CalcCropExtents(float actualWidth, float actualHeight, float fieldOfView, float d)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&actualWidth);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &actualHeight;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &fieldOfView;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &d;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalcCropExtents_Private_Static_Vector2_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1046511, XrefRangeEnd = 1046513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector2 Panini_Generic_Inv(Vector2 projPos, float d)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&projPos);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &d;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Panini_Generic_Inv_Private_Static_Vector2_Vector2_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1046513, XrefRangeEnd = 1046514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float Method_Internal_Static_Single_Single_Single_PDM_0(float d, float l)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&d);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &l;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Method_Internal_Static_Single_Single_Single_PDM_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float Method_Internal_Static_Single_Single_Single_PDM_1(float d, float l)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&d);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &l;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Method_Internal_Static_Single_Single_Single_PDM_1, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1046522, RefRangeEnd = 1046524, XrefRangeStart = 1046514, XrefRangeEnd = 1046522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float Method_Internal_Static_Single_Vector3_Vector3_0(Vector3 p1, Vector3 p2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&p1);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &p2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Method_Internal_Static_Single_Vector3_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1046524, XrefRangeEnd = 1046535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector2 Method_Internal_Static_Vector2_Vector2_Vector2_Vector2_AnimationCurve_byref___c__DisplayClass74_0_PDM_0(Vector2 rayOff, Vector2 rayOff0, Vector2 curSize, AnimationCurve distortionCurve, ref __c__DisplayClass74_0 A_4)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&rayOff);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rayOff0;
		*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &curSize;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)distortionCurve);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)A_4);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Method_Internal_Static_Vector2_Vector2_Vector2_Vector2_AnimationCurve_byref___c__DisplayClass74_0_PDM_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1046535, XrefRangeEnd = 1046536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float Method_Internal_Static_Single_Single_Single_PDM_2(float min, float max)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&min);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &max;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Method_Internal_Static_Single_Single_Single_PDM_2, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public LensFlareCommonSRP(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
