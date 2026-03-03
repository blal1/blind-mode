using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine.Jobs;

namespace UnityEngine.U2D.Animation;

public sealed class WorldToLocalTransformAccessJob : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_outMatrix;

	private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_TransformAccess_0;

	public unsafe NativeArray<float4x4> outMatrix
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outMatrix);
			return new NativeArray<float4x4>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float4x4>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outMatrix), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float4x4>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	static WorldToLocalTransformAccessJob()
	{
		Il2CppClassPointerStore<WorldToLocalTransformAccessJob>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.2D.Animation.Runtime.dll", "UnityEngine.U2D.Animation", "WorldToLocalTransformAccessJob");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldToLocalTransformAccessJob>.NativeClassPtr);
		NativeFieldInfoPtr_outMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldToLocalTransformAccessJob>.NativeClassPtr, "outMatrix");
		NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_TransformAccess_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldToLocalTransformAccessJob>.NativeClassPtr, 100663406);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 955106, RefRangeEnd = 955110, XrefRangeStart = 955104, XrefRangeEnd = 955106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	public WorldToLocalTransformAccessJob(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public WorldToLocalTransformAccessJob()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldToLocalTransformAccessJob>.NativeClassPtr))
	{
	}
}
