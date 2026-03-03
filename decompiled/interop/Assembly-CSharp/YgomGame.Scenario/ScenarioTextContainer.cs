using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Scenario;

[Token(Token = "0x2000A8A")]
public class ScenarioTextContainer : ScenarioContainerBase
{
	[Token(Token = "0x2000A8B")]
	public enum TextPos
	{
		[Token(Token = "0x40092BC")]
		Center,
		[Token(Token = "0x40092BD")]
		Left,
		[Token(Token = "0x40092BE")]
		Right,
		[Token(Token = "0x40092BF")]
		Bottom,
		[Token(Token = "0x40092C0")]
		Subtitle
	}

	[Token(Token = "0x2000A8C")]
	public enum GroupType
	{
		[Token(Token = "0x40092C2")]
		Text,
		[Token(Token = "0x40092C3")]
		Subtitle
	}

	[Token(Token = "0x2000A8D")]
	private class TextGroup
	{
		[Token(Token = "0x40092C4")]
		private const string k_ELabel_TextRoot = "TextRoot";

		[Token(Token = "0x40092C5")]
		private const string k_ELabel_TextTemplate = "TextTemplate";

		[Token(Token = "0x40092C6")]
		private const string k_ELabel_Arrow = "Arrow";

		[Token(Token = "0x40092C7")]
		private const string k_TweenShowArrow = "ShowArrow";

		[Token(Token = "0x40092C8")]
		private const string k_TweenHideArrow = "HideArrow";

		[Token(Token = "0x40092C9")]
		[FieldOffset(Offset = "0x10")]
		public readonly TextPos textPos;

		[Token(Token = "0x40092CA")]
		[FieldOffset(Offset = "0x18")]
		public readonly Transform textRoot;

		[Token(Token = "0x40092CB")]
		[FieldOffset(Offset = "0x20")]
		public readonly TMP_Text textTemplate;

		[Token(Token = "0x40092CC")]
		[FieldOffset(Offset = "0x28")]
		private bool m_SurfaceVisible;

		[Token(Token = "0x40092CD")]
		[FieldOffset(Offset = "0x29")]
		private bool m_ArrowVisible;

		[Token(Token = "0x40092CE")]
		[FieldOffset(Offset = "0x2A")]
		private bool m_ReadyArrow;

		[Token(Token = "0x40092CF")]
		[FieldOffset(Offset = "0x30")]
		private GameObject m_Arrow;

		[Token(Token = "0x40092D0")]
		[FieldOffset(Offset = "0x38")]
		private Tween m_ArrowShowTween;

		[Token(Token = "0x40092D1")]
		[FieldOffset(Offset = "0x40")]
		private Tween m_ArrowHideTween;

		[Token(Token = "0x40092D2")]
		[FieldOffset(Offset = "0x48")]
		private List<Tween> m_ArrowLoopTweens;

		[Token(Token = "0x40092D3")]
		[FieldOffset(Offset = "0x50")]
		private GroupType m_GroupType;

