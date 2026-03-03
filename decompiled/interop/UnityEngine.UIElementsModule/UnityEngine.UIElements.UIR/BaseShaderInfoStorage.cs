using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Profiling;

namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x2000568")]
internal abstract class BaseShaderInfoStorage : IDisposable
{
	[Token(Token = "0x4001337")]
	[FieldOffset(Offset = "0x0")]
	protected static int s_TextureCounter;

	[Token(Token = "0x4001338")]
	[FieldOffset(Offset = "0x8")]
	internal static ProfilerMarker s_MarkerCopyTexture;

	[Token(Token = "0x4001339")]
	[FieldOffset(Offset = "0x10")]
	internal static ProfilerMarker s_MarkerGetTextureData;

	[Token(Token = "0x400133A")]
	[FieldOffset(Offset = "0x18")]
	internal static ProfilerMarker s_MarkerUpdateTexture;

	[Token(Token = "0x170009BA")]
	public abstract Texture2D texture
	{
		[Token(Token = "0x6002655")]
		get;
	}

	[Token(Token = "0x170009BB")]
	protected bool disposed
	{
		[Token(Token = "0x6002659")]
		[Address(RVA = "0x465880", Offset = "0x464A80", VA = "0x180465880")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600265A")]
		[Address(RVA = "0x71FA70", Offset = "0x71EC70", VA = "0x18071FA70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6002656")]
	public abstract bool AllocateRect(int width, int height, out RectInt uvs);

	[Token(Token = "0x6002657")]
	public abstract void SetTexel(int x, int y, Color color);

	[Token(Token = "0x6002658")]
	public abstract void UpdateTexture();

	[Token(Token = "0x600265B")]
	[Address(RVA = "0x2A57090", Offset = "0x2A56290", VA = "0x182A57090", Slot = "4")]
	public void Dispose()
	{
	}

	[Token(Token = "0x600265C")]
	[Address(RVA = "0x2A57080", Offset = "0x2A56280", VA = "0x182A57080", Slot = "9")]
	protected virtual void Dispose(bool disposing)
	{
	}

	[Token(Token = "0x600265D")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	protected BaseShaderInfoStorage()
	{
	}
}
