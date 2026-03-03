using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.Timeline;

namespace YgomSample;

[Token(Token = "0x2001DB8")]
public class LabeledTimelineSampleController : MonoBehaviour
{
	[Token(Token = "0x40104D1")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private string m_PlayLabel;

	[Token(Token = "0x40104D2")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private LabelDirectorWrapMode m_WrapMode;

	[Token(Token = "0x40104D3")]
	[FieldOffset(Offset = "0x30")]
	private LabeledPlayableController m_LabeledPlayableController;

	[Token(Token = "0x600BE02")]
	[Address(RVA = "0x58BA40", Offset = "0x58AC40", VA = "0x18058BA40")]
	private void Start()
	{
	}

	[Token(Token = "0x600BE03")]
	[Address(RVA = "0x58BA10", Offset = "0x58AC10", VA = "0x18058BA10")]
	[ContextMenu("Play")]
	public void Play()
	{
	}

	[Token(Token = "0x600BE04")]
	[Address(RVA = "0x58BAA0", Offset = "0x58ACA0", VA = "0x18058BAA0")]
	public LabeledTimelineSampleController()
	{
	}
}
