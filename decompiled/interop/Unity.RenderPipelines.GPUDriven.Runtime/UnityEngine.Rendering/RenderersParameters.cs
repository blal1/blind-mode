using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

public sealed class RenderersParameters : Il2CppSystem.ValueType
{
	[OriginalName("Unity.RenderPipelines.GPUDriven.Runtime.dll", "", "Flags")]
	[System.Flags]
	public enum Flags
	{
		None = 0,
		UseBoundingSphereParameter = 1
	}

	public static class ParamNames : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__BaseColor;

		private static readonly System.IntPtr NativeFieldInfoPtr_unity_SpecCube0_HDR;

		private static readonly System.IntPtr NativeFieldInfoPtr_unity_SHCoefficients;

		private static readonly System.IntPtr NativeFieldInfoPtr_unity_LightmapST;

		private static readonly System.IntPtr NativeFieldInfoPtr_unity_ObjectToWorld;

		private static readonly System.IntPtr NativeFieldInfoPtr_unity_WorldToObject;

		private static readonly System.IntPtr NativeFieldInfoPtr_unity_MatrixPreviousM;

		private static readonly System.IntPtr NativeFieldInfoPtr_unity_MatrixPreviousMI;

		private static readonly System.IntPtr NativeFieldInfoPtr_unity_WorldBoundingSphere;

		private static readonly System.IntPtr NativeFieldInfoPtr_DOTS_ST_WindParams;

		private static readonly System.IntPtr NativeFieldInfoPtr_DOTS_ST_WindHistoryParams;

