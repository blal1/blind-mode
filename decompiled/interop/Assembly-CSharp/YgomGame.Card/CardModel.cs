using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Duel;

namespace YgomGame.Card;

[Token(Token = "0x2001615")]
public class CardModel : MonoBehaviour
{
	[Token(Token = "0x2001618")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass61_0
	{
		[Token(Token = "0x400D495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool loadedFront;

		[Token(Token = "0x400D496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool loadedBack;

		[Token(Token = "0x6008977")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass61_0()
		{
		}

		[Token(Token = "0x6008978")]
		[Address(RVA = "0x465890", Offset = "0x464A90", VA = "0x180465890")]
		internal void _003CLoadTexturesProcess_003Eb__0(CardModel self)
		{
		}

		[Token(Token = "0x6008979")]
		[Address(RVA = "0x4658A0", Offset = "0x464AA0", VA = "0x1804658A0")]
		internal void _003CLoadTexturesProcess_003Eb__1()
		{
		}
	}

	[Token(Token = "0x2001619")]
	[CompilerGenerated]
	private sealed class _003CLoadTexturesProcess_003Ed__61 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400D497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400D498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400D499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CardModel _003C_003E4__this;

		[Token(Token = "0x400D49A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int cardId;

		[Token(Token = "0x400D49B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int styleID;

		[Token(Token = "0x400D49C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int sleeveId;

		[Token(Token = "0x400D49D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private _003C_003Ec__DisplayClass61_0 _003C_003E8__1;

		[Token(Token = "0x400D49E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Action<CardModel> onFinished;

		[Token(Token = "0x17001510")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600897D")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001511")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600897F")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600897A")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CLoadTexturesProcess_003Ed__61(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600897B")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600897C")]
		[Address(RVA = "0xD5ABF0", Offset = "0xD59DF0", VA = "0x180D5ABF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600897E")]
		[Address(RVA = "0xD5AE00", Offset = "0xD5A000", VA = "0x180D5AE00", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400D481")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static UnityEngine.Object m_modelSrc;

	[Token(Token = "0x400D483")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private int styleId;

	[Token(Token = "0x400D484")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int sleeveId;

	[Token(Token = "0x400D485")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Quaternion rotationBase;

	[Token(Token = "0x400D487")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static readonly string cardModelResPath;

	[Token(Token = "0x400D488")]
	public const float thickness = 0.05f;

	[Token(Token = "0x400D489")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static readonly Vector3 size;

	[Token(Token = "0x17001503")]
	public int cardId
	{
		[Token(Token = "0x600894A")]
		[Address(RVA = "0x4BDC30", Offset = "0x4BCE30", VA = "0x1804BDC30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600894B")]
		[Address(RVA = "0x51E0C0", Offset = "0x51D2C0", VA = "0x18051E0C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001504")]
	public CardRoot.ModelType modelType
	{
		[Token(Token = "0x600894C")]
		[Address(RVA = "0x6333B0", Offset = "0x6325B0", VA = "0x1806333B0")]
		[CompilerGenerated]
		get
		{
			return default(CardRoot.ModelType);
		}
		[Token(Token = "0x600894D")]
		[Address(RVA = "0x7EB190", Offset = "0x7EA390", VA = "0x1807EB190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001505")]
	private static UnityEngine.Object modelSrc
	{
		[Token(Token = "0x6008951")]
		[Address(RVA = "0xD4C190", Offset = "0xD4B390", VA = "0x180D4C190")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001506")]
	public bool isTerminated
	{
		[Token(Token = "0x6008953")]
		[Address(RVA = "0x51FEA0", Offset = "0x51F0A0", VA = "0x18051FEA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6008954")]
		[Address(RVA = "0x5FDF60", Offset = "0x5FD160", VA = "0x1805FDF60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001507")]
	public bool loadingFront
	{
		[Token(Token = "0x6008958")]
		[Address(RVA = "0x5F07F0", Offset = "0x5EF9F0", VA = "0x1805F07F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6008959")]
		[Address(RVA = "0x768DE0", Offset = "0x767FE0", VA = "0x180768DE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001508")]
	public bool loadingBack
	{
		[Token(Token = "0x600895A")]
		[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001509")]
	public GameObject frontModel
	{
		[Token(Token = "0x600895B")]
		[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600895C")]
		[Address(RVA = "0x595520", Offset = "0x594720", VA = "0x180595520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700150A")]
	public GameObject backModel
	{
		[Token(Token = "0x600895D")]
		[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600895E")]
		[Address(RVA = "0x595530", Offset = "0x594730", VA = "0x180595530")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700150B")]
	public GameObject sideModel
	{
		[Token(Token = "0x600895F")]
		[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6008960")]
		[Address(RVA = "0x414E90", Offset = "0x414090", VA = "0x180414E90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700150C")]
	public MeshRenderer frontRenderer
	{
		[Token(Token = "0x6008961")]
		[Address(RVA = "0x580700", Offset = "0x57F900", VA = "0x180580700")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6008962")]
		[Address(RVA = "0x580760", Offset = "0x57F960", VA = "0x180580760")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700150D")]
	public MeshRenderer backRenderer
	{
		[Token(Token = "0x6008963")]
		[Address(RVA = "0x5EA220", Offset = "0x5E9420", VA = "0x1805EA220")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6008964")]
		[Address(RVA = "0x81BD60", Offset = "0x81AF60", VA = "0x18081BD60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700150E")]
	public MeshRenderer sideRenderer
	{
		[Token(Token = "0x6008965")]
		[Address(RVA = "0x589E50", Offset = "0x589050", VA = "0x180589E50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6008966")]
		[Address(RVA = "0x589E60", Offset = "0x589060", VA = "0x180589E60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700150F")]
	public Quaternion currentRotation
	{
		[Token(Token = "0x600896D")]
		[Address(RVA = "0xD4BF60", Offset = "0xD4B160", VA = "0x180D4BF60")]
		get
		{
			return default(Quaternion);
		}
	}

	[Token(Token = "0x600894E")]
	[Address(RVA = "0xD4A8F0", Offset = "0xD49AF0", VA = "0x180D4A8F0")]
	public static (CardModel, GameObject) CreateAsync(Transform parent, int cardId, int sleeveId, int rareId, [Optional] Action<CardModel> onFinished)
	{
		return default((CardModel, GameObject));
	}

	[Token(Token = "0x600894F")]
	[Address(RVA = "0xD4BC60", Offset = "0xD4AE60", VA = "0x180D4BC60")]
	public void StartLoadTexture(int cardId, int sleeveId, int styleID, [Optional] Action<CardModel> onFinished)
	{
	}

	[Token(Token = "0x6008950")]
	[Address(RVA = "0xD4A830", Offset = "0xD49A30", VA = "0x180D4A830")]
	public static CardModel AddComponent(GameObject go)
	{
		return null;
	}

	[Token(Token = "0x6008952")]
	[Address(RVA = "0xD4BDE0", Offset = "0xD4AFE0", VA = "0x180D4BDE0")]
	public void Terminate()
	{
	}

	[Token(Token = "0x6008955")]
	[Address(RVA = "0xD4B3D0", Offset = "0xD4A5D0", VA = "0x180D4B3D0")]
	public void SetCardTexAsync(int cardId, int styleID, [Optional] Action<CardModel> onLoaded)
	{
	}

	[Token(Token = "0x6008956")]
	[Address(RVA = "0xD4B5C0", Offset = "0xD4A7C0", VA = "0x180D4B5C0")]
	public void SetCardTexAsync(MeshRenderer target, int cardId, int rareId, [Optional] Action<CardModel> onLoaded, bool force = false)
	{
	}

	[Token(Token = "0x6008957")]
	[Address(RVA = "0xD4A8E0", Offset = "0xD49AE0", VA = "0x180D4A8E0")]
	public void CrearContents()
	{
	}

	[Token(Token = "0x6008967")]
	[Address(RVA = "0xD4BC10", Offset = "0xD4AE10", VA = "0x180D4BC10")]
	public void Show()
	{
	}

	[Token(Token = "0x6008968")]
	[Address(RVA = "0xD4AE00", Offset = "0xD4A000", VA = "0x180D4AE00")]
	public void Hide()
	{
	}

	[Token(Token = "0x6008969")]
	[Address(RVA = "0xD4AE50", Offset = "0xD4A050", VA = "0x180D4AE50")]
	public void Initialize()
	{
	}

	[Token(Token = "0x600896A")]
	[Address(RVA = "0xD4AFF0", Offset = "0xD4A1F0", VA = "0x180D4AFF0")]
	[IteratorStateMachine(typeof(_003CLoadTexturesProcess_003Ed__61))]
	private IEnumerator LoadTexturesProcess(int cardId, int sleeveId, int styleID, Action<CardModel> onFinished)
	{
		return null;
	}

	[Token(Token = "0x600896B")]
	[Address(RVA = "0xD4B140", Offset = "0xD4A340", VA = "0x180D4B140")]
	public void SetBackInsight(bool insight)
	{
	}

	[Token(Token = "0x600896C")]
	[Address(RVA = "0xD4BA40", Offset = "0xD4AC40", VA = "0x180D4BA40")]
	public void SetRotation(Quaternion rotation)
	{
	}

	[Token(Token = "0x600896E")]
	[Address(RVA = "0xD4B760", Offset = "0xD4A960", VA = "0x180D4B760")]
	public void SetFrontColor(Color color)
	{
	}

	[Token(Token = "0x600896F")]
	[Address(RVA = "0xD4B0A0", Offset = "0xD4A2A0", VA = "0x180D4B0A0")]
	public void SetBackColor(Color color)
	{
	}

	[Token(Token = "0x6008970")]
	[Address(RVA = "0xD4B800", Offset = "0xD4AA00", VA = "0x180D4B800")]
	public void SetModelType(CardRoot.ModelType modelType)
	{
	}

	[Token(Token = "0x6008971")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public CardModel()
	{
	}
}
