using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000219")]
[EventCategory(EventCategory.ChangePanel)]
public abstract class PanelChangedEventBase<T> : EventBase<T> where T : PanelChangedEventBase<T>, new()
{
	[Token(Token = "0x1700029B")]
	public IPanel originPanel
	{
		[Token(Token = "0x6000EC6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000EC7")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700029C")]
	public IPanel destinationPanel
	{
		[Token(Token = "0x6000EC8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000EC9")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6000ECA")]
	protected override void Init()
	{
	}

	[Token(Token = "0x6000ECB")]
	private void LocalInit()
	{
	}

	[Token(Token = "0x6000ECC")]
	public static T GetPooled(IPanel originPanel, IPanel destinationPanel)
	{
		return null;
	}

	[Token(Token = "0x6000ECD")]
	protected PanelChangedEventBase()
	{
	}
}
