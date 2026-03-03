using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using YgomGame.Dialog.CommonDialog;

namespace YgomGame.Mission;

[Token(Token = "0x2000BF5")]
public class BulkRecieveContext
{
	[Token(Token = "0x2000BF6")]
	public class RecievableContext
	{
		[Token(Token = "0x4009942")]
		[FieldOffset(Offset = "0x10")]
		public readonly Dictionary<int, Dictionary<int, List<int>>> recieveMap;

		[Token(Token = "0x170009C7")]
		public int length
		{
			[Token(Token = "0x60048C9")]
			[Address(RVA = "0x5C7C60", Offset = "0x5C6E60", VA = "0x1805C7C60")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60048CA")]
			[Address(RVA = "0x615AB0", Offset = "0x614CB0", VA = "0x180615AB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60048CB")]
		[Address(RVA = "0x924420", Offset = "0x923620", VA = "0x180924420")]
		public void Clear()
		{
		}

		[Token(Token = "0x60048CC")]
		[Address(RVA = "0x924470", Offset = "0x923670", VA = "0x180924470")]
		public RecievableContext()
		{
		}
	}

	[Token(Token = "0x2000BF7")]
	public class ResultContext
	{
		[Token(Token = "0x4009946")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, object> goalItems;

		[Token(Token = "0x170009C8")]
		public List<object> totalItems
		{
			[Token(Token = "0x60048CD")]
			[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60048CE")]
			[Address(RVA = "0x439010", Offset = "0x438210", VA = "0x180439010")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170009C9")]
		public bool isSendPresent
		{
			[Token(Token = "0x60048CF")]
			[Address(RVA = "0x444790", Offset = "0x443990", VA = "0x180444790")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60048D0")]
			[Address(RVA = "0x662770", Offset = "0x661970", VA = "0x180662770")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170009CA")]
		public bool isReceived
		{
			[Token(Token = "0x60048D1")]
			[Address(RVA = "0x924800", Offset = "0x923A00", VA = "0x180924800")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60048D2")]
		[Address(RVA = "0x9244F0", Offset = "0x9236F0", VA = "0x1809244F0")]
		public void Clear()
		{
		}

		[Token(Token = "0x60048D3")]
		[Address(RVA = "0x924530", Offset = "0x923730", VA = "0x180924530")]
		public void Import(Dictionary<string, object> resultData)
		{
		}

		[Token(Token = "0x60048D4")]
		[Address(RVA = "0x924670", Offset = "0x923870", VA = "0x180924670")]
		public EntryItemListData.Context SearchGoalItemContext(MissionContext missionCtx, int goalPos)
		{
			return null;
		}

		[Token(Token = "0x60048D5")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public ResultContext()
		{
		}
	}

	[Token(Token = "0x4009940")]
	[FieldOffset(Offset = "0x10")]
	private readonly Dictionary<TabContext, RecievableContext> m_RecievableContextMap;

	[Token(Token = "0x4009941")]
	[FieldOffset(Offset = "0x18")]
	public readonly ResultContext resultContext;

	[Token(Token = "0x60048C4")]
	[Address(RVA = "0x918600", Offset = "0x917800", VA = "0x180918600")]
	public int GetRecievableLength()
	{
		return default(int);
	}

	[Token(Token = "0x60048C5")]
	[Address(RVA = "0x917C50", Offset = "0x916E50", VA = "0x180917C50")]
	public void Clear()
	{
	}

	[Token(Token = "0x60048C6")]
	[Address(RVA = "0x918750", Offset = "0x917950", VA = "0x180918750")]
	public void Import(IReadOnlyList<TabContext> tabCtxts)
	{
	}

	[Token(Token = "0x60048C7")]
	[Address(RVA = "0x917DF0", Offset = "0x916FF0", VA = "0x180917DF0")]
	public (List<int>, List<int>, List<int>) ExportReq(TabContext tabContext)
	{
		return default((List<int>, List<int>, List<int>));
	}

	[Token(Token = "0x60048C8")]
	[Address(RVA = "0x918E70", Offset = "0x918070", VA = "0x180918E70")]
	public BulkRecieveContext()
	{
	}
}
