using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using YgomGame.Menu.Common;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Deck;

[Token(Token = "0x2001103")]
public class SearchCategory : MonoBehaviour
{
	[Token(Token = "0x400B3CA")]
	[FieldOffset(Offset = "0x20")]
	private ElementObjectManager m_eom;

	[Token(Token = "0x400B3CB")]
	[FieldOffset(Offset = "0x28")]
	private GameObject m_ImageOn;

	[Token(Token = "0x400B3CC")]
	[FieldOffset(Offset = "0x30")]
	private GameObject m_ImageOff;

	[Token(Token = "0x400B3CD")]
	[FieldOffset(Offset = "0x38")]
	private SelectionButton m_button;

	[Token(Token = "0x400B3CE")]
	[FieldOffset(Offset = "0x40")]
	private GameObject m_templateObj;

	[Token(Token = "0x400B3CF")]
	[FieldOffset(Offset = "0x48")]
	private UnityAction m_OnClickAction;

	[Token(Token = "0x400B3D0")]
	[FieldOffset(Offset = "0x50")]
	private SearchCategoryWidget m_SearchCategoryWidget;

	[Token(Token = "0x1700111C")]
	public SearchCategoryWidget searchCategoryWidget
	{
		[Token(Token = "0x6006AF1")]
		[Address(RVA = "0x580700", Offset = "0x57F900", VA = "0x180580700")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006AF2")]
	[Address(RVA = "0xB2EEA0", Offset = "0xB2E0A0", VA = "0x180B2EEA0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6006AF3")]
	[Address(RVA = "0xB2F1A0", Offset = "0xB2E3A0", VA = "0x180B2F1A0")]
	public IAsyncProgressContainer SetParams(int id, string name, bool isSelected)
	{
		return null;
	}

	[Token(Token = "0x6006AF4")]
	[Address(RVA = "0xB2F090", Offset = "0xB2E290", VA = "0x180B2F090")]
	private IAsyncProgressContainer SetData(int id, string name)
	{
		return null;
	}

	[Token(Token = "0x6006AF5")]
	[Address(RVA = "0xB2F140", Offset = "0xB2E340", VA = "0x180B2F140")]
	public void SetOnClickCallback(UnityAction callback)
	{
	}

	[Token(Token = "0x6006AF6")]
	[Address(RVA = "0xB2EFB0", Offset = "0xB2E1B0", VA = "0x180B2EFB0")]
	public bool OnClick()
	{
		return default(bool);
	}

	[Token(Token = "0x6006AF7")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	private void Start()
	{
	}

	[Token(Token = "0x6006AF8")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public SearchCategory()
	{
	}
}
