using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using YgomGame.Card;
using YgomSystem;

namespace YgomGame.Settings;

[Token(Token = "0x2000A06")]
public class SettingsUtil
{
	[Token(Token = "0x2000A07")]
	public struct SoundParam
	{
		[Token(Token = "0x2000A08")]
		public enum INIT_TYPE
		{
			[Token(Token = "0x4008F85")]
			DEFAULT,
			[Token(Token = "0x4008F86")]
			WORK
		}

		[Token(Token = "0x4008F7D")]
		[FieldOffset(Offset = "0x0")]
		public int bgm;

		[Token(Token = "0x4008F7E")]
		[FieldOffset(Offset = "0x4")]
		public int se;

		[Token(Token = "0x4008F7F")]
		[FieldOffset(Offset = "0x8")]
		public int voice;

		[Token(Token = "0x4008F80")]
		[FieldOffset(Offset = "0xC")]
		public int movie;

		[Token(Token = "0x4008F81")]
		[FieldOffset(Offset = "0x10")]
		public bool bgmMute;

		[Token(Token = "0x4008F82")]
		[FieldOffset(Offset = "0x11")]
		public bool seMute;

		[Token(Token = "0x4008F83")]
		[FieldOffset(Offset = "0x12")]
		public bool voiceMute;

		[Token(Token = "0x6003E4C")]
		[Address(RVA = "0x85BAB0", Offset = "0x85ACB0", VA = "0x18085BAB0")]
		public SoundParam(INIT_TYPE initType)
		{
		}

		[Token(Token = "0x6003E4D")]
		[Address(RVA = "0x85BA80", Offset = "0x85AC80", VA = "0x18085BA80")]
		public SoundParam(int init_bgm, int init_se, int init_voice, int init_video, bool init_bgm_mute = false, bool init_se_mute = false, bool init_voice_mute = false)
		{
		}
	}

	[Token(Token = "0x2000A09")]
	public struct BasicParam
	{
		[Token(Token = "0x2000A0A")]
		public enum INIT_TYPE
		{
			[Token(Token = "0x4008F91")]
			DEFAULT,
			[Token(Token = "0x4008F92")]
			WORK
		}

		[Token(Token = "0x2000A0B")]
		public enum CARD_TEXT_SIZE
		{
			[Token(Token = "0x4008F94")]
			LARGE,
			[Token(Token = "0x4008F95")]
			MEDIUM,
			[Token(Token = "0x4008F96")]
			SMALL
		}

		[Token(Token = "0x2000A0C")]
		public enum QUALITY
		{
			[Token(Token = "0x4008F98")]
			STANDARD,
			[Token(Token = "0x4008F99")]
			RECOMMENDED,
			[Token(Token = "0x4008F9A")]
			HIGH,
			[Token(Token = "0x4008F9B")]
			CUSTOM
		}

		[Token(Token = "0x2000A0D")]
		public enum ANTI_ALIASING
		{
			[Token(Token = "0x4008F9D")]
			NONE,
			[Token(Token = "0x4008F9E")]
			LOW,
			[Token(Token = "0x4008F9F")]
			HIGH
		}

		[Token(Token = "0x2000A0E")]
		public enum CARD_QUALITY
		{
			[Token(Token = "0x4008FA1")]
			LOW,
			[Token(Token = "0x4008FA2")]
			STANDARD,
			[Token(Token = "0x4008FA3")]
			HIGH
		}

		[Token(Token = "0x4008F87")]
		[FieldOffset(Offset = "0x0")]
		public int perform;

		[Token(Token = "0x4008F88")]
		[FieldOffset(Offset = "0x4")]
		public QUALITY quality;

		[Token(Token = "0x4008F89")]
		[FieldOffset(Offset = "0x8")]
		public ANTI_ALIASING customAntiAliasing;

		[Token(Token = "0x4008F8A")]
		[FieldOffset(Offset = "0xC")]
		public CARD_QUALITY customCardQuality;

		[Token(Token = "0x4008F8B")]
		[FieldOffset(Offset = "0x10")]
		public int customResolution;

		[Token(Token = "0x4008F8C")]
		[FieldOffset(Offset = "0x14")]
		public int resolution;

		[Token(Token = "0x4008F8D")]
		[FieldOffset(Offset = "0x18")]
		public bool fullScreen;

		[Token(Token = "0x4008F8E")]
		[FieldOffset(Offset = "0x1C")]
		public CARD_TEXT_SIZE cardTextSize;

		[Token(Token = "0x4008F8F")]
		[FieldOffset(Offset = "0x20")]
		public bool vibration;

		[Token(Token = "0x6003E4E")]
		[Address(RVA = "0x845F80", Offset = "0x845180", VA = "0x180845F80")]
		public BasicParam(INIT_TYPE initType)
		{
		}
	}

	[Token(Token = "0x2000A0F")]
	public struct SystemParam
	{
		[Token(Token = "0x2000A10")]
		public enum INIT_TYPE
		{
			[Token(Token = "0x4008FA8")]
			DEFAULT,
			[Token(Token = "0x4008FA9")]
			WORK
		}

		[Token(Token = "0x4008FA4")]
		[FieldOffset(Offset = "0x0")]
		public bool notify;

		[Token(Token = "0x4008FA5")]
		[FieldOffset(Offset = "0x1")]
		public bool chat;

		[Token(Token = "0x4008FA6")]
		[FieldOffset(Offset = "0x2")]
		public bool surveyReservation;

		[Token(Token = "0x6003E4F")]
		[Address(RVA = "0x85BD60", Offset = "0x85AF60", VA = "0x18085BD60")]
		public SystemParam(INIT_TYPE initType)
		{
		}

		[Token(Token = "0x6003E50")]
		[Address(RVA = "0x85BEC0", Offset = "0x85B0C0", VA = "0x18085BEC0")]
		public SystemParam(bool init_notify, bool init_chat, bool init_surveyReservation)
		{
		}
	}

	[Token(Token = "0x2000A11")]
	public enum SHOW_CARDREPORT_TYPE
	{
		[Token(Token = "0x4008FAB")]
		NONE,
		[Token(Token = "0x4008FAC")]
		ALL
	}

	[Token(Token = "0x2000A12")]
	public enum SHOW_RIVALNAME_TYPE
	{
		[Token(Token = "0x4008FAE")]
		HIDE,
		[Token(Token = "0x4008FAF")]
		SHOW
	}

	[Token(Token = "0x2000A13")]
	public enum SHOW_HAPPENEDEFFECT_TYPE
	{
		[Token(Token = "0x4008FB1")]
		OFF,
		[Token(Token = "0x4008FB2")]
		ON,
		[Token(Token = "0x4008FB3")]
		ON_ONLY_DUELSTATUS
	}

	[Token(Token = "0x2000A14")]
	public enum BGM_MODE
	{
		[Token(Token = "0x4008FB5")]
		FIELD_MYSELF,
		[Token(Token = "0x4008FB6")]
		FIELD_RIVAL
	}

	[Token(Token = "0x2000A15")]
	public struct DuelParam
	{
		[Token(Token = "0x2000A16")]
		public enum INIT_TYPE
		{
			[Token(Token = "0x4008FD2")]
			DEFAULT,
			[Token(Token = "0x4008FD3")]
			WORK
		}

