using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x200019E")]
public struct StartDragArgs
{
	[Token(Token = "0x1700022D")]
	public readonly string title
	{
		[Token(Token = "0x6000C30")]
		[Address(RVA = "0x5BF740", Offset = "0x5BE940", VA = "0x1805BF740")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700022E")]
	public readonly DragVisualMode visualMode
	{
		[Token(Token = "0x6000C31")]
		[Address(RVA = "0x130E8C0", Offset = "0x130DAC0", VA = "0x18130E8C0")]
		[CompilerGenerated]
		get
		{
			return default(DragVisualMode);
		}
	}

	[Token(Token = "0x1700022F")]
	internal Hashtable genericData
	{
		[Token(Token = "0x6000C32")]
		[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Token(Token = "0x6000C33")]
		[Address(RVA = "0x439010", Offset = "0x438210", VA = "0x180439010")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000230")]
	internal IEnumerable<Object> unityObjectReferences
	{
		[Token(Token = "0x6000C34")]
		[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Token(Token = "0x6000C35")]
		[Address(RVA = "0x417C80", Offset = "0x416E80", VA = "0x180417C80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000231")]
	internal string[] assetPaths
	{
		[Token(Token = "0x6000C36")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Token(Token = "0x6000C37")]
		[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6000C2F")]
	[Address(RVA = "0x2B22910", Offset = "0x2B21B10", VA = "0x182B22910")]
	public StartDragArgs(string title, DragVisualMode visualMode)
	{
	}

	[Token(Token = "0x6000C38")]
	[Address(RVA = "0x2B22860", Offset = "0x2B21A60", VA = "0x182B22860")]
	public void SetGenericData(string key, object data)
	{
	}
}
