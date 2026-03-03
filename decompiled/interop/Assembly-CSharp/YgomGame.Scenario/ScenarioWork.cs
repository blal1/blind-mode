using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using YgomGame.Utility;
using YgomSystem.Utility;

namespace YgomGame.Scenario;

[Token(Token = "0x2000AD5")]
public class ScenarioWork
{
	[Token(Token = "0x40093FC")]
	[FieldOffset(Offset = "0x10")]
	public AssetContainer assetContainer;

	[Token(Token = "0x40093FD")]
	[FieldOffset(Offset = "0x18")]
	public DefinitionSetting definitionSetting;

	[Token(Token = "0x40093FE")]
	[FieldOffset(Offset = "0x20")]
	private float m_BeforeBGMFadeOut;

	[Token(Token = "0x40093FF")]
	[FieldOffset(Offset = "0x24")]
	private float m_OnCloseVoiceFadeOut;

	[Token(Token = "0x4009400")]
	[FieldOffset(Offset = "0x28")]
	private float m_HideMenuByAutoSec;

	[Token(Token = "0x4009401")]
	[FieldOffset(Offset = "0x2C")]
	public float autoProgressUnitSec;

	[Token(Token = "0x4009402")]
	[FieldOffset(Offset = "0x30")]
	public float autoProgressWaitClickSec;

	[Token(Token = "0x4009403")]
	[FieldOffset(Offset = "0x34")]
	public float titleVoiceDelaySec;

	[Token(Token = "0x4009404")]
	[FieldOffset(Offset = "0x38")]
	public float titleVoiceMarginSec;

	[Token(Token = "0x4009405")]
	[FieldOffset(Offset = "0x3C")]
	public float sequenceVoiceMarginSec;

	[Token(Token = "0x4009406")]
	[FieldOffset(Offset = "0x40")]
	private float m_TitleDuration;

	[Token(Token = "0x4009407")]
	[FieldOffset(Offset = "0x44")]
	public float startFadeOutDuration;

	[Token(Token = "0x4009408")]
	[FieldOffset(Offset = "0x48")]
	public float startFadeInDuration;

	[Token(Token = "0x4009409")]
	[FieldOffset(Offset = "0x4C")]
	public float endFadeOutDuration;

	[Token(Token = "0x400940A")]
	[FieldOffset(Offset = "0x50")]
	public float endFadeInDuration;

	[Token(Token = "0x400940B")]
	[FieldOffset(Offset = "0x58")]
	private ScenarioCardContainer.InitializeData m_CardInitializeData;

	[Token(Token = "0x400940C")]
	[FieldOffset(Offset = "0x60")]
	private ScenarioBGActor.Setting m_BGSetting;

	[Token(Token = "0x400940D")]
	[FieldOffset(Offset = "0x68")]
	private ScenarioObjectContainer m_ObjectContainer;

	[Token(Token = "0x400940E")]
	[FieldOffset(Offset = "0x70")]
	private ScenarioLoadGroupContainer m_LoadGropuContainer;

	[Token(Token = "0x400940F")]
	[FieldOffset(Offset = "0x78")]
	private readonly List<string> m_LoadedTextGroupIds;

	[Token(Token = "0x4009410")]
	[FieldOffset(Offset = "0x80")]
	private bool m_IsAuto;

	[Token(Token = "0x4009411")]
	[FieldOffset(Offset = "0x81")]
	private bool m_IsAutoHide;

	[Token(Token = "0x4009412")]
	[FieldOffset(Offset = "0x82")]
	private bool m_IsFullScreen;

	[Token(Token = "0x4009413")]
	[FieldOffset(Offset = "0x83")]
	private bool m_IsLog;

	[Token(Token = "0x4009414")]
	[FieldOffset(Offset = "0x84")]
	private bool m_InVolumeEdit;

	[Token(Token = "0x4009415")]
	[FieldOffset(Offset = "0x85")]
	private bool m_Suspend;

