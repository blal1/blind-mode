using Il2CppDummyDll;

[Token(Token = "0x200009D")]
public abstract class USndPlugin_abstract
{
	[Token(Token = "0x600030C")]
	public abstract void Init();

	[Token(Token = "0x600030D")]
	public abstract void Delete();

	[Token(Token = "0x600030E")]
	public abstract bool IsMusicPlaying();

	[Token(Token = "0x600030F")]
	public abstract bool IsOtherAudioPlaying();

	[Token(Token = "0x6000310")]
	public abstract bool IsSpeaker();

	[Token(Token = "0x6000311")]
	public abstract bool IsMannerMode();

	[Token(Token = "0x6000312")]
	public abstract void SetAudioFocus();

	[Token(Token = "0x6000313")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	protected USndPlugin_abstract()
	{
	}
}
