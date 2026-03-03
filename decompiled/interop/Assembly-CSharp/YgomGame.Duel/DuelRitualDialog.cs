using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.Utility;
using YgomSystem.YGomTMPro;

namespace YgomGame.Duel;

[Token(Token = "0x20018CB")]
public class DuelRitualDialog : DuelInfoDialogBase, IGameObjectPool
{
	[Token(Token = "0x20018CC")]
	public enum Mode
	{
		[Token(Token = "0x400E890")]
		None,
		[Token(Token = "0x400E891")]
		Star,
		[Token(Token = "0x400E892")]
		Link,
		[Token(Token = "0x400E893")]
		Atk
	}

	[Token(Token = "0x20018CD")]
	private class RitualDialogOperationInfo : OperationInfo
	{
		[Token(Token = "0x6009FD9")]
		[Address(RVA = "0xEE5130", Offset = "0xEE4330", VA = "0x180EE5130")]
		public static OperationInfo OpenOperation(DuelRitualDialog dialog, Place place)
		{
			return null;
		}

		[Token(Token = "0x6009FDA")]
		[Address(RVA = "0xEE4FF0", Offset = "0xEE41F0", VA = "0x180EE4FF0")]
		public static OperationInfo OpenOperation(DuelRitualDialog dialog)
		{
			return null;
		}

		[Token(Token = "0x6009FDB")]
		[Address(RVA = "0xEE5270", Offset = "0xEE4470", VA = "0x180EE5270")]
		public RitualDialogOperationInfo()
		{
		}
	}

	[Token(Token = "0x400E87F")]
	[FieldOffset(Offset = "0xA0")]
	private GameObject starGroup;

	[Token(Token = "0x400E880")]
	[FieldOffset(Offset = "0xA8")]
	private GameObject linkGroup;

	[Token(Token = "0x400E881")]
	[FieldOffset(Offset = "0xB0")]
	private GameObject atkGroup;

	[Token(Token = "0x400E882")]
	[FieldOffset(Offset = "0xB8")]
	private ElementObjectManager starTemplate;

	[Token(Token = "0x400E883")]
	[FieldOffset(Offset = "0xC0")]
	private ElementObjectManager linkTemplate;

	[Token(Token = "0x400E884")]
	[FieldOffset(Offset = "0xC8")]
	private ExtendedTextMeshProUGUI textRequireParam;

	[Token(Token = "0x400E885")]
	[FieldOffset(Offset = "0xD0")]
	private ExtendedTextMeshProUGUI textCurrentParam;

	[Token(Token = "0x400E886")]
	[FieldOffset(Offset = "0xD8")]
	private Mode currentMode;

	[Token(Token = "0x400E88B")]
	[FieldOffset(Offset = "0xF0")]
	private List<ElementObjectManager> countObjects;

	[Token(Token = "0x400E88D")]
	private const string key = "DuelRitualDialog";

	[Token(Token = "0x400E88E")]
	private const string prefabPath = "Prefabs/Duel/DuelRitualDialog";

