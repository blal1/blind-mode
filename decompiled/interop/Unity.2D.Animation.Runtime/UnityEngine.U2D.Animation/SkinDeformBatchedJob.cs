using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Unity.Collections;
using Unity.Mathematics;

namespace UnityEngine.U2D.Animation;

public sealed class SkinDeformBatchedJob : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_vertices;

	private static readonly System.IntPtr NativeFieldInfoPtr_finalBoneTransforms;

	private static readonly System.IntPtr NativeFieldInfoPtr_perSkinJobData;

	private static readonly System.IntPtr NativeFieldInfoPtr_spriteSkinData;

	private static readonly System.IntPtr NativeFieldInfoPtr_vertexLookupData;

	private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0;

	public unsafe NativeSlice<byte> vertices
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vertices);
			return new NativeSlice<byte>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeSlice<byte>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vertices), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeSlice<byte>>.NativeClassPtr, ref *(uint*)null));
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

	public unsafe NativeArray<PerSkinJobData> perSkinJobData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_perSkinJobData);
			return new NativeArray<PerSkinJobData>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<PerSkinJobData>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_perSkinJobData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<PerSkinJobData>>.NativeClassPtr, ref *(uint*)null));
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

	public unsafe NativeArray<int2> vertexLookupData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vertexLookupData);
			return new NativeArray<int2>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int2>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vertexLookupData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int2>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	static SkinDeformBatchedJob()
	{
		Il2CppClassPointerStore<SkinDeformBatchedJob>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.2D.Animation.Runtime.dll", "UnityEngine.U2D.Animation", "SkinDeformBatchedJob");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkinDeformBatchedJob>.NativeClassPtr);
		NativeFieldInfoPtr_vertices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkinDeformBatchedJob>.NativeClassPtr, "vertices");
		NativeFieldInfoPtr_finalBoneTransforms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkinDeformBatchedJob>.NativeClassPtr, "finalBoneTransforms");
		NativeFieldInfoPtr_perSkinJobData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkinDeformBatchedJob>.NativeClassPtr, "perSkinJobData");
		NativeFieldInfoPtr_spriteSkinData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkinDeformBatchedJob>.NativeClassPtr, "spriteSkinData");
		NativeFieldInfoPtr_vertexLookupData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkinDeformBatchedJob>.NativeClassPtr, "vertexLookupData");
		NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinDeformBatchedJob>.NativeClassPtr, 100663335);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 954247, XrefRangeEnd = 954294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Execute(int i)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&i);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public SkinDeformBatchedJob(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public SkinDeformBatchedJob()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkinDeformBatchedJob>.NativeClassPtr))
	{
	}
}
