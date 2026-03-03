using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.UI.PropertyOverrider;

namespace YgomGame.Menu.Common;

[Token(Token = "0x200143F")]
public class BindingItemThumbSwitchOVLabel : MonoBehaviour, BindingItemThumb.IHandler
{
	[Token(Token = "0x400C5DF")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private PlatformOverriderGroup m_Group;

	[Token(Token = "0x400C5E0")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private string m_DefaultGroupLabel;

	[Token(Token = "0x400C5E1")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private string m_DXGroupLabel;

	[Token(Token = "0x6007DF6")]
	[Address(RVA = "0xC6AAB0", Offset = "0xC69CB0", VA = "0x180C6AAB0", Slot = "4")]
	public void OnBindingItemThumb(BindingItemThumb bindingItemThumb, BindingItemThumb.BindingStep bindingStep)
	{
	}

	[Token(Token = "0x6007DF7")]
	[Address(RVA = "0xC6AB70", Offset = "0xC69D70", VA = "0x180C6AB70")]
	private void SwitchGroupLabel(BindingItemThumb bindingItemThumb)
	{
	}

	[Token(Token = "0x6007DF8")]
	[Address(RVA = "0xC6AC20", Offset = "0xC69E20", VA = "0x180C6AC20")]
	public BindingItemThumbSwitchOVLabel()
	{
	}
}
