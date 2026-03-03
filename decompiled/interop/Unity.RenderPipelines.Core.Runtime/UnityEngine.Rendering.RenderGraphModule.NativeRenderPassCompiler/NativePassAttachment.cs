using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler;

[StructLayout(LayoutKind.Explicit)]
public struct NativePassAttachment
{
	private static readonly System.IntPtr NativeFieldInfoPtr_handle;

	private static readonly System.IntPtr NativeFieldInfoPtr_loadAction;

	private static readonly System.IntPtr NativeFieldInfoPtr_storeAction;

	private static readonly System.IntPtr NativeFieldInfoPtr_memoryless;

	private static readonly System.IntPtr NativeFieldInfoPtr_mipLevel;

	private static readonly System.IntPtr NativeFieldInfoPtr_depthSlice;

	[FieldOffset(0)]
	public ResourceHandle handle;

	[FieldOffset(12)]
	public RenderBufferLoadAction loadAction;

	[FieldOffset(16)]
	public RenderBufferStoreAction storeAction;

	[FieldOffset(20)]
	[MarshalAs(UnmanagedType.U1)]
	public bool memoryless;

	[FieldOffset(24)]
	public int mipLevel;

	[FieldOffset(28)]
	public int depthSlice;

	static NativePassAttachment()
	{
		Il2CppClassPointerStore<NativePassAttachment>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler", "NativePassAttachment");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativePassAttachment>.NativeClassPtr);
		NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativePassAttachment>.NativeClassPtr, "handle");
		NativeFieldInfoPtr_loadAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativePassAttachment>.NativeClassPtr, "loadAction");
		NativeFieldInfoPtr_storeAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativePassAttachment>.NativeClassPtr, "storeAction");
		NativeFieldInfoPtr_memoryless = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativePassAttachment>.NativeClassPtr, "memoryless");
		NativeFieldInfoPtr_mipLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativePassAttachment>.NativeClassPtr, "mipLevel");
		NativeFieldInfoPtr_depthSlice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativePassAttachment>.NativeClassPtr, "depthSlice");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativePassAttachment>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
