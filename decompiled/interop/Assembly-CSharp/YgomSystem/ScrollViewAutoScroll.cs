using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace YgomSystem;

[Token(Token = "0x200019F")]
[RequireComponent(typeof(ScrollRect))]
public class ScrollViewAutoScroll : MonoBehaviour
{
	[Token(Token = "0x20001A0")]
	private enum ScrollViewDirection
	{
		[Token(Token = "0x40009C6")]
		Horizontal,
		[Token(Token = "0x40009C7")]
		Vertical
	}

	[Token(Token = "0x20001A1")]
	private enum Step
	{
		[Token(Token = "0x40009C9")]
		BeginIdleStep,
		[Token(Token = "0x40009CA")]
		ScrollStep,
		[Token(Token = "0x40009CB")]
		EndIdleStep
	}

	[Token(Token = "0x40009BC")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float m_ScrollSpeed;

	[Token(Token = "0x40009BD")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float m_WaitTimeBegin;

	[Token(Token = "0x40009BE")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float m_WaitTimeEnd;

	[Token(Token = "0x40009BF")]
	[FieldOffset(Offset = "0x2C")]
	private ScrollViewDirection m_Direction;

	[Token(Token = "0x40009C0")]
	[FieldOffset(Offset = "0x30")]
	private Coroutine m_UpdateScrollCorutine;

	[Token(Token = "0x40009C1")]
	[FieldOffset(Offset = "0x38")]
	private ScrollRect m_ScrollRect;

	[Token(Token = "0x40009C2")]
	[FieldOffset(Offset = "0x40")]
	private RectTransform m_ContentRT;

	[Token(Token = "0x40009C3")]
	[FieldOffset(Offset = "0x48")]
	private float m_DeltaTime;

	[Token(Token = "0x40009C4")]
	[FieldOffset(Offset = "0x4C")]
	private Step m_Step;

	[Token(Token = "0x6000A60")]
	[Address(RVA = "0xC14320", Offset = "0xC13520", VA = "0x180C14320")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000A61")]
	[Address(RVA = "0xC14460", Offset = "0xC13660", VA = "0x180C14460")]
	public void ResetScroll()
	{
	}

	[Token(Token = "0x6000A62")]
	[Address(RVA = "0xC145A0", Offset = "0xC137A0", VA = "0x180C145A0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000A63")]
	[Address(RVA = "0xC143B0", Offset = "0xC135B0", VA = "0x180C143B0")]
	private void BeginIdleProcess()
	{
	}

	[Token(Token = "0x6000A64")]
	[Address(RVA = "0xC14490", Offset = "0xC13690", VA = "0x180C14490")]
	private void ScrollProcess()
	{
	}

	[Token(Token = "0x6000A65")]
	[Address(RVA = "0xC14400", Offset = "0xC13600", VA = "0x180C14400")]
	private void EndIdleProcess()
	{
	}

	[Token(Token = "0x6000A66")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public ScrollViewAutoScroll()
	{
	}
}
