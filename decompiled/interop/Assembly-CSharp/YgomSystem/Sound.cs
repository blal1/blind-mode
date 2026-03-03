using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using USnd;
using UnityEngine;

namespace YgomSystem;

[Token(Token = "0x2000192")]
public class Sound : MonoBehaviour
{
	[Token(Token = "0x2000193")]
	public enum Master
	{
		[Token(Token = "0x4000975")]
		BGM,
		[Token(Token = "0x4000976")]
		SE,
		[Token(Token = "0x4000977")]
		VOICE
	}

	[Token(Token = "0x2000196")]
	[CompilerGenerated]
	private sealed class _003CCheckLoadXML_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400097F")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000980")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000981")]
		[FieldOffset(Offset = "0x20")]
		public bool categoryAll;

		[Token(Token = "0x4000982")]
		[FieldOffset(Offset = "0x28")]
		public string label;

		[Token(Token = "0x4000983")]
		[FieldOffset(Offset = "0x30")]
		public Sound _003C_003E4__this;

		[Token(Token = "0x4000984")]
		[FieldOffset(Offset = "0x38")]
		public int separateDepth;

		[Token(Token = "0x4000985")]
		[FieldOffset(Offset = "0x40")]
		public Action finishedCallback;

		[Token(Token = "0x1700010A")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000A2E")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700010B")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000A30")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A2B")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CCheckLoadXML_003Ed__34(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000A2C")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000A2D")]
		[Address(RVA = "0xC16E90", Offset = "0xC16090", VA = "0x180C16E90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A2F")]
		[Address(RVA = "0xC17010", Offset = "0xC16210", VA = "0x180C17010", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000197")]
	[CompilerGenerated]
	private sealed class _003CLoadSoundClipAsyncCoroutine_003Ed__44 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000986")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000987")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000988")]
		[FieldOffset(Offset = "0x20")]
		public List<string> targetList;

		[Token(Token = "0x4000989")]
		[FieldOffset(Offset = "0x28")]
		public Sound _003C_003E4__this;

		[Token(Token = "0x400098A")]
		[FieldOffset(Offset = "0x30")]
		public Action finishedCallback;

		[Token(Token = "0x400098B")]
		[FieldOffset(Offset = "0x38")]
		private int _003Ccount_003E5__2;

		[Token(Token = "0x400098C")]
		[FieldOffset(Offset = "0x3C")]
		private int _003Cmax_003E5__3;

		[Token(Token = "0x400098D")]
		[FieldOffset(Offset = "0x40")]
		private List<string>.Enumerator _003C_003E7__wrap3;

		[Token(Token = "0x1700010C")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000A35")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700010D")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000A37")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A31")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CLoadSoundClipAsyncCoroutine_003Ed__44(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000A32")]
		[Address(RVA = "0xC17290", Offset = "0xC16490", VA = "0x180C17290", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000A33")]
		[Address(RVA = "0xC17050", Offset = "0xC16250", VA = "0x180C17050", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A34")]
		[Address(RVA = "0xC17320", Offset = "0xC16520", VA = "0x180C17320")]
		private void _003C_003Em__Finally1()
		{
		}

		[Token(Token = "0x6000A36")]
		[Address(RVA = "0xC17250", Offset = "0xC16450", VA = "0x180C17250", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000198")]
	[CompilerGenerated]
	private sealed class _003CLoadSoundSettingCoroutine_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400098E")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400098F")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000990")]
		[FieldOffset(Offset = "0x20")]
		public Sound _003C_003E4__this;

		[Token(Token = "0x1700010E")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000A3B")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700010F")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000A3D")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A38")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CLoadSoundSettingCoroutine_003Ed__21(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000A39")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000A3A")]
		[Address(RVA = "0xC17370", Offset = "0xC16570", VA = "0x180C17370", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A3C")]
		[Address(RVA = "0xC17820", Offset = "0xC16A20", VA = "0x180C17820", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000199")]
	[CompilerGenerated]
	private sealed class _003CLoadSoundXml_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000991")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000992")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000993")]
		[FieldOffset(Offset = "0x20")]
		public Sound _003C_003E4__this;

		[Token(Token = "0x4000994")]
		[FieldOffset(Offset = "0x28")]
		public string[] NameList;

		[Token(Token = "0x4000995")]
		[FieldOffset(Offset = "0x30")]
		public bool checkExist;

		[Token(Token = "0x4000996")]
		[FieldOffset(Offset = "0x34")]
		private int _003CloadId_003E5__2;

		[Token(Token = "0x4000997")]
		[FieldOffset(Offset = "0x38")]
		private string[] _003C_003E7__wrap2;

		[Token(Token = "0x4000998")]
		[FieldOffset(Offset = "0x40")]
		private int _003C_003E7__wrap3;

		[Token(Token = "0x4000999")]
		[FieldOffset(Offset = "0x48")]
		private string _003CxmlFileName_003E5__5;

		[Token(Token = "0x17000110")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000A41")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000111")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000A43")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A3E")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CLoadSoundXml_003Ed__39(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000A3F")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000A40")]
		[Address(RVA = "0xC17860", Offset = "0xC16A60", VA = "0x180C17860", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A42")]
		[Address(RVA = "0xC17B50", Offset = "0xC16D50", VA = "0x180C17B50", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400096C")]
	[FieldOffset(Offset = "0x0")]
	private static Sound s_instance;

	[Token(Token = "0x400096D")]
	[FieldOffset(Offset = "0x20")]
	private string[] ResourcesXmlList;

	[Token(Token = "0x400096E")]
	[FieldOffset(Offset = "0x28")]
	private string[] AssetBundleXmlList;

	[Token(Token = "0x4000971")]
	[FieldOffset(Offset = "0x38")]
	private string CurrentBGM;

	[Token(Token = "0x4000972")]
	[FieldOffset(Offset = "0x8")]
	private static List<string> BGMList;

	[Token(Token = "0x4000973")]
	[FieldOffset(Offset = "0x40")]
	private List<string> AB_SE_DUEL;

	[Token(Token = "0x17000107")]
	public static Sound Instance
	{
		[Token(Token = "0x60009E3")]
		[Address(RVA = "0xB07C70", Offset = "0xB06E70", VA = "0x180B07C70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000108")]
	public bool IsReady
	{
		[Token(Token = "0x60009E7")]
		[Address(RVA = "0x51FEA0", Offset = "0x51F0A0", VA = "0x18051FEA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60009E8")]
		[Address(RVA = "0x5FDF60", Offset = "0x5FD160", VA = "0x1805FDF60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000109")]
	public bool IsLoadingLabelXml
	{
		[Token(Token = "0x60009E9")]
		[Address(RVA = "0x5F07F0", Offset = "0x5EF9F0", VA = "0x1805F07F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60009EA")]
		[Address(RVA = "0x768DE0", Offset = "0x767FE0", VA = "0x180768DE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x60009E4")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	[Conditional("YGO_DEBUG")]
	private static void SoundDebugPrint(string str)
	{
	}

	[Token(Token = "0x60009E5")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	[Conditional("YGO_DEBUG")]
	private static void SoundDebugPrintWarning(string str)
	{
	}

	[Token(Token = "0x60009E6")]
	[Address(RVA = "0xB07BE0", Offset = "0xB06DE0", VA = "0x180B07BE0")]
	private string getMasterName(Master master)
	{
		return null;
	}

	[Token(Token = "0x60009EB")]
	[Address(RVA = "0xB04A80", Offset = "0xB03C80", VA = "0x180B04A80")]
	private void Awake()
	{
	}

	[Token(Token = "0x60009EC")]
	[Address(RVA = "0xB064F0", Offset = "0xB056F0", VA = "0x180B064F0")]
	private void Start()
	{
	}

	[Token(Token = "0x60009ED")]
	[Address(RVA = "0xB05D90", Offset = "0xB04F90", VA = "0x180B05D90")]
	[IteratorStateMachine(typeof(_003CLoadSoundSettingCoroutine_003Ed__21))]
	private IEnumerator LoadSoundSettingCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60009EE")]
	[Address(RVA = "0xB05D60", Offset = "0xB04F60", VA = "0x180B05D60")]
	public void LoadSoundResourcesXml()
	{
	}

	[Token(Token = "0x60009EF")]
	[Address(RVA = "0xB05930", Offset = "0xB04B30", VA = "0x180B05930")]
	public void LoadSoundAssetBundleXml()
	{
	}

	[Token(Token = "0x60009F0")]
	[Address(RVA = "0xB05EA0", Offset = "0xB050A0", VA = "0x180B05EA0")]
	public void LoadSysSoundDataAsync(Action finishedCallback)
	{
	}

	[Token(Token = "0x60009F1")]
	[Address(RVA = "0xB05840", Offset = "0xB04A40", VA = "0x180B05840")]
	public void LoadDuelSoundXml(string[] NameList, bool checkExist = true)
	{
	}

	[Token(Token = "0x60009F2")]
	[Address(RVA = "0xB057E0", Offset = "0xB049E0", VA = "0x180B057E0")]
	public void LoadDuelSoundDataAsync(Action finishedCallback)
	{
	}

	[Token(Token = "0x60009F3")]
	[Address(RVA = "0xB058D0", Offset = "0xB04AD0", VA = "0x180B058D0")]
	public void LoadMateSoundDataAsync(Action finishedCallback)
	{
	}

	[Token(Token = "0x60009F4")]
	[Address(RVA = "0xB05870", Offset = "0xB04A70", VA = "0x180B05870")]
	public void LoadFieldSoundDataAsync(Action finishedCallback)
	{
	}

	[Token(Token = "0x60009F5")]
	[Address(RVA = "0xB05490", Offset = "0xB04690", VA = "0x180B05490")]
	public bool IsVoice(string label, bool verifyStr = false)
	{
		return default(bool);
	}

	[Token(Token = "0x60009F6")]
	[Address(RVA = "0xB04B00", Offset = "0xB03D00", VA = "0x180B04B00")]
	public bool CanRemoveVoice()
	{
		return default(bool);
	}

	[Token(Token = "0x60009F7")]
	[Address(RVA = "0xB05F00", Offset = "0xB05100", VA = "0x180B05F00")]
	public void LoadVoiceDataAsync(string label, Action finishedCallback, bool categoryAll = false)
	{
	}

	[Token(Token = "0x60009F8")]
	[Address(RVA = "0xB05FE0", Offset = "0xB051E0", VA = "0x180B05FE0")]
	public void LoadVoiceSoundData(Action finishedCallback)
	{
	}

	[Token(Token = "0x60009F9")]
	[Address(RVA = "0xB06E00", Offset = "0xB06000", VA = "0x180B06E00")]
	public void UnloadVoiceSoundData(bool removeLabel = false)
	{
	}

	[Token(Token = "0x60009FA")]
	[Address(RVA = "0xB04BE0", Offset = "0xB03DE0", VA = "0x180B04BE0")]
	[IteratorStateMachine(typeof(_003CCheckLoadXML_003Ed__34))]
	private IEnumerator CheckLoadXML(string label, int separateDepth, Action finishedCallback, bool categoryAll = false)
	{
		return null;
	}

	[Token(Token = "0x60009FB")]
	[Address(RVA = "0xB05040", Offset = "0xB04240", VA = "0x180B05040")]
	private string GetXmlNameByLabel(string label, int separateDepth)
	{
		return null;
	}

	[Token(Token = "0x60009FC")]
	[Address(RVA = "0xB04D30", Offset = "0xB03F30", VA = "0x180B04D30")]
	private string GetAudioClipFilePath(AudioManager.AudioLabelSettings als)
	{
		return null;
	}

	[Token(Token = "0x60009FD")]
	[Address(RVA = "0xB06BF0", Offset = "0xB05DF0", VA = "0x180B06BF0")]
	public void UnloadDuelSoundData()
	{
	}

	[Token(Token = "0x60009FE")]
	[Address(RVA = "0xB06850", Offset = "0xB05A50", VA = "0x180B06850")]
	public void UnloadAllSoundData()
	{
	}

	[Token(Token = "0x60009FF")]
	[Address(RVA = "0xB05E00", Offset = "0xB05000", VA = "0x180B05E00")]
	[IteratorStateMachine(typeof(_003CLoadSoundXml_003Ed__39))]
	private IEnumerator LoadSoundXml(string[] NameList, bool checkExist = true)
	{
		return null;
	}

	[Token(Token = "0x6000A00")]
	[Address(RVA = "0xB05560", Offset = "0xB04760", VA = "0x180B05560")]
	public void LoadCategorySoundDataAsync(string categoryName, Action finishedCallback, bool updateRndSrc = true)
	{
	}

	[Token(Token = "0x6000A01")]
	[Address(RVA = "0xB06B10", Offset = "0xB05D10", VA = "0x180B06B10")]
	public void UnloadCategorySoundData(string categoryName, bool removeLabel = false)
	{
	}

	[Token(Token = "0x6000A02")]
	[Address(RVA = "0xB05BA0", Offset = "0xB04DA0", VA = "0x180B05BA0")]
	public void LoadSoundClip(string Label)
	{
	}

	[Token(Token = "0x6000A03")]
	[Address(RVA = "0xB05960", Offset = "0xB04B60", VA = "0x180B05960")]
	[IteratorStateMachine(typeof(_003CLoadSoundClipAsyncCoroutine_003Ed__44))]
	public IEnumerator LoadSoundClipAsyncCoroutine(List<string> targetList, Action finishedCallback)
	{
		return null;
	}

	[Token(Token = "0x6000A04")]
	[Address(RVA = "0xB05A10", Offset = "0xB04C10", VA = "0x180B05A10")]
	private bool LoadSoundClipAsync(string Label, Action finishedCallback)
	{
		return default(bool);
	}

	[Token(Token = "0x6000A05")]
	[Address(RVA = "0xB06CC0", Offset = "0xB05EC0", VA = "0x180B06CC0")]
	private bool UnloadSoundClip(string Label)
	{
		return default(bool);
	}

	[Token(Token = "0x6000A06")]
	[Address(RVA = "0xB050D0", Offset = "0xB042D0", VA = "0x180B050D0")]
	private bool IsCategoryMember(string label, string category)
	{
		return default(bool);
	}

	[Token(Token = "0x6000A07")]
	[Address(RVA = "0xB05100", Offset = "0xB04300", VA = "0x180B05100")]
	public bool IsLoadingXml()
	{
		return default(bool);
	}

	[Token(Token = "0x6000A08")]
	[Address(RVA = "0xB050B0", Offset = "0xB042B0", VA = "0x180B050B0")]
	private bool IsAudioManagerLoadingLabel()
	{
		return default(bool);
	}

	[Token(Token = "0x6000A09")]
	[Address(RVA = "0xB04CB0", Offset = "0xB03EB0", VA = "0x180B04CB0")]
	public void ClearObject()
	{
	}

	[Token(Token = "0x6000A0A")]
	[Address(RVA = "0xB06390", Offset = "0xB05590", VA = "0x180B06390")]
	public int Play(string label)
	{
		return default(int);
	}

	[Token(Token = "0x6000A0B")]
	[Address(RVA = "0xB06180", Offset = "0xB05380", VA = "0x180B06180")]
	private int PlayImpl(string label, float delay = -1f)
	{
		return default(int);
	}

	[Token(Token = "0x6000A0C")]
	[Address(RVA = "0xB06080", Offset = "0xB05280", VA = "0x180B06080")]
	public int Play3D(string label, Vector3 position)
	{
		return default(int);
	}

	[Token(Token = "0x6000A0D")]
	[Address(RVA = "0xB06040", Offset = "0xB05240", VA = "0x180B06040")]
	public int Play3D(string label, GameObject traceTarget)
	{
		return default(int);
	}

	[Token(Token = "0x6000A0E")]
	[Address(RVA = "0xB061C0", Offset = "0xB053C0", VA = "0x180B061C0")]
	public int PlayOption(string label, float volume = -1f, float fadeTime = -1f, float pan = -1f, int pitch = -1, float delay = -1f)
	{
		return default(int);
	}

	[Token(Token = "0x6000A0F")]
	[Address(RVA = "0xB064E0", Offset = "0xB056E0", VA = "0x180B064E0")]
	public void SetPan(int instanceID, float newPan, float moveTime = 0f)
	{
	}

	[Token(Token = "0x6000A10")]
	[Address(RVA = "0xB06830", Offset = "0xB05A30", VA = "0x180B06830")]
	public void Stop(int instanceId, float fade = -1f)
	{
	}

	[Token(Token = "0x6000A11")]
	[Address(RVA = "0xB06840", Offset = "0xB05A40", VA = "0x180B06840")]
	public void Stop(string label, float fade = -1f)
	{
	}

	[Token(Token = "0x6000A12")]
	[Address(RVA = "0xB066D0", Offset = "0xB058D0", VA = "0x180B066D0")]
	public void StopLoopInCategory(string categoryName, float fade = -1f)
	{
	}

	[Token(Token = "0x6000A13")]
	[Address(RVA = "0xB065F0", Offset = "0xB057F0", VA = "0x180B065F0")]
	public void StopAll()
	{
	}

	[Token(Token = "0x6000A14")]
	[Address(RVA = "0xB06480", Offset = "0xB05680", VA = "0x180B06480")]
	public void SetMasterVolume(Master masterName, float volume, float moveTime = -1f)
	{
	}

	[Token(Token = "0x6000A15")]
	[Address(RVA = "0xB04F00", Offset = "0xB04100", VA = "0x180B04F00")]
	public float GetMasterVolume(Master masterName)
	{
		return default(float);
	}

	[Token(Token = "0x6000A16")]
	[Address(RVA = "0xB060D0", Offset = "0xB052D0", VA = "0x180B060D0")]
	public int PlayBGM(string label, float delay = -1f)
	{
		return default(int);
	}

	[Token(Token = "0x6000A17")]
	[Address(RVA = "0xB06960", Offset = "0xB05B60", VA = "0x180B06960")]
	public static void UnloadBGM()
	{
	}

	[Token(Token = "0x6000A18")]
	[Address(RVA = "0xB05200", Offset = "0xB04400", VA = "0x180B05200")]
	public bool IsPlayingBGM()
	{
		return default(bool);
	}

	[Token(Token = "0x6000A19")]
	[Address(RVA = "0xB05190", Offset = "0xB04390", VA = "0x180B05190")]
	public bool IsPlayingBGM(string label)
	{
		return default(bool);
	}

	[Token(Token = "0x6000A1A")]
	[Address(RVA = "0xB05130", Offset = "0xB04330", VA = "0x180B05130")]
	public bool IsLoopSe(string label)
	{
		return default(bool);
	}

	[Token(Token = "0x6000A1B")]
	[Address(RVA = "0xB053F0", Offset = "0xB045F0", VA = "0x180B053F0")]
	public bool IsSe(string label)
	{
		return default(bool);
	}

	[Token(Token = "0x6000A1C")]
	[Address(RVA = "0xB052E0", Offset = "0xB044E0", VA = "0x180B052E0")]
	public bool IsPlayingLoopSe(string label)
	{
		return default(bool);
	}

	[Token(Token = "0x6000A1D")]
	[Address(RVA = "0xB05340", Offset = "0xB04540", VA = "0x180B05340")]
	public bool IsPlayingSe(string label)
	{
		return default(bool);
	}

	[Token(Token = "0x6000A1E")]
	[Address(RVA = "0xB05370", Offset = "0xB04570", VA = "0x180B05370")]
	public bool IsPlayingVOICE(string label)
	{
		return default(bool);
	}

	[Token(Token = "0x6000A1F")]
	[Address(RVA = "0xB052D0", Offset = "0xB044D0", VA = "0x180B052D0")]
	public bool IsPlayingLabel(string label)
	{
		return default(bool);
	}

	[Token(Token = "0x6000A20")]
	[Address(RVA = "0xB04F50", Offset = "0xB04150", VA = "0x180B04F50")]
	public string GetPlayingBgmLabel()
	{
		return null;
	}

	[Token(Token = "0x6000A21")]
	[Address(RVA = "0xB04CC0", Offset = "0xB03EC0", VA = "0x180B04CC0")]
	public void ForceStopBGMAll()
	{
	}

	[Token(Token = "0x6000A22")]
	[Address(RVA = "0xB06660", Offset = "0xB05860", VA = "0x180B06660")]
	public void StopBGM(float fade = -1f)
	{
	}

	[Token(Token = "0x6000A23")]
	[Address(RVA = "0xB067E0", Offset = "0xB059E0", VA = "0x180B067E0")]
	public void StopVOICE(float fade = -1f)
	{
	}

	[Token(Token = "0x6000A24")]
	[Address(RVA = "0xB06EE0", Offset = "0xB060E0", VA = "0x180B06EE0")]
	public Sound()
	{
	}
}
