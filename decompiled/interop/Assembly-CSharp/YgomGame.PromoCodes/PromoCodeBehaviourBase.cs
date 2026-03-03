using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using YgomSystem.ElementSystem;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.PromoCodes;

[Token(Token = "0x2000B43")]
public abstract class PromoCodeBehaviourBase : IPromoCodeBehaviour
{
	[Token(Token = "0x2000B44")]
	[CompilerGenerated]
	private sealed class _003CProgressUpdate_003Ed__44 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400962F")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4009630")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4009631")]
		[FieldOffset(Offset = "0x20")]
		public PromoCodeBehaviourBase _003C_003E4__this;

		[Token(Token = "0x4009632")]
		[FieldOffset(Offset = "0x28")]
		private IEnumerator _003CprogressUpdateRoutine_003E5__2;

		[Token(Token = "0x1700093B")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600450E")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700093C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6004510")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600450B")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CProgressUpdate_003Ed__44(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600450C")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600450D")]
		[Address(RVA = "0x8F9260", Offset = "0x8F8460", VA = "0x1808F9260", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600450F")]
		[Address(RVA = "0x8F9490", Offset = "0x8F8690", VA = "0x1808F9490", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4009625")]
	[FieldOffset(Offset = "0x10")]
	protected readonly Dictionary<string, object> Args;

	[Token(Token = "0x4009626")]
	[FieldOffset(Offset = "0x18")]
	protected PromoCodesViewController.SourceContainer m_SourceContainer;

	[Token(Token = "0x4009627")]
	[FieldOffset(Offset = "0x20")]
	private IPromoCodeBehaviour.ProgressState m_ProgressState;

	[Token(Token = "0x400962A")]
	[FieldOffset(Offset = "0x38")]
	private List<IWidget> m_Widgets;

	[Token(Token = "0x400962B")]
	[FieldOffset(Offset = "0x40")]
	private List<IEnumerator> m_WidgetInitialRoutines;

	[Token(Token = "0x400962C")]
	[FieldOffset(Offset = "0x48")]
	public string m_HeaderButtonLabel;

	[Token(Token = "0x400962D")]
	[FieldOffset(Offset = "0x50")]
	public Action m_HeaderButtonAction;

	[Token(Token = "0x17000930")]
	protected IPromoCodeBehaviourHandler m_Handler
	{
		[Token(Token = "0x60044F0")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60044EF")]
		[Address(RVA = "0x402FB0", Offset = "0x4021B0", VA = "0x180402FB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000931")]
	protected ElementObjectManager m_View
	{
		[Token(Token = "0x60044F2")]
		[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60044F1")]
		[Address(RVA = "0x4130D0", Offset = "0x4122D0", VA = "0x1804130D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000932")]
	public string headerButtonLabel
	{
		[Token(Token = "0x60044F3")]
		[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000933")]
	public Action headerButtonAction
	{
		[Token(Token = "0x60044F4")]
		[Address(RVA = "0x580700", Offset = "0x57F900", VA = "0x180580700", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000934")]
	public Action<OnErrorBehaviour, string> onErrorCallback
	{
		[Token(Token = "0x60044F5")]
		[Address(RVA = "0x5EA220", Offset = "0x5E9420", VA = "0x1805EA220", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60044F6")]
		[Address(RVA = "0x81BD60", Offset = "0x81AF60", VA = "0x18081BD60", Slot = "20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000935")]
	public abstract IPromoCodeBehaviour.Type type
	{
		[Token(Token = "0x60044FA")]
		get;
	}

	[Token(Token = "0x17000936")]
	public IPromoCodeBehaviour.ProgressState progressState
	{
		[Token(Token = "0x60044FB")]
		[Address(RVA = "0x4BDC30", Offset = "0x4BCE30", VA = "0x1804BDC30", Slot = "5")]
		get
		{
			return default(IPromoCodeBehaviour.ProgressState);
		}
	}

	[Token(Token = "0x17000937")]
	public abstract string viewLabel
	{
		[Token(Token = "0x60044FC")]
		get;
	}

	[Token(Token = "0x17000938")]
	public abstract string titleCategoryText
	{
		[Token(Token = "0x60044FD")]
		get;
	}

	[Token(Token = "0x17000939")]
	public abstract string titleBodyText
	{
		[Token(Token = "0x60044FE")]
		get;
	}

	[Token(Token = "0x1700093A")]
	public abstract bool useInputCoolTime
	{
		[Token(Token = "0x60044FF")]
		get;
	}

	[Token(Token = "0x60044F7")]
	[Address(RVA = "0x8E6B80", Offset = "0x8E5D80", VA = "0x1808E6B80", Slot = "14")]
	public void GetCooltimeTargets(List<InputFieldWidget> res)
	{
	}

	[Token(Token = "0x60044F8")]
	[Address(RVA = "0x8E6CA0", Offset = "0x8E5EA0", VA = "0x1808E6CA0")]
	private void InnerGetCooltimeTargets(IWidget widget, List<InputFieldWidget> res)
	{
	}

	[Token(Token = "0x60044F9")]
	[Address(RVA = "0x8E6F80", Offset = "0x8E6180", VA = "0x1808E6F80")]
	protected PromoCodeBehaviourBase(Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6004500")]
	public abstract bool IsValid();

	[Token(Token = "0x6004501")]
	[Address(RVA = "0x402FB0", Offset = "0x4021B0", VA = "0x180402FB0", Slot = "13")]
	public void Initialize(IPromoCodeBehaviourHandler handler)
	{
	}

	[Token(Token = "0x6004502")]
	[Address(RVA = "0x4130D0", Offset = "0x4122D0", VA = "0x1804130D0", Slot = "15")]
	public void OnCreatedView(ElementObjectManager view)
	{
	}

	[Token(Token = "0x6004503")]
	[Address(RVA = "0x8E6EE0", Offset = "0x8E60E0", VA = "0x1808E6EE0")]
	protected void OnLaunchFailed()
	{
	}

	[Token(Token = "0x6004504")]
	[Address(RVA = "0x8E6F60", Offset = "0x8E6160", VA = "0x1808E6F60")]
	protected void SendError(OnErrorBehaviour errorBehaviour, string errorMessage)
	{
	}

	[Token(Token = "0x6004505")]
	[Address(RVA = "0x417C80", Offset = "0x416E80", VA = "0x180417C80", Slot = "16")]
	public void BeginInitialize(PromoCodesViewController.SourceContainer sourceContainer)
	{
	}

	[Token(Token = "0x6004506")]
	[Address(RVA = "0x8E6EF0", Offset = "0x8E60F0", VA = "0x1808E6EF0", Slot = "17")]
	[IteratorStateMachine(typeof(_003CProgressUpdate_003Ed__44))]
	public IEnumerator ProgressUpdate()
	{
		return null;
	}

	[Token(Token = "0x6004507")]
	protected abstract IEnumerator OnProgressUpdate();

	[Token(Token = "0x6004508")]
	[Address(RVA = "0x8E69E0", Offset = "0x8E5BE0", VA = "0x1808E69E0")]
	protected void AssignWidget(IWidget widget)
	{
	}

	[Token(Token = "0x6004509")]
	public abstract void OnReady();

	[Token(Token = "0x600450A")]
	[Address(RVA = "0x8E69A0", Offset = "0x8E5BA0", VA = "0x1808E69A0")]
	protected void AssignHeaderButton(string label, Action action)
	{
	}
}
