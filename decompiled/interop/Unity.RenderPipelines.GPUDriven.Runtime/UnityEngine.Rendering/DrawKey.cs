using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct DrawKey
{
	private static readonly System.IntPtr NativeFieldInfoPtr_meshID;

	private static readonly System.IntPtr NativeFieldInfoPtr_submeshIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_materialID;

	private static readonly System.IntPtr NativeFieldInfoPtr_flags;

	private static readonly System.IntPtr NativeFieldInfoPtr_transparentInstanceId;

	private static readonly System.IntPtr NativeFieldInfoPtr_overridenComponents;

	private static readonly System.IntPtr NativeFieldInfoPtr_range;

	private static readonly System.IntPtr NativeFieldInfoPtr_lightmapIndex;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DrawKey_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	[FieldOffset(0)]
	public BatchMeshID meshID;

	[FieldOffset(4)]
	public int submeshIndex;

	[FieldOffset(8)]
	public BatchMaterialID materialID;

	[FieldOffset(12)]
	public BatchDrawCommandFlags flags;

	[FieldOffset(16)]
	public int transparentInstanceId;

	[FieldOffset(20)]
	public uint overridenComponents;

	[FieldOffset(24)]
	public RangeKey range;

	[FieldOffset(52)]
	public int lightmapIndex;

	static DrawKey()
	{
		Il2CppClassPointerStore<DrawKey>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "DrawKey");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrawKey>.NativeClassPtr);
		NativeFieldInfoPtr_meshID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawKey>.NativeClassPtr, "meshID");
		NativeFieldInfoPtr_submeshIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawKey>.NativeClassPtr, "submeshIndex");
		NativeFieldInfoPtr_materialID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawKey>.NativeClassPtr, "materialID");
		NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawKey>.NativeClassPtr, "flags");
		NativeFieldInfoPtr_transparentInstanceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawKey>.NativeClassPtr, "transparentInstanceId");
		NativeFieldInfoPtr_overridenComponents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawKey>.NativeClassPtr, "overridenComponents");
		NativeFieldInfoPtr_range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawKey>.NativeClassPtr, "range");
		NativeFieldInfoPtr_lightmapIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawKey>.NativeClassPtr, "lightmapIndex");
		NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DrawKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawKey>.NativeClassPtr, 100663543);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawKey>.NativeClassPtr, 100663544);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1069274, RefRangeEnd = 1069277, XrefRangeStart = 1069264, XrefRangeEnd = 1069274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool Equals(DrawKey other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DrawKey_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1069277, RefRangeEnd = 1069282, XrefRangeStart = 1069277, XrefRangeEnd = 1069277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override int GetHashCode()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DrawKey>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
