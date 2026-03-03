using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Stats;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.YGomTMPro;

[Token(Token = "0x2000052")]
public class CardReportTelopController : MonoBehaviour
{
	[Token(Token = "0x2000053")]
	public enum Step
	{
		[Token(Token = "0x40001A8")]
		Idle,
		[Token(Token = "0x40001A9")]
		Opening,
		[Token(Token = "0x40001AA")]
		Showing,
		[Token(Token = "0x40001AB")]
		Closing
	}

	[Token(Token = "0x400019B")]
	[FieldOffset(Offset = "0x20")]
	private ElementObjectManager m_EOManager;

	[Token(Token = "0x400019C")]
	[FieldOffset(Offset = "0x28")]
	private RawImage m_CardPicture;

	[Token(Token = "0x400019D")]
	[FieldOffset(Offset = "0x30")]
	private ExtendedTextMeshProUGUI m_ItemName;

	[Token(Token = "0x400019E")]
	[FieldOffset(Offset = "0x38")]
	private ExtendedTextMeshProUGUI m_ItemBody;

	[Token(Token = "0x400019F")]
	[FieldOffset(Offset = "0x40")]
	private GameObject m_Effect1;

	[Token(Token = "0x40001A0")]
	[FieldOffset(Offset = "0x48")]
	private GameObject m_Effect2;

	[Token(Token = "0x40001A1")]
	[FieldOffset(Offset = "0x50")]
	private GameObject m_Bg0;

	[Token(Token = "0x40001A2")]
	[FieldOffset(Offset = "0x58")]
	private GameObject m_Bg1;

	[Token(Token = "0x40001A3")]
	[FieldOffset(Offset = "0x60")]
	private GameObject m_Bg2;

	[Token(Token = "0x40001A4")]
	[FieldOffset(Offset = "0x68")]
	private Tween m_Tween;

	[Token(Token = "0x40001A5")]
	[FieldOffset(Offset = "0x70")]
	private int m_Countdown;

	[Token(Token = "0x1700001D")]
	public Step step
	{
		[Token(Token = "0x6000179")]
		[Address(RVA = "0x3EC970", Offset = "0x3EBB70", VA = "0x1803EC970")]
		[CompilerGenerated]
		get
		{
			return default(Step);
		}
		[Token(Token = "0x600017A")]
		[Address(RVA = "0x3EC980", Offset = "0x3EBB80", VA = "0x1803EC980")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x600017B")]
	[Address(RVA = "0x3EC2A0", Offset = "0x3EB4A0", VA = "0x1803EC2A0")]
	private void Awake()
	{
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0x3EC5F0", Offset = "0x3EB7F0", VA = "0x1803EC5F0")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0x3EC700", Offset = "0x3EB900", VA = "0x1803EC700")]
	public void SetStateContent(int cardid, string message, string messageNum, string messageUnit, CardStatsData.CARD_STATS_EFFECT_TYPE effecttype)
	{
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0x3EC880", Offset = "0x3EBA80", VA = "0x1803EC880")]
	public void Show(int duration)
	{
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0x3EC6D0", Offset = "0x3EB8D0", VA = "0x1803EC6D0")]
	public void Hide()
	{
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0x3EC660", Offset = "0x3EB860", VA = "0x1803EC660")]
	public void HideEffect()
	{
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0x3EC510", Offset = "0x3EB710", VA = "0x1803EC510")]
	public void Clear()
	{
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0x3EC6E0", Offset = "0x3EB8E0", VA = "0x1803EC6E0")]
	public void OnHide()
	{
	}

	[Token(Token = "0x6000183")]
	[Address(RVA = "0x3EC6F0", Offset = "0x3EB8F0", VA = "0x1803EC6F0")]
	public void OnShow()
	{
	}

	[Token(Token = "0x6000184")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public CardReportTelopController()
	{
	}
}
