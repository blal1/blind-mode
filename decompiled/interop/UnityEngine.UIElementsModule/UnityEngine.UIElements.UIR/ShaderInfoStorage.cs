using System;
using Il2CppDummyDll;
using Unity.Collections;

namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x2000569")]
internal class ShaderInfoStorage<T> : BaseShaderInfoStorage where T : struct
{
	[Token(Token = "0x400133C")]
	[FieldOffset(Offset = "0x0")]
	private readonly int m_InitialSize;

	[Token(Token = "0x400133D")]
	[FieldOffset(Offset = "0x0")]
	private readonly int m_MaxSize;

	[Token(Token = "0x400133E")]
	[FieldOffset(Offset = "0x0")]
	private readonly TextureFormat m_Format;

	[Token(Token = "0x400133F")]
	[FieldOffset(Offset = "0x0")]
	private readonly Func<Color, T> m_Convert;

	[Token(Token = "0x4001340")]
	[FieldOffset(Offset = "0x0")]
	private UIRAtlasAllocator m_Allocator;

	[Token(Token = "0x4001341")]
	[FieldOffset(Offset = "0x0")]
	private Texture2D m_Texture;

	[Token(Token = "0x4001342")]
	[FieldOffset(Offset = "0x0")]
	private NativeArray<T> m_Texels;

	[Token(Token = "0x170009BC")]
	public override Texture2D texture
	{
		[Token(Token = "0x6002661")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600265F")]
	public ShaderInfoStorage(TextureFormat format, Func<Color, T> convert, int initialSize = 64, int maxSize = 4096)
	{
	}

	[Token(Token = "0x6002660")]
	protected override void Dispose(bool disposing)
	{
	}

	[Token(Token = "0x6002662")]
	public override bool AllocateRect(int width, int height, out RectInt uvs)
	{
		return default(bool);
	}

	[Token(Token = "0x6002663")]
	public override void SetTexel(int x, int y, Color color)
	{
	}

	[Token(Token = "0x6002664")]
	public override void UpdateTexture()
	{
	}

	[Token(Token = "0x6002665")]
	private void CreateOrExpandTexture()
	{
	}

	[Token(Token = "0x6002666")]
	private static void CpuBlit(NativeArray<T> src, int srcWidth, int srcHeight, NativeArray<T> dst, int dstWidth, int dstHeight)
	{
	}
}
