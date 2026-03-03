using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using YgomSystem.Utility;

namespace YgomSystem.UI.PropertyOverrider;

[Token(Token = "0x20005C6")]
public abstract class PlatformTextMeshProOverriderBase<TARGET> : PropertyOverriderBase<TARGET> where TARGET : TMP_Text
{
	[Token(Token = "0x4001BDD")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	private OverrideFloatProperty m_FontSize;

	[Token(Token = "0x4001BDE")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	private OverrideBoolProperty m_EnableAutoSize;

	[Token(Token = "0x4001BDF")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	private OverrideFloatProperty m_FontSizeMin;

	[Token(Token = "0x4001BE0")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	private OverrideFloatProperty m_FontSizeMax;

	[Token(Token = "0x4001BE1")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	private OverrideFloatProperty m_CharacterSpacing;

	[Token(Token = "0x4001BE2")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	private OverrideFloatProperty m_WordSpacing;

	[Token(Token = "0x4001BE3")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	private OverrideFloatProperty m_LineSpacing;

	[Token(Token = "0x4001BE4")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	private OverrideFloatProperty m_ParagraphSpacing;

	[Token(Token = "0x17000475")]
	public OverrideFloatProperty fontSize
	{
		[Token(Token = "0x60025F1")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000476")]
	public OverrideBoolProperty enableAutoSize
	{
		[Token(Token = "0x60025F2")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000477")]
	public OverrideFloatProperty fontSizeMin
	{
		[Token(Token = "0x60025F3")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000478")]
	public OverrideFloatProperty fontSizeMax
	{
		[Token(Token = "0x60025F4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000479")]
	public OverrideFloatProperty characterSpacing
	{
		[Token(Token = "0x60025F5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700047A")]
	public OverrideFloatProperty wordSpacing
	{
		[Token(Token = "0x60025F6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700047B")]
	public OverrideFloatProperty lineSpacing
	{
		[Token(Token = "0x60025F7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700047C")]
	public OverrideFloatProperty paragraphSpacing
	{
		[Token(Token = "0x60025F8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60025F9")]
	protected override void ImportImpl(TARGET target, DeviceInfo.PlatformType platformType)
	{
	}

	[Token(Token = "0x60025FA")]
	protected override void ExportImpl(TARGET target, DeviceInfo.PlatformType platformType)
	{
	}

	[Token(Token = "0x60025FB")]
	protected PlatformTextMeshProOverriderBase()
	{
	}
}
