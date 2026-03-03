using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Unity.Collections;
using Unity.Mathematics;

namespace UnityEngine.U2D.Animation;

public sealed class BoneDeformBatchedJob : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_boneTransform;

	private static readonly System.IntPtr NativeFieldInfoPtr_rootTransform;

	private static readonly System.IntPtr NativeFieldInfoPtr_boneLookupData;

	private static readonly System.IntPtr NativeFieldInfoPtr_spriteSkinData;

	private static readonly System.IntPtr NativeFieldInfoPtr_rootTransformIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_boneTransformIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_finalBoneTransforms;

	private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0;

	public unsafe NativeArray<float4x4> boneTransform
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_boneTransform);
			return new NativeArray<float4x4>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float4x4>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_boneTransform), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float4x4>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<float4x4> rootTransform
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rootTransform);
			return new NativeArray<float4x4>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float4x4>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rootTransform), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float4x4>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<int2> boneLookupData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_boneLookupData);
			return new NativeArray<int2>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int2>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_boneLookupData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int2>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<SpriteSkinData> spriteSkinData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spriteSkinData);
			return new NativeArray<SpriteSkinData>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<SpriteSkinData>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spriteSkinData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<SpriteSkinData>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeHashMap<int, TransformAccessJob.TransformData> rootTransformIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rootTransformIndex);
			return new NativeHashMap<int, TransformAccessJob.TransformData>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeHashMap<int, TransformAccessJob.TransformData>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rootTransformIndex), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<int, TransformAccessJob.TransformData>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeHashMap<int, TransformAccessJob.TransformData> boneTransformIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_boneTransformIndex);
			return new NativeHashMap<int, TransformAccessJob.TransformData>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeHashMap<int, TransformAccessJob.TransformData>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_boneTransformIndex), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<int, TransformAccessJob.TransformData>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<float4x4> finalBoneTransforms
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_finalBoneTransforms);
			return new NativeArray<float4x4>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float4x4>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_finalBoneTransforms), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float4x4>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	static BoneDeformBatchedJob()
	{
		Il2CppClassPointerStore<BoneDeformBatchedJob>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.2D.Animation.Runtime.dll", "UnityEngine.U2D.Animation", "BoneDeformBatchedJob");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoneDeformBatchedJob>.NativeClassPtr);
		NativeFieldInfoPtr_boneTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoneDeformBatchedJob>.NativeClassPtr, "boneTransform");
		NativeFieldInfoPtr_rootTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoneDeformBatchedJob>.NativeClassPtr, "rootTransform");
		NativeFieldInfoPtr_boneLookupData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoneDeformBatchedJob>.NativeClassPtr, "boneLookupData");
		NativeFieldInfoPtr_spriteSkinData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoneDeformBatchedJob>.NativeClassPtr, "spriteSkinData");
		NativeFieldInfoPtr_rootTransformIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoneDeformBatchedJob>.NativeClassPtr, "rootTransformIndex");
		NativeFieldInfoPtr_boneTransformIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoneDeformBatchedJob>.NativeClassPtr, "boneTransformIndex");
		NativeFieldInfoPtr_finalBoneTransforms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoneDeformBatchedJob>.NativeClassPtr, "finalBoneTransforms");
		NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneDeformBatchedJob>.NativeClassPtr, 100663334);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 954233, XrefRangeEnd = 954247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Execute(int i)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&i);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public BoneDeformBatchedJob(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public BoneDeformBatchedJob()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoneDeformBatchedJob>.NativeClassPtr))
	{
	}
}