	[Token(Token = "0x4009416")]
	[FieldOffset(Offset = "0x86")]
	private bool m_DemoMode;

	[Token(Token = "0x4009418")]
	[FieldOffset(Offset = "0x90")]
	public bool isHideUI;

	[Token(Token = "0x4009419")]
	[FieldOffset(Offset = "0x91")]
	public bool arrowVisible;

	[Token(Token = "0x400941A")]
	[FieldOffset(Offset = "0x98")]
	private readonly ScenarioLocalSave m_LocalSave;

	[Token(Token = "0x400941B")]
	[FieldOffset(Offset = "0xA0")]
	public readonly ScenarioSettingsWrapper settingWrapper;

	[Token(Token = "0x400941C")]
	[FieldOffset(Offset = "0xA8")]
	public bool loadedSoundVoice;

	[Token(Token = "0x400941D")]
	[FieldOffset(Offset = "0xB0")]
	public readonly List<string> playingOnceSeLabels;

	[Token(Token = "0x400941E")]
	[FieldOffset(Offset = "0xB8")]
	public readonly List<string> playingLoopSeLabels;

	[Token(Token = "0x400941F")]
	[FieldOffset(Offset = "0xC0")]
	public List<string> playingTMClipLabels;

	[Token(Token = "0x4009420")]
	[FieldOffset(Offset = "0xC8")]
	public readonly List<string> playingVoiceLabels;

