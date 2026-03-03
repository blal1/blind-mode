using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame;

[Token(Token = "0x200062A")]
public class CardCheckViewController : ViewController
{
	[Token(Token = "0x200062C")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass152_0
	{
		[Token(Token = "0x4001E1D")]
		[FieldOffset(Offset = "0x10")]
		public CardCheckViewController _003C_003E4__this;

		[Token(Token = "0x4001E1E")]
		[FieldOffset(Offset = "0x18")]
		public int numLanguage;

		[Token(Token = "0x4001E1F")]
		[FieldOffset(Offset = "0x20")]
		public string currentlanguage;

		[Token(Token = "0x4001E20")]
		[FieldOffset(Offset = "0x28")]
		public Toggle m_CheckDataModeToggle;

		[Token(Token = "0x60028E4")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass152_0()
		{
		}

		[Token(Token = "0x60028E5")]
		[Address(RVA = "0x6B4A20", Offset = "0x6B3C20", VA = "0x1806B4A20")]
		internal void _003COnStart_003Eb__0()
		{
		}

		[Token(Token = "0x60028E6")]
		[Address(RVA = "0x6B4DD0", Offset = "0x6B3FD0", VA = "0x1806B4DD0")]
		internal void _003COnStart_003Eb__1()
		{
		}

		[Token(Token = "0x60028E7")]
		[Address(RVA = "0x6B4FC0", Offset = "0x6B41C0", VA = "0x1806B4FC0")]
		internal void _003COnStart_003Eb__2()
		{
		}

		[Token(Token = "0x60028E8")]
		[Address(RVA = "0x6B51E0", Offset = "0x6B43E0", VA = "0x1806B51E0")]
		internal void _003COnStart_003Eb__3()
		{
		}

		[Token(Token = "0x60028E9")]
		[Address(RVA = "0x6B5210", Offset = "0x6B4410", VA = "0x1806B5210")]
		internal void _003COnStart_003Eb__4()
		{
		}

		[Token(Token = "0x60028EA")]
		[Address(RVA = "0x6B5240", Offset = "0x6B4440", VA = "0x1806B5240")]
		internal void _003COnStart_003Eb__5()
		{
		}

		[Token(Token = "0x60028EB")]
		[Address(RVA = "0x6B5270", Offset = "0x6B4470", VA = "0x1806B5270")]
		internal void _003COnStart_003Eb__6()
		{
		}

		[Token(Token = "0x60028EC")]
		[Address(RVA = "0x6B52D0", Offset = "0x6B44D0", VA = "0x1806B52D0")]
		internal void _003COnStart_003Eb__7()
		{
		}

		[Token(Token = "0x60028ED")]
		[Address(RVA = "0x6B5330", Offset = "0x6B4530", VA = "0x1806B5330")]
		internal void _003COnStart_003Eb__8()
		{
		}

		[Token(Token = "0x60028EE")]
		[Address(RVA = "0x6B5390", Offset = "0x6B4590", VA = "0x1806B5390")]
		internal void _003COnStart_003Eb__9()
		{
		}

		[Token(Token = "0x60028EF")]
		[Address(RVA = "0x6B4A40", Offset = "0x6B3C40", VA = "0x1806B4A40")]
		internal void _003COnStart_003Eb__10(bool value)
		{
		}

		[Token(Token = "0x60028F0")]
		[Address(RVA = "0x6B4B60", Offset = "0x6B3D60", VA = "0x1806B4B60")]
		internal void _003COnStart_003Eb__11()
		{
		}

		[Token(Token = "0x60028F1")]
		[Address(RVA = "0x6B4C10", Offset = "0x6B3E10", VA = "0x1806B4C10")]
		internal void _003COnStart_003Eb__12(bool value)
		{
		}

		[Token(Token = "0x60028F2")]
		[Address(RVA = "0x6B4C30", Offset = "0x6B3E30", VA = "0x1806B4C30")]
		internal void _003COnStart_003Eb__13(int value)
		{
		}

		[Token(Token = "0x60028F3")]
		[Address(RVA = "0x6B4C80", Offset = "0x6B3E80", VA = "0x1806B4C80")]
		internal void _003COnStart_003Eb__15()
		{
		}

		[Token(Token = "0x60028F4")]
		[Address(RVA = "0x6B4CE0", Offset = "0x6B3EE0", VA = "0x1806B4CE0")]
		internal void _003COnStart_003Eb__16()
		{
		}

		[Token(Token = "0x60028F5")]
		[Address(RVA = "0x6B4D40", Offset = "0x6B3F40", VA = "0x1806B4D40")]
		internal void _003COnStart_003Eb__17()
		{
		}

		[Token(Token = "0x60028F6")]
		[Address(RVA = "0x6B4DA0", Offset = "0x6B3FA0", VA = "0x1806B4DA0")]
		internal void _003COnStart_003Eb__19()
		{
		}

		[Token(Token = "0x60028F7")]
		[Address(RVA = "0x6B4EE0", Offset = "0x6B40E0", VA = "0x1806B4EE0")]
		internal void _003COnStart_003Eb__20()
		{
		}
	}

	[Token(Token = "0x200062E")]
	[CompilerGenerated]
	private sealed class _003CAutoUpdateCard_003Ed__163 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001E23")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001E24")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001E25")]
		[FieldOffset(Offset = "0x20")]
		public CardCheckViewController _003C_003E4__this;

		[Token(Token = "0x1700053F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60028FD")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000540")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60028FF")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60028FA")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CAutoUpdateCard_003Ed__163(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60028FB")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60028FC")]
		[Address(RVA = "0x6B2920", Offset = "0x6B1B20", VA = "0x1806B2920", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60028FE")]
		[Address(RVA = "0x6B2AC0", Offset = "0x6B1CC0", VA = "0x1806B2AC0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x200062F")]
	[CompilerGenerated]
	private sealed class _003COnStart_003Ed__152 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001E26")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001E27")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001E28")]
		[FieldOffset(Offset = "0x20")]
		public CardCheckViewController _003C_003E4__this;

		[Token(Token = "0x4001E29")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass152_0 _003C_003E8__1;

		[Token(Token = "0x17000541")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002903")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000542")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002905")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002900")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003COnStart_003Ed__152(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002901")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002902")]
		[Address(RVA = "0x6B2B00", Offset = "0x6B1D00", VA = "0x1806B2B00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002904")]
		[Address(RVA = "0x6B4600", Offset = "0x6B3800", VA = "0x1806B4600", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4001DDD")]
	private const string LABEL_EO_CARDID = "CardId";

	[Token(Token = "0x4001DDE")]
	private const string LABEL_EO_TSIZE = "TextSize";

	[Token(Token = "0x4001DDF")]
	private const string LABEL_EO_TSIZE_P = "TextSize_P";

	[Token(Token = "0x4001DE0")]
	private const string LABEL_EO_NLENGTH = "NameLength";

	[Token(Token = "0x4001DE1")]
	private const string LABEL_EO_TLENGTH = "TextLength";

	[Token(Token = "0x4001DE2")]
	private const string LABEL_EO_TLENGTH_P = "TextLength_P";

	[Token(Token = "0x4001DE3")]
	private const string LABEL_EO_TOGGLE = "Toggle";

	[Token(Token = "0x4001DE4")]
	private const string LABEL_EO_CHECK = "Check";

	[Token(Token = "0x4001DE5")]
	private const string LABEL_EO_RANDOM = "Random";

	[Token(Token = "0x4001DE6")]
	private const string LABEL_EO_UPDATEFONT = "UpdateFont";

	[Token(Token = "0x4001DE7")]
	private const string LABEL_EO_MASK = "Mask";

	[Token(Token = "0x4001DE8")]
	private const string LABEL_EO_INPUT_FIELD = "InputField";

	[Token(Token = "0x4001DE9")]
	private const string LABEL_EO_COUNTER = "Counter";

	[Token(Token = "0x4001DEA")]
	private const string LABEL_EO_STARTID = "StartId";

	[Token(Token = "0x4001DEB")]
	private const string LABEL_EO_ENDID = "EndId";

	[Token(Token = "0x4001DEC")]
	private const string LABEL_EO_DURATION = "Duration";

	[Token(Token = "0x4001DED")]
	private const string LABEL_EO_PLAY = "Play";

	[Token(Token = "0x4001DEE")]
	private const string LABEL_EO_PAUSE = "Pause";

	[Token(Token = "0x4001DEF")]
	private const string LABEL_EO_DROPDOWNLANGUAGE = "DropDownLanguage";

	[Token(Token = "0x4001DF0")]
	private const string LABEL_EO_UPDATELANGUAGE = "UpdateLanguage";

	[Token(Token = "0x4001DF1")]
	private const string LABEL_EO_TOGGLEALLLANGUAGE = "ToggleAllLanguage";

	[Token(Token = "0x4001DF2")]
	private const string LABEL_EO_LANGUAGE00 = "ja-JP";

	[Token(Token = "0x4001DF3")]
	private const string LABEL_EO_LANGUAGE01 = "en-US";

	[Token(Token = "0x4001DF4")]
	private const string LABEL_EO_LANGUAGE02 = "fr-FR";

	[Token(Token = "0x4001DF5")]
	private const string LABEL_EO_LANGUAGE03 = "it-IT";

	[Token(Token = "0x4001DF6")]
	private const string LABEL_EO_LANGUAGE04 = "de-DE";

	[Token(Token = "0x4001DF7")]
	private const string LABEL_EO_LANGUAGE05 = "es-ES";

	[Token(Token = "0x4001DF8")]
	private const string LABEL_EO_LANGUAGE06 = "pt-BR";

	[Token(Token = "0x4001DF9")]
	private const string LABEL_EO_LANGUAGE07 = "ko-KR";

	[Token(Token = "0x4001DFA")]
	private const string LABEL_EO_LANGUAGE08 = "zh-TW";

	[Token(Token = "0x4001DFB")]
	private const string LABEL_EO_LANGUAGE09 = "zh-CN";

	[Token(Token = "0x4001DFC")]
	[FieldOffset(Offset = "0x48")]
	private string[] LABEL_EO_LANGUAGE;

	[Token(Token = "0x4001DFD")]
	private const string LABEL_EO_IMAGETYPE = "ImageType";

	[Token(Token = "0x4001DFE")]
	private const string LABEL_EO_OCG = "OCG";

	[Token(Token = "0x4001DFF")]
	private const string LABEL_EO_TCG = "TCG";

	[Token(Token = "0x4001E00")]
	private const string LABEL_EO_ILLUST = "Illust";

	[Token(Token = "0x4001E01")]
	private const string LABEL_EO_ILLUST_HD = "Illust_HD";

	[Token(Token = "0x4001E02")]
	private const string LABEL_EO_FRAME_M = "FrameM";

	[Token(Token = "0x4001E03")]
	private const string LABEL_EO_FRAME_P = "FrameP";

	[Token(Token = "0x4001E04")]
	private const string LABEL_EO_FRAME_ST = "FrameST";

	[Token(Token = "0x4001E05")]
	private const string LABEL_EO_INPUT = "Input";

	[Token(Token = "0x4001E06")]
	private const string LABEL_EO_STYLE_NORMAL = "NormalStyle";

	[Token(Token = "0x4001E07")]
	private const string LABEL_EO_STYLE_SHINE = "ShineStyle";

	[Token(Token = "0x4001E08")]
	private const string LABEL_EO_STYLE_ROYAL = "RoyalStyle";

	[Token(Token = "0x4001E09")]
	private const string LABEL_EO_TOGGLE_SAVE_IMAGE = "SaveImage";

	[Token(Token = "0x4001E0A")]
	private const string LABEL_EO_TOGGLE_SAVE_FONTINFO = "SaveFontSize";

	[Token(Token = "0x4001E0B")]
	private const string LABEL_EO_TOGGLE_CLEAR_FONTINFO = "ClearFontSize";

	[Token(Token = "0x4001E0C")]
	private const string LABEL_EO_TOGGLE_CHECK_FONTINFO = "CheckFontSize";

	[Token(Token = "0x4001E0D")]
	[FieldOffset(Offset = "0x50")]
	private List<int> m_InputMRKList;

	[Token(Token = "0x4001E0E")]
	[FieldOffset(Offset = "0x58")]
	private bool m_AutoPlay;

	[Token(Token = "0x4001E0F")]
	[FieldOffset(Offset = "0x60")]
	private ElementObjectManager m_Eom;

	[Token(Token = "0x4001E10")]
	[FieldOffset(Offset = "0x68")]
	private int CARDNUM;

	[Token(Token = "0x4001E11")]
	[FieldOffset(Offset = "0x6C")]
	private int m_CurrentPicture;

	[Token(Token = "0x4001E12")]
	[FieldOffset(Offset = "0x70")]
	private List<RawImage> m_CardPictures;

	[Token(Token = "0x4001E13")]
	[FieldOffset(Offset = "0x78")]
	private List<int> m_TargetList;

	[Token(Token = "0x4001E14")]
	[FieldOffset(Offset = "0x80")]
	private int m_ListId;

	[Token(Token = "0x4001E15")]
	[FieldOffset(Offset = "0x84")]
	private int m_ListEnd;

	[Token(Token = "0x4001E16")]
	[FieldOffset(Offset = "0x88")]
	private int m_StyleId;

	[Token(Token = "0x4001E17")]
	[FieldOffset(Offset = "0x90")]
	private Selector m_Selector;

	[Token(Token = "0x4001E18")]
	[FieldOffset(Offset = "0x98")]
	private bool m_isOCG;

	[Token(Token = "0x4001E19")]
	[FieldOffset(Offset = "0xA0")]
	private string CurrentLang;

	[Token(Token = "0x17000516")]
	private int m_CardId
	{
		[Token(Token = "0x600289D")]
		[Address(RVA = "0x6A3600", Offset = "0x6A2800", VA = "0x1806A3600")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600289E")]
		[Address(RVA = "0x6A53B0", Offset = "0x6A45B0", VA = "0x1806A53B0")]
		set
		{
		}
	}

	[Token(Token = "0x17000517")]
	private int m_FSize
	{
		[Token(Token = "0x600289F")]
		[Address(RVA = "0x6A3BF0", Offset = "0x6A2DF0", VA = "0x1806A3BF0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60028A0")]
		[Address(RVA = "0x6A56B0", Offset = "0x6A48B0", VA = "0x1806A56B0")]
		set
		{
		}
	}

	[Token(Token = "0x17000518")]
	private int m_FSize_P
	{
		[Token(Token = "0x60028A1")]
		[Address(RVA = "0x6A3B20", Offset = "0x6A2D20", VA = "0x1806A3B20")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60028A2")]
		[Address(RVA = "0x6A55F0", Offset = "0x6A47F0", VA = "0x1806A55F0")]
		set
		{
		}
	}

	[Token(Token = "0x17000519")]
	private int m_NLength
	{
		[Token(Token = "0x60028A3")]
		[Address(RVA = "0x6A4400", Offset = "0x6A3600", VA = "0x1806A4400")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60028A4")]
		[Address(RVA = "0x6A5770", Offset = "0x6A4970", VA = "0x1806A5770")]
		set
		{
		}
	}

	[Token(Token = "0x1700051A")]
	private int m_TLength
	{
		[Token(Token = "0x60028A5")]
		[Address(RVA = "0x6A4C40", Offset = "0x6A3E40", VA = "0x1806A4C40")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60028A6")]
		[Address(RVA = "0x6A59B0", Offset = "0x6A4BB0", VA = "0x1806A59B0")]
		set
		{
		}
	}

	[Token(Token = "0x1700051B")]
	private int m_TLength_P
	{
		[Token(Token = "0x60028A7")]
		[Address(RVA = "0x6A4B30", Offset = "0x6A3D30", VA = "0x1806A4B30")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60028A8")]
		[Address(RVA = "0x6A58F0", Offset = "0x6A4AF0", VA = "0x1806A58F0")]
		set
		{
		}
	}

	[Token(Token = "0x1700051C")]
	private int m_StartId
	{
		[Token(Token = "0x60028A9")]
		[Address(RVA = "0x6A4A90", Offset = "0x6A3C90", VA = "0x1806A4A90")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60028AA")]
		[Address(RVA = "0x6A5830", Offset = "0x6A4A30", VA = "0x1806A5830")]
		set
		{
		}
	}

	[Token(Token = "0x1700051D")]
	private int m_EndId
	{
		[Token(Token = "0x60028AB")]
		[Address(RVA = "0x6A3A80", Offset = "0x6A2C80", VA = "0x1806A3A80")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60028AC")]
		[Address(RVA = "0x6A5530", Offset = "0x6A4730", VA = "0x1806A5530")]
		set
		{
		}
	}

	[Token(Token = "0x1700051E")]
	private float m_Duration
	{
		[Token(Token = "0x60028AD")]
		[Address(RVA = "0x6A39E0", Offset = "0x6A2BE0", VA = "0x1806A39E0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60028AE")]
		[Address(RVA = "0x6A5470", Offset = "0x6A4670", VA = "0x1806A5470")]
		set
		{
		}
	}

	[Token(Token = "0x1700051F")]
	private SelectionButton m_CheckButton
	{
		[Token(Token = "0x60028AF")]
		[Address(RVA = "0x6A3720", Offset = "0x6A2920", VA = "0x1806A3720")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000520")]
	private SelectionButton m_RandomButton
	{
		[Token(Token = "0x60028B0")]
		[Address(RVA = "0x6A4720", Offset = "0x6A3920", VA = "0x1806A4720")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000521")]
	private SelectionButton m_UpdateFontButton
	{
		[Token(Token = "0x60028B1")]
		[Address(RVA = "0x6A50C0", Offset = "0x6A42C0", VA = "0x1806A50C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000522")]
	private RawImage m_CardPicture
	{
		[Token(Token = "0x60028B2")]
		[Address(RVA = "0x6A36D0", Offset = "0x6A28D0", VA = "0x1806A36D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000523")]
	private SelectionButton m_Play
	{
		[Token(Token = "0x60028B3")]
		[Address(RVA = "0x6A4670", Offset = "0x6A3870", VA = "0x1806A4670")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000524")]
	private SelectionButton m_Pause
	{
		[Token(Token = "0x60028B4")]
		[Address(RVA = "0x6A45C0", Offset = "0x6A37C0", VA = "0x1806A45C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000525")]
	private Toggle[] m_LanguageToggles
	{
		[Token(Token = "0x60028B5")]
		[Address(RVA = "0x6A41C0", Offset = "0x6A33C0", VA = "0x1806A41C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000526")]
	private SelectionButton[] m_UpdateLanguage
	{
		[Token(Token = "0x60028B6")]
		[Address(RVA = "0x6A5170", Offset = "0x6A4370", VA = "0x1806A5170")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000527")]
	private Dropdown m_DropDwonLanguage
	{
		[Token(Token = "0x60028B7")]
		[Address(RVA = "0x6A3930", Offset = "0x6A2B30", VA = "0x1806A3930")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000528")]
	private SelectionButton m_Language
	{
		[Token(Token = "0x60028B8")]
		[Address(RVA = "0x6A4350", Offset = "0x6A3550", VA = "0x1806A4350")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000529")]
	private Toggle m_ToggleAllLanguage
	{
		[Token(Token = "0x60028B9")]
		[Address(RVA = "0x6A4D50", Offset = "0x6A3F50", VA = "0x1806A4D50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700052A")]
	private SelectionButton m_AllLanguage
	{
		[Token(Token = "0x60028BA")]
		[Address(RVA = "0x6A3550", Offset = "0x6A2750", VA = "0x1806A3550")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700052B")]
	private Text m_imageTypeText
	{
		[Token(Token = "0x60028BB")]
		[Address(RVA = "0x6A5300", Offset = "0x6A4500", VA = "0x1806A5300")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700052C")]
	private Toggle m_ToggleFrame_M
	{
		[Token(Token = "0x60028BC")]
		[Address(RVA = "0x6A4E00", Offset = "0x6A4000", VA = "0x1806A4E00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700052D")]
	private SelectionButton m_Frame_M
	{
		[Token(Token = "0x60028BD")]
		[Address(RVA = "0x6A3CC0", Offset = "0x6A2EC0", VA = "0x1806A3CC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700052E")]
	private bool m_IsFrame_M
	{
		[Token(Token = "0x60028BE")]
		[Address(RVA = "0x6A4010", Offset = "0x6A3210", VA = "0x1806A4010")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700052F")]
	private Toggle m_ToggleFrame_P
	{
		[Token(Token = "0x60028BF")]
		[Address(RVA = "0x6A4EB0", Offset = "0x6A40B0", VA = "0x1806A4EB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000530")]
	private SelectionButton m_Frame_P
	{
		[Token(Token = "0x60028C0")]
		[Address(RVA = "0x6A3D70", Offset = "0x6A2F70", VA = "0x1806A3D70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000531")]
	private bool m_IsFrame_P
	{
		[Token(Token = "0x60028C1")]
		[Address(RVA = "0x6A40A0", Offset = "0x6A32A0", VA = "0x1806A40A0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000532")]
	private Toggle m_ToggleFrame_ST
	{
		[Token(Token = "0x60028C2")]
		[Address(RVA = "0x6A4F60", Offset = "0x6A4160", VA = "0x1806A4F60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000533")]
	private SelectionButton m_Frame_ST
	{
		[Token(Token = "0x60028C3")]
		[Address(RVA = "0x6A3E20", Offset = "0x6A3020", VA = "0x1806A3E20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000534")]
	private bool m_IsFrame_ST
	{
		[Token(Token = "0x60028C4")]
		[Address(RVA = "0x6A4130", Offset = "0x6A3330", VA = "0x1806A4130")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000535")]
	private SelectionButton m_NormalStyleButton
	{
		[Token(Token = "0x60028C5")]
		[Address(RVA = "0x6A4510", Offset = "0x6A3710", VA = "0x1806A4510")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000536")]
	private SelectionButton m_ShineStyleButton
	{
		[Token(Token = "0x60028C6")]
		[Address(RVA = "0x6A49E0", Offset = "0x6A3BE0", VA = "0x1806A49E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000537")]
	private SelectionButton m_RoyalStyleButton
	{
		[Token(Token = "0x60028C7")]
		[Address(RVA = "0x6A47D0", Offset = "0x6A39D0", VA = "0x1806A47D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000538")]
	private SelectionButton m_InputListButton
	{
		[Token(Token = "0x60028C8")]
		[Address(RVA = "0x6A3ED0", Offset = "0x6A30D0", VA = "0x1806A3ED0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000539")]
	private SelectionButton m_SaveImage
	{
		[Token(Token = "0x60028C9")]
		[Address(RVA = "0x6A4930", Offset = "0x6A3B30", VA = "0x1806A4930")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700053A")]
	private SelectionButton m_SaveFontSize
	{
		[Token(Token = "0x60028CA")]
		[Address(RVA = "0x6A4880", Offset = "0x6A3A80", VA = "0x1806A4880")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700053B")]
	private SelectionButton m_ClearFontSize
	{
		[Token(Token = "0x60028CB")]
		[Address(RVA = "0x6A3880", Offset = "0x6A2A80", VA = "0x1806A3880")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700053C")]
	private SelectionButton m_CheckDataMode
	{
		[Token(Token = "0x60028CC")]
		[Address(RVA = "0x6A37D0", Offset = "0x6A29D0", VA = "0x1806A37D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700053D")]
	private Toggle m_ToggleSaveImage
	{
		[Token(Token = "0x60028CD")]
		[Address(RVA = "0x6A5010", Offset = "0x6A4210", VA = "0x1806A5010")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700053E")]
	private bool m_IsAllLanguage
	{
		[Token(Token = "0x60028CE")]
		[Address(RVA = "0x6A3F80", Offset = "0x6A3180", VA = "0x1806A3F80")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60028CF")]
	[Address(RVA = "0x6A2940", Offset = "0x6A1B40", VA = "0x1806A2940")]
	private void Start()
	{
	}

	[Token(Token = "0x60028D0")]
	[Address(RVA = "0x6A2770", Offset = "0x6A1970", VA = "0x1806A2770")]
	[IteratorStateMachine(typeof(_003COnStart_003Ed__152))]
	private IEnumerator OnStart()
	{
		return null;
	}

	[Token(Token = "0x60028D1")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	private void Update()
	{
	}

	[Token(Token = "0x60028D2")]
	[Address(RVA = "0x6A1AE0", Offset = "0x6A0CE0", VA = "0x1806A1AE0")]
	private void DebugPrintCardData(int mrk)
	{
	}

	[Token(Token = "0x60028D3")]
	[Address(RVA = "0x6A1E70", Offset = "0x6A1070", VA = "0x1806A1E70")]
	private void MakeTargetList()
	{
	}

	[Token(Token = "0x60028D4")]
	[Address(RVA = "0x6A2120", Offset = "0x6A1320", VA = "0x1806A2120")]
	private void MakeTargetListforAll()
	{
	}

	[Token(Token = "0x60028D5")]
	[Address(RVA = "0x6A3100", Offset = "0x6A2300", VA = "0x1806A3100")]
	private void UpdateFontSize()
	{
	}

	[Token(Token = "0x60028D6")]
	[Address(RVA = "0x6A2D20", Offset = "0x6A1F20", VA = "0x1806A2D20")]
	private void UpdateCardAsync()
	{
	}

	[Token(Token = "0x60028D7")]
	[Address(RVA = "0x6A2FE0", Offset = "0x6A21E0", VA = "0x1806A2FE0")]
	private void UpdateCardOneAsync()
	{
	}

	[Token(Token = "0x60028D8")]
	[Address(RVA = "0x6A1630", Offset = "0x6A0830", VA = "0x1806A1630")]
	private void ChangeLanguage(string lang)
	{
	}

	[Token(Token = "0x60028D9")]
	[Address(RVA = "0x6A27E0", Offset = "0x6A19E0", VA = "0x1806A27E0")]
	private void SaveCardImageAsJpg(Texture texture, int cardId)
	{
	}

	[Token(Token = "0x60028DA")]
	[Address(RVA = "0x6A15C0", Offset = "0x6A07C0", VA = "0x1806A15C0")]
	[IteratorStateMachine(typeof(_003CAutoUpdateCard_003Ed__163))]
	private IEnumerator AutoUpdateCard()
	{
		return null;
	}

	[Token(Token = "0x60028DB")]
	[Address(RVA = "0x6A1C80", Offset = "0x6A0E80", VA = "0x1806A1C80")]
	private void InputList(string country)
	{
	}

	[Token(Token = "0x60028DC")]
	[Address(RVA = "0x6A2330", Offset = "0x6A1530", VA = "0x1806A2330")]
	private void NameCheck(string country)
	{
	}

	[Token(Token = "0x60028DD")]
	[Address(RVA = "0x6A1750", Offset = "0x6A0950", VA = "0x1806A1750")]
	private void ContainsCheck(string country)
	{
	}

	[Token(Token = "0x60028DE")]
	[Address(RVA = "0x6A3290", Offset = "0x6A2490", VA = "0x1806A3290")]
	public CardCheckViewController()
	{
	}
}
