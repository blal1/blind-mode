using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace YgomSystem.UI.ElementWidget;

[Token(Token = "0x2000613")]
public class InputFieldWrapper
{
	[Token(Token = "0x2000614")]
	private enum Mode
	{
		[Token(Token = "0x4001D4D")]
		uGUI,
		[Token(Token = "0x4001D4E")]
		TMP
	}

	[Token(Token = "0x2000615")]
	public class OnChangedEvent : UnityEvent<string>
	{
		[Token(Token = "0x600280D")]
		[Address(RVA = "0x6ADD70", Offset = "0x6ACF70", VA = "0x1806ADD70")]
		public OnChangedEvent()
		{
		}
	}

	[Token(Token = "0x4001D47")]
	[FieldOffset(Offset = "0x10")]
	private Mode mode;

	[Token(Token = "0x4001D48")]
	[FieldOffset(Offset = "0x18")]
	private ExtendedInputField inputField;

	[Token(Token = "0x4001D49")]
	[FieldOffset(Offset = "0x20")]
	private TMP_InputField TMPInputField;

	[Token(Token = "0x170004ED")]
	public TextWrapper textComponent
	{
		[Token(Token = "0x60027F0")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60027F1")]
		[Address(RVA = "0x402FB0", Offset = "0x4021B0", VA = "0x180402FB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170004EE")]
	private Selectable selectable
	{
		[Token(Token = "0x60027F4")]
		[Address(RVA = "0x6AC8B0", Offset = "0x6ABAB0", VA = "0x1806AC8B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004EF")]
	public bool interactable
	{
		[Token(Token = "0x60027F5")]
		[Address(RVA = "0x6AC7D0", Offset = "0x6AB9D0", VA = "0x1806AC7D0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60027F6")]
		[Address(RVA = "0x6ACC70", Offset = "0x6ABE70", VA = "0x1806ACC70")]
		set
		{
		}
	}

	[Token(Token = "0x170004F0")]
	public string text
	{
		[Token(Token = "0x60027F7")]
		[Address(RVA = "0x6AC910", Offset = "0x6ABB10", VA = "0x1806AC910")]
		get
		{
			return null;
		}
		[Token(Token = "0x60027F8")]
		[Address(RVA = "0x6ACD00", Offset = "0x6ABF00", VA = "0x1806ACD00")]
		set
		{
		}
	}

	[Token(Token = "0x170004F1")]
	public GameObject gameObject
	{
		[Token(Token = "0x60027F9")]
		[Address(RVA = "0x6AC750", Offset = "0x6AB950", VA = "0x1806AC750")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004F2")]
	public Graphic targetGraphic
	{
		[Token(Token = "0x60027FA")]
		[Address(RVA = "0x6AC8D0", Offset = "0x6ABAD0", VA = "0x1806AC8D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004F3")]
	public Transform transform
	{
		[Token(Token = "0x60027FB")]
		[Address(RVA = "0x6AC970", Offset = "0x6ABB70", VA = "0x1806AC970")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004F4")]
	public OnChangedEvent onValueChanged
	{
		[Token(Token = "0x60027FC")]
		[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60027FD")]
		[Address(RVA = "0x4130D0", Offset = "0x4122D0", VA = "0x1804130D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170004F5")]
	public InputField.ContentType contentType
	{
		[Token(Token = "0x6002802")]
		[Address(RVA = "0x6AC660", Offset = "0x6AB860", VA = "0x1806AC660")]
		get
		{
			return default(InputField.ContentType);
		}
		[Token(Token = "0x6002803")]
		[Address(RVA = "0x6ACA90", Offset = "0x6ABC90", VA = "0x1806ACA90")]
		set
		{
		}
	}

	[Token(Token = "0x170004F6")]
	public int characterLimit
	{
		[Token(Token = "0x6002804")]
		[Address(RVA = "0x6AC610", Offset = "0x6AB810", VA = "0x1806AC610")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002805")]
		[Address(RVA = "0x6ACA40", Offset = "0x6ABC40", VA = "0x1806ACA40")]
		set
		{
		}
	}

	[Token(Token = "0x170004F7")]
	public InputField.InputType inputType
	{
		[Token(Token = "0x6002806")]
		[Address(RVA = "0x6AC780", Offset = "0x6AB980", VA = "0x1806AC780")]
		get
		{
			return default(InputField.InputType);
		}
		[Token(Token = "0x6002807")]
		[Address(RVA = "0x6ACC20", Offset = "0x6ABE20", VA = "0x1806ACC20")]
		set
		{
		}
	}

	[Token(Token = "0x170004F8")]
	public InputField.LineType lineType
	{
		[Token(Token = "0x6002808")]
		[Address(RVA = "0x6AC810", Offset = "0x6ABA10", VA = "0x1806AC810")]
		get
		{
			return default(InputField.LineType);
		}
		[Token(Token = "0x6002809")]
		[Address(RVA = "0x6ACCB0", Offset = "0x6ABEB0", VA = "0x1806ACCB0")]
		set
		{
		}
	}

	[Token(Token = "0x170004F9")]
	public Graphic placeholder
	{
		[Token(Token = "0x600280A")]
		[Address(RVA = "0x6AC860", Offset = "0x6ABA60", VA = "0x1806AC860")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004FA")]
	public int caretPosition
	{
		[Token(Token = "0x600280B")]
		[Address(RVA = "0x6AC5C0", Offset = "0x6AB7C0", VA = "0x1806AC5C0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600280C")]
		[Address(RVA = "0x6AC9C0", Offset = "0x6ABBC0", VA = "0x1806AC9C0")]
		set
		{
		}
	}

	[Token(Token = "0x60027F2")]
	[Address(RVA = "0x6AC4B0", Offset = "0x6AB6B0", VA = "0x1806AC4B0")]
	public InputFieldWrapper(ExtendedInputField inputField)
	{
	}

	[Token(Token = "0x60027F3")]
	[Address(RVA = "0x6AC3A0", Offset = "0x6AB5A0", VA = "0x1806AC3A0")]
	public InputFieldWrapper(TMP_InputField inputField)
	{
	}

	[Token(Token = "0x60027FE")]
	[Address(RVA = "0x6AC300", Offset = "0x6AB500", VA = "0x1806AC300")]
	public void InvokeOnValueChanged(string text)
	{
	}

	[Token(Token = "0x60027FF")]
	[Address(RVA = "0x6AC350", Offset = "0x6AB550", VA = "0x1806AC350")]
	public void SetTextWithoutNotify(string text)
	{
	}

	[Token(Token = "0x6002800")]
	[Address(RVA = "0x6AC260", Offset = "0x6AB460", VA = "0x1806AC260")]
	public void ActivateInputField()
	{
	}

	[Token(Token = "0x6002801")]
	[Address(RVA = "0x6AC2B0", Offset = "0x6AB4B0", VA = "0x1806AC2B0")]
	public void DeactivateInputField()
	{
	}
}
