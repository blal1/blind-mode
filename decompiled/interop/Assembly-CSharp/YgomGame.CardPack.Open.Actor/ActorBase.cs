using Il2CppDummyDll;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.CardPack.Open.Actor;

[Token(Token = "0x2001578")]
public abstract class ActorBase<T> : ElementWidgetBehaviourBase<T>, IActor where T : ActorBase<T>
{
	[Token(Token = "0x60084F5")]
	protected ActorBase()
	{
	}
}
