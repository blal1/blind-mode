using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000005")]
internal abstract class AtlasBase
{
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x10")]
	internal TextureRegistry textureRegistry;

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x29746E0", Offset = "0x29738E0", VA = "0x1829746E0", Slot = "4")]
	public virtual bool TryGetAtlas(VisualElement ctx, Texture2D src, out TextureId atlas, out RectInt atlasRect)
	{
		return default(bool);
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
	public virtual void ReturnAtlas(VisualElement ctx, Texture2D src, TextureId atlas)
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "6")]
	public virtual void Reset()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "7")]
	protected virtual void OnAssignedToPanel(IPanel panel)
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "8")]
	protected virtual void OnRemovedFromPanel(IPanel panel)
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "9")]
	protected virtual void OnUpdateDynamicTextures(IPanel panel)
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x29745D0", Offset = "0x29737D0", VA = "0x1829745D0")]
	internal void InvokeAssignedToPanel(IPanel panel)
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x21186B0", Offset = "0x21178B0", VA = "0x1821186B0")]
	internal void InvokeRemovedFromPanel(IPanel panel)
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x2224390", Offset = "0x2223590", VA = "0x182224390")]
	internal void InvokeUpdateDynamicTextures(IPanel panel)
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x29745F0", Offset = "0x29737F0", VA = "0x1829745F0")]
	protected static void RepaintTexturedElements(IPanel panel)
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x29746C0", Offset = "0x29738C0", VA = "0x1829746C0")]
	protected void SetDynamicTexture(TextureId id, Texture texture)
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x2974750", Offset = "0x2973950", VA = "0x182974750")]
	protected AtlasBase()
	{
	}
}