		[Token(Token = "0x2000A17")]
		public enum CHAIN_TYPE
		{
			[Token(Token = "0x4008FD5")]
			MY_CHAIN_ON,
			[Token(Token = "0x4008FD6")]
			MY_CHAIN_OFF
		}

		[Token(Token = "0x2000A18")]
		public enum MANUAL_TYPE
		{
			[Token(Token = "0x4008FD8")]
			NONE,
			[Token(Token = "0x4008FD9")]
			TOUCH,
			[Token(Token = "0x4008FDA")]
			TOGGLE,
			[Token(Token = "0x4008FDB")]
			TOUCH2,
			[Token(Token = "0x4008FDC")]
			TOUCH3,
			[Token(Token = "0x4008FDD")]
			TOGGLE2,
			[Token(Token = "0x4008FDE")]
			CUSTOM
		}

		[Token(Token = "0x2000A19")]
		public enum CONFIRM_MODE
		{
			[Token(Token = "0x4008FE0")]
			NONE,
			[Token(Token = "0x4008FE1")]
			AUTO,
			[Token(Token = "0x4008FE2")]
			ON,
			[Token(Token = "0x4008FE3")]
			OFF
		}

		[Token(Token = "0x2000A1A")]
		public enum CONFIRM_SWITCH_MODE
		{
			[Token(Token = "0x4008FE5")]
			NONE,
			[Token(Token = "0x4008FE6")]
			SET_ON,
			[Token(Token = "0x4008FE7")]
			SET_OFF,
			[Token(Token = "0x4008FE8")]
			SET_AUTO
		}

		[Token(Token = "0x2000A1B")]
		public enum LOCATE_TYPE
		{
			[Token(Token = "0x4008FEA")]
			AUTO,
			[Token(Token = "0x4008FEB")]
			MANUAL
		}

		[Token(Token = "0x2000A1C")]
		public enum COMMAND_TYPE
		{
			[Token(Token = "0x4008FED")]
			MASTERDUEL,
			[Token(Token = "0x4008FEE")]
			DUELLINKS
		}

		[Token(Token = "0x2000A1D")]
		public enum SKIP_TYPE
		{
			[Token(Token = "0x4008FF0")]
			NONE,
			[Token(Token = "0x4008FF1")]
			ONETIME,
			[Token(Token = "0x4008FF2")]
			ALWAYS
		}

		[Token(Token = "0x2000A1E")]
		public enum CAMERA_TYPE
		{
			[Token(Token = "0x4008FF4")]
			NEAR,
			[Token(Token = "0x4008FF5")]
			FAR
		}

		[Token(Token = "0x2000A1F")]
		public enum SHOW_CARDINFO_TYPE
		{
			[Token(Token = "0x4008FF7")]
			NONE,
			[Token(Token = "0x4008FF8")]
			AUTO_ALL,
			[Token(Token = "0x4008FF9")]
			AUTO_ONLY_CARDSHOW
		}

		[Token(Token = "0x2000A20")]
		public enum CARDLIST_LAYOUT_TYPE
		{
			[Token(Token = "0x4008FFB")]
			NORMAL,
			[Token(Token = "0x4008FFC")]
			WIDE,
			[Token(Token = "0x4008FFD")]
			LAST_SET
		}

		[Token(Token = "0x2000A21")]
		public enum GENERIC_CARDLIST_LAYOUT_TYPE
		{
			[Token(Token = "0x4008FFF")]
			NORMAL,
			[Token(Token = "0x4009000")]
			WIDE,
			[Token(Token = "0x4009001")]
			LAST_SET
		}

		[Token(Token = "0x4008FB7")]
		[FieldOffset(Offset = "0x0")]
		public CHAIN_TYPE chainType;

		[Token(Token = "0x4008FB8")]
		[FieldOffset(Offset = "0x4")]
		public MANUAL_TYPE manualType;

		[Token(Token = "0x4008FB9")]
		[FieldOffset(Offset = "0x8")]
		public bool customConfirmUseSwitch;

		[Token(Token = "0x4008FBA")]
		[FieldOffset(Offset = "0xC")]
		public CONFIRM_MODE customConfirmDefault;

		[Token(Token = "0x4008FBB")]
		[FieldOffset(Offset = "0x10")]
		public CONFIRM_MODE customConfirmHold0;

		[Token(Token = "0x4008FBC")]
		[FieldOffset(Offset = "0x14")]
		public CONFIRM_MODE customConfirmHold1;

		[Token(Token = "0x4008FBD")]
		[FieldOffset(Offset = "0x18")]
		public CONFIRM_SWITCH_MODE switchOnTurnEnd;

		[Token(Token = "0x4008FBE")]
		[FieldOffset(Offset = "0x1C")]
		public LOCATE_TYPE locateType;

		[Token(Token = "0x4008FBF")]
		[FieldOffset(Offset = "0x20")]
		public COMMAND_TYPE commandType;

		[Token(Token = "0x4008FC0")]
		[FieldOffset(Offset = "0x24")]
		public bool autoPlayEnable;

		[Token(Token = "0x4008FC1")]
		[FieldOffset(Offset = "0x25")]
		public bool enemyEmote;

		[Token(Token = "0x4008FC2")]
		[FieldOffset(Offset = "0x26")]
		public bool decideActivateOrder;

		[Token(Token = "0x4008FC3")]
		[FieldOffset(Offset = "0x28")]
		public int showCardInfoType;

		[Token(Token = "0x4008FC4")]
		[FieldOffset(Offset = "0x2C")]
		public bool showAudienceInfo;

		[Token(Token = "0x4008FC5")]
		[FieldOffset(Offset = "0x2D")]
		public bool showSetCard;

		[Token(Token = "0x4008FC6")]
		[FieldOffset(Offset = "0x2E")]
		public bool showBattleStep;

		[Token(Token = "0x4008FC7")]
		[FieldOffset(Offset = "0x30")]
		public SKIP_TYPE skipSummonEffectType;

		[Token(Token = "0x4008FC8")]
		[FieldOffset(Offset = "0x34")]
		public SKIP_TYPE skipMonsterCutinType;

		[Token(Token = "0x4008FC9")]
		[FieldOffset(Offset = "0x38")]
		public SKIP_TYPE skipCardRunEffectType;

		[Token(Token = "0x4008FCA")]
		[FieldOffset(Offset = "0x3C")]
		public bool useConsoleLayout;

		[Token(Token = "0x4008FCB")]
		[FieldOffset(Offset = "0x40")]
		public CAMERA_TYPE cameraType;

		[Token(Token = "0x4008FCC")]
		[FieldOffset(Offset = "0x44")]
		public int showRivalName;

		[Token(Token = "0x4008FCD")]
		[FieldOffset(Offset = "0x48")]
		public int showCardReportType;

		[Token(Token = "0x4008FCE")]
		[FieldOffset(Offset = "0x4C")]
		public int showHappenedEffectType;

		[Token(Token = "0x4008FCF")]
		[FieldOffset(Offset = "0x50")]
		public int cardSelectionListLayoutType;

		[Token(Token = "0x4008FD0")]
		[FieldOffset(Offset = "0x54")]
		public int genericCardListLayoutType;

		[Token(Token = "0x6003E51")]
		[Address(RVA = "0x8462B0", Offset = "0x8454B0", VA = "0x1808462B0")]
		public DuelParam(INIT_TYPE initType)
		{
		}
	}

