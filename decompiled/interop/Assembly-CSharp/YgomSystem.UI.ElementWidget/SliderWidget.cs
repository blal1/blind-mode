using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace YgomSystem.UI.ElementWidget;

[Token(Token = "0x200061E")]
public class SliderWidget : ElementWidgetBehaviourBase<SliderWidget>
{
	[Token(Token = "0x4001D91")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private string k_ELabelSlider;

	[Token(Token = "0x4001D92")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private string k_ELabelInputButton;

	[Token(Token = "0x4001D93")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Range(0.01f, 3f)]
	private float k_PadMoveScale;

	[Token(Token = "0x4001D94")]
	[FieldOffset(Offset = "0x40")]
	private Slider m_SliderCache;

	[Token(Token = "0x4001D95")]
	[FieldOffset(Offset = "0x48")]
	private SelectionButton m_InputButtonCache;

	[Token(Token = "0x4001D96")]
	[FieldOffset(Offset = "0x50")]
	private bool startSlide;

	[Token(Token = "0x4001D97")]
	private const float k_padMoveSpeedDefault = 0.01f;

	[Token(Token = "0x4001D98")]
	[FieldOffset(Offset = "0x54")]
	private float m_padMoveSpeed;

	[Token(Token = "0x17000507")]
	public Slider slider
	{
		[Token(Token = "0x6002853")]
		[Address(RVA = "0x6AF390", Offset = "0x6AE590", VA = "0x1806AF390")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000508")]
	public SelectionButton inputButton
	{
		[Token(Token = "0x6002854")]
		[Address(RVA = "0x6AF2D0", Offset = "0x6AE4D0", VA = "0x1806AF2D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002855")]
	[Address(RVA = "0x6AEF20", Offset = "0x6AE120", VA = "0x1806AEF20")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002856")]
	[Address(RVA = "0x6AF240", Offset = "0x6AE440", VA = "0x1806AF240")]
	public SliderWidget()
	{
	}
}
