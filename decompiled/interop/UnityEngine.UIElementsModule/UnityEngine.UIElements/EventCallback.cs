using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20001CD")]
public delegate void EventCallback<in TEventType>(TEventType evt);
[Token(Token = "0x20001CE")]
public delegate void EventCallback<in TEventType, in TCallbackArgs>(TEventType evt, TCallbackArgs userArgs);
