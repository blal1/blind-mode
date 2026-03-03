using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Experimental.U2D;

[StructLayout(LayoutKind.Explicit)]
public struct SpriteIntermediateRendererInfo
{
	private static readonly System.IntPtr NativeFieldInfoPtr_SpriteID;

	private static readonly System.IntPtr NativeFieldInfoPtr_TextureID;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaterialID;

	private static readonly System.IntPtr NativeFieldInfoPtr_Color;

	private static readonly System.IntPtr NativeFieldInfoPtr_Transform;

	private static readonly System.IntPtr NativeFieldInfoPtr_Bounds;

	private static readonly System.IntPtr NativeFieldInfoPtr_Layer;

	private static readonly System.IntPtr NativeFieldInfoPtr_SortingLayer;

	private static readonly System.IntPtr NativeFieldInfoPtr_SortingOrder;

	private static readonly System.IntPtr NativeFieldInfoPtr_SceneCullingMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_IndexData;

	private static readonly System.IntPtr NativeFieldInfoPtr_VertexData;

	private static readonly System.IntPtr NativeFieldInfoPtr_IndexCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_VertexCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_ShaderChannelMask;

	[FieldOffset(0)]
	public int SpriteID;

	[FieldOffset(4)]
	public int TextureID;

	[FieldOffset(8)]
	public int MaterialID;

	[FieldOffset(12)]
	public Color Color;

	[FieldOffset(28)]
	public Matrix4x4 Transform;

	[FieldOffset(92)]
	public Bounds Bounds;

	[FieldOffset(116)]
	public int Layer;

	[FieldOffset(120)]
	public int SortingLayer;

	[FieldOffset(124)]
	public int SortingOrder;

	[FieldOffset(128)]
	public ulong SceneCullingMask;

	[FieldOffset(136)]
	public System.IntPtr IndexData;

	[FieldOffset(144)]
	public System.IntPtr VertexData;

	[FieldOffset(152)]
	public int IndexCount;

	[FieldOffset(156)]
	public int VertexCount;

	[FieldOffset(160)]
	public int ShaderChannelMask;

	static SpriteIntermediateRendererInfo()
	{
		Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.U2D", "SpriteIntermediateRendererInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr);
		NativeFieldInfoPtr_SpriteID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, "SpriteID");
		NativeFieldInfoPtr_TextureID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, "TextureID");
		NativeFieldInfoPtr_MaterialID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, "MaterialID");
		NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, "Color");
		NativeFieldInfoPtr_Transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, "Transform");
		NativeFieldInfoPtr_Bounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, "Bounds");
		NativeFieldInfoPtr_Layer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, "Layer");
		NativeFieldInfoPtr_SortingLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, "SortingLayer");
		NativeFieldInfoPtr_SortingOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, "SortingOrder");
		NativeFieldInfoPtr_SceneCullingMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, "SceneCullingMask");
		NativeFieldInfoPtr_IndexData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, "IndexData");
		NativeFieldInfoPtr_VertexData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, "VertexData");
		NativeFieldInfoPtr_IndexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, "IndexCount");
		NativeFieldInfoPtr_VertexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, "VertexCount");
		NativeFieldInfoPtr_ShaderChannelMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, "ShaderChannelMask");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
