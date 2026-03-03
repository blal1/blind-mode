using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using YgomSystem.UI;

namespace YgomGame;

[Token(Token = "0x200065E")]
public class FullScreenUiBg : MonoBehaviour
{
	[Token(Token = "0x4001EBF")]
	private const string PREFAB_PATH = "Prefabs/VC/Utility/FullScreenUIBg";

	[Token(Token = "0x4001EC0")]
	[FieldOffset(Offset = "0x20")]
	private UiSwitchTweenAnimationController m_UiSwitchTweenAnimationController;

	[Token(Token = "0x4001EC1")]
	[FieldOffset(Offset = "0x28")]
	private bool m_IsShow_Current;

	[Token(Token = "0x4001EC2")]
	[FieldOffset(Offset = "0x29")]
	private bool m_IsShow_Next;

	[Token(Token = "0x4001EC3")]
	[FieldOffset(Offset = "0x30")]
	private GameObject m_ShortcutRoot;

	[Token(Token = "0x4001EC4")]
	[FieldOffset(Offset = "0x38")]
	private AutoCloseToggle m_AutoCloseToggle;

	[Token(Token = "0x60029BB")]
	[Address(RVA = "0x6D8B60", Offset = "0x6D7D60", VA = "0x1806D8B60")]
	public static void Create(Transform parent, UnityAction<FullScreenUiBg> onFinished)
	{
	}

	[Token(Token = "0x60029BC")]
	[Address(RVA = "0x6D8C50", Offset = "0x6D7E50", VA = "0x1806D8C50")]
	private void Initialize()
	{
	}

	[Token(Token = "0x60029BD")]
	[Address(RVA = "0x6D8D70", Offset = "0x6D7F70", VA = "0x1806D8D70")]
	public void Show()
	{
	}

	[Token(Token = "0x60029BE")]
	[Address(RVA = "0x6D8B10", Offset = "0x6D7D10", VA = "0x1806D8B10")]
	public void Close()
	{
	}

	[Token(Token = "0x60029BF")]
	[Address(RVA = "0x6D8D10", Offset = "0x6D7F10", VA = "0x1806D8D10")]
	public void SetShortcutVisible(bool visible)
	{
	}

	[Token(Token = "0x60029C0")]
	[Address(RVA = "0x595520", Offset = "0x594720", VA = "0x180595520")]
	public void SetAutoCloseToggle(AutoCloseToggle autoCloseToggle)
	{
	}

	[Token(Token = "0x60029C1")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public FullScreenUiBg()
	{
	}
}
