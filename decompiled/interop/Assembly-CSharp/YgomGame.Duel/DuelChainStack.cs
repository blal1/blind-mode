using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using YgomSystem.ElementSystem;

namespace YgomGame.Duel;

[Token(Token = "0x2001A0C")]
public class DuelChainStack : MonoBehaviour
{
	[Token(Token = "0x400F05D")]
	private const string LABEL_EO_CHAINSET = "ChainCardSet";

	[Token(Token = "0x400F05E")]
	private const string LABEL_EO_OFFSET = "Offset";

	[Token(Token = "0x400F05F")]
	private const string LABEL_EO_STRIPE = "ChainStraight";

	[Token(Token = "0x400F060")]
	private const string LABEL_EO_CHAINCARDEOM = "DummyChainCard";

	[Token(Token = "0x400F061")]
	private const string LABEL_EO_CHAINCARD = "DummyCardModel_front";

	[Token(Token = "0x400F062")]
	private const string LABEL_EO_CHAINNUM = "ChainNum";

	[Token(Token = "0x400F063")]
	private const string LABEL_EO_DIGITAL = "_Digit";

	[Token(Token = "0x400F064")]
	private const string LABEL_EO_TEN = "_Tens";

	[Token(Token = "0x400F065")]
	private const string LABEL_EO_ONE = "_Ones";

	[Token(Token = "0x400F066")]
	private const string LABEL_EO_RESOLVETEXT = "ResolveTextSet";

	[Token(Token = "0x400F067")]
	private const string LABEL_EO_CHAINEFFECT = "_Chain";

	[Token(Token = "0x400F068")]
	private const string LABEL_EO_CHAINSCALE = "CardLightSetScaleC";

	[Token(Token = "0x400F069")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<bool, string>[] m_LabelTable;

	[Token(Token = "0x400F06A")]
	[FieldOffset(Offset = "0x20")]
	private List<DuelChainManager.ChainSpotData> m_ChaindataList;

	[Token(Token = "0x170019F0")]
	private ElementObjectManager m_Eom
	{
		[Token(Token = "0x600A856")]
		[Address(RVA = "0xF49190", Offset = "0xF48390", VA = "0x180F49190")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170019F1")]
	private PlayableDirector m_Pd
	{
		[Token(Token = "0x600A857")]
		[Address(RVA = "0xF491D0", Offset = "0xF483D0", VA = "0x180F491D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600A858")]
	[Address(RVA = "0xF47A50", Offset = "0xF46C50", VA = "0x180F47A50")]
	private GameObject GetChainSet(int layer, bool pos)
	{
		return null;
	}

	[Token(Token = "0x600A859")]
	[Address(RVA = "0xF47B80", Offset = "0xF46D80", VA = "0x180F47B80")]
	private GameObject GetChainStripe(int layer0, bool pos0, int layer1, bool pos1)
	{
		return null;
	}

	[Token(Token = "0x600A85A")]
	[Address(RVA = "0xF47600", Offset = "0xF46800", VA = "0x180F47600")]
	private MeshRenderer GetChainCard(int layer, bool pos)
	{
		return null;
	}

	[Token(Token = "0x600A85B")]
	[Address(RVA = "0xF48CD0", Offset = "0xF47ED0", VA = "0x180F48CD0")]
	private void SetChainStripe(int layer0, bool pos0, bool pos1)
	{
	}

	[Token(Token = "0x600A85C")]
	[Address(RVA = "0xF47EB0", Offset = "0xF470B0", VA = "0x180F47EB0")]
	private void HideChainStripeInLayer(int layer0)
	{
	}

	[Token(Token = "0x600A85D")]
	[Address(RVA = "0xF47E10", Offset = "0xF47010", VA = "0x180F47E10")]
	private void HideChainSetInLayer(int layer)
	{
	}

	[Token(Token = "0x600A85E")]
	[Address(RVA = "0xF47F70", Offset = "0xF47170", VA = "0x180F47F70")]
	private void SetChainCard(int layer, bool isleft, int cardid, int styleid, bool isresolve)
	{
	}

	[Token(Token = "0x600A85F")]
	[Address(RVA = "0xF47D10", Offset = "0xF46F10", VA = "0x180F47D10")]
	private (bool, int, int) GetDataFromLayer(int layer)
	{
		return default((bool, int, int));
	}

	[Token(Token = "0x600A860")]
	[Address(RVA = "0xF48450", Offset = "0xF47650", VA = "0x180F48450")]
	private void SetChainNum(int layer, bool pos, int num)
	{
	}

	[Token(Token = "0x600A861")]
	[Address(RVA = "0xF47760", Offset = "0xF46960", VA = "0x180F47760")]
	private (SpriteRenderer, SpriteRenderer, SpriteRenderer) GetChainNumSR(int layer, bool pos)
	{
		return default((SpriteRenderer, SpriteRenderer, SpriteRenderer));
	}

	[Token(Token = "0x600A862")]
	[Address(RVA = "0xF48DC0", Offset = "0xF47FC0", VA = "0x180F48DC0")]
	private void SetSpriteNum(SpriteRenderer sprite, int digit)
	{
	}

	[Token(Token = "0x600A863")]
	[Address(RVA = "0xF489F0", Offset = "0xF47BF0", VA = "0x180F489F0")]
	public void SetChainStack1(List<DuelChainManager.ChainSpotData> chainstack)
	{
	}

	[Token(Token = "0x600A864")]
	[Address(RVA = "0xF48B30", Offset = "0xF47D30", VA = "0x180F48B30")]
	public void SetChainStack2(List<DuelChainManager.ChainSpotData> chainstack)
	{
	}

	[Token(Token = "0x600A865")]
	[Address(RVA = "0xF48650", Offset = "0xF47850", VA = "0x180F48650")]
	public void SetChainResolve1(List<DuelChainManager.ChainSpotData> chainstack)
	{
	}

	[Token(Token = "0x600A866")]
	[Address(RVA = "0xF486E0", Offset = "0xF478E0", VA = "0x180F486E0")]
	public void SetChainResolve2(List<DuelChainManager.ChainSpotData> chainstack, bool isFirst)
	{
	}

	[Token(Token = "0x600A867")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public DuelChainStack()
	{
	}
}
