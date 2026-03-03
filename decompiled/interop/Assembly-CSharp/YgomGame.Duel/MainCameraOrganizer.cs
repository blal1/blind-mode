using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace YgomGame.Duel;

[Token(Token = "0x2001A5D")]
public class MainCameraOrganizer : MonoBehaviour
{
	[Token(Token = "0x2001A5E")]
	private enum Step
	{
		[Token(Token = "0x400F2E1")]
		Initializing,
		[Token(Token = "0x400F2E2")]
		DuelCameraWork,
		[Token(Token = "0x400F2E3")]
		ExecBgCamera,
		[Token(Token = "0x400F2E4")]
		EndBgCamera,
		[Token(Token = "0x400F2E5")]
		Idle
	}

	[Token(Token = "0x2001A5F")]
	public enum ViewMode
	{
		[Token(Token = "0x400F2E7")]
		Default,
		[Token(Token = "0x400F2E8")]
		DuelTop,
		[Token(Token = "0x400F2E9")]
		DuelTopInput,
		[Token(Token = "0x400F2EA")]
		Manual,
		[Token(Token = "0x400F2EB")]
		DuelTopFar,
		[Token(Token = "0x400F2EC")]
		DuelTopInputFar
	}

	[Token(Token = "0x400F2B7")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[ColorUsage(false)]
	[Tooltip("背景色の指定（YGO_DEBUG有効に限る）")]
	private Color _backgroundColorDebug;

	[Token(Token = "0x400F2B8")]
	[FieldOffset(Offset = "0x30")]
	private Step step;

	[Token(Token = "0x400F2B9")]
	[FieldOffset(Offset = "0x38")]
	private CameraShaker camShaker;

	[Token(Token = "0x400F2BA")]
	[FieldOffset(Offset = "0x40")]
	private bool shakeSubCamera;

	[Token(Token = "0x400F2BB")]
	[FieldOffset(Offset = "0x48")]
	private IMainCameraOperation externalOperator;

	[Token(Token = "0x400F2BC")]
	[FieldOffset(Offset = "0x50")]
	private float time;

	[Token(Token = "0x400F2BD")]
	[FieldOffset(Offset = "0x58")]
	private Dictionary<ViewMode, CameraViewSetting.ViewInfo> views;

	[Token(Token = "0x400F2BE")]
	[FieldOffset(Offset = "0x60")]
	private ViewMode currentViewMode;

	[Token(Token = "0x400F2BF")]
	[FieldOffset(Offset = "0x64")]
	private Vector3 gameCamShakedPos;

	[Token(Token = "0x400F2C0")]
	[FieldOffset(Offset = "0x70")]
	private Vector3 gameCamPos;

	[Token(Token = "0x400F2C1")]
	[FieldOffset(Offset = "0x7C")]
	private Quaternion gameCamRot;

	[Token(Token = "0x400F2C2")]
	[FieldOffset(Offset = "0x8C")]
	private float gameCamFov;

	[Token(Token = "0x400F2C3")]
	[FieldOffset(Offset = "0x90")]
	private float gameCamNearClip;

	[Token(Token = "0x400F2C4")]
	[FieldOffset(Offset = "0x94")]
	private float gameCamFarClip;

	[Token(Token = "0x400F2C5")]
	[FieldOffset(Offset = "0x98")]
	private Vector3 bgCamEndPos;

	[Token(Token = "0x400F2C6")]
	[FieldOffset(Offset = "0xA4")]
	private Quaternion bgCamEndRot;

	[Token(Token = "0x400F2C7")]
	[FieldOffset(Offset = "0xB4")]
	private float bgCamFov;

	[Token(Token = "0x400F2C8")]
	[FieldOffset(Offset = "0xB8")]
	private float bgCamNearClip;

	[Token(Token = "0x400F2C9")]
	[FieldOffset(Offset = "0xBC")]
	private float bgCamFarClip;

	[Token(Token = "0x400F2CB")]
	[FieldOffset(Offset = "0xC8")]
	private Camera subCamera3D;

	[Token(Token = "0x400F2CC")]
	[FieldOffset(Offset = "0xD0")]
	private Camera subCamera2D;

	[Token(Token = "0x400F2CD")]
	[FieldOffset(Offset = "0xD8")]
	private Camera screenCamera3D;

	[Token(Token = "0x400F2CE")]
	[FieldOffset(Offset = "0xE0")]
	private Camera screenCamera2D;

	[Token(Token = "0x400F2CF")]
	[FieldOffset(Offset = "0xE8")]
	private Camera performCamera3D;

	[Token(Token = "0x400F2D3")]
	[FieldOffset(Offset = "0x108")]
	private AudioListener listener;

	[Token(Token = "0x400F2D6")]
	[FieldOffset(Offset = "0x0")]
	private static MainCameraOrganizer _instance;

	[Token(Token = "0x400F2D7")]
	private const float bgToGameCamDuration = 2f;

	[Token(Token = "0x400F2D8")]
	[FieldOffset(Offset = "0x118")]
	private Volume postProcessVolume;

	[Token(Token = "0x400F2D9")]
	[FieldOffset(Offset = "0x120")]
	private float targetPPWeight;

	[Token(Token = "0x400F2DA")]
	[FieldOffset(Offset = "0x124")]
	private float timerPPWeight;

	[Token(Token = "0x400F2DB")]
	[FieldOffset(Offset = "0x128")]
	private float timePPWeight;

	[Token(Token = "0x400F2DC")]
	[FieldOffset(Offset = "0x12C")]
	private float startPPWeight;

	[Token(Token = "0x400F2DD")]
	[FieldOffset(Offset = "0x130")]
	private float currentWeight;

	[Token(Token = "0x400F2DE")]
	[FieldOffset(Offset = "0x138")]
	private UniversalAdditionalCameraData postProcessTarget;

	[Token(Token = "0x17001A6B")]
	public CameraViewSetting.ViewInfo view
	{
		[Token(Token = "0x600AB08")]
		[Address(RVA = "0xF73290", Offset = "0xF72490", VA = "0x180F73290")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A6C")]
	public Camera camera3D
	{
		[Token(Token = "0x600AB09")]
		[Address(RVA = "0x49BB10", Offset = "0x49AD10", VA = "0x18049BB10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600AB0A")]
		[Address(RVA = "0x3DAE90", Offset = "0x3DA090", VA = "0x1803DAE90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001A6D")]
	public Camera uiCameraContent
	{
		[Token(Token = "0x600AB0B")]
		[Address(RVA = "0x5961D0", Offset = "0x5953D0", VA = "0x1805961D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600AB0C")]
		[Address(RVA = "0x5FC6E0", Offset = "0x5FB8E0", VA = "0x1805FC6E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001A6E")]
	public Camera uiCameraOverlay
	{
		[Token(Token = "0x600AB0D")]
		[Address(RVA = "0x596200", Offset = "0x595400", VA = "0x180596200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600AB0E")]
		[Address(RVA = "0x5FC6C0", Offset = "0x5FB8C0", VA = "0x1805FC6C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001A6F")]
	public bool cameraWorkFinish
	{
		[Token(Token = "0x600AB0F")]
		[Address(RVA = "0x62D9D0", Offset = "0x62CBD0", VA = "0x18062D9D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600AB10")]
		[Address(RVA = "0x62DFC0", Offset = "0x62D1C0", VA = "0x18062DFC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001A70")]
	private int hideCounterOverUI2D
	{
		[Token(Token = "0x600AB11")]
		[Address(RVA = "0xA2A0C0", Offset = "0xA292C0", VA = "0x180A2A0C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600AB12")]
		[Address(RVA = "0xA2A510", Offset = "0xA29710", VA = "0x180A2A510")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001A71")]
	private int hideCounterOverUI3D
	{
		[Token(Token = "0x600AB13")]
		[Address(RVA = "0x6D4710", Offset = "0x6D3910", VA = "0x1806D4710")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600AB14")]
		[Address(RVA = "0x6D7720", Offset = "0x6D6920", VA = "0x1806D7720")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001A72")]
	public static MainCameraOrganizer instance
	{
		[Token(Token = "0x600AB15")]
		[Address(RVA = "0xF73020", Offset = "0xF72220", VA = "0x180F73020")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A73")]
	public bool isInitialized
	{
		[Token(Token = "0x600AB1A")]
		[Address(RVA = "0xF73280", Offset = "0xF72480", VA = "0x180F73280")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600AB1B")]
		[Address(RVA = "0xF732E0", Offset = "0xF724E0", VA = "0x180F732E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x600AB16")]
	[Address(RVA = "0xF70700", Offset = "0xF6F900", VA = "0x180F70700")]
	private void Awake()
	{
	}

	[Token(Token = "0x600AB17")]
	[Address(RVA = "0xF708D0", Offset = "0xF6FAD0", VA = "0x180F708D0")]
	public static MainCameraOrganizer Create(GameObject root, string name)
	{
		return null;
	}

	[Token(Token = "0x600AB18")]
	[Address(RVA = "0xF71350", Offset = "0xF70550", VA = "0x180F71350")]
	public void Initialize()
	{
	}

	[Token(Token = "0x600AB19")]
	[Address(RVA = "0xF723C0", Offset = "0xF715C0", VA = "0x180F723C0")]
	public void SetupViews()
	{
	}

	[Token(Token = "0x600AB1C")]
	[Address(RVA = "0xF71300", Offset = "0xF70500", VA = "0x180F71300")]
	public void InitializeToDuel(bool isAudience)
	{
	}

	[Token(Token = "0x600AB1D")]
	[Address(RVA = "0xF70F60", Offset = "0xF70160", VA = "0x180F70F60")]
	public void FinishToDuel()
	{
	}

	[Token(Token = "0x600AB1E")]
	[Address(RVA = "0xF71F20", Offset = "0xF71120", VA = "0x180F71F20")]
	public void Reboot()
	{
	}

	[Token(Token = "0x600AB1F")]
	[Address(RVA = "0xF71F10", Offset = "0xF71110", VA = "0x180F71F10")]
	public void PrepareToDuel(bool bgCameraEnabled)
	{
	}

	[Token(Token = "0x600AB20")]
	[Address(RVA = "0xF707E0", Offset = "0xF6F9E0", VA = "0x180F707E0")]
	public void CameraWorkBegin(Camera camera)
	{
	}

	[Token(Token = "0x600AB21")]
	[Address(RVA = "0xF70810", Offset = "0xF6FA10", VA = "0x180F70810")]
	public void CameraWorkEnd()
	{
	}

	[Token(Token = "0x600AB22")]
	[Address(RVA = "0xF722C0", Offset = "0xF714C0", VA = "0x180F722C0")]
	public void SetViewMode(ViewMode viewMode, bool immediate = true, bool isDuelAudience = false)
	{
	}

	[Token(Token = "0x600AB23")]
	[Address(RVA = "0xF726F0", Offset = "0xF718F0", VA = "0x180F726F0")]
	public void Shake(string type, bool shakeSubCamera = false)
	{
	}

	[Token(Token = "0x600AB24")]
	[Address(RVA = "0xF720D0", Offset = "0xF712D0", VA = "0x180F720D0")]
	public void SetActivePostProcessing(bool active, bool immediate = true)
	{
	}

	[Token(Token = "0x600AB25")]
	[Address(RVA = "0xF72110", Offset = "0xF71310", VA = "0x180F72110")]
	public void SetActiveScreenOverUICamera(bool active2D, bool active3D)
	{
	}

	[Token(Token = "0x600AB26")]
	[Address(RVA = "0xF721B0", Offset = "0xF713B0", VA = "0x180F721B0")]
	public void SetExternalOperator(IMainCameraOperation externalOperator)
	{
	}

	[Token(Token = "0x600AB27")]
	[Address(RVA = "0xF72D00", Offset = "0xF71F00", VA = "0x180F72D00")]
	private void Update()
	{
	}

	[Token(Token = "0x600AB28")]
	[Address(RVA = "0xF71EC0", Offset = "0xF710C0", VA = "0x180F71EC0")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600AB29")]
	[Address(RVA = "0xF71EB0", Offset = "0xF710B0", VA = "0x180F71EB0")]
	private void InitializingStep()
	{
	}

	[Token(Token = "0x600AB2A")]
	[Address(RVA = "0xF709A0", Offset = "0xF6FBA0", VA = "0x180F709A0")]
	private void DuelStartShow()
	{
	}

	[Token(Token = "0x600AB2B")]
	[Address(RVA = "0xF70E80", Offset = "0xF70080", VA = "0x180F70E80")]
	private void ExecBgCameraStep()
	{
	}

	[Token(Token = "0x600AB2C")]
	[Address(RVA = "0xF70AD0", Offset = "0xF6FCD0", VA = "0x180F70AD0")]
	private void EndBgCameraStep()
	{
	}

	[Token(Token = "0x600AB2D")]
	[Address(RVA = "0xF71090", Offset = "0xF70290", VA = "0x180F71090")]
	private void IdleStep()
	{
	}

	[Token(Token = "0x600AB2E")]
	[Address(RVA = "0xF72720", Offset = "0xF71920", VA = "0x180F72720")]
	private void UpdateGameCam(float lerpT = 0.5f)
	{
	}

	[Token(Token = "0x600AB2F")]
	[Address(RVA = "0xF721C0", Offset = "0xF713C0", VA = "0x180F721C0")]
	public void SetPostProcessWeight(float startWeight = -1f, float targetWeight = 1f, float transitionTime = 0.5f)
	{
	}

	[Token(Token = "0x600AB30")]
	[Address(RVA = "0xF72B50", Offset = "0xF71D50", VA = "0x180F72B50")]
	private void UpdatePostProcessWeight()
	{
	}

	[Token(Token = "0x600AB31")]
	[Address(RVA = "0xF72F90", Offset = "0xF72190", VA = "0x180F72F90")]
	public MainCameraOrganizer()
	{
	}
}