	[Token(Token = "0x17001841")]
	public Engine.DialogRitualType ritualType
	{
		[Token(Token = "0x6009FBF")]
		[Address(RVA = "0xA2A110", Offset = "0xA29310", VA = "0x180A2A110")]
		[CompilerGenerated]
		get
		{
			return default(Engine.DialogRitualType);
		}
		[Token(Token = "0x6009FC0")]
		[Address(RVA = "0xA2A550", Offset = "0xA29750", VA = "0x180A2A550")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001842")]
	public int remainNum
	{
		[Token(Token = "0x6009FC1")]
		[Address(RVA = "0x746560", Offset = "0x745760", VA = "0x180746560")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6009FC2")]
		[Address(RVA = "0xA2A4F0", Offset = "0xA296F0", VA = "0x180A2A4F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001843")]
	public int maxNum
	{
		[Token(Token = "0x6009FC3")]
		[Address(RVA = "0xA2A0E0", Offset = "0xA292E0", VA = "0x180A2A0E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6009FC4")]
		[Address(RVA = "0xA2A530", Offset = "0xA29730", VA = "0x180A2A530")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001844")]
	public string message
	{
		[Token(Token = "0x6009FC5")]
		[Address(RVA = "0x49BAE0", Offset = "0x49ACE0", VA = "0x18049BAE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6009FC6")]
		[Address(RVA = "0x49C200", Offset = "0x49B400", VA = "0x18049C200")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001845")]
	public bool isReady
	{
		[Token(Token = "0x6009FC7")]
		[Address(RVA = "0x49B790", Offset = "0x49A990", VA = "0x18049B790")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6009FC8")]
		[Address(RVA = "0x49C010", Offset = "0x49B210", VA = "0x18049C010")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001846")]
	public string poolKey
	{
		[Token(Token = "0x6009FC9")]
		[Address(RVA = "0xED6DA0", Offset = "0xED5FA0", VA = "0x180ED6DA0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001847")]
	public GameObject pooledTarget
	{
		[Token(Token = "0x6009FCA")]
		[Address(RVA = "0x4A1C50", Offset = "0x4A0E50", VA = "0x1804A1C50", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6009FCB")]
	[Address(RVA = "0xED6340", Offset = "0xED5540", VA = "0x180ED6340")]
	public void ReqOpen(Place place)
	{
	}

	[Token(Token = "0x6009FCC")]
	[Address(RVA = "0xED61C0", Offset = "0xED53C0", VA = "0x180ED61C0")]
	public void ReqOpen()
	{
	}

	[Token(Token = "0x6009FCD")]
	[Address(RVA = "0xED5DC0", Offset = "0xED4FC0", VA = "0x180ED5DC0")]
	public static void Create(RunEffectWorker effectWorker, Transform parent, Action<DuelRitualDialog> finishCallback)
	{
	}

	[Token(Token = "0x6009FCE")]
	[Address(RVA = "0xED5A90", Offset = "0xED4C90", VA = "0x180ED5A90", Slot = "6")]
	protected override void CreateUI()
	{
	}

	[Token(Token = "0x6009FCF")]
	[Address(RVA = "0xED59C0", Offset = "0xED4BC0", VA = "0x180ED59C0")]
	public void Begin(string message, Engine.DialogRitualType type, int remainNum, int maxNum)
	{
	}

	[Token(Token = "0x6009FD0")]
	[Address(RVA = "0xED60B0", Offset = "0xED52B0", VA = "0x180ED60B0")]
	public void End()
	{
	}

	[Token(Token = "0x6009FD1")]
	[Address(RVA = "0xED6770", Offset = "0xED5970", VA = "0x180ED6770")]
	public void SetStarFadeEnable(bool enable, int uniqueId)
	{
	}

	[Token(Token = "0x6009FD2")]
	[Address(RVA = "0xED6170", Offset = "0xED5370", VA = "0x180ED6170")]
	private void Open(Place place)
	{
	}

	[Token(Token = "0x6009FD3")]
	[Address(RVA = "0x648190", Offset = "0x647390", VA = "0x180648190")]
	private void Open()
	{
	}

	[Token(Token = "0x6009FD4")]
	[Address(RVA = "0xED6970", Offset = "0xED5B70", VA = "0x180ED6970")]
	private void SetupCountGroup(Mode mode, int maxNum)
	{
	}

	[Token(Token = "0x6009FD5")]
	[Address(RVA = "0xED64C0", Offset = "0xED56C0", VA = "0x180ED64C0")]
	public void SetCount(int remainNum)
	{
	}

	[Token(Token = "0x6009FD6")]
	[Address(RVA = "0xED5F70", Offset = "0xED5170", VA = "0x180ED5F70")]
	private void DestroyCountObjectList()
	{
	}

	[Token(Token = "0x6009FD7")]
	[Address(RVA = "0xED60C0", Offset = "0xED52C0", VA = "0x180ED60C0", Slot = "19")]
	public void OnReturned()
	{
	}

	[Token(Token = "0x6009FD8")]
	[Address(RVA = "0xED6D20", Offset = "0xED5F20", VA = "0x180ED6D20")]
	public DuelRitualDialog()
	{
	}
}
