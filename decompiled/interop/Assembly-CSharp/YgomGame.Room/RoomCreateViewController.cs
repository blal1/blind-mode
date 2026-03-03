using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.ActionSheet;
using YgomGame.Menu;
using YgomSystem.Network;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.Room;

[Token(Token = "0x2000ADD")]
public class RoomCreateViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x2000ADE")]
	internal abstract class TemplateInfo
	{
		[Token(Token = "0x4009442")]
		[FieldOffset(Offset = "0x10")]
		internal readonly int templateType;

		[Token(Token = "0x4009443")]
		[FieldOffset(Offset = "0x18")]
		internal readonly string settingLabel;

		[Token(Token = "0x600430B")]
		[Address(RVA = "0x8DAEA0", Offset = "0x8DA0A0", VA = "0x1808DAEA0")]
		public TemplateInfo(string settingLabel, int templateType)
		{
		}
	}

	[Token(Token = "0x2000ADF")]
	internal class LabelInfo : TemplateInfo
	{
		[Token(Token = "0x600430C")]
		[Address(RVA = "0x8C92D0", Offset = "0x8C84D0", VA = "0x1808C92D0")]
		internal LabelInfo(string settingLabel)
		{
		}
	}

	[Token(Token = "0x2000AE0")]
	internal abstract class ButtonInfoBase : TemplateInfo
	{
		[Token(Token = "0x4009444")]
		[FieldOffset(Offset = "0x20")]
		internal readonly string title;

		[Token(Token = "0x170008F8")]
		internal string valueText
		{
			[Token(Token = "0x600430D")]
			[Address(RVA = "0x8C8520", Offset = "0x8C7720", VA = "0x1808C8520")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008F9")]
		protected internal abstract object objectValue
		{
			[Token(Token = "0x600430E")]
			get;
		}

		[Token(Token = "0x170008FA")]
		internal bool pushable
		{
			[Token(Token = "0x6004310")]
			[Address(RVA = "0x588F60", Offset = "0x588160", VA = "0x180588F60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600430F")]
			[Address(RVA = "0x588F70", Offset = "0x588170", VA = "0x180588F70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170008FB")]
		internal Func<string> funcValueText
		{
			[Token(Token = "0x6004316")]
			[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6004315")]
			[Address(RVA = "0x595530", Offset = "0x594730", VA = "0x180595530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1400005B")]
		internal event Action buttonHandler
		{
			[Token(Token = "0x6004311")]
			[Address(RVA = "0x8C83E0", Offset = "0x8C75E0", VA = "0x1808C83E0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004312")]
			[Address(RVA = "0x8C8550", Offset = "0x8C7750", VA = "0x1808C8550")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400005C")]
		internal event Action updateHandler
		{
			[Token(Token = "0x6004313")]
			[Address(RVA = "0x8C8480", Offset = "0x8C7680", VA = "0x1808C8480")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004314")]
			[Address(RVA = "0x8C85F0", Offset = "0x8C77F0", VA = "0x1808C85F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6004317")]
		[Address(RVA = "0x8C8380", Offset = "0x8C7580", VA = "0x1808C8380")]
		internal ButtonInfoBase(string settingLabel, string title)
		{
		}

		[Token(Token = "0x6004318")]
		[Address(RVA = "0x8C8340", Offset = "0x8C7540", VA = "0x1808C8340")]
		internal void OnClick()
		{
		}

		[Token(Token = "0x6004319")]
		[Address(RVA = "0x8C8360", Offset = "0x8C7560", VA = "0x1808C8360")]
		internal void OnUpdate()
		{
		}

		[Token(Token = "0x600431A")]
		[Address(RVA = "0x8C82D0", Offset = "0x8C74D0", VA = "0x1808C82D0")]
		internal void AddToDictionary(ref Dictionary<string, object> refDic)
		{
		}
	}

	[Token(Token = "0x2000AE1")]
	internal class ButtonStringInfo : ButtonInfoBase
	{
		[Token(Token = "0x170008FC")]
		internal string currentValue
		{
			[Token(Token = "0x600431B")]
			[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600431C")]
			[Address(RVA = "0x414E90", Offset = "0x414090", VA = "0x180414E90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170008FD")]
		protected internal override object objectValue
		{
			[Token(Token = "0x600431D")]
			[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600431E")]
		[Address(RVA = "0x8C87D0", Offset = "0x8C79D0", VA = "0x1808C87D0")]
		public ButtonStringInfo(string settingLabel, string title, string defaultValue)
		{
		}
	}

	[Token(Token = "0x2000AE2")]
	internal class ButtonIntValueInfo : ButtonInfoBase
	{
		[Token(Token = "0x170008FE")]
		internal int currentValue
		{
			[Token(Token = "0x6004320")]
			[Address(RVA = "0x49BDB0", Offset = "0x49AFB0", VA = "0x18049BDB0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6004321")]
			[Address(RVA = "0x49C4C0", Offset = "0x49B6C0", VA = "0x18049C4C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170008FF")]
		protected internal override object objectValue
		{
			[Token(Token = "0x6004322")]
			[Address(RVA = "0x8C8780", Offset = "0x8C7980", VA = "0x1808C8780", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004323")]
		[Address(RVA = "0x8C86B0", Offset = "0x8C78B0", VA = "0x1808C86B0")]
		public ButtonIntValueInfo(string settingLabel, string title, int defaultValue)
		{
		}
	}

	[Token(Token = "0x2000AE3")]
	internal class ButtonBoolValueInfo : ButtonInfoBase
	{
		[Token(Token = "0x17000900")]
		internal bool currentValue
		{
			[Token(Token = "0x6004325")]
			[Address(RVA = "0x7CE740", Offset = "0x7CD940", VA = "0x1807CE740")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004326")]
			[Address(RVA = "0x8C82C0", Offset = "0x8C74C0", VA = "0x1808C82C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000901")]
		protected internal override object objectValue
		{
			[Token(Token = "0x6004327")]
			[Address(RVA = "0x8C8290", Offset = "0x8C7490", VA = "0x1808C8290", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004328")]
		[Address(RVA = "0x8C81C0", Offset = "0x8C73C0", VA = "0x1808C81C0")]
		public ButtonBoolValueInfo(string settingLabel, string title, bool defaultValue)
		{
		}

		[Token(Token = "0x6004329")]
		[Address(RVA = "0x8C8130", Offset = "0x8C7330", VA = "0x1808C8130")]
		internal void SwitchValue()
		{
		}
	}

	[Token(Token = "0x4009433")]
	[FieldOffset(Offset = "0xD0")]
	private readonly string SCROLL_LABEL;

	[Token(Token = "0x4009434")]
	[FieldOffset(Offset = "0xD8")]
	private readonly string BTN_OK_LABEL;

	[Token(Token = "0x4009435")]
	[FieldOffset(Offset = "0xE0")]
	private List<TemplateInfo> infos;

	[Token(Token = "0x4009436")]
	[FieldOffset(Offset = "0xE8")]
	private InfinityScrollView isv;

	[Token(Token = "0x4009437")]
	internal const string KEY_MEMBER_MAX = "member_max";

	[Token(Token = "0x4009438")]
	internal const string KEY_PUBLIC = "is_public";

	[Token(Token = "0x4009439")]
	internal const string KEY_SPECTRAL = "is_spectral";

	[Token(Token = "0x400943A")]
	internal const string KEY_SPECTER = "is_specter";

	[Token(Token = "0x400943B")]
	internal const string KEY_COMMENT = "room_comment";

	[Token(Token = "0x400943C")]
	internal const string KEY_TIME = "battle_time";

	[Token(Token = "0x400943D")]
	internal const string KEY_LP = "battle_lp";

	[Token(Token = "0x400943E")]
	internal const string KEY_REPLAY = "is_replay";

	[Token(Token = "0x400943F")]
	internal const string KEY_BATTLE_RULE = "battle_rule";

	[Token(Token = "0x4009440")]
	[FieldOffset(Offset = "0xF0")]
	private List<RoomUtil.DuelTimeSetting> _duelTimeSettings;

	[Token(Token = "0x4009441")]
	[FieldOffset(Offset = "0xF8")]
	private RegulationSelectSheet _regulationSelectSheet;

	[Token(Token = "0x170008F7")]
	protected override Type[] textIds
	{
		[Token(Token = "0x60042F3")]
		[Address(RVA = "0x896830", Offset = "0x895A30", VA = "0x180896830", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60042F4")]
	[Address(RVA = "0x3E4080", Offset = "0x3E3280", VA = "0x1803E4080", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x60042F5")]
	[Address(RVA = "0x893990", Offset = "0x892B90", VA = "0x180893990", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x60042F6")]
	[Address(RVA = "0x893B70", Offset = "0x892D70", VA = "0x180893B70")]
	private void OnUpdateEntity(GameObject go, int index)
	{
	}

	[Token(Token = "0x60042F7")]
	[Address(RVA = "0x894DB0", Offset = "0x893FB0", VA = "0x180894DB0")]
	private void SetupData()
	{
	}

	[Token(Token = "0x60042F8")]
	[Address(RVA = "0x895B40", Offset = "0x894D40", VA = "0x180895B40")]
	private ButtonInfoBase SetupMemberMax()
	{
		return null;
	}

	[Token(Token = "0x60042F9")]
	[Address(RVA = "0x8957E0", Offset = "0x8949E0", VA = "0x1808957E0")]
	private ButtonInfoBase SetupIsPublic()
	{
		return null;
	}

	[Token(Token = "0x60042FA")]
	[Address(RVA = "0x896010", Offset = "0x895210", VA = "0x180896010")]
	private ButtonInfoBase SetupSpectationOK()
	{
		return null;
	}

	[Token(Token = "0x60042FB")]
	[Address(RVA = "0x896210", Offset = "0x895410", VA = "0x180896210")]
	private ButtonInfoBase SetupSpectationPublic()
	{
		return null;
	}

	[Token(Token = "0x60042FC")]
	[Address(RVA = "0x894410", Offset = "0x893610", VA = "0x180894410")]
	private ButtonInfoBase SetupBattleRule()
	{
		return null;
	}

	[Token(Token = "0x60042FD")]
	[Address(RVA = "0x895D60", Offset = "0x894F60", VA = "0x180895D60")]
	private ButtonInfoBase SetupRoomComment()
	{
		return null;
	}

	[Token(Token = "0x60042FE")]
	[Address(RVA = "0x8946A0", Offset = "0x8938A0", VA = "0x1808946A0")]
	private ButtonInfoBase SetupBattleTime()
	{
		return null;
	}

	[Token(Token = "0x60042FF")]
	[Address(RVA = "0x894180", Offset = "0x893380", VA = "0x180894180")]
	private ButtonInfoBase SetupBattleLP()
	{
		return null;
	}

	[Token(Token = "0x6004300")]
	[Address(RVA = "0x895990", Offset = "0x894B90", VA = "0x180895990")]
	private ButtonInfoBase SetupIsReplay()
	{
		return null;
	}

	[Token(Token = "0x6004301")]
	[Address(RVA = "0x893560", Offset = "0x892760", VA = "0x180893560")]
	private void CallAPIRoomCreate()
	{
	}

	[Token(Token = "0x6004302")]
	[Address(RVA = "0x893790", Offset = "0x892990", VA = "0x180893790")]
	private void ErrorRoomCreate(RoomCode roomCode)
	{
	}

	[Token(Token = "0x6004303")]
	[Address(RVA = "0x893510", Offset = "0x892710", VA = "0x180893510")]
	private Handle APIRoomCreate(Dictionary<string, object> _room_settings_)
	{
		return null;
	}

	[Token(Token = "0x6004304")]
	[Address(RVA = "0x893EF0", Offset = "0x8930F0", VA = "0x180893EF0")]
	private void OpenActionSheet(string title, IReadOnlyList<string> texts, int initIndex, Action<int> callback)
	{
	}

	[Token(Token = "0x6004305")]
	[Address(RVA = "0x896760", Offset = "0x895960", VA = "0x180896760")]
	public RoomCreateViewController()
	{
	}
}
