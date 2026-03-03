using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Unity.Collections;

namespace UnityEngine.U2D.Animation;

public sealed class CopySpriteRendererBoneTransformBuffersJob : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_isSpriteSkinValidForDeformArray;

	private static readonly System.IntPtr NativeFieldInfoPtr_spriteSkinData;

	private static readonly System.IntPtr NativeFieldInfoPtr_perSkinJobData;

	private static readonly System.IntPtr NativeFieldInfoPtr_ptrBoneTransforms;

	private static readonly System.IntPtr NativeFieldInfoPtr_buffers;

	private static readonly System.IntPtr NativeFieldInfoPtr_bufferSizes;

	private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0;

	public unsafe NativeArray<bool> isSpriteSkinValidForDeformArray
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isSpriteSkinValidForDeformArray);
			return new NativeArray<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<bool>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isSpriteSkinValidForDeformArray), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<bool>>.NativeClassPtr, ref *(uint*)null));
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

	public unsafe System.IntPtr ptrBoneTransforms
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ptrBoneTransforms);
			return *(System.IntPtr*)num;
		}
		set
		{
			*(System.IntPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ptrBoneTransforms)) = value;
		}
	}

	public unsafe NativeArray<System.IntPtr> buffers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buffers);
			return new NativeArray<System.IntPtr>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<System.IntPtr>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buffers), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<System.IntPtr>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<int> bufferSizes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bufferSizes);
			return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bufferSizes), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	static CopySpriteRendererBoneTransformBuffersJob()
	{
		Il2CppClassPointerStore<CopySpriteRendererBoneTransformBuffersJob>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.2D.Animation.Runtime.dll", "UnityEngine.U2D.Animation", "CopySpriteRendererBoneTransformBuffersJob");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CopySpriteRendererBoneTransformBuffersJob>.NativeClassPtr);
		NativeFieldInfoPtr_isSpriteSkinValidForDeformArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopySpriteRendererBoneTransformBuffersJob>.NativeClassPtr, "isSpriteSkinValidForDeformArray");
		NativeFieldInfoPtr_spriteSkinData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopySpriteRendererBoneTransformBuffersJob>.NativeClassPtr, "spriteSkinData");
		NativeFieldInfoPtr_perSkinJobData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopySpriteRendererBoneTransformBuffersJob>.NativeClassPtr, "perSkinJobData");
		NativeFieldInfoPtr_ptrBoneTransforms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopySpriteRendererBoneTransformBuffersJob>.NativeClassPtr, "ptrBoneTransforms");
		NativeFieldInfoPtr_buffers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopySpriteRendererBoneTransformBuffersJob>.NativeClassPtr, "buffers");
		NativeFieldInfoPtr_bufferSizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopySpriteRendererBoneTransformBuffersJob>.NativeClassPtr, "bufferSizes");
		NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopySpriteRendererBoneTransformBuffersJob>.NativeClassPtr, 100663339);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 954303, XrefRangeEnd = 954305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Execute(int i)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&i);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public CopySpriteRendererBoneTransformBuffersJob(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public CopySpriteRendererBoneTransformBuffersJob()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CopySpriteRendererBoneTransformBuffersJob>.NativeClassPtr))
	{
	}
}
