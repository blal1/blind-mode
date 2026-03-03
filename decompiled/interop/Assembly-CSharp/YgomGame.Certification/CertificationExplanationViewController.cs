using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Menu;
using YgomGame.Menu.Common;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.FreeScroll;

namespace YgomGame.Certification;

[Token(Token = "0x20014BC")]
public class CertificationExplanationViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x20014BD")]
	public enum ContentType
	{
		[Token(Token = "0x400C814")]
		none,
		[Token(Token = "0x400C815")]
		RootTemplate
	}

	[Token(Token = "0x20014BE")]
	public class ExplanationData
	{
		[Token(Token = "0x400C816")]
		[FieldOffset(Offset = "0x10")]
		public int quizId;

		[Token(Token = "0x400C817")]
		[FieldOffset(Offset = "0x18")]
		public string questionPrefabPath;

		[Token(Token = "0x400C818")]
		[FieldOffset(Offset = "0x20")]
		public string title;

		[Token(Token = "0x400C819")]
		[FieldOffset(Offset = "0x28")]
		public string questionText;

		[Token(Token = "0x400C81A")]
		[FieldOffset(Offset = "0x30")]
		public string answerText;

		[Token(Token = "0x400C81B")]
		[FieldOffset(Offset = "0x38")]
		public int answerIndex;

		[Token(Token = "0x400C81C")]
		[FieldOffset(Offset = "0x40")]
		public string answerPrefabPath;

		[Token(Token = "0x400C81D")]
		[FieldOffset(Offset = "0x48")]
		public string explanationText;

		[Token(Token = "0x400C81E")]
		[FieldOffset(Offset = "0x50")]
		public string explanationPrefabPath;

		[Token(Token = "0x400C81F")]
		[FieldOffset(Offset = "0x58")]
		public CertificationUtil.QuestionType questionType;

		[Token(Token = "0x400C820")]
		[FieldOffset(Offset = "0x5C")]
		public CertificationUtil.QuestionType explanationType;

		[Token(Token = "0x400C821")]
		[FieldOffset(Offset = "0x60")]
		public CertificationUtil.AnswerType answerType;

		[Token(Token = "0x400C822")]
		[FieldOffset(Offset = "0x68")]
		public List<string> choices;

		[Token(Token = "0x400C823")]
		[FieldOffset(Offset = "0x70")]
		public bool isCorrect;

		[Token(Token = "0x60080A4")]
		[Address(RVA = "0xC980C0", Offset = "0xC972C0", VA = "0x180C980C0")]
		public ExplanationData()
		{
		}
	}

	[Token(Token = "0x20014C2")]
	[CompilerGenerated]
	private sealed class _003CSetElements_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400C82E")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400C82F")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400C830")]
		[FieldOffset(Offset = "0x20")]
		public CertificationExplanationViewController _003C_003E4__this;

		[Token(Token = "0x400C831")]
		[FieldOffset(Offset = "0x28")]
		private int _003Ci_003E5__2;

		[Token(Token = "0x400C832")]
		[FieldOffset(Offset = "0x2C")]
		private int _003Ccount_003E5__3;

		[Token(Token = "0x400C833")]
		[FieldOffset(Offset = "0x30")]
		private List<ExplanationData>.Enumerator _003C_003E7__wrap3;

		[Token(Token = "0x170013B9")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60080B4")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170013BA")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60080B6")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60080B0")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CSetElements_003Ed__34(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60080B1")]
		[Address(RVA = "0xC99720", Offset = "0xC98920", VA = "0x180C99720", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60080B2")]
		[Address(RVA = "0xC99150", Offset = "0xC98350", VA = "0x180C99150", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60080B3")]
		[Address(RVA = "0xC997B0", Offset = "0xC989B0", VA = "0x180C997B0")]
		private void _003C_003Em__Finally1()
		{
		}

		[Token(Token = "0x60080B5")]
		[Address(RVA = "0xC996E0", Offset = "0xC988E0", VA = "0x180C996E0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20014C3")]
	[CompilerGenerated]
	private sealed class _003CanswerPrefabBindingEnumarator_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400C834")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400C835")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400C836")]
		[FieldOffset(Offset = "0x20")]
		public CertificationExplanationViewController _003C_003E4__this;

		[Token(Token = "0x400C837")]
		[FieldOffset(Offset = "0x28")]
		public int index;

		[Token(Token = "0x400C838")]
		[FieldOffset(Offset = "0x30")]
		public BindingGameObjectEx parent;

		[Token(Token = "0x400C839")]
		[FieldOffset(Offset = "0x38")]
		public ExplanationData data;

		[Token(Token = "0x400C83A")]
		[FieldOffset(Offset = "0x40")]
		public bool isInc;

		[Token(Token = "0x170013BB")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60080BA")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170013BC")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60080BC")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60080B7")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CanswerPrefabBindingEnumarator_003Ed__37(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60080B8")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60080B9")]
		[Address(RVA = "0xC9B020", Offset = "0xC9A220", VA = "0x180C9B020", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60080BB")]
		[Address(RVA = "0xC9B1E0", Offset = "0xC9A3E0", VA = "0x180C9B1E0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20014C4")]
	[CompilerGenerated]
	private sealed class _003CquestionPrefabBindingEnumarator_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400C83B")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400C83C")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400C83D")]
		[FieldOffset(Offset = "0x20")]
		public CertificationExplanationViewController _003C_003E4__this;

		[Token(Token = "0x400C83E")]
		[FieldOffset(Offset = "0x28")]
		public int index;

		[Token(Token = "0x400C83F")]
		[FieldOffset(Offset = "0x30")]
		public BindingGameObjectEx parent;

		[Token(Token = "0x400C840")]
		[FieldOffset(Offset = "0x38")]
		public CertificationUtil.QuestionType type;

		[Token(Token = "0x400C841")]
		[FieldOffset(Offset = "0x40")]
		public string path;

		[Token(Token = "0x400C842")]
		[FieldOffset(Offset = "0x48")]
		public bool isInc;

		[Token(Token = "0x170013BD")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60080C0")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170013BE")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60080C2")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60080BD")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CquestionPrefabBindingEnumarator_003Ed__36(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60080BE")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60080BF")]
		[Address(RVA = "0xC9B220", Offset = "0xC9A420", VA = "0x180C9B220", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60080C1")]
		[Address(RVA = "0xC9B450", Offset = "0xC9A650", VA = "0x180C9B450", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400C7F4")]
	private const string prefPath = "Certification/CertificationExplanation";

	[Token(Token = "0x400C7F5")]
	[FieldOffset(Offset = "0xD0")]
	private readonly string L_ExplanationTemplate;

	[Token(Token = "0x400C7F6")]
	[FieldOffset(Offset = "0xD8")]
	private readonly string L_ContentTemplate;

	[Token(Token = "0x400C7F7")]
	[FieldOffset(Offset = "0xE0")]
	private readonly string L_Header1Template;

	[Token(Token = "0x400C7F8")]
	[FieldOffset(Offset = "0xE8")]
	private readonly string L_Header2Template;

	[Token(Token = "0x400C7F9")]
	[FieldOffset(Offset = "0xF0")]
	private readonly string L_Text;

	[Token(Token = "0x400C7FA")]
	[FieldOffset(Offset = "0xF8")]
	private readonly string L_TableRootTemplate;

	[Token(Token = "0x400C7FB")]
	[FieldOffset(Offset = "0x100")]
	private readonly string L_TableRowTemplate;

	[Token(Token = "0x400C7FC")]
	[FieldOffset(Offset = "0x108")]
	private readonly string L_PrefabTemplate;

	[Token(Token = "0x400C7FD")]
	[FieldOffset(Offset = "0x110")]
	private readonly string L_TextTemplate;

	[Token(Token = "0x400C7FE")]
	[FieldOffset(Offset = "0x118")]
	private readonly string L_Header2TemplateExplanation;

	[Token(Token = "0x400C7FF")]
	[FieldOffset(Offset = "0x120")]
	private readonly string L_TextTemplateExplanation;

	[Token(Token = "0x400C800")]
	[FieldOffset(Offset = "0x128")]
	private readonly string L_TableRootTemplateExplanation;

	[Token(Token = "0x400C801")]
	[FieldOffset(Offset = "0x130")]
	private Dictionary<ContentType, ElementObjectManager> templates;

	[Token(Token = "0x400C802")]
	[FieldOffset(Offset = "0x138")]
	private FreeScrollView m_FreeScrollView;

	[Token(Token = "0x400C803")]
	[FieldOffset(Offset = "0x140")]
	private ScrollRect m_ScrollRect;

	[Token(Token = "0x400C804")]
	[FieldOffset(Offset = "0x148")]
	private Scrollbar m_Scrollbar;

	[Token(Token = "0x400C805")]
	[FieldOffset(Offset = "0x150")]
	private Selector m_ScrollSelector;

	[Token(Token = "0x400C806")]
	[FieldOffset(Offset = "0x158")]
	private GameObject content;

	[Token(Token = "0x400C807")]
	[FieldOffset(Offset = "0x160")]
	private List<ExplanationData> explanationDatas;

	[Token(Token = "0x400C808")]
	[FieldOffset(Offset = "0x168")]
	private Texture2D texture2D;

	[Token(Token = "0x400C809")]
	[FieldOffset(Offset = "0x170")]
	private List<object> answerList;

	[Token(Token = "0x400C80A")]
	[FieldOffset(Offset = "0x178")]
	private List<Selector> selectors;

	[Token(Token = "0x400C80B")]
	[FieldOffset(Offset = "0x180")]
	private Dictionary<Selector, List<SelectionItem>> cardScrollTemplateSelectorDic;

	[Token(Token = "0x400C80C")]
	[FieldOffset(Offset = "0x188")]
	private List<Coroutine> coroutines;

	[Token(Token = "0x400C80D")]
	[FieldOffset(Offset = "0x190")]
	private int m_BindingRequestCnt;

	[Token(Token = "0x400C80E")]
	[FieldOffset(Offset = "0x194")]
	private int currentDoIndex;

	[Token(Token = "0x400C80F")]
	[FieldOffset(Offset = "0x198")]
	private int currentDoAnswerIndex;

	[Token(Token = "0x400C810")]
	[FieldOffset(Offset = "0x19C")]
	private bool isStart;

	[Token(Token = "0x400C811")]
	[FieldOffset(Offset = "0x1A0")]
	private List<CertificationRogicHander.ICertificationTemplateController> templateControllerList;

	[Token(Token = "0x400C812")]
	[FieldOffset(Offset = "0x1A8")]
	private bool isFinishedSetScroll;

	[Token(Token = "0x170013B8")]
	protected override int outGameBgId
	{
		[Token(Token = "0x6008090")]
		[Address(RVA = "0x573650", Offset = "0x572850", VA = "0x180573650", Slot = "20")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6008091")]
	[Address(RVA = "0xC8BF00", Offset = "0xC8B100", VA = "0x180C8BF00")]
	public static void Open(ViewControllerManager vc, List<object> answerList)
	{
	}

	[Token(Token = "0x6008092")]
	[Address(RVA = "0xC8AF30", Offset = "0xC8A130", VA = "0x180C8AF30", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6008093")]
	[Address(RVA = "0xC8AFC0", Offset = "0xC8A1C0", VA = "0x180C8AFC0", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x6008094")]
	[Address(RVA = "0xC8A380", Offset = "0xC89580", VA = "0x180C8A380")]
	private void InitData()
	{
	}

	[Token(Token = "0x6008095")]
	[Address(RVA = "0xC8B2B0", Offset = "0xC8A4B0", VA = "0x180C8B2B0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6008096")]
	[Address(RVA = "0xC8C150", Offset = "0xC8B350", VA = "0x180C8C150")]
	[IteratorStateMachine(typeof(_003CSetElements_003Ed__34))]
	private IEnumerator SetElements()
	{
		return null;
	}

	[Token(Token = "0x6008097")]
	[Address(RVA = "0xC8AD80", Offset = "0xC89F80", VA = "0x180C8AD80")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6008098")]
	[Address(RVA = "0xC8DD30", Offset = "0xC8CF30", VA = "0x180C8DD30")]
	[IteratorStateMachine(typeof(_003CquestionPrefabBindingEnumarator_003Ed__36))]
	private IEnumerator questionPrefabBindingEnumarator(BindingGameObjectEx parent, CertificationUtil.QuestionType type, string path, int index, bool isInc)
	{
		return null;
	}

	[Token(Token = "0x6008099")]
	[Address(RVA = "0xC8DC70", Offset = "0xC8CE70", VA = "0x180C8DC70")]
	[IteratorStateMachine(typeof(_003CanswerPrefabBindingEnumarator_003Ed__37))]
	private IEnumerator answerPrefabBindingEnumarator(BindingGameObjectEx parent, ExplanationData data, int index, bool isInc)
	{
		return null;
	}

	[Token(Token = "0x600809A")]
	[Address(RVA = "0xC8C650", Offset = "0xC8B850", VA = "0x180C8C650")]
	private void SetTemplateView(ExplanationData data, int index)
	{
	}

	[Token(Token = "0x600809B")]
	[Address(RVA = "0xC8BFD0", Offset = "0xC8B1D0", VA = "0x180C8BFD0")]
	private void SetAllTemplate(bool frag)
	{
	}

	[Token(Token = "0x600809C")]
	[Address(RVA = "0xC8D7D0", Offset = "0xC8C9D0", VA = "0x180C8D7D0")]
	private void Update()
	{
	}

	[Token(Token = "0x600809D")]
	[Address(RVA = "0xC8B570", Offset = "0xC8A770", VA = "0x180C8B570")]
	private void OnLoadQuestionPrefabComplate(GameObject parent, GameObject go, CertificationUtil.QuestionType type, string path, int index, bool frag = false)
	{
	}

	[Token(Token = "0x600809E")]
	[Address(RVA = "0xC8B370", Offset = "0xC8A570", VA = "0x180C8B370")]
	private void OnLoadAnswerPrefabComplate(GameObject parent, GameObject go, ExplanationData data, int index, bool frag = false)
	{
	}

	[Token(Token = "0x600809F")]
	[Address(RVA = "0xC8C1C0", Offset = "0xC8B3C0", VA = "0x180C8C1C0")]
	private void SetScrollView()
	{
	}

	[Token(Token = "0x60080A0")]
	[Address(RVA = "0xC8D800", Offset = "0xC8CA00", VA = "0x180C8D800")]
	public CertificationExplanationViewController()
	{
	}
}
