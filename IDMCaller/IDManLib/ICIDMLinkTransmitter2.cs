using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace IDManLib
{
    [ComImport, TypeIdentifier, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), CompilerGenerated, Guid("94D09862-1875-4FC9-B434-91CF25C840A1")]
    public interface ICIDMLinkTransmitter2 : ICIDMLinkTransmitter
    {
        void _VtblGap1_1();

        /// <summary>   Transfers one link (URL) to IDM, brings Start Download dialog, or just adds the file
        ///             to IDM download queue if a special flag is set. </summary>
        ///
        /// <param name="bstrUrl">              Url to download. </param>
        /// <param name="bstrReferer">          Referer. </param>
        /// <param name="bstrCookies">          cookies. </param>
        /// <param name="bstrData">             PostData (if using POST method) </param>
        /// <param name="bstrUser">             UserName (if server requires authentication). </param>
        /// <param name="bstrPassword">         Password. </param>
        /// <param name="bstrLocalPath">        LocalPath (where to save a file on your computer). </param>
        /// <param name="bstrLocalFileName">    LocalFileName (file name to save with). </param>
        /// <param name="lFlags">               Flags, can be zero or a combination of the following values:
        ///                                 	1 - do not show any confirmations dialogs;
        ///	                                 	2 - add to queue only, do not start downloading. </param>
        /// <param name="reserved1">            can be used to set a specific user-agent header with the following way:
        ///                                     reserved1.vt = VT_BSTR; reserved1.bstrVal = pbstrUA; if you don’t need to specify a
        ///                                     user agent, then reserved1.vt should be set to VT_EMPTY. </param>
        /// <param name="reserved2">            not used, you should set reserved2.vt to VT_EMPTY. </param>
        void SendLinkToIDM2(
            [In, MarshalAs(UnmanagedType.BStr)] string bstrUrl,
            [In, MarshalAs(UnmanagedType.BStr)] string bstrReferer,
            [In, MarshalAs(UnmanagedType.BStr)] string bstrCookies,
            [In, MarshalAs(UnmanagedType.BStr)] string bstrData, 
            [In, MarshalAs(UnmanagedType.BStr)] string bstrUser,
            [In, MarshalAs(UnmanagedType.BStr)] string bstrPassword,
            [In, MarshalAs(UnmanagedType.BStr)] string bstrLocalPath,
            [In, MarshalAs(UnmanagedType.BStr)] string bstrLocalFileName,
            [In] int lFlags, 
            [In, MarshalAs(UnmanagedType.Struct)] object reserved1,
            [In, MarshalAs(UnmanagedType.Struct)] object reserved2
        );
    }
}
