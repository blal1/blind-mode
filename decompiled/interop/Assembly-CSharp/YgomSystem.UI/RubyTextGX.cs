using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.LocalizedFont;
using YgomSystem.YGomTMPro;

namespace YgomSystem.UI;

[Token(Token = "0x200054E")]
[AddComponentMenu("UI/RubyTextGX", 10)]
[RequireComponent(typeof(ContentSizeFitter))]
public class RubyTextGX : ExtendedTextMeshProUGUI, ILocalizedFontOwner
{
	[Token(Token = "0x200054F")]
	private struct RubyInfo
	{
		[Token(Token = "0x40019C9")]
		[FieldOffset(Offset = "0x0")]
		public string rubyText;

		[Token(Token = "0x40019CA")]
		[FieldOffset(Offset = "0x8")]
		public int noRubyIndex;

		[Token(Token = "0x40019CB")]
		[FieldOffset(Offset = "0xC")]
		public int baseTextLen;
	}

	[Token(Token = "0x2000550")]
	private struct RubyTextInfo
	{
		[Token(Token = "0x40019CC")]
		[FieldOffset(Offset = "0x0")]
		public List<RubyInfo> rubyInfoList;

		[Token(Token = "0x40019CD")]
		[FieldOffset(Offset = "0x8")]
		public string parsedText;

		[Token(Token = "0x40019CE")]
		[FieldOffset(Offset = "0x10")]
		public string parsedTextWithRuby;
	}

	[Token(Token = "0x40019BA")]
	private const string tagRuby = "$R";

	[Token(Token = "0x40019BB")]
	private const string tagRubyBegin = "(";

	[Token(Token = "0x40019BC")]
	private const string tagRubyEnd = ")";

	[Token(Token = "0x40019BD")]
	[FieldOffset(Offset = "0x7E0")]
	[SerializeField]
	private float rubyScaleFactor;

	[Token(Token = "0x40019BE")]
	[FieldOffset(Offset = "0x7E8")]
	private RubyTextInfo m_RubyTextInfo;

	[Token(Token = "0x40019BF")]
	[FieldOffset(Offset = "0x800")]
	private List<(int, TMP_TextInfoExtended.VERTEXINDEX, Vector3)> m_MeshModifyInfoList;

	[Token(Token = "0x40019C0")]
	[FieldOffset(Offset = "0x808")]
	private bool m_ReCalculated;

	[Token(Token = "0x40019C1")]
	[FieldOffset(Offset = "0x809")]
	private bool m_RubyFit;

	[Token(Token = "0x40019C2")]
	[FieldOffset(Offset = "0x80C")]
	private float m_MeshRectMinX;

	[Token(Token = "0x40019C3")]
	[FieldOffset(Offset = "0x810")]
	private float m_MeshRectMaxX;

	[Token(Token = "0x40019C4")]
	[FieldOffset(Offset = "0x814")]
	private float m_MeshRectMinY;

	[Token(Token = "0x40019C5")]
	[FieldOffset(Offset = "0x818")]
	private float m_MeshRectMaxY;

	[Token(Token = "0x40019C6")]
	[FieldOffset(Offset = "0x820")]
	private ContentSizeFitter m_ContentSizeFilter;

	[Token(Token = "0x40019C7")]
	[FieldOffset(Offset = "0x828")]
	private float m_PreferredWidthWithRuby;

	[Token(Token = "0x40019C8")]
	[FieldOffset(Offset = "0x82C")]
	private float m_PreferredHeightWithRuby;

