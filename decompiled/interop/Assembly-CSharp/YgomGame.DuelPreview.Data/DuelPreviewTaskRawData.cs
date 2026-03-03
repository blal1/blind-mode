using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.DuelPreview.Data;

[Serializable]
[Token(Token = "0x2000E43")]
public class DuelPreviewTaskRawData
{
	[Serializable]
	[Token(Token = "0x2000E44")]
	public class MrkFilterdData
	{
		[Serializable]
		[Token(Token = "0x2000E45")]
		public class Data
		{
			[Token(Token = "0x400A2D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int mrk;

			[Token(Token = "0x400A2DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string value;

			[Token(Token = "0x6005674")]
			[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
			public Data()
			{
			}
		}

		[Token(Token = "0x400A2D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private List<Data> m_Datas;

		[Token(Token = "0x6005672")]
		[Address(RVA = "0x9BCA30", Offset = "0x9BBC30", VA = "0x1809BCA30")]
		public object Find(int mrk)
		{
			return null;
		}

		[Token(Token = "0x6005673")]
		[Address(RVA = "0x9BCB60", Offset = "0x9BBD60", VA = "0x1809BCB60")]
		public MrkFilterdData()
		{
		}
	}

	[Token(Token = "0x2000E46")]
	public enum TaskType
	{
		[Token(Token = "0x400A2DC")]
		None,
		[Token(Token = "0x400A2DD")]
		SummonCutin,
		[Token(Token = "0x400A2DE")]
		CardEffectRun,
		[Token(Token = "0x400A2DF")]
		SpawnCard,
		[Token(Token = "0x400A2E0")]
		PlayBeziersMotion,
		[Token(Token = "0x400A2E1")]
		SetCardMaterial,
		[Token(Token = "0x400A2E2")]
		PlaySimpleEffect,
		[Token(Token = "0x400A2E3")]
		Group,
		[Token(Token = "0x400A2E4")]
		ScreenFilter,
		[Token(Token = "0x400A2E5")]
		SpawnPref,
		[Token(Token = "0x400A2E6")]
		PlayTmLabel,
		[Token(Token = "0x400A2E7")]
		PlayTmGoToEnd,
		[Token(Token = "0x400A2E8")]
		WaitSecond,
		[Token(Token = "0x400A2E9")]
		PlayTm,
		[Token(Token = "0x400A2EA")]
		WaitTm,
		[Token(Token = "0x400A2EB")]
		BindingPrefCard,
		[Token(Token = "0x400A2EC")]
		SetPrefVisible,
		[Token(Token = "0x400A2ED")]
		SyncPos,
		[Token(Token = "0x400A2EE")]
		SetPos,
		[Token(Token = "0x400A2EF")]
		SetActivate,
		[Token(Token = "0x400A2F0")]
		SetField,
		[Token(Token = "0x400A2F1")]
		WaitCardEffectRun,
		[Token(Token = "0x400A2F2")]
		SyncPlayEnd,
		[Token(Token = "0x400A2F3")]
		ResistMods
	}

	[Token(Token = "0x2000E47")]
	public enum TransitionType
	{
		[Token(Token = "0x400A2F5")]
		WaitPlayComplete,
		[Token(Token = "0x400A2F6")]
		Through
	}

	[Token(Token = "0x400A2CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[SerializeField]
	private TaskType m_TaskType;

	[Token(Token = "0x400A2CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[SerializeField]
	private TransitionType m_TransitionType;

	[Token(Token = "0x400A2CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private bool[] m_BoolArgs;

	[Token(Token = "0x400A2D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private int[] m_IntArgs;

	[Token(Token = "0x400A2D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float[] m_FloatArgs;

	[Token(Token = "0x400A2D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private string[] m_StringArgs;

	[Token(Token = "0x400A2D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	[TextArea]
	private string[] m_TextArgs;

	[Token(Token = "0x400A2D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Vector3[] m_Vector3Args;

	[Token(Token = "0x400A2D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Color[] m_ColorArgs;

	[Token(Token = "0x400A2D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Sprite[] m_SpriteArgs;

	[Token(Token = "0x400A2D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private MrkFilterdData[] m_MrkFilteredDatas;

	[Token(Token = "0x17000CFF")]
	public TransitionType transitionType
	{
		[Token(Token = "0x600565D")]
		[Address(RVA = "0x64B770", Offset = "0x64A970", VA = "0x18064B770")]
		get
		{
			return default(TransitionType);
		}
	}

	[Token(Token = "0x17000D00")]
	public bool[] boolArgs
	{
		[Token(Token = "0x600565E")]
		[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D01")]
	public int[] intArgs
	{
		[Token(Token = "0x600565F")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D02")]
	public float[] floatArgs
	{
		[Token(Token = "0x6005660")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D03")]
	public string[] stringArgs
	{
		[Token(Token = "0x6005661")]
		[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D04")]
	public string[] textArgs
	{
		[Token(Token = "0x6005662")]
		[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D05")]
	public Vector3[] vector3Args
	{
		[Token(Token = "0x6005663")]
		[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D06")]
	public Color[] colorArgs
	{
		[Token(Token = "0x6005664")]
		[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D07")]
	public Sprite[] spriteArgs
	{
		[Token(Token = "0x6005665")]
		[Address(RVA = "0x580700", Offset = "0x57F900", VA = "0x180580700")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D08")]
	public MrkFilterdData[] mrkFilteredDatas
	{
		[Token(Token = "0x6005666")]
		[Address(RVA = "0x5EA220", Offset = "0x5E9420", VA = "0x1805EA220")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6005667")]
	[Address(RVA = "0x9B73E0", Offset = "0x9B65E0", VA = "0x1809B73E0")]
	public bool ArgAt(int index, bool defaultValue = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6005668")]
	[Address(RVA = "0x9B7200", Offset = "0x9B6400", VA = "0x1809B7200")]
	public int ArgAt(int index, int defaultValue = 0)
	{
		return default(int);
	}

	[Token(Token = "0x6005669")]
	[Address(RVA = "0x9B7300", Offset = "0x9B6500", VA = "0x1809B7300")]
	public float ArgAt(int index, float defaultValue = 0f)
	{
		return default(float);
	}

	[Token(Token = "0x600566A")]
	[Address(RVA = "0x9B7370", Offset = "0x9B6570", VA = "0x1809B7370")]
	public string ArgAt(int index, [Optional] string defaultValue)
	{
		return null;
	}

	[Token(Token = "0x600566B")]
	[Address(RVA = "0x9B7160", Offset = "0x9B6360", VA = "0x1809B7160")]
	public Vector3 ArgAt(int index, Vector3 defaultValue)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600566C")]
	[Address(RVA = "0x9B7270", Offset = "0x9B6470", VA = "0x1809B7270")]
	public Color ArgAt(int index, Color defaultValue)
	{
		return default(Color);
	}

	[Token(Token = "0x600566D")]
	[Address(RVA = "0x9B7450", Offset = "0x9B6650", VA = "0x1809B7450")]
	public Sprite ArgAt(int index, [Optional] Sprite defaultValue)
	{
		return null;
	}

	[Token(Token = "0x600566E")]
	[Address(RVA = "0x9B70F0", Offset = "0x9B62F0", VA = "0x1809B70F0")]
	public MrkFilterdData ArgAt(int index, [Optional] MrkFilterdData defaultValue)
	{
		return null;
	}

	[Token(Token = "0x600566F")]
	public T ArgAt<T>(T[] args, int index, T defaultValue)
	{
		return (T)null;
	}

	[Token(Token = "0x6005670")]
	[Address(RVA = "0x9B74C0", Offset = "0x9B66C0", VA = "0x1809B74C0")]
	public IDuelPreviewTask CreateTask()
	{
		return null;
	}

	[Token(Token = "0x6005671")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public DuelPreviewTaskRawData()
	{
	}
}
