using Il2CppDummyDll;
using UnityEngine.TextCore.Text;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000456")]
public class PanelTextSettings : TextSettings
{
	[Token(Token = "0x4000E56")]
	[FieldOffset(Offset = "0x0")]
	private static PanelTextSettings s_DefaultPanelTextSettings;

	[Token(Token = "0x1700089B")]
	internal static PanelTextSettings defaultPanelTextSettings
	{
		[Token(Token = "0x600202D")]
		[Address(RVA = "0x29F79C0", Offset = "0x29F6BC0", VA = "0x1829F79C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600202E")]
	[Address(RVA = "0x29F7910", Offset = "0x29F6B10", VA = "0x1829F7910")]
	internal static void InitializeDefaultPanelTextSettingsIfNull()
	{
	}

	[Token(Token = "0x600202F")]
	[Address(RVA = "0x2889E60", Offset = "0x2889060", VA = "0x182889E60")]
	public PanelTextSettings()
	{
	}
}
