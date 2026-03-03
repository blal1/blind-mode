using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Bg;

namespace YgomGame.Duel;

[Token(Token = "0x200193C")]
public class Character2D : MonoBehaviour
{
	[Token(Token = "0x2001941")]
	[CompilerGenerated]
	private sealed class _003COnFinishCoroutine_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400EB6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400EB6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400EB6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int id;

		[Token(Token = "0x400EB6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Character.SubAvatarChange condition;

		[Token(Token = "0x400EB6E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Character2D _003C_003E4__this;

		[Token(Token = "0x400EB6F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action onFinish;

		[Token(Token = "0x170018EE")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600A2C3")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170018EF")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600A2C5")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600A2C0")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003COnFinishCoroutine_003Ed__21(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600A2C1")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600A2C2")]
		[Address(RVA = "0xEFD6D0", Offset = "0xEFC8D0", VA = "0x180EFD6D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600A2C4")]
		[Address(RVA = "0xEFD810", Offset = "0xEFCA10", VA = "0x180EFD810", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400EB40")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	public RawImage rawImg;

	[Token(Token = "0x400EB41")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly string Character2DPrefabPath;

	[Token(Token = "0x400EB42")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool isInitialized;

	[Token(Token = "0x400EB43")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	private bool IsDestroyed;

	[Token(Token = "0x400EB44")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Character chara;

	[Token(Token = "0x400EB45")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int renderTextureId;

	[Token(Token = "0x400EB46")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private bool autoCameraOnOff;

	[Token(Token = "0x400EB47")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Coroutine soundCheckCroutine;

	[Token(Token = "0x400EB48")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static GameObject mateCreateLocatorCache;

	[Token(Token = "0x170018EA")]
	public bool IsInitialized
	{
		[Token(Token = "0x600A2A2")]
		[Address(RVA = "0x588F60", Offset = "0x588160", VA = "0x180588F60")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170018EB")]
	public Character character
	{
		[Token(Token = "0x600A2A3")]
		[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170018EC")]
	public Animator animator
	{
		[Token(Token = "0x600A2A4")]
		[Address(RVA = "0xEED170", Offset = "0xEEC370", VA = "0x180EED170")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170018ED")]
	private static GameObject mateCreateLocator
	{
		[Token(Token = "0x600A2A5")]
		[Address(RVA = "0xEED1D0", Offset = "0xEEC3D0", VA = "0x180EED1D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600A2A6")]
	[Address(RVA = "0xEEC6F0", Offset = "0xEEB8F0", VA = "0x180EEC6F0")]
	private static void Create(Transform parent, [Optional] Action<Character2D> onFinish)
	{
	}

	[Token(Token = "0x600A2A7")]
	[Address(RVA = "0xEEC830", Offset = "0xEEBA30", VA = "0x180EEC830")]
	public static void Create(int avatarId, Transform parent, Vector3 modelPos, Vector3 modelRot, Vector3 modelScale, Vector3 camPos, Vector3 camRot, int renderTexW = 256, int renderTexH = 256, [Optional] Action<Character2D> onFinish, bool enblePostEffect = false, float imgW = -1f, float imgH = -1f, Character.SubAvatarChange condition = Character.SubAvatarChange.OutgameOnly)
	{
	}

	[Token(Token = "0x600A2A8")]
	[Address(RVA = "0xEEC4F0", Offset = "0xEEB6F0", VA = "0x180EEC4F0")]
	public static void Create(int avatarId, Transform parent, Vector3 modelPos, Vector3 modelRot, Vector3 modelScale, int renderTexW = 256, int renderTexH = 256, [Optional] Action<Character2D> onFinish, bool enblePostEffect = false, float imgW = -1f, float imgH = -1f)
	{
	}

	[Token(Token = "0x600A2A9")]
	[Address(RVA = "0xEECB70", Offset = "0xEEBD70", VA = "0x180EECB70")]
	private void Initialize(int avatarId, Vector3 modelPos, Vector3 modelRot, Vector3 modelScale, Vector3 camPos, Vector3 camRot, int renderTexW = 256, int renderTexH = 256, [Optional] Action onFinish, bool enblePostEffect = false, float imgW = -1f, float imgH = -1f, Character.SubAvatarChange condition = Character.SubAvatarChange.OutgameOnly)
	{
	}

	[Token(Token = "0x600A2AA")]
	[Address(RVA = "0xEECFC0", Offset = "0xEEC1C0", VA = "0x180EECFC0")]
	[IteratorStateMachine(typeof(_003COnFinishCoroutine_003Ed__21))]
	private IEnumerator OnFinishCoroutine(int id, [Optional] Action onFinish, Character.SubAvatarChange condition = Character.SubAvatarChange.OutgameOnly)
	{
		return null;
	}

	[Token(Token = "0x600A2AB")]
	[Address(RVA = "0xEECB20", Offset = "0xEEBD20", VA = "0x180EECB20")]
	public GameObject GetModelInstance()
	{
		return null;
	}

	[Token(Token = "0x600A2AC")]
	[Address(RVA = "0xEED070", Offset = "0xEEC270", VA = "0x180EED070")]
	public void PlayMotion(AvatarMotionSetting.MotionID motion)
	{
	}

	[Token(Token = "0x600A2AD")]
	[Address(RVA = "0xEECB40", Offset = "0xEEBD40", VA = "0x180EECB40")]
	public bool HasMotion(AvatarMotionSetting.MotionID motion)
	{
		return default(bool);
	}

	[Token(Token = "0x600A2AE")]
	[Address(RVA = "0xEED0C0", Offset = "0xEEC2C0", VA = "0x180EED0C0")]
	public void StopMotionSe(float fade = -1f)
	{
	}

	[Token(Token = "0x600A2AF")]
	[Address(RVA = "0xEED0A0", Offset = "0xEEC2A0", VA = "0x180EED0A0")]
	public void SetEnableSe(bool flg)
	{
	}

	[Token(Token = "0x600A2B0")]
	[Address(RVA = "0xEECDB0", Offset = "0xEEBFB0", VA = "0x180EECDB0")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x600A2B1")]
	[Address(RVA = "0xEECEA0", Offset = "0xEEC0A0", VA = "0x180EECEA0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600A2B2")]
	[Address(RVA = "0xEECF30", Offset = "0xEEC130", VA = "0x180EECF30")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600A2B3")]
	[Address(RVA = "0x994190", Offset = "0x993390", VA = "0x180994190")]
	public void SetAutoCameraOnOff(bool flg)
	{
	}

	[Token(Token = "0x600A2B4")]
	[Address(RVA = "0xEED150", Offset = "0xEEC350", VA = "0x180EED150")]
	public Character2D()
	{
	}
}
