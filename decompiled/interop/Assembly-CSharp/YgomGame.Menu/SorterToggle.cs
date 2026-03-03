using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.YGomTMPro;

namespace YgomGame.Menu;

[Token(Token = "0x2001189")]
public class SorterToggle : MonoBehaviour
{
	[Token(Token = "0x400B7BB")]
	[FieldOffset(Offset = "0x20")]
	private UnityAction m_OnClickAscAction;

	[Token(Token = "0x400B7BC")]
	[FieldOffset(Offset = "0x28")]
	private UnityAction m_OnClickDescAction;

	[Token(Token = "0x400B7BD")]
	private const string LABEL_SBN_ASCBUTTON = "Button0";

	[Token(Token = "0x400B7BE")]
	private const string LABEL_SBN_DESCBUTTON = "Button1";

	[Token(Token = "0x400B7BF")]
	private const string LABEL_RT_ASCIMAGEOFF = "ImageOff0";

	[Token(Token = "0x400B7C0")]
	private const string LABEL_RT_ASCIMAGEON = "ImageOn0";

	[Token(Token = "0x400B7C1")]
	private const string LABEL_RT_DESCIMAGEOFF = "ImageOff1";

	[Token(Token = "0x400B7C2")]
	private const string LABEL_RT_DESCIMAGEON = "ImageOn1";

	[Token(Token = "0x400B7C3")]
	private const string LABEL_TXT_METHODTEXT = "Label";

	[Token(Token = "0x1700114E")]
	private ElementObjectManager m_eom
	{
		[Token(Token = "0x6006DFA")]
		[Address(RVA = "0xB68480", Offset = "0xB67680", VA = "0x180B68480")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700114F")]
	private ExtendedTextMeshProUGUI m_MethodLabel
	{
		[Token(Token = "0x6006DFB")]
		[Address(RVA = "0xB683F0", Offset = "0xB675F0", VA = "0x180B683F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001150")]
	private RectTransform m_AscImageOff
	{
		[Token(Token = "0x6006DFC")]
		[Address(RVA = "0xB68120", Offset = "0xB67320", VA = "0x180B68120")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001151")]
	private RectTransform m_AscImageOn
	{
		[Token(Token = "0x6006DFD")]
		[Address(RVA = "0xB681B0", Offset = "0xB673B0", VA = "0x180B681B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001152")]
	private RectTransform m_DescImageOff
	{
		[Token(Token = "0x6006DFE")]
		[Address(RVA = "0xB682D0", Offset = "0xB674D0", VA = "0x180B682D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001153")]
	private RectTransform m_DescImageOn
	{
		[Token(Token = "0x6006DFF")]
		[Address(RVA = "0xB68360", Offset = "0xB67560", VA = "0x180B68360")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001154")]
	private SelectionButton m_AscButton
	{
		[Token(Token = "0x6006E00")]
		[Address(RVA = "0xB68090", Offset = "0xB67290", VA = "0x180B68090")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001155")]
	private SelectionButton m_DescButton
	{
		[Token(Token = "0x6006E01")]
		[Address(RVA = "0xB68240", Offset = "0xB67440", VA = "0x180B68240")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006E02")]
	[Address(RVA = "0xB67A50", Offset = "0xB66C50", VA = "0x180B67A50")]
	public void Initialize(string label, bool isAscOn, bool isDescOn, bool isUnordered)
	{
	}

	[Token(Token = "0x6006E03")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	private void Awake()
	{
	}

	[Token(Token = "0x6006E04")]
	[Address(RVA = "0xB67F40", Offset = "0xB67140", VA = "0x180B67F40")]
	private void Start()
	{
	}

	[Token(Token = "0x6006E05")]
	[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380")]
	public void SetOnClickAscCallback(UnityAction callback)
	{
	}

	[Token(Token = "0x6006E06")]
	[Address(RVA = "0x402FB0", Offset = "0x4021B0", VA = "0x180402FB0")]
	public void SetOnClickDescCallback(UnityAction callback)
	{
	}

	[Token(Token = "0x6006E07")]
	[Address(RVA = "0xB67EC0", Offset = "0xB670C0", VA = "0x180B67EC0")]
	public void SetDownTransitionItem(SelectionItem item)
	{
	}

	[Token(Token = "0x6006E08")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public SorterToggle()
	{
	}
}
