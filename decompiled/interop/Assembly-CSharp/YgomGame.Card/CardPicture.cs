using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using YgomSystem.YGomTMPro;

namespace YgomGame.Card;

[Token(Token = "0x200161A")]
public class CardPicture : MonoBehaviour
{
	[Token(Token = "0x400D49F")]
	[FieldOffset(Offset = "0x20")]
	public CardPictureTop topArea;

	[Token(Token = "0x400D4A0")]
	[FieldOffset(Offset = "0x28")]
	public Transform mainArea;

	[Token(Token = "0x400D4A1")]
	[FieldOffset(Offset = "0x30")]
	public Transform bottomArea;

	[Token(Token = "0x400D4A2")]
	private const int ILLUST_HEIGHT = 544;

	[Token(Token = "0x400D4A3")]
	private const int ILLUST_WIDTH = 544;

	[Token(Token = "0x400D4A4")]
	private const int ILLUST_HEIGHTSP = 566;

	[Token(Token = "0x400D4A5")]
	private const int ILLUST_WIDTHSP = 566;

	[Token(Token = "0x400D4A6")]
	private const float MAGICTYPETAGBIAS_GENERIC = -67.48f;

	[Token(Token = "0x400D4A7")]
	private const float MAGICTYPETAGBIAS_CH = -50f;

	[Token(Token = "0x400D4A8")]
	private const float MAGICTYPETAGBIAS_EN = -76.3f;

	[Token(Token = "0x400D4A9")]
	private const int PENDULUMTAGINDEX = 3;