	[Token(Token = "0x2000A22")]
	public struct AudienceParam
	{
		[Token(Token = "0x2000A23")]
		public enum INIT_TYPE
		{
			[Token(Token = "0x4009011")]
			DEFAULT,
			[Token(Token = "0x4009012")]
			WORK
		}

		[Token(Token = "0x2000A24")]
		public enum SKIP_TYPE
		{
			[Token(Token = "0x4009014")]
			NONE,
			[Token(Token = "0x4009015")]
			ALWAYS,
			[Token(Token = "0x4009016")]
			ONETIME
		}

		[Token(Token = "0x2000A25")]
		public enum CAMERA_TYPE
		{
			[Token(Token = "0x4009018")]
			NEAR,
			[Token(Token = "0x4009019")]
			FAR
		}

		[Token(Token = "0x2000A26")]
		public enum SHOW_CARDINFO_TYPE
		{
			[Token(Token = "0x400901B")]
			NONE,
			[Token(Token = "0x400901C")]
			AUTO_ALL,
			[Token(Token = "0x400901D")]
			AUTO_ONLY_CARDSHOW
		}

		[Token(Token = "0x2000A27")]
		public enum GENERIC_CARDLIST_LAYOUT_TYPE
		{
			[Token(Token = "0x400901F")]
			NORMAL,
			[Token(Token = "0x4009020")]
			WIDE,
			[Token(Token = "0x4009021")]
			LAST_SET
		}

		[Token(Token = "0x4009002")]
		[FieldOffset(Offset = "0x0")]
		public bool enemyEmote;

		[Token(Token = "0x4009003")]
		[FieldOffset(Offset = "0x4")]
		public int showCardInfoType;

		[Token(Token = "0x4009004")]
		[FieldOffset(Offset = "0x8")]
		public bool showAudienceInfo;

		[Token(Token = "0x4009005")]
		[FieldOffset(Offset = "0x9")]
		public bool showSetCard;

		[Token(Token = "0x4009006")]
		[FieldOffset(Offset = "0xA")]
		public bool showBattleStep;

		[Token(Token = "0x4009007")]
		[FieldOffset(Offset = "0xC")]
		public SKIP_TYPE skipSummonEffectType;

		[Token(Token = "0x4009008")]
		[FieldOffset(Offset = "0x10")]
		public SKIP_TYPE skipMonsterCutinType;

		[Token(Token = "0x4009009")]
		[FieldOffset(Offset = "0x14")]
		public SKIP_TYPE skipCardRunEffectType;

		[Token(Token = "0x400900A")]
		[FieldOffset(Offset = "0x18")]
		public bool useConsoleLayout;

		[Token(Token = "0x400900B")]
		[FieldOffset(Offset = "0x1C")]
		public CAMERA_TYPE cameraType;

		[Token(Token = "0x400900C")]
		[FieldOffset(Offset = "0x20")]
		public int showRivalName;

		[Token(Token = "0x400900D")]
		[FieldOffset(Offset = "0x24")]
		public int showCardReportType;

		[Token(Token = "0x400900E")]
		[FieldOffset(Offset = "0x28")]
		public int showHappenedEffectType;

		[Token(Token = "0x400900F")]
		[FieldOffset(Offset = "0x2C")]
		public int genericCardListLayoutType;

		[Token(Token = "0x6003E52")]
		[Address(RVA = "0x845A90", Offset = "0x844C90", VA = "0x180845A90")]
		public AudienceParam(INIT_TYPE initType)
		{
		}
	}

	[Token(Token = "0x2000A28")]
	public class PrivacyParam
	{
		[Token(Token = "0x2000A29")]
		public enum WatchPermissionType
		{
			[Token(Token = "0x4009025")]
			NotAllow,
			[Token(Token = "0x4009026")]
			FriendOnly,
			[Token(Token = "0x4009027")]
			Open
		}

		[Token(Token = "0x4009022")]
		[FieldOffset(Offset = "0x10")]
		public WatchPermissionType watchPermission;

		[Token(Token = "0x4009023")]
		[FieldOffset(Offset = "0x14")]
		public bool anonymWhenWatched;

		[Token(Token = "0x6003E53")]
		[Address(RVA = "0x848A00", Offset = "0x847C00", VA = "0x180848A00")]
		public Dictionary<string, object> CreateAPIParameter()
		{
			return null;
		}

		[Token(Token = "0x6003E54")]
		[Address(RVA = "0x848B10", Offset = "0x847D10", VA = "0x180848B10")]
		public static PrivacyParam GetFromClientWork()
		{
			return null;
		}

		[Token(Token = "0x6003E55")]
		[Address(RVA = "0x616CF0", Offset = "0x615EF0", VA = "0x180616CF0")]
		public PrivacyParam()
		{
		}
	}

