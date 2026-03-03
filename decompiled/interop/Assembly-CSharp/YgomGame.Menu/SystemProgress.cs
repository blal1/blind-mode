using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.Utility;

namespace YgomGame.Menu;

[Token(Token = "0x20013E3")]
public class SystemProgress : MonoBehaviour
{
	[Token(Token = "0x20013E4")]
	public enum ProgressType
	{
		[Token(Token = "0x400C45D")]
		None,
		[Token(Token = "0x400C45E")]
		Normal,
		[Token(Token = "0x400C45F")]
		Tips,
		[Token(Token = "0x400C460")]
		Blank
	}

	[Token(Token = "0x20013E5")]
	[CompilerGenerated]
	private sealed class _003CShowNormalProgress_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400C461")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400C462")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400C463")]
		[FieldOffset(Offset = "0x20")]
		public SystemProgress _003C_003E4__this;

		[Token(Token = "0x400C464")]
		[FieldOffset(Offset = "0x28")]
		public bool isShow;

		[Token(Token = "0x400C465")]
		[FieldOffset(Offset = "0x30")]
		private Tween _003CloadingTween_003E5__2;

		[Token(Token = "0x17001300")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6007BCF")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001301")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6007BD1")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6007BCC")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CShowNormalProgress_003Ed__39(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6007BCD")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6007BCE")]
		[Address(RVA = "0xC4E6F0", Offset = "0xC4D8F0", VA = "0x180C4E6F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6007BD0")]
		[Address(RVA = "0xC4E8E0", Offset = "0xC4DAE0", VA = "0x180C4E8E0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400C446")]
	[FieldOffset(Offset = "0x20")]
	public CanvasGroup fillScreen;

	[Token(Token = "0x400C447")]
	[FieldOffset(Offset = "0x28")]
	public Image fadeScreen;

	[Token(Token = "0x400C448")]
	[FieldOffset(Offset = "0x30")]
	public GameObject normalProgress;

	[Token(Token = "0x400C449")]
	[FieldOffset(Offset = "0x38")]
	public GameObject tipsProgress;

	[Token(Token = "0x400C44A")]
	[FieldOffset(Offset = "0x40")]
	public GameObject connectingProgress;

	[Token(Token = "0x400C44B")]
	[FieldOffset(Offset = "0x48")]
	public ElementObjectManager fatalErrorDialogPref;

	[Token(Token = "0x400C44C")]
	[FieldOffset(Offset = "0x50")]
	public float delayTime;

	[Token(Token = "0x400C44D")]
	[FieldOffset(Offset = "0x54")]
	public float guaranteeTime;

	[Token(Token = "0x400C44E")]
	[FieldOffset(Offset = "0x58")]
	public float fadeSpeed;

	[Token(Token = "0x400C44F")]
	[FieldOffset(Offset = "0x5C")]
	public float fadeAlpha;

	[Token(Token = "0x400C450")]
	[FieldOffset(Offset = "0x60")]
	private int count;

	[Token(Token = "0x400C451")]
	[FieldOffset(Offset = "0x64")]
	private float crntTime;

	[Token(Token = "0x400C452")]
	[FieldOffset(Offset = "0x68")]
	private bool rebooting;

	[Token(Token = "0x400C453")]
	[FieldOffset(Offset = "0x69")]
	private bool unloadCalled;

	[Token(Token = "0x400C454")]
	[FieldOffset(Offset = "0x6C")]
	private ResourceManager.UnloadCheckLevel unloadCheckLevel;

	[Token(Token = "0x400C455")]
	[FieldOffset(Offset = "0x70")]
	private string abortRequest;

	[Token(Token = "0x400C456")]
	[FieldOffset(Offset = "0x78")]
	private AppInfo.BootType abortRequestType;

	[Token(Token = "0x400C457")]
	[FieldOffset(Offset = "0x7C")]
	private ProgressType crntType;

	[Token(Token = "0x400C458")]
	[FieldOffset(Offset = "0x80")]
	private bool crntScreenCenter;

	[Token(Token = "0x400C459")]
	[FieldOffset(Offset = "0x88")]
	private Dictionary<string, object> tipsSettingDict;

	[Token(Token = "0x400C45A")]
	[FieldOffset(Offset = "0x90")]
	private Image centerFadeScreen;

	[Token(Token = "0x400C45B")]
	[FieldOffset(Offset = "0x98")]
	public bool CenterFade;

	[Token(Token = "0x170012FE")]
	[Obsolete]
	public static SystemProgress Instance
	{
		[Token(Token = "0x6007BB6")]
		[Address(RVA = "0xC49780", Offset = "0xC48980", VA = "0x180C49780")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012FF")]
	public Color fadeColor
	{
		[Token(Token = "0x6007BB7")]
		[Address(RVA = "0xC49900", Offset = "0xC48B00", VA = "0x180C49900")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x6007BB8")]
	[Address(RVA = "0xC49790", Offset = "0xC48990", VA = "0x180C49790")]
	public static string get_driverURL()
	{
		return null;
	}

	[Token(Token = "0x6007BB9")]
	[Address(RVA = "0xC49340", Offset = "0xC48540", VA = "0x180C49340")]
	public void OnFatalErrorReboot()
	{
	}

	[Token(Token = "0x6007BBA")]
	[Address(RVA = "0xC49350", Offset = "0xC48550", VA = "0x180C49350")]
	public void OnSafeModeReboot()
	{
	}

	[Token(Token = "0x6007BBB")]
	[Address(RVA = "0xC491D0", Offset = "0xC483D0", VA = "0x180C491D0")]
	public void OnAbortRebootRequest(string bootpage, AppInfo.BootType boottype = AppInfo.BootType.ExitReboot)
	{
	}

	[Token(Token = "0x6007BBC")]
	[Address(RVA = "0xC49280", Offset = "0xC48480", VA = "0x180C49280")]
	private void OnAbortReboot(string bootpage, AppInfo.BootType boottype)
	{
	}

	[Token(Token = "0x6007BBD")]
	[Address(RVA = "0xC486E0", Offset = "0xC478E0", VA = "0x180C486E0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6007BBE")]
	[Address(RVA = "0xC492A0", Offset = "0xC484A0", VA = "0x180C492A0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6007BBF")]
	[Address(RVA = "0xC49520", Offset = "0xC48720", VA = "0x180C49520")]
	private void Update()
	{
	}

	[Token(Token = "0x6007BC0")]
	[Address(RVA = "0xC49460", Offset = "0xC48660", VA = "0x180C49460")]
	private void SetDirty()
	{
	}

	[Token(Token = "0x6007BC1")]
	[Address(RVA = "0xC48DE0", Offset = "0xC47FE0", VA = "0x180C48DE0")]
	public float GetFadeAlpha()
	{
		return default(float);
	}

	[Token(Token = "0x6007BC2")]
	[Address(RVA = "0xC48FB0", Offset = "0xC481B0", VA = "0x180C48FB0")]
	private bool IsNeedChangeFadeAlpha(Color fadeColor)
	{
		return default(bool);
	}

	[Token(Token = "0x6007BC3")]
	[Address(RVA = "0xC48A50", Offset = "0xC47C50", VA = "0x180C48A50")]
	public void DispProgress(ProgressType type, Color fadeColor, float delay = 0f, bool immediate = false, ResourceManager.UnloadCheckLevel unloadCheckLevel = ResourceManager.UnloadCheckLevel.Low)
	{
	}

	[Token(Token = "0x6007BC4")]
	[Address(RVA = "0xC494A0", Offset = "0xC486A0", VA = "0x180C494A0")]
	[IteratorStateMachine(typeof(_003CShowNormalProgress_003Ed__39))]
	private IEnumerator ShowNormalProgress(bool isShow)
	{
		return null;
	}

	[Token(Token = "0x6007BC5")]
	[Address(RVA = "0xC49380", Offset = "0xC48580", VA = "0x180C49380")]
	private static string RandomSelectTipsNumberString(Dictionary<string, object> tipsSettingDict)
	{
		return null;
	}

	[Token(Token = "0x6007BC6")]
	[Address(RVA = "0xC49010", Offset = "0xC48210", VA = "0x180C49010")]
	private void LoadTipsSetting()
	{
	}

	[Token(Token = "0x6007BC7")]
	[Address(RVA = "0xC48F40", Offset = "0xC48140", VA = "0x180C48F40")]
	public void HideProgress()
	{
	}

	[Token(Token = "0x6007BC8")]
	[Address(RVA = "0xC48E70", Offset = "0xC48070", VA = "0x180C48E70")]
	public ViewControllerManager.FadeState GetFadeState()
	{
		return default(ViewControllerManager.FadeState);
	}

	[Token(Token = "0x6007BC9")]
	[Address(RVA = "0xC48EE0", Offset = "0xC480E0", VA = "0x180C48EE0")]
	public GameObject GetNormalProgress()
	{
		return null;
	}

	[Token(Token = "0x6007BCA")]
	[Address(RVA = "0xC48990", Offset = "0xC47B90", VA = "0x180C48990")]
	public void ClearOnReboot()
	{
	}

	[Token(Token = "0x6007BCB")]
	[Address(RVA = "0xC49760", Offset = "0xC48960", VA = "0x180C49760")]
	public SystemProgress()
	{
	}
}
