using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Profiling;

namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x2000572")]
internal class TextureBlitter : IDisposable
{
	[Token(Token = "0x2000573")]
	private struct BlitInfo
	{
		[Token(Token = "0x400136C")]
		[FieldOffset(Offset = "0x0")]
		public Texture src;

		[Token(Token = "0x400136D")]
		[FieldOffset(Offset = "0x8")]
		public RectInt srcRect;

		[Token(Token = "0x400136E")]
		[FieldOffset(Offset = "0x18")]
		public Vector2Int dstPos;

		[Token(Token = "0x400136F")]
		[FieldOffset(Offset = "0x20")]
		public int border;

		[Token(Token = "0x4001370")]
		[FieldOffset(Offset = "0x24")]
		public Color tint;
	}

	[Token(Token = "0x4001363")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int[] k_TextureIds;

	[Token(Token = "0x4001364")]
	[FieldOffset(Offset = "0x8")]
	private static ProfilerMarker s_CommitSampler;

	[Token(Token = "0x4001365")]
	[FieldOffset(Offset = "0x10")]
	private BlitInfo[] m_SingleBlit;

	[Token(Token = "0x4001366")]
	[FieldOffset(Offset = "0x18")]
	private Material m_BlitMaterial;

	[Token(Token = "0x4001367")]
	[FieldOffset(Offset = "0x20")]
	private MaterialPropertyBlock m_Properties;

	[Token(Token = "0x4001368")]
	[FieldOffset(Offset = "0x28")]
	private RectInt m_Viewport;

	[Token(Token = "0x4001369")]
	[FieldOffset(Offset = "0x38")]
	private RenderTexture m_PrevRT;

	[Token(Token = "0x400136A")]
	[FieldOffset(Offset = "0x40")]
	private List<BlitInfo> m_PendingBlits;

	[Token(Token = "0x170009C2")]
	protected bool disposed
	{
		[Token(Token = "0x6002688")]
		[Address(RVA = "0x7CE740", Offset = "0x7CD940", VA = "0x1807CE740")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002689")]
		[Address(RVA = "0x8C82C0", Offset = "0x8C74C0", VA = "0x1808C82C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x600268A")]
	[Address(RVA = "0x2A65810", Offset = "0x2A64A10", VA = "0x182A65810", Slot = "4")]
	public void Dispose()
	{
	}

	[Token(Token = "0x600268B")]
	[Address(RVA = "0x2A65880", Offset = "0x2A64A80", VA = "0x182A65880", Slot = "5")]
	protected virtual void Dispose(bool disposing)
	{
	}

	[Token(Token = "0x600268C")]
	[Address(RVA = "0x2A661E0", Offset = "0x2A653E0", VA = "0x182A661E0")]
	static TextureBlitter()
	{
	}

	[Token(Token = "0x600268D")]
	[Address(RVA = "0x2A66310", Offset = "0x2A65510", VA = "0x182A66310")]
	public TextureBlitter(int capacity = 512)
	{
	}

	[Token(Token = "0x600268E")]
	[Address(RVA = "0x2A66050", Offset = "0x2A65250", VA = "0x182A66050")]
	public void QueueBlit(Texture src, RectInt srcRect, Vector2Int dstPos, bool addBorder, Color tint)
	{
	}

	[Token(Token = "0x600268F")]
	[Address(RVA = "0x2A655D0", Offset = "0x2A647D0", VA = "0x182A655D0")]
	public void BlitOneNow(RenderTexture dst, Texture src, RectInt srcRect, Vector2Int dstPos, bool addBorder, Color tint)
	{
	}

	[Token(Token = "0x6002690")]
	[Address(RVA = "0x2A65710", Offset = "0x2A64910", VA = "0x182A65710")]
	public void Commit(RenderTexture dst)
	{
	}

	[Token(Token = "0x6002691")]
	[Address(RVA = "0x2A65390", Offset = "0x2A64590", VA = "0x182A65390")]
	private void BeginBlit(RenderTexture dst)
	{
	}

	[Token(Token = "0x6002692")]
	[Address(RVA = "0x2A65900", Offset = "0x2A64B00", VA = "0x182A65900")]
	private void DoBlit(IList<BlitInfo> blitInfos, int startIndex)
	{
	}

	[Token(Token = "0x6002693")]
	[Address(RVA = "0x2A65FB0", Offset = "0x2A651B0", VA = "0x182A65FB0")]
	private void EndBlit()
	{
	}
}
