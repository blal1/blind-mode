using System.Runtime.InteropServices;

namespace CrossSpeak;

internal static class LibSpeechdWrapperAPI
{
	internal readonly struct GoString
	{
		public string Msg { get; }

		public long Len { get; }

		public GoString(string msg, long len)
		{
			Msg = msg;
			Len = len;
		}
	}

	[DllImport("lib/screen-reader-libs/linux/libspeechdwrapper.so")]
	internal static extern int Initialize();

	[DllImport("lib/screen-reader-libs/linux/libspeechdwrapper.so")]
	internal static extern int Speak(GoString text, bool interrupt);

	[DllImport("lib/screen-reader-libs/linux/libspeechdwrapper.so")]
	internal static extern int Close();
}
