using Il2CppDummyDll;
using UnityEngine.Timeline;

namespace YgomSystem.Timeline;

[Token(Token = "0x2000219")]
public class ExtendedSignalEmitter : SignalEmitter
{
	[Token(Token = "0x4000AD7")]
	[FieldOffset(Offset = "0x38")]
	public bool useCallback;

	[Token(Token = "0x4000AD8")]
	[FieldOffset(Offset = "0x39")]
	public bool playSound;

	[Token(Token = "0x4000AD9")]
	[FieldOffset(Offset = "0x40")]
	public string soundLabel;

	[Token(Token = "0x6000C7E")]
	[Address(RVA = "0xD36E60", Offset = "0xD36060", VA = "0x180D36E60")]
	public ExtendedSignalEmitter()
	{
	}
}
