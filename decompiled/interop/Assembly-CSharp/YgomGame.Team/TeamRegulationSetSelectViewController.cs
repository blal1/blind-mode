using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.YGomTMPro;

namespace YgomGame.Team;

[Token(Token = "0x2001676")]
public class TeamRegulationSetSelectViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported, IBokeSupported
{
	[Token(Token = "0x2001677")]
	public class Param
	{
		[Token(Token = "0x17001550")]
		public List<TeamUtil.RegulationSet> regulationSetList
		{
			[Token(Token = "0x6008BC1")]
			[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6008BC0")]
			[Address(RVA = "0x439010", Offset = "0x438210", VA = "0x180439010")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17001551")]
		public int selectedIndex
		{
			[Token(Token = "0x6008BC3")]
			[Address(RVA = "0x5C7C60", Offset = "0x5C6E60", VA = "0x1805C7C60")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6008BC2")]
			[Address(RVA = "0x615AB0", Offset = "0x614CB0", VA = "0x180615AB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17001552")]
		public Action<int> onResult
		{
			[Token(Token = "0x6008BC5")]
			[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6008BC4")]
			[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6008BC6")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public Param()
		{
		}
	}

	[Token(Token = "0x2001678")]
	private class TabButton
	{
		[Token(Token = "0x400D6AD")]
		[FieldOffset(Offset = "0x10")]
		private string _title;

		[Token(Token = "0x17001553")]
		internal ElementObjectManager tabTop
		{
			[Token(Token = "0x6008BC8")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6008BC7")]
			[Address(RVA = "0x417C80", Offset = "0x416E80", VA = "0x180417C80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17001554")]
		internal SelectionButton button
		{
			[Token(Token = "0x6008BCA")]
			[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6008BC9")]
			[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17001555")]
		internal GameObject imageOn
		{
			[Token(Token = "0x6008BCC")]
			[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6008BCB")]
			[Address(RVA = "0x402FB0", Offset = "0x4021B0", VA = "0x180402FB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17001556")]
		internal GameObject imageOff
		{
			[Token(Token = "0x6008BCE")]
			[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6008BCD")]
			[Address(RVA = "0x4130D0", Offset = "0x4122D0", VA = "0x1804130D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17001557")]
		internal string[] itemStrings
		{
			[Token(Token = "0x6008BD0")]
			[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6008BCF")]
			[Address(RVA = "0x595520", Offset = "0x594720", VA = "0x180595520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17001558")]
		internal int index
		{
			[Token(Token = "0x6008BD2")]
			[Address(RVA = "0x5FA7B0", Offset = "0x5F99B0", VA = "0x1805FA7B0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6008BD1")]
			[Address(RVA = "0x409CD0", Offset = "0x408ED0", VA = "0x180409CD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17001559")]
		internal bool active
		{
			[Token(Token = "0x6008BD7")]
			[Address(RVA = "0x6A94E0", Offset = "0x6A86E0", VA = "0x1806A94E0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700155A")]
		internal string title
		{
			[Token(Token = "0x6008BD9")]
			[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
			get
			{
				return null;
			}
			[Token(Token = "0x6008BD8")]
			[Address(RVA = "0xD5DAC0", Offset = "0xD5CCC0", VA = "0x180D5DAC0")]
			set
			{
			}
		}

		[Token(Token = "0x140000BB")]
		internal event Action<int, string[]> onSelected
		{
			[Token(Token = "0x6008BD3")]
			[Address(RVA = "0xD5D8C0", Offset = "0xD5CAC0", VA = "0x180D5D8C0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6008BD4")]
			[Address(RVA = "0xD5DA10", Offset = "0xD5CC10", VA = "0x180D5DA10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x140000BC")]
		internal event Action onOkGoing
		{
			[Token(Token = "0x6008BD5")]
			[Address(RVA = "0xD5D820", Offset = "0xD5CA20", VA = "0x180D5D820")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6008BD6")]
			[Address(RVA = "0xD5D970", Offset = "0xD5CB70", VA = "0x180D5D970")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6008BDA")]
		[Address(RVA = "0xD5D470", Offset = "0xD5C670", VA = "0x180D5D470")]
		internal TabButton(ElementObjectManager tabTop, int index, string buttonTitle, string[] values)
		{
		}

		[Token(Token = "0x6008BDB")]
		[Address(RVA = "0xD5D3F0", Offset = "0xD5C5F0", VA = "0x180D5D3F0")]
		internal void SetSelected(bool active)
		{
		}

		[Token(Token = "0x6008BDC")]
		[Address(RVA = "0xD5D3C0", Offset = "0xD5C5C0", VA = "0x180D5D3C0")]
		internal void Focus()
		{
		}
	}

	[Token(Token = "0x400D6A0")]
	private const int SELECT_MAX = 3;

	[Token(Token = "0x400D6A1")]
	private const int REGULATIONSET_MAX = 5;

	[Token(Token = "0x400D6A2")]
	internal const string VC_PATH = "Team/TeamRegulationSetSelect";

	[Token(Token = "0x400D6A3")]
	[FieldOffset(Offset = "0xD0")]
	private Param _param;

	[Token(Token = "0x400D6A4")]
	[FieldOffset(Offset = "0xD8")]
	private int _prevSelectedIndex;

	[Token(Token = "0x400D6A5")]
	[FieldOffset(Offset = "0xE0")]
	private TabButton[] _tabButtons;

	[Token(Token = "0x400D6A6")]
	[FieldOffset(Offset = "0xE8")]
	private ExtendedTextMeshProUGUI _title;

	[Token(Token = "0x400D6A7")]
	[FieldOffset(Offset = "0xF0")]
	private ExtendedTextMeshProUGUI[] _reguHeadTxts;

	[Token(Token = "0x400D6A8")]
	[FieldOffset(Offset = "0xF8")]
	private ExtendedTextMeshProUGUI[] _reguValueTxts;

	[Token(Token = "0x400D6A9")]
	[FieldOffset(Offset = "0x100")]
	private SelectionButton _decideBtn;

	[Token(Token = "0x6008BB7")]
	[Address(RVA = "0xD6C240", Offset = "0xD6B440", VA = "0x180D6C240", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6008BB8")]
	[Address(RVA = "0xD6C2C0", Offset = "0xD6B4C0", VA = "0x180D6C2C0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6008BB9")]
	[Address(RVA = "0xD6CCC0", Offset = "0xD6BEC0", VA = "0x180D6CCC0")]
	private void OnTabSelected(int tabIndex, string[] values)
	{
	}

	[Token(Token = "0x6008BBA")]
	[Address(RVA = "0xD6D040", Offset = "0xD6C240", VA = "0x180D6D040")]
	private void SetupTabShortcut(GameObject target, UnityAction action)
	{
	}

	[Token(Token = "0x6008BBB")]
	[Address(RVA = "0xD6D3C0", Offset = "0xD6C5C0", VA = "0x180D6D3C0")]
	public TeamRegulationSetSelectViewController()
	{
	}
}
