using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;

namespace YgomGame.Duel;

[Token(Token = "0x2001919")]
public class ManaSet : MonoBehaviour
{
	[Token(Token = "0x200191A")]
	private enum Step
	{
		[Token(Token = "0x400EAAB")]
		None,
		[Token(Token = "0x400EAAC")]
		BeforeNum,
		[Token(Token = "0x400EAAD")]
		ChangeNum,
		[Token(Token = "0x400EAAE")]
		AfterNum,
		[Token(Token = "0x400EAAF")]
		Out
	}

	[Token(Token = "0x400EA9F")]
	[FieldOffset(Offset = "0x20")]
	private ElementObjectManager ui;

	[Token(Token = "0x400EAA0")]
	[FieldOffset(Offset = "0x28")]
	private Image counterIcon;

	[Token(Token = "0x400EAA1")]
	[FieldOffset(Offset = "0x30")]
	private TextMeshProUGUI text;

	[Token(Token = "0x400EAA2")]
	[FieldOffset(Offset = "0x38")]
	private Vector3 targetAnchor;

	[Token(Token = "0x400EAA3")]
	[FieldOffset(Offset = "0x44")]
	private int afterNum;

	[Token(Token = "0x400EAA4")]
	[FieldOffset(Offset = "0x48")]
	private int currentNum;

	[Token(Token = "0x400EAA5")]
	[FieldOffset(Offset = "0x4C")]
	private int deltaNum;

	[Token(Token = "0x400EAA6")]
	[FieldOffset(Offset = "0x50")]
	private float timer;

	[Token(Token = "0x400EAA7")]
	private const float timeCounterChange = 1f;

	[Token(Token = "0x400EAA8")]
	private const float timeAfter = 0.3f;

	[Token(Token = "0x400EAA9")]
	[FieldOffset(Offset = "0x54")]
	private Step step;

	[Token(Token = "0x600A1CC")]
	[Address(RVA = "0xEF4E50", Offset = "0xEF4050", VA = "0x180EF4E50")]
	public void Initialize()
	{
	}

	[Token(Token = "0x600A1CD")]
	[Address(RVA = "0xEF4F20", Offset = "0xEF4120", VA = "0x180EF4F20")]
	public void Play(Engine.CounterType type, int beforeNum, int afterNum, Vector3 targetAnchor)
	{
	}

	[Token(Token = "0x600A1CE")]
	[Address(RVA = "0xEF5220", Offset = "0xEF4420", VA = "0x180EF5220")]
	private void Update()
	{
	}

	[Token(Token = "0x600A1CF")]
	[Address(RVA = "0xEF5070", Offset = "0xEF4270", VA = "0x180EF5070")]
	private void UpdatePosition()
	{
	}

	[Token(Token = "0x600A1D0")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public ManaSet()
	{
	}
}
