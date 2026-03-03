using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.YGomTMPro;

namespace YgomGame;

[Token(Token = "0x20006DE")]
public class PopUpText : MonoBehaviour
{
	[Token(Token = "0x400228B")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private int m_FontSizeForString;

	[Token(Token = "0x400228C")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private int m_FontSizeForNumber;

	[Token(Token = "0x400228D")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private int m_FontSizeForString_Mobile;

	[Token(Token = "0x400228E")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private int m_FontSizeForNumber_Mobile;

	[Token(Token = "0x400228F")]
	[FieldOffset(Offset = "0x30")]
	private Queue<string> m_TaskQueue;

	[Token(Token = "0x4002290")]
	[FieldOffset(Offset = "0x38")]
	private bool m_Showing;

	[Token(Token = "0x4002291")]
	[FieldOffset(Offset = "0x39")]
	private bool m_IsClosing;

	[Token(Token = "0x4002292")]
	[FieldOffset(Offset = "0x40")]
	private Image m_PopUpBaseNW;

	[Token(Token = "0x4002293")]
	[FieldOffset(Offset = "0x48")]
	private Image m_PopUpBaseNE;

	[Token(Token = "0x4002294")]
	[FieldOffset(Offset = "0x50")]
	private Image m_PopUpBaseSW;

	[Token(Token = "0x4002295")]
	[FieldOffset(Offset = "0x58")]
	private Image m_PopUpBaseSE;

	[Token(Token = "0x4002296")]
	[FieldOffset(Offset = "0x60")]
	private ElementObjectManager m_EOManager;

	[Token(Token = "0x4002297")]
	[FieldOffset(Offset = "0x68")]
	private ExtendedTextMeshProUGUI m_PopUpText;

	[Token(Token = "0x4002298")]
	[FieldOffset(Offset = "0x70")]
	private ExtendedTextMeshProUGUI m_PopUpText_Preset;

	[Token(Token = "0x4002299")]
	[FieldOffset(Offset = "0x78")]
	private RectTransform m_Rt;

	[Token(Token = "0x400229A")]
	[FieldOffset(Offset = "0x80")]
	private bool m_Isforui;

	[Token(Token = "0x400229B")]
	[FieldOffset(Offset = "0x88")]
	private Transform m_TargetRT;

	[Token(Token = "0x400229C")]
	[FieldOffset(Offset = "0x90")]
	private bool m_UpdateContent;

	[Token(Token = "0x400229D")]
	[FieldOffset(Offset = "0x91")]
	private bool m_FollowTarget;

	[Token(Token = "0x400229E")]
	[FieldOffset(Offset = "0x98")]
	public UnityAction onClosed;

	[Token(Token = "0x170005AD")]
	public bool IsShowing
	{
		[Token(Token = "0x6002DD3")]
		[Address(RVA = "0x406E70", Offset = "0x406070", VA = "0x180406E70")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6002DD4")]
	[Address(RVA = "0x7200C0", Offset = "0x71F2C0", VA = "0x1807200C0")]
	public void SetEnable(bool enable)
	{
	}

	[Token(Token = "0x6002DD5")]
	[Address(RVA = "0x720130", Offset = "0x71F330", VA = "0x180720130")]
	public bool ShowText(string text, Transform targetRT, bool isforui, bool followTarget)
	{
		return default(bool);
	}

	[Token(Token = "0x6002DD6")]
	[Address(RVA = "0x71FA80", Offset = "0x71EC80", VA = "0x18071FA80")]
	public void HideText()
	{
	}

	[Token(Token = "0x6002DD7")]
	[Address(RVA = "0x7208F0", Offset = "0x71FAF0", VA = "0x1807208F0")]
	public void UpdateText(string text)
	{
	}

	[Token(Token = "0x6002DD8")]
	[Address(RVA = "0x71FB80", Offset = "0x71ED80", VA = "0x18071FB80")]
	public void Initialize(UnityAction onClosedEvent)
	{
	}

	[Token(Token = "0x6002DD9")]
	[Address(RVA = "0x720330", Offset = "0x71F530", VA = "0x180720330")]
	private void UpdatePosition()
	{
	}

	[Token(Token = "0x6002DDA")]
	[Address(RVA = "0x720950", Offset = "0x71FB50", VA = "0x180720950")]
	private void Update()
	{
	}

	[Token(Token = "0x6002DDB")]
	[Address(RVA = "0x720B40", Offset = "0x71FD40", VA = "0x180720B40")]
	public PopUpText()
	{
	}
}
