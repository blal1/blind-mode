using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Menu.Common;
using YgomGame.Utility;
using YgomSystem.ElementSystem;
using YgomSystem.Network;
using YgomSystem.YGomTMPro;

namespace YgomGame.Certification;

[Token(Token = "0x20014CB")]
public class CertificationUtil : MonoBehaviour
{
	[Token(Token = "0x20014CC")]
	public enum AnswerType
	{
		[Token(Token = "0x400C86D")]
		CountDown,
		[Token(Token = "0x400C86E")]
		Choices
	}

	[Token(Token = "0x20014CD")]
	public enum QuestionType
	{
		[Token(Token = "0x400C870")]
		CountDown,
		[Token(Token = "0x400C871")]
		Prefab,
		[Token(Token = "0x400C872")]
		Card,
		[Token(Token = "0x400C873")]
		Cards,
		[Token(Token = "0x400C874")]
		LetterCards,
		[Token(Token = "0x400C875")]
		CardsShuffle,
		[Token(Token = "0x400C876")]
		CardsScroll,
		[Token(Token = "0x400C877")]
		DuelField,
		[Token(Token = "0x400C878")]
		CardsSnapScroll
	}

	[Token(Token = "0x20014CE")]
	public enum ViewType
	{
		[Token(Token = "0x400C87A")]
		Default,
		[Token(Token = "0x400C87B")]
		Large
	}

	[Token(Token = "0x20014CF")]
	public enum ProgressState
	{
		[Token(Token = "0x400C87D")]
		None = 0,
		[Token(Token = "0x400C87E")]
		WritingComplete = 1,
		[Token(Token = "0x400C87F")]
		PracticalComplate = 2,
		[Token(Token = "0x400C880")]
		NotReceiveReward = 3,
		[Token(Token = "0x400C881")]
		ReceivedReward = 7
	}

	[Token(Token = "0x20014D0")]
	public class CertificationTimer
	{
		[Token(Token = "0x20014D1")]
		[Flags]
		private enum CountDownFrag
		{
			[Token(Token = "0x400C897")]
			zero = 1,
			[Token(Token = "0x400C898")]
			one = 2,
			[Token(Token = "0x400C899")]
			two = 4,
			[Token(Token = "0x400C89A")]
			three = 8,
			[Token(Token = "0x400C89B")]
			four = 0x10
		}

