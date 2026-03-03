using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x200025F")]
internal class RuntimePanel : BaseRuntimePanel, IRuntimePanel, IPanel, IDisposable
{
	[Token(Token = "0x400095C")]
	[FieldOffset(Offset = "0x0")]
	internal static readonly EventDispatcher s_EventDispatcher;

	[Token(Token = "0x400095D")]
	[FieldOffset(Offset = "0x200")]
	private readonly PanelSettings m_PanelSettings;

	[Token(Token = "0x17000319")]
	public PanelSettings panelSettings
	{
		[Token(Token = "0x60010A0")]
		[Address(RVA = "0x49BF10", Offset = "0x49B110", VA = "0x18049BF10", Slot = "58")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60010A1")]
	[Address(RVA = "0x2B3AD70", Offset = "0x2B39F70", VA = "0x182B3AD70")]
	public static RuntimePanel Create(ScriptableObject ownerObject)
	{
		return null;
	}

	[Token(Token = "0x60010A2")]
	[Address(RVA = "0x2B3B000", Offset = "0x2B3A200", VA = "0x182B3B000")]
	private RuntimePanel(ScriptableObject ownerObject)
	{
	}

	[Token(Token = "0x60010A3")]
	[Address(RVA = "0x2B3AE40", Offset = "0x2B3A040", VA = "0x182B3AE40", Slot = "57")]
	internal override void Update()
	{
	}

	[Token(Token = "0x60010A4")]
	[Address(RVA = "0x2B3ADD0", Offset = "0x2B39FD0", VA = "0x182B3ADD0")]
	private void OnElementFocus(FocusEvent evt)
	{
	}
}
