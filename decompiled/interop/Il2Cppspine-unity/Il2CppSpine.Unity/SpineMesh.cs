using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppSpine.Unity;

public static class SpineMesh : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_MeshHideflags;

	private static readonly System.IntPtr NativeMethodInfoPtr_NewSkeletonMesh_Public_Static_Mesh_0;

	public unsafe static HideFlags MeshHideflags
	{
		get
		{
			Unsafe.SkipInit(out HideFlags result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MeshHideflags, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MeshHideflags, (void*)(&value));
		}
	}

	static SpineMesh()
	{
		Il2CppClassPointerStore<SpineMesh>.NativeClassPtr = IL2CPP.GetIl2CppClass("spine-unity.dll", "Spine.Unity", "SpineMesh");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpineMesh>.NativeClassPtr);
		NativeFieldInfoPtr_MeshHideflags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpineMesh>.NativeClassPtr, "MeshHideflags");
		NativeMethodInfoPtr_NewSkeletonMesh_Public_Static_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpineMesh>.NativeClassPtr, 100664107);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 857632, RefRangeEnd = 857634, XrefRangeStart = 857623, XrefRangeEnd = 857632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Mesh NewSkeletonMesh()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NewSkeletonMesh_Public_Static_Mesh_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
	}

	public SpineMesh(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
