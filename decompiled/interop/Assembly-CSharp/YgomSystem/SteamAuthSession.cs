using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Steamworks;

namespace YgomSystem;

[Token(Token = "0x200017F")]
public class SteamAuthSession
{
	[Token(Token = "0x2000180")]
	public enum DIALOG_TYPE
	{
		[Token(Token = "0x4000923")]
		NO_STEAMMANAGER_INITIALIZE,
		[Token(Token = "0x4000924")]
		NEED_REAUTH_REBOOT
	}

	[Token(Token = "0x400091A")]
	[FieldOffset(Offset = "0x10")]
	private string steam_auth_session;

	[Token(Token = "0x400091B")]
	[FieldOffset(Offset = "0x18")]
	private HAuthTicket m_HAuthTicket;

	[Token(Token = "0x400091C")]
	[FieldOffset(Offset = "0x1C")]
	private uint m_pcbTicket;

	[Token(Token = "0x400091D")]
	private const int m_tokenLength = 1024;

	[Token(Token = "0x400091E")]
	[FieldOffset(Offset = "0x20")]
	private byte[] m_token;

	[Token(Token = "0x400091F")]
	[FieldOffset(Offset = "0x28")]
	private Callback<GetAuthSessionTicketResponse_t> m_SessionTicketResponse;

	[Token(Token = "0x4000920")]
	[FieldOffset(Offset = "0x30")]
	private Action<string> m_callback;

	[Token(Token = "0x4000921")]
	[FieldOffset(Offset = "0x38")]
	private Dictionary<DIALOG_TYPE, Dictionary<string, object>> dialogParam;

	[Token(Token = "0x60009B1")]
	[Address(RVA = "0xB085B0", Offset = "0xB077B0", VA = "0x180B085B0")]
	[Obsolete("完了コールバックを待っていないため取得出来ない可能性があります")]
	public string GetSession()
	{
		return null;
	}

	[Token(Token = "0x60009B2")]
	[Address(RVA = "0xB08A60", Offset = "0xB07C60", VA = "0x180B08A60")]
	public bool RequestSession(Action<string> callback)
	{
		return default(bool);
	}

	[Token(Token = "0x60009B3")]
	[Address(RVA = "0xB08380", Offset = "0xB07580", VA = "0x180B08380")]
	public void CancelSession()
	{
	}

	[Token(Token = "0x60009B4")]
	[Address(RVA = "0xB083D0", Offset = "0xB075D0", VA = "0x180B083D0")]
	public Dictionary<string, object> GetDialogParam(DIALOG_TYPE type)
	{
		return null;
	}

	[Token(Token = "0x60009B5")]
	[Address(RVA = "0xB08430", Offset = "0xB07630", VA = "0x180B08430")]
	private void GetSessionTicket()
	{
	}

	[Token(Token = "0x60009B6")]
	[Address(RVA = "0xB08910", Offset = "0xB07B10", VA = "0x180B08910")]
	private bool RequestSessionTicket(Action<string> callback)
	{
		return default(bool);
	}

	[Token(Token = "0x60009B7")]
	[Address(RVA = "0xB08750", Offset = "0xB07950", VA = "0x180B08750")]
	private void RequestSessionTicketResponseCallback(GetAuthSessionTicketResponse_t r)
	{
	}

	[Token(Token = "0x60009B8")]
	[Address(RVA = "0xB08BE0", Offset = "0xB07DE0", VA = "0x180B08BE0")]
	public SteamAuthSession()
	{
	}
}
