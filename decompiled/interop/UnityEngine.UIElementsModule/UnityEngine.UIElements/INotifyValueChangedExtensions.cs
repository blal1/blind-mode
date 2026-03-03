using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20000E1")]
public static class INotifyValueChangedExtensions
{
	[Token(Token = "0x60006D7")]
	public static bool RegisterValueChangedCallback<T>(this INotifyValueChanged<T> control, EventCallback<ChangeEvent<T>> callback)
	{
		return default(bool);
	}

	[Token(Token = "0x60006D8")]
	public static bool UnregisterValueChangedCallback<T>(this INotifyValueChanged<T> control, EventCallback<ChangeEvent<T>> callback)
	{
		return default(bool);
	}
}
