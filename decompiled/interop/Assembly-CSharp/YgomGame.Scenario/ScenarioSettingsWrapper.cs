using Il2CppDummyDll;
using YgomGame.Settings;

namespace YgomGame.Scenario;

[Token(Token = "0x2000ACC")]
public class ScenarioSettingsWrapper
{
	[Token(Token = "0x2000ACD")]
	public enum SoundSettingType
	{
		[Token(Token = "0x40093B9")]
		BGM,
		[Token(Token = "0x40093BA")]
		SE,
		[Token(Token = "0x40093BB")]
		Voice,
		[Token(Token = "0x40093BC")]
		Movie
	}

	[Token(Token = "0x40093B6")]
	[FieldOffset(Offset = "0x10")]
	private SettingsUtil.SoundParam m_SoundParam;

	[Token(Token = "0x40093B7")]
	[FieldOffset(Offset = "0x24")]
	private bool m_SoundVolumeDirty;

	[Token(Token = "0x600424E")]
	[Address(RVA = "0x8A15C0", Offset = "0x8A07C0", VA = "0x1808A15C0")]
	public void Initialize()
	{
	}

	[Token(Token = "0x600424F")]
	[Address(RVA = "0x8A14B0", Offset = "0x8A06B0", VA = "0x1808A14B0")]
	public string GetSoundSettingLabel(SoundSettingType volumeType)
	{
		return null;
	}

	[Token(Token = "0x6004250")]
	[Address(RVA = "0x8A1590", Offset = "0x8A0790", VA = "0x1808A1590")]
	public int GetSoundSettingValue(SoundSettingType settingType)
	{
		return default(int);
	}

	[Token(Token = "0x6004251")]
	[Address(RVA = "0x8A1670", Offset = "0x8A0870", VA = "0x1808A1670")]
	public void SetSoundSettingValue(SoundSettingType settingType, int value)
	{
	}

	[Token(Token = "0x6004252")]
	[Address(RVA = "0x8A1600", Offset = "0x8A0800", VA = "0x1808A1600")]
	public void SaveSettingIfDirty()
	{
	}

	[Token(Token = "0x6004253")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public ScenarioSettingsWrapper()
	{
	}
}
