using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.Timeline;

namespace YgomSample;

[Token(Token = "0x2001DB7")]
public class LabelCallbackSampleController : MonoBehaviour
{
	[Token(Token = "0x40104CC")]
	private const string k_ELabel_TMRoot = "TMRoot";

	[Token(Token = "0x40104CD")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float m_TimeScale;

	[Token(Token = "0x40104CE")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private string m_Label;

	[Token(Token = "0x40104CF")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private LabelDirectorWrapMode m_WrapMode;

	[Token(Token = "0x40104D0")]
	[FieldOffset(Offset = "0x38")]
	private LabeledPlayableController m_LabeledPlayableController;

	[Token(Token = "0x600BDFA")]
	[Address(RVA = "0x58B850", Offset = "0x58AA50", VA = "0x18058B850")]
	private void Start()
	{
	}

	[Token(Token = "0x600BDFB")]
	[Address(RVA = "0x58B790", Offset = "0x58A990", VA = "0x18058B790")]
	[ContextMenu("Progress")]
	public void Progress()
	{
	}

	[Token(Token = "0x600BDFC")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	private void OnTMLabelPaused(string label, LabeledPlayableController pd)
	{
	}

	[Token(Token = "0x600BDFD")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	private void OnTMLabelPlayed(string label, LabeledPlayableController pd)
	{
	}

	[Token(Token = "0x600BDFE")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	private void OnTMLabelStopped(string label, LabeledPlayableController pd)
	{
	}

	[Token(Token = "0x600BDFF")]
	[Address(RVA = "0x58B760", Offset = "0x58A960", VA = "0x18058B760")]
	[ContextMenu("Play")]
	private void Play()
	{
	}

	[Token(Token = "0x600BE00")]
	[Address(RVA = "0x58B740", Offset = "0x58A940", VA = "0x18058B740")]
	[ContextMenu("PlayNextLabel")]
	private void PlayNextLabel()
	{
	}

	[Token(Token = "0x600BE01")]
	[Address(RVA = "0x58BA00", Offset = "0x58AC00", VA = "0x18058BA00")]
	public LabelCallbackSampleController()
	{
	}
}
