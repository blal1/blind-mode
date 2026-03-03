using Il2CppDummyDll;

namespace USnd;

[Token(Token = "0x20000FC")]
public class AudioDefine
{
	[Token(Token = "0x20000FD")]
	public enum INSTANCE_STATUS
	{
		[Token(Token = "0x400062D")]
		STOP,
		[Token(Token = "0x400062E")]
		STOP_SOON,
		[Token(Token = "0x400062F")]
		PREPARE,
		[Token(Token = "0x4000630")]
		PLAY,
		[Token(Token = "0x4000631")]
		PAUSE,
		[Token(Token = "0x4000632")]
		PAUSE_SOON
	}

	[Token(Token = "0x20000FE")]
	public enum LOAD_XML_STATUS
	{
		[Token(Token = "0x4000634")]
		STANDBY,
		[Token(Token = "0x4000635")]
		LOADING,
		[Token(Token = "0x4000636")]
		FINISH,
		[Token(Token = "0x4000637")]
		ERROR
	}

	[Token(Token = "0x20000FF")]
	public enum LOAD_JSON_STATUS
	{
		[Token(Token = "0x4000639")]
		STANDBY,
		[Token(Token = "0x400063A")]
		LOADING,
		[Token(Token = "0x400063B")]
		FINISH,
		[Token(Token = "0x400063C")]
		ERROR
	}

	[Token(Token = "0x4000617")]
	[FieldOffset(Offset = "0x0")]
	public static readonly int DEFAULT_SAMPLE_RATE;

	[Token(Token = "0x4000618")]
	[FieldOffset(Offset = "0x4")]
	public static readonly bool ANDROID_MANNER_MODE_MUTE;

	[Token(Token = "0x4000619")]
	[FieldOffset(Offset = "0x8")]
	public static readonly float DEFAULT_VOLUME;

	[Token(Token = "0x400061A")]
	[FieldOffset(Offset = "0xC")]
	public static readonly float DEFAULT_PAN;

	[Token(Token = "0x400061B")]
	[FieldOffset(Offset = "0x10")]
	public static readonly int DEFAULT_PITCH;

	[Token(Token = "0x400061C")]
	[FieldOffset(Offset = "0x14")]
	public static readonly int DEFAULT_FADE;

	[Token(Token = "0x400061D")]
	[FieldOffset(Offset = "0x18")]
	public static readonly int INSTANCE_ID_ERROR;

	[Token(Token = "0x400061E")]
	[FieldOffset(Offset = "0x1C")]
	public static readonly float VOLUME_MAX;

	[Token(Token = "0x400061F")]
	[FieldOffset(Offset = "0x20")]
	public static readonly float VOLUME_MIN;

	[Token(Token = "0x4000620")]
	[FieldOffset(Offset = "0x24")]
	public static readonly float PAN_LEFT;

	[Token(Token = "0x4000621")]
	[FieldOffset(Offset = "0x28")]
	public static readonly float PAN_RIGHT;

	[Token(Token = "0x4000622")]
	[FieldOffset(Offset = "0x2C")]
	public static readonly float PAN_CENTER;

	[Token(Token = "0x4000623")]
	[FieldOffset(Offset = "0x30")]
	public static readonly int PITCH_MAX;

	[Token(Token = "0x4000624")]
	[FieldOffset(Offset = "0x34")]
	public static readonly int PITCH_MIN;

	[Token(Token = "0x4000625")]
	[FieldOffset(Offset = "0x38")]
	public static readonly int PITCH_NORMAL;

	[Token(Token = "0x4000626")]
	[FieldOffset(Offset = "0x3C")]
	public static readonly int TABLE_UPPER_VERSION;

	[Token(Token = "0x4000627")]
	[FieldOffset(Offset = "0x40")]
	public static readonly int TABLE_LOWER_VERSION;

	[Token(Token = "0x4000628")]
	[FieldOffset(Offset = "0x44")]
	public static readonly int TABLE_ADD_IS_ANDROID_NATIVE_VERSION;

	[Token(Token = "0x4000629")]
	[FieldOffset(Offset = "0x48")]
	public static readonly int TABLE_ADD_INTERVAL_VERSION;

	[Token(Token = "0x400062A")]
	[FieldOffset(Offset = "0x4C")]
	public static readonly int LIST_CAPACITY;

	[Token(Token = "0x400062B")]
	[FieldOffset(Offset = "0x50")]
	public static readonly float[] PITCH_VALUES;

	[Token(Token = "0x6000635")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public AudioDefine()
	{
	}
}
