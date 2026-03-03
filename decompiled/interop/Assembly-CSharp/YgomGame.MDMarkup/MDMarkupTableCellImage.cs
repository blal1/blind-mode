using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.UI;
using YgomSystem.ElementSystem;

namespace YgomGame.MDMarkup;

[Token(Token = "0x2000D07")]
public class MDMarkupTableCellImage : MDMarkupTableCellBase, IMDMarkupAsyncWidget
{
	[Token(Token = "0x4009D4A")]
	[FieldOffset(Offset = "0x30")]
	private readonly string k_ELabelImage;

	[Token(Token = "0x4009D4B")]
	[FieldOffset(Offset = "0x38")]
	private readonly Image m_Image;

	[Token(Token = "0x4009D4C")]
	[FieldOffset(Offset = "0x40")]
	public readonly LayoutElement m_LayoutElement;

	[Token(Token = "0x17000B2F")]
	public Image image
	{
		[Token(Token = "0x6004EB8")]
		[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B30")]
	public bool isReady
	{
		[Token(Token = "0x6004EBA")]
		[Address(RVA = "0x7CE740", Offset = "0x7CD940", VA = "0x1807CE740", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6004EB9")]
		[Address(RVA = "0x8C82C0", Offset = "0x8C74C0", VA = "0x1808C82C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6004EBB")]
	[Address(RVA = "0x95BBD0", Offset = "0x95ADD0", VA = "0x18095BBD0")]
	public MDMarkupTableCellImage(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x6004EBC")]
	[Address(RVA = "0x95B9D0", Offset = "0x95ABD0", VA = "0x18095B9D0")]
	public void SetSprite(string imagePath, float overrideHeight = 0f)
	{
	}

	[Token(Token = "0x6004EBD")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "18")]
	public void OnReady()
	{
	}
}
