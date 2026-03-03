using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine.Jobs;

namespace UnityEngine.Rendering.Universal;

public class DecalUpdateCachedSystem : Il2CppSystem.Object
{
	public sealed class UpdateTransformsJob : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_k_MinusYtoZRotation;

		private static readonly System.IntPtr NativeFieldInfoPtr_positions;

		private static readonly System.IntPtr NativeFieldInfoPtr_rotations;

		private static readonly System.IntPtr NativeFieldInfoPtr_scales;

		private static readonly System.IntPtr NativeFieldInfoPtr_dirty;

		private static readonly System.IntPtr NativeFieldInfoPtr_scaleModes;

		private static readonly System.IntPtr NativeFieldInfoPtr_sizeOffsets;

		private static readonly System.IntPtr NativeFieldInfoPtr_decalToWorlds;

		private static readonly System.IntPtr NativeFieldInfoPtr_normalToWorlds;

		private static readonly System.IntPtr NativeFieldInfoPtr_boundingSpheres;

		private static readonly System.IntPtr NativeFieldInfoPtr_minDistance;

		private static readonly System.IntPtr NativeMethodInfoPtr_DistanceBetweenQuaternions_Private_Single_quaternion_quaternion_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_TransformAccess_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetDecalProjectBoundingSphere_Private_BoundingSphere_Matrix4x4_0;

		public unsafe static quaternion k_MinusYtoZRotation
		{
			get
			{
				Unsafe.SkipInit(out quaternion result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_MinusYtoZRotation, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_MinusYtoZRotation, (void*)(&value));
			}
		}

