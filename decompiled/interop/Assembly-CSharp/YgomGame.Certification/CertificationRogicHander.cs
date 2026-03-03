using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using YgomGame.Card;
using YgomGame.Menu;
using YgomGame.Menu.Common;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;
using YgomSystem.UI.PropertyOverrider;
using YgomSystem.YGomTMPro;

namespace YgomGame.Certification;

[Token(Token = "0x20014DA")]
public class CertificationRogicHander : MonoBehaviour
{
	[Token(Token = "0x20014DB")]
	public class ChoicesTemplateController : ICertificationTemplateController
	{
		[Token(Token = "0x400C90E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly string L_ButtonHorizontal1;

		[Token(Token = "0x400C90F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly string L_ButtonHorizontal2;

		[Token(Token = "0x400C910")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly string L_ButtonTemplate;

		[Token(Token = "0x400C911")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly string L_TimeOutText;

		[Token(Token = "0x400C912")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly string L_Text;

		[Token(Token = "0x400C913")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly string L_On;

		[Token(Token = "0x400C914")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly string L_Off;

		[Token(Token = "0x400C915")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly string L_Correct;

		[Token(Token = "0x400C916")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly string L_ButtonTextCorrect;

		[Token(Token = "0x400C917")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private readonly string L_ButtonTextOn;

		[Token(Token = "0x400C918")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private readonly string L_ButtonText;

		[Token(Token = "0x400C919")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private ElementObjectManager _eom;

		[Token(Token = "0x400C91A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private GameObject templateGO;

		[Token(Token = "0x400C91B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int choicesNum;

		[Token(Token = "0x400C91C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int answerIndex;

		[Token(Token = "0x400C91D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int selectedIndex;

		[Token(Token = "0x400C91E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private string questiontext;

		[Token(Token = "0x400C91F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private List<string> choicesTextList;

		[Token(Token = "0x400C920")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private GameObject btnOn;

		[Token(Token = "0x400C921")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private GameObject btnOff;

		[Token(Token = "0x400C922")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private GameObject btnCorrect;

		[Token(Token = "0x400C923")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Action onClickAction;

		[Token(Token = "0x400C924")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Action<PadInputDirection> onFaildTras;

		[Token(Token = "0x400C925")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Dictionary<int, SelectionButton> buttonMap;

		[Token(Token = "0x400C926")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Dictionary<int, ElementObjectManager> buttonEomMap;

		[Token(Token = "0x400C927")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private bool isExplanation;

		[Token(Token = "0x6008146")]
		[Address(RVA = "0xC975D0", Offset = "0xC967D0", VA = "0x180C975D0")]
		public ChoicesTemplateController(GameObject go, [Optional] BaseMenuViewController vc)
		{
		}

		[Token(Token = "0x6008147")]
		[Address(RVA = "0xC97370", Offset = "0xC96570", VA = "0x180C97370", Slot = "4")]
		public void StartDisp()
		{
		}

		[Token(Token = "0x6008148")]
		[Address(RVA = "0xC96E40", Offset = "0xC96040", VA = "0x180C96E40", Slot = "5")]
		public void RemoveDisp()
		{
		}

		[Token(Token = "0x6008149")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "6")]
		public void UpdateDisp()
		{
		}

		[Token(Token = "0x600814A")]
		[Address(RVA = "0xC96080", Offset = "0xC95280", VA = "0x180C96080")]
		private void InitData(int id, [Optional] QuestionData qdata)
		{
		}

		[Token(Token = "0x600814B")]
		[Address(RVA = "0xC96640", Offset = "0xC95840", VA = "0x180C96640")]
		public void Initialize(int questionId, bool isExp, int selectedIdx = -1, [Optional] QuestionData qdata, [Optional] Action onComp)
		{
		}

		[Token(Token = "0x600814C")]
		[Address(RVA = "0xC97040", Offset = "0xC96240", VA = "0x180C97040")]
		public int ShowSelected()
		{
			return default(int);
		}

		[Token(Token = "0x600814D")]
		[Address(RVA = "0xC96EB0", Offset = "0xC960B0", VA = "0x180C96EB0")]
		public void ShowAnswer()
		{
		}
	}

	[Token(Token = "0x20014DD")]
	protected class AnsChoicesTypeBehaviour : AnswerTypeBehaviour
	{
		[Token(Token = "0x20014DE")]
		[CompilerGenerated]
		private sealed class _003CAnswerCoroutine_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400C938")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400C939")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400C93A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AnsChoicesTypeBehaviour _003C_003E4__this;

			[Token(Token = "0x170013CF")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6008165")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170013D0")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6008167")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6008162")]
			[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
			[DebuggerHidden]
			public _003CAnswerCoroutine_003Ed__23(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6008163")]
			[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6008164")]
			[Address(RVA = "0xC981D0", Offset = "0xC973D0", VA = "0x180C981D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6008166")]
			[Address(RVA = "0xC986F0", Offset = "0xC978F0", VA = "0x180C986F0", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x400C92A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Dictionary<int, SelectionButton> buttonMap;

		[Token(Token = "0x400C92B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Dictionary<int, ElementObjectManager> buttonEomMap;

		[Token(Token = "0x400C92C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private UnityAction onFinished;

		[Token(Token = "0x400C92D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private UnityAction mateAction;

		[Token(Token = "0x400C92E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private ExtendedTextMeshProUGUI questionText;

		[Token(Token = "0x400C92F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private int answerIndex;

		[Token(Token = "0x400C930")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private int selectedIndex;

		[Token(Token = "0x400C931")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private string questiontext;

		[Token(Token = "0x400C932")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private bool endFrag;

		[Token(Token = "0x400C933")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private int inputBlockerCount;

		[Token(Token = "0x400C934")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private List<string> choicesTextList;

		[Token(Token = "0x400C935")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private ChoicesTemplateController templateController;

		[Token(Token = "0x400C936")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public Func<PadInputDirection, bool> onInputKeyEdgeAction;

		[Token(Token = "0x400C937")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Coroutine coroutine;

		[Token(Token = "0x6008154")]
		[Address(RVA = "0xC852F0", Offset = "0xC844F0", VA = "0x180C852F0")]
		public AnsChoicesTypeBehaviour(ViewControllerManager manager, BaseMenuViewController vc, ElementObjectManager parentEOM, ElementObjectManager viewEOM, ElementObjectManager questionEOM, QuestionTypeBehaviour questionTypeBehaviour, CertificationRogicHander rogicHander, [Optional] Func<PadInputDirection, bool> func)
		{
		}

		[Token(Token = "0x6008155")]
		[Address(RVA = "0xC84410", Offset = "0xC83610", VA = "0x180C84410", Slot = "4")]
		internal override void InitData(int id, QuestionData qdata)
		{
		}

		[Token(Token = "0x6008156")]
		[Address(RVA = "0xC84CE0", Offset = "0xC83EE0", VA = "0x180C84CE0")]
		private void OnFaildTransition(PadInputDirection dir)
		{
		}

		[Token(Token = "0x6008157")]
		[Address(RVA = "0xC84890", Offset = "0xC83A90", VA = "0x180C84890", Slot = "5")]
		internal override void InitDisp(bool isLast, [Optional] UnityAction mateAction, [Optional] UnityAction onFinished)
		{
		}

		[Token(Token = "0x6008158")]
		[Address(RVA = "0xC84FC0", Offset = "0xC841C0", VA = "0x180C84FC0")]
		private void SelectChoice()
		{
		}

		[Token(Token = "0x6008159")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
		private void DestroyButtons()
		{
		}

		[Token(Token = "0x600815A")]
		[Address(RVA = "0xC852C0", Offset = "0xC844C0", VA = "0x180C852C0", Slot = "6")]
		internal override void UpdateDisp()
		{
		}

		[Token(Token = "0x600815B")]
		[Address(RVA = "0xC85130", Offset = "0xC84330", VA = "0x180C85130", Slot = "8")]
		internal override void StartCountDown()
		{
		}

		[Token(Token = "0x600815C")]
		[Address(RVA = "0xC851E0", Offset = "0xC843E0", VA = "0x180C851E0", Slot = "9")]
		internal override void TimeOut()
		{
		}

		[Token(Token = "0x600815D")]
		[Address(RVA = "0xC84360", Offset = "0xC83560", VA = "0x180C84360")]
		[IteratorStateMachine(typeof(_003CAnswerCoroutine_003Ed__23))]
		private IEnumerator AnswerCoroutine()
		{
			return null;
		}

		[Token(Token = "0x600815E")]
		[Address(RVA = "0xC843D0", Offset = "0xC835D0", VA = "0x180C843D0")]
		internal void CheckingAnswer()
		{
		}

		[Token(Token = "0x600815F")]
		[Address(RVA = "0xC85090", Offset = "0xC84290", VA = "0x180C85090")]
		private void ShowCorrectButton()
		{
		}

		[Token(Token = "0x6008160")]
		[Address(RVA = "0xC84BD0", Offset = "0xC83DD0", VA = "0x180C84BD0")]
		internal void NextQuestion()
		{
		}

		[Token(Token = "0x6008161")]
		[Address(RVA = "0xC84EA0", Offset = "0xC840A0", VA = "0x180C84EA0", Slot = "7")]
		internal override void RemoveDisp()
		{
		}
	}

	[Token(Token = "0x20014DF")]
	public class DuelFieldTemplateController : QuestionTemplateController, ICertificationTemplateController
	{
		[Token(Token = "0x400C93B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GameObject templateGO;

		[Token(Token = "0x400C93C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private BindingDuelFieldCards bindingFieldCards;

		[Token(Token = "0x400C93D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<SelectionButton> _buttonList;

		[Token(Token = "0x400C93E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private BaseMenuViewController vc;

		[Token(Token = "0x170013D1")]
		public List<SelectionButton> buttonList
		{
			[Token(Token = "0x6008168")]
			[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6008169")]
		[Address(RVA = "0xC98030", Offset = "0xC97230", VA = "0x180C98030")]
		public DuelFieldTemplateController(GameObject go)
		{
		}

		[Token(Token = "0x600816A")]
		[Address(RVA = "0xC97F40", Offset = "0xC97140", VA = "0x180C97F40", Slot = "5")]
		public void StartDisp()
		{
		}

		[Token(Token = "0x600816B")]
		[Address(RVA = "0xC97D80", Offset = "0xC96F80", VA = "0x180C97D80", Slot = "6")]
		public void RemoveDisp()
		{
		}

		[Token(Token = "0x600816C")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "7")]
		public void UpdateDisp()
		{
		}

		[Token(Token = "0x600816D")]
		[Address(RVA = "0xC97DF0", Offset = "0xC96FF0", VA = "0x180C97DF0")]
		public void SetActiveSelectionItems(bool frag)
		{
		}

		[Token(Token = "0x600816E")]
		[Address(RVA = "0xC97950", Offset = "0xC96B50", VA = "0x180C97950")]
		public void Initialize(List<SelectionItem> items, string path, bool isExplanation, [Optional] BaseMenuViewController vc, [Optional] Action onComplated, [Optional] QuestionData qdata)
		{
		}
	}

	[Token(Token = "0x20014E0")]
	protected class DuelFieldTypeBehaviour : QuestionTypeBehaviour
	{
		[Token(Token = "0x400C93F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private GameObject Container;

		[Token(Token = "0x400C940")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private GameObject ContainerCopy;

		[Token(Token = "0x400C941")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private GameObject textGroup;

		[Token(Token = "0x400C942")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int typeId;

		[Token(Token = "0x400C943")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private string prefPath;

		[Token(Token = "0x400C944")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private DuelFieldTemplateController templateController;

		[Token(Token = "0x600816F")]
		[Address(RVA = "0xCAB540", Offset = "0xCAA740", VA = "0x180CAB540")]
		public DuelFieldTypeBehaviour(ViewControllerManager manager, BaseMenuViewController vc, ElementObjectManager parentEOM, ElementObjectManager viewEOM)
		{
		}

		[Token(Token = "0x6008170")]
		[Address(RVA = "0xCAAE60", Offset = "0xCAA060", VA = "0x180CAAE60", Slot = "4")]
		internal override void InitDisp(int id, bool isSamePath, QuestionData qdata)
		{
		}

		[Token(Token = "0x6008171")]
		[Address(RVA = "0xCAB490", Offset = "0xCAA690", VA = "0x180CAB490", Slot = "7")]
		internal override void StartCountDown()
		{
		}

		[Token(Token = "0x6008172")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		internal override void UpdateDisp()
		{
		}

		[Token(Token = "0x6008173")]
		[Address(RVA = "0xCAB3F0", Offset = "0xCAA5F0", VA = "0x180CAB3F0", Slot = "6")]
		internal override void RemoveDisp()
		{
		}

		[Token(Token = "0x6008174")]
		[Address(RVA = "0xCAAC80", Offset = "0xCA9E80", VA = "0x180CAAC80", Slot = "8")]
		internal override void Answered()
		{
		}
	}

	[Token(Token = "0x20014E2")]
	protected class CardTypeBehaviour : QuestionTypeBehaviour
	{
		[Token(Token = "0x400C948")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly string L_HideTextGroup;

		[Token(Token = "0x400C949")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly string L_HideTextNormal;

		[Token(Token = "0x400C94A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private readonly string L_HideTextPenduram;

		[Token(Token = "0x400C94B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private readonly string L_HideName;

		[Token(Token = "0x400C94C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private readonly string L_HideLv;

		[Token(Token = "0x400C94D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private readonly string L_HideAtrType;

		[Token(Token = "0x400C94E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private readonly string L_CardImageHideTextNormal;

		[Token(Token = "0x400C94F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private readonly string L_CardImageHideTextPenduram;

		[Token(Token = "0x400C950")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private readonly string L_CardImageHideName;

		[Token(Token = "0x400C951")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private readonly string L_CardImageHideLv;

		[Token(Token = "0x400C952")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private readonly string L_CardImageHideAtrType;

		[Token(Token = "0x400C953")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private GameObject holder;

		[Token(Token = "0x400C954")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private GameObject Container;

		[Token(Token = "0x400C955")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private string prefPath;

		[Token(Token = "0x400C956")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private GameObject templateGO;

		[Token(Token = "0x400C957")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private GameObject ContainerCopy;

		[Token(Token = "0x400C958")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private SelectionButton selectionButton;

		[Token(Token = "0x400C959")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private bool isDetailClose;

		[Token(Token = "0x400C95A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Texture2D renderTexture;

		[Token(Token = "0x6008179")]
		[Address(RVA = "0xC9E2A0", Offset = "0xC9D4A0", VA = "0x180C9E2A0")]
		public CardTypeBehaviour(ViewControllerManager manager, BaseMenuViewController vc, ElementObjectManager parentEOM, ElementObjectManager viewEOM)
		{
		}

		[Token(Token = "0x600817A")]
		[Address(RVA = "0xC9D660", Offset = "0xC9C860", VA = "0x180C9D660", Slot = "4")]
		internal override void InitDisp(int id, bool isSamePath, QuestionData qdata)
		{
		}

		[Token(Token = "0x600817B")]
		[Address(RVA = "0xC9D760", Offset = "0xC9C960", VA = "0x180C9D760")]
		private void OnLoadPrefabComplete(GameObject go)
		{
		}

		[Token(Token = "0x600817C")]
		[Address(RVA = "0xC9E1E0", Offset = "0xC9D3E0", VA = "0x180C9E1E0", Slot = "7")]
		internal override void StartCountDown()
		{
		}

		[Token(Token = "0x600817D")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		internal override void UpdateDisp()
		{
		}

		[Token(Token = "0x600817E")]
		[Address(RVA = "0xC9E0F0", Offset = "0xC9D2F0", VA = "0x180C9E0F0", Slot = "6")]
		internal override void RemoveDisp()
		{
		}

		[Token(Token = "0x600817F")]
		[Address(RVA = "0xC9D520", Offset = "0xC9C720", VA = "0x180C9D520", Slot = "8")]
		internal override void Answered()
		{
		}
	}

	[Token(Token = "0x20014E4")]
	public class CardsTemplateController : QuestionTemplateController, ICertificationTemplateController
	{
		[Token(Token = "0x400C95D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly string L_HideTextGroup;

		[Token(Token = "0x400C95E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly string L_HideTextNormal;

		[Token(Token = "0x400C95F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly string L_HideTextPenduram;

		[Token(Token = "0x400C960")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly string L_HideName;

		[Token(Token = "0x400C961")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly string L_HideLv;

		[Token(Token = "0x400C962")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly string L_HideAtrType;

		[Token(Token = "0x400C963")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private readonly string L_CardImageHideTextNormal;

		[Token(Token = "0x400C964")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private readonly string L_CardImageHideTextPenduram;

		[Token(Token = "0x400C965")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private readonly string L_CardImageHideName;

		[Token(Token = "0x400C966")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private readonly string L_CardImageHideLv;

		[Token(Token = "0x400C967")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private readonly string L_CardImageHideAtrType;

		[Token(Token = "0x400C968")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private readonly string L_letter;

		[Token(Token = "0x400C969")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private bool isDetailClose;

		[Token(Token = "0x400C96A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
		private bool isHideText;

		[Token(Token = "0x400C96B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8A")]
		private bool isHideLv;

		[Token(Token = "0x400C96C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8B")]
		private bool isHideName;

		[Token(Token = "0x400C96D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private bool isHideAtrType;

		[Token(Token = "0x400C96E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private List<ElementObjectManager> eomList;

		[Token(Token = "0x400C96F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private GameObject templateGO;

		[Token(Token = "0x400C970")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private List<int> mrkList;

		[Token(Token = "0x400C971")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Dictionary<Content.Frame, Texture2D> textureDictinary;

		[Token(Token = "0x400C972")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private List<SelectionButton> _buttonList;

		[Token(Token = "0x400C973")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private List<SelectionItem> selectionItems;

		[Token(Token = "0x170013D2")]
		public List<SelectionButton> buttonList
		{
			[Token(Token = "0x6008182")]
			[Address(RVA = "0x49BB20", Offset = "0x49AD20", VA = "0x18049BB20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170013D3")]
		public List<SelectionItem> selectionItemList
		{
			[Token(Token = "0x6008183")]
			[Address(RVA = "0x49B7C0", Offset = "0x49A9C0", VA = "0x18049B7C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6008184")]
		[Address(RVA = "0xCA7400", Offset = "0xCA6600", VA = "0x180CA7400")]
		public CardsTemplateController(GameObject go)
		{
		}

		[Token(Token = "0x6008185")]
		[Address(RVA = "0xCA72A0", Offset = "0xCA64A0", VA = "0x180CA72A0", Slot = "5")]
		public void StartDisp()
		{
		}

		[Token(Token = "0x6008186")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "7")]
		public void UpdateDisp()
		{
		}

		[Token(Token = "0x6008187")]
		[Address(RVA = "0xCA6FA0", Offset = "0xCA61A0", VA = "0x180CA6FA0", Slot = "6")]
		public void RemoveDisp()
		{
		}

		[Token(Token = "0x6008188")]
		[Address(RVA = "0xCA7150", Offset = "0xCA6350", VA = "0x180CA7150")]
		public void SetUnactiveSelectionItems()
		{
		}

		[Token(Token = "0x6008189")]
		[Address(RVA = "0xCA5D60", Offset = "0xCA4F60", VA = "0x180CA5D60")]
		public void Initialize(List<SelectionItem> items, bool isLetter, bool isExplanation = false, [Optional] Action onCompleted, int quizindex = 0, [Optional] QuestionData qdata)
		{
		}
	}

	[Token(Token = "0x20014E8")]
	protected class CardsTypeBehaviour : QuestionTypeBehaviour
	{
		[Token(Token = "0x400C97A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<ElementObjectManager> eomList;

		[Token(Token = "0x400C97B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private GameObject holder;

		[Token(Token = "0x400C97C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private GameObject Container;

		[Token(Token = "0x400C97D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private GameObject textGroup;

		[Token(Token = "0x400C97E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private string prefPath;

		[Token(Token = "0x400C97F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private GameObject templateGO;

		[Token(Token = "0x400C980")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private GameObject ContainerCopy;

		[Token(Token = "0x400C981")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private List<int> mrkList;

		[Token(Token = "0x400C982")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private List<SelectionButton> buttonList;

		[Token(Token = "0x400C983")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Dictionary<Content.Frame, Texture2D> textureDictinary;

		[Token(Token = "0x400C984")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private CardsTemplateController templateController;

		[Token(Token = "0x400C985")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private bool isLetter;

		[Token(Token = "0x170013D4")]
		public List<int> cardMrkList
		{
			[Token(Token = "0x6008190")]
			[Address(RVA = "0x49B7F0", Offset = "0x49A9F0", VA = "0x18049B7F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6008191")]
		[Address(RVA = "0xCA7D30", Offset = "0xCA6F30", VA = "0x180CA7D30")]
		public CardsTypeBehaviour(ViewControllerManager manager, BaseMenuViewController vc, ElementObjectManager parentEOM, ElementObjectManager viewEOM, bool isLetter = false)
		{
		}

		[Token(Token = "0x6008192")]
		[Address(RVA = "0xCA77C0", Offset = "0xCA69C0", VA = "0x180CA77C0", Slot = "4")]
		internal override void InitDisp(int id, bool isSamePath, QuestionData qdata)
		{
		}

		[Token(Token = "0x6008193")]
		[Address(RVA = "0xCA7C80", Offset = "0xCA6E80", VA = "0x180CA7C80", Slot = "7")]
		internal override void StartCountDown()
		{
		}

		[Token(Token = "0x6008194")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		internal override void UpdateDisp()
		{
		}

		[Token(Token = "0x6008195")]
		[Address(RVA = "0xCA7BF0", Offset = "0xCA6DF0", VA = "0x180CA7BF0", Slot = "6")]
		internal override void RemoveDisp()
		{
		}

		[Token(Token = "0x6008196")]
		[Address(RVA = "0xCA77A0", Offset = "0xCA69A0", VA = "0x180CA77A0", Slot = "8")]
		internal override void Answered()
		{
		}
	}

	[Token(Token = "0x20014EA")]
	public class CardsScrollTemplateController : QuestionTemplateController, ICertificationTemplateController
	{
		[Token(Token = "0x20014EB")]
		public class CardTemplateData
		{
			[Token(Token = "0x400C9B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly string L_HideTextGroup;

			[Token(Token = "0x400C9B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly string L_HideTextNormal;

			[Token(Token = "0x400C9B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private readonly string L_HideTextPenduram;

			[Token(Token = "0x400C9B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private readonly string L_HideName;

			[Token(Token = "0x400C9B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private readonly string L_HideLv;

			[Token(Token = "0x400C9B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private readonly string L_HideAtrType;

			[Token(Token = "0x400C9B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private readonly string L_CardImageHideTextNormal;

			[Token(Token = "0x400C9B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private readonly string L_CardImageHideTextPenduram;

			[Token(Token = "0x400C9B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private readonly string L_CardImageHideName;

			[Token(Token = "0x400C9B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private readonly string L_CardImageHideLv;

			[Token(Token = "0x400C9BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private readonly string L_CardImageHideAtrType;

			[Token(Token = "0x400C9BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private ElementObjectManager _eom;

			[Token(Token = "0x400C9BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public GameObject HideText;

			[Token(Token = "0x400C9BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public GameObject HideName;

			[Token(Token = "0x400C9BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			public GameObject HideLv;

			[Token(Token = "0x400C9BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			public GameObject HideAtrType;

			[Token(Token = "0x400C9C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public RawImage HideNameImage;

			[Token(Token = "0x400C9C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			public RawImage HideLvImage;

			[Token(Token = "0x400C9C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			public RawImage HideAtrTypeImage;

			[Token(Token = "0x400C9C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			public RawImage HideTextNormalImage;

			[Token(Token = "0x400C9C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			public RawImage HideTextPenduramImage;

			[Token(Token = "0x400C9C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			public GameObject Normal;

			[Token(Token = "0x400C9C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			public GameObject Pe;

			[Token(Token = "0x400C9C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			public SelectionButton btn;

			[Token(Token = "0x400C9C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			public bool isP;

			[Token(Token = "0x170013D6")]
			public ElementObjectManager eom
			{
				[Token(Token = "0x60081AF")]
				[Address(RVA = "0x49B9F0", Offset = "0x49ABF0", VA = "0x18049B9F0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60081B0")]
			[Address(RVA = "0xC9CA00", Offset = "0xC9BC00", VA = "0x180C9CA00")]
			public CardTemplateData(ElementObjectManager eom)
			{
			}
		}

		[Token(Token = "0x20014F2")]
		[CompilerGenerated]
		private sealed class _003CyPlayPaging_003Ed__58 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400C9D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400C9D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400C9DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int direction;

			[Token(Token = "0x400C9DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public CardsScrollTemplateController _003C_003E4__this;

			[Token(Token = "0x400C9DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private string _003CoutKey_003E5__2;

			[Token(Token = "0x400C9DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private string _003CinKey_003E5__3;

			[Token(Token = "0x170013D7")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x60081C3")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170013D8")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x60081C5")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60081C0")]
			[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
			[DebuggerHidden]
			public _003CyPlayPaging_003Ed__58(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60081C1")]
			[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x60081C2")]
			[Address(RVA = "0xCAED80", Offset = "0xCADF80", VA = "0x180CAED80", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60081C4")]
			[Address(RVA = "0xCAF1D0", Offset = "0xCAE3D0", VA = "0x180CAF1D0", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x400C989")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Selector _selector;

		[Token(Token = "0x400C98A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly string L_NextButton;

		[Token(Token = "0x400C98B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly string L_PrevButton;

		[Token(Token = "0x400C98C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly string L_ShortcutButtonL1;

		[Token(Token = "0x400C98D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly string L_ShortcutButtonR1;

		[Token(Token = "0x400C98E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly string k_TLabelPagingNextOut;

		[Token(Token = "0x400C98F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private readonly string k_TLabelPagingBackOut;

		[Token(Token = "0x400C990")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private readonly string k_TLabelPagingNextIn;

		[Token(Token = "0x400C991")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private readonly string k_TLabelPagingBackIn;

		[Token(Token = "0x400C992")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private string m_TweenIndicatorOn;

		[Token(Token = "0x400C993")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private string m_TweenIndicatorOff;

		[Token(Token = "0x400C994")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private bool isDetailClose;

		[Token(Token = "0x400C995")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x81")]
		private bool isHideText;

		[Token(Token = "0x400C996")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x82")]
		private bool isHideLv;

		[Token(Token = "0x400C997")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x83")]
		private bool isHideName;

		[Token(Token = "0x400C998")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private bool isHideAtrType;

		[Token(Token = "0x400C999")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private List<ElementObjectManager> eomList;

		[Token(Token = "0x400C99A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private GameObject templateGO;

		[Token(Token = "0x400C99B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private SlidePagerWidget slidePagerWidget;

		[Token(Token = "0x400C99C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private GameObject m_ShortCutL1;

		[Token(Token = "0x400C99D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private GameObject m_ShortCutR1;

		[Token(Token = "0x400C99E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private SelectionButton m_PrevButton;

		[Token(Token = "0x400C99F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private SelectionButton m_NextButton;

		[Token(Token = "0x400C9A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int m_PageIdx;

		[Token(Token = "0x400C9A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int m_PageCount;

		[Token(Token = "0x400C9A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private List<int> subMrkList;

		[Token(Token = "0x400C9A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private List<int> hidePageList;

		[Token(Token = "0x400C9A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private List<int> mrkList;

		[Token(Token = "0x400C9A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Dictionary<Content.Frame, Texture2D> textureDictinary;

		[Token(Token = "0x400C9A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private List<SelectionItem> _buttonList;

		[Token(Token = "0x400C9A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private List<SelectionItem> _buttonObjList;

		[Token(Token = "0x400C9A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private int currentSelectIndex;

		[Token(Token = "0x400C9A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private List<CardTemplateData> cardTemplateDatas;

		[Token(Token = "0x400C9AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private List<GameObject> pagerMap;

		[Token(Token = "0x400C9AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private bool isActiveShortcut;

		[Token(Token = "0x400C9AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public Action onChangedPage;

		[Token(Token = "0x400C9AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Dictionary<string, object> Args;

		[Token(Token = "0x400C9AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private PlatformOverriderGroup pog;

		[Token(Token = "0x400C9AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private List<int> partMrkList;

		[Token(Token = "0x170013D5")]
		public List<SelectionItem> buttonList
		{
			[Token(Token = "0x600819B")]
			[Address(RVA = "0x5961D0", Offset = "0x5953D0", VA = "0x1805961D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600819C")]
		[Address(RVA = "0xCA1400", Offset = "0xCA0600", VA = "0x180CA1400")]
		public CardsScrollTemplateController(GameObject go)
		{
		}

		[Token(Token = "0x600819D")]
		[Address(RVA = "0xCA0920", Offset = "0xC9FB20", VA = "0x180CA0920", Slot = "5")]
		public void StartDisp()
		{
		}

		[Token(Token = "0x600819E")]
		[Address(RVA = "0xCA05A0", Offset = "0xC9F7A0", VA = "0x180CA05A0", Slot = "6")]
		public void RemoveDisp()
		{
		}

		[Token(Token = "0x600819F")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "7")]
		public void UpdateDisp()
		{
		}

		[Token(Token = "0x60081A0")]
		[Address(RVA = "0xCA0750", Offset = "0xC9F950", VA = "0x180CA0750")]
		public void SetActiveSelectionItems(bool frag)
		{
		}

		[Token(Token = "0x60081A1")]
		[Address(RVA = "0xC9EE20", Offset = "0xC9E020", VA = "0x180C9EE20")]
		public void Initialize(List<SelectionItem> items, string path, bool isExplanation = false, [Optional] Action onCompleted, [Optional] QuestionData qdata)
		{
		}

		[Token(Token = "0x60081A2")]
		[Address(RVA = "0xCA0C20", Offset = "0xC9FE20", VA = "0x180CA0C20")]
		private void UpdateView(bool isFirst = false)
		{
		}

		[Token(Token = "0x60081A3")]
		[Address(RVA = "0xCA0A20", Offset = "0xC9FC20", VA = "0x180CA0A20")]
		private void UnactiveHideMode(ElementObjectManager cardeom, int templateIdx, int i, List<int> mrklist)
		{
		}

		[Token(Token = "0x60081A4")]
		[Address(RVA = "0xC9E4D0", Offset = "0xC9D6D0", VA = "0x180C9E4D0")]
		private void ActiveHideMode(ElementObjectManager cardeom, int templateIndex, int idx, List<int> mrkList)
		{
		}

		[Token(Token = "0x60081A5")]
		[Address(RVA = "0xCA0590", Offset = "0xC9F790", VA = "0x180CA0590")]
		private void RefreshPage()
		{
		}

		[Token(Token = "0x60081A6")]
		[Address(RVA = "0x5867E0", Offset = "0x5859E0", VA = "0x1805867E0")]
		private void OnChangedPage()
		{
		}

		[Token(Token = "0x60081A7")]
		[Address(RVA = "0xCA0550", Offset = "0xC9F750", VA = "0x180CA0550")]
		private void OnClickNextButton()
		{
		}

		[Token(Token = "0x60081A8")]
		[Address(RVA = "0xCA0570", Offset = "0xC9F770", VA = "0x180CA0570")]
		private void OnClickPrevButton()
		{
		}

		[Token(Token = "0x60081A9")]
		[Address(RVA = "0xCA0550", Offset = "0xC9F750", VA = "0x180CA0550")]
		private void ToNextPage()
		{
		}

		[Token(Token = "0x60081AA")]
		[Address(RVA = "0xCA0570", Offset = "0xC9F770", VA = "0x180CA0570")]
		private void ToPrevPage()
		{
		}

		[Token(Token = "0x60081AB")]
		[Address(RVA = "0xC9ECF0", Offset = "0xC9DEF0", VA = "0x180C9ECF0")]
		private void ChangePage(int dstIdx, int direction = 0)
		{
		}

		[Token(Token = "0x60081AC")]
		[Address(RVA = "0xCA1900", Offset = "0xCA0B00", VA = "0x180CA1900")]
		[IteratorStateMachine(typeof(_003CyPlayPaging_003Ed__58))]
		private IEnumerator yPlayPaging(int direction = 0)
		{
			return null;
		}

		[Token(Token = "0x60081AD")]
		[Address(RVA = "0x951EA0", Offset = "0x9510A0", VA = "0x180951EA0")]
		private string GetTLabelPagingOut(int direction)
		{
			return null;
		}

		[Token(Token = "0x60081AE")]
		[Address(RVA = "0xC9EE10", Offset = "0xC9E010", VA = "0x180C9EE10")]
		private string GetTLabelPagingIn(int direction)
		{
			return null;
		}
	}

	[Token(Token = "0x20014F3")]
	protected class CardsScrollTypeBehaviour : QuestionTypeBehaviour
	{
		[Token(Token = "0x400C9DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<ElementObjectManager> eomList;

		[Token(Token = "0x400C9DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private GameObject holder;

		[Token(Token = "0x400C9E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private GameObject Container;

		[Token(Token = "0x400C9E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private GameObject textGroup;

		[Token(Token = "0x400C9E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private string prefPath;

		[Token(Token = "0x400C9E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private GameObject templateGO;

		[Token(Token = "0x400C9E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private GameObject ContainerCopy;

		[Token(Token = "0x400C9E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private List<int> mrkList;

		[Token(Token = "0x400C9E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private List<SelectionButton> buttonList;

		[Token(Token = "0x400C9E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Dictionary<Content.Frame, Texture2D> textureDictinary;

		[Token(Token = "0x400C9E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private CardsScrollTemplateController templateController;

		[Token(Token = "0x400C9E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private bool isLetter;

		[Token(Token = "0x170013D9")]
		public List<int> cardMrkList
		{
			[Token(Token = "0x60081C6")]
			[Address(RVA = "0x49B7F0", Offset = "0x49A9F0", VA = "0x18049B7F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60081C7")]
		[Address(RVA = "0xCA20D0", Offset = "0xCA12D0", VA = "0x180CA20D0")]
		public CardsScrollTypeBehaviour(ViewControllerManager manager, BaseMenuViewController vc, ElementObjectManager parentEOM, ElementObjectManager viewEOM, bool isLetter = false)
		{
		}

		[Token(Token = "0x60081C8")]
		[Address(RVA = "0xCA19A0", Offset = "0xCA0BA0", VA = "0x180CA19A0", Slot = "4")]
		internal override void InitDisp(int id, bool isSamePath, QuestionData qdata)
		{
		}

		[Token(Token = "0x60081C9")]
		[Address(RVA = "0xCA1F40", Offset = "0xCA1140", VA = "0x180CA1F40", Slot = "7")]
		internal override void StartCountDown()
		{
		}

		[Token(Token = "0x60081CA")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		internal override void UpdateDisp()
		{
		}

		[Token(Token = "0x60081CB")]
		[Address(RVA = "0xCA1EB0", Offset = "0xCA10B0", VA = "0x180CA1EB0", Slot = "6")]
		internal override void RemoveDisp()
		{
		}

		[Token(Token = "0x60081CC")]
		[Address(RVA = "0xCA1980", Offset = "0xCA0B80", VA = "0x180CA1980", Slot = "8")]
		internal override void Answered()
		{
		}
	}

	[Token(Token = "0x20014F5")]
	public class CardsSnapScrollTemplateController : QuestionTemplateController, ICertificationTemplateController
	{
		[Token(Token = "0x20014F6")]
		public enum HideType
		{
			[Token(Token = "0x400CA17")]
			None,
			[Token(Token = "0x400CA18")]
			Name,
			[Token(Token = "0x400CA19")]
			Text,
			[Token(Token = "0x400CA1A")]
			Lv,
			[Token(Token = "0x400CA1B")]
			AtrType
		}

		[Token(Token = "0x20014F7")]
		public class PageTemplate
		{
			[Token(Token = "0x400CA1C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private ElementObjectManager eom;

			[Token(Token = "0x400CA1D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int index;

			[Token(Token = "0x400CA1E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public List<CardTemplateData> cards;

			[Token(Token = "0x400CA1F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public List<CardTemplateData> activeCards;

			[Token(Token = "0x400CA20")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public List<int> activeThumBtnIndexList;

			[Token(Token = "0x400CA21")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public int currentSelectIndex;

			[Token(Token = "0x400CA22")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Dictionary<Content.Frame, Texture2D> textureDictinary;

			[Token(Token = "0x400CA23")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Dictionary<string, object> Args;

			[Token(Token = "0x400CA24")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public UnityAction onSelectedCallBack;

			[Token(Token = "0x400CA25")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public UnityAction onDeselectedCallBack;

			[Token(Token = "0x400CA26")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public UnityAction<int> onClickCardBtn;

			[Token(Token = "0x400CA27")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Dictionary<int, UnityAction> onClickCardBtnMap;

			[Token(Token = "0x60081E6")]
			[Address(RVA = "0xCABDB0", Offset = "0xCAAFB0", VA = "0x180CABDB0")]
			public PageTemplate(ElementObjectManager eom, int index)
			{
			}

			[Token(Token = "0x60081E7")]
			[Address(RVA = "0x595530", Offset = "0x594730", VA = "0x180595530")]
			public void setTextureDic(Dictionary<Content.Frame, Texture2D> dic)
			{
			}

			[Token(Token = "0x60081E8")]
			[Address(RVA = "0xCAB550", Offset = "0xCAA750", VA = "0x180CAB550")]
			public void Initialize(int pageIdx, HideType hideType, [Optional] List<int> mrkList, bool isExplanation = false, [Optional] Action onCompleted)
			{
			}

			[Token(Token = "0x60081E9")]
			[Address(RVA = "0xCABC60", Offset = "0xCAAE60", VA = "0x180CABC60")]
			public void SetActiveCards(bool frag)
			{
			}
		}

		[Token(Token = "0x20014FA")]
		public class CardTemplateData
		{
			[Token(Token = "0x400CA2D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly string L_HideTextGroup;

			[Token(Token = "0x400CA2E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly string L_HideTextNormal;

			[Token(Token = "0x400CA2F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private readonly string L_HideTextPenduram;

			[Token(Token = "0x400CA30")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private readonly string L_HideName;

			[Token(Token = "0x400CA31")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private readonly string L_HideLv;

			[Token(Token = "0x400CA32")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private readonly string L_HideAtrType;

			[Token(Token = "0x400CA33")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private readonly string L_CardImageHideTextNormal;

			[Token(Token = "0x400CA34")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private readonly string L_CardImageHideTextPenduram;

			[Token(Token = "0x400CA35")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private readonly string L_CardImageHideName;

			[Token(Token = "0x400CA36")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private readonly string L_CardImageHideLv;

			[Token(Token = "0x400CA37")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private readonly string L_CardImageHideAtrType;

			[Token(Token = "0x400CA38")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private readonly string L_CardImage;

			[Token(Token = "0x400CA39")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private ElementObjectManager _eom;

			[Token(Token = "0x400CA3A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public GameObject HideText;

			[Token(Token = "0x400CA3B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			public GameObject HideName;

			[Token(Token = "0x400CA3C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			public GameObject HideLv;

			[Token(Token = "0x400CA3D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public GameObject HideAtrType;

			[Token(Token = "0x400CA3E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			public RawImage HideNameImage;

			[Token(Token = "0x400CA3F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			public RawImage HideLvImage;

			[Token(Token = "0x400CA40")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			public RawImage HideAtrTypeImage;

			[Token(Token = "0x400CA41")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			public RawImage HideTextNormalImage;

			[Token(Token = "0x400CA42")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			public RawImage HideTextPenduramImage;

			[Token(Token = "0x400CA43")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			public GameObject Normal;

			[Token(Token = "0x400CA44")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			public GameObject Pe;

			[Token(Token = "0x400CA45")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			public GameObject cardImage;

			[Token(Token = "0x400CA46")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			public int index;

			[Token(Token = "0x400CA47")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			public SelectionButton btn;

			[Token(Token = "0x400CA48")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private Texture2D renderTexture;

			[Token(Token = "0x400CA49")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			public HideType hideType;

			[Token(Token = "0x400CA4A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
			public bool isActive;

			[Token(Token = "0x400CA4B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			public int mrk;

			[Token(Token = "0x170013DC")]
			public ElementObjectManager eom
			{
				[Token(Token = "0x60081EF")]
				[Address(RVA = "0x449820", Offset = "0x448A20", VA = "0x180449820")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170013DD")]
			public bool isP
			{
				[Token(Token = "0x60081F0")]
				[Address(RVA = "0xC9D480", Offset = "0xC9C680", VA = "0x180C9D480")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60081F1")]
			[Address(RVA = "0xC9CE20", Offset = "0xC9C020", VA = "0x180C9CE20")]
			public CardTemplateData(ElementObjectManager eom, int index)
			{
			}

			[Token(Token = "0x60081F2")]
			[Address(RVA = "0xC9D2E0", Offset = "0xC9C4E0", VA = "0x180C9D2E0")]
			public void bindingCardImage(bool isBind = true)
			{
			}

			[Token(Token = "0x60081F3")]
			[Address(RVA = "0xC9C9C0", Offset = "0xC9BBC0", VA = "0x180C9C9C0")]
			public void SetTextureAndActiveHide(Texture2D renderTexture)
			{
			}

			[Token(Token = "0x60081F4")]
			[Address(RVA = "0xC9C790", Offset = "0xC9B990", VA = "0x180C9C790")]
			public void SetOnClickBtn(int i, List<int> mrklist, [Optional] Dictionary<string, object> Args)
			{
			}

			[Token(Token = "0x60081F5")]
			[Address(RVA = "0xC9C300", Offset = "0xC9B500", VA = "0x180C9C300")]
			public void HideModeChangeByType(HideType hideType)
			{
			}
		}

		[Token(Token = "0x20014FF")]
		[CompilerGenerated]
		private sealed class _003CyPlayPaging_003Ed__64 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400CA58")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400CA59")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400CA5A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int direction;

			[Token(Token = "0x400CA5B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public CardsSnapScrollTemplateController _003C_003E4__this;

			[Token(Token = "0x170013DE")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6008206")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170013DF")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6008208")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6008203")]
			[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
			[DebuggerHidden]
			public _003CyPlayPaging_003Ed__64(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6008204")]
			[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6008205")]
			[Address(RVA = "0xCAF210", Offset = "0xCAE410", VA = "0x180CAF210", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6008207")]
			[Address(RVA = "0xCAF570", Offset = "0xCAE770", VA = "0x180CAF570", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x400C9ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Selector _selector;

		[Token(Token = "0x400C9EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly string L_NextButton;

		[Token(Token = "0x400C9EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly string L_PrevButton;

		[Token(Token = "0x400C9F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly string L_ShortcutButtonL1;

		[Token(Token = "0x400C9F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly string L_ShortcutButtonR1;

		[Token(Token = "0x400C9F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly string k_TLabelPagingNextOut;

		[Token(Token = "0x400C9F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private readonly string k_TLabelPagingBackOut;

		[Token(Token = "0x400C9F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private readonly string k_TLabelPagingNextIn;

		[Token(Token = "0x400C9F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private readonly string k_TLabelPagingBackIn;

		[Token(Token = "0x400C9F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private readonly string L_snapTemplate;

		[Token(Token = "0x400C9F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private string m_TweenIndicatorOn;

		[Token(Token = "0x400C9F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private string m_TweenIndicatorOff;

		[Token(Token = "0x400C9F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private bool isActiveShortcut;

		[Token(Token = "0x400C9FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
		private bool isHideText;

		[Token(Token = "0x400C9FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8A")]
		private bool isHideLv;

		[Token(Token = "0x400C9FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8B")]
		private bool isHideName;

		[Token(Token = "0x400C9FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private bool isHideAtrType;

		[Token(Token = "0x400C9FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private GameObject templateGO;

		[Token(Token = "0x400C9FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private ScrollRectPageSnap m_PageSnap;

		[Token(Token = "0x400CA00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private ExtendedScrollRect m_ScrollRect;

		[Token(Token = "0x400CA01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private RectSelectionItem m_RectSelectionItem;

		[Token(Token = "0x400CA02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private CanvasGroup m_CanvasGroup;

		[Token(Token = "0x400CA03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private SlidePagerWidget slidePagerWidget;

		[Token(Token = "0x400CA04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private GameObject m_ShortCutL1;

		[Token(Token = "0x400CA05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private GameObject m_ShortCutR1;

		[Token(Token = "0x400CA06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private SelectionButton m_PrevButton;

		[Token(Token = "0x400CA07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private SelectionButton m_NextButton;

		[Token(Token = "0x400CA08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int m_PageIdx;

		[Token(Token = "0x400CA09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private int m_PageCount;

		[Token(Token = "0x400CA0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int currentSelectIndex;

		[Token(Token = "0x400CA0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public Action onChangedPage;

		[Token(Token = "0x400CA0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private List<SelectionItem> buttonList;

		[Token(Token = "0x400CA0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private List<SelectionItem> _buttonObjList;

		[Token(Token = "0x400CA0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private List<int> subMrkList;

		[Token(Token = "0x400CA0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private List<int> hidePageList;

		[Token(Token = "0x400CA10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private List<GameObject> pagerMap;

		[Token(Token = "0x400CA11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private List<int> mrkList;

		[Token(Token = "0x400CA12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public Dictionary<Content.Frame, Texture2D> textureDictinary;

		[Token(Token = "0x400CA13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Dictionary<string, object> Args;

		[Token(Token = "0x400CA14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Dictionary<int, PageTemplate> pageTemplateMap;

		[Token(Token = "0x400CA15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private List<ElementObjectManager> snapTemplateEomMap;

		[Token(Token = "0x170013DA")]
		public Selector selector
		{
			[Token(Token = "0x60081D1")]
			[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170013DB")]
		public List<SelectionItem> buttonObjList
		{
			[Token(Token = "0x60081D2")]
			[Address(RVA = "0x5FC5E0", Offset = "0x5FB7E0", VA = "0x1805FC5E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60081D3")]
		[Address(RVA = "0xCA4DE0", Offset = "0xCA3FE0", VA = "0x180CA4DE0")]
		public CardsSnapScrollTemplateController(GameObject go)
		{
		}

		[Token(Token = "0x60081D4")]
		[Address(RVA = "0xCA4850", Offset = "0xCA3A50", VA = "0x180CA4850", Slot = "5")]
		public void StartDisp()
		{
		}

		[Token(Token = "0x60081D5")]
		[Address(RVA = "0xCA4400", Offset = "0xCA3600", VA = "0x180CA4400", Slot = "6")]
		public void RemoveDisp()
		{
		}

		[Token(Token = "0x60081D6")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "7")]
		public void UpdateDisp()
		{
		}

		[Token(Token = "0x60081D7")]
		[Address(RVA = "0xCA4680", Offset = "0xCA3880", VA = "0x180CA4680")]
		public void SetActiveSelectionItems(bool frag)
		{
		}

		[Token(Token = "0x60081D8")]
		[Address(RVA = "0xCA4990", Offset = "0xCA3B90", VA = "0x180CA4990")]
		public void StopSnapScroll()
		{
		}

		[Token(Token = "0x60081D9")]
		[Address(RVA = "0xCA2420", Offset = "0xCA1620", VA = "0x180CA2420")]
		public void Initialize(List<SelectionItem> items, string path, bool isExplanation = false, [Optional] Action onCompleted, [Optional] QuestionData qdata)
		{
		}

		[Token(Token = "0x60081DA")]
		[Address(RVA = "0xCA4080", Offset = "0xCA3280", VA = "0x180CA4080")]
		private void OnDeviceChange(SelectorManager.InputDevice inputDevice)
		{
		}

		[Token(Token = "0x60081DB")]
		[Address(RVA = "0xCA4A40", Offset = "0xCA3C40", VA = "0x180CA4A40")]
		private void UpdateView(bool isFirst = false)
		{
		}

		[Token(Token = "0x60081DC")]
		[Address(RVA = "0xCA43F0", Offset = "0xCA35F0", VA = "0x180CA43F0")]
		private void RefreshPage()
		{
		}

		[Token(Token = "0x60081DD")]
		[Address(RVA = "0xCA4020", Offset = "0xCA3220", VA = "0x180CA4020")]
		private void OnChangedPage()
		{
		}

		[Token(Token = "0x60081DE")]
		[Address(RVA = "0xCA4040", Offset = "0xCA3240", VA = "0x180CA4040")]
		private void OnClickNextButton()
		{
		}

		[Token(Token = "0x60081DF")]
		[Address(RVA = "0xCA4060", Offset = "0xCA3260", VA = "0x180CA4060")]
		private void OnClickPrevButton()
		{
		}

		[Token(Token = "0x60081E0")]
		[Address(RVA = "0xCA4040", Offset = "0xCA3240", VA = "0x180CA4040")]
		private void ToNextPage()
		{
		}

		[Token(Token = "0x60081E1")]
		[Address(RVA = "0xCA4060", Offset = "0xCA3260", VA = "0x180CA4060")]
		private void ToPrevPage()
		{
		}

		[Token(Token = "0x60081E2")]
		[Address(RVA = "0xCA2280", Offset = "0xCA1480", VA = "0x180CA2280")]
		private void ChangePage(int dstIdx, int direction = 0)
		{
		}

		[Token(Token = "0x60081E3")]
		[Address(RVA = "0xCA52E0", Offset = "0xCA44E0", VA = "0x180CA52E0")]
		[IteratorStateMachine(typeof(_003CyPlayPaging_003Ed__64))]
		private IEnumerator yPlayPaging(int direction = 0)
		{
			return null;
		}

		[Token(Token = "0x60081E4")]
		[Address(RVA = "0x951EA0", Offset = "0x9510A0", VA = "0x180951EA0")]
		private string GetTLabelPagingOut(int direction)
		{
			return null;
		}

		[Token(Token = "0x60081E5")]
		[Address(RVA = "0xC9EE10", Offset = "0xC9E010", VA = "0x180C9EE10")]
		private string GetTLabelPagingIn(int direction)
		{
			return null;
		}
	}

	[Token(Token = "0x2001500")]
	protected class CardsSnapScrollTypeBehaviour : QuestionTypeBehaviour
	{
		[Token(Token = "0x400CA5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<ElementObjectManager> eomList;

		[Token(Token = "0x400CA5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private GameObject holder;

		[Token(Token = "0x400CA5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private GameObject Container;

		[Token(Token = "0x400CA5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private GameObject textGroup;

		[Token(Token = "0x400CA60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private string prefPath;

		[Token(Token = "0x400CA61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private GameObject templateGO;

		[Token(Token = "0x400CA62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private GameObject ContainerCopy;

		[Token(Token = "0x400CA63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private List<int> mrkList;

		[Token(Token = "0x400CA64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private List<SelectionButton> buttonList;

		[Token(Token = "0x400CA65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Dictionary<Content.Frame, Texture2D> textureDictinary;

		[Token(Token = "0x400CA66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private CardsSnapScrollTemplateController templateController;

		[Token(Token = "0x400CA67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private bool isLetter;

		[Token(Token = "0x170013E0")]
		public List<int> cardMrkList
		{
			[Token(Token = "0x6008209")]
			[Address(RVA = "0x49B7F0", Offset = "0x49A9F0", VA = "0x18049B7F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600820A")]
		[Address(RVA = "0xCA5BB0", Offset = "0xCA4DB0", VA = "0x180CA5BB0")]
		public CardsSnapScrollTypeBehaviour(ViewControllerManager manager, BaseMenuViewController vc, ElementObjectManager parentEOM, ElementObjectManager viewEOM, bool isLetter = false)
		{
		}

		[Token(Token = "0x600820B")]
		[Address(RVA = "0xCA5440", Offset = "0xCA4640", VA = "0x180CA5440", Slot = "4")]
		internal override void InitDisp(int id, bool isSamePath, QuestionData qdata)
		{
		}

		[Token(Token = "0x600820C")]
		[Address(RVA = "0xCA59E0", Offset = "0xCA4BE0", VA = "0x180CA59E0", Slot = "7")]
		internal override void StartCountDown()
		{
		}

		[Token(Token = "0x600820D")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		internal override void UpdateDisp()
		{
		}

		[Token(Token = "0x600820E")]
		[Address(RVA = "0xCA5950", Offset = "0xCA4B50", VA = "0x180CA5950", Slot = "6")]
		internal override void RemoveDisp()
		{
		}

		[Token(Token = "0x600820F")]
		[Address(RVA = "0xCA5360", Offset = "0xCA4560", VA = "0x180CA5360", Slot = "8")]
		internal override void Answered()
		{
		}
	}

	[Token(Token = "0x2001502")]
	protected class PrefabTypeBehaviour : QuestionTypeBehaviour
	{
		[Token(Token = "0x400CA6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private GameObject templateGO;

		[Token(Token = "0x400CA6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private GameObject Container;

		[Token(Token = "0x400CA6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private GameObject largeContainer;

		[Token(Token = "0x400CA6E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private GameObject ContainerCopy;

		[Token(Token = "0x400CA6F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject textGroup;

		[Token(Token = "0x400CA70")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private GameObject overTextGroup;

		[Token(Token = "0x400CA71")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private GameObject infoBtnGo;

		[Token(Token = "0x400CA72")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private SelectionButton infoBtn;

		[Token(Token = "0x400CA73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private bool opening;

		[Token(Token = "0x400CA74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private int typeId;

		[Token(Token = "0x6008214")]
		[Address(RVA = "0xCAB540", Offset = "0xCAA740", VA = "0x180CAB540")]
		public PrefabTypeBehaviour(ViewControllerManager manager, BaseMenuViewController vc, ElementObjectManager parentEOM, ElementObjectManager viewEOM)
		{
		}

		[Token(Token = "0x6008215")]
		[Address(RVA = "0xCAC060", Offset = "0xCAB260", VA = "0x180CAC060", Slot = "4")]
		internal override void InitDisp(int id, bool isSamePath, QuestionData qdata)
		{
		}

		[Token(Token = "0x6008216")]
		[Address(RVA = "0xCAC390", Offset = "0xCAB590", VA = "0x180CAC390")]
		private void OnClickInfoBtn()
		{
		}

		[Token(Token = "0x6008217")]
		[Address(RVA = "0xCABFE0", Offset = "0xCAB1E0", VA = "0x180CABFE0")]
		private void Close()
		{
		}

		[Token(Token = "0x6008218")]
		[Address(RVA = "0xCAC4A0", Offset = "0xCAB6A0", VA = "0x180CAC4A0")]
		private void Open()
		{
		}

		[Token(Token = "0x6008219")]
		[Address(RVA = "0xCAC430", Offset = "0xCAB630", VA = "0x180CAC430")]
		private void OnLoadPrefabComplete(GameObject go)
		{
		}

		[Token(Token = "0x600821A")]
		[Address(RVA = "0xCAC600", Offset = "0xCAB800", VA = "0x180CAC600", Slot = "7")]
		internal override void StartCountDown()
		{
		}

		[Token(Token = "0x600821B")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		internal override void UpdateDisp()
		{
		}

		[Token(Token = "0x600821C")]
		[Address(RVA = "0xCAC520", Offset = "0xCAB720", VA = "0x180CAC520", Slot = "6")]
		internal override void RemoveDisp()
		{
		}

		[Token(Token = "0x600821D")]
		[Address(RVA = "0xCABEA0", Offset = "0xCAB0A0", VA = "0x180CABEA0", Slot = "8")]
		internal override void Answered()
		{
		}
	}

	[Token(Token = "0x2001503")]
	protected class StartCountDownTypeBehaviour : QuestionTypeBehaviour
	{
		[Token(Token = "0x400CA75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly string L_TextRank;

		[Token(Token = "0x400CA76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly string L_Icon;

		[Token(Token = "0x400CA77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private GameObject holder;

		[Token(Token = "0x400CA78")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private GameObject Container;

		[Token(Token = "0x400CA79")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private string prefPath;

		[Token(Token = "0x400CA7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float limitTime;

		[Token(Token = "0x400CA7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private bool isCompleteSetElements;

		[Token(Token = "0x400CA7C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private IAsyncProgressContent m_AsyncProgressContent;

		[Token(Token = "0x400CA7D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private GameObject templateGO;

		[Token(Token = "0x400CA7E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private GameObject ContainerCopy;

		[Token(Token = "0x400CA7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private CertificationWritingViewController vcCertifi;

		[Token(Token = "0x400CA80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private DownloadViewController vcDL;

		[Token(Token = "0x600821F")]
		[Address(RVA = "0xCAD270", Offset = "0xCAC470", VA = "0x180CAD270")]
		public StartCountDownTypeBehaviour(ViewControllerManager manager, CertificationWritingViewController vc, ElementObjectManager parentEOM, ElementObjectManager viewEOM)
		{
		}

		[Token(Token = "0x6008220")]
		[Address(RVA = "0xCAD190", Offset = "0xCAC390", VA = "0x180CAD190")]
		public StartCountDownTypeBehaviour(ViewControllerManager manager, DownloadViewController vc, ElementObjectManager parentEOM, ElementObjectManager viewEOM)
		{
		}

		[Token(Token = "0x6008221")]
		[Address(RVA = "0xCACAD0", Offset = "0xCABCD0", VA = "0x180CACAD0", Slot = "4")]
		internal override void InitDisp(int id, bool isSamePath, QuestionData qdata)
		{
		}

		[Token(Token = "0x6008222")]
		[Address(RVA = "0xCACE30", Offset = "0xCAC030", VA = "0x180CACE30")]
		private void SetCallBack(GameObject go)
		{
		}

		[Token(Token = "0x6008223")]
		[Address(RVA = "0xCAD140", Offset = "0xCAC340", VA = "0x180CAD140", Slot = "5")]
		internal override void UpdateDisp()
		{
		}

		[Token(Token = "0x6008224")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "7")]
		internal override void StartCountDown()
		{
		}

		[Token(Token = "0x6008225")]
		[Address(RVA = "0xCACDB0", Offset = "0xCABFB0", VA = "0x180CACDB0", Slot = "6")]
		internal override void RemoveDisp()
		{
		}

		[Token(Token = "0x6008226")]
		[Address(RVA = "0xCAC990", Offset = "0xCABB90", VA = "0x180CAC990", Slot = "8")]
		internal override void Answered()
		{
		}
	}

	[Token(Token = "0x2001504")]
	protected class AnsStartCountDownTypeBehaviour : AnswerTypeBehaviour
	{
		[Token(Token = "0x400CA81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private UnityAction onFinished;

		[Token(Token = "0x400CA82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private ExtendedTextMeshProUGUI countDownText;

		[Token(Token = "0x6008228")]
		[Address(RVA = "0xC9C190", Offset = "0xC9B390", VA = "0x180C9C190")]
		public AnsStartCountDownTypeBehaviour(ViewControllerManager manager, BaseMenuViewController vc, ElementObjectManager parentEOM, ElementObjectManager viewEOM, ElementObjectManager questionEOM, QuestionTypeBehaviour questionTypeBehaviour, CertificationRogicHander rogicHander)
		{
		}

		[Token(Token = "0x6008229")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "4")]
		internal override void InitData(int id, QuestionData qdata)
		{
		}

		[Token(Token = "0x600822A")]
		[Address(RVA = "0xC9BF80", Offset = "0xC9B180", VA = "0x180C9BF80", Slot = "5")]
		internal override void InitDisp(bool isLast, [Optional] UnityAction unityAction, [Optional] UnityAction onFinished)
		{
		}

		[Token(Token = "0x600822B")]
		[Address(RVA = "0xC9C110", Offset = "0xC9B310", VA = "0x180C9C110", Slot = "6")]
		internal override void UpdateDisp()
		{
		}

		[Token(Token = "0x600822C")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "8")]
		internal override void StartCountDown()
		{
		}

		[Token(Token = "0x600822D")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "9")]
		internal override void TimeOut()
		{
		}

		[Token(Token = "0x600822E")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "7")]
		internal override void RemoveDisp()
		{
		}

		[Token(Token = "0x600822F")]
		[Address(RVA = "0xC9C0C0", Offset = "0xC9B2C0", VA = "0x180C9C0C0")]
		internal void NextQuestion()
		{
		}
	}

	[Token(Token = "0x2001505")]
	public class QuestionData
	{
		[Token(Token = "0x400CA83")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CertificationUtil.AnswerType answerType;

		[Token(Token = "0x400CA84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public CertificationUtil.QuestionType questionType;

		[Token(Token = "0x400CA85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CertificationUtil.ViewType viewType;

		[Token(Token = "0x400CA86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string questionText;

		[Token(Token = "0x400CA87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string prefabPath;

		[Token(Token = "0x400CA88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string questionTemplatePath;

		[Token(Token = "0x400CA89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int LimitTime;

		[Token(Token = "0x400CA8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IAnswerData answerData;

		[Token(Token = "0x400CA8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public int quizId;

		[Token(Token = "0x6008230")]
		[Address(RVA = "0xCAC6C0", Offset = "0xCAB8C0", VA = "0x180CAC6C0")]
		public QuestionData(CertificationUtil.AnswerType answerType, CertificationUtil.QuestionType questionType, string questionText, string prefabPath, string questionTempPath, int LimitTime, CertificationUtil.ViewType viewType)
		{
		}

		[Token(Token = "0x6008231")]
		[Address(RVA = "0x40C450", Offset = "0x40B650", VA = "0x18040C450")]
		public int GetLimitTime()
		{
			return default(int);
		}
	}

	[Token(Token = "0x2001506")]
	public interface IAnswerData
	{
	}

	[Token(Token = "0x2001507")]
	public class ChoicesAnswerData : IAnswerData
	{
		[Token(Token = "0x400CA8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<string> answers;

		[Token(Token = "0x400CA8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int correctAnswerIndex;

		[Token(Token = "0x6008232")]
		[Address(RVA = "0x955B70", Offset = "0x954D70", VA = "0x180955B70")]
		public ChoicesAnswerData(List<string> answers, int correctAnswerIndex)
		{
		}
	}

	[Token(Token = "0x2001508")]
	public interface ICertificationTemplateController
	{
		[Token(Token = "0x6008233")]
		void StartDisp();

		[Token(Token = "0x6008234")]
		void RemoveDisp();

		[Token(Token = "0x6008235")]
		void UpdateDisp();
	}

	[Token(Token = "0x2001509")]
	public class QuestionTemplateController
	{
		[Token(Token = "0x400CA8E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private ElementObjectManager _eom;

		[Token(Token = "0x400CA8F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private PlatformOverriderGroup pog;

		[Token(Token = "0x400CA90")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool isExplanation;

		[Token(Token = "0x400CA91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public CertificationUtil.ViewType viewType;

		[Token(Token = "0x170013E1")]
		public ElementObjectManager eom
		{
			[Token(Token = "0x6008236")]
			[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6008237")]
		[Address(RVA = "0xCAC860", Offset = "0xCABA60", VA = "0x180CAC860")]
		public QuestionTemplateController(GameObject go)
		{
		}

		[Token(Token = "0x6008238")]
		[Address(RVA = "0xCAC750", Offset = "0xCAB950", VA = "0x180CAC750", Slot = "4")]
		public virtual void OverriderActivate()
		{
		}
	}

	[Token(Token = "0x200150A")]
	protected abstract class AnswerTypeBehaviour
	{
		[Token(Token = "0x400CA92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected readonly string QUESTION_TEXT_LABEL;

		[Token(Token = "0x400CA93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected readonly string BUTTON_LABEL;

		[Token(Token = "0x400CA94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected readonly string COUNTDOWN_TEXT_LABEL;

		[Token(Token = "0x400CA95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected readonly string FOOTER_AREA_LABEL;

		[Token(Token = "0x400CA96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal readonly ViewControllerManager manager;

		[Token(Token = "0x400CA97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal readonly BaseMenuViewController vc;

		[Token(Token = "0x400CA98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal readonly ElementObjectManager parentEOM;

		[Token(Token = "0x400CA99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected ElementObjectManager viewEOM;

		[Token(Token = "0x400CA9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected ElementObjectManager questionViewEOM;

		[Token(Token = "0x400CA9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected CertificationRogicHander rogicHander;

		[Token(Token = "0x400CA9C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		internal float limitTime;

		[Token(Token = "0x400CA9D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		internal bool timeOut;

		[Token(Token = "0x400CA9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
		internal bool answered;

		[Token(Token = "0x400CA9F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x66")]
		internal bool isCorrectAnswer;

		[Token(Token = "0x400CAA0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x67")]
		internal bool isReady;

		[Token(Token = "0x400CAA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		internal object objectTypeAnswer;

		[Token(Token = "0x400CAA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		protected QuestionTypeBehaviour questionTypeBehaviour;

		[Token(Token = "0x6008239")]
		[Address(RVA = "0xC9C190", Offset = "0xC9B390", VA = "0x180C9C190")]
		protected AnswerTypeBehaviour(ViewControllerManager manager, BaseMenuViewController vc, ElementObjectManager parentEOM, ElementObjectManager viewEOM, ElementObjectManager quesEOM, QuestionTypeBehaviour typeBehaviour, CertificationRogicHander rogicHander)
		{
		}

		[Token(Token = "0x600823A")]
		internal abstract void InitData(int id, QuestionData qdata);

		[Token(Token = "0x600823B")]
		internal abstract void InitDisp(bool isLast, [Optional] UnityAction mateAction, [Optional] UnityAction onFinished);

		[Token(Token = "0x600823C")]
		internal abstract void UpdateDisp();

		[Token(Token = "0x600823D")]
		internal abstract void RemoveDisp();

		[Token(Token = "0x600823E")]
		internal abstract void StartCountDown();

		[Token(Token = "0x600823F")]
		internal abstract void TimeOut();
	}

	[Token(Token = "0x200150B")]
	protected abstract class QuestionTypeBehaviour
	{
		[Token(Token = "0x400CAA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected readonly string TEXT_LABEL;

		[Token(Token = "0x400CAA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected ElementObjectManager viewEOM;

		[Token(Token = "0x400CAA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal readonly ViewControllerManager manager;

		[Token(Token = "0x400CAA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal readonly BaseMenuViewController vc;

		[Token(Token = "0x400CAA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal readonly ElementObjectManager parentEOM;

		[Token(Token = "0x400CAA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal bool eventFrag;

		[Token(Token = "0x400CAA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		internal bool isReady;

		[Token(Token = "0x400CAAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal List<SelectionItem> selectionItems;

		[Token(Token = "0x6008240")]
		[Address(RVA = "0xCAC8D0", Offset = "0xCABAD0", VA = "0x180CAC8D0")]
		protected QuestionTypeBehaviour(ViewControllerManager manager, BaseMenuViewController vc, ElementObjectManager parentEOM, ElementObjectManager viewEOM)
		{
		}

		[Token(Token = "0x6008241")]
		internal abstract void InitDisp(int id, bool isSamePath, QuestionData qdata);

		[Token(Token = "0x6008242")]
		internal abstract void UpdateDisp();

		[Token(Token = "0x6008243")]
		internal abstract void RemoveDisp();

		[Token(Token = "0x6008244")]
		internal abstract void StartCountDown();

		[Token(Token = "0x6008245")]
		internal abstract void Answered();
	}

	[Token(Token = "0x200150C")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass105_0
	{
		[Token(Token = "0x400CAAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CertificationRogicHander _003C_003E4__this;

		[Token(Token = "0x400CAAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public DialogViewControllerManager dlgViewMgr;

		[Token(Token = "0x400CAAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action _003C_003E9__2;

		[Token(Token = "0x400CAAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UnityAction _003C_003E9__4;

		[Token(Token = "0x6008246")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass105_0()
		{
		}

		[Token(Token = "0x6008247")]
		[Address(RVA = "0xCAD4D0", Offset = "0xCAC6D0", VA = "0x180CAD4D0")]
		internal void _003CyStartWriting_003Eb__2()
		{
		}

		[Token(Token = "0x6008248")]
		[Address(RVA = "0xCAD4F0", Offset = "0xCAC6F0", VA = "0x180CAD4F0")]
		internal void _003CyStartWriting_003Eb__4()
		{
		}

		[Token(Token = "0x6008249")]
		[Address(RVA = "0xCAD4A0", Offset = "0xCAC6A0", VA = "0x180CAD4A0")]
		internal bool _003CyStartWriting_003Eb__0()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200150D")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass105_1
	{
		[Token(Token = "0x400CAAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public KeyValuePair<int, QuestionData> question;

		[Token(Token = "0x400CAB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public _003C_003Ec__DisplayClass105_0 CS_0024_003C_003E8__locals1;

		[Token(Token = "0x600824A")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass105_1()
		{
		}

		[Token(Token = "0x600824B")]
		[Address(RVA = "0xCAD540", Offset = "0xCAC740", VA = "0x180CAD540")]
		internal void _003CyStartWriting_003Eb__3()
		{
		}

		[Token(Token = "0x600824C")]
		[Address(RVA = "0xCAD710", Offset = "0xCAC910", VA = "0x180CAD710")]
		internal void _003CyStartWriting_003Eb__5(GameObject res)
		{
		}
	}

	[Token(Token = "0x200150E")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass105_2
	{
		[Token(Token = "0x400CAB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool isLoadedQuestionTemp;

		[Token(Token = "0x400CAB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool isChangeViewType;

		[Token(Token = "0x400CAB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public _003C_003Ec__DisplayClass105_1 CS_0024_003C_003E8__locals2;

		[Token(Token = "0x600824D")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass105_2()
		{
		}

		[Token(Token = "0x600824E")]
		[Address(RVA = "0xCAD8A0", Offset = "0xCACAA0", VA = "0x180CAD8A0")]
		internal void _003CyStartWriting_003Eb__1(GameObject res)
		{
		}
	}

	[Token(Token = "0x200150F")]
	[CompilerGenerated]
	private sealed class _003CyStartWriting_003Ed__105 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400CAB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400CAB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400CAB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CertificationRogicHander _003C_003E4__this;

		[Token(Token = "0x400CAB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass105_0 _003C_003E8__1;

		[Token(Token = "0x400CAB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass105_2 _003C_003E8__2;

		[Token(Token = "0x400CAB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Dictionary<string, object> _003CArgs_003E5__2;

		[Token(Token = "0x400CABA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Dictionary<int, QuestionData>.Enumerator _003C_003E7__wrap2;

		[Token(Token = "0x400CABB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool _003CisLast_003E5__4;

		[Token(Token = "0x400CABC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private UnityAction _003CfinisedAction_003E5__5;

		[Token(Token = "0x400CABD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private UnityAction _003CmateAction_003E5__6;

		[Token(Token = "0x400CABE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private bool _003CtimerActive_003E5__7;

		[Token(Token = "0x170013E2")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6008253")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170013E3")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6008255")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600824F")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyStartWriting_003Ed__105(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6008250")]
		[Address(RVA = "0xCB2160", Offset = "0xCB1360", VA = "0x180CB2160", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6008251")]
		[Address(RVA = "0xCAF5B0", Offset = "0xCAE7B0", VA = "0x180CAF5B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6008252")]
		[Address(RVA = "0xCB21F0", Offset = "0xCB13F0", VA = "0x180CB21F0")]
		private void _003C_003Em__Finally1()
		{
		}

		[Token(Token = "0x6008254")]
		[Address(RVA = "0xCB2120", Offset = "0xCB1320", VA = "0x180CB2120", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400C8C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	protected readonly string L_Main;

	[Token(Token = "0x400C8C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected readonly string L_QuestionArea;

	[Token(Token = "0x400C8C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected readonly string L_AnswerArea;

	[Token(Token = "0x400C8C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected readonly string L_TimerRoot;

	[Token(Token = "0x400C8C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	protected readonly string L_TimerNum;

	[Token(Token = "0x400C8C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	protected readonly string L_QuestionStart;

	[Token(Token = "0x400C8CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	protected readonly string L_QuestionCorrect;

	[Token(Token = "0x400C8CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	protected readonly string L_QuestionIncorrect;

	[Token(Token = "0x400C8CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	protected readonly string L_QuestionTimeout;

	[Token(Token = "0x400C8CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	protected readonly string L_TextQuestionNum;

	[Token(Token = "0x400C8CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	protected readonly string L_Tween_Default;

	[Token(Token = "0x400C8CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	protected readonly string L_Tween_Animate;

	[Token(Token = "0x400C8D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	protected string countDownPrefabPath;

	[Token(Token = "0x400C8D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private GameObject timerRoot;

	[Token(Token = "0x400C8D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private GameObject timerBase0;

	[Token(Token = "0x400C8D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private GameObject timerBase1;

	[Token(Token = "0x400C8D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private GameObject timerBase2;

	[Token(Token = "0x400C8D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private GameObject timerGauge0;

	[Token(Token = "0x400C8D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private GameObject timerGauge1;

	[Token(Token = "0x400C8D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private Image fillAmountImage;

	[Token(Token = "0x400C8D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	protected GameObject questionStart;

	[Token(Token = "0x400C8D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	protected GameObject questionCorrect;

	[Token(Token = "0x400C8DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	protected GameObject questionIncorrect;

	[Token(Token = "0x400C8DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	protected GameObject questionTimeout;

	[Token(Token = "0x400C8DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	protected ExtendedTextMeshProUGUI textQuestionNum;

	[Token(Token = "0x400C8DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private bool startButtonClick;

	[Token(Token = "0x400C8DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE9")]
	private bool timeOut;

	[Token(Token = "0x400C8DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEA")]
	public bool finishQuestion;

	[Token(Token = "0x400C8E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEB")]
	public bool isAnswerTweenStart;

	[Token(Token = "0x400C8E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	public bool finishAllQuestion;

	[Token(Token = "0x400C8E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private float currentQuestionLimitTime;

	[Token(Token = "0x400C8E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	private float currentTime;

	[Token(Token = "0x400C8E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private int totalQuestionNum;

	[Token(Token = "0x400C8E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	private int requireNum;

	[Token(Token = "0x400C8E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private int GradeIndex;

	[Token(Token = "0x400C8E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
	public bool isReadyMate;

	[Token(Token = "0x400C8E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private ElementObjectManager viewEom;

	[Token(Token = "0x400C8E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	protected ElementObjectManager questionViewEom;

	[Token(Token = "0x400C8EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	protected ElementObjectManager mainEom;

	[Token(Token = "0x400C8EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	protected ElementObjectManager questionAreaEom;

	[Token(Token = "0x400C8EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	protected ElementObjectManager answerAreaEom;

	[Token(Token = "0x400C8ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	protected ExtendedTextMeshProUGUI countDownText;

	[Token(Token = "0x400C8EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	protected SelectionButton retireButton;

	[Token(Token = "0x400C8EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	protected ExtendedTextMeshProUGUI questionText;

	[Token(Token = "0x400C8F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	protected ContentSizeFitter sizeFitter;

	[Token(Token = "0x400C8F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	protected ExtendedScrollRect scrollRect;

	[Token(Token = "0x400C8F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	protected bool isChecked;

	[Token(Token = "0x400C8F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x159")]
	public bool isUseCountDown;

	[Token(Token = "0x400C8F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15A")]
	public bool isBlockNextQuestion;

	[Token(Token = "0x400C8F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15B")]
	private bool permissionNextQuestion;

	[Token(Token = "0x400C8F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private AnswerTypeBehaviour answertypeBehaviour;

	[Token(Token = "0x400C8F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private CertificationUtil.AnswerType prevAnswerType;

	[Token(Token = "0x400C8F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private string prevImagePath;

	[Token(Token = "0x400C8F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private string prevQuestionTemplatePath;

	[Token(Token = "0x400C8FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private ElementObjectManager prevViewTypeTemplate;

	[Token(Token = "0x400C8FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private ElementObjectManager currentViewTypeTemplate;

	[Token(Token = "0x400C8FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private QuestionTypeBehaviour questionTypeBehaviour;

	[Token(Token = "0x400C8FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private CertificationUtil.CertificationTimer certificationTimer;

	[Token(Token = "0x400C8FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	private IAsyncProgressContent m_AsyncProgressContentAnswerTemp;

	[Token(Token = "0x400C8FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private IAsyncProgressContent m_AsyncProgressContentQuestionTemp;

	[Token(Token = "0x400C900")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	private int inputBlockerCount;

	[Token(Token = "0x400C901")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	private Dictionary<int, QuestionData> questions;

	[Token(Token = "0x400C902")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	public List<object> answerResultList;

	[Token(Token = "0x400C903")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	public Coroutine coroutine;

	[Token(Token = "0x400C904")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	protected ElementObjectManager m_View;

	[Token(Token = "0x400C905")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	protected ViewControllerManager manager;

	[Token(Token = "0x400C906")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	protected BaseMenuViewController m_Owner;

	[Token(Token = "0x400C907")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	protected Selector m_OwnerSelector;

	[Token(Token = "0x400C908")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
	public Action<Dictionary<string, object>> onFinishedWriting;

	[Token(Token = "0x400C909")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	public Action<bool> onFinishedOneQuestion;

	[Token(Token = "0x400C90A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
	public Action onClickedRetire;

	[Token(Token = "0x400C90B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
	public Action onStartMateFirst;

	[Token(Token = "0x400C90C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
	public Action onStartMate;

	[Token(Token = "0x400C90D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
	public Func<PadInputDirection, bool> onAnswerBtnInputKeyEdgeAction;

	[Token(Token = "0x170013CB")]
	public float openCurrentQuestionLimitTime
	{
		[Token(Token = "0x600812F")]
		[Address(RVA = "0xC90C80", Offset = "0xC8FE80", VA = "0x180C90C80")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170013CC")]
	public float openCurrentTime
	{
		[Token(Token = "0x6008130")]
		[Address(RVA = "0xC90C90", Offset = "0xC8FE90", VA = "0x180C90C90")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170013CD")]
	public bool IsPermissionNextQuestion
	{
		[Token(Token = "0x6008131")]
		[Address(RVA = "0xC90C30", Offset = "0xC8FE30", VA = "0x180C90C30")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6008132")]
		[Address(RVA = "0xC90DB0", Offset = "0xC8FFB0", VA = "0x180C90DB0")]
		set
		{
		}
	}

	[Token(Token = "0x170013CE")]
	public bool isReady
	{
		[Token(Token = "0x6008133")]
		[Address(RVA = "0xC90C40", Offset = "0xC8FE40", VA = "0x180C90C40")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6008134")]
	[Address(RVA = "0xC8FA70", Offset = "0xC8EC70", VA = "0x180C8FA70")]
	public void OnRemove()
	{
	}

	[Token(Token = "0x6008135")]
	[Address(RVA = "0xC8FB60", Offset = "0xC8ED60", VA = "0x180C8FB60")]
	public void Process()
	{
	}

	[Token(Token = "0x6008136")]
	[Address(RVA = "0xC8F890", Offset = "0xC8EA90", VA = "0x180C8F890")]
	public void Init(int grade, int require, int total)
	{
	}

	[Token(Token = "0x6008137")]
	[Address(RVA = "0xC904A0", Offset = "0xC8F6A0", VA = "0x180C904A0")]
	public void SetQuestionData(Dictionary<int, QuestionData> data)
	{
	}

	[Token(Token = "0x6008138")]
	[Address(RVA = "0xC90000", Offset = "0xC8F200", VA = "0x180C90000", Slot = "4")]
	public virtual void SetElements(ElementObjectManager m_View, ViewControllerManager vcm, BaseMenuViewController owner, Selector ownerSelector)
	{
	}

	[Token(Token = "0x6008139")]
	[Address(RVA = "0xC8F8D0", Offset = "0xC8EAD0", VA = "0x180C8F8D0")]
	public void OnFinishedQuestion()
	{
	}

	[Token(Token = "0x600813A")]
	[Address(RVA = "0xC8FE10", Offset = "0xC8F010", VA = "0x180C8FE10")]
	protected void SetActiveTweenObject(bool active)
	{
	}

	[Token(Token = "0x600813B")]
	[Address(RVA = "0xC8F8B0", Offset = "0xC8EAB0", VA = "0x180C8F8B0")]
	private void OnClickRetire()
	{
	}

	[Token(Token = "0x600813C")]
	[Address(RVA = "0xC90DC0", Offset = "0xC8FFC0", VA = "0x180C90DC0")]
	[IteratorStateMachine(typeof(_003CyStartWriting_003Ed__105))]
	private IEnumerator yStartWriting()
	{
		return null;
	}

	[Token(Token = "0x600813D")]
	[Address(RVA = "0xC8FA50", Offset = "0xC8EC50", VA = "0x180C8FA50")]
	private void OnFinishedWriting(Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x600813E")]
	[Address(RVA = "0xC8F550", Offset = "0xC8E750", VA = "0x180C8F550")]
	private void CheckTextScroll(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x600813F")]
	[Address(RVA = "0xC8FC30", Offset = "0xC8EE30", VA = "0x180C8FC30")]
	private void ResetTextScroll(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x6008140")]
	[Address(RVA = "0xC8F600", Offset = "0xC8E800", VA = "0x180C8F600")]
	private void CreateAnswerTypeBehaviourIns(CertificationUtil.AnswerType type)
	{
	}

	[Token(Token = "0x6008141")]
	[Address(RVA = "0xC90770", Offset = "0xC8F970", VA = "0x180C90770")]
	public void UpdateRogichander()
	{
	}

	[Token(Token = "0x6008142")]
	[Address(RVA = "0xC90CA0", Offset = "0xC8FEA0", VA = "0x180C90CA0")]
	private bool isAnswerCheckTweenActive()
	{
		return default(bool);
	}

	[Token(Token = "0x6008143")]
	[Address(RVA = "0xC90910", Offset = "0xC8FB10", VA = "0x180C90910")]
	public CertificationRogicHander()
	{
	}
}
