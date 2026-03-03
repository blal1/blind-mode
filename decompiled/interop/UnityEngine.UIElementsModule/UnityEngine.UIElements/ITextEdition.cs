using System;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000464")]
public interface ITextEdition
{
	[Token(Token = "0x170008E2")]
	internal bool multiline
	{
		[Token(Token = "0x6002121")]
		get;
		[Token(Token = "0x6002122")]
		set;
	}

	[Token(Token = "0x170008E3")]
	bool isReadOnly
	{
		[Token(Token = "0x6002123")]
		get;
		[Token(Token = "0x6002124")]
		set;
	}

	[Token(Token = "0x170008E4")]
	int maxLength
	{
		[Token(Token = "0x6002125")]
		get;
		[Token(Token = "0x6002126")]
		set;
	}

	[Token(Token = "0x170008E5")]
	string placeholder
	{
		[Token(Token = "0x6002127")]
		get;
		[Token(Token = "0x6002128")]
		set;
	}

	[Token(Token = "0x170008E6")]
	bool isDelayed
	{
		[Token(Token = "0x6002129")]
		get;
		[Token(Token = "0x600212A")]
		set;
	}

	[Token(Token = "0x170008E7")]
	internal Func<char, bool> AcceptCharacter
	{
		[Token(Token = "0x600212D")]
		get;
		[Token(Token = "0x600212E")]
		set;
	}

	[Token(Token = "0x170008E8")]
	internal Action<bool> UpdateScrollOffset
	{
		[Token(Token = "0x600212F")]
		get;
		[Token(Token = "0x6002130")]
		set;
	}

	[Token(Token = "0x170008E9")]
	internal Action UpdateValueFromText
	{
		[Token(Token = "0x6002131")]
		get;
		[Token(Token = "0x6002132")]
		set;
	}

	[Token(Token = "0x170008EA")]
	internal Action UpdateTextFromValue
	{
		[Token(Token = "0x6002133")]
		get;
		[Token(Token = "0x6002134")]
		set;
	}

	[Token(Token = "0x170008EB")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal Action MoveFocusToCompositeRoot
	{
		[Token(Token = "0x6002135")]
		get;
		[Token(Token = "0x6002136")]
		set;
	}

	[Token(Token = "0x170008EC")]
	internal Func<string> GetDefaultValueType
	{
		[Token(Token = "0x6002137")]
		get;
		[Token(Token = "0x6002138")]
		set;
	}

	[Token(Token = "0x170008ED")]
	char maskChar
	{
		[Token(Token = "0x600213B")]
		get;
		[Token(Token = "0x600213C")]
		set;
	}

	[Token(Token = "0x170008EE")]
	bool isPassword
	{
		[Token(Token = "0x600213D")]
		get;
		[Token(Token = "0x600213E")]
		set;
	}

	[Token(Token = "0x170008EF")]
	bool hidePlaceholderOnFocus
	{
		[Token(Token = "0x600213F")]
		get;
		[Token(Token = "0x6002140")]
		set;
	}

	[Token(Token = "0x170008F0")]
	bool autoCorrection
	{
		[Token(Token = "0x6002141")]
		[Address(RVA = "0x2A09E60", Offset = "0x2A09060", VA = "0x182A09E60", Slot = "32")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002142")]
		[Address(RVA = "0x2A0A120", Offset = "0x2A09320", VA = "0x182A0A120", Slot = "33")]
		set
		{
		}
	}

	[Token(Token = "0x170008F1")]
	bool hideMobileInput
	{
		[Token(Token = "0x6002143")]
		[Address(RVA = "0x2A09F10", Offset = "0x2A09110", VA = "0x182A09F10", Slot = "34")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002144")]
		[Address(RVA = "0x2A0A1D0", Offset = "0x2A093D0", VA = "0x182A0A1D0", Slot = "35")]
		set
		{
		}
	}

	[Token(Token = "0x170008F2")]
	TouchScreenKeyboard touchScreenKeyboard
	{
		[Token(Token = "0x6002145")]
		[Address(RVA = "0x2A0A070", Offset = "0x2A09270", VA = "0x182A0A070", Slot = "36")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008F3")]
	TouchScreenKeyboardType keyboardType
	{
		[Token(Token = "0x6002146")]
		[Address(RVA = "0x2A09FC0", Offset = "0x2A091C0", VA = "0x182A09FC0", Slot = "37")]
		get
		{
			return default(TouchScreenKeyboardType);
		}
		[Token(Token = "0x6002147")]
		[Address(RVA = "0x2A0A280", Offset = "0x2A09480", VA = "0x182A0A280", Slot = "38")]
		set
		{
		}
	}

	[Token(Token = "0x600212B")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal void SaveValueAndText();

	[Token(Token = "0x600212C")]
	internal void RestoreValueAndText();

	[Token(Token = "0x6002139")]
	internal void UpdateText(string value);

	[Token(Token = "0x600213A")]
	internal string CullString(string s);
}
