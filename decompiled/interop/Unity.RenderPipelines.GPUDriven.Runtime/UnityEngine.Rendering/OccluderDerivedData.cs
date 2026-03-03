using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct OccluderDerivedData
{
	private static readonly System.IntPtr NativeFieldInfoPtr_viewProjMatrix;

	private static readonly System.IntPtr NativeFieldInfoPtr_viewOriginWorldSpace;

	private static readonly System.IntPtr NativeFieldInfoPtr_radialDirWorldSpace;

	private static readonly System.IntPtr NativeFieldInfoPtr_facingDirWorldSpace;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromParameters_Public_Static_OccluderDerivedData_byref_OccluderSubviewUpdate_0;

	[FieldOffset(0)]
	public Matrix4x4 viewProjMatrix;

	[FieldOffset(64)]
	public Vector4 viewOriginWorldSpace;

	[FieldOffset(80)]
	public Vector4 radialDirWorldSpace;

	[FieldOffset(96)]
	public Vector4 facingDirWorldSpace;

	static OccluderDerivedData()
	{
		Il2CppClassPointerStore<OccluderDerivedData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "OccluderDerivedData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OccluderDerivedData>.NativeClassPtr);
		NativeFieldInfoPtr_viewProjMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccluderDerivedData>.NativeClassPtr, "viewProjMatrix");
		NativeFieldInfoPtr_viewOriginWorldSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccluderDerivedData>.NativeClassPtr, "viewOriginWorldSpace");
		NativeFieldInfoPtr_radialDirWorldSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccluderDerivedData>.NativeClassPtr, "radialDirWorldSpace");
		NativeFieldInfoPtr_facingDirWorldSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccluderDerivedData>.NativeClassPtr, "facingDirWorldSpace");
		NativeMethodInfoPtr_FromParameters_Public_Static_OccluderDerivedData_byref_OccluderSubviewUpdate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OccluderDerivedData>.NativeClassPtr, 100663889);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1073634, RefRangeEnd = 1073635, XrefRangeStart = 1073626, XrefRangeEnd = 1073634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static OccluderDerivedData FromParameters([In] ref OccluderSubviewUpdate occluderSubviewUpdate)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref occluderSubviewUpdate);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromParameters_Public_Static_OccluderDerivedData_byref_OccluderSubviewUpdate_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(OccluderDerivedData*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<OccluderDerivedData>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
