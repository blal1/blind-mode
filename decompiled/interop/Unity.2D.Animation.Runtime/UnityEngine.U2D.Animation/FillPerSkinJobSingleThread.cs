using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Unity.Collections;

namespace UnityEngine.U2D.Animation;

public sealed class FillPerSkinJobSingleThread : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_combinedSkinBatch;

	private static readonly System.IntPtr NativeFieldInfoPtr_isSpriteSkinValidForDeformArray;

	private static readonly System.IntPtr NativeFieldInfoPtr_spriteSkinDataArray;

	private static readonly System.IntPtr NativeFieldInfoPtr_perSkinJobDataArray;

	private static readonly System.IntPtr NativeFieldInfoPtr_combinedSkinBatchArray;

	private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;

	public unsafe PerSkinJobData combinedSkinBatch
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_combinedSkinBatch);
			return *(PerSkinJobData*)num;
		}
		set
		{
			*(PerSkinJobData*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_combinedSkinBatch)) = value;
		}
	}

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

	public unsafe NativeArray<SpriteSkinData> spriteSkinDataArray
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spriteSkinDataArray);
			return new NativeArray<SpriteSkinData>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<SpriteSkinData>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spriteSkinDataArray), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<SpriteSkinData>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<PerSkinJobData> perSkinJobDataArray
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_perSkinJobDataArray);
			return new NativeArray<PerSkinJobData>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<PerSkinJobData>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_perSkinJobDataArray), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<PerSkinJobData>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<PerSkinJobData> combinedSkinBatchArray
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_combinedSkinBatchArray);
			return new NativeArray<PerSkinJobData>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<PerSkinJobData>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_combinedSkinBatchArray), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<PerSkinJobData>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	static FillPerSkinJobSingleThread()
	{
		Il2CppClassPointerStore<FillPerSkinJobSingleThread>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.2D.Animation.Runtime.dll", "UnityEngine.U2D.Animation", "FillPerSkinJobSingleThread");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FillPerSkinJobSingleThread>.NativeClassPtr);
		NativeFieldInfoPtr_combinedSkinBatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FillPerSkinJobSingleThread>.NativeClassPtr, "combinedSkinBatch");
		NativeFieldInfoPtr_isSpriteSkinValidForDeformArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FillPerSkinJobSingleThread>.NativeClassPtr, "isSpriteSkinValidForDeformArray");
		NativeFieldInfoPtr_spriteSkinDataArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FillPerSkinJobSingleThread>.NativeClassPtr, "spriteSkinDataArray");
		NativeFieldInfoPtr_perSkinJobDataArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FillPerSkinJobSingleThread>.NativeClassPtr, "perSkinJobDataArray");
		NativeFieldInfoPtr_combinedSkinBatchArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FillPerSkinJobSingleThread>.NativeClassPtr, "combinedSkinBatchArray");
		NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FillPerSkinJobSingleThread>.NativeClassPtr, 100663337);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 954301, XrefRangeEnd = 954302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Execute()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public FillPerSkinJobSingleThread(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public FillPerSkinJobSingleThread()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FillPerSkinJobSingleThread>.NativeClassPtr))
	{
	}
}
