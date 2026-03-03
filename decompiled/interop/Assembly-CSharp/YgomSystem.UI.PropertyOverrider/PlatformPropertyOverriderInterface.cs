using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.Utility;

namespace YgomSystem.UI.PropertyOverrider;

[Token(Token = "0x20005BD")]
public abstract class PlatformPropertyOverriderInterface : MonoBehaviour, IPlatformPropertyOverrider
{
	[Token(Token = "0x1700046E")]
	public abstract OverrideMode overrideMode
	{
		[Token(Token = "0x60025CD")]
		get;
		[Token(Token = "0x60025CE")]
		set;
	}

	[Token(Token = "0x1700046F")]
	public abstract string switchLabel
	{
		[Token(Token = "0x60025D5")]
		get;
	}

	[Token(Token = "0x17000470")]
	public abstract bool switchLabelAsReg
	{
		[Token(Token = "0x60025D6")]
		get;
	}

	[Token(Token = "0x60025CF")]
	public abstract void ApplyImmediate();

	[Token(Token = "0x60025D0")]
	public abstract void ApplyImmediate(DeviceInfo.PlatformType platformType);

	[Token(Token = "0x60025D1")]
	public abstract void Export();

	[Token(Token = "0x60025D2")]
	public abstract void Export(DeviceInfo.PlatformType platformType);

	[Token(Token = "0x60025D3")]
	public abstract void Import();

	[Token(Token = "0x60025D4")]
	public abstract void Import(DeviceInfo.PlatformType platformType);

	[Token(Token = "0x60025D7")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	protected PlatformPropertyOverriderInterface()
	{
	}
}
