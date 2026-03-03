using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20001AA")]
public class DropdownMenuAction : DropdownMenuItem
{
	[Token(Token = "0x20001AB")]
	[Flags]
	public enum Status
	{
		[Token(Token = "0x40007EB")]
		None = 0,
		[Token(Token = "0x40007EC")]
		Normal = 1,
		[Token(Token = "0x40007ED")]
		Disabled = 2,
		[Token(Token = "0x40007EE")]
		Checked = 4,
		[Token(Token = "0x40007EF")]
		Hidden = 8
	}

	[Token(Token = "0x40007E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action<DropdownMenuAction> actionCallback;

	[Token(Token = "0x40007E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly Func<DropdownMenuAction, Status> actionStatusCallback;

	[Token(Token = "0x1700023B")]
	public string name
	{
		[Token(Token = "0x6000C79")]
		[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700023C")]
	private Status status
	{
		[Token(Token = "0x6000C7A")]
		[Address(RVA = "0x615AB0", Offset = "0x614CB0", VA = "0x180615AB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700023D")]
	private DropdownMenuEventInfo eventInfo
	{
		[Token(Token = "0x6000C7B")]
		[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700023E")]
	private object userData
	{
		[Token(Token = "0x6000C7C")]
		[Address(RVA = "0x402FB0", Offset = "0x4021B0", VA = "0x180402FB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x6000C7D")]
	[Address(RVA = "0x2B0ED90", Offset = "0x2B0DF90", VA = "0x182B0ED90")]
	public static Status AlwaysEnabled(DropdownMenuAction a)
	{
		return default(Status);
	}

	[Token(Token = "0x6000C7E")]
	[Address(RVA = "0x2B0ED80", Offset = "0x2B0DF80", VA = "0x182B0ED80")]
	public static Status AlwaysDisabled(DropdownMenuAction a)
	{
		return default(Status);
	}

	[Token(Token = "0x6000C7F")]
	[Address(RVA = "0x2B0EDF0", Offset = "0x2B0DFF0", VA = "0x182B0EDF0")]
	public DropdownMenuAction(string actionName, Action<DropdownMenuAction> actionCallback, Func<DropdownMenuAction, Status> actionStatusCallback, [Optional] object userData)
	{
	}

	[Token(Token = "0x6000C80")]
	[Address(RVA = "0x2B0EDA0", Offset = "0x2B0DFA0", VA = "0x182B0EDA0")]
	public void UpdateActionStatus(DropdownMenuEventInfo eventInfo)
	{
	}
}
