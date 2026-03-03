using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.Utility;

namespace YgomSystem.UI.PropertyOverrider;

[Token(Token = "0x20005C8")]
[RequireComponent(typeof(Text))]
[AddComponentMenu("Ygom/UI/Platform Overrider/Text Overrider")]
public class PlatformTextOverrider : PropertyOverriderBase<Text>
{
	[Token(Token = "0x4001BE5")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private OverrideIntProperty m_FontSize;

	[Token(Token = "0x4001BE6")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private OverrideBoolProperty m_BestFit;

	[Token(Token = "0x4001BE7")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private OverrideIntProperty m_MinSize;

	[Token(Token = "0x4001BE8")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private OverrideIntProperty m_MaxSize;

	[Token(Token = "0x1700047D")]
	public OverrideIntProperty fontSize
	{
		[Token(Token = "0x60025FD")]
		[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700047E")]
	public OverrideBoolProperty bestFit
	{
		[Token(Token = "0x60025FE")]
		[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700047F")]
	public OverrideIntProperty minSize
	{
		[Token(Token = "0x60025FF")]
		[Address(RVA = "0x580700", Offset = "0x57F900", VA = "0x180580700")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000480")]
	public OverrideIntProperty maxSize
	{
		[Token(Token = "0x6002600")]
		[Address(RVA = "0x5EA220", Offset = "0x5E9420", VA = "0x1805EA220")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002601")]
	[Address(RVA = "0x69D180", Offset = "0x69C380", VA = "0x18069D180", Slot = "26")]
	protected override void ImportImpl(Text target, DeviceInfo.PlatformType platformType)
	{
	}

	[Token(Token = "0x6002602")]
	[Address(RVA = "0x69D080", Offset = "0x69C280", VA = "0x18069D080", Slot = "25")]
	protected override void ExportImpl(Text target, DeviceInfo.PlatformType platformType)
	{
	}

	[Token(Token = "0x6002603")]
	[Address(RVA = "0x69D290", Offset = "0x69C490", VA = "0x18069D290")]
	public PlatformTextOverrider()
	{
	}
}
