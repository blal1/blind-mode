using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000045")]
public interface INotifyBindablePropertyChanged
{
	[Token(Token = "0x14000001")]
	event EventHandler<BindablePropertyChangedEventArgs> propertyChanged;
}
