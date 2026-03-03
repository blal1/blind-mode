using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Deck;

[Token(Token = "0x20010E3")]
public class FilterCheck : MonoBehaviour
{
	[Token(Token = "0x400B25F")]
	[FieldOffset(Offset = "0x20")]
	public UnityAction m_OnClickAction;

	[Token(Token = "0x400B260")]
	private const string k_LABEL_SHORTCUTPARENT = "ShortcutParent";

	[Token(Token = "0x400B261")]
	private const string k_LABEL_AND = "And";

	[Token(Token = "0x400B262")]
	private const string k_LABEL_OR = "Or";

	[Token(Token = "0x400B263")]
	[FieldOffset(Offset = "0x28")]
	private ElementObjectManager m_Eom;

	[Token(Token = "0x400B264")]
	[FieldOffset(Offset = "0x30")]
	private RectTransform m_AND;

	[Token(Token = "0x400B265")]
	[FieldOffset(Offset = "0x38")]
	private RectTransform m_OR;

	[Token(Token = "0x400B266")]
	[FieldOffset(Offset = "0x40")]
	private bool isInitilaized;

	[Token(Token = "0x170010F5")]
	public bool isAnd
	{
		[Token(Token = "0x60069FD")]
		[Address(RVA = "0x4166B0", Offset = "0x4158B0", VA = "0x1804166B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60069FE")]
		[Address(RVA = "0x416710", Offset = "0x415910", VA = "0x180416710")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170010F6")]
	public FilterDialog.FilterGroupType m_GroupType
	{
		[Token(Token = "0x60069FF")]
		[Address(RVA = "0x5FA7A0", Offset = "0x5F99A0", VA = "0x1805FA7A0")]
		[CompilerGenerated]
		get
		{
			return default(FilterDialog.FilterGroupType);
		}
		[Token(Token = "0x6006A00")]
		[Address(RVA = "0x86B170", Offset = "0x86A370", VA = "0x18086B170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170010F7")]
	public SelectionButton m_Button
	{
		[Token(Token = "0x6006A01")]
		[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6006A02")]
		[Address(RVA = "0x414E90", Offset = "0x414090", VA = "0x180414E90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170010F8")]
	public GameObject m_ShortcutParent
	{
		[Token(Token = "0x6006A03")]
		[Address(RVA = "0x580700", Offset = "0x57F900", VA = "0x180580700")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6006A04")]
		[Address(RVA = "0x580760", Offset = "0x57F960", VA = "0x180580760")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6006A05")]
	[Address(RVA = "0xB0EB70", Offset = "0xB0DD70", VA = "0x180B0EB70")]
	private void InitializeElements()
	{
	}

	[Token(Token = "0x6006A06")]
	[Address(RVA = "0xB0ECD0", Offset = "0xB0DED0", VA = "0x180B0ECD0")]
	public void Initialize(bool isAnd, FilterDialog.FilterGroupType type)
	{
	}

	[Token(Token = "0x6006A07")]
	[Address(RVA = "0xB0EB60", Offset = "0xB0DD60", VA = "0x180B0EB60")]
	private void Awake()
	{
	}

	[Token(Token = "0x6006A08")]
	[Address(RVA = "0xB0EDD0", Offset = "0xB0DFD0", VA = "0x180B0EDD0")]
	private void Start()
	{
	}

	[Token(Token = "0x6006A09")]
	[Address(RVA = "0xB0EEA0", Offset = "0xB0E0A0", VA = "0x180B0EEA0")]
	public void Toggle()
	{
	}

	[Token(Token = "0x6006A0A")]
	[Address(RVA = "0xB0ED60", Offset = "0xB0DF60", VA = "0x180B0ED60")]
	public void SetOn(bool isAnd)
	{
	}

	[Token(Token = "0x6006A0B")]
	[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380")]
	public void SetOnClickCallback(UnityAction callback)
	{
	}

	[Token(Token = "0x6006A0C")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public FilterCheck()
	{
	}
}
