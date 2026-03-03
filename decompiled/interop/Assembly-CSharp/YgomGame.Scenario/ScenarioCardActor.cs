using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using YgomSystem.ElementSystem;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Scenario;

[Token(Token = "0x2000A60")]
public class ScenarioCardActor : ElementWidgetBase
{
	[Token(Token = "0x2000A61")]
	public class TimelineAssets
	{
		[Token(Token = "0x40091D2")]
		[FieldOffset(Offset = "0x10")]
		public TimelineAsset timelineFadeIn;

		[Token(Token = "0x40091D3")]
		[FieldOffset(Offset = "0x18")]
		public TimelineAsset timelineFadeOut;

		[Token(Token = "0x40091D4")]
		[FieldOffset(Offset = "0x20")]
		public TimelineAsset timelineFadeSwap;

		[Token(Token = "0x6004004")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public TimelineAssets()
		{
		}
	}

	[Token(Token = "0x40091C2")]
	internal const string k_ActorProtectorPath = "Protector/<_CARD_ILLUST_>/0001/PMat";

	[Token(Token = "0x40091C3")]
	[FieldOffset(Offset = "0x20")]
	private readonly string k_ELabelBackModel;

	[Token(Token = "0x40091C4")]
	[FieldOffset(Offset = "0x28")]
	private readonly string k_ELabelFrontModel;

	[Token(Token = "0x40091C5")]
	[FieldOffset(Offset = "0x30")]
	private readonly string k_ELabelSubFrontModel;

	[Token(Token = "0x40091C6")]
	[FieldOffset(Offset = "0x38")]
	private readonly string k_ELabelSideModel;

	[Token(Token = "0x40091C7")]
	[FieldOffset(Offset = "0x40")]
	private PlayableDirector m_PlayableDirector;

	[Token(Token = "0x40091C8")]
	[FieldOffset(Offset = "0x48")]
	private TimelineAssets m_TimelineAssets;

	[Token(Token = "0x40091C9")]
	[FieldOffset(Offset = "0x50")]
	private readonly ScenarioCardPopActor m_CardPopActor;

	[Token(Token = "0x40091CA")]
	[FieldOffset(Offset = "0x58")]
	public readonly MeshRenderer frontRenderer;

	[Token(Token = "0x40091CB")]
	[FieldOffset(Offset = "0x60")]
	public readonly MeshRenderer subFrontRenderer;

	[Token(Token = "0x40091CC")]
	[FieldOffset(Offset = "0x68")]
	public readonly MeshRenderer backRenderer;

	[Token(Token = "0x40091CD")]
	[FieldOffset(Offset = "0x70")]
	public readonly MeshRenderer sideRenderer;

	[Token(Token = "0x40091CE")]
	[FieldOffset(Offset = "0x78")]
	private int m_LoadingCnt;

	[Token(Token = "0x17000888")]
	public bool ready
	{
		[Token(Token = "0x6003FE9")]
		[Address(RVA = "0x86AB20", Offset = "0x869D20", VA = "0x18086AB20")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000889")]
	public bool isPlaying
	{
		[Token(Token = "0x6003FEA")]
		[Address(RVA = "0x42D530", Offset = "0x42C730", VA = "0x18042D530")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003FEB")]
		[Address(RVA = "0x42D650", Offset = "0x42C850", VA = "0x18042D650")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700088A")]
	public int mrk
	{
		[Token(Token = "0x6003FEC")]
		[Address(RVA = "0x5889C0", Offset = "0x587BC0", VA = "0x1805889C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6003FED")]
		[Address(RVA = "0x588B20", Offset = "0x587D20", VA = "0x180588B20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700088B")]
	public int subMrk
	{
		[Token(Token = "0x6003FEE")]
		[Address(RVA = "0x4497E0", Offset = "0x4489E0", VA = "0x1804497E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6003FEF")]
		[Address(RVA = "0x449830", Offset = "0x448A30", VA = "0x180449830")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700088C")]
	public ScenarioCardPopActor popActor
	{
		[Token(Token = "0x6003FF0")]
		[Address(RVA = "0x580700", Offset = "0x57F900", VA = "0x180580700")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700088D")]
	public bool isPlayingFadeOut
	{
		[Token(Token = "0x6003FF1")]
		[Address(RVA = "0x86AA80", Offset = "0x869C80", VA = "0x18086AA80")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6003FF2")]
	[Address(RVA = "0x86A670", Offset = "0x869870", VA = "0x18086A670")]
	public ScenarioCardActor(ElementObjectManager eom, ElementObjectManager cardEom, ElementObjectManager popEom, TimelineAssets timelineAssets)
	{
	}

	[Token(Token = "0x6003FF3")]
	[Address(RVA = "0x869F60", Offset = "0x869160", VA = "0x180869F60", Slot = "9")]
	public override void Clear()
	{
	}

	[Token(Token = "0x6003FF4")]
	[Address(RVA = "0x869F30", Offset = "0x869130", VA = "0x180869F30")]
	public void ClearSub()
	{
	}

	[Token(Token = "0x6003FF5")]
	[Address(RVA = "0x869D90", Offset = "0x868F90", VA = "0x180869D90")]
	public void CaptureSub()
	{
	}

	[Token(Token = "0x6003FF6")]
	[Address(RVA = "0x869BC0", Offset = "0x868DC0", VA = "0x180869BC0")]
	public void Binding(int mrk)
	{
	}

	[Token(Token = "0x6003FF7")]
	[Address(RVA = "0x86A2D0", Offset = "0x8694D0", VA = "0x18086A2D0")]
	public void Show()
	{
	}

	[Token(Token = "0x6003FF8")]
	[Address(RVA = "0x86A080", Offset = "0x869280", VA = "0x18086A080")]
	public void Hide()
	{
	}

	[Token(Token = "0x6003FF9")]
	[Address(RVA = "0x86A030", Offset = "0x869230", VA = "0x18086A030")]
	public void HideFront()
	{
	}

	[Token(Token = "0x6003FFA")]
	[Address(RVA = "0x86A240", Offset = "0x869440", VA = "0x18086A240")]
	public void PlayFadeIn()
	{
	}

	[Token(Token = "0x6003FFB")]
	[Address(RVA = "0x86A270", Offset = "0x869470", VA = "0x18086A270")]
	public void PlayFadeOut()
	{
	}

	[Token(Token = "0x6003FFC")]
	[Address(RVA = "0x86A2A0", Offset = "0x8694A0", VA = "0x18086A2A0")]
	public void PlaySwap()
	{
	}

	[Token(Token = "0x6003FFD")]
	[Address(RVA = "0x86A110", Offset = "0x869310", VA = "0x18086A110")]
	private void OnPlayed(PlayableDirector director)
	{
	}

	[Token(Token = "0x6003FFE")]
	[Address(RVA = "0x86A120", Offset = "0x869320", VA = "0x18086A120")]
	private void OnStopped(PlayableDirector director)
	{
	}

	[Token(Token = "0x6003FFF")]
	[Address(RVA = "0x86A400", Offset = "0x869600", VA = "0x18086A400")]
	public void ToBlurTarget()
	{
	}

	[Token(Token = "0x6004000")]
	[Address(RVA = "0x86A460", Offset = "0x869660", VA = "0x18086A460")]
	public void ToIgnoreBlurTarget()
	{
	}
}
