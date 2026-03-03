using System;
using System.IO;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.Utility;

[Token(Token = "0x20003AC")]
public class AsyncMiniJSON : MonoBehaviour
{
	[Token(Token = "0x20003AD")]
	private struct ParseParam
	{
		[Token(Token = "0x17000242")]
		public string json
		{
			[Token(Token = "0x6001637")]
			[Address(RVA = "0x5BF740", Offset = "0x5BE940", VA = "0x1805BF740")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001636")]
			[Address(RVA = "0x5BF760", Offset = "0x5BE960", VA = "0x1805BF760")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000243")]
		public Action<object> onfinish
		{
			[Token(Token = "0x6001639")]
			[Address(RVA = "0x5BF750", Offset = "0x5BE950", VA = "0x1805BF750")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001638")]
			[Address(RVA = "0x5BF770", Offset = "0x5BE970", VA = "0x1805BF770")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600163A")]
		[Address(RVA = "0x5BF700", Offset = "0x5BE900", VA = "0x1805BF700")]
		public ParseParam(string arg_json, Action<object> arg_onfinish)
		{
		}
	}

	[Token(Token = "0x20003AE")]
	private sealed class Parser : IDisposable
	{
		[Token(Token = "0x20003AF")]
		private enum TOKEN
		{
			[Token(Token = "0x4001294")]
			NONE,
			[Token(Token = "0x4001295")]
			CURLY_OPEN,
			[Token(Token = "0x4001296")]
			CURLY_CLOSE,
			[Token(Token = "0x4001297")]
			SQUARED_OPEN,
			[Token(Token = "0x4001298")]
			SQUARED_CLOSE,
			[Token(Token = "0x4001299")]
			COLON,
			[Token(Token = "0x400129A")]
			COMMA,
			[Token(Token = "0x400129B")]
			STRING,
			[Token(Token = "0x400129C")]
			NUMBER,
			[Token(Token = "0x400129D")]
			TRUE,
			[Token(Token = "0x400129E")]
			FALSE,
			[Token(Token = "0x400129F")]
			NULL
		}

		[Token(Token = "0x4001290")]
		private const string WORD_BREAK = "{}[],:\"";

		[Token(Token = "0x4001291")]
		[FieldOffset(Offset = "0x10")]
		private StringReader json;

		[Token(Token = "0x4001292")]
		[FieldOffset(Offset = "0x18")]
		private TaskManager parserTaskManager;

		[Token(Token = "0x17000244")]
		private char PeekChar
		{
			[Token(Token = "0x600164A")]
			[Address(RVA = "0x5C1000", Offset = "0x5C0200", VA = "0x1805C1000")]
			get
			{
				return default(char);
			}
		}

		[Token(Token = "0x17000245")]
		private char NextChar
		{
			[Token(Token = "0x600164B")]
			[Address(RVA = "0x5C0A70", Offset = "0x5BFC70", VA = "0x1805C0A70")]
			get
			{
				return default(char);
			}
		}

		[Token(Token = "0x17000246")]
		private string NextWord
		{
			[Token(Token = "0x600164C")]
			[Address(RVA = "0x5C0E20", Offset = "0x5C0020", VA = "0x1805C0E20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000247")]
		private TOKEN NextToken
		{
			[Token(Token = "0x600164D")]
			[Address(RVA = "0x5C0AE0", Offset = "0x5BFCE0", VA = "0x1805C0AE0")]
			get
			{
				return default(TOKEN);
			}
		}

		[Token(Token = "0x600163B")]
		[Address(RVA = "0x5BF8A0", Offset = "0x5BEAA0", VA = "0x1805BF8A0")]
		public static bool IsWordBreak(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x600163C")]
		[Address(RVA = "0x5C09A0", Offset = "0x5BFBA0", VA = "0x1805C09A0")]
		private Parser(string jsonString)
		{
		}

		[Token(Token = "0x600163D")]
		[Address(RVA = "0x5C0000", Offset = "0x5BF200", VA = "0x1805C0000")]
		public static Parser Parse(string jsonString, Action<object> onfinish)
		{
			return null;
		}

		[Token(Token = "0x600163E")]
		[Address(RVA = "0x5C0960", Offset = "0x5BFB60", VA = "0x1805C0960")]
		public void Update()
		{
		}

		[Token(Token = "0x600163F")]
		[Address(RVA = "0x5BF870", Offset = "0x5BEA70", VA = "0x1805BF870")]
		public bool IsDone()
		{
			return default(bool);
		}

		[Token(Token = "0x6001640")]
		[Address(RVA = "0x3CA1F0", Offset = "0x3C93F0", VA = "0x1803CA1F0", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6001641")]
		[Address(RVA = "0x5C05E0", Offset = "0x5BF7E0", VA = "0x1805C05E0")]
		private bool Task_ParseObject(TaskManager.ID tThis, int nExecNum, float fExecSec, object tParam)
		{
			return default(bool);
		}

		[Token(Token = "0x6001642")]
		[Address(RVA = "0x5C01C0", Offset = "0x5BF3C0", VA = "0x1805C01C0")]
		private bool Task_ParseArray(TaskManager.ID tThis, int nExecNum, float fExecSec, object tParam)
		{
			return default(bool);
		}

		[Token(Token = "0x6001643")]
		[Address(RVA = "0x5BFFC0", Offset = "0x5BF1C0", VA = "0x1805BFFC0")]
		private void ParseValue(Action<object> onfinish)
		{
		}

		[Token(Token = "0x6001644")]
		[Address(RVA = "0x5BF920", Offset = "0x5BEB20", VA = "0x1805BF920")]
		private void ParseByToken(TOKEN token, Action<object> onfinish)
		{
		}

		[Token(Token = "0x6001645")]
		[Address(RVA = "0x5C08C0", Offset = "0x5BFAC0", VA = "0x1805C08C0")]
		private bool Task_ParseString(TaskManager.ID tThis, int nExecNum, float fExecSec, object tParam)
		{
			return default(bool);
		}

		[Token(Token = "0x6001646")]
		[Address(RVA = "0x5C0480", Offset = "0x5BF680", VA = "0x1805C0480")]
		private bool Task_ParseNumber(TaskManager.ID tThis, int nExecNum, float fExecSec, object tParam)
		{
			return default(bool);
		}

		[Token(Token = "0x6001647")]
		[Address(RVA = "0x5BFCB0", Offset = "0x5BEEB0", VA = "0x1805BFCB0")]
		private string ParseString()
		{
			return null;
		}

		[Token(Token = "0x6001648")]
		[Address(RVA = "0x5BFBD0", Offset = "0x5BEDD0", VA = "0x1805BFBD0")]
		private object ParseNumber()
		{
			return null;
		}

		[Token(Token = "0x6001649")]
		[Address(RVA = "0x5BF780", Offset = "0x5BE980", VA = "0x1805BF780")]
		private void EatWhitespace()
		{
		}
	}

	[Token(Token = "0x400128B")]
	private const float EXECUTE_TASK_LIMIT_TIME = 0.03f;

	[Token(Token = "0x400128C")]
	private const string DEFAULT_GAMEOBJECT_NAME = "AsyncMiniJSON";

	[Token(Token = "0x400128D")]
	[FieldOffset(Offset = "0x20")]
	private TaskManager jsonTaskManager;

	[Token(Token = "0x6001630")]
	[Address(RVA = "0x5A0E80", Offset = "0x5A0080", VA = "0x1805A0E80")]
	public static void Deserialize(string json, GameObject owner, Action<object> onfinish)
	{
	}

	[Token(Token = "0x6001631")]
	[Address(RVA = "0x5A1100", Offset = "0x5A0300", VA = "0x1805A1100")]
	public static bool IsJsonAsyncParse()
	{
		return default(bool);
	}

	[Token(Token = "0x6001632")]
	[Address(RVA = "0x5A11A0", Offset = "0x5A03A0", VA = "0x1805A11A0")]
	public void Parse(string json, Action<object> onfinish)
	{
	}

	[Token(Token = "0x6001633")]
	[Address(RVA = "0x5A12B0", Offset = "0x5A04B0", VA = "0x1805A12B0")]
	private bool Task_StartParse(TaskManager.ID tThis, int nExecNum, float fExecSec, object tParam)
	{
		return default(bool);
	}

	[Token(Token = "0x6001634")]
	[Address(RVA = "0x5A15B0", Offset = "0x5A07B0", VA = "0x1805A15B0")]
	private void Update()
	{
	}

	[Token(Token = "0x6001635")]
	[Address(RVA = "0x5A1690", Offset = "0x5A0890", VA = "0x1805A1690")]
	public AsyncMiniJSON()
	{
	}
}
