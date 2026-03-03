using Il2CppDummyDll;
using UnityEngine.Events;

namespace YgomSystem.UI.PropertyOverrider;

[Token(Token = "0x20005BC")]
public interface ISupportedChangedEvent
{
	[Token(Token = "0x1700046D")]
	UnityEvent onChanged
	{
		[Token(Token = "0x60025CC")]
		get;
	}
}
