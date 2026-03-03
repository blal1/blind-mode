using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using TMPro;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Shop;

[Token(Token = "0x200095C")]
public class ProductGroupHeaderWidget : ElementWidgetBase
{
	[Token(Token = "0x200095D")]
	public class Context : IShowcaseGruopContext
	{
		[Token(Token = "0x4008B21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string label;

		[Token(Token = "0x4008B22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string buttonLabel;

		[Token(Token = "0x4008B23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action buttonAction;

		[Token(Token = "0x17000773")]
		public bool ValidButton
		{
			[Token(Token = "0x6003905")]
			[Address(RVA = "0x7EB160", Offset = "0x7EA360", VA = "0x1807EB160")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000774")]
		public int categoryId
		{
			[Token(Token = "0x6003906")]
			[Address(RVA = "0x62E210", Offset = "0x62D410", VA = "0x18062E210", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6003907")]
			[Address(RVA = "0x62E240", Offset = "0x62D440", VA = "0x18062E240")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000775")]
		public int subCategoryId
		{
			[Token(Token = "0x6003908")]
			[Address(RVA = "0x6333B0", Offset = "0x6325B0", VA = "0x1806333B0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6003909")]
			[Address(RVA = "0x7EB190", Offset = "0x7EA390", VA = "0x1807EB190")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000776")]
		public int sectionId
		{
			[Token(Token = "0x600390A")]
			[Address(RVA = "0x49B840", Offset = "0x49AA40", VA = "0x18049B840", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600390B")]
			[Address(RVA = "0x49C0C0", Offset = "0x49B2C0", VA = "0x18049C0C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600390C")]
		[Address(RVA = "0x7EB0A0", Offset = "0x7EA2A0", VA = "0x1807EB0A0")]
		public Context(string label, int categoryId, int subCategoryId, int sectionId, [Optional] string buttonLabel, [Optional] Action buttonAction)
		{
		}
	}

	[Token(Token = "0x4008B1B")]
	private const string k_ELabelLabel = "Label";

	[Token(Token = "0x4008B1C")]
	private const string k_ELabelButton = "SubButton_0_0";

	[Token(Token = "0x4008B1D")]
	private const string k_ELabelButtonLabel = "SubButton_0_0/Text";

	[Token(Token = "0x4008B1E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly TMP_Text m_Label;

	[Token(Token = "0x4008B1F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public readonly SelectionButton button;

	[Token(Token = "0x4008B20")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly TMP_Text m_ButtonLabel;

	[Token(Token = "0x6003903")]
	[Address(RVA = "0x7ED450", Offset = "0x7EC650", VA = "0x1807ED450")]
	public ProductGroupHeaderWidget(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x6003904")]
	[Address(RVA = "0x7ED140", Offset = "0x7EC340", VA = "0x1807ED140")]
	public void ApplyContext(Context context)
	{
	}
}
