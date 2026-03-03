using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements;

[Token(Token = "0x200027F")]
[UnityEngine.Bindings.NativeHeader("Modules/UIElements/Core/Native/Renderer/UIRMeshBuilder.bindings.h")]
internal static class MeshBuilderNative
{
	[Token(Token = "0x2000280")]
	public struct NativeColorPage
	{
		[Token(Token = "0x40009C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int isValid;

		[Token(Token = "0x40009C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public Color32 pageAndID;
	}

	[Token(Token = "0x2000281")]
	public struct NativeBorderParams
	{
		[Token(Token = "0x40009C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Rect rect;

		[Token(Token = "0x40009C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color leftColor;

		[Token(Token = "0x40009C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color topColor;

		[Token(Token = "0x40009C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Color rightColor;

		[Token(Token = "0x40009C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Color bottomColor;

		[Token(Token = "0x40009CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float leftWidth;

		[Token(Token = "0x40009CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float topWidth;

		[Token(Token = "0x40009CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float rightWidth;

		[Token(Token = "0x40009CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float bottomWidth;

		[Token(Token = "0x40009CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector2 topLeftRadius;

		[Token(Token = "0x40009CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Vector2 topRightRadius;

		[Token(Token = "0x40009D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Vector2 bottomRightRadius;

		[Token(Token = "0x40009D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Vector2 bottomLeftRadius;

		[Token(Token = "0x40009D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		internal NativeColorPage leftColorPage;

		[Token(Token = "0x40009D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		internal NativeColorPage topColorPage;

		[Token(Token = "0x40009D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		internal NativeColorPage rightColorPage;

		[Token(Token = "0x40009D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		internal NativeColorPage bottomColorPage;
	}

	[Token(Token = "0x2000282")]
	public struct NativeRectParams
	{
		[Token(Token = "0x40009D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Rect rect;

		[Token(Token = "0x40009D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rect subRect;

		[Token(Token = "0x40009D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Rect uv;

		[Token(Token = "0x40009D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Color color;

		[Token(Token = "0x40009DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ScaleMode scaleMode;

		[Token(Token = "0x40009DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public IntPtr backgroundRepeatInstanceList;

		[Token(Token = "0x40009DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public int backgroundRepeatInstanceListStartIndex;

		[Token(Token = "0x40009DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public int backgroundRepeatInstanceListEndIndex;

		[Token(Token = "0x40009DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Vector2 topLeftRadius;

		[Token(Token = "0x40009DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector2 topRightRadius;

		[Token(Token = "0x40009E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Vector2 bottomRightRadius;

		[Token(Token = "0x40009E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Vector2 bottomLeftRadius;

		[Token(Token = "0x40009E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Rect backgroundRepeatRect;

		[Token(Token = "0x40009E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IntPtr texture;

		[Token(Token = "0x40009E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IntPtr sprite;

		[Token(Token = "0x40009E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public IntPtr vectorImage;

		[Token(Token = "0x40009E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IntPtr spriteTexture;

		[Token(Token = "0x40009E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public IntPtr spriteVertices;

		[Token(Token = "0x40009E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public IntPtr spriteUVs;

		[Token(Token = "0x40009E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public IntPtr spriteTriangles;

		[Token(Token = "0x40009EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public Rect spriteGeomRect;

		[Token(Token = "0x40009EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Vector2 contentSize;

		[Token(Token = "0x40009EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public Vector2 textureSize;

		[Token(Token = "0x40009ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public float texturePixelsPerPoint;

		[Token(Token = "0x40009EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		public int leftSlice;

		[Token(Token = "0x40009EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public int topSlice;

		[Token(Token = "0x40009F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		public int rightSlice;

		[Token(Token = "0x40009F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public int bottomSlice;

		[Token(Token = "0x40009F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		public float sliceScale;

		[Token(Token = "0x40009F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public Vector4 rectInset;

		[Token(Token = "0x40009F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public NativeColorPage colorPage;

		[Token(Token = "0x40009F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public int meshFlags;
	}

	[Token(Token = "0x6001146")]
	[Address(RVA = "0x2B33DE0", Offset = "0x2B32FE0", VA = "0x182B33DE0")]
	[UnityEngine.Bindings.ThreadSafe]
	public static MeshWriteDataInterface MakeBorder(NativeBorderParams borderParams, float posZ)
	{
		return default(MeshWriteDataInterface);
	}

	[Token(Token = "0x6001147")]
	[Address(RVA = "0x2B33EB0", Offset = "0x2B330B0", VA = "0x182B33EB0")]
	[UnityEngine.Bindings.ThreadSafe]
	public static MeshWriteDataInterface MakeSolidRect(NativeRectParams rectParams, float posZ)
	{
		return default(MeshWriteDataInterface);
	}

	[Token(Token = "0x6001148")]
	[Address(RVA = "0x2B33F80", Offset = "0x2B33180", VA = "0x182B33F80")]
	[UnityEngine.Bindings.ThreadSafe]
	public static MeshWriteDataInterface MakeTexturedRect(NativeRectParams rectParams, float posZ)
	{
		return default(MeshWriteDataInterface);
	}

	[Token(Token = "0x6001149")]
	[Address(RVA = "0x2B34290", Offset = "0x2B33490", VA = "0x182B34290")]
	[UnityEngine.Bindings.ThreadSafe]
	public static MeshWriteDataInterface MakeVectorGraphicsStretchBackground(Vertex[] svgVertices, ushort[] svgIndices, float svgWidth, float svgHeight, Rect targetRect, Rect sourceUV, ScaleMode scaleMode, Color tint, NativeColorPage colorPage)
	{
		return default(MeshWriteDataInterface);
	}

	[Token(Token = "0x600114A")]
	[Address(RVA = "0x2B34060", Offset = "0x2B33260", VA = "0x182B34060")]
	[UnityEngine.Bindings.ThreadSafe]
	public static MeshWriteDataInterface MakeVectorGraphics9SliceBackground(Vertex[] svgVertices, ushort[] svgIndices, float svgWidth, float svgHeight, Rect targetRect, Vector4 sliceLTRB, Color tint, NativeColorPage colorPage)
	{
		return default(MeshWriteDataInterface);
	}

	[MethodImpl(4096)]
	[Token(Token = "0x600114B")]
	[Address(RVA = "0x2B33D80", Offset = "0x2B32F80", VA = "0x182B33D80")]
	private static extern void MakeBorder_Injected([In] ref NativeBorderParams borderParams, float posZ, out MeshWriteDataInterface ret);

	[MethodImpl(4096)]
	[Token(Token = "0x600114C")]
	[Address(RVA = "0x2B33E50", Offset = "0x2B33050", VA = "0x182B33E50")]
	private static extern void MakeSolidRect_Injected([In] ref NativeRectParams rectParams, float posZ, out MeshWriteDataInterface ret);

	[MethodImpl(4096)]
	[Token(Token = "0x600114D")]
	[Address(RVA = "0x2B33F20", Offset = "0x2B33120", VA = "0x182B33F20")]
	private static extern void MakeTexturedRect_Injected([In] ref NativeRectParams rectParams, float posZ, out MeshWriteDataInterface ret);

	[MethodImpl(4096)]
	[Token(Token = "0x600114E")]
	[Address(RVA = "0x2B34220", Offset = "0x2B33420", VA = "0x182B34220")]
	private static extern void MakeVectorGraphicsStretchBackground_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper svgVertices, ref UnityEngine.Bindings.ManagedSpanWrapper svgIndices, float svgWidth, float svgHeight, [In] ref Rect targetRect, [In] ref Rect sourceUV, ScaleMode scaleMode, [In] ref Color tint, [In] ref NativeColorPage colorPage, out MeshWriteDataInterface ret);

	[MethodImpl(4096)]
	[Token(Token = "0x600114F")]
	[Address(RVA = "0x2B33FF0", Offset = "0x2B331F0", VA = "0x182B33FF0")]
	private static extern void MakeVectorGraphics9SliceBackground_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper svgVertices, ref UnityEngine.Bindings.ManagedSpanWrapper svgIndices, float svgWidth, float svgHeight, [In] ref Rect targetRect, [In] ref Vector4 sliceLTRB, [In] ref Color tint, [In] ref NativeColorPage colorPage, out MeshWriteDataInterface ret);
}
