using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Properties;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000070")]
public abstract class BaseBoolField : BaseField<bool>
{
	[Token(Token = "0x4000215")]
	[FieldOffset(Offset = "0x0")]
	internal static readonly BindingId textProperty;

	[Token(Token = "0x4000216")]
	[FieldOffset(Offset = "0x98")]
	internal static readonly BindingId toggleOnLabelClickProperty;

	[Token(Token = "0x4000217")]
	[FieldOffset(Offset = "0x538")]
	protected Label m_Label;

	[Token(Token = "0x4000218")]
	[FieldOffset(Offset = "0x540")]
	protected internal readonly VisualElement m_CheckMark;

	[Token(Token = "0x4000219")]
	[FieldOffset(Offset = "0x548")]
	internal readonly Clickable m_Clickable;

	[Token(Token = "0x400021C")]
	[FieldOffset(Offset = "0x558")]
	private string m_OriginalText;

	[Token(Token = "0x1700008A")]
	internal bool acceptClicksIfDisabled
	{
		[Token(Token = "0x6000400")]
		[Address(RVA = "0x299AA40", Offset = "0x2999C40", VA = "0x18299AA40")]
		set
		{
		}
	}

	[Token(Token = "0x1700008B")]
	[CreateProperty]
	public bool toggleOnLabelClick
	{
		[Token(Token = "0x6000401")]
		[Address(RVA = "0x299AA20", Offset = "0x2999C20", VA = "0x18299AA20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000402")]
		[Address(RVA = "0x299ABD0", Offset = "0x2999DD0", VA = "0x18299ABD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700008C")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal bool toggleOnTextClick
	{
		[Token(Token = "0x6000403")]
		[Address(RVA = "0x299AA30", Offset = "0x2999C30", VA = "0x18299AA30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000404")]
		[Address(RVA = "0x299ABE0", Offset = "0x2999DE0", VA = "0x18299ABE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700008D")]
	[CreateProperty]
	public string text
	{
		[Token(Token = "0x6000407")]
		[Address(RVA = "0x299A9F0", Offset = "0x2999BF0", VA = "0x18299A9F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000408")]
		[Address(RVA = "0x299AAC0", Offset = "0x2999CC0", VA = "0x18299AAC0")]
		set
		{
		}
	}

	[Token(Token = "0x6000405")]
	[Address(RVA = "0x299A680", Offset = "0x2999880", VA = "0x18299A680")]
	public BaseBoolField(string label)
	{
	}

	[Token(Token = "0x6000406")]
	[Address(RVA = "0x2999E40", Offset = "0x2999040", VA = "0x182999E40")]
	private void OnNavigationSubmit(NavigationSubmitEvent evt)
	{
	}

	[Token(Token = "0x6000409")]
	[Address(RVA = "0x29999E0", Offset = "0x2998BE0", VA = "0x1829999E0", Slot = "156")]
	protected virtual void InitLabel()
	{
	}

	[Token(Token = "0x600040A")]
	[Address(RVA = "0x2999F70", Offset = "0x2999170", VA = "0x182999F70", Slot = "155")]
	public override void SetValueWithoutNotify(bool newValue)
	{
	}

	[Token(Token = "0x600040B")]
	[Address(RVA = "0x2999B40", Offset = "0x2998D40", VA = "0x182999B40")]
	private void OnClickEvent(EventBase evt)
	{
	}

	[Token(Token = "0x600040C")]
	[Address(RVA = "0x299A060", Offset = "0x2999260", VA = "0x18299A060")]
	private bool ShouldIgnoreClick(Vector3 position)
	{
		return default(bool);
	}

	[Token(Token = "0x600040D")]
	[Address(RVA = "0x299A1A0", Offset = "0x29993A0", VA = "0x18299A1A0", Slot = "157")]
	protected virtual void ToggleValue()
	{
	}

	[Token(Token = "0x600040E")]
	[Address(RVA = "0x299A2D0", Offset = "0x29994D0", VA = "0x18299A2D0", Slot = "154")]
	protected override void UpdateMixedValueContent()
	{
	}

	[Token(Token = "0x600040F")]
	[Address(RVA = "0x2999E80", Offset = "0x2999080", VA = "0x182999E80", Slot = "152")]
	internal override void RegisterEditingCallbacks()
	{
	}

	[Token(Token = "0x6000410")]
	[Address(RVA = "0x299A1E0", Offset = "0x29993E0", VA = "0x18299A1E0", Slot = "153")]
	internal override void UnregisterEditingCallbacks()
	{
	}
}
