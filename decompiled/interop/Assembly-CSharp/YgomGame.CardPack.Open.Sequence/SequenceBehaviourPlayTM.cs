using Il2CppDummyDll;
using UnityEngine.Playables;

namespace YgomGame.CardPack.Open.Sequence;

[Token(Token = "0x200156A")]
public class SequenceBehaviourPlayTM : SequenceBehaviour
{
	[Token(Token = "0x400CCAD")]
	[FieldOffset(Offset = "0x20")]
	private PlayableAsset m_PlayableAsset;

	[Token(Token = "0x17001434")]
	protected override bool isAcceptToSkipLoop
	{
		[Token(Token = "0x6008450")]
		[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6008451")]
	[Address(RVA = "0xCE05D0", Offset = "0xCDF7D0", VA = "0x180CE05D0")]
	public SequenceBehaviourPlayTM(SequenceBehaviourWork sequenceBehaviourWork, PlayableAsset playableAsset)
	{
	}

	[Token(Token = "0x6008452")]
	[Address(RVA = "0xCE0570", Offset = "0xCDF770", VA = "0x180CE0570", Slot = "11")]
	protected override void OnBegin()
	{
	}

	[Token(Token = "0x6008453")]
	[Address(RVA = "0xCC8CB0", Offset = "0xCC7EB0", VA = "0x180CC8CB0", Slot = "12")]
	protected override bool OnUpdate()
	{
		return default(bool);
	}
}
