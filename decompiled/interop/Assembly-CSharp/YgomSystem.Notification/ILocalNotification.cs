using Il2CppDummyDll;

namespace YgomSystem.Notification;

[Token(Token = "0x200023D")]
public interface ILocalNotification
{
	[Token(Token = "0x6000D44")]
	void Initialize();

	[Token(Token = "0x6000D45")]
	void AllClear();
}