		[Token(Token = "0x170008A5")]
		public bool arrowVisible
		{
			[Token(Token = "0x60040E8")]
			[Address(RVA = "0x62E230", Offset = "0x62D430", VA = "0x18062E230")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170008A6")]
		public GroupType groupType
		{
			[Token(Token = "0x60040E9")]
			[Address(RVA = "0x49BD90", Offset = "0x49AF90", VA = "0x18049BD90")]
			get
			{
				return default(GroupType);
			}
			[Token(Token = "0x60040EA")]
			[Address(RVA = "0x891D50", Offset = "0x890F50", VA = "0x180891D50")]
			set
			{
			}
		}

		[Token(Token = "0x60040EB")]
		[Address(RVA = "0x891B10", Offset = "0x890D10", VA = "0x180891B10")]
		public TextGroup(TextPos textPos, ElementObjectManager eom, TMP_Text fallbackTextTemplate, GameObject fallbackArrow)
		{
		}

		[Token(Token = "0x60040EC")]
		[Address(RVA = "0x891500", Offset = "0x890700", VA = "0x180891500")]
		public void SetTextVisible(bool visible, bool surface = false)
		{
		}

		[Token(Token = "0x60040ED")]
		[Address(RVA = "0x891910", Offset = "0x890B10", VA = "0x180891910")]
		public void ShowArrow()
		{
		}

		[Token(Token = "0x60040EE")]
		[Address(RVA = "0x891480", Offset = "0x890680", VA = "0x180891480")]
		public void HideArrow()
		{
		}

		[Token(Token = "0x60040EF")]
		[Address(RVA = "0x891640", Offset = "0x890840", VA = "0x180891640")]
		private void SetupArrows()
		{
		}
	}

	[Token(Token = "0x40092AE")]
	private const string k_ELabelTextGroup_Center = "CenterGroup";

	[Token(Token = "0x40092AF")]
	private const string k_ELabelTextGroup_Left = "LeftGroup";

	[Token(Token = "0x40092B0")]
	private const string k_ELabelTextGroup_Right = "RightGroup";

	[Token(Token = "0x40092B1")]
	private const string k_ELabelTextGroup_Bottom = "BottomGroup";

	[Token(Token = "0x40092B2")]
	private const string k_ELabelTextGroup_Subtitle = "SubtitleGroup";

	[Token(Token = "0x40092B3")]
	[FieldOffset(Offset = "0x28")]
	private readonly string k_ELabel_Arrow;

	[Token(Token = "0x40092B4")]
	[FieldOffset(Offset = "0x30")]
	private readonly string k_ELabel_TextTemplate;

	[Token(Token = "0x40092B5")]
	[FieldOffset(Offset = "0x38")]
	private int m_Pos;

	[Token(Token = "0x40092B6")]
	[FieldOffset(Offset = "0x40")]
	private Dictionary<TextPos, TextGroup> m_TextWidgetMap;

	[Token(Token = "0x40092B7")]
	[FieldOffset(Offset = "0x48")]
	private float m_ArrowShowMarginPast;

	[Token(Token = "0x40092B8")]
	[FieldOffset(Offset = "0x50")]
	private readonly Dictionary<int, List<TMP_Text>> m_ActiveTexts;

	[Token(Token = "0x40092B9")]
	[FieldOffset(Offset = "0x58")]
	private readonly Dictionary<int, Stack<TMP_Text>> m_InactiveTexts;

	[Token(Token = "0x40092BA")]
	[FieldOffset(Offset = "0x60")]
	public TMP_FontAsset messageFontAsset;

	[Token(Token = "0x60040DC")]
	[Address(RVA = "0x8900F0", Offset = "0x88F2F0", VA = "0x1808900F0")]
	private string GetTextGroupELabel(TextPos textPos)
	{
		return null;
	}

	[Token(Token = "0x60040DD")]
	[Address(RVA = "0x8901A0", Offset = "0x88F3A0", VA = "0x1808901A0")]
	private TextGroup GetTextGroup(int pos)
	{
		return null;
	}

	[Token(Token = "0x60040DE")]
	[Address(RVA = "0x8901A0", Offset = "0x88F3A0", VA = "0x1808901A0")]
	private TextGroup GetTextGroup(TextPos textPos)
	{
		return null;
	}

	[Token(Token = "0x60040DF")]
	[Address(RVA = "0x890C80", Offset = "0x88FE80", VA = "0x180890C80")]
	public ScenarioTextContainer(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x60040E0")]
	[Address(RVA = "0x890AA0", Offset = "0x88FCA0", VA = "0x180890AA0")]
	public void SetGroupType(int pos, GroupType groupType)
	{
	}

	[Token(Token = "0x60040E1")]
	[Address(RVA = "0x8904C0", Offset = "0x88F6C0", VA = "0x1808904C0")]
	public TMP_Text RentText(int pos)
	{
		return null;
	}

	[Token(Token = "0x60040E2")]
	[Address(RVA = "0x8908B0", Offset = "0x88FAB0", VA = "0x1808908B0")]
	public void ReturnText(TMP_Text rentedText, int pos)
	{
	}

	[Token(Token = "0x60040E3")]
	[Address(RVA = "0x8903B0", Offset = "0x88F5B0", VA = "0x1808903B0")]
	public void ProgressUpdateArrow(ScenarioBehaviour waitInputBehaviour, bool isHide, bool isSuspended, float deltaTime = 0f)
	{
	}

	[Token(Token = "0x60040E4")]
	[Address(RVA = "0x890200", Offset = "0x88F400", VA = "0x180890200")]
	public void HideArrow()
	{
	}

	[Token(Token = "0x60040E5")]
	[Address(RVA = "0x890B20", Offset = "0x88FD20", VA = "0x180890B20")]
	public void SetSubtitleVisible(bool visible)
	{
	}

	[Token(Token = "0x60040E6")]
	[Address(RVA = "0x890B40", Offset = "0x88FD40", VA = "0x180890B40")]
	public void ShowTexts(bool surface = false)
	{
	}

	[Token(Token = "0x60040E7")]
	[Address(RVA = "0x890270", Offset = "0x88F470", VA = "0x180890270")]
	public void HideTexts(bool surface = false)
	{
	}
}
