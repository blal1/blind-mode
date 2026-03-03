using Il2CppDummyDll;
using YgomSystem.ElementSystem;

namespace YgomSystem.UI.ElementWidget;

[Token(Token = "0x200060B")]
public class DirectionalToggleGroupWidget : ElementWidgetBehaviourBase<DirectionalToggleGroupWidget>
{
	[Token(Token = "0x4001D0C")]
	[FieldOffset(Offset = "0x28")]
	private ToggleGroupWidget m_ToggleGroupWidget;

	[Token(Token = "0x4001D0D")]
	[FieldOffset(Offset = "0x30")]
	public bool focusIdxToSelectionTransitionItem;

	[Token(Token = "0x170004D3")]
	public ToggleGroupWidget toggleGroupWidget
	{
		[Token(Token = "0x600279B")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600279C")]
	[Address(RVA = "0x6A79C0", Offset = "0x6A6BC0", VA = "0x1806A79C0")]
	public static DirectionalToggleGroupWidget Create(ElementObjectManager eom, string elabelFormat, int defaultIdx = 0)
	{
		return null;
	}

	[Token(Token = "0x600279D")]
	[Address(RVA = "0x6A78F0", Offset = "0x6A6AF0", VA = "0x1806A78F0")]
	public static DirectionalToggleGroupWidget Create(ElementObjectManager eom, ToggleWidget[] toggles, int defaultIdx = 0)
	{
		return null;
	}

	[Token(Token = "0x600279E")]
	[Address(RVA = "0x6A7F90", Offset = "0x6A7190", VA = "0x1806A7F90")]
	private void Start()
	{
	}

	[Token(Token = "0x600279F")]
	[Address(RVA = "0x6A7C30", Offset = "0x6A6E30", VA = "0x1806A7C30")]
	private void OnSelectedToggleCallback()
	{
	}

	[Token(Token = "0x60027A0")]
	[Address(RVA = "0x6A7C20", Offset = "0x6A6E20", VA = "0x1806A7C20")]
	private void OnChangeIdx(int idx)
	{
	}

	[Token(Token = "0x60027A1")]
	[Address(RVA = "0x6A7D90", Offset = "0x6A6F90", VA = "0x1806A7D90")]
	private void SetCurrentToggleToSelector()
	{
	}

	[Token(Token = "0x60027A2")]
	[Address(RVA = "0x6A8370", Offset = "0x6A7570", VA = "0x1806A8370")]
	public DirectionalToggleGroupWidget()
	{
	}
}