	[Token(Token = "0x2000A2A")]
	[CompilerGenerated]
	private sealed class _003CAdjustResolution_003Ed__165 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4009028")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4009029")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400902A")]
		[FieldOffset(Offset = "0x20")]
		private float _003Cdt_003E5__2;

		[Token(Token = "0x400902B")]
		[FieldOffset(Offset = "0x24")]
		private int _003ColdW_003E5__3;

		[Token(Token = "0x400902C")]
		[FieldOffset(Offset = "0x28")]
		private int _003ColdH_003E5__4;

		[Token(Token = "0x400902D")]
		[FieldOffset(Offset = "0x2C")]
		private int _003ColdX_003E5__5;

		[Token(Token = "0x400902E")]
		[FieldOffset(Offset = "0x30")]
		private int _003ColdY_003E5__6;

		[Token(Token = "0x17000850")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003E59")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000851")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003E5B")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003E56")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CAdjustResolution_003Ed__165(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003E57")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003E58")]
		[Address(RVA = "0x85BFC0", Offset = "0x85B1C0", VA = "0x18085BFC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6003E5A")]
		[Address(RVA = "0x85C270", Offset = "0x85B470", VA = "0x18085C270", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4008F6C")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string SETTING_JSON_PATH;

	[Token(Token = "0x4008F6D")]
	[FieldOffset(Offset = "0x8")]
	public static readonly string CHAT_SETTING_PATH;

	[Token(Token = "0x4008F6E")]
	[FieldOffset(Offset = "0x10")]
	private static readonly SoundParam defaultSoundParam;

	[Token(Token = "0x4008F6F")]
	[FieldOffset(Offset = "0x24")]
	private static readonly BasicParam defaultBasicParam;

	[Token(Token = "0x4008F70")]
	[FieldOffset(Offset = "0x48")]
	private static readonly SystemParam defaultSystemParam;

	[Token(Token = "0x4008F71")]
	[FieldOffset(Offset = "0x4C")]
	private static readonly DuelParam defaultDuelParam;

	[Token(Token = "0x4008F72")]
	[FieldOffset(Offset = "0xA4")]
	private static readonly AudienceParam defaultAudienceParam;

	[Token(Token = "0x4008F73")]
	[FieldOffset(Offset = "0xD4")]
	private static SoundParam soundParamCache;

	[Token(Token = "0x4008F74")]
	[FieldOffset(Offset = "0xE8")]
	private static BasicParam basicParamCache;

	[Token(Token = "0x4008F75")]
	[FieldOffset(Offset = "0x10C")]
	private static SystemParam systemParamCache;

	[Token(Token = "0x4008F76")]
	[FieldOffset(Offset = "0x110")]
	private static DuelParam duelParamCache;

	[Token(Token = "0x4008F77")]
	[FieldOffset(Offset = "0x168")]
	private static AudienceParam audienceParamCache;

	[Token(Token = "0x4008F78")]
	[FieldOffset(Offset = "0x198")]
	public static readonly int BaseWidth;

	[Token(Token = "0x4008F79")]
	[FieldOffset(Offset = "0x19C")]
	public static readonly int BaseHeight;

	[Token(Token = "0x4008F7A")]
	[FieldOffset(Offset = "0x1A0")]
	public static readonly int[] RESOLUTION_WIDTH;

	[Token(Token = "0x4008F7B")]
	[FieldOffset(Offset = "0x1A8")]
	public static readonly int[] RESOLUTION_HEIGHT;

	[Token(Token = "0x17000815")]
	public static int bgmVolume
	{
		[Token(Token = "0x6003DB8")]
		[Address(RVA = "0x85A9F0", Offset = "0x859BF0", VA = "0x18085A9F0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000816")]
	public static int seVolume
	{
		[Token(Token = "0x6003DB9")]
		[Address(RVA = "0x85B3C0", Offset = "0x85A5C0", VA = "0x18085B3C0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000817")]
	public static int voiceVolume
	{
		[Token(Token = "0x6003DBA")]
		[Address(RVA = "0x85B9C0", Offset = "0x85ABC0", VA = "0x18085B9C0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000818")]
	public static int movieVolume
	{
		[Token(Token = "0x6003DBB")]
		[Address(RVA = "0x85B180", Offset = "0x85A380", VA = "0x18085B180")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000819")]
	public static bool bgmMute
	{
		[Token(Token = "0x6003DBC")]
		[Address(RVA = "0x85A990", Offset = "0x859B90", VA = "0x18085A990")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700081A")]
	public static bool seMute
	{
		[Token(Token = "0x6003DBD")]
		[Address(RVA = "0x85B360", Offset = "0x85A560", VA = "0x18085B360")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700081B")]
	public static bool voiceMute
	{
		[Token(Token = "0x6003DBE")]
		[Address(RVA = "0x85B960", Offset = "0x85AB60", VA = "0x18085B960")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700081C")]
	public static int performance
	{
		[Token(Token = "0x6003DC0")]
		[Address(RVA = "0x85B1E0", Offset = "0x85A3E0", VA = "0x18085B1E0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700081D")]
	public static BasicParam.QUALITY quality
	{
		[Token(Token = "0x6003DC1")]
		[Address(RVA = "0x85B2A0", Offset = "0x85A4A0", VA = "0x18085B2A0")]
		get
		{
			return default(BasicParam.QUALITY);
		}
	}

	[Token(Token = "0x1700081E")]
	public static BasicParam.ANTI_ALIASING customAntiAliasing
	{
		[Token(Token = "0x6003DC2")]
		[Address(RVA = "0x85AC90", Offset = "0x859E90", VA = "0x18085AC90")]
		get
		{
			return default(BasicParam.ANTI_ALIASING);
		}
	}

	[Token(Token = "0x1700081F")]
	public static BasicParam.CARD_QUALITY customCardQuality
	{
		[Token(Token = "0x6003DC3")]
		[Address(RVA = "0x85ACF0", Offset = "0x859EF0", VA = "0x18085ACF0")]
		get
		{
			return default(BasicParam.CARD_QUALITY);
		}
	}

	[Token(Token = "0x17000820")]
	public static int customResolution
	{
		[Token(Token = "0x6003DC4")]
		[Address(RVA = "0x85AED0", Offset = "0x85A0D0", VA = "0x18085AED0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000821")]
	public static int resolution
	{
		[Token(Token = "0x6003DC5")]
		[Address(RVA = "0x85B300", Offset = "0x85A500", VA = "0x18085B300")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000822")]
	public static bool fullScreen
	{
		[Token(Token = "0x6003DC6")]
		[Address(RVA = "0x85AFF0", Offset = "0x85A1F0", VA = "0x18085AFF0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000823")]
	public static BasicParam.CARD_TEXT_SIZE cardTextSize
	{
		[Token(Token = "0x6003DC7")]
		[Address(RVA = "0x85AB10", Offset = "0x859D10", VA = "0x18085AB10")]
		get
		{
			return default(BasicParam.CARD_TEXT_SIZE);
		}
	}

	[Token(Token = "0x17000824")]
	public static bool vibration
	{
		[Token(Token = "0x6003DC8")]
		[Address(RVA = "0x85B900", Offset = "0x85AB00", VA = "0x18085B900")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000825")]
	public static bool chat
	{
		[Token(Token = "0x6003DC9")]
		[Address(RVA = "0x85ABD0", Offset = "0x859DD0", VA = "0x18085ABD0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000826")]
	public static bool pushNotyfy
	{
		[Token(Token = "0x6003DCA")]
		[Address(RVA = "0x85B240", Offset = "0x85A440", VA = "0x18085B240")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000827")]
	public static bool surveyReservation
	{
		[Token(Token = "0x6003DCB")]
		[Address(RVA = "0x85B7E0", Offset = "0x85A9E0", VA = "0x18085B7E0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000828")]
	public static DuelParam.CHAIN_TYPE chainType
	{
		[Token(Token = "0x6003DCC")]
		[Address(RVA = "0x85AB70", Offset = "0x859D70", VA = "0x18085AB70")]
		get
		{
			return default(DuelParam.CHAIN_TYPE);
		}
	}

	[Token(Token = "0x17000829")]
	public static DuelParam.MANUAL_TYPE manualType
	{
		[Token(Token = "0x6003DCD")]
		[Address(RVA = "0x85B120", Offset = "0x85A320", VA = "0x18085B120")]
		get
		{
			return default(DuelParam.MANUAL_TYPE);
		}
	}

	[Token(Token = "0x1700082A")]
	public static DuelParam.LOCATE_TYPE locateType
	{
		[Token(Token = "0x6003DCE")]
		[Address(RVA = "0x85B0C0", Offset = "0x85A2C0", VA = "0x18085B0C0")]
		get
		{
			return default(DuelParam.LOCATE_TYPE);
		}
	}

	[Token(Token = "0x1700082B")]
	public static DuelParam.COMMAND_TYPE commandType
	{
		[Token(Token = "0x6003DCF")]
		[Address(RVA = "0x85AC30", Offset = "0x859E30", VA = "0x18085AC30")]
		get
		{
			return default(DuelParam.COMMAND_TYPE);
		}
	}

	[Token(Token = "0x1700082C")]
	public static bool autoPlay
	{
		[Token(Token = "0x6003DD0")]
		[Address(RVA = "0x85A930", Offset = "0x859B30", VA = "0x18085A930")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700082D")]
	public static bool emote
	{
		[Token(Token = "0x6003DD1")]
		[Address(RVA = "0x85AF90", Offset = "0x85A190", VA = "0x18085AF90")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700082E")]
	public static bool decideActivateOrder
	{
		[Token(Token = "0x6003DD2")]
		[Address(RVA = "0x85AF30", Offset = "0x85A130", VA = "0x18085AF30")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700082F")]
	public static int showCardInfoType
	{
		[Token(Token = "0x6003DD3")]
		[Address(RVA = "0x85B4E0", Offset = "0x85A6E0", VA = "0x18085B4E0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000830")]
	public static bool showAudienceInfo
	{
		[Token(Token = "0x6003DD4")]
		[Address(RVA = "0x85B420", Offset = "0x85A620", VA = "0x18085B420")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000831")]
	public static bool showSetCard
	{
		[Token(Token = "0x6003DD5")]
		[Address(RVA = "0x85B660", Offset = "0x85A860", VA = "0x18085B660")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000832")]
	public static bool showBattleStep
	{
		[Token(Token = "0x6003DD6")]
		[Address(RVA = "0x85B480", Offset = "0x85A680", VA = "0x18085B480")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000833")]
	public static DuelParam.SKIP_TYPE skipSummonEffectType
	{
		[Token(Token = "0x6003DD7")]
		[Address(RVA = "0x85B780", Offset = "0x85A980", VA = "0x18085B780")]
		get
		{
			return default(DuelParam.SKIP_TYPE);
		}
	}

	[Token(Token = "0x17000834")]
	public static DuelParam.SKIP_TYPE skipMonsterCutinType
	{
		[Token(Token = "0x6003DD8")]
		[Address(RVA = "0x85B720", Offset = "0x85A920", VA = "0x18085B720")]
		get
		{
			return default(DuelParam.SKIP_TYPE);
		}
	}

	[Token(Token = "0x17000835")]
	public static DuelParam.SKIP_TYPE skipCardRunEffectType
	{
		[Token(Token = "0x6003DD9")]
		[Address(RVA = "0x85B6C0", Offset = "0x85A8C0", VA = "0x18085B6C0")]
		get
		{
			return default(DuelParam.SKIP_TYPE);
		}
	}

	[Token(Token = "0x17000836")]
	public static bool useConsoleLayout
	{
		[Token(Token = "0x6003DDA")]
		[Address(RVA = "0x85B8A0", Offset = "0x85AAA0", VA = "0x18085B8A0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000837")]
	public static DuelParam.CAMERA_TYPE cameraType
	{
		[Token(Token = "0x6003DDB")]
		[Address(RVA = "0x85AA50", Offset = "0x859C50", VA = "0x18085AA50")]
		get
		{
			return default(DuelParam.CAMERA_TYPE);
		}
	}

	[Token(Token = "0x17000838")]
	public static int showRivalName
	{
		[Token(Token = "0x6003DDC")]
		[Address(RVA = "0x85B600", Offset = "0x85A800", VA = "0x18085B600")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000839")]
	public static int showCardReportType
	{
		[Token(Token = "0x6003DDD")]
		[Address(RVA = "0x85B540", Offset = "0x85A740", VA = "0x18085B540")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700083A")]
	public static int showHappenedEffectType
	{
		[Token(Token = "0x6003DDE")]
		[Address(RVA = "0x85B5A0", Offset = "0x85A7A0", VA = "0x18085B5A0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700083B")]
	public static int cardSelectionListLayoutType
	{
		[Token(Token = "0x6003DDF")]
		[Address(RVA = "0x85AAB0", Offset = "0x859CB0", VA = "0x18085AAB0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700083C")]
	public static int genericCardListLayoutType
	{
		[Token(Token = "0x6003DE0")]
		[Address(RVA = "0x85B000", Offset = "0x85A200", VA = "0x18085B000")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700083D")]
	public static bool customConfirmUseSwitch
	{
		[Token(Token = "0x6003DE1")]
		[Address(RVA = "0x85AE70", Offset = "0x85A070", VA = "0x18085AE70")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700083E")]
	public static DuelParam.CONFIRM_MODE customConfirmDefault
	{
		[Token(Token = "0x6003DE2")]
		[Address(RVA = "0x85AD50", Offset = "0x859F50", VA = "0x18085AD50")]
		get
		{
			return default(DuelParam.CONFIRM_MODE);
		}
	}

	[Token(Token = "0x1700083F")]
	public static DuelParam.CONFIRM_MODE customConfirmHold0
	{
		[Token(Token = "0x6003DE3")]
		[Address(RVA = "0x85ADB0", Offset = "0x859FB0", VA = "0x18085ADB0")]
		get
		{
			return default(DuelParam.CONFIRM_MODE);
		}
	}

	[Token(Token = "0x17000840")]
	public static DuelParam.CONFIRM_MODE customConfirmHold1
	{
		[Token(Token = "0x6003DE4")]
		[Address(RVA = "0x85AE10", Offset = "0x85A010", VA = "0x18085AE10")]
		get
		{
			return default(DuelParam.CONFIRM_MODE);
		}
	}

	[Token(Token = "0x17000841")]
	public static DuelParam.CONFIRM_SWITCH_MODE switchOnTurnEnd
	{
		[Token(Token = "0x6003DE5")]
		[Address(RVA = "0x85B840", Offset = "0x85AA40", VA = "0x18085B840")]
		get
		{
			return default(DuelParam.CONFIRM_SWITCH_MODE);
		}
	}

	[Token(Token = "0x17000842")]
	public static int audienceShowCardInfoType
	{
		[Token(Token = "0x6003DE6")]
		[Address(RVA = "0x85A5D0", Offset = "0x8597D0", VA = "0x18085A5D0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000843")]
	public static bool audienceShowAudienceInfo
	{
		[Token(Token = "0x6003DE7")]
		[Address(RVA = "0x85A510", Offset = "0x859710", VA = "0x18085A510")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000844")]
	public static bool audienceShowSetCard
	{
		[Token(Token = "0x6003DE8")]
		[Address(RVA = "0x85A750", Offset = "0x859950", VA = "0x18085A750")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000845")]
	public static bool audienceShowBattleStep
	{
		[Token(Token = "0x6003DE9")]
		[Address(RVA = "0x85A570", Offset = "0x859770", VA = "0x18085A570")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000846")]
	public static AudienceParam.SKIP_TYPE audienceSkipSummonEffectType
	{
		[Token(Token = "0x6003DEA")]
		[Address(RVA = "0x85A870", Offset = "0x859A70", VA = "0x18085A870")]
		get
		{
			return default(AudienceParam.SKIP_TYPE);
		}
	}

	[Token(Token = "0x17000847")]
	public static AudienceParam.SKIP_TYPE audienceSkipMonsterCutinType
	{
		[Token(Token = "0x6003DEB")]
		[Address(RVA = "0x85A810", Offset = "0x859A10", VA = "0x18085A810")]
		get
		{
			return default(AudienceParam.SKIP_TYPE);
		}
	}

	[Token(Token = "0x17000848")]
	public static AudienceParam.SKIP_TYPE audienceSkipCardRunEffectType
	{
		[Token(Token = "0x6003DEC")]
		[Address(RVA = "0x85A7B0", Offset = "0x8599B0", VA = "0x18085A7B0")]
		get
		{
			return default(AudienceParam.SKIP_TYPE);
		}
	}

	[Token(Token = "0x17000849")]
	public static bool audienceUseConsoleLayout
	{
		[Token(Token = "0x6003DED")]
		[Address(RVA = "0x85A8D0", Offset = "0x859AD0", VA = "0x18085A8D0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700084A")]
	public static AudienceParam.CAMERA_TYPE audienceCameraType
	{
		[Token(Token = "0x6003DEE")]
		[Address(RVA = "0x85A450", Offset = "0x859650", VA = "0x18085A450")]
		get
		{
			return default(AudienceParam.CAMERA_TYPE);
		}
	}

	[Token(Token = "0x1700084B")]
	public static int audienceShowRivalName
	{
		[Token(Token = "0x6003DEF")]
		[Address(RVA = "0x85A6F0", Offset = "0x8598F0", VA = "0x18085A6F0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700084C")]
	public static int audienceShowCardReportType
	{
		[Token(Token = "0x6003DF0")]
		[Address(RVA = "0x85A630", Offset = "0x859830", VA = "0x18085A630")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700084D")]
	public static int audienceShowHappenedEffectType
	{
		[Token(Token = "0x6003DF1")]
		[Address(RVA = "0x85A690", Offset = "0x859890", VA = "0x18085A690")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700084E")]
	public static int audienceGenericCardListLayoutType
	{
		[Token(Token = "0x6003DF2")]
		[Address(RVA = "0x85A4B0", Offset = "0x8596B0", VA = "0x18085A4B0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700084F")]
	public static bool isUseLightImages
	{
		[Token(Token = "0x6003E0E")]
		[Address(RVA = "0x85B060", Offset = "0x85A260", VA = "0x18085B060")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003E0D")]
		[Address(RVA = "0x85BA20", Offset = "0x85AC20", VA = "0x18085BA20")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x6003DBF")]
	[Address(RVA = "0x859C20", Offset = "0x858E20", VA = "0x180859C20")]
	public static int VolumeBySoundMaster(Sound.Master soundMaster)
	{
		return default(int);
	}

	[Token(Token = "0x6003DF3")]
	[Address(RVA = "0x8577C0", Offset = "0x8569C0", VA = "0x1808577C0")]
	public static void SaveSettings()
	{
	}

	[Token(Token = "0x6003DF4")]
	[Address(RVA = "0x857930", Offset = "0x856B30", VA = "0x180857930")]
	public static void SaveSettings(SoundParam soundParam)
	{
	}

	[Token(Token = "0x6003DF5")]
	[Address(RVA = "0x8595E0", Offset = "0x8587E0", VA = "0x1808595E0")]
	public static void SaveSettings(DuelParam duelParam, SoundParam soundParam)
	{
	}

	[Token(Token = "0x6003DF6")]
	[Address(RVA = "0x857640", Offset = "0x856840", VA = "0x180857640")]
	public static void SaveSettings(SystemParam systemParam)
	{
	}

	[Token(Token = "0x6003DF7")]
	[Address(RVA = "0x857AA0", Offset = "0x856CA0", VA = "0x180857AA0")]
	public static void SaveSettings(DuelParam duelParam, SoundParam soundParam, BasicParam basicParam, SystemParam systemParam, AudienceParam audienceParam)
	{
	}

	[Token(Token = "0x6003DF8")]
	[Address(RVA = "0x853A80", Offset = "0x852C80", VA = "0x180853A80")]
	public static void InitializeSettings()
	{
	}

	[Token(Token = "0x6003DF9")]
	[Address(RVA = "0x84EB00", Offset = "0x84DD00", VA = "0x18084EB00")]
	public static void ApplySettings(bool isDirtyQuality = true)
	{
	}

	[Token(Token = "0x6003DFA")]
	[Address(RVA = "0x8541F0", Offset = "0x8533F0", VA = "0x1808541F0")]
	public static void OnUpdateSettingsJsonData(object obj)
	{
	}

	[Token(Token = "0x6003DFB")]
	[Address(RVA = "0x84F0B0", Offset = "0x84E2B0", VA = "0x18084F0B0")]
	public static void ApplyVolumeBGM(float volume)
	{
	}

	[Token(Token = "0x6003DFC")]
	[Address(RVA = "0x84F130", Offset = "0x84E330", VA = "0x18084F130")]
	public static void ApplyVolumeSE(float volume)
	{
	}

	[Token(Token = "0x6003DFD")]
	[Address(RVA = "0x84F1C0", Offset = "0x84E3C0", VA = "0x18084F1C0")]
	public static void ApplyVolumeVoice(float volume)
	{
	}

	[Token(Token = "0x6003DFE")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public static void ApplyVolumeMovie(float volume)
	{
	}

	[Token(Token = "0x6003DFF")]
	[Address(RVA = "0x859760", Offset = "0x858960", VA = "0x180859760")]
	public static void SetPerformance(int param)
	{
	}

	[Token(Token = "0x6003E00")]
	[Address(RVA = "0x852690", Offset = "0x851890", VA = "0x180852690")]
	public static int GetPerformanceParamByLevel(int level)
	{
		return default(int);
	}

	[Token(Token = "0x6003E01")]
	[Address(RVA = "0x851DF0", Offset = "0x850FF0", VA = "0x180851DF0")]
	public static int GetLevelByPerformance(float param)
	{
		return default(int);
	}

	[Token(Token = "0x6003E02")]
	[Address(RVA = "0x8598C0", Offset = "0x858AC0", VA = "0x1808598C0")]
	public static void SetQuality(BasicParam.QUALITY quality)
	{
	}

	[Token(Token = "0x6003E03")]
	[Address(RVA = "0x851FF0", Offset = "0x8511F0", VA = "0x180851FF0")]
	public static int GetMSAA()
	{
		return default(int);
	}

	[Token(Token = "0x6003E04")]
	[Address(RVA = "0x8502D0", Offset = "0x84F4D0", VA = "0x1808502D0")]
	public static CardQuality GetCardQuality()
	{
		return default(CardQuality);
	}

	[Token(Token = "0x6003E05")]
	[Address(RVA = "0x852420", Offset = "0x851620", VA = "0x180852420")]
	public static int GetNumSelectableResolutions()
	{
		return default(int);
	}

	[Token(Token = "0x6003E06")]
	[Address(RVA = "0x8529B0", Offset = "0x851BB0", VA = "0x1808529B0")]
	public static (int, int) GetResolutionWH(int resolution, BasicParam.QUALITY quality, int customResolution)
	{
		return default((int, int));
	}

	[Token(Token = "0x6003E07")]
	[Address(RVA = "0x859B80", Offset = "0x858D80", VA = "0x180859B80")]
	public static void SetResolution(int width, int height)
	{
	}

	[Token(Token = "0x6003E08")]
	[Address(RVA = "0x851710", Offset = "0x850910", VA = "0x180851710")]
	public static List<int> GetCustomResolutionHeight()
	{
		return null;
	}

	[Token(Token = "0x6003E09")]
	[Address(RVA = "0x84EAB0", Offset = "0x84DCB0", VA = "0x18084EAB0")]
	[IteratorStateMachine(typeof(_003CAdjustResolution_003Ed__165))]
	private static IEnumerator AdjustResolution()
	{
		return null;
	}

	[Token(Token = "0x6003E0A")]
	[Address(RVA = "0x859750", Offset = "0x858950", VA = "0x180859750")]
	public static void SetFullScreen(bool isFullScreen)
	{
	}

	[Token(Token = "0x6003E0B")]
	[Address(RVA = "0x854170", Offset = "0x853370", VA = "0x180854170")]
	public static bool IsChatSettingEnable()
	{
		return default(bool);
	}

	[Token(Token = "0x6003E0C")]
	[Address(RVA = "0x859BD0", Offset = "0x858DD0", VA = "0x180859BD0")]
	public static void SetVibration(bool vibration)
	{
	}

	[Token(Token = "0x6003E0F")]
	[Address(RVA = "0x854230", Offset = "0x853430", VA = "0x180854230")]
	public static void ResetCache()
	{
	}

	[Token(Token = "0x6003E10")]
	[Address(RVA = "0x850080", Offset = "0x84F280", VA = "0x180850080")]
	private static int GetBgmVolume()
	{
		return default(int);
	}

	[Token(Token = "0x6003E11")]
	[Address(RVA = "0x852BD0", Offset = "0x851DD0", VA = "0x180852BD0")]
	private static int GetSeVolume()
	{
		return default(int);
	}

	[Token(Token = "0x6003E12")]
	[Address(RVA = "0x8539F0", Offset = "0x852BF0", VA = "0x1808539F0")]
	private static int GetVoiceVolume()
	{
		return default(int);
	}

	[Token(Token = "0x6003E13")]
	[Address(RVA = "0x852340", Offset = "0x851540", VA = "0x180852340")]
	private static int GetMovieVolume()
	{
		return default(int);
	}

	[Token(Token = "0x6003E14")]
	[Address(RVA = "0x84FFF0", Offset = "0x84F1F0", VA = "0x18084FFF0")]
	private static bool GetBgmMute()
	{
		return default(bool);
	}

	[Token(Token = "0x6003E15")]
	[Address(RVA = "0x852B40", Offset = "0x851D40", VA = "0x180852B40")]
	private static bool GetSeMute()
	{
		return default(bool);
	}

	[Token(Token = "0x6003E16")]
	[Address(RVA = "0x853960", Offset = "0x852B60", VA = "0x180853960")]
	private static bool GetVoiceMute()
	{
		return default(bool);
	}

	[Token(Token = "0x6003E17")]
	[Address(RVA = "0x8526D0", Offset = "0x8518D0", VA = "0x1808526D0")]
	private static int GetPerformance()
	{
		return default(int);
	}

	[Token(Token = "0x6003E18")]
	[Address(RVA = "0x8527F0", Offset = "0x8519F0", VA = "0x1808527F0")]
	private static BasicParam.QUALITY GetQuality()
	{
		return default(BasicParam.QUALITY);
	}

	[Token(Token = "0x6003E19")]
	[Address(RVA = "0x850DC0", Offset = "0x84FFC0", VA = "0x180850DC0")]
	private static BasicParam.ANTI_ALIASING GetCustomAntiAliasing()
	{
		return default(BasicParam.ANTI_ALIASING);
	}

	[Token(Token = "0x6003E1A")]
	[Address(RVA = "0x850F80", Offset = "0x850180", VA = "0x180850F80")]
	private static BasicParam.CARD_QUALITY GetCustomCardQuality()
	{
		return default(BasicParam.CARD_QUALITY);
	}

	[Token(Token = "0x6003E1B")]
	[Address(RVA = "0x851BA0", Offset = "0x850DA0", VA = "0x180851BA0")]
	private static int GetCustomResolution()
	{
		return default(int);
	}

	[Token(Token = "0x6003E1C")]
	[Address(RVA = "0x852AB0", Offset = "0x851CB0", VA = "0x180852AB0")]
	private static int GetResolution()
	{
		return default(int);
	}

	[Token(Token = "0x6003E1D")]
	[Address(RVA = "0x850730", Offset = "0x84F930", VA = "0x180850730")]
	private static BasicParam.CARD_TEXT_SIZE GetCardTextSize()
	{
		return default(BasicParam.CARD_TEXT_SIZE);
	}

	[Token(Token = "0x6003E1E")]
	[Address(RVA = "0x8538D0", Offset = "0x852AD0", VA = "0x1808538D0")]
	private static bool GetVibration()
	{
		return default(bool);
	}

	[Token(Token = "0x6003E1F")]
	[Address(RVA = "0x850AB0", Offset = "0x84FCB0", VA = "0x180850AB0")]
	private static bool GetChat()
	{
		return default(bool);
	}

	[Token(Token = "0x6003E20")]
	[Address(RVA = "0x852760", Offset = "0x851960", VA = "0x180852760")]
	private static bool GetPushNotyfy()
	{
		return default(bool);
	}

	[Token(Token = "0x6003E21")]
	[Address(RVA = "0x8535E0", Offset = "0x8527E0", VA = "0x1808535E0")]
	private static bool GetSurveyReservation()
	{
		return default(bool);
	}

	[Token(Token = "0x6003E22")]
	[Address(RVA = "0x8508F0", Offset = "0x84FAF0", VA = "0x1808508F0")]
	private static DuelParam.CHAIN_TYPE GetChainType()
	{
		return default(DuelParam.CHAIN_TYPE);
	}

	[Token(Token = "0x6003E23")]
	[Address(RVA = "0x852180", Offset = "0x851380", VA = "0x180852180")]
	private static DuelParam.MANUAL_TYPE GetManualType()
	{
		return default(DuelParam.MANUAL_TYPE);
	}

	[Token(Token = "0x6003E24")]
	[Address(RVA = "0x851E30", Offset = "0x851030", VA = "0x180851E30")]
	private static DuelParam.LOCATE_TYPE GetLocateType()
	{
		return default(DuelParam.LOCATE_TYPE);
	}

	[Token(Token = "0x6003E25")]
	[Address(RVA = "0x850C00", Offset = "0x84FE00", VA = "0x180850C00")]
	private static DuelParam.COMMAND_TYPE GetCommandType()
	{
		return default(DuelParam.COMMAND_TYPE);
	}

	[Token(Token = "0x6003E26")]
	[Address(RVA = "0x851CC0", Offset = "0x850EC0", VA = "0x180851CC0")]
	private static bool GetEmote()
	{
		return default(bool);
	}

	[Token(Token = "0x6003E27")]
	[Address(RVA = "0x84FF60", Offset = "0x84F160", VA = "0x18084FF60")]
	private static bool GetAutoPlay()
	{
		return default(bool);
	}

	[Token(Token = "0x6003E28")]
	[Address(RVA = "0x851C30", Offset = "0x850E30", VA = "0x180851C30")]
	private static bool GetDecideActivateOrder()
	{
		return default(bool);
	}

	[Token(Token = "0x6003E29")]
	[Address(RVA = "0x852D80", Offset = "0x851F80", VA = "0x180852D80")]
	private static int GetShowCardInfoType()
	{
		return default(int);
	}

	[Token(Token = "0x6003E2A")]
	[Address(RVA = "0x852C60", Offset = "0x851E60", VA = "0x180852C60")]
	private static bool GetShowAudienceInfo()
	{
		return default(bool);
	}

	[Token(Token = "0x6003E2B")]
	[Address(RVA = "0x853000", Offset = "0x852200", VA = "0x180853000")]
	private static bool GetShowSetCard()
	{
		return default(bool);
	}

	[Token(Token = "0x6003E2C")]
	[Address(RVA = "0x852CF0", Offset = "0x851EF0", VA = "0x180852CF0")]
	private static bool GetShowBattleStep()
	{
		return default(bool);
	}

	[Token(Token = "0x6003E2D")]
	[Address(RVA = "0x853410", Offset = "0x852610", VA = "0x180853410")]
	private static DuelParam.SKIP_TYPE GetSkipSummonEffectType()
	{
		return default(DuelParam.SKIP_TYPE);
	}

	[Token(Token = "0x6003E2E")]
	[Address(RVA = "0x853250", Offset = "0x852450", VA = "0x180853250")]
	private static DuelParam.SKIP_TYPE GetSkipMonsterCutinType()
	{
		return default(DuelParam.SKIP_TYPE);
	}

	[Token(Token = "0x6003E2F")]
	[Address(RVA = "0x853090", Offset = "0x852290", VA = "0x180853090")]
	private static DuelParam.SKIP_TYPE GetSkipCardRunEffectType()
	{
		return default(DuelParam.SKIP_TYPE);
	}

	[Token(Token = "0x6003E30")]
	[Address(RVA = "0x853830", Offset = "0x852A30", VA = "0x180853830")]
	private static bool GetUseConsoleLayout()
	{
		return default(bool);
	}

	[Token(Token = "0x6003E31")]
	[Address(RVA = "0x850110", Offset = "0x84F310", VA = "0x180850110")]
	private static DuelParam.CAMERA_TYPE GetCameraType()
	{
		return default(DuelParam.CAMERA_TYPE);
	}

	[Token(Token = "0x6003E32")]
	[Address(RVA = "0x852F60", Offset = "0x852160", VA = "0x180852F60")]
	private static int GetShowRivalName()
	{
		return default(int);
	}

	[Token(Token = "0x6003E33")]
	[Address(RVA = "0x852E20", Offset = "0x852020", VA = "0x180852E20")]
	private static int GetShowCardReportType()
	{
		return default(int);
	}

	[Token(Token = "0x6003E34")]
	[Address(RVA = "0x852EC0", Offset = "0x8520C0", VA = "0x180852EC0")]
	private static int GetShowHappenedEffectType()
	{
		return default(int);
	}

	[Token(Token = "0x6003E35")]
	[Address(RVA = "0x850690", Offset = "0x84F890", VA = "0x180850690")]
	private static int GetCardSelectionListLayoutType()
	{
		return default(int);
	}

	[Token(Token = "0x6003E36")]
	[Address(RVA = "0x851D50", Offset = "0x850F50", VA = "0x180851D50")]
	private static int GetGenericCardListLayoutType()
	{
		return default(int);
	}

	[Token(Token = "0x6003E37")]
	[Address(RVA = "0x851680", Offset = "0x850880", VA = "0x180851680")]
	private static bool GetCustomConfirmUseSwitch()
	{
		return default(bool);
	}

	[Token(Token = "0x6003E38")]
	[Address(RVA = "0x851140", Offset = "0x850340", VA = "0x180851140")]
	private static DuelParam.CONFIRM_MODE GetCustomConfirmDefault()
	{
		return default(DuelParam.CONFIRM_MODE);
	}

	[Token(Token = "0x6003E39")]
	[Address(RVA = "0x851300", Offset = "0x850500", VA = "0x180851300")]
	private static DuelParam.CONFIRM_MODE GetCustomConfirmHold0()
	{
		return default(DuelParam.CONFIRM_MODE);
	}

	[Token(Token = "0x6003E3A")]
	[Address(RVA = "0x8514C0", Offset = "0x8506C0", VA = "0x1808514C0")]
	private static DuelParam.CONFIRM_MODE GetCustomConfirmHold1()
	{
		return default(DuelParam.CONFIRM_MODE);
	}

	[Token(Token = "0x6003E3B")]
	[Address(RVA = "0x853670", Offset = "0x852870", VA = "0x180853670")]
	private static DuelParam.CONFIRM_SWITCH_MODE GetSwitchOnTurnEnd()
	{
		return default(DuelParam.CONFIRM_SWITCH_MODE);
	}

	[Token(Token = "0x6003E3C")]
	[Address(RVA = "0x84F6F0", Offset = "0x84E8F0", VA = "0x18084F6F0")]
	private static int GetAudienceShowCardInfoType()
	{
		return default(int);
	}

	[Token(Token = "0x6003E3D")]
	[Address(RVA = "0x84F5B0", Offset = "0x84E7B0", VA = "0x18084F5B0")]
	private static bool GetAudienceShowAudienceInfo()
	{
		return default(bool);
	}

	[Token(Token = "0x6003E3E")]
	[Address(RVA = "0x84F510", Offset = "0x84E710", VA = "0x18084F510")]
	private static bool GetAudienceSetCard()
	{
		return default(bool);
	}

	[Token(Token = "0x6003E3F")]
	[Address(RVA = "0x84F650", Offset = "0x84E850", VA = "0x18084F650")]
	private static bool GetAudienceShowBattleStep()
	{
		return default(bool);
	}

	[Token(Token = "0x6003E40")]
	[Address(RVA = "0x84FCF0", Offset = "0x84EEF0", VA = "0x18084FCF0")]
	private static AudienceParam.SKIP_TYPE GetAudienceSkipSummonEffectType()
	{
		return default(AudienceParam.SKIP_TYPE);
	}

	[Token(Token = "0x6003E41")]
	[Address(RVA = "0x84FB30", Offset = "0x84ED30", VA = "0x18084FB30")]
	private static AudienceParam.SKIP_TYPE GetAudienceSkipMonsterCutinType()
	{
		return default(AudienceParam.SKIP_TYPE);
	}

	[Token(Token = "0x6003E42")]
	[Address(RVA = "0x84F970", Offset = "0x84EB70", VA = "0x18084F970")]
	private static AudienceParam.SKIP_TYPE GetAudienceSkipCardRunEffectType()
	{
		return default(AudienceParam.SKIP_TYPE);
	}

	[Token(Token = "0x6003E43")]
	[Address(RVA = "0x84FEC0", Offset = "0x84F0C0", VA = "0x18084FEC0")]
	private static bool GetAudienceUseConsoleLayout()
	{
		return default(bool);
	}

	[Token(Token = "0x6003E44")]
	[Address(RVA = "0x84F2B0", Offset = "0x84E4B0", VA = "0x18084F2B0")]
	private static AudienceParam.CAMERA_TYPE GetAudienceCameraType()
	{
		return default(AudienceParam.CAMERA_TYPE);
	}

	[Token(Token = "0x6003E45")]
	[Address(RVA = "0x84F8D0", Offset = "0x84EAD0", VA = "0x18084F8D0")]
	private static int GetAudienceShowRivalName()
	{
		return default(int);
	}

	[Token(Token = "0x6003E46")]
	[Address(RVA = "0x84F790", Offset = "0x84E990", VA = "0x18084F790")]
	private static int GetAudienceShowCardReportType()
	{
		return default(int);
	}

	[Token(Token = "0x6003E47")]
	[Address(RVA = "0x84F830", Offset = "0x84EA30", VA = "0x18084F830")]
	private static int GetAudienceShowHappenedEfectType()
	{
		return default(int);
	}

	[Token(Token = "0x6003E48")]
	[Address(RVA = "0x84F470", Offset = "0x84E670", VA = "0x18084F470")]
	private static int GetAudienceGenericCardListLayoutType()
	{
		return default(int);
	}

	[Token(Token = "0x6003E49")]
	[Address(RVA = "0x84F250", Offset = "0x84E450", VA = "0x18084F250")]
	public static void ClearAllSettings()
	{
	}

	[Token(Token = "0x6003E4A")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public SettingsUtil()
	{
	}
}
