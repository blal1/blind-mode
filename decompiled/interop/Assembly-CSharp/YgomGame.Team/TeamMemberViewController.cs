using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Menu;
using YgomSystem.Network;
using YgomSystem.UI;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.Team;

[Token(Token = "0x2001666")]
public class TeamMemberViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported, TeamLobbyPollingWatcher.ICallback
{
	[Token(Token = "0x2001667")]
	public class PcodeData : MonoBehaviour
	{
		[Token(Token = "0x17001544")]
		public long value
		{
			[Token(Token = "0x6008B71")]
			[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6008B70")]
			[Address(RVA = "0x7320F0", Offset = "0x7312F0", VA = "0x1807320F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6008B72")]
		[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
		public PcodeData()
		{
		}
	}

	[Token(Token = "0x2001668")]
	public class Param
	{
		[Token(Token = "0x17001545")]
		public TeamLobbyPollingWatcher watchDog
		{
			[Token(Token = "0x6008B74")]
			[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6008B73")]
			[Address(RVA = "0x439010", Offset = "0x438210", VA = "0x180439010")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17001546")]
		public int teamNumMax
		{
			[Token(Token = "0x6008B76")]
			[Address(RVA = "0x5C7C60", Offset = "0x5C6E60", VA = "0x1805C7C60")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6008B75")]
			[Address(RVA = "0x615AB0", Offset = "0x614CB0", VA = "0x180615AB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6008B77")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public Param()
		{
		}
	}

	[Token(Token = "0x2001669")]
	private enum ArgKeyName
	{
		[Token(Token = "0x400D64E")]
		name,
		[Token(Token = "0x400D64F")]
		pcode,
		[Token(Token = "0x400D650")]
		follow_num,
		[Token(Token = "0x400D651")]
		follower_num,
		[Token(Token = "0x400D652")]
		level,
		[Token(Token = "0x400D653")]
		rank,
		[Token(Token = "0x400D654")]
		rate,
		[Token(Token = "0x400D655")]
		icon_id,
		[Token(Token = "0x400D656")]
		icon_frame_id,
		[Token(Token = "0x400D657")]
		tag,
		[Token(Token = "0x400D658")]
		avatar_id,
		[Token(Token = "0x400D659")]
		wallpaper,
		[Token(Token = "0x400D65A")]
		exp,
		[Token(Token = "0x400D65B")]
		need_exp,
		[Token(Token = "0x400D65C")]
		online_id,
		[Token(Token = "0x400D65D")]
		is_same_os,
		[Token(Token = "0x400D65E")]
		xuid,
		[Token(Token = "0x400D65F")]
		edit,
		[Token(Token = "0x400D660")]
		rank_event,
		[Token(Token = "0x400D661")]
		official,
		[Token(Token = "0x400D662")]
		MAX
	}

	[Token(Token = "0x400D641")]
	[FieldOffset(Offset = "0xD0")]
	private readonly string LBL_PLATFORMPLAYERICON;

	[Token(Token = "0x400D642")]
	[FieldOffset(Offset = "0xD8")]
	private readonly string LBL_PLATFORMPLAYERNAMEGROUP;

	[Token(Token = "0x400D643")]
	[FieldOffset(Offset = "0xE0")]
	private readonly string LBL_PROFILEICON;

	[Token(Token = "0x400D644")]
	[FieldOffset(Offset = "0xE8")]
	private readonly string LBL_BUTTON;

	[Token(Token = "0x400D645")]
	[FieldOffset(Offset = "0xF0")]
	private InfinityScrollView _scrollView;

	[Token(Token = "0x400D646")]
	[FieldOffset(Offset = "0xF8")]
	private Param _param;

	[Token(Token = "0x400D647")]
	[FieldOffset(Offset = "0x100")]
	private Dictionary<long, Dictionary<string, object>> members;

	[Token(Token = "0x400D648")]
	[FieldOffset(Offset = "0x108")]
	private Dictionary<int, string> s_KeyNameCaches;

	[Token(Token = "0x400D649")]
	[FieldOffset(Offset = "0x110")]
	private List<long> _orderedPcodes;

	[Token(Token = "0x6008B5D")]
	[Address(RVA = "0xD69CB0", Offset = "0xD68EB0", VA = "0x180D69CB0")]
	public static void Open(ViewControllerManager manager, Param param)
	{
	}

	[Token(Token = "0x6008B5E")]
	[Address(RVA = "0xD69280", Offset = "0xD68480", VA = "0x180D69280")]
	private bool GetBool(Dictionary<string, object> data, ArgKeyName key)
	{
		return default(bool);
	}

	[Token(Token = "0x6008B5F")]
	[Address(RVA = "0xD69300", Offset = "0xD68500", VA = "0x180D69300")]
	private int GetInt(Dictionary<string, object> data, ArgKeyName key)
	{
		return default(int);
	}

	[Token(Token = "0x6008B60")]
	[Address(RVA = "0xD69380", Offset = "0xD68580", VA = "0x180D69380")]
	private long GetLong(Dictionary<string, object> data, ArgKeyName key)
	{
		return default(long);
	}

	[Token(Token = "0x6008B61")]
	[Address(RVA = "0xD69400", Offset = "0xD68600", VA = "0x180D69400")]
	private string GetString(Dictionary<string, object> data, ArgKeyName key)
	{
		return null;
	}

	[Token(Token = "0x6008B62")]
	[Address(RVA = "0xD69D20", Offset = "0xD68F20", VA = "0x180D69D20")]
	private void Register(Dictionary<string, object> data, ArgKeyName key, object value)
	{
	}

	[Token(Token = "0x6008B63")]
	[Address(RVA = "0xD69480", Offset = "0xD68680", VA = "0x180D69480", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6008B64")]
	[Address(RVA = "0xD69560", Offset = "0xD68760", VA = "0x180D69560", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6008B65")]
	[Address(RVA = "0xD694F0", Offset = "0xD686F0", VA = "0x180D694F0", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x6008B66")]
	[Address(RVA = "0xD69E60", Offset = "0xD69060", VA = "0x180D69E60")]
	private void Start()
	{
	}

	[Token(Token = "0x6008B67")]
	[Address(RVA = "0xD696C0", Offset = "0xD688C0", VA = "0x180D696C0")]
	private void OnEntityUpdate(GameObject obj, int index)
	{
	}

	[Token(Token = "0x6008B68")]
	[Address(RVA = "0xD69BF0", Offset = "0xD68DF0", VA = "0x180D69BF0", Slot = "28")]
	public void OnPollingResponse(Handle handle)
	{
	}

	[Token(Token = "0x6008B69")]
	[Address(RVA = "0xD69CA0", Offset = "0xD68EA0", VA = "0x180D69CA0")]
	private void OnProfileCardOpening(Dictionary<string, object> member)
	{
	}

	[Token(Token = "0x6008B6A")]
	[Address(RVA = "0xD69FE0", Offset = "0xD691E0", VA = "0x180D69FE0")]
	private void UpdateMembers()
	{
	}

	[Token(Token = "0x6008B6B")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "29")]
	public void OnApplyingStatusChanged(TeamLobbyPollingWatcher.ApplyingBattleData data)
	{
	}

	[Token(Token = "0x6008B6C")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "30")]
	public void OnAppliedFromOtherTeam(TeamLobbyPollingWatcher.AppliedBattleData data)
	{
	}

	[Token(Token = "0x6008B6D")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "31")]
	public void OnOpponentTeamInfoUpdated(OpponentTeamInfo data)
	{
	}

	[Token(Token = "0x6008B6E")]
	[Address(RVA = "0xD6B080", Offset = "0xD6A280", VA = "0x180D6B080")]
	public TeamMemberViewController()
	{
	}
}