	[Token(Token = "0x400D4AA")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private RawImage cardframe;

	[Token(Token = "0x400D4AB")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private RawImage illust_normal;

	[Token(Token = "0x400D4AC")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private RawImage illust_pendulum;

	[Token(Token = "0x400D4AD")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private RawImage illust_sp;

	[Token(Token = "0x400D4AE")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private ExtendedTextMeshProUGUI attrRuby;

	[Token(Token = "0x400D4AF")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private ExtendedTextMeshProUGUI cardText;

	[Token(Token = "0x400D4B0")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private ExtendedTextMeshProUGUI pdlmText;

	[Token(Token = "0x400D4B1")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Text pdlmScaleL;

	[Token(Token = "0x400D4B2")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Text pdlmScaleR;

	[Token(Token = "0x400D4B3")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private GameObject nonEffectArea;

	[Token(Token = "0x400D4B4")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private GameObject atkRoot;

	[Token(Token = "0x400D4B5")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private GameObject defRoot;

	[Token(Token = "0x400D4B6")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private Text atkText;

	[Token(Token = "0x400D4B7")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private Text defText;

	[Token(Token = "0x400D4B8")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private Image linkNum;

	[Token(Token = "0x400D4B9")]
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	private ExtendedTextMeshProUGUI spelltrapText;

	[Token(Token = "0x400D4BA")]
	[FieldOffset(Offset = "0xB8")]
	[Header("MediumParts:")]
	[SerializeField]
	private Sprite[] AttrSprites;

	[Token(Token = "0x400D4BB")]
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	private Sprite[] IconSprites;

	[Token(Token = "0x400D4BC")]
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	private Image AttrIcon;

	[Token(Token = "0x400D4BD")]
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	private Image SpellTrapIcon;

	[Token(Token = "0x400D4BE")]
	[FieldOffset(Offset = "0xD8")]
	[SerializeField]
	private GameObject LinkRoot;

	[Token(Token = "0x400D4BF")]
	[FieldOffset(Offset = "0xE0")]
	[SerializeField]
	private GameObject LinkDarkRoot;

	[Token(Token = "0x400D4C0")]
	[FieldOffset(Offset = "0xE8")]
	[SerializeField]
	private Image[] LinkIcons;

	[Token(Token = "0x400D4C1")]
	[FieldOffset(Offset = "0xF0")]
	[SerializeField]
	private Image Separator;

	[Token(Token = "0x400D4C2")]
	[FieldOffset(Offset = "0xF8")]
	private bool materialSetuped;

	[Token(Token = "0x400D4C3")]
	[FieldOffset(Offset = "0x100")]
	private GameObject _cachedGo;

	[Token(Token = "0x400D4C4")]
	[FieldOffset(Offset = "0x108")]
	private int cardId;

	[Token(Token = "0x400D4C5")]
	private const string prefabPath = "Prefabs/Duel/CardPicture";

	[Token(Token = "0x400D4C6")]
	private const string question = "?";

	[Token(Token = "0x400D4C7")]
	[FieldOffset(Offset = "0x0")]
	private static CardPicture instance;

	[Token(Token = "0x17001512")]
	public GameObject cachedGameObject
	{
		[Token(Token = "0x6008980")]
		[Address(RVA = "0xD50EB0", Offset = "0xD500B0", VA = "0x180D50EB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001513")]
	public static float FontSize
	{
		[Token(Token = "0x6008981")]
		[Address(RVA = "0xD50E50", Offset = "0xD50050", VA = "0x180D50E50")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6008982")]
		[Address(RVA = "0xD50FB0", Offset = "0xD501B0", VA = "0x180D50FB0")]
		set
		{
		}
	}

	[Token(Token = "0x17001514")]
	public static float FontSize_P
	{
		[Token(Token = "0x6008983")]
		[Address(RVA = "0xD50DF0", Offset = "0xD4FFF0", VA = "0x180D50DF0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6008984")]
		[Address(RVA = "0xD50F40", Offset = "0xD50140", VA = "0x180D50F40")]
		set
		{
		}
	}

	[Token(Token = "0x6008985")]
	[Address(RVA = "0xD4ED50", Offset = "0xD4DF50", VA = "0x180D4ED50")]
	public static CardPicture Create(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6008986")]
	[Address(RVA = "0xD4EC60", Offset = "0xD4DE60", VA = "0x180D4EC60")]
	public static void CreateAsync(Transform parent, Action<CardPicture> callback, bool bestFit = false)
	{
	}

	[Token(Token = "0x6008987")]
	[Address(RVA = "0xD4EEB0", Offset = "0xD4E0B0", VA = "0x180D4EEB0")]
	private void Initialize()
	{
	}

	[Token(Token = "0x6008988")]
	[Address(RVA = "0xD4F430", Offset = "0xD4E630", VA = "0x180D4F430")]
	public void SetUpCardContent(int mrk)
	{
	}

	[Token(Token = "0x6008989")]
	[Address(RVA = "0xD4FA20", Offset = "0xD4EC20", VA = "0x180D4FA20")]
	public void SetupCardAsync(int mrk, UnityAction<bool> onFinished)
	{
	}

	[Token(Token = "0x600898A")]
	[Address(RVA = "0xD501D0", Offset = "0xD4F3D0", VA = "0x180D501D0")]
	public void SetupText(int mrk, bool maskmode)
	{
	}

	[Token(Token = "0x600898B")]
	[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
	public RawImage GetImage()
	{
		return null;
	}

	[Token(Token = "0x600898C")]
	[Address(RVA = "0xD4EF60", Offset = "0xD4E160", VA = "0x180D4EF60")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600898D")]
	[Address(RVA = "0xD4F160", Offset = "0xD4E360", VA = "0x180D4F160")]
	private void SetFrame(int mrk)
	{
	}

	[Token(Token = "0x600898E")]
	[Address(RVA = "0xD4FC00", Offset = "0xD4EE00", VA = "0x180D4FC00")]
	private void SetupIcon(int cardid, bool maskmode)
	{
	}

	[Token(Token = "0x600898F")]
	[Address(RVA = "0xD4F010", Offset = "0xD4E210", VA = "0x180D4F010")]
	private void SetAttrIcon(int cardid)
	{
	}

	[Token(Token = "0x6008990")]
	[Address(RVA = "0xD4F340", Offset = "0xD4E540", VA = "0x180D4F340")]
	private void SetMagicTypeIcon(int cardid)
	{
	}

	[Token(Token = "0x6008991")]
	[Address(RVA = "0xD4F250", Offset = "0xD4E450", VA = "0x180D4F250")]
	private void SetLinkIcon(int linkmask)
	{
	}

	[Token(Token = "0x6008992")]
	[Address(RVA = "0xD4F900", Offset = "0xD4EB00", VA = "0x180D4F900")]
	private void SetUpCardIllustAsync(int mrk, UnityAction onFinished)
	{
	}

	[Token(Token = "0x6008993")]
	[Address(RVA = "0xD50DD0", Offset = "0xD4FFD0", VA = "0x180D50DD0")]
	public CardPicture()
	{
	}
}