		public unsafe static int _BaseColor
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__BaseColor, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__BaseColor, (void*)(&value));
			}
		}

		public unsafe static int unity_SpecCube0_HDR
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_unity_SpecCube0_HDR, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_unity_SpecCube0_HDR, (void*)(&value));
			}
		}

		public unsafe static int unity_SHCoefficients
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_unity_SHCoefficients, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_unity_SHCoefficients, (void*)(&value));
			}
		}

		public unsafe static int unity_LightmapST
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_unity_LightmapST, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_unity_LightmapST, (void*)(&value));
			}
		}

		public unsafe static int unity_ObjectToWorld
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_unity_ObjectToWorld, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_unity_ObjectToWorld, (void*)(&value));
			}
		}

		public unsafe static int unity_WorldToObject
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_unity_WorldToObject, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_unity_WorldToObject, (void*)(&value));
			}
		}

		public unsafe static int unity_MatrixPreviousM
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_unity_MatrixPreviousM, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_unity_MatrixPreviousM, (void*)(&value));
			}
		}

		public unsafe static int unity_MatrixPreviousMI
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_unity_MatrixPreviousMI, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_unity_MatrixPreviousMI, (void*)(&value));
			}
		}

		public unsafe static int unity_WorldBoundingSphere
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_unity_WorldBoundingSphere, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_unity_WorldBoundingSphere, (void*)(&value));
			}
		}

		public unsafe static Il2CppStructArray<int> DOTS_ST_WindParams
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DOTS_ST_WindParams, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DOTS_ST_WindParams, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static Il2CppStructArray<int> DOTS_ST_WindHistoryParams
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DOTS_ST_WindHistoryParams, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DOTS_ST_WindHistoryParams, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static ParamNames()
		{
			Il2CppClassPointerStore<ParamNames>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RenderersParameters>.NativeClassPtr, "ParamNames");
			NativeFieldInfoPtr__BaseColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParamNames>.NativeClassPtr, "_BaseColor");
			NativeFieldInfoPtr_unity_SpecCube0_HDR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParamNames>.NativeClassPtr, "unity_SpecCube0_HDR");
			NativeFieldInfoPtr_unity_SHCoefficients = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParamNames>.NativeClassPtr, "unity_SHCoefficients");
			NativeFieldInfoPtr_unity_LightmapST = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParamNames>.NativeClassPtr, "unity_LightmapST");
			NativeFieldInfoPtr_unity_ObjectToWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParamNames>.NativeClassPtr, "unity_ObjectToWorld");
			NativeFieldInfoPtr_unity_WorldToObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParamNames>.NativeClassPtr, "unity_WorldToObject");
			NativeFieldInfoPtr_unity_MatrixPreviousM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParamNames>.NativeClassPtr, "unity_MatrixPreviousM");
			NativeFieldInfoPtr_unity_MatrixPreviousMI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParamNames>.NativeClassPtr, "unity_MatrixPreviousMI");
			NativeFieldInfoPtr_unity_WorldBoundingSphere = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParamNames>.NativeClassPtr, "unity_WorldBoundingSphere");
			NativeFieldInfoPtr_DOTS_ST_WindParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParamNames>.NativeClassPtr, "DOTS_ST_WindParams");
			NativeFieldInfoPtr_DOTS_ST_WindHistoryParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParamNames>.NativeClassPtr, "DOTS_ST_WindHistoryParams");
		}

		public ParamNames(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct ParamInfo
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_index;

		private static readonly System.IntPtr NativeFieldInfoPtr_gpuAddress;

		private static readonly System.IntPtr NativeFieldInfoPtr_uintOffset;

		[FieldOffset(0)]
		public int index;

		[FieldOffset(4)]
		public int gpuAddress;

		[FieldOffset(8)]
		public int uintOffset;

		static ParamInfo()
		{
			Il2CppClassPointerStore<ParamInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RenderersParameters>.NativeClassPtr, "ParamInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParamInfo>.NativeClassPtr);
			NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParamInfo>.NativeClassPtr, "index");
			NativeFieldInfoPtr_gpuAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParamInfo>.NativeClassPtr, "gpuAddress");
			NativeFieldInfoPtr_uintOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParamInfo>.NativeClassPtr, "uintOffset");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParamInfo>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_s_uintSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_lightmapScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_localToWorld;

	private static readonly System.IntPtr NativeFieldInfoPtr_worldToLocal;

	private static readonly System.IntPtr NativeFieldInfoPtr_matrixPreviousM;

	private static readonly System.IntPtr NativeFieldInfoPtr_matrixPreviousMI;

	private static readonly System.IntPtr NativeFieldInfoPtr_shCoefficients;

	private static readonly System.IntPtr NativeFieldInfoPtr_boundingSphere;

	private static readonly System.IntPtr NativeFieldInfoPtr_windParams;

	private static readonly System.IntPtr NativeFieldInfoPtr_windHistoryParams;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateInstanceDataBuffer_Public_Static_GPUInstanceDataBuffer_Flags_byref_InstanceNumInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_byref_GPUInstanceDataBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_ParamInfo_byref_GPUInstanceDataBuffer_Int32_Boolean_0;

	public unsafe static int s_uintSize
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_uintSize, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_uintSize, (void*)(&value));
		}
	}

	public unsafe ParamInfo lightmapScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightmapScale);
			return *(ParamInfo*)num;
		}
		set
		{
			*(ParamInfo*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightmapScale)) = value;
		}
	}

	public unsafe ParamInfo localToWorld
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localToWorld);
			return *(ParamInfo*)num;
		}
		set
		{
			*(ParamInfo*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localToWorld)) = value;
		}
	}

	public unsafe ParamInfo worldToLocal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldToLocal);
			return *(ParamInfo*)num;
		}
		set
		{
			*(ParamInfo*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldToLocal)) = value;
		}
	}

	public unsafe ParamInfo matrixPreviousM
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_matrixPreviousM);
			return *(ParamInfo*)num;
		}
		set
		{
			*(ParamInfo*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_matrixPreviousM)) = value;
		}
	}

	public unsafe ParamInfo matrixPreviousMI
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_matrixPreviousMI);
			return *(ParamInfo*)num;
		}
		set
		{
			*(ParamInfo*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_matrixPreviousMI)) = value;
		}
	}

	public unsafe ParamInfo shCoefficients
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shCoefficients);
			return *(ParamInfo*)num;
		}
		set
		{
			*(ParamInfo*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shCoefficients)) = value;
		}
	}

	public unsafe ParamInfo boundingSphere
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_boundingSphere);
			return *(ParamInfo*)num;
		}
		set
		{
			*(ParamInfo*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_boundingSphere)) = value;
		}
	}

	public unsafe Il2CppStructArray<ParamInfo> windParams
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_windParams);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<ParamInfo>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_windParams)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<ParamInfo> windHistoryParams
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_windHistoryParams);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<ParamInfo>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_windHistoryParams)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static RenderersParameters()
	{
		Il2CppClassPointerStore<RenderersParameters>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "RenderersParameters");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderersParameters>.NativeClassPtr);
		NativeFieldInfoPtr_s_uintSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderersParameters>.NativeClassPtr, "s_uintSize");
		NativeFieldInfoPtr_lightmapScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderersParameters>.NativeClassPtr, "lightmapScale");
		NativeFieldInfoPtr_localToWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderersParameters>.NativeClassPtr, "localToWorld");
		NativeFieldInfoPtr_worldToLocal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderersParameters>.NativeClassPtr, "worldToLocal");
		NativeFieldInfoPtr_matrixPreviousM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderersParameters>.NativeClassPtr, "matrixPreviousM");
		NativeFieldInfoPtr_matrixPreviousMI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderersParameters>.NativeClassPtr, "matrixPreviousMI");
		NativeFieldInfoPtr_shCoefficients = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderersParameters>.NativeClassPtr, "shCoefficients");
		NativeFieldInfoPtr_boundingSphere = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderersParameters>.NativeClassPtr, "boundingSphere");
		NativeFieldInfoPtr_windParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderersParameters>.NativeClassPtr, "windParams");
		NativeFieldInfoPtr_windHistoryParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderersParameters>.NativeClassPtr, "windHistoryParams");
		NativeMethodInfoPtr_CreateInstanceDataBuffer_Public_Static_GPUInstanceDataBuffer_Flags_byref_InstanceNumInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderersParameters>.NativeClassPtr, 100664055);
		NativeMethodInfoPtr__ctor_Public_Void_byref_GPUInstanceDataBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderersParameters>.NativeClassPtr, 100664056);
		NativeMethodInfoPtr_Method_Internal_Static_ParamInfo_byref_GPUInstanceDataBuffer_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderersParameters>.NativeClassPtr, 100664058);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1075383, RefRangeEnd = 1075384, XrefRangeStart = 1075332, XrefRangeEnd = 1075383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GPUInstanceDataBuffer CreateInstanceDataBuffer(Flags flags, [In] ref InstanceNumInfo instanceNumInfo)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&flags);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref instanceNumInfo);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateInstanceDataBuffer_Public_Static_GPUInstanceDataBuffer_Flags_byref_InstanceNumInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GPUInstanceDataBuffer>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1075459, RefRangeEnd = 1075461, XrefRangeStart = 1075384, XrefRangeEnd = 1075459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RenderersParameters([In] ref GPUInstanceDataBuffer instanceDataBuffer)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderersParameters>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)instanceDataBuffer);
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_byref_GPUInstanceDataBuffer_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		instanceDataBuffer = ((intPtr4 == (System.IntPtr)0) ? null : new GPUInstanceDataBuffer(intPtr4));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1075467, RefRangeEnd = 1075468, XrefRangeStart = 1075461, XrefRangeEnd = 1075467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ParamInfo Method_Internal_Static_ParamInfo_byref_GPUInstanceDataBuffer_Int32_Boolean_0([In] ref GPUInstanceDataBuffer instanceDataBuffer, int paramNameIdx, bool assertOnFail = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)instanceDataBuffer);
		*ptr = (nint)(&intPtr);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &paramNameIdx;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &assertOnFail;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Method_Internal_Static_ParamInfo_byref_GPUInstanceDataBuffer_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		instanceDataBuffer = ((intPtr4 == (System.IntPtr)0) ? null : new GPUInstanceDataBuffer(intPtr4));
		return *(ParamInfo*)IL2CPP.il2cpp_object_unbox(intPtr3);
	}

	public RenderersParameters(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public RenderersParameters()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderersParameters>.NativeClassPtr))
	{
	}
}