		[Token(Token = "0x400C882")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly string L_TimerRoot;

		[Token(Token = "0x400C883")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly string L_TimerBase0;

		[Token(Token = "0x400C884")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly string L_TimerBase1;

		[Token(Token = "0x400C885")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly string L_TimerBase2;

		[Token(Token = "0x400C886")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly string L_TimerGauge0;

		[Token(Token = "0x400C887")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly string L_TimerGauge1;

		[Token(Token = "0x400C888")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly string L_TimerNum;

		[Token(Token = "0x400C889")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private GameObject timerRoot;

		[Token(Token = "0x400C88A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private GameObject timerBase0;

		[Token(Token = "0x400C88B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private GameObject timerBase1;

		[Token(Token = "0x400C88C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private GameObject timerBase2;

		[Token(Token = "0x400C88D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject timerGauge0;

		[Token(Token = "0x400C88E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private GameObject timerGauge1;

		[Token(Token = "0x400C88F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Image fillAmountImage;

		[Token(Token = "0x400C890")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private ExtendedTextMeshProUGUI countDownText;

		[Token(Token = "0x400C891")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private ElementObjectManager _eom;

		[Token(Token = "0x400C892")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float currentQuestionLimitTime;

		[Token(Token = "0x400C893")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Action onTimeOut;

		[Token(Token = "0x400C894")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private bool isInit;

		[Token(Token = "0x400C895")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private CountDownFrag countDownFrag;

		[Token(Token = "0x60080FD")]
		[Address(RVA = "0xC919B0", Offset = "0xC90BB0", VA = "0x180C919B0")]
		public CertificationTimer(GameObject go)
		{
		}

		[Token(Token = "0x60080FE")]
		[Address(RVA = "0xC90FE0", Offset = "0xC901E0", VA = "0x180C90FE0")]
		public void Initialize()
		{
		}

		[Token(Token = "0x60080FF")]
		[Address(RVA = "0xC912D0", Offset = "0xC904D0", VA = "0x180C912D0")]
		public void Reset(float limitTime, [Optional] Action onTimeOut)
		{
		}

		[Token(Token = "0x6008100")]
		[Address(RVA = "0xC913C0", Offset = "0xC905C0", VA = "0x180C913C0")]
		public void SetTimerView(float remaineTime)
		{
		}

		[Token(Token = "0x6008101")]
		[Address(RVA = "0xC91650", Offset = "0xC90850", VA = "0x180C91650")]
		public void UpdateView(float currentTime)
		{
		}

		[Token(Token = "0x6008102")]
		[Address(RVA = "0xC90E30", Offset = "0xC90030", VA = "0x180C90E30")]
		private void CallTimerSE(float currentTime)
		{
		}
	}

	[Token(Token = "0x400C861")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static string m_CertificaionIconPath;

	[Token(Token = "0x400C862")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static string m_CertificaionIconImagePath;

	[Token(Token = "0x400C863")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static string m_CertificaionCommonIconPath;

	[Token(Token = "0x400C864")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static readonly string def10;

	[Token(Token = "0x400C865")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static readonly string sma10;

	[Token(Token = "0x400C866")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static readonly string def1;

	[Token(Token = "0x400C867")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static readonly string sma1;

	[Token(Token = "0x400C868")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static readonly string def10num;

	[Token(Token = "0x400C869")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static readonly string sma10num;

	[Token(Token = "0x400C86A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static readonly string def1num;

	[Token(Token = "0x400C86B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private static readonly string sma1num;

	[Token(Token = "0x60080E8")]
	[Address(RVA = "0xC93510", Offset = "0xC92710", VA = "0x180C93510")]
	public static void HandleResultCode(Handle handle, [Optional] Action onSuccess, [Optional] Action<CertificationCode> onFailed)
	{
	}

	[Token(Token = "0x60080E9")]
	[Address(RVA = "0xC93CE0", Offset = "0xC92EE0", VA = "0x180C93CE0")]
	public static void SetHolderActive(ElementObjectManager eom, bool isLarge)
	{
	}

	[Token(Token = "0x60080EA")]
	[Address(RVA = "0xC91FE0", Offset = "0xC911E0", VA = "0x180C91FE0")]
	public static string GetCertificationCommonIconPath(int id)
	{
		return null;
	}

	[Token(Token = "0x60080EB")]
	[Address(RVA = "0xC91B40", Offset = "0xC90D40", VA = "0x180C91B40")]
	public static BindingGameObjectEx BindCertificationCommonIcon(GameObject target, int id, bool async = true, [Optional] Action<GameObject> onCompleted)
	{
		return null;
	}

	[Token(Token = "0x60080EC")]
	[Address(RVA = "0xC92360", Offset = "0xC91560", VA = "0x180C92360")]
	public static string GetCertificationIconPath(int id)
	{
		return null;
	}

	[Token(Token = "0x60080ED")]
	[Address(RVA = "0xC91E30", Offset = "0xC91030", VA = "0x180C91E30")]
	public static BindingImageEx BindCertificationIcon(Image target, int id, bool async = true, bool removeColor = false)
	{
		return null;
	}

	[Token(Token = "0x60080EE")]
	[Address(RVA = "0xC91C70", Offset = "0xC90E70", VA = "0x180C91C70")]
	public static BindingImageEx BindCertificationIcon(Image target, int id, Action<GameObject> onFinish, bool async = true)
	{
		return null;
	}

	[Token(Token = "0x60080EF")]
	[Address(RVA = "0xC93760", Offset = "0xC92960", VA = "0x180C93760")]
	public static void SetGradeIdOfCertificationIcon(GameObject targetIcon, int gradeId)
	{
	}

	[Token(Token = "0x60080F0")]
	[Address(RVA = "0xC93700", Offset = "0xC92900", VA = "0x180C93700")]
	public static bool IsUnlocked()
	{
		return default(bool);
	}

	[Token(Token = "0x60080F1")]
	[Address(RVA = "0xC92560", Offset = "0xC91760", VA = "0x180C92560")]
	public static int GetGradeId(int id)
	{
		return default(int);
	}

	[Token(Token = "0x60080F2")]
	[Address(RVA = "0xC92780", Offset = "0xC91980", VA = "0x180C92780")]
	public static string GetPracticalText(TextGroupLoadHolder textGroupLoadHolder)
	{
		return null;
	}

	[Token(Token = "0x60080F3")]
	[Address(RVA = "0xC92CC0", Offset = "0xC91EC0", VA = "0x180C92CC0")]
	public static string GetPracticalText(int nowWindowId, TextGroupLoadHolder textGroupLoadHolder)
	{
		return null;
	}

	[Token(Token = "0x60080F4")]
	[Address(RVA = "0xC923E0", Offset = "0xC915E0", VA = "0x180C923E0")]
	public static Dictionary<string, object> GetCertificationMaster(int id)
	{
		return null;
	}

	[Token(Token = "0x60080F5")]
	[Address(RVA = "0xC92470", Offset = "0xC91670", VA = "0x180C92470")]
	public static Dictionary<string, object> GetCertification(int id)
	{
		return null;
	}

	[Token(Token = "0x60080F6")]
	[Address(RVA = "0xC934B0", Offset = "0xC926B0", VA = "0x180C934B0")]
	public static List<object> GetQuizList()
	{
		return null;
	}

	[Token(Token = "0x60080F7")]
	[Address(RVA = "0xC92500", Offset = "0xC91700", VA = "0x180C92500")]
	public static int GetCurrentCertificationId()
	{
		return default(int);
	}

	[Token(Token = "0x60080F8")]
	[Address(RVA = "0xC92640", Offset = "0xC91840", VA = "0x180C92640")]
	public static int GetInProgressGrade(int id)
	{
		return default(int);
	}

	[Token(Token = "0x60080F9")]
	[Address(RVA = "0xC93420", Offset = "0xC92620", VA = "0x180C93420")]
	public static int GetProgressStatus(int id)
	{
		return default(int);
	}

	[Token(Token = "0x60080FA")]
	[Address(RVA = "0xC926D0", Offset = "0xC918D0", VA = "0x180C926D0")]
	public static int GetPracticalProgress(int id, int practical_id)
	{
		return default(int);
	}

	[Token(Token = "0x60080FB")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public CertificationUtil()
	{
	}
}
