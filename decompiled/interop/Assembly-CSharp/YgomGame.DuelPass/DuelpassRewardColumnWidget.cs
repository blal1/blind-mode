using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using YgomSystem.UI;

namespace YgomGame.Duelpass;

[Token(Token = "0x2000EE1")]
public class DuelpassRewardColumnWidget
{
	[Token(Token = "0x2000EE3")]
	[CompilerGenerated]
	private sealed class _003CPlayGradeUpSe_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A547")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A548")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400A549")]
		[FieldOffset(Offset = "0x20")]
		private float _003CelapsedTime_003E5__2;

		[Token(Token = "0x17000DF3")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6005A55")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000DF4")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005A57")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005A52")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CPlayGradeUpSe_003Ed__37(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6005A53")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6005A54")]
		[Address(RVA = "0x9FCB20", Offset = "0x9FBD20", VA = "0x1809FCB20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005A56")]
		[Address(RVA = "0x9FCC60", Offset = "0x9FBE60", VA = "0x1809FCC60", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400A53B")]
	[FieldOffset(Offset = "0x18")]
	private TMP_Text gradeText;

	[Token(Token = "0x400A540")]
	[FieldOffset(Offset = "0x40")]
	private DuelpassRewardButtonWidget normalRewardButton;

	[Token(Token = "0x400A541")]
	[FieldOffset(Offset = "0x48")]
	private DuelpassRewardButtonWidget goldRewardButton;

	[Token(Token = "0x17000DED")]
	public int ScrollEntityIdx
	{
		[Token(Token = "0x6005A32")]
		[Address(RVA = "0x3C7100", Offset = "0x3C6300", VA = "0x1803C7100")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6005A31")]
		[Address(RVA = "0x5F4710", Offset = "0x5F3910", VA = "0x1805F4710")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000DEE")]
	public int Grade
	{
		[Token(Token = "0x6005A34")]
		[Address(RVA = "0x64B770", Offset = "0x64A970", VA = "0x18064B770")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6005A33")]
		[Address(RVA = "0x64B780", Offset = "0x64A980", VA = "0x18064B780")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000DEF")]
	public TweenColorTo GradeTextColor
	{
		[Token(Token = "0x6005A36")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6005A35")]
		[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000DF0")]
	public TweenColorTo GradeTextBase
	{
		[Token(Token = "0x6005A38")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6005A37")]
		[Address(RVA = "0x402FB0", Offset = "0x4021B0", VA = "0x180402FB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000DF1")]
	public GameObject TextColor
	{
		[Token(Token = "0x6005A3A")]
		[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6005A39")]
		[Address(RVA = "0x4130D0", Offset = "0x4122D0", VA = "0x1804130D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000DF2")]
	public GameObject BaseColor
	{
		[Token(Token = "0x6005A3C")]
		[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6005A3B")]
		[Address(RVA = "0x595520", Offset = "0x594720", VA = "0x180595520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6005A3D")]
	[Address(RVA = "0x9F45D0", Offset = "0x9F37D0", VA = "0x1809F45D0")]
	public DuelpassRewardColumnWidget(GameObject gob)
	{
	}

	[Token(Token = "0x6005A3E")]
	[Address(RVA = "0x9F4390", Offset = "0x9F3590", VA = "0x1809F4390")]
	public void SetDownTransition(SelectionItem item)
	{
	}

	[Token(Token = "0x6005A3F")]
	[Address(RVA = "0x9F39C0", Offset = "0x9F2BC0", VA = "0x1809F39C0")]
	public void Init(DuelpassRewardColumnContext context, int achievedGrade)
	{
	}

	[Token(Token = "0x6005A40")]
	[Address(RVA = "0x9F4430", Offset = "0x9F3630", VA = "0x1809F4430")]
	public void SetSide(DuelpassRewardColumnWidget left, DuelpassRewardColumnWidget right)
	{
	}

	[Token(Token = "0x6005A41")]
	[Address(RVA = "0x9F43D0", Offset = "0x9F35D0", VA = "0x1809F43D0")]
	public void SetSide()
	{
	}

	[Token(Token = "0x6005A42")]
	[Address(RVA = "0x9F3EF0", Offset = "0x9F30F0", VA = "0x1809F3EF0")]
	public void ReceiveFunctionOff()
	{
	}

	[Token(Token = "0x6005A43")]
	[Address(RVA = "0x9F42B0", Offset = "0x9F34B0", VA = "0x1809F42B0")]
	public void SetAchievement(int achievedGrade)
	{
	}

	[Token(Token = "0x6005A44")]
	[Address(RVA = "0x9F41A0", Offset = "0x9F33A0", VA = "0x1809F41A0")]
	public void SetAchievementWithTween(int achievedGrade)
	{
	}

	[Token(Token = "0x6005A45")]
	[Address(RVA = "0x9F36E0", Offset = "0x9F28E0", VA = "0x1809F36E0")]
	public void Achieved()
	{
	}

	[Token(Token = "0x6005A46")]
	[Address(RVA = "0x9F44D0", Offset = "0x9F36D0", VA = "0x1809F44D0")]
	public void TweenToAchieved()
	{
	}

	[Token(Token = "0x6005A47")]
	[Address(RVA = "0x9F3EA0", Offset = "0x9F30A0", VA = "0x1809F3EA0")]
	[IteratorStateMachine(typeof(_003CPlayGradeUpSe_003Ed__37))]
	private IEnumerator PlayGradeUpSe(int grade)
	{
		return null;
	}

	[Token(Token = "0x6005A48")]
	[Address(RVA = "0x9F3880", Offset = "0x9F2A80", VA = "0x1809F3880")]
	public void DeAchieved()
	{
	}

	[Token(Token = "0x6005A49")]
	[Address(RVA = "0x9F40D0", Offset = "0x9F32D0", VA = "0x1809F40D0")]
	public void SelectColumnButton(int row)
	{
	}

	[Token(Token = "0x6005A4A")]
	[Address(RVA = "0x9F3F20", Offset = "0x9F3120", VA = "0x1809F3F20")]
	public void SelectButton(int row, bool GoldGrade = false)
	{
	}

	[Token(Token = "0x6005A4B")]
	[Address(RVA = "0x9F37B0", Offset = "0x9F29B0", VA = "0x1809F37B0")]
	public int CheckHasButton(SelectionButton button)
	{
		return default(int);
	}
}