	[Token(Token = "0x170008DC")]
	public float seFadeOutSec
	{
		[Token(Token = "0x60042A4")]
		[Address(RVA = "0x8A9AC0", Offset = "0x8A8CC0", VA = "0x1808A9AC0")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170008DD")]
	public float onTextFilledArrowWaitSec
	{
		[Token(Token = "0x60042A5")]
		[Address(RVA = "0x8A9A20", Offset = "0x8A8C20", VA = "0x1808A9A20")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170008DE")]
	public float onVoiceCompletedArrowWaitSec
	{
		[Token(Token = "0x60042A6")]
		[Address(RVA = "0x8A9A70", Offset = "0x8A8C70", VA = "0x1808A9A70")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170008DF")]
	public string scenarioName
	{
		[Token(Token = "0x60042A7")]
		[Address(RVA = "0x49BEA0", Offset = "0x49B0A0", VA = "0x18049BEA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60042A8")]
		[Address(RVA = "0x457410", Offset = "0x456610", VA = "0x180457410")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170008E0")]
	public bool isAuto
	{
		[Token(Token = "0x60042A9")]
		[Address(RVA = "0x449800", Offset = "0x448A00", VA = "0x180449800")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60042AA")]
		[Address(RVA = "0x8A9E60", Offset = "0x8A9060", VA = "0x1808A9E60")]
		set
		{
		}
	}

	[Token(Token = "0x170008E1")]
	public bool isHideArrow
	{
		[Token(Token = "0x60042AB")]
		[Address(RVA = "0x8A9950", Offset = "0x8A8B50", VA = "0x1808A9950")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170008E2")]
	public bool isLog
	{
		[Token(Token = "0x60042AC")]
		[Address(RVA = "0x6ABE80", Offset = "0x6AB080", VA = "0x1806ABE80")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60042AD")]
		[Address(RVA = "0x6AC1F0", Offset = "0x6AB3F0", VA = "0x1806AC1F0")]
		set
		{
		}
	}

	[Token(Token = "0x170008E3")]
	public bool isAutoHide
	{
		[Token(Token = "0x60042AE")]
		[Address(RVA = "0x4497F0", Offset = "0x4489F0", VA = "0x1804497F0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60042AF")]
		[Address(RVA = "0x449840", Offset = "0x448A40", VA = "0x180449840")]
		set
		{
		}
	}

	[Token(Token = "0x170008E4")]
	public bool isShowSubtitle
	{
		[Token(Token = "0x60042B0")]
		[Address(RVA = "0x8A99A0", Offset = "0x8A8BA0", VA = "0x1808A99A0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60042B1")]
		[Address(RVA = "0x8A9FE0", Offset = "0x8A91E0", VA = "0x1808A9FE0")]
		set
		{
		}
	}

	[Token(Token = "0x170008E5")]
	public bool isShowSubtitleMovie
	{
		[Token(Token = "0x60042B2")]
		[Address(RVA = "0x8A9970", Offset = "0x8A8B70", VA = "0x1808A9970")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60042B3")]
		[Address(RVA = "0x8A9EB0", Offset = "0x8A90B0", VA = "0x1808A9EB0")]
		set
		{
		}
	}

	[Token(Token = "0x170008E6")]
	public bool isFullScreen
	{
		[Token(Token = "0x60042B4")]
		[Address(RVA = "0x8A9940", Offset = "0x8A8B40", VA = "0x1808A9940")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60042B5")]
		[Address(RVA = "0x8A9EA0", Offset = "0x8A90A0", VA = "0x1808A9EA0")]
		set
		{
		}
	}

	[Token(Token = "0x170008E7")]
	public bool inVolumeEdit
	{
		[Token(Token = "0x60042B6")]
		[Address(RVA = "0x8A9920", Offset = "0x8A8B20", VA = "0x1808A9920")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60042B7")]
		[Address(RVA = "0x8A9E30", Offset = "0x8A9030", VA = "0x1808A9E30")]
		set
		{
		}
	}

	[Token(Token = "0x170008E8")]
	public bool isSuspend
	{
		[Token(Token = "0x60042B8")]
		[Address(RVA = "0x8A99D0", Offset = "0x8A8BD0", VA = "0x1808A99D0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60042B9")]
		[Address(RVA = "0x8AA110", Offset = "0x8A9310", VA = "0x1808AA110")]
		set
		{
		}
	}

	[Token(Token = "0x170008E9")]
	public bool isDemoMode
	{
		[Token(Token = "0x60042BA")]
		[Address(RVA = "0x8A9930", Offset = "0x8A8B30", VA = "0x1808A9930")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60042BB")]
		[Address(RVA = "0x8A9E90", Offset = "0x8A9090", VA = "0x1808A9E90")]
		set
		{
		}
	}

	[Token(Token = "0x170008EA")]
	public float beforeBGMFadeOut
	{
		[Token(Token = "0x60042BC")]
		[Address(RVA = "0x64BF80", Offset = "0x64B180", VA = "0x18064BF80")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170008EB")]
	public float onCloseVoiceFadeOut
	{
		[Token(Token = "0x60042BD")]
		[Address(RVA = "0x64A0A0", Offset = "0x6492A0", VA = "0x18064A0A0")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170008EC")]
	public float autoHideNeedSec
	{
		[Token(Token = "0x60042BE")]
		[Address(RVA = "0x649DB0", Offset = "0x648FB0", VA = "0x180649DB0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60042BF")]
		[Address(RVA = "0x8A9E20", Offset = "0x8A9020", VA = "0x1808A9E20")]
		set
		{
		}
	}

	[Token(Token = "0x170008ED")]
	public float titleDuration
	{
		[Token(Token = "0x60042C0")]
		[Address(RVA = "0x8A9B10", Offset = "0x8A8D10", VA = "0x1808A9B10")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170008EE")]
	public ScenarioObjectContainer objectContainer
	{
		[Token(Token = "0x60042C1")]
		[Address(RVA = "0x49B9F0", Offset = "0x49ABF0", VA = "0x18049B9F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008EF")]
	public ScenarioObjectContainer3D objectContainer3D
	{
		[Token(Token = "0x60042C2")]
		[Address(RVA = "0x8A99E0", Offset = "0x8A8BE0", VA = "0x1808A99E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008F0")]
	public ScenarioObjectContainerUI objectContainerUI
	{
		[Token(Token = "0x60042C3")]
		[Address(RVA = "0x8A9A00", Offset = "0x8A8C00", VA = "0x1808A9A00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008F1")]
	public ScenarioCardContainer.InitializeData cardInitializeData
	{
		[Token(Token = "0x60042C4")]
		[Address(RVA = "0x5EA220", Offset = "0x5E9420", VA = "0x1805EA220")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008F2")]
	public ScenarioBGActor.Setting bgSetting
	{
		[Token(Token = "0x60042C5")]
		[Address(RVA = "0x589E50", Offset = "0x589050", VA = "0x180589E50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008F3")]
	public ScenarioLoadGroupContainer loadGroupContainer
	{
		[Token(Token = "0x60042C6")]
		[Address(RVA = "0x449820", Offset = "0x448A20", VA = "0x180449820")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x14000056")]
	public event Action<bool> onChangeAutoEvent
	{
		[Token(Token = "0x60042C7")]
		[Address(RVA = "0x8A9620", Offset = "0x8A8820", VA = "0x1808A9620")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60042C8")]
		[Address(RVA = "0x8A9B20", Offset = "0x8A8D20", VA = "0x1808A9B20")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000057")]
	public event Action<bool> onChangeShowSubtitleEvent
	{
		[Token(Token = "0x60042C9")]
		[Address(RVA = "0x8A97A0", Offset = "0x8A89A0", VA = "0x1808A97A0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60042CA")]
		[Address(RVA = "0x8A9CA0", Offset = "0x8A8EA0", VA = "0x1808A9CA0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000058")]
	public event Action<bool> onChangeInVolumeEditEvent
	{
		[Token(Token = "0x60042CB")]
		[Address(RVA = "0x8A96E0", Offset = "0x8A88E0", VA = "0x1808A96E0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60042CC")]
		[Address(RVA = "0x8A9BE0", Offset = "0x8A8DE0", VA = "0x1808A9BE0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000059")]
	public event Action<bool> onChangeSuspendEvent
	{
		[Token(Token = "0x60042CD")]
		[Address(RVA = "0x8A9860", Offset = "0x8A8A60", VA = "0x1808A9860")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60042CE")]
		[Address(RVA = "0x8A9D60", Offset = "0x8A8F60", VA = "0x1808A9D60")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x60042CF")]
	[Address(RVA = "0x8A8D20", Offset = "0x8A7F20", VA = "0x1808A8D20")]
	public void Initialize(ScenarioObjectContainer objectContainer, ScenarioLoadGroupContainer loadGroupContainer)
	{
	}

	[Token(Token = "0x60042D0")]
	[Address(RVA = "0x8A9380", Offset = "0x8A8580", VA = "0x1808A9380")]
	public void WriteEndFadeOutDurationAsSkip()
	{
	}

	[Token(Token = "0x60042D1")]
	[Address(RVA = "0x3D77E0", Offset = "0x3D69E0", VA = "0x1803D77E0")]
	public void OnCreatedLoadPacker(ScenarioLoadGroupContainer loadPacker)
	{
	}

	[Token(Token = "0x60042D2")]
	[Address(RVA = "0x8A89C0", Offset = "0x8A7BC0", VA = "0x1808A89C0")]
	public void AssignTMSoundLabel(List<string> tmSoundLabels)
	{
	}

	[Token(Token = "0x60042D3")]
	[Address(RVA = "0x8A8B50", Offset = "0x8A7D50", VA = "0x1808A8B50")]
	public string GetTextWidthLoadCheck(string text)
	{
		return null;
	}

	[Token(Token = "0x60042D4")]
	[Address(RVA = "0x8A9260", Offset = "0x8A8460", VA = "0x1808A9260")]
	public void UnloadTextGroups()
	{
	}

	[Token(Token = "0x60042D5")]
	[Address(RVA = "0x8A9240", Offset = "0x8A8440", VA = "0x1808A9240")]
	public void SaveLocalSetting()
	{
	}

	[Token(Token = "0x60042D6")]
	[Address(RVA = "0x8A93D0", Offset = "0x8A85D0", VA = "0x1808A93D0")]
	public ScenarioWork()
	{
	}
}
