using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Unity.Collections;
using Unity.Mathematics;

namespace UnityEngine.U2D.Animation;

public sealed class PrepareDeformJob : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_perSkinJobData;

	private static readonly System.IntPtr NativeFieldInfoPtr_batchDataSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_boneLookupData;

	private static readonly System.IntPtr NativeFieldInfoPtr_vertexLookupData;

	private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;

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

	public unsafe int batchDataSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_batchDataSize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_batchDataSize)) = value;
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

	static PrepareDeformJob()
	{
		Il2CppClassPointerStore<PrepareDeformJob>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.2D.Animation.Runtime.dll", "UnityEngine.U2D.Animation", "PrepareDeformJob");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrepareDeformJob>.NativeClassPtr);
		NativeFieldInfoPtr_perSkinJobData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrepareDeformJob>.NativeClassPtr, "perSkinJobData");
		NativeFieldInfoPtr_batchDataSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrepareDeformJob>.NativeClassPtr, "batchDataSize");
		NativeFieldInfoPtr_boneLookupData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrepareDeformJob>.NativeClassPtr, "boneLookupData");
		NativeFieldInfoPtr_vertexLookupData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrepareDeformJob>.NativeClassPtr, "vertexLookupData");
		NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrepareDeformJob>.NativeClassPtr, 100663333);
	}

	[CallerCount(0)]
	public unsafe virtual void Execute()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public PrepareDeformJob(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public PrepareDeformJob()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrepareDeformJob>.NativeClassPtr))
	{
	}
}
