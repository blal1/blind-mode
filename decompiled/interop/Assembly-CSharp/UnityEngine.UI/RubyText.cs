using System.Collections.Generic;
using Il2CppDummyDll;
using YgomSystem.LocalizedFont;

namespace UnityEngine.UI;

[Token(Token = "0x20000BA")]
[AddComponentMenu("UI/RubyText", 10)]
public class RubyText : Text, ILocalizedFontOwner
{
	[Token(Token = "0x20000BB")]
	private struct RubyInfo
	{
		[Token(Token = "0x40003C9")]
		[FieldOffset(Offset = "0x0")]
		public string rubyText;

		[Token(Token = "0x40003CA")]
		[FieldOffset(Offset = "0x8")]
		public int noRubyIndex;

		[Token(Token = "0x40003CB")]
		[FieldOffset(Offset = "0xC")]
		public int baseTextLen;
	}

	[Token(Token = "0x40003BE")]
	[FieldOffset(Offset = "0x110")]
	[SerializeField]
	private float rubyScaleFactor;

	[Token(Token = "0x40003BF")]
	[FieldOffset(Offset = "0x114")]
	private bool rubyFit;

	[Token(Token = "0x40003C0")]
	[FieldOffset(Offset = "0x118")]
	[SerializeField]
	private LocalizedFontSettingsBase.FontType m_localizedFontType;

	[Token(Token = "0x40003C1")]
	[FieldOffset(Offset = "0x11C")]
	[SerializeField]
	private int m_localizedFontMaterialIndex;

	[Token(Token = "0x40003C2")]
	[FieldOffset(Offset = "0x120")]
	private readonly UIVertex[] m_TempVerts;

	[Token(Token = "0x40003C3")]
	[FieldOffset(Offset = "0x128")]
	private List<RubyInfo> rubyInfos;

	[Token(Token = "0x40003C4")]
	private const string tagRuby = "$R";

	[Token(Token = "0x40003C5")]
	private const string tagRubyBegin = "(";

	[Token(Token = "0x40003C6")]
	private const string tagRubyEnd = ")";

	[Token(Token = "0x40003C7")]
	[FieldOffset(Offset = "0x130")]
	private float minX;

	[Token(Token = "0x40003C8")]
	[FieldOffset(Offset = "0x134")]
	private float maxX;

	[Token(Token = "0x1700004E")]
	public LocalizedFontSettingsBase.FontType localizedFontType
	{
		[Token(Token = "0x6000361")]
		[Address(RVA = "0x49BF20", Offset = "0x49B120", VA = "0x18049BF20", Slot = "85")]
		get
		{
			return default(LocalizedFontSettingsBase.FontType);
		}
		[Token(Token = "0x6000362")]
		[Address(RVA = "0x49C660", Offset = "0x49B860", VA = "0x18049C660", Slot = "86")]
		set
		{
		}
	}

	[Token(Token = "0x1700004F")]
	public int localizedFontMaterialIndex
	{
		[Token(Token = "0x6000363")]
		[Address(RVA = "0x49BE10", Offset = "0x49B010", VA = "0x18049BE10", Slot = "87")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000364")]
		[Address(RVA = "0x49C520", Offset = "0x49B720", VA = "0x18049C520", Slot = "88")]
		set
		{
		}
	}

	[Token(Token = "0x17000050")]
	public float rubyScale
	{
		[Token(Token = "0x6000365")]
		[Address(RVA = "0x680F80", Offset = "0x680180", VA = "0x180680F80")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000366")]
		[Address(RVA = "0x6813F0", Offset = "0x6805F0", VA = "0x1806813F0")]
		set
		{
		}
	}

	[Token(Token = "0x17000051")]
	public bool rubyFitWidth
	{
		[Token(Token = "0x6000367")]
		[Address(RVA = "0x680F70", Offset = "0x680170", VA = "0x180680F70")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000368")]
		[Address(RVA = "0x6813B0", Offset = "0x6805B0", VA = "0x1806813B0")]
		set
		{
		}
	}

	[Token(Token = "0x17000052")]
	public override float preferredWidth
	{
		[Token(Token = "0x600036A")]
		[Address(RVA = "0x680DE0", Offset = "0x67FFE0", VA = "0x180680DE0", Slot = "79")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000053")]
	public override float preferredHeight
	{
		[Token(Token = "0x600036B")]
		[Address(RVA = "0x680C50", Offset = "0x67FE50", VA = "0x180680C50", Slot = "82")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6000369")]
	[Address(RVA = "0x680AC0", Offset = "0x67FCC0", VA = "0x180680AC0", Slot = "6")]
	protected override void Start()
	{
	}

	[Token(Token = "0x600036C")]
	[Address(RVA = "0x680F90", Offset = "0x680190", VA = "0x180680F90")]
	private string parseRubyTag(string sourceText, string rubyTag, string rtTag, string endTag, List<RubyInfo> infos)
	{
		return null;
	}

	[Token(Token = "0x600036D")]
	[Address(RVA = "0x67E870", Offset = "0x67DA70", VA = "0x18067E870", Slot = "44")]
	protected override void OnPopulateMesh(VertexHelper toFill)
	{
	}

	[Token(Token = "0x600036E")]
	[Address(RVA = "0x680B80", Offset = "0x67FD80", VA = "0x180680B80")]
	public RubyText()
	{
	}
}
