using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000268")]
internal interface IGroupManager
{
	[Token(Token = "0x60010DF")]
	void Init(IGroupBox groupBox);

	[Token(Token = "0x60010E0")]
	void OnOptionSelectionChanged(IGroupBoxOption selectedOption);

	[Token(Token = "0x60010E1")]
	void RegisterOption(IGroupBoxOption option);

	[Token(Token = "0x60010E2")]
	void UnregisterOption(IGroupBoxOption option);
}
