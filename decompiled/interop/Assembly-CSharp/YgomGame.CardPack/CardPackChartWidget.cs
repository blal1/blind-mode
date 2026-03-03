using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.CardPack;

[Token(Token = "0x200152D")]
public class CardPackChartWidget : ElementWidgetBase
{
	[Token(Token = "0x400CB86")]
	[FieldOffset(Offset = "0x20")]
	private readonly string k_ELabelDestructive;

	[Token(Token = "0x400CB87")]
	[FieldOffset(Offset = "0x28")]
	private readonly string k_ELabelDifficult;

	[Token(Token = "0x400CB88")]
	[FieldOffset(Offset = "0x30")]
	private readonly string k_ELabelHandling;

	[Token(Token = "0x60082F4")]
	[Address(RVA = "0xCB33B0", Offset = "0xCB25B0", VA = "0x180CB33B0")]
	public static CardPackChartWidget Create(ElementObjectManager eom)
	{
		return null;
	}

	[Token(Token = "0x60082F5")]
	[Address(RVA = "0xCB34D0", Offset = "0xCB26D0", VA = "0x180CB34D0")]
	public CardPackChartWidget(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x60082F6")]
	[Address(RVA = "0xCB32C0", Offset = "0xCB24C0", VA = "0x180CB32C0")]
	public void Binging(int destructive, int handling, int difficult)
	{
	}

	[Token(Token = "0x60082F7")]
	[Address(RVA = "0xCB2ED0", Offset = "0xCB20D0", VA = "0x180CB2ED0")]
	private void BindGauge(ElementObjectManager gaugeEom, float amount)
	{
	}

	[Token(Token = "0x60082F8")]
	[Address(RVA = "0xCB30D0", Offset = "0xCB22D0", VA = "0x180CB30D0")]
	private void BindUniqueGauge(ElementObjectManager gaugeEom, string label, float amount, Color color)
	{
	}
}
