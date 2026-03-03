using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace YgomSystem.LocalFileSystem;

[Token(Token = "0x20002F2")]
public class LocalFileStream : IDisposable
{
	[StructLayout(3)]
	[Token(Token = "0x20002F3")]
	[CompilerGenerated]
	private struct _003CReadAllBytesCallback_003Ed__47 : IAsyncStateMachine
	{
		[Token(Token = "0x4000FFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4000FFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x4000FFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LocalFileStream _003C_003E4__this;

		[Token(Token = "0x4000FFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action<byte[]> finishCallback;

		[Token(Token = "0x4000FFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action<Exception> errorCallback;

		[Token(Token = "0x4001000")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TaskAwaiter<byte[]> _003C_003Eu__1;

		[Token(Token = "0x600125E")]
		[Address(RVA = "0x418120", Offset = "0x417320", VA = "0x180418120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600125F")]
		[Address(RVA = "0x418110", Offset = "0x417310", VA = "0x180418110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x20002F4")]
	[CompilerGenerated]
	private struct _003CReadAsyncCallback_003Ed__43 : IAsyncStateMachine
	{
		[Token(Token = "0x4001001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4001002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x4001003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LocalFileStream _003C_003E4__this;

		[Token(Token = "0x4001004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public byte[] buffer;

		[Token(Token = "0x4001005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int offset;

		[Token(Token = "0x4001006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int count;

		[Token(Token = "0x4001007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Action<int> finishCallback;

		[Token(Token = "0x4001008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Action<Exception> errorCallback;

		[Token(Token = "0x4001009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TaskAwaiter<int> _003C_003Eu__1;

		[Token(Token = "0x6001260")]
		[Address(RVA = "0x418360", Offset = "0x417560", VA = "0x180418360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6001261")]
		[Address(RVA = "0x418110", Offset = "0x417310", VA = "0x180418110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x20002F5")]
	[CompilerGenerated]
	private struct _003CWriteAsyncCallback_003Ed__24 : IAsyncStateMachine
	{
		[Token(Token = "0x400100A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x400100B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x400100C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LocalFileStream _003C_003E4__this;

		[Token(Token = "0x400100D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public byte[] data;

		[Token(Token = "0x400100E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int offset;

		[Token(Token = "0x400100F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int count;

		[Token(Token = "0x4001010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Action finishCallback;

		[Token(Token = "0x4001011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Action<Exception> errorCallback;

		[Token(Token = "0x4001012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TaskAwaiter _003C_003Eu__1;

		[Token(Token = "0x6001262")]
		[Address(RVA = "0x419720", Offset = "0x418920", VA = "0x180419720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6001263")]
		[Address(RVA = "0x418110", Offset = "0x417310", VA = "0x180418110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x4000FF6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private Stream m_ioStream;

	[Token(Token = "0x4000FF7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private FileLocation m_location;

	[Token(Token = "0x4000FF8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private string m_nativePath;

	[Token(Token = "0x4000FF9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private StreamOpenMode m_openMode;

	[Token(Token = "0x4000FFA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private ReadRequest m_asyncReadRequest;

	[Token(Token = "0x170001D5")]
	public string nativePath
	{
		[Token(Token = "0x600121A")]
		[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001D6")]
	public StreamOpenMode openMode
	{
		[Token(Token = "0x600121B")]
		[Address(RVA = "0x40C450", Offset = "0x40B650", VA = "0x18040C450")]
		get
		{
			return default(StreamOpenMode);
		}
	}

	[Token(Token = "0x170001D7")]
	public Stream ioStream
	{
		[Token(Token = "0x600121C")]
		[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001D8")]
	public long Position
	{
		[Token(Token = "0x6001252")]
		[Address(RVA = "0x40C380", Offset = "0x40B580", VA = "0x18040C380")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x170001D9")]
	public long Length
	{
		[Token(Token = "0x6001253")]
		[Address(RVA = "0x40C350", Offset = "0x40B550", VA = "0x18040C350")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x170001DA")]
	public long Remain
	{
		[Token(Token = "0x6001254")]
		[Address(RVA = "0x40C3B0", Offset = "0x40B5B0", VA = "0x18040C3B0")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x600120F")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	private LocalFileStream()
	{
	}

	[Token(Token = "0x6001210")]
	[Address(RVA = "0x40C460", Offset = "0x40B660", VA = "0x18040C460")]
	private void initialize(string _nativePath, FileLocation _location, StreamOpenMode _openMode)
	{
	}

	[Token(Token = "0x6001211")]
	[Address(RVA = "0x40C650", Offset = "0x40B850", VA = "0x18040C650")]
	private void openStreamByLocation(Storage _storage, string _name, FileNameType _nameType, StreamOpenMode _openMode)
	{
	}

	[Token(Token = "0x6001212")]
	[Address(RVA = "0x40C740", Offset = "0x40B940", VA = "0x18040C740")]
	private void openStreamByNativePath(string _nativePath, StreamOpenMode _openMode)
	{
	}

	[Token(Token = "0x6001213")]
	[Address(RVA = "0x409FC0", Offset = "0x4091C0", VA = "0x180409FC0", Slot = "5")]
	protected virtual void Dispose(bool disposing)
	{
	}

	[Token(Token = "0x6001214")]
	[Address(RVA = "0x40A0C0", Offset = "0x4092C0", VA = "0x18040A0C0", Slot = "1")]
	~LocalFileStream()
	{
	}

	[Token(Token = "0x6001215")]
	[Address(RVA = "0x40C240", Offset = "0x40B440", VA = "0x18040C240")]
	public LocalFileStream(Storage storage, string name, FileNameType nameType, StreamOpenMode openMode)
	{
	}

	[Token(Token = "0x6001216")]
	[Address(RVA = "0x40C190", Offset = "0x40B390", VA = "0x18040C190")]
	public LocalFileStream(Storage storage, string name, StreamOpenMode openMode)
	{
	}

	[Token(Token = "0x6001217")]
	[Address(RVA = "0x40C1F0", Offset = "0x40B3F0", VA = "0x18040C1F0")]
	public LocalFileStream(FileLocation location, StreamOpenMode openMode)
	{
	}

	[Token(Token = "0x6001218")]
	[Address(RVA = "0x40C2A0", Offset = "0x40B4A0", VA = "0x18040C2A0")]
	public LocalFileStream(string nativePath, StreamOpenMode openMode)
	{
	}

	[Token(Token = "0x6001219")]
	[Address(RVA = "0x40A180", Offset = "0x409380", VA = "0x18040A180")]
	public FileLocation GetLocation()
	{
		return default(FileLocation);
	}

	[Token(Token = "0x600121D")]
	[Address(RVA = "0x40C160", Offset = "0x40B360", VA = "0x18040C160")]
	public void Write(byte[] data, int offset, int count)
	{
	}

	[Token(Token = "0x600121E")]
	[Address(RVA = "0x40BCE0", Offset = "0x40AEE0", VA = "0x18040BCE0")]
	public Task WriteAsync(byte[] data, int offset, int count)
	{
		return null;
	}

	[Token(Token = "0x600121F")]
	[Address(RVA = "0x40BBB0", Offset = "0x40ADB0", VA = "0x18040BBB0")]
	[AsyncStateMachine(typeof(_003CWriteAsyncCallback_003Ed__24))]
	public void WriteAsyncCallback(byte[] data, int offset, int count, Action finishCallback, Action<Exception> errorCallback)
	{
	}

	[Token(Token = "0x6001220")]
	[Address(RVA = "0x40BB70", Offset = "0x40AD70", VA = "0x18040BB70")]
	public void WriteAllBytes(byte[] writeData)
	{
	}

	[Token(Token = "0x6001221")]
	[Address(RVA = "0x40B9E0", Offset = "0x40ABE0", VA = "0x18040B9E0")]
	public Task WriteAllBytesAsync(byte[] writeData)
	{
		return null;
	}

	[Token(Token = "0x6001222")]
	[Address(RVA = "0x40BA20", Offset = "0x40AC20", VA = "0x18040BA20")]
	public void WriteAllBytesCallback(byte[] writeData, Action finishCallback, Action<Exception> errorCallback)
	{
	}

	[Token(Token = "0x6001223")]
	[Address(RVA = "0x40BD70", Offset = "0x40AF70", VA = "0x18040BD70")]
	public void WriteByte(byte data)
	{
	}

	[Token(Token = "0x6001224")]
	[Address(RVA = "0x40BF60", Offset = "0x40B160", VA = "0x18040BF60")]
	public void WriteShort(short val)
	{
	}

	[Token(Token = "0x6001225")]
	[Address(RVA = "0x40C100", Offset = "0x40B300", VA = "0x18040C100")]
	public void WriteUShort(ushort val)
	{
	}

	[Token(Token = "0x6001226")]
	[Address(RVA = "0x40BEA0", Offset = "0x40B0A0", VA = "0x18040BEA0")]
	public void WriteInt(int val)
	{
	}

	[Token(Token = "0x6001227")]
	[Address(RVA = "0x40C040", Offset = "0x40B240", VA = "0x18040C040")]
	public void WriteUInt(uint val)
	{
	}

	[Token(Token = "0x6001228")]
	[Address(RVA = "0x40BF00", Offset = "0x40B100", VA = "0x18040BF00")]
	public void WriteLong(long val)
	{
	}

	[Token(Token = "0x6001229")]
	[Address(RVA = "0x40C0A0", Offset = "0x40B2A0", VA = "0x18040C0A0")]
	public void WriteULong(ulong val)
	{
	}

	[Token(Token = "0x600122A")]
	[Address(RVA = "0x40BE50", Offset = "0x40B050", VA = "0x18040BE50")]
	public void WriteFloat(float val)
	{
	}

	[Token(Token = "0x600122B")]
	[Address(RVA = "0x40BE00", Offset = "0x40B000", VA = "0x18040BE00")]
	public void WriteDouble(double val)
	{
	}

	[Token(Token = "0x600122C")]
	[Address(RVA = "0x40BD10", Offset = "0x40AF10", VA = "0x18040BD10")]
	public void WriteBool(bool val)
	{
	}

	[Token(Token = "0x600122D")]
	[Address(RVA = "0x40BDA0", Offset = "0x40AFA0", VA = "0x18040BDA0")]
	public void WriteChar(char val)
	{
	}

	[Token(Token = "0x600122E")]
	[Address(RVA = "0x40BFC0", Offset = "0x40B1C0", VA = "0x18040BFC0")]
	public void WriteString(string str)
	{
	}

	[Token(Token = "0x600122F")]
	[Address(RVA = "0x40A000", Offset = "0x409200", VA = "0x18040A000")]
	public void Fill(byte data, int count)
	{
	}

	[Token(Token = "0x6001230")]
	[Address(RVA = "0x40ADD0", Offset = "0x409FD0", VA = "0x18040ADD0")]
	public int Read(byte[] buffer, int offset, int count)
	{
		return default(int);
	}

	[Token(Token = "0x6001231")]
	[Address(RVA = "0x40A4E0", Offset = "0x4096E0", VA = "0x18040A4E0")]
	public Task<int> ReadAsync(byte[] buffer, int offset, int count)
	{
		return null;
	}

	[Token(Token = "0x6001232")]
	[Address(RVA = "0x40A3B0", Offset = "0x4095B0", VA = "0x18040A3B0")]
	[AsyncStateMachine(typeof(_003CReadAsyncCallback_003Ed__43))]
	public void ReadAsyncCallback(byte[] buffer, int offset, int count, Action<int> finishCallback, Action<Exception> errorCallback)
	{
	}

	[Token(Token = "0x6001233")]
	[Address(RVA = "0x40A630", Offset = "0x409830", VA = "0x18040A630")]
	public byte[] ReadBytes(int count = 0)
	{
		return null;
	}

	[Token(Token = "0x6001234")]
	[Address(RVA = "0x40A360", Offset = "0x409560", VA = "0x18040A360")]
	public byte[] ReadAllBytes()
	{
		return null;
	}

	[Token(Token = "0x6001235")]
	[Address(RVA = "0x40A1D0", Offset = "0x4093D0", VA = "0x18040A1D0")]
	public Task<byte[]> ReadAllBytesAsync()
	{
		return null;
	}

	[Token(Token = "0x6001236")]
	[Address(RVA = "0x40A270", Offset = "0x409470", VA = "0x18040A270")]
	[AsyncStateMachine(typeof(_003CReadAllBytesCallback_003Ed__47))]
	public void ReadAllBytesCallback(Action<byte[]> finishCallback, Action<Exception> errorCallback)
	{
	}

	[Token(Token = "0x6001237")]
	[Address(RVA = "0x40AE00", Offset = "0x40A000", VA = "0x18040AE00")]
	public ReadRequest RequestReadAllBytes()
	{
		return null;
	}

	[Token(Token = "0x6001238")]
	private T readType<T>(Func<byte[], int, T> bitConverter, int sizeOfType) where T : struct
	{
		return (T)null;
	}

	[Token(Token = "0x6001239")]
	[Address(RVA = "0x40A5A0", Offset = "0x4097A0", VA = "0x18040A5A0")]
	public byte ReadByte()
	{
		return default(byte);
	}

	[Token(Token = "0x600123A")]
	[Address(RVA = "0x40AAF0", Offset = "0x409CF0", VA = "0x18040AAF0")]
	public short ReadShort()
	{
		return default(short);
	}

	[Token(Token = "0x600123B")]
	[Address(RVA = "0x40AD40", Offset = "0x409F40", VA = "0x18040AD40")]
	public ushort ReadUShort()
	{
		return default(ushort);
	}

	[Token(Token = "0x600123C")]
	[Address(RVA = "0x40A9D0", Offset = "0x409BD0", VA = "0x18040A9D0")]
	public int ReadInt()
	{
		return default(int);
	}

	[Token(Token = "0x600123D")]
	[Address(RVA = "0x40AC20", Offset = "0x409E20", VA = "0x18040AC20")]
	public uint ReadUInt()
	{
		return default(uint);
	}

	[Token(Token = "0x600123E")]
	[Address(RVA = "0x40AA60", Offset = "0x409C60", VA = "0x18040AA60")]
	public long ReadLong()
	{
		return default(long);
	}

	[Token(Token = "0x600123F")]
	[Address(RVA = "0x40ACB0", Offset = "0x409EB0", VA = "0x18040ACB0")]
	public ulong ReadULong()
	{
		return default(ulong);
	}

	[Token(Token = "0x6001240")]
	[Address(RVA = "0x40A940", Offset = "0x409B40", VA = "0x18040A940")]
	public float ReadFloat()
	{
		return default(float);
	}

	[Token(Token = "0x6001241")]
	[Address(RVA = "0x40A8B0", Offset = "0x409AB0", VA = "0x18040A8B0")]
	public double ReadDouble()
	{
		return default(double);
	}

	[Token(Token = "0x6001242")]
	[Address(RVA = "0x40A510", Offset = "0x409710", VA = "0x18040A510")]
	public bool ReadBool()
	{
		return default(bool);
	}

	[Token(Token = "0x6001243")]
	[Address(RVA = "0x40A820", Offset = "0x409A20", VA = "0x18040A820")]
	public char ReadChar()
	{
		return default(char);
	}

	[Token(Token = "0x6001244")]
	[Address(RVA = "0x40AB80", Offset = "0x409D80", VA = "0x18040AB80")]
	public string ReadString()
	{
		return null;
	}

	[Token(Token = "0x6001245")]
	private bool tryReadType<T>(Func<T> reader, out T result) where T : struct
	{
		return default(bool);
	}

	[Token(Token = "0x6001246")]
	[Address(RVA = "0x40B0C0", Offset = "0x40A2C0", VA = "0x18040B0C0")]
	public bool TryReadByte(out byte result)
	{
		return default(bool);
	}

	[Token(Token = "0x6001247")]
	[Address(RVA = "0x40B480", Offset = "0x40A680", VA = "0x18040B480")]
	public bool TryReadShort(out short result)
	{
		return default(bool);
	}

	[Token(Token = "0x6001248")]
	[Address(RVA = "0x40B750", Offset = "0x40A950", VA = "0x18040B750")]
	public bool TryReadUShort(out ushort result)
	{
		return default(bool);
	}

	[Token(Token = "0x6001249")]
	[Address(RVA = "0x40B340", Offset = "0x40A540", VA = "0x18040B340")]
	public bool TryReadInt(out int result)
	{
		return default(bool);
	}

	[Token(Token = "0x600124A")]
	[Address(RVA = "0x40B610", Offset = "0x40A810", VA = "0x18040B610")]
	public bool TryReadUInt(out uint result)
	{
		return default(bool);
	}

	[Token(Token = "0x600124B")]
	[Address(RVA = "0x40B3E0", Offset = "0x40A5E0", VA = "0x18040B3E0")]
	public bool TryReadLong(out long result)
	{
		return default(bool);
	}

	[Token(Token = "0x600124C")]
	[Address(RVA = "0x40B6B0", Offset = "0x40A8B0", VA = "0x18040B6B0")]
	public bool TryReadULong(out ulong result)
	{
		return default(bool);
	}

	[Token(Token = "0x600124D")]
	[Address(RVA = "0x40B2A0", Offset = "0x40A4A0", VA = "0x18040B2A0")]
	public bool TryReadFloat(out float result)
	{
		return default(bool);
	}

	[Token(Token = "0x600124E")]
	[Address(RVA = "0x40B200", Offset = "0x40A400", VA = "0x18040B200")]
	public bool TryReadDouble(out double result)
	{
		return default(bool);
	}

	[Token(Token = "0x600124F")]
	[Address(RVA = "0x40B020", Offset = "0x40A220", VA = "0x18040B020")]
	public bool TryReadBool(out bool result)
	{
		return default(bool);
	}

	[Token(Token = "0x6001250")]
	[Address(RVA = "0x40B160", Offset = "0x40A360", VA = "0x18040B160")]
	public bool TryReadChar(out char result)
	{
		return default(bool);
	}

	[Token(Token = "0x6001251")]
	[Address(RVA = "0x40B520", Offset = "0x40A720", VA = "0x18040B520")]
	public bool TryReadString(out string result)
	{
		return default(bool);
	}

	[Token(Token = "0x6001255")]
	[Address(RVA = "0x40AFB0", Offset = "0x40A1B0", VA = "0x18040AFB0")]
	public long Seek(long offset, SeekOrigin origin)
	{
		return default(long);
	}

	[Token(Token = "0x6001256")]
	[Address(RVA = "0x40A1A0", Offset = "0x4093A0", VA = "0x18040A1A0")]
	public void Head()
	{
	}

	[Token(Token = "0x6001257")]
	[Address(RVA = "0x40AFE0", Offset = "0x40A1E0", VA = "0x18040AFE0")]
	public void Tail()
	{
	}

	[Token(Token = "0x6001258")]
	[Address(RVA = "0x40A150", Offset = "0x409350", VA = "0x18040A150")]
	public void Flush()
	{
	}

	[Token(Token = "0x6001259")]
	[Address(RVA = "0x40A130", Offset = "0x409330", VA = "0x18040A130")]
	public Task FlushAsync()
	{
		return null;
	}

	[Token(Token = "0x600125A")]
	[Address(RVA = "0x409F50", Offset = "0x409150", VA = "0x180409F50", Slot = "4")]
	public void Dispose()
	{
	}
}
