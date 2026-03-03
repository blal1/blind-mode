using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x200000E")]
public static class BackgroundPropertyHelper
{
	[Token(Token = "0x600003F")]
	[Address(RVA = "0x2974930", Offset = "0x2973B30", VA = "0x182974930")]
	public static BackgroundPosition ConvertScaleModeToBackgroundPosition(ScaleMode scaleMode = ScaleMode.StretchToFill)
	{
		return default(BackgroundPosition);
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x13A7ED0", Offset = "0x13A70D0", VA = "0x1813A7ED0")]
	public static BackgroundRepeat ConvertScaleModeToBackgroundRepeat(ScaleMode scaleMode = ScaleMode.StretchToFill)
	{
		return default(BackgroundRepeat);
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x2974B40", Offset = "0x2973D40", VA = "0x182974B40")]
	public static BackgroundSize ConvertScaleModeToBackgroundSize(ScaleMode scaleMode = ScaleMode.StretchToFill)
	{
		return default(BackgroundSize);
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x2974C00", Offset = "0x2973E00", VA = "0x182974C00")]
	public static ScaleMode ResolveUnityBackgroundScaleMode(BackgroundPosition backgroundPositionX, BackgroundPosition backgroundPositionY, BackgroundRepeat backgroundRepeat, BackgroundSize backgroundSize, out bool valid)
	{
		return default(ScaleMode);
	}
}
