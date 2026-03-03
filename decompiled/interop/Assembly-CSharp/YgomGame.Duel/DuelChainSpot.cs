using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using YgomSystem.ElementSystem;
using YgomSystem.Timeline;

namespace YgomGame.Duel;

[Token(Token = "0x2001A0A")]
public class DuelChainSpot : MonoBehaviour
{
	[Token(Token = "0x2001A0B")]
	private enum Step
	{
		[Token(Token = "0x400F059")]
		WaitChainResolveBegin,
		[Token(Token = "0x400F05A")]
		WaitChainResolveEnd,
		[Token(Token = "0x400F05B")]
		WaitTimelineEnd,
		[Token(Token = "0x400F05C")]
		Idle
	}

	[Token(Token = "0x400F04F")]
	private const string LABEL_ICON_CHAINWRAP = "ChainWrapSet";

	[Token(Token = "0x400F050")]
	private const string LABEL_ICON_NUM0 = "DummyNum01";

	[Token(Token = "0x400F051")]
	private const string LABEL_ICON_NUM1 = "DummyNum02_01";

	[Token(Token = "0x400F052")]
	private const string LABEL_ICON_NUM2 = "DummyNum02_02";

	[Token(Token = "0x400F053")]
	[FieldOffset(Offset = "0x20")]
	private ElementObjectManager m_EOManager_Origin;

	[Token(Token = "0x400F054")]
	[FieldOffset(Offset = "0x28")]
	private Vector3 m_OriginPos;

	[Token(Token = "0x400F055")]
	[FieldOffset(Offset = "0x34")]
	private Step m_Step;

	[Token(Token = "0x400F056")]
	[FieldOffset(Offset = "0x38")]
	private bool m_OnChainResolveBeginFlag;

	[Token(Token = "0x400F057")]
	[FieldOffset(Offset = "0x39")]
	private bool m_OnChainResolveEndFlag;

	[Token(Token = "0x170019EC")]
	private DuelIconSprites m_DuelIconSprites
	{
		[Token(Token = "0x600A849")]
		[Address(RVA = "0x9D9130", Offset = "0x9D8330", VA = "0x1809D9130")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170019ED")]
	private ElementObjectManager m_EOManager
	{
		[Token(Token = "0x600A84A")]
		[Address(RVA = "0xF474E0", Offset = "0xF466E0", VA = "0x180F474E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170019EE")]
	private PlayableDirector m_PlayableDirector
	{
		[Token(Token = "0x600A84B")]
		[Address(RVA = "0xF475C0", Offset = "0xF467C0", VA = "0x180F475C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170019EF")]
	private LabeledPlayableController m_LPController
	{
		[Token(Token = "0x600A84C")]
		[Address(RVA = "0xF47570", Offset = "0xF46770", VA = "0x180F47570")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600A84D")]
	[Address(RVA = "0xF46870", Offset = "0xF45A70", VA = "0x180F46870")]
	public void Play(int chainnum, int position, bool cardexist, bool turn, Vector3 worldposition, bool mutesound)
	{
	}

	[Token(Token = "0x600A84E")]
	[Address(RVA = "0x96E7E0", Offset = "0x96D9E0", VA = "0x18096E7E0")]
	public void OnChainResolveBegin()
	{
	}

	[Token(Token = "0x600A84F")]
	[Address(RVA = "0xA4AB60", Offset = "0xA49D60", VA = "0x180A4AB60")]
	public void OnChainResolveEnd()
	{
	}

	[Token(Token = "0x600A850")]
	[Address(RVA = "0xF467F0", Offset = "0xF459F0", VA = "0x180F467F0")]
	public void OnChainSetMore()
	{
	}

	[Token(Token = "0x600A851")]
	[Address(RVA = "0xF46EA0", Offset = "0xF460A0", VA = "0x180F46EA0")]
	private void Update()
	{
	}

	[Token(Token = "0x600A852")]
	[Address(RVA = "0xF471C0", Offset = "0xF463C0", VA = "0x180F471C0")]
	private void WaitChainResolveBegin()
	{
	}

	[Token(Token = "0x600A853")]
	[Address(RVA = "0xF47360", Offset = "0xF46560", VA = "0x180F47360")]
	private void WaitChainResolveEnd()
	{
	}

	[Token(Token = "0x600A854")]
	[Address(RVA = "0xF47450", Offset = "0xF46650", VA = "0x180F47450")]
	private void WaitTimelineEnd()
	{
	}

	[Token(Token = "0x600A855")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public DuelChainSpot()
	{
	}
}
