using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct GPUDrivenLODGroupDataNative
{
	private static readonly System.IntPtr NativeFieldInfoPtr_lodGroupID;

	private static readonly System.IntPtr NativeFieldInfoPtr_lodOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_lodCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_fadeMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_worldSpaceReferencePoint;

	private static readonly System.IntPtr NativeFieldInfoPtr_worldSpaceSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_renderersCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastLODIsBillboard;

	private static readonly System.IntPtr NativeFieldInfoPtr_forceLODMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_lodGroupCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_invalidLODGroupID;

	private static readonly System.IntPtr NativeFieldInfoPtr_invalidLODGroupCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_lodRenderersCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_lodScreenRelativeTransitionHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_lodFadeTransitionWidth;

	private static readonly System.IntPtr NativeFieldInfoPtr_lodDataCount;

	[FieldOffset(0)]
	public System.IntPtr lodGroupID;

	[FieldOffset(8)]
	public System.IntPtr lodOffset;

	[FieldOffset(16)]
	public System.IntPtr lodCount;

	[FieldOffset(24)]
	public System.IntPtr fadeMode;

	[FieldOffset(32)]
	public System.IntPtr worldSpaceReferencePoint;

	[FieldOffset(40)]
	public System.IntPtr worldSpaceSize;

	[FieldOffset(48)]
	public System.IntPtr renderersCount;

	[FieldOffset(56)]
	public System.IntPtr lastLODIsBillboard;

	[FieldOffset(64)]
	public System.IntPtr forceLODMask;

	[FieldOffset(72)]
	public int lodGroupCount;

	[FieldOffset(80)]
	public System.IntPtr invalidLODGroupID;

	[FieldOffset(88)]
	public int invalidLODGroupCount;

	[FieldOffset(96)]
	public System.IntPtr lodRenderersCount;

	[FieldOffset(104)]
	public System.IntPtr lodScreenRelativeTransitionHeight;

	[FieldOffset(112)]
	public System.IntPtr lodFadeTransitionWidth;

	[FieldOffset(120)]
	public int lodDataCount;

	static GPUDrivenLODGroupDataNative()
	{
		Il2CppClassPointerStore<GPUDrivenLODGroupDataNative>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "GPUDrivenLODGroupDataNative");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GPUDrivenLODGroupDataNative>.NativeClassPtr);
		NativeFieldInfoPtr_lodGroupID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenLODGroupDataNative>.NativeClassPtr, "lodGroupID");
		NativeFieldInfoPtr_lodOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenLODGroupDataNative>.NativeClassPtr, "lodOffset");
		NativeFieldInfoPtr_lodCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenLODGroupDataNative>.NativeClassPtr, "lodCount");
		NativeFieldInfoPtr_fadeMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenLODGroupDataNative>.NativeClassPtr, "fadeMode");
		NativeFieldInfoPtr_worldSpaceReferencePoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenLODGroupDataNative>.NativeClassPtr, "worldSpaceReferencePoint");
		NativeFieldInfoPtr_worldSpaceSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenLODGroupDataNative>.NativeClassPtr, "worldSpaceSize");
		NativeFieldInfoPtr_renderersCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenLODGroupDataNative>.NativeClassPtr, "renderersCount");
		NativeFieldInfoPtr_lastLODIsBillboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenLODGroupDataNative>.NativeClassPtr, "lastLODIsBillboard");
		NativeFieldInfoPtr_forceLODMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenLODGroupDataNative>.NativeClassPtr, "forceLODMask");
		NativeFieldInfoPtr_lodGroupCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenLODGroupDataNative>.NativeClassPtr, "lodGroupCount");
		NativeFieldInfoPtr_invalidLODGroupID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenLODGroupDataNative>.NativeClassPtr, "invalidLODGroupID");
		NativeFieldInfoPtr_invalidLODGroupCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenLODGroupDataNative>.NativeClassPtr, "invalidLODGroupCount");
		NativeFieldInfoPtr_lodRenderersCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenLODGroupDataNative>.NativeClassPtr, "lodRenderersCount");
		NativeFieldInfoPtr_lodScreenRelativeTransitionHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenLODGroupDataNative>.NativeClassPtr, "lodScreenRelativeTransitionHeight");
		NativeFieldInfoPtr_lodFadeTransitionWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenLODGroupDataNative>.NativeClassPtr, "lodFadeTransitionWidth");
		NativeFieldInfoPtr_lodDataCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenLODGroupDataNative>.NativeClassPtr, "lodDataCount");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GPUDrivenLODGroupDataNative>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
