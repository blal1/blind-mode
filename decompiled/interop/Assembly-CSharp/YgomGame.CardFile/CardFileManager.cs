using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Utility;

namespace YgomGame.CardFile;

[Token(Token = "0x20015A3")]
public class CardFileManager : MonoBehaviour
{
	[Token(Token = "0x20015A4")]
	[CompilerGenerated]
	private sealed class _003COnLoadedProcess_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400CE2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400CE2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400CE30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CardFileManager _003C_003E4__this;

		[Token(Token = "0x1700149C")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600861A")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700149D")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600861C")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6008617")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003COnLoadedProcess_003Ed__38(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6008618")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6008619")]
		[Address(RVA = "0xCFA590", Offset = "0xCF9790", VA = "0x180CFA590", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600861B")]
		[Address(RVA = "0xCFA610", Offset = "0xCF9810", VA = "0x180CFA610", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400CE23")]
	public const string pathCardFileSetting = "CardFile/ScriptableObject/CardFileSetting";

	[Token(Token = "0x400CE24")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int loadingCount;

	[Token(Token = "0x400CE26")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Action<int> onPageChangedCallback;

	[Token(Token = "0x400CE27")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Action onFinishedCallback;

	[Token(Token = "0x17001494")]
	private bool loaded
	{
		[Token(Token = "0x60085F9")]
		[Address(RVA = "0x5EA820", Offset = "0x5E9A20", VA = "0x1805EA820")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001495")]
	public DefinitionSetting cfSetting
	{
		[Token(Token = "0x60085FB")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60085FA")]
		[Address(RVA = "0x402FB0", Offset = "0x4021B0", VA = "0x180402FB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001496")]
	public CardFileDefinition.OpenType fromOpen
	{
		[Token(Token = "0x60085FD")]
		[Address(RVA = "0x5FA7B0", Offset = "0x5F99B0", VA = "0x1805FA7B0")]
		[CompilerGenerated]
		get
		{
			return default(CardFileDefinition.OpenType);
		}
		[Token(Token = "0x60085FC")]
		[Address(RVA = "0x409CD0", Offset = "0x408ED0", VA = "0x180409CD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001497")]
	public CardFileBase cfBase
	{
		[Token(Token = "0x60085FF")]
		[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60085FE")]
		[Address(RVA = "0x414E90", Offset = "0x414090", VA = "0x180414E90")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x17001498")]
	public CardFilePagerInfo cfp
	{
		[Token(Token = "0x6008601")]
		[Address(RVA = "0x580700", Offset = "0x57F900", VA = "0x180580700")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6008600")]
		[Address(RVA = "0x580760", Offset = "0x57F960", VA = "0x180580760")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x17001499")]
	public CardFileSelector cfs
	{
		[Token(Token = "0x6008602")]
		[Address(RVA = "0x5EA220", Offset = "0x5E9420", VA = "0x1805EA220")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6008603")]
		[Address(RVA = "0x81BD60", Offset = "0x81AF60", VA = "0x18081BD60")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x1700149A")]
	public CardFileController cfc
	{
		[Token(Token = "0x6008604")]
		[Address(RVA = "0x589E50", Offset = "0x589050", VA = "0x180589E50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6008605")]
		[Address(RVA = "0x589E60", Offset = "0x589060", VA = "0x180589E60")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x1700149B")]
	public CardFileInfo cfi
	{
		[Token(Token = "0x6008606")]
		[Address(RVA = "0x49B9F0", Offset = "0x49ABF0", VA = "0x18049B9F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6008607")]
		[Address(RVA = "0x49C1F0", Offset = "0x49B3F0", VA = "0x18049C1F0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x6008608")]
	[Address(RVA = "0x49C1F0", Offset = "0x49B3F0", VA = "0x18049C1F0")]
	public void SetCardFileInfo(CardFileInfo cfi)
	{
	}

	[Token(Token = "0x6008609")]
	[Address(RVA = "0xCED7E0", Offset = "0xCEC9E0", VA = "0x180CED7E0")]
	public static CardFileManager Create(int itemId, CardFileDefinition.OpenType openType)
	{
		return null;
	}

	[Token(Token = "0x600860A")]
	[Address(RVA = "0xCED8D0", Offset = "0xCECAD0", VA = "0x180CED8D0")]
	private void Initialize(int itemId, CardFileDefinition.OpenType openType)
	{
	}

	[Token(Token = "0x600860B")]
	[Address(RVA = "0xCEDD00", Offset = "0xCECF00", VA = "0x180CEDD00")]
	private void PageChange(int page)
	{
	}

	[Token(Token = "0x600860C")]
	[Address(RVA = "0xCEDC90", Offset = "0xCECE90", VA = "0x180CEDC90")]
	[IteratorStateMachine(typeof(_003COnLoadedProcess_003Ed__38))]
	private IEnumerator OnLoadedProcess()
	{
		return null;
	}

	[Token(Token = "0x600860D")]
	[Address(RVA = "0xCEDD80", Offset = "0xCECF80", VA = "0x180CEDD80")]
	public void Terminate()
	{
	}

	[Token(Token = "0x600860E")]
	public static T CreateGameObject<T>(GameObject parent, string name, [Optional] Type[] components) where T : MonoBehaviour
	{
		return null;
	}

	[Token(Token = "0x600860F")]
	[Address(RVA = "0xCED7C0", Offset = "0xCEC9C0", VA = "0x180CED7C0")]
	public static GameObject CreateGameObject(GameObject parent, string name, [Optional] Type[] components)
	{
		return null;
	}

	[Token(Token = "0x6008610")]
	[Address(RVA = "0xCEE180", Offset = "0xCED380", VA = "0x180CEE180")]
	public static void WarningGameObjectExists(string path)
	{
	}

	[Token(Token = "0x6008611")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public CardFileManager()
	{
	}
}
