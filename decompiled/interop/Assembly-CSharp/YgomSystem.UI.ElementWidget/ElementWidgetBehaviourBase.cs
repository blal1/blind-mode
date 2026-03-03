using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;

namespace YgomSystem.UI.ElementWidget;

[Token(Token = "0x200060E")]
public class ElementWidgetBehaviourBase<T> : MonoBehaviour where T : ElementWidgetBehaviourBase<T>
{
	[Token(Token = "0x4001D1F")]
	[FieldOffset(Offset = "0x0")]
	private ElementObjectManager m_EomCache;

	[Token(Token = "0x170004DA")]
	public ElementObjectManager eom
	{
		[Token(Token = "0x60027B7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60027B8")]
	protected static T InnerCreate(ElementObjectManager eom)
	{
		return null;
	}

	[Token(Token = "0x60027B9")]
	protected virtual void CollectComponents()
	{
	}

	[Token(Token = "0x60027BA")]
	public ElementWidgetBehaviourBase()
	{
	}
}
