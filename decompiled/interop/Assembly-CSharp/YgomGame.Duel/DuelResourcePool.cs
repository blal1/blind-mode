using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.Utility;

namespace YgomGame.Duel;

[Token(Token = "0x2001A31")]
public class DuelResourcePool : MonoBehaviour
{
	[Token(Token = "0x2001A33")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass35_0
	{
		[Token(Token = "0x400F1FE")]
		[FieldOffset(Offset = "0x10")]
		public FontRasterizer fontRasterizer;

		[Token(Token = "0x400F1FF")]
		[FieldOffset(Offset = "0x18")]
		public bool isErrFontRasterizer;

		[Token(Token = "0x400F200")]
		[FieldOffset(Offset = "0x1C")]
		public Color outlineCol;

		[Token(Token = "0x400F201")]
		[FieldOffset(Offset = "0x30")]
		public Texture2D rasterizedTex;

		[Token(Token = "0x400F202")]
		[FieldOffset(Offset = "0x38")]
		public bool isErrRasterizedTex;

		[Token(Token = "0x600A9C3")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass35_0()
		{
		}

		[Token(Token = "0x600A9C4")]
		[Address(RVA = "0xF755B0", Offset = "0xF747B0", VA = "0x180F755B0")]
		internal void _003CGetFreeTextTurnChangeTexImpl_003Eb__0(string resPath)
		{
		}

		[Token(Token = "0x600A9C5")]
		[Address(RVA = "0xF756A0", Offset = "0xF748A0", VA = "0x180F756A0")]
		internal void _003CGetFreeTextTurnChangeTexImpl_003Eb__1(Text textComponent)
		{
		}

		[Token(Token = "0x600A9C6")]
		[Address(RVA = "0xF758A0", Offset = "0xF74AA0", VA = "0x180F758A0")]
		internal void _003CGetFreeTextTurnChangeTexImpl_003Eb__2(RenderTexture rt, Texture2D tex)
		{
		}
	}

	[Token(Token = "0x2001A34")]
	[CompilerGenerated]
	private sealed class _003CGetFreeTextTurnChangeTexImpl_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400F203")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400F204")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400F205")]
		[FieldOffset(Offset = "0x20")]
		public int player;

		[Token(Token = "0x400F206")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass35_0 _003C_003E8__1;

		[Token(Token = "0x400F207")]
		[FieldOffset(Offset = "0x30")]
		public Action<Texture2D> onFinished;

		[Token(Token = "0x400F208")]
		[FieldOffset(Offset = "0x38")]
		private int _003Cw_003E5__2;

		[Token(Token = "0x400F209")]
		[FieldOffset(Offset = "0x3C")]
		private int _003Ch_003E5__3;

		[Token(Token = "0x400F20A")]
		[FieldOffset(Offset = "0x40")]
		private string _003Ctext_003E5__4;

		[Token(Token = "0x17001A37")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600A9CA")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001A38")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600A9CC")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600A9C7")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CGetFreeTextTurnChangeTexImpl_003Ed__35(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600A9C8")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600A9C9")]
		[Address(RVA = "0xF732F0", Offset = "0xF724F0", VA = "0x180F732F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600A9CB")]
		[Address(RVA = "0xF73730", Offset = "0xF72930", VA = "0x180F73730", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400F1F5")]
	private const string shuffleDeckModelPath = "Duel/Models/DeckModelWrapper";

	[Token(Token = "0x400F1F6")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<int, Texture2D> freeTextTurnChangeTexs;

	[Token(Token = "0x17001A30")]
	public SpriteContainer duelIcon
	{
		[Token(Token = "0x600A9A8")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600A9A9")]
		[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001A31")]
	public SpriteContainer counterIcon
	{
		[Token(Token = "0x600A9AA")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600A9AB")]
		[Address(RVA = "0x402FB0", Offset = "0x4021B0", VA = "0x180402FB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001A32")]
	public bool isInitialized
	{
		[Token(Token = "0x600A9AE")]
		[Address(RVA = "0xF65030", Offset = "0xF64230", VA = "0x180F65030")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001A33")]
	public bool isTerminated
	{
		[Token(Token = "0x600A9B0")]
		[Address(RVA = "0x406E70", Offset = "0x406070", VA = "0x180406E70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600A9B1")]
		[Address(RVA = "0x406E80", Offset = "0x406080", VA = "0x180406E80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001A34")]
	public DuelGameObjectManager goManager
	{
		[Token(Token = "0x600A9B2")]
		[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600A9B3")]
		[Address(RVA = "0x595530", Offset = "0x594730", VA = "0x180595530")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001A35")]
	public Dictionary<Engine.AffectType, Texture2D> affectIcons
	{
		[Token(Token = "0x600A9B6")]
		[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600A9B7")]
		[Address(RVA = "0x414E90", Offset = "0x414090", VA = "0x180414E90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001A36")]
	public GameObject shuffleDeckModel
	{
		[Token(Token = "0x600A9B8")]
		[Address(RVA = "0x580700", Offset = "0x57F900", VA = "0x180580700")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600A9B9")]
		[Address(RVA = "0x580760", Offset = "0x57F960", VA = "0x180580760")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x600A9AC")]
	[Address(RVA = "0xF64680", Offset = "0xF63880", VA = "0x180F64680")]
	public static DuelResourcePool Create(DuelGameObjectManager goManager, GameObject root, string name)
	{
		return null;
	}

	[Token(Token = "0x600A9AD")]
	[Address(RVA = "0xF649D0", Offset = "0xF63BD0", VA = "0x180F649D0")]
	private void Initialize()
	{
	}

	[Token(Token = "0x600A9AF")]
	[Address(RVA = "0xF64E20", Offset = "0xF64020", VA = "0x180F64E20")]
	public void Terminate()
	{
	}

	[Token(Token = "0x600A9B4")]
	[Address(RVA = "0xF64CA0", Offset = "0xF63EA0", VA = "0x180F64CA0")]
	private void LoadDuelIconContainer()
	{
	}

	[Token(Token = "0x600A9B5")]
	[Address(RVA = "0xF64BE0", Offset = "0xF63DE0", VA = "0x180F64BE0")]
	private void LoadCounterIconContainer()
	{
	}

	[Token(Token = "0x600A9BA")]
	[Address(RVA = "0xF64D60", Offset = "0xF63F60", VA = "0x180F64D60")]
	private void LoadShuffleDeckModel()
	{
	}

	[Token(Token = "0x600A9BB")]
	[Address(RVA = "0xF647F0", Offset = "0xF639F0", VA = "0x180F647F0")]
	public void GetFreeTextTurnChangeTex(int player, Action<Texture2D> onFinished)
	{
	}

	[Token(Token = "0x600A9BC")]
	[Address(RVA = "0xF64770", Offset = "0xF63970", VA = "0x180F64770")]
	[IteratorStateMachine(typeof(_003CGetFreeTextTurnChangeTexImpl_003Ed__35))]
	private IEnumerator GetFreeTextTurnChangeTexImpl(int player, Action<Texture2D> onFinished)
	{
		return null;
	}

	[Token(Token = "0x600A9BD")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public DuelResourcePool()
	{
	}
}
