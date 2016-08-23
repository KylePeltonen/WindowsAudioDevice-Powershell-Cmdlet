using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreAudioApi;

namespace AudioDeviceCmdlets
{
    public static class EDataFlowExtensions
    {
        public static string ToFriendlyString(this EDataFlow me)
        {
            switch (me)
            {
                case EDataFlow.eCapture:
                    return "Recording";
                case EDataFlow.eRender:
                    return "Playback";
                case EDataFlow.eAll:
                    return "All";
                default:
                    return "Unknown";
            }
        }

        public static EDataFlow ToEDataFlow(string value)
        {
            switch (value)
            {
                case "Recording":
                    return EDataFlow.eCapture;
                case "Playback":
                    return EDataFlow.eRender;
                case "All":
                    return EDataFlow.eAll;
            }

            throw new System.ComponentModel.InvalidEnumArgumentException();
        }
    }
}
