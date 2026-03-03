using Il2CppDummyDll;

namespace Unity.Properties;

[Token(Token = "0x200004E")]
public interface IListPropertyAccept<TList>
{
	[Token(Token = "0x6000133")]
	void Accept<TContainer>(IListPropertyVisitor visitor, Property<TContainer, TList> property, ref TContainer container, ref TList list);
}