	[Token(Token = "0x170003A3")]
	public float rubyScale
	{
		[Token(Token = "0x6002268")]
		[Address(RVA = "0x64F550", Offset = "0x64E750", VA = "0x18064F550")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6002269")]
		[Address(RVA = "0x64F9D0", Offset = "0x64EBD0", VA = "0x18064F9D0")]
		set
		{
		}
	}

	[Token(Token = "0x170003A4")]
	public bool rubyFitWidth
	{
		[Token(Token = "0x600226A")]
		[Address(RVA = "0x64F540", Offset = "0x64E740", VA = "0x18064F540")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600226B")]
		[Address(RVA = "0x64F990", Offset = "0x64EB90", VA = "0x18064F990")]
		set
		{
		}
	}

	[Token(Token = "0x170003A5")]
	private List<RubyInfo> m_RubyInfoList
	{
		[Token(Token = "0x600226C")]
		[Address(RVA = "0x64F4F0", Offset = "0x64E6F0", VA = "0x18064F4F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003A6")]
	private string m_ParsedText
	{
		[Token(Token = "0x600226D")]
		[Address(RVA = "0x64F4E0", Offset = "0x64E6E0", VA = "0x18064F4E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003A7")]
	private string m_ParsedTextWithRuby
	{
		[Token(Token = "0x600226E")]
		[Address(RVA = "0x64F4D0", Offset = "0x64E6D0", VA = "0x18064F4D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003A8")]
	public override float preferredWidth
	{
		[Token(Token = "0x600226F")]
		[Address(RVA = "0x64F520", Offset = "0x64E720", VA = "0x18064F520", Slot = "84")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170003A9")]
	public override float preferredHeight
	{
		[Token(Token = "0x6002270")]
		[Address(RVA = "0x64F500", Offset = "0x64E700", VA = "0x18064F500", Slot = "85")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170003AA")]
	public override string text
	{
		[Token(Token = "0x6002271")]
		[Address(RVA = "0x64F560", Offset = "0x64E760", VA = "0x18064F560", Slot = "65")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002272")]
		[Address(RVA = "0x64FA10", Offset = "0x64EC10", VA = "0x18064FA10", Slot = "66")]
		set
		{
		}
	}

	[Token(Token = "0x6002273")]
	[Address(RVA = "0x64DD50", Offset = "0x64CF50", VA = "0x18064DD50", Slot = "4")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6002274")]
	[Address(RVA = "0x64EF40", Offset = "0x64E140", VA = "0x18064EF40", Slot = "6")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6002275")]
	[Address(RVA = "0x64EC60", Offset = "0x64DE60", VA = "0x18064EC60")]
	protected void OnPopulateRubyText(TMP_TextInfo tmpinfo)
	{
	}

	[Token(Token = "0x6002276")]
	[Address(RVA = "0x64DE10", Offset = "0x64D010", VA = "0x18064DE10")]
	private void GenerateMeshModifyInfoData(TMP_TextInfo tmpinfo)
	{
	}

	[Token(Token = "0x6002277")]
	[Address(RVA = "0x64F310", Offset = "0x64E510", VA = "0x18064F310")]
	private void UpdateTmpInfo(TMP_TextInfo tmpinfo, float baseY, float ofs, float word_ofs, float px, float pw, float ph, float cy, float rubyScale, int index, int idx, float d, TMP_TextInfoExtended.VERTEXINDEX pos)
	{
	}

	[Token(Token = "0x6002278")]
	[Address(RVA = "0x64F220", Offset = "0x64E420", VA = "0x18064F220")]
	private void UpdateTmpInfo2(TMP_TextInfo tmpinfo, float baseY, float ofs, float px, float pw, float ph, float cy, float rubyScale, int index, float d, TMP_TextInfoExtended.VERTEXINDEX pos)
	{
	}

	[Token(Token = "0x6002279")]
	[Address(RVA = "0x64DBB0", Offset = "0x64CDB0", VA = "0x18064DBB0")]
	private void AddUpdateData(int index, TMP_TextInfoExtended.VERTEXINDEX pos, Vector3 uiv)
	{
	}

	[Token(Token = "0x600227A")]
	[Address(RVA = "0x64F010", Offset = "0x64E210", VA = "0x18064F010")]
	private void UpdateRubyTextInfo(string rawstr)
	{
	}

	[Token(Token = "0x600227B")]
	[Address(RVA = "0x64F570", Offset = "0x64E770", VA = "0x18064F570")]
	private string parseRubyTag(string sourceText, string rubyTag, string rtTag, string endTag, List<RubyInfo> infos)
	{
		return null;
	}

	[Token(Token = "0x600227C")]
	[Address(RVA = "0x64F440", Offset = "0x64E640", VA = "0x18064F440")]
	public RubyTextGX()
	{
	}
}
