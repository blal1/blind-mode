using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine;

[StructLayout(LayoutKind.Explicit)]
public struct CombineInstance
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_MeshInstanceID;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SubMeshIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Transform;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LightmapScaleOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RealtimeLightmapScaleOffset;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_mesh_Public_set_Void_Mesh_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_subMeshIndex_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_transform_Public_set_Void_Matrix4x4_0;

	[FieldOffset(0)]
	public int m_MeshInstanceID;

	[FieldOffset(4)]
	public int m_SubMeshIndex;

	[FieldOffset(8)]
	public Matrix4x4 m_Transform;

	[FieldOffset(72)]
	public Vector4 m_LightmapScaleOffset;

	[FieldOffset(88)]
	public Vector4 m_RealtimeLightmapScaleOffset;

	public unsafe Mesh mesh
	{
		get
		{
			return Mesh.FromInstanceID(m_MeshInstanceID);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1179342, RefRangeEnd = 1179343, XrefRangeStart = 1179337, XrefRangeEnd = 1179342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_mesh_Public_set_Void_Mesh_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int subMeshIndex
	{
		get
		{
			return m_SubMeshIndex;
		}
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 376349, RefRangeEnd = 376359, XrefRangeStart = 376349, XrefRangeEnd = 376359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_subMeshIndex_Public_set_Void_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Matrix4x4 transform
	{
		get
		{
			return m_Transform;
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1179343, RefRangeEnd = 1179344, XrefRangeStart = 1179343, XrefRangeEnd = 1179343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_transform_Public_set_Void_Matrix4x4_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public Vector4 lightmapScaleOffset
	{
		get
		{
			return m_LightmapScaleOffset;
		}
		set
		{
			m_LightmapScaleOffset = value;
		}
	}

	public Vector4 realtimeLightmapScaleOffset
	{
		get
		{
			return m_RealtimeLightmapScaleOffset;
		}
		set
		{
			m_RealtimeLightmapScaleOffset = value;
		}
	}

	static CombineInstance()
	{
		Il2CppClassPointerStore<CombineInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "CombineInstance");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CombineInstance>.NativeClassPtr);
		NativeFieldInfoPtr_m_MeshInstanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombineInstance>.NativeClassPtr, "m_MeshInstanceID");
		NativeFieldInfoPtr_m_SubMeshIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombineInstance>.NativeClassPtr, "m_SubMeshIndex");
		NativeFieldInfoPtr_m_Transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombineInstance>.NativeClassPtr, "m_Transform");
		NativeFieldInfoPtr_m_LightmapScaleOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombineInstance>.NativeClassPtr, "m_LightmapScaleOffset");
		NativeFieldInfoPtr_m_RealtimeLightmapScaleOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombineInstance>.NativeClassPtr, "m_RealtimeLightmapScaleOffset");
		NativeMethodInfoPtr_set_mesh_Public_set_Void_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombineInstance>.NativeClassPtr, 100665101);
		NativeMethodInfoPtr_set_subMeshIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombineInstance>.NativeClassPtr, 100665102);
		NativeMethodInfoPtr_set_transform_Public_set_Void_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombineInstance>.NativeClassPtr, 100665103);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CombineInstance>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