		public unsafe NativeArray<float3> positions
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_positions);
				return new NativeArray<float3>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float3>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_positions), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float3>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<quaternion> rotations
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotations);
				return new NativeArray<quaternion>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<quaternion>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotations), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<quaternion>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<float3> scales
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scales);
				return new NativeArray<float3>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float3>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scales), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float3>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<bool> dirty
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dirty);
				return new NativeArray<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<bool>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dirty), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<bool>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<DecalScaleMode> scaleModes
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scaleModes);
				return new NativeArray<DecalScaleMode>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<DecalScaleMode>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scaleModes), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<DecalScaleMode>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<float4x4> sizeOffsets
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sizeOffsets);
				return new NativeArray<float4x4>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float4x4>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sizeOffsets), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float4x4>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<float4x4> decalToWorlds
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_decalToWorlds);
				return new NativeArray<float4x4>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float4x4>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_decalToWorlds), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float4x4>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<float4x4> normalToWorlds
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_normalToWorlds);
				return new NativeArray<float4x4>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float4x4>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_normalToWorlds), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float4x4>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<BoundingSphere> boundingSpheres
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_boundingSpheres);
				return new NativeArray<BoundingSphere>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<BoundingSphere>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_boundingSpheres), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<BoundingSphere>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe float minDistance
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minDistance);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minDistance)) = value;
			}
		}

		static UpdateTransformsJob()
		{
			Il2CppClassPointerStore<UpdateTransformsJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DecalUpdateCachedSystem>.NativeClassPtr, "UpdateTransformsJob");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateTransformsJob>.NativeClassPtr);
			NativeFieldInfoPtr_k_MinusYtoZRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTransformsJob>.NativeClassPtr, "k_MinusYtoZRotation");
			NativeFieldInfoPtr_positions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTransformsJob>.NativeClassPtr, "positions");
			NativeFieldInfoPtr_rotations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTransformsJob>.NativeClassPtr, "rotations");
			NativeFieldInfoPtr_scales = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTransformsJob>.NativeClassPtr, "scales");
			NativeFieldInfoPtr_dirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTransformsJob>.NativeClassPtr, "dirty");
			NativeFieldInfoPtr_scaleModes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTransformsJob>.NativeClassPtr, "scaleModes");
			NativeFieldInfoPtr_sizeOffsets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTransformsJob>.NativeClassPtr, "sizeOffsets");
			NativeFieldInfoPtr_decalToWorlds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTransformsJob>.NativeClassPtr, "decalToWorlds");
			NativeFieldInfoPtr_normalToWorlds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTransformsJob>.NativeClassPtr, "normalToWorlds");
			NativeFieldInfoPtr_boundingSpheres = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTransformsJob>.NativeClassPtr, "boundingSpheres");
			NativeFieldInfoPtr_minDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTransformsJob>.NativeClassPtr, "minDistance");
			NativeMethodInfoPtr_DistanceBetweenQuaternions_Private_Single_quaternion_quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTransformsJob>.NativeClassPtr, 100664135);
			NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_TransformAccess_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTransformsJob>.NativeClassPtr, 100664136);
			NativeMethodInfoPtr_GetDecalProjectBoundingSphere_Private_BoundingSphere_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTransformsJob>.NativeClassPtr, 100664137);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1082573, RefRangeEnd = 1082574, XrefRangeStart = 1082573, XrefRangeEnd = 1082573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float DistanceBetweenQuaternions(quaternion a, quaternion b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&a);
			*(quaternion**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DistanceBetweenQuaternions_Private_Single_quaternion_quaternion_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1082574, XrefRangeEnd = 1082611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Execute(int index, TransformAccess transform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&index);
			*(TransformAccess**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &transform;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_TransformAccess_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1082621, RefRangeEnd = 1082622, XrefRangeStart = 1082611, XrefRangeEnd = 1082621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BoundingSphere GetDecalProjectBoundingSphere(Matrix4x4 decalToWorld)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&decalToWorld);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDecalProjectBoundingSphere_Private_BoundingSphere_Matrix4x4_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(BoundingSphere*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public UpdateTransformsJob(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public UpdateTransformsJob()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpdateTransformsJob>.NativeClassPtr))
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_m_EntityManager;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Sampler;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SamplerJob;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_DecalEntityManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Private_Void_DecalEntityChunk_DecalCachedChunk_Int32_0;

	public unsafe DecalEntityManager m_EntityManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EntityManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DecalEntityManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EntityManager)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ProfilingSampler m_Sampler
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Sampler);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Sampler)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ProfilingSampler m_SamplerJob
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SamplerJob);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SamplerJob)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static DecalUpdateCachedSystem()
	{
		Il2CppClassPointerStore<DecalUpdateCachedSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "DecalUpdateCachedSystem");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecalUpdateCachedSystem>.NativeClassPtr);
		NativeFieldInfoPtr_m_EntityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalUpdateCachedSystem>.NativeClassPtr, "m_EntityManager");
		NativeFieldInfoPtr_m_Sampler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalUpdateCachedSystem>.NativeClassPtr, "m_Sampler");
		NativeFieldInfoPtr_m_SamplerJob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalUpdateCachedSystem>.NativeClassPtr, "m_SamplerJob");
		NativeMethodInfoPtr__ctor_Public_Void_DecalEntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalUpdateCachedSystem>.NativeClassPtr, 100664132);
		NativeMethodInfoPtr_Execute_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalUpdateCachedSystem>.NativeClassPtr, 100664133);
		NativeMethodInfoPtr_Execute_Private_Void_DecalEntityChunk_DecalCachedChunk_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalUpdateCachedSystem>.NativeClassPtr, 100664134);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1082637, RefRangeEnd = 1082638, XrefRangeStart = 1082622, XrefRangeEnd = 1082637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DecalUpdateCachedSystem(DecalEntityManager entityManager)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecalUpdateCachedSystem>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entityManager);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_DecalEntityManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1082652, RefRangeEnd = 1082653, XrefRangeStart = 1082638, XrefRangeEnd = 1082652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Execute()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Execute_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1082678, RefRangeEnd = 1082679, XrefRangeStart = 1082653, XrefRangeEnd = 1082678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Execute(DecalEntityChunk entityChunk, DecalCachedChunk cachedChunk, int count)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entityChunk);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cachedChunk);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Execute_Private_Void_DecalEntityChunk_DecalCachedChunk_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public DecalUpdateCachedSystem(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
