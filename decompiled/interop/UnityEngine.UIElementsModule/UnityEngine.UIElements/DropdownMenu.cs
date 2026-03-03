using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20001AC")]
public class DropdownMenu
{
	[Token(Token = "0x40007F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private List<DropdownMenuItem> m_MenuItems;

	[Token(Token = "0x40007F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private DropdownMenuEventInfo m_DropdownMenuEventInfo;

	[Token(Token = "0x1700023F")]
	internal int Count
	{
		[Token(Token = "0x6000C81")]
		[Address(RVA = "0x2B0FA10", Offset = "0x2B0EC10", VA = "0x182B0FA10")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6000C82")]
	[Address(RVA = "0x1B5CB80", Offset = "0x1B5BD80", VA = "0x181B5CB80")]
	public List<DropdownMenuItem> MenuItems()
	{
		return null;
	}

	[Token(Token = "0x6000C83")]
	[Address(RVA = "0x2B0F240", Offset = "0x2B0E440", VA = "0x182B0F240")]
	public void AppendAction(string actionName, Action<DropdownMenuAction> action, Func<DropdownMenuAction, DropdownMenuAction.Status> actionStatusCallback, [Optional] object userData)
	{
	}

	[Token(Token = "0x6000C84")]
	[Address(RVA = "0x2B0F120", Offset = "0x2B0E320", VA = "0x182B0F120")]
	public void AppendAction(string actionName, Action<DropdownMenuAction> action, DropdownMenuAction.Status status = DropdownMenuAction.Status.Normal)
	{
	}

	[Token(Token = "0x6000C85")]
	[Address(RVA = "0x2B0F370", Offset = "0x2B0E570", VA = "0x182B0F370")]
	public void AppendSeparator([Optional] string subMenuPath)
	{
	}

	[Token(Token = "0x6000C86")]
	[Address(RVA = "0x2B0F5E0", Offset = "0x2B0E7E0", VA = "0x182B0F5E0")]
	public void InsertSeparator(string subMenuPath, int atIndex)
	{
	}

	[Token(Token = "0x6000C87")]
	[Address(RVA = "0x2B0F730", Offset = "0x2B0E930", VA = "0x182B0F730")]
	public void PrepareForDisplay(EventBase e)
	{
	}

	[Token(Token = "0x6000C88")]
	[Address(RVA = "0x2B0F990", Offset = "0x2B0EB90", VA = "0x182B0F990")]
	public DropdownMenu()
	{
	}
}
