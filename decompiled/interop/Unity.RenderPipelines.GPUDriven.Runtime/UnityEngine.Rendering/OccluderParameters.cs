using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct OccluderParameters
{
	private static readonly System.IntPtr NativeFieldInfoPtr_viewInstanceID;

	private static readonly System.IntPtr NativeFieldInfoPtr_subviewCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_depthTexture;

	private static readonly System.IntPtr NativeFieldInfoPtr_depthSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_depthIsArray;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

	[FieldOffset(0)]
	public int viewInstanceID;

	[FieldOffset(4)]
	public int subviewCount;

	[FieldOffset(8)]
	public TextureHandle depthTexture;

	[FieldOffset(24)]
	public Vector2Int depthSize;

	[FieldOffset(32)]
	[MarshalAs(UnmanagedType.U1)]
	public bool depthIsArray;

	static OccluderParameters()
	{
		Il2CppClassPointerStore<OccluderParameters>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "OccluderParameters");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OccluderParameters>.NativeClassPtr);
		NativeFieldInfoPtr_viewInstanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccluderParameters>.NativeClassPtr, "viewInstanceID");
		NativeFieldInfoPtr_subviewCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccluderParameters>.NativeClassPtr, "subviewCount");
		NativeFieldInfoPtr_depthTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccluderParameters>.NativeClassPtr, "depthTexture");
		NativeFieldInfoPtr_depthSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccluderParameters>.NativeClassPtr, "depthSize");
		NativeFieldInfoPtr_depthIsArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccluderParameters>.NativeClassPtr, "depthIsArray");
		NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OccluderParameters>.NativeClassPtr, 100663537);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1069260, RefRangeEnd = 1069261, XrefRangeStart = 1069251, XrefRangeEnd = 1069260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe OccluderParameters(int viewInstanceID)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&viewInstanceID);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<OccluderParameters>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
