using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using YgomGame.Bg;
using YgomGame.Menu;
using YgomGame.Menu.Common;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.PropertyOverrider;
using YgomSystem.YGomTMPro;

namespace YgomGame.Certification;

[Token(Token = "0x2001510")]
public class CertificationWritingViewController : BaseMenuViewController
{
	[Token(Token = "0x2001511")]
	[Flags]
	private enum CountDownFrag
	{
		[Token(Token = "0x400CAF6")]
		zero = 1,
		[Token(Token = "0x400CAF7")]
		one = 2,
		[Token(Token = "0x400CAF8")]
		two = 4,
		[Token(Token = "0x400CAF9")]
		three = 8,
		[Token(Token = "0x400CAFA")]
		four = 0x10
	}

	[Token(Token = "0x2001512")]
	public class QuestionData
	{
		[Token(Token = "0x400CAFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CertificationUtil.AnswerType answerType;

		[Token(Token = "0x400CAFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public CertificationUtil.QuestionType questionType;

		[Token(Token = "0x400CAFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CertificationUtil.ViewType viewType;

		[Token(Token = "0x400CAFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string questionText;

		[Token(Token = "0x400CAFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string prefabPath;

		[Token(Token = "0x400CB00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string questionTemplatePath;

		[Token(Token = "0x400CB01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int LimitTime;

		[Token(Token = "0x600827C")]
		[Address(RVA = "0xCAC6C0", Offset = "0xCAB8C0", VA = "0x180CAC6C0")]
		public QuestionData(CertificationUtil.AnswerType answerType, CertificationUtil.QuestionType questionType, string questionText, string prefabPath, string questionTempPath, int LimitTime, CertificationUtil.ViewType viewType)
		{
		}

		[Token(Token = "0x600827D")]
		[Address(RVA = "0x40C450", Offset = "0x40B650", VA = "0x18040C450")]
		public int GetLimitTime()
		{
			return default(int);
		}
	}

	[Token(Token = "0x2001513")]
	public interface ICertificationTemplateController
	{
		[Token(Token = "0x600827E")]
		void StartDisp();

		[Token(Token = "0x600827F")]
		void RemoveDisp();

		[Token(Token = "0x6008280")]
		void UpdateDisp();
	}

	[Token(Token = "0x2001514")]
	public class QuestionTemplateController
	{
		[Token(Token = "0x400CB02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private ElementObjectManager _eom;

		[Token(Token = "0x400CB03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private PlatformOverriderGroup pog;

		[Token(Token = "0x400CB04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool isExplanation;

		[Token(Token = "0x400CB05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public CertificationUtil.ViewType viewType;

		[Token(Token = "0x170013EB")]
		public ElementObjectManager eom
		{
			[Token(Token = "0x6008281")]
			[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6008282")]
		[Address(RVA = "0xCC5D60", Offset = "0xCC4F60", VA = "0x180CC5D60")]
		public QuestionTemplateController(GameObject go)
		{
		}

		[Token(Token = "0x6008283")]
		[Address(RVA = "0xCC5C50", Offset = "0xCC4E50", VA = "0x180CC5C50", Slot = "4")]
		public virtual void OverriderActivate()
		{
		}
	}

	[Token(Token = "0x2001515")]
	protected abstract class AnswerTypeBehaviour
	{
		[Token(Token = "0x400CB06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected readonly string QUESTION_TEXT_LABEL;

		[Token(Token = "0x400CB07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected readonly string BUTTON_LABEL;

		[Token(Token = "0x400CB08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected readonly string COUNTDOWN_TEXT_LABEL;

		[Token(Token = "0x400CB09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected readonly string FOOTER_AREA_LABEL;

		[Token(Token = "0x400CB0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal readonly ViewControllerManager manager;

		[Token(Token = "0x400CB0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal readonly CertificationWritingViewController vc;

		[Token(Token = "0x400CB0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal readonly ElementObjectManager parentEOM;

		[Token(Token = "0x400CB0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected ElementObjectManager viewEOM;

		[Token(Token = "0x400CB0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected ElementObjectManager questionViewEOM;

		[Token(Token = "0x400CB0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		internal float limitTime;

		[Token(Token = "0x400CB10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		internal bool timeOut;

		[Token(Token = "0x400CB11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
		internal bool answered;

		[Token(Token = "0x400CB12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5E")]
		internal bool isCorrectAnswer;

		[Token(Token = "0x400CB13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5F")]
		internal bool isReady;

		[Token(Token = "0x400CB14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		internal object objectTypeAnswer;

		[Token(Token = "0x400CB15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		protected QuestionTypeBehaviour questionTypeBehaviour;

		[Token(Token = "0x6008284")]
		[Address(RVA = "0xCB2240", Offset = "0xCB1440", VA = "0x180CB2240")]
		protected AnswerTypeBehaviour(ViewControllerManager manager, CertificationWritingViewController vc, ElementObjectManager parentEOM, ElementObjectManager viewEOM, ElementObjectManager quesEOM, QuestionTypeBehaviour typeBehaviour)
		{
		}

		[Token(Token = "0x6008285")]
		internal abstract void InitData(int id);

		[Token(Token = "0x6008286")]
		internal abstract void InitDisp(bool isLast, [Optional] UnityAction mateAction, [Optional] UnityAction onFinished);

		[Token(Token = "0x6008287")]
		internal abstract void UpdateDisp();

		[Token(Token = "0x6008288")]
		internal abstract void RemoveDisp();

		[Token(Token = "0x6008289")]
		internal abstract void StartCountDown();

		[Token(Token = "0x600828A")]
		internal abstract void TimeOut();
	}

	[Token(Token = "0x2001516")]
	protected abstract class QuestionTypeBehaviour
	{
		[Token(Token = "0x400CB16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected readonly string TEXT_LABEL;

		[Token(Token = "0x400CB17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected ElementObjectManager viewEOM;

		[Token(Token = "0x400CB18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal readonly ViewControllerManager manager;

		[Token(Token = "0x400CB19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal readonly CertificationWritingViewController vc;

		[Token(Token = "0x400CB1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal readonly ElementObjectManager parentEOM;

		[Token(Token = "0x400CB1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal bool eventFrag;

		[Token(Token = "0x400CB1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		internal bool isReady;

		[Token(Token = "0x400CB1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal List<SelectionItem> selectionItems;

		[Token(Token = "0x600828B")]
		[Address(RVA = "0xCC5DD0", Offset = "0xCC4FD0", VA = "0x180CC5DD0")]
		protected QuestionTypeBehaviour(ViewControllerManager manager, CertificationWritingViewController vc, ElementObjectManager parentEOM, ElementObjectManager viewEOM)
		{
		}

		[Token(Token = "0x600828C")]
		internal abstract void InitDisp(int id, bool isSamePath, QuestionData qdata);

		[Token(Token = "0x600828D")]
		internal abstract void UpdateDisp();

		[Token(Token = "0x600828E")]
		internal abstract void RemoveDisp();

		[Token(Token = "0x600828F")]
		internal abstract void StartCountDown();

		[Token(Token = "0x6008290")]
		internal abstract void Answered();
	}

	[Token(Token = "0x400CABF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private readonly string L_Main;

	[Token(Token = "0x400CAC0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private readonly string L_QuestionArea;

	[Token(Token = "0x400CAC1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private readonly string L_AnswerArea;

	[Token(Token = "0x400CAC2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private readonly string L_TimerRoot;

	[Token(Token = "0x400CAC3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private readonly string L_TimerNum;

	[Token(Token = "0x400CAC4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private readonly string L_QuestionStart;

	[Token(Token = "0x400CAC5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private readonly string L_QuestionCorrect;

	[Token(Token = "0x400CAC6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private readonly string L_QuestionIncorrect;

	[Token(Token = "0x400CAC7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private readonly string L_QuestionTimeout;

	[Token(Token = "0x400CAC8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private readonly string L_TextQuestionNum;

	[Token(Token = "0x400CAC9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private GameObject timerRoot;

	[Token(Token = "0x400CACA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private GameObject timerBase0;

	[Token(Token = "0x400CACB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private GameObject timerBase1;

	[Token(Token = "0x400CACC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private GameObject timerBase2;

	[Token(Token = "0x400CACD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private GameObject timerGauge0;

	[Token(Token = "0x400CACE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private GameObject timerGauge1;

	[Token(Token = "0x400CACF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private Image fillAmountImage;

	[Token(Token = "0x400CAD0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private GameObject questionStart;

	[Token(Token = "0x400CAD1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private GameObject questionCorrect;

	[Token(Token = "0x400CAD2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private GameObject questionIncorrect;

	[Token(Token = "0x400CAD3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private GameObject questionTimeout;

	[Token(Token = "0x400CAD4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private ExtendedTextMeshProUGUI textQuestionNum;

	[Token(Token = "0x400CAD5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private int totalQuestionNum;

	[Token(Token = "0x400CAD6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
	private int requireNum;

	[Token(Token = "0x400CAD7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private int GradeIndex;

	[Token(Token = "0x400CAD8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private CertificationMateViewer mateViewer;

	[Token(Token = "0x400CAD9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private ElementObjectManager viewEom;

	[Token(Token = "0x400CADA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	private ElementObjectManager questionViewEom;

	[Token(Token = "0x400CADB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private ElementObjectManager mainEom;

	[Token(Token = "0x400CADC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	private ElementObjectManager questionAreaEom;

	[Token(Token = "0x400CADD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	private ElementObjectManager answerAreaEom;

	[Token(Token = "0x400CADE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	private ExtendedTextMeshProUGUI countDownText;

	[Token(Token = "0x400CADF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	private SelectionButton retireButton;

	[Token(Token = "0x400CAE0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	private ExtendedTextMeshProUGUI questionText;

	[Token(Token = "0x400CAE1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	private ContentSizeFitter sizeFitter;

	[Token(Token = "0x400CAE2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	private ExtendedScrollRect scrollRect;

	[Token(Token = "0x400CAE3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	private bool isChecked;

	[Token(Token = "0x400CAE4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
	private AnswerTypeBehaviour answertypeBehaviour;

	[Token(Token = "0x400CAE5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	private CertificationUtil.AnswerType prevAnswerType;

	[Token(Token = "0x400CAE6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
	private QuestionTypeBehaviour questionTypeBehaviour;

	[Token(Token = "0x400CAE7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
	private IAsyncProgressContent m_AsyncProgressContentAnswerTemp;

	[Token(Token = "0x400CAE8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
	private IAsyncProgressContent m_AsyncProgressContentQuestionTemp;

	[Token(Token = "0x400CAE9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
	private readonly string QUESTION_TEMPLATE;

	[Token(Token = "0x400CAEA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
	private readonly string TEMPLATE_PATH;

	[Token(Token = "0x400CAEB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
	private readonly string TEMPLATE_PATH_LARGE_WRITING;

	[Token(Token = "0x400CAEC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
	private int inputBlockerCount;

	[Token(Token = "0x400CAED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
	private Dictionary<int, CertificationRogicHander.QuestionData> questions;

	[Token(Token = "0x400CAEE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
	private List<object> answerResultList;

	[Token(Token = "0x400CAEF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
	private CountDownFrag countDownFrag;

	[Token(Token = "0x400CAF0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
	private Coroutine coroutine;

	[Token(Token = "0x400CAF1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
	[SerializeField]
	private int textVolumeThreshold_KanziHan;

	[Token(Token = "0x400CAF2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25C")]
	[SerializeField]
	private int textVolumeThreshold_other;

	[Token(Token = "0x400CAF3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
	private CertificationRogicHander rogicHander;

	[Token(Token = "0x400CAF4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
	private CertificationUtil.CertificationTimer certificationTimer;

	[Token(Token = "0x170013E4")]
	public float openCurrentQuestionLimitTime
	{
		[Token(Token = "0x6008256")]
		[Address(RVA = "0xCAAAB0", Offset = "0xCA9CB0", VA = "0x180CAAAB0")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170013E5")]
	public float openCurrentTime
	{
		[Token(Token = "0x6008257")]
		[Address(RVA = "0xCAAB10", Offset = "0xCA9D10", VA = "0x180CAAB10")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170013E6")]
	public int totalQuestionNumPub
	{
		[Token(Token = "0x6008258")]
		[Address(RVA = "0x49B750", Offset = "0x49A950", VA = "0x18049B750")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170013E7")]
	public int requireNumPub
	{
		[Token(Token = "0x6008259")]
		[Address(RVA = "0x49B760", Offset = "0x49A960", VA = "0x18049B760")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170013E8")]
	public int GradeIndexPub
	{
		[Token(Token = "0x600825A")]
		[Address(RVA = "0xCAAA10", Offset = "0xCA9C10", VA = "0x180CAAA10")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170013E9")]
	private bool isReadyMate
	{
		[Token(Token = "0x600825B")]
		[Address(RVA = "0xCAAA20", Offset = "0xCA9C20", VA = "0x180CAAA20")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170013EA")]
	protected override int outGameBgId
	{
		[Token(Token = "0x600825C")]
		[Address(RVA = "0x573650", Offset = "0x572850", VA = "0x180573650", Slot = "20")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600825D")]
	[Address(RVA = "0xCA8A90", Offset = "0xCA7C90", VA = "0x180CA8A90", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x600825E")]
	[Address(RVA = "0xCA8E20", Offset = "0xCA8020", VA = "0x180CA8E20", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x600825F")]
	public T CreateGameObject<T>(GameObject parent, string name, [Optional] Type[] components) where T : MonoBehaviour
	{
		return null;
	}

	[Token(Token = "0x6008260")]
	[Address(RVA = "0xB8BF50", Offset = "0xB8B150", VA = "0x180B8BF50")]
	public GameObject CreateGameObject(GameObject parent, string name, [Optional] Type[] components)
	{
		return null;
	}

	[Token(Token = "0x6008261")]
	[Address(RVA = "0xCA9D00", Offset = "0xCA8F00", VA = "0x180CA9D00")]
	private void Start()
	{
	}

	[Token(Token = "0x6008262")]
	[Address(RVA = "0xCA8B60", Offset = "0xCA7D60", VA = "0x180CA8B60", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x6008263")]
	[Address(RVA = "0xCA9020", Offset = "0xCA8220", VA = "0x180CA9020", Slot = "24")]
	protected override void OnTransitionStart(TransitionType type)
	{
	}

	[Token(Token = "0x6008264")]
	[Address(RVA = "0xCA81D0", Offset = "0xCA73D0", VA = "0x180CA81D0")]
	private void GetInitData()
	{
	}

	[Token(Token = "0x6008265")]
	[Address(RVA = "0xCA80C0", Offset = "0xCA72C0", VA = "0x180CA80C0")]
	private bool CheckTextVolume(string text)
	{
		return default(bool);
	}

	[Token(Token = "0x6008266")]
	[Address(RVA = "0xCA8A10", Offset = "0xCA7C10", VA = "0x180CA8A10")]
	public static bool IsKanzi(string target)
	{
		return default(bool);
	}

	[Token(Token = "0x6008267")]
	[Address(RVA = "0xCA8990", Offset = "0xCA7B90", VA = "0x180CA8990")]
	public static bool IsHan(string target)
	{
		return default(bool);
	}

	[Token(Token = "0x6008268")]
	[Address(RVA = "0xCA9470", Offset = "0xCA8670", VA = "0x180CA9470")]
	private void SetElements()
	{
	}

	[Token(Token = "0x6008269")]
	[Address(RVA = "0xCA9380", Offset = "0xCA8580", VA = "0x180CA9380")]
	private void SetActiveTweenObject(bool active)
	{
	}

	[Token(Token = "0x600826A")]
	[Address(RVA = "0xCA8D20", Offset = "0xCA7F20", VA = "0x180CA8D20")]
	private void OnClickRetire()
	{
	}

	[Token(Token = "0x600826B")]
	[Address(RVA = "0xCA9860", Offset = "0xCA8A60", VA = "0x180CA9860")]
	private void SetMate()
	{
	}

	[Token(Token = "0x600826C")]
	[Address(RVA = "0xCA90C0", Offset = "0xCA82C0", VA = "0x180CA90C0")]
	private void PlayMateMotion(AvatarMotionSetting.MotionID id)
	{
	}

	[Token(Token = "0x600826D")]
	[Address(RVA = "0xCA8010", Offset = "0xCA7210", VA = "0x180CA8010")]
	private void CheckTextScroll(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x600826E")]
	[Address(RVA = "0xCA91A0", Offset = "0xCA83A0", VA = "0x180CA91A0")]
	private void ResetTextScroll(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x600826F")]
	[Address(RVA = "0xCAA630", Offset = "0xCA9830", VA = "0x180CAA630")]
	private void Update()
	{
	}

	[Token(Token = "0x6008270")]
	[Address(RVA = "0xCA9A40", Offset = "0xCA8C40", VA = "0x180CA9A40")]
	private void SetTimerView(float remaineTime)
	{
	}

	[Token(Token = "0x6008271")]
	[Address(RVA = "0xCAAB70", Offset = "0xCA9D70", VA = "0x180CAAB70")]
	private bool isAnswerCheckTweenActive()
	{
		return default(bool);
	}

	[Token(Token = "0x6008272")]
	[Address(RVA = "0xCA7EE0", Offset = "0xCA70E0", VA = "0x180CA7EE0")]
	private void CallApi(int grade_id, [Optional] Action onComplited)
	{
	}

	[Token(Token = "0x6008273")]
	[Address(RVA = "0xCAA6E0", Offset = "0xCA98E0", VA = "0x180CAA6E0")]
	public CertificationWritingViewController()
	{
	}
}
