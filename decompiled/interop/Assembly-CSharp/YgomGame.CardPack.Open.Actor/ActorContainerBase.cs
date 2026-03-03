using Il2CppDummyDll;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.CardPack.Open.Actor;

[Token(Token = "0x2001570")]
public abstract class ActorContainerBase<T> : ElementWidgetBehaviourBase<T> where T : ActorContainerBase<T>
{
	[Token(Token = "0x6008481")]
	public abstract void Cleanup(bool keepInfo);

	[Token(Token = "0x6008482")]
	protected ActorContainerBase()
	{
	}
}
