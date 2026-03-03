using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000266")]
internal interface IGroupBox
{
	[Token(Token = "0x60010DD")]
	void OnOptionAdded(IGroupBoxOption option);

	[Token(Token = "0x60010DE")]
	void OnOptionRemoved(IGroupBoxOption option);
}
[Token(Token = "0x2000267")]
internal interface IGroupBox<T> : IGroupBox where T : IGroupManager
{
}
