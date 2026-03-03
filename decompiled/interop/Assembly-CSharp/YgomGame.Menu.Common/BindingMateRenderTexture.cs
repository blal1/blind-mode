using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using YgomGame.Bg;
using YgomSystem.Utility;

namespace YgomGame.Menu.Common;

[Token(Token = "0x2001448")]
[RequireComponent(typeof(RawImage))]
[DisallowMultipleComponent]
public class BindingMateRenderTexture : BindingAsyncBase
{
	[Token(Token = "0x2001449")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass28_0
	{
		[Token(Token = "0x400C623")]
		[FieldOffset(Offset = "0x10")]
		public BindingMateRenderTexture _003C_003E4__this;

		[Token(Token = "0x400C624")]
		[FieldOffset(Offset = "0x18")]
		public bool mateApplyDone;

		[Token(Token = "0x6007E4A")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass28_0()
		{
		}

		[Token(Token = "0x6007E4B")]
		[Address(RVA = "0xC7F3A0", Offset = "0xC7E5A0", VA = "0x180C7F3A0")]
		internal void _003CyBindingRoutine_003Eb__0(int rtId, RenderTexture renderTexture, Texture2D texture)
		{
		}

		[Token(Token = "0x6007E4C")]
		[Address(RVA = "0xC7F450", Offset = "0xC7E650", VA = "0x180C7F450")]
		internal void _003CyBindingRoutine_003Eb__1()
		{
		}
	}

	[Token(Token = "0x200144A")]
	[CompilerGenerated]
	private sealed class _003CyBindingRoutine_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400C625")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400C626")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400C627")]
		[FieldOffset(Offset = "0x20")]
		public BindingMateRenderTexture _003C_003E4__this;

		[Token(Token = "0x400C628")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass28_0 _003C_003E8__1;

		[Token(Token = "0x400C629")]
		[FieldOffset(Offset = "0x30")]
		private Vector3 _003Cpos_003E5__2;

		[Token(Token = "0x400C62A")]
		[FieldOffset(Offset = "0x3C")]
		private Vector3 _003Crot_003E5__3;

		[Token(Token = "0x400C62B")]
		[FieldOffset(Offset = "0x48")]
		private Vector3 _003Cscale_003E5__4;

		[Token(Token = "0x1700136F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6007E50")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001370")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6007E52")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6007E4D")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyBindingRoutine_003Ed__28(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6007E4E")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6007E4F")]
		[Address(RVA = "0xC80F70", Offset = "0xC80170", VA = "0x180C80F70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6007E51")]
		[Address(RVA = "0xC81AE0", Offset = "0xC80CE0", VA = "0x180C81AE0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400C613")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private int m_MateId;

	[Token(Token = "0x400C614")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private Vector3 m_Position;

	[Token(Token = "0x400C615")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[FormerlySerializedAs("m_EulerAngles")]
	private Vector3 m_Rotation;

	[Token(Token = "0x400C616")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	private Vector3 m_Scale;

	[Token(Token = "0x400C617")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[AssetPath(typeof(MateTransformSetting))]
	private string m_MateTransformSettingPath;

	[Token(Token = "0x400C618")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private bool m_UseTransformSetting;

	[Token(Token = "0x400C619")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private GameObject m_Locater;

	[Token(Token = "0x400C61A")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private AvatarMotionSetting.MotionID m_BeginMotion;

	[Token(Token = "0x400C61B")]
	[FieldOffset(Offset = "0x74")]
	[SerializeField]
	private bool m_EnableSe;

	[Token(Token = "0x400C61C")]
	[FieldOffset(Offset = "0x78")]
	private GameObject m_RenderTextureTarget;

	[Token(Token = "0x400C61D")]
	[FieldOffset(Offset = "0x80")]
	private int m_RenderTextureTargetId;

	[Token(Token = "0x400C61E")]
	[FieldOffset(Offset = "0x88")]
	private RenderTexture m_RenderTexture;

	[Token(Token = "0x400C61F")]
	[FieldOffset(Offset = "0x90")]
	private uint m_CharacterPrefCrc;

	[Token(Token = "0x400C620")]
	[FieldOffset(Offset = "0x98")]
	private Character m_Character;

	[Token(Token = "0x400C621")]
	[FieldOffset(Offset = "0xA0")]
	private uint m_SettingCrc;

	[Token(Token = "0x400C622")]
	[FieldOffset(Offset = "0xA8")]
	private RawImage m_RawImage;

	[Token(Token = "0x1700136A")]
	public string mateTransformSettingPath
	{
		[Token(Token = "0x6007E40")]
		[Address(RVA = "0x5EA220", Offset = "0x5E9420", VA = "0x1805EA220")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700136B")]
	public int mateId
	{
		[Token(Token = "0x6007E41")]
		[Address(RVA = "0x49B840", Offset = "0x49AA40", VA = "0x18049B840")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007E42")]
		[Address(RVA = "0xC6C3D0", Offset = "0xC6B5D0", VA = "0x180C6C3D0")]
		set
		{
		}
	}

	[Token(Token = "0x1700136C")]
	public bool validMateId
	{
		[Token(Token = "0x6007E43")]
		[Address(RVA = "0x93FE10", Offset = "0x93F010", VA = "0x18093FE10")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700136D")]
	public Character character
	{
		[Token(Token = "0x6007E44")]
		[Address(RVA = "0x49B870", Offset = "0x49AA70", VA = "0x18049B870")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700136E")]
	public RawImage rawImage
	{
		[Token(Token = "0x6007E45")]
		[Address(RVA = "0xC6C330", Offset = "0xC6B530", VA = "0x180C6C330")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007E46")]
	[Address(RVA = "0xC6C190", Offset = "0xC6B390", VA = "0x180C6C190", Slot = "16")]
	protected override void OnSourceChange()
	{
	}

	[Token(Token = "0x6007E47")]
	[Address(RVA = "0xC6C3E0", Offset = "0xC6B5E0", VA = "0x180C6C3E0", Slot = "17")]
	[IteratorStateMachine(typeof(_003CyBindingRoutine_003Ed__28))]
	protected override IEnumerator yBindingRoutine()
	{
		return null;
	}

	[Token(Token = "0x6007E48")]
	[Address(RVA = "0xC6BFF0", Offset = "0xC6B1F0", VA = "0x180C6BFF0", Slot = "18")]
	protected override void OnReleaseResources()
	{
	}

	[Token(Token = "0x6007E49")]
	[Address(RVA = "0xC6C250", Offset = "0xC6B450", VA = "0x180C6C250")]
	public BindingMateRenderTexture()
	{
	}
}
