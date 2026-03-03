using Il2CppDummyDll;

namespace YgomSystem.UI;

[Token(Token = "0x200045A")]
public interface IObjectPool<T>
{
	[Token(Token = "0x6001C26")]
	void CreateReserve(int cnt);

	[Token(Token = "0x6001C27")]
	T Rent();

	[Token(Token = "0x6001C28")]
	void Return(T obj);

	[Token(Token = "0x6001C29")]
	void ReturnAll();
}
