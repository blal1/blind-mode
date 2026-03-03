using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using YgomSystem.ElementSystem;

namespace YgomGame.Duel;

[Token(Token = "0x2001944")]
public class BattlePhaseInfoViewer : MonoBehaviour
{
	[Token(Token = "0x400EB85")]
	[FieldOffset(Offset = "0x20")]
	private GameObject root;

	[Token(Token = "0x400EB86")]
	[FieldOffset(Offset = "0x28")]
	private GameObject battleStepInfo;

	[Token(Token = "0x400EB87")]
	[FieldOffset(Offset = "0x30")]
	private TMP_Text textBattleStep;

	[Token(Token = "0x400EB88")]
	[FieldOffset(Offset = "0x38")]
	private Engine.StepType battleStep;

	[Token(Token = "0x400EB89")]
	[FieldOffset(Offset = "0x3C")]
	private Engine.DmgStepType damageStep;

	[Token(Token = "0x600A2D0")]
	[Address(RVA = "0xEE9DB0", Offset = "0xEE8FB0", VA = "0x180EE9DB0")]
	public void Initialize(ElementObjectManager ui)
	{
	}

	[Token(Token = "0x600A2D1")]
	[Address(RVA = "0xEEA180", Offset = "0xEE9380", VA = "0x180EEA180")]
	public void SetDisp(bool disp)
	{
	}

	[Token(Token = "0x600A2D2")]
	[Address(RVA = "0xEE9F30", Offset = "0xEE9130", VA = "0x180EE9F30")]
	public void SetBattleStep(Engine.StepType battleStep, Engine.DmgStepType damageStep, bool force = false)
	{
	}

	[Token(Token = "0x600A2D3")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public BattlePhaseInfoViewer()
	{
	}
}
