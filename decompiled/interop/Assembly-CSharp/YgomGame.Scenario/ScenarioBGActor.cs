using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.Timeline;

namespace YgomGame.Scenario;

[Token(Token = "0x2000A55")]
[DisallowMultipleComponent]
[RequireComponent(typeof(RawImage))]
public class ScenarioBGActor : MonoBehaviour
{
	[Token(Token = "0x2000A56")]
	public class Setting
	{
		[Token(Token = "0x4009184")]
		[FieldOffset(Offset = "0x10")]
		public ElementObjectManager titlePref;

		[NonSerialized]
		[Token(Token = "0x4009185")]
		[FieldOffset(Offset = "0x18")]
		public Vector2Int bgRenderSize;

		[NonSerialized]
		[Token(Token = "0x4009186")]
		[FieldOffset(Offset = "0x20")]
		public Vector2Int bgRenderSizeFull;

		[Token(Token = "0x6003F8A")]
		[Address(RVA = "0x87A1D0", Offset = "0x8793D0", VA = "0x18087A1D0")]
		public Setting()
		{
		}
	}

	[Token(Token = "0x4009177")]
	[FieldOffset(Offset = "0x20")]
	private RawImage m_RawImageCache;

	[Token(Token = "0x4009178")]
	[FieldOffset(Offset = "0x28")]
	private string m_BgPath;

	[Token(Token = "0x4009179")]
	[FieldOffset(Offset = "0x30")]
	private bool m_LoadingBg;

	[Token(Token = "0x400917A")]
	[FieldOffset(Offset = "0x31")]
	private bool m_IsError;

	[Token(Token = "0x400917B")]
	[FieldOffset(Offset = "0x38")]
	private ScenarioBGLoader.BgGeneratedResource m_BgGeneratedResource;

	[Token(Token = "0x400917C")]
	[FieldOffset(Offset = "0x40")]
	private Vector3 m_ScreenMinPos;

	[Token(Token = "0x400917D")]
	[FieldOffset(Offset = "0x4C")]
	private Vector3 m_ScreenMaxPos;

	[Token(Token = "0x400917E")]
	[FieldOffset(Offset = "0x58")]
	private float m_ScreenScale;

	[Token(Token = "0x400917F")]
	[FieldOffset(Offset = "0x5C")]
	private Vector3 m_OffsetScale;

	[Token(Token = "0x4009180")]
	[FieldOffset(Offset = "0x68")]
	private bool m_Capture;

	[Token(Token = "0x4009181")]
	[FieldOffset(Offset = "0x70")]
	private Setting m_BgSetting;

	[Token(Token = "0x4009182")]
	[FieldOffset(Offset = "0x78")]
	private ScenarioBGLoader m_BGLoader;

	[Token(Token = "0x4009183")]
	[FieldOffset(Offset = "0x80")]
	private readonly Vector3 m_ShakerCenter;

