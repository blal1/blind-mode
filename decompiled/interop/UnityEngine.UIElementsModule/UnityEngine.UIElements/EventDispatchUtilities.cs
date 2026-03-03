using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using JetBrains.Annotations;

namespace UnityEngine.UIElements;

[Token(Token = "0x20001D9")]
internal static class EventDispatchUtilities
{
	[MethodImpl(256)]
	[Token(Token = "0x6000D68")]
	[Address(RVA = "0x2B151D0", Offset = "0x2B143D0", VA = "0x182B151D0")]
	private static void PropagateEvent(EventBase evt, [NotNull] BaseVisualElementPanel panel, [NotNull] VisualElement target, bool isCapturingTarget)
	{
	}

	[Token(Token = "0x6000D69")]
	[Address(RVA = "0x2B14AA0", Offset = "0x2B13CA0", VA = "0x182B14AA0")]
	public static void HandleEventAtTargetAndDefaultPhase(EventBase evt, [NotNull] BaseVisualElementPanel panel, [NotNull] VisualElement target)
	{
	}

	[Token(Token = "0x6000D6A")]
	[Address(RVA = "0x2B142F0", Offset = "0x2B134F0", VA = "0x182B142F0")]
	private static void HandleEventAcrossPropagationPath(EventBase evt, [NotNull] BaseVisualElementPanel panel, [NotNull] VisualElement target, bool isCapturingTarget)
	{
	}

	[Token(Token = "0x6000D6B")]
	[Address(RVA = "0x2B13670", Offset = "0x2B12870", VA = "0x182B13670")]
	private static void HandleEventAcrossPropagationPathWithCompatibilityEvent(EventBase evt, [NotNull] EventBase compatibilityEvt, [NotNull] BaseVisualElementPanel panel, [NotNull] VisualElement target, bool isCapturingTarget)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x6000D6C")]
	[Address(RVA = "0x2B14F90", Offset = "0x2B14190", VA = "0x182B14F90")]
	private static void HandleEvent_DefaultActionAtTarget(EventBase evt, [NotNull] BaseVisualElementPanel panel, [NotNull] VisualElement element, bool disabled)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x6000D6D")]
	[Address(RVA = "0x2B15060", Offset = "0x2B14260", VA = "0x182B15060")]
	private static void HandleEvent_DefaultAction(EventBase evt, [NotNull] BaseVisualElementPanel panel, [NotNull] VisualElement element, bool disabled)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x6000D6E")]
	[Address(RVA = "0x2B15130", Offset = "0x2B14330", VA = "0x182B15130")]
	private static void HandleEvent_TrickleDownCallbacks(EventBase evt, [NotNull] BaseVisualElementPanel panel, [NotNull] VisualElement element)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x6000D6F")]
	[Address(RVA = "0x2B14EF0", Offset = "0x2B140F0", VA = "0x182B14EF0")]
	private static void HandleEvent_BubbleUpCallbacks(EventBase evt, [NotNull] BaseVisualElementPanel panel, [NotNull] VisualElement element)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x6000D70")]
	[Address(RVA = "0x2B15170", Offset = "0x2B14370", VA = "0x182B15170")]
	private static void HandleEvent_TrickleDownHandleEvent(EventBase evt, [NotNull] BaseVisualElementPanel panel, [NotNull] VisualElement element, bool disabled)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x6000D71")]
	[Address(RVA = "0x2B14F30", Offset = "0x2B14130", VA = "0x182B14F30")]
	private static void HandleEvent_BubbleUpHandleEvent(EventBase evt, [NotNull] BaseVisualElementPanel panel, [NotNull] VisualElement element, bool disabled)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x6000D72")]
	[Address(RVA = "0x2B0D600", Offset = "0x2B0C800", VA = "0x182B0D600")]
	private static void HandleEvent_BubbleUpAllDefaultActions(EventBase evt, [NotNull] BaseVisualElementPanel panel, [NotNull] VisualElement element, bool disabled, bool isCapturingTarget)
	{
	}

	[Token(Token = "0x6000D73")]
	[Address(RVA = "0x2B12DD0", Offset = "0x2B11FD0", VA = "0x182B12DD0")]
	private static bool Disabled([NotNull] EventBase evt, [NotNull] VisualElement target)
	{
		return default(bool);
	}

	[Token(Token = "0x6000D74")]
	[Address(RVA = "0x2B13380", Offset = "0x2B12580", VA = "0x182B13380")]
	public static void DispatchToFocusedElementOrPanelRoot(EventBase evt, [NotNull] BaseVisualElementPanel panel)
	{
	}

	[Token(Token = "0x6000D75")]
	[Address(RVA = "0x2B13250", Offset = "0x2B12450", VA = "0x182B13250")]
	public static void DispatchToElementUnderPointerOrPanelRoot(EventBase evt, [NotNull] BaseVisualElementPanel panel, int pointerId, Vector2 position)
	{
	}

	[Token(Token = "0x6000D76")]
	[Address(RVA = "0x2B12EC0", Offset = "0x2B120C0", VA = "0x182B12EC0")]
	public static void DispatchToCachedElementUnderPointerOrPanelRoot(EventBase evt, [NotNull] BaseVisualElementPanel panel, int pointerId, Vector2 position)
	{
	}

	[Token(Token = "0x6000D77")]
	[Address(RVA = "0x2B12E10", Offset = "0x2B12010", VA = "0x182B12E10")]
	public static void DispatchToAssignedTarget(EventBase evt, [NotNull] BaseVisualElementPanel panel)
	{
	}

	[Token(Token = "0x6000D78")]
	[Address(RVA = "0x2B11980", Offset = "0x2B10B80", VA = "0x182B11980")]
	public static void DefaultDispatch(EventBase evt, [NotNull] BaseVisualElementPanel panel)
	{
	}

	[Token(Token = "0x6000D79")]
	[Address(RVA = "0x2B12FE0", Offset = "0x2B121E0", VA = "0x182B12FE0")]
	public static void DispatchToCapturingElementOrElementUnderPointer(EventBase evt, [NotNull] BaseVisualElementPanel panel, int pointerId, Vector2 position)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x6000D7A")]
	[Address(RVA = "0x2B13140", Offset = "0x2B12340", VA = "0x182B13140")]
	private static bool DispatchToCapturingElement(EventBase evt, [NotNull] BaseVisualElementPanel panel, int pointerId, Vector2 position)
	{
		return default(bool);
	}

	[Token(Token = "0x6000D7B")]
	[Address(RVA = "0x2B135F0", Offset = "0x2B127F0", VA = "0x182B135F0")]
	internal static void DispatchToPanelRoot(EventBase evt, [NotNull] BaseVisualElementPanel panel)
	{
	}

	[Token(Token = "0x6000D7C")]
	[Address(RVA = "0x2B156A0", Offset = "0x2B148A0", VA = "0x182B156A0")]
	internal static void PropagateToRemainingIMGUIContainers(EventBase evt, [NotNull] VisualElement root)
	{
	}

	[Token(Token = "0x6000D7D")]
	[Address(RVA = "0x2B152D0", Offset = "0x2B144D0", VA = "0x182B152D0")]
	private static void PropagateToRemainingIMGUIContainerRecursive(EventBase evt, [NotNull] VisualElement root)
	{
	}
}
