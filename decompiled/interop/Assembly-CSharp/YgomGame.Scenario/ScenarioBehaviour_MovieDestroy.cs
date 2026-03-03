using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Movie;

namespace YgomGame.Scenario;

[Token(Token = "0x2000AA8")]
public class ScenarioBehaviour_MovieDestroy : ScenarioBehaviour
{
	[Token(Token = "0x400933C")]
	[FieldOffset(Offset = "0x50")]
	private GameObject m_CreatedGameObject;

	[Token(Token = "0x400933D")]
	[FieldOffset(Offset = "0x58")]
	private MovieWidget m_CreatedWidget;

	[Token(Token = "0x400933E")]
	[FieldOffset(Offset = "0x60")]
	private string m_Label;

	[Token(Token = "0x6004170")]
	[Address(RVA = "0x897E40", Offset = "0x897040", VA = "0x180897E40")]
	public ScenarioBehaviour_MovieDestroy(object commandData)
	{
	}

	[Token(Token = "0x6004171")]
	[Address(RVA = "0x897AF0", Offset = "0x896CF0", VA = "0x180897AF0", Slot = "12")]
	protected override void ProgressInit()
	{
	}

	[Token(Token = "0x6004172")]
	[Address(RVA = "0x897BE0", Offset = "0x896DE0", VA = "0x180897BE0", Slot = "20")]
	protected override bool ProgressPointerClick()
	{
		return default(bool);
	}

	[Token(Token = "0x6004173")]
	[Address(RVA = "0x8978C0", Offset = "0x896AC0", VA = "0x1808978C0")]
	private void OnDestroyAction()
	{
	}
}
