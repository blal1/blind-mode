using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Unity.Collections;
using Unity.Mathematics;

namespace UnityEngine.Rendering.Universal;

public sealed class TilingJob : Il2CppSystem.ValueType
{
	[StructLayout(LayoutKind.Explicit)]
	[ObfuscatedName("UnityEngine.Rendering.Universal.TilingJob+<>c__DisplayClass19_0")]
	public struct __c__DisplayClass19_0
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_light;

		private static readonly System.IntPtr NativeFieldInfoPtr_lightPositionVS;

		private static readonly System.IntPtr NativeFieldInfoPtr_lightDirectionVS;

		private static readonly System.IntPtr NativeFieldInfoPtr_cosHalfAngle;

		private static readonly System.IntPtr NativeFieldInfoPtr_coneHeight;

		[FieldOffset(0)]
		public VisibleLight light;

		[FieldOffset(116)]
		public float3 lightPositionVS;

		[FieldOffset(128)]
		public float3 lightDirectionVS;

		[FieldOffset(140)]
		public float cosHalfAngle;

		[FieldOffset(144)]
		public float coneHeight;

		static __c__DisplayClass19_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass19_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, "<>c__DisplayClass19_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass19_0>.NativeClassPtr);
			NativeFieldInfoPtr_light = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass19_0>.NativeClassPtr, "light");
			NativeFieldInfoPtr_lightPositionVS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass19_0>.NativeClassPtr, "lightPositionVS");
			NativeFieldInfoPtr_lightDirectionVS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass19_0>.NativeClassPtr, "lightDirectionVS");
			NativeFieldInfoPtr_cosHalfAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass19_0>.NativeClassPtr, "cosHalfAngle");
			NativeFieldInfoPtr_coneHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass19_0>.NativeClassPtr, "coneHeight");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<__c__DisplayClass19_0>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	[ObfuscatedName("UnityEngine.Rendering.Universal.TilingJob+<>c__DisplayClass20_0")]
	public struct __c__DisplayClass20_0
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_light;

		private static readonly System.IntPtr NativeFieldInfoPtr_lightPosVS;

		private static readonly System.IntPtr NativeFieldInfoPtr_lightDirVS;

		private static readonly System.IntPtr NativeFieldInfoPtr_cosHalfAngle;

		[FieldOffset(0)]
		public VisibleLight light;

		[FieldOffset(116)]
		public float3 lightPosVS;

		[FieldOffset(128)]
		public float3 lightDirVS;

		[FieldOffset(140)]
		public float cosHalfAngle;

		static __c__DisplayClass20_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass20_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, "<>c__DisplayClass20_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass20_0>.NativeClassPtr);
			NativeFieldInfoPtr_light = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass20_0>.NativeClassPtr, "light");
			NativeFieldInfoPtr_lightPosVS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass20_0>.NativeClassPtr, "lightPosVS");
			NativeFieldInfoPtr_lightDirVS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass20_0>.NativeClassPtr, "lightDirVS");
			NativeFieldInfoPtr_cosHalfAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass20_0>.NativeClassPtr, "cosHalfAngle");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<__c__DisplayClass20_0>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_lights;

	private static readonly System.IntPtr NativeFieldInfoPtr_reflectionProbes;

	private static readonly System.IntPtr NativeFieldInfoPtr_tileRanges;

	private static readonly System.IntPtr NativeFieldInfoPtr_itemsPerTile;

	private static readonly System.IntPtr NativeFieldInfoPtr_rangesPerItem;

	private static readonly System.IntPtr NativeFieldInfoPtr_worldToViews;

	private static readonly System.IntPtr NativeFieldInfoPtr_tileScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_tileScaleInv;

	private static readonly System.IntPtr NativeFieldInfoPtr_viewPlaneBottoms;

	private static readonly System.IntPtr NativeFieldInfoPtr_viewPlaneTops;

	private static readonly System.IntPtr NativeFieldInfoPtr_viewToViewportScaleBiases;

	private static readonly System.IntPtr NativeFieldInfoPtr_tileCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_near;

	private static readonly System.IntPtr NativeFieldInfoPtr_isOrthographic;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TileYRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Offset;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ViewIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CenterOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_CubePoints;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_CubeLineIndices;

	private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TileLight_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TileLightOrthographic_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TileReflectionProbe_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ViewToTileSpace_Private_float2_float3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ViewToTileSpaceOrthographic_Private_float2_float3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExpandY_Private_Void_float3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExpandOrthographic_Private_Void_float3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExpandRangeOrthographic_Private_Void_byref_InclusiveRange_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_square_Private_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSphereHorizon_Private_Static_Void_float2_Single_Single_Single_byref_float2_byref_float2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSphereYPlaneHorizon_Private_Static_Void_float3_Single_Single_Single_Single_byref_float3_byref_float3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCircleClipPoints_Private_Static_Boolean_float3_float3_Single_Single_byref_float3_byref_float3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IntersectEllipseLine_Private_Static_ValueTuple_2_Single_Single_Single_Single_float3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetProjectedCircleHorizon_Private_Static_Void_float2_Single_float2_float2_byref_float2_byref_float2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IntersectCircleYPlane_Private_Static_Boolean_Single_float3_float3_float3_float3_Single_byref_float3_byref_float3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetConeSideTangentPoints_Private_Static_Void_float3_float3_Single_Single_Single_Single_float3_float3_byref_float3_byref_float3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EvaluateNearConic_Private_Static_float3_Single_float3_float3_Single_float3_float3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindNearConicTangentTheta_Private_Static_float2_float2_float2_Single_float2_float2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindNearConicYTheta_Private_Static_float2_Single_float3_float3_Single_float3_float3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_Boolean_float3_byref___c__DisplayClass19_0_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_Boolean_float3_byref___c__DisplayClass19_0_1;

	private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_Boolean_float3_byref___c__DisplayClass20_0_0;

	public unsafe NativeArray<VisibleLight> lights
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lights);
			return new NativeArray<VisibleLight>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<VisibleLight>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lights), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<VisibleLight>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<VisibleReflectionProbe> reflectionProbes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reflectionProbes);
			return new NativeArray<VisibleReflectionProbe>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<VisibleReflectionProbe>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reflectionProbes), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<VisibleReflectionProbe>>.NativeClassPtr, ref *(uint*)null));
		}
	}

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

	public unsafe Fixed2<float4x4> worldToViews
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldToViews);
			return new Fixed2<float4x4>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Fixed2<float4x4>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldToViews), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Fixed2<float4x4>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe float2 tileScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tileScale);
			return *(float2*)num;
		}
		set
		{
			*(float2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tileScale)) = value;
		}
	}

	public unsafe float2 tileScaleInv
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tileScaleInv);
			return *(float2*)num;
		}
		set
		{
			*(float2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tileScaleInv)) = value;
		}
	}

	public unsafe Fixed2<float> viewPlaneBottoms
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_viewPlaneBottoms);
			return new Fixed2<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Fixed2<float>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_viewPlaneBottoms), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Fixed2<float>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe Fixed2<float> viewPlaneTops
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_viewPlaneTops);
			return new Fixed2<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Fixed2<float>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_viewPlaneTops), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Fixed2<float>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe Fixed2<float4> viewToViewportScaleBiases
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_viewToViewportScaleBiases);
			return new Fixed2<float4>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Fixed2<float4>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_viewToViewportScaleBiases), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Fixed2<float4>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe int2 tileCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tileCount);
			return *(int2*)num;
		}
		set
		{
			*(int2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tileCount)) = value;
		}
	}

	public unsafe float near
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_near);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_near)) = value;
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

	public unsafe InclusiveRange m_TileYRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TileYRange);
			return *(InclusiveRange*)num;
		}
		set
		{
			*(InclusiveRange*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TileYRange)) = value;
		}
	}

	public unsafe int m_Offset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Offset);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Offset)) = value;
		}
	}

	public unsafe int m_ViewIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ViewIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ViewIndex)) = value;
		}
	}

	public unsafe float2 m_CenterOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CenterOffset);
			return *(float2*)num;
		}
		set
		{
			*(float2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CenterOffset)) = value;
		}
	}

	public unsafe static Il2CppStructArray<float3> k_CubePoints
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_CubePoints, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<float3>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_CubePoints, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<int4> k_CubeLineIndices
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_CubeLineIndices, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int4>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_CubeLineIndices, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static TilingJob()
	{
		Il2CppClassPointerStore<TilingJob>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "TilingJob");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TilingJob>.NativeClassPtr);
		NativeFieldInfoPtr_lights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, "lights");
		NativeFieldInfoPtr_reflectionProbes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, "reflectionProbes");
		NativeFieldInfoPtr_tileRanges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, "tileRanges");
		NativeFieldInfoPtr_itemsPerTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, "itemsPerTile");
		NativeFieldInfoPtr_rangesPerItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, "rangesPerItem");
		NativeFieldInfoPtr_worldToViews = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, "worldToViews");
		NativeFieldInfoPtr_tileScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, "tileScale");
		NativeFieldInfoPtr_tileScaleInv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, "tileScaleInv");
		NativeFieldInfoPtr_viewPlaneBottoms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, "viewPlaneBottoms");
		NativeFieldInfoPtr_viewPlaneTops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, "viewPlaneTops");
		NativeFieldInfoPtr_viewToViewportScaleBiases = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, "viewToViewportScaleBiases");
		NativeFieldInfoPtr_tileCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, "tileCount");
		NativeFieldInfoPtr_near = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, "near");
		NativeFieldInfoPtr_isOrthographic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, "isOrthographic");
		NativeFieldInfoPtr_m_TileYRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, "m_TileYRange");
		NativeFieldInfoPtr_m_Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, "m_Offset");
		NativeFieldInfoPtr_m_ViewIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, "m_ViewIndex");
		NativeFieldInfoPtr_m_CenterOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, "m_CenterOffset");
		NativeFieldInfoPtr_k_CubePoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, "k_CubePoints");
		NativeFieldInfoPtr_k_CubeLineIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, "k_CubeLineIndices");
		NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, 100665618);
		NativeMethodInfoPtr_TileLight_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, 100665619);
		NativeMethodInfoPtr_TileLightOrthographic_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, 100665620);
		NativeMethodInfoPtr_TileReflectionProbe_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, 100665621);
		NativeMethodInfoPtr_ViewToTileSpace_Private_float2_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, 100665622);
		NativeMethodInfoPtr_ViewToTileSpaceOrthographic_Private_float2_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, 100665623);
		NativeMethodInfoPtr_ExpandY_Private_Void_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, 100665624);
		NativeMethodInfoPtr_ExpandOrthographic_Private_Void_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, 100665625);
		NativeMethodInfoPtr_ExpandRangeOrthographic_Private_Void_byref_InclusiveRange_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, 100665626);
		NativeMethodInfoPtr_square_Private_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, 100665627);
		NativeMethodInfoPtr_GetSphereHorizon_Private_Static_Void_float2_Single_Single_Single_byref_float2_byref_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, 100665628);
		NativeMethodInfoPtr_GetSphereYPlaneHorizon_Private_Static_Void_float3_Single_Single_Single_Single_byref_float3_byref_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, 100665629);
		NativeMethodInfoPtr_GetCircleClipPoints_Private_Static_Boolean_float3_float3_Single_Single_byref_float3_byref_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, 100665630);
		NativeMethodInfoPtr_IntersectEllipseLine_Private_Static_ValueTuple_2_Single_Single_Single_Single_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, 100665631);
		NativeMethodInfoPtr_GetProjectedCircleHorizon_Private_Static_Void_float2_Single_float2_float2_byref_float2_byref_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, 100665632);
		NativeMethodInfoPtr_IntersectCircleYPlane_Private_Static_Boolean_Single_float3_float3_float3_float3_Single_byref_float3_byref_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, 100665633);
		NativeMethodInfoPtr_GetConeSideTangentPoints_Private_Static_Void_float3_float3_Single_Single_Single_Single_float3_float3_byref_float3_byref_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, 100665634);
		NativeMethodInfoPtr_EvaluateNearConic_Private_Static_float3_Single_float3_float3_Single_float3_float3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, 100665635);
		NativeMethodInfoPtr_FindNearConicTangentTheta_Private_Static_float2_float2_float2_Single_float2_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, 100665636);
		NativeMethodInfoPtr_FindNearConicYTheta_Private_Static_float2_Single_float3_float3_Single_float3_float3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, 100665637);
		NativeMethodInfoPtr_Method_Internal_Static_Boolean_float3_byref___c__DisplayClass19_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, 100665639);
		NativeMethodInfoPtr_Method_Internal_Static_Boolean_float3_byref___c__DisplayClass19_0_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, 100665640);
		NativeMethodInfoPtr_Method_Internal_Static_Boolean_float3_byref___c__DisplayClass20_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, 100665641);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1100678, XrefRangeEnd = 1100686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Execute(int jobIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&jobIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1100907, RefRangeEnd = 1100908, XrefRangeStart = 1100686, XrefRangeEnd = 1100907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TileLight(int lightIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&lightIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TileLight_Private_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1101015, RefRangeEnd = 1101016, XrefRangeStart = 1100908, XrefRangeEnd = 1101015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TileLightOrthographic(int lightIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&lightIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TileLightOrthographic_Private_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1101081, RefRangeEnd = 1101082, XrefRangeStart = 1101016, XrefRangeEnd = 1101081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TileReflectionProbe(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TileReflectionProbe_Private_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 1101087, RefRangeEnd = 1101099, XrefRangeStart = 1101082, XrefRangeEnd = 1101087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float2 ViewToTileSpace(float3 positionVS)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&positionVS);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ViewToTileSpace_Private_float2_float3_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float2*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1101104, RefRangeEnd = 1101107, XrefRangeStart = 1101099, XrefRangeEnd = 1101104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float2 ViewToTileSpaceOrthographic(float3 positionVS)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&positionVS);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ViewToTileSpaceOrthographic_Private_float2_float3_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float2*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(18)]
	[CachedScanResults(RefRangeStart = 1101113, RefRangeEnd = 1101131, XrefRangeStart = 1101107, XrefRangeEnd = 1101113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ExpandY(float3 positionVS)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&positionVS);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExpandY_Private_Void_float3_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 1101137, RefRangeEnd = 1101146, XrefRangeStart = 1101131, XrefRangeEnd = 1101137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ExpandOrthographic(float3 positionVS)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&positionVS);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExpandOrthographic_Private_Void_float3_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1101151, RefRangeEnd = 1101157, XrefRangeStart = 1101146, XrefRangeEnd = 1101151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ExpandRangeOrthographic(ref InclusiveRange range, float xVS)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref range);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &xVS;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExpandRangeOrthographic_Private_Void_byref_InclusiveRange_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(101)]
	[CachedScanResults(RefRangeStart = 1023193, RefRangeEnd = 1023294, XrefRangeStart = 1023193, XrefRangeEnd = 1023294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float square(float x)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&x);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_square_Private_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1101169, RefRangeEnd = 1101171, XrefRangeStart = 1101157, XrefRangeEnd = 1101169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetSphereHorizon(float2 center, float radius, float near, float clipRadius, out float2 p0, out float2 p1)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&center);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &radius;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &near;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &clipRadius;
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref p0);
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref p1);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSphereHorizon_Private_Static_Void_float2_Single_Single_Single_byref_float2_byref_float2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1101194, RefRangeEnd = 1101196, XrefRangeStart = 1101171, XrefRangeEnd = 1101194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetSphereYPlaneHorizon(float3 center, float sphereRadius, float near, float clipRadius, float y, out float3 left, out float3 right)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = (nint)(&center);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sphereRadius;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &near;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &clipRadius;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref left);
		*(void**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref right);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSphereYPlaneHorizon_Private_Static_Void_float3_Single_Single_Single_Single_byref_float3_byref_float3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1101203, RefRangeEnd = 1101204, XrefRangeStart = 1101196, XrefRangeEnd = 1101203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetCircleClipPoints(float3 circleCenter, float3 circleNormal, float circleRadius, float near, out float3 p0, out float3 p1)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&circleCenter);
		*(float3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &circleNormal;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &circleRadius;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &near;
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref p0);
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref p1);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCircleClipPoints_Private_Static_Boolean_float3_float3_Single_Single_byref_float3_byref_float3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1101216, RefRangeEnd = 1101217, XrefRangeStart = 1101204, XrefRangeEnd = 1101216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.ValueTuple<float, float> IntersectEllipseLine(float a, float b, float3 line)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&a);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		*(float3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &line;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IntersectEllipseLine_Private_Static_ValueTuple_2_Single_Single_Single_Single_float3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new Il2CppSystem.ValueTuple<float, float>(pointer);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1101226, RefRangeEnd = 1101228, XrefRangeStart = 1101217, XrefRangeEnd = 1101226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetProjectedCircleHorizon(float2 center, float radius, float2 U, float2 V, out float2 uv1, out float2 uv2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&center);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &radius;
		*(float2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &U;
		*(float2**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &V;
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref uv1);
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref uv2);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetProjectedCircleHorizon_Private_Static_Void_float2_Single_float2_float2_byref_float2_byref_float2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1101231, RefRangeEnd = 1101232, XrefRangeStart = 1101228, XrefRangeEnd = 1101231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IntersectCircleYPlane(float y, float3 circleCenter, float3 circleNormal, float3 circleU, float3 circleV, float circleRadius, out float3 p1, out float3 p2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = (nint)(&y);
		*(float3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &circleCenter;
		*(float3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &circleNormal;
		*(float3**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &circleU;
		*(float3**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &circleV;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &circleRadius;
		*(void**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref p1);
		*(void**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref p2);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IntersectCircleYPlane_Private_Static_Boolean_Single_float3_float3_float3_float3_Single_byref_float3_byref_float3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1101241, RefRangeEnd = 1101242, XrefRangeStart = 1101232, XrefRangeEnd = 1101241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetConeSideTangentPoints(float3 vertex, float3 axis, float cosHalfAngle, float circleRadius, float coneHeight, float range, float3 circleU, float3 circleV, out float3 l1, out float3 l2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[10];
		*ptr = (nint)(&vertex);
		*(float3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &axis;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &cosHalfAngle;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &circleRadius;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &coneHeight;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &range;
		*(float3**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &circleU;
		*(float3**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &circleV;
		*(void**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref l1);
		*(void**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref l2);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetConeSideTangentPoints_Private_Static_Void_float3_float3_Single_Single_Single_Single_float3_float3_byref_float3_byref_float3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1101258, RefRangeEnd = 1101264, XrefRangeStart = 1101242, XrefRangeEnd = 1101258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float3 EvaluateNearConic(float near, float3 o, float3 d, float r, float3 u, float3 v, float theta)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = (nint)(&near);
		*(float3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &o;
		*(float3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &d;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &r;
		*(float3**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &u;
		*(float3**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &v;
		*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &theta;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EvaluateNearConic_Private_Static_float3_Single_float3_float3_Single_float3_float3_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1101284, RefRangeEnd = 1101286, XrefRangeStart = 1101264, XrefRangeEnd = 1101284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float2 FindNearConicTangentTheta(float2 o, float2 d, float r, float2 u, float2 v)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&o);
		*(float2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &d;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &r;
		*(float2**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &u;
		*(float2**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &v;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindNearConicTangentTheta_Private_Static_float2_float2_float2_Single_float2_float2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float2*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1101341, RefRangeEnd = 1101342, XrefRangeStart = 1101286, XrefRangeEnd = 1101341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float2 FindNearConicYTheta(float near, float3 o, float3 d, float r, float3 u, float3 v, float y)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = (nint)(&near);
		*(float3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &o;
		*(float3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &d;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &r;
		*(float3**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &u;
		*(float3**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &v;
		*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindNearConicYTheta_Private_Static_float2_Single_float3_float3_Single_float3_float3_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float2*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 1101343, RefRangeEnd = 1101357, XrefRangeStart = 1101342, XrefRangeEnd = 1101343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Method_Internal_Static_Boolean_float3_byref___c__DisplayClass19_0_0(float3 p, ref __c__DisplayClass19_0 A_1)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&p);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref A_1);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Method_Internal_Static_Boolean_float3_byref___c__DisplayClass19_0_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1101359, RefRangeEnd = 1101365, XrefRangeStart = 1101357, XrefRangeEnd = 1101359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Method_Internal_Static_Boolean_float3_byref___c__DisplayClass19_0_1(float3 p, ref __c__DisplayClass19_0 A_1)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&p);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref A_1);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Method_Internal_Static_Boolean_float3_byref___c__DisplayClass19_0_1, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 1101343, RefRangeEnd = 1101357, XrefRangeStart = 1101343, XrefRangeEnd = 1101357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Method_Internal_Static_Boolean_float3_byref___c__DisplayClass20_0_0(float3 p, ref __c__DisplayClass20_0 A_1)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&p);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref A_1);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Method_Internal_Static_Boolean_float3_byref___c__DisplayClass20_0_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public TilingJob(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public TilingJob()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TilingJob>.NativeClassPtr))
	{
	}
}
