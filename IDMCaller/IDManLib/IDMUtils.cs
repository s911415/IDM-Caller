using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace IDManLib
{
    public enum IDMParamsFlag
    {
        None = 0,
        NoConfirm = 1,
        AddToQueueOnly = 2
    }

    [Serializable]
    public class IDMParams
    {
        public string Url { get; set; }
        public string Referer { get; set; }
        public string Cookies { get; set; }
        public string Data { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string LocalPath { get; set; }
        public string LocalFileName { get; set; }
        public int Flags { get; set; } = 0;
        public string UserAgent { get; set; }
    }

    public static class IDMUtils
    {
        public static void DownloadFile(IDMParams idmParams)
        {
            CIDMLinkTransmitter transmitter = (CIDMLinkTransmitter)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("AC746233-E9D3-49CD-862F-068F7B7CCCA4")));

            if (string.IsNullOrEmpty(idmParams.Referer)) idmParams.Referer = string.Empty;
            if (string.IsNullOrEmpty(idmParams.Cookies)) idmParams.Cookies = string.Empty;
            if (string.IsNullOrEmpty(idmParams.User)) idmParams.User = string.Empty;
            if (string.IsNullOrEmpty(idmParams.Password)) idmParams.Password = string.Empty;
            if (string.IsNullOrEmpty(idmParams.UserAgent)) idmParams.UserAgent = null;
            try
            {
                transmitter.SendLinkToIDM2(
                    idmParams.Url,
                    idmParams.Referer,
                    idmParams.Cookies,
                    idmParams.Data,
                    idmParams.User,
                    idmParams.Password,
                    idmParams.LocalPath,
                    idmParams.LocalFileName,
                    idmParams.Flags,
                    idmParams.UserAgent,
                    null
                );
            }
            catch (Exception e)
            {
            }


            //foreach (var ptr in ptrList)
            //{
            //    Marshal.Release(ptr);
            //}
        }
    }
}
