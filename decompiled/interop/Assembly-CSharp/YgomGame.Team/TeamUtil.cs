using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Events;
using YgomSystem.Network;
using YgomSystem.UI;

namespace YgomGame.Team;

[Token(Token = "0x20016A9")]
public class TeamUtil
{
	[Token(Token = "0x20016AA")]
	public class RegulationSet
	{
		[Token(Token = "0x17001567")]
		public string name
		{
			[Token(Token = "0x6008D11")]
			[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6008D10")]
			[Address(RVA = "0x439010", Offset = "0x438210", VA = "0x180439010")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17001568")]
		public int id
		{
			[Token(Token = "0x6008D13")]
			[Address(RVA = "0x5C7C60", Offset = "0x5C6E60", VA = "0x1805C7C60")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6008D12")]
			[Address(RVA = "0x615AB0", Offset = "0x614CB0", VA = "0x180615AB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17001569")]
		public int[] regulations
		{
			[Token(Token = "0x6008D15")]
			[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6008D14")]
			[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6008D16")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public RegulationSet()
		{
		}
	}

	[Token(Token = "0x20016AB")]
	public enum MatchType
	{
		[Token(Token = "0x400D7E7")]
		Null,
		[Token(Token = "0x400D7E8")]
		Normal,
		[Token(Token = "0x400D7E9")]
		Max
	}

	[Token(Token = "0x17001566")]
	private static string stringCrossPlatformPlay
	{
		[Token(Token = "0x6008D03")]
		[Address(RVA = "0xD8C7C0", Offset = "0xD8B9C0", VA = "0x180D8C7C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6008D04")]
	[Address(RVA = "0xD8C2E0", Offset = "0xD8B4E0", VA = "0x180D8C2E0")]
	public static bool IsForceLeaveError(TeamCode code)
	{
		return default(bool);
	}

	[Token(Token = "0x6008D05")]
	[Address(RVA = "0xD8C2C0", Offset = "0xD8B4C0", VA = "0x180D8C2C0")]
	public static bool IsFatalError(TeamCode code)
	{
		return default(bool);
	}

	[Token(Token = "0x6008D06")]
	[Address(RVA = "0xD8B3D0", Offset = "0xD8A5D0", VA = "0x180D8B3D0")]
	public static bool HandleResultCode(Handle handle, UnityAction onSuccess, UnityAction<TeamCode> onFailed, bool showDialog = true)
	{
		return default(bool);
	}

	[Token(Token = "0x6008D07")]
	[Address(RVA = "0xD8C5C0", Offset = "0xD8B7C0", VA = "0x180D8C5C0")]
	public static void OpenRegulationSelect(int[] regulationList, int selectedRegID, Action<int, string> onResult)
	{
	}

	[Token(Token = "0x6008D08")]
	[Address(RVA = "0xD8C310", Offset = "0xD8B510", VA = "0x180D8C310")]
	public static void OpenDeckSelect(ViewControllerManager manager, int regulationID, int deckId)
	{
	}

	[Token(Token = "0x6008D09")]
	[Address(RVA = "0xD8ACE0", Offset = "0xD89EE0", VA = "0x180D8ACE0")]
	public static void CallAPI_DeckCheck(int regulationId, Action onEnd)
	{
	}

	[Token(Token = "0x6008D0A")]
	[Address(RVA = "0xD8AD10", Offset = "0xD89F10", VA = "0x180D8AD10")]
	public static void CallAPI_SetReulationSetID(int regSetId, Action<TeamCode> onEnd)
	{
	}

	[Token(Token = "0x6008D0B")]
	[Address(RVA = "0xD8B0B0", Offset = "0xD8A2B0", VA = "0x180D8B0B0")]
	public static void CallAPI_TeamEntry(int teamId, Action onSuccess)
	{
	}

	[Token(Token = "0x6008D0C")]
	[Address(RVA = "0xD8AF10", Offset = "0xD8A110", VA = "0x180D8AF10")]
	public static void CallAPI_TeamEntry(int teamId, int matchType, Action onSuccess, Action onFailed)
	{
	}

	[Token(Token = "0x6008D0D")]
	[Address(RVA = "0xD8ADE0", Offset = "0xD89FE0", VA = "0x180D8ADE0")]
	public static void CallAPI_TeamEntryAndArrive(int teamId, int matchType, int tableNo, Action onSuccess, Action onFailed)
	{
	}

	[Token(Token = "0x6008D0E")]
	[Address(RVA = "0xD8B240", Offset = "0xD8A440", VA = "0x180D8B240")]
	public static string GetStringFromTextID(string text)
	{
		return null;
	}

	[Token(Token = "0x6008D0F")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public TeamUtil()
	{
	}
}
