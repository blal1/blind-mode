using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Duel;

[Token(Token = "0x20018F4")]
public class ListCardBase : MonoBehaviour
{
	[Token(Token = "0x400E980")]
	[FieldOffset(Offset = "0x20")]
	private ListCardBaseData m_CardData;

	[Token(Token = "0x400E981")]
	[FieldOffset(Offset = "0x28")]
	private ElementObjectManager m_EOManager;

	[Token(Token = "0x400E982")]
	[FieldOffset(Offset = "0x30")]
	private RawImage m_CardPicture;

	[Token(Token = "0x400E983")]
	[FieldOffset(Offset = "0x38")]
	private SelectionButton m_Sbtn;

	[Token(Token = "0x17001877")]
	public int cardid
	{
		[Token(Token = "0x600A0C8")]
		[Address(RVA = "0xEDEDE0", Offset = "0xEDDFE0", VA = "0x180EDEDE0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001878")]
	public int premid
	{
		[Token(Token = "0x600A0C9")]
		[Address(RVA = "0xEDEE20", Offset = "0xEDE020", VA = "0x180EDEE20")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001879")]
	public int dataindex
	{
		[Token(Token = "0x600A0CA")]
		[Address(RVA = "0xEDEE00", Offset = "0xEDE000", VA = "0x180EDEE00")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700187A")]
	public RawImage cardPicture
	{
		[Token(Token = "0x600A0CB")]
		[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700187B")]
	public SelectionButton sbtn
	{
		[Token(Token = "0x600A0CC")]
		[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600A0CD")]
	[Address(RVA = "0xEDEA20", Offset = "0xEDDC20", VA = "0x180EDEA20")]
	private void InitComponent()
	{
	}

	[Token(Token = "0x600A0CE")]
	[Address(RVA = "0xEDEAE0", Offset = "0xEDDCE0", VA = "0x180EDEAE0")]
	public void Initialize(UnityAction onSelected, UnityAction onClick)
	{
	}

	[Token(Token = "0x600A0CF")]
	[Address(RVA = "0xEDED40", Offset = "0xEDDF40", VA = "0x180EDED40")]
	public void SetData(ListCardBaseData data)
	{
	}

	[Token(Token = "0x600A0D0")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public ListCardBase()
	{
	}
}
