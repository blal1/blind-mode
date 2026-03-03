using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.Effect;

namespace YgomGame.DuelPreview.Controller;

[Token(Token = "0x2000E9F")]
public class PreviewFieldController : IPreviewPlayerControllerRequireGob, IPreviewPlayerController
{
	[Token(Token = "0x2000EA0")]
	[CompilerGenerated]
	private sealed class _003CLoadField_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A3F9")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A3FA")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400A3FB")]
		[FieldOffset(Offset = "0x20")]
		public string fieldPath;

		[Token(Token = "0x400A3FC")]
		[FieldOffset(Offset = "0x28")]
		public PreviewFieldController _003C_003E4__this;

		[Token(Token = "0x400A3FD")]
		[FieldOffset(Offset = "0x30")]
		private string _003CfieldFullPath_003E5__2;

		[Token(Token = "0x17000D95")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600586B")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D96")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600586D")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005868")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CLoadField_003Ed__25(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6005869")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600586A")]
		[Address(RVA = "0x9FC830", Offset = "0x9FBA30", VA = "0x1809FC830", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600586C")]
		[Address(RVA = "0x9FC930", Offset = "0x9FBB30", VA = "0x1809FC930", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000EA1")]
	[CompilerGenerated]
	private sealed class _003CyInitialize_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A3FE")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A3FF")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400A400")]
		[FieldOffset(Offset = "0x20")]
		public PreviewFieldController _003C_003E4__this;

		[Token(Token = "0x17000D97")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6005871")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D98")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005873")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600586E")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyInitialize_003Ed__19(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600586F")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6005870")]
		[Address(RVA = "0x9FFBB0", Offset = "0x9FEDB0", VA = "0x1809FFBB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005872")]
		[Address(RVA = "0x9FFEF0", Offset = "0x9FF0F0", VA = "0x1809FFEF0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400A3F0")]
	private const string k_BgDefaultSpritePath = "DuelPreview/FieldCapture/DuelPreviewFIeldCapture_Default";

	[Token(Token = "0x400A3F1")]
	private const string k_BgLightResPath = "Duel/BG/Light/GlobalFieldLight";

	[Token(Token = "0x400A3F2")]
	private const string k_BgPathFormat = "Prefabs/Shop/DuelPreview/FieldCapture/{0}";

	[Token(Token = "0x400A3F3")]
	[FieldOffset(Offset = "0x10")]
	private readonly PreviewResourceController m_ResourceController;

	[Token(Token = "0x400A3F4")]
	[FieldOffset(Offset = "0x18")]
	private GameObject m_PlayerRoot;

	[Token(Token = "0x400A3F5")]
	[FieldOffset(Offset = "0x20")]
	private SpriteScaler m_FieldSpriteScaler;

	[Token(Token = "0x400A3F6")]
	[FieldOffset(Offset = "0x28")]
	private SpriteRenderer m_FieldSpriteRenderer;

	[Token(Token = "0x400A3F7")]
	[FieldOffset(Offset = "0x30")]
	private Sprite m_DefaultSprite;

	[Token(Token = "0x400A3F8")]
	[FieldOffset(Offset = "0x38")]
	private GameObject m_BgLightRoot;

	[Token(Token = "0x17000D92")]
	public Sprite defaultSprite
	{
		[Token(Token = "0x6005859")]
		[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D93")]
	public Sprite currentFieldSprite
	{
		[Token(Token = "0x600585A")]
		[Address(RVA = "0x9F7E00", Offset = "0x9F7000", VA = "0x1809F7E00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D94")]
	public ControllerType controllerType
	{
		[Token(Token = "0x600585B")]
		[Address(RVA = "0x452710", Offset = "0x451910", VA = "0x180452710", Slot = "6")]
		get
		{
			return default(ControllerType);
		}
	}

	[Token(Token = "0x600585C")]
	[Address(RVA = "0x9F7A30", Offset = "0x9F6C30", VA = "0x1809F7A30")]
	private static string MakeFieldFullPath(string fieldPath)
	{
		return null;
	}

	[Token(Token = "0x600585D")]
	[Address(RVA = "0x438FD0", Offset = "0x4381D0", VA = "0x180438FD0")]
	public PreviewFieldController(PreviewResourceController resourceController)
	{
	}

	[Token(Token = "0x600585E")]
	[Address(RVA = "0x9F77F0", Offset = "0x9F69F0", VA = "0x1809F77F0", Slot = "4")]
	public void BindGob(params GameObject[] gobs)
	{
	}

	[Token(Token = "0x600585F")]
	[Address(RVA = "0x9F7D50", Offset = "0x9F6F50", VA = "0x1809F7D50", Slot = "5")]
	public void UnbindGob()
	{
	}

	[Token(Token = "0x6005860")]
	[Address(RVA = "0x9F7E20", Offset = "0x9F7020", VA = "0x1809F7E20", Slot = "7")]
	[IteratorStateMachine(typeof(_003CyInitialize_003Ed__19))]
	public IEnumerator yInitialize()
	{
		return null;
	}

	[Token(Token = "0x6005861")]
	[Address(RVA = "0x9F78D0", Offset = "0x9F6AD0", VA = "0x1809F78D0", Slot = "8")]
	public void Terminate()
	{
	}

	[Token(Token = "0x6005862")]
	[Address(RVA = "0x9F7A70", Offset = "0x9F6C70", VA = "0x1809F7A70", Slot = "9")]
	public void Release()
	{
	}

	[Token(Token = "0x6005863")]
	[Address(RVA = "0x9F7780", Offset = "0x9F6980", VA = "0x1809F7780")]
	public void ActivateRender()
	{
	}

	[Token(Token = "0x6005864")]
	[Address(RVA = "0x9F78D0", Offset = "0x9F6AD0", VA = "0x1809F78D0")]
	public void DeactivateRenderer()
	{
	}

	[Token(Token = "0x6005865")]
	[Address(RVA = "0x9F7C80", Offset = "0x9F6E80", VA = "0x1809F7C80")]
	public void Setup(Camera renderCamera)
	{
	}

	[Token(Token = "0x6005866")]
	[Address(RVA = "0x9F79A0", Offset = "0x9F6BA0", VA = "0x1809F79A0")]
	[IteratorStateMachine(typeof(_003CLoadField_003Ed__25))]
	public IEnumerator LoadField(string fieldPath)
	{
		return null;
	}

	[Token(Token = "0x6005867")]
	[Address(RVA = "0x9F7BB0", Offset = "0x9F6DB0", VA = "0x1809F7BB0")]
	public void SetField(string fieldPath)
	{
	}
}
