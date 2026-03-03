using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal;

[StructLayout(LayoutKind.Explicit)]
public struct TileData
{
	private static readonly System.IntPtr NativeFieldInfoPtr_tileID;

	private static readonly System.IntPtr NativeFieldInfoPtr_listBitMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_relLightOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_unused;

	[FieldOffset(0)]
	public uint tileID;

	[FieldOffset(4)]
	public uint listBitMask;

	[FieldOffset(8)]
	public uint relLightOffset;

	[FieldOffset(12)]
	public uint unused;

	static TileData()
	{
		Il2CppClassPointerStore<TileData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "TileData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileData>.NativeClassPtr);
		NativeFieldInfoPtr_tileID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileData>.NativeClassPtr, "tileID");
		NativeFieldInfoPtr_listBitMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileData>.NativeClassPtr, "listBitMask");
		NativeFieldInfoPtr_relLightOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileData>.NativeClassPtr, "relLightOffset");
		NativeFieldInfoPtr_unused = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileData>.NativeClassPtr, "unused");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TileData>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
