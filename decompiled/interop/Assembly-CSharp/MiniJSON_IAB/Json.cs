using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Il2CppDummyDll;

namespace MiniJSON_IAB;

[Token(Token = "0x200010A")]
public static class Json
{
	[Token(Token = "0x200010B")]
	private sealed class Parser : IDisposable
	{
		[Token(Token = "0x200010C")]
		private enum TOKEN
		{
			[Token(Token = "0x4000699")]
			NONE,
			[Token(Token = "0x400069A")]
			CURLY_OPEN,
			[Token(Token = "0x400069B")]
			CURLY_CLOSE,
			[Token(Token = "0x400069C")]
			SQUARED_OPEN,
			[Token(Token = "0x400069D")]
			SQUARED_CLOSE,
			[Token(Token = "0x400069E")]
			COLON,
			[Token(Token = "0x400069F")]
			COMMA,
			[Token(Token = "0x40006A0")]
			STRING,
			[Token(Token = "0x40006A1")]
			NUMBER,
			[Token(Token = "0x40006A2")]
			TRUE,
			[Token(Token = "0x40006A3")]
			FALSE,
			[Token(Token = "0x40006A4")]
			NULL
		}

		[Token(Token = "0x4000696")]
		private const string WORD_BREAK = "{}[],:\"";

		[Token(Token = "0x4000697")]
		[FieldOffset(Offset = "0x10")]
		private StringReader json;

		[Token(Token = "0x17000081")]
		private char PeekChar
		{
			[Token(Token = "0x60006C1")]
			[Address(RVA = "0x9E4520", Offset = "0x9E3720", VA = "0x1809E4520")]
			get
			{
				return default(char);
			}
		}

		[Token(Token = "0x17000082")]
		private char NextChar
		{
			[Token(Token = "0x60006C2")]
			[Address(RVA = "0x9E3F90", Offset = "0x9E3190", VA = "0x1809E3F90")]
			get
			{
				return default(char);
			}
		}

		[Token(Token = "0x17000083")]
		private string NextWord
		{
			[Token(Token = "0x60006C3")]
			[Address(RVA = "0x9E4340", Offset = "0x9E3540", VA = "0x1809E4340")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000084")]
		private TOKEN NextToken
		{
			[Token(Token = "0x60006C4")]
			[Address(RVA = "0x9E4000", Offset = "0x9E3200", VA = "0x1809E4000")]
			get
			{
				return default(TOKEN);
			}
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x9E33C0", Offset = "0x9E25C0", VA = "0x1809E33C0")]
		public static bool IsWordBreak(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x9E3F10", Offset = "0x9E3110", VA = "0x1809E3F10")]
		private Parser(string jsonString)
		{
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x9E3DC0", Offset = "0x9E2FC0", VA = "0x1809E3DC0")]
		public static object Parse(string jsonString)
		{
			return null;
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x3CA1F0", Offset = "0x3C93F0", VA = "0x1803CA1F0", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x9E3930", Offset = "0x9E2B30", VA = "0x1809E3930")]
		private Dictionary<string, object> ParseObject()
		{
			return null;
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x9E3440", Offset = "0x9E2640", VA = "0x1809E3440")]
		private List<object> ParseArray()
		{
			return null;
		}

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x9E3D90", Offset = "0x9E2F90", VA = "0x1809E3D90")]
		private object ParseValue()
		{
			return null;
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x9E3520", Offset = "0x9E2720", VA = "0x1809E3520")]
		private object ParseByToken(TOKEN token)
		{
			return null;
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x9E3A80", Offset = "0x9E2C80", VA = "0x1809E3A80")]
		private string ParseString()
		{
			return null;
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x9E3890", Offset = "0x9E2A90", VA = "0x1809E3890")]
		private object ParseNumber()
		{
			return null;
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x9E32D0", Offset = "0x9E24D0", VA = "0x1809E32D0")]
		private void EatWhitespace()
		{
		}
	}

	[Token(Token = "0x200010D")]
	private sealed class Serializer
	{
		[Token(Token = "0x40006A5")]
		[FieldOffset(Offset = "0x10")]
		private StringBuilder builder;

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x9E53B0", Offset = "0x9E45B0", VA = "0x1809E53B0")]
		private Serializer()
		{
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x9D5250", Offset = "0x9D4450", VA = "0x1809D5250")]
		public static string Serialize(object obj)
		{
			return null;
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x9E51A0", Offset = "0x9E43A0", VA = "0x1809E51A0")]
		private void SerializeValue(object value)
		{
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x9E49B0", Offset = "0x9E3BB0", VA = "0x1809E49B0")]
		private void SerializeObject(IDictionary obj)
		{
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x9E4780", Offset = "0x9E3980", VA = "0x1809E4780")]
		private void SerializeArray(IList anArray)
		{
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x9E4ED0", Offset = "0x9E40D0", VA = "0x1809E4ED0")]
		private void SerializeString(string str)
		{
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x9E4C80", Offset = "0x9E3E80", VA = "0x1809E4C80")]
		private void SerializeOther(object value)
		{
		}
	}

	[Token(Token = "0x60006B4")]
	[Address(RVA = "0x9D5240", Offset = "0x9D4440", VA = "0x1809D5240")]
	public static object Deserialize(string json)
	{
		return null;
	}

	[Token(Token = "0x60006B5")]
	[Address(RVA = "0x9D5250", Offset = "0x9D4450", VA = "0x1809D5250")]
	public static string Serialize(object obj)
	{
		return null;
	}
}
