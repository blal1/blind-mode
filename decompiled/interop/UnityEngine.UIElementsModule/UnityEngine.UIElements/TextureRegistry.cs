using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20002B7")]
internal class TextureRegistry
{
	[Token(Token = "0x20002B8")]
	private struct TextureInfo
	{
		[Token(Token = "0x4000AF9")]
		[FieldOffset(Offset = "0x0")]
		public Texture texture;

		[Token(Token = "0x4000AFA")]
		[FieldOffset(Offset = "0x8")]
		public bool dynamic;

		[Token(Token = "0x4000AFB")]
		[FieldOffset(Offset = "0xC")]
		public int refCount;
	}

	[Token(Token = "0x4000AF4")]
	[FieldOffset(Offset = "0x10")]
	private List<TextureInfo> m_Textures;

	[Token(Token = "0x4000AF5")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<Texture, TextureId> m_TextureToId;

	[Token(Token = "0x4000AF6")]
	[FieldOffset(Offset = "0x20")]
	private Stack<TextureId> m_FreeIds;

	[Token(Token = "0x4000AF7")]
	internal const int maxTextures = 2048;

	[Token(Token = "0x1700039A")]
	public static TextureRegistry instance
	{
		[Token(Token = "0x60012EE")]
		[Address(RVA = "0x2B6DEE0", Offset = "0x2B6D0E0", VA = "0x182B6DEE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60012EF")]
	[Address(RVA = "0x2B6D5C0", Offset = "0x2B6C7C0", VA = "0x182B6D5C0")]
	public Texture GetTexture(TextureId id)
	{
		return null;
	}

	[Token(Token = "0x60012F0")]
	[Address(RVA = "0x2B6D230", Offset = "0x2B6C430", VA = "0x182B6D230")]
	public TextureId AllocAndAcquireDynamic()
	{
		return default(TextureId);
	}

	[Token(Token = "0x60012F1")]
	[Address(RVA = "0x2B6D9F0", Offset = "0x2B6CBF0", VA = "0x182B6D9F0")]
	public void UpdateDynamic(TextureId id, Texture texture)
	{
	}

	[Token(Token = "0x60012F2")]
	[Address(RVA = "0x2B6D240", Offset = "0x2B6C440", VA = "0x182B6D240")]
	private TextureId AllocAndAcquire(Texture texture, bool dynamic)
	{
		return default(TextureId);
	}

	[Token(Token = "0x60012F3")]
	[Address(RVA = "0x2B6D090", Offset = "0x2B6C290", VA = "0x182B6D090")]
	public TextureId Acquire(Texture tex)
	{
		return default(TextureId);
	}

	[Token(Token = "0x60012F4")]
	[Address(RVA = "0x2B6D760", Offset = "0x2B6C960", VA = "0x182B6D760")]
	public void Release(TextureId id)
	{
	}

	[Token(Token = "0x60012F5")]
	[Address(RVA = "0x2B6DDD0", Offset = "0x2B6CFD0", VA = "0x182B6DDD0")]
	public TextureRegistry()
	{
	}
}
