using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20000E0")]
public interface INotifyValueChanged<T>
{
	[Token(Token = "0x170000FE")]
	T value
	{
		[Token(Token = "0x60006D4")]
		get;
		[Token(Token = "0x60006D5")]
		set;
	}

	[Token(Token = "0x60006D6")]
	void SetValueWithoutNotify(T newValue);
}
