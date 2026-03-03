using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.UIElements.UIR;

namespace UnityEngine.UIElements;

[Token(Token = "0x20002A4")]
internal class DynamicAtlasPage : IDisposable
{
	[Token(Token = "0x4000A9B")]
	[FieldOffset(Offset = "0x38")]
	private readonly int m_1Padding;

	[Token(Token = "0x4000A9C")]
	[FieldOffset(Offset = "0x3C")]
	private readonly int m_2Padding;

	[Token(Token = "0x4000A9D")]
	[FieldOffset(Offset = "0x40")]
	private Allocator2D m_Allocator;

	[Token(Token = "0x4000A9E")]
	[FieldOffset(Offset = "0x48")]
	private TextureBlitter m_Blitter;

	[Token(Token = "0x4000A9F")]
	[FieldOffset(Offset = "0x50")]
	private Vector2Int m_CurrentSize;

	[Token(Token = "0x4000AA0")]
	[FieldOffset(Offset = "0x0")]
	private static int s_TextureCounter;

	[Token(Token = "0x17000381")]
	public TextureId textureId
	{
		[Token(Token = "0x6001267")]
		[Address(RVA = "0x3C7100", Offset = "0x3C6300", VA = "0x1803C7100")]
		[CompilerGenerated]
		get
		{
			return default(TextureId);
		}
		[Token(Token = "0x6001268")]
		[Address(RVA = "0x5F4710", Offset = "0x5F3910", VA = "0x1805F4710")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000382")]
	public RenderTexture atlas
	{
		[Token(Token = "0x6001269")]
		[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600126A")]
		[Address(RVA = "0x417C80", Offset = "0x416E80", VA = "0x180417C80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000383")]
	public RenderTextureFormat format
	{
		[Token(Token = "0x600126B")]
		[Address(RVA = "0x4BDC30", Offset = "0x4BCE30", VA = "0x1804BDC30")]
		[CompilerGenerated]
		get
		{
			return default(RenderTextureFormat);
		}
	}

	[Token(Token = "0x17000384")]
	public FilterMode filterMode
	{
		[Token(Token = "0x600126C")]
		[Address(RVA = "0x416290", Offset = "0x415490", VA = "0x180416290")]
		[CompilerGenerated]
		get
		{
			return default(FilterMode);
		}
	}

	[Token(Token = "0x17000385")]
	protected bool disposed
	{
		[Token(Token = "0x600126E")]
		[Address(RVA = "0x453D30", Offset = "0x452F30", VA = "0x180453D30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600126F")]
		[Address(RVA = "0x415440", Offset = "0x414640", VA = "0x180415440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x600126D")]
	[Address(RVA = "0x2B5DD70", Offset = "0x2B5CF70", VA = "0x182B5DD70")]
	public DynamicAtlasPage(RenderTextureFormat format, FilterMode filterMode, Vector2Int minSize, Vector2Int maxSize)
	{
	}

	[Token(Token = "0x6001270")]
	[Address(RVA = "0x2B5D290", Offset = "0x2B5C490", VA = "0x182B5D290", Slot = "4")]
	public void Dispose()
	{
	}

	[Token(Token = "0x6001271")]
	[Address(RVA = "0x2B5D0C0", Offset = "0x2B5C2C0", VA = "0x182B5D0C0", Slot = "5")]
	protected virtual void Dispose(bool disposing)
	{
	}

	[Token(Token = "0x6001272")]
	[Address(RVA = "0x2B5D3C0", Offset = "0x2B5C5C0", VA = "0x182B5D3C0")]
	public bool TryAdd(Texture2D image, out Allocator2D.Alloc2D alloc, out RectInt rect)
	{
		return default(bool);
	}

	[Token(Token = "0x6001273")]
	[Address(RVA = "0x2B5DBE0", Offset = "0x2B5CDE0", VA = "0x182B5DBE0")]
	public void Update(Texture2D image, RectInt rect)
	{
	}

	[Token(Token = "0x6001274")]
	[Address(RVA = "0x2B5D300", Offset = "0x2B5C500", VA = "0x182B5D300")]
	public void Remove(Allocator2D.Alloc2D alloc)
	{
	}

	[Token(Token = "0x6001275")]
	[Address(RVA = "0x2B5CF40", Offset = "0x2B5C140", VA = "0x182B5CF40")]
	public void Commit()
	{
	}

	[Token(Token = "0x6001276")]
	[Address(RVA = "0x2B5D770", Offset = "0x2B5C970", VA = "0x182B5D770")]
	private void UpdateAtlasTexture()
	{
	}

	[Token(Token = "0x6001277")]
	[Address(RVA = "0x2B5CF80", Offset = "0x2B5C180", VA = "0x182B5CF80")]
	private RenderTexture CreateAtlasTexture()
	{
		return null;
	}
}
