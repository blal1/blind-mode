using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Scenario;

[Token(Token = "0x2000ACB")]
public class ScenarioLocalSave
{
	[Token(Token = "0x40093B1")]
	private const string k_SaveKey = "Scenario_LocalSave";

	[Token(Token = "0x40093B2")]
	private const string k_DataKey_Menu_ShowSubtitle = "Menu.ShowSubtitle";

	[Token(Token = "0x40093B3")]
	private const string k_DataKey_Menu_ShowSubtitleMovie = "Menu.ShowSubtitleMovie";

	[Token(Token = "0x40093B4")]
	[FieldOffset(Offset = "0x10")]
	private bool m_Dirty;

	[Token(Token = "0x40093B5")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<string, object> m_DataCache;

	[Token(Token = "0x170008D4")]
	private Dictionary<string, object> data
	{
		[Token(Token = "0x6004246")]
		[Address(RVA = "0x8A1030", Offset = "0x8A0230", VA = "0x1808A1030")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008D5")]
	public bool showSubtitle
	{
		[Token(Token = "0x6004249")]
		[Address(RVA = "0x8A1200", Offset = "0x8A0400", VA = "0x1808A1200")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600424A")]
		[Address(RVA = "0x8A13F0", Offset = "0x8A05F0", VA = "0x1808A13F0")]
		set
		{
		}
	}

	[Token(Token = "0x170008D6")]
	public bool showSubtitleMovie
	{
		[Token(Token = "0x600424B")]
		[Address(RVA = "0x8A1070", Offset = "0x8A0270", VA = "0x1808A1070")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600424C")]
		[Address(RVA = "0x8A1330", Offset = "0x8A0530", VA = "0x1808A1330")]
		set
		{
		}
	}

	[Token(Token = "0x6004247")]
	[Address(RVA = "0x8A0E20", Offset = "0x8A0020", VA = "0x1808A0E20")]
	private Dictionary<string, object> Load()
	{
		return null;
	}

	[Token(Token = "0x6004248")]
	[Address(RVA = "0x8A0F50", Offset = "0x8A0150", VA = "0x1808A0F50")]
	public void Save(bool force = false)
	{
	}

	[Token(Token = "0x600424D")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public ScenarioLocalSave()
	{
	}
}
