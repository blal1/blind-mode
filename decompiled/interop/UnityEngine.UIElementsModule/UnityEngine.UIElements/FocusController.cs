using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000252")]
public class FocusController
{
	[Token(Token = "0x2000253")]
	private struct FocusedElement
	{
		[Token(Token = "0x4000911")]
		[FieldOffset(Offset = "0x0")]
		public VisualElement m_SubTreeRoot;

		[Token(Token = "0x4000912")]
		[FieldOffset(Offset = "0x8")]
		public VisualElement m_FocusedElement;
	}

	[Token(Token = "0x400090B")]
	[FieldOffset(Offset = "0x18")]
	private TextElement m_SelectedTextElement;

	[Token(Token = "0x400090C")]
	[FieldOffset(Offset = "0x20")]
	private List<FocusedElement> m_FocusedElements;

	[Token(Token = "0x400090D")]
	[FieldOffset(Offset = "0x28")]
	private Focusable m_LastFocusedElement;

	[Token(Token = "0x400090E")]
	[FieldOffset(Offset = "0x30")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal Focusable m_LastPendingFocusedElement;

	[Token(Token = "0x400090F")]
	[FieldOffset(Offset = "0x38")]
	private int m_PendingFocusCount;

	[Token(Token = "0x170002F1")]
	private IFocusRing focusRing
	{
		[Token(Token = "0x6001019")]
		[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002F2")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal TextElement selectedTextElement
	{
		[Token(Token = "0x600101A")]
		[Address(RVA = "0x2B2C900", Offset = "0x2B2BB00", VA = "0x182B2C900")]
		set
		{
		}
	}

	[Token(Token = "0x170002F3")]
	public Focusable focusedElement
	{
		[Token(Token = "0x600101B")]
		[Address(RVA = "0x2B2C8A0", Offset = "0x2B2BAA0", VA = "0x182B2C8A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002F4")]
	internal int imguiKeyboardControl
	{
		[Token(Token = "0x6001032")]
		[Address(RVA = "0x5EA1B0", Offset = "0x5E93B0", VA = "0x1805EA1B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001033")]
		[Address(RVA = "0x600F80", Offset = "0x600180", VA = "0x180600F80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x6001018")]
	[Address(RVA = "0x2B2C800", Offset = "0x2B2BA00", VA = "0x182B2C800")]
	public FocusController(IFocusRing focusRing)
	{
	}

	[Token(Token = "0x600101C")]
	[Address(RVA = "0x2B2B5C0", Offset = "0x2B2A7C0", VA = "0x182B2B5C0")]
	public void IgnoreEvent(EventBase evt)
	{
	}

	[Token(Token = "0x600101D")]
	[Address(RVA = "0x2B2B6A0", Offset = "0x2B2A8A0", VA = "0x182B2B6A0")]
	internal bool IsFocused(Focusable f)
	{
		return default(bool);
	}

	[Token(Token = "0x600101E")]
	[Address(RVA = "0x2B2B050", Offset = "0x2B2A250", VA = "0x182B2B050")]
	internal Focusable GetRetargetedFocusedElement(VisualElement retargetAgainst)
	{
		return null;
	}

	[Token(Token = "0x600101F")]
	[Address(RVA = "0x2B2AF90", Offset = "0x2B2A190", VA = "0x182B2AF90")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal Focusable GetLeafFocusedElement()
	{
		return null;
	}

	[Token(Token = "0x6001020")]
	[Address(RVA = "0x2B2B7E0", Offset = "0x2B2A9E0", VA = "0x182B2B7E0")]
	private bool IsLocalElement(Focusable f)
	{
		return default(bool);
	}

	[Token(Token = "0x6001021")]
	[Address(RVA = "0x2B2B830", Offset = "0x2B2AA30", VA = "0x182B2B830")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal bool IsPendingFocus(Focusable f)
	{
		return default(bool);
	}

	[Token(Token = "0x6001022")]
	[Address(RVA = "0x2B2BF90", Offset = "0x2B2B190", VA = "0x182B2BF90")]
	internal void SetFocusToLastFocusedElement()
	{
	}

	[Token(Token = "0x6001023")]
	[Address(RVA = "0x2B2A920", Offset = "0x2B29B20", VA = "0x182B2A920")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal void BlurLastFocusedElement()
	{
	}

	[Token(Token = "0x6001024")]
	[Address(RVA = "0x2B2AB40", Offset = "0x2B29D40", VA = "0x182B2AB40")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal void DoFocusChange(Focusable f)
	{
	}

	[Token(Token = "0x6001025")]
	[Address(RVA = "0x2B2B900", Offset = "0x2B2AB00", VA = "0x182B2B900")]
	internal void ProcessPendingFocusChange(Focusable f)
	{
	}

	[Token(Token = "0x6001026")]
	[Address(RVA = "0x2B2ACD0", Offset = "0x2B29ED0", VA = "0x182B2ACD0")]
	private static void GetFocusTargets(Focusable f, List<FocusedElement> outTargets)
	{
	}

	[Token(Token = "0x6001027")]
	[Address(RVA = "0x2B2ABC0", Offset = "0x2B29DC0", VA = "0x182B2ABC0")]
	internal Focusable FocusNextInDirection(Focusable currentFocusable, FocusChangeDirection direction)
	{
		return null;
	}

	[Token(Token = "0x6001028")]
	[Address(RVA = "0x2B2A810", Offset = "0x2B29A10", VA = "0x182B2A810")]
	private void AboutToReleaseFocus(Focusable focusable, Focusable willGiveFocusTo, FocusChangeDirection direction, DispatchMode dispatchMode)
	{
	}

	[Token(Token = "0x6001029")]
	[Address(RVA = "0x2B2BC60", Offset = "0x2B2AE60", VA = "0x182B2BC60")]
	private void ReleaseFocus(Focusable focusable, Focusable willGiveFocusTo, FocusChangeDirection direction, DispatchMode dispatchMode)
	{
	}

	[Token(Token = "0x600102A")]
	[Address(RVA = "0x2B2A700", Offset = "0x2B29900", VA = "0x182B2A700")]
	private void AboutToGrabFocus(Focusable focusable, Focusable willTakeFocusFrom, FocusChangeDirection direction, DispatchMode dispatchMode)
	{
	}

	[Token(Token = "0x600102B")]
	[Address(RVA = "0x2B2B280", Offset = "0x2B2A480", VA = "0x182B2B280")]
	private void GrabFocus(Focusable focusable, Focusable willTakeFocusFrom, FocusChangeDirection direction, bool bIsFocusDelegated, DispatchMode dispatchMode)
	{
	}

	[Token(Token = "0x600102C")]
	[Address(RVA = "0x2B2AA30", Offset = "0x2B29C30", VA = "0x182B2AA30")]
	internal void Blur(Focusable focusable, bool bIsFocusDelegated = false, DispatchMode dispatchMode = DispatchMode.Default)
	{
	}

	[Token(Token = "0x600102D")]
	[Address(RVA = "0x2B2C210", Offset = "0x2B2B410", VA = "0x182B2C210")]
	internal void SwitchFocus(Focusable newFocusedElement, bool bIsFocusDelegated = false, DispatchMode dispatchMode = DispatchMode.Default)
	{
	}

	[Token(Token = "0x600102E")]
	[Address(RVA = "0x2B2C2E0", Offset = "0x2B2B4E0", VA = "0x182B2C2E0")]
	internal void SwitchFocus(Focusable newFocusedElement, FocusChangeDirection direction, bool bIsFocusDelegated = false, DispatchMode dispatchMode = DispatchMode.Default)
	{
	}

	[Token(Token = "0x600102F")]
	[Address(RVA = "0x2B2C020", Offset = "0x2B2B220", VA = "0x182B2C020")]
	internal void SwitchFocusOnEvent(Focusable currentFocusable, EventBase e)
	{
	}

	[Token(Token = "0x6001030")]
	[Address(RVA = "0x2B2BB90", Offset = "0x2B2AD90", VA = "0x182B2BB90")]
	internal void ReevaluateFocus()
	{
	}

	[Token(Token = "0x6001031")]
	[Address(RVA = "0x2B2AE30", Offset = "0x2B2A030", VA = "0x182B2AE30")]
	internal bool GetFocusableParentForPointerEvent(Focusable target, out Focusable effectiveTarget)
	{
		return default(bool);
	}

	[Token(Token = "0x6001034")]
	[Address(RVA = "0x2B2C6E0", Offset = "0x2B2B8E0", VA = "0x182B2C6E0")]
	internal void SyncIMGUIFocus(int imguiKeyboardControlID, Focusable imguiContainerHavingKeyboardControl, bool forceSwitch)
	{
	}
}
