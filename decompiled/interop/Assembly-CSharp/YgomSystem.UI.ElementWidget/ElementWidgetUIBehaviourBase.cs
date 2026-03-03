using Il2CppDummyDll;
using UnityEngine.EventSystems;
using YgomSystem.ElementSystem;

namespace YgomSystem.UI.ElementWidget;

[Token(Token = "0x2000611")]
public class ElementWidgetUIBehaviourBase<T> : UIBehaviour where T : ElementWidgetUIBehaviourBase<T>
{
	[Token(Token = "0x4001D24")]
	[FieldOffset(Offset = "0x0")]
	private ElementObjectManager m_EomCache;

	[Token(Token = "0x170004DB")]
	public ElementObjectManager eom
	{
		[Token(Token = "0x60027C2")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60027C3")]
	protected static T InnerCreate(ElementObjectManager eom)
	{
		return null;
	}

	[Token(Token = "0x60027C4")]
	protected virtual void CollectComponents()
	{
	}

	[Token(Token = "0x60027C5")]
	public ElementWidgetUIBehaviourBase()
	{
	}
}
