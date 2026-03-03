using System;
using Il2CppDummyDll;
using Unity.Profiling;

namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x2000530")]
internal class RenderChainCommand : LinkedPoolItem<RenderChainCommand>
{
	[Token(Token = "0x4001166")]
	[FieldOffset(Offset = "0x18")]
	internal VisualElement owner;

	[Token(Token = "0x4001167")]
	[FieldOffset(Offset = "0x20")]
	internal RenderChainCommand prev;

	[Token(Token = "0x4001168")]
	[FieldOffset(Offset = "0x28")]
	internal RenderChainCommand next;

	[Token(Token = "0x4001169")]
	[FieldOffset(Offset = "0x30")]
	internal bool isTail;

	[Token(Token = "0x400116A")]
	[FieldOffset(Offset = "0x34")]
	internal CommandType type;

	[Token(Token = "0x400116B")]
	[FieldOffset(Offset = "0x38")]
	internal State state;

	[Token(Token = "0x400116C")]
	[FieldOffset(Offset = "0x50")]
	internal MeshHandle mesh;

	[Token(Token = "0x400116D")]
	[FieldOffset(Offset = "0x58")]
	internal int indexOffset;

	[Token(Token = "0x400116E")]
	[FieldOffset(Offset = "0x5C")]
	internal int indexCount;

	[Token(Token = "0x400116F")]
	[FieldOffset(Offset = "0x60")]
	internal Action callback;

	[Token(Token = "0x4001170")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int k_ID_MainTex;

	[Token(Token = "0x4001171")]
	[FieldOffset(Offset = "0x8")]
	private static ProfilerMarker s_ImmediateOverheadMarker;

	[Token(Token = "0x60024FB")]
	[Address(RVA = "0x2A56B30", Offset = "0x2A55D30", VA = "0x182A56B30")]
	internal void Reset()
	{
	}

	[Token(Token = "0x60024FC")]
	[Address(RVA = "0x2A558E0", Offset = "0x2A54AE0", VA = "0x182A558E0")]
	internal void ExecuteNonDrawMesh(DrawParams drawParams, float pixelsPerPoint, ref Exception immediateException)
	{
	}

	[Token(Token = "0x60024FD")]
	[Address(RVA = "0x2A55630", Offset = "0x2A54830", VA = "0x182A55630")]
	private void Blit(Texture source, RenderTexture destination, float depth)
	{
	}

	[Token(Token = "0x60024FE")]
	[Address(RVA = "0x2A56720", Offset = "0x2A55920", VA = "0x182A56720")]
	public static void PushScissor(DrawParams drawParams, Rect scissor, float pixelsPerPoint)
	{
	}

	[Token(Token = "0x60024FF")]
	[Address(RVA = "0x2A56500", Offset = "0x2A55700", VA = "0x182A56500")]
	public static void PopScissor(DrawParams drawParams, float pixelsPerPoint)
	{
	}

	[Token(Token = "0x6002500")]
	[Address(RVA = "0x2A557A0", Offset = "0x2A549A0", VA = "0x182A557A0")]
	private static Rect CombineScissorRects(Rect r0, Rect r1)
	{
		return default(Rect);
	}

	[Token(Token = "0x6002501")]
	[Address(RVA = "0x2A56A40", Offset = "0x2A55C40", VA = "0x182A56A40")]
	private static RectInt RectPointsToPixelsAndFlipYAxis(Rect rect, float pixelsPerPoint)
	{
		return default(RectInt);
	}

	[Token(Token = "0x6002502")]
	[Address(RVA = "0x2A56C40", Offset = "0x2A55E40", VA = "0x182A56C40")]
	public RenderChainCommand()
	{
	}
}
