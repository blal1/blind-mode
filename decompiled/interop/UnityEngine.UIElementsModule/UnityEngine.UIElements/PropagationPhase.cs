using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20001D8")]
public enum PropagationPhase
{
	[Token(Token = "0x400085B")]
	None = 0,
	[Token(Token = "0x400085C")]
	TrickleDown = 1,
	[Token(Token = "0x400085D")]
	BubbleUp = 3,
	[Token(Token = "0x400085E")]
	[Obsolete("PropagationPhase.AtTarget has been removed as part of an event propagation simplification. Events now propagate through the TrickleDown phase followed immediately by the BubbleUp phase. Please use TrickleDown or BubbleUp. You can check if the event target is the current element by testing event.target == this in your local callback.", false)]
	AtTarget = 2,
	[Token(Token = "0x400085F")]
	[Obsolete("PropagationPhase.DefaultAction has been removed as part of an event propagation simplification. ExecuteDefaultAction now occurs as part of the BubbleUp phase. Please use BubbleUp.", false)]
	DefaultAction = 4,
	[Token(Token = "0x4000860")]
	[Obsolete("PropagationPhase.DefaultActionAtTarget has been removed as part of an event propagation simplification. ExecuteDefaultActionAtTarget now occurs as part of the BubbleUp phase. Please use BubbleUp", false)]
	DefaultActionAtTarget = 5
}
