using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x200056F")]
[AddComponentMenu("Ygom/UI/View Controller/View Controller")]
public class ViewController : MonoBehaviour
{
	[Token(Token = "0x2000570")]
	public enum TransitionType
	{
		[Token(Token = "0x4001A80")]
		Push,
		[Token(Token = "0x4001A81")]
		Pop,
		[Token(Token = "0x4001A82")]
		Cover,
		[Token(Token = "0x4001A83")]
		Uncover,
		[Token(Token = "0x4001A84")]
		SwapIn,
		[Token(Token = "0x4001A85")]
		SwapOut,
		[Token(Token = "0x4001A86")]
		Max
	}

	[Token(Token = "0x2000571")]
	public enum ViewStyle
	{
		[Token(Token = "0x4001A88")]
		Part,
		[Token(Token = "0x4001A89")]
		Full
	}

	[Token(Token = "0x4001A75")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ViewStyle viewStyle;

	[Token(Token = "0x4001A76")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool acceptBack;

	[Token(Token = "0x4001A77")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
	public bool securitySingle031;

	[Token(Token = "0x4001A78")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
	public bool parallelTransition;

	[Token(Token = "0x4001A79")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x27")]
	public bool uniqueView;

	[Token(Token = "0x4001A7A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Dictionary<string, object> args;

	[Token(Token = "0x4001A7B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public ViewControllerManager manager;

	[Token(Token = "0x4001A7C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private List<MonoBehaviour> unSleepArray;

	[Token(Token = "0x4001A7E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	protected static readonly string ParameterArgKey;

	[Token(Token = "0x170003CC")]
	[HideInInspector]
	public Dictionary<string, object> Args
	{
		[Token(Token = "0x600232F")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600232E")]
		[Address(RVA = "0x402FB0", Offset = "0x4021B0", VA = "0x180402FB0")]
		set
		{
		}
	}

	[Token(Token = "0x170003CD")]
	protected virtual int selectorPriorityAddRange
	{
		[Token(Token = "0x6002330")]
		[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170003CE")]
	protected int selectorPriorityBase
	{
		[Token(Token = "0x6002331")]
		[Address(RVA = "0x5FA7B0", Offset = "0x5F99B0", VA = "0x1805FA7B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002332")]
		[Address(RVA = "0x409CD0", Offset = "0x408ED0", VA = "0x180409CD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170003CF")]
	protected int selectorPriorityMax
	{
		[Token(Token = "0x6002333")]
		[Address(RVA = "0x65AF50", Offset = "0x65A150", VA = "0x18065AF50")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6002334")]
	[Address(RVA = "0x65A500", Offset = "0x659700", VA = "0x18065A500")]
	public int GetSelectorPriorityAdditional(int addPos)
	{
		return default(int);
	}

	[Token(Token = "0x6002335")]
	[Address(RVA = "0x65AB60", Offset = "0x659D60", VA = "0x18065AB60")]
	public void PrepareStackEntry()
	{
	}

	[Token(Token = "0x6002336")]
	[Address(RVA = "0x44E9B0", Offset = "0x44DBB0", VA = "0x18044E9B0", Slot = "5")]
	public virtual void SetVisibleOnInitialize(bool visible)
	{
	}

	[Token(Token = "0x6002337")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "6")]
	public virtual void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6002338")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "7")]
	public virtual void NotificationStackRemove()
	{
	}

	[Token(Token = "0x6002339")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "8")]
	public virtual void NotificationStack(ViewControllerManager vcm, ViewController vc, bool isEntry)
	{
	}

	[Token(Token = "0x600233A")]
	[Address(RVA = "0x65ACB0", Offset = "0x659EB0", VA = "0x18065ACB0", Slot = "9")]
	public virtual float Progress()
	{
		return default(float);
	}

	[Token(Token = "0x600233B")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "10")]
	public virtual void ProgressUpdate()
	{
	}

	[Token(Token = "0x600233C")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "11")]
	public virtual void TransitionStart(TransitionType type)
	{
	}

	[Token(Token = "0x600233D")]
	[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "12")]
	public virtual bool TransitionUpdate(TransitionType type)
	{
		return default(bool);
	}

	[Token(Token = "0x600233E")]
	[Address(RVA = "0x65A460", Offset = "0x659660", VA = "0x18065A460")]
	protected ViewControllerManager GetRootManager()
	{
		return null;
	}

	[Token(Token = "0x600233F")]
	[Address(RVA = "0x65AA50", Offset = "0x659C50", VA = "0x18065AA50", Slot = "13")]
	public virtual bool OnBack()
	{
		return default(bool);
	}

	[Token(Token = "0x6002340")]
	[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "14")]
	public virtual bool OnResult(ViewController from, object value)
	{
		return default(bool);
	}

	[Token(Token = "0x6002341")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "15")]
	public virtual void OnFocusChanged(bool setfocus)
	{
	}

	[Token(Token = "0x6002342")]
	[Address(RVA = "0x65AE00", Offset = "0x65A000", VA = "0x18065AE00")]
	public ViewController SendResult(object value)
	{
		return null;
	}

	[Token(Token = "0x6002343")]
	[Address(RVA = "0x65AD00", Offset = "0x659F00", VA = "0x18065AD00")]
	public void SendBack()
	{
	}

	[Token(Token = "0x6002344")]
	[Address(RVA = "0x65AAE0", Offset = "0x659CE0", VA = "0x18065AAE0")]
	public void PopViewController()
	{
	}

	[Token(Token = "0x6002345")]
	[Address(RVA = "0x65ACE0", Offset = "0x659EE0", VA = "0x18065ACE0")]
	public void PushViewController(string prefabname, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6002346")]
	[Address(RVA = "0x65ACC0", Offset = "0x659EC0", VA = "0x18065ACC0")]
	public void PushViewController(GameObject prefab)
	{
	}

	[Token(Token = "0x6002347")]
	[Address(RVA = "0x65AE80", Offset = "0x65A080", VA = "0x18065AE80")]
	public void SwapViewController(string prefabname, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6002348")]
	[Address(RVA = "0x65AE40", Offset = "0x65A040", VA = "0x18065AE40")]
	public void SwapViewController(GameObject prefab)
	{
	}

	[Token(Token = "0x6002349")]
	[Address(RVA = "0x65A550", Offset = "0x659750", VA = "0x18065A550")]
	public bool IsDoneBindingUnSleep()
	{
		return default(bool);
	}

	[Token(Token = "0x600234A")]
	[Address(RVA = "0x65A0F0", Offset = "0x6592F0", VA = "0x18065A0F0")]
	public void CallUnSleepStart()
	{
	}

	[Token(Token = "0x600234B")]
	[Address(RVA = "0x65A290", Offset = "0x659490", VA = "0x18065A290")]
	public void CallUnSleepUpdate()
	{
	}

	[Token(Token = "0x600234C")]
	[Address(RVA = "0x65A8E0", Offset = "0x659AE0", VA = "0x18065A8E0")]
	private void MakeUnSleepArray()
	{
	}

	[Token(Token = "0x600234D")]
	public static Dictionary<string, object> CreateParameterArg<T>(T parameter) where T : class
	{
		return null;
	}

	[Token(Token = "0x600234E")]
	protected T GetParameterArg<T>() where T : class
	{
		return null;
	}

	[Token(Token = "0x600234F")]
	[Address(RVA = "0x65AF30", Offset = "0x65A130", VA = "0x18065AF30")]
	public ViewController()
	{
	}
}
