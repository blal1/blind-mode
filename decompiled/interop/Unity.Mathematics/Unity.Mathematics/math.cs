using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Mathematics;

public static class math : Il2CppSystem.Object
{
	[StructLayout(LayoutKind.Explicit)]
	public struct LongDoubleUnion
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_longValue;

		private static readonly System.IntPtr NativeFieldInfoPtr_doubleValue;

		[FieldOffset(0)]
		public long longValue;

		[FieldOffset(0)]
		public double doubleValue;

		static LongDoubleUnion()
		{
			Il2CppClassPointerStore<LongDoubleUnion>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<math>.NativeClassPtr, "LongDoubleUnion");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LongDoubleUnion>.NativeClassPtr);
			NativeFieldInfoPtr_longValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LongDoubleUnion>.NativeClassPtr, "longValue");
			NativeFieldInfoPtr_doubleValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LongDoubleUnion>.NativeClassPtr, "doubleValue");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LongDoubleUnion>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_hash_Public_Static_UInt32_bool2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_hash_Public_Static_UInt32_bool4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_float2_Public_Static_float2_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_hash_Public_Static_UInt32_float2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_float2x2_Public_Static_float2x2_float2_float2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_determinant_Public_Static_Single_float2x2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_hash_Public_Static_UInt32_float2x2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_float3_Public_Static_float3_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_float3_Public_Static_float3_Single_float2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_float3_Public_Static_float3_float2_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_hash_Public_Static_UInt32_float3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_float3x3_Public_Static_float3x3_float3_float3_float3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_float3x3_Public_Static_float3x3_Single_Single_Single_Single_Single_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_transpose_Public_Static_float3x3_float3x3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_determinant_Public_Static_Single_float3x3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_hash_Public_Static_UInt32_float3x3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_float4_Public_Static_float4_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_float4_Public_Static_float4_float2_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_float4_Public_Static_float4_float2_float2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_float4_Public_Static_float4_float3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_hash_Public_Static_UInt32_float4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_float4x4_Public_Static_float4x4_float4_float4_float4_float4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_transform_Public_Static_float3_float4x4_float3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_hash_Public_Static_UInt32_float4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_int2_Public_Static_int2_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_hash_Public_Static_UInt32_int2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_hash_Public_Static_UInt32_int3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_hash_Public_Static_UInt32_int4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_asuint_Public_Static_uint2_int2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_asuint_Public_Static_uint3_int3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_asuint_Public_Static_uint4_int4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_asuint_Public_Static_UInt32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_asuint_Public_Static_uint2_float2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_asuint_Public_Static_uint3_float3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_asuint_Public_Static_uint4_float4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_asfloat_Public_Static_Single_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_asfloat_Public_Static_float3_uint3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_asfloat_Public_Static_float4_uint4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isnan_Public_Static_bool4_float4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_min_Public_Static_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_min_Public_Static_UInt32_UInt32_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_min_Public_Static_Int64_Int64_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_min_Public_Static_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_min_Public_Static_float3_float3_float3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_min_Public_Static_float4_float4_float4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_max_Public_Static_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_max_Public_Static_int2_int2_int2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_max_Public_Static_UInt32_UInt32_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_max_Public_Static_Int64_Int64_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_max_Public_Static_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_max_Public_Static_float3_float3_float3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_max_Public_Static_float4_float4_float4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_lerp_Public_Static_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_lerp_Public_Static_float3_float3_float3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_clamp_Public_Static_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_clamp_Public_Static_UInt32_UInt32_UInt32_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_clamp_Public_Static_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_saturate_Public_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_abs_Public_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_abs_Public_Static_float3_float3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_abs_Public_Static_float4_float4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_dot_Public_Static_Single_float2_float2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_dot_Public_Static_Single_float3_float3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_dot_Public_Static_Single_float4_float4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_atan_Public_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_atan_Public_Static_float2_float2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_cos_Public_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_cos_Public_Static_float3_float3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_sin_Public_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_sin_Public_Static_float3_float3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_rcp_Public_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_rcp_Public_Static_float2_float2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_log2_Public_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_sqrt_Public_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_rsqrt_Public_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_normalize_Public_Static_float2_float2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_normalize_Public_Static_float3_float3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_length_Public_Static_Single_float2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_length_Public_Static_Single_float3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_length_Public_Static_Single_float4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_lengthsq_Public_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_lengthsq_Public_Static_Single_float2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_lengthsq_Public_Static_Single_float3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_lengthsq_Public_Static_Single_float4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_distance_Public_Static_Single_float3_float3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_distancesq_Public_Static_Single_float3_float3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_distancesq_Public_Static_Single_float4_float4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_cross_Public_Static_float3_float3_float3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_any_Public_Static_Boolean_bool2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_any_Public_Static_Boolean_bool4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_select_Public_Static_UInt32_UInt32_UInt32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_select_Public_Static_uint2_uint2_uint2_bool2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_select_Public_Static_uint4_uint4_uint4_bool4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_sincos_Public_Static_Void_float3_byref_float3_byref_float3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_countbits_Public_Static_Int32_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_lzcnt_Public_Static_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_lzcnt_Public_Static_Int32_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_tzcnt_Public_Static_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_tzcnt_Public_Static_Int32_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_tzcnt_Public_Static_Int32_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_rol_Public_Static_UInt32_UInt32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ceilpow2_Public_Static_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ceilpow2_Public_Static_int2_int2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ceilpow2_Public_Static_UInt32_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ceillog2_Public_Static_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_floorlog2_Public_Static_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_radians_Public_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_csum_Public_Static_UInt32_uint2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_csum_Public_Static_UInt32_uint3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_csum_Public_Static_UInt32_uint4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_csum_Public_Static_Single_float3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_f16tof32_Public_Static_Single_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_hash_with_unaligned_loads_Private_Static_UInt32_ptr_Void_Int32_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_hash_Public_Static_UInt32_ptr_Void_Int32_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_float3x3_Public_Static_float3x3_quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_mul_Public_Static_float3_float3x3_float3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_mul_Public_Static_float3x3_float3x3_float3x3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_mul_Public_Static_float4_float4x4_float4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_mul_Public_Static_float4x4_float4x4_float4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_quaternion_Public_Static_quaternion_float4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_mul_Public_Static_quaternion_quaternion_quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_hash_Public_Static_UInt32_quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_uint2_Public_Static_uint2_UInt32_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_hash_Public_Static_UInt32_uint2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_uint3_Public_Static_uint3_UInt32_UInt32_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_hash_Public_Static_UInt32_uint3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_uint4_Public_Static_uint4_UInt32_UInt32_UInt32_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_hash_Public_Static_UInt32_uint4_0;

	static math()
	{
		Il2CppClassPointerStore<math>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Mathematics.dll", "Unity.Mathematics", "math");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<math>.NativeClassPtr);
		NativeMethodInfoPtr_hash_Public_Static_UInt32_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663298);
		NativeMethodInfoPtr_hash_Public_Static_UInt32_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663299);
		NativeMethodInfoPtr_float2_Public_Static_float2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663300);
		NativeMethodInfoPtr_hash_Public_Static_UInt32_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663301);
		NativeMethodInfoPtr_float2x2_Public_Static_float2x2_float2_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663302);
		NativeMethodInfoPtr_determinant_Public_Static_Single_float2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663303);
		NativeMethodInfoPtr_hash_Public_Static_UInt32_float2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663304);
		NativeMethodInfoPtr_float3_Public_Static_float3_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663305);
		NativeMethodInfoPtr_float3_Public_Static_float3_Single_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663306);
		NativeMethodInfoPtr_float3_Public_Static_float3_float2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663307);
		NativeMethodInfoPtr_hash_Public_Static_UInt32_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663308);
		NativeMethodInfoPtr_float3x3_Public_Static_float3x3_float3_float3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663309);
		NativeMethodInfoPtr_float3x3_Public_Static_float3x3_Single_Single_Single_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663310);
		NativeMethodInfoPtr_transpose_Public_Static_float3x3_float3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663311);
		NativeMethodInfoPtr_determinant_Public_Static_Single_float3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663312);
		NativeMethodInfoPtr_hash_Public_Static_UInt32_float3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663313);
		NativeMethodInfoPtr_float4_Public_Static_float4_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663314);
		NativeMethodInfoPtr_float4_Public_Static_float4_float2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663315);
		NativeMethodInfoPtr_float4_Public_Static_float4_float2_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663316);
		NativeMethodInfoPtr_float4_Public_Static_float4_float3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663317);
		NativeMethodInfoPtr_hash_Public_Static_UInt32_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663318);
		NativeMethodInfoPtr_float4x4_Public_Static_float4x4_float4_float4_float4_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663319);
		NativeMethodInfoPtr_transform_Public_Static_float3_float4x4_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663320);
		NativeMethodInfoPtr_hash_Public_Static_UInt32_float4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663321);
		NativeMethodInfoPtr_int2_Public_Static_int2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663322);
		NativeMethodInfoPtr_hash_Public_Static_UInt32_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663323);
		NativeMethodInfoPtr_hash_Public_Static_UInt32_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663324);
		NativeMethodInfoPtr_hash_Public_Static_UInt32_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663325);
		NativeMethodInfoPtr_asuint_Public_Static_uint2_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663326);
		NativeMethodInfoPtr_asuint_Public_Static_uint3_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663327);
		NativeMethodInfoPtr_asuint_Public_Static_uint4_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663328);
		NativeMethodInfoPtr_asuint_Public_Static_UInt32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663329);
		NativeMethodInfoPtr_asuint_Public_Static_uint2_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663330);
		NativeMethodInfoPtr_asuint_Public_Static_uint3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663331);
		NativeMethodInfoPtr_asuint_Public_Static_uint4_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663332);
		NativeMethodInfoPtr_asfloat_Public_Static_Single_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663333);
		NativeMethodInfoPtr_asfloat_Public_Static_float3_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663334);
		NativeMethodInfoPtr_asfloat_Public_Static_float4_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663335);
		NativeMethodInfoPtr_isnan_Public_Static_bool4_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663336);
		NativeMethodInfoPtr_min_Public_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663337);
		NativeMethodInfoPtr_min_Public_Static_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663338);
		NativeMethodInfoPtr_min_Public_Static_Int64_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663339);
		NativeMethodInfoPtr_min_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663340);
		NativeMethodInfoPtr_min_Public_Static_float3_float3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663341);
		NativeMethodInfoPtr_min_Public_Static_float4_float4_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663342);
		NativeMethodInfoPtr_max_Public_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663343);
		NativeMethodInfoPtr_max_Public_Static_int2_int2_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663344);
		NativeMethodInfoPtr_max_Public_Static_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663345);
		NativeMethodInfoPtr_max_Public_Static_Int64_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663346);
		NativeMethodInfoPtr_max_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663347);
		NativeMethodInfoPtr_max_Public_Static_float3_float3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663348);
		NativeMethodInfoPtr_max_Public_Static_float4_float4_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663349);
		NativeMethodInfoPtr_lerp_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663350);
		NativeMethodInfoPtr_lerp_Public_Static_float3_float3_float3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663351);
		NativeMethodInfoPtr_clamp_Public_Static_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663352);
		NativeMethodInfoPtr_clamp_Public_Static_UInt32_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663353);
		NativeMethodInfoPtr_clamp_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663354);
		NativeMethodInfoPtr_saturate_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663355);
		NativeMethodInfoPtr_abs_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663356);
		NativeMethodInfoPtr_abs_Public_Static_float3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663357);
		NativeMethodInfoPtr_abs_Public_Static_float4_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663358);
		NativeMethodInfoPtr_dot_Public_Static_Single_float2_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663359);
		NativeMethodInfoPtr_dot_Public_Static_Single_float3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663360);
		NativeMethodInfoPtr_dot_Public_Static_Single_float4_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663361);
		NativeMethodInfoPtr_atan_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663362);
		NativeMethodInfoPtr_atan_Public_Static_float2_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663363);
		NativeMethodInfoPtr_cos_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663364);
		NativeMethodInfoPtr_cos_Public_Static_float3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663365);
		NativeMethodInfoPtr_sin_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663366);
		NativeMethodInfoPtr_sin_Public_Static_float3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663367);
		NativeMethodInfoPtr_rcp_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663368);
		NativeMethodInfoPtr_rcp_Public_Static_float2_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663369);
		NativeMethodInfoPtr_log2_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663370);
		NativeMethodInfoPtr_sqrt_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663371);
		NativeMethodInfoPtr_rsqrt_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663372);
		NativeMethodInfoPtr_normalize_Public_Static_float2_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663373);
		NativeMethodInfoPtr_normalize_Public_Static_float3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663374);
		NativeMethodInfoPtr_length_Public_Static_Single_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663375);
		NativeMethodInfoPtr_length_Public_Static_Single_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663376);
		NativeMethodInfoPtr_length_Public_Static_Single_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663377);
		NativeMethodInfoPtr_lengthsq_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663378);
		NativeMethodInfoPtr_lengthsq_Public_Static_Single_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663379);
		NativeMethodInfoPtr_lengthsq_Public_Static_Single_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663380);
		NativeMethodInfoPtr_lengthsq_Public_Static_Single_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663381);
		NativeMethodInfoPtr_distance_Public_Static_Single_float3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663382);
		NativeMethodInfoPtr_distancesq_Public_Static_Single_float3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663383);
		NativeMethodInfoPtr_distancesq_Public_Static_Single_float4_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663384);
		NativeMethodInfoPtr_cross_Public_Static_float3_float3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663385);
		NativeMethodInfoPtr_any_Public_Static_Boolean_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663386);
		NativeMethodInfoPtr_any_Public_Static_Boolean_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663387);
		NativeMethodInfoPtr_select_Public_Static_UInt32_UInt32_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663388);
		NativeMethodInfoPtr_select_Public_Static_uint2_uint2_uint2_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663389);
		NativeMethodInfoPtr_select_Public_Static_uint4_uint4_uint4_bool4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663390);
		NativeMethodInfoPtr_sincos_Public_Static_Void_float3_byref_float3_byref_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663391);
		NativeMethodInfoPtr_countbits_Public_Static_Int32_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663392);
		NativeMethodInfoPtr_lzcnt_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663393);
		NativeMethodInfoPtr_lzcnt_Public_Static_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663394);
		NativeMethodInfoPtr_tzcnt_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663395);
		NativeMethodInfoPtr_tzcnt_Public_Static_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663396);
		NativeMethodInfoPtr_tzcnt_Public_Static_Int32_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663397);
		NativeMethodInfoPtr_rol_Public_Static_UInt32_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663398);
		NativeMethodInfoPtr_ceilpow2_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663399);
		NativeMethodInfoPtr_ceilpow2_Public_Static_int2_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663400);
		NativeMethodInfoPtr_ceilpow2_Public_Static_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663401);
		NativeMethodInfoPtr_ceillog2_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663402);
		NativeMethodInfoPtr_floorlog2_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663403);
		NativeMethodInfoPtr_radians_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663404);
		NativeMethodInfoPtr_csum_Public_Static_UInt32_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663405);
		NativeMethodInfoPtr_csum_Public_Static_UInt32_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663406);
		NativeMethodInfoPtr_csum_Public_Static_UInt32_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663407);
		NativeMethodInfoPtr_csum_Public_Static_Single_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663408);
		NativeMethodInfoPtr_f16tof32_Public_Static_Single_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663409);
		NativeMethodInfoPtr_hash_with_unaligned_loads_Private_Static_UInt32_ptr_Void_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663410);
		NativeMethodInfoPtr_hash_Public_Static_UInt32_ptr_Void_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663411);
		NativeMethodInfoPtr_float3x3_Public_Static_float3x3_quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663412);
		NativeMethodInfoPtr_mul_Public_Static_float3_float3x3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663413);
		NativeMethodInfoPtr_mul_Public_Static_float3x3_float3x3_float3x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663414);
		NativeMethodInfoPtr_mul_Public_Static_float4_float4x4_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663415);
		NativeMethodInfoPtr_mul_Public_Static_float4x4_float4x4_float4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663416);
		NativeMethodInfoPtr_quaternion_Public_Static_quaternion_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663417);
		NativeMethodInfoPtr_mul_Public_Static_quaternion_quaternion_quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663418);
		NativeMethodInfoPtr_hash_Public_Static_UInt32_quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663419);
		NativeMethodInfoPtr_uint2_Public_Static_uint2_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663420);
		NativeMethodInfoPtr_hash_Public_Static_UInt32_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663421);
		NativeMethodInfoPtr_uint3_Public_Static_uint3_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663422);
		NativeMethodInfoPtr_hash_Public_Static_UInt32_uint3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663423);
		NativeMethodInfoPtr_uint4_Public_Static_uint4_UInt32_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663424);
		NativeMethodInfoPtr_hash_Public_Static_UInt32_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<math>.NativeClassPtr, 100663425);
	}

	[CallerCount(0)]
	public unsafe static uint hash(bool2 v)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&v);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_hash_Public_Static_UInt32_bool2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static uint hash(bool4 v)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&v);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_hash_Public_Static_UInt32_bool4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float2 float2(float x, float y)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_float2_Public_Static_float2_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float2*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static uint hash(float2 v)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&v);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_hash_Public_Static_UInt32_float2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float2x2 float2x2(float2 c0, float2 c1)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&c0);
		*(float2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &c1;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_float2x2_Public_Static_float2x2_float2_float2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float2x2*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float determinant(float2x2 m)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&m);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_determinant_Public_Static_Single_float2x2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static uint hash(float2x2 v)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&v);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_hash_Public_Static_UInt32_float2x2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float3 float3(float x, float y, float z)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&x);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &z;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_float3_Public_Static_float3_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float3 float3(float x, float2 yz)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(float2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &yz;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_float3_Public_Static_float3_Single_float2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float3 float3(float2 xy, float z)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&xy);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &z;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_float3_Public_Static_float3_float2_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static uint hash(float3 v)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&v);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_hash_Public_Static_UInt32_float3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float3x3 float3x3(float3 c0, float3 c1, float3 c2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&c0);
		*(float3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &c1;
		*(float3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &c2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_float3x3_Public_Static_float3x3_float3_float3_float3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float3x3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float3x3 float3x3(float m00, float m01, float m02, float m10, float m11, float m12, float m20, float m21, float m22)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[9];
		*ptr = (nint)(&m00);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &m01;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &m02;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &m10;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &m11;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &m12;
		*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &m20;
		*(float**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &m21;
		*(float**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &m22;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_float3x3_Public_Static_float3x3_Single_Single_Single_Single_Single_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float3x3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float3x3 transpose(float3x3 v)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&v);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_transpose_Public_Static_float3x3_float3x3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float3x3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float determinant(float3x3 m)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&m);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_determinant_Public_Static_Single_float3x3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static uint hash(float3x3 v)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&v);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_hash_Public_Static_UInt32_float3x3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float4 float4(float x, float y, float z, float w)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&x);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &z;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &w;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_float4_Public_Static_float4_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float4*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float4 float4(float2 xy, float z, float w)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&xy);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &z;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &w;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_float4_Public_Static_float4_float2_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float4*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float4 float4(float2 xy, float2 zw)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&xy);
		*(float2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &zw;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_float4_Public_Static_float4_float2_float2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float4*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float4 float4(float3 xyz, float w)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&xyz);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &w;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_float4_Public_Static_float4_float3_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float4*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static uint hash(float4 v)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&v);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_hash_Public_Static_UInt32_float4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float4x4 float4x4(float4 c0, float4 c1, float4 c2, float4 c3)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&c0);
		*(float4**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &c1;
		*(float4**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &c2;
		*(float4**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &c3;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_float4x4_Public_Static_float4x4_float4_float4_float4_float4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float4x4*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float3 transform(float4x4 a, float3 b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(float3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_transform_Public_Static_float3_float4x4_float3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1023128, RefRangeEnd = 1023129, XrefRangeStart = 1023128, XrefRangeEnd = 1023128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint hash(float4x4 v)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&v);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_hash_Public_Static_UInt32_float4x4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static int2 int2(int x, int y)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_int2_Public_Static_int2_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int2*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static uint hash(int2 v)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&v);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_hash_Public_Static_UInt32_int2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static uint hash(int3 v)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&v);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_hash_Public_Static_UInt32_int3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static uint hash(int4 v)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&v);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_hash_Public_Static_UInt32_int4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1403)]
	[CachedScanResults(RefRangeStart = 106100, RefRangeEnd = 107503, XrefRangeStart = 106100, XrefRangeEnd = 107503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint2 asuint(int2 x)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&x);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_asuint_Public_Static_uint2_int2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint2*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static uint3 asuint(int3 x)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&x);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_asuint_Public_Static_uint3_int3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 732551, RefRangeEnd = 732556, XrefRangeStart = 732551, XrefRangeEnd = 732556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint4 asuint(int4 x)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&x);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_asuint_Public_Static_uint4_int4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint4*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static uint asuint(float x)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&x);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_asuint_Public_Static_UInt32_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static uint2 asuint(float2 x)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&x);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_asuint_Public_Static_uint2_float2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint2*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static uint3 asuint(float3 x)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&x);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_asuint_Public_Static_uint3_float3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 732551, RefRangeEnd = 732556, XrefRangeStart = 732551, XrefRangeEnd = 732556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint4 asuint(float4 x)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&x);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_asuint_Public_Static_uint4_float4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint4*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float asfloat(uint x)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&x);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_asfloat_Public_Static_Single_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float3 asfloat(uint3 x)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&x);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_asfloat_Public_Static_float3_uint3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 732551, RefRangeEnd = 732556, XrefRangeStart = 732551, XrefRangeEnd = 732556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float4 asfloat(uint4 x)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&x);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_asfloat_Public_Static_float4_uint4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float4*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool4 isnan(float4 x)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&x);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isnan_Public_Static_bool4_float4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool4*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static int min(int x, int y)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_min_Public_Static_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static uint min(uint x, uint y)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_min_Public_Static_UInt32_UInt32_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static long min(long x, long y)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(long**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_min_Public_Static_Int64_Int64_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float min(float x, float y)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_min_Public_Static_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float3 min(float3 x, float3 y)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(float3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_min_Public_Static_float3_float3_float3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float4 min(float4 x, float4 y)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(float4**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_min_Public_Static_float4_float4_float4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float4*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static int max(int x, int y)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_max_Public_Static_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static int2 max(int2 x, int2 y)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(int2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_max_Public_Static_int2_int2_int2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int2*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static uint max(uint x, uint y)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_max_Public_Static_UInt32_UInt32_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static long max(long x, long y)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(long**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_max_Public_Static_Int64_Int64_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float max(float x, float y)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_max_Public_Static_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float3 max(float3 x, float3 y)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(float3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_max_Public_Static_float3_float3_float3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float4 max(float4 x, float4 y)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(float4**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_max_Public_Static_float4_float4_float4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float4*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float lerp(float start, float end, float t)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&start);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &t;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_lerp_Public_Static_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float3 lerp(float3 start, float3 end, float t)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&start);
		*(float3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &t;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_lerp_Public_Static_float3_float3_float3_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static int clamp(int valueToClamp, int lowerBound, int upperBound)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&valueToClamp);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &lowerBound;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &upperBound;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_clamp_Public_Static_Int32_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static uint clamp(uint valueToClamp, uint lowerBound, uint upperBound)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&valueToClamp);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &lowerBound;
		*(uint**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &upperBound;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_clamp_Public_Static_UInt32_UInt32_UInt32_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float clamp(float valueToClamp, float lowerBound, float upperBound)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&valueToClamp);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &lowerBound;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &upperBound;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_clamp_Public_Static_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float saturate(float x)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&x);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_saturate_Public_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float abs(float x)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&x);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_abs_Public_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float3 abs(float3 x)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&x);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_abs_Public_Static_float3_float3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float4 abs(float4 x)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&x);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_abs_Public_Static_float4_float4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float4*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float dot(float2 x, float2 y)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(float2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_dot_Public_Static_Single_float2_float2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float dot(float3 x, float3 y)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(float3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_dot_Public_Static_Single_float3_float3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float dot(float4 x, float4 y)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(float4**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_dot_Public_Static_Single_float4_float4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1023129, XrefRangeEnd = 1023133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float atan(float x)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&x);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_atan_Public_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1023141, RefRangeEnd = 1023143, XrefRangeStart = 1023133, XrefRangeEnd = 1023141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float2 atan(float2 x)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&x);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_atan_Public_Static_float2_float2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float2*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1023143, XrefRangeEnd = 1023147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float cos(float x)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&x);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_cos_Public_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1023159, RefRangeEnd = 1023161, XrefRangeStart = 1023147, XrefRangeEnd = 1023159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float3 cos(float3 x)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&x);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_cos_Public_Static_float3_float3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1023161, XrefRangeEnd = 1023165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float sin(float x)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&x);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_sin_Public_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1023177, RefRangeEnd = 1023179, XrefRangeStart = 1023165, XrefRangeEnd = 1023177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float3 sin(float3 x)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&x);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_sin_Public_Static_float3_float3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float rcp(float x)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&x);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_rcp_Public_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float2 rcp(float2 x)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&x);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_rcp_Public_Static_float2_float2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float2*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1023179, XrefRangeEnd = 1023183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float log2(float x)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&x);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_log2_Public_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1023183, XrefRangeEnd = 1023186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float sqrt(float x)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&x);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_sqrt_Public_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1023186, XrefRangeEnd = 1023187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float rsqrt(float x)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&x);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_rsqrt_Public_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1023187, XrefRangeEnd = 1023188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float2 normalize(float2 x)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&x);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_normalize_Public_Static_float2_float2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float2*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1023188, XrefRangeEnd = 1023189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float3 normalize(float3 x)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&x);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_normalize_Public_Static_float3_float3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1023189, XrefRangeEnd = 1023190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float length(float2 x)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&x);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_length_Public_Static_Single_float2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1023191, RefRangeEnd = 1023192, XrefRangeStart = 1023190, XrefRangeEnd = 1023191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float length(float3 x)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&x);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_length_Public_Static_Single_float3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1023192, XrefRangeEnd = 1023193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float length(float4 x)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&x);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_length_Public_Static_Single_float4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(101)]
	[CachedScanResults(RefRangeStart = 1023193, RefRangeEnd = 1023294, XrefRangeStart = 1023193, XrefRangeEnd = 1023193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float lengthsq(float x)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&x);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_lengthsq_Public_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float lengthsq(float2 x)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&x);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_lengthsq_Public_Static_Single_float2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float lengthsq(float3 x)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&x);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_lengthsq_Public_Static_Single_float3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float lengthsq(float4 x)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&x);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_lengthsq_Public_Static_Single_float4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1023294, XrefRangeEnd = 1023295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float distance(float3 x, float3 y)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(float3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_distance_Public_Static_Single_float3_float3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float distancesq(float3 x, float3 y)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(float3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_distancesq_Public_Static_Single_float3_float3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float distancesq(float4 x, float4 y)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(float4**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_distancesq_Public_Static_Single_float4_float4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float3 cross(float3 x, float3 y)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(float3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_cross_Public_Static_float3_float3_float3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool any(bool2 x)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&x);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_any_Public_Static_Boolean_bool2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool any(bool4 x)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&x);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_any_Public_Static_Boolean_bool4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static uint select(uint falseValue, uint trueValue, bool test)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&falseValue);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &trueValue;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &test;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_select_Public_Static_UInt32_UInt32_UInt32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static uint2 select(uint2 falseValue, uint2 trueValue, bool2 test)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&falseValue);
		*(uint2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &trueValue;
		*(bool2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &test;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_select_Public_Static_uint2_uint2_uint2_bool2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint2*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static uint4 select(uint4 falseValue, uint4 trueValue, bool4 test)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&falseValue);
		*(uint4**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &trueValue;
		*(bool4**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &test;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_select_Public_Static_uint4_uint4_uint4_bool4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint4*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1023295, XrefRangeEnd = 1023297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void sincos(float3 x, out float3 s, out float3 c)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&x);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref s);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref c);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_sincos_Public_Static_Void_float3_byref_float3_byref_float3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static int countbits(ulong x)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&x);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_countbits_Public_Static_Int32_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static int lzcnt(int x)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&x);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_lzcnt_Public_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static int lzcnt(uint x)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&x);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_lzcnt_Public_Static_Int32_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1023297, RefRangeEnd = 1023298, XrefRangeStart = 1023297, XrefRangeEnd = 1023297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int tzcnt(int x)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&x);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_tzcnt_Public_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1023297, RefRangeEnd = 1023298, XrefRangeStart = 1023297, XrefRangeEnd = 1023298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int tzcnt(uint x)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&x);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_tzcnt_Public_Static_Int32_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1023298, RefRangeEnd = 1023300, XrefRangeStart = 1023298, XrefRangeEnd = 1023298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int tzcnt(ulong x)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&x);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_tzcnt_Public_Static_Int32_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static uint rol(uint x, int n)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &n;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_rol_Public_Static_UInt32_UInt32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static int ceilpow2(int x)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&x);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ceilpow2_Public_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1023300, RefRangeEnd = 1023301, XrefRangeStart = 1023300, XrefRangeEnd = 1023300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int2 ceilpow2(int2 x)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&x);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ceilpow2_Public_Static_int2_int2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int2*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static uint ceilpow2(uint x)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&x);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ceilpow2_Public_Static_UInt32_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1023301, RefRangeEnd = 1023302, XrefRangeStart = 1023301, XrefRangeEnd = 1023301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ceillog2(int x)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&x);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ceillog2_Public_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 960166, RefRangeEnd = 960167, XrefRangeStart = 960166, XrefRangeEnd = 960167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int floorlog2(int x)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&x);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_floorlog2_Public_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float radians(float x)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&x);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_radians_Public_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static uint csum(uint2 x)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&x);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_csum_Public_Static_UInt32_uint2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static uint csum(uint3 x)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&x);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_csum_Public_Static_UInt32_uint3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static uint csum(uint4 x)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&x);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_csum_Public_Static_UInt32_uint4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float csum(float3 x)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&x);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_csum_Public_Static_Single_float3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float f16tof32(uint x)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&x);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_f16tof32_Public_Static_Single_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1023302, RefRangeEnd = 1023303, XrefRangeStart = 1023302, XrefRangeEnd = 1023302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint hash_with_unaligned_loads(void* pBuffer, int numBytes, uint seed)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)pBuffer;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &numBytes;
		*(uint**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &seed;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_hash_with_unaligned_loads_Private_Static_UInt32_ptr_Void_Int32_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1023304, RefRangeEnd = 1023309, XrefRangeStart = 1023303, XrefRangeEnd = 1023304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint hash(void* pBuffer, int numBytes, uint seed = 0u)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)pBuffer;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &numBytes;
		*(uint**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &seed;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_hash_Public_Static_UInt32_ptr_Void_Int32_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1023309, XrefRangeEnd = 1023310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float3x3 float3x3(quaternion rotation)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&rotation);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_float3x3_Public_Static_float3x3_quaternion_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float3x3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float3 mul(float3x3 a, float3 b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(float3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_mul_Public_Static_float3_float3x3_float3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1023310, RefRangeEnd = 1023311, XrefRangeStart = 1023310, XrefRangeEnd = 1023310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float3x3 mul(float3x3 a, float3x3 b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(float3x3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_mul_Public_Static_float3x3_float3x3_float3x3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float3x3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 1023311, RefRangeEnd = 1023327, XrefRangeStart = 1023311, XrefRangeEnd = 1023311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float4 mul(float4x4 a, float4 b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(float4**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_mul_Public_Static_float4_float4x4_float4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float4*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 1023327, RefRangeEnd = 1023336, XrefRangeStart = 1023327, XrefRangeEnd = 1023327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float4x4 mul(float4x4 a, float4x4 b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(float4x4**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_mul_Public_Static_float4x4_float4x4_float4x4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float4x4*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 732551, RefRangeEnd = 732556, XrefRangeStart = 732551, XrefRangeEnd = 732556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static quaternion quaternion(float4 value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_quaternion_Public_Static_quaternion_float4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(quaternion*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static quaternion mul(quaternion a, quaternion b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(quaternion**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_mul_Public_Static_quaternion_quaternion_quaternion_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(quaternion*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static uint hash(quaternion q)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&q);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_hash_Public_Static_UInt32_quaternion_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static uint2 uint2(uint x, uint y)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_uint2_Public_Static_uint2_UInt32_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint2*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static uint hash(uint2 v)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&v);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_hash_Public_Static_UInt32_uint2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static uint3 uint3(uint x, uint y, uint z)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&x);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(uint**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &z;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_uint3_Public_Static_uint3_UInt32_UInt32_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static uint hash(uint3 v)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&v);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_hash_Public_Static_UInt32_uint3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static uint4 uint4(uint x, uint y, uint z, uint w)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&x);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(uint**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &z;
		*(uint**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &w;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_uint4_Public_Static_uint4_UInt32_UInt32_UInt32_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint4*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static uint hash(uint4 v)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&v);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_hash_Public_Static_UInt32_uint4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public math(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
