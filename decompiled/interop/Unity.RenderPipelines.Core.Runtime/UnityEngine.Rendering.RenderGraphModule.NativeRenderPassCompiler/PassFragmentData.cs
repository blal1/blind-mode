using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler;

[StructLayout(LayoutKind.Explicit)]
public struct PassFragmentData
{
	private static readonly System.IntPtr NativeFieldInfoPtr_resource;

	private static readonly System.IntPtr NativeFieldInfoPtr_accessFlags;

	private static readonly System.IntPtr NativeFieldInfoPtr_mipLevel;

	private static readonly System.IntPtr NativeFieldInfoPtr_depthSlice;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SameSubResource_Public_Static_Boolean_byref_PassFragmentData_byref_PassFragmentData_0;

	[FieldOffset(0)]
	public ResourceHandle resource;

	[FieldOffset(12)]
	public AccessFlags accessFlags;

	[FieldOffset(16)]
	public int mipLevel;

	[FieldOffset(20)]
	public int depthSlice;

	static PassFragmentData()
	{
		Il2CppClassPointerStore<PassFragmentData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler", "PassFragmentData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PassFragmentData>.NativeClassPtr);
		NativeFieldInfoPtr_resource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassFragmentData>.NativeClassPtr, "resource");
		NativeFieldInfoPtr_accessFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassFragmentData>.NativeClassPtr, "accessFlags");
		NativeFieldInfoPtr_mipLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassFragmentData>.NativeClassPtr, "mipLevel");
		NativeFieldInfoPtr_depthSlice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassFragmentData>.NativeClassPtr, "depthSlice");
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassFragmentData>.NativeClassPtr, 100667856);
		NativeMethodInfoPtr_SameSubResource_Public_Static_Boolean_byref_PassFragmentData_byref_PassFragmentData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassFragmentData>.NativeClassPtr, 100667857);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1063352, XrefRangeEnd = 1063358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override int GetHashCode()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1063358, XrefRangeEnd = 1063361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SameSubResource([In] ref PassFragmentData x, [In] ref PassFragmentData y)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref x);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref y);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SameSubResource_Public_Static_Boolean_byref_PassFragmentData_byref_PassFragmentData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PassFragmentData>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
