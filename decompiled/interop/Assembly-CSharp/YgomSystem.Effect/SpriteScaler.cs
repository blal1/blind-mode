using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.Effect;

[Token(Token = "0x2000325")]
public class SpriteScaler : MonoBehaviour
{
	[Token(Token = "0x2000326")]
	public enum FitMode
	{
		[Token(Token = "0x400113F")]
		None,
		[Token(Token = "0x4001140")]
		FitWidth,
		[Token(Token = "0x4001141")]
		FitHeight,
		[Token(Token = "0x4001142")]
		FitWidthMaintainAspectRatio,
		[Token(Token = "0x4001143")]
		FitHeightMaintainAspectRatio,
		[Token(Token = "0x4001144")]
		FitWidthHeight,
		[Token(Token = "0x4001145")]
		FitHighestResolutionMaintainAspectRatio,
		[Token(Token = "0x4001146")]
		FitLowestResolutionMaintainAspectRatio
	}

	[Token(Token = "0x400112F")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private bool applyOnUpdate;

	[Token(Token = "0x4001130")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private FitMode fitMode;

	[Token(Token = "0x4001131")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public Vector3 offsetScale;

	[Token(Token = "0x4001132")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private bool _useDirectSizeSetting;

	[Token(Token = "0x4001133")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Vector2 _directSizeSetting;

	[Token(Token = "0x4001134")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private bool _changePosition;

	[Token(Token = "0x4001135")]
	[FieldOffset(Offset = "0x41")]
	[SerializeField]
	private bool _isUseFixedDepth;

	[Token(Token = "0x4001136")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	private float _fixedDepth;

	[Token(Token = "0x4001138")]
	[FieldOffset(Offset = "0x50")]
	private SpriteRenderer targetSprite;

	[Token(Token = "0x4001139")]
	[FieldOffset(Offset = "0x58")]
	private SpriteMask targetMask;

	[Token(Token = "0x400113A")]
	[FieldOffset(Offset = "0x60")]
	private bool isApplied;

	[Token(Token = "0x400113B")]
	[FieldOffset(Offset = "0x61")]
	private bool applyOnCustomSize;

	[Token(Token = "0x400113C")]
	[FieldOffset(Offset = "0x62")]
	private bool m_ScaleYtoZ;

	[Token(Token = "0x400113D")]
	[FieldOffset(Offset = "0x64")]
	private Vector2 appliedScreenSize;

	[Token(Token = "0x170001F5")]
	public bool isApplyOnUpdate
	{
		[Token(Token = "0x60013A5")]
		[Address(RVA = "0x416680", Offset = "0x415880", VA = "0x180416680")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60013A6")]
		[Address(RVA = "0x4166E0", Offset = "0x4158E0", VA = "0x1804166E0")]
		set
		{
		}
	}

	[Token(Token = "0x170001F6")]
	public bool useDirectSizeSetting
	{
		[Token(Token = "0x60013A7")]
		[Address(RVA = "0x4166A0", Offset = "0x4158A0", VA = "0x1804166A0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60013A8")]
		[Address(RVA = "0x416700", Offset = "0x415900", VA = "0x180416700")]
		set
		{
		}
	}

	[Token(Token = "0x170001F7")]
	public Vector2 directSizeSetting
	{
		[Token(Token = "0x60013A9")]
		[Address(RVA = "0x416650", Offset = "0x415850", VA = "0x180416650")]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x60013AA")]
		[Address(RVA = "0x4166C0", Offset = "0x4158C0", VA = "0x1804166C0")]
		set
		{
		}
	}

	[Token(Token = "0x170001F8")]
	public bool changePosition
	{
		[Token(Token = "0x60013AB")]
		[Address(RVA = "0x416640", Offset = "0x415840", VA = "0x180416640")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60013AC")]
		[Address(RVA = "0x3D77B0", Offset = "0x3D69B0", VA = "0x1803D77B0")]
		set
		{
		}
	}

	[Token(Token = "0x170001F9")]
	public bool useFixedDepth
	{
		[Token(Token = "0x60013AD")]
		[Address(RVA = "0x4166B0", Offset = "0x4158B0", VA = "0x1804166B0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60013AE")]
		[Address(RVA = "0x416710", Offset = "0x415910", VA = "0x180416710")]
		set
		{
		}
	}

	[Token(Token = "0x170001FA")]
	public float fixedDepth
	{
		[Token(Token = "0x60013AF")]
		[Address(RVA = "0x416670", Offset = "0x415870", VA = "0x180416670")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60013B0")]
		[Address(RVA = "0x4166D0", Offset = "0x4158D0", VA = "0x1804166D0")]
		set
		{
		}
	}

	[Token(Token = "0x170001FB")]
	public Camera viewCamera
	{
		[Token(Token = "0x60013B1")]
		[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60013B2")]
		[Address(RVA = "0x414E90", Offset = "0x414090", VA = "0x180414E90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170001FC")]
	public bool scaleYtoZ
	{
		[Token(Token = "0x60013B3")]
		[Address(RVA = "0x416690", Offset = "0x415890", VA = "0x180416690")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60013B4")]
		[Address(RVA = "0x4166F0", Offset = "0x4158F0", VA = "0x1804166F0")]
		set
		{
		}
	}

	[Token(Token = "0x60013B5")]
	[Address(RVA = "0x416370", Offset = "0x415570", VA = "0x180416370")]
	public void SetFitMode(FitMode fitMode)
	{
	}

	[Token(Token = "0x60013B6")]
	[Address(RVA = "0x416290", Offset = "0x415490", VA = "0x180416290")]
	public FitMode GetFitMode()
	{
		return default(FitMode);
	}

	[Token(Token = "0x60013B7")]
	[Address(RVA = "0x416480", Offset = "0x415680", VA = "0x180416480")]
	public Sprite TryGetTargetSprite()
	{
		return null;
	}

	[Token(Token = "0x60013B8")]
	[Address(RVA = "0x416380", Offset = "0x415580", VA = "0x180416380")]
	public void Setup(Camera view_camera)
	{
	}

	[Token(Token = "0x60013B9")]
	[Address(RVA = "0x4158A0", Offset = "0x414AA0", VA = "0x1804158A0")]
	public void Apply()
	{
	}

	[Token(Token = "0x60013BA")]
	[Address(RVA = "0x4158F0", Offset = "0x414AF0", VA = "0x1804158F0")]
	public void Apply(float screenWidth, float screenHeight)
	{
	}

	[Token(Token = "0x60013BB")]
	[Address(RVA = "0x416300", Offset = "0x415500", VA = "0x180416300")]
	public void Reapply()
	{
	}

	[Token(Token = "0x60013BC")]
	[Address(RVA = "0x4162A0", Offset = "0x4154A0", VA = "0x1804162A0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60013BD")]
	[Address(RVA = "0x416550", Offset = "0x415750", VA = "0x180416550")]
	private void Update()
	{
	}

	[Token(Token = "0x60013BE")]
	[Address(RVA = "0x4165A0", Offset = "0x4157A0", VA = "0x1804165A0")]
	public SpriteScaler()
	{
	}
}