	[Token(Token = "0x1700085F")]
	public object renderTarget
	{
		[Token(Token = "0x6003F66")]
		[Address(RVA = "0x866EC0", Offset = "0x8660C0", VA = "0x180866EC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000860")]
	public RawImage rawImage
	{
		[Token(Token = "0x6003F67")]
		[Address(RVA = "0x866E30", Offset = "0x866030", VA = "0x180866E30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000861")]
	public bool isReady
	{
		[Token(Token = "0x6003F68")]
		[Address(RVA = "0x866DE0", Offset = "0x865FE0", VA = "0x180866DE0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000862")]
	public bool isError
	{
		[Token(Token = "0x6003F69")]
		[Address(RVA = "0x5F07F0", Offset = "0x5EF9F0", VA = "0x1805F07F0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000863")]
	public bool isExists
	{
		[Token(Token = "0x6003F6A")]
		[Address(RVA = "0x866DC0", Offset = "0x865FC0", VA = "0x180866DC0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000864")]
	public bool isExistsObj
	{
		[Token(Token = "0x6003F6B")]
		[Address(RVA = "0x866D60", Offset = "0x865F60", VA = "0x180866D60")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000865")]
	public bool visible
	{
		[Token(Token = "0x6003F6C")]
		[Address(RVA = "0x866FA0", Offset = "0x8661A0", VA = "0x180866FA0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003F6D")]
		[Address(RVA = "0x867210", Offset = "0x866410", VA = "0x180867210")]
		set
		{
		}
	}

	[Token(Token = "0x17000866")]
	public Color color
	{
		[Token(Token = "0x6003F6E")]
		[Address(RVA = "0x866CB0", Offset = "0x865EB0", VA = "0x180866CB0")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x6003F6F")]
		[Address(RVA = "0x866FE0", Offset = "0x8661E0", VA = "0x180866FE0")]
		set
		{
		}
	}

	[Token(Token = "0x17000867")]
	public Vector3 offsetScale
	{
		[Token(Token = "0x6003F70")]
		[Address(RVA = "0x866E10", Offset = "0x866010", VA = "0x180866E10")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6003F71")]
		[Address(RVA = "0x867030", Offset = "0x866230", VA = "0x180867030")]
		set
		{
		}
	}

	[Token(Token = "0x17000868")]
	public float screenScale
	{
		[Token(Token = "0x6003F72")]
		[Address(RVA = "0x7DBBC0", Offset = "0x7DADC0", VA = "0x1807DBBC0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6003F73")]
		[Address(RVA = "0x8670F0", Offset = "0x8662F0", VA = "0x1808670F0")]
		set
		{
		}
	}

	[Token(Token = "0x17000869")]
	public Vector3 spritePos
	{
		[Token(Token = "0x6003F74")]
		[Address(RVA = "0x866F20", Offset = "0x866120", VA = "0x180866F20")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6003F75")]
		[Address(RVA = "0x8671B0", Offset = "0x8663B0", VA = "0x1808671B0")]
		set
		{
		}
	}

	[Token(Token = "0x1700086A")]
	public GameObject shakeTarget
	{
		[Token(Token = "0x6003F76")]
		[Address(RVA = "0x866EF0", Offset = "0x8660F0", VA = "0x180866EF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700086B")]
	public LabeledPlayableController labeledPlayableController
	{
		[Token(Token = "0x6003F77")]
		[Address(RVA = "0x866DF0", Offset = "0x865FF0", VA = "0x180866DF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700086C")]
	public ScenarioSoundTrackBinder voiceTrackBinder
	{
		[Token(Token = "0x6003F78")]
		[Address(RVA = "0x866FD0", Offset = "0x8661D0", VA = "0x180866FD0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700086D")]
	public bool hasVoiceClips
	{
		[Token(Token = "0x6003F79")]
		[Address(RVA = "0x866D00", Offset = "0x865F00", VA = "0x180866D00")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700086E")]
	public List<string> tmSoundClips
	{
		[Token(Token = "0x6003F7A")]
		[Address(RVA = "0x866F80", Offset = "0x866180", VA = "0x180866F80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003F7B")]
	[Address(RVA = "0x8666A0", Offset = "0x8658A0", VA = "0x1808666A0")]
	public void SetTitleText(string title)
	{
	}

	[Token(Token = "0x6003F7C")]
	[Address(RVA = "0x8668D0", Offset = "0x865AD0", VA = "0x1808668D0")]
	public void TryActivateFadeoutKeep()
	{
	}

	[Token(Token = "0x6003F7D")]
	[Address(RVA = "0x866370", Offset = "0x865570", VA = "0x180866370")]
	public void Initialize(Setting bgSetting, ScenarioBGLoader bgLoader)
	{
	}

	[Token(Token = "0x6003F7E")]
	[Address(RVA = "0x8663B0", Offset = "0x8655B0", VA = "0x1808663B0")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6003F7F")]
	[Address(RVA = "0x8661F0", Offset = "0x8653F0", VA = "0x1808661F0")]
	private void CheckPositionInScreen()
	{
	}

	[Token(Token = "0x6003F80")]
	[Address(RVA = "0x8664D0", Offset = "0x8656D0", VA = "0x1808664D0")]
	public void LoadBg(string bgPath, bool tryFullSize = false)
	{
	}

	[Token(Token = "0x6003F81")]
	[Address(RVA = "0x865F40", Offset = "0x865140", VA = "0x180865F40")]
	public void CaptureBg(ScenarioBGActor source)
	{
	}

	[Token(Token = "0x6003F82")]
	[Address(RVA = "0x866620", Offset = "0x865820", VA = "0x180866620")]
	public void ReleaseBg()
	{
	}

	[Token(Token = "0x6003F83")]
	[Address(RVA = "0x865CC0", Offset = "0x864EC0", VA = "0x180865CC0")]
	private Vector3 CalcScreenDiffMin()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6003F84")]
	[Address(RVA = "0x865A40", Offset = "0x864C40", VA = "0x180865A40")]
	private Vector3 CalcScreenDiffMax()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6003F85")]
	[Address(RVA = "0x865580", Offset = "0x864780", VA = "0x180865580")]
	private void AdjustPositionInScreen()
	{
	}

	[Token(Token = "0x6003F86")]
	[Address(RVA = "0x865840", Offset = "0x864A40", VA = "0x180865840")]
	public Vector3 CalcDirectionalPos(int direction)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6003F87")]
	[Address(RVA = "0x866300", Offset = "0x865500", VA = "0x180866300")]
	public bool ExistsLabeledTimeline()
	{
		return default(bool);
	}

	[Token(Token = "0x6003F88")]
	[Address(RVA = "0x866C10", Offset = "0x865E10", VA = "0x180866C10")]
	public ScenarioBGActor()
	{
	}
}
