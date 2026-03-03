using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.Network;

namespace YgomSystem.UI;

[Token(Token = "0x200043C")]
public class UINetworkHandler : MonoBehaviour
{
	[Token(Token = "0x40014B7")]
	[FieldOffset(Offset = "0x20")]
	private List<Handle> m_NetworkProgressDispOwners;

	[Token(Token = "0x40014B8")]
	[FieldOffset(Offset = "0x28")]
	private int m_ResourceNetworkProgressCnt;

	[Token(Token = "0x40014B9")]
	[FieldOffset(Offset = "0x2C")]
	private bool m_Retry;

	[Token(Token = "0x40014BA")]
	[FieldOffset(Offset = "0x30")]
	private int m_SkipHandleSectionMainteCnt;

	[Token(Token = "0x40014BB")]
	[FieldOffset(Offset = "0x38")]
	private List<Handle> m_RetryHandles;

	[Token(Token = "0x6001B1B")]
	[Address(RVA = "0x5F5D20", Offset = "0x5F4F20", VA = "0x1805F5D20")]
	private static bool isIgnoreNetworkProgressCommand(string command)
	{
		return default(bool);
	}

	[Token(Token = "0x6001B1C")]
	[Address(RVA = "0x5F5860", Offset = "0x5F4A60", VA = "0x1805F5860")]
	public void SetSkipHandleSectionMainteEnabled(bool enabled)
	{
	}

	[Token(Token = "0x6001B1D")]
	[Address(RVA = "0x5F5870", Offset = "0x5F4A70", VA = "0x1805F5870")]
	public void SetSystemHandler()
	{
	}

	[Token(Token = "0x6001B1E")]
	[Address(RVA = "0x5F4D10", Offset = "0x5F3F10", VA = "0x1805F4D10")]
	public void ClearOnReboot()
	{
	}

	[Token(Token = "0x6001B1F")]
	[Address(RVA = "0x5F6420", Offset = "0x5F5620", VA = "0x1805F6420")]
	private void networkStartHandle(Handle handle)
	{
	}

	[Token(Token = "0x6001B20")]
	[Address(RVA = "0x5F61F0", Offset = "0x5F53F0", VA = "0x1805F61F0")]
	private void networkCompleteHandle(Handle handle)
	{
	}

	[Token(Token = "0x6001B21")]
	[Address(RVA = "0x5F6360", Offset = "0x5F5560", VA = "0x1805F6360")]
	private void networkErrorHandle(Handle handle)
	{
	}

	[Token(Token = "0x6001B22")]
	[Address(RVA = "0x5F6290", Offset = "0x5F5490", VA = "0x1805F6290")]
	public void networkDisconnectErrorDialog()
	{
	}

	[Token(Token = "0x6001B23")]
	[Address(RVA = "0x5F6940", Offset = "0x5F5B40", VA = "0x1805F6940")]
	private void resourceProgressHandle(bool isshow)
	{
	}

	[Token(Token = "0x6001B24")]
	[Address(RVA = "0x5F6A20", Offset = "0x5F5C20", VA = "0x1805F6A20")]
	private bool? resourceRetryHandle(bool firstcall)
	{
		return null;
	}

	[Token(Token = "0x6001B25")]
	[Address(RVA = "0x5F6570", Offset = "0x5F5770", VA = "0x1805F6570")]
	private void resourceErrorHandle(string path)
	{
	}

	[Token(Token = "0x6001B26")]
	[Address(RVA = "0x5F4D80", Offset = "0x5F3F80", VA = "0x1805F4D80")]
	public void OpenNetworkErrorDialog(Handle handle)
	{
	}

	[Token(Token = "0x6001B27")]
	[Address(RVA = "0x5F5C70", Offset = "0x5F4E70", VA = "0x1805F5C70")]
	public UINetworkHandler()
	{
	}
}
