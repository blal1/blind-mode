using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.Utility;

namespace YgomSystem.UI.PropertyOverrider;

[Token(Token = "0x20005B9")]
public abstract class PropertyOverriderBase<Target> : PlatformPropertyOverriderInterface, IPlatformPropertyOverrider where Target : Component
{
	[Token(Token = "0x4001BC8")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	private PlatformOverriderGroup m_Group;

	[Token(Token = "0x4001BC9")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	private string m_SwitchLabel;

	[Token(Token = "0x4001BCA")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	private bool m_SwitchLabelAsReg;

	[Token(Token = "0x4001BCB")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[HideInInspector]
	private OverrideMode m_OverrideMode;

	[Token(Token = "0x4001BCC")]
	[FieldOffset(Offset = "0x0")]
	private bool m_IsDone;

	[Token(Token = "0x17000466")]
	public override OverrideMode overrideMode
	{
		[Token(Token = "0x60025B1")]
		get
		{
			return default(OverrideMode);
		}
		[Token(Token = "0x60025B2")]
		set
		{
		}
	}

	[Token(Token = "0x17000467")]
	public bool isDone
	{
		[Token(Token = "0x60025B3")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000468")]
	public override string switchLabel
	{
		[Token(Token = "0x60025B4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000469")]
	public override bool switchLabelAsReg
	{
		[Token(Token = "0x60025B5")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60025B6")]
	private void Awake()
	{
	}

	[Token(Token = "0x60025B7")]
	protected virtual Target GetTargetComponent()
	{
		return null;
	}

	[Token(Token = "0x60025B8")]
	private DeviceInfo.PlatformType GetCurrentPlatformType()
	{
		return default(DeviceInfo.PlatformType);
	}

	[Token(Token = "0x60025B9")]
	public override void ApplyImmediate()
	{
	}

	[Token(Token = "0x60025BA")]
	public override void ApplyImmediate(DeviceInfo.PlatformType platformType)
	{
	}

	[Token(Token = "0x60025BB")]
	public override void Import()
	{
	}

	[Token(Token = "0x60025BC")]
	public override void Import(DeviceInfo.PlatformType platformType)
	{
	}

	[Token(Token = "0x60025BD")]
	public override void Export()
	{
	}

	[Token(Token = "0x60025BE")]
	public override void Export(DeviceInfo.PlatformType platformType)
	{
	}

	[Token(Token = "0x60025BF")]
	protected abstract void ExportImpl(Target target, DeviceInfo.PlatformType platformType);

	[Token(Token = "0x60025C0")]
	protected abstract void ImportImpl(Target target, DeviceInfo.PlatformType platformType);

	[Token(Token = "0x60025C1")]
	protected PropertyOverriderBase()
	{
	}
}
