using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20002D1")]
public interface ICustomStyle
{
	[Token(Token = "0x6001424")]
	bool TryGetValue(CustomStyleProperty<float> property, out float value);

	[Token(Token = "0x6001425")]
	bool TryGetValue(CustomStyleProperty<int> property, out int value);

	[Token(Token = "0x6001426")]
	bool TryGetValue(CustomStyleProperty<Color> property, out Color value);

	[Token(Token = "0x6001427")]
	bool TryGetValue(CustomStyleProperty<Texture2D> property, out Texture2D value);

	[Token(Token = "0x6001428")]
	bool TryGetValue(CustomStyleProperty<Sprite> property, out Sprite value);

	[Token(Token = "0x6001429")]
	bool TryGetValue(CustomStyleProperty<VectorImage> property, out VectorImage value);

	[Token(Token = "0x600142A")]
	bool TryGetValue(CustomStyleProperty<string> property, out string value);
}
