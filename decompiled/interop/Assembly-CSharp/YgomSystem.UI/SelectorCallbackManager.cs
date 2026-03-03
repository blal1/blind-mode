using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace YgomSystem.UI;

[Token(Token = "0x20004A6")]
public class SelectorCallbackManager
{
	[Token(Token = "0x20004A7")]
	private class CallbackInfo
	{
		[Token(Token = "0x40016C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SelectorManager.KeyType keyTypeMain;

		[Token(Token = "0x40016C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public SelectorManager.KeyType keyTypeSub;

		[Token(Token = "0x40016C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SelectorManager.MouseType mouseType;

		[Token(Token = "0x40016CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public SelectorManager.AnalogType analogType;

		[Token(Token = "0x40016CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SelectorManager.KeyStatus status;

		[Token(Token = "0x40016CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<CallbackPack> packs;

		[Token(Token = "0x40016CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<uint> resultID;

		[Token(Token = "0x6001EB5")]
		[Address(RVA = "0x6155A0", Offset = "0x6147A0", VA = "0x1806155A0")]
		public CallbackInfo(SelectorManager.KeyType main = SelectorManager.KeyType.None, SelectorManager.KeyType sub = SelectorManager.KeyType.None, SelectorManager.MouseType mouse = SelectorManager.MouseType.None, SelectorManager.AnalogType analog = SelectorManager.AnalogType.None, SelectorManager.KeyStatus status = SelectorManager.KeyStatus.OnPush)
		{
		}

		[Token(Token = "0x6001EB6")]
		[Address(RVA = "0x614D20", Offset = "0x613F20", VA = "0x180614D20")]
		public bool Match(SelectorManager.KeyType main = SelectorManager.KeyType.None, SelectorManager.KeyType sub = SelectorManager.KeyType.None, SelectorManager.MouseType mouse = SelectorManager.MouseType.None, SelectorManager.AnalogType analog = SelectorManager.AnalogType.None, SelectorManager.KeyStatus status = SelectorManager.KeyStatus.OnPush)
		{
			return default(bool);
		}

		[Token(Token = "0x6001EB7")]
		[Address(RVA = "0x6148A0", Offset = "0x613AA0", VA = "0x1806148A0")]
		public bool Equals(SelectorManager.KeyType main = SelectorManager.KeyType.None, SelectorManager.KeyType sub = SelectorManager.KeyType.None, SelectorManager.MouseType mouse = SelectorManager.MouseType.None, SelectorManager.AnalogType analog = SelectorManager.AnalogType.None, SelectorManager.KeyStatus status = SelectorManager.KeyStatus.OnPush)
		{
			return default(bool);
		}

		[Token(Token = "0x6001EB8")]
		[Address(RVA = "0x614260", Offset = "0x613460", VA = "0x180614260")]
		public void AddCallback(uint id, SelectionItem item, Func<bool> callback)
		{
		}

		[Token(Token = "0x6001EB9")]
		[Address(RVA = "0x614150", Offset = "0x613350", VA = "0x180614150")]
		public void AddCallback(uint id, int priority, Func<bool> callback)
		{
		}

		[Token(Token = "0x6001EBA")]
		[Address(RVA = "0x614A00", Offset = "0x613C00", VA = "0x180614A00")]
		public bool InvokeCallback(int priorityMin, [Optional] SelectionItem item)
		{
			return default(bool);
		}

		[Token(Token = "0x6001EBB")]
		[Address(RVA = "0x614FE0", Offset = "0x6141E0", VA = "0x180614FE0")]
		public List<uint> RemoveCallback(SelectionItem item)
		{
			return null;
		}

		[Token(Token = "0x6001EBC")]
		[Address(RVA = "0x615120", Offset = "0x614320", VA = "0x180615120")]
		public List<uint> RemoveCallback(SelectionItem item, Func<bool> callback)
		{
			return null;
		}

		[Token(Token = "0x6001EBD")]
		[Address(RVA = "0x614E90", Offset = "0x614090", VA = "0x180614E90")]
		public List<uint> RemoveCallback(int priority, Func<bool> callback)
		{
			return null;
		}

		[Token(Token = "0x6001EBE")]
		[Address(RVA = "0x614D60", Offset = "0x613F60", VA = "0x180614D60")]
		public List<uint> RemoveCallback(uint id)
		{
			return null;
		}

		[Token(Token = "0x6001EBF")]
		[Address(RVA = "0x614610", Offset = "0x613810", VA = "0x180614610")]
		public List<uint> ClearCallback()
		{
			return null;
		}

		[Token(Token = "0x6001EC0")]
		[Address(RVA = "0x6148D0", Offset = "0x613AD0", VA = "0x1806148D0")]
		public bool Exist(uint id)
		{
			return default(bool);
		}

		[Token(Token = "0x6001EC1")]
		[Address(RVA = "0x614380", Offset = "0x613580", VA = "0x180614380")]
		public void Cleanup()
		{
		}

		[Token(Token = "0x6001EC2")]
		[Address(RVA = "0x615280", Offset = "0x614480", VA = "0x180615280", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Token(Token = "0x20004AD")]
	private class CallbackPack
	{
		[Token(Token = "0x40016D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint id;

		[Token(Token = "0x40016D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SelectionItem item;

		[Token(Token = "0x40016D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Func<bool> callback;

		[Token(Token = "0x40016D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int priority;

		[Token(Token = "0x6001ECF")]
		[Address(RVA = "0x615820", Offset = "0x614A20", VA = "0x180615820")]
		public CallbackPack(uint id, SelectionItem item, Func<bool> callback)
		{
		}

		[Token(Token = "0x6001ED0")]
		[Address(RVA = "0x615890", Offset = "0x614A90", VA = "0x180615890")]
		public CallbackPack(uint id, int priority, Func<bool> callback)
		{
		}

		[Token(Token = "0x6001ED1")]
		[Address(RVA = "0x615660", Offset = "0x614860", VA = "0x180615660")]
		public void ClearCallback()
		{
		}

		[Token(Token = "0x6001ED2")]
		[Address(RVA = "0x615680", Offset = "0x614880", VA = "0x180615680", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Token(Token = "0x40016C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private List<CallbackInfo> selectedCallbacks;

	[Token(Token = "0x40016C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private List<CallbackInfo> shortcutCallbacks;

	[Token(Token = "0x40016C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<uint> packIDList;

	[Token(Token = "0x40016C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private uint createCount;

	[Token(Token = "0x40016C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static List<uint> resultID;

	[Token(Token = "0x40016C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private int activeClusterPriorityMin;

	[Token(Token = "0x6001EA2")]
	[Address(RVA = "0x616D00", Offset = "0x615F00", VA = "0x180616D00")]
	public uint AddSelectedCallback(SelectionItem item, SelectorManager.KeyStatus status, SelectorManager.KeyType main, SelectorManager.KeyType sub, SelectorManager.MouseType mouse, SelectorManager.AnalogType analog, Func<bool> callback)
	{
		return default(uint);
	}

	[Token(Token = "0x6001EA3")]
	[Address(RVA = "0x6173A0", Offset = "0x6165A0", VA = "0x1806173A0")]
	public List<uint> ClearSelectedCallback(SelectionItem item)
	{
		return null;
	}

	[Token(Token = "0x6001EA4")]
	[Address(RVA = "0x618420", Offset = "0x617620", VA = "0x180618420")]
	public List<uint> RemoveSelectedCallback(SelectionItem item, SelectorManager.KeyStatus status, SelectorManager.KeyType main, SelectorManager.KeyType sub, SelectorManager.MouseType mouse, SelectorManager.AnalogType analog, Func<bool> callback)
	{
		return null;
	}

	[Token(Token = "0x6001EA5")]
	[Address(RVA = "0x6187C0", Offset = "0x6179C0", VA = "0x1806187C0")]
	public List<uint> RemoveSelectedCallback(SelectionItem item, SelectorManager.KeyStatus status, SelectorManager.KeyType main, SelectorManager.KeyType sub, SelectorManager.MouseType mouse, SelectorManager.AnalogType analog)
	{
		return null;
	}

	[Token(Token = "0x6001EA6")]
	[Address(RVA = "0x617F60", Offset = "0x617160", VA = "0x180617F60")]
	public List<uint> RemoveCallback(uint packID)
	{
		return null;
	}

	[Token(Token = "0x6001EA7")]
	[Address(RVA = "0x617060", Offset = "0x616260", VA = "0x180617060")]
	public uint AddShortcutCallback(SelectionItem item, SelectorManager.KeyStatus status, SelectorManager.KeyType main, SelectorManager.KeyType sub, SelectorManager.MouseType mouse, SelectorManager.AnalogType analog, Func<bool> callback, bool highPriority = false)
	{
		return default(uint);
	}

	[Token(Token = "0x6001EA8")]
	[Address(RVA = "0x6176F0", Offset = "0x6168F0", VA = "0x1806176F0")]
	public List<uint> ClearShortcutCallback(SelectionItem item)
	{
		return null;
	}

	[Token(Token = "0x6001EA9")]
	[Address(RVA = "0x619280", Offset = "0x618480", VA = "0x180619280")]
	public List<uint> RemoveShortcutCallback(SelectionItem item, SelectorManager.KeyStatus status, SelectorManager.KeyType main, SelectorManager.KeyType sub, SelectorManager.MouseType mouse, SelectorManager.AnalogType analog, Func<bool> callback)
	{
		return null;
	}

	[Token(Token = "0x6001EAA")]
	[Address(RVA = "0x618EF0", Offset = "0x6180F0", VA = "0x180618EF0")]
	public List<uint> RemoveShortcutCallback(SelectionItem item, SelectorManager.KeyStatus status, SelectorManager.KeyType main, SelectorManager.KeyType sub, SelectorManager.MouseType mouse, SelectorManager.AnalogType analog)
	{
		return null;
	}

	[Token(Token = "0x6001EAB")]
	[Address(RVA = "0x616E40", Offset = "0x616040", VA = "0x180616E40")]
	public uint AddShortcutCallback(int priority, SelectorManager.KeyStatus status, SelectorManager.KeyType main, SelectorManager.KeyType sub, SelectorManager.MouseType mouse, SelectorManager.AnalogType analog, Func<bool> callback, bool highPriority = false)
	{
		return default(uint);
	}

	[Token(Token = "0x6001EAC")]
	[Address(RVA = "0x618B50", Offset = "0x617D50", VA = "0x180618B50")]
	public List<uint> RemoveShortcutCallback(int priority, SelectorManager.KeyStatus status, SelectorManager.KeyType main, SelectorManager.KeyType sub, SelectorManager.MouseType mouse, SelectorManager.AnalogType analog, Func<bool> callback)
	{
		return null;
	}

	[Token(Token = "0x6001EAD")]
	[Address(RVA = "0x617A40", Offset = "0x616C40", VA = "0x180617A40")]
	private CallbackInfo GetCallbackInfo(List<CallbackInfo> targetList, SelectorManager.KeyStatus status, SelectorManager.KeyType main = SelectorManager.KeyType.None, SelectorManager.KeyType sub = SelectorManager.KeyType.None, SelectorManager.MouseType mouse = SelectorManager.MouseType.None, SelectorManager.AnalogType analog = SelectorManager.AnalogType.None)
	{
		return null;
	}

	[Token(Token = "0x6001EAE")]
	[Address(RVA = "0x617D90", Offset = "0x616F90", VA = "0x180617D90")]
	private uint IssueCallbackPackID()
	{
		return default(uint);
	}

	[Token(Token = "0x6001EAF")]
	[Address(RVA = "0x617B10", Offset = "0x616D10", VA = "0x180617B10")]
	public bool InvokeSelectedCallback(SelectionItem selectedItem, SelectorManager.KeyStatus status, SelectorManager.KeyType main, SelectorManager.KeyType sub, SelectorManager.MouseType mouse, SelectorManager.AnalogType analog)
	{
		return default(bool);
	}

	[Token(Token = "0x6001EB0")]
	[Address(RVA = "0x617C80", Offset = "0x616E80", VA = "0x180617C80")]
	public bool InvokeShortcutCallback(SelectorManager.KeyStatus status, SelectorManager.KeyType main, SelectorManager.KeyType sub, SelectorManager.MouseType mouse, SelectorManager.AnalogType analog)
	{
		return default(bool);
	}

	[Token(Token = "0x6001EB1")]
	[Address(RVA = "0x6171D0", Offset = "0x6163D0", VA = "0x1806171D0")]
	public void Cleanup()
	{
	}

	[Token(Token = "0x6001EB2")]
	[Address(RVA = "0x619620", Offset = "0x618820", VA = "0x180619620")]
	public void SetActiveClusterPriority(int min, bool force)
	{
	}

	[Token(Token = "0x6001EB3")]
	[Address(RVA = "0x6196D0", Offset = "0x6188D0", VA = "0x1806196D0")]
	public SelectorCallbackManager()
	{
	}
}
